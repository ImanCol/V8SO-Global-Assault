using UnityEngine;

public class Cannon : VigObject
{
    private bool newAim;

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
        if (arg1 != 0)
        {
            if (arg1 == 10)
            {
                arg2 &= 0xFFF;
                switch (arg2)
                {
                    case 578:
                        result = uint.MaxValue;
                        if (1 < maxHalfHealth)
                        {
                            maxHalfHealth--;
                            VigObject vigObject = Utilities.FUN_2CD78(this);
                            ushort param = 40;
                            if (((Vehicle)vigObject).doubleDamage != 0)
                            {
                                param = 80;
                            }
                            Cannonball cannonball = FUN_45218(vigObject, 202, param);
                            result = 120u;
                            cannonball.tags = 1;
                            cannonball.flags |= 1073741824u;
                        }
                        break;
                    case 580:
                        {
                            result = uint.MaxValue;
                            if (1 >= maxHalfHealth)
                            {
                                break;
                            }
                            VigObject vigObject2 = Utilities.FUN_2CD78(this);
                            VigObject child = child2;
                            short num = (short)child.vr.x;
                            short num2 = (short)child.vr.y;
                            ushort param = 75;
                            if (((Vehicle)vigObject2).doubleDamage != 0)
                            {
                                param = 150;
                            }
                            Cannonball cannonball = FUN_45218(vigObject2, 175, param);
                            cannonball.flags |= 1073741824u;
                            short num3 = (short)maxHalfHealth;
                            int num4 = 1;
                            while (num3 != 0 && num4 < 6)
                            {
                                int num5 = (int)GameManager.FUN_2AC5C();
                                child.vr.x = num + (short)(num5 * 192 >> 15) - 96;
                                num5 = (int)GameManager.FUN_2AC5C();
                                child.vr.y = num2 + (short)(num5 * 192 >> 15) - 96;
                                child.ApplyTransformation();
                                Cannonball cannonball2 = LevelManager.instance.FUN_42408(vigObject2, child, 175, typeof(Cannonball), null) as Cannonball;
                                cannonball2.flags = 1610612884u;
                                cannonball2.maxHalfHealth = param;
                                cannonball2.FUN_305FC();
                                cannonball2.physics2.M2 = 60;
                                num5 = vigObject2.physics1.X;
                                if (num5 < 0)
                                {
                                    num5 += 127;
                                }
                                cannonball2.physics1.Z = (num5 >> 7) + cannonball2.vTransform.rotation.V02 * 6;
                                num5 = vigObject2.physics1.Y;
                                if (num5 < 0)
                                {
                                    num5 += 127;
                                }
                                cannonball2.physics1.W = (num5 >> 7) + cannonball2.vTransform.rotation.V12 * 6;
                                num5 = vigObject2.physics1.Z;
                                if (num5 < 0)
                                {
                                    num5 += 127;
                                }
                                cannonball2.physics2.X = (num5 >> 7) + cannonball2.vTransform.rotation.V22 * 6;
                                num3 = (short)(maxHalfHealth - 1);
                                maxHalfHealth = (ushort)num3;
                                num4++;
                            }
                            child.vr.x = num;
                            child.vr.y = num2;
                            child.ApplyTransformation();
                            result = 120u;
                            if (maxHalfHealth == 0)
                            {
                                FUN_3A368();
                                result = 120u;
                            }
                            break;
                        }
                    default:
                        {
                            result = 0u;
                            if (arg2 != 579)
                            {
                                break;
                            }
                            if (maxHalfHealth < 3)
                            {
                                result = uint.MaxValue;
                                break;
                            }
                            maxHalfHealth -= 2;
                            VigObject vigObject = Utilities.FUN_2CD78(this);
                            ushort param = 35;
                            if (((Vehicle)vigObject).doubleDamage != 0)
                            {
                                param = 70;
                            }
                            Cannonball cannonball = FUN_45218(vigObject, 216, param);
                            cannonball.tags = 2;
                            cannonball.flags |= 1073741824u;
                            GameManager.instance.FUN_30CB0(cannonball, 300);
                            result = 120u;
                            break;
                        }
                }
                goto IL_0371;
            }
        }
        else
        {
            int num4 = FUN_42330(arg2);
            if (num4 < 1)
            {
                return 0u;
            }
        }
        result = 0u;
        goto IL_0371;
    IL_0371:
        return result;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        uint result;
        switch (arg1)
        {
            case 0:
                {
                    int num3 = FUN_42330(arg2);
                    if (num3 < 1)
                    {
                        return 0u;
                    }
                    VigObject child = child2;
                    VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
                    VigObject target = ((Vehicle)arg2).target;
                    if (target == null)
                    {
                        child.vr.y = (int)Mathf.Lerp(child.vr.y, 0f, 0.2f);
                        child.vr.x = (int)Mathf.Lerp(child.vr.x, 0f, 0.2f);
                        child.ApplyRotationMatrix();
                        return 0u;
                    }
                    Vector3Int vector3Int2;
                    if (target.type != 2 || !newAim)
                    {
                        vector3Int2 = new Vector3Int(target.screen.x - vigTransform.position.x, target.screen.y - vigTransform.position.y, target.screen.z - vigTransform.position.z);
                    }
                    else
                    {
                        Vehicle vehicle = (Vehicle)target;
                        num3 = ((vehicle.direction >= 0) ? vehicle.physics1.W : (-vehicle.physics1.W));
                        int num4 = (((Vehicle)arg2).direction >= 0) ? arg2.physics1.W : (-arg2.physics1.W);
                        Vector3Int vector3Int3 = Utilities.FUN_24148(v: new Vector3Int(0, 0, num3 * 14 + num4 * 14), transform: target.vTransform);
                        vector3Int2 = new Vector3Int(vector3Int3.x - vigTransform.position.x, vector3Int3.y - vigTransform.position.y, vector3Int3.z - vigTransform.position.z);
                    }
                    vector3Int2 = Utilities.FUN_2426C(vigTransform.rotation, new Matrix2x4(vector3Int2.x, vector3Int2.y, vector3Int2.z, 0));
                    long num5 = Utilities.Ratan2(vector3Int2.x, vector3Int2.z);
                    uint num6 = (uint)((long)vector3Int2.z * (long)vector3Int2.z);
                    int num7 = (int)((ulong)((long)vector3Int2.z * (long)vector3Int2.z) >> 32);
                    result = (uint)((int)((long)vector3Int2.x * (long)vector3Int2.x) + (int)num6);
                    num3 = Utilities.FUN_2ABC4(result, (int)((ulong)((long)vector3Int2.x * (long)vector3Int2.x) >> 32) + num7 + ((result < num6) ? 1 : 0));
                    num6 = (uint)((long)vector3Int2.y * 24576L);
                    num7 = (int)((ulong)((long)vector3Int2.y * 24576L) >> 32);
                    int num8 = (int)Utilities.Divdi3((int)num6, num7, num3, num3 >> 31);
                    num8 = Utilities.Ratan2(num8 - num3 * 56 / 49152, 24576) * -1048576 >> 20;
                    num3 = 256;
                    if (num8 < 256)
                    {
                        num3 = num8;
                    }
                    num8 = -128;
                    if (-128 < num3)
                    {
                        num8 = num3;
                    }
                    num3 = (int)(num5 << 20 >> 20) - child.vr.y;
                    if (num3 > 2048)
                    {
                        num3 -= 4096;
                    }
                    else if (num3 < -2048)
                    {
                        num3 += 4096;
                    }
                    if (num3 < 0)
                    {
                        num3 += 3;
                    }
                    child.vr.y += num3 >> 2;
                    if (child.vr.y > 4096)
                    {
                        child.vr.y -= 4096;
                    }
                    else if (child.vr.y < -4096)
                    {
                        child.vr.y += 4096;
                    }
                    num3 = (short)num8 - child.vr.x;
                    if (num3 < 0)
                    {
                        num3 += 3;
                    }
                    child.vr.x += num3 >> 2;
                    child.ApplyTransformation();
                    return 0u;
                }
            default:
                result = 0u;
                break;
            case 1:
                maxHalfHealth = 12;
                flags |= 16384u;
                if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                {
                    newAim = true;
                }
                goto default;
            case 11:
                result = 0u;
                if (arg2 != null)
                {
                    int num4 = GameManager.instance.FUN_1DD9C();
                    Vector3Int param = GameManager.instance.FUN_2CE50(this);
                    GameManager.instance.FUN_1E628(num4, GameManager.instance.DAT_C2C, 48, param);
                    result = 0u;
                }
                break;
            case 12:
                {
                    int num4 = 75;
                    if (((Vehicle)arg2).doubleDamage != 0)
                    {
                        num4 = 150;
                    }
                    FUN_45218(arg2, 175, (ushort)num4);
                    result = 60u;
                    break;
                }
            case 13:
                {
                    int num3 = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
                    result = 0u;
                    if (num3 < 4096000)
                    {
                        result = ((arg2.physics1.W < 4577) ? 1u : 0u);
                    }
                    break;
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
                        num = ((num2 < 461) ? 1u : 0u);
                    }
                    if (Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen) < 393216)
                    {
                        if (num != 0)
                        {
                            return 580u;
                        }
                        if ((((Vehicle)arg2).target.flags & 0x30000000) != 805306368)
                        {
                            return 579u;
                        }
                        return 578u;
                    }
                    if (num != 0)
                    {
                        return 579u;
                    }
                }
                result = 0u;
                break;
        }
        return result;
    }

    private Cannonball FUN_45218(VigObject param1, short param2, ushort param3)
    {
        VigObject child = child2;
        Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(3, typeof(Ballistic), 8u) as Ballistic;
        Utilities.ParentChildren(ballistic, ballistic);
        Cannonball cannonball = LevelManager.instance.FUN_42408(param1, child, (ushort)param2, typeof(Cannonball), ballistic) as Cannonball;
        cannonball.flags = 536871060u;
        cannonball.maxHalfHealth = param3;
        cannonball.FUN_305FC();
        cannonball.physics2.M2 = 60;
        int num = param1.physics1.X;
        if (num < 0)
        {
            num += 127;
        }
        cannonball.physics1.Z = (num >> 7) + cannonball.vTransform.rotation.V02 * 6;
        num = param1.physics1.Y;
        if (num < 0)
        {
            num += 127;
        }
        cannonball.physics1.W = (num >> 7) + cannonball.vTransform.rotation.V12 * 6;
        num = param1.physics1.Z;
        if (num < 0)
        {
            num += 127;
        }
        cannonball.physics2.X = (num >> 7) + cannonball.vTransform.rotation.V22 * 6;
        ballistic.FUN_30BF0();
        Vector3Int v = Utilities.FUN_24094(child.vTransform.rotation, GameManager.DAT_A3C);
        param1.FUN_2B1FC(v, screen);
        int param4 = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E580(param4, GameManager.instance.DAT_C2C, 53, cannonball.screen);
        maxHalfHealth--;
        if (maxHalfHealth == 0)
        {
            FUN_3A368();
        }
        return cannonball;
    }
}
