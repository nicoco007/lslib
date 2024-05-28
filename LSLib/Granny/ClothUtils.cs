using LSLib.Granny.Model;
using OpenTK.Mathematics;
using Supercluster.KDTree;
using System.Diagnostics;
using System.IO.Compression;
using Triplet = (short A, short B, short C);

namespace LSLib.Granny
{
    public class ClothUtils
    {
        public static string Serialize(Triplet[] triplets)
        {
            var data = new byte[triplets.Length * 6];

            for (int i = 0; i < triplets.Length; i++)
            {
                SetBytes(triplets[i].A, data, i * 6);
                SetBytes(triplets[i].B, data, i * 6 + 2);
                SetBytes(triplets[i].C, data, i * 6 + 4);
            }

            using var target = new MemoryStream();

            using (var zlibStream = new ZLibStream(target, CompressionLevel.SmallestSize))
            using (var source = new MemoryStream(data))
            {
                source.CopyTo(zlibStream);
            }

            return Convert.ToBase64String(target.ToArray());
        }

        public static Triplet[] Deserialize(string str)
        {
            var compressedData = Convert.FromBase64String(str);
            using var target = new MemoryStream();

            using (var source = new MemoryStream(compressedData))
            using (var zlibStream = new ZLibStream(source, CompressionMode.Decompress))
            {
                zlibStream.CopyTo(target);
            }

            var data = target.ToArray();
            var triplets = new Triplet[data.Length / 6];

            for (var i = 0; i < triplets.Length; i++)
            {
                triplets[i] = new Triplet(
                    GetShort(data, i * 6),
                    GetShort(data, i * 6 + 2),
                    GetShort(data, i * 6 + 4));
            }

            return triplets;
        }

        public static Triplet[] Generate(Mesh physicsMesh, Mesh targetMesh)
        {
            Debug.WriteLine($"Generate Start");
            Stopwatch stopwatch = Stopwatch.StartNew();

            var physicsClothMesh = ClothMesh.Build(physicsMesh);
            Debug.WriteLine($"Build Physics Mesh {stopwatch.Elapsed}");

            var targetClothMesh = ClothMesh.Build(targetMesh);
            Debug.WriteLine($"Build Target Mesh {stopwatch.Elapsed}");

            var physicsClothVertices = GetPhysicsClothVertices(physicsClothMesh);
            Debug.WriteLine($"GetPhysicsClothVertices {stopwatch.Elapsed}");

            var targetClothVertices = GetTargetClothVertices(targetClothMesh);
            Debug.WriteLine($"GetTargetClothVertices {stopwatch.Elapsed}");

            var kdTree = BuildKdTree(physicsClothVertices);
            Debug.WriteLine($"BuildKdTree {stopwatch.Elapsed}");

            var triplets = new Triplet[targetClothVertices.Length];

            Parallel.For(0, targetClothVertices.Length, (index) =>
            {
                var vertex = targetClothVertices[index];
                Span<(short PhysicsIndex, float Distance)> triplet = stackalloc (short, float)[3];
                var tripletIndex = 0;

                // TODO: Searching the whole tree every time is slow. Maybe do RadialSearch? Hard to tell if there was a limit used by the game devs.
                foreach (var physicsVertex in kdTree.NearestNeighbors([vertex.Position.X, vertex.Position.Y, vertex.Position.Z], kdTree.Count).Select(t => t.Item2))
                {
                    if (vertex.Mask != 0 && (physicsVertex.Mask & vertex.Mask) == 0)
                    {
                        continue;
                    }

                    var distance = (vertex.Position - physicsVertex.Position).Length;

                    // TODO: this doesn't make a whole lot of sense but gets us very close to what the game does
                    if (tripletIndex == 1 && distance > triplet[0].Distance * 2.875)
                    {
                        break;
                    }
                    else if (tripletIndex == 2 && (distance > (triplet[0].Distance + triplet[1].Distance) || distance > triplet[0].Distance * 2.8))
                    {
                        break;
                    }

                    triplet[tripletIndex++] = (physicsVertex.PhysicsIndex, distance);

                    if (tripletIndex == 3)
                    {
                        break;
                    }
                }

                while (tripletIndex < 3)
                {
                    triplet[tripletIndex++] = (-1, -1);
                }

                triplets[index] = new Triplet(triplet[0].PhysicsIndex, triplet[1].PhysicsIndex, triplet[2].PhysicsIndex);
            });

            Debug.WriteLine($"Generate End {stopwatch.Elapsed}");

            return triplets;
        }

        private static KDTree<float, PhysicsVertex> BuildKdTree(PhysicsVertex[] vertices)
        {
            // TODO: This kinda sucks. It'd be nice if the KD tree could use the position property directly. Might be worth modifying the package?
            var points = new float[vertices.Length][];

            for (int i = 0; i < points.Length; i++)
            {
                var vertex = vertices[i];
                points[i] = [vertex.Position.X, vertex.Position.Y, vertex.Position.Z];
            }

            // don't use Math.Sqrt and Math.Pow for the metric since this'll be called thousands of times (square distance is fine here)
            return new KDTree<float, PhysicsVertex>(3, points, vertices, (a, b) => (b[0] - a[0]) * (b[0] - a[0]) + (b[1] - a[1]) * (b[1] - a[1]) + (b[2] - a[2]) * (b[2] - a[2]));
        }

        private static PhysicsVertex[] GetPhysicsClothVertices(ClothMesh mesh)
        {
            var markedVertices = GetMarkedVertices(mesh);
            var encountered = new HashSet<Vector3>();
            var physicsVertices = new List<PhysicsVertex>(markedVertices.Count);

            for (int i = 0; i < mesh.Indices.Count / 3; i++)
            {
                ClothVertex v1 = mesh.Vertices[mesh.Indices[i * 3]];
                ClothVertex v2 = mesh.Vertices[mesh.Indices[i * 3 + 1]];
                ClothVertex v3 = mesh.Vertices[mesh.Indices[i * 3 + 2]];

                // skip the triangle if it has a non-cloth vertex
                if (!markedVertices.Contains(v1) || !markedVertices.Contains(v2) || !markedVertices.Contains(v3))
                {
                    continue;
                }

                for (int j = 0; j < 3; j++)
                {
                    ClothVertex vertex = mesh.Vertices[mesh.Indices[i * 3 + j]];

                    // overlapping vertices should all map to the first encountered
                    if (encountered.Contains(vertex.Position))
                    {
                        continue;
                    }

                    physicsVertices.Add(new PhysicsVertex((short)physicsVertices.Count, vertex));
                    encountered.Add(vertex.Position);
                }
            }

            return [.. physicsVertices];
        }

        private static ClothVertex[] GetTargetClothVertices(ClothMesh mesh)
        {
            ClothVertex[] clothVertices = [.. GetMarkedVertices(mesh).OrderBy(v => v.Index)];
            var packedVertices = new ClothVertex[clothVertices.Length];

            var i = 0;

            for (; i < clothVertices.Length && clothVertices[i].Index < clothVertices.Length; i++)
            {
                var vertex = clothVertices[i];
                packedVertices[vertex.Index] = vertex;
            }

            var current = 0;

            for (; i < clothVertices.Length; i++)
            {
                while (packedVertices[current] != null)
                {
                    current++;
                }

                packedVertices[current++] = clothVertices[i];
            }

            return packedVertices;
        }

        private static HashSet<ClothVertex> GetMarkedVertices(ClothMesh mesh)
        {
            var clothVertices = new HashSet<ClothVertex>(mesh.Vertices.Where(v => v.Weight > 0));

            AddOverlappingVertices(clothVertices);
            AddConnectedVertices(clothVertices);
            AddOverlappingVertices(clothVertices);
            AddConnectedVertices(clothVertices);
            AddOverlappingVertices(clothVertices);

            return clothVertices;
        }

        private static void AddOverlappingVertices(HashSet<ClothVertex> clothVertices)
        {
            foreach (var vertex in clothVertices.SelectMany(v => v.Overlapping).ToList())
            {
                clothVertices.Add(vertex);
            }
        }

        private static void AddConnectedVertices(HashSet<ClothVertex> clothVertices)
        {
            foreach (var vertex in clothVertices.SelectMany(v => v.Neighbors).ToList())
            {
                clothVertices.Add(vertex);
            }
        }

        private static unsafe short GetShort(byte[] array, int offset)
        {
            fixed (byte* ptr = &array[offset])
            {
                return *(short*)ptr;
            }
        }

        private static unsafe void SetBytes(short value, byte[] array, int offset)
        {
            fixed (byte* ptr = &array[offset])
            {
                *(short*)ptr = value;
            }
        }

        private record ClothMesh(IReadOnlyList<ClothVertex> vertices, IReadOnlyList<int> indices)
        {
            public IReadOnlyList<ClothVertex> Vertices { get; } = vertices;

            public IReadOnlyList<int> Indices { get; } = indices;

            internal static ClothMesh Build(Mesh mesh)
            {
                var vertices = new ClothVertex[mesh.PrimaryVertexData.Vertices.Count];
                var verticesByPosition = new Dictionary<Vector3, HashSet<ClothVertex>>();

                for (int i = 0; i < vertices.Length; i++)
                {
                    var vertex = new ClothVertex(i, mesh.PrimaryVertexData.Vertices[i]);
                    vertices[i] = vertex;

                    if (!verticesByPosition.TryGetValue(vertex.Position, out var overlapping))
                    {
                        overlapping = [];
                        verticesByPosition.Add(vertex.Position, overlapping);
                    }

                    overlapping.Add(vertex);
                }

                foreach (var vertex in vertices)
                {
                    foreach (var other in verticesByPosition[vertex.Position].Where(v => v != vertex))
                    {
                        vertex.Overlapping.Add(other);
                    }
                }

                var indices = mesh.PrimaryTopology.Indices;

                for (var i = 0; i < indices.Count / 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        var vertex = vertices[indices[i * 3 + j]];
                        vertex.Neighbors.Add(vertices[indices[i * 3 + ((j + 1) % 3)]]);
                        vertex.Neighbors.Add(vertices[indices[i * 3 + ((j + 2) % 3)]]);
                    }
                }

                return new ClothMesh(vertices, indices);
            }
        }

        private record ClothVertex
        {
            internal int Index { get; }

            internal Vector3 Position { get; }

            internal byte Weight { get; }

            internal byte Mask { get; }

            internal IList<ClothVertex> Neighbors { get; }

            internal IList<ClothVertex> Overlapping { get; }

            // byte conversion must be the same as VertexSerialization.WriteNormalByteVector4 or things will break!
            internal ClothVertex(int index, Vertex vertex)
                : this(index, vertex.Position, (byte)(vertex.Color0.X * 255), (byte)(vertex.Color0.Z * 255))
            {
            }

            internal ClothVertex(int index, Vector3 position, byte weight, byte mask)
            {
                Index = index;
                Position = position;
                Weight = weight;
                Mask = mask;
                Neighbors = new List<ClothVertex>();
                Overlapping = new List<ClothVertex>();
            }
        }

        private record PhysicsVertex
        {
            internal short PhysicsIndex { get; }

            internal Vector3 Position { get; }

            internal byte Mask { get; }

            internal PhysicsVertex(short physicsIndex, ClothVertex clothVertex)
                : this(physicsIndex, clothVertex.Position, clothVertex.Mask)
            {
            }

            internal PhysicsVertex(short physicsIndex, Vector3 position, byte mask)
            {
                PhysicsIndex = physicsIndex;
                Position = position;
                Mask = mask;
            }
        }
    }
}
