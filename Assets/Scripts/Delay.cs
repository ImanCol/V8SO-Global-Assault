using UnityEngine;

public class Delay : VigObject
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 2)
        {
            PDAT_74.FUN_4D8A8(vData, (ushort)DAT_1A, child2);
            UnityEngine.Object.Destroy(base.gameObject);
        }
        return 0u;
    }
}
