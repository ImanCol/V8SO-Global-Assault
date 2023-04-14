using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _ROCKET_TYPE
{
    Rocket, //FUN_430F8
    Bastion, //FUN_42D18
    RoadRunner //FUN_43024
}

public class Rocket : VigObject
{
    public _ROCKET_TYPE state;

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
            case _ROCKET_TYPE.Rocket:
                if ((flags & 0x1000000) != 0)
                {
                    VigObject self = hit.self;
                    if (self.type == 8 && self.GetType() == typeof(Bullet))
                    {
                        return 0u;
                    }
                    if (self.type == 2)
                    {
                        Vector3Int v = new Vector3Int(vTransform.position.x - self.vTransform.position.x, vTransform.position.y - self.vTransform.position.y, vTransform.position.z - self.vTransform.position.z);
                        Utilities.FUN_243B4(self.vTransform.rotation);
                        Vector3Int vector3Int = Utilities.FUN_23F7C(new Vector3Int(physics1.Z, physics1.W, physics2.X));
                        physics1.Z = vector3Int.x;
                        physics1.W = vector3Int.y;
                        physics2.X = vector3Int.z;
                        vTransform.position = Utilities.FUN_23F7C(v);
                        vTransform.rotation = Utilities.FUN_247F4(vTransform.rotation);
                        GameManager.instance.FUN_300B8(GameManager.instance.worldObjs, this);
                        state = _ROCKET_TYPE.RoadRunner;
                        physics2.M2 = 360;
                        Utilities.FUN_2CC48(self, this);
                        base.transform.parent = self.transform;
                        return 1u;
                    }
                }
                return FUN_42638(hit, 33, 63);
            case _ROCKET_TYPE.Bastion:
                {
                    VigObject self = hit.self;
                    if (self.type == 8 && self.GetType() == typeof(Bullet))
                    {
                        return 0u;
                    }
                    return FUN_42638(hit, 33, 63);
                }
            default:
                return 0u;
        }
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (state)
        {
            case _ROCKET_TYPE.Rocket:
                switch (arg1)
                {
                    case 2:
                        vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
                        state = _ROCKET_TYPE.Bastion;
                        break;
                    default:
                        return 0u;
                    case 0:
                        {
                            Matrix3x3 rotation = vTransform.rotation;
                            screen.x += physics1.Z;
                            screen.y += physics1.W;
                            screen.z += physics2.X;
                            vTransform.position = screen;
                            FUN_24700(0, 0, 512);
                            if ((physics2.M2 & 0x1F) == 0)
                            {
                                vTransform.rotation = Utilities.MatrixNormal(rotation);
                            }
                            short m2 = physics2.M2;
                            physics2.M2--;
                            if (m2 == 1)
                            {
                                GameManager.instance.FUN_309A0(this);
                                return uint.MaxValue;
                            }
                            if (GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z) <= screen.y)
                            {
                                int param = GameManager.instance.FUN_1DD9C();
                                GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 63, screen);
                                LevelManager.instance.FUN_4DE54(screen, 33);
                                LevelManager.instance.FUN_309C8(this, 1);
                                return uint.MaxValue;
                            }
                            break;
                        }
                }
                return 0u;
            case _ROCKET_TYPE.Bastion:
                if (arg1 == 0)
                {
                    screen.x += physics1.Z;
                    screen.y += physics1.W;
                    screen.z += physics2.X;
                    vTransform.position = screen;
                    VigObject param2 = DAT_84;
                    int param;
                    if (param2 != null)
                    {
                        Vector3Int vout = new Vector3Int(param2.screen.x - screen.x, param2.screen.y - screen.y, param2.screen.z - screen.z);
                        Utilities.FUN_2A098(vout, out vout);
                        if (physics2.M2 < 211)
                        {
                            physics1.Z = physics1.Z / 2 + vout.x * 4;
                            physics1.W = physics1.W / 2 + vout.y * 4;
                            physics2.X = physics2.X / 2 + vout.z * 4;
                        }
                        else
                        {
                            param = physics1.Z * 15;
                            if (param < 0)
                            {
                                param += 15;
                            }
                            int num = physics1.W * 15;
                            physics1.Z = (param >> 4) + vout.x / 2;
                            if (num < 0)
                            {
                                num += 15;
                            }
                            param = physics2.X * 15;
                            physics1.W = (num >> 4) + vout.y / 2;
                            if (param < 0)
                            {
                                param += 15;
                            }
                            physics2.X = (param >> 4) + vout.z / 2;
                        }
                        vout = new Vector3Int(physics1.Z, physics1.W, physics2.X);
                        Utilities.FUN_29FC8(vout, out Vector3Int vout2);
                        vTransform.rotation = Utilities.FUN_2A724(vout2);
                    }
                    ushort num2 = (ushort)(physics2.M2 - 1);
                    physics2.M2 = (short)num2;
                    if (num2 == 0 || ((num2 & 0xF) == 0 && DAT_84 != null && GameManager.instance.FUN_30134(GameManager.instance.worldObjs, DAT_84) == null))
                    {
                        GameManager.instance.FUN_309A0(this);
                        return uint.MaxValue;
                    }
                    param = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
                    if (screen.y < param)
                    {
                        return 0u;
                    }
                    int param3 = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 63, screen);
                    LevelManager.instance.FUN_4DE54(screen, 33);
                    LevelManager.instance.FUN_309C8(this, 1);
                    return uint.MaxValue;
                }
                return 0u;
            case _ROCKET_TYPE.RoadRunner:
                if (arg1 == 0)
                {
                    Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
                    if ((vehicle.flags & 0x4000000) == 0)
                    {
                        vehicle.FUN_2B1FC(new Vector3Int(physics1.Z, physics1.W, physics2.X), vTransform.position);
                    }
                    short m = physics2.M2;
                    physics2.M2--;
                    if (m == 1)
                    {
                        int param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 63, screen);
                        LevelManager.instance.FUN_4DE54(vTransform.position, 34);
                        vehicle.FUN_3A020(-40, vTransform.position, param3: true);
                        VigObject param2 = FUN_2CCBC();
                        GameManager.instance.FUN_307CC(param2);
                        return uint.MaxValue;
                    }
                }
                return 0u;
            default:
                return 0u;
        }
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 != 2 && 2 < arg1)
        {
            return 0u;
        }
        return 0u;
    }
}
