using System.Collections.Generic;
using UnityEngine;

public class Hovermine : Mine
{
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
        Vector3Int v = new Vector3Int(0, -131072, 0);
        VigObject self = hit.self;
        if (!(self.GetType() == typeof(OilSlick2)))
        {
            if (hit.object2.type == 3)
            {
                return 0u;
            }
            //if (self.GetType() == typeof(Tornado) || self.GetType() == typeof(Bearhug))
            if (self.GetType() == typeof(Tornado) || self.GetType() == typeof(Brearhug))
            {
                return 0u;
            }
            if (self.type == 0)
            {
                return 1u;
            }
            if (self.type == 3)
            {
                return 0u;
            }
            if (self.type == 2)
            {
                Vehicle vehicle = (Vehicle)self;
                vehicle.FUN_2B370(v, screen);
                if (vehicle.id < 0)
                {
                    GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 4, 64);
                }
            }
        }
        GameManager.instance.FUN_300B8(GameManager.instance.DAT_10C8, this);
        int param = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 65, vTransform.position);
        LevelManager.instance.FUN_4DE54(screen, 39);
        LevelManager.instance.FUN_309C8(this, 0);
        return uint.MaxValue;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        new Vector3Int(0, -131072, 0);
        if (arg1 != 2)
        {
            if (arg1 < 3)
            {
                if (arg1 != 0)
                {
                    return 0u;
                }
                short num = (short)(physics2.M3 + 1);
                physics2.M3 = num;
                int num4;
                if (30 < num)
                {
                    VigObject vigObject = null;
                    physics2.M3 = 0;
                    byte b = ++DAT_19;
                    int num2 = 2048000;
                    if (10 < b && id < 0)
                    {
                        id = 0;
                    }
                    List<VigTuple> worldObjs = GameManager.instance.worldObjs;
                    for (int i = 0; i < worldObjs.Count; i++)
                    {
                        VigObject vObject = worldObjs[i].vObject;
                        int num3;
                        if ((vObject.id <= 0 || id <= 0) && vObject.type == 2 && (vObject.flags & 0x4000) != 0 && vObject.id != id && vObject != DAT_80 && (num3 = Utilities.FUN_29F6C(vObject.vTransform.position, vTransform.position)) < num2)
                        {
                            vigObject = vObject;
                            num2 = num3;
                        }
                    }
                    DAT_84 = vigObject;
                    if (vigObject == null)
                    {
                        physics1.Z = 0;
                        physics1.W = 56;
                        physics2.X = 0;
                    }
                    else
                    {
                        Vector3Int vout = new Vector3Int(vigObject.vTransform.position.x - vTransform.position.x, vigObject.vTransform.position.y - vTransform.position.y, vigObject.vTransform.position.z - vTransform.position.z);
                        Utilities.FUN_2A098(vout, out vout);
                        num4 = vout.x * 2288;
                        if (num4 < 0)
                        {
                            num4 += 4095;
                        }
                        physics1.Z = num4 >> 11;
                        num4 = vout.y * 2288;
                        if (num4 < 0)
                        {
                            num4 += 4095;
                        }
                        physics1.W = num4 >> 11;
                        num4 = vout.z * 2288;
                        if (num4 < 0)
                        {
                            num4 += 4095;
                        }
                        physics2.X = num4 >> 11;
                    }
                }
                screen.x += physics1.Z;
                screen.y += physics1.W;
                screen.z += physics2.X;
                physics1.W += 56;
                num4 = screen.y + physics1.W;
                screen.y = num4;
                FUN_2D114(screen, ref vTransform);
                if (vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 + 10240 < vTransform.position.y)
                {
                    vTransform.position.y = GameManager.instance.DAT_DB0;
                }
                if (vTransform.position.y < num4)
                {
                    physics1.W = 0;
                    int num2 = vTransform.position.y - physics1.W;
                    screen.y = num2;
                    num4 = Utilities.DAT_65C90[(physics2.M2 & 0xFFF) * 2] * 5120;
                    if (num4 < 0)
                    {
                        num4 += 4095;
                    }
                    vTransform.position.y = num2 + (num4 >> 12);
                }
                else
                {
                    num4 = Utilities.DAT_65C90[(physics2.M2 & 0xFFF) * 2] * 5120;
                    if (num4 < 0)
                    {
                        num4 += 4095;
                    }
                    vTransform.position.y = screen.y + (num4 >> 12) - physics1.W;
                }
                physics2.M2 += 34;
                return 0u;
            }
            return 0u;
        }
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
        }
        GameManager.instance.FUN_30CB0(this, 120);
        return 0u;
    }
}
