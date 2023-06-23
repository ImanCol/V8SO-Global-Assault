using System;
using UnityEngine;

// Token: 0x020000C4 RID: 196
public class HOOVRDAM : VigObject
{
    // Token: 0x060003EE RID: 1006 RVA: 0x00007FCE File Offset: 0x000061CE
    protected override void Start()
    {
        base.Start();
    }

    // Token: 0x060003EF RID: 1007 RVA: 0x00007FD6 File Offset: 0x000061D6
    protected override void Update()
    {
        base.Update();
    }

    // Token: 0x060003F0 RID: 1008 RVA: 0x00008BA1 File Offset: 0x00006DA1
    private void Awake()
    {
        if (HOOVRDAM.instance == null)
        {
            HOOVRDAM.instance = this;
            this.flags |= 8192U;
            this.vData = LevelManager.instance.xobfList[42]; //Error al leer, provoca inconvenientes con el agua
        }
    }

    // Token: 0x060003F1 RID: 1009 RVA: 0x000351D4 File Offset: 0x000333D4
    public override uint UpdateW(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 0:
                {
                    int num5;
                    if (arg2 != 0)
                    {
                        int num = this.DAT_80_2 - arg2;
                        this.DAT_80_2 = num;
                        if (num < 0)
                        {
                            do
                            {
                                uint dat_84_ = this.DAT_84_2;
                                int num2 = (int)((dat_84_ & 7U) * 64U / 2U);
                                int num3 = num2 + 32;
                                this.DAT_80_2 += 6;
                                int num4 = 50;
                                TileData tileData = VigTerrain.instance.tileData[num4];
                                do
                                {
                                    num5 = (((this.DAT_88[num2 + 1] & 1) != 0) ? 128 : 0);
                                    tileData.uv1_x = ((int)(((this.DAT_88[num2 + 1] - 10) & 15) / 2) << 8) | ((int)((ushort)this.DAT_88[num2] & 255) + num5);
                                    tileData.uv1_y = (ushort)this.DAT_88[num2] >> 8;
                                    tileData.uv2_x = ((int)(((this.DAT_88[num2 + 3] - 10) & 15) / 2) << 8) | ((int)((ushort)this.DAT_88[num2 + 2] & 255) + num5);
                                    tileData.uv2_y = (ushort)this.DAT_88[num2 + 2] >> 8;
                                    tileData.uv3_x = ((int)(((this.DAT_88[num2 + 5] - 10) & 15) / 2) << 8) | ((int)((ushort)this.DAT_88[num2 + 4] & 255) + num5);
                                    tileData.uv3_y = (ushort)this.DAT_88[num2 + 4] >> 8;
                                    tileData.uv4_x = ((int)(((this.DAT_88[num2 + 7] - 10) & 15) / 2) << 8) | ((int)((ushort)this.DAT_88[num2 + 6] & 255) + num5);
                                    tileData.uv4_y = (ushort)this.DAT_88[num2 + 6] >> 8;
                                    num2 += 8;
                                    tileData = VigTerrain.instance.tileData[++num4];
                                }
                                while (num2 != num3);
                                this.DAT_84_2 = dat_84_ + 1U;
                            }
                            while (this.DAT_80_2 < 0);
                        }
                    }
                    this.DAT_1C30 = (int)GameManager.FUN_2AC5C();
                    if (((GameManager.instance.DAT_28 - (int)this.DAT_19) & 4095) >= 127)
                    {
                        return 0U;
                    }
                    num5 = (int)GameManager.FUN_2AC5C();
                    if ((num5 & 31) != 0)
                    {
                        return 0U;
                    }
                    UIManager.instance.FUN_4E338(new Color32(128, 128, 128, 10));
                    if (!this.DAT_90.trigger && this.DAT_90.DAT_18 == 0)
                    {
                        num5 = (int)GameManager.FUN_2AC5C();
                        this.DAT_90.tags = (sbyte)(num5 & 1);
                        this.DAT_90.trigger = true;
                        GameManager.instance.FUN_30CB0(this.DAT_90, (int)(this.DAT_90.tags ^ 1) * 180);
                        return 0U;
                    }
                    return 0U;
                }
            case 1:
                {
                    GameObject gameObject = new GameObject();
                    this.DAT_90 = gameObject.AddComponent<Thunder2>();
                    this.DAT_90.flags = 128U;
                    GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, this.DAT_90);
                    GameManager.instance.offsetFactor = 2.5f;
                    GameManager.instance.offsetStart = 0f;
                    GameManager.instance.angleOffset = 0.4f;
                    GameManager.instance.aspectRatioScale = 240f;
                    this.flags = 128U;
                    this.DAT_19 = (byte)GameManager.FUN_2AC5C();
                    short[] array = HOOVRDAM.FUN_1A0(50);
                    this.DAT_88 = array;
                    VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
                    VigObject vigObject2 = GameManager.instance.FUN_4AC1C(4261412864U, vigObject);
                    GameManager.instance.DAT_1038 = ((vigObject2 != null) ? 1 : 0);
                    this.id = 1;
                    break;
                }
            case 2:
                break;
            case 3:
                return 0U;
            case 4:
                this.DAT_88 = null;
                return 0U;
            default:
                return 0U;
        }
        GameManager.instance.FUN_34B34();
        GameManager.instance.FUN_30CB0(this, 240);
        return 0U;
    }

    // Token: 0x060003F2 RID: 1010 RVA: 0x00035590 File Offset: 0x00033790
    public override uint UpdateW(VigObject arg1, int arg2, Vector3Int arg3)
    {
        if (arg2 == 10)
        {
            uint num;
            if (arg3.z + -82575360 < 5505025)
            {
                num = 0U;
                if (arg1.type == 9)
                {
                    this.DAT_1C30++;
                    num = 0U;
                    if ((this.DAT_1C30 & 15) == 0)
                    {
                        Vehicle vehicle = (Vehicle)Utilities.FUN_2CD78(arg1);
                        Ballistic ballistic;
                        if (vehicle.physics1.W < 3814)
                        {
                            ballistic = this.vData.ini.FUN_2C17C(607, typeof(Ballistic), 8U) as Ballistic;
                        }
                        else
                        {
                            num = 606U;
                            if ((arg1.flags & 268435456U) != 0U)
                            {
                                num = 605U;
                            }
                            ballistic = this.vData.ini.FUN_2C17C((ushort)num, typeof(Ballistic), 8U) as Ballistic;
                            short num2 = Utilities.FUN_2A27C(vehicle.vTransform.rotation);
                            ballistic.vr.y = (int)num2;
                        }
                        ballistic.type = 7;
                        ballistic.flags = 36U;
                        ballistic.screen = arg3;
                        ballistic.FUN_3066C();
                        num = 0U;
                    }
                }
            }
            else
            {
                Vehicle vehicle = (Vehicle)Utilities.FUN_2CDB0(arg1);
                num = 0U;
                if ((vehicle.flags & 603979776U) == 536870912U && (vehicle.flags & 16384U) != 0U)
                {
                    Debug.Log("Water? " + vehicle.vehicle + " - " + DAT_A0_2 + " - " + false);
                    vehicle.FUN_3A020(-150, HOOVRDAM.DAT_A0_2, false);
                    HOOVRDAM.FUN_510(vehicle.vTransform.position, this.vData, 609, 608, 0, 4, 60);
                    VigObject vigObject = vehicle.child2;
                    while (vigObject != null)
                    {
                        if (vigObject.vMesh != null)
                        {
                            vigObject.vMesh.DAT_02 = 64;
                        }
                        vigObject = vigObject.child;
                    }
                    if (vehicle.vLOD != null)
                    {
                        vehicle.vLOD.DAT_02 = 64;
                    }
                    sbyte b = (sbyte)vehicle.DAT_DF;
                    if (b == 0)
                    {
                        b = (sbyte)GameManager.instance.FUN_1DD9C();
                        vehicle.DAT_DF = (byte)b;
                    }
                    GameManager.instance.FUN_1E098((int)b, LevelManager.instance.xobfList[42].sndList, 2, 0U, true);
                    GameManager.instance.FUN_1E2C8((int)vehicle.DAT_18, 0U);
                    vehicle.state = _VEHICLE_TYPE.Dam;
                    vehicle.tags = 0;
                    vehicle.flags = (vehicle.flags & 4294967293U) | 100663328U;
                    int num3 = (int)GameManager.FUN_2AC5C();
                    vehicle.DAT_DE = (byte)((num3 << 2 >> 15) + 60);
                    vehicle.physics1.X = 0;
                    vehicle.physics1.Y = 117120;
                    vehicle.physics1.Z = 0;
                    GameManager.instance.FUN_30CB0(vehicle, 60);
                    VigCamera vCamera = vehicle.vCamera;
                    num = 0U;
                    if (vCamera != null)
                    {
                        int[] array = new int[16];
                        VigObject vigObject2 = GameManager.instance.FUN_31950((int)vehicle.DAT_DE);
                        array[0] = vCamera.screen.x;
                        array[1] = vCamera.screen.y;
                        array[2] = vCamera.screen.z;
                        array[3] = 120;
                        array[4] = 60751872;
                        array[6] = 88539136;
                        array[5] = 2160640;
                        array[7] = 360;
                        array[8] = vigObject2.screen.x;
                        array[9] = vigObject2.screen.y - 73728;
                        array[10] = vigObject2.screen.z + 327680;
                        array[11] = 0;
                        vCamera.FUN_4BDC4(array);
                        num = 0U;
                    }
                }
            }
            return num;
        }
        return 0U;
    }

    // Token: 0x060003F3 RID: 1011 RVA: 0x00035934 File Offset: 0x00033B34
    public override sbyte UpdateW(VigObject arg1, int arg2, TileData arg3)
    {
        if (arg2 == 12)
        {
            int num = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E098(num, this.vData.sndList, 6, 0U, true);
            return (sbyte)num;
        }
        return 0;
    }

    // Token: 0x060003F4 RID: 1012 RVA: 0x00035970 File Offset: 0x00033B70
    public override uint UpdateW(VigObject arg1, int arg2, int arg3)
    {
        if (arg2 != 18)
        {
            return 0U;
        }
        if (arg3 == 0 || arg1.type != 8 || GameManager.instance.terrain.GetTileByPosition((uint)arg1.vTransform.position.x, (uint)arg1.vTransform.position.z).DAT_10[3] != 1)
        {
            if (arg1.type == 0)
            {
                this.destroyedObjects++;
            }
            GameManager.instance.FUN_327CC(arg1);
            return 0U;
        }
        HOOVRDAM.FUN_510(arg1.vTransform.position, this.vData, 609, 608, 0, 4, 60);
        return 0U;
    }

    // Token: 0x060003F5 RID: 1013 RVA: 0x00035A18 File Offset: 0x00033C18
    private static Water2 FUN_510(Vector3Int param1, XOBF_DB param2, ushort param3, short param4, int param5, short param6, int param7)
    {
        Water2 water = param2.ini.FUN_2C17C(param3, typeof(Water2), 8U) as Water2;
        water.vTransform = GameManager.FUN_2A39C();
        water.vTransform.position = param1;
        water.DAT_58 = 32768;
        water.DAT_98 = param2;
        water.physics2.M3 = param4;
        water.flags |= 164U;
        water.physics1.M1 = param6;
        water.FUN_305FC();
        GameManager.instance.FUN_30CB0(water, param7);
        int num = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E580(num, param2.sndList, param5, param1, false);
        return water;
    }

    // Token: 0x060003F6 RID: 1014 RVA: 0x00035ACC File Offset: 0x00033CCC
    private static short[] FUN_1A0(int param1)
    {
        short[] array = new short[4];
        short[] array2 = new short[256];
        LevelManager.instance.FUN_21594(array, 138, 0, 30788);
        int num = param1;
        if (param1 < 0)
        {
            num = param1 + 15;
        }
        uint num2 = (uint)((ushort)LevelManager.instance.DAT_DBA);
        uint num3 = 0U;
        int num4 = 0;
        do
        {
            uint num5 = num3;
            if (num3 < 0U)
            {
                num5 = num3 + 3U;
            }
            uint num6 = num3 & 2U;
            int num7 = (param1 + (num >> 4) * -16) * (int)num2 + (int)(array[0] * 2) + (((int)num5 >> 2) * 2 + (int)(num3 & 1U)) * (int)((ushort)LevelManager.instance.DAT_DBA) / 2;
            num3 += 1U;
            num5 = (uint)((num >> 4) * (int)num2 + (int)array[1] + ((int)(num6 * (uint)((ushort)LevelManager.instance.DAT_DBA)) >> 2));
            ushort num8 = (ushort)((ushort)((int)(num5 & 256U) >> 4) | ((ushort)(num7 - (num7 >> 31) >> 7) & 15) | 128 | (ushort)((num5 & 512U) << 2));
            short num9 = (short)(((ushort)num7 & 127) + (ushort)((short)num5 * 256));
            ushort num10 = (ushort)((uint)((ushort)LevelManager.instance.DAT_DBA) >> 1);
            short num11 = (short)(num10 - 1);
            array2[num4 + 7] = (short)num8;
            array2[num4 + 5] = (short)num8;
            array2[num4 + 3] = (short)num8;
            array2[num4 + 1] = (short)num8;
            array2[num4 + 4] = num9;
            array2[num4] = (short)(num9 + num11 * 256);
            array2[num4 + 2] = (short)(array2[num4 + 4] + num11 * 257);
            array2[num4 + 6] = (short)(array2[num4 + 4] - 1 + (short)num10);
            num4 += 8;
        }
        while (num3 < 32U);
        return array2;
    }

    // Token: 0x04000180 RID: 384
    private static Vector3Int DAT_A0_2 = new Vector3Int(0, 0, 0);

    // Token: 0x04000181 RID: 385
    public static HOOVRDAM instance;

    // Token: 0x04000182 RID: 386
    public int DAT_1C30;

    // Token: 0x04000183 RID: 387
    public int DAT_80_2;

    // Token: 0x04000184 RID: 388
    public uint DAT_84_2;

    // Token: 0x04000185 RID: 389
    public short[] DAT_88;

    // Token: 0x04000186 RID: 390
    public Thunder2 DAT_90;

    // Token: 0x04000187 RID: 391
    public int destroyedObjects;
}
