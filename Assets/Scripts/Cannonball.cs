using System.Collections.Generic;
using UnityEngine;

public class Cannonball : VigObject
{
    public VigObject DAT_90;

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
        sbyte tags = base.tags;
        if (tags == 1)
        {
            if (hit.object2.type != 3)
            {
                VigObject self = hit.self;
                if (self.type == 8 && self.GetType() == typeof(Bullet))
                {
                    return 0u;
                }
                Ballistic obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(140, typeof(Ballistic), 8u) as Ballistic;
                obj.flags = 52u;
                obj.screen = screen;
                obj.FUN_3066C();
                LevelManager.instance.FUN_4DE54(screen, 42);
                int param = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 64, vTransform.position);
                if (self.type == 2)
                {
                    Vector3Int v = new Vector3Int(physics1.Z * 96, physics1.W * 96, physics2.X * 96);
                    self.FUN_2B370(v, vTransform.position);
                    self.physics2.Z <<= 4;
                    self.physics1.Y = -292864;
                    self.physics2.X <<= 4;
                    if (self.id < 0)
                    {
                        GameManager.instance.FUN_15B00(~self.id, byte.MaxValue, 8, 32);
                    }
                }
                GameManager.instance.FUN_309A0(this);
                return uint.MaxValue;
            }
        }
        else
        {
            if (tags < 2)
            {
                if (tags != 0)
                {
                    return 0u;
                }
                return FUN_42638(hit, 37, 66);
            }
            if (tags != 2)
            {
                return 0u;
            }
            int num = 66;
            if (hit.object2.type != 3)
            {
                VigObject vigObject = null;
                VigObject self2 = hit.self;
                if (self2.type == 8)
                {
                    if (self2.GetType() == typeof(Bullet))
                    {
                        return 0u;
                    }
                    if (self2.GetType() == typeof(StarPower2))
                    {
                        return 0u;
                    }
                }
                int num2 = 20480000;
                int num3;
                if (self2.type == 2)
                {
                    Vehicle vehicle = (Vehicle)self2;
                    num3 = (maxHalfHealth << 11) / vehicle.DAT_A6;
                    int num4 = physics1.Z * num3;
                    maxHalfHealth = (ushort)(maxHalfHealth * 3 >> 2);
                    Vector3Int v2 = default(Vector3Int);
                    if (num4 < -524288)
                    {
                        v2.x = -524288;
                    }
                    else
                    {
                        v2.x = 524288;
                        if (num4 < 524289)
                        {
                            v2.x = num4;
                        }
                    }
                    num4 = physics1.W * num3;
                    v2.y = -524288;
                    if (-524289 < num4)
                    {
                        v2.y = 524288;
                        if (num4 < 524289)
                        {
                            v2.y = num4;
                        }
                    }
                    num4 = physics2.X * num3;
                    v2.z = -524288;
                    if (-524289 < num4)
                    {
                        v2.z = 524288;
                        if (num4 < 524289)
                        {
                            v2.z = num4;
                        }
                    }
                    vehicle.FUN_2B370(v2, vTransform.position);
                    if (vehicle.id < 0)
                    {
                        GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 2, 128);
                    }
                    if (vehicle.shield != 0)
                    {
                        num = -1;
                    }
                }
                if (-1 < num)
                {
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, num, vTransform.position);
                }
                IDAT_74 = hit.object2.id;
                num3 = DAT_80.id;
                tags = (sbyte)((num3 >= 0) ? (-1) : GameManager.instance.DAT_1128[~num3]);
                List<VigTuple> worldObjs = GameManager.instance.worldObjs;
                for (int i = 0; i < worldObjs.Count; i++)
                {
                    VigObject vObject = worldObjs[i].vObject;
                    VigObject self = vigObject;
                    int num5 = num2;
                    if (vObject.type != 2 || (vObject.flags & 0x4000) == 0)
                    {
                        vigObject = self;
                        num2 = num5;
                    }
                    else if ((num3 = vObject.id) != IDAT_74 && (0 < num3 || tags != GameManager.instance.DAT_1128[~num3]))
                    {
                        num5 = Utilities.FUN_29F6C(vObject.vTransform.position, vTransform.position);
                        self = vObject;
                        if (num5 < num2)
                        {
                            vigObject = self;
                            num2 = num5;
                        }
                    }
                }
                if (vigObject != null)
                {
                    Vector3Int vout = new Vector3Int(vigObject.screen.x - vTransform.position.x, vigObject.screen.y - vTransform.position.y, vigObject.screen.z - vTransform.position.z);
                    Utilities.FUN_2A098(vout, out vout);
                    physics1.Z = vout.x * 6;
                    physics1.W = vout.y * 6;
                    physics2.X = vout.z * 6;
                    flags |= 536870912u;
                }
            }
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 2)
        {
            LevelManager.instance.FUN_4DE54(screen, 39);
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 66, screen);
            LevelManager.instance.FUN_309C8(this, 1);
            return uint.MaxValue;
        }
        if (arg1 < 3)
        {
            if (arg1 != 0)
            {
                return 0u;
            }
            screen.x += physics1.Z;
            screen.y += physics1.W;
            screen.z += physics2.X;
            vTransform.position = screen;
            physics1.W += 56;
            int num = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
            if (screen.y <= num)
            {
                return 0u;
            }
            if (tags != 2)
            {
                screen.y = num;
                LevelManager.instance.FUN_4DE54(screen, 39);
                int param = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 66, screen);
                LevelManager.instance.FUN_309C8(this, 1);
                uint num2 = uint.MaxValue;
            }
            else
            {
                Vector3Int vector3Int = Utilities.VectorNormal(GameManager.instance.terrain.FUN_1B998((uint)screen.x, (uint)screen.z));
                screen.y = num;
                num = vector3Int.x * physics1.Z + vector3Int.y * physics1.W + vector3Int.z * physics2.X;
                if (num < 0)
                {
                    num += 2047;
                }
                num >>= 11;
                if (-1 < num)
                {
                    return 0u;
                }
                int num3 = num * vector3Int.x;
                if (num3 < 0)
                {
                    num3 += 4095;
                }
                physics1.Z -= num3 >> 12;
                num3 = num * vector3Int.y;
                if (num3 < 0)
                {
                    num3 += 4095;
                }
                physics1.W -= num3 >> 12;
                num *= vector3Int.z;
                if (num < 0)
                {
                    num += 4095;
                }
                physics2.X -= num >> 12;
            }
        }
        else if (arg1 != 3)
        {
            return 0u;
        }
        return 0u;
    }
}
