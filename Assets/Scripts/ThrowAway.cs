using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _THROWAWAY_TYPE
{
    Spawnable, //FUN_4A6E0
    Unspawnable,  //FUN_4CD60
    Type3 //FUN_4CB4C
}

public class Throwaway : VigObject
{
    public byte DAT_87;

    public _THROWAWAY_TYPE state;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override uint OnCollision(HitDetection hit)
    {
        switch (state)
        {
            case _THROWAWAY_TYPE.Unspawnable:
                {
                    VigObject self = hit.self;
                    if (self.type != 2)
                    {
                        return 0u;
                    }
                    GameManager.instance.FUN_2F798(this, hit);
                    int num3 = physics1.Z * hit.normal1.x + physics1.W * hit.normal1.y + physics2.X * hit.normal1.z;
                    if (num3 < 0)
                    {
                        num3 += 2047;
                    }
                    num3 >>= 11;
                    if (-1 < num3)
                    {
                        return 0u;
                    }
                    Vector3Int v = default(Vector3Int);
                    v.x = physics1.Z << 7;
                    v.y = physics1.W << 7;
                    v.z = physics2.X << 7;
                    self.FUN_2B370(v, vTransform.position);
                    if (self.id < 0)
                    {
                        GameManager.instance.FUN_15B00(~self.id, byte.MaxValue, 2, 128);
                    }
                    int num2 = num3 * hit.normal1.x;
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    physics1.Z -= num2 >> 12;
                    num2 = num3 * hit.normal1.y;
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    physics1.W -= num2 >> 12;
                    num3 *= hit.normal1.z;
                    if (num3 < 0)
                    {
                        num3 += 4095;
                    }
                    physics2.X -= num3 >> 12;
                    break;
                }
            case _THROWAWAY_TYPE.Type3:
                {
                    GameManager.instance.FUN_2F798(this, hit);
                    int num = physics1.Z * hit.normal1.x + physics1.W * hit.normal1.y + physics2.X * hit.normal1.z;
                    if (num < 0)
                    {
                        num += 2047;
                    }
                    num >>= 11;
                    if (-1 < num)
                    {
                        return 0u;
                    }
                    int num2 = num * hit.normal1.x;
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    physics1.Z -= num2 >> 12;
                    num2 = num * hit.normal1.y;
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    physics1.W -= num2 >> 12;
                    num *= hit.normal1.z;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    physics2.X -= num >> 12;
                    break;
                }
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (state)
        {
            case _THROWAWAY_TYPE.Unspawnable:
                return FUN_4CD60(arg1, arg2);
            case _THROWAWAY_TYPE.Spawnable:
                {
                    uint num2 = FUN_4CD60(arg1, arg2);
                    if ((int)num2 < 0)
                    {
                        Pickup pickup = LevelManager.instance.FUN_4AD24(GameManager.DAT_63FA4[tags + 6]);
                        pickup.maxHalfHealth = maxHalfHealth;
                        pickup.vTransform = vTransform;
                        pickup.screen = vTransform.position;
                        byte b = pickup.DAT_19 = (byte)GameManager.FUN_2AC5C();
                        pickup.FUN_3066C();
                        GameManager.instance.FUN_30CB0(pickup, 600);
                    }
                    return num2;
                }
            case _THROWAWAY_TYPE.Type3:
                switch (arg1)
                {
                    case 1:
                        {
                            byte dAT_ = 3;
                            if (10239 < DAT_58)
                            {
                                dAT_ = 1;
                                if (DAT_58 < 30720)
                                {
                                    dAT_ = 2;
                                }
                            }
                            DAT_87 = dAT_;
                            break;
                        }
                    case 0:
                        {
                            vTransform.position.x += physics1.Z;
                            vTransform.position.y += physics1.W;
                            vTransform.position.z += physics2.X;
                            physics1.W += 90;
                            int num = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
                            if (vTransform.position.y <= num)
                            {
                                return 0u;
                            }
                            vTransform.position.y = num;
                            physics1.W = -physics1.W / 2;
                            if (--DAT_87 != 0)
                            {
                                return 0u;
                            }
                            GameManager.instance.FUN_309A0(this);
                            return uint.MaxValue;
                        }
                }
                break;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (state == _THROWAWAY_TYPE.Type3 && arg1 == 1)
        {
            byte dAT_ = 3;
            if (10239 < DAT_58)
            {
                dAT_ = 1;
                if (DAT_58 < 30720)
                {
                    dAT_ = 2;
                }
            }
            DAT_87 = dAT_;
        }
        return 0u;
    }

    private uint FUN_4CD60(int arg1, int arg2)
    {
        if (arg1 == 0)
        {
            vTransform.position.x += physics1.Z;
            vTransform.position.y += physics1.W;
            vTransform.position.z += physics2.X;
            FUN_24700(physics1.M0, physics1.M1, physics1.M2);
            if ((++DAT_19 & 0xF) == 0)
            {
                vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
            }
            int num = physics1.W + 90;
            physics1.W = num;
            if (0 < num)
            {
                num = FUN_2CFBC(vTransform.position);
                if (vTransform.position.y <= num)
                {
                    return 0u;
                }
                vTransform.position.y = num;
                physics1.W = -physics1.W / 2;
                if (vCollider != null)
                {
                    LevelManager.instance.FUN_4DE54(vTransform.position, 13);
                }
                sbyte b = (sbyte)(DAT_87 - 1);
                DAT_87 = (byte)b;
                if (b != 0)
                {
                    return 0u;
                }
                GameManager.instance.FUN_309A0(this);
                return uint.MaxValue;
            }
        }
        return 0u;
    }
}
