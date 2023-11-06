using UnityEngine;

public class SLerpFullBehaviour : FunctionBehavior
{
    public Vector3 start;
    public Vector3 end;

    public static Vector3 FakeSlerpUnclampedInPlace(Vector3 from, Vector3 to, float amount)
    {
        float angleTo = Vector3.Angle(from, to);
        Vector3 cross = Vector3.Cross(from, to);
        cross.Normalize();
        Quaternion q1 = Quaternion.AngleAxis(angleTo * amount, cross);
        return q1 * from;
    }
    public override Vector3 VirtualFuction(float value)
    {
        var a = FakeSLerpBehaviour.FakeSlerpUnclampedInPlace(start, end, value);
        var b = FakeSLerpBehaviour.FakeSlerpUnclampedInPlace(end, start, 1 - value);
        return Vector3.Lerp(a,b,value);
    }
}
