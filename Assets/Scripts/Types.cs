using System;
using System.Collections;
using System.Collections.Generic;

namespace Types
{
    public enum DisplayAspectRatio
    {
        Auto,
        MatchWindow,
        Custom,
        R4_3,
        R16_9,
        R19_9,
        R20_9,
        PAR1_1,
        Count
    }
    public class TypesClass
    {
        private static readonly sbyte INT8_MIN = sbyte.MaxValue;

        private static readonly short INT16_MAX = short.MaxValue;

        private static readonly int INT32_MAX = int.MaxValue;

        private static readonly long INT64_MAX = long.MaxValue;

        public static int INT8_C(int x)
        {
            return x;
        }

        public static int INT16_C(int x)
        {
            return x;
        }

        public static int INT32_C(int x)
        {
            return x + (INT32_MAX - INT32_MAX);
        }

        public static int INT64_C(int x)
        {
            return x + (int)(INT64_MAX - INT64_MAX);
        }

        public static int SignExtend32(int value, int NBITS)
        {
            int num = 32 - NBITS;
            return value << num >> num;
        }

        public static long SignExtend64(long value, int NBITS)
        {
            int num = 64 - NBITS;
            return value << num >> num;
        }
    }
}