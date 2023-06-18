using System;
using Types;
using Unity.Burst;

[BurstCompile]
public class Coprocessor2
{
    public static Cop2Vector0 vector0;

    public static Cop2Vector1 vector1;

    public static Cop2Vector2 vector2;

    public static ushort averageZ;

    public static Cop2Accumulator accumulator;

    public static Cop2Maths mathsAccumulator;

    public static Cop2RT rotationMatrix;

    public static Cop2LLM lightMatrix;

    public static Cop2LCM lightColorMatrix;

    public static Cop2ClrCode colorCode;

    public static Cop2TV translationVector;

    public static Cop2BC backgroundColor;

    public static Cop2FC farColor;

    public static Cop2ClrFIFO colorFIFO;

    public static Cop2SxyFIFO screenXYFIFO;

    public static Cop2SxyzFIFO screenXYZFIFO;

    public static Cop2SzFIFO screenZFIFO;

    public static Cop2OF screenOffset;

    public static short depthQueingA;

    public static uint depthQueingB;

    public static ushort projectionPlaneDistance;

    public static int zScaleFactor3;

    public static int zScaleFactor4;

    private static readonly long MAC0_MIN_VALUE = -(TypesClass.INT64_C(1) << 31);

    private static readonly long MAC0_MAX_VALUE = (TypesClass.INT64_C(1) << 31) - 1;

    private static readonly long MAC123_MIN_VALUE = -(TypesClass.INT64_C(1) << 11);

    private static readonly long MAC123_MAX_VALUE = (TypesClass.INT64_C(1) << 11) - 1;

    private static readonly int IR0_MIN_VALUE = 0;

    private static readonly int IR0_MAX_VALUE = 4096;

    private static readonly int IR123_MIN_VALUE = -(TypesClass.INT64_C(1) << 15);

    private static readonly int IR123_MAX_VALUE = (TypesClass.INT64_C(1) << 15) - 1;

    private static DisplayAspectRatio s_aspect_ratio = DisplayAspectRatio.R4_3;

    private static uint s_custom_aspect_ratio_numerator;

    private static uint s_custom_aspect_ratio_denominator;

    private static float s_custom_aspect_ratio_f;

    private static short[] V0 = new short[3];

    private static short[] V1 = new short[3];

    private static short[] V2 = new short[3];

    private static short[,] LLM = new short[3, 3];

    private static short[,] LCM = new short[3, 3];

    private static int[,] RT = new int[3, 3];

    private static int[] TR = new int[3];

    private static int[] BK = new int[3];

    private static long[] xyz = new long[3];

    private static byte[] RGBC = new byte[3];

    private static short[,] M = new short[3, 3];

    private static int[] T = new int[3];

    private static byte[] unr_table = new byte[257]
    {
        255,
        253,
        251,
        249,
        247,
        245,
        243,
        241,
        239,
        238,
        236,
        234,
        232,
        230,
        228,
        227,
        225,
        223,
        221,
        220,
        218,
        216,
        214,
        213,
        211,
        209,
        208,
        206,
        205,
        203,
        201,
        200,
        198,
        197,
        195,
        193,
        192,
        190,
        189,
        187,
        186,
        184,
        183,
        181,
        180,
        178,
        177,
        176,
        174,
        173,
        171,
        170,
        169,
        167,
        166,
        164,
        163,
        162,
        160,
        159,
        158,
        156,
        155,
        154,
        153,
        151,
        150,
        149,
        148,
        146,
        145,
        144,
        143,
        141,
        140,
        139,
        138,
        137,
        135,
        134,
        133,
        132,
        131,
        130,
        129,
        127,
        126,
        125,
        124,
        123,
        122,
        121,
        120,
        119,
        117,
        116,
        115,
        114,
        113,
        112,
        111,
        110,
        109,
        108,
        107,
        106,
        105,
        104,
        103,
        102,
        101,
        100,
        99,
        98,
        97,
        96,
        95,
        94,
        93,
        93,
        92,
        91,
        90,
        89,
        88,
        87,
        86,
        85,
        84,
        83,
        83,
        82,
        81,
        80,
        79,
        78,
        77,
        77,
        76,
        75,
        74,
        73,
        72,
        72,
        71,
        70,
        69,
        68,
        67,
        67,
        66,
        65,
        64,
        63,
        63,
        62,
        61,
        60,
        60,
        59,
        58,
        57,
        57,
        56,
        55,
        54,
        54,
        53,
        52,
        51,
        51,
        50,
        49,
        49,
        48,
        47,
        46,
        46,
        45,
        44,
        44,
        43,
        42,
        42,
        41,
        40,
        40,
        39,
        38,
        38,
        37,
        36,
        36,
        35,
        34,
        34,
        33,
        32,
        32,
        31,
        30,
        30,
        29,
        29,
        28,
        27,
        27,
        26,
        25,
        25,
        24,
        24,
        23,
        22,
        22,
        21,
        21,
        20,
        20,
        19,
        18,
        18,
        17,
        17,
        16,
        15,
        15,
        14,
        14,
        13,
        13,
        12,
        12,
        11,
        10,
        10,
        9,
        9,
        8,
        8,
        7,
        7,
        6,
        6,
        5,
        5,
        4,
        4,
        3,
        3,
        2,
        2,
        1,
        1,
        0,
        0,
        0
    };

    public static void ExecuteRTPS(byte shift, bool lm)
    {
        V0[0] = vector0.vx0;
        V0[1] = vector0.vy0;
        V0[2] = vector0.vz0;
        RTPS(V0, shift, lm, last: true);
    }

    public static void ExecuteNCLIP()
    {
        TruncateAndSetMAC((long)screenXYFIFO.sx0 * (long)screenXYFIFO.sy1 + (long)screenXYFIFO.sx1 * (long)screenXYFIFO.sy2 + (long)screenXYFIFO.sx2 * (long)screenXYFIFO.sy0 - (long)screenXYFIFO.sx0 * (long)screenXYFIFO.sy2 - (long)screenXYFIFO.sx1 * (long)screenXYFIFO.sy0 - (long)screenXYFIFO.sx2 * (long)screenXYFIFO.sy1, 0, 0);
    }

    public static void ExecuteDPCS(byte shift, bool lm)
    {
        RGBC[0] = colorCode.r;
        RGBC[1] = colorCode.g;
        RGBC[2] = colorCode.b;
        DPCS(RGBC, shift, lm);
    }

    public static void ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX matrix, _MVMVA_MULTIPLY_VECTOR multiply, _MVMVA_TRANSLATION_VECTOR translation, byte shift, bool lm)
    {
        short num = 0;
        short num2 = 0;
        short num3 = 0;
        switch (matrix)
        {
            case _MVMVA_MULTIPLY_MATRIX.Color:
                M[0, 0] = lightColorMatrix.lb1;
                M[0, 1] = lightColorMatrix.lb2;
                M[0, 2] = lightColorMatrix.lb3;
                M[1, 0] = lightColorMatrix.lg1;
                M[1, 1] = lightColorMatrix.lg2;
                M[1, 2] = lightColorMatrix.lg3;
                M[2, 0] = lightColorMatrix.lr1;
                M[2, 1] = lightColorMatrix.lr2;
                M[2, 2] = lightColorMatrix.lr3;
                break;
            case _MVMVA_MULTIPLY_MATRIX.Light:
                M[0, 0] = lightMatrix.l11;
                M[0, 1] = lightMatrix.l12;
                M[0, 2] = lightMatrix.l13;
                M[1, 0] = lightMatrix.l21;
                M[1, 1] = lightMatrix.l22;
                M[1, 2] = lightMatrix.l23;
                M[2, 0] = lightMatrix.l31;
                M[2, 1] = lightMatrix.l32;
                M[2, 2] = lightMatrix.l33;
                break;
            case _MVMVA_MULTIPLY_MATRIX.Rotation:
                M[0, 0] = rotationMatrix.rt11;
                M[0, 1] = rotationMatrix.rt12;
                M[0, 2] = rotationMatrix.rt13;
                M[1, 0] = rotationMatrix.rt21;
                M[1, 1] = rotationMatrix.rt22;
                M[1, 2] = rotationMatrix.rt23;
                M[2, 0] = rotationMatrix.rt31;
                M[2, 1] = rotationMatrix.rt32;
                M[2, 2] = rotationMatrix.rt33;
                break;
            default:
                M[0, 0] = (short)(-(colorCode.r << 4));
                M[0, 1] = (short)(colorCode.r << 4);
                M[0, 2] = accumulator.ir0;
                M[1, 0] = rotationMatrix.rt13;
                M[1, 1] = rotationMatrix.rt13;
                M[1, 2] = rotationMatrix.rt13;
                M[2, 0] = rotationMatrix.rt22;
                M[2, 1] = rotationMatrix.rt22;
                M[2, 2] = rotationMatrix.rt22;
                break;
        }
        switch (multiply)
        {
            case _MVMVA_MULTIPLY_VECTOR.V0:
                num = vector0.vx0;
                num2 = vector0.vy0;
                num3 = vector0.vz0;
                break;
            case _MVMVA_MULTIPLY_VECTOR.V1:
                num = vector1.vx1;
                num2 = vector1.vy1;
                num3 = vector1.vz1;
                break;
            case _MVMVA_MULTIPLY_VECTOR.V2:
                num = vector2.vx2;
                num2 = vector2.vy2;
                num3 = vector2.vz2;
                break;
            default:
                num = accumulator.ir1;
                num2 = accumulator.ir2;
                num3 = accumulator.ir3;
                break;
        }
        switch (translation)
        {
            case _MVMVA_TRANSLATION_VECTOR.TR:
                T[0] = translationVector._trx;
                T[1] = translationVector._try;
                T[2] = translationVector._trz;
                break;
            case _MVMVA_TRANSLATION_VECTOR.BK:
                T[0] = backgroundColor._rbk;
                T[1] = backgroundColor._gbk;
                T[2] = backgroundColor._bbk;
                break;
            case _MVMVA_TRANSLATION_VECTOR.FC:
                T[0] = farColor._rfc;
                T[1] = farColor._gfc;
                T[3] = farColor._bfc;
                break;
            default:
                T[0] = 0;
                T[1] = 0;
                T[2] = 0;
                break;
        }
        MultMatVec(M, T, num, num2, num3, shift, lm);
    }

    public static void ExecuteCDP(byte shift, bool lm)
    {
        LCM[0, 0] = lightColorMatrix.lr1;
        LCM[0, 1] = lightColorMatrix.lr2;
        LCM[0, 2] = lightColorMatrix.lr3;
        LCM[1, 0] = lightColorMatrix.lg1;
        LCM[1, 1] = lightColorMatrix.lg2;
        LCM[1, 2] = lightColorMatrix.lg3;
        LCM[2, 0] = lightColorMatrix.lb1;
        LCM[2, 1] = lightColorMatrix.lb2;
        LCM[2, 2] = lightColorMatrix.lb3;
        BK[0] = backgroundColor._rbk;
        BK[1] = backgroundColor._gbk;
        BK[2] = backgroundColor._bbk;
        MultMatVec(LCM, BK, accumulator.ir1, accumulator.ir2, accumulator.ir3, shift, lm);
        int num = colorCode.r * accumulator.ir1 << 4;
        int num2 = colorCode.g * accumulator.ir2 << 4;
        int num3 = colorCode.b * accumulator.ir3 << 4;
        InterpolateColor(num, num2, num3, shift, lm);
        PushRGBFromMAC();
    }

    public static void ExecuteSQR(byte shift, bool lm)
    {
        mathsAccumulator.mac1 = accumulator.ir1 * accumulator.ir1 >> (int)shift;
        mathsAccumulator.mac2 = accumulator.ir2 * accumulator.ir2 >> (int)shift;
        mathsAccumulator.mac3 = accumulator.ir3 * accumulator.ir3 >> (int)shift;
        TruncateAndSetIR(mathsAccumulator.mac1, 1, lm);
        TruncateAndSetIR(mathsAccumulator.mac2, 2, lm);
        TruncateAndSetIR(mathsAccumulator.mac3, 3, lm);
    }

    public static void ExecuteGPF(byte shift, bool lm)
    {
        TruncateAndSetMACAndIR(accumulator.ir1 * accumulator.ir0, 1, shift, lm);
        TruncateAndSetMACAndIR(accumulator.ir2 * accumulator.ir0, 2, shift, lm);
        TruncateAndSetMACAndIR(accumulator.ir3 * accumulator.ir0, 3, shift, lm);
        PushRGBFromMAC();
    }

    public static void ExecuteOP(byte shift, bool lm)
    {
        int rt = rotationMatrix.rt11;
        int rt2 = rotationMatrix.rt22;
        int rt3 = rotationMatrix.rt33;
        int ir = accumulator.ir1;
        int ir2 = accumulator.ir2;
        int ir3 = accumulator.ir3;
        TruncateAndSetMACAndIR(ir3 * rt2 - ir2 * rt3, 1, shift, lm);
        TruncateAndSetMACAndIR(ir * rt3 - ir3 * rt, 2, shift, lm);
        TruncateAndSetMACAndIR(ir2 * rt - ir * rt2, 3, shift, lm);
    }

    public static void ExecuteCC(byte shift, bool lm)
    {
        LCM[0, 0] = lightColorMatrix.lr1;
        LCM[0, 1] = lightColorMatrix.lr2;
        LCM[0, 2] = lightColorMatrix.lr3;
        LCM[1, 0] = lightColorMatrix.lg1;
        LCM[1, 1] = lightColorMatrix.lg2;
        LCM[1, 2] = lightColorMatrix.lg3;
        LCM[2, 0] = lightColorMatrix.lb1;
        LCM[2, 1] = lightColorMatrix.lb2;
        LCM[2, 2] = lightColorMatrix.lb3;
        BK[0] = backgroundColor._rbk;
        BK[1] = backgroundColor._gbk;
        BK[2] = backgroundColor._bbk;
        MultMatVec(LCM, BK, accumulator.ir1, accumulator.ir2, accumulator.ir3, shift, lm);
        TruncateAndSetMACAndIR((long)(colorCode.r * accumulator.ir1) << 4, 1, shift, lm);
        TruncateAndSetMACAndIR((long)(colorCode.g * accumulator.ir2) << 4, 2, shift, lm);
        TruncateAndSetMACAndIR((long)(colorCode.b * accumulator.ir3) << 4, 3, shift, lm);
        PushRGBFromMAC();
    }

    public static void ExecuteRTPT(byte shift, bool lm)
    {
        V0[0] = vector0.vx0;
        V0[1] = vector0.vy0;
        V0[2] = vector0.vz0;
        V1[0] = vector1.vx1;
        V1[1] = vector1.vy1;
        V1[2] = vector1.vz1;
        V2[0] = vector2.vx2;
        V2[1] = vector2.vy2;
        V2[2] = vector2.vz2;
        RTPS(V0, shift, lm, last: false);
        RTPS(V1, shift, lm, last: false);
        RTPS(V2, shift, lm, last: true);
    }

    public static void ExecuteAVSZ3()
    {
        long num = (long)zScaleFactor3 * (long)(screenZFIFO.sz1 + screenZFIFO.sz2 + screenZFIFO.sz3);
        TruncateAndSetMAC(num, 0, 0);
        SetOTZ((int)(num >> 12));
    }

    public static void ExecuteAVSZ4()
    {
        long num = (long)zScaleFactor4 * (long)(screenZFIFO.sz0 + screenZFIFO.sz1 + screenZFIFO.sz2 + screenZFIFO.sz3);
        TruncateAndSetMAC(num, 0, 0);
        SetOTZ((int)(num >> 12));
    }

    public static void ExecuteNCCT(byte shift, bool lm)
    {
        V0[0] = vector0.vx0;
        V0[1] = vector0.vy0;
        V0[2] = vector0.vz0;
        V1[0] = vector1.vx1;
        V1[1] = vector1.vy1;
        V1[2] = vector1.vz1;
        V2[0] = vector2.vx2;
        V2[1] = vector2.vy2;
        V2[2] = vector2.vz2;
        NCCS(V0, shift, lm);
        NCCS(V1, shift, lm);
        NCCS(V2, shift, lm);
    }

    public static void ExecuteNCCS(byte shift, bool lm)
    {
        V0[0] = vector0.vx0;
        V0[1] = vector0.vy0;
        V0[2] = vector0.vz0;
        NCCS(V0, shift, lm);
    }

    private static void DPCS(byte[] color, byte shift, bool lm)
    {
        TruncateAndSetMAC((long)((ulong)color[0] << 16), 1, 0);
        TruncateAndSetMAC((long)((ulong)color[1] << 16), 2, 0);
        TruncateAndSetMAC((long)((ulong)color[2] << 16), 3, 0);
        InterpolateColor(mathsAccumulator.mac1, mathsAccumulator.mac2, mathsAccumulator.mac3, shift, lm);
        PushRGBFromMAC();
    }

    private static void RTPS(short[] V, byte shift, bool lm, bool last)
    {
        TR[0] = translationVector._trx;
        TR[1] = translationVector._try;
        TR[2] = translationVector._trz;
        RT[0, 0] = rotationMatrix.rt11;
        RT[0, 1] = rotationMatrix.rt12;
        RT[0, 2] = rotationMatrix.rt13;
        RT[1, 0] = rotationMatrix.rt21;
        RT[1, 1] = rotationMatrix.rt22;
        RT[1, 2] = rotationMatrix.rt23;
        RT[2, 0] = rotationMatrix.rt31;
        RT[2, 1] = rotationMatrix.rt32;
        RT[2, 2] = rotationMatrix.rt33;
        for (int i = 0; i < 3; i++)
        {
            xyz[i] = SignExtendMACResult(SignExtendMACResult(((long)TR[i] << 12) + (long)RT[i, 0] * (long)V[0], i + 1) + (long)RT[i, 1] * (long)V[1], i + 1) + (long)RT[i, 2] * (long)V[2];
        }
        long value = xyz[0];
        long value2 = xyz[1];
        long num = xyz[2];
        TruncateAndSetMAC(value, 1, shift);
        TruncateAndSetMAC(value2, 2, shift);
        TruncateAndSetMAC(num, 3, shift);
        TruncateAndSetIR(mathsAccumulator.mac1, 1, lm);
        TruncateAndSetIR(mathsAccumulator.mac2, 2, lm);
        TruncateAndSetIR((int)(num >> 12), 3, lm: false);
        accumulator.ir3 = (short)mathsAccumulator.mac3.Clamp((!lm) ? IR123_MIN_VALUE : 0, IR123_MAX_VALUE);
        PushSZ((int)(num >> 12));
        long num2 = UNRDivide(projectionPlaneDistance, (ushort)screenZFIFO.sz3);
        long num3;
        switch (s_aspect_ratio)
        {
            case DisplayAspectRatio.R16_9:
                num3 = num2 * accumulator.ir1 * 3 / 4 + screenOffset.ofx;
                break;
            case DisplayAspectRatio.R19_9:
                num3 = num2 * accumulator.ir1 * 12 / 19 + screenOffset.ofx;
                break;
            case DisplayAspectRatio.R20_9:
                num3 = num2 * accumulator.ir1 * 3 / 5 + screenOffset.ofx;
                break;
            case DisplayAspectRatio.MatchWindow:
            case DisplayAspectRatio.Custom:
                num3 = num2 * accumulator.ir1 * s_custom_aspect_ratio_numerator / (long)s_custom_aspect_ratio_denominator + screenOffset.ofx;
                break;
            default:
                num3 = num2 * accumulator.ir1 + screenOffset.ofx;
                break;
        }
        long num4 = num2 * accumulator.ir2 + screenOffset.ofy;
        PushSXY((int)(num3 >> 16), (int)(num4 >> 16));
        PushSXYZ(V[0], V[1], V[2]);
        if (last)
        {
            long num5 = num2 * depthQueingA + depthQueingB;
            TruncateAndSetMAC(num5, 0, 0);
            TruncateAndSetIR((int)(num5 >> 12), 0, lm: true);
        }
    }

    private static void NCCS(short[] V, byte shift, bool lm)
    {
        LLM[0, 0] = lightMatrix.l11;
        LLM[0, 1] = lightMatrix.l12;
        LLM[0, 2] = lightMatrix.l13;
        LLM[1, 0] = lightMatrix.l21;
        LLM[1, 1] = lightMatrix.l22;
        LLM[1, 2] = lightMatrix.l23;
        LLM[2, 0] = lightMatrix.l31;
        LLM[2, 1] = lightMatrix.l32;
        LLM[2, 2] = lightMatrix.l33;
        LCM[0, 0] = lightColorMatrix.lr1;
        LCM[0, 1] = lightColorMatrix.lr2;
        LCM[0, 2] = lightColorMatrix.lr3;
        LCM[1, 0] = lightColorMatrix.lg1;
        LCM[1, 1] = lightColorMatrix.lg2;
        LCM[1, 2] = lightColorMatrix.lg3;
        LCM[2, 0] = lightColorMatrix.lb1;
        LCM[2, 1] = lightColorMatrix.lb2;
        LCM[2, 2] = lightColorMatrix.lb3;
        BK[0] = backgroundColor._rbk;
        BK[1] = backgroundColor._gbk;
        BK[2] = backgroundColor._bbk;
        MultMatVec(LLM, V[0], V[1], V[2], shift, lm);
        MultMatVec(LCM, BK, accumulator.ir1, accumulator.ir2, accumulator.ir3, shift, lm);
        TruncateAndSetMACAndIR((long)(colorCode.r * accumulator.ir1) << 4, 1, shift, lm);
        TruncateAndSetMACAndIR((long)(colorCode.g * accumulator.ir2) << 4, 2, shift, lm);
        TruncateAndSetMACAndIR((long)(colorCode.b * accumulator.ir3) << 4, 3, shift, lm);
        PushRGBFromMAC();
    }

    private static void MultMatVec(short[,] M, short Vx, short Vy, short Vz, byte shift, bool lm)
    {
        for (int i = 0; i < 3; i++)
        {
            TruncateAndSetMACAndIR(SignExtendMACResult((long)M[i, 0] * (long)Vx + (long)M[i, 1] * (long)Vy, i + 1) + (long)M[i, 2] * (long)Vz, i + 1, shift, lm);
        }
    }

    private static void MultMatVec(short[,] M, int[] T, short Vx, short Vy, short Vz, byte shift, bool lm)
    {
        for (int i = 0; i < 3; i++)
        {
            TruncateAndSetMACAndIR(SignExtendMACResult(SignExtendMACResult(((long)T[i] << 12) + M[i, 0] * Vx, i + 1) + M[i, 1] * Vy, i + 1) + M[i, 2] * Vz, i + 1, shift, lm);
        }
    }

    private static uint UNRDivide(uint lhs, uint rhs)
    {
        if (rhs * 2 <= lhs)
        {
            return 131071u;
        }
        int num = (rhs == 0) ? 16 : Utilities.LeadingZeros((ushort)rhs);
        lhs <<= num;
        rhs <<= num;
        uint num2 = rhs | 0x8000;
        int num3 = 257 + unr_table[(num2 & 0x7FFF) + 64 >> 7];
        int num4 = (int)num2 * -num3 + 128 >> 8;
        uint num5 = (uint)(num3 * (131072 + num4) + 128 >> 8);
        uint val = (uint)((ulong)((long)lhs * (long)num5 + 32768) >> 16);
        return Math.Min(131071u, val);
    }

    private static void InterpolateColor(long in_MAC1, long in_MAC2, long in_MAC3, byte shift, bool lm)
    {
        TruncateAndSetMACAndIR(((long)farColor._rfc << 12) - in_MAC1, 1, shift, lm: false);
        TruncateAndSetMACAndIR(((long)farColor._gfc << 12) - in_MAC2, 2, shift, lm: false);
        TruncateAndSetMACAndIR(((long)farColor._bfc << 12) - in_MAC3, 3, shift, lm: false);
        TruncateAndSetMACAndIR(accumulator.ir1 * accumulator.ir0 + in_MAC1, 1, shift, lm);
        TruncateAndSetMACAndIR(accumulator.ir2 * accumulator.ir0 + in_MAC2, 2, shift, lm);
        TruncateAndSetMACAndIR(accumulator.ir3 * accumulator.ir0 + in_MAC3, 3, shift, lm);
    }

    private static void SetOTZ(int value)
    {
        if (value < 0)
        {
            value = 0;
        }
        else if (value > 65535)
        {
            value = 65535;
        }
        averageZ = (ushort)value;
    }

    private static void TruncateAndSetMACAndIR(long value, int index, byte shift, bool lm)
    {
        value >>= (int)shift;
        int num = (int)value;
        switch (index)
        {
            case 0:
                mathsAccumulator.mac0 = num;
                break;
            case 1:
                mathsAccumulator.mac1 = num;
                break;
            case 2:
                mathsAccumulator.mac2 = num;
                break;
            default:
                mathsAccumulator.mac3 = num;
                break;
        }
        TruncateAndSetIR(num, index, lm);
    }

    private static void TruncateAndSetIR(int value, int index, bool lm)
    {
        int num = (index == 0) ? IR0_MIN_VALUE : IR123_MIN_VALUE;
        int num2 = (index == 0) ? IR0_MAX_VALUE : IR123_MAX_VALUE;
        int num3 = (!lm) ? num : 0;
        if (value < num3)
        {
            value = num3;
        }
        else if (value > num2)
        {
            value = num2;
        }
        switch (index)
        {
            case 0:
                accumulator.ir0 = (short)value;
                break;
            case 1:
                accumulator.ir1 = (short)value;
                break;
            case 2:
                accumulator.ir2 = (short)value;
                break;
            default:
                accumulator.ir3 = (short)value;
                break;
        }
    }

    private static void TruncateAndSetMAC(long value, int index, byte shift)
    {
        value >>= (int)shift;
        switch (index)
        {
            case 0:
                mathsAccumulator.mac0 = (int)value;
                break;
            case 1:
                mathsAccumulator.mac1 = (int)value;
                break;
            case 2:
                mathsAccumulator.mac2 = (int)value;
                break;
            default:
                mathsAccumulator.mac3 = (int)value;
                break;
        }
    }

    private static long SignExtendMACResult(long value, int index)
    {
        return TypesClass.SignExtend64(value, (index == 0) ? 31 : 44);
    }

    private static void PushRGBFromMAC()
    {
        uint num = TruncateRGB(mathsAccumulator.mac1 >> 4, 0);
        uint num2 = TruncateRGB(mathsAccumulator.mac2 >> 4, 1);
        uint num3 = TruncateRGB(mathsAccumulator.mac3 >> 4, 2);
        uint code = colorCode.code;
        colorFIFO.r0 = colorFIFO.r1;
        colorFIFO.g0 = colorFIFO.g1;
        colorFIFO.b0 = colorFIFO.b1;
        colorFIFO.cd0 = colorFIFO.cd1;
        colorFIFO.r1 = colorFIFO.r2;
        colorFIFO.g1 = colorFIFO.g2;
        colorFIFO.b1 = colorFIFO.b2;
        colorFIFO.cd1 = colorFIFO.cd2;
        colorFIFO.r2 = (byte)num;
        colorFIFO.g2 = (byte)num2;
        colorFIFO.b2 = (byte)num3;
        colorFIFO.cd2 = (byte)code;
    }

    private static void PushSXY(int x, int y)
    {
        if (x < -1024)
        {
            x = -1024;
        }
        else if (x > 1023)
        {
            x = 1023;
        }
        if (y < -1024)
        {
            y = -1024;
        }
        else if (y > 1023)
        {
            y = 1023;
        }
        screenXYFIFO.sx0 = screenXYFIFO.sx1;
        screenXYFIFO.sy0 = screenXYFIFO.sy1;
        screenXYFIFO.sx1 = screenXYFIFO.sx2;
        screenXYFIFO.sy1 = screenXYFIFO.sy2;
        screenXYFIFO.sx2 = (short)x;
        screenXYFIFO.sy2 = (short)y;
    }

    private static void PushSXYZ(int x, int y, int z)
    {
        screenXYZFIFO.sx0 = screenXYZFIFO.sx1;
        screenXYZFIFO.sy0 = screenXYZFIFO.sy1;
        screenXYZFIFO.sz0 = screenXYZFIFO.sz1;
        screenXYZFIFO.sx1 = screenXYZFIFO.sx2;
        screenXYZFIFO.sy1 = screenXYZFIFO.sy2;
        screenXYZFIFO.sz1 = screenXYZFIFO.sz2;
        screenXYZFIFO.sx2 = (short)x;
        screenXYZFIFO.sy2 = (short)y;
        screenXYZFIFO.sz2 = (short)z;
    }

    private static void PushSZ(int value)
    {
        if (value < 0)
        {
            value = 0;
        }
        else if (value > 65535)
        {
            value = 65535;
        }
        screenZFIFO.sz0 = screenZFIFO.sz1;
        screenZFIFO.sz1 = screenZFIFO.sz2;
        screenZFIFO.sz2 = screenZFIFO.sz3;
        screenZFIFO.sz3 = (short)value;
    }

    private static uint TruncateRGB(int value, int index)
    {
        if (value < 0 || value > 255)
        {
            if (value >= 0)
            {
                return 255u;
            }
            return 0u;
        }
        return (uint)value;
    }
}
