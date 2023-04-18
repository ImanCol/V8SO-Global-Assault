using UnityEngine;

public class Mortar : VigObject
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
        uint num2;
        uint num;
        switch (arg1)
        {
            case 0:
                FUN_42330(arg2);
                num = 0u;
                break;
            default:
                num = 0u;
                break;
            case 10:
                {
                    arg2 &= 0xFFF;
                    ushort param;
                    if (arg2 == 546)
                    {
                        if (maxHalfHealth < 2)
                        {
                            return uint.MaxValue;
                        }
                        Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
                        param = 37;
                        if (vehicle.doubleDamage != 0)
                        {
                            param = 74;
                        }
                        Shell shell = FUN_46480(vehicle, 203, 15, param);
                        shell.tags = 1;
                        num = (shell.flags |= 1073741824u);
                        param = (ushort)(maxHalfHealth - 2);
                    }
                    else
                    {
                        Vehicle vehicle;
                        if (arg2 == 548)
                        {
                            if (maxHalfHealth < 2)
                            {
                                return uint.MaxValue;
                            }
                            vehicle = (Utilities.FUN_2CD78(this) as Vehicle);
                            num = 5u;
                            if (maxHalfHealth < 5)
                            {
                                num = maxHalfHealth;
                            }
                            if (vehicle.doubleDamage != 0)
                            {
                                num *= 2;
                            }
                            Shell shell2 = FUN_46480(vehicle, 204, 19, (ushort)(num * 75));
                            shell2.tags = 2;
                            shell2.flags |= 1073741856u;
                            num = (uint)(maxHalfHealth - 5);
                            num2 = 0u;
                            if (0 < (int)num)
                            {
                                num2 = num;
                            }
                            maxHalfHealth = (ushort)num2;
                            num2 &= 0xFFFF;
                            goto IL_018c;
                        }
                        if (arg2 != 547)
                        {
                            return 0u;
                        }
                        if (maxHalfHealth < 3)
                        {
                            return uint.MaxValue;
                        }
                        vehicle = (Utilities.FUN_2CD78(this) as Vehicle);
                        param = 75;
                        if (vehicle.doubleDamage != 0)
                        {
                            param = 150;
                        }
                        Shell shell3 = FUN_46480(vehicle, 217, 24, param);
                        shell3.tags = 3;
                        num = (shell3.flags |= 1073741856u);
                        param = (ushort)(maxHalfHealth - 3);
                    }
                    maxHalfHealth = param;
                    num2 = param;
                    goto IL_018c;
                }
            IL_018c:
                num = 120u;
                if (num2 == 0)
                {
                    FUN_3A368();
                    num = 120u;
                }
                break;
        }
        return num;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        uint result;
        switch (arg1)
        {
            case 0:
                FUN_42330(arg2);
                result = 0u;
                break;
            case 1:
                maxHalfHealth = 10;
                flags |= 16384u;
                goto default;
            default:
                result = 0u;
                break;
            case 12:
                {
                    FUN_46480(param4: (ushort)((((Vehicle)arg2).doubleDamage != 0) ? 150 : 75), param1: (Vehicle)arg2, param2: 183, param3: 6);
                    uint num2 = --maxHalfHealth;
                    result = 120u;
                    if (num2 == 0)
                    {
                        FUN_3A368();
                        result = 120u;
                    }
                    break;
                }
            case 13:
                {
                    Vehicle vehicle = (Vehicle)arg2;
                    int num = Utilities.FUN_29F6C(arg2.screen, vehicle.target.screen);
                    bool flag = false;
                    for (int i = 0; i < 3; i++)
                    {
                        if (vehicle.weapons[i] != null && vehicle.weapons[i].tags != 5 && vehicle.weapons[i].tags != 4 && vehicle.weapons[i].tags != 7)
                        {
                            flag = true;
                        }
                    }
                    result = (uint)(((2047998u < (uint)(num - 2048001)) ? (flag ? 1 : 0) : 0) ^ 1);
                    break;
                }
            case 14:
                if (((GameManager.instance.DAT_28 - (arg2.DAT_19 ^ 0x14)) & Mathf.Clamp(511 - (GameManager.instance.EnemyKill - 70) * 2, 0, 511)) == 0 && UpdateW(13, arg2) != 0)
                {
                    if (((Vehicle)arg2).target.physics1.W > 8000)
                    {
                        return 547u;
                    }
                    if (((Vehicle)arg2).target.physics1.W < 2000)
                    {
                        return 548u;
                    }
                    return 546u;
                }
                result = 0u;
                break;
        }
        return result;
    }

    private Shell FUN_46480(Vehicle param1, ushort param2, short param3, ushort param4)
    {
        VigObject child = child2;
        Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(8, typeof(Ballistic), 8u) as Ballistic;
        Shell shell = LevelManager.instance.FUN_42408(param1, child, param2, typeof(Shell), ballistic) as Shell;
        shell.DAT_1A = param3;
        shell.flags = 536872080u;
        shell.maxHalfHealth = param4;
        shell.FUN_305FC();
        shell.physics2.M2 = 0;
        VigObject vigObject = param1.target;
        if (param1.target == null)
        {
            vigObject = param1;
        }
        shell.DAT_84 = vigObject;
        int num = Utilities.FUN_29F6C(shell.vTransform.position, vigObject.vTransform.position);
        num >>= 9;
        int num2 = 4096;
        if (4095 < num)
        {
            num2 = 8192;
            if (num < 8193)
            {
                num2 = num;
            }
        }
        num = param1.physics1.X;
        if (num < 0)
        {
            num += 127;
        }
        int num3 = shell.vTransform.rotation.V01 * num2;
        if (num3 < 0)
        {
            num3 += 4095;
        }
        shell.physics1.Z = (num >> 7) - (num3 >> 12);
        num = param1.physics1.Y;
        if (num < 0)
        {
            num += 127;
        }
        num3 = shell.vTransform.rotation.V11 * num2;
        if (num3 < 0)
        {
            num3 += 4095;
        }
        shell.physics1.W = (num >> 7) - (num3 >> 12);
        num = param1.physics1.Z;
        if (num < 0)
        {
            num += 127;
        }
        num2 = shell.vTransform.rotation.V21 * num2;
        if (num2 < 0)
        {
            num2 += 4095;
        }
        shell.physics2.X = (num >> 7) - (num2 >> 12);
        shell.vTransform = GameManager.FUN_2A39C();
        ballistic.flags |= 1040u;
        ballistic.FUN_30BF0();
        Vector3Int v = Utilities.FUN_24094(child.vTransform.rotation, GameManager.DAT_A4C);
        param1.FUN_2B1FC(v, screen);
        sbyte param5 = shell.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
        shell.UpdateW(1, 0);
        GameManager.instance.FUN_1E580(param5, GameManager.instance.DAT_C2C, 57, shell.screen);
        return shell;
    }
}