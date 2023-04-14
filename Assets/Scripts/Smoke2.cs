using UnityEngine;

public class Smoke2 : VigObject
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        base.transform.eulerAngles = new Vector3(0f, 0f, base.transform.eulerAngles.z);
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 == 5)
        {
            FUN_2CCBC();
            GameManager.instance.FUN_2C4B4(this);
            return uint.MaxValue;
        }
        return 0u;
    }
}
