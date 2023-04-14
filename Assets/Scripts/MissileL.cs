using System.Collections.Generic;
using UnityEngine;

public class MissileL : VigObject
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
        int param;
        if (arg1 != 0)
        {
            if (arg1 != 2)
            {
                if (arg1 != 10)
                {
                    return 0u;
                }
                arg2 &= 0xFFF;
                if (arg2 == 1092)
                {
                    if (1 < base.maxHalfHealth)
                    {
                        Afterburner afterburner = vData.ini.FUN_2C17C(186, typeof(Afterburner), 8u) as Afterburner;
                        Vehicle vehicle = (Vehicle)(afterburner.PDAT_78 = (Utilities.FUN_2CD78(this) as Vehicle));
                        afterburner.id = 120;
                        ConfigContainer cont = FUN_2C5F4(32769);
                        Utilities.FUN_2CA94(this, cont, afterburner);
                        afterburner.transform.parent = base.transform;
                        afterburner.FUN_30B78();
                        afterburner.FUN_30BF0();
                        base.maxHalfHealth -= 2;
                        vehicle.DAT_F6 |= 256;
                        vehicle.FUN_39B50();
                        return 240u;
                    }
                }
                else if (arg2 == 1090)
                {
                    if (2 < base.maxHalfHealth)
                    {
                        base.maxHalfHealth -= 2;
                        Vehicle vehicle2 = Utilities.FUN_2CD78(this) as Vehicle;
                        Missile missile = FUN_445B0(vehicle2, 199);
                        missile.DAT_84 = vehicle2;
                        missile.flags |= 1090519040u;
                        missile.maxHalfHealth = 60;
                        if (vehicle2.doubleDamage != 0)
                        {
                            missile.maxHalfHealth = 120;
                        }
                        param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 67, missile.screen);
                        return 120u;
                    }
                }
                else
                {
                    if (arg2 != 1091)
                    {
                        return 0u;
                    }
                    if (1 < base.maxHalfHealth)
                    {
                        ushort maxFullHealth = 4;
                        if (base.maxHalfHealth < 4)
                        {
                            maxFullHealth = base.maxHalfHealth;
                        }
                        base.maxFullHealth = maxFullHealth;
                        goto IL_0029;
                    }
                }
                return uint.MaxValue;
            }
            goto IL_0029;
        }
        FUN_42330(arg2);
        return 0u;
    IL_0029:
        Vehicle vehicle3 = Utilities.FUN_2CD78(this) as Vehicle;
        Missile missile2 = FUN_445B0(vehicle3, 188);
        param = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 51, missile2.screen);
        missile2.flags |= 1073741824u;
        ushort maxHalfHealth = 60;
        if (vehicle3.doubleDamage != 0)
        {
            maxHalfHealth = 120;
        }
        missile2.maxHalfHealth = maxHalfHealth;
        short num = (short)(base.maxFullHealth - 1);
        base.maxFullHealth = (ushort)num;
        if (num != 0)
        {
            GameManager.instance.FUN_30CB0(this, 8);
        }
        Matrix3x3 rotation = GameManager.FUN_2A39C().rotation;
        rotation = Utilities.RotMatrixY(base.maxFullHealth * 256 - 384, rotation);
        missile2.vTransform.rotation = Utilities.MulMatrix(missile2.vTransform.rotation, rotation);
        return 120u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        switch (arg1)
        {
            case 0:
                FUN_42330(arg2);
                return 0u;
            case 1:
                base.maxHalfHealth = 12;
                flags |= 16384u;
                if (vr.x <= 0)
                {
                    VigObject vigObject = new GameObject().AddComponent<VigObject>();
                    vigObject.parent = this;
                    child2 = vigObject;
                    vigObject.transform.parent = base.transform;
                    vigObject.vr = new Vector3Int(127, 0, 0);
                    vigObject.ApplyRotationMatrix();
                    vigObject.vData = vData;
                }
                goto default;
            default:
                return 0u;
            case 12:
                {
                    VigObject vigObject2 = FUN_445B0((Vehicle)arg2, 188);
                    ushort maxHalfHealth = 60;
                    if (((Vehicle)arg2).doubleDamage != 0)
                    {
                        maxHalfHealth = 120;
                    }
                    vigObject2.maxHalfHealth = maxHalfHealth;
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 51, vigObject2.screen);
                    return 90u;
                }
            case 13:
                {
                    int num4 = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
                    return (uint)(((3891198u < (uint)(num4 - 204801)) ? 1 : 0) ^ 1);
                }
            case 14:
                if (((GameManager.instance.DAT_28 - (arg2.DAT_19 ^ 0x14)) & Mathf.Clamp(511 - (GameManager.instance.DAT_CC4 - 70) * 2, 0, 511)) == 0)
                {
                    List<VigTuple> worldObjs = GameManager.instance.worldObjs;
                    int num = 0;
                    for (int i = 0; i < worldObjs.Count; i++)
                    {
                        VigObject vObject = worldObjs[i].vObject;
                        if ((vObject.type == 8 && (vObject.flags & 0x1000000) != 0 && vObject.DAT_80 == arg2) || (vObject.GetType() == typeof(Rocket) && ((Rocket)vObject).state == _ROCKET_TYPE.Bastion && vObject.DAT_80 == arg2))
                        {
                            num = 0;
                            break;
                        }
                        if (vObject.type == 8 && vObject.DAT_84 == arg2)
                        {
                            num++;
                        }
                    }
                    if (num >= 3)
                    {
                        return 1090u;
                    }
                    Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
                    uint num2 = 0u;
                    if (vector3Int.z < 2048000)
                    {
                        int num3 = (int)((long)Utilities.Ratan2(vector3Int.x, vector3Int.z) << 20) >> 20;
                        if (num3 < 0)
                        {
                            num3 = -num3;
                        }
                        num2 = ((num3 < 461) ? 1u : 0u);
                    }
                    int num4 = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
                    if (num4 < 393216 && num2 == 0)
                    {
                        return 1090u;
                    }
                    if ((((Vehicle)arg2).DAT_F6 & 8) != 0)
                    {
                        return 1092u;
                    }
                    vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
                    num2 = 0u;
                    if (vector3Int.z < 1327104)
                    {
                        int num3 = (int)((long)Utilities.Ratan2(vector3Int.x, vector3Int.z) << 20) >> 20;
                        if (num3 < 0)
                        {
                            num3 = -num3;
                        }
                        num2 = ((num3 < 446) ? 1u : 0u);
                    }
                    if (num2 != 0)
                    {
                        return 1091u;
                    }
                }
                return 0u;
        }
    }

    private Missile FUN_445B0(Vehicle param1, short param2)
    {
        Missile missile = (!(child2 == null)) ? (LevelManager.instance.FUN_42408(param1, child2, (ushort)param2, typeof(Missile), null) as Missile) : (LevelManager.instance.FUN_42408(param1, this, (ushort)param2, typeof(Missile), null) as Missile);
        Vector3Int v = new Vector3Int(missile.vTransform.rotation.V01 << 5, missile.vTransform.rotation.V11 << 5, missile.vTransform.rotation.V21 << 5);
        missile.flags = 536871044u;
        missile.FUN_305FC();
        int num = param1.physics1.X;
        if (num < 0)
        {
            num += 127;
        }
        int num2 = missile.vTransform.rotation.V01 * 1750;
        if (num2 < 0)
        {
            num2 += 4095;
        }
        missile.physics1.Z = (num >> 7) - (num2 >> 12);
        num = param1.physics1.Y;
        if (num < 0)
        {
            num += 127;
        }
        num2 = missile.vTransform.rotation.V11 * 1750;
        if (num2 < 0)
        {
            num2 += 4095;
        }
        missile.physics1.W = (num >> 7) - (num2 >> 12);
        num = param1.physics1.Z;
        if (num < 0)
        {
            num += 127;
        }
        num2 = missile.vTransform.rotation.V21 * 1750;
        if (num2 < 0)
        {
            num2 += 4095;
        }
        missile.physics2.X = (num >> 7) - (num2 >> 12);
        VigObject dAT_ = param1.target;
        if (param1.target == null)
        {
            dAT_ = param1;
        }
        missile.DAT_84 = dAT_;
        param1.FUN_2B370(v, missile.screen);
        maxHalfHealth--;
        missile.physics2.Z = 7834;
        if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
        {
            missile.physics2.Z = 15258;
        }
        if (maxHalfHealth == 0)
        {
            FUN_3A368();
        }
        return missile;
    }
}