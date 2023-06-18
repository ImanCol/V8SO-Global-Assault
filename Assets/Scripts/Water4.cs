using Unity.Burst;

[BurstCompile]
public class Water4 : VigObject
{
    public XOBF_DB DAT_98;

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
            case 2:
                physics1.M0 = -1;
                return 0u;
            case 0:
                {
                    short num = (short)(physics1.M0 - 1);
                    physics1.M0 = num;
                    if (num == -1)
                    {
                        Ballistic ballistic = DAT_98.ini.FUN_2C17C((ushort)physics2.M3, typeof(Ballistic), 8u) as Ballistic;
                        ballistic.vTransform = GameManager.FUN_2A39C();
                        int num2 = (int)GameManager.FUN_2AC5C();
                        int dAT_ = DAT_58;
                        ballistic.vTransform.position.y = 0;
                        ballistic.vTransform.position.x = (num2 * 2 * dAT_ >> 15) - dAT_;
                        num2 = (int)GameManager.FUN_2AC5C();
                        dAT_ = DAT_58;
                        ballistic.vTransform.position.z = (num2 * 2 * dAT_ >> 15) - dAT_;
                        Utilities.FUN_2CC48(this, ballistic);
                        Utilities.ParentChildren(this, this);
                        physics1.M0 = physics1.M1;
                    }
                    if (child2 == null)
                    {
                        GameManager.instance.FUN_309A0(this);
                        return uint.MaxValue;
                    }
                    break;
                }
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 == 5)
        {
            vAnim = null;
            flags |= 2u;
            return uint.MaxValue;
        }
        return 0u;
    }
}
