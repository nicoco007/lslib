using LSLib.Granny;
using LSLib.Granny.Model;
using OpenTK.Mathematics;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ClothTest
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string input = @"D:\Users\Nicolas\Desktop\DGB_M_ARM_Barbarian_A_Body.GR2";
            string output = @"E:\Steam Library\steamapps\common\Baldurs Gate 3\Data\Generated\Public\SharedDev\Assets\Characters\_Models\Dragonborn\_Male\Resources\DGB_M_ARM_Barbarian_A_Body.GR2";

            var exporter = new Exporter()
            {
                Options = new ExporterOptions()
                {
                    InputFormat = ExportFormat.GR2,
                    OutputFormat = ExportFormat.GR2,
                    ApplyBasisTransforms = true,
                    BuildDummySkeleton = true,
                    FlipMesh = false,
                    DeduplicateUVs = false,
                    DeduplicateVertices = false,
                },
            };

            exporter.Options.LoadGameSettings(LSLib.LS.Enums.Game.BaldursGate3);

            var model = GR2Utils.LoadModel(input, exporter.Options);

            int v1 = 2544; // top left
            int v2 = 2760; // bottom
            int v3 = 6124; // top right
            Mesh mesh = model.Meshes.First(m => m.Name == "DGB_M_ARM_Barbarian_A_Skirt_Mesh");
            Move(ref mesh.PrimaryVertexData.Vertices[v1].Position, new Vector3(new Vector3(0, 0.00000009f, 0)));
            Move(ref mesh.PrimaryVertexData.Vertices[v3].Position, new Vector3(new Vector3(0, 0.000000185f, 0)));
            Console.WriteLine(mesh.PrimaryVertexData.Vertices[v3].Position - mesh.PrimaryVertexData.Vertices[v1].Position);

            GR2Utils.SaveModel(model, output, exporter);
        }

        private static void Move(ref Vector3 vector, Vector3 offset)
        {
            Console.WriteLine($"Actual difference: {(vector + offset) - vector}");
            vector += offset;
        }

        // tested with:
        // [798b4ec8-03a5-8f19-b803-4be6bbde44dd] HUM_M_ARM_Myrkul_B_Body
        // [34a5f40b-d199-86cb-4f53-528510924063] HUM_M_CLT_Daisy_Dress_A
        // [c0117660-260a-e7b6-85f5-57b410a5cbda] HUM_MS_ARM_Barbarian_A_Body
        // [4dd200dd-d7dc-729f-0673-83f8a62441aa] HUM_MS_ARM_Chainshirt_Shadowheart_A_Body (all LODs)
        // [e14e6f65-cdb5-22b3-4dbe-c0badee7d045] DGB_M_ARM_Barbarian_A_Body
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"D:\Users\Nicolas\Desktop\Baldur's Gate 3\Modder's Multitool\UnpackedData\Shared", "_merged.lsx", SearchOption.AllDirectories);
            int total = 0;

            for (int i = 0; i < files.Length; i++)
            {
                Console.Write($"{i} / {files.Length} ({(double)i / files.Length * 100:0.00}%) - {total}");
                Console.CursorLeft = 0;

                XDocument doc = XDocument.Load(files[i]);

                foreach (XElement element in doc.XPathSelectElements("/save/region[@id='VisualBank']/node[@id='VisualBank']/children/node[@id='Resource']"))
                {
                    var ClothProxyMapping = element.XPathSelectElement("children/node[@id='ClothProxyMapping']");

                    if (ClothProxyMapping == null)
                    {
                        continue;
                    }

                    string visualName = element.XPathSelectElement("attribute[@id='Name']").Attribute("value").Value;
                    string sourceFile = Path.Join(@"D:\Users\Nicolas\Desktop\Baldur's Gate 3\Modder's Multitool\UnpackedData\Models", element.XPathSelectElement("attribute[@id='SourceFile']")?.Attribute("value").Value);

                    if (!File.Exists(sourceFile))
                    {
                        continue;
                    }

                    try
                    {
                        Root root = GR2Utils.LoadModel(sourceFile);

                        foreach (var thing in ClothProxyMapping.XPathSelectElements("children/node[@id='Object']"))
                        {
                            string[] mapKey = thing.XPathSelectElement("attribute[@id='MapKey']").Attribute("value").Value.Split('.');
                            Mesh physicsMesh = root.Meshes.FirstOrDefault(m => m.ExportOrder == int.Parse(mapKey[2]));

                            if (physicsMesh == null)
                            {
                                continue;
                            }

                            foreach (var target in thing.XPathSelectElements("children/node[@id='MapValue']/children/node[@id='Object']"))
                            {
                                if (!target.HasElements)
                                {
                                    continue;
                                }
                                var nbClosestVertices = int.Parse(target.XPathSelectElement("attribute[@id='NbClosestVertices']").Attribute("value").Value, CultureInfo.InvariantCulture);
                                string[] name = target.XPathSelectElement("attribute[@id='Name']").Attribute("value").Value.Split('.');
                                var expected = ClothUtils.Deserialize(target.XPathSelectElement("attribute[@id='ClosestVertices']").Attribute("value").Value);
                                Mesh targetMesh = root.Meshes.FirstOrDefault(m => m.ExportOrder == int.Parse(name[2]));

                                if (targetMesh == null)
                                {
                                    continue;
                                }

                                var generated = ClothUtils.Generate(physicsMesh, targetMesh);

                                if (generated.Length == 0)
                                {
                                    continue;
                                }

                                if (nbClosestVertices != generated.Length * 3)
                                {
                                    Console.WriteLine($"!!! {visualName} {physicsMesh.Name} {targetMesh.Name} | expected={nbClosestVertices} generated={generated.Length * 3}");
                                }

                                total++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }

            Console.Write($"{files.Length} / {files.Length} (100.00%)");
        }

        static void Main2(string[] args)
        {
            var expected = ClothUtils.Deserialize("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");
            File.WriteAllText("expected.txt", string.Join("\n", expected));

            Root root = GR2Utils.LoadModel(@"D:\Users\Nicolas\Desktop\Baldur's Gate 3\Modder's Multitool\UnpackedData\Models\Generated\Public\Shared\Assets\Characters\_Models\Dwarves\_Female\Resources\DWR_F_ARM_Githyanki_HalfPlate_B_Body.GR2");
            Mesh physicsMesh = root.Meshes.First(m => m.Name == "DWR_F_ARM_Githyanki_HalfPlate_B_Body_Cloth_Mesh");
            Mesh targetMesh = root.Meshes.First(m => m.Name == "DWR_F_ARM_Githyanki_HalfPlate_B_Body_Mesh");

            var generated = ClothUtils.Generate(physicsMesh, targetMesh);
            Console.WriteLine($"NbClosestVertices: {generated.Length * 3}");
            File.WriteAllText("generated.txt", string.Join("\n", generated));

            if (expected.Length == generated.Length)
            {
                int wrong = 0;
                int wronglySet = 0;
                int wronglyNotSet = 0;

                for (int i = 0; i < generated.Length; i++)
                {
                    if (expected[i] != generated[i])
                    {
                        Console.WriteLine($"{i}: {expected[i]} != {generated[i]}");
                        CheckValues(expected[i].A, generated[i].A, ref wrong, ref wronglySet, ref wronglyNotSet);
                        CheckValues(expected[i].B, generated[i].B, ref wrong, ref wronglySet, ref wronglyNotSet);
                        CheckValues(expected[i].C, generated[i].C, ref wrong, ref wronglySet, ref wronglyNotSet);
                    }
                }

                int total = generated.Length * 3;
                Console.WriteLine($"Wrong: {wrong} ({(float)wrong / total * 100:0.00}%)");
                Console.WriteLine($"Wrongly set: {wronglySet} ({(float)wronglySet / total * 100:0.00}%)");
                Console.WriteLine($"Wrongly not set: {wronglyNotSet} ({(float)wronglyNotSet / total * 100:0.00}%)");
            }
            else
            {
                Console.WriteLine("Expected and generated lengths do not match");
            }
        }

        private static void CheckValues(short original, short generated, ref int wrong, ref int wronglySet, ref int wronglyNotSet)
        {
            if (original == generated)
            {
                return;
            }

            if (original == -1)
            {
                wronglySet++;
            }
            else if (generated == -1)
            {
                wronglyNotSet++;
            }
            else
            {
                wrong++;
            }
        }
    }
}
