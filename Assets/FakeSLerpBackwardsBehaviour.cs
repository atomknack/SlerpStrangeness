using UnityEngine;

public class FakeSLerpBackwardsBehaviour : FunctionBehavior
{
    public Vector3 start;
    public Vector3 end;
    public override Vector3 VirtualFuction(float value)
    {
        return FakeSLerpBehaviour.FakeSlerpUnclampedInPlace(end, start, 1-value);
    }
}
