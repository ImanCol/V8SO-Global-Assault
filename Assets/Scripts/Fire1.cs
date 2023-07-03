public class Fire1 : VigObject
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
        uint result;
        switch (arg1)
        {
            case 0:
                {
                    short num = (short)(physics1.M0 - 1);
                    physics1.M0 = num;
                    result = 0u;
                    if (num == -1)
                    {
                        Fire2 fire = DAT_98.ini.FUN_2C17C((ushort)physics2.M3, typeof(Fire2), 8u) as Fire2;
                        int num2 = (int)((GameManager.FUN_2AC5C() & 0xFFF) * 2);
                        fire.flags |= 1076u;
                        int num3 = physics1.Y * Utilities.DAT_65C90[num2];
                        if (num3 < 0)
                        {
                            num3 += 4095;
                        }
                        fire.physics1.Z = num3 >> 12;
                        num2 = physics1.Y * Utilities.DAT_65C90[num2 + 1];
                        if (num2 < 0)
                        {
                            num2 += 4095;
                        }
                        fire.physics2.X = num2 >> 12;
                        num2 = (int)GameManager.FUN_2AC5C();
                        fire.physics1.W = physics1.Z + (num2 * physics1.Z >> 15);
                        fire.screen = GameManager.instance.FUN_2CE50(this);
                        fire.FUN_4EE40();
                        fire.FUN_30B78();
                        physics1.M0 = physics1.M1;
                        (Utilities.FUN_2CDB0(this) as Vehicle).FUN_39DCC(-maxHalfHealth, vTransform.position, param3: true);
                        if (DAT_18 != 0)
                        {
                            result = GameManager.instance.FUN_1E478(fire.vTransform.position);
                            GameManager.instance.FUN_1E2C8(DAT_18, result);
                            result = 0u;
                        }
                    }
                    break;
                }
            case 2:
                {
                    (Utilities.FUN_2CDB0(this) as Vehicle).DAT_F6 &= 65527;
                    GameManager.instance.FUN_1DE78(DAT_18);
                    VigObject param = FUN_2CCBC();
                    GameManager.instance.FUN_307CC(param);
                    result = uint.MaxValue;
                    break;
                }
            default:
                result = 0u;
                break;
        }
        return result;
    }
}
