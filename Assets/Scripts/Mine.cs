using UnityEngine;

public class Mine : VigObject
{
    public OilSlick2 DAT_98;

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
        VigObject self = hit.self;
        if (hit.object2.type == 3)
        {
            return 0u;
        }
        //if (self.GetType() == typeof(Bearhug))
        if (self.GetType() == typeof(Brearhug))
        {
            return 0u;
        }
        if (self.type == 3)
        {
            return 0u;
        }
        if (self.type == 0)
        {
            return 1u;
        }
        if (self.type == 2)
        {
            Vehicle vehicle = (Vehicle)self;
            vehicle.FUN_2B370(GameManager.DAT_A5C, screen);
            vehicle.FUN_39714(screen);
            if (vehicle.type < 0)
            {
                GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 4, 64);
            }
        }
        if (DAT_98 != null)
        {
            DAT_98.CreateBurstFire(chain: true);
        }
        GameManager.instance.FUN_300B8(GameManager.instance.DAT_10C8, this);
        int param = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 65, screen);
        LevelManager.instance.FUN_4DE54(screen, 39);
        LevelManager.instance.FUN_309C8(this, 0);
        return uint.MaxValue;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                if (DAT_80 != null)
                {
                    if (((Vehicle)DAT_80).doubleDamage != 0)
                    {
                        maxHalfHealth = 300;
                    }
                    else
                    {
                        maxHalfHealth = 150;
                    }
                    if (DAT_80 != null && DAT_80.maxHalfHealth == 0)
                    {
                        flags &= 3758096383u;
                        return 0u;
                    }
                }
                break;
            default:
                return 0u;
            case 0:
                {
                    int num;
                    if (tags != 0)
                    {
                        num = GameManager.DAT_65C90[((ushort)physics2.M2 & 0xFFF) * 2] * 5120;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        vTransform.position.y = GameManager.instance.DAT_DB0 + (num >> 12);
                        physics2.M2 += 34;
                        return 0u;
                    }
                    if (FUN_46D70() == 0)
                    {
                        return 0u;
                    }
                    if (vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 <= vTransform.position.y)
                    {
                        tags = 1;
                        physics2.M2 = 0;
                    }
                    else
                    {
                        FUN_30BA8();
                    }
                    id = 0;
                    flags |= 768u;
                    GameManager.instance.FUN_30080(GameManager.instance.DAT_10C8, this);
                    num = Utilities.FUN_29A9C(GameManager.instance.DAT_10C8);
                    if (15 < num)
                    {
                        VigObject vObject = GameManager.instance.DAT_10C8[0].vObject;
                        if (vObject.GetType().IsSubclassOf(typeof(VigObject)))
                        {
                            vObject.UpdateW(2, 0);
                        }
                    }
                    if ((flags & 0x20000000) == 0)
                    {
                        return 0u;
                    }
                    break;
                }
        }
        GameManager.instance.FUN_30CB0(this, 120);
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 != 2 && 2 < arg1)
        {
            switch (arg1)
            {
                default:
                    return 0u;
                case 8:
                    {
                        if (DAT_98 != null)
                        {
                            DAT_98.CreateBurstFire(chain: true);
                        }
                        GameManager.instance.FUN_300B8(GameManager.instance.DAT_10C8, this);
                        int param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 65, screen);
                        LevelManager.instance.FUN_4DE54(screen, 39);
                        LevelManager.instance.FUN_309C8(this, 0);
                        return uint.MaxValue;
                    }
                case 3:
                    break;
            }
        }
        GameManager.instance.FUN_30CB0(this, 120);
        return 0u;
    }

    public int FUN_46D70()
    {
        screen.x += physics1.Z;
        screen.y += physics1.W;
        screen.z += physics2.X;
        physics1.Z -= physics1.Z >> 4;
        physics1.W -= physics1.W >> 4;
        physics2.X -= physics2.X >> 4;
        vTransform.position.x = screen.x;
        vTransform.position.y = screen.y;
        vTransform.position.z = screen.z;
        physics1.W += 56;
        Vector3Int normalVector = default(Vector3Int);
        int num = FUN_2CFBC(screen, ref normalVector);
        if (vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < num)
        {
            num = GameManager.instance.DAT_DB0;
        }
        int result = 0;
        if (num < screen.y)
        {
            uint num2 = GameManager.instance.FUN_1E478(screen);
            screen.y = num;
            result = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E098(result, GameManager.instance.DAT_C2C, 55, (uint)((int)(num2 >> (physics2.M2 & 0x1F)) & ((1073758208 >> (physics2.M2 & 0x1F)) - 65537)));
            physics2.M2++;
            vTransform.rotation = Utilities.FUN_2A5EC(normalVector);
            result = 1;
            if (761 < physics1.W)
            {
                physics1.W = -physics1.W / 2;
                physics1.Z >>= 2;
                physics2.X >>= 2;
                result = 0;
            }
        }
        return result;
    }
}
