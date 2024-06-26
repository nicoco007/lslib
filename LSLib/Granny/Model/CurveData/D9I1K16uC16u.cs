﻿using OpenTK.Mathematics;
using LSLib.Granny.GR2;

namespace LSLib.Granny.Model.CurveData;

public class D9I1K16uC16u : AnimationCurveData
{
    [Serialization(Type = MemberType.Inline)]
    public CurveDataHeader CurveDataHeader_D9I1K16uC16u;
    public UInt16 OneOverKnotScaleTrunc;
    public float ControlScale;
    public float ControlOffset;
    [Serialization(Prototype = typeof(ControlUInt16), Kind = SerializationKind.UserMember, Serializer = typeof(UInt16ListSerializer))]
    public List<UInt16> KnotsControls;

    public override int NumKnots()
    {
        return KnotsControls.Count / 2;
    }

    public override List<float> GetKnots()
    {
        var scale = ConvertOneOverKnotScaleTrunc(OneOverKnotScaleTrunc);
        var numKnots = NumKnots();
        var knots = new List<float>(numKnots);
        for (var i = 0; i < numKnots; i++)
            knots.Add((float)KnotsControls[i] / scale);

        return knots;
    }

    public override void Translate(Vector3 vector)
    {
        throw new InvalidOperationException();
    }

    public override void Scale(Vector3 vector)
    {
        throw new InvalidOperationException();
    }

    public override void ScaleKnots(float factor)
    {
        float scale = ConvertOneOverKnotScaleTrunc(OneOverKnotScaleTrunc);
        OneOverKnotScaleTrunc = ConvertOneOverKnotScale(scale / factor);
    }

    public override List<Quaternion> GetQuaternions()
    {
        throw new InvalidOperationException("D9I1K16uC16u is not a rotation curve!");
    }

    public override List<Matrix3> GetMatrices()
    {
        var numKnots = NumKnots();
        var knots = new List<Matrix3>(numKnots);
        for (var i = 0; i < numKnots; i++)
        {
            var scale = (float)KnotsControls[numKnots + i] * ControlScale + ControlOffset;
            var mat = new Matrix3(
                scale, 0, 0,
                0, scale, 0,
                0, 0, scale
            );
            knots.Add(mat);
        }

        return knots;
    }
}
