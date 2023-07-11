using System.Collections.Generic;
using UnityEngine;

public class Blimp : VigObject
{
    public VigObject DAT_8C;

    public Vehicle DAT_90;

    public Vehicle.AI DAT_94;

    public short[] DAT_A4;

    public ushort DAT_A8;

    public short DAT_AA;

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
        sbyte tags;
        if (hit.self.type == 2 && hit.self.id < 0)
        {
            Vehicle vehicle = (Vehicle)hit.self;
            tags = base.tags;
            if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0 && tags == 3)
            {
                int num = Utilities.FUN_2A27C(vehicle.vTransform.rotation);
                num = (num - vr.y) * 1048576 >> 16;
                if (num < 0)
                {
                    num = -num;
                }
                if (num < 4096)
                {
                    VigCamera vCamera = vehicle.vCamera;
                    DAT_90 = vehicle;
                    vehicle.state = _VEHICLE_TYPE.Blimp;
                    vehicle.PDAT_78 = this;
                    vehicle.flags = (uint)(((int)vehicle.flags & -9) | 0x2000020);
                    vehicle.physics1.X = (screen.x - vehicle.vTransform.position.x) * 4;
                    vehicle.physics1.Y = (screen.y - vehicle.vTransform.position.y) * 4;
                    vehicle.physics1.Z = (screen.z - vehicle.vTransform.position.z) * 4;
                    vehicle.turning = 0;
                    GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
                    GameManager.instance.FUN_30CB0(vehicle, 32);
                    if (vCamera != null)
                    {
                        vCamera.FUN_4BDC4(new int[12]
                        {
                            vCamera.screen.x,
                            vCamera.screen.y,
                            vCamera.screen.z,
                            120,
                            vTransform.position.x + vTransform.rotation.V02 * -100,
                            vTransform.position.y - 204800,
                            vTransform.position.z + vTransform.rotation.V22 * -100,
                            0,
                            0,
                            0,
                            0,
                            0
                        });
                        vCamera.DAT_9C = 1024000;
                        DAT_AA = 0;
                        base.tags = 0;
                    }
                    int param = GameManager.instance.FUN_1DD9C();
                    int param2 = 1;
                    List<AudioClip> sndList = vData.sndList;
                    GameManager.instance.FUN_1E628(param, sndList, param2, screen);
                    return 0u;
                }
                tags = base.tags;
            }
        }
        else
        {
            tags = base.tags;
        }
        if (tags < 4)
        {
            if (hit.self.type == 8)
            {
                if (FUN_32B90(hit.self.maxHalfHealth))
                {
                    base.tags = 4;
                    FUN_117C(32768);
                    FUN_117C(32769);
                    RespawnBlimp();
                    return 0u;
                }
            }
            else if (hit.self.type != 3)
            {
                GameManager.instance.FUN_2F798(this, hit);
                int num = physics1.X * hit.normal1.x + physics1.Y * hit.normal1.y + physics1.Z * hit.normal1.z;
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
                physics1.X -= num2 >> 12;
                num2 = num * hit.normal1.y;
                if (num2 < 0)
                {
                    num2 += 4095;
                }
                physics1.Y -= num2 >> 12;
                num *= hit.normal1.z;
                if (num < 0)
                {
                    num += 4095;
                }
                physics1.Z -= num >> 12;
                int param = GameManager.instance.FUN_1DD9C();
                int param2 = 9;
                List<AudioClip> sndList = GameManager.instance.DAT_C2C;
                GameManager.instance.FUN_1E628(param, sndList, param2, screen);
                return 0u;
            }
        }
        else
        {
            if (4 < tags)
            {
                return 0u;
            }
            if (hit.self.type != 0)
            {
                return 0u;
            }
            if ((flags & 0x8000) != 0)
            {
                return 0u;
            }
            FUN_4DC94();
            base.tags = 5;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 0:
                {
                    screen.x += physics1.X;
                    screen.y += physics1.Y;
                    screen.z += physics1.Z;
                    int num;
                    int num3;
                    VigObject vigObject;
                    switch (((byte)tags + 1) * 16777216 >> 24)
                    {
                        case 1:
                            {
                                num3 = (int)GameManager.FUN_2AC5C();
                                vigObject = (DAT_8C = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (num3 << 3 >> 15) - 32));
                                short[] param3 = GameManager.instance.FUN_51ED4(vTransform.position, vigObject.screen, 70560u, 0u);
                                DAT_94.FUN_51BDC(param3);
                                tags = 1;
                                goto case 2;
                            }
                        case 2:
                            if (((GameManager.instance.DAT_28 - DAT_19) & 0xFF) == 0)
                            {
                                short[] param3 = GameManager.instance.FUN_51ED4(vTransform.position, DAT_8C.screen, 70560u, 0u);
                                DAT_94.FUN_51BDC(param3);
                            }
                            if (DAT_94.DAT_00 == 0)
                            {
                                DAT_94.DAT_08 = DAT_8C.screen.x;
                                DAT_94.DAT_0C = DAT_8C.screen.z;
                            }
                            num3 = DAT_94.FUN_51CFC(this, 262144);
                            if (DAT_94.DAT_00 < 0)
                            {
                                tags = 2;
                            }
                            num = (num3 - DAT_A8) * 1048576 >> 20;
                            num3 = -8;
                            if (-9 < num)
                            {
                                num3 = 8;
                                if (num < 9)
                                {
                                    num3 = num;
                                }
                            }
                            num3 = DAT_A8 + num3;
                            num = num3 * 65536 >> 16;
                            DAT_A8 = (ushort)num3;
                            if (num < 0)
                            {
                                num += 63;
                            }
                            vr.y += num >> 6;
                            goto case 0;
                        case 0:
                            if (-1 >= tags)
                            {
                                if (physics1.X < 0)
                                {
                                    if (screen.x >> 16 < DAT_A4[0])
                                    {
                                        goto IL_02b8;
                                    }
                                    if (physics1.Z < 0)
                                    {
                                        if (screen.z >> 16 < DAT_A4[1])
                                        {
                                            goto IL_02b8;
                                        }
                                    }
                                    else if (DAT_A4[1] + DAT_A4[3] < screen.z >> 16)
                                    {
                                        goto IL_02b8;
                                    }
                                }
                                else
                                {
                                    if (screen.x >> 16 > DAT_A4[0] + DAT_A4[2])
                                    {
                                        goto IL_0369;
                                    }
                                    if (physics1.Z < 0)
                                    {
                                        if (screen.z >> 16 < DAT_A4[1])
                                        {
                                            goto IL_0369;
                                        }
                                    }
                                    else if (DAT_A4[1] + DAT_A4[3] < screen.z >> 16)
                                    {
                                        goto IL_0369;
                                    }
                                }
                            }
                            goto IL_03ab;
                        case 3:
                            {
                                num = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
                                num -= screen.y + 20480;
                                int num2 = ((DAT_8C.vr.y - vr.y) * 1048576 >> 20) - (short)DAT_A8;
                                num3 = -8;
                                if (-9 < num2)
                                {
                                    num3 = 8;
                                    if (num2 < -9)
                                    {
                                        num3 = num2;
                                    }
                                }
                                num3 = DAT_A8 + num3;
                                num2 = num3 * 65536 >> 16;
                                DAT_A8 = (ushort)num3;
                                if (num2 < 0)
                                {
                                    num2 += 63;
                                }
                                num3 = -physics1.X;
                                vr.y += num2 >> 6;
                                if (0 < physics1.X)
                                {
                                    num3 += 15;
                                }
                                num3 >>= 4;
                                num2 = -64;
                                if (-65 < num3)
                                {
                                    num2 = 64;
                                    if (num3 < 65)
                                    {
                                        num2 = num3;
                                    }
                                }
                                num3 = -physics1.Z;
                                physics1.X += num2;
                                if (0 < physics1.Z)
                                {
                                    num3 += 15;
                                }
                                num3 >>= 4;
                                num2 = -64;
                                if (-65 < num3)
                                {
                                    num2 = 64;
                                    if (num3 < 65)
                                    {
                                        num2 = num3;
                                    }
                                }
                                physics1.Z += num2;
                                num3 = num;
                                if (num < 0)
                                {
                                    num3 = num + 15;
                                }
                                num2 = 762;
                                if (num3 >> 4 < 762)
                                {
                                    num2 = num3 >> 4;
                                }
                                num2 -= physics1.Y;
                                num3 = -64;
                                if (-65 < num2)
                                {
                                    num3 = 64;
                                    if (num2 < 65)
                                    {
                                        num3 = num2;
                                    }
                                }
                                physics1.Y += num3;
                                ApplyTransformation();
                                if (num < 409 && (short)DAT_A8 < 64)
                                {
                                    tags = 3;
                                    DAT_AA = 900;
                                    int param2 = GameManager.instance.FUN_1DD9C();
                                    GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 0, screen);
                                }
                                break;
                            }
                        case 4:
                            if (--DAT_AA == -1)
                            {
                                DAT_AA = 0;
                                tags = 0;
                            }
                            break;
                        case 5:
                            if (physics1.X < 0)
                            {
                                if (screen.x >> 16 < DAT_A4[0])
                                {
                                    goto IL_07e0;
                                }
                                if (physics1.Z < 0)
                                {
                                    if (screen.z >> 16 < DAT_A4[1])
                                    {
                                        physics1.Z = 0;
                                        goto IL_07ec;
                                    }
                                }
                                else if (DAT_A4[1] + DAT_A4[3] < screen.z >> 16)
                                {
                                    goto IL_07e0;
                                }
                            }
                            else
                            {
                                if (screen.x >> 16 > DAT_A4[0] + DAT_A4[2])
                                {
                                    goto IL_0873;
                                }
                                if (physics1.Z < 0)
                                {
                                    if (screen.z >> 16 < DAT_A4[1])
                                    {
                                        physics1.Z = 0;
                                        goto IL_087f;
                                    }
                                }
                                else if (DAT_A4[1] + DAT_A4[3] < screen.z >> 16)
                                {
                                    goto IL_0873;
                                }
                            }
                            goto IL_088b;
                        case 6:
                            {
                                if ((flags & 0x8000) == 0)
                                {
                                    GameManager.instance.FUN_1DE78(DAT_18);
                                    DAT_18 = 0;
                                    GameManager.instance.FUN_309A0(this);
                                }
                                break;
                            }
                        IL_0873:
                            physics1.Z = 0;
                            goto IL_087f;
                        IL_087f:
                            physics1.X = 0;
                            goto IL_088b;
                        IL_02b8:
                            vr.y += 16;
                            physics1.Z = -physics1.Z;
                            physics1.X = -physics1.X;
                            goto IL_03ab;
                        IL_03ab:
                            ApplyTransformation();
                            num3 = vTransform.rotation.V02 * 3051;
                            if (num3 < 0)
                            {
                                num3 += 4095;
                            }
                            num3 = (num3 >> 12) - physics1.X;
                            if (num3 < 0)
                            {
                                num3 += 15;
                            }
                            num3 >>= 4;
                            num = -64;
                            if (-65 < num3)
                            {
                                num = 64;
                                if (num3 < 65)
                                {
                                    num = num3;
                                }
                            }
                            num3 = vTransform.rotation.V22 * 3051;
                            physics1.X += num;
                            if (num3 < 0)
                            {
                                num3 += 4095;
                            }
                            num3 = (num3 >> 12) - physics1.Z;
                            if (num3 < 0)
                            {
                                num3 += 15;
                            }
                            num3 >>= 4;
                            num = -64;
                            if (-65 < num3)
                            {
                                num = 64;
                                if (num3 < 65)
                                {
                                    num = num3;
                                }
                            }
                            physics1.Z += num;
                            num3 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
                            num3 -= screen.y + 409600;
                            if (num3 < 0)
                            {
                                num3 += 15;
                            }
                            num = -762;
                            if (-762 < num3 >> 4)
                            {
                                num = num3 >> 4;
                            }
                            num -= physics1.Y;
                            num3 = -64;
                            if (-65 < num)
                            {
                                num3 = 64;
                                if (num < 65)
                                {
                                    num3 = num;
                                }
                            }
                            physics1.Y += num3;
                            break;
                        IL_07e0:
                            physics1.Z = 0;
                            goto IL_07ec;
                        IL_07ec:
                            physics1.X = 0;
                            goto IL_088b;
                        IL_088b:
                            if (-512 < vr.x)
                            {
                                vr.x -= 4;
                            }
                            ApplyTransformation();
                            num3 = vTransform.rotation.V02 * 3051;
                            if (num3 < 0)
                            {
                                num3 += 4095;
                            }
                            num3 = (num3 >> 12) - physics1.X;
                            if (num3 < 0)
                            {
                                num3 += 15;
                            }
                            num3 >>= 4;
                            num = -64;
                            if (-65 < num3)
                            {
                                num = 64;
                                if (num3 < 65)
                                {
                                    num = num3;
                                }
                            }
                            num3 = vTransform.rotation.V12 * 3051;
                            physics1.X += num;
                            if (num3 < 0)
                            {
                                num3 += 4095;
                            }
                            num3 = (num3 >> 12) - physics1.Y;
                            if (num3 < 0)
                            {
                                num3 += 15;
                            }
                            num3 >>= 4;
                            num = -64;
                            if (-65 < num3)
                            {
                                num = 64;
                                if (num3 < 65)
                                {
                                    num = num3;
                                }
                            }
                            num3 = vTransform.rotation.V22 * 3051;
                            physics1.Y += num;
                            if (num3 < 0)
                            {
                                num3 += 4095;
                            }
                            num3 = (num3 >> 12) - physics1.Z;
                            if (num3 < 0)
                            {
                                num3 += 15;
                            }
                            num3 >>= 4;
                            num = -64;
                            if (-65 < num3)
                            {
                                num = 64;
                                if (num3 < 65)
                                {
                                    num = num3;
                                }
                            }
                            physics1.Z += num;
                            num3 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
                            if (num3 < screen.y && (flags & 0x8000) == 0)
                            {
                                FUN_4DC94();
                                tags = 5;
                            }
                            break;
                        IL_0369:
                            vr.y += 16;
                            physics1.Z = -physics1.Z;
                            physics1.X = -physics1.X;
                            goto IL_03ab;
                    }
                    if (arg2 == 0)
                    {
                        return 0u;
                    }
                    vigObject = child2;
                    while (!(vigObject == null))
                    {
                        if (vigObject.id == 0)
                        {
                            vigObject.vr.z += arg2 * 256;
                            vigObject.ApplyTransformation();
                        }
                        else if (vigObject.id == 1)
                        {
                            if (tags == 3)
                            {
                                if (vigObject.vr.x < 853)
                                {
                                    vigObject.vr.x += 32;
                                    vigObject.ApplyTransformation();
                                }
                            }
                            else if (vigObject.vr.x != 0)
                            {
                                vigObject.vr.x -= 32;
                                vigObject.ApplyTransformation();
                            }
                        }
                        vigObject = vigObject.child;
                    }
                    uint volume = GameManager.instance.FUN_1E7A8(screen);
                    GameManager.instance.FUN_1E2C8(DAT_18, volume);
                    return 0u;
                }
            case 1:
                {
                    flags = 132u;
                    VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(0);
                    if (vigTuple != null)
                        DAT_A4 = vigTuple.array;
                    sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
                    maxFullHealth *= 4;
                    maxHalfHealth *= 4;
                    GameManager.instance.FUN_1E098(param, vData.sndList, 5, 0u, param5: true);
                    return 0u;
                }
            case 2:
                flags &= 4294967263u;
                break;
            case 4:
                DAT_94.FUN_51CC0();
                GameManager.instance.FUN_1DE78(DAT_18);
                break;
        }
        return 0u;
    }

    private void FUN_117C(ushort param1)
    {
        Blimp2 blimp = new GameObject().AddComponent<Blimp2>();
        blimp.flags |= 36u;
        blimp.physics2.M3 = 21;
        blimp.physics1.M1 = 4;
        blimp.maxHalfHealth = 2;
        blimp.physics1.Y = 512;
        blimp.DAT_98 = LevelManager.instance.xobfList[19];
        blimp.physics1.Z = -1536;
        blimp.physics1.W = 0;
        ConfigContainer cont = vData.ini.FUN_2C590(1365, param1);
        Utilities.FUN_2CA94(this, cont, blimp);
        Utilities.ParentChildren(this, this);
        blimp.FUN_30B78();
    }

    private static void RespawnBlimp()
    {
        IMP_OBJ.LoadOBJ(LevelManager.instance.objData[175].buffer);
    }
}
