using System.Collections.Generic;
using UnityEngine;

public class RocketL : VigObject
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
        VigObject vigObject;
        VigObject vigObject2;
        short num;
        if (arg1 != 0)
        {
            if (arg1 == 2)
            {
                goto IL_0029;
            }
            if (arg1 != 10)
            {
                result = 0u;
            }
            else
            {
                arg2 &= 0xFFF;
                if (arg2 == 1058)
                {
                    if (maxHalfHealth < 2)
                    {
                        return uint.MaxValue;
                    }
                    vigObject = Utilities.FUN_2CD78(this);
                    vigObject2 = FUN_4336C((Vehicle)vigObject, 187);
                    vigObject2.flags |= 1090519040u;
                    num = (short)(maxHalfHealth - 2);
                    maxHalfHealth = (ushort)num;
                    if (num != 0)
                    {
                        return 120u;
                    }
                    goto IL_02fb;
                }
                if (arg2 != 1059)
                {
                    if (arg2 != 1060)
                    {
                        return 0u;
                    }
                    if (maxHalfHealth < 2)
                    {
                        return uint.MaxValue;
                    }
                    maxFullHealth = 5;
                    goto IL_0029;
                }
                vigObject2 = Utilities.FUN_2CD78(this);
                VigObject[] array = new VigObject[3];
                int num2 = 3;
                if (maxHalfHealth < 3)
                {
                    num2 = maxHalfHealth;
                }
                int num3 = 0;
                do
                {
                    int num4 = 204800000;
                    VigObject vigObject3 = null;
                    List<VigTuple> worldObjs = GameManager.instance.worldObjs;
                    for (int i = 0; i < worldObjs.Count; i++)
                    {
                        VigObject vObject = worldObjs[i].vObject;
                        int num5 = num4;
                        VigObject vigObject4 = vigObject3;
                        if (vObject.type != 8)
                        {
                            num4 = num5;
                            vigObject3 = vigObject4;
                        }
                        else if (vObject.DAT_84 == vigObject2 && vObject != array[0] && vObject != array[1])
                        {
                            num5 = Utilities.FUN_29F6C(vObject.vTransform.position, vigObject2.vTransform.position);
                            vigObject4 = vObject;
                            if (num5 < num4)
                            {
                                num4 = num5;
                                vigObject3 = vigObject4;
                            }
                        }
                    }
                    array[num3] = vigObject3;
                    Rocket rocket = FUN_4336C((Vehicle)vigObject2, GameManager.DAT_63FC8[num3]);
                    rocket.DAT_1A = 211;
                    rocket.DAT_84 = vigObject3;
                    rocket.maxHalfHealth = (ushort)((uint)rocket.maxHalfHealth >> 1);
                    int num6 = (int)GameManager.FUN_2AC5C();
                    rocket.physics1.Z += -1024 + (num6 << 11 >> 15);
                    num6 = (int)GameManager.FUN_2AC5C();
                    num3++;
                    rocket.physics1.W += -1024 + (num6 << 11 >> 15);
                    num6 = (int)GameManager.FUN_2AC5C();
                    rocket.physics2.X += -1024 + (num6 << 11 >> 15);
                    GameManager.instance.FUN_30CB0(rocket, 7);
                }
                while (num3 < num2);
                num = (short)(maxHalfHealth - num2);
                maxHalfHealth = (ushort)num;
                result = 30u;
                if (num == 0)
                {
                    FUN_3A368();
                    result = 30u;
                }
            }
        }
        else
        {
            FUN_42330(arg2);
            result = 0u;
        }
        goto IL_0305;
    IL_0029:
        vigObject = Utilities.FUN_2CD78(this);
        vigObject2 = FUN_4336C((Vehicle)vigObject, 174);
        vigObject2.flags |= 1073741824u;
        num = (short)(maxHalfHealth - 1);
        maxHalfHealth = (ushort)num;
        if (num != 0)
        {
            num = (short)(maxFullHealth - 1);
            maxFullHealth = (ushort)num;
            if (num != 0)
            {
                GameManager.instance.FUN_30CB0(this, 8);
            }
            return 120u;
        }
        goto IL_02fb;
    IL_02fb:
        FUN_3A368();
        result = 120u;
        goto IL_0305;
    IL_0305:
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
                maxHalfHealth = 10;
                goto default;
            default:
                result = 0u;
                break;
            case 12:
                {
                    FUN_4336C((Vehicle)arg2, 174);
                    short num3 = (short)(maxHalfHealth - 1);
                    maxHalfHealth = (ushort)num3;
                    result = 30u;
                    if (num3 == 0)
                    {
                        FUN_3A368();
                        result = 30u;
                    }
                    break;
                }
            case 13:
                {
                    Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
                    result = 0u;
                    if (vector3Int.z < 2048000)
                    {
                        int num2 = (int)((long)Utilities.Ratan2(vector3Int.x, vector3Int.z) << 20) >> 20;
                        if (num2 < 0)
                        {
                            num2 = -num2;
                        }
                        result = ((num2 < 113) ? 1u : 0u);
                    }
                    break;
                }
            case 14:
                if (((GameManager.instance.DAT_28 - (arg2.DAT_19 ^ 0x14)) & Mathf.Clamp(63 - (GameManager.instance.EnemyKill - 70), 0, 63)) == 0)
                {
                    List<VigTuple> worldObjs = GameManager.instance.worldObjs;
                    int num = 0;
                    for (int i = 0; i < worldObjs.Count; i++)
                    {
                        VigObject vObject = worldObjs[i].vObject;
                        if ((vObject.GetType() == typeof(Rocket) && ((Rocket)vObject).state == _ROCKET_TYPE.Bastion && vObject.DAT_80 == arg2) || (vObject.type == 8 && (vObject.flags & 0x1000000) != 0 && vObject.DAT_80 == arg2))
                        {
                            num = 0;
                            break;
                        }
                        if (vObject.type == 8 && vObject.DAT_84 == arg2)
                        {
                            num++;
                        }
                    }
                    if (num >= 2)
                    {
                        return 1059u;
                    }
                    if (UpdateW(13, arg2) != 0 && Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen) < 524288)
                    {
                        if (((Vehicle)arg2).target.physics1.W > 8000)
                        {
                            return 1058u;
                        }
                        if (((Vehicle)arg2).target.physics1.W < 2000)
                        {
                            return 1059u;
                        }
                        return 1060u;
                    }
                }
                result = 0u;
                break;
        }
        return result;
    }

    private Rocket FUN_4336C(Vehicle param1, int param2)
    {
        Rocket rocket = LevelManager.instance.FUN_42408(param1, this, (ushort)param2, typeof(Rocket), null) as Rocket;
        if (1u < (uint)(param2 - 212))
        {
            Particle1 particle = LevelManager.instance.FUN_4DE54(rocket.screen, 1);
            particle.flags &= 4294967279u;
            particle.vTransform = rocket.vTransform;
        }
        rocket.flags = 536871044u;
        ushort maxHalfHealth = 80;
        if (param1.doubleDamage != 0)
        {
            maxHalfHealth = 160;
        }
        rocket.maxHalfHealth = maxHalfHealth;
        rocket.FUN_305FC();
        int num = param1.physics1.X;
        if (num < 0)
        {
            num += 127;
        }
        rocket.physics1.Z = (num >> 7) + rocket.vTransform.rotation.V02 * 4;
        num = param1.physics1.Y;
        if (num < 0)
        {
            num += 127;
        }
        rocket.physics1.W = (num >> 7) + rocket.vTransform.rotation.V12 * 4;
        num = param1.physics1.Z;
        if (num < 0)
        {
            num += 127;
        }
        rocket.physics2.X = (num >> 7) + rocket.vTransform.rotation.V22 * 4;
        rocket.physics2.M2 = 240;
        int param3 = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E580(param3, GameManager.instance.DAT_C2C, 52, rocket.screen);
        param1.FUN_2B1FC(GameManager.DAT_A30, screen);
        return rocket;
    }
}
