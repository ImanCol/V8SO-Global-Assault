using System;
using UnityEngine;

public class FlameThrower : VigObject
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
                    int num = FUN_42330(arg2);
                    if (num < 1)
                    {
                        return 0u;
                    }
                    if (base.id != 0)
                    {
                        return 0u;
                    }
                    break;
                }
            default:
                return 0u;
            case 10:
                {
                    arg2 &= 0xFFF;
                    Matrix3x3 matrix3x;
                    short num2;
                    if (arg2 == 788)
                    {
                        if (base.maxHalfHealth < 10)
                        {
                            return uint.MaxValue;
                        }
                        Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
                        VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
                        ConfigContainer configContainer = FUN_2C5F4(32768);
                        VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(3, typeof(Ballistic), 8u);
                        VigObject vigObject2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C(110, typeof(Brimstone), 8u);
                        Vector3Int v = new Vector3Int(0, 0, 0);
                        v.y = -256;
                        v.z = 4096;
                        Utilities.FUN_2CA94(this, configContainer, vigObject);
                        vigObject.FUN_30BF0();
                        vigObject2.vTransform.position = Utilities.FUN_24148(vigTransform, configContainer.v3_1);
                        matrix3x = (vigObject2.vTransform.rotation = new Matrix3x3
                        {
                            V00 = 4096,
                            V01 = 0,
                            V02 = 0,
                            V10 = 0,
                            V11 = 4096,
                            V12 = 0,
                            V20 = 0,
                            V21 = 0,
                            V22 = 4096
                        });
                        int param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 60);
                        vigObject2.flags = 1610614420u;
                        short id = vehicle.id;
                        vigObject2.type = 8;
                        vigObject2.maxHalfHealth = 100;
                        if (vehicle.doubleDamage != 0)
                        {
                            vigObject2.maxHalfHealth = 200;
                        }
                        vigObject2.DAT_80 = vehicle;
                        vigObject2.physics2.M3 = 2;
                        vigObject2.id = id;
                        v = Utilities.ApplyMatrixSV(vigTransform.rotation, v);
                        int num = vehicle.physics1.X;
                        if (num < 0)
                        {
                            num += 127;
                        }
                        vigObject2.physics1.Z = (num >> 7) + v.x * 4;
                        num = vehicle.physics1.Y;
                        if (num < 0)
                        {
                            num += 127;
                        }
                        vigObject2.physics1.W = (num >> 7) + v.y * 4;
                        num = vehicle.physics1.Z;
                        if (num < 0)
                        {
                            num += 127;
                        }
                        vigObject2.physics2.X = (num >> 7) + v.z * 4;
                        vigObject2.FUN_305FC();
                        num2 = (short)(base.maxHalfHealth - 10);
                    }
                    else
                    {
                        ConfigContainer configContainer2;
                        VigObject vigObject;
                        int param;
                        short id;
                        int num;
                        if (arg2 == 786)
                        {
                            if (base.maxHalfHealth < 2)
                            {
                                return uint.MaxValue;
                            }
                            Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
                            configContainer2 = FUN_2C5F4(32768);
                            uint num3 = 0u;
                            ushort num4 = 65024;
                            vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(20, typeof(Ballistic), 8u);
                            Vector3Int v = new Vector3Int(0, 0, 0);
                            v.y = 256;
                            Utilities.FUN_2CA94(this, configContainer2, vigObject);
                            Utilities.ParentChildren(this, this);
                            vigObject.FUN_30BF0();
                            GameManager.instance.FUN_2CF00(out Vector3Int param2, this, configContainer2);
                            param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 60);
                            ushort num5;
                            while (true)
                            {
                                vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(113, typeof(Flamewall1), 8u);
                                vigObject.flags = 1610613908u;
                                id = vehicle.id;
                                vigObject.type = 8;
                                vigObject.maxHalfHealth = 50;
                                if (vehicle.doubleDamage != 0)
                                {
                                    vigObject.maxHalfHealth = 100;
                                }
                                vigObject.DAT_80 = vehicle;
                                vigObject.id = id;
                                matrix3x = (vigObject.vTransform.rotation = new Matrix3x3
                                {
                                    V00 = 4096,
                                    V01 = 0,
                                    V02 = 0,
                                    V10 = 0,
                                    V11 = 4096,
                                    V12 = 0,
                                    V20 = 0,
                                    V21 = 0,
                                    V22 = 4096
                                });
                                vigObject.vTransform.position = param2;
                                if ((num3 & 1) == 0)
                                {
                                    v.x = (short)num4;
                                }
                                else
                                {
                                    v.x = (short)num3 * 1024 - 512;
                                }
                                Vector3Int vector3Int = Utilities.ApplyMatrixSV(vehicle.vTransform.rotation, v);
                                num = vehicle.physics1.X;
                                if (num < 0)
                                {
                                    num += 127;
                                }
                                vigObject.physics1.Z = (num >> 7) + vector3Int.x;
                                num = vehicle.physics1.Y;
                                if (num < 0)
                                {
                                    num += 127;
                                }
                                vigObject.physics1.W = (num >> 7) + vector3Int.y;
                                num = vehicle.physics1.Z;
                                if (num < 0)
                                {
                                    num += 127;
                                }
                                vigObject.physics2.X = (num >> 7) + vector3Int.z;
                                vigObject.FUN_305FC();
                                num5 = (base.maxHalfHealth -= 2);
                                num3++;
                                if (num5 < 2)
                                {
                                    break;
                                }
                                num4 = (ushort)(num4 - 1024);
                                if (7 < (int)num3)
                                {
                                    return 120u;
                                }
                            }
                            if (num5 != 0)
                            {
                                return 120u;
                            }
                            goto IL_070e;
                        }
                        if (arg2 != 787)
                        {
                            return 0u;
                        }
                        if (base.maxHalfHealth < 5)
                        {
                            return uint.MaxValue;
                        }
                        Vehicle obj = Utilities.FUN_2CD78(this) as Vehicle;
                        configContainer2 = FUN_2C5F4(32768);
                        vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(222, typeof(OilSlick1), 8u);
                        Utilities.ParentChildren(vigObject, vigObject);
                        vigObject.vTransform = GameManager.instance.FUN_2CEAC(this, configContainer2);
                        param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 60);
                        vigObject.flags = 172u;
                        id = obj.id;
                        vigObject.maxHalfHealth = 100;
                        vigObject.id = id;
                        int num6 = obj.physics1.X;
                        if (num6 < 0)
                        {
                            num6 += 255;
                        }
                        vigObject.physics1.X = num6 >> 8;
                        num6 = obj.physics1.Y;
                        if (num6 < 0)
                        {
                            num6 += 255;
                        }
                        vigObject.physics1.Y = num6 >> 8;
                        num = obj.physics1.Z;
                        if (num < 0)
                        {
                            num += 255;
                        }
                        vigObject.physics1.Z = num >> 8;
                        vigObject.FUN_2D1DC();
                        vigObject.FUN_4C9C8();
                        vigObject.FUN_305FC();
                        num2 = (short)(base.maxHalfHealth - 5);
                    }
                    base.maxHalfHealth = (ushort)num2;
                    if (num2 != 0)
                    {
                        return 120u;
                    }
                    goto IL_070e;
                }
            case 2:
                {
                    Vehicle vehicle = (Vehicle)Utilities.FUN_2CD78(this);
                    VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
                    ConfigContainer configContainer = FUN_2C5F4(32768);
                    bool num7 = (DAT_19 & 3) != 0;
                    Type type = (!num7) ? typeof(Flame1) : typeof(Flame2);
                    VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(111, type, 8u);
                    Utilities.ParentChildren(vigObject, vigObject);
                    Vector3Int v = new Vector3Int(0, 0, 0);
                    Vector3Int vector3Int2 = new Vector3Int(0, 0, 0);
                    ushort num4 = (ushort)GameManager.FUN_2AC5C();
                    v.x = (short)((num4 & 0x1FF) - 256);
                    num4 = (ushort)GameManager.FUN_2AC5C();
                    ushort maxHalfHealth = 20;
                    v.y = (short)((num4 & 0x1FF) - 256);
                    v.z = 4096;
                    vector3Int2 = v;
                    short num2 = base.id;
                    vigObject.flags = 644u;
                    vigObject.tags = (sbyte)((num2 == 0) ? 1 : 0);
                    ushort num8 = (ushort)vehicle.id;
                    vigObject.type = 8;
                    vigObject.id = (short)num8;
                    if (vehicle.doubleDamage != 0)
                    {
                        maxHalfHealth = 40;
                    }
                    vigObject.maxHalfHealth = maxHalfHealth;
                    num8 = (ushort)GameManager.FUN_2AC5C();
                    vigObject.vr.z = num8;
                    vigObject.child2.flags = 1040u;
                    if (type.Equals(typeof(Flame1)))
                    {
                        ((Flame1)vigObject).DAT_80 = vehicle;
                    }
                    else
                    {
                        ((Flame2)vigObject).DAT_80 = vehicle;
                    }
                    vigObject.ApplyTransformation();
                    vigObject.vTransform.position = Utilities.FUN_24148(vigTransform, configContainer.v3_1);
                    vector3Int2 = Utilities.ApplyMatrixSV(vigTransform.rotation, vector3Int2);
                    int num = vehicle.physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vigObject.physics1.Z = (num >> 7) + vector3Int2.x * 2;
                    num = vehicle.physics1.Y;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vigObject.physics1.W = (num >> 7) + vector3Int2.y * 2;
                    num = vehicle.physics1.Z;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vigObject.physics2.X = (num >> 7) + vector3Int2.z * 2;
                    if (num7)
                    {
                        vigObject.FUN_4EDFC();
                        GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, vigObject);
                    }
                    else
                    {
                        vigObject.FUN_305FC();
                    }
                    DAT_19--;
                    if (DAT_19 == 0)
                    {
                        if (base.maxHalfHealth == 0)
                        {
                            FUN_3A368();
                        }
                    }
                    else
                    {
                        GameManager.instance.FUN_30CB0(this, 2);
                    }
                    return (uint)((DAT_19 + 1) * 2);
                }
            case 11:
                if (arg2 != 0)
                {
                    return 0u;
                }
                break;
            case 4:
                break;
            IL_070e:
                FUN_3A368();
                return 120u;
        }
        if (DAT_18 != 0)
        {
            GameManager.instance.FUN_1E14C(DAT_18, GameManager.instance.DAT_C2C, 60);
            DAT_18 = 0;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        switch (arg1)
        {
            case 0:
                {
                    int num6 = FUN_42330(arg2);
                    if (num6 < 1)
                    {
                        return 0u;
                    }
                    if (base.id != 0)
                    {
                        return 0u;
                    }
                    break;
                }
            case 1:
                base.maxHalfHealth = 20;
                return 0u;
            default:
                return 0u;
            case 11:
                if (arg2 != null)
                {
                    return 0u;
                }
                break;
            case 12:
                {
                    if (DAT_18 == 0)
                    {
                        sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 59, param4: true);
                    }
                    base.maxHalfHealth--;
                    VigObject vigObject2 = Utilities.FUN_2CD78(this);
                    byte dAT_ = 12;
                    if (vigObject2.id < 0)
                    {
                        dAT_ = 4;
                    }
                    DAT_19 = dAT_;
                    goto case 2;
                }
            case 2:
                {
                    Vehicle vehicle = (Vehicle)Utilities.FUN_2CD78(this);
                    VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
                    ConfigContainer configContainer = FUN_2C5F4(32768);
                    bool num3 = (DAT_19 & 3) != 0;
                    Type type = (!num3) ? typeof(Flame1) : typeof(Flame2);
                    VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(111, type, 8u);
                    Utilities.ParentChildren(vigObject, vigObject);
                    Vector3Int vector3Int2 = new Vector3Int(0, 0, 0);
                    Vector3Int vector3Int3 = new Vector3Int(0, 0, 0);
                    ushort num4 = (ushort)GameManager.FUN_2AC5C();
                    vector3Int2.x = (short)((num4 & 0x1FF) - 256);
                    num4 = (ushort)GameManager.FUN_2AC5C();
                    ushort maxHalfHealth = 20;
                    vector3Int2.y = (short)((num4 & 0x1FF) - 256);
                    vector3Int2.z = 4096;
                    vector3Int3 = vector3Int2;
                    short id = base.id;
                    vigObject.flags = 644u;
                    vigObject.tags = (sbyte)((id == 0) ? 1 : 0);
                    ushort num5 = (ushort)vehicle.id;
                    vigObject.type = 8;
                    vigObject.id = (short)num5;
                    if (vehicle.doubleDamage != 0)
                    {
                        maxHalfHealth = 40;
                    }
                    vigObject.maxHalfHealth = maxHalfHealth;
                    num5 = (ushort)GameManager.FUN_2AC5C();
                    vigObject.vr.z = num5;
                    vigObject.child2.flags = 1040u;
                    if (type.Equals(typeof(Flame1)))
                    {
                        ((Flame1)vigObject).DAT_80 = vehicle;
                    }
                    else
                    {
                        ((Flame2)vigObject).DAT_80 = vehicle;
                    }
                    vigObject.ApplyTransformation();
                    vigObject.vTransform.position = Utilities.FUN_24148(vigTransform, configContainer.v3_1);
                    vector3Int3 = Utilities.ApplyMatrixSV(vigTransform.rotation, vector3Int3);
                    int num6 = vehicle.physics1.X;
                    if (num6 < 0)
                    {
                        num6 += 127;
                    }
                    vigObject.physics1.Z = (num6 >> 7) + vector3Int3.x * 2;
                    num6 = vehicle.physics1.Y;
                    if (num6 < 0)
                    {
                        num6 += 127;
                    }
                    vigObject.physics1.W = (num6 >> 7) + vector3Int3.y * 2;
                    num6 = vehicle.physics1.Z;
                    if (num6 < 0)
                    {
                        num6 += 127;
                    }
                    vigObject.physics2.X = (num6 >> 7) + vector3Int3.z * 2;
                    if (num3)
                    {
                        vigObject.FUN_4EDFC();
                        GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, vigObject);
                    }
                    else
                    {
                        vigObject.FUN_305FC();
                    }
                    DAT_19--;
                    if (DAT_19 == 0)
                    {
                        if (base.maxHalfHealth == 0)
                        {
                            FUN_3A368();
                        }
                    }
                    else
                    {
                        GameManager.instance.FUN_30CB0(this, 2);
                    }
                    return (uint)((DAT_19 + 1) * 2);
                }
            case 13:
                {
                    Vector3Int vector3Int2 = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
                    if (245759 < vector3Int2.z)
                    {
                        return 0u;
                    }
                    int num6 = (int)((long)Utilities.Ratan2(vector3Int2.x, vector3Int2.z) << 20) >> 20;
                    if (num6 < 0)
                    {
                        num6 = -num6;
                    }
                    if (num6 >= 113)
                    {
                        return 0u;
                    }
                    return 1u;
                }
            case 14:
                if (((GameManager.instance.DAT_28 - (arg2.DAT_19 ^ 0x14)) & Mathf.Clamp(63 - (GameManager.instance.DAT_CC4 - 70), 0, 63)) == 0)
                {
                    Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
                    uint num = 0u;
                    if (vector3Int.z < 2048000)
                    {
                        int num2 = (int)((long)Utilities.Ratan2(vector3Int.x, vector3Int.z) << 20) >> 20;
                        if (num2 < 0)
                        {
                            num2 = -num2;
                        }
                        num = ((num2 < 113) ? 1u : 0u);
                    }
                    if (num != 0)
                    {
                        return 788u;
                    }
                }
                return 0u;
            case 4:
                break;
        }
        if (DAT_18 != 0)
        {
            GameManager.instance.FUN_1E14C(DAT_18, GameManager.instance.DAT_C2C, 60);
            DAT_18 = 0;
        }
        return 0u;
    }
}
