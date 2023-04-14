using UnityEngine;

public class Particle7 : VigObject
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
            LevelManager.instance.FUN_4D16C(vData, (ushort)DAT_1A, vTransform);
            UnityEngine.Object.Destroy(base.gameObject);
        }
        return 0u;
    }
}
