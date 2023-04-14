using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _MISSILE_TYPE
{
    Shell, //FUN_441D4
    Projectile,  //FUN_438F4
    Halo //FUN_43E84
}

public class Missile : VigObject
{
    public _MISSILE_TYPE state;

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
            case _MISSILE_TYPE.Shell:
                return FUN_42638(hit, 37, 64);
            case _MISSILE_TYPE.Projectile:
                {
                    if ((GameManager.instance.DAT_40 & 0x400) == 0)
                    {
                        return FUN_42638(hit, 37, 64);
                    }
                    Particle2 particle = LevelManager.instance.FUN_4E128(screen, 79, 40);
                    particle.vr = new Vector3Int(2048, 0, 0);
                    particle.ApplyTransformation();
                    particle.vTransform.rotation = Utilities.MulMatrix(vTransform.rotation, particle.vTransform.rotation);
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 63, screen);
                    GameManager.instance.FUN_309A0(this);
                    return uint.MaxValue;
                }
            case _MISSILE_TYPE.Halo:
                if (hit.self.type != 8)
                {
                    return FUN_42638(hit, 37, 64);
                }
                return 0u;
            default:
                return 0u;
        }
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (state)
        {
            case _MISSILE_TYPE.Shell:
                if (arg1 < 4)
                {
                    if (arg1 != 0)
                    {
                        return 0u;
                    }
                    physics1.W += 56;
                    screen.x += physics1.Z;
                    screen.y += physics1.W;
                    screen.z += physics2.X;
                    vTransform.position = screen;
                    if ((flags & 0x1000000) != 0)
                    {
                        physics1.Z = physics1.Z * 3968 >> 12;
                        physics1.W = physics1.W * 3968 >> 12;
                        physics2.X = physics2.X * 3968 >> 12;
                    }
                }
                else if (arg1 == 4)
                {
                    DAT_84.flags &= 4160749567u;
                }
                return 0u;
            case _MISSILE_TYPE.Projectile:
                {
                    if (3 < arg1)
                    {
                        if (arg1 == 4 && (flags & 0x1000000) != 0)
                        {
                            DAT_84.flags &= 4160749567u;
                        }
                        return 0u;
                    }
                    if (arg1 != 0)
                    {
                        return 0u;
                    }
                    int num4;
                    int num3;
                    if (DAT_84 == DAT_80)
                    {
                        num4 = 15258;
                    }
                    else
                    {
                        num3 = Utilities.FUN_29F6C(vTransform.position, DAT_84.screen);
                        num4 = 15258;
                        if (num3 < 262144)
                        {
                            num4 = physics2.Z;
                        }
                    }
                    int num = vTransform.rotation.V02 * num4;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    num = (num >> 12) - physics1.Z;
                    if (num < 0)
                    {
                        num += 15;
                    }
                    num >>= 4;
                    num3 = -256;
                    if (-257 < num)
                    {
                        num3 = 256;
                        if (num < 257)
                        {
                            num3 = num;
                        }
                    }
                    num = vTransform.rotation.V12 * num4;
                    physics1.Z += num3;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    num = (num >> 12) - physics1.W;
                    if (num < 0)
                    {
                        num += 7;
                    }
                    physics1.W += num >> 3;
                    num = vTransform.rotation.V22 * num4;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    num = (num >> 12) - physics2.X;
                    if (num < 0)
                    {
                        num += 15;
                    }
                    num >>= 4;
                    num3 = -256;
                    if (-257 < num)
                    {
                        num3 = 256;
                        if (num < 257)
                        {
                            num3 = num;
                        }
                    }
                    physics2.X += num3;
                    screen.x += physics1.Z;
                    screen.y += physics1.W;
                    screen.z += physics2.X;
                    num = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
                    int param;
                    if (num < screen.y)
                    {
                        if ((GameManager.instance.DAT_40 & 0x400) == 0)
                        {
                            param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 64, screen);
                            LevelManager.instance.FUN_4DE54(screen, 33);
                        }
                        else
                        {
                            Particle2 particle2 = LevelManager.instance.FUN_4E128(screen, 79, 40);
                            particle2.FUN_2D114(particle2.screen, ref particle2.vTransform);
                            param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 63, screen);
                        }
                        LevelManager.instance.FUN_309C8(this, 1);
                        return uint.MaxValue;
                    }
                    vTransform.position = screen;
                    Vector3Int vector3Int = default(Vector3Int);
                    if (DAT_84 == DAT_80)
                    {
                        Vehicle vehicle = (Vehicle)DAT_84;
                        Vector3Int vector3Int2 = Utilities.FUN_24148(vehicle.vTransform, vehicle.manualAim.vTransform.position);
                        vector3Int.x = vector3Int2.x - screen.x;
                        vector3Int.y = vector3Int2.y - screen.y + DAT_84.vCollider.reader.ReadInt32(8) / 2;
                        vector3Int.z = vector3Int2.z - screen.z;
                    }
                    else
                    {
                        vector3Int.x = DAT_84.screen.x - screen.x;
                        vector3Int.y = DAT_84.screen.y - screen.y + DAT_84.vCollider.reader.ReadInt32(8) / 2;
                        vector3Int.z = DAT_84.screen.z - screen.z;
                    }
                    num = GameManager.instance.terrain.FUN_1B750((uint)(screen.x + physics1.Z * 16), (uint)(screen.z + physics2.X * 16));
                    num -= screen.y + 20480;
                    if (num < vector3Int.y)
                    {
                        vector3Int.y = num;
                    }
                    vector3Int = Utilities.FUN_2426C(vTransform.rotation, new Matrix2x4(vector3Int.x, vector3Int.y, vector3Int.z, 0));
                    long num5 = Utilities.Ratan2(-vector3Int.y, vector3Int.z);
                    long num6 = -256L;
                    if (-257 < num5)
                    {
                        num6 = 256L;
                        if (num5 < 257)
                        {
                            num6 = num5;
                        }
                    }
                    short y = -256;
                    if (0 < vector3Int.x)
                    {
                        y = 256;
                    }
                    FUN_24700((short)num6, y, 0);
                    if (((GameManager.instance.DAT_28 - DAT_19) & 0x1F) == 0)
                    {
                        vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
                    }
                    if (GameManager.instance.DAT_36 && ((ushort)physics2.M2 & 3) == 0)
                    {
                        Particle1 particle3 = LevelManager.instance.FUN_4DE54(screen, 7);
                        particle3.flags |= 1024u;
                        particle3.vr.z = physics2.M2 * 96;
                        particle3.ApplyTransformation();
                    }
                    short m2 = physics2.M2;
                    physics2.M2--;
                    if (m2 != 1)
                    {
                        return 0u;
                    }
                    param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 64, screen);
                    LevelManager.instance.FUN_4DE54(screen, 37);
                    GameManager.instance.FUN_309A0(this);
                    return uint.MaxValue;
                }
            case _MISSILE_TYPE.Halo:
                if (arg1 < 4)
                {
                    if (arg1 != 0)
                    {
                        return 0u;
                    }
                    int num = vTransform.rotation.V02 * 15258;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    num = (num >> 12) - physics1.Z;
                    if (num < 0)
                    {
                        num += 15;
                    }
                    int num2 = 256;
                    if (num >> 4 < 256)
                    {
                        num2 = num >> 4;
                    }
                    num = -256;
                    if (-256 < num2)
                    {
                        num = num2;
                    }
                    num = physics1.Z + num;
                    physics1.Z = num;
                    num2 = vTransform.rotation.V22 * 15258;
                    screen.x += num;
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    num = (num2 >> 12) - physics2.X;
                    if (num < 0)
                    {
                        num += 15;
                    }
                    num2 = 256;
                    if (num >> 4 < 256)
                    {
                        num2 = num >> 4;
                    }
                    num = -256;
                    if (-256 < num2)
                    {
                        num = num2;
                    }
                    num = physics2.X + num;
                    physics2.X = num;
                    screen.z += num;
                    num = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
                    if (num < screen.y)
                    {
                        int param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 64, screen);
                        LevelManager.instance.FUN_4DE54(screen, 33);
                        LevelManager.instance.FUN_309C8(this, 1);
                        return uint.MaxValue;
                    }
                    vTransform.position = screen;
                    FUN_24700(0, 256, 0);
                    if ((-DAT_19 & 0x1F) == 0)
                    {
                        vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
                    }
                    if ((physics2.M2 & 3) == 0)
                    {
                        Particle1 particle = LevelManager.instance.FUN_4DE54(screen, 21);
                        particle.flags |= 1024u;
                        particle.vr.z = physics2.M2 * 96;
                        particle.ApplyTransformation();
                    }
                    VigObject dAT_ = DAT_84;
                    if ((dAT_.flags & 0x4000000) == 0)
                    {
                        if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                        {
                            int num3 = Utilities.FUN_29F6C(vTransform.position, dAT_.vTransform.position);
                            int num4 = 15258;
                            if (num3 < 1048576)
                            {
                                dAT_.screen = screen;
                                dAT_.flags |= 134217728u;
                            }
                            else
                            {
                                dAT_.flags &= 4160749567u;
                            }
                        }
                        else
                        {
                            dAT_.screen = screen;
                        }
                    }
                    short m = physics2.M2;
                    physics2.M2--;
                    if (m == 1)
                    {
                        int param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 64, screen);
                        LevelManager.instance.FUN_4DE54(screen, 37);
                        GameManager.instance.FUN_309A0(this);
                        return uint.MaxValue;
                    }
                }
                else
                {
                    if (arg1 != 4)
                    {
                        return 0u;
                    }
                    if ((flags & 0x1000000) != 0)
                    {
                        DAT_84.flags &= 4160749567u;
                    }
                }
                break;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        switch (state)
        {
            case _MISSILE_TYPE.Shell:
                {
                    if (arg1 != 5)
                    {
                        return 0u;
                    }
                    GameManager.instance.FUN_1FEB8(vMesh);
                    GameManager.instance.FUN_2C4B4(child2);
                    uint num = 186u;
                    if ((base.flags & 0x1000000) != 0)
                    {
                        num = 198u;
                    }
                    FUN_2C344(vData, (ushort)num, 8u);
                    uint flags = base.flags;
                    base.flags |= 132u;
                    if ((flags & 0x1000000) == 0)
                    {
                        state = _MISSILE_TYPE.Projectile;
                    }
                    else
                    {
                        state = _MISSILE_TYPE.Halo;
                        DAT_84.flags |= 134217728u;
                    }
                    physics2.M2 = 480;
                    return 0u;
                }
            case _MISSILE_TYPE.Projectile:
                if (arg1 != 10)
                {
                    return 0u;
                }
                if (DAT_84 != arg2)
                {
                    return 0u;
                }
                DAT_84 = DAT_80;
                break;
        }
        return 0u;
    }
}
