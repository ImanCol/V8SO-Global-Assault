public class Flame2 : VigObject
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
        switch (arg1)
        {
            case 0:
                {
                    vTransform.position.x += physics1.Z;
                    vTransform.position.y += physics1.W;
                    vTransform.position.z += physics2.X;
                    int num = physics1.Z * 31;
                    if (num < 0)
                    {
                        num += 31;
                    }
                    physics1.Z = num >> 5;
                    num = physics2.X * 31;
                    if (num < 0)
                    {
                        num += 31;
                    }
                    physics2.X = num >> 5;
                    bool num2 = GameManager.instance.DAT_DA0 <= vTransform.position.z;
                    physics1.W -= 16;
                    if ((num2 || vTransform.position.y <= GameManager.instance.DAT_DB0) && vTransform.position.y <= GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z))
                    {
                        return 0u;
                    }
                    break;
                }
            default:
                return 0u;
            case 5:
                break;
        }
        FUN_4EE8C(GameManager.instance.interObjs);
        return uint.MaxValue;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 != 5)
        {
            return 0u;
        }
        FUN_4EE8C(GameManager.instance.interObjs);
        return uint.MaxValue;
    }
}
