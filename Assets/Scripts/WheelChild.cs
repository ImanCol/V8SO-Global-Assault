using UnityEngine;

public class WheelChild : VigObject
{
    public Vector3 eulerAngles;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        base.transform.localEulerAngles += eulerAngles;
    }
}
