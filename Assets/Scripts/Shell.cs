using UnityEngine;

public class Shell : VigObject
{
    public bool cancel;

    private bool newAim;

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
        if (hit.object2.type == 3)
        {
            return 0u;
        }
        sbyte tags = base.tags;
        VigObject self = hit.self;
        if (tags != 0 && self.type == 8 && self.GetType() == typeof(Bullet))
        {
            return 0u;
        }
        if (tags == 1)
        {
            LevelManager.instance.FUN_4DE54(screen, 140);
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 64, vTransform.position);
            if (self.type == 2)
            {
                Vehicle vehicle = (Vehicle)self;
                if (vehicle.wheelsType == _WHEELS.Air)
                {
                    vehicle.physics1.Y = -585856;
                    vehicle.physics2.Z = 156000;
                }
                else
                {
                    vehicle.physics1.Y = -585856;
                    vehicle.physics2.Z = 52000;
                }
                vehicle.flip += 10;
                if (vehicle.shield == 0)
                {
                    vehicle.FUN_39BC4();
                }
                if (vehicle.id < 0)
                {
                    GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 2, 128);
                }
            }
        }
        else
        {
            if (tags < 2)
            {
                if (tags == 0)
                {
                    return FUN_42638(hit, 37, 66);
                }
                return 0u;
            }
            switch (tags)
            {
                case 2:
                    {
                        UIManager.instance.FUN_4E414(screen, new Color32(128, 0, 0, 8));
                        Particle2 particle;
                        if (hit.self.type == 2 && (hit.self.flags & 0x10000000) != 0)
                        {
                            particle = LevelManager.instance.FUN_4E128(screen, 53, 0);
                            Utilities.ParentChildren(particle, particle);
                            particle.FUN_2D114(particle.screen, ref particle.vTransform);
                            particle.flags |= 16u;
                            int num = 131072;
                            if (((Vehicle)DAT_80).doubleDamage != 0)
                            {
                                num = 262144;
                            }
                            GameManager.instance.terrain.FUN_45B00(screen.x, screen.z, num, maxHalfHealth << 8);
                            return FUN_42638(hit, 37, 66);
                        }
                        particle = LevelManager.instance.FUN_4E128(screen, 79, 200);
                        Utilities.ParentChildren(particle, particle);
                        int param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 66, screen);
                        break;
                    }
                default:
                    return 0u;
                case 3:
                    {
                        LevelManager.instance.FUN_4DE54(screen, 141);
                        LevelManager.instance.FUN_4DE54(screen, 42);
                        int param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 64, vTransform.position);
                        if (self.type != 2)
                        {
                            break;
                        }
                        Vehicle vehicle = (Vehicle)self;
                        vehicle.physics1.Y = 1171840;
                        int num = 0;
                        if (vehicle.shield != 0)
                        {
                            break;
                        }
                        if (vehicle.wheelsType == _WHEELS.Ground)
                        {
                            do
                            {
                                if (vehicle.wheels[num] != null)
                                {
                                    vehicle.FUN_3968C(vehicle.wheels[num]);
                                }
                                num++;
                            }
                            while (num < 6);
                        }
                        else if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || vehicle.id == -1)
                        {
                            vehicle.FUN_3E32C(_WHEELS.Ground, 0);
                            if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                            {
                                //ClientSend.Pickup(16, 0, 0);
                            }
                        }
                        //else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
                        else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && vehicle.id > 0)
                        {
                            vehicle.FUN_3E32C(_WHEELS.Ground, 0);
                            //ClientSend.PickupAI(vehicle.id, 16, 0, 0);
                        }
                        break;
                    }
            }
        }
        GameManager.instance.FUN_309A0(this);
        return uint.MaxValue;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        int num4;
        if (arg1 < 4)
        {
            if (arg1 == 1)
            {
                physics2.M4 = 3;
                if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                {
                    physics2.M4 = 0;
                    newAim = true;
                }
            }
            if (arg1 != 0)
            {
                return 0u;
            }
            VigObject vigObject;
            if (physics2.M2 < 20)
            {
                vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C((ushort)DAT_1A, typeof(VigObject), 8u);
                vigObject.vTransform.rotation.SetValue32(0, 4096);
                vigObject.vTransform.rotation.SetValue32(1, 0);
                vigObject.vTransform.rotation.SetValue32(2, 4096);
                vigObject.vTransform.rotation.SetValue32(3, 0);
                vigObject.vTransform.rotation.SetValue32(4, 4096);
                vigObject.vTransform.position = new Vector3Int(0, 0, 0);
                vigObject.flags |= 1040u;
                vigObject.FUN_2FBC8((ushort)((short)GameManager.instance.timer * 2 - DAT_4A));
                Utilities.FUN_2CC9C(this, vigObject);
                vigObject.transform.parent = base.transform;
                physics2.M2++;
            }
            vigObject = child2;
            VigObject child = child2.child;
            while (child != null)
            {
                vigObject.vTransform.position.x = child.vTransform.position.x - physics1.Z;
                vigObject.vTransform.position.y = child.vTransform.position.y - physics1.W;
                vigObject.vTransform.position.z = child.vTransform.position.z - physics2.X;
                vigObject = child;
                child = child.child;
            }
            vigObject.vTransform.position.x = -physics1.Z;
            vigObject.vTransform.position.y = -physics1.W;
            vigObject.vTransform.position.z = -physics2.X;
            screen.x += physics1.Z;
            screen.y += physics1.W;
            screen.z += physics2.X;
            vTransform.position = screen;
            if ((uint)(physics1.W + 56) < 56u)
            {
                GameManager.instance.FUN_1E580(DAT_18, GameManager.instance.DAT_C2C, 58, screen);
                if (DAT_84.id == id || ((Vehicle)DAT_84).state == _VEHICLE_TYPE.Collector)
                {
                    id = 0;
                }
                flags &= 4294967263u;
            }
            vigObject = DAT_84;
            physics1.W += 56;
            physics2.M5 = physics2.M4;
            if (newAim)
            {
                if (physics1.W > 3052)
                {
                    physics1.W = 3052;
                }
                else
                {
                    physics2.M5 = 5;
                }
            }
            if (vigObject == DAT_80 && !cancel)
            {
                Vehicle vehicle = (Vehicle)DAT_84;
                Vector3Int vector3Int = Utilities.FUN_24148(vehicle.vTransform, vehicle.manualAim.vTransform.position);
                int x = vector3Int.x;
                int x2 = screen.x;
                int z = vector3Int.z;
                int z2 = screen.z;
                long num = (long)physics1.W * (long)physics1.W;
                uint num2 = (uint)((vector3Int.y - screen.y) * 112);
                uint num3 = (uint)((int)num + (int)num2);
                num4 = (int)((ulong)num >> 32) + ((int)num2 >> 31) + ((num3 < num2) ? 1 : 0);
                if (0 < num4 || (num4 == 0 && num3 != 0))
                {
                    int num5 = Utilities.FUN_2ABC4(num3, num4);
                    num5 -= physics1.W;
                    num4 = num5;
                    if (num5 < 0)
                    {
                        num4 = -num5;
                    }
                    if (256 < num4)
                    {
                        num4 = (x - x2) * 56 / num5 - physics1.Z;
                        if (num4 < 0)
                        {
                            num4 += 31;
                        }
                        physics1.Z += num4 >> (int)physics2.M5;
                        num4 = (z - z2) * 56 / num5 - physics2.X;
                        if (num4 < 0)
                        {
                            num4 += 31;
                        }
                        physics2.X += num4 >> (int)physics2.M5;
                        goto IL_06ca;
                    }
                }
                cancel = true;
            }
            else if (vigObject != null && !cancel)
            {
                if ((vigObject.flags & 0x4000000) == 0 || (((Vehicle)vigObject).DAT_F6 & 0xA00) != 0)
                {
                    int x = vigObject.screen.x;
                    int x2 = screen.x;
                    int z = vigObject.screen.z;
                    int z2 = screen.z;
                    long num6 = (long)physics1.W * (long)physics1.W;
                    uint num2 = (uint)((vigObject.screen.y - screen.y) * 112);
                    uint num3 = (uint)((int)num6 + (int)num2);
                    num4 = (int)((ulong)num6 >> 32) + ((int)num2 >> 31) + ((num3 < num2) ? 1 : 0);
                    if (0 < num4 || (num4 == 0 && num3 != 0))
                    {
                        int num5 = Utilities.FUN_2ABC4(num3, num4);
                        num5 -= physics1.W;
                        num4 = num5;
                        if (num5 < 0)
                        {
                            num4 = -num5;
                        }
                        if (256 < num4)
                        {
                            num4 = (x - x2) * 56 / num5 - physics1.Z;
                            if (num4 < 0)
                            {
                                num4 += 31;
                            }
                            physics1.Z += num4 >> (int)physics2.M5;
                            num4 = (z - z2) * 56 / num5 - physics2.X;
                            if (num4 < 0)
                            {
                                num4 += 31;
                            }
                            physics2.X += num4 >> (int)physics2.M5;
                            goto IL_06ca;
                        }
                    }
                }
                cancel = true;
            }
            goto IL_06ca;
        }
        return 0u;
    IL_06ca:
        FUN_2D1DC();
        num4 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
        if (screen.y <= num4)
        {
            return 0u;
        }
        sbyte tags = base.tags;
        if (tags == 2)
        {
            Particle2 particle = LevelManager.instance.FUN_4E128(screen, 53, maxHalfHealth);
            Utilities.ParentChildren(particle, particle);
            particle.flags |= 16u;
            GameManager.instance.FUN_1E628(DAT_18, GameManager.instance.DAT_C2C, 66, screen);
            int z = 131072;
            if (((Vehicle)DAT_80).doubleDamage != 0)
            {
                z = 262144;
            }
            GameManager.instance.terrain.FUN_45B00(screen.x, screen.z, z, maxHalfHealth << 7);
            Particle1 particle2 = LevelManager.instance.FUN_4DE54(screen, 39);
            Utilities.ParentChildren(particle2, particle2);
            UIManager.instance.FUN_4E414(screen, new Color32(128, 0, 0, 8));
        }
        else
        {
            if (tags < 3)
            {
                if (tags < 0)
                {
                    return 0u;
                }
            }
            else if (tags != 3)
            {
                return 0u;
            }
            Particle1 particle2 = LevelManager.instance.FUN_4DE54(screen, 39);
            Utilities.ParentChildren(particle2, particle2);
            GameManager.instance.FUN_1E628(DAT_18, GameManager.instance.DAT_C2C, 66, screen);
        }
        LevelManager.instance.FUN_309C8(this, 1);
        return uint.MaxValue;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 != 10)
        {
            return 0u;
        }
        if (DAT_84 == arg2)
        {
            DAT_84 = DAT_80;
            return 0u;
        }
        return 0u;
    }
}
