using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Profiling;
using Unity.Jobs;
using Unity.Collections;
using Unity.Burst;
using TMPro;
using Rewired;
using System.Threading;
using System.Threading.Tasks;
using Beebyte.Obfuscator;
using LoadMap; //Administra Carga de Mapa

public delegate VigObject _VEHICLE_INIT(XOBF_DB param1, int param2, uint param3); //needs parameters
public delegate VigObject _SPECIAL_INIT(XOBF_DB param1, int param2);
public delegate VigObject _OBJECT_INIT(XOBF_DB param1, int param2, uint param3);

[Serializable]
public struct VehicleStats
{
    public byte accel;

    public byte speed;

    public byte armor;

    public byte avoidance;
}

[Serializable]
public struct VehicleData
{
    // Token: 0x04000414 RID: 1044
    public short[] DAT_00;

    // Token: 0x04000415 RID: 1045
    public byte DAT_0C;

    // Token: 0x04000416 RID: 1046
    public _VEHICLE vehicleID;

    // Token: 0x04000417 RID: 1047
    public sbyte DAT_0E;

    // Token: 0x04000418 RID: 1048
    public sbyte DAT_0F;

    // Token: 0x04000419 RID: 1049
    public byte DAT_10;

    // Token: 0x0400041A RID: 1050
    public byte DAT_11;

    // Token: 0x0400041B RID: 1051
    public byte DAT_12;

    // Token: 0x0400041C RID: 1052
    public byte DAT_13;

    // Token: 0x0400041D RID: 1053
    public byte DAT_14;

    // Token: 0x0400041E RID: 1054
    public byte DAT_15;

    // Token: 0x0400041F RID: 1055
    public byte DAT_16;

    // Token: 0x04000420 RID: 1056
    public ushort maxHalfHealth;

    // Token: 0x04000421 RID: 1057
    public ushort DAT_1A;

    // Token: 0x04000422 RID: 1058
    public int lightness;

    // Token: 0x04000423 RID: 1059
    public int DAT_20;

    // Token: 0x04000424 RID: 1060
    public ushort peelout;

    // Token: 0x04000425 RID: 1061
    public Vector3Int DAT_24;

    // Token: 0x04000426 RID: 1062
    public short DAT_2A;

    // Token: 0x04000427 RID: 1063
    public byte[] DAT_2C;
}

public enum _GAME_MODE
{
    Quest,
    Arcade,
    Alone,
    Survival,
    Demo,
    Versus,
    Coop,
    Quest2,
    Unk1,
    Unk2,
    Versus2,
    Coop2,
    Survival2,
    GlobbalOffense, //Algun Mapa mas grande?
    Invasion, //Freneticas batallas con IA
    FreeWill //Freneticas batallas con IA

}

public enum _SCREEN_MODE
{
    Whole,
    Horizontal,
    Vertical,
    Unknown
}
public enum _DITHERING
{
    None,
    Standard,
    PSX
}


[Serializable]
public class BSP
{
    public int DAT_00; //0x00
    public int DAT_04; //0x04
    public List<VigTuple> LDAT_04; //0x04
    public BSP DAT_08; //0x08
    public BSP DAT_0C; //0x0C
}

[BurstCompile]
[SkipRename]
public class GameManager : MonoBehaviour
{
    [Header("Frame Settings")]
    public int MaxRate = 9999;
    public float TargetFrameRate = 60.0f;
    float currentFrameTime;


    private float currentFps = 0.0f;

    IEnumerator WaitForNextFrame()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();
            currentFrameTime += 1.0f / TargetFrameRate;
            var t = Time.realtimeSinceStartup;
            var sleepTime = currentFrameTime - t - 0.01f;
            if (sleepTime > 0)
                Thread.Sleep((int)(sleepTime * 1000));
            while (t < currentFrameTime)
                t = Time.realtimeSinceStartup;
            currentFps = 1.0f / (Time.deltaTime + 0.00001f);
        }
    }



    public struct TerrainJob : IJob
    {
        // Token: 0x06000875 RID: 2165 RVA: 0x000608E0 File Offset: 0x0005EAE0
        public void Execute()
        {
            int num = 0;
            int num2 = 0;
            int num3 = this.param1[0].x;
            int i = this.param1[0].y;
            if (i < 0)
            {
                i += 1023;
            }
            int num4 = i >> 10 << 2;
            i = (i >> 10) * 1024;
            int num5 = 0;
            int num6 = num3;
            bool flag = false;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;
            for (; ; )
            {
                i += 1024;
                int num11 = this.param1[num].y;
                int num12 = num6;
                while (i > num11)
                {
                    num7 = this.param1[num].x;
                    num9 = this.param1[num].y;
                    if (num7 < num12)
                    {
                        num12 = num7;
                    }
                    if (num == 0)
                    {
                        num = this.param2;
                    }
                    num--;
                    num11 = this.param1[num].y;
                    flag = num11 < num9;
                    if (flag)
                    {
                        break;
                    }
                }
                if (num9 == 0 || num7 == 0)
                {
                    Debug.Log("!");
                }
                num11 = num3;
                if (this.param1[num5].y >= i)
                {
                    goto IL_1CC;
                }
                int num13 = num2;
                for (; ; )
                {
                    num8 = this.param1[num13].x;
                    num10 = this.param1[num13].y;
                    if (num11 < num8)
                    {
                        num11 = num8;
                    }
                    num5++;
                    num2++;
                    flag = false;
                    if (num2 == this.param2 || this.param1[num13 + 1].y < num10)
                    {
                        flag = true;
                    }
                    if (flag)
                    {
                        break;
                    }
                    int num14 = num13 + 1;
                    num13++;
                    if (this.param1[num14].y >= i)
                    {
                        goto IL_1CC;
                    }
                }
            IL_26F:
                int num15 = num11 + 1023;
                if (num12 < 0)
                {
                    num12 += 1023;
                }
                if (num15 < 0)
                {
                    num15 = num11 + 2046;
                }
                VigTerrain.FUN_1BE68(num12 >> 10 << 2, num15 >> 10 << 2, num4);
                num4 += 4;
                if (flag)
                {
                    break;
                }
                continue;
            IL_1CC:
                if (num10 == 0 || num8 == 0)
                {
                    Debug.Log("!");
                }
                if (flag)
                {
                    goto IL_26F;
                }
                num6 = num7 + (this.param1[num].x - num7) * (i - num9) / (this.param1[num].y - num9);
                num3 = num8 + (this.param1[num5].x - num8) * (i - num10) / (this.param1[num5].y - num10);
                if (num6 < num12)
                {
                    num12 = num6;
                }
                if (num11 < num3)
                {
                    num11 = num3;
                    goto IL_26F;
                }
                goto IL_26F;
            }
        }

        // Token: 0x04000517 RID: 1303
        public NativeArray<Vector2Int> param1;

        // Token: 0x04000518 RID: 1304
        public int param2;
    }

    public static GameManager instance;

    public static short[] SQRT = new short[]
    {
        4096, 4127, 4159, 4190, 4222, 4252, 4283, 4314, 4344,
        4374, 4404, 4434, 4463, 4492, 4521, 4550, 4579, 4608,
        4636, 4664, 4692, 4720, 4748, 4775, 4802, 4830, 4857,
        4884, 4910, 4937, 4964, 4990, 5016, 5042, 5068, 5094,
        5120, 5145, 5170, 5196, 5221, 5246, 5271, 5296, 5320,
        5345, 5369, 5394, 5418, 5442, 5466, 5490, 5514, 5538,
        5561, 5585, 5608, 5632, 5655, 5678, 5701, 5724, 5747,
        5769, 5792, 5815, 5837, 5860, 5882, 5904, 5926, 5948,
        5970, 5992, 6014, 6036, 6058, 6079, 6101, 6122, 6144,
        6165, 6186, 6207, 6228, 6249, 6270, 6291, 6312, 6333,
        6353, 6374, 6394, 6415, 6435, 6456, 6476, 6496, 6516,
        6536, 6556, 6576, 6596, 6616, 6636, 6656, 6675, 6695,
        6714, 6734, 6753, 6773, 6792, 6811, 6830, 6850, 6869,
        6888, 6907, 6926, 6945, 6963, 6982, 7001, 7020, 7038,
        7057, 7075, 7094, 7112, 7131, 7149, 7168, 7186, 7204,
        7222, 7240, 7258, 7276, 7294, 7312, 7330, 7348, 7366,
        7384, 7401, 7419, 7437, 7454, 7472, 7489, 7507, 7524,
        7542, 7559, 7576, 7594, 7611, 7628, 7645, 7662, 7680,
        7697, 7714, 7731, 7747, 7764, 7781, 7798, 7815, 7832,
        7848, 7865, 7882, 7898, 7915, 7931, 7948, 7964, 7981,
        7997, 8014, 8030, 8046, 8062, 8079, 8095, 8111, 8127,
        8143, 8159, 8175
    };

    // Token: 0x0400044A RID: 1098
    public static short[] UNK4 = new short[]
    {
        4096, 4064, 4033, 4003, 3973, 3944, 3916, 3888, 3861, 3835,
        3809, 3783, 3758, 3734, 3710, 3686, 3663, 3640, 3618, 3596,
        3575, 3554, 3533, 3513, 3493, 3473, 3454, 3435, 3416, 3397,
        3379, 3361, 3344, 3327, 3310, 3293, 3276, 3260, 3244, 3228,
        3213, 3197, 3182, 3167, 3153, 3138, 3124, 3110, 3096, 3082,
        3069, 3055, 3042, 3029, 3016, 3003, 2991, 2978, 2966, 2954,
        2942, 2930, 2919, 2907, 2896, 2885, 2873, 2862, 2852, 2841,
        2830, 2820, 2809, 2799, 2789, 2779, 2769, 2759, 2749, 2740,
        2730, 2721, 2711, 2702, 2693, 2684, 2675, 2666, 2657, 2649,
        2640, 2631, 2623, 2615, 2606, 2598, 2590, 2582, 2574, 2566,
        2558, 2550, 2543, 2535, 2528, 2520, 2513, 2505, 2498, 2491,
        2484, 2477, 2469, 2462, 2456, 2449, 2442, 2435, 2428, 2422,
        2415, 2409, 2402, 2396, 2389, 2383, 2377, 2371, 2364, 2358,
        2352, 2346, 2340, 2334, 2328, 2322, 2317, 2311, 2305, 2299,
        2294, 2288, 2283, 2277, 2272, 2266, 2261, 2255, 2250, 2245,
        2239, 2234, 2229, 2224, 2219, 2214, 2209, 2204, 2199, 2194,
        2189, 2184, 2179, 2174, 2170, 2165, 2160, 2155, 2151, 2146,
        2142, 2137, 2133, 2128, 2124, 2119, 2115, 2110, 2106, 2102,
        2097, 2093, 2089, 2084, 2080, 2076, 2072, 2068, 2064, 2060,
        2056, 2052
    };

    // Token: 0x0400044B RID: 1099


    // Token: 0x0400044D RID: 1101
    public static uint[,] DAT_637DC = new uint[,]
    {
        { 0U, 0U, 2824221714U, 1193984U, 2824221714U, 2824221714U },
        { 0U, 0U, 2824221714U, 1193984U, 2824221714U, 2824221714U }
    };

    // Token: 0x0400044E RID: 1102
    public static uint[,] DAT_637E0 = new uint[,]
    {
        { 0U, 0U, 3116896263U, 4096U, 3116896263U, 3116899591U },
        { 0U, 0U, 3116896263U, 4096U, 3116896263U, 3116899591U }
    };

    // Token: 0x0400044F RID: 1103
    public static Vector3Int[] DAT_63970 = new Vector3Int[]
    {
        new Vector3Int(-2048, -1472, 0),
        new Vector3Int(2048, -1472, 0),
        new Vector3Int(6144, -1472, 0),
        new Vector3Int(-2048, 0, 0),
        new Vector3Int(2048, 0, 0),
        new Vector3Int(6144, 0, 0)
    };

    // Token: 0x04000450 RID: 1104
    public static byte[] DAT_639A0 = new byte[]
    {
        0, 4, 1, 4, 2, 4, 3, 4, 0, 1,
        0, 2, 1, 3, 2, 3
    };

    // Token: 0x04000451 RID: 1105
    public static uint[] DAT_639EC = new uint[]
    {
        4983104U, 21258U, 4655744U, 21262U, 4655424U, 483668U, 25891136U, 21194U, 76500U, 809090U,
        4655424U, 25647444U, 4655424U, 25647444U, 4653780U, 23310U, 4655424U, 25647444U, 25901124U, 741440U,
        4655424U, 25647444U, 21322200U, 469120U, 4655424U, 25647444U, 4655424U, 25647444U, 4655424U, 25647444U
    };

    // Token: 0x04000452 RID: 1106
    public static uint DAT_63A64 = 826366246U;

    // Token: 0x04000453 RID: 1107
    public static uint DAT_63A68 = 0U;

    // Token: 0x04000454 RID: 1108
    public static uint[] DAT_63A6C = new uint[] { 33554432U, 67108864U, 134217728U, 268435456U };

    // Token: 0x04000455 RID: 1109
    public static byte[] DAT_63A7C = new byte[] { 90, 89, 91, 91 };

    // Token: 0x04000456 RID: 1110
    public static ushort[] specialLimit = new ushort[]
    {
        50, 6, 3, 3, 3, 3, 3, 3, 50, 2,
        2, 3, 3, 3, 2, 3, 3, 3
    };

    // Token: 0x04000457 RID: 1111
    public static short[] DAT_63F58 = new short[] { 16, 17, 18, 19 };

    // Token: 0x04000458 RID: 1112
    public static byte[] DAT_63F60 = new byte[] { 0, 0, 0, 0, 1, 1, 2, 3 };

    // Token: 0x04000459 RID: 1113
    public static ushort[] DAT_63F68 = new ushort[] { 2048, 0, 2048, 819, 655 };

    // Token: 0x0400045A RID: 1114
    public static ushort[] DAT_63F74 = new ushort[]
    {
        0, 0, 0, 0, 0, 0, 56, 72, 56, 72,
        56, 72, 63, 70, 59, 77, 63, 70, 67, 81,
        65, 75, 65, 75
    };

    // Token: 0x0400045B RID: 1115
    public static short[] DAT_63FA4 = new short[]
    {
        9, 3, 4, 2, 0, 7, 8, 12, 10, 11,
        14, 13, 15, 6, 20, 21, 22, 23
    };

    // Token: 0x0400045C RID: 1116
    public static int[] DAT_63FC8 = new int[] { 211, 212, 213 };

    // Token: 0x0400045D RID: 1117
    public static short[] DAT_63FE4 = new short[]
    {
        39, -1, 33, 29, 35, 13, 33, 35, -1, -1,
        -1, 36, -1, -1, -1, -1, 37, 38, -1, -1,
        -1, -1, -1, -1, -1, -1, 42, 44, 43, 45,
        -1, -1, -1, -1, -1, -1, 13, 20, -1, -1,
        -1, -1, -1, -1, -1, -1, 138, 136, -1, -1,
        -1, -1, -1, -1, -1, -1, 29, 25, 31, 27
    };

    // Token: 0x0400045E RID: 1118
    public static short[] DAT_6405C = new short[]
    {
        116, 123, -1, -1, -1, -1, -1, -1, -1, -1,
        49, 48, 50, 47, -1, -1, -1, -1, -1, -1
    };

    // Token: 0x0400045F RID: 1119
    public static short[] DAT_64084 = new short[]
    {
        53, 55, 57, 53, -1, -1, -1, -1, 59, -1,
        -1, -1, -1, -1, -1, -1, -1, -1, 79, 81
    };

    // Token: 0x04000460 RID: 1120
    public static int[] DAT_640C8 = new int[] { 24, 12, 8, 0 };

    // Token: 0x04000461 RID: 1121
    public static Color32[] DAT_640AC = new Color32[]
    {
        new Color32(128, 128, 128, 8),
        new Color32(128, 128, 0, 8),
        new Color32(180, 128, 80, 8),
        new Color32(128, 0, 0, 8),
        new Color32(128, 0, 128, 8),
        new Color32(30, 128, 200, 8),
        new Color32(0, 128, 0, 8)
    };


    public static VehicleData[] vehicleConfigs = new VehicleData[]
    {
        new VehicleData
        {
            DAT_00 = new short[] { 16, 12, 48, 152, 64, 128 },
            DAT_0C = 12,
            vehicleID = _VEHICLE.Wonderwagon,
            DAT_0E = 16,
            DAT_0F = -6,
            DAT_10 = 22,
            DAT_11 = 38,
            DAT_12 = 67,
            DAT_13 = 112,
            DAT_14 = 136,
            DAT_15 = 28,
            DAT_16 = 19,
            maxHalfHealth = 683,
            DAT_1A = 983,
            lightness = 5103,
            DAT_20 = 4447,
            peelout = 5,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 6144,
            DAT_2C = new byte[] { 174, 88, 43, 155 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 4, 8, 48, 56, 92, 92 },
            DAT_0C = 12,
            vehicleID = _VEHICLE.Thunderbolt,
            DAT_0E = 18,
            DAT_0F = -2,
            DAT_10 = 19,
            DAT_11 = 32,
            DAT_12 = 57,
            DAT_13 = 148,
            DAT_14 = 200,
            DAT_15 = 50,
            DAT_16 = 36,
            maxHalfHealth = 903,
            DAT_1A = 1203,
            lightness = 4206,
            DAT_20 = 3112,
            peelout = 4,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 10649,
            DAT_2C = new byte[] { 200, 172, 91, 52 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 0, 0, 156, 156, 255, 255 },
            DAT_0C = 12,
            vehicleID = _VEHICLE.DakotaCycle,
            DAT_0E = 40,
            DAT_0F = -2,
            DAT_10 = 25,
            DAT_11 = 32,
            DAT_12 = 64,
            DAT_13 = 112,
            DAT_14 = 128,
            DAT_15 = 24,
            DAT_16 = 16,
            maxHalfHealth = 1200,
            DAT_1A = 1800,
            lightness = 4323,
            DAT_20 = 3750,
            peelout = 7,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 2048,
            DAT_2C = new byte[] { 168, 102, 25, 174 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 8, 8, 64, 64, 92, 92 },
            DAT_0C = 15,
            vehicleID = _VEHICLE.SamsonTow,
            DAT_0E = 9,
            DAT_0F = -2,
            DAT_10 = 48,
            DAT_11 = 67,
            DAT_12 = 131,
            DAT_13 = 44,
            DAT_14 = 52,
            DAT_15 = 49,
            DAT_16 = 35,
            maxHalfHealth = 1069,
            DAT_1A = 1369,
            lightness = 3705,
            DAT_20 = 3112,
            peelout = 1,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 12902,
            DAT_2C = new byte[] { 155, 102, 128, 55 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 24, 28, 40, 40, 32, 32, 1039 },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Livingston,
            DAT_0E = 4,
            DAT_0F = -1,
            DAT_10 = 57,
            DAT_11 = 73,
            DAT_12 = 147,
            DAT_13 = 20,
            DAT_14 = 24,
            DAT_15 = 50,
            DAT_16 = 39,
            maxHalfHealth = 1400,
            DAT_1A = 1700,
            lightness = 2061,
            DAT_20 = 1729,
            peelout = 4,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 18432,
            DAT_2C = new byte[] { 25, 74, 200, 31 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 0, 0, 40, 40, 92, 40 },
            DAT_0C = 3,
            vehicleID = _VEHICLE.Xanadu,
            DAT_0E = 1,
            DAT_0F = 0,
            DAT_10 = 32,
            DAT_11 = 38,
            DAT_12 = 70,
            DAT_13 = 34,
            DAT_14 = 40,
            DAT_15 = 40,
            DAT_16 = 33,
            maxHalfHealth = 1179,
            DAT_1A = 1479,
            lightness = 1541,
            DAT_20 = 1297,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 14336,
            DAT_2C = new byte[] { 57, 88, 152, 71 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 0, 0, 28, 28, 16, 28 },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Palomino,
            DAT_0E = 6,
            DAT_0F = -2,
            DAT_10 = 41,
            DAT_11 = 67,
            DAT_12 = 124,
            DAT_13 = 58,
            DAT_14 = 72,
            DAT_15 = 54,
            DAT_16 = 38,
            maxHalfHealth = 1014,
            DAT_1A = 1314,
            lightness = 3537,
            DAT_20 = 2829,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 12288,
            DAT_2C = new byte[] { 181, 158, 116, 36 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 20, 40, 56, 64, 128, 96 },
            DAT_0C = 12,
            vehicleID = _VEHICLE.ElGuerrero,
            DAT_0E = 8,
            DAT_0F = -3,
            DAT_10 = 22,
            DAT_11 = 35,
            DAT_12 = 67,
            DAT_13 = 101,
            DAT_14 = 120,
            DAT_15 = 47,
            DAT_16 = 33,
            maxHalfHealth = 959,
            DAT_1A = 1259,
            lightness = 3940,
            DAT_20 = 3311,
            peelout = 2,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 11264,
            DAT_2C = new byte[] { 168, 130, 103, 68 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 32, 32, 40, 40, 48, 48, 2051 },
            DAT_0C = 3,
            vehicleID = _VEHICLE.BlueBurro,
            DAT_0E = 0,
            DAT_0F = 0,
            DAT_10 = 28,
            DAT_11 = 38,
            DAT_12 = 80,
            DAT_13 = 34,
            DAT_14 = 40,
            DAT_15 = 37,
            DAT_16 = 35,
            maxHalfHealth = 1290,
            DAT_1A = 1590,
            lightness = 1945,
            DAT_20 = 1638,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 16384,
            DAT_2C = new byte[] { 64, 46, 176, 56 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 20, 20, 64, 64, 128, 128 },
            DAT_0C = 3,
            vehicleID = _VEHICLE.Excelsior,
            DAT_0E = 0,
            DAT_0F = 0,
            DAT_10 = 22,
            DAT_11 = 35,
            DAT_12 = 64,
            DAT_13 = 72,
            DAT_14 = 96,
            DAT_15 = 48,
            DAT_16 = 38,
            maxHalfHealth = 1124,
            DAT_1A = 1424,
            lightness = 2754,
            DAT_20 = 2075,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 13516,
            DAT_2C = new byte[] { 135, 130, 140, 37 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 0, 0, 72, 96, 96, 160 },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Tsunami,
            DAT_0E = 12,
            DAT_0F = -2,
            DAT_10 = 22,
            DAT_11 = 54,
            DAT_12 = 99,
            DAT_13 = 186,
            DAT_14 = byte.MaxValue,
            DAT_15 = 37,
            DAT_16 = 26,
            maxHalfHealth = 628,
            DAT_1A = 928,
            lightness = 3705,
            DAT_20 = 2706,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 3072,
            DAT_2C = new byte[] { 200, 200, 31, 114 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 36, 36, 90, 90, 200, 200 },
            DAT_0C = 3,
            vehicleID = _VEHICLE.Marathon,
            DAT_0E = 8,
            DAT_0F = -4,
            DAT_10 = 6,
            DAT_11 = 12,
            DAT_12 = 25,
            DAT_13 = 191,
            DAT_14 = byte.MaxValue,
            DAT_15 = 18,
            DAT_16 = 12,
            maxHalfHealth = 655,
            DAT_1A = 955,
            lightness = 3176,
            DAT_20 = 1434,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 4096,
            DAT_2C = new byte[] { 109, 60, 37, 200 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 0, 0, 24, 32, 72, 72, 3327 },
            DAT_0C = byte.MaxValue,
            vehicleID = _VEHICLE.Trekker,
            DAT_0E = 0,
            DAT_0F = 0,
            DAT_10 = 38,
            DAT_11 = 60,
            DAT_12 = 115,
            DAT_13 = 58,
            DAT_14 = 72,
            DAT_15 = 20,
            DAT_16 = 19,
            maxHalfHealth = 793,
            DAT_1A = 1093,
            lightness = 5764,
            DAT_20 = 4577,
            peelout = 7,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 9830,
            DAT_2C = new byte[] { 161, 32, 67, 154 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 24, 28, 32, 32, 16, 16, 3331 },
            DAT_0C = 3,
            vehicleID = _VEHICLE.Loader,
            DAT_0E = 0,
            DAT_0F = 0,
            DAT_10 = 22,
            DAT_11 = 38,
            DAT_12 = 67,
            DAT_13 = 48,
            DAT_14 = 56,
            DAT_15 = 47,
            DAT_16 = 38,
            maxHalfHealth = 1345,
            DAT_1A = 1645,
            lightness = 2936,
            DAT_20 = 2490,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 17408,
            DAT_2C = new byte[] { 90, 25, 188, 39 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 48, 44, 64, 64, 200, 200 },
            DAT_0C = 12,
            vehicleID = _VEHICLE.Stinger,
            DAT_0E = 16,
            DAT_0F = -1,
            DAT_10 = 12,
            DAT_11 = 22,
            DAT_12 = 44,
            DAT_13 = 186,
            DAT_14 = byte.MaxValue,
            DAT_15 = 37,
            DAT_16 = 26,
            maxHalfHealth = 710,
            DAT_1A = 1010,
            lightness = 3891,
            DAT_20 = 2829,
            peelout = 4,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 7372,
            DAT_2C = new byte[] { 187, 165, 49, 112 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 48, 48, 88, 88, 224, 224 },
            DAT_0C = 12,
            vehicleID = _VEHICLE.Vertigo,
            DAT_0E = 24,
            DAT_0F = -3,
            DAT_10 = 16,
            DAT_11 = 25,
            DAT_12 = 51,
            DAT_13 = 158,
            DAT_14 = 216,
            DAT_15 = 41,
            DAT_16 = 29,
            maxHalfHealth = 738,
            DAT_1A = 1038,
            lightness = 3705,
            DAT_20 = 2706,
            peelout = 3,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 9216,
            DAT_2C = new byte[] { 194, 186, 55, 93 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 0, 0, 72, 64, 160, 200 },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Goliath,
            DAT_0E = 6,
            DAT_0F = -1,
            DAT_10 = 48,
            DAT_11 = 67,
            DAT_12 = 131,
            DAT_13 = 49,
            DAT_14 = 56,
            DAT_15 = 56,
            DAT_16 = 40,
            maxHalfHealth = 1234,
            DAT_1A = 1534,
            lightness = 4716,
            DAT_20 = 4096,
            peelout = 2,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 15360,
            DAT_2C = new byte[] { 161, 60, 164, 25 }
        },
        new VehicleData
        {
            DAT_00 = new short[] { 52, 52, 64, 64, 128, 128 },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Wapiti,
            DAT_0E = 8,
            DAT_0F = -1,
            DAT_10 = 38,
            DAT_11 = 57,
            DAT_12 = 112,
            DAT_13 = 65,
            DAT_14 = 80,
            DAT_15 = 41,
            DAT_16 = 29,
            maxHalfHealth = 848,
            DAT_1A = 1148,
            lightness = 4511,
            DAT_20 = 3662,
            peelout = 2,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 10240,
            DAT_2C = new byte[] { 187, 116, 79, 95 }
        }
    };

    public static Color32[] DAT_1f800000 = new Color32[32];

    // Token: 0x04000464 RID: 1124
    public static HitDetection hit;

    // Token: 0x04000465 RID: 1125
    public static int DAT_1f800080;

    // Token: 0x04000466 RID: 1126
    public static Vector3Int DAT_1f800084;

    // Token: 0x04000467 RID: 1127
    public static short DAT_1f800094;
    public short DAT_1f800094_;

    // Token: 0x04000468 RID: 1128
    public static short DAT_1f800096;
    public short DAT_1f800096_;

    // Token: 0x04000469 RID: 1129
    public static short DAT_1f800098;
    public short DAT_1f800098_;

    // Token: 0x0400046A RID: 1130
    public static short DAT_1f80009a;
    public short DAT_1f80009a_;

    // Token: 0x0400046B RID: 1131
    public static TerrainScreen[] terrainScreen = new TerrainScreen[40];

    // Token: 0x0400046C RID: 1132
    public static AudioSource[] voices = new AudioSource[24];

    // Token: 0x0400046D RID: 1133
    public static Matrix3x3 DAT_718 = new Matrix3x3
    {
        V00 = 4096,
        V01 = 0,
        V02 = 0,
        V10 = 0,
        V11 = 0,
        V12 = 0,
        V20 = 0,
        V21 = 0,
        V22 = 0
    };

    // Token: 0x0400046E RID: 1134
    public static byte[] DAT_854 = new byte[]
    {
        12, 32, 20, 32, 12, 24, 12, 24, 16, 28,
        12, 28, 24, 24, 0, 24
    };

    // Token: 0x0400046F RID: 1135
    public static ushort[] DAT_854_2 = new ushort[]
    {
        12, 20, 28, 40, 20, 28, 28, 40, 12, 20,
        20, 32, 12, 16, 20, 32, 16, 28, 24, 40,
        12, 0, 24, 40, 20, 32, 20, 32, 0, 0,
        20, 32
    };

    // Token: 0x04000470 RID: 1136
    public static VigTransform defaultTransform = new VigTransform
    {
        rotation = new Matrix3x3
        {
            V00 = 4096,
            V01 = 0,
            V02 = 0,
            V10 = 0,
            V11 = 4096,
            V12 = 0,
            V20 = 0,
            V21 = 0,
            V22 = 4096
        },
        position = new Vector3Int(0, 0, 0)
    };

    // Token: 0x04000471 RID: 1137
    public static Vector3Int DAT_9C4 = new Vector3Int(0, 0, 0);

    // Token: 0x04000472 RID: 1138
    public static byte[] DAT_A14 = new byte[] { 0, 1, 2, 3 };

    // Token: 0x04000473 RID: 1139
    public static Vector3Int DAT_A18 = new Vector3Int(0, 0, 196608);

    // Token: 0x04000474 RID: 1140
    public static Vector3Int DAT_A24 = new Vector3Int(0, 26624, 0);

    // Token: 0x04000475 RID: 1141
    public static Vector3Int DAT_A30 = new Vector3Int(0, 0, -32768);

    // Token: 0x04000476 RID: 1142
    public static Vector3Int DAT_A3C = new Vector3Int(0, 0, -131072);

    // Token: 0x04000477 RID: 1143
    public static Vector3Int DAT_A4C = new Vector3Int(0, 131072, 0);

    // Token: 0x04000478 RID: 1144
    public static Vector3Int DAT_A5C = new Vector3Int(0, -131072, 0);

    // Token: 0x04000479 RID: 1145
    public static Vector3Int DAT_A68 = new Vector3Int(0, 32768, 0);

    // Token: 0x0400047A RID: 1146
    public static short[] DAT_BC0 = new short[]
    {
        2, 3, 4, 5, 6, 7, 8, 9, 24, 25,
        31, 0, 10, 11, 12, 13, 14, 15, 16, 17,
        18, 19, 20, 58, 63, 64, 65, 66, 75, 0,
        75, 67, 68, 71, 72, 73, 74
    };

    // Token: 0x0400047B RID: 1147
    public static List<Junction> updateJunc = new List<Junction>();

    // Token: 0x0400047C RID: 1148
    public VigTerrain terrain;

    // Token: 0x0400047D RID: 1149
    public LevelManager levelManager;

    // Token: 0x0400047E RID: 1150
    public VigConfig commonWheelConfiguration;

    // Token: 0x0400047F RID: 1151
    public Vehicle[] playerObjects;

    // Token: 0x04000480 RID: 1152
    public VigCamera[] cameraObjects;

    // Token: 0x04000481 RID: 1153
    public byte[] vehicles;

    // Token: 0x04000482 RID: 1154

    [Header("BPS")]
    [SerializeField]
    public BSP bspTree = null;

    // Token: 0x04000485 RID: 1157 
    public int translateFactor = 10000; //4096

    // Token: 0x04000486 RID: 1158
    public int translateFactor2 = 1000; //16

    // Token: 0x04000487 RID: 1159
    public float pixelSnapMin = 0.002f;

    // Token: 0x04000488 RID: 1160
    public float pixelSnapMax = 0.998f;

    // Token: 0x04000489 RID: 1161
    private NativeArray<Vector2Int> nativeArray;

    // Token: 0x0400048A RID: 1162
    private GameManager.TerrainJob terrainJob;

    // Token: 0x0400048B RID: 1163
    private JobHandle terrainHandle;

    // Token: 0x0400048C RID: 1164
    public Queue<ScreenPoly> DAT_610;

    // Token: 0x0400048D RID: 1165
    public bool DAT_83B;

    public byte difficultyMode;

    public sbyte[] damageMode;

    public Color32[] DAT_CE0;

    // Token: 0x04000491 RID: 1169
    public ushort[] DAT_CF0;

    // Token: 0x04000492 RID: 1170
    public byte[,] DAT_CF4;

    // Token: 0x04000493 RID: 1171
    public byte DAT_CF8;

    // Token: 0x04000494 RID: 1172
    public byte[] DAT_CFC;

    // Token: 0x04000495 RID: 1173
    public byte DAT_D08;

    // Token: 0x04000496 RID: 1174
    public int DAT_D0C;

    // Token: 0x04000497 RID: 1175
    public byte[] DAT_D18;

    // Token: 0x04000498 RID: 1176
    public byte[] DAT_D19;

    // Token: 0x04000499 RID: 1177
    public byte[] DAT_D1A;

    // Token: 0x0400049A RID: 1178
    public byte[] DAT_D1B;

    // Token: 0x0400049B RID: 1179
    public byte[,] DAT_D28;

    // Token: 0x0400049C RID: 1180
    public int DAT_DA0; //Amplia Horizontalmente el agua

    // Token: 0x0400049D RID: 1181
    public ushort DAT_DA8;

    // Token: 0x0400049E RID: 1182
    public int DAT_DB0; //Altura del Agua

    // Token: 0x0400049F RID: 1183

    public short drawDistance1;
    public short drawDistance2;
    public short drawDistance3;
    public short DAT_DB4;

    // Token: 0x040004A0 RID: 1184
    public short DAT_DB6;

    // Token: 0x040004A1 RID: 1185
    public short DAT_DB8;

    // Token: 0x040004A2 RID: 1186
    public VigTransform DAT_F00;

    // Token: 0x040004A3 RID: 1187
    public int DAT_F20 = 240; //871?

    // Token: 0x040004A4 RID: 1188
    public VigTransform DAT_F28;

    // Token: 0x040004A5 RID: 1189
    public Matrix3x3 DAT_F48;

    // Token: 0x040004A6 RID: 1190
    public Matrix3x3 DAT_F68; //Posicion luz?

    // Token: 0x040004A7 RID: 1191
    public VigTransform DAT_F88;

    // Token: 0x040004A8 RID: 1192
    public Matrix3x3 DAT_FA8;

    // Token: 0x040004A9 RID: 1193
    public Vector2Int DAT_FC8;

    // Token: 0x040004AA RID: 1194
    public Matrix3x3 DAT_FD8;

    // Token: 0x040004AB RID: 1195
    public short DAT_E1C;

    // Token: 0x040004AC RID: 1196
    public VigTransform DAT_EA8;

    // Token: 0x040004AD RID: 1197
    public Vector3Int DAT_EC8;

    // Token: 0x040004AE RID: 1198
    public int DAT_ED8; //250

    // Token: 0x040004AF RID: 1199
    public int DAT_EDC; //550

    // Token: 0x040004B0 RID: 1200
    public VigTransform DAT_EE0;

    // Token: 0x040004B1 RID: 1201
    public byte DAT_1000;

    // Token: 0x040004B2 RID: 1202
    public byte DAT_1002;

    // Token: 0x040004B3 RID: 1203
    public byte DAT_1004;

    // Token: 0x040004B4 RID: 1204
    public int DAT_101C;

    // Token: 0x040004B5 RID: 1205
    public int DAT_1028;

    // Token: 0x040004B6 RID: 1206
    public sbyte[] DAT_1030;

    // Token: 0x040004B7 RID: 1207
    public sbyte playerSpawns;

    // Token: 0x040004B8 RID: 1208
    public int DAT_1038;

    public int DAT_1084;

    public int DAT_10F0;
    public sbyte DAT_111C;
    public SunLensFlare DAT_1124;
    public sbyte[] DAT_1128;
    public int DAT_1130;
    public Navigation DAT_1138;
    public VigMesh[] DAT_1150;
    public VehicleStats[] vehicleStats;
    public uint DAT_E44;
    public int DAT_C74;
    public int EnemyKill;
    public byte DAT_898;
    public List<AudioClip> DAT_C2C;
    public ushort timer;
    public ushort[,] DAT_08;
    public int DAT_20;
    public int DAT_24;
    public int DAT_28;
    public _SCREEN_MODE screenMode;
    public _GAME_MODE gameMode;
    public bool gameEnded;
    public bool DAT_36;
    public int gravityFactor;
    public int DAT_40;
    public int map;
    public Material targetHUD;
    public Material targetTextPrefab;
    public _DITHERING ditheringMethod;
    public bool drawPlayer;
    public bool drawObjects;
    public bool drawTerrain;
    public bool drawRoads;
    public bool playMusic;
    public bool inDebug;
    public bool inMenu;
    public bool autoTarget;
    public bool ready;
    public float max;
    public float terrainHeight;
    public float offsetFactor;
    public float offsetStart;
    public float angleOffset;
    public float aspectRatioScale;
    public StatsPanel statsPanel;
    public GameObject selectOptions;
    public GameObject panelOnline;
    public Dropdown driverDropdown;
    public Dropdown stageDropdown;
    public Dropdown ditheringDropdown;
    public Dropdown gameModeDropdown;
    public Dropdown mpModeDropdown;
    public Dropdown damageDropdown;
    public Dropdown difficultyDropdown;
    public Dropdown onlineDmgDropdown;
    public Dropdown livesDropdown;
    public Dropdown gravityDropdown;
    public Toggle drawPlayerToggle;
    public Toggle drawObjectsToggle;
    public Toggle drawTerrainToggle;
    public Toggle drawRoadsToggle;
    public Toggle[] spawnEnemiesToggle;
    public Toggle disableDpadToggle;
    public Toggle disableAutoTarget;
    public Toggle disableDriverPlus;
    public Toggle enableExperimentalDakota;
    public RectTransform spawnsRect;
    public List<int> playable;
    public List<int> survival;
    public int currentSpawn;
    public int wrenchCount;
    public bool lowHealth;
    public int totalSpawns;
    public int aiMin;
    public int aiMax;
    public int spawns;
    public bool paused;
    public bool noAI;
    public bool noPhysics;
    public bool noHUD;
    public bool DriverPlus;
    public bool experimentalDakota;
    public bool enableReticle;

    [Serializable]
    public class SerializableVehicle<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        [SerializeField]
        private List<TKey> vehicleList = new List<TKey>();

        [SerializeField]
        private List<TValue> vehicleElement = new List<TValue>();

        public void OnBeforeSerialize()
        {
            vehicleList.Clear();
            vehicleElement.Clear();

            foreach (var pair in this)
            {
                vehicleList.Add(pair.Key);
                vehicleElement.Add(pair.Value);
            }
        }

        public void OnAfterDeserialize()
        {
            this.Clear();

            if (vehicleList.Count != vehicleElement.Count)
            {
                Debug.LogError("Error al deserializar el diccionario. La cantidad de claves y valores no coincide.");
                return;
            }

            for (int i = 0; i < vehicleList.Count; i++)
            {
                this[vehicleList[i]] = vehicleElement[i];
            }
        }
    }

    [Header("Network Members")]
    [SerializeField]
    public SerializableVehicle<long, Vehicle> networkMembers = new SerializableVehicle<long, Vehicle>();
    public List<VigObject> networkObjs;
    public SerializableVehicle<long, short> networkIds = new SerializableVehicle<long, short>();
    public List<Vehicle> networkEnemies;
    public SerializableVehicle<short, Vehicle> enemiesDictionary = new SerializableVehicle<short, Vehicle>();
    public int leash;
    private bool atStart;
    public int driverPlus = 0;
    int Players;
    private Player player;
    public void SetGravity()
    {
        switch (gravityDropdown.value)
        {
            case 0:
                gravityFactor = 5760;
                break;
            case 1:
                gravityFactor = 11520;
                break;
            case 2:
                gravityFactor = 23040;
                break;
        }
    }
    public void SetPlayer(Packet _packet)
    {
        Debug.Log("User ID: " + _packet);
        Players += 1;
        statsPanel.SpawnVehicle(Players, 0);
    }
    public async void SetDriver()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            //switch (statsPanel.cursor)
            switch (driverDropdown.value)
            {
                case 0:
                    vehicles[0] = 0;
                    break;
                case 1:
                    vehicles[0] = 1;
                    break;
                case 2:
                    vehicles[0] = 2;
                    break;
                case 3:
                    vehicles[0] = 3;
                    break;
                case 4:
                    vehicles[0] = 4;
                    break;
                case 5:
                    vehicles[0] = 5;
                    break;
                case 6:
                    vehicles[0] = 6;
                    break;
                case 7:
                    vehicles[0] = 7;
                    break;
                case 8:
                    vehicles[0] = 8;
                    break;
                case 9:
                    vehicles[0] = 9;
                    break;
                case 10:
                    vehicles[0] = 10;
                    break;
                case 11:
                    vehicles[0] = 11;
                    break;
                case 12:
                    vehicles[0] = 12;
                    break;
                case 13:
                    vehicles[0] = 13;
                    break;
                case 14:
                    vehicles[0] = 14;
                    break;
                case 15:
                    vehicles[0] = 15;
                    break;
                case 16:
                    vehicles[0] = 16;
                    break;
                case 17:
                    vehicles[0] = 17;
                    break;
                case 18:
                    vehicles[0] = 21;
                    break;
                case 19:
                    vehicles[0] = 22;
                    break;
                case 20:
                    vehicles[0] = 23;
                    break;
                case 21:
                    vehicles[0] = 24;
                    break;
                case 22:
                    vehicles[0] = 25;
                    break;
                case 23:
                    vehicles[0] = 26;
                    break;
                case 24:
                    vehicles[0] = 27;
                    break;
                case 25:
                    vehicles[0] = 28;
                    break;
                case 26:
                    vehicles[0] = 29;
                    break;
                case 27:
                    vehicles[0] = 30;
                    break;
                case 28:
                    vehicles[0] = 31;
                    break;
                case 29:
                    vehicles[0] = 32;
                    break;
                case 30:
                    vehicles[0] = 33;
                    break;
                case 31:
                    vehicles[0] = 34;
                    break;
                case 32:
                    vehicles[0] = 35;
                    break;
                case 33:
                    vehicles[0] = 36;
                    break;
                case 34:
                    vehicles[0] = 37;
                    break;
                case 35:
                    vehicles[0] = 38;
                    break;
            }
            //driverDropdown.value = vehicles[0];
            if (online)
                await ClientSend.NotReady(0L).ContinueWith(Task =>
                    {

                    });
            Demo.instance.readyLabel.gameObject.SetActive(value: true);
            Demo.instance.notReadyLabel.gameObject.SetActive(value: false);
            Demo.instance.SetupPlaceholders();
            await Task.Yield(); // Esperar un frame
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            //            Demo.instance.componentPanel.Find("Vehicle/Dakota").gameObject.SetActive(false);
            switch (driverDropdown.value)
            {
                case 0:
                    vehicles[0] = 0;
                    break;
                case 1:
                    vehicles[0] = 1;
                    break;
                case 2:
                    vehicles[0] = 2;
                    //if (!online)
                    //Demo.instance.componentPanel.Find("Vehicle/Dakota").gameObject.SetActive(true);
                    break;
                case 3:
                    vehicles[0] = 3;
                    break;
                case 4:
                    vehicles[0] = 4;
                    break;
                case 5:
                    vehicles[0] = 5;
                    break;
                case 6:
                    vehicles[0] = 6;
                    break;
                case 7:
                    vehicles[0] = 7;
                    break;
                case 8:
                    vehicles[0] = 8;
                    break;
                case 9:
                    vehicles[0] = 9;
                    break;
                case 10:
                    vehicles[0] = 10;
                    break;
                case 11:
                    vehicles[0] = 11;
                    break;
                case 12:
                    vehicles[0] = 12;
                    break;
                case 13:
                    vehicles[0] = 13;
                    break;
                case 14:
                    vehicles[0] = 14;
                    break;
                case 15:
                    vehicles[0] = 15;
                    break;
                case 16:
                    vehicles[0] = 16;
                    break;
                case 17:
                    vehicles[0] = 17;
                    break;
            }
            if (online)
                await ClientSend.NotReady(0L).ContinueWith(Task =>
                    {

                    });
            Demo.instance.readyLabel.gameObject.SetActive(value: true);
            Demo.instance.notReadyLabel.gameObject.SetActive(value: false);
            Demo.instance.SetupPlaceholders();
        }
        await Task.Yield(); // Esperar un frame
    }

    public async void SetStage()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            switch (map)
            {
                case 1:
                    mapText = "Arizona - MeteorCrater";
                    break;
                case 2:
                    mapText = "Utah - Winter Games";
                    break;
                case 3:
                    mapText = "Louisiana - Ghastly Bayou";
                    break;
                case 4:
                    mapText = "Florida - Launch Site";
                    break;
                case 5:
                    mapText = "Pennsylvania - Steel Mill";
                    break;
                case 6:
                    mapText = "Minnesota - Nuclear Plant";
                    break;
                case 7:
                    mapText = "Alaska - Alaskan Pipeline";
                    break;
                case 8:
                    mapText = "California - Pacific Harbor";
                    break;
                case 9:
                    mapText = "Nevada - Secret Base";
                    break;
                case 10:
                    mapText = "Utah - Sand Factory";
                    break;
                case 11:
                    mapText = "New - Mexico Oil Fields";
                    break;
                case 12:
                    mapText = "Arizona - Aircraft Graveyard";
                    break;
                case 13:
                    mapText = "New Mexico - Ghost Town";
                    break;
                case 14:
                    mapText = "Arizona Nevada - Hoover Dam";
                    break;
                case 15:
                    mapText = "California - Valley Farms";
                    break;
                case 16:
                    mapText = "Nevada - Casino City";
                    break;
                case 17:
                    mapText = "Utah - Canyonlands";
                    break;
                case 18:
                    mapText = "Colorado - Ski Resort";
                    break;
            }
            if (inDebug)
            {
                Debug.Log("MAP: " + map);
                Debug.Log("statsPanel.maps: " + statsPanel.maps);
                selectOptions.transform.Find("Map/Preview").GetComponent<Image>().sprite = statsPanel.maps[map - 1];
                selectOptions.transform.Find("Map/Text (TMP)").GetComponent<TextMeshProUGUI>().text = mapText.ToString();
            }
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            map = stageDropdown.value + 1;
            Debug.Log("Scene Set: " + map);
        }
        if (online)
            await ClientSend.Map(0L).ContinueWith(Task =>
                    {

                    });
        await Task.Yield(); // Esperar un frame
    }

    public void SetDithering()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            ditheringMethod = _DITHERING.None;
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            switch (ditheringDropdown.value)
            {
                case 0:
                    ditheringMethod = _DITHERING.None;
                    break;
                case 1:
                    ditheringMethod = _DITHERING.Standard;
                    break;
                case 2:
                    ditheringMethod = _DITHERING.PSX;
                    break;
            }
        }
    }

    public async void SetLives()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            selectOptions.transform.Find("Lives/Text (TMP)").GetComponent<TextMeshProUGUI>().text = currentValueLives.ToString();

            sbyte b = playerSpawns = (sbyte)(currentValueLives);
            for (int i = 0; i < networkMembers.Count; i++)
            {
                DAT_1030[i] = b;
            }
        }
        if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            sbyte b = playerSpawns = (sbyte)(livesDropdown.value + 1);
            for (int i = 0; i < networkMembers.Count; i++)
            {
                DAT_1030[i] = b;
            }
        }
        if (online)
            await ClientSend.Lives(playerSpawns, 0L).ContinueWith(Task =>
                    {

                    });
        await Task.Yield(); // Esperar un frame
    }

    public void SetGameMode()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            switch (modeIndex)
            {
                case 0:
                    gameMode = _GAME_MODE.Arcade;
                    break;
                case 1:
                    gameMode = _GAME_MODE.Survival;
                    DAT_1030[0] = 1;
                    DAT_1030[1] = 0;
                    DAT_1030[2] = 0;
                    DAT_1030[3] = 0;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            switch (gameModeDropdown.value)
            {
                case 0:
                    gameMode = _GAME_MODE.Arcade;
                    spawnsRect.gameObject.SetActive(value: true);
                    break;
                case 1:
                    gameMode = _GAME_MODE.Survival;
                    spawnsRect.gameObject.SetActive(value: false);
                    DAT_1030[0] = 1;
                    DAT_1030[1] = 0;
                    DAT_1030[2] = 0;
                    DAT_1030[3] = 0;
                    break;
            }
        }
    }

    public async void SetMultiplayerMode()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            switch (modeIndex)
            {
                case 10:
                    gameMode = _GAME_MODE.Versus2;
                    selectOptions.transform.Find("Lives").gameObject.SetActive(value: true);
                    selectOptions.transform.Find("Space 1").gameObject.SetActive(value: false);
                    selectOptions.transform.Find("Damages").gameObject.SetActive(value: true);
                    selectOptions.transform.Find("Space 2").gameObject.SetActive(value: false);
                    selectOptions.transform.Find("Difficulty").gameObject.SetActive(value: false);
                    selectOptions.transform.Find("Space 3").gameObject.SetActive(value: true);
                    break;
                case 11:
                    gameMode = _GAME_MODE.Coop2;
                    selectOptions.transform.Find("Lives").gameObject.SetActive(value: false);
                    selectOptions.transform.Find("Space 1").gameObject.SetActive(value: true);
                    selectOptions.transform.Find("Damages").gameObject.SetActive(value: true);
                    selectOptions.transform.Find("Space 2").gameObject.SetActive(value: false);
                    selectOptions.transform.Find("Difficulty").gameObject.SetActive(value: true);
                    selectOptions.transform.Find("Space 3").gameObject.SetActive(value: false);
                    DAT_1030[0] = 1;
                    DAT_1030[1] = 1;
                    DAT_1030[2] = 1;
                    DAT_1030[3] = 1;
                    DAT_1030[4] = 1;
                    DAT_1030[5] = 1;
                    break;
                case 12:
                    gameMode = _GAME_MODE.Survival2;
                    selectOptions.transform.Find("Lives").gameObject.SetActive(value: false);
                    selectOptions.transform.Find("Space 1").gameObject.SetActive(value: true);
                    selectOptions.transform.Find("Damages").gameObject.SetActive(value: true);
                    selectOptions.transform.Find("Space 2").gameObject.SetActive(value: false);
                    selectOptions.transform.Find("Difficulty").gameObject.SetActive(value: true);
                    selectOptions.transform.Find("Space 3").gameObject.SetActive(value: false);
                    DAT_1030[0] = 1;
                    DAT_1030[1] = 0;
                    DAT_1030[2] = 0;
                    DAT_1030[3] = 0;
                    break;
            }
            selectOptions.transform.Find("Mode/Text (TMP)").GetComponent<TextMeshProUGUI>().text = gameMode.ToString().Substring(0, gameMode.ToString().Length - 1);
            if (online)
                await ClientSend.Mode(0L).ContinueWith(Task =>
                    {

                    });
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            Debug.Log("MODE: " + mpModeDropdown.value);
            switch (mpModeDropdown.value)
            {
                case 0:
                    gameMode = _GAME_MODE.Versus2;
                    livesDropdown.transform.parent.gameObject.SetActive(value: true);
                    onlineDmgDropdown.transform.parent.gameObject.SetActive(value: true);
                    damageDropdown.transform.parent.gameObject.SetActive(value: false);
                    difficultyDropdown.transform.parent.gameObject.SetActive(value: false);
                    break;
                case 1:
                    gameMode = _GAME_MODE.Coop2;
                    livesDropdown.transform.parent.gameObject.SetActive(value: false);
                    onlineDmgDropdown.transform.parent.gameObject.SetActive(value: false);
                    damageDropdown.transform.parent.gameObject.SetActive(value: true);
                    difficultyDropdown.transform.parent.gameObject.SetActive(value: true);
                    DAT_1030[0] = 1;
                    DAT_1030[1] = 1;
                    DAT_1030[2] = 1;
                    DAT_1030[3] = 1;
                    DAT_1030[4] = 1;
                    DAT_1030[5] = 1;
                    break;
                case 2:
                    gameMode = _GAME_MODE.Survival2;
                    livesDropdown.transform.parent.gameObject.SetActive(value: false);
                    onlineDmgDropdown.transform.parent.gameObject.SetActive(value: false);
                    damageDropdown.transform.parent.gameObject.SetActive(value: true);
                    difficultyDropdown.transform.parent.gameObject.SetActive(value: true);
                    DAT_1030[0] = 1;
                    DAT_1030[1] = 0;
                    DAT_1030[2] = 0;
                    DAT_1030[3] = 0;
                    break;
            }
            if (online)
                await ClientSend.Mode(0L).ContinueWith(Task =>
                    {

                    });
        }
        await Task.Yield(); // Esperar un frame
    }

    public async void SetDamage()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            switch (currentDamageIndex)
            {
                case 1:
                    damageText = "Low";
                    break;
                case 2:
                    damageText = "Normal";
                    break;
                case 3:
                    damageText = "High";
                    break;
            }
            selectOptions.transform.Find("Damages/Text (TMP)").GetComponent<TextMeshProUGUI>().text = damageText;
            if (online)
                await ClientSend.Damage(0L).ContinueWith(Task =>
                    {

                    });
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            int value = damageDropdown.value;
            damageMode[0] = (sbyte)value;
            damageMode[1] = (sbyte)value;
            if (online)
                await ClientSend.Damage(0L).ContinueWith(Task =>
                    {

                    });
        }
        await Task.Yield(); // Esperar un frame
    }

    public async void SetDifficulty()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            switch (currentValueDifficulty)
            {
                case 1:
                    difficultyInt = 86;
                    break;
                case 2:
                    difficultyInt = 89;
                    break;
                case 3:
                    difficultyInt = 92;
                    break;
            }
            int value = currentValueDifficulty;
            this.difficultyMode = (byte)value;
            selectOptions.transform.Find("Difficulty/Text (TMP)").GetComponent<TextMeshProUGUI>().text = difficultyInt.ToString();
            if (online)
                await ClientSend.Difficulty(0L).ContinueWith(Task =>
                    {

                    });
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            int value = difficultyDropdown.value;
            this.difficultyMode = (byte)value;
            if (online)
                await ClientSend.Difficulty(0L).ContinueWith(Task =>
                    {

                    });
        }
        await Task.Yield(); // Esperar un frame
    }

    public async void SetOnlineDamage()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            switch (currentDamageIndex)
            {
                case 1:
                    damageText = "Low";
                    break;
                case 2:
                    damageText = "Normal";
                    break;
                case 3:
                    damageText = "High";
                    break;
            }

            selectOptions.transform.Find("Damages/Text (TMP)").GetComponent<TextMeshProUGUI>().text = damageText;

            int value = currentDamageIndex;
            this.difficultyMode = (byte)value;
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            int value = onlineDmgDropdown.value;
            this.difficultyMode = (byte)value;
        }
        if (online)
            await ClientSend.Difficulty(0L).ContinueWith(Task =>
                    {

                    });
        await Task.Yield(); // Esperar un frame
    }
    public void SetDrawPlayer()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
            drawPlayer = true;
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            drawPlayer = drawPlayerToggle.isOn;
            drawPlayer = drawPlayerToggle.isOn;
        }
    }

    public void SetDrawObjects()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
            drawObjects = true;
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            drawObjects = drawObjectsToggle.isOn;
        }
    }

    public void SetDrawTerrain()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
            drawTerrain = true;
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            drawTerrain = drawTerrainToggle.isOn;
        }
    }

    public void SetDrawRoads()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
            drawRoads = true;
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            drawRoads = drawRoadsToggle.isOn;
        }
    }

    public void SetEnemySpawn(int index)
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
            DAT_1030[index] = 1;
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            DAT_1030[index] = (sbyte)(spawnEnemiesToggle[index].isOn ? 1 : 0);
        }
    }

    public void SetDPAD()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
        DAT_637E0[0, 5] = (disableDpadToggle.isOn ? 7431u : 3116899591u);
    }

    public void SetAutoTarget()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
        autoTarget = (disableAutoTarget.isOn ? true : false);
    }
    public void SetPLUS()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
        DriverPlus = (disableDriverPlus.isOn ? true : false);
    }

    public void SetExperimentalDakota()
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            FUN_1E098(1, Menu.instance.sounds, 10, 4095);
            experimentalDakota = false;
        }
        else if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            //experimentalDakota = false;
            experimentalDakota = enableExperimentalDakota.isOn;
        }
    }

    [Obsolete]
    public async void SetPlayerReady(bool ready)
    {
        this.ready = ready;
        if (ready)
        {
            if (online)
                await ClientSend.Ready(0L).ContinueWith(Task =>
                    {

                    });
        }
        else
        {
            if (online)
                await ClientSend.NotReady(0L).ContinueWith(Task =>
                    {

                    });
        }
        await Task.Yield(); // Esperar un frame
    }

    public void RandomizeEnemies(int players)
    {
        List<int> list = new List<int>(this.playable);
        this.survival = new List<int>();
        int num = this.playable.Count - players;
        for (int i = 0; i < num; i++)
        {
            int num2;
            do
            {
                num2 = UnityEngine.Random.Range(0, list.Count);
            }
            while (list[num2] == (int)this.vehicles[0] || list[num2] == (int)this.vehicles[1]);
            this.survival.Add(list[num2]);
            list.RemoveAt(num2);
        }
        for (int j = 0; j < 6; j++)
        {
            if (this.gameMode == _GAME_MODE.Arcade)
            {
                this.SetEnemySpawn(j);
            }
            int num3;
            do
            {
                num3 = UnityEngine.Random.Range(0, this.playable.Count);
            }
            while (this.playable[num3] == (int)this.vehicles[0] || this.playable[num3] == (int)this.vehicles[1]);
            this.vehicles[j + 2] = (byte)this.playable[num3];
            this.playable.RemoveAt(num3);
        }
    }

    //public void RandomizeEnemies(int players)
    //{
    //    List<int> list = new List<int>(playable);
    //    survival = new List<int>();
    //    int num = playable.Count - players;
    //    for (int i = 0; i < num; i++)
    //    {
    //        int index;
    //        do
    //        {
    //            index = UnityEngine.Random.Range(0, list.Count);
    //        }
    //        while (list[index] == vehicles[0] || list[index] == vehicles[1]);
    //        survival.Add(list[index]);
    //        list.RemoveAt(index);
    //    }

    //    int playerammount = 4;

    //    if (players == 1)
    //    {
    //        playerammount = 4;
    //        Debug.Log("Singleplayer Iniciado");
    //    }
    //    else if (players == 2)
    //    {
    //        playerammount = 6;
    //        Debug.Log("Multiplayer Iniciado");
    //    }

    //    Debug.Log("Jugadores-Capacidad: " + playable.Capacity);
    //    Debug.Log("Jugadores-Cantidad: " + playable.Count);


    //    for (int j = 0; j < playerammount; j++)
    //    {
    //        if (gameMode == _GAME_MODE.Arcade)
    //        {
    //            SetEnemySpawn(j);
    //        }
    //        int index2;
    //        do
    //        {
    //            index2 = UnityEngine.Random.Range(0, playable.Count);
    //            //Debug.Log("Playable Count: " + playable.Count);
    //        }
    //        while (playable[index2] == vehicles[0] || playable[index2] == vehicles[1]);
    //        vehicles[j + 2] = (byte)playable[index2];
    //        playable.RemoveAt(index2);
    //    }
    //}

    public void setOnline(bool setOnline)
    {
#if UNITY_SWITCH
#elif UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
        online = setOnline;
#endif
    }
    public bool online = false;

    [Obsolete]
    public async void LoadLevel()
    {
        online = false;
        SetDriver();
        SetPLUS();
        if (DriverPlus)
            vehicles[0] += 21;
        //Debug.Log("Set Player: " + statsPanel.cursor);
        SetStage();
        SetDithering();
        SetGameMode();
        SetDamage();
        SetDifficulty();
        SetDrawPlayer();
        SetDrawObjects();
        SetDrawTerrain();
        SetDrawRoads();
        SetDPAD();
        SetAutoTarget();
        //SetExperimentalDakota();
        //RandomizeEnemies(1);

        //vehicles[0] = driverPlayer;

        List<int> prev = new List<int>(playable);
        survival = new List<int>();
        int count = playable.Count - 1;

        for (int i = 0; i < count; i++)
        {
            do
            {
                int random = UnityEngine.Random.Range(0, prev.Count);

                if (prev[random] != vehicles[0])
                {
                    survival.Add(prev[random]);
                    prev.RemoveAt(random);
                    break;
                }
            } while (true);
        }

        for (int i = 0; i < 4; i++)
        {
            if (gameMode == _GAME_MODE.Arcade)
                SetEnemySpawn(i);

            do
            {
                int random = UnityEngine.Random.Range(0, playable.Count);

                if (playable[random] != vehicles[0])
                {
                    vehicles[i + 2] = (byte)playable[random];
                    playable.RemoveAt(random);
                    break;
                }
            } while (true);
        }

        totalSpawns = DAT_1030[0] + DAT_1030[1] + DAT_1030[2] + DAT_1030[3];
        UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
        await LoadSceneAsyncWithDelay(map);
        await Task.Yield(); // Esperar un frame
    }
    public bool isHost = false;

    public bool isParty = false;

    public bool sceneLoadedDone = false;

    public void waitLoadMultiplayerLevel(bool isWaitHost)
    {
        paused = !paused;
        isWait = !isWait;
        DestroyProgressBar();
        MusicManager.instance.PlayNextMusic().ContinueWith(Task =>
                   {

                   });
        //SceneManager.UnloadSceneAsync(19);
        //inDebug = false;
        //inMenu = false;
        //asyncLoadScene.allowSceneActivation = true;
        //asyncSceneMap.allowSceneActivation = true;
        //isHost = isWaitHost;
        Debug.Log("El Host hizo algo!");
    }

    [Obsolete]
    public async void LoadMultiplayerLevel(bool isHosting)
    {

        //online = true;
        //Debug.Log("Set Player: " + statsPanel.cursor);

        experimentalDakota = false;
        SetDriver();
        SetPLUS();
        if (DriverPlus)
            vehicles[0] += 21;
        SetDPAD();
        SetAutoTarget();

        SetDamage();
        SetDrawPlayer();

        if (online)
            await ClientSend.Ready(0L).ContinueWith(Task =>
                    {

                    });
        if (isHosting)
        {
            SetMultiplayerMode();
            //gameMode = _GAME_MODE.Quest;
            SetStage();
            if (gameMode == _GAME_MODE.Versus2)
            {
                SetOnlineDamage();
                SetLives();
            }
            else
            {
                SetDamage();
                SetDifficulty();
            }
            if (online)
                //DiscordController.instance.SetLobbyMetadata("level", Demo.mapNames[map - 1]);
                DiscordController.SetLobbyMetadata("level", Demo.mapNames[map - 1]);
            while (DiscordController.instance.pendingCallbacks)
            {
                DiscordController.instance.discord.RunCallbacks();
            }
            //RandomizeEnemies(2);

            List<int> prev = new List<int>(playable);
            survival = new List<int>();
            int count = playable.Count - 2;

            for (int i = 0; i < count; i++)
            {
                do
                {
                    int random = UnityEngine.Random.Range(0, prev.Count);

                    if (prev[random] != vehicles[0])
                    {
                        survival.Add(prev[random]);
                        prev.RemoveAt(random);
                        break;
                    }
                } while (true);
            }

            for (int i = 0; i < 4; i++)
            {
                if (gameMode == _GAME_MODE.Arcade)
                    SetEnemySpawn(i);

                do
                {
                    int random = UnityEngine.Random.Range(0, playable.Count);

                    if (playable[random] != vehicles[0])
                    {
                        vehicles[i + 2] = (byte)playable[random];
                        playable.RemoveAt(random);
                        break;
                    }
                } while (true);
            }


            if (online)
                await ClientSend.Load().ContinueWith(Task =>
                    {

                    });
        }
        for (short num = 1; num <= 6; num = (short)(num + 1))
        {
            Debug.Log("Enemy: " + num);
            enemiesDictionary.Add(num, null);
        }
        drawTerrain = true;
        drawRoads = true;
        drawObjects = true;
        drawPlayer = true;
        DiscordController.instance.sceneLoaded = false;
        UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
        //StartCoroutine(UpdateReflections());
        //StartCoroutine(LoadSceneAsyncWithDelay(map));
        isHost = isHosting;
        Debug.Log("Es Host?: " + isHost);
        await LoadSceneAsyncWithDelay(map);
        await Task.Yield(); // Esperar un frame
    }

    public void LoadDebug()
    {
        //StopCoroutine(UpdateReflections());
        inDebug = true;
        Destroy(this.gameObject);
        Destroy(SceneLoader.instance.gameObject);
        //Destroy(MusicManager.instance.gameObject);
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        //StartCoroutine(LoadSceneAsyncWithDelay(0));
    }

    public void FUN_17F34(int param1, int param2)
    {
        DAT_DA0 = param2;
        DAT_DB0 = 3143680 - param1;
    }

    public void FUN_17EB8()
    {
        uint num = (uint)(this.DAT_DB0 - this.DAT_F28.position.y);
        Vector3Int vector3Int = new Vector3Int((int)this.DAT_F28.rotation.V10, (int)this.DAT_F28.rotation.V11, (int)this.DAT_F28.rotation.V12);
        Water.instance.FUN_15F28(this.DAT_F28, this.DAT_DB0); //Posiciona el agua sobre el jugador
        uint num2 = (uint)vector3Int.z;
        if ((num ^ num2) < 1U)
        {
            if (num2 < 0U)
            {
                num2 = (uint)-num2;
            }
            if (1637U < num2)
            {
                return;
            }
        }
        Water.instance.FUN_16664(vector3Int, (int)num); //Dibuja y asigna posicion
    }
    public void FUN_1C134()
    {
        this.terrain.ClearTerrainData();
        this.FUN_1C158();
    }
    public void FUN_1DC0C(bool param1, int param2, bool param3 = false)
    {
        if (param1)
        {
            GameManager.voices[param2].loop = param3;
            GameManager.voices[param2].Play();
            return;
        }
        GameManager.voices[param2].Pause();
    }
    public int FUN_1DD9C()
    {
        int num = 0;
        AudioSource[] array = GameManager.voices;
        uint num2 = this.DAT_E44;
        while ((num2 & 1U) != 0U || array[num].isPlaying)
        {
            num++;
            num2 = (uint)((int)num2 >> 1);
            if (23 < num)
            {
                return 0;
            }
        }
        return num + 1;
    }
    public bool IsAudioPlaying(int param1, AudioClip param2)
    {
        return param1 != 0 && GameManager.voices[param1 - 1].clip == param2 && GameManager.voices[param1 - 1].isPlaying;
    }
    public bool IsAudioPlaying(int param1)
    {
        return param1 != 0 && GameManager.voices[param1 - 1].isPlaying;
    }
    public void FUN_1DE78(int param1)
    {
        if (param1 != 0)
        {
            this.FUN_1DC0C(false, (param1 - 1) & 31, false);
        }
    }
    public void FUN_1E098(int param1, List<AudioClip> param2, int param3, uint param4, bool param5 = false)
    {
        if (param1 != 0)
        {
            AudioClip audioClip = param2[param3];
            int num = 4096;
            int num2 = param1 - 1;
            if (audioClip != null)
            {
                GameManager.SpuSetVoicePitch(num2, num);
                GameManager.SpuSetVoiceVolume(num2, (int)((short)param4), (int)((short)(param4 >> 16)));
                GameManager.SpuSetVoiceStartAddr(num2, audioClip);
                this.FUN_1DC0C(true, num2 & 31, param5);
            }
        }
    }

    public void FUN_1E14C(int param1, List<AudioClip> param2, int param3, bool param4 = false)
    {
        int num = (int)this.DAT_E1C;
        uint num2 = (uint)((uint)((ushort)this.DAT_E1C) << 16) >> 31;
        num += (int)num2;
        num >>= 1;
        num2 = (uint)((uint)num << 16);
        num2 += (uint)num;
        this.FUN_1E098(param1, param2, param3, num2, param4);
    }
    public void FUN_1E188(int param1, List<AudioClip> param2, int param3, bool param4 = false)
    {
        uint num = (uint)((uint)this.DAT_E1C << 16);
        num = (uint)this.DAT_E1C + num;
        this.FUN_1E098(param1, param2, param3, num, param4);
    }
    public void FUN_1E188(int param1, List<AudioClip> param2, int param3, int param4, bool param5 = false)
    {
        uint num = (uint)((uint)this.DAT_E1C << 16);
        num = (uint)this.DAT_E1C + num;
        this.FUN_1E098(param1, param2, param3, num << param4, param5);
    }
    public void FUN_1E28C(int param1, List<AudioClip> param2, int param3)
    {
        uint num = (uint)((ushort)this.DAT_E1C) >> 31;
        uint num2 = (uint)this.DAT_E1C + num;
        num2 = (uint)((int)num2 >> 1);
        num2 = (num2 << 16) + num2;
        this.FUN_1E1B0(param1, param2, param3, num2, false);
    }
    public void FUN_1E2E8(int source, int sampleRate)
    {
        if (source != 0)
        {
            GameManager.voices[source - 1].pitch = (float)sampleRate / (float)(GameManager.voices[source - 1].clip.frequency / 11);
        }
    }
    public void FUN_1E30C(int source, int sampleRate)
    {
        if (source != 0)
        {
            int num = GameManager.voices[source - 1].clip.frequency / 11;
            sampleRate = (int)((uint)(num * sampleRate) >> 12);
            GameManager.voices[source - 1].pitch = (float)sampleRate / (float)num;
        }
    }
    public void FUN_1E580(int param1, List<AudioClip> param2, int param3, Vector3Int param4, bool param5 = false)
    {
        uint num = this.FUN_1E478(param4);
        this.FUN_1E098(param1, param2, param3, num, param5);
    }
    public void FUN_1E5D4(int param1, List<AudioClip> param2, int param3, Vector3Int param4, bool param5 = false)
    {
        uint num = this.FUN_1E478(param4);
        this.FUN_1E098(param1, param2, param3, num << 1, param5);
    }
    public void FUN_1E5D4(int param1, List<AudioClip> param2, int param3, Vector3Int param4, int param5, bool param6 = false)
    {
        uint num = this.FUN_1E478(param4);
        this.FUN_1E098(param1, param2, param3, num << param5, param6);
    }
    public static void SpuSetVoicePitch(int vNum, int sampleRate)
    {
        GameManager.voices[vNum].pitch = (float)sampleRate / 4096f;
    }
    public void FUN_1E2C8(int source, uint volume)
    {
        if (source != 0)
        {
            int num = (int)((short)volume);
            int num2 = (int)((short)(volume >> 16));
            num &= 32767;
            if (num > 16383)
            {
                num = -num & 32767;
            }
            num2 &= 32767;
            if (num2 > 16383)
            {
                num2 = -num2 & 32767;
            }
            float num3 = (float)num / 16384f;
            float num4 = (float)num2 / 16384f;
            GameManager.voices[source - 1].volume = Mathf.Max(num3, num4);
            GameManager.voices[source - 1].panStereo = num4 - num3;
        }
    }
    public static void SpuSetVoiceVolume(int vNum, int volL, int volR)
    {
        volL &= 32767;
        if (volL > 16383)
        {
            volL = -volL & 32767;
        }
        volR &= 32767;
        if (volR > 16383)
        {
            volR = -volR & 32767;
        }
        float num = (float)volL / 16384f;
        float num2 = (float)volR / 16384f;
        GameManager.voices[vNum].volume = Mathf.Max(num, num2);
        GameManager.voices[vNum].panStereo = num2 - num;
    }
    public static void SpuSetVoiceStartAddr(int vNum, AudioClip startAddr)
    {
        GameManager.voices[vNum].clip = startAddr;
    }
    public void FUN_1E1B0(int param1, List<AudioClip> param2, int param3, uint param4, bool param5 = false)
    {
        if (param1 != 0)
        {
            AudioClip audioClip = param2[param3];
            if (audioClip != null)
            {
                int num = param1 - 1;
                int num2 = (int)(GameManager.FUN_2AC5C() + 114688U) >> 5;
                GameManager.SpuSetVoicePitch(num, num2);
                GameManager.SpuSetVoiceVolume(num, (int)((short)param4), (int)((short)(param4 >> 16)));
                GameManager.SpuSetVoiceStartAddr(num, audioClip);
                this.FUN_1DC0C(true, num & 31, param5);
            }
        }
    }
    public void FUN_1E628(int param1, List<AudioClip> param2, int param3, Vector3Int param4, bool param5 = false)
    {
        uint num = this.FUN_1E478(param4);
        this.FUN_1E1B0(param1, param2, param3, num, param5);
    }
    public void FUN_1E8B0(List<AudioClip> param1, int param2, Vector3Int param3)
    {
        uint num = this.FUN_1E7A8(param3);
        if (num != 0U)
        {
            int num2 = this.FUN_1DD9C();
            this.FUN_1E1B0(num2, param1, param2, num, false);
        }
    }
    public void FUN_1FEB8(VigMesh param1)
    {
        if (param1 != null)
        {
            if (param1.DAT_14 != null)
            {
                param1.DAT_14 = null;
            }
            UnityEngine.Object.Destroy(param1);
        }
    }
    public void FUN_2C0A0(VigObject param1)
    {
        if (param1 != null)
        {
            do
            {
                ushort num = this.timer;
                BufferedBinaryReader bufferedBinaryReader = param1.vAnim;
                if (bufferedBinaryReader == null)
                {
                    bufferedBinaryReader = new BufferedBinaryReader(param1.vData.animations);
                    if (bufferedBinaryReader.GetBuffer() != null)
                    {
                        int num2 = bufferedBinaryReader.ReadInt32((int)((ushort)param1.DAT_1A * 4 + 4));
                        if (num2 != 0)
                        {
                            bufferedBinaryReader.Seek((long)num2, SeekOrigin.Begin);
                        }
                        else
                        {
                            bufferedBinaryReader = null;
                        }
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                else
                {
                    bufferedBinaryReader.Seek(0L, SeekOrigin.Begin);
                    int num2 = bufferedBinaryReader.ReadInt32((int)((ushort)param1.DAT_1A * 4 + 4));
                    if (num2 != 0)
                    {
                        bufferedBinaryReader.Seek((long)num2, SeekOrigin.Begin);
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                param1.vAnim = bufferedBinaryReader;
                param1.DAT_4A = num;
                if (param1.child2 != null)
                {
                    this.FUN_2C0A0(param1.child2);
                }
                param1 = param1.child;
            }
            while (param1 != null);
        }
    }

    public void FUN_2C4B4(VigObject param1)
    {
        if (param1 != null)
        {
            VigObject child;
            do
            {
                if (param1.vLOD != null && param1.vLOD != param1.vMesh)
                {
                    this.FUN_1FEB8(param1.vLOD);
                }
                this.FUN_1FEB8(param1.vMesh);
                this.FUN_2C4B4(param1.child2);
                child = param1.child;
                UnityEngine.Object.Destroy(param1.gameObject);
                param1 = child;
            }
            while (child != null);
        }
    }
    public void FUN_2DE18()
    {
        Utilities.SetColorMatrix(this.DAT_FA8);
        Utilities.SetBackColor(64, 64, 64);
        Utilities.SetFogNearFar(2048, 8192, this.DAT_ED8);
        Utilities.SetColorMatrix2(this.DAT_FA8);
        Utilities.SetBackColor2(64, 64, 64);
        Utilities.SetFogNearFar2(2048, 8192, this.DAT_ED8);
    }
    public void FUN_2DE84(int param1, Vector3Int param2, Color32 param3)
    {
        int num = param1;
        param1 = num * 3;
        this.DAT_F68.SetValue16(param1, param2.x);
        this.DAT_F68.SetValue16(param1 + 1, param2.y);
        this.DAT_F68.SetValue16(param1 + 2, param2.z);
        this.DAT_FA8.SetValue16(num, (int)param3.r << 4);
        this.DAT_FA8.SetValue16(num + 3, (int)param3.g << 4);
        this.DAT_FA8.SetValue16(num + 6, (int)param3.b << 4);
    }
    public void FUN_2FB70(VigObject param1, HitDetection param2, HitDetection param3)
    {
        param3.self = param1;
        param3.collider1 = param2.collider2;
        param3.collider2 = param2.collider1;
        param3.object1 = param2.object2;
        param3.object2 = param2.object1;
        this.FUN_2F798(param2.self, param3, 1);
    }
    public int FUN_2FE58(VigObject param1, ushort param2)
    {
        int num;
        for (; ; )
        {
            VigObject child = param1.child;
            if ((param1.flags & 4U) == 0U)
            {
                num = param1.FUN_2FBC8(param2);
                if (-1 < num)
                {
                    if (param1.child2 == null)
                    {
                        goto IL_3F;
                    }
                    num = this.FUN_2FE58(param1.child2, param2);
                }
                if (num < -1)
                {
                    break;
                }
            }
        IL_3F:
            param1 = child;
            if (child == null)
            {
                return 0;
            }
        }
        return num;
    }

    public void FUN_2FEE8(VigObject param1, ushort param2)
    {
        int num = param1.FUN_2FBC8(param2);
        if (-1 < num && param1.child2 != null)
        {
            this.FUN_2FE58(param1.child2, param2);
        }
    }
    public VigTuple2 FUN_2FF3C(uint param1, uint param2)
    {
        List<VigTuple2> dat_10D = this.DAT_10D8;
        VigTuple2 vigTuple = null;
        for (int i = 0; i < dat_10D.Count; i++)
        {
            vigTuple = dat_10D[i];
            if ((uint)vigTuple.array[0] <= param1 >> 16 && (uint)vigTuple.array[1] <= param2 >> 16 && param1 >> 16 <= (uint)(vigTuple.array[0] + vigTuple.array[2]) && param2 >> 16 <= (uint)(vigTuple.array[1] + vigTuple.array[3]))
            {
                break;
            }
            vigTuple = null;
        }
        return vigTuple;
    }
    public VigTuple2 FUN_2FFD0(int param1)
    {
        List<VigTuple2> dat_10D = this.DAT_10D8;
        VigTuple2 vigTuple = null;
        for (int i = 0; i < dat_10D.Count; i++)
        {
            vigTuple = dat_10D[i];
            if ((int)vigTuple.id == param1)
            {
                break;
            }
            vigTuple = null;
        }
        return vigTuple;
    }
    public void FUN_3001C(List<VigTuple> param1)
    {
        param1 = new List<VigTuple>();
    }
    public VigTuple FUN_30080(List<VigTuple> param1, VigObject param2)
    {
        VigTuple vigTuple = new VigTuple(param2, 0U);
        param1.Add(vigTuple);
        return vigTuple;
    }
    public bool FUN_300B8(List<VigTuple> param1, VigObject param2)
    {
        int num = 0;
        while (num != param1.Count)
        {
            VigTuple vigTuple = param1[num++];
            if (vigTuple.vObject == param2)
            {
                if (param1 == this.DAT_1088)
                {
                    this.DAT_1088_tmp.Add(vigTuple);
                }
                else if (param1 == this.DAT_1110)
                {
                    this.DAT_1110_tmp.Add(vigTuple);
                }
                else if (param1 == this.worldObjs)
                {
                    this.worldObjs_tmp.Add(vigTuple);
                }
                else
                {
                    param1.Remove(vigTuple);
                }
                vigTuple.vObject = null;
                return true;
            }
        }
        return false;
    }
    public VigTuple FUN_30134(List<VigTuple> param1, VigObject param2)
    {
        if (param1 == null)
        {
            param1 = new List<VigTuple>();
        }
        for (int num = 0; num != param1.Count; num++)
        {
            VigTuple vigTuple = param1[num];
            if (vigTuple.vObject == param2)
            {
                return vigTuple;
            }
        }
        return null;
    }
    public VigTuple FUN_301DC(List<VigTuple> param1, int param2)
    {
        return this.FUN_30180(param1, param2, null);
    }
    public VigTuple FUN_301FC(List<VigTuple> param1, Type param2)
    {
        VigTuple vigTuple = null;
        for (int i = 0; i < param1.Count; i++)
        {
            vigTuple = param1[i];
            if (vigTuple.vObject.GetType() == param2)
            {
                break;
            }
            vigTuple = null;
        }
        return vigTuple;
    }
    private VigTuple _GetPowerup(List<VigTuple> param1, Vector3Int param2)
    {
        VigTuple vigTuple = null;
        for (int i = 0; i < param1.Count; i++)
        {
            vigTuple = param1[i];
            if (vigTuple.vObject.screen == param2 && vigTuple.vObject.GetType() == typeof(Pickup) && vigTuple.vObject.type == 5)
            {
                break;
            }
            vigTuple = null;
        }
        return vigTuple;
    }
    public VigObject GetPowerup(List<VigTuple> param1, Vector3Int param2)
    {
        VigTuple vigTuple = this._GetPowerup(param1, param2);
        VigObject vigObject = null;
        if (vigTuple != null)
        {
            vigObject = vigTuple.vObject;
        }
        return vigObject;
    }
    public VigObject FUN_3027C(List<VigTuple> param1, int param2, VigObject param3)
    {
        VigTuple vigTuple = this.FUN_30180(param1, param2, param3);
        VigObject vigObject = null;
        if (vigTuple != null)
        {
            vigObject = vigTuple.vObject;
        }
        return vigObject;
    }
    public VigObject FUN_302A8(List<VigTuple> param1, Type param2)
    {
        VigTuple vigTuple = this.FUN_301FC(param1, param2);
        VigObject vigObject = null;
        if (vigTuple != null)
        {
            vigObject = vigTuple.vObject;
        }
        return vigObject;
    }
    public VigObject FUN_302D4(List<VigTuple> param1, uint param2, int param3)
    {
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            Debug.Log("Vehiculos en escenario? vObject: " + vObject + " - id: " + vObject.id + " - type: " + (uint)vObject.type);
            Debug.Log("Parametros: " + param2 + " - " + param3);
            if ((int)vObject.id == param3 && (uint)vObject.type == param2)
            {
                Debug.Log("Hay algo...");
                return vObject;
            }
        }
        Debug.Log("No hay algo...");
        return null;
    }
    public uint FUN_30334(List<VigTuple> param1, int param2, VigObject param3)
    {
        uint num = 0U;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (!vObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                num = 0U;
            }
            else
            {
                num = vObject.UpdateW(param2, param3);
            }
            if (num != 0U)
            {
                break;
            }
        }
        return num;
    }
    public uint FUN_30334(List<VigTuple> param1, int param2, int param3)
    {
        uint num = 0U;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (!vObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                num = 0U;
            }
            else
            {
                num = vObject.UpdateW(param2, param3);
            }
            if (num != 0U)
            {
                break;
            }
        }
        return num;
    }
    public uint FUN_303C0(List<VigTuple> param1, _EVENT_CALL param2, int param3)
    {
        uint num = 0U;
        for (int i = 0; i < param1.Count; i++)
        {
            VigTuple vigTuple = param1[i];
            num = param2(vigTuple, param3);
            if (num != 0U)
            {
                break;
            }
        }
        return num;
    }
    public int FUN_30428(List<VigTuple> param1, uint param2)
    {
        int num = 0;
        for (int i = 0; i < param1.Count; i++)
        {
            VigTuple vigTuple = param1[i];
            uint flags = vigTuple.vObject.flags;
            if (31 < vigTuple.vObject.id && (flags & param2) != 0U && (flags & 32770U) == 0U)
            {
                num++;
            }
        }
        return num;
    }
    public VigObject FUN_30498(List<VigTuple> param1, uint param2, int param3)
    {
        VigObject vigObject = null;
        for (int i = 0; i < param1.Count; i++)
        {
            vigObject = param1[i].vObject;
            if (31 < vigObject.id && (vigObject.flags & param2) != 0U && (vigObject.flags & 32770U) == 0U && --param3 == -1)
            {
                break;
            }
            vigObject = null;
        }
        return vigObject;
    }
    public VigObject FUN_30498_2(List<VigTuple> param1, uint param2, int param3)
    {
        VigObject vigObject = null;
        for (int i = 0; i < param1.Count; i++)
        {
            vigObject = param1[i].vObject;
            if (31 < vigObject.id && (vigObject.flags & param2) != 0U && (vigObject.flags & 32770U) != 0U && --param3 == -1)
            {
                break;
            }
        }
        return vigObject;
    }
    public void FUN_307CC(VigObject param1)
    {
        if (param1 != null)
        {
            VigObject child;
            do
            {
                param1.FUN_306FC();
                if (param1.vLOD != null && param1.vLOD != param1.vMesh)
                {
                    this.FUN_1FEB8(param1.vLOD);
                }
                this.FUN_1FEB8(param1.vMesh);
                this.FUN_307CC(param1.child2);
                child = param1.child;
                UnityEngine.Object.Destroy(param1.gameObject);
                if (this.DAT_1068.Count > 0)
                {
                    List<VigTuple> dat_ = this.DAT_1068;
                    for (int i = 0; i < dat_.Count; i++)
                    {
                        VigObject vObject = dat_[i].vObject;
                        if (vObject.GetType().IsSubclassOf(typeof(VigObject)))
                        {
                            vObject.UpdateW(10, param1);
                        }
                    }
                }
                param1 = child;
            }
            while (child != null);
        }
    }
    public void FUN_308C4(VigObject param1)
    {
        if (param1.vShadow != null)
        {
            this.FUN_4C4BC(param1.vShadow);
        }
        this.FUN_307CC(param1);
    }
    public void FUN_30904(VigObject param1)
    {
        if (param1.type == 255)
        {
            UnityEngine.Object.Destroy(param1.FUN_306FC().gameObject);
            return;
        }
        this.FUN_308C4(param1);
    }
    public void FUN_3094C(Tuple<List<VigTuple>, VigTuple> param1)
    {
        if (param1.Item2 != null)
        {
            param1.Item1.Remove(param1.Item2);
            this.FUN_308C4(param1.Item2.vObject);
        }
    }
    public void FUN_309A0(VigObject param1)
    {
        Tuple<List<VigTuple>, VigTuple> tuple = this.FUN_31868(param1);
        this.FUN_3094C(tuple);
    }

    [Header("SetDraw")]
    public bool setDraw = false;
    ulong countVehicle = 0;

    //IMPORTANTE! Dibuja los objetos en el escenario. Actualiza Reflejos? OPTIMIZAR REFLEJOS!
    public async void FUN_30B24(List<VigTuple> param1)
    {
        foreach (var item in param1)
        {
            if (item.vObject.GetType() == typeof(Vehicle))
            {
                countVehicle++;
            }
        }
        vigObjectCount = param1;
        if (setDraw)
            for (int i = 0; i < param1.Count; i++)
            {

                this.FUN_2D9E0(param1[i].vObject);
                //await Task.Delay(TimeSpan.FromSeconds(reflectionUpdateTime));
            }
        await Task.Yield();
        countVehicle = 0;
        //await Task.Delay(TimeSpan.FromSeconds(reflectionUpdateTime));
    }

    public void FUN_30CB0(VigObject param1, int param2)
    {
        if ((param1.flags & 1U) != 0U)
        {
            this.FUN_300B8(this.DAT_1110, param1);
        }
        VigTuple vigTuple = new VigTuple(null, 0U);
        vigTuple.vObject = param1;
        int dat_ = this.DAT_28;
        param1.flags |= 1U;
        vigTuple.flag = (uint)(param2 + dat_);
        List<VigTuple> dat_2 = this.DAT_1110;
        int num = 0;
        while (num < dat_2.Count && dat_2[num].flag < (uint)(param2 + dat_))
        {
            num++;
        }
        this.DAT_1110.Insert(0, vigTuple);
    }
    public void FUN_30DE8(BSP param1, int param2, int param3, int param4, int param5)
    {
        int num = param1.DAT_00;
        if (num == 1)
        {
            num = param1.DAT_04;
            if (param2 < num)
            {
                this.FUN_30DE8(param1.DAT_08, param2, param3, param4, param5);
            }
            if (param3 <= num)
            {
                return;
            }
        }
        else
        {
            if (num == 0)
            {
                this.FUN_30B24(param1.LDAT_04);
                return;
            }
            if (num == 2)
            {
                num = param1.DAT_04;
                this.FUN_30DE8(param1.DAT_08, param2, param3, param4, param5);
                if (param5 <= num)
                {
                    return;
                }
            }
            else
            {
                if (num != 3)
                {
                    return;
                }
                this.FUN_30DE8(param1.DAT_08, param2, param3, param4, param5);
            }
        }
        //        Debug.Log("Draw:" + param1.DAT_0C + " - " + param2 + " - " + param3 + " - " + param4 + " - " + param5);
        this.FUN_30DE8(param1.DAT_0C, param2, param3, param4, param5);
    }
    public Tuple<List<VigTuple>, VigTuple> FUN_310F4(BSP param1, VigObject param2)
    {
        while (param1.DAT_00 != 0)
        {
            Tuple<List<VigTuple>, VigTuple> tuple = this.FUN_310F4(param1.DAT_08, param2);
            if (tuple.Item2 != null)
            {
                return tuple;
            }
            param1 = param1.DAT_0C;
        }
        return new Tuple<List<VigTuple>, VigTuple>(param1.LDAT_04, this.FUN_30134(param1.LDAT_04, param2));
    }
    public VigObject FUN_31160(BSP param1, int param2, VigObject param3)
    {
        while (param1.DAT_00 != 0)
        {
            VigObject vigObject = this.FUN_31160(param1.DAT_08, param2, param3);
            if (vigObject != null)
            {
                return vigObject;
            }
            param1 = param1.DAT_0C;
        }
        return this.FUN_3027C(param1.LDAT_04, param2, param3);
    }
    public uint FUN_31248(BSP param1, int param2, int param3)
    {
        uint num;
        if (param1.DAT_00 == 0)
        {
            num = this.FUN_30334(param1.LDAT_04, param2, param3);
        }
        else
        {
            if (this.FUN_31248(param1.DAT_08, param2, param3) == 0U && this.FUN_31248(param1.DAT_0C, param2, param3) == 0U)
            {
                return 0U;
            }
            num = 1U;
        }
        return num;
    }
    public Tuple<List<VigTuple>, VigTuple> FUN_318A8(VigObject param1)
    {
        return this.FUN_310F4(this.bspTree, param1);
    }
    public VigObject FUN_318D0(int param1)
    {
        return this.FUN_31160(this.bspTree, param1, null);
    }
    public uint FUN_31924(int param1, int param2)
    {
        return this.FUN_31248(this.bspTree, param1, param2);
    }
    public VigObject FUN_311DC(BSP param1, Type param2)
    {
        while (param1.DAT_00 != 0)
        {
            VigObject vigObject = this.FUN_311DC(param1.DAT_08, param2);
            if (vigObject != null)
            {
                return vigObject;
            }
            param1 = param1.DAT_0C;
        }
        return this.FUN_302A8(param1.LDAT_04, param2);
    }
    public VigObject FUN_318F8(int param1, VigObject param2)
    {
        return this.FUN_31160(this.bspTree, param1, param2);
    }
    public VigObject FUN_31C98(int param1, int param2, Vector2Int param3, Vector2Int param4)
    {
        return this.FUN_31B30(this.bspTree, param1, param2, param3, param4);
    }
    public VigObject FUN_31B30(BSP param1, int param2, int param3, Vector2Int param4, Vector2Int param5)
    {
        int num = param1.DAT_00;
        bool flag;
        VigObject vigObject2;
        if (num == 1)
        {
            num = param1.DAT_04;
            if (param4.x < num)
            {
                VigObject vigObject = this.FUN_31B30(param1.DAT_08, param2, param3, param4, param5);
                if (vigObject != null)
                {
                    return vigObject;
                }
            }
            flag = num < param4.y;
        }
        else
        {
            if (num == 0)
            {
                return this.FUN_31A74(param1.LDAT_04, param2, param3, param4, param5);
            }
            if (num != 2)
            {
                if (num != 3)
                {
                    return null;
                }
                vigObject2 = this.FUN_31B30(param1.DAT_08, param2, param3, param4, param5);
                if (vigObject2 != null)
                {
                    return vigObject2;
                }
                vigObject2 = this.FUN_31B30(param1.DAT_0C, param2, param3, param4, param5);
                if (vigObject2 != null)
                {
                    return vigObject2;
                }
                return null;
            }
            else
            {
                num = param1.DAT_04;
                if (param5.x < num)
                {
                    VigObject vigObject = this.FUN_31B30(param1.DAT_08, param2, param3, param4, param5);
                    if (vigObject != null)
                    {
                        return vigObject;
                    }
                }
                flag = num < param5.y;
            }
        }
        if (!flag)
        {
            return null;
        }
        vigObject2 = this.FUN_31B30(param1.DAT_0C, param2, param3, param4, param5);
        if (vigObject2 == null)
        {
            vigObject2 = null;
        }
        return vigObject2;
    }

    public uint FUN_31A24(int param1, int param2)
    {
        uint num = this.FUN_30334(this.worldObjs, param1, param2);
        if (num == 0U)
        {
            return this.FUN_31248(this.bspTree, param1, param2);
        }
        return num;
    }

    public uint FUN_312DC(BSP param1, _EVENT_CALL param2, int param3)
    {
        uint num;
        if (param1.DAT_00 == 0)
        {
            num = this.FUN_303C0(param1.LDAT_04, param2, param3);
        }
        else
        {
            num = this.FUN_312DC(param1.DAT_08, param2, param3);
            if (num == 0U)
            {
                num = this.FUN_312DC(param1.DAT_0C, param2, param3);
                if (num == 0U)
                {
                    num = 0U;
                }
            }
        }
        return num;
    }

    public VigObject FUN_31A74(List<VigTuple> param1, int param2, int param3, Vector2Int param4, Vector2Int param5)
    {
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (param2 <= (int)vObject.id && (int)vObject.id <= param3)
            {
                int dat_ = vObject.DAT_58;
                if (param4.x < vObject.screen.x + dat_ && vObject.screen.x - dat_ < param4.y && param5.x < vObject.screen.z + dat_ && vObject.screen.z - dat_ < param5.y)
                {
                    return vObject;
                }
            }
        }
        return null;
    }


    //Dibuja objetos en Pantalla
    //BSP= 2:82408976
    public void FUN_3150C()
    {
        if (this.bspTree != null)
        {
            Vector3Int vector3Int = default(Vector3Int);
            vector3Int.x = -GameManager.instance.DAT_EDC / 2;
            vector3Int.y = 0;
            vector3Int.z = GameManager.instance.DAT_ED8;
            Vector3Int vector3Int2 = default(Vector3Int);
            vector3Int2.x = GameManager.instance.DAT_EDC / 2;
            vector3Int2.y = 0;
            vector3Int2.z = GameManager.instance.DAT_ED8;
            vector3Int = Utilities.VectorNormal(vector3Int);
            vector3Int2 = Utilities.VectorNormal(vector3Int2);
            Utilities.SetRotMatrix(GameManager.instance.DAT_F28.rotation);
            vector3Int = Utilities.FUN_23EA0(vector3Int);
            vector3Int2 = Utilities.FUN_23EA0(vector3Int2);
            int num = vector3Int2.x;
            int num2 = vector3Int.x;
            int num3 = num;
            if (num2 < num)
            {
                num3 = num2;
            }
            int num4 = 0;
            if (num3 < 0)
            {
                num4 = num3;
            }
            if (num < num2)
            {
                num = num2;
            }
            num3 = 0;
            if (0 < num)
            {
                num3 = num;
            }
            num = vector3Int2.z;
            int z = vector3Int.z;
            num2 = num;
            if (z < num)
            {
                num2 = z;
            }
            int num5 = 0;
            if (num2 < 0)
            {
                num5 = num2;
            }
            if (num < z)
            {
                num = z;
            }
            num2 = 0;
            if (0 < num)
            {
                num2 = num;
            }
            //this.FUN_30DE8(this.bspTree, GameManager.instance.DAT_F28.position.x + num4 * 1024, GameManager.instance.DAT_F28.position.x + num3 * 1024, GameManager.instance.DAT_F28.position.z + num5 * 1024, GameManager.instance.DAT_F28.position.z + num2 * 1024);
            //this.FUN_30DE8(this.bspTree, GameManager.instance.DAT_F28.position.x + num4 * drawObjInt1, GameManager.instance.DAT_F28.position.x + num3 * drawObjInt2, GameManager.instance.DAT_F28.position.z + num5 * drawObjInt3, GameManager.instance.DAT_F28.position.z + num2 * drawObjInt4);
            this.FUN_30DE8(this.bspTree, GameManager.instance.DAT_F28.position.x + num4 * drawObjInt1, GameManager.instance.DAT_F28.position.x + num3 * drawObjInt2, GameManager.instance.DAT_F28.position.z + num5 * drawObjInt3, GameManager.instance.DAT_F28.position.z + num2 * drawObjInt4);
        }
    }

    public int drawObjInt1;
    public int drawObjInt2;
    public int drawObjInt3;
    public int drawObjInt4;

    public void FUN_31360(ushort param1)
    {
        List<VigTuple> dat_10A = this.DAT_10A8;
        for (int i = 0; i < dat_10A.Count; i++)
        {
            VigTuple vigTuple = dat_10A[i];
            if (vigTuple.vObject != null)
            {
                this.FUN_2FEE8(vigTuple.vObject, param1);
            }
        }
    }

    public void FUN_313C8(int param1)
    {
        for (int i = 0; i < this.DAT_1088.Count; i++)
        {
            if (this.DAT_1088[i].vObject != null && this.DAT_1088[i].vObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                this.DAT_1088[i].vObject.UpdateW(0, param1);
            }
        }
    }

    [Header("VigTuple")]

    [SerializeField]

    // Token: 0x04000483 RID: 1155
    public List<VigTuple> worldObjs;
    // Token: 0x04000484 RID: 1156
    public List<VigTuple> interObjs;
    public List<VigTuple> DAT_1068;
    public List<VigTuple> DAT_1078;
    public List<VigTuple> DAT_1088;
    public List<VigTuple> DAT_1098;
    public List<VigTuple> DAT_10A8;
    public List<VigTuple> DAT_10C8;
    public List<VigTuple2> DAT_10D8;
    public List<VigTuple> DAT_1088_tmp;
    public List<VigTuple> DAT_1110_tmp;
    public List<VigTuple> worldObjs_tmp;
    public List<VigTuple> DAT_1110;
    public VigTuple vigTupleUpdate;

    public void FUN_31440(uint param1)
    {
        for (int i = 0; i < this.DAT_1110.Count; i++)
        {
            VigTuple vigTuple = this.DAT_1110[i];
            if (param1 >= vigTuple.flag)
            {
                VigObject vObject = vigTuple.vObject;
                if (!(vObject == null))
                {
                    vObject.flags &= 4294967294U;
                    this.DAT_1110.RemoveAt(i--);
                    if (vObject.GetType().IsSubclassOf(typeof(VigObject)))
                    {
                        vObject.UpdateW(2, 0);
                    }
                }
            }
        }
    }

    public void FUN_31678()
    {
        if (this.drawTerrain)
        {
            this.FUN_1C134();
        }
        this.FUN_2DE18();
        if (this.drawRoads)
        {
            this.FUN_50B38();
        }
        JobHandle.ScheduleBatchedJobs();
        if (this.drawPlayer)
        {
            this.FUN_30B24(this.worldObjs);
            this.FUN_30B24(this.interObjs);
        }
        if (this.drawObjects)
        {
            this.FUN_3150C();
        }
        this.terrainHandle.Complete();
        this.nativeArray.Dispose();
        this.terrain.CreateTerrainMesh();
        Junction.junctionHandle.Complete();
        for (int i = 0; i < GameManager.updateJunc.Count; i++)
        {
            GameManager.updateJunc[i].CreateRoadData();
        }
        GameManager.updateJunc.Clear();
        if (this.drawTerrain)
        {
            this.terrain.FUN_1C910();
        }
        LevelManager.instance.level.UpdateW(17, 0);
        if (this.DAT_1124 != null)
        {
            this.FUN_33728(this.DAT_1124, LevelManager.instance.DAT_10F8);
        }
    }

    public void FUN_31728()
    {
        this.FUN_3174C();
    }

    public Tuple<List<VigTuple>, VigTuple> FUN_31868(VigObject param1)
    {
        Tuple<List<VigTuple>, VigTuple> tuple = new Tuple<List<VigTuple>, VigTuple>(this.worldObjs, this.FUN_30134(this.worldObjs, param1));
        if (tuple.Item2 == null)
        {
            return this.FUN_310F4(this.bspTree, param1);
        }
        return tuple;
    }

    public VigObject FUN_31950(int param1)
    {
        //Por transicion de tuneles y agua
        VigObject vigObject = this.FUN_3027C(this.worldObjs, param1, null);
        if (vigObject == null)
        {
            vigObject = this.FUN_31160(this.bspTree, param1, null);
        }
        return vigObject;
    }

    public VigObject FUN_31994(Type param1)
    {
        VigObject vigObject = this.FUN_302A8(this.worldObjs, param1);
        if (vigObject == null)
        {
            vigObject = this.FUN_311DC(this.bspTree, param1);
        }
        return vigObject;
    }

    public VigObject FUN_31EDC(int param1)
    {
        VigObject vigObject = this.FUN_30250(this.DAT_1078, param1);
        VigObject vigObject2;
        if (vigObject == null)
        {
            vigObject2 = null;
        }
        else
        {
            vigObject2 = vigObject.FUN_31DDC();
        }
        return vigObject2;
    }

    public VigObject FUN_31F1C(Vector3Int param1)
    {
        uint num = uint.MaxValue;
        VigObject vigObject = null;
        List<VigTuple> dat_ = this.DAT_1078;
        for (int i = 0; i < dat_.Count; i++)
        {
            VigObject vObject = dat_[i].vObject;
            if (vObject.id - 1 < 31)
            {
                uint num2 = (uint)Utilities.FUN_29F6C(param1, vObject.screen);
                if (num2 < num)
                {
                    num = num2;
                    vigObject = vObject;
                }
            }
        }
        return vigObject;
    }

    public Vehicle FUN_3208C(int param1)
    {
        Placeholder placeholder = (Placeholder)this.FUN_30250(this.DAT_1078, param1);
        int num = param1 + 1;
        if (param1 < 0)
        {
            num = ~param1;
        }
        return this.FUN_36C2C(placeholder, (int)this.vehicles[num], param1);
    }

    public Vehicle FUN_3208C(int param1, int param2)
    {
        Placeholder placeholder = (Placeholder)this.FUN_30250(this.DAT_1078, param2);
        if (placeholder == null)
        {
            placeholder = (Placeholder)this.FUN_30250(this.DAT_1078, -1);
        }
        int num = param1 + 1;
        if (param1 < 0)
        {
            num = ~param1;
        }
        return this.FUN_36C2C(placeholder, (int)this.vehicles[num], param1);
    }

    public VigObject FUN_320DC(Vector3Int param1, int param2)
    {
        VigObject vigObject = null;
        VigObject vigObject2 = null;
        int num = -1;
        int num2 = -1;
        sbyte b;
        if (param2 < 0)
        {
            b = this.DAT_1128[~param2];
        }
        else
        {
            b = -1;
        }
        List<VigTuple> list = this.worldObjs;
        for (int i = 0; i < list.Count; i++)
        {
            VigObject vObject = list[i].vObject;
            if (vObject.type == 2 && vObject.maxHalfHealth != 0)
            {
                int num3 = Utilities.FUN_29F6C(param1, vObject.screen);
                int num4 = (int)vObject.id;
                if (num4 != param2 && (0 < num4 || b != this.DAT_1128[~num4]))
                {
                    num4 = num3;
                    int num5 = num;
                    VigObject vigObject3 = vObject;
                    VigObject vigObject4 = vigObject;
                    if (num3 >= num2)
                    {
                        num4 = num2;
                        num5 = num3;
                        vigObject3 = vigObject2;
                        vigObject4 = vObject;
                        if (num3 >= num)
                        {
                            goto IL_AE;
                        }
                    }
                    num2 = num4;
                    num = num5;
                    vigObject2 = vigObject3;
                    vigObject = vigObject4;
                }
            }
        IL_AE:;
        }
        if (vigObject2 == null)
        {
            vigObject2 = vigObject;
        }
        return vigObject2;
    }

    public void FUN_327CC(VigObject param1)
    {
        short id = param1.id;
        if (param1.parent == null && param1.type == 0)
        {
            List<VigTuple> list = this.worldObjs;
            for (int i = 0; i < list.Count; i++)
            {
                VigTuple vigTuple = list[i];
                if (vigTuple.vObject.id == id && vigTuple.vObject.type == 3)
                {
                    this.FUN_3094C(new Tuple<List<VigTuple>, VigTuple>(list, vigTuple));
                }
            }
            VigTuple vigTuple2 = this.FUN_301DC(this.DAT_1078, (int)id);
            if (vigTuple2 == null)
            {
                if (120 < param1.maxHalfHealth)
                {
                    uint num = GameManager.FUN_2AC5C();
                    if ((num & 3U) == 0U)
                    {
                        int num2 = (int)GameManager.FUN_2AC5C();
                        int num3 = (num2 << 1) + num2;
                        num3 = (num3 << 6) - num2;
                        num3 = (num3 << 2) - num2;
                        num3 = (num3 << 2) - num2;
                        num3 >>= 15;
                        num3 -= 1525;
                        Vector3Int vector3Int = default(Vector3Int);
                        vector3Int.x = num3;
                        vector3Int.y = -4577;
                        num2 = (int)GameManager.FUN_2AC5C();
                        num3 = (num2 << 1) + num2;
                        num3 = (num3 << 6) - num2;
                        num3 = (num3 << 2) - num2;
                        num3 = (num3 << 2) - num2;
                        num3 >>= 15;
                        num3 -= 1525;
                        vector3Int.z = num3;
                        LevelManager.instance.FUN_4AAC0(4269277184U, param1.screen, vector3Int);
                        return;
                    }
                }
            }
            else
            {
                uint num = vigTuple2.vObject.flags;
                if ((num & 2U) == 0U)
                {
                    if ((num & 512U) != 0U)
                    {
                        return;
                    }
                }
                else
                {
                    VigObject vigObject = this.FUN_4AC1C(4294705152U, vigTuple2.vObject);
                    if (vigObject != null)
                    {
                        vigObject.flags &= 4278190077U;
                        num = vigTuple2.vObject.flags;
                        if ((num & 512U) == 0U)
                        {
                            vigTuple2.vObject.flags = (num & 4294967293U) | 512U;
                            return;
                        }
                    }
                }
                if (vigTuple2.vObject.GetType() == typeof(Placeholder))
                {
                    return;
                }
                if (this.gameMode < _GAME_MODE.Versus2 || DiscordController.IsOwner())
                {
                    this.FUN_3094C(new Tuple<List<VigTuple>, VigTuple>(this.DAT_1078, vigTuple2));
                }
            }
        }
    }

    public VigTuple FUN_335FC(VigObject param1)
    {
        VigTuple vigTuple = new VigTuple(param1, 0U);
        this.DAT_1098.Add(vigTuple);
        return vigTuple;
    }

    public void FUN_33728(SunLensFlare param1, Vector3Int param2)
    {
        param1.vTransform.position = Utilities.ApplyMatrixSV(this.DAT_F00.rotation, param1.vr);
        param1.vTransform.position.x = param1.vTransform.position.x << 6;
        param1.vTransform.position.y = param1.vTransform.position.y << 6;
        param1.vTransform.position.z = param1.vTransform.position.z << 6;
        param1.vMesh.FUN_21F70(param1.vTransform);
    }

    public VigObject FUN_34120(List<VigTuple> param1, uint param2, Vector3Int param3)
    {
        uint num = uint.MaxValue;
        VigObject vigObject = null;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (31 < vObject.id && (vObject.flags & 16384U) != 0U && (vObject.flags & param2) != 0U && !((Pickup)vObject).cannotReach)
            {
                uint num2 = (uint)Utilities.FUN_29F6C(param3, vObject.screen);
                if (num2 < num)
                {
                    num = num2;
                    vigObject = vObject;
                }
            }
        }
        return vigObject;
    }

    public VigObject FUN_34120_2(List<VigTuple> param1, uint param2, Vector3Int param3)
    {
        uint num = uint.MaxValue;
        VigObject vigObject = null;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (31 < vObject.id && (vObject.flags & param2) != 0U)
            {
                uint num2 = (uint)Utilities.FUN_29F6C(param3, vObject.screen);
                if (num2 < num)
                {
                    num = num2;
                    vigObject = vObject;
                }
            }
        }
        return vigObject;
    }

    public VigObject FUN_34120_3(List<VigTuple> param1, List<ushort> param2, Vector3Int param3)
    {
        uint num = uint.MaxValue;
        VigObject vigObject = null;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (31 < vObject.id && param2.Contains((ushort)vObject.DAT_1A))
            {
                uint num2 = (uint)Utilities.FUN_29F6C(param3, vObject.screen);
                if (num2 < num)
                {
                    num = num2;
                    vigObject = vObject;
                }
            }
        }
        return vigObject;
    }

    private void FUN_347A8(uint param1)
    {
        uint num = (uint)((short)this.levelManager.DAT_C18[1] * 2);
        uint num2 = (uint)this.DAT_1038;
        if (num2 < num)
        {
            do
            {
                int num3 = (int)GameManager.FUN_2AC5C();
                int num4 = this.FUN_30428(this.DAT_1078, param1);
                num4 = num3 * num4;
                VigObject vigObject = this.FUN_30498(this.DAT_1078, param1, num4 >> 15);
                vigObject = this.FUN_4AC6C(param1, vigObject);
                if (vigObject == null)
                {
                    break;
                }
                num = (uint)((short)this.levelManager.DAT_C18[1] * 2);
                int num5 = this.DAT_1038 + 1;
                this.DAT_1038 = num5;
                num2 = (uint)num5;
            }
            while (num2 < num);
        }
    }

    private void FUN_349A0()
    {
        int num = 0;
        int num2 = 4;
        if (this.gameMode > _GAME_MODE.Versus2)
        {
            num2 = 6;
        }
        while (this.difficultyMode != 0 || this.spawns != 30 || this.EnemyKill > 30)
        {
            if (this.difficultyMode == 1 && this.spawns == 70 && this.EnemyKill <= 70)
            {
                return;
            }
            if (this.spawns == 70 && this.EnemyKill < 70)
            {
                return;
            }
            if (this.gameMode > _GAME_MODE.Versus2 && !DiscordController.IsOwner())
            {
                return;
            }
            if (-1 < (sbyte)this.vehicles[2 + num] && this.DAT_1030[num] != 0)
            {
                VigObject vigObject = this.FUN_302D4(this.worldObjs, 2U, num + 1);
                if (vigObject == null)
                {
                    if (this.gameMode == _GAME_MODE.Survival || this.gameMode == _GAME_MODE.Survival2)
                    {
                        for (int i = 0; i < this.vehicles.Length - 2; i++)
                        {
                            if ((int)this.vehicles[i + 2] == this.survival[this.currentSpawn])
                            {
                                this.currentSpawn++;
                                if (this.currentSpawn >= this.survival.Count)
                                {
                                    this.currentSpawn = 0;
                                }
                                i = -1;
                            }
                        }
                        this.vehicles[2 + num] = (byte)this.survival[this.currentSpawn];
                    }
                    if (this.gameMode < _GAME_MODE.Coop2)
                    {
                        vigObject = this.FUN_3208C(num + 1);
                    }
                    else
                    {
                        vigObject = this.FUN_3208C(num + 1, num % 4 + 1);
                    }
                    if (vigObject != null)
                    {
                        int num3 = 0;
                        vigObject.tags = 1;
                        vigObject.flags &= 33554431U;
                        for (; ; )
                        {
                            int num4 = (int)GameManager.FUN_2AC5C();
                            if ((vigObject.flags & GameManager.DAT_63A6C[(int)((uint)((uint)num4 << 2) >> 15)]) == 0U)
                            {
                                vigObject.flags |= GameManager.DAT_63A6C[(int)((uint)((uint)num4 << 2) >> 15)];
                                num3++;
                                if (num3 >= 3)
                                {
                                    break;
                                }
                            }
                        }
                        uint flags = vigObject.flags;
                        vigObject.FUN_3066C();
                        num3 = (int)(vigObject.vTransform.rotation.V02 * 4577);
                        if (num3 < 0)
                        {
                            num3 += 31;
                        }
                        vigObject.physics1.X = num3 >> 5;
                        vigObject.physics1.Y = 0;
                        num3 = (int)(vigObject.vTransform.rotation.V22 * 4577);
                        if (num3 < 0)
                        {
                            num3 += 31;
                        }
                        vigObject.physics1.Z = num3 >> 5;
                        sbyte[] dat_ = this.DAT_1030;
                        int num5 = num;
                        dat_[num5] -= 1;
                        this.spawns++;
                        if (this.gameMode > _GAME_MODE.Versus2)
                        {
                            this.networkEnemies.Add((Vehicle)vigObject);
                            this.enemiesDictionary[vigObject.id] = (Vehicle)vigObject;
                            ClientSend.SpawnAI(vigObject.id, (byte)((Vehicle)vigObject).vehicle, flags);
                        }
                    }
                }
            }
            num++;
            if (num >= num2)
            {
                return;
            }
        }
    }

    public void FUN_34B34()
    {
        VigTuple[] array = new VigTuple[32];
        int num = 0;
        int num2 = 0;
        int num3 = 0;
        lowHealth = false;
        int num4;
        if ((DAT_40 & 0x1000) == 0)
        {
            num4 = 1;
            if (this.difficultyMode != 0)
            {
                num4 = 2;
            }
        }
        else
        {
            num4 = 3;
        }
        uint num5 = 0u;
        int num6 = 0;
        uint num7 = uint.MaxValue;
        int num8 = 1;
        DAT_1130++;
        uint num9 = 4261412864u;
        if (gameMode == _GAME_MODE.Arcade || gameMode == _GAME_MODE.Survival || gameMode == _GAME_MODE.Coop || gameMode == _GAME_MODE.Demo || gameMode == _GAME_MODE.Coop2 || gameMode == _GAME_MODE.Survival2)
        {
            FUN_349A0();
        }
        if (gameMode > _GAME_MODE.Versus2)
        {
            num4++;
        }
        if (gameMode == _GAME_MODE.Survival || gameMode == _GAME_MODE.Survival2)
        {
            num4 += this.EnemyKill / 25;
        }
        List<VigTuple> list = worldObjs;
        for (int i = 0; i < list.Count; i++)
        {
            VigTuple vigTuple = list[i];
            VigObject vObject = vigTuple.vObject;
            if (vObject.type != 2 && vObject.type != 13)
            {
                continue;
            }
            Vehicle vehicle = (Vehicle)vObject;
            if (vObject.id < 0 && vObject.type == 2 && gameMode != _GAME_MODE.Demo)
            {
                if (vObject.maxHalfHealth == 0)
                {
                    continue;
                }
                num6++;
                num5 = (uint)((int)num5 | (1 << (DAT_1128[~vObject.id] & 0x1F)));
                if (vehicle.weapons[2] == null)
                {
                    num8 = 1;
                }
                for (int j = 0; j < 3; j++)
                {
                    VigObject vigObject = vehicle.weapons[j];
                    if (vigObject != null && vigObject.maxFullHealth << 1 <= vigObject.maxHalfHealth)
                    {
                        num9 = (uint)((int)num9 & ~(16777216 << (vigObject.tags & 0x1F)));
                    }
                }
                if (vehicle.body[0] == null)
                {
                    if (vehicle.maxFullHealth > vehicle.maxHalfHealth * 3)
                    {
                        lowHealth = true;
                    }
                }
                else if (vehicle.maxFullHealth > (vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth) * 3)
                {
                    lowHealth = true;
                }
                continue;
            }
            if (vehicle.maxHalfHealth != 0)
            {
                uint flags = vObject.flags;
                if ((flags & 0x4000000) == 0)
                {
                    if (vObject.vTransform.rotation.V11 < 0)
                    {
                        if (vehicle.wheelsType == _WHEELS.Sea && (flags & 0x10000000) == 0)
                        {
                            vehicle.FUN_391AC();
                        }
                        else if (vehicle.ignition <= 0)
                        {
                            vehicle.physics2.Z += 65536;
                            vehicle.flip += 10;
                        }
                    }
                    else
                    {
                        TileData tileByPosition = terrain.GetTileByPosition((uint)vObject.vTransform.position.x, (uint)vObject.vTransform.position.z);
                        if (((flags & 0x20000000) == 0 && vehicle.vTransform.position.x > 0 && vehicle.vTransform.position.z > 0 && vehicle.vTransform.position.x < 117440512 && vehicle.vTransform.position.z < 117440512) || ((uint)terrain.DAT_DE4 <= (uint)vehicle.vTransform.position.x && (uint)vObject.vTransform.position.x <= (uint)terrain.DAT_DE8 && (uint)terrain.DAT_DEC <= (uint)vehicle.vTransform.position.z && (uint)vehicle.vTransform.position.z <= (uint)terrain.DAT_DF0 && tileByPosition.DAT_10[3] != 7) || (vehicle.tags == 1 && (DAT_1130 & 3) != 0))
                        {
                            if (vehicle.tags != 1 && vehicle.tags != 4)
                            {
                                if (vehicle.DAT_B3 * 3 >> 2 < vehicle.acceleration && vehicle.physics1.W < 457 && vehicle.tags != 0)
                                {
                                    vehicle.direction = -1;
                                    vehicle.turning = 0;
                                    vehicle.tags = 0;
                                    if (vehicle.acceleration < 40)
                                    {
                                        vehicle.acceleration = vehicle.DAT_B3;
                                    }
                                    else
                                    {
                                        vehicle.acceleration = (short)((uint)vehicle.DAT_B3 >> 2);
                                    }
                                }
                                else if (vehicle.id < 0)
                                {
                                    if (vehicle.target == null)
                                    {
                                        vehicle.tags = 3;
                                        vehicle.DAT_F4 = 0;
                                    }
                                    else
                                    {
                                        vehicle.tags = 2;
                                    }
                                }
                                else
                                {
                                    uint num10 = (uint)Utilities.FUN_29F6C(playerObjects[0].vTransform.position, vehicle.vTransform.position);
                                    if (gameMode == _GAME_MODE.Demo && num10 < num7)
                                    {
                                        num7 = num10;
                                    }
                                    VigObject target = playerObjects[0];
                                    if ((gameMode - 6 < _GAME_MODE.Alone || gameMode > _GAME_MODE.Versus2) && playerObjects[1] != null)
                                    {
                                        uint num11 = (uint)Utilities.FUN_29F6C(playerObjects[1].vTransform.position, vehicle.vTransform.position);
                                        if (num11 < num10)
                                        {
                                            target = playerObjects[1];
                                            num10 = num11;
                                        }
                                    }
                                    vehicle.target = target;
                                    if (vehicle.tags == 0)
                                    {
                                        vehicle.tags = 3;
                                        vehicle.DAT_F4 = 0;
                                        vehicle.ai.rubberTimer = 500;
                                        array[num2++] = new VigTuple(vObject, num10);
                                    }
                                    else if (vehicle.tags == 2)
                                    {
                                        if (2048000 < num10)
                                        {
                                            vehicle.tags = 3;
                                            vehicle.DAT_F4 = 0;
                                            array[num2++] = new VigTuple(vObject, num10);
                                        }
                                        else
                                        {
                                            if (vehicle.weapons[1] == null)
                                            {
                                                vehicle.tags = 3;
                                            }
                                            else
                                            {
                                                if (vehicle.body[0] == null)
                                                {
                                                    if (vehicle.maxFullHealth < vehicle.maxHalfHealth * 3)
                                                    {
                                                        int j = Utilities.FUN_29F6C(vehicle.target.vTransform.position, vehicle.vTransform.position);
                                                        if (2287 < vehicle.target.physics1.W || 204799 < j)
                                                        {
                                                            num3++;
                                                            goto IL_078f;
                                                        }
                                                        vehicle.tags = 3;
                                                    }
                                                    else
                                                    {
                                                        lowHealth = true;
                                                    }
                                                }
                                                else if (vehicle.maxFullHealth < (vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth) * 3)
                                                {
                                                    int j = Utilities.FUN_29F6C(vehicle.target.vTransform.position, vehicle.vTransform.position);
                                                    if (2287 < vehicle.target.physics1.W || 204799 < j)
                                                    {
                                                        num3++;
                                                        goto IL_078f;
                                                    }
                                                }
                                                else
                                                {
                                                    lowHealth = true;
                                                }
                                                vehicle.tags = 3;
                                            }
                                            vehicle.DAT_F4 = 0;
                                        }
                                    }
                                    else if (vehicle.weapons[1] != null)
                                    {
                                        flags = (uint)((!(vehicle.body[0] == null)) ? (vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth) : vehicle.maxHalfHealth);
                                        if ((int)vehicle.maxFullHealth < (int)(flags * 3))
                                        {
                                            array[num2++] = new VigTuple(vObject, num10);
                                        }
                                        else
                                        {
                                            lowHealth = true;
                                        }
                                    }
                                }
                                goto IL_078f;
                            }
                        }
                        else
                        {
                            VigObject target = FUN_31F1C(vehicle.vTransform.position);
                            vehicle.vTransform = target.vTransform;
                            vehicle.tags = 1;
                            int j = vObject.vTransform.rotation.V02 * 4577;
                            vehicle.vTransform.position.y -= 32768;
                            vehicle.flags |= 32u;
                            if (j < 0)
                            {
                                j += 31;
                            }
                            vehicle.physics1.X = j >> 5;
                            vehicle.physics1.Y = 0;
                            j = vehicle.vTransform.rotation.V22 * 4577;
                            if (j < 0)
                            {
                                j += 31;
                            }
                            vehicle.physics1.Z = j >> 5;
                            vehicle.physics2.X = 0;
                            vehicle.physics2.Y = 0;
                            vehicle.physics2.Z = 0;
                        }
                    }
                }
            }
            goto IL_08a0;
        IL_08a0:
            if (vObject.id != 0 && vObject.type == 2)
            {
                num++;
            }
            continue;
        IL_078f:
            if (vehicle.weapons[0] == null)
            {
                num8 = 1;
            }
            goto IL_08a0;
        }
        if (gameMode < _GAME_MODE.Versus2 || DiscordController.IsOwner())
        {
            if (num8 != 0)
            {
                if (num9 == 0)
                {
                    num9 = 4261412864u;
                }
                FUN_347A8(num9);
            }
            FUN_34840();
            if (LevelManager.instance.level.id == 0)
            {
                FUN_34914();
            }
        }
        if (gameMode == _GAME_MODE.Alone || gameMode == _GAME_MODE.Versus || DAT_C74 != 0)
        {
            return;
        }
        if (_GAME_MODE.Unk1 < gameMode && gameMode < _GAME_MODE.Versus2)
        {
            if (gameMode == _GAME_MODE.Unk2)
            {
                if (1 < num6)
                {
                    return;
                }
            }
            else if (num5 == 3)
            {
                return;
            }
            DAT_C74 = 1;
            return;
        }
        if (gameMode == _GAME_MODE.Survival)
        {
            int num15 = (this.EnemyKill > 80) ? this.EnemyKill : (this.EnemyKill % 70);
            int num16 = num15 * 2;
            int j = num16;
            if (num16 < 0)
            {
                j = num16 + 3;
            }
            num16 += (j >> 2) * -4;
            while (true)
            {
                bool flag = num < num15 + 1;
                if (4 < num15 + 1)
                {
                    flag = (num < 4);
                }
                j = 0;
                if (!flag)
                {
                    break;
                }
                do
                {
                    if (DAT_1030[num16] == 0)
                    {
                        DAT_1030[num16] = 1;
                        break;
                    }
                    int num17 = 3;
                    if (num16 != 0)
                    {
                        num17 = num16 - 1;
                    }
                    j++;
                    num16 = num17;
                }
                while (j < 4);
                num++;
            }
        }
        if (gameMode == _GAME_MODE.Survival2 && DiscordController.IsOwner())
        {
            int num15 = (this.EnemyKill > 80) ? this.EnemyKill : (this.EnemyKill % 70);
            int num16 = num15 * 2;
            int j = num16;
            if (num16 < 0)
            {
                j = num16 + 3;
            }
            num16 += (j >> 2) * -4;
            while (true)
            {
                bool flag = num < num15 + 1;
                if (6 < num15 + 1)
                {
                    flag = (num < 6);
                }
                j = 0;
                if (!flag)
                {
                    break;
                }
                do
                {
                    if (DAT_1030[num16] == 0)
                    {
                        DAT_1030[num16] = 1;
                        break;
                    }
                    int num17 = 5;
                    if (num16 != 0)
                    {
                        num17 = num16 - 1;
                    }
                    j++;
                    num16 = num17;
                }
                while (j < 6);
                num++;
            }
        }
        if (num3 < num4)
        {
            bool flag;
            int j;
            do
            {
                flag = false;
                j = 0;
                if (0 >= num2 - 1)
                {
                    continue;
                }
                int num16 = 0;
                do
                {
                    VigTuple vigTuple2 = array[num16];
                    VigTuple vigTuple = array[++j];
                    if (array[j].flag < array[num16].flag)
                    {
                        VigObject vObject2 = vigTuple2.vObject;
                        uint flag2 = array[num16].flag;
                        uint flag3 = array[j].flag;
                        vigTuple2.vObject = vigTuple.vObject;
                        array[num16].flag = flag3;
                        flag3 = flag2;
                        vigTuple.vObject = vObject2;
                        array[j].flag = flag3;
                        flag = true;
                        break;
                    }
                    num16 = j;
                }
                while (j < num2 - 1);
            }
            while (flag);
            j = 0;
            if (num3 < num4)
            {
                while (num2 > j)
                {
                    num3++;
                    VigObject vObject = array[j].vObject;
                    vObject.tags = 2;
                    j++;
                    if (num3 >= num4)
                    {
                        break;
                    }
                }
            }
        }
        if (gameMode == _GAME_MODE.Versus2)
        {
            if (num == 0)
            {
                bool flag4 = true;
                for (int k = 0; k < DAT_1030.Length; k++)
                {
                    if (DAT_1030[k] != 0)
                    {
                        flag4 = false;
                    }
                }
                if (flag4)
                {
                    if (!gameEnded)
                    {
                        UIManager.instance.WinScreen();
                    }
                    gameEnded = true;
                    DAT_C74 = 1;
                    playerObjects[0].vCamera.flags |= 33554432u;
                    return;
                }
            }
            if (playerObjects[0].maxHalfHealth == 0 && playerObjects[0].DAT_C8 >= 540 && playerSpawns > 0)
            {
                playerSpawns--;
                int param = FUN_1DD9C();
                FUN_1E580(param, instance.DAT_C2C, 66, playerObjects[0].vTransform.position);
                LevelManager.instance.FUN_4DE54(playerObjects[0].vTransform.position, 39);
                FUN_309A0(playerObjects[0]);
                LevelManager.instance.defaultCamera.transform.SetParent(null, worldPositionStays: false);
                FUN_307CC(playerObjects[0].vCamera);
                playerObjects[0] = FUN_3208C(-1, ~DiscordController.GetMemberId());
                playerObjects[0].FUN_3066C();
                LevelManager.instance.FUN_3D94(playerObjects[0]);
                Debug.Log("Spawn Vehicle...");
                ClientSend.Spawn();
            }
            return;
        }
        if (gameMode == _GAME_MODE.Coop2)
        {
            bool flag = true;
            for (int l = 0; l < 4; l++)
            {
                if (DAT_1030[l] != 0)
                {
                    flag = false;
                }
            }
            if (!flag)
            {
                return;
            }
        }
        if (num == 0 && gameMode != _GAME_MODE.Survival2)
        {
            if (gameMode != 0)
            {
                _GAME_MODE gameMode2 = gameMode;
            }
            if (!gameEnded)
            {
                UIManager.instance.WinScreen();
            }
            gameEnded = true;
            DAT_C74 = 1;
            playerObjects[0].vCamera.flags |= 33554432u;
        }
        if ((gameMode == _GAME_MODE.Survival || gameMode == _GAME_MODE.Survival2) && DAT_C74 == 0)
        {
            if (this.difficultyMode == 0)
            {
                if (this.EnemyKill == 30)
                {
                    playerObjects[0].vCamera.flags |= 33554432u;
                    DAT_C74 = 1;
                    UIManager.instance.GoodJob();
                }
            }
            else if (this.difficultyMode == 1 && this.EnemyKill == 70)
            {
                playerObjects[0].vCamera.flags |= 33554432u;
                DAT_C74 = 1;
                UIManager.instance.GoodJob();
            }
        }
        _GAME_MODE gameMode3 = gameMode;
    }

    private global::Navigation FUN_35A6C(global::Navigation param1, global::Navigation param2)
    {
        global::Navigation navigation = param1;
        global::Navigation navigation2 = null;
        if (param1 != null)
        {
            do
            {
                global::Navigation navigation3 = navigation;
                navigation = navigation3;
                if (param2.DAT_14 <= navigation3.DAT_14)
                {
                    break;
                }
                navigation = navigation3.next;
                navigation2 = navigation3;
            }
            while (navigation != null);
        }
        param2.next = navigation;
        if (navigation2 == null)
        {
            return param2;
        }
        navigation2.next = param2;
        return param1;
    }

    private void FUN_35AC0(global::Navigation param1)
    {
        if (param1 != null)
        {
            do
            {
                int num = param1.aimpIndex + (int)param1.DAT_10;
                ushort[] aimpData = this.levelManager.aimpData;
                int num2 = num + 1;
                aimpData[num2] &= 40959;
                param1 = param1.next;
            }
            while (param1 != null);
        }
    }

    private global::Navigation FUN_35B00(int param1, int param2)
    {
        global::Navigation dat_ = this.DAT_1138;
        if (this.DAT_1138 != null)
        {
            this.DAT_1138 = this.DAT_1138.next;
        }
        uint num = 11U;
        if (dat_ != null)
        {
            uint num2 = (uint)((uint)param1 << 21);
            int num3 = param2 << 21;
            int num4 = 0;
            uint num5;
            ushort num6;
            for (; ; )
            {
                num -= 1U;
                num5 = num2 >> 31;
                if (num3 < 0)
                {
                    num5 |= 2U;
                }
                num6 = this.levelManager.aimpData[num4 + (int)num5 + 1];
                if (num6 == 0)
                {
                    break;
                }
                num2 <<= 1;
                if ((num6 & 32768) != 0)
                {
                    break;
                }
                num3 <<= 1;
                num4 += (int)(num6 * 5);
            }
            num6 = (ushort)(-1 << (int)num);
            dat_.aimpIndex = num4;
            dat_.DAT_10 = (byte)num5;
            dat_.DAT_11 = (byte)num;
            dat_.DAT_0C = (ushort)(param1 & (int)num6);
            dat_.DAT_0E = (ushort)(param2 & (int)num6);
        }
        return dat_;
    }

    private Navigation FUN_35BAC(Navigation param1, uint param2, uint param3)
    {
        Navigation dAT_ = DAT_1138;
        if (DAT_1138 != null)
        {
            int num = param1.aimpIndex;
            uint num2 = param1.DAT_11;
            int num3 = (int)((param1.DAT_0C ^ param2) | (param1.DAT_0E ^ param3)) >> (int)(num2 & 0x1F);
            while (true)
            {
                num3 >>= 1;
                num2++;
                if (num3 == 0)
                {
                    break;
                }
                if (levelManager.aimpData[num] == 0)
                {
                    DAT_1138 = DAT_1138.next;
                    return null;
                }
                num += levelManager.aimpData[num] * -5;
            }
            uint num4 = param2 << (int)(32 - num2);
            num3 = (int)(param3 << (int)(32 - num2));
            uint num5;
            ushort num6;
            while (true)
            {
                num2--;
                num5 = num4 >> 31;
                if (num3 < 0)
                {
                    num5 |= 2;
                }
                num6 = levelManager.aimpData[num + num5 + 1];
                if (num6 == 0)
                {
                    break;
                }
                num4 <<= 1;
                if ((num6 & 0x8000) != 0)
                {
                    break;
                }
                num3 <<= 1;
                num += num6 * 5;
            }
            num6 = (ushort)(-1 << (int)num2);
            DAT_1138 = DAT_1138.next;
            dAT_.aimpIndex = num;
            dAT_.DAT_10 = (byte)num5;
            dAT_.DAT_11 = (byte)num2;
            dAT_.DAT_0C = (ushort)(param2 & num6);
            dAT_.DAT_0E = (ushort)(param3 & num6);
        }
        return dAT_;
    }

    private global::Navigation FUN_35CBC(global::Navigation param1)
    {
        global::Navigation navigation = null;
        ushort num = this.levelManager.aimpData[param1.aimpIndex + (int)param1.DAT_10 + 1];
        ushort num2 = 3840;
        if (num != 0)
        {
            num2 = num;
        }
        int num3 = (int)param1.DAT_0E + (1 << (int)param1.DAT_11);
        if ((num2 & 256) != 0)
        {
            for (global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)(param1.DAT_0C - 1), (uint)param1.DAT_0E); navigation2 != null; navigation2 = this.FUN_35BAC(navigation2, (uint)(param1.DAT_0C - 1), (uint)navigation2.DAT_0E + (1U << (int)navigation2.DAT_11)))
            {
                if (this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
                {
                    navigation2.next = navigation;
                    navigation = navigation2;
                }
                if (num3 <= (int)navigation2.DAT_0E + (1 << (int)navigation2.DAT_11))
                {
                    break;
                }
            }
        }
        if ((num2 & 512) != 0)
        {
            for (global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)param1.DAT_0C + (1U << (int)param1.DAT_11), (uint)param1.DAT_0E); navigation2 != null; navigation2 = this.FUN_35BAC(navigation2, (uint)navigation2.DAT_0C, (uint)navigation2.DAT_0E + (1U << (int)navigation2.DAT_11)))
            {
                if (this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
                {
                    navigation2.next = navigation;
                    navigation = navigation2;
                }
                if (num3 <= (int)navigation2.DAT_0E + (1 << (int)navigation2.DAT_11))
                {
                    break;
                }
            }
        }
        num3 = (int)param1.DAT_0C + (1 << (int)param1.DAT_11);
        if ((num2 & 2048) != 0)
        {
            int num4;
            for (global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)param1.DAT_0C, (uint)(param1.DAT_0E - 1)); navigation2 != null; navigation2 = this.FUN_35BAC(navigation2, (uint)num4, (uint)(param1.DAT_0E - 1)))
            {
                if (this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
                {
                    navigation2.next = navigation;
                    navigation = navigation2;
                }
                num4 = (int)navigation2.DAT_0C + (1 << (int)navigation2.DAT_11);
                if (num3 <= num4)
                {
                    break;
                }
            }
        }
        if ((num2 & 1024) != 0)
        {
            int num4;
            for (global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)param1.DAT_0C, (uint)param1.DAT_0E + (1U << (int)param1.DAT_11)); navigation2 != null; navigation2 = this.FUN_35BAC(navigation2, (uint)num4, (uint)navigation2.DAT_0E))
            {
                if (this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
                {
                    navigation2.next = navigation;
                    navigation = navigation2;
                }
                num4 = (int)navigation2.DAT_0C + (1 << (int)navigation2.DAT_11);
                if (num3 <= num4)
                {
                    break;
                }
            }
        }
        if ((num2 & 4096) != 0)
        {
            num3 = param1.aimpIndex + 5 + (int)param1.DAT_10;
            global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)(param1.DAT_0C + (ushort)((sbyte)this.levelManager.aimpData[num3 + 1])), (uint)(param1.DAT_0E + (ushort)((sbyte)(this.levelManager.aimpData[num3 + 1] >> 8))));
            if (navigation2 != null && this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
            {
                navigation2.next = navigation;
                navigation = navigation2;
            }
        }
        return navigation;
    }

    public int FUN_35FF0(global::Navigation param1, short param2, short param3)
    {
        int num = (1 << (int)param1.DAT_11) / 2;
        int num2 = (int)param1.DAT_0C + num - (int)param2;
        num = (int)param1.DAT_0E + num - (int)param3;
        return (int)Utilities.SquareRoot((long)(num2 * num2 + num * num)) << 7;
    }

    public short[] FUN_36060(Vector3Int param1, Vector3Int param2, uint param3, uint param4)
    {
        return this.FUN_36084(param1, param2, param3, param4);
    }

    private short[] FUN_36084(Vector3Int param1, Vector3Int param2, uint param3, uint param4)
    {
        int num = (int)Utilities.FUN_14A54();
        int num2 = num;
        int num3 = 1022;
        this.DAT_1138 = this.levelManager.ainav;
        global::Navigation navigation = this.levelManager.ainav;
        global::Navigation navigation2;
        do
        {
            navigation2 = new global::Navigation();
            navigation.next = navigation2;
            num3--;
            navigation = navigation2;
        }
        while (-1 < num3);
        navigation2.next = null;
        global::Navigation navigation3 = this.FUN_35B00(param2.x >> 16, param2.z >> 16);
        navigation = navigation3;
        if (this.levelManager.aimpData[navigation3.aimpIndex + (int)navigation3.DAT_10 + 1] == 0)
        {
            navigation = this.FUN_35CBC(navigation3);
            if (navigation == null)
            {
                return null;
            }
            navigation3.next = this.DAT_1138;
            this.DAT_1138 = navigation3;
        }
        global::Navigation navigation4 = this.FUN_35B00(param1.x >> 16, param1.z >> 16);
        navigation3 = navigation4;
        if (this.levelManager.aimpData[navigation4.aimpIndex + (int)navigation4.DAT_10 + 1] == 0)
        {
            navigation3 = this.FUN_35CBC(navigation4);
            if (navigation3 == null)
            {
                return null;
            }
            navigation4.next = this.DAT_1138;
            this.DAT_1138 = navigation4;
        }
        navigation3.DAT_18 = 0;
        int num4 = this.FUN_35FF0(navigation2, (short)navigation.DAT_0C, (short)navigation.DAT_0E);
        navigation3.DAT_14 = num4;
        navigation3.next = null;
        navigation3.DAT_04 = null;
        navigation2 = null;
        while (navigation3 != null)
        {
            bool flag;
            if ((param4 & 2U) == 0U)
            {
                num3 = (int)Utilities.FUN_14A54();
                num2 += UnityEngine.Random.Range(this.aiMin, this.aiMax);
                flag = num2 > 1000;
                flag = false;
            }
            else
            {
                param3 -= 1U;
                flag = param3 == 0U;
            }
            if (flag && (param4 & 1U) != 0U)
            {
                break;
            }
            navigation4 = navigation3.next;
            if (flag || (navigation3.aimpIndex == navigation.aimpIndex && navigation3.DAT_10 == navigation.DAT_10))
            {
                num = navigation3.aimpIndex + (int)navigation3.DAT_10;
                ushort[] aimpData = this.levelManager.aimpData;
                int num5 = num + 1;
                aimpData[num5] &= 40959;
                global::Navigation navigation5 = navigation3.DAT_04;
                num3 = 0;
                while (navigation5 != null)
                {
                    navigation5 = navigation5.DAT_04;
                    num3++;
                }
                num3 -= ((num3 != 0) ? 1 : 0);
                short[] array = new short[(num3 + 2) * 2];
                int num6 = num3 * 2;
                array[num6 + 3] = 0;
                array[num6 + 2] = 0;
                array[num6] = (short)(param2.x >> 16);
                num3--;
                array[num6 + 1] = (short)(param2.z >> 16);
                if (num3 != -1)
                {
                    int num7 = num3 * 2;
                    do
                    {
                        navigation3 = navigation3.DAT_04;
                        array[num7] = (short)((int)navigation3.DAT_0C + (1 << (int)navigation3.DAT_11) / 2);
                        num3--;
                        array[num7 + 1] = (short)((int)navigation3.DAT_0E + (1 << (int)navigation3.DAT_11) / 2);
                        num7 -= 2;
                    }
                    while (num3 != -1);
                }
                this.FUN_35AC0(navigation4);
                this.FUN_35AC0(navigation2);
                return array;
            }
            global::Navigation navigation6 = this.FUN_35CBC(navigation3);
            for (global::Navigation navigation7 = navigation6; navigation7 != null; navigation7 = navigation6)
            {
                navigation6 = navigation7.next;
                navigation7.DAT_18 = navigation3.DAT_18 + ((int)((byte)this.levelManager.aimpData[navigation7.aimpIndex + (int)navigation7.DAT_10 + 1]) << (int)navigation7.DAT_11);
                num3 = navigation7.aimpIndex + (int)navigation7.DAT_10;
                ushort num8 = this.levelManager.aimpData[num3 + 1];
                global::Navigation navigation8 = null;
                if ((num8 & 16384) != 0)
                {
                    global::Navigation navigation9 = navigation4;
                    if ((num8 & 8192) != 0)
                    {
                        navigation9 = navigation2;
                    }
                    if (navigation7.aimpIndex != navigation9.aimpIndex || navigation7.DAT_10 != navigation9.DAT_10)
                    {
                        do
                        {
                            navigation8 = navigation9;
                            navigation9 = navigation8.next;
                        }
                        while (navigation7.aimpIndex != navigation9.aimpIndex || navigation7.DAT_10 != navigation9.DAT_10);
                    }
                    navigation7.next = this.DAT_1138;
                    int dat_ = navigation9.DAT_18;
                    num3 = navigation7.DAT_18;
                    this.DAT_1138 = navigation7;
                    if (0 < dat_ - num3)
                    {
                        if (navigation8 == null)
                        {
                            if ((num8 & 8192) == 0)
                            {
                                navigation4 = navigation9.next;
                            }
                            else
                            {
                                navigation2 = navigation9.next;
                            }
                        }
                        else
                        {
                            navigation8.next = navigation9.next;
                        }
                        this.levelManager.aimpData[navigation9.aimpIndex + (int)navigation9.DAT_10 + 1] = (ushort)(num8 & 57343);
                        num4 = navigation7.DAT_18;
                        navigation9.DAT_04 = navigation3;
                        navigation9.DAT_18 = num4;
                        navigation9.DAT_14 -= dat_ - num3;
                        navigation4 = this.FUN_35A6C(navigation4, navigation9);
                    }
                }
                else
                {
                    this.levelManager.aimpData[num3 + 1] = (ushort)(num8 | 16384);
                    num3 = this.FUN_35FF0(navigation7, (short)navigation.DAT_0C, (short)navigation.DAT_0E);
                    navigation7.DAT_04 = navigation3;
                    navigation7.DAT_14 = navigation7.DAT_18 + num3;
                    navigation4 = this.FUN_35A6C(navigation4, navigation7);
                }
            }
            navigation3.next = navigation2;
            num3 = navigation3.aimpIndex + (int)navigation3.DAT_10;
            ushort[] aimpData2 = this.levelManager.aimpData;
            int num9 = num3 + 1;
            aimpData2[num9] |= 24576;
            navigation2 = navigation3;
            navigation3 = navigation4;
        }
        this.FUN_35AC0(navigation3);
        this.FUN_35AC0(navigation2);
        return null;
    }

    public bool FUN_36558(int param1, int param2)
    {
        return 99 < this.vehicleStats[param2].accel && 99 < this.vehicleStats[param2].speed && 99 < this.vehicleStats[param2].armor && 99 < this.vehicleStats[param2].avoidance;
    }

    public string gameTagPlayerLocal;

    public void setPlayerName(string playerName)
    {
        gameTagPlayerLocal = playerName;
    }
    public TextMeshPro gameTagPlayer;
    private SpriteRenderer spriteLifePlayer;

    public Matrix4x4 matrix;

    public GameObject target; //El objeto a seguir
    public float followSpeed = 5f; //Velocidad de seguimiento
    public bool reticula = true;

    public bool positionSprite = true;
    public bool rotationSprite = true;
    public bool scaleSprite = true;

    public Vector3 positionInt;
    public Quaternion rotationInt;
    public Vector3 scaleInt;


    private void GameTagPlayer(Vector3Int param1, int param2, VigMesh param3, VigTransform param4, int param5, Vehicle vehicle)
    {
        Vector3Int vector3Int = Utilities.FUN_24148(param4, param1);
        //Debug.Log("Vehicle Param1: " + param1); //Vehicle Screen
        //Debug.Log("Vehicle Param2: " + param2); //Vehicle DAT_58
        //Debug.Log("Vehicle Param3: " + param3); //LevelManager (VisMesh)
        //Debug.Log("Vehicle Param4-position: " + param4.position);
        //Debug.Log("Vehicle Param4-rotation: " + param4.rotation);
        //Debug.Log("Vehicle Param5: " + param5);
        //Debug.Log("Vehicle vector3Int: " + vector3Int);
        //vector3Int.x = vector3Int.x * param5 >> 8;
        //Debug.Log("Vehicle vector3Int: " + vector3Int.x);
        //vector3Int.y = vector3Int.y * param5 >> 8;
        //Debug.Log("Vehicle vector3Int: " + vector3Int.y);
        //vector3Int.z = vector3Int.z * param5 >> 8;
        //Debug.Log("Vehicle vector3Int: " + vector3Int.z);
        //
        //Debug.Log("Tipo de Vehiculo: " + vehicle.vehicle); //Tipo de Vehiculo Señalado
    }

    public AudioVisualizer audioVisualizer;

    private void FUN_380D8(Vector3Int param1, int param2, VigMesh param3, VigTransform param4, int param5)
    {
        Vector3Int vector3Int = Utilities.FUN_24148(param4, param1);
        vector3Int.x = vector3Int.x * param5 >> 8;
        vector3Int.y = vector3Int.y * param5 >> 8;
        vector3Int.z = vector3Int.z * param5 >> 8;
        if ((vector3Int.x - param2) * 256 < vector3Int.z * 160 && vector3Int.z * -160 < (vector3Int.x + param2) * 256 && (vector3Int.y - param2) * 256 < vector3Int.z * 120 && vector3Int.z * -120 < (vector3Int.y + param2) * 256)
        {
            int num = (param5 & 0x1FF) * 32;
            int num2 = Utilities.DAT_65C90[num / 2 + 1] * param2;
            Matrix3x3 matrix3x = default(Matrix3x3);
            matrix3x.V00 = (short)(num2 >> 16);
            if (num2 < 0)
            {
                matrix3x.V00 = (short)(num2 + 1048575 >> 16);
            }
            matrix3x.V00 >>= 4;
            param2 = Utilities.DAT_65C90[num / 2] * param2;
            if (param2 < 0)
            {
                param2 += 1048575;
            }
            matrix3x.V10 = (short)(param2 >> 20);
            matrix3x.V01 = (short)(-matrix3x.V10);
            matrix3x.V22 = 4096;
            matrix3x.V21 = 0;
            matrix3x.V20 = 0;
            matrix3x.V12 = 0;
            matrix3x.V02 = 0;
            matrix3x.V11 = matrix3x.V00;
            VigTransform param6 = default(VigTransform);
            param6.rotation = matrix3x;
            param6.position = param1;
            param3.FUN_21F70(param6);
            Vector3 vector = new Vector3((float)param6.position.x / (float)translateFactor, (float)(-param6.position.y) / (float)translateFactor, (float)param6.position.z / (float)translateFactor);
            Vector3 eulerAngles = Quaternion.LookRotation(vector - LevelManager.instance.defaultCamera.transform.position, Vector3.up).eulerAngles;
            Quaternion q = Quaternion.Euler(eulerAngles.x, eulerAngles.y, (float)param5 * 180f / 256f);
            Vector3 scale = param6.rotation.Scale;

            matrix = Matrix4x4.TRS(Vector3.Lerp(LevelManager.instance.defaultCamera.transform.position, vector, (float)param5 / 256f), q, scale);

            if (reticula)
            {
                //Mesh Personalizado
                Mesh meshAudio = new Mesh();
                if (audioVisualizer.isMeshAudio)
                {
                    audioVisualizer.matrix = matrix;
                    meshAudio = audioVisualizer.updateMesh();
                }
                else
                {
                    meshAudio = param3.GetMesh();
                }

                //Graphics.DrawMesh(param3.GetMesh(), matrix, targetHUD, 8);
                Graphics.DrawMesh(meshAudio, matrix, targetHUD, 8);

            }

            Vector3 positionText = matrix.GetColumn(3);
            Quaternion rotationText = Quaternion.LookRotation(matrix.GetColumn(2), matrix.GetColumn(1));
            Vector3 scaleText = new Vector3(matrix.GetColumn(0).magnitude, matrix.GetColumn(1).magnitude, matrix.GetColumn(2).magnitude);
        }
    }

    public void FUN_3827C(Vehicle param1, VigTransform param2)
    {
        if (!isWait)
        {
            return;
        }
        Vehicle vehicle = null;
        if (!paused)
        {
            //Verifica si hay objetivos
            if ((Vehicle)param1.target != null) //Sigue dando error al comenzar
            {
                vehicle = (Vehicle)param1.target;
                VigObject vigObject = param1.weapons[param1.weaponSlot];
                Vector3Int param3 = vehicle.screen;
                short dAT_C;
                int dAT_;
                VigMesh param4;
                if (vehicle.jammer == 0)
                {
                    int num = 0;
                    param3 = vehicle.vTransform.position;
                    if (vigObject != null)
                    {
                        num = (((vigObject.flags & 0x4000) != 0) ? 1 : 0);
                    }
                    dAT_C = param1.DAT_C6;
                    dAT_ = vehicle.DAT_58;
                    param4 = DAT_1150[num];
                }
                else
                {
                    dAT_C = param1.DAT_C6;
                    dAT_ = vehicle.DAT_58;
                    param4 = DAT_1150[2];
                }
                //Reticula otros Jugadores
                FUN_380D8(param3, dAT_, param4, param2, dAT_C);

                GameTagPlayer(param3, dAT_, param4, param2, dAT_C, vehicle);
            }
            if (param1.jammer != 0 || (DAT_40 & 0x200000) != 0 || enableReticle)
            {
                //reticula Jugador
                FUN_380D8(param1.screen, param1.DAT_58, DAT_1150[3], param2, 256);
                GameTagPlayer(param1.screen, param1.DAT_58, DAT_1150[3], param2, 256, vehicle);
            }
        }
    }

    public uint FUN_4A970(uint param1, uint param2)
    {
        int num;
        if (this.gameMode == _GAME_MODE.Versus2)
        {
            num = 2;
        }
        else
        {
            num = (int)this.difficultyMode;
        }
        int num2 = ~num + 3;
        while (num2 != -1)
        {
            do
            {
                param2 = GameManager.FUN_2AC5C() * 18U >> 15;
            }
            while (GameManager.DAT_63FA4[(int)param2] < 0 || ((ulong)param1 & (ulong)(262144L << (int)(param2 & 31U & 31U))) == 0UL);
            if (param2 == 13U)
            {
                return 13U;
            }
            num2--;
            if (4294967295U < param1)
            {
                return param2;
            }
        }
        return param2;
    }

    public short meshHelp = 0;
    public short effectHelp = 0;

    //Mesh Help
    //0 Repair
    //2 Lazy
    //3 MultiDamage
    //4 Shield
    //5 BrownBox
    //6 GreenBox
    //7 Heavy
    //8 WaterWheels
    //9 SnowWheels 
    //10 Missille
    //11 TankShot
    //12 Ballistic
    //13 Mine
    //14 Mortar
    //15 Flame
    //16 Accel
    //17 Speed
    //18 Armor
    //19 Avoidance

    //Quest
    //20 Briefcase
    //21 Fuel Can
    //22 Bomb
    //23 Toolbox

    public VigObject FUN_4AB18(uint param1, VigObject param2)
    {
        VigObject vigObject;
        if (param2 == null)
        {
            vigObject = null;
        }
        else
        {
            vigObject = null;
            if ((param1 & param2.flags) != 0)
            {
                int num = (int)FUN_4A970(param1 & param2.flags, 0u);
                //Debug.Log("Get Parameters Pickup: " + num + " - " + param1 + " - " + param2 + " - " + param2.name + " - " + param2.flags);
                if (num == 3)
                {
                    DAT_101C++;
                }
                bool flag = false;
                if (6 < num && (int)param2.flags < 0)
                {
                    flag = ((param2.flags & 0x7E000000) != 0);
                }
                param2.tags = (sbyte)(flag ? 1 : 0);

                //Dibuja el efecto del objeto
                short num2 = param2.DAT_1A = (short)((!flag) ? DAT_63FA4[num] : 5);
                //short num2 = param2.DAT_1A = (short)((!flag) ? DAT_63FA4[meshHelp] : 5); //Max: 18
                //short num2 = param2.DAT_1A = meshHelp; //Max: 18

                Debug.Log("Pickup Number: " + num2);
                if (gameMode >= _GAME_MODE.Versus2)
                {
                    Debug.Log("SpawnPickup");
                    ClientSend.SpawnPickup(param2.id, param2.tags, DAT_63FA4[num], param2.parent != null);
                    Debug.Log("Pass..");
                }
                vigObject = param2.FUN_31DDC();
                vigObject.flags |= 16777216u;

                //Genera el efecto del objeto
                vigObject.DAT_1A = DAT_63FA4[num];
                //vigObject.DAT_1A = effectHelp;
            }
        }
        return vigObject;
    }

    public VigObject FUN_4AC1C(uint param1, VigObject param2)
    {
        VigObject vigObject;
        if (this.gameMode < _GAME_MODE.Versus2 || DiscordController.IsOwner())
        {
            vigObject = this.FUN_4AB18(param1, param2);
            if (vigObject != null)
            {
                param2.flags |= 32768U;
                vigObject.FUN_3066C();
            }
        }
        else
        {
            vigObject = null;
        }
        return vigObject;
    }

    public VigObject FUN_4AC6C(uint param1, VigObject param2)
    {
        int num = 0;
        VigObject vigObject = param2;
        if (param2 != null)
        {
            do
            {
                vigObject = vigObject.child;
                num++;
            }
            while (vigObject != null);
        }
        int num2 = (int)GameManager.FUN_2AC5C();
        num2 = num2 * num >> 15;
        VigObject vigObject2 = param2;
        for (num2--; num2 != -1; num2--)
        {
            vigObject2 = vigObject2.child;
        }
        vigObject = this.FUN_4AB18(param1, vigObject2);
        if (vigObject != null)
        {
            param2.flags |= 32768U;
            vigObject.FUN_3066C();
        }
        return vigObject;
    }

    public VigCamera FUN_4B914(Vehicle param1, ushort param2, Camera cam)
    {
        GameObject gameObject = new GameObject();
        VigCamera vigCamera = gameObject.AddComponent<VigCamera>();
        cam.transform.parent = gameObject.transform;
        vigCamera.target = param1;
        vigCamera.maxHalfHealth = param2;
        vigCamera.flags |= 16777216U;
        vigCamera.FUN_4B898();
        return vigCamera;
    }

    public void FUN_4C4BC(VigShadow param1)
    {
        if (param1 != null)
        {
            this.FUN_1FEB8(param1.vMesh);
            UnityEngine.Object.Destroy(param1.gameObject);
        }
    }

    public VigObject FUN_4EEB0(List<VigObject> param1, XOBF_DB param2, ushort param3, Type param4, int param5)
    {
        int num = 0;
        VigObject vigObject = null;
        VigObject vigObject2 = vigObject;
        if (0 < param5)
        {
            do
            {
                vigObject2 = param2.ini.FUN_2C17C(param3, param4, 8U);
                vigObject2.vTransform = GameManager.FUN_2A39C();
                vigObject2.child = vigObject;
                num++;
                vigObject2.LDAT_78 = param1;
                vigObject = vigObject2;
            }
            while (num < param5);
        }
        param1[0] = vigObject2;
        return vigObject2;
    }

    public VigObject FUN_4EF80(List<VigObject> param1)
    {
        VigObject vigObject = param1[0];
        if (vigObject != null)
        {
            param1[0] = vigObject.child;
            vigObject.child = null;
            vigObject.FUN_2C05C();
        }
        return vigObject;
    }

    public void FUN_50B38()
    {
        List<Junction> roadList = this.levelManager.roadList;
        for (int i = 0; i < roadList.Count; i++)
        {
            if (this.FUN_2E22C_2(roadList[i].pos, roadList[i].DAT_18))
            {
                Vector3Int vector3Int = Utilities.FUN_24148_2(this.DAT_F00, roadList[i].pos);
                if (vector3Int.z < 2097152)
                {
                    roadList[i].vTransform.position = roadList[i].pos;
                    roadList[i].FUN_4F804(vector3Int);
                }
                else
                {
                    roadList[i].ClearRoadData();
                }
            }
            else
            {
                roadList[i].ClearRoadData();
            }
        }
        if (0 < this.levelManager.DAT_1184)
        {
            for (int j = 0; j < this.levelManager.DAT_1184; j++)
            {
                if (this.levelManager.juncList[j].DAT_18 != null)
                {
                    this.FUN_507DC(this.levelManager.juncList[j]);
                }
            }
        }
    }

    public short[] FUN_51ED4(Vector3Int param1, Vector3Int param2, uint param3, uint param4)
    {
        if (this.DAT_D0C != 0)
        {
            param3 >>= 11;
            param4 |= 2U;
        }
        return this.FUN_36060(param1, param2, param3, param4);
    }

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = MaxRate;
        currentFrameTime = Time.realtimeSinceStartup;
        //WaitForNextFrame();
        StartCoroutine("WaitForNextFrame");

        if (instance == null)
        {
            instance = this;
            player = ReInput.players.GetPlayer(0);
            audioVisualizer = GameObject.Find("MusicManager").gameObject.GetComponent<AudioVisualizer>();
        }
        this.DAT_08 = new ushort[,]
        {
            { 0, 0, 0, 801, 8448, 8515 },
            { 0, 0, 0, 801, 8448, 8448 }
        };
        gravityFactor = 11520;
        DAT_898 = byte.MaxValue;
        DAT_36 = true;
        DAT_E1C = 8191;
        vehicles = new byte[20];
        vehicles[2] = byte.MaxValue;
        vehicles[3] = byte.MaxValue;
        vehicles[4] = byte.MaxValue;
        vehicles[5] = byte.MaxValue;
        vehicles[6] = byte.MaxValue;
        vehicles[7] = byte.MaxValue;
        playerObjects = new Vehicle[2];
        cameraObjects = new VigCamera[2];
        vehicleStats = new VehicleStats[18];
        DAT_1030 = new sbyte[20];
        DAT_1068 = new List<VigTuple>();
        DAT_1078 = new List<VigTuple>();
        DAT_1088 = new List<VigTuple>();
        DAT_1088_tmp = new List<VigTuple>();
        DAT_1098 = new List<VigTuple>();
        DAT_10A8 = new List<VigTuple>();
        DAT_10C8 = new List<VigTuple>();
        DAT_10D8 = new List<VigTuple2>();
        DAT_1110 = new List<VigTuple>();
        DAT_1110_tmp = new List<VigTuple>();
        DAT_1150 = new VigMesh[4];
        worldObjs = new List<VigTuple>();
        worldObjs_tmp = new List<VigTuple>();
        interObjs = new List<VigTuple>();
        hit = new HitDetection(new byte[0]);
        networkMembers = new SerializableVehicle<long, Vehicle>();
        networkIds = new SerializableVehicle<long, short>();
        networkObjs = new List<VigObject>();
        networkEnemies = new List<Vehicle>();
        enemiesDictionary = new SerializableVehicle<short, Vehicle>();
        noHUD = true;
        DAT_D18 = new byte[2];
        DAT_D19 = new byte[2];
        DAT_D1A = new byte[2];
        DAT_D1B = new byte[2];
        DAT_D28 = new byte[2, 8];
        damageMode = new sbyte[2];
        DAT_CF0 = new ushort[2];
        DAT_CF4 = new byte[2, 2];
        DAT_CFC = new byte[4];
        DAT_1128 = new sbyte[6];
        for (int i = 0; i < 24; i++)
        {
            voices[i] = base.gameObject.AddComponent<AudioSource>();
        }
    }


    int setTouch;
    public void setMapOnLeftButtonPressed()
    {
        setTouch = 1;
        UpdateOptions();
    }
    public void setMapOnRightButtonPressed()
    {
        setTouch = 2;
        UpdateOptions();
    }
    public void setModeOnLeftButtonPressed()
    {
        setTouch = 3;
        UpdateOptions();
    }
    public void setModeOnRightButtonPressed()
    {
        setTouch = 4;
        UpdateOptions();
    }
    public void setLiveOnLeftButtonPressed()
    {
        setTouch = 5;
        UpdateOptions();
    }
    public void setLiveOnRightButtonPressed()
    {
        setTouch = 6;
        UpdateOptions();
    }
    public void setDamageOnLeftButtonPressed()
    {
        setTouch = 7;
        UpdateOptions();
    }
    public void setDamageOnRightButtonPressed()
    {
        setTouch = 8;
        UpdateOptions();
    }
    public void setDifficultyOnLeftButtonPressed()
    {
        setTouch = 9;
        UpdateOptions();
    }
    public void setDifficultyOnRightButtonPressed()
    {
        setTouch = 10;
        UpdateOptions();
    }


    [Header("Scene Loading Progress")]
    public float loadingProgress = 0f;
    public float totalSceneProgress = 0f; //Progreso total de la carga de la escena
    public float currentSceneProgress = 0f; //Progreso actual de la carga de la escena
    public AsyncOperation asyncSceneMap;
    public int sceneBuildIndex;
    Scene loadedScene;

    [Obsolete]
    public void DestroyScene()
    {
        // Verificar si el nombre de la escena no es nulo o vacío
        if (!string.IsNullOrEmpty(sceneName))
        {
            Scene sceneToUnload = SceneManager.GetSceneByName(sceneName);
            if (sceneToUnload.IsValid())
            {
                SceneManager.UnloadScene(sceneToUnload);

                Debug.Log(sceneToUnload);

                if (sceneToUnload.isLoaded)
                {
                    SceneManager.UnloadSceneAsync(sceneToUnload);
                }
                else
                {
                    Debug.LogWarning("La escena no está cargada." + " Reference: " + sceneToUnload.path);
                }
            }
            else
            {
                Debug.LogWarning("La escena no es válida." + " Reference: " + sceneName);
            }
        }
        else
        {
            Debug.LogWarning("El nombre de la escena es nulo o vacío." + " Reference: " + sceneName);
        }
    }

    private int buildIndex = 0;

    private string GetSceneNameByBuildIndex(int buildIndex)
    {
        Scene[] scenes = new Scene[SceneManager.sceneCountInBuildSettings];

        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            scenes[i] = SceneManager.GetSceneByBuildIndex(i);
        }

        if (buildIndex >= 0 && buildIndex < scenes.Length)
        {
            return scenes[buildIndex].name;
        }
        return null;
    }

    public string sceneName;

    [Header("ProgressBarGui")]
    public bool LoadScene = false;
    public float progressBarWidth = Screen.width; //Ancho total de la barra de progreso
    public float progressBarHeight = 20f; //Alto de la barra de progreso
    public float progressBarHorizontal = 2f; //Alto de la barra de progreso
    public float progressBarVertical = 15f; //Alto de la barra de progreso
    public float slideSpeed = 200f; //Velocidad de deslizamiento del slide
    public float progress = 0f; //Progreso actual de la barra
    public Texture2D progressBarTexture;

    public bool showFps = true;
    public int deph = 0;

    public bool guiButton = false;

    public Rect connectionWindowRect = new Rect(100, 100, 300, 180);

    //Zona de pruebas
#if DEBUG

#endif

    private async void OnGUI()
    {
#if DEBUG
        if (showFps)
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 20;
            style.normal.textColor = Color.yellow;
            GUI.Label(new Rect(10, 10, 200, 20), "FPS: " + currentFps.ToString("F2"), style);
            style.normal.textColor = Color.green;
            GUI.Label(new Rect(10, 40, 200, 20), "Coun Vehicle: " + countVehicle.ToString("F2"), style);
            style.normal.textColor = Color.magenta;
            GUI.Label(new Rect(10, 80, 200, 20), "Refresh Object True: " + refreshObject.ToString("F2"), style);
            style.normal.textColor = Color.blue;
            GUI.Label(new Rect(10, 120, 200, 20), "Refresh Object False: " + notRefreshObject.ToString("F2"), style);
        }

        if (!inDebug && guiButton)
        {
            connectionWindowRect = GUILayout.Window(1, connectionWindowRect, ConnectionWindow, "Debug Options");
        }
#endif
        if (!LoadScene || !isWait) // Solo dibujar la barra de progreso si no se han cargado completamente o esta esperando el Host
        {
            GUI.depth = deph;
            // Calcular la posición de la barra de progreso en la pantalla
            float progressBarX = (Screen.width - progressBarWidth) / progressBarHorizontal; // Centrado horizontal
            float progressBarY = (Screen.height - progressBarHeight) / progressBarVertical; // Centrado vertical
            Rect progressBarRect = new Rect(progressBarX, progressBarY, progressBarWidth, progressBarHeight);

            // Calcular la cantidad de mosaicos completos y el progreso dentro del mosaico actual
            int completeTiles = Mathf.FloorToInt(currentSceneProgress * progressBarWidth / progressBarTexture.width);
            float partialTileProgress = (currentSceneProgress * progressBarWidth) % progressBarTexture.width;

            // Dibujar los mosaicos completos
            for (int i = 0; i < completeTiles; i++)
            {
                Rect tileRect = new Rect(progressBarRect.x + i * progressBarTexture.width, progressBarRect.y, progressBarTexture.width, progressBarRect.height);
                GUI.DrawTexture(tileRect, progressBarTexture);
            }

            // Dibujar el mosaico parcial
            Rect partialTileRect = new Rect(progressBarRect.x + completeTiles * progressBarTexture.width, progressBarRect.y, partialTileProgress, progressBarRect.height);
            Rect partialTileTexCoords = new Rect(0f, 0f, partialTileProgress / progressBarTexture.width, 1f);
            GUI.DrawTextureWithTexCoords(partialTileRect, progressBarTexture, partialTileTexCoords);
        }
        else
        {
            //Eliminar la barra de progreso
            //DestroyProgressBar();
        }
        await Task.Yield(); // Esperar un frame
    }

    private void DestroyProgressBar()
    {

        progressBarTexture = null;

        // Realizar aquí cualquier acción necesaria para eliminar la barra de progreso
        // Por ejemplo, desactivar objetos, limpiar referencias, etc.
        //Demo.instance.controlPanel();
        // ...

    }

    private async void ConnectionWindow(int windowId)
    {
        using (new GUILayout.VerticalScope())
        {
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Enabled Optimization"))
                    {
                        enabledOptimization = !enabledOptimization;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(enabledOptimization, "");
                }
            }
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Enabled Refresh Mesh"))
                    {
                        enabledRefreshMesh = !enabledRefreshMesh;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(enabledRefreshMesh, "");
                }
            }
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Experimental Quality"))
                    {
                        experimentalQuality = !experimentalQuality;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(experimentalQuality, "");
                }
            }
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Enabled Reflection"))
                    {
                        enabledReflection = !enabledReflection;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(enabledReflection, "");
                }
            }
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Enabled Mesh"))
                    {
                        enabledMesh = !enabledMesh;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(enabledMesh, "");
                }
            }
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Enabled child"))
                    {
                        enabledChild2 = !enabledChild2;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(enabledChild2, "");
                }
            }
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Enabled vLoD"))
                    {
                        enabledvLoD = !enabledvLoD;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(enabledvLoD, "");
                }
            }
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Enabled Console"))
                    {
                        enabledConsole = !enabledConsole;
                        Debug.unityLogger.logEnabled = enabledConsole;
                        GameObject.Find("IngameDebugConsole").gameObject.GetComponent<Canvas>().enabled = enabledConsole;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(enabledConsole, "");
                }
                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Show FPS"))
                    {
                        showFps = !showFps;
                    }
                    GUILayout.FlexibleSpace();
                    GUILayout.Toggle(showFps, "");
                }
            }

            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Spawn Enemy"))
            {
                await spawnEnemy();
            }
        }
        GUI.DragWindow();
    }

    private bool EnemySpawn = false;
    private async Task spawnEnemy()
    {
        EnemySpawn = true;
        int num = 3;
        Debug.Log("Verificando Vehiculos en Arena... " + worldObjs);
        //VigObject vigObject = this.FUN_302D4(this.worldObjs, 2U, num + 1);
        for (int i = 0; i < 4; i++)
        {
            VigObject vigObject = null;
            if (vigObject == null)
            {
                if (this.gameMode < _GAME_MODE.Coop2)
                {
                    vigObject = this.FUN_3208C(i + 1);
                }
                else
                {
                    vigObject = this.FUN_3208C(i + 1, i % 4 + 1);
                }
                if (vigObject != null)
                {
                    vigObject.FUN_3066C();
                }
            }
        }
        EnemySpawn = false;
        //FUN_349A0();
        //GameManager.instance.FUN_34B34();
        //GameManager.instance.FUN_3208C(1, 1);
        await Task.Yield(); // Esperar un frame
    }

    [Obsolete]
    private async Task LoadSceneAsyncWithDelay(int sceneIndex)
    {
        SceneLoader.staticCanvasLoadScene.enabled = true;
        Debug.Log("Obtener mapa cargado...");
        await SceneLoader.getMap(sceneIndex);
        Debug.Log("obtenido mapa cargado...");

        sceneMap = sceneIndex;
        asyncSceneMap = SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Single);
        asyncSceneMap.allowSceneActivation = false;
        if (SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            Demo.instance.loadButtonOnline.gameObject.SetActive(false);
            Demo.instance.loadTextOnline.gameObject.SetActive(true);
            Demo.instance.backButton.gameObject.SetActive(false);
        }
        if (isHost || !online)
            Demo.instance.loadTextOnline.text = "Press SpaceBar | (X) to Continue...";
        else
            Demo.instance.loadTextOnline.text = "Waiting Host...";

        while (!asyncSceneMap.isDone)
        {
            totalSceneProgress = asyncSceneMap.progress;

            // Si el progreso total es menor a 0.9f, establece el progreso actual de acuerdo al progreso total
            if (totalSceneProgress < 0.9f)
            {
                currentSceneProgress = totalSceneProgress;
            }

            // Si el progreso total es igual o mayor a 0.9f, establece el progreso actual en 1.0f para indicar que la escena está completamente cargada
            else if (asyncSceneMap.progress >= 0.9f)
            {
                Debug.Log("Termino la carga de la Escena.");
                LoadScene = true;
                inDebug = false;
                inMenu = false;
                asyncSceneMap.allowSceneActivation = true;
                if (player.GetButtonDown("START") || player.GetButtonDown("Space") && isHost)
                {
                    Debug.Log("Es el Host!");
                    Scene thisScene = SceneManager.GetSceneByBuildIndex(0);
                    Scene asyncScene = SceneManager.GetSceneByBuildIndex(sceneIndex);
                    await Task.Delay(System.TimeSpan.FromSeconds(1));
                }

                // Obtener el nombre de la escena por índice de compilación
                sceneName = GetSceneNameByBuildIndex(sceneIndex);

                Debug.Log("Escena Precargada: " + sceneName);
                currentSceneProgress = 1.0f;
            }

            Debug.Log("Cargando Mapa..." + asyncSceneMap.progress);

            // Actualizar la barra de progreso en cada iteración del ciclo
            await Task.Yield(); // Esperar un frame
        }
        await SceneLoader.setLoadingStatus(isHost);
        await Task.Yield(); // Esperar un frame
                            // La carga de la escena se ha completado correctamente, puedes realizar cualquier otra acción necesaria aquí
    }

    private void Start()
    {
        //QualitySettings.SetQualityLevel(0);
        //Debug.Log(QualitySettings.GetRenderPipelineAssetAt(0));
        //Debug.Log(QualitySettings.GetQualityLevel());

        if (inDebug && inMenu && SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            //StartCoroutine(UpdateReflections());

            if (inDebug)
            {
                map = 1;
                gameMode = _GAME_MODE.Versus2;

                SetStage();

                //selectOptions.transform.Find("Map/Preview").GetComponent<Image>().sprite = statsPanel.maps[map];
                //selectOptions.transform.Find("Map/Text (TMP)").GetComponent<TextMeshProUGUI>().text = mapText;
                selectOptions.transform.Find("Mode/Text (TMP)").GetComponent<TextMeshProUGUI>().text = gameMode.ToString().Substring(0, gameMode.ToString().Length - 1);
                selectOptions.transform.Find("Lives/Text (TMP)").GetComponent<TextMeshProUGUI>().text = currentValueLives.ToString();
                selectOptions.transform.Find("Damages/Text (TMP)").GetComponent<TextMeshProUGUI>().text = damageText;

                //if (selectOptions.transform.Find("Mode").gameObject.transform.Find("Text (TMP)").gameObject)
                //{
                //Test: Desactiva texto de Mode
                //selectOptions.transform.Find("Mode").gameObject.transform.Find("Text (TMP)").gameObject.SetActive(value: false);
                //selectOptions.transform.Find("Mode/Text (TMP)").GetComponent<TextMeshProUGUI>().text = gameMode.ToString();
                //gameMode = _GAME_MODE.Arcade;
                //}

            }
        }
        else
        {
            reflectionsCoroutine = StartCoroutine(UpdateReflections());
        }
    }

    string touchMessage;
    int currentValueLives = 1;
    public int currentDamageIndex = 2;
    public int currentValueDifficulty = 1;
    public string damageText = "Normal";
    public string mapText = "Arizona - MeteorCrater";
    public int difficultyInt;
    int modeIndex;

    //List<Sprite> Maps = StatsPanel.instance.maps;

    private async void UpdateOptions()
    {
        if (setTouch <= 2)
            FUN_1E098(1, Menu.instance.sounds, 7, 4095);

        if (setTouch == 1)
        {
            if (map > 0)
            {
                if (map == 1)
                {
                    map = 18;
                }
                else
                {
                    map -= 1;
                }
                //touchMessage = "Map Left: " + map;
            }
        }
        else if (setTouch == 2)
        {
            if (map < 19)
            {
                if (map == 18)
                {
                    map = 1;
                }
                else
                {
                    map += 1;
                }
                //touchMessage = "Map Right: " + map;
            }
        }
        else if (setTouch == 3)
        {
            modeIndex = (int)gameMode;
            if (modeIndex > 9)
            {
                FUN_1E098(1, Menu.instance.sounds, 0, 4095);
                modeIndex--;
                if (modeIndex < 10) modeIndex = Enum.GetNames(typeof(_GAME_MODE)).Length - 1;
                touchMessage = "Mode Left: " + gameMode;
            }
            else
            {
                FUN_1E098(1, Menu.instance.sounds, 9, 4095);
            }
        }
        else if (setTouch == 4)
        {
            modeIndex = (int)gameMode;
            if (modeIndex < 13)
            {
                FUN_1E098(1, Menu.instance.sounds, 0, 4095);
                modeIndex++;
                if (modeIndex >= Enum.GetNames(typeof(_GAME_MODE)).Length) modeIndex = 10;
                //touchMessage = "Mode Right: " + gameMode;
            }
            else
            {
                FUN_1E098(1, Menu.instance.sounds, 9, 4095);
            }
        }
        else if (setTouch == 5)
        {
            if (currentValueLives > 1)
            {
                FUN_1E098(1, Menu.instance.sounds, 0, 4095);
                currentValueLives -= 1;
                sbyte b = playerSpawns = (sbyte)currentValueLives;
                for (int i = 0; i < networkMembers.Count; i++)
                {
                    DAT_1030[i] = b;
                }
                //touchMessage = "Damages Left: " + currentValueLives;
                await ClientSend.Lives(playerSpawns, 0L).ContinueWith(Task =>
                    {

                    });
            }
            else
            {
                FUN_1E098(1, Menu.instance.sounds, 9, 4095);
            }
        }
        else if (setTouch == 6)
        {
            if (currentValueLives < 3)
            {
                FUN_1E098(1, Menu.instance.sounds, 0, 4095);
                currentValueLives += 1;
                sbyte b = playerSpawns = (sbyte)currentValueLives;
                for (int i = 0; i < networkMembers.Count; i++)
                {
                    DAT_1030[i] = b;
                }
                //touchMessage = "Damages Left: " + currentValueLives;
                await ClientSend.Lives(playerSpawns, 0L).ContinueWith(Task =>
                    {

                    });

            }
            else
            {
                FUN_1E098(1, Menu.instance.sounds, 9, 4095);
            }
        }
        else if (setTouch == 7)
        {
            if (currentDamageIndex > 1)
            {
                FUN_1E098(1, Menu.instance.sounds, 0, 4095);
                currentDamageIndex -= 1;
                damageMode[0] = (sbyte)currentDamageIndex;
                damageMode[1] = (sbyte)currentDamageIndex;
                await ClientSend.Damage(0L).ContinueWith(Task =>
                    {

                    });
                //touchMessage = "Damages Left: " + currentDamageIndex;
            }
            else
            {
                FUN_1E098(1, Menu.instance.sounds, 9, 4095);
            }
        }
        else if (setTouch == 8)
        {
            if (currentDamageIndex < 3)
            {
                FUN_1E098(1, Menu.instance.sounds, 0, 4095);
                currentDamageIndex += 1;
                damageMode[0] = (sbyte)currentDamageIndex;
                damageMode[1] = (sbyte)currentDamageIndex;
                await ClientSend.Damage(0L).ContinueWith(Task =>
                    {

                    });
                //touchMessage = "Damages Right: " + currentDamageIndex;
            }
            else
            {
                FUN_1E098(1, Menu.instance.sounds, 9, 4095);
            }
        }
        else if (setTouch == 9)
        {
            if (currentValueDifficulty > 1)
            {
                FUN_1E098(1, Menu.instance.sounds, 0, 4095);
                currentValueDifficulty -= 1;
                //touchMessage = "Difficulty Right: " + currentValueDifficulty;
            }
            else
            {
                FUN_1E098(1, Menu.instance.sounds, 9, 4095);
            }
        }
        else if (setTouch == 10)
        {
            if (currentValueDifficulty < 3)
            {
                FUN_1E098(1, Menu.instance.sounds, 0, 4095);
                currentValueDifficulty += 1;
                //touchMessage = "Difficulty Right: " + currentValueDifficulty;
            }
            else
            {
                FUN_1E098(1, Menu.instance.sounds, 9, 4095);
            }
        }

        SetMultiplayerMode();
        SetOnlineDamage();
        //SetDamage();
        SetStage();
        SetDifficulty();
        SetLives();

        setTouch = 0;

        //Debug.Log("Touch: " + touchMessage);

        //Debug.Log(ReInput.mapping.GetActionId("Mode-Touch LEFT"));
        //Debug.Log(ReInput.players.GetPlayer(0).GetButtonDown("Mode-Touch LEFT"));
        await Task.Yield(); // Esperar un frame
    }

    [Header("Spawn IA Combo L1+R1+L2+R2")]
    private bool pressed = false;

    private void Update()
    {
        //Obtener la progresión de carga de la escena actual
        //loadingProgress = SceneManager.LoadSceneAsync(map).progress;

        if (inDebug || inMenu || SceneManager.GetActiveScene().name == "MENU-Driver" || SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            if (player.GetButtonDown("Escape"))
            {
                Application.Quit();
            }
            return;
        }
        else
        {
            //Debug.Log("Miembros en Partida..." + networkMembers.Count);
            //Debug.Log("Values en Partida..." + networkMembers.Values);
            //foreach (var value in networkMembers.Values)
            //{
            //    Debug.Log("Miembro: " + value);
            //    Debug.Log("Tipo de Vehiculo: " + value.vehicle);
            //    //Debug.Log("Nombre de Vehiculo: " + value.userId);
            //    Debug.Log("userId de Vehiculo: " + value.userId);
            //    //Debug.Log("userId de Vehiculo: " + value.gameTag);
            //    //Realizar acciones con el valor
            //    //...
            //}
        }

        if (player.GetButtonDown("F1"))
        {
            Debug.Log("Press...");
            guiButton = !guiButton;
        }

        if (player.GetButton("L2") && player.GetButton("R2") && player.GetButton("L1") && player.GetButton("R1") && !pressed)
        {
            DAT_1030[0] = 1;
            DAT_1030[2] = 1;
            DAT_1030[3] = 1;
            DAT_1030[4] = 1;
            DAT_1030[5] = 1;
            DAT_1030[6] = 1;
        }
        if (isWait)
            if (player.GetButton("SELECT") && player.GetButton("START") && player.GetButton("L2") && player.GetButton("R2") && player.GetButton("L1") && player.GetButton("R1") || player.GetButtonDown("Escape"))
            //if (player.GetButtonDown("START"))
            {
                if (gameMode >= _GAME_MODE.Versus2)
                {
                    //DiscordController.instance.DisconnectNetwork2();
                    DiscordController.DisconnectNetwork2();
                }
                while (DiscordController.instance.pendingCallbacks)
                {
                    DiscordController.instance.discord.RunCallbacks();
                }
                LoadDebug();
            }
        FUN_3827C(playerObjects[0], DAT_F00); //PointPotitionMap?
        if (player.GetButtonDown("START") || player.GetButtonDown("Space"))
        {
            if (isWait)
                if (isHost || !online)
                {
                    paused = !paused;
                    if (gameMode >= _GAME_MODE.Versus2)
                    {
                        if (online)
                            ClientSend.Pause();
                    }
                }
        }
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        if (player.GetButtonDown("Home"))
        {
            enableReticle = !enableReticle;
        }
        if (player.GetButtonDown("Return"))
        {
            ScreenCapture.CaptureScreenshot("screenshot.png");
        }
        if (player.GetButtonDown("Delete"))
        {
            noAI = !noAI;
        }
        if (player.GetButtonDown("Insert"))
        {
            noPhysics = !noPhysics;
        }
        if (player.GetButtonDown("End"))
        {
            noHUD = !noHUD;
            UIManager.instance.hudRect.gameObject.SetActive(noHUD);
            UIManager.instance.feedbackRect.gameObject.SetActive(noHUD);
        }
    }

    public bool isWait = false;
    int sceneMap = new int();

    //IEnumerator UpdateReflections()
    //{
    //    while (true)
    //    {
    //        //updateReflections = true;
    //        yield return new WaitForSeconds(reflectionUpdateTime);
    //        //shouldRunCoroutine = true;
    //    }
    //}

    //IEnumerator UpdateReflections()
    //{
    //    while (true)
    //    {
    //        //updateReflections = true;
    //        yield return new WaitForSeconds(reflectionUpdateTime);
    //        //shouldRunCoroutine = true;
    //    }
    //}

    private void StopReflections()
    {
        if (reflectionsCoroutine != null)
        {
            StopCoroutine(reflectionsCoroutine);
            reflectionsCoroutine = null;
        }
    }

    private async void FixedUpdate()
    {
        if (inDebug || inMenu || SceneManager.GetActiveScene().name == "MENU-Driver" || SceneManager.GetActiveScene().name == "DEBUG-Online")
        {
            //Debug.Log("In Debug Return");
            await Task.Yield(); // Esperar un frame
            return;
        }

        if (!isWait)
            if (player.GetButtonDown("CROSS") || player.GetButtonDown("Space")) //Presiona X para empezar
            {
                {
                    if (online)
                    {
                        await new ClientSend().waitLoad();
                        paused = !paused;
                    }
                    else
                        paused = !paused;
                    isWait = !isWait;
                    DestroyProgressBar();
                    //reflectionsCoroutine = StartCoroutine(UpdateReflections());
                    //StartCoroutine(UpdateReflections());
                    //SceneManager.UnloadSceneAsync(19);
                    await MusicManager.instance.PlayNextMusic().ContinueWith(Task =>
                    {

                    });
                }
            }

        if (isWait)
        {
            //Retiene la funcion de LevelManager
            if (!LevelManager.instance)
            {
                //Debug.Log("Return...");
                await Task.Yield(); // Esperar un frame
                return;
            }
            else
            {
                //Debug.Log("NoReturn...");
                if (!LevelManager.instance.isEnabled)
                {
                    if (SceneLoader.staticCanvasLoadScene.enabled)
                        SceneLoader.staticCanvasLoadScene.enabled = false;
                    //SceneLoader.staticCanvasLoadScene = null;
                    //SceneManager.UnloadScene("LoadScene");
                    Debug.Log("Continue...");
                    //if (UIManager.instance)
                    //    UIManager.instance.UiInitiate();
                    LevelManager.instance.enabled = true;
                    switch (sceneMap)
                    {
                        case 1:
                            //LevelManager.instance.GetComponent<Route66>().enabled = true;
                            //GameObject.Find("LevelManager").GetComponent<Route66>().enabled = true;
                            break;
                        case 2:
                            //GameObject.Find("LevelManager").GetComponent<OLYMPIC>().enabled = true;
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                            break;
                        case 10:
                            break;
                        case 11:
                            break;
                        case 12:
                            break;
                        case 13:
                            break;
                        case 14:
                            break;
                        case 15:
                            break;
                        case 16:
                            break;
                        case 17:
                            break;
                        case 18:
                            break;
                    }
                    LevelManager.instance.isEnabled = true;
                }
            }
            //Debug.Log("isWait...Done");

            Color32 color = UIManager.instance.flash.color;

            if (color.r != 0 || color.g != 0 || color.b != 0 || color.a != 0)
            {
                UIManager.instance.flash.color = new Color32(0, 0, 0, 0);
            }

            if (gameMode >= _GAME_MODE.Versus2)
            {
                for (int i = 0; i < networkMembers.Count; i++)
                {
                    if (networkMembers.ContainsValue(null))
                    {
                        //Debug.Log("No hay Miembros en Partida..." + networkMembers.Count);
                        //Debug.Log("No hay Miembros en Partida..." + networkMembers.name);
                        await Task.Yield(); // Esperar un frame
                        return;
                    }
                    //if (online)
                    //ClientSend.Spawn();
                    //Debug.Log("Miembros en Partida..." + networkMembers.Count);
                }
            }

            if (!paused)
            {
                uint num = 1U;
                int num2 = 0;
                while ((long)num2 < (long)((ulong)num))
                {
                    this.DAT_28++;
                    this.timer = (ushort)this.DAT_28;
                    uint num3 = 0U;
                    if ((long)num2 == (long)((ulong)(num - 1U)))
                    {
                        num3 = num;
                    }
                    this.FUN_313C8((int)num3);
                    this.FUN_31440((uint)this.DAT_28);
                    this.FUN_31728();
                    for (int j = 0; j < this.worldObjs_tmp.Count; j++)
                    {
                        this.worldObjs.Remove(this.worldObjs_tmp[j]);
                    }
                    this.worldObjs_tmp.Clear();
                    if (this.playerObjects[0] != null && (InputManager.controllers[0].DAT_A & 128) != 0)
                    {
                        this.playerObjects[0].view = (_CAR_VIEW)3 - (int)this.playerObjects[0].view;
                    }
                    num2++;
                    await Task.Yield();
                }
            }
            else
            {
                //Debug.Log("Camera..." + cameraObjects[0].vTransform.rotation.Matrix2Quaternion); en pausa
                cameraObjects[0].vTransform.rotation = Utilities.RotMatrixYXZ_gte(cameraObjects[0].vr);
            }
            FUN_31360((ushort)(DAT_28 & 0xFFFF));
            DAT_24 = 1 - DAT_24;
            if (screenMode == _SCREEN_MODE.Horizontal)
            {
                int param2 = 320;
                int param3 = 160;
                int param4 = 120;
                int param5 = 60;
                FUN_2DF30(param2, param4, param3, param5);
            }
            else if (screenMode < _SCREEN_MODE.Vertical)
            {
                int param2 = 512;
                if (screenMode == _SCREEN_MODE.Whole)
                {
                    int param4 = 240;
                    int param3 = 160;
                    int param5 = 120;
                    FUN_2DF30(param2, param4, param3, param5);
                }
            }
            else
            {
                int param2;
                if (screenMode == _SCREEN_MODE.Vertical)
                {
                    param2 = 160;
                    int param4 = 240;
                    int param3 = 80;
                    int param5 = 120;
                    FUN_2DF30(param2, param4, param3, param5);
                }
                param2 = 160;
                if (screenMode == _SCREEN_MODE.Unknown)
                {
                    int param3 = 80;
                    int param4 = 120;
                    int param5 = 60;
                    FUN_2DF30(param2, param4, param3, param5);
                }
            }
            if (screenMode == _SCREEN_MODE.Whole)
            {
                Vehicle vehicle;
                VigObject vigObject;
                if (gameMode < _GAME_MODE.Versus || playerObjects[0].maxHalfHealth != 0 || gameMode >= _GAME_MODE.Versus2)
                {
                    vehicle = playerObjects[0];
                    if (playerObjects[1] != null)
                    {
                        uint flags = playerObjects[1].flags;
                        vigObject = playerObjects[1];
                        if ((flags & 0x2000000) == 0)
                        {
                            vigObject.flags = (uint)((int)flags & -3);
                        }
                    }
                }
                else
                {
                    uint flags = playerObjects[0].flags;
                    vigObject = playerObjects[0];
                    vehicle = playerObjects[1];
                    if ((flags & 0x2000000) == 0)
                    {
                        vigObject.flags = (uint)((int)flags & -3);
                    }
                }
                short fieldOfView;
                if (vehicle.view == _CAR_VIEW.Close)
                {
                    if ((vehicle.flags & 0x2000000) != 0)
                    {
                        VigCamera vCamera = vehicle.vCamera;
                        fieldOfView = vCamera.fieldOfView;
                        vigObject = vCamera;
                    }
                    else
                    {
                        vigObject = vehicle.closeViewer;
                        vehicle.flags |= 2u;
                        fieldOfView = vehicle.vCamera.fieldOfView;
                    }
                }
                else
                {
                    if ((vehicle.flags & 0x2000000) == 0)
                    {
                        vehicle.flags &= 4294967293u;
                    }
                    VigCamera vCamera2 = vehicle.vCamera;
                    fieldOfView = vCamera2.fieldOfView;
                    vigObject = vCamera2;
                }
                LevelManager.instance.defaultCamera.transform.SetParent(vigObject.transform, worldPositionStays: false); //error?
                FUN_2D278(vigObject, fieldOfView);
                terrain.DAT_BDFF0[0] = DAT_F00;
                FUN_31678();
                atStart = true;
                if (DAT_1084 < 0)
                {
                    DAT_1084 = 0;
                }
                if (vehicle.view != 0)
                {
                    UIManager.instance.UpdateHUD(playerObjects[0], DAT_28);
                }
                UIManager.instance.RefreshFlares(DAT_28);
                UIManager.instance.RefreshCameras();
                UIManager.instance.RefreshDestroyed(this.EnemyKill);
            }
            for (int l = 0; l < DAT_1088_tmp.Count; l++)
            {
                DAT_1088.Remove(DAT_1088_tmp[l]);
            }
            DAT_1088_tmp.Clear();
            for (int m = 0; m < DAT_1110_tmp.Count; m++)
            {
                DAT_1110.Remove(DAT_1110_tmp[m]);
            }
            DAT_1110_tmp.Clear();

            //Si no son los modos Online
            if (gameMode < _GAME_MODE.Versus2)
            {
                await Task.Yield(); // Esperar un frame
                return;
            }
            if (online)
            {
                ClientSend.Transform(playerObjects[0].vTransform);
                ClientSend.Physics(playerObjects[0].physics1, playerObjects[0].physics2);
                ClientSend.Control(playerObjects[0]);
                ClientSend.Status(playerObjects[0]);
                ClientSend.RandomNumber(DAT_63A64, DAT_63A68);
            }
            if (gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner())
            {
                for (int n = 0; n < networkEnemies.Count; n++)
                {
                    if (online)
                    {
                        ClientSend.TransformAI(networkEnemies[n].id, networkEnemies[n].vTransform);
                        ClientSend.PhysicsAI(networkEnemies[n].id, networkEnemies[n].physics1, networkEnemies[n].physics2);
                        ClientSend.ControlAI(networkEnemies[n]);
                        ClientSend.StatusAI(networkEnemies[n]);
                    }
                }
            }
        }
        await Task.Yield(); // Esperar un frame
    }

    private Coroutine reflectionsCoroutine;

    private bool shouldRunCoroutine = true;

    private void FUN_1C158()
    {
        //Posiblemente establece la cantidad de objetos dibujados en la escena?
        if (this.gameMode < _GAME_MODE.Coop || this.gameMode >= _GAME_MODE.Versus2)
        {
            this.DAT_DB4 = drawDistance1; //125
            this.DAT_DB6 = drawDistance2; //32767
            this.DAT_DB8 = drawDistance3; //32767
            //this.DAT_DB4 = 80;
            //this.DAT_DB6 = 40;
            //this.DAT_DB8 = 20;
        }
        else
        {
            this.DAT_DB4 = drawDistance1;
            this.DAT_DB6 = drawDistance2;
            this.DAT_DB8 = drawDistance3;
            //this.DAT_DB4 = 48;
            //this.DAT_DB6 = 24;
            //this.DAT_DB8 = 12;
        }
        Utilities.SetRotMatrix(this.DAT_F28.rotation);
        Vector3Int vector3Int = default(Vector3Int);
        vector3Int.x = this.DAT_F28.position.x;
        if (this.DAT_F28.position.x < 0)
        {
            vector3Int.x = this.DAT_F28.position.x + 255;
        }
        vector3Int.x >>= 8;
        vector3Int.y = this.DAT_F28.position.y;
        if (this.DAT_F28.position.y < 0)
        {
            vector3Int.y = this.DAT_F28.position.y + 255;
        }
        vector3Int.y >>= 8;
        vector3Int.z = this.DAT_F28.position.z;
        if (this.DAT_F28.position.z < 0)
        {
            vector3Int.z = this.DAT_F28.position.z + 255;
        }
        vector3Int.z >>= 8;
        this.terrain.UpdatePosition((Vector3)this.DAT_F28.position / (float)this.translateFactor);
        GameManager.DAT_1f800084 = new Vector3Int(-vector3Int.x, -vector3Int.y, -vector3Int.z);
        Coprocessor.translationVector._trx = vector3Int.x;
        Coprocessor.translationVector._try = vector3Int.y;
        Coprocessor.translationVector._trz = vector3Int.z;
        int num = (int)this.DAT_DB4 * (this.DAT_EDC / 2) * 256 / this.DAT_ED8;
        uint num2 = 0U;
        int num3 = (int)this.DAT_DB4 * (this.DAT_F20 / 2) * 256 / this.DAT_ED8;
        uint num4 = 0U;
        Vector3Int vector3Int2 = default(Vector3Int);
        List<Vector3Int> list = new List<Vector3Int>();
        do
        {
            vector3Int2.x = num;
            if (num4 == 0U)
            {
                vector3Int2.x = -vector3Int2.x;
            }
            vector3Int2.y = num3;
            if ((num2 & 2U) == 0U)
            {
                vector3Int2.y = -vector3Int2.y;
            }
            num2 += 1U;
            vector3Int2.z = (int)this.DAT_DB4 << 8;
            list.Add(Utilities.FUN_23F58(vector3Int2));
            num4 = num2 & 1U;
        }
        while (num2 < 4U);
        int i = 0;
        num = 0;
        List<Vector2Int> list2 = new List<Vector2Int>();
        list.Add(vector3Int);
        do
        {
            if (list[num].y + 8 < 12289)
            {
                list2.Add(new Vector2Int(list[num].x, list[num].z));
                i++;
            }
            num++;
        }
        while (num < 5);
        num = 0;
        int num7;
        do
        {
            num4 = (uint)GameManager.DAT_639A0[num * 2];
            num2 = (uint)GameManager.DAT_639A0[num * 2 + 1];
            int num5 = (int)num4;
            int num6 = (int)num2;
            if (list[num6].y < -8)
            {
                if (-9 < list[num5].y)
                {
                    num3 = list[num5].x;
                    list2.Add(new Vector2Int(num3 + (list[num6].x - num3) * (-8 - list[num5].y) / (list[num6].y - list[num5].y), list[num5].z + (list[num6].z - list[num5].z) * (-8 - list[num5].y) / (list[num6].y - list[num5].y)));
                    i++;
                }
            }
            else if (-9 >= list[num5].y)
            {
                num3 = list[num5].x;
                list2.Add(new Vector2Int(num3 + (list[num6].x - num3) * (-8 - list[num5].y) / (list[num6].y - list[num5].y), list[num5].z + (list[num6].z - list[num5].z) * (-8 - list[num5].y) / (list[num6].y - list[num5].y)));
                i++;
            }
            if (list[num6].y < 12281)
            {
                if (list[num5].y >= 12281)
                {
                    num3 = list[num5].x;
                    list2.Add(new Vector2Int(num3 + (list[num6].x - num3) * (12280 - list[num5].y) / (list[num6].y - list[num5].y), list[num5].z + (list[num6].z - list[num5].z) * (12280 - list[num5].y) / (list[num6].y - list[num5].y)));
                    i++;
                }
            }
            else if (list[num5].y < 12281)
            {
                num3 = list[num5].x;
                list2.Add(new Vector2Int(num3 + (list[num6].x - num3) * (12280 - list[num5].y) / (list[num6].y - list[num5].y), list[num5].z + (list[num6].z - list[num5].z) * (12280 - list[num5].y) / (list[num6].y - list[num5].y)));
                i++;
            }
            num++;
            num7 = 0;
        }
        while (7 >= num);
        if (i != 0)
        {
            num = int.MaxValue;
            int num8 = int.MaxValue;
            num3 = 0;
            int num9;
            if (0 < i)
            {
                do
                {
                    num9 = list2[num3].y;
                    if (num9 < num || (num9 == num && list2[num3].x < num8))
                    {
                        num8 = list2[num3].x;
                        num = num9;
                        num7 = num3;
                    }
                    num3++;
                }
                while (num3 < i);
            }
            list2[num7] = new Vector2Int(list2[0].x, list2[0].y);
            list2[0] = new Vector2Int(num8, num);
            num3 = i - 1;
            num9 = 1;
            bool flag;
            do
            {
                flag = false;
                int num10 = num9;
                int num11 = 0;
                if (num9 < num3)
                {
                    do
                    {
                        int num6 = num9;
                        int num12 = num9 + 1;
                        int num13 = num12;
                        int x = list2[num6].x;
                        int y = list2[num13].y;
                        int j = x - num8;
                        int y2 = list2[num6].y;
                        int x2 = list2[num13].x;
                        int num14 = x2 - num8;
                        int num15 = j * (y - num) - (y2 - num) * num14;
                        if (num15 == 0)
                        {
                            i--;
                            num3--;
                            bool flag2;
                            if (y2 == y)
                            {
                                if (j < 0)
                                {
                                    j = -j;
                                }
                                if (num14 < 0)
                                {
                                    num14 = -num14;
                                }
                                flag2 = num14 < j;
                            }
                            else
                            {
                                flag2 = y < y2;
                            }
                            for (j = num9 + (flag2 ? 1 : 0); j < i; j = num14)
                            {
                                num14 = j + 1;
                                num12 = list2[num14].y;
                                list2[j] = new Vector2Int(list2[num14].x, num12);
                            }
                            num9--;
                        }
                        else if (num15 < 0)
                        {
                            list2[num6] = new Vector2Int(x2, list2[num13].y);
                            list2[num13] = new Vector2Int(x, y2);
                            if (!flag)
                            {
                                num10 = 1;
                                if (2 < num9)
                                {
                                    num10 = num9 - 1;
                                }
                                flag = true;
                            }
                            num11 = num9;
                        }
                        num9++;
                    }
                    while (num9 < num3);
                }
                num3 = num11;
                num9 = num10;
            }
            while (flag);
            num3 = 0;
            num = 0;
            if (0 < i)
            {
                int num13 = 0;
                do
                {
                    if (1 < num)
                    {
                        do
                        {
                            num9 = num - 1;
                            num8 = list2[num9].x;
                            if ((list2[num9].y - list2[num - 2].y) * (list2[num13].x - num8) <= (num8 - list2[num - 2].x) * (list2[num13].y - list2[num9].y))
                            {
                                break;
                            }
                            num = num9;
                        }
                        while (1 < num9);
                    }
                    num8 = list2[num13].y;
                    list2[num] = new Vector2Int(list2[num13].x, num8);
                    num++;
                    num3++;
                    num13++;
                }
                while (num3 < i);
            }
            Utilities.SetRotMatrix(this.DAT_F00.rotation);
            Utilities.SetRotMatrix3(this.DAT_F00.rotation);
            Coprocessor.translationVector._trx = 0;
            Coprocessor.translationVector._try = 0;
            Coprocessor.translationVector._trz = 0;
            Coprocessor3.translationVector._trx = 0;
            Coprocessor3.translationVector._try = 0;
            Coprocessor3.translationVector._trz = 0;
            Utilities.SetColorMatrix(this.levelManager.DAT_738);
            Utilities.SetColorMatrix3(this.levelManager.DAT_738);
            Utilities.SetLightMatrix(GameManager.DAT_718);
            Utilities.SetLightMatrix3(GameManager.DAT_718);
            Utilities.SetBackColor((int)this.levelManager.DAT_E04.r, (int)this.levelManager.DAT_E04.g, (int)this.levelManager.DAT_E04.b);
            Utilities.SetBackColor3((int)this.levelManager.DAT_E04.r, (int)this.levelManager.DAT_E04.g, (int)this.levelManager.DAT_E04.b);
            Utilities.SetFarColor((int)this.levelManager.DAT_DA4.r, (int)this.levelManager.DAT_DA4.g, (int)this.levelManager.DAT_DA4.b);
            Utilities.SetFarColor3((int)this.levelManager.DAT_DA4.r, (int)this.levelManager.DAT_DA4.g, (int)this.levelManager.DAT_DA4.b);
            GameManager.DAT_1f800080 = 256;
            Utilities.SetFogNearFar((int)this.DAT_DB6 << 8, (int)this.DAT_DB4 << 8, this.DAT_ED8);
            Utilities.SetFogNearFar3((int)this.DAT_DB6 << 8, (int)this.DAT_DB4 << 8, this.DAT_ED8);
            Coprocessor.colorCode.r = this.levelManager.DAT_DDC.r;
            Coprocessor.colorCode.g = this.levelManager.DAT_DDC.g;
            Coprocessor.colorCode.b = this.levelManager.DAT_DDC.b;
            Coprocessor.colorCode.code = this.levelManager.DAT_DDC.a;
            for (i = 0; i < 32; i++)
            {
                Coprocessor.accumulator.ir1 = (short)(i << 7);
                Coprocessor.ExecuteCC(12, true);
                VigTerrain.DAT_BA4F0[i] = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, Coprocessor.colorFIFO.cd2);
                GameManager.DAT_1f800000[i] = new Color32(this.terrain.DAT_B9370[i].r, this.terrain.DAT_B9370[i].g, this.terrain.DAT_B9370[i].b, 52);
            }
            GameManager.DAT_1f800094 = (short)((ushort)this.DAT_EDC);
            GameManager.DAT_1f800096 = (short)((ushort)this.DAT_F20);
            GameManager.DAT_1f800098 = (short)(this.DAT_DB6 << 8);
            GameManager.DAT_1f80009a = (short)(this.DAT_DB8 << 8);
            GameManager.DAT_1f800094 = DAT_1f800094_; //100 new 32767
            GameManager.DAT_1f800096 = DAT_1f800096_; //240 new 32767
            GameManager.DAT_1f800098 = DAT_1f800098_; //10240 new 32767   safe: 16328
            GameManager.DAT_1f80009a = DAT_1f80009a_; //5120 new 14124 solo si mantiene camara centrada //seguro si camara hace padding: 2019
            this.nativeArray = new NativeArray<Vector2Int>(list2.Count, Allocator.Persistent, NativeArrayOptions.ClearMemory);
            for (int k = 0; k < this.nativeArray.Length; k++)
            {
                this.nativeArray[k] = list2[k];
            }
            this.terrainJob = new GameManager.TerrainJob
            {
                param1 = this.nativeArray,
                param2 = num
            };
            this.terrainHandle = this.terrainJob.Schedule(default(JobHandle));
        }
    }

    private int FUN_1E354(Vector3Int v3)
    {
        int num = Utilities.FUN_29E84(v3);
        int num2 = num + 2097152;
        if (num2 < 0)
        {
            num2 = num + 2101247;
        }
        return ((int)this.DAT_E1C << 9) / (num2 >> 12);
    }

    private int FUN_1E39C(Vector3Int v3)
    {
        int num = Utilities.FUN_29E84(v3);
        int num2 = num + 2097152;
        if (num2 < 0)
        {
            num2 = num + 2101247;
        }
        int num3 = ((int)this.DAT_E1C << 9) / (num2 >> 12);
        num2 = Utilities.LeadingZeros(num);
        uint num4 = 12U;
        if ((int)((long)num2 - 1L) < 12)
        {
            num4 = (uint)((long)num2 - 1L);
        }
        if (num == 0)
        {
            num = 0;
        }
        else
        {
            num = (v3.x << (int)num4) / (num >> (int)(12U - num4));
        }
        num2 = (4096 - num) * num3;
        if (num2 < 0)
        {
            num2 += 8191;
        }
        num3 = (num + 4096) * num3;
        if (num3 < 0)
        {
            num3 += 8191;
        }
        return (num2 >> 13) | (num3 >> 13 << 16);
    }

    public uint FUN_1E478(Vector3Int pos)
    {
        Vector3Int v = Utilities.FUN_24148(DAT_F00, pos);
        int num;
        if (screenMode == _SCREEN_MODE.Whole)
        {
            if (!DAT_83B)
            {
                return (uint)FUN_1E39C(v);
            }
            num = FUN_1E354(v);
            return (uint)((num * 65536 >> 16) + num * 65536);
        }
        Vector3Int v2 = Utilities.FUN_24148(terrain.DAT_BDFF0[0], pos);
        short num2;
        if (!DAT_83B)
        {
            num = FUN_1E354(v);
            num2 = (short)FUN_1E354(v2);
            return (uint)((num << 16) | (ushort)num2);
        }
        num2 = (short)FUN_1E354(v);
        short num3 = (short)FUN_1E354(v2);
        num = DAT_E1C;
        if (num2 + num3 < DAT_E1C)
        {
            num = num2 + num3;
        }
        return (uint)(num * 65537);
    }

    public int FUN_1E67C(Vector3Int param1)
    {
        int num = Utilities.FUN_29E84(param1);
        if (2097152 - num < 0)
        {
            return 0;
        }
        int num2 = (2097152 - num >> 12) * DAT_E1C;
        if (num2 < 0)
        {
            num2 += 511;
        }
        return num2 << 7 >> 16;
    }

    public uint FUN_1E6D8(Vector3Int param1)
    {
        int num = Utilities.FUN_29E84(param1);
        uint result = 0u;
        if (num < 2097152)
        {
            int num2 = -num + 2097152;
            if (num2 < 0)
            {
                num2 = -num + 2101247;
            }
            num2 = (num2 >> 12) * DAT_E1C;
            if (num2 < 0)
            {
                num2 += 511;
            }
            int num3 = (num != 0) ? ((param1.x << 12) / num) : 0;
            int num4 = (4096 - num3) * (num2 >> 9);
            if (num2 < 0)
            {
                num2 += 8191;
            }
            result = (uint)((num4 >> 13) | (num2 >> 13 << 16));
        }
        return result;
    }

    public uint FUN_1E7A8(Vector3Int param1)
    {
        Vector3Int param2 = Utilities.FUN_24148(DAT_F00, param1);
        if (screenMode == _SCREEN_MODE.Whole)
        {
            return FUN_1E6D8(param2);
        }
        Vector3Int param3 = Utilities.FUN_24148(terrain.DAT_BDFF0[0], param1);
        int num = FUN_1E67C(param2);
        short num2 = (short)FUN_1E67C(param3);
        return (uint)(((uint)num << 16) | (ushort)num2);
    }

    public void FUN_15B00(int param1, byte param2, byte param3, byte param4)
    {
        if (gameMode != _GAME_MODE.Demo)
        {
            DAT_D28[param1, 5] = param2;
            DAT_D28[param1, 6] = param3;
            DAT_D28[param1, 7] = param4;
        }
    }

    public void FUN_15ADC(int param1, byte param2)
    {
        if (gameMode != _GAME_MODE.Demo)
        {
            DAT_D28[param1, 4] = param2;
        }
    }

    public void FUN_15AA8(int param1, byte param2, byte param3, byte param4, byte param5)
    {
        if (gameMode != _GAME_MODE.Demo)
        {
            DAT_D28[param1, 4] = param2;
            DAT_D28[param1, 5] = param3;
            DAT_D28[param1, 6] = param4;
            DAT_D28[param1, 7] = param5;
        }
    }

    public async void FUN_2D278(VigObject param1, int param2)
    {
        VigTransform param3 = FUN_2CDF4(param1);
        FUN_2E0E8(param3, param2);
        await Task.Yield();
    }

    public void FUN_2DFF0(VigTransform param1)
    {
        VigTransform vigTransform = default(VigTransform);
        vigTransform.rotation.V00 = (short)DAT_ED8;
        vigTransform.rotation.V02 = (short)(-DAT_EDC + (int)((uint)(-DAT_EDC) >> 31) >> 1);
        vigTransform.rotation.V10 = (short)(-vigTransform.rotation.V00);
        vigTransform.rotation.V12 = vigTransform.rotation.V02;
        vigTransform.rotation.V21 = (short)(-vigTransform.rotation.V00);
        vigTransform.rotation.V22 = (short)(-DAT_F20 + (int)((uint)(-DAT_F20) >> 31) >> 1);
        Vector3Int n = new Vector3Int(vigTransform.rotation.V00, vigTransform.rotation.V01, vigTransform.rotation.V02);
        Vector3Int n2 = new Vector3Int(vigTransform.rotation.V10, vigTransform.rotation.V11, vigTransform.rotation.V12);
        Vector3Int n3 = new Vector3Int(vigTransform.rotation.V20, vigTransform.rotation.V21, vigTransform.rotation.V22);
        n = Utilities.VectorNormal(n);
        n2 = Utilities.VectorNormal(n2);
        n3 = Utilities.VectorNormal(n3);
        vigTransform.rotation = new Matrix3x3
        {
            V00 = (short)n.x,
            V01 = (short)n.y,
            V02 = (short)n.z,
            V10 = (short)n2.x,
            V11 = (short)n2.y,
            V12 = (short)n2.z,
            V20 = (short)n3.x,
            V21 = (short)n3.y,
            V22 = (short)n3.z
        };
        DAT_FD8 = Utilities.FUN_247C4(vigTransform.rotation, param1.rotation);
    }

    public HitDetection FUN_2F798(VigObject obj, HitDetection hit, int multiply = 1)
    {
        VigTransform vigTransform = FUN_2CDF4(hit.object2);
        BufferedBinaryReader collider = hit.collider1;
        long position = hit.collider1.Position;
        long position2 = hit.collider2.Position;
        if (collider.ReadUInt16(0) == 1)
        {
            BufferedBinaryReader collider2 = hit.collider2;
            BoundingBox boundingBox = default(BoundingBox);
            boundingBox.min = new Vector3Int(collider.ReadInt32(4), collider.ReadInt32(8) * multiply, collider.ReadInt32(12));
            boundingBox.max = new Vector3Int(collider.ReadInt32(16), collider.ReadInt32(20), collider.ReadInt32(24));
            BoundingBox bbox = boundingBox;
            if (collider2.ReadUInt16(0) == 1)
            {
                int num = 0;
                uint num2 = 2147483648u;
                int num3 = 0;
                do
                {
                    collider2.Seek(4L, SeekOrigin.Current);
                    Radius radius = default(Radius);
                    radius.matrixSV = default(Vector3Int);
                    if (num3 == 0)
                    {
                        radius.matrixSV.x = (((num3 == 3) ? 1 : 0) - 1) * 4096;
                    }
                    else
                    {
                        radius.matrixSV.x = ((num3 == 3) ? 1 : 0) << 12;
                    }
                    if (num3 == 1)
                    {
                        radius.matrixSV.y = (((num3 == 4) ? 1 : 0) - 1) * 4096;
                    }
                    else
                    {
                        radius.matrixSV.y = ((num3 == 4) ? 1 : 0) << 12;
                    }
                    if (num3 == 2)
                    {
                        radius.matrixSV.z = (((num3 == 5) ? 1 : 0) - 1) * 4096;
                    }
                    else
                    {
                        radius.matrixSV.z = ((num3 == 5) ? 1 : 0) << 12;
                    }
                    radius.contactOffset = collider2.ReadInt32(0);
                    if (num3 < 3)
                    {
                        radius.contactOffset = -radius.contactOffset;
                    }
                    int num4 = Utilities.FUN_2E5B0(bbox, obj.vTransform, radius, vigTransform);
                    if ((int)num2 < num4)
                    {
                        num = num3;
                        num2 = (uint)num4;
                    }
                    num3++;
                }
                while (num3 < 6);
                uint num5 = (num == 3) ? 1u : 0u;
                if (num == 0)
                {
                    num5--;
                }
                Vector3Int v = default(Vector3Int);
                v.x = (short)(num5 << 12);
                if (num == 1)
                {
                    v.y = (((num == 4) ? 1 : 0) - 1) * 4096;
                }
                else
                {
                    v.y = ((num == 4) ? 1 : 0) << 12;
                }
                if (num == 2)
                {
                    v.z = (((num == 5) ? 1 : 0) - 1) * 4096;
                }
                else
                {
                    v.z = ((num == 5) ? 1 : 0) << 12;
                }
                hit.normal1 = Utilities.ApplyMatrixSV(vigTransform.rotation, v);
                hit.normal2 = Utilities.FUN_24238(obj.vTransform.rotation, hit.normal1);
                if (hit.normal2.x < 0)
                {
                    hit.position.x = bbox.max.x;
                }
                else
                {
                    hit.position.x = bbox.min.x;
                }
                if (hit.normal2.y < 0)
                {
                    hit.position.y = bbox.max.y;
                }
                else
                {
                    hit.position.y = bbox.min.y;
                }
                if (hit.normal2.z < 0)
                {
                    hit.position.z = bbox.max.z;
                }
                else
                {
                    hit.position.z = bbox.min.z;
                }
                hit.distance = (int)num2;
            }
            else if (collider2.ReadUInt16(0) == 2)
            {
                uint num2 = 2147483648u;
                int num3 = 0;
                int num = 0;
                if (collider2.ReadUInt16(2) != 0)
                {
                    int num4 = 4;
                    do
                    {
                        Radius radius2 = default(Radius);
                        radius2.matrixSV = new Vector3Int(collider2.ReadInt16(num4), collider2.ReadInt16(num4 + 2), collider2.ReadInt16(num4 + 4));
                        radius2.contactOffset = collider2.ReadInt32(num4 + 8);
                        Radius radius3 = radius2;
                        int num6 = Utilities.FUN_2E5B0(bbox, obj.vTransform, radius3, vigTransform);
                        if ((int)num2 < num6)
                        {
                            num = num3;
                            num2 = (uint)num6;
                        }
                        num3++;
                        num4 += 12;
                    }
                    while (num3 < collider2.ReadUInt16(2));
                }
                num = num * 12 + 4;
                hit.normal1 = Utilities.ApplyMatrixSV(v0: new Vector3Int(collider2.ReadInt16(num), collider2.ReadInt16(num + 2), collider2.ReadInt16(num + 4)), m: vigTransform.rotation);
                hit.normal2 = Utilities.FUN_24238(obj.vTransform.rotation, hit.normal1);
                if (hit.normal2.x < 0)
                {
                    hit.position.x = bbox.max.x;
                }
                else
                {
                    hit.position.x = bbox.min.x;
                }
                if (hit.normal2.y < 0)
                {
                    hit.position.y = bbox.max.y;
                }
                else
                {
                    hit.position.y = bbox.min.y;
                }
                if (hit.normal2.z < 0)
                {
                    hit.position.z = bbox.max.z;
                }
                else
                {
                    hit.position.z = bbox.min.z;
                }
                hit.distance = (int)num2;
            }
        }
        hit.collider1.Seek(position, SeekOrigin.Begin);
        hit.collider2.Seek(position2, SeekOrigin.Begin);
        return hit;
    }

    public void FUN_2D778(VigObject param1, VigTransform param2)
    {
        {
            do
            {
                if ((param1.flags & 2) == 0)
                {

                    VigTransform vigTransform = Utilities.CompMatrixLV(param2, param1.vTransform);

                    if ((param1.flags & 0x10) != 0)
                    {
                        if ((param1.flags & 0x400) == 0)
                        {
                            vigTransform.rotation = Utilities.FUN_2A4A4(vigTransform.rotation);
                        }
                        else
                        {
                            vigTransform.rotation = param1.vTransform.rotation;
                        }
                    }

                    if (param1.vMesh != null)
                    {
                        param1.vMesh.FUN_21F70(vigTransform); //Spawn Chasis
                                                              //if (getDriver == 2)
                                                              //FUN_2D778(param1.child2, vigTransform);
                        Player = getPlayer;
                        //Debug.Log("1 - PlayerObject: " + param1.name + " - " + "Vehiculo: " + getDriver + " - " + "Player: " + getPlayer);
                    }

                    if (param1.child2 != null)
                    {
                        param1.child2.name = "ChildVehicle";
                        if (isBus == true)
                        {
                            //Muestra los tubos de escape solo si el vehículo actual es un bus
                            FUN_2D778(param1.child2, vigTransform);
                            Debug.Log("Bus - PlayerObject: " + param1.name + " - " + "Vehiculo: " + getDriver + " - " + "Player: " + getPlayer);
                        }
                        else if (isTruck != true)
                        {
                            // Muestra la carga solo si el vehículo actual es un camión
                            FUN_2D778(param1.child2, vigTransform);
                            //Debug.Log("Truck - PlayerObject: " + param1.name + " - " + "Vehiculo: " + getDriver + " - " + "Player: " + getPlayer);
                        }
                    }
                }
                param1 = param1.child;
            }
            while (param1 != null);
        }
    }

    public bool updateReflections = true;
    public float reflectionUpdateTime = 0.5f; //Tiempo en segundos entre actualizaciones de reflejos
    VigObject getPlayer;
    int getDriver;

    private bool isBus = false;
    private bool isTruck = false;
    VigObject Player;

    //Metodo StatsPanel 
    public void SetReflections(VigObject param1, int driver)
    {
        isBus = false;
        isTruck = false;

        if (driver == 4)
        {
            Player = param1;
            isTruck = true;
        }
        else if (driver == 8)
        {
            Player = param1;
            isBus = true;
        }

        getPlayer = param1;
        getDriver = driver;

        //Debug.Log("Objeto: " + param1);
        FUN_2D9E0(param1);
    }

    //Reflejo y otros


    public int Vehiclereflection = 0;

    List<VigTuple> vigObjectCount;
    IEnumerator UpdateReflections()
    {
        //while (true)
        //{
        //    //if (vigObjectCount != null)
        //    //{
        //    //    for (int i = 0; i < vigObjectCount.Count; i++)
        //    //    {
        //    //        //Debug.Log("vigObjectCount: " + vigObjectCount.Count);
        //    //        //Debug.Log("vObject: " + vigObjectCount[i].vObject);
        //    //        //this.FUN_2D9E0(vigObjectCount[i].vObject);
        //    //    }
        //    //}
        //    yield return new WaitForFixedUpdate();
        //}
        yield return new WaitForFixedUpdate();

    }

    [Header("Quiality Setting")]
    public bool enabledOptimization = true;
    public float checkFPS = 0.5f;
    public int refreshObject;
    public int notRefreshObject;
    public bool enabledRefreshMesh = true;
    public bool experimentalQuality = false;
    public bool enabledReflection = true;
    public bool enabledMesh = true;
    public bool enabledChild2 = true;
    public bool enabledvLoD = true;
    public bool enabledConsole = true;




    [Serializable]
    public class ObjectStateDictionary : ISerializationCallbackReceiver
    {
        [SerializeField]
        private List<VigObject> keys = new List<VigObject>();

        [SerializeField]
        private List<ObjectState> values = new List<ObjectState>();

        private Dictionary<VigObject, ObjectState> dictionary = new Dictionary<VigObject, ObjectState>();

        public void OnBeforeSerialize()
        {
            keys.Clear();
            values.Clear();

            foreach (var pair in dictionary)
            {
                keys.Add(pair.Key);
                values.Add(pair.Value);
            }
        }

        public void OnAfterDeserialize()
        {
            dictionary.Clear();

            if (keys.Count != values.Count)
            {
                Debug.LogError("Error al deserializar el diccionario. La cantidad de claves y valores no coincide.");
                return;
            }

            for (int i = 0; i < keys.Count; i++)
            {
                dictionary[keys[i]] = values[i];
            }
        }

        public void Add(VigObject key, ObjectState value)
        {
            dictionary.Add(key, value);
        }

        public bool ContainsKey(VigObject key)
        {
            return dictionary.ContainsKey(key);
        }

        public bool Remove(VigObject key)
        {
            return dictionary.Remove(key);
        }

        public bool TryGetValue(VigObject key, out ObjectState value)
        {
            return dictionary.TryGetValue(key, out value);
        }

        public ObjectState this[VigObject key]
        {
            get => dictionary[key];
            set => dictionary[key] = value;
        }
    }



#if DEBUG
    //Optimizacion
    [Serializable]
    public class SerializeObject<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        [SerializeField]
        private List<TKey> vigObjectList = new List<TKey>();

        [SerializeField]
        private List<TValue> objectStateElement = new List<TValue>();

        public void OnBeforeSerialize()
        {
            vigObjectList.Clear();
            objectStateElement.Clear();

            foreach (var pair in this)
            {
                vigObjectList.Add(pair.Key);
                objectStateElement.Add(pair.Value);
            }
        }

        public void OnAfterDeserialize()
        {
            this.Clear();

            if (vigObjectList.Count != objectStateElement.Count)
            {
                Debug.LogError("Error al deserializar el diccionario. La cantidad de claves y valores no coincide.");
                return;
            }

            for (int i = 0; i < vigObjectList.Count; i++)
            {
                this[vigObjectList[i]] = objectStateElement[i];
            }
        }
    }

    [SerializeField]
    private SerializeObject<VigObject, ObjectState> objectStates = new SerializeObject<VigObject, ObjectState>();
    // Clase auxiliar para almacenar el estado de los objetos
#else
    private Dictionary<VigObject, ObjectState> objectStates = new Dictionary<VigObject, ObjectState>();
#endif
    public void FUN_2D9E0(VigObject param1)
    {

        // Control de rendimiento: Verifica los FPS o consumo de recursos
        if (enabledOptimization)
        {
            if (ShouldReduceUpdateFrequency())
            {
                return;
            }
        }

        bool hasChanges = CheckForObjectChanges(param1);

        //Debug.Log("hasChanges: " + hasChanges);
        StoreObjectState(param1, hasChanges);
        //Debug.Log("hasChanges: " + hasChanges);

        if (hasChanges)
        {
            // Código para actualizar los reflejos aquí
            if (enabledReflection)
            {
                UpdateReflections(param1);
            }

            // Reinicia Mesh - Mejorar para borrar Mesh de Driver
            if (enabledRefreshMesh)
            {
                Utilities.ResetMesh(param1);
            }

            VigTransform vigTransform = Utilities.CompMatrixLV(DAT_F00, param1.vTransform);

            if (vigTransform.position.z >= 4194304)
            {
                return;
            }

            // Optimiza La carga en el escenario
            // Retorna en primera persona. Borra Mesh de Driver
            if ((param1.flags & 2) != 0 || !FUN_2E22C(param1.vTransform.position, param1.DAT_58))
            {
                return;
            }

            // Unknow
            if ((param1.flags & 0x10) != 0)
            {
                if ((param1.flags & 0x400) == 0)
                {
                    if (param1.vTransform.padding == 0)
                    {
                        vigTransform.rotation = DAT_EE0.rotation;
                    }
                    else
                    {
                        vigTransform.rotation = Utilities.FUN_2A4A4(vigTransform.rotation);
                    }
                }
                else
                {
                    vigTransform.rotation = param1.vTransform.rotation;
                }
            }

            uint num = 64u;

            // Calculo de Reflejos
            if (enabledReflection)
            {
                if ((param1.flags & 0x2000) != 0)
                {
                    int num2 = param1.vTransform.position.x;
                    if (num2 < 0)
                    {
                        num2 += 65535;
                    }
                    if ((uint)num2 > 117440512u)
                    {
                        num2 = 0;
                    }
                    int num3 = param1.vTransform.position.z;
                    if (num3 < 0)
                    {
                        num3 += 65535;
                    }
                    if ((uint)num3 > 117440512u)
                    {
                        num3 = 0;
                    }
                    num = (uint)(terrain.vertices[terrain.chunks[((uint)(num2 >> 16) >> 6) * 32 + ((uint)(num3 >> 16) >> 6)] * 4096 + (((long)(num3 >> 16) & 63L) * 2 + ((long)(num2 >> 16) & 63L) * 128) / 2] & 0xF800) >> 8;
                }
                Utilities.SetBackColor((int)num, (int)num, (int)num);
            }

            if (param1.DAT_6C == 0 || vigTransform.position.z <= param1.DAT_6C)
            {
                if ((param1.flags & 0x20000) == 0)
                {
                    if ((param1.flags & 0x10000) == 0 || DAT_DA0 <= param1.vTransform.position.z || param1.vTransform.position.y + param1.DAT_58 <= DAT_DB0)
                    {
                        // Debug.Log("Distancia 1: flags: " + param1.flags + " - DAT_DA0: " + DAT_DA0 + " <= vTransform.position.z: " + param1.vTransform.position.z + " vTransform.position.y: " + param1.vTransform.position.y + " + DAT_58: " + param1.DAT_58 + " <= DAT_DB0: " + DAT_DB0);
                        // Spawn Vehicle?
                        if (param1.vMesh != null)
                        {
                            //Debug.Log("Draw Mesh...:" + param1.vMesh + " - " + param1.child2);
                            if (enabledMesh)
                                //param1.vMesh.en // Carroceria Dakota

                                param1.vMesh.FUN_21F70(vigTransform); // Carroceria Dakota
                        }
                        if (param1.child2 != null)
                        {
                            if (enabledChild2)
                                FUN_2D778(param1.child2, vigTransform); // Llantas Dakota y Carroceria de otros
                        }
                    }
                    else
                    {
                        //Debug.Log("Distancia 2: flags: " + param1.flags + " - DAT_DA0: " + DAT_DA0 + " <= vTransform.position.z: " + param1.vTransform.position.z + " vTransform.position.y: " + param1.vTransform.position.y + " + DAT_58: " + param1.DAT_58 + " <= DAT_DB0: " + DAT_DB0);
                        if (param1.vMesh != null)
                        {
                            param1.vMesh.FUN_2D2A8(vigTransform);
                        }
                        if (param1.child2 != null)
                        {
                            param1.child2.FUN_2D368(vigTransform);
                        }
                    }
                }
                else
                {
                    // Deshabilita Normal LOD??
                    Vector3Int param2 = new Vector3Int(param1.vTransform.position.x, terrain.FUN_1B750((uint)param1.vTransform.position.x, (uint)param1.vTransform.position.z), param1.vTransform.position.z);
                    Vector3Int n = terrain.FUN_1BB50(param1.vTransform.position.x, param1.vTransform.position.z);
                    n = Utilities.VectorNormal(n);
                    if (param1.vMesh != null)
                    {
                        param1.vMesh.FUN_2D4D4(vigTransform, n, param2);
                    }
                    if (param1.child2 != null)
                    {
                        param1.child2.FUN_2D5EC(vigTransform, n, param2);
                    }
                }
            }

            // Render vLOD
            else if (param1.vLOD != null)
            {
                if (enabledvLoD)
                {
                    vigTransform.rotation = param1.FUN_2D884(vigTransform);
                }
            }

            // Draw Shadow GROUND
            if (enabledReflection)
            {
                if ((param1.flags & 8) != 0)
                {
                    if ((param1.flags & 0x200) == 0)
                    {
                        param1.FUN_4C4F4();
                    }
                    param1.vShadow.FUN_4C73C();
                }
            }
            refreshObject++;
        }
        else
        {
            notRefreshObject++;
        }
    }


    private bool ShouldReduceUpdateFrequency()
    {
        // Aquí implementas la lógica para verificar los FPS o consumo de recursos
        // y decides si se debe reducir la frecuencia de actualización.
        // Por ejemplo, puedes usar el tiempo promedio por frame o el uso de CPU/GPU.
        // Si el rendimiento es bajo, devuelve true; de lo contrario, devuelve false.

        // Ejemplo simplificado:
        return Time.deltaTime > checkFPS;// Si el tiempo por frame supera los 0.02 segundos, se considera bajo rendimiento.
    }

    private bool CheckForObjectChanges(VigObject obj)
    {

        if (objectStates.TryGetValue(obj, out ObjectState state))
        {
            //Debug.Log("No ha cambiado...");
            return state.HasChanged(obj);
        }
        //Debug.Log("Ha cambiado...");
        return true; // No previous state found, consider it changed
    }

    private void StoreObjectState(VigObject obj, bool hasChanges)
    {
        if (objectStates.ContainsKey(obj))
        {
            objectStates[obj].UpdateState(obj, hasChanges);
        }
        else
        {
            objectStates.Add(obj, new ObjectState(obj, hasChanges));
        }
    }

    private void UpdateReflections(VigObject obj)
    {
        // Código para actualizar los reflejos aquí
    }

    [Serializable]
    public class ObjectState
    {
        public bool ishasChanges;
        public bool isEnabledMesh;
        public bool isVisibleMesh;
        public int typeid;
        public Type typeObject;
        public Vector3 position;
        public Matrix3x3 rotation;
        public VigMesh vmesh;
        public VigMesh vmeshVertices;
        public VigMesh vLOD;
        public Mesh mesh;
        public Vector3[] vertices;
        public ushort vLODVertices;
        public VigShadow vShadow;
        public VigObject vChild;
        public VigObject vChild2;
        public ushort maxHalfHealth;
        public List<ushort> maxHalfHealthBody = new List<ushort>();
        public short DAT_1A;
        //public bool shouldUpdate; // Indica si el objeto debe actualizarse
        //public bool hasMeshChanged; // Indica si el objeto ha cambiado de malla
        //public bool isInFrontOfCamera; // Indica si el objeto está en frente de la cámara

        [Header("Vehicle")]
        public int weaponSlot;
        public _WHEELS wheelsType;
        public VigObject target;

        public ObjectState(VigObject obj, bool hasChanges)
        {

            UpdateState(obj, hasChanges);
        }

        public bool HasChanged(VigObject obj)
        {
            //Recoger estados
            MeshFilter meshFilter = new MeshFilter();
            bool hasMeshChanged = false;
            bool hasPositionChanged = false;
            bool hasRotationChanged = false;
            bool hasMaxHalfHealth = false;
            List<bool> hasMaxHalfHealthBody = new List<bool>();
            bool hasDAT_1A = false;
            bool hasEnabledMesh = false;
            bool hasVisibleMesh = false;
            if (obj.gameObject.GetComponent<MeshFilter>())
            {
                meshFilter = obj.gameObject.GetComponent<MeshFilter>();
                hasMeshChanged = (!meshFilter.mesh.vertices.Equals(vertices));
            }
            hasPositionChanged = (!obj.vTransform.position.Equals(position));
            hasRotationChanged = (!obj.vTransform.rotation.Equals(rotation));
            hasMaxHalfHealth = (!obj.maxHalfHealth.Equals(maxHalfHealth));
            hasDAT_1A = (!obj.DAT_1A.Equals(DAT_1A));
            if (obj.gameObject.GetComponent<MeshRenderer>())
            {
                hasEnabledMesh = (!obj.GetComponent<MeshRenderer>().enabled.Equals(isEnabledMesh));
                hasVisibleMesh = (!obj.GetComponent<MeshRenderer>().isVisible.Equals(isVisibleMesh));
            }
            switch (obj.type)
            {
                case 0://es un Objeto Child o Variado?
                       //return obj.gameObject.GetComponent<MeshFilter>().mesh.vertices != vertices || obj.vTransform.position != position || !obj.vTransform.rotation.Equals(rotation);
                       //Debug.Log("obj: " + obj.GetType() + " " + hasMeshChanged + " " + hasPositionChanged + " " + hasRotationChanged + " " + hasMaxHalfHealth + " " + hasDAT_1A);
                       //if (obj.gameObject.GetComponent<MeshRenderer>())
                       //{
                       //    return hasEnabledMesh || hasVisibleMesh;
                       //    //Debug.Log("obj: " + obj.GetType() + " - MeshRenderer: enabled:" + hasEnabledMesh + " - isVisible:" + hasVisibleMesh);
                       //}
                       //else
                       //{
                       //    //Debug.Log("obj: " + obj.GetType() + " - Sin Mesh");
                       //}

                    //Objetos de recoleccion
                    if ((obj.GetType()) == typeof(Pickup))
                    {
                        return hasRotationChanged;
                    }
                    //Efectos visuales
                    if ((obj.GetType()) == typeof(Flash))
                    {
                        return true;
                    }
                    //Efectos que acompañan a los daños del escenario
                    if ((obj.GetType()) == typeof(Fire1) || (obj.GetType()) == typeof(Fire2) || (obj.GetType()) == typeof(Fire3))
                    {
                        return true;
                    }
                    //Objetos estaticos en el esceario
                    if ((obj.GetType()) == typeof(Observatory) || (obj.GetType()) == typeof(ServiceStation) || (obj.GetType()) == typeof(DonutShop))
                    {
                        return hasEnabledMesh || hasVisibleMesh || hasMaxHalfHealth || hasPositionChanged || hasRotationChanged;
                    }
                    return hasMeshChanged || hasPositionChanged || hasRotationChanged || hasMaxHalfHealth || hasDAT_1A;
                //return obj.vTransform.position != position || !obj.vTransform.rotation.Equals(rotation);
                //case 1://es un NAN
                case 2://es un Vehiculo
                    Vehicle vehicle = obj.gameObject.GetComponent<Vehicle>();
                    int indexOf = 0;
                    hasMaxHalfHealthBody.Clear();
                    foreach (var item in vehicle.body)
                    {
                        bool hasHealth = false;
                        //Debug.Log("item type:" + item.GetType());
                        if (item)
                        {
                            //Debug.Log("item health:" + item.maxHalfHealth + " index:" + indexOf);
                            //maxHalfHealthBody.Add(item.maxHalfHealth);
                            //maxHalfHealthBody[indexOf] = item.maxHalfHealth;
                            //hasMaxHalfHealthBody.Add(!item.maxHalfHealth.Equals(maxHalfHealthBody[indexOf]));
                            hasHealth = (!item.maxHalfHealth.Equals(maxHalfHealthBody[indexOf]));
                        }
                        hasMaxHalfHealthBody.Add(hasHealth);
                        indexOf++;
                    }

                    //Debug.Log("Type Object: " + obj.type);
                    //return obj.gameObject.GetComponent<MeshFilter>().mesh.vertices == vertices;
                    //hasMaxHalfHealthBody[0] = (!vehicle.body[0].GetComponent<VigObject>().maxHalfHealth.Equals(maxHalfHealthBody[0]));
                    bool hasweaponSlot = (vehicle.weaponSlot != weaponSlot);
                    bool haswheelsType = (vehicle.wheelsType != wheelsType);
                    bool hastarget = (vehicle.target != target);

                    string logText = "obj: " + obj.GetType() + "\n";
                    logText += "Mesh: " + hasMeshChanged + "\n";
                    logText += "Position: " + hasPositionChanged + "\n";
                    logText += "Rotation: " + hasRotationChanged + "\n";
                    logText += "Health: " + hasMaxHalfHealth + "\n";
                    logText += "HealthBody[0]: " + hasMaxHalfHealthBody[0] + "\n";
                    logText += "sDAT_1A: " + hasDAT_1A + "\n";
                    logText += "WeaponSlot: " + hasweaponSlot + "\n";
                    logText += "WheelsType: " + haswheelsType + "\n";
                    logText += "Starget: " + hastarget + "\n";
                    logText += "EnabledMesh: " + hasEnabledMesh + "\n";
                    logText += "VisibleMesh: " + hasVisibleMesh + "\n";
                    //Debug.Log(logText);
                    //Debug.Log("maxHalfHealth:" + vehicle.body[0].gameObject.GetComponent<VigObject>().maxHalfHealth);

                    //Debug.Log("obj: " + obj.GetType() + " hasMeshChanged:" + hasMeshChanged + " hasPositionChanged:" + hasPositionChanged + " hasRotationChanged:" + hasRotationChanged + " hasMaxHalfHealth:" + hasMaxHalfHealth + " hasDAT_1A:" + hasDAT_1A + " hasEnabledMesh:" + hasEnabledMesh + " hasVisibleMesh:" + hasVisibleMesh);

                    //Debug.Log("obj: " + obj.GetType() + " " + hasweaponSlot + " " + haswheelsType + " " + hastarget);
                    bool stateBool = (hasEnabledMesh || hasVisibleMesh || hasweaponSlot || hasMaxHalfHealth || haswheelsType || hastarget || hasDAT_1A);
                    bool stateBool2 = (hasMaxHalfHealthBody[0] || hasMaxHalfHealthBody[1] || hasMaxHalfHealthBody[2] || hasMaxHalfHealthBody[3]);
                    return stateBool || stateBool2;

                case 3://es un Pickup, Oilk
                    return obj.vTransform.position != position || !obj.vTransform.rotation.Equals(rotation);
                //case 4://es un NAN
                case 5://es un PlaceHolder, Meteor small?
                    return true;
                //case 6://es un NAN
                case 7://es un Particle, Shadow Ground?
                    return true;
                case 8://es un Missile, Mine, Smoke?
                    return true;
                //case 9://es un NAN
                case 10://es un Policia o Trailer?
                        //Debug.Log("Type Object: " + obj.type);
                    return hasVisibleMesh;
                default:
                    //Debug.Log("Type Object: " + obj.type);
                    return hasPositionChanged || hasRotationChanged;
            }
        }

        public void UpdateState(VigObject obj, bool hasChanges)
        {
            if (hasChanges)
            {

                typeid = obj.type;
                typeObject = obj.GetType();
                position = obj.vTransform.position;
                rotation = obj.vTransform.rotation;
                vmesh = obj.vMesh;
                vChild = obj.child;
                vChild2 = obj.child2;
                vLOD = obj.vLOD;
                maxHalfHealth = obj.maxHalfHealth;
                DAT_1A = obj.DAT_1A;
                if (obj.gameObject.GetComponent<MeshRenderer>())
                {
                    isEnabledMesh = obj.GetComponent<MeshRenderer>().enabled;
                    isVisibleMesh = obj.GetComponent<MeshRenderer>().isVisible;
                }
                if (obj.gameObject.GetComponent<MeshFilter>())
                {
                    mesh = obj.gameObject.GetComponent<MeshFilter>().mesh;
                    vertices = obj.gameObject.GetComponent<MeshFilter>().mesh.vertices;
                    //obj.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                }
                if (obj.vLOD != null)
                    vLODVertices = obj.vLOD.vertices;
                vShadow = obj.vShadow;
                switch (obj.type)
                {
                    case 2://es un Vehiculo+
                        Vehicle vehicle = obj.gameObject.GetComponent<Vehicle>();
                        //maxHalfHealthBody[0] = vehicle.body[0].gameObject.GetComponent<VigObject>().maxHalfHealth;
                        weaponSlot = vehicle.weaponSlot;
                        wheelsType = vehicle.wheelsType;
                        target = vehicle.target;

                        int indexOf = 0;
                        maxHalfHealthBody.Clear();
                        foreach (var item in vehicle.body)
                        {
                            ushort maxHealth = 0;
                            //Debug.Log("item type:" + item.GetType());
                            if (item)
                            {
                                //Debug.Log("item health:" + item.maxHalfHealth + " index:" + indexOf);
                                //maxHalfHealthBody.Add(item.maxHalfHealth);
                                maxHealth = item.maxHalfHealth;
                                //maxHalfHealthBody[indexOf] = item.maxHalfHealth;
                            }
                            maxHalfHealthBody.Add(maxHealth);
                            indexOf++;
                        }

                        //Debug.Log("Type Object: " + obj.type);

                        string logText = "obj: " + obj.GetType() + "\n";
                        logText += "typeid: " + typeid + "\n";
                        logText += "typeObject: " + typeObject + "\n";
                        logText += "position: " + position + "\n";
                        logText += "rotation: " + rotation + "\n";
                        logText += "vmesh: " + vmesh + "\n";
                        logText += "vChild: " + vChild + "\n";
                        logText += "vChild2: " + vChild2 + "\n";
                        logText += "vLOD: " + vLOD + "\n";
                        logText += "maxHalfHealth: " + maxHalfHealth + "\n";
                        logText += "maxHalfHealthBody[0]: " + maxHalfHealthBody[0] + "\n";
                        logText += "maxHalfHealthBody[0]: " + maxHalfHealthBody[1] + "\n";
                        logText += "DAT_1A: " + DAT_1A + "\n";
                        Debug.Log(logText);

                        break;
                    case 10://Policia
                        Debug.Log("obj: " + obj.GetType() + " | Type Object: " + obj.type);
                        break;
                }

                //Debug.Log("obj: " + obj.GetType() + " | Type Object: " + obj.type + " maxHalfHealth:" + maxHalfHealth);

            }
            else
            {
            }
            ishasChanges = hasChanges;
        }
    }

    public int x;
    public int y;
    private void FUN_2DEE8(int param1, int param2)
    {
        //Utilities.SetScreenOffset(param1, param2);
        Utilities.SetScreenOffset(x, y);
        DAT_FC8 = new Vector2Int(param1, param2);
    }

    private void FUN_2DF30(int param1, int param2, int param3, int param4)
    {
        //DAT_EDC = param1;
        //DAT_F20 = param2;
        FUN_2DEE8(param3, param4);
    }

    public VigTransform FUN_2CDF4(VigObject obj)
    {
        VigTransform vigTransform = obj.vTransform;
        while (true)
        {
            obj = Utilities.FUN_2CD78(obj);
            if (obj == null)
            {
                break;
            }
            DAT_EA8 = Utilities.CompMatrixLV(obj.vTransform, vigTransform);
            vigTransform = DAT_EA8;
        }
        return vigTransform;
    }

    public Vector3Int FUN_2CE50(VigObject obj)
    {
        Vector3Int vector3Int = obj.vTransform.position;
        while (true)
        {
            obj = Utilities.FUN_2CD78(obj);
            if (obj == null)
            {
                break;
            }
            DAT_EC8 = Utilities.FUN_24148(obj.vTransform, vector3Int);
            vector3Int = DAT_EC8;
        }
        return vector3Int;
    }

    [Header("ConfigContainers")]
    [SerializeField]
    public List<ConfigContainer> configContainersObject;
    public ConfigContainer configContainers_FUN_2CEAC;

    public VigTransform FUN_2CEAC(VigObject param1, ConfigContainer param2)
    {
        configContainers_FUN_2CEAC = param2;
        VigTransform m = FUN_2CDF4(param1);
        VigTransform m2 = Utilities.FUN_2C77C(param2);
        return Utilities.CompMatrixLV(m, m2);
    }

    public void FUN_2CF00(out Vector3Int param1, VigObject param2, ConfigContainer param3)
    {
        VigTransform transform = FUN_2CDF4(param2);
        param1 = Utilities.FUN_24148(transform, param3.v3_1);
    }

    public void FUN_2E0E8(VigTransform param1, int param2)
    {
        DAT_F28 = param1;
        DAT_F88 = DAT_F28;
        DAT_F00 = Utilities.FUN_2A3EC(param1);
        //DAT_ED8 = param2;
        Utilities.SetProjectionPlane(param2);
        Utilities.SetProjectionPlane3(param2);
        DAT_F48 = Utilities.FUN_247C4(DAT_F68, param1.rotation);
        FUN_2DFF0(DAT_F00);
        DAT_EE0 = DAT_F00;
        DAT_EE0.rotation = Utilities.FUN_2A4A4(DAT_EE0.rotation);
    }

    public bool FUN_2E22C(Vector3Int param1, int param2)
    {
        Coprocessor.rotationMatrix.rt11 = DAT_FD8.V00;
        Coprocessor.rotationMatrix.rt12 = DAT_FD8.V01;
        Coprocessor.rotationMatrix.rt13 = DAT_FD8.V02;
        Coprocessor.rotationMatrix.rt21 = DAT_FD8.V10;
        Coprocessor.rotationMatrix.rt22 = DAT_FD8.V11;
        Coprocessor.rotationMatrix.rt23 = DAT_FD8.V12;
        Coprocessor.rotationMatrix.rt31 = DAT_FD8.V20;
        Coprocessor.rotationMatrix.rt32 = DAT_FD8.V21;
        Coprocessor.rotationMatrix.rt33 = DAT_FD8.V22;
        Coprocessor.accumulator.ir1 = (short)(param1.x - DAT_F28.position.x >> 8);
        Coprocessor.accumulator.ir2 = (short)(param1.y - DAT_F28.position.y >> 8);
        Coprocessor.accumulator.ir3 = (short)(param1.z - DAT_F28.position.z >> 8);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        param2 >>= 8;
        bool result = false;
        if (Coprocessor.accumulator.ir1 < param2 && Coprocessor.accumulator.ir2 < param2)
        {
            result = (Coprocessor.accumulator.ir3 < param2);
        }
        return result;
    }

    private bool FUN_2E22C_2(Vector3Int param1, int param2)
    {
        Coprocessor2.rotationMatrix.rt11 = DAT_FD8.V00;
        Coprocessor2.rotationMatrix.rt12 = DAT_FD8.V01;
        Coprocessor2.rotationMatrix.rt13 = DAT_FD8.V02;
        Coprocessor2.rotationMatrix.rt21 = DAT_FD8.V10;
        Coprocessor2.rotationMatrix.rt22 = DAT_FD8.V11;
        Coprocessor2.rotationMatrix.rt23 = DAT_FD8.V12;
        Coprocessor2.rotationMatrix.rt31 = DAT_FD8.V20;
        Coprocessor2.rotationMatrix.rt32 = DAT_FD8.V21;
        Coprocessor2.rotationMatrix.rt33 = DAT_FD8.V22;
        Coprocessor2.accumulator.ir1 = (short)(param1.x - DAT_F28.position.x >> 8);
        Coprocessor2.accumulator.ir2 = (short)(param1.y - DAT_F28.position.y >> 8);
        Coprocessor2.accumulator.ir3 = (short)(param1.z - DAT_F28.position.z >> 8);
        Coprocessor2.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        param2 >>= 8;
        bool result = false;
        if (Coprocessor2.accumulator.ir1 < param2 && Coprocessor2.accumulator.ir2 < param2)
        {
            result = (Coprocessor2.accumulator.ir3 < param2);
        }
        return result;
    }

    private HitDetection FUN_2E998(VigObject param1, VigObject param2, VigTransform param3, VigTransform param4)
    {
        if (param1.vCollider != null)
        {
            if (param2.vCollider == null)
            {
                return null;
            }
            BufferedBinaryReader reader = param1.vCollider.reader;
            BufferedBinaryReader reader2 = param2.vCollider.reader;
            short num = reader.ReadInt16(0);
            while (num != 0)
            {
                num = reader.ReadInt16(0);
                reader2.Seek(0L, SeekOrigin.Begin);
                BoundingBox boundingBox;
                Radius radius;
                switch (num)
                {
                    case 1:
                        if ((reader.ReadUInt16(2) & 0x8000) == 0)
                        {
                            num = reader2.ReadInt16(0);
                            while (num != 0)
                            {
                                num = reader2.ReadInt16(0);
                                switch (num)
                                {
                                    case 2:
                                        {
                                            int num2 = 0;
                                            if (reader2.ReadUInt16(2) == 0)
                                            {
                                                hit.collider1.ChangeBuffer(reader);
                                                hit.collider2.ChangeBuffer(reader2);
                                                hit.object1 = param1;
                                                hit.object2 = param2;
                                                return hit;
                                            }
                                            int num3 = 4;
                                            while (true)
                                            {
                                                boundingBox = default(BoundingBox);
                                                boundingBox.min = new Vector3Int(reader.ReadInt32(4), reader.ReadInt32(8), reader.ReadInt32(12));
                                                boundingBox.max = new Vector3Int(reader.ReadInt32(16), reader.ReadInt32(20), reader.ReadInt32(24));
                                                BoundingBox param5 = boundingBox;
                                                radius = new Radius
                                                {
                                                    matrixSV = new Vector3Int(reader2.ReadInt16(num3), reader2.ReadInt16(num3 + 2), reader2.ReadInt16(num3 + 4)),
                                                    contactOffset = reader2.ReadInt32(num3 + 8)
                                                };
                                                Radius param6 = radius;
                                                uint num4 = Utilities.FUN_2E2E8(param5, param3, param6, param4);
                                                num2++;
                                                if (num4 == 0)
                                                {
                                                    break;
                                                }
                                                num3 += 12;
                                                if (reader2.ReadUInt16(2) <= num2)
                                                {
                                                    hit.collider1.ChangeBuffer(reader);
                                                    hit.collider2.ChangeBuffer(reader2);
                                                    hit.object1 = param1;
                                                    hit.object2 = param2;
                                                    return hit;
                                                }
                                            }
                                            reader2.Seek(reader2.ReadUInt16(2) * 12 + 4, SeekOrigin.Current);
                                            num = reader2.ReadInt16(0);
                                            break;
                                        }
                                    case 1:
                                        if ((reader2.ReadUInt16(2) & 0x8000) == 0)
                                        {
                                            boundingBox = default(BoundingBox);
                                            boundingBox.min = new Vector3Int(reader.ReadInt32(4), reader.ReadInt32(8), reader.ReadInt32(12));
                                            boundingBox.max = new Vector3Int(reader.ReadInt32(16), reader.ReadInt32(20), reader.ReadInt32(24));
                                            BoundingBox boundingBox2 = boundingBox;
                                            boundingBox = default(BoundingBox);
                                            boundingBox.min = new Vector3Int(reader2.ReadInt32(4), reader2.ReadInt32(8), reader2.ReadInt32(12));
                                            boundingBox.max = new Vector3Int(reader2.ReadInt32(16), reader2.ReadInt32(20), reader2.ReadInt32(24));
                                            BoundingBox boundingBox3 = boundingBox;
                                            if (Utilities.FUN_281FC(boundingBox2, param3, boundingBox3, param4) && Utilities.FUN_281FC(boundingBox3, param4, boundingBox2, param3))
                                            {
                                                hit.collider1.ChangeBuffer(reader);
                                                hit.collider2.ChangeBuffer(reader2);
                                                hit.object1 = param1;
                                                hit.object2 = param2;
                                                return hit;
                                            }
                                        }
                                        reader2.Seek(28L, SeekOrigin.Current);
                                        num = reader2.ReadInt16(0);
                                        break;
                                }
                            }
                        }
                        reader.Seek(28L, SeekOrigin.Current);
                        num = reader.ReadInt16(0);
                        continue;
                    case 2:
                        break;
                    default:
                        continue;
                }
                while (true)
                {
                    bool flag = false;
                    while (true)
                    {
                        num = reader2.ReadInt16(0);
                        while (true)
                        {
                            if (num == 0)
                            {
                                reader.Seek(reader.ReadUInt16(2) * 12 + 4, SeekOrigin.Current);
                                num = reader.ReadInt16(0);
                                flag = true;
                                break;
                            }
                            num = reader2.ReadInt16(0);
                            if (num == 1)
                            {
                                break;
                            }
                            if (num != 2)
                            {
                                continue;
                            }
                            goto IL_0378;
                        }
                        if (flag)
                        {
                            break;
                        }
                        if ((reader2.ReadUInt16(2) & 0x8000) == 0)
                        {
                            int num2 = 0;
                            if (reader.ReadUInt16(2) == 0)
                            {
                                hit.collider1.ChangeBuffer(reader);
                                hit.collider2.ChangeBuffer(reader2);
                                hit.object1 = param1;
                                hit.object2 = param2;
                                return hit;
                            }
                            int num3 = 4;
                            while (true)
                            {
                                boundingBox = default(BoundingBox);
                                boundingBox.min = new Vector3Int(reader2.ReadInt32(4), reader2.ReadInt32(8), reader2.ReadInt32(12));
                                boundingBox.max = new Vector3Int(reader2.ReadInt32(16), reader2.ReadInt32(20), reader2.ReadInt32(24));
                                BoundingBox param7 = boundingBox;
                                radius = new Radius
                                {
                                    matrixSV = new Vector3Int(reader.ReadInt16(num3), reader.ReadInt16(num3 + 2), reader.ReadInt16(num3 + 4)),
                                    contactOffset = reader.ReadInt32(num3 + 8)
                                };
                                Radius param8 = radius;
                                uint num5 = Utilities.FUN_2E2E8(param7, param4, param8, param3);
                                num2++;
                                if (num5 == 0)
                                {
                                    break;
                                }
                                num3 += 12;
                                if (reader.ReadUInt16(2) <= num2)
                                {
                                    hit.collider1.ChangeBuffer(reader);
                                    hit.collider2.ChangeBuffer(reader2);
                                    hit.object1 = param1;
                                    hit.object2 = param2;
                                    return hit;
                                }
                            }
                        }
                        reader2.Seek(28L, SeekOrigin.Current);
                    }
                    break;
                IL_0378:
                    reader2.Seek(reader2.ReadUInt16(2) * 12 + 4, SeekOrigin.Current);
                }
            }
            reader.Seek(0L, SeekOrigin.Begin);
            reader2.Seek(0L, SeekOrigin.Begin);
        }
        return null;
    }

    private HitDetection FUN_2ECF8(VigObject param1, VigObject param2, VigTransform param3)
    {
        VigObject vigObject = param1.child2;
        HitDetection hitDetection;
        while (true)
        {
            if (vigObject == null)
            {
                return null;
            }
            if (vigObject.vCollider == null || (vigObject.flags & 0x20) != 0)
            {
                if ((vigObject.flags & 0x800) != 0)
                {
                    VigTransform param4 = Utilities.CompMatrixLV(param3, vigObject.vTransform);
                    hitDetection = FUN_2ECF8(vigObject, param2, param4);
                    if (hitDetection != null)
                    {
                        return hitDetection;
                    }
                }
            }
            else
            {
                VigTransform param4 = Utilities.CompMatrixLV(param3, vigObject.vTransform);
                hitDetection = FUN_2E998(vigObject, param2, param4, param2.vTransform);
                if (hitDetection != null)
                {
                    return hitDetection;
                }
                if ((vigObject.flags & 0x800) != 0)
                {
                    hitDetection = FUN_2ECF8(vigObject, param2, param4);
                    if (hitDetection != null)
                    {
                        break;
                    }
                }
            }
            vigObject = vigObject.child;
        }
        return hitDetection;
    }

    private HitDetection FUN_2EDEC(VigObject param1, VigObject param2, VigTransform param3)
    {
        VigObject vigObject = param2.child2;
        HitDetection hitDetection;
        while (true)
        {
            if (vigObject == null)
            {
                return null;
            }
            if (vigObject.vCollider == null || (vigObject.flags & 0x20) != 0)
            {
                if ((vigObject.flags & 0x800) != 0)
                {
                    VigTransform param4 = Utilities.CompMatrixLV(param3, vigObject.vTransform);
                    hitDetection = FUN_2EDEC(param1, vigObject, param4);
                    if (hitDetection != null)
                    {
                        return hitDetection;
                    }
                }
            }
            else
            {
                VigTransform param4 = Utilities.CompMatrixLV(param3, vigObject.vTransform);
                hitDetection = FUN_2E998(param1, vigObject, param1.vTransform, param4);
                if (hitDetection != null)
                {
                    return hitDetection;
                }
                if ((vigObject.flags & 0x800) != 0)
                {
                    hitDetection = FUN_2EDEC(param1, vigObject, param4);
                    if (hitDetection != null)
                    {
                        break;
                    }
                }
            }
            vigObject = vigObject.child;
        }
        return hitDetection;
    }

    private uint FUN_2EEE0(VigObject param1, VigObject param2)
    {
        bool flag = false;
        if (param1.id == param2.id)
        {
            return 0u;
        }
        int num = param1.DAT_58 + param2.DAT_58;
        int num2 = param1.vTransform.position.x - param2.vTransform.position.x;
        if (num2 < 0)
        {
            num2 = -num2;
        }
        if (num2 < num)
        {
            num2 = param1.vTransform.position.y - param2.vTransform.position.y;
            if (num2 < 0)
            {
                num2 = -num2;
            }
            if (num2 < num)
            {
                num2 = param1.vTransform.position.z - param2.vTransform.position.z;
                if (num2 < 0)
                {
                    num2 = -num2;
                }
                flag = (num2 < num);
            }
        }
        if (!flag)
        {
            return 0u;
        }
        if ((param2.flags & 0x40) != 0)
        {
            if (param1.PDAT_74 == null)
            {
                param1.PDAT_74 = param2;
            }
            else
            {
                Vector3Int position = param1.vTransform.position;
                if (!(param1.PDAT_78 != null))
                {
                    goto IL_018f;
                }
                num = Utilities.FUN_29F6C(param1.PDAT_74.vTransform.position, position);
                if (Utilities.FUN_29F6C(param1.PDAT_78.vTransform.position, position) <= num)
                {
                    num = Utilities.FUN_29F6C(param2.vTransform.position, position);
                    num2 = Utilities.FUN_29F6C(param1.PDAT_74.vTransform.position, position);
                    if (num2 > num)
                    {
                        param1.PDAT_74 = param2;
                    }
                }
                else
                {
                    num = Utilities.FUN_29F6C(param2.vTransform.position, position);
                    num2 = Utilities.FUN_29F6C(param1.PDAT_78.vTransform.position, position);
                    if (num2 > num)
                    {
                        goto IL_018f;
                    }
                }
            }
        }
        goto IL_0196;
    IL_018f:
        param1.PDAT_78 = param2;
        goto IL_0196;
    IL_0196:
        HitDetection hitDetection = FUN_2E998(param1, param2, param1.vTransform, param2.vTransform);
        uint num3 = 0u;
        if (hitDetection != null)
        {
            hitDetection.self = param2;
            num3 = param1.OnCollision(hitDetection);
            if (num3 + 1 < 2)
            {
                BufferedBinaryReader collider = hitDetection.collider2;
                VigObject @object = hitDetection.object2;
                num3 >>= 31;
                hitDetection.self = param1;
                hitDetection.collider2 = hitDetection.collider1;
                hitDetection.collider1 = collider;
                hitDetection.object2 = hitDetection.object1;
                hitDetection.object1 = @object;
#if DEBUG
                //Corregir posibles fallos en objetos al detectar sus colisiones
                //Debug.Log("Colision comenzada...: " + num2 + " - Self: " + hitDetection.self + " - Objeto 1: " + hitDetection.object1 + " - Colision 1: " + hitDetection.object1 + " - Objeto 2: " + hitDetection.object2 + " Colision 2: " + hitDetection.collider2);
#endif
                num2 = (int)param2.OnCollision(hitDetection); //Colision? posible error agua : Correjido
                if (num2 < 0)
                {
                    num3 |= 2;
                }
            }
            else
            {
                num3 >>= 31;
            }
        }
        hitDetection = null;
        if (num3 == 0)
        {
            if (((param1.flags & 0x800) == 0 || (hitDetection = FUN_2ECF8(param1, param2, param1.vTransform)) == null) && ((param2.flags & 0x800) == 0 || (hitDetection = FUN_2EDEC(param1, param2, param2.vTransform)) == null) && hitDetection == null)
            {
                return 0u;
            }
            hitDetection.self = param2;
            num3 = param1.OnCollision(hitDetection);
            if (num3 + 1 < 2)
            {
                BufferedBinaryReader collider = hitDetection.collider2;
                VigObject @object = hitDetection.object2;
                num3 >>= 31;
                hitDetection.self = param1;
                hitDetection.collider2 = hitDetection.collider1;
                hitDetection.collider1 = collider;
                hitDetection.object2 = hitDetection.object1;
                hitDetection.object1 = @object;
                num2 = (int)param2.OnCollision(hitDetection);
                if (num2 < 0)
                {
                    num3 |= 2;
                }
            }
            else
            {
                num3 >>= 31;
            }
        }
        return num3;
    }

    private VigTuple FUN_30180(List<VigTuple> param1, int param2, VigObject param3)
    {
        for (int i = 0; i < param1.Count; i++)
        {
            if (param1[i].vObject != param3 && param1[i].vObject.id == param2)
            {
                return param1[i];
            }
        }
        return null;
    }

    public VigObject FUN_30250(List<VigTuple> param1, int param2)
    {
        VigTuple vigTuple = FUN_30180(param1, param2, null);
        VigObject result = null;
        if (vigTuple != null)
        {
            result = vigTuple.vObject;
        }
        return result;
    }

    private bool FUN_30F20(BSP param1, VigObject param2)
    {
        BSP[] array = new BSP[32];
        int x = param2.vTransform.position.x;
        int dAT_ = param2.DAT_58;
        int z = param2.vTransform.position.z;
        array[0] = param1;
        int num = 0;
        int num2 = 1;
        int num3;
        do
        {
            if (num >= array.Length || num < 0)
            {
                return false;
            }
            BSP bSP = array[num];
            int dAT_2 = bSP.DAT_00;
            num3 = num2 - 1;
            switch (dAT_2)
            {
                case 1:
                    if (x - dAT_ < bSP.DAT_04)
                    {
                        array[num] = bSP.DAT_08;
                        num++;
                        num3 = num2;
                    }
                    if (bSP.DAT_04 < x + dAT_)
                    {
                        bSP = bSP.DAT_0C;
                        num3++;
                        array[num] = bSP;
                        num++;
                    }
                    break;
                case 0:
                    for (int i = 0; i < bSP.LDAT_04.Count; i++)
                    {
                        VigTuple vigTuple = bSP.LDAT_04[i];
                        if ((vigTuple.vObject.flags & 0x20) == 0 && FUN_2EEE0(param2, vigTuple.vObject) != 0)
                        {
                            return false;
                        }
                    }
                    break;
                case 2:
                    if (z - dAT_ < bSP.DAT_04)
                    {
                        array[num] = bSP.DAT_08;
                        num++;
                        num3 = num2;
                    }
                    if (bSP.DAT_04 < z + dAT_)
                    {
                        bSP = bSP.DAT_0C;
                        num3++;
                        array[num] = bSP;
                        num++;
                    }
                    break;
                case 3:
                    num3 = num2 + 1;
                    array[num] = bSP.DAT_08;
                    bSP = bSP.DAT_0C;
                    num++;
                    array[num] = bSP;
                    num++;
                    break;
            }
            num--;
            num2 = num3;
        }
        while (num3 != 0);
        return true;
    }

    private void FUN_3174C()
    {
        int count = worldObjs.Count;
        for (int i = 0; i < worldObjs.Count && i < count; i++)
        {
            VigObject vObject = worldObjs[i].vObject;
            if (!(vObject != null) || (vObject.flags & 0x20) != 0)
            {
                continue;
            }
            vObject.PDAT_78 = null;
            vObject.PDAT_74 = null;
            for (int j = i + 1; j < worldObjs.Count && j < count; j++)
            {
                VigObject vObject2 = worldObjs[j].vObject;
                if (vObject2 != null)
                {
                    uint flags = vObject2.flags;
                    if ((flags & 0x20) == 0 && (flags & vObject.flags & 0x200) == 0)
                    {
                        FUN_2EEE0(vObject, vObject2);
                    }
                }
            }
            if (bspTree != null && (vObject.flags & 0x100) == 0)
            {
                FUN_30F20(bspTree, vObject);
            }
        }
    }

    private void FUN_34840()
    {
        uint num;
        uint num2;
        if (gameMode != _GAME_MODE.Versus2)
        {
            num = (uint)((short)levelManager.DAT_C18[2] * 2);
            num2 = (uint)((short)levelManager.DAT_C18[3] * 2);
        }
        else
        {
            num = (uint)(short)levelManager.DAT_C18[2] / 2u;
            num2 = (uint)(short)levelManager.DAT_C18[3] / 2u;
        }
        if ((uint)DAT_10F0 >= num)
        {
            return;
        }
        VigObject x;
        do
        {
            uint num3 = 3670016u;
            if (gameMode != _GAME_MODE.Versus || (uint)DAT_101C < num2)
            {
                uint num4 = FUN_2AC5C();
                num3 = 7864320u;
                if ((num4 & 3) == 0)
                {
                    num3 = 3670016u;
                }
            }
            int num5 = (int)FUN_2AC5C();
            int num6 = FUN_30428(DAT_1078, num3);
            VigObject param = FUN_30498(DAT_1078, num3, num5 * num6 >> 15);
            x = FUN_4AC6C(num3, param);
        }
        while (x != null && (uint)(++DAT_10F0) < num);
    }

    private void FUN_34914()
    {
        uint num = (uint)((gameMode == _GAME_MODE.Versus2) ? ((int)((uint)(short)levelManager.DAT_C18[4] / 2u)) : ((int)(short)levelManager.DAT_C18[4]));
        if ((uint)DAT_1028 >= num)
        {
            return;
        }
        do
        {
            int num2 = (int)FUN_2AC5C();
            int num3 = FUN_30428(DAT_1078, 25427968u);
            VigObject param = FUN_30498(DAT_1078, 25427968u, num2 * num3 >> 15);
            if (FUN_4AC6C(25427968u, param) == null)
            {
                break;
            }
            DAT_1028++;
        }
        while ((uint)DAT_1028 < num);
    }

    private _PLACEHOLDER_TYPE FUN_36B64(ushort param1)
    {
        if (param1 > 17)
        {
            param1 = (ushort)(param1 - 21);
        }
        return (_PLACEHOLDER_TYPE)param1;
    }

    //Asigna accesorios Salvaje Point?
    private Vehicle FUN_36C2C(Placeholder param1, int param2, int param3)
    {
        if (param2 < 0 || param1 == null)
        {
            return null;
        }
        _PLACEHOLDER_TYPE pLACEHOLDER_TYPE = param1.state = FUN_36B64((ushort)param2);
        int index;
        if (param3 < 0)
        {
            index = (39 - param3) * 4;
            if (!(levelManager.xobfList[39 - param3] != null) || !(levelManager.xobfList[39 - param3].ini != null))
            {
                goto IL_007a;
            }
        }
        else
        {
            if (this.EnemyKill < 70)
            {
                goto IL_007a;
            }
            index = param2 + 21;
        }
        goto IL_007c;
    IL_007c:
        XOBF_DB vData = levelManager.xobfList[index];
        param1.DAT_1A = 0;
        param1.vData = vData;
        Vehicle vehicle = (Vehicle)param1.FUN_31DDC();
        if (gameMode >= _GAME_MODE.Versus2)
        {
            vehicle.id = (short)param3;
        }
        int i = 0;
        if (param3 >= 0)
        {
            //Assigna Accesorios y mejoras
            if (EnemySpawn)
                vehicle.InitializeEnemySpawn();
            else
                vehicle.InitializeEnemyStats();
        }
        for (; i < 2; i++)
        {
            if (vehicle.body[i] != null)
            {
                vehicle.body[i].id = vehicle.id;
            }
        }
        if (0 < param3)
        {
            index = vehicle.vTransform.rotation.V02 * 4577;
            if (index < 0)
            {
                index += 31;
            }
            vehicle.physics1.X = index >> 5;
            vehicle.physics1.Y = 0;
            index = vehicle.vTransform.rotation.V22 * 4577;
            if (index < 0)
            {
                index += 31;
            }
            vehicle.physics1.Z = index >> 5;
        }
        return vehicle;
    IL_007a:
        index = param2;
        goto IL_007c;
    }

    private void FUN_507DC(JUNC_DB param1)
    {
        bool num = FUN_2E22C(param1.DAT_00, (int)param1.DAT_18.DAT_18);
        Vector3Int position = Utilities.FUN_24148(DAT_F00, param1.DAT_00);
        if (num && position.z < 2097152)
        {
            VigTransform param2 = default(VigTransform);
            param2.rotation = default(Matrix3x3);
            param2.rotation.SetValue32(0, 0);
            param2.rotation.SetValue32(1, 0);
            param2.rotation.SetValue32(2, 0);
            param2.rotation.SetValue32(3, 0);
            param2.rotation.SetValue32(4, 0);
            param2.padding = 0;
            param2.position = position;
            param1.DAT_18.FUN_21F70(param2);
        }
    }

    public static VigTransform FUN_2A39C()
    {
        return defaultTransform;
    }

    public static uint FUN_2AC5C()
    {
        uint dAT_63A = DAT_63A64;
        uint num = (uint)((byte)DAT_63A68 << 31);
        DAT_63A68 = (byte)dAT_63A;
        uint num2 = (dAT_63A >> 1) + num;
        dAT_63A <<= 12;
        uint num3 = num2 ^ dAT_63A;
        dAT_63A = num3 >> 20;
        return (DAT_63A64 = (num3 ^ dAT_63A)) & 0x7FFF;
    }

    static GameManager()
    {
        Matrix3x3 matrix3x = new Matrix3x3
        {
            V00 = 4096,
            V01 = 0,
            V02 = 0,
            V10 = 0,
            V11 = 0,
            V12 = 0,
            V20 = 0,
            V21 = 0,
            V22 = 0
        };
        DAT_718 = matrix3x;
        DAT_854 = new byte[16]
        {
            12,
            32,
            20,
            32,
            12,
            24,
            12,
            24,
            16,
            28,
            12,
            28,
            24,
            24,
            0,
            24
        };
        DAT_854_2 = new ushort[32]
        {
            12,
            20,
            28,
            40,
            20,
            28,
            28,
            40,
            12,
            20,
            20,
            32,
            12,
            16,
            20,
            32,
            16,
            28,
            24,
            40,
            12,
            0,
            24,
            40,
            20,
            32,
            20,
            32,
            0,
            0,
            20,
            32
        };
        VigTransform vigTransform = default(VigTransform);
        matrix3x = new Matrix3x3
        {
            V00 = 4096,
            V01 = 0,
            V02 = 0,
            V10 = 0,
            V11 = 4096,
            V12 = 0,
            V20 = 0,
            V21 = 0,
            V22 = 4096
        };
        vigTransform.rotation = matrix3x;
        vigTransform.position = new Vector3Int(0, 0, 0);
        defaultTransform = vigTransform;
        DAT_9C4 = new Vector3Int(0, 0, 0);
        DAT_A14 = new byte[4]
        {
            0,
            1,
            2,
            3
        };
        DAT_A18 = new Vector3Int(0, 0, 196608);
        DAT_A24 = new Vector3Int(0, 26624, 0);
        DAT_A30 = new Vector3Int(0, 0, -32768);
        DAT_A3C = new Vector3Int(0, 0, -131072);
        DAT_A4C = new Vector3Int(0, 131072, 0);
        DAT_A5C = new Vector3Int(0, -131072, 0);
        DAT_A68 = new Vector3Int(0, 32768, 0);
        DAT_BC0 = new short[37]
        {
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            24,
            25,
            31,
            0,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            58,
            63,
            64,
            65,
            66,
            75,
            0,
            75,
            67,
            68,
            71,
            72,
            73,
            74
        };
        updateJunc = new List<Junction>();
    }
}
