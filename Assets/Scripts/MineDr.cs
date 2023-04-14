using System;
using UnityEngine;

public class MineDr : VigObject
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
        uint result;
        switch (arg1)
        {
            case 0:
                FUN_42330(arg2);
                result = 0u;
                break;
            default:
                result = 0u;
                break;
            case 10:
                {
                    arg2 &= 0xFFF;
                    short num3;
                    switch (arg2)
                    {
                        case 306:
                            {
                                if (maxHalfHealth < 3)
                                {
                                    return uint.MaxValue;
                                }
                                Vehicle param = Utilities.FUN_2CD78(this) as Vehicle;
                                //VigObject vigObject = FUN_479DC(param, 195, typeof(Bearhug));
                                VigObject vigObject = FUN_479DC(param, 195, typeof(Brearhug));
                                int num = vigObject.DAT_58 = Utilities.FUN_29E84(new Vector3Int(vigObject.vCollider.reader.ReadInt32(16), vigObject.vCollider.reader.ReadInt32(20), vigObject.vCollider.reader.ReadInt32(24)));
                                vigObject.type = 3;
                                vigObject.flags |= 1073741824u;
                                num3 = (short)(maxHalfHealth - 3);
                                break;
                            }
                        default:
                            return 0u;
                        case 307:
                            {
                                if (maxHalfHealth < 2)
                                {
                                    return uint.MaxValue;
                                }
                                Vehicle param = Utilities.FUN_2CD78(this) as Vehicle;
                                VigObject vigObject = FUN_479DC(param, 214, typeof(Hovermine));
                                vigObject.child2.transform.parent = vigObject.transform;
                                int num = vigObject.DAT_58 = Utilities.FUN_29E84(new Vector3Int(vigObject.vCollider.reader.ReadInt32(16), vigObject.vCollider.reader.ReadInt32(20), vigObject.vCollider.reader.ReadInt32(24)));
                                vigObject.flags |= 1073741824u;
                                GameManager.instance.FUN_30CB0(vigObject, 120);
                                num3 = (short)(maxHalfHealth - 2);
                                break;
                            }
                        case 308:
                            {
                                if (maxHalfHealth < 2)
                                {
                                    return uint.MaxValue;
                                }
                                Vehicle param = Utilities.FUN_2CD78(this) as Vehicle;
                                VigObject vigObject = FUN_479DC(param, 191, typeof(CactusPatch));
                                int num = vigObject.DAT_58 = Utilities.FUN_29E84(new Vector3Int(vigObject.vCollider.reader.ReadInt32(16), vigObject.vCollider.reader.ReadInt32(20), vigObject.vCollider.reader.ReadInt32(24)));
                                vigObject.type = 3;
                                ushort num2 = 6;
                                if (maxHalfHealth < 6)
                                {
                                    num2 = maxHalfHealth;
                                }
                                vigObject.maxHalfHealth = num2;
                                num3 = (short)(maxHalfHealth - num2);
                                break;
                            }
                    }
                    maxHalfHealth = (ushort)num3;
                    result = 120u;
                    if (num3 == 0)
                    {
                        FUN_3A368();
                        result = 120u;
                    }
                    break;
                }
        }
        return result;
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
                maxHalfHealth = 6;
                goto default;
            default:
                result = 0u;
                break;
            case 12:
                FUN_479DC((Vehicle)arg2, 182, typeof(Mine));
                maxHalfHealth--;
                result = 60u;
                if (maxHalfHealth == 0)
                {
                    FUN_3A368();
                    result = 60u;
                }
                break;
            case 13:
                {
                    uint num = GameManager.FUN_2AC5C();
                    if ((num & 0x3FF) == 0 || ((num & 0xFF) == 0 && (sbyte)LevelManager.instance.FUN_35778(arg2.vTransform.position.x, arg2.vTransform.position.z) == sbyte.MinValue))
                    {
                        result = 1u;
                        break;
                    }
                    result = 0u;
                    if ((num & 0xF) != 0)
                    {
                        break;
                    }
                    VigObject target = ((Vehicle)arg2).target;
                    Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, target.vTransform.position);
                    if (vector3Int.z >= 0 || -614400 >= vector3Int.z)
                    {
                        break;
                    }
                    int num2 = (int)((long)Utilities.Ratan2(vector3Int.x, vector3Int.z) << 20) >> 20;
                    if (num2 < 0)
                    {
                        num2 = -num2;
                    }
                    if (1706 < num2)
                    {
                        Utilities.FUN_2A168(out Vector3Int vout, target.vTransform.position, arg2.vTransform.position);
                        num2 = target.physics1.X;
                        if (num2 < 0)
                        {
                            num2 += 127;
                        }
                        int num3 = target.physics1.Y;
                        if (num3 < 0)
                        {
                            num3 += 127;
                        }
                        int num4 = target.physics1.Z;
                        if (num4 < 0)
                        {
                            num4 += 127;
                        }
                        num4 = (num2 >> 7) * vout.x + (num3 >> 7) * vout.y + (num4 >> 7) * vout.z;
                        if (num4 < 0)
                        {
                            num4 += 4095;
                        }
                        result = ((-vector3Int.z < (num4 >> 12) * 60) ? 1u : 0u);
                    }
                    break;
                }
            case 14:
                if (((GameManager.instance.DAT_28 - (arg2.DAT_19 ^ 0x14)) & Mathf.Clamp(127 - (GameManager.instance.DAT_CC4 - 70), 0, 127)) == 0)
                {
                    if (((Vehicle)((Vehicle)arg2).target).wheelsType != 0)
                    {
                        return 307u;
                    }
                    if (UpdateW(13, arg2) != 0)
                    {
                        return 306u;
                    }
                }
                result = 0u;
                break;
        }
        return result;
    }

    private Mine FUN_479DC(Vehicle param1, short param2, Type param3)
    {
        Mine mine = LevelManager.instance.FUN_42408(param1, this, (ushort)param2, param3, null) as Mine;
        uint flags = 536871040u;
        if (mine.vAnim != null)
        {
            flags = 536871044u;
        }
        mine.flags = flags;
        ushort maxHalfHealth = 150;
        if (param1.doubleDamage != 0)
        {
            maxHalfHealth = 300;
        }
        mine.maxHalfHealth = maxHalfHealth;
        mine.FUN_305FC();
        mine.FUN_2D1DC();
        mine.physics2.M2 = 0;
        int num = param1.physics1.X;
        if (num < 0)
        {
            num += 127;
        }
        int num2 = mine.vTransform.rotation.V01;
        if (num2 < 0)
        {
            num2 += 3;
        }
        mine.physics1.Z = (num >> 7) - (num2 >> 2);
        num = param1.physics1.Y;
        if (num < 0)
        {
            num += 127;
        }
        num2 = mine.vTransform.rotation.V11;
        if (num2 < 0)
        {
            num2 += 3;
        }
        mine.physics1.W = (num >> 7) - (num2 >> 2);
        num = param1.physics1.Z;
        if (num < 0)
        {
            num += 127;
        }
        num2 = mine.vTransform.rotation.V21;
        if (num2 < 0)
        {
            num2 += 3;
        }
        mine.physics2.X = (num >> 7) - (num2 >> 2);
        param1.FUN_2B1FC(GameManager.DAT_A68, screen);
        int param4 = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E580(param4, GameManager.instance.DAT_C2C, 54, mine.screen);
        return mine;
    }
}
