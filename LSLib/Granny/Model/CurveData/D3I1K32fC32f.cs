﻿using OpenTK.Mathematics;
using LSLib.Granny.GR2;

namespace LSLib.Granny.Model.CurveData;

public class D3I1K32fC32f : AnimationCurveData
{
    [Serialization(Type = MemberType.Inline)]
    public CurveDataHeader CurveDataHeader_D3I1K32fC32f;
    public UInt16 Padding;
    [Serialization(ArraySize = 3)]
    public float[] ControlScales;
    [Serialization(ArraySize = 3)]
    public float[] ControlOffsets;
    [Serialization(Prototype = typeof(ControlReal32), Kind = SerializationKind.UserMember, Serializer = typeof(SingleListSerializer))]
    public List<Single> KnotsControls;

    public override int NumKnots()
    {
        return KnotsControls.Count / 2;
    }

    public override List<float> GetKnots()
    {
        var numKnots = NumKnots();
        var knots = new List<float>(numKnots);
        for (var i = 0; i < numKnots; i++)
            knots.Add(KnotsControls[i]);

        return knots;
    }

    public override void Translate(Vector3 vector)
    {
        ControlOffsets[0] += vector.X;
        ControlOffsets[1] += vector.Y;
        ControlOffsets[2] += vector.Z;
    }

    public override void Scale(Vector3 vector)
    {
        ControlOffsets[0] *= vector.X;
        ControlOffsets[1] *= vector.Y;
        ControlOffsets[2] *= vector.Z;

        ControlScales[0] *= vector.X;
        ControlScales[1] *= vector.Y;
        ControlScales[2] *= vector.Z;
    }

    public override void ScaleKnots(float factor)
    {
        for (int i = 0; i < KnotsControls.Count; i++)
        {
            KnotsControls[i] = factor * KnotsControls[i];
        }
    }

    public override List<Vector3> GetPoints()
    {
        var numKnots = NumKnots();
        var knots = new List<Vector3>(numKnots);
        for (var i = 0; i < numKnots; i++)
        {
            var vec = new Vector3(
                KnotsControls[numKnots + i] * ControlScales[0] + ControlOffsets[0],
                KnotsControls[numKnots + i] * ControlScales[1] + ControlOffsets[1],
                KnotsControls[numKnots + i] * ControlScales[2] + ControlOffsets[2]
            );
            knots.Add(vec);
        }

        return knots;
    }
}
