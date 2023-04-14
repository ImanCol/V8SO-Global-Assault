using UnityEngine;

public class VigCamera : VigObject
{
    public struct CAMERA_PATHWAY
    {
        public int[] DAT_00;

        public int DAT_04;

        public int DAT_08;

        public int DAT_0C;

        public int DAT_10;

        public int DAT_14;

        public int DAT_18;

        public int DAT_1C;

        public int DAT_20;

        public int DAT_24;

        public int DAT_28;

        public int DAT_2C;

        public int DAT_30;

        public ushort DAT_34;

        public ushort DAT_36;

        public void FUN_4C1EC()
        {
            DAT_00 = null;
        }

        public void FUN_4C1C4(int[] param1)
        {
            DAT_00 = param1;
            DAT_34 = 0;
            DAT_36 = 0;
            FUN_4BE24();
        }

        public void FUN_4BE24()
        {
            uint dAT_ = DAT_34;
            int num = (int)(dAT_ * 4);
            Vector3Int vector3Int;
            if (dAT_ == 0)
            {
                vector3Int = new Vector3Int(0, 0, 0);
            }
            else
            {
                vector3Int = default(Vector3Int);
                vector3Int.z = DAT_00[num + 3];
                if (1 < dAT_)
                {
                    vector3Int.z -= DAT_00[num - 5];
                }
                vector3Int.z = 4096 / vector3Int.z;
                vector3Int.x = (DAT_00[num + 4] - DAT_00[num - 4]) * vector3Int.z;
                if (vector3Int.x < 0)
                {
                    vector3Int.x += 4095;
                }
                vector3Int.x >>= 12;
                vector3Int.y = (DAT_00[num + 5] - DAT_00[num - 3]) * vector3Int.z;
                if (vector3Int.y < 0)
                {
                    vector3Int.y += 4095;
                }
                vector3Int.y >>= 12;
                vector3Int.z = (DAT_00[num + 6] - DAT_00[num - 2]) * vector3Int.z;
                if (vector3Int.z < 0)
                {
                    vector3Int.z += 4095;
                }
                vector3Int.z >>= 12;
            }
            Vector3Int vector3Int2 = default(Vector3Int);
            vector3Int2.z = DAT_00[num + 7];
            if (vector3Int2.z == 0)
            {
                vector3Int2 = new Vector3Int(0, 0, 0);
            }
            else
            {
                if (DAT_34 != 0)
                {
                    vector3Int2.z -= DAT_00[num - 1];
                }
                vector3Int2.z = 4096 / vector3Int2.z;
                vector3Int2.x = (DAT_00[num + 8] - DAT_00[num]) * vector3Int2.z;
                if (vector3Int2.x < 0)
                {
                    vector3Int2.x += 4095;
                }
                vector3Int2.x >>= 12;
                vector3Int2.y = (DAT_00[num + 9] - DAT_00[num + 1]) * vector3Int2.z;
                if (vector3Int2.y < 0)
                {
                    vector3Int2.y += 4095;
                }
                vector3Int2.y >>= 12;
                vector3Int2.z = (DAT_00[num + 10] - DAT_00[num + 2]) * vector3Int2.z;
                if (vector3Int2.z < 0)
                {
                    vector3Int2.z += 4095;
                }
                vector3Int2.z >>= 12;
            }
            int num2 = (DAT_00[num] - DAT_00[num + 4]) * 2 + vector3Int.x + vector3Int2.x;
            if (num2 < 0)
            {
                num2 += 15;
            }
            DAT_04 = num2 >> 4;
            num2 = (DAT_00[num + 1] - DAT_00[num + 5]) * 2 + vector3Int.y + vector3Int2.y;
            if (num2 < 0)
            {
                num2 += 15;
            }
            DAT_08 = num2 >> 4;
            num2 = (DAT_00[num + 2] - DAT_00[num + 6]) * 2 + vector3Int.z + vector3Int2.z;
            if (num2 < 0)
            {
                num2 += 15;
            }
            DAT_0C = num2 >> 4;
            vector3Int2.x = DAT_00[num + 4] * 3 + DAT_00[num] * -3 + vector3Int.x * -2 - vector3Int2.x;
            if (vector3Int2.x < 0)
            {
                vector3Int2.x += 15;
            }
            DAT_10 = vector3Int2.x >> 4;
            vector3Int2.y = DAT_00[num + 5] * 3 + DAT_00[num + 1] * -3 + vector3Int.y * -2 - vector3Int2.y;
            if (vector3Int2.y < 0)
            {
                vector3Int2.y += 15;
            }
            DAT_14 = vector3Int2.y >> 4;
            vector3Int2.z = DAT_00[num + 6] * 3 + DAT_00[num + 2] * -3 + vector3Int.z * -2 - vector3Int2.z;
            if (vector3Int2.z < 0)
            {
                vector3Int2.z += 15;
            }
            DAT_18 = vector3Int2.z >> 4;
            if (vector3Int.x < 0)
            {
                vector3Int.x += 15;
            }
            DAT_1C = vector3Int.x >> 4;
            if (vector3Int.y < 0)
            {
                vector3Int.y += 15;
            }
            DAT_20 = vector3Int.y >> 4;
            if (vector3Int.z < 0)
            {
                vector3Int.z += 15;
            }
            DAT_24 = vector3Int.z >> 4;
            DAT_28 = DAT_00[num];
            DAT_2C = DAT_00[num + 1];
            DAT_30 = DAT_00[num + 2];
        }
    }

    public VigObject target;

    public new Vector3Int DAT_84;

    public int DAT_9C;

    public int DAT_98;

    public int DAT_A0_1;

    public short DAT_90;

    public short DAT_92;

    public short DAT_94;

    public CAMERA_PATHWAY pathway;

    public _CAMERA_TYPE state;

    public short fieldOfView => (short)maxHalfHealth;

    private void Awake()
    {
    }

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
        switch (state)
        {
            case _CAMERA_TYPE.Default:
                switch (arg1)
                {
                    default:
                        return 0u;
                    case 2:
                        {
                            Vehicle vehicle = (Vehicle)target;
                            base.flags &= 3959422975u;
                            if (vehicle.vCamera == this)
                            {
                                return 0u;
                            }
                            GameManager.instance.FUN_30CB0(vehicle.vCamera, 0);
                            vehicle.vCamera = this;
                            LevelManager.instance.defaultCamera.transform.SetParent(base.transform, worldPositionStays: false);
                            return 0u;
                        }
                    case 0:
                        {
                            uint flags = base.flags;
                            if ((flags & 0x10000000) != 0)
                            {
                                if (!FUN_4C210((ushort)arg2))
                                {
                                    pathway.FUN_4C1EC();
                                    base.flags &= 4026531839u;
                                }
                            }
                            else if ((flags & 0x4000000) != 0)
                            {
                                screen.x += DAT_84.x;
                                screen.y += DAT_84.y;
                                screen.z += DAT_84.z;
                            }
                            else
                            {
                                int dAT_A0_ = DAT_A0_1;
                                Vector3Int vector3Int;
                                int dAT_9C;
                                if ((flags & 0x2000000) == 0)
                                {
                                    if ((flags & 0x20000000) == 0)
                                    {
                                        short num = Utilities.FUN_2A27C(target.vTransform.rotation);
                                        int num2 = ((num + DAT_92) & 0xFFF) * 2;
                                        vector3Int = default(Vector3Int);
                                        vector3Int.x = GameManager.DAT_65C90[num2];
                                        num = GameManager.DAT_65C90[((ushort)DAT_90 & 0xFFF) * 2];
                                        vector3Int.y = -num;
                                        vector3Int.z = GameManager.DAT_65C90[num2 + 1];
                                    }
                                    else
                                    {
                                        vector3Int = Utilities.ApplyMatrixSV(v3: new Vector3Int(GameManager.DAT_65C90[((ushort)DAT_92 & 0xFFF) * 2], -GameManager.DAT_65C90[((ushort)DAT_90 & 0xFFF) * 2], GameManager.DAT_65C90[((ushort)DAT_92 & 0xFFF) * 2 + 1]), m33: target.vTransform.rotation);
                                    }
                                }
                                else
                                {
                                    int num3 = DAT_9C + 2288;
                                    dAT_9C = 716800;
                                    if (num3 < 716800)
                                    {
                                        dAT_9C = num3;
                                    }
                                    DAT_9C = dAT_9C;
                                    flags = (uint)((ushort)DAT_92 + 8);
                                    DAT_92 = (short)flags;
                                    vector3Int = default(Vector3Int);
                                    vector3Int.x = GameManager.DAT_65C90[(flags & 0xFFF) * 2];
                                    short num = GameManager.DAT_65C90[((ushort)DAT_90 & 0xFFF) * 2];
                                    int num2 = GameManager.DAT_65C90[((ushort)DAT_92 & 0xFFF) * 2 + 1];
                                    vector3Int.y = -num;
                                    vector3Int.z = num2;
                                }
                                Vector3Int phy = default(Vector3Int);
                                flags = (uint)((ushort)vector3Int.x << 16 >> 16);
                                uint dAT_9C2 = (uint)DAT_9C;
                                long num4 = (long)flags * (long)dAT_9C2;
                                uint num5 = (uint)((ushort)vector3Int.y << 16 >> 16);
                                phy.x = target.vTransform.position.x - ((int)((uint)num4 >> 12) | (((int)((ulong)num4 >> 32) + (int)flags * ((int)dAT_9C2 >> 31) + (int)dAT_9C2 * ((ushort)vector3Int.x << 16 >> 31)) * 1048576)) - screen.x;
                                flags = (uint)DAT_9C;
                                num4 = (long)num5 * (long)flags;
                                dAT_9C2 = (uint)((ushort)vector3Int.z << 16 >> 16);
                                phy.y = target.vTransform.position.y - ((int)((uint)num4 >> 12) | (((int)((ulong)num4 >> 32) + (int)num5 * ((int)flags >> 31) + (int)flags * ((ushort)vector3Int.y << 16 >> 31)) * 1048576)) - screen.y;
                                flags = (uint)DAT_9C;
                                num4 = (long)dAT_9C2 * (long)flags;
                                phy.z = target.vTransform.position.z - ((int)((uint)num4 >> 12) | (((int)((ulong)num4 >> 32) + (int)dAT_9C2 * ((int)flags >> 31) + (int)flags * ((ushort)vector3Int.z << 16 >> 31)) * 1048576)) - screen.z;
                                flags = (uint)Utilities.FUN_29E84(phy);
                                dAT_9C = (int)flags >> 31;
                                if (dAT_A0_ < 0)
                                {
                                    screen.x += phy.x;
                                    screen.y += phy.y;
                                    screen.z += phy.z;
                                }
                                else
                                {
                                    bool flag = false;
                                    dAT_9C2 = (uint)(dAT_A0_ / 2);
                                    dAT_A0_ = dAT_A0_ - (dAT_A0_ >> 31) >> 31;
                                    ulong num6 = 0uL;
                                    if (dAT_A0_ < dAT_9C || (dAT_9C == dAT_A0_ && dAT_9C2 < flags))
                                    {
                                        num6 = (ulong)Utilities.Divdi3((int)((flags - dAT_9C2) * 4096), ((dAT_9C - dAT_A0_ - ((flags < dAT_9C2) ? 1 : 0)) * 4096) | (int)(flags - dAT_9C2 >> 20), (int)flags, dAT_9C);
                                        if (0 < (int)(num6 >> 32) || ((int)(num6 >> 32) == 0 && (int)num6 > 256))
                                        {
                                            flag = true;
                                        }
                                    }
                                    dAT_A0_ = (int)(num6 >> 32);
                                    flags = (uint)num6;
                                    if (flag)
                                    {
                                        if ((base.flags & 0x8000000) == 0)
                                        {
                                            screen.x += ((int)((uint)((long)(uint)phy.x * (long)flags) >> 12) | (((int)((ulong)((long)(uint)phy.x * (long)flags) >> 32) + phy.x * dAT_A0_ + (int)flags * (phy.x >> 31)) * 1048576));
                                            screen.y += ((int)((uint)((long)(uint)phy.y * (long)flags) >> 12) | (((int)((ulong)((long)(uint)phy.y * (long)flags) >> 32) + phy.y * dAT_A0_ + (int)flags * (phy.y >> 31)) * 1048576));
                                            screen.z += ((int)((uint)((long)(uint)phy.z * (long)flags) >> 12) | (((int)((ulong)((long)(uint)phy.z * (long)flags) >> 32) + phy.z * dAT_A0_ + (int)flags * (phy.z >> 31)) * 1048576));
                                            goto IL_075a;
                                        }
                                    }
                                    else if ((base.flags & 0x8000000) != 0)
                                    {
                                        base.flags &= 4160749567u;
                                    }
                                    flags = (uint)phy.x;
                                    if (phy.x < 0)
                                    {
                                        flags = (uint)(phy.x + 7);
                                    }
                                    int num3 = DAT_98;
                                    dAT_9C = (int)flags >> 3;
                                    dAT_A0_ = -num3;
                                    if (-num3 <= dAT_9C)
                                    {
                                        dAT_A0_ = num3;
                                        if (dAT_9C <= num3)
                                        {
                                            dAT_A0_ = dAT_9C;
                                        }
                                    }
                                    screen.x += dAT_A0_;
                                    flags = (uint)phy.y;
                                    if (phy.y < 0)
                                    {
                                        flags = (uint)(phy.y + 15);
                                    }
                                    num3 = DAT_98;
                                    dAT_9C = (int)flags >> 4;
                                    dAT_A0_ = -num3;
                                    if (-num3 <= dAT_9C)
                                    {
                                        dAT_A0_ = num3;
                                        if (dAT_9C <= num3)
                                        {
                                            dAT_A0_ = dAT_9C;
                                        }
                                    }
                                    screen.y += dAT_A0_;
                                    flags = (uint)phy.z;
                                    if (phy.z < 0)
                                    {
                                        flags = (uint)(phy.z + 7);
                                    }
                                    num3 = DAT_98;
                                    dAT_9C = (int)flags >> 3;
                                    dAT_A0_ = -num3;
                                    if (-num3 <= dAT_9C)
                                    {
                                        dAT_A0_ = num3;
                                        if (dAT_9C <= num3)
                                        {
                                            dAT_A0_ = dAT_9C;
                                        }
                                    }
                                    screen.z += dAT_A0_;
                                }
                            }
                            goto IL_075a;
                        }
                    IL_075a:
                        if ((base.flags & 0x1000000) != 0)
                        {
                            int dAT_A0_ = VigTerrain.instance.FUN_1B750((uint)target.vTransform.position.x, (uint)target.vTransform.position.z);
                            if (target.vTransform.position.y < dAT_A0_)
                            {
                                int num3 = screen.y;
                                int dAT_9C = VigTerrain.instance.FUN_1B750((uint)screen.x, (uint)screen.z);
                                dAT_A0_ = dAT_9C - 32768;
                                if (num3 < dAT_9C - 32768)
                                {
                                    dAT_A0_ = num3;
                                }
                                screen.y = dAT_A0_;
                            }
                        }
                        FUN_4BAFC(target.vTransform.position);
                        vr.x += DAT_94;
                        ApplyTransformation();
                        return 0u;
                }
            case _CAMERA_TYPE.Teleport:
                {
                    uint result;
                    if (arg1 == 0)
                    {
                        FUN_4BBDC(DAT_80.vTransform.position);
                        ApplyTransformation();
                        result = 0u;
                    }
                    else
                    {
                        result = 0u;
                        if (arg1 == 2)
                        {
                            VigObject dAT_ = DAT_80;
                            if (dAT_.type == 2)
                            {
                                dAT_.flags &= 4261412863u;
                            }
                            GameManager.instance.FUN_308C4(this);
                            result = uint.MaxValue;
                        }
                    }
                    return result;
                }
            default:
                return 0u;
        }
    }

    private void FUN_4B820()
    {
        if (GameManager.instance.screenMode == _SCREEN_MODE.Horizontal)
        {
            DAT_90 = -160;
            DAT_94 = 80;
            return;
        }
        if (GameManager.instance.screenMode < _SCREEN_MODE.Vertical)
        {
            if (GameManager.instance.screenMode != 0)
            {
                return;
            }
        }
        else if (GameManager.instance.screenMode != _SCREEN_MODE.Vertical)
        {
            if (GameManager.instance.screenMode == _SCREEN_MODE.Unknown)
            {
                DAT_90 = -192;
                DAT_94 = 128;
            }
            return;
        }
        DAT_90 = -256;
        DAT_94 = 160;
    }

    public void FUN_4B898()
    {
        FUN_4B820();
        DAT_92 = 0;
        int num = (GameManager.instance.screenMode == _SCREEN_MODE.Whole) ? 155536 : ((GameManager.instance.screenMode != _SCREEN_MODE.Unknown) ? 81920 : 133120);
        DAT_9C = target.DAT_58 + num;
        DAT_98 = 11444;
        DAT_A0_1 = 204800;
    }

    public void FUN_4BBDC(Vector3Int param1)
    {
        FUN_4BAFC(param1);
    }

    public void FUN_4BC0C()
    {
        short num = Utilities.FUN_2A27C(target.vTransform.rotation);
        uint dAT_9C = (uint)DAT_9C;
        int num2 = ((num + DAT_92) & 0xFFF) * 2;
        uint num3 = (uint)((ushort)GameManager.DAT_65C90[num2] << 16 >> 16);
        long num4 = (long)dAT_9C * (long)num3;
        screen.x = target.vTransform.position.x - ((int)((uint)num4 >> 12) | (((int)((ulong)num4 >> 32) + (int)dAT_9C * ((ushort)GameManager.DAT_65C90[num2] << 16 >> 31) + (int)num3 * ((int)dAT_9C >> 31)) * 1048576));
        uint num5 = (uint)((long)(int)dAT_9C * (long)(-GameManager.DAT_65C90[(DAT_90 & 0xFFF) * 2]));
        int num6 = (int)((ulong)((long)(int)dAT_9C * (long)(-GameManager.DAT_65C90[(DAT_90 & 0xFFF) * 2])) >> 32);
        dAT_9C = (uint)DAT_9C;
        screen.y = target.vTransform.position.y - ((int)(num5 >> 12) | (num6 << 20));
        num3 = (uint)((ushort)GameManager.DAT_65C90[num2 + 1] << 16 >> 16);
        num4 = (long)dAT_9C * (long)num3;
        VigObject vigObject = target;
        screen.z = target.vTransform.position.z - ((int)((uint)num4 >> 12) | (((int)((ulong)num4 >> 32) + (int)dAT_9C * ((ushort)GameManager.DAT_65C90[num2 + 1] << 16 >> 31) + (int)num3 * ((int)dAT_9C >> 31)) * 1048576));
        FUN_4BAFC(vigObject.vTransform.position);
        vr.x += DAT_94;
        ApplyTransformation();
    }

    public void FUN_4BDC4(int[] param1)
    {
        if ((flags & 0x10000000) != 0)
        {
            pathway.FUN_4C1EC();
        }
        pathway.FUN_4C1C4(param1);
        flags |= 402653184u;
    }

    private bool FUN_4C210(ushort param1)
    {
        int[] dAT_ = pathway.DAT_00;
        ushort num = (ushort)(pathway.DAT_36 + param1);
        pathway.DAT_36 = num;
        uint num2 = (uint)(pathway.DAT_34 + 1);
        if (dAT_[pathway.DAT_34 * 4 + 3] < num)
        {
            pathway.DAT_34 = (ushort)num2;
            if (dAT_[(num2 & 0xFFFF) * 4 + 3] == 0)
            {
                int num3 = pathway.DAT_34 * 4;
                screen.x = dAT_[num3];
                screen.y = dAT_[num3 + 1];
                screen.z = dAT_[num3 + 2];
                return false;
            }
            pathway.FUN_4BE24();
        }
        int num4;
        int num5;
        if (pathway.DAT_34 == 0)
        {
            num4 = 0;
            num5 = 0;
        }
        else
        {
            num4 = pathway.DAT_00[pathway.DAT_34 * 4 - 1];
            num5 = -num4;
        }
        num4 = (num + num5) * 4096 / (pathway.DAT_00[pathway.DAT_34 * 4 + 3] - num4);
        num5 = num4 * num4;
        if (num5 < 0)
        {
            num5 += 4095;
        }
        num5 >>= 12;
        int num6 = num5 * num4;
        if (num6 < 0)
        {
            num6 += 4095;
        }
        num6 >>= 12;
        int num7 = pathway.DAT_04 * num6 + pathway.DAT_10 * num5 + pathway.DAT_1C * num4;
        if (num7 < 0)
        {
            num7 += 255;
        }
        screen.x = (num7 >> 8) + pathway.DAT_28;
        num7 = pathway.DAT_08 * num6 + pathway.DAT_14 * num5 + pathway.DAT_20 * num4;
        if (num7 < 0)
        {
            num7 += 255;
        }
        screen.y = (num7 >> 8) + pathway.DAT_2C;
        num5 = pathway.DAT_0C * num6 + pathway.DAT_18 * num5 + pathway.DAT_24 * num4;
        if (num5 < 0)
        {
            num5 += 255;
        }
        screen.z = (num5 >> 8) + pathway.DAT_30;
        return true;
    }
}
