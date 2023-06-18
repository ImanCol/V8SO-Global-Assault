using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using MathExtended.Matrices;
using UnityEngine.UI;
using Unity.Burst;

[Serializable]
public struct Matrix3x3
{
    // Token: 0x1700001C RID: 28
    // (get) Token: 0x06000B6F RID: 2927 RVA: 0x00098DAC File Offset: 0x00096FAC
    public Vector3 Scale
    {
        get
        {
            float num = (float)this.V00 / 4096f;
            float num2 = (float)this.V01 / 4096f;
            float num3 = (float)this.V02 / 4096f;
            float num4 = (float)this.V10 / 4096f;
            float num5 = (float)this.V11 / 4096f;
            float num6 = (float)this.V12 / 4096f;
            float num7 = (float)this.V20 / 4096f;
            float num8 = (float)this.V21 / 4096f;
            float num9 = (float)this.V22 / 4096f;
            float magnitude = new Vector3(num, num4, num7).magnitude;
            float magnitude2 = new Vector3(num2, num5, num8).magnitude;
            float magnitude3 = new Vector3(num3, num6, num9).magnitude;
            return new Vector3(magnitude, magnitude2, magnitude3);
        }
    }

    // Token: 0x1700001D RID: 29
    // (get) Token: 0x06000B70 RID: 2928 RVA: 0x00098E80 File Offset: 0x00097080
    public Quaternion Matrix2Quaternion
    {
        get
        {
            double num;
            double num2;
            double num3;
            double num4;
            double num5;
            double num6;
            double num7;
            double num8;
            double num9;
            if (this.skewed)
            {
                num = (double)this._V00 / 4096.0;
                num2 = (double)this._V01 / 4096.0;
                num3 = (double)this._V02 / 4096.0;
                num4 = (double)this._V10 / 4096.0;
                num5 = (double)this._V11 / 4096.0;
                num6 = (double)this._V12 / 4096.0;
                num7 = (double)this._V20 / 4096.0;
                num8 = (double)this._V21 / 4096.0;
                num9 = (double)this._V22 / 4096.0;
            }
            else
            {
                num = (double)this.V00 / 4096.0;
                num2 = (double)this.V01 / 4096.0;
                num3 = (double)this.V02 / 4096.0;
                num4 = (double)this.V10 / 4096.0;
                num5 = (double)this.V11 / 4096.0;
                num6 = (double)this.V12 / 4096.0;
                num7 = (double)this.V20 / 4096.0;
                num8 = (double)this.V21 / 4096.0;
                num9 = (double)this.V22 / 4096.0;
            }
            float num10 = (float)(num + num5 + num9);
            double num12;
            double num13;
            double num14;
            double num15;
            if (num10 > 0f)
            {
                float num11 = (float)Math.Sqrt((double)(num10 + 1f)) * 2f;
                num12 = 0.25 * (double)num11;
                num13 = (num8 - num6) / (double)num11;
                num14 = (num3 - num7) / (double)num11;
                num15 = (num4 - num2) / (double)num11;
            }
            else if ((num > num5) & (num > num9))
            {
                float num16 = (float)Math.Sqrt(1.0 + num - num5 - num9) * 2f;
                num12 = (num8 - num6) / (double)num16;
                num13 = 0.25 * (double)num16;
                num14 = (num2 + num4) / (double)num16;
                num15 = (num3 + num7) / (double)num16;
            }
            else if (num5 > num9)
            {
                float num17 = (float)Math.Sqrt(1.0 + num5 - num - num9) * 2f;
                num12 = (num3 - num7) / (double)num17;
                num13 = (num2 + num4) / (double)num17;
                num14 = 0.25 * (double)num17;
                num15 = (num6 + num8) / (double)num17;
            }
            else
            {
                float num18 = (float)Math.Sqrt(1.0 + num9 - num - num5) * 2f;
                num12 = (num4 - num2) / (double)num18;
                num13 = (num3 + num7) / (double)num18;
                num14 = (num6 + num8) / (double)num18;
                num15 = 0.25 * (double)num18;
            }
            return new Quaternion((float)num13, (float)num14, (float)num15, (float)num12);
        }
    }

    // Token: 0x06000B71 RID: 2929 RVA: 0x00099158 File Offset: 0x00097358
    public void MatrixNormal()
    {
        this.skewed = true;
        this._V00 = this.V00;
        this._V01 = this.V01;
        this._V02 = this.V02;
        this._V10 = this.V10;
        this._V11 = this.V11;
        this._V12 = this.V12;
        this._V20 = this.V20;
        this._V21 = this.V21;
        this._V22 = this.V22;
    }

    // Token: 0x06000B72 RID: 2930 RVA: 0x000991D8 File Offset: 0x000973D8
    public int GetValue32(int index)
    {
        if (index >= 5)
        {
            index = 4;
        }
        else if (index < 0)
        {
            index = 0;
        }
        int num;
        switch (index)
        {
            case 0:
                num = ((int)this.V01 << 16) | (int)((ushort)this.V00);
                break;
            case 1:
                num = ((int)this.V10 << 16) | (int)((ushort)this.V02);
                break;
            case 2:
                num = ((int)this.V12 << 16) | (int)((ushort)this.V11);
                break;
            case 3:
                num = ((int)this.V21 << 16) | (int)((ushort)this.V20);
                break;
            default:
                num = (int)this.V22;
                break;
        }
        return num;
    }

    // Token: 0x06000B73 RID: 2931 RVA: 0x00099268 File Offset: 0x00097468
    public void SetValue32(int index, int value)
    {
        switch (index)
        {
            case 0:
                this.V00 = (short)value;
                this.V01 = (short)(value >> 16);
                return;
            case 1:
                this.V02 = (short)value;
                this.V10 = (short)(value >> 16);
                return;
            case 2:
                this.V11 = (short)value;
                this.V12 = (short)(value >> 16);
                return;
            case 3:
                this.V20 = (short)value;
                this.V21 = (short)(value >> 16);
                return;
            default:
                this.V22 = (short)value;
                return;
        }
    }

    // Token: 0x06000B74 RID: 2932 RVA: 0x000992E8 File Offset: 0x000974E8
    public void SetValue16(int index, int value)
    {
        switch (index)
        {
            case 0:
                this.V00 = (short)value;
                return;
            case 1:
                this.V01 = (short)value;
                return;
            case 2:
                this.V02 = (short)value;
                return;
            case 3:
                this.V10 = (short)value;
                return;
            case 4:
                this.V11 = (short)value;
                return;
            case 5:
                this.V12 = (short)value;
                return;
            case 6:
                this.V20 = (short)value;
                return;
            case 7:
                this.V21 = (short)value;
                return;
            default:
                this.V22 = (short)value;
                return;
        }
    }

    // Token: 0x040007DD RID: 2013
    public short V00;

    // Token: 0x040007DE RID: 2014
    public short V01;

    // Token: 0x040007DF RID: 2015
    public short V02;

    // Token: 0x040007E0 RID: 2016
    public short V10;

    // Token: 0x040007E1 RID: 2017
    public short V11;

    // Token: 0x040007E2 RID: 2018
    public short V12;

    // Token: 0x040007E3 RID: 2019
    public short V20;

    // Token: 0x040007E4 RID: 2020
    public short V21;

    // Token: 0x040007E5 RID: 2021
    public short V22;

    // Token: 0x040007E6 RID: 2022
    public bool skewed;

    // Token: 0x040007E7 RID: 2023
    public short _V00;

    // Token: 0x040007E8 RID: 2024
    public short _V01;

    // Token: 0x040007E9 RID: 2025
    public short _V02;

    // Token: 0x040007EA RID: 2026
    public short _V10;

    // Token: 0x040007EB RID: 2027
    public short _V11;

    // Token: 0x040007EC RID: 2028
    public short _V12;

    // Token: 0x040007ED RID: 2029
    public short _V20;

    // Token: 0x040007EE RID: 2030
    public short _V21;

    // Token: 0x040007EF RID: 2031
    public short _V22;
}
[Serializable]
public struct Matrix2x3
{
    // Token: 0x06000B75 RID: 2933 RVA: 0x00099370 File Offset: 0x00097570
    public Matrix2x3(int x, int y, int z)
    {
        this.M0 = (short)(x & 65535);
        this.M1 = (short)(x >> 16);
        this.M2 = (short)(y & 65535);
        this.M3 = (short)(y >> 16);
        this.M4 = (short)(z & 65535);
        this.M5 = (short)(z >> 16);
    }

    // Token: 0x06000B76 RID: 2934 RVA: 0x000993C8 File Offset: 0x000975C8
    public Matrix2x3(Vector3Int v3)
    {
        this.M0 = (short)(v3.x & 65535);
        this.M1 = (short)(v3.x >> 16);
        this.M2 = (short)(v3.y & 65535);
        this.M3 = (short)(v3.y >> 16);
        this.M4 = (short)(v3.z & 65535);
        this.M5 = (short)(v3.z >> 16);
    }

    // Token: 0x1700001E RID: 30
    // (get) Token: 0x06000B77 RID: 2935 RVA: 0x0000B20D File Offset: 0x0000940D
    // (set) Token: 0x06000B78 RID: 2936 RVA: 0x0000B220 File Offset: 0x00009420
    public int X
    {
        get
        {
            return ((int)this.M1 << 16) | (int)((ushort)this.M0);
        }
        set
        {
            this.M0 = (short)(value & 65535);
            this.M1 = (short)(value >> 16);
        }
    }

    // Token: 0x1700001F RID: 31
    // (get) Token: 0x06000B79 RID: 2937 RVA: 0x0000B23B File Offset: 0x0000943B
    // (set) Token: 0x06000B7A RID: 2938 RVA: 0x0000B24E File Offset: 0x0000944E
    public int Y
    {
        get
        {
            return ((int)this.M3 << 16) | (int)((ushort)this.M2);
        }
        set
        {
            this.M2 = (short)(value & 65535);
            this.M3 = (short)(value >> 16);
        }
    }

    // Token: 0x17000020 RID: 32
    // (get) Token: 0x06000B7B RID: 2939 RVA: 0x0000B269 File Offset: 0x00009469
    // (set) Token: 0x06000B7C RID: 2940 RVA: 0x0000B27C File Offset: 0x0000947C
    public int Z
    {
        get
        {
            return ((int)this.M5 << 16) | (int)((ushort)this.M4);
        }
        set
        {
            this.M4 = (short)(value & 65535);
            this.M5 = (short)(value >> 16);
        }
    }

    // Token: 0x040007F0 RID: 2032
    public short M0;

    // Token: 0x040007F1 RID: 2033
    public short M1;

    // Token: 0x040007F2 RID: 2034
    public short M2;

    // Token: 0x040007F3 RID: 2035
    public short M3;

    // Token: 0x040007F4 RID: 2036
    public short M4;

    // Token: 0x040007F5 RID: 2037
    public short M5;
}
[Serializable]
public struct Matrix2x4
{
    // Token: 0x06000B7D RID: 2941 RVA: 0x00099444 File Offset: 0x00097644
    public Matrix2x4(int x, int y, int z, int w)
    {
        this.M0 = (short)(x & 65535);
        this.M1 = (short)(x >> 16);
        this.M2 = (short)(y & 65535);
        this.M3 = (short)(y >> 16);
        this.M4 = (short)(z & 65535);
        this.M5 = (short)(z >> 16);
        this.M6 = (short)(w & 65535);
        this.M7 = (short)(w >> 16);
    }

    // Token: 0x17000021 RID: 33
    // (get) Token: 0x06000B7E RID: 2942 RVA: 0x0000B297 File Offset: 0x00009497
    // (set) Token: 0x06000B7F RID: 2943 RVA: 0x0000B2AA File Offset: 0x000094AA
    public int X
    {
        get
        {
            return ((int)this.M1 << 16) | (int)((ushort)this.M0);
        }
        set
        {
            this.M0 = (short)(value & 65535);
            this.M1 = (short)(value >> 16);
        }
    }

    // Token: 0x17000022 RID: 34
    // (get) Token: 0x06000B80 RID: 2944 RVA: 0x0000B2C5 File Offset: 0x000094C5
    // (set) Token: 0x06000B81 RID: 2945 RVA: 0x0000B2D8 File Offset: 0x000094D8
    public int Y
    {
        get
        {
            return ((int)this.M3 << 16) | (int)((ushort)this.M2);
        }
        set
        {
            this.M2 = (short)(value & 65535);
            this.M3 = (short)(value >> 16);
        }
    }

    // Token: 0x17000023 RID: 35
    // (get) Token: 0x06000B82 RID: 2946 RVA: 0x0000B2F3 File Offset: 0x000094F3
    // (set) Token: 0x06000B83 RID: 2947 RVA: 0x0000B306 File Offset: 0x00009506
    public int Z
    {
        get
        {
            return ((int)this.M5 << 16) | (int)((ushort)this.M4);
        }
        set
        {
            this.M4 = (short)(value & 65535);
            this.M5 = (short)(value >> 16);
        }
    }

    // Token: 0x17000024 RID: 36
    // (get) Token: 0x06000B84 RID: 2948 RVA: 0x0000B321 File Offset: 0x00009521
    // (set) Token: 0x06000B85 RID: 2949 RVA: 0x0000B334 File Offset: 0x00009534
    public int W
    {
        get
        {
            return ((int)this.M7 << 16) | (int)((ushort)this.M6);
        }
        set
        {
            this.M6 = (short)(value & 65535);
            this.M7 = (short)(value >> 16);
        }
    }

    // Token: 0x040007F6 RID: 2038
    public short M0;

    // Token: 0x040007F7 RID: 2039
    public short M1;

    // Token: 0x040007F8 RID: 2040
    public short M2;

    // Token: 0x040007F9 RID: 2041
    public short M3;

    // Token: 0x040007FA RID: 2042
    public short M4;

    // Token: 0x040007FB RID: 2043
    public short M5;

    // Token: 0x040007FC RID: 2044
    public short M6;

    // Token: 0x040007FD RID: 2045
    public short M7;
}

[Serializable]
public struct VigTransform
{
    public Matrix3x3 rotation;
    public short padding;
    public Vector3Int position;
}


[BurstCompile]
public class VigObject : MonoBehaviour
{
    private float forceModifier = 1; // Valor predeterminado en caso de que no se establezca otro valor




    public uint flags;

    public byte type;

    public sbyte tags;

    public short id;

    public VigObject child;

    public VigObject child2;

    public VigObject parent;

    public sbyte DAT_18;

    public byte DAT_19;

    public short DAT_1A;

    public ushort maxHalfHealth;

    public ushort maxFullHealth;

    public VigTransform vTransform;

    public VigMesh vMesh;

    public Vector3Int screen;

    public Vector3Int vr;

    public ushort DAT_4A;

    public int DAT_58;

    public XOBF_DB vData;

    public VigCollider vCollider;

    public BufferedBinaryReader vAnim;

    public VigMesh vLOD;

    public int DAT_6C;

    public VigShadow vShadow;

    public VigObject PDAT_74;

    public ConfigContainer CCDAT_74;

    public VigTuple TDAT_74;

    public int IDAT_74;

    public VigObject PDAT_78;

    public List<VigObject> LDAT_78;

    public VigTuple TDAT_78;

    public int IDAT_78;

    public VigObject PDAT_7C;

    public int IDAT_7C;

    public VigObject DAT_80;

    public VigObject DAT_84;

    public Matrix2x4 physics1;

    public Matrix2x4 physics2;

    public Vector3Int DAT_A0;

    public short DAT_A6;


    protected virtual void Start()
    {
    }

    protected virtual void Update()
    {
        base.transform.localPosition = new Vector3((float)vTransform.position.x / (float)GameManager.instance.translateFactor, (float)(-vTransform.position.y) / (float)GameManager.instance.translateFactor, (float)vTransform.position.z / (float)GameManager.instance.translateFactor);
        base.transform.localRotation = vTransform.rotation.Matrix2Quaternion;
        base.transform.localEulerAngles = new Vector3(0f - base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 0f - base.transform.localEulerAngles.z);
        base.transform.localScale = vTransform.rotation.Scale;
    }

    public virtual uint UpdateW(int arg1, int arg2)
    {
        return 0u;
    }

    public virtual uint UpdateW(int arg1, VigObject arg2)
    {
        return 0u;
    }

    public virtual uint UpdateW(VigObject arg1, int arg2, Vector3Int arg3)
    {
        return 0u;
    }

    public virtual uint UpdateW(VigObject arg1, int arg2, int arg3)
    {
        return 0u;
    }

    public virtual sbyte UpdateW(VigObject arg1, int arg2, TileData arg3)
    {
        return 0;
    }

    public Transform GetTransform()
    {
        base.transform.localPosition = new Vector3((float)vTransform.position.x / (float)GameManager.instance.translateFactor, (float)(-vTransform.position.y) / (float)GameManager.instance.translateFactor, (float)vTransform.position.z / (float)GameManager.instance.translateFactor);
        base.transform.localRotation = vTransform.rotation.Matrix2Quaternion;
        base.transform.localEulerAngles = new Vector3(0f - base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 0f - base.transform.localEulerAngles.z);
        base.transform.localScale = vTransform.rotation.Scale;
        return base.transform;
    }

    public void ApplyTransformation()
    {
        vTransform.position = screen;
        vTransform.rotation = Utilities.RotMatrixYXZ_gte(vr);
        vTransform.rotation.skewed = false;
        vTransform.padding = 0;
    }

    public void ApplyRotationMatrix()
    {
        vTransform.rotation = Utilities.RotMatrixYXZ_gte(vr);
        vTransform.rotation.skewed = false;
        vTransform.padding = 0;
    }

    public void FUN_24700(short x, short y, short z)
    {
        Coprocessor.rotationMatrix.rt11 = vTransform.rotation.V00;
        Coprocessor.rotationMatrix.rt12 = vTransform.rotation.V01;
        Coprocessor.rotationMatrix.rt13 = vTransform.rotation.V02;
        Coprocessor.rotationMatrix.rt21 = vTransform.rotation.V10;
        Coprocessor.rotationMatrix.rt22 = vTransform.rotation.V11;
        Coprocessor.rotationMatrix.rt23 = vTransform.rotation.V12;
        Coprocessor.rotationMatrix.rt31 = vTransform.rotation.V20;
        Coprocessor.rotationMatrix.rt32 = vTransform.rotation.V21;
        Coprocessor.rotationMatrix.rt33 = vTransform.rotation.V22;
        Coprocessor.accumulator.ir1 = 4096;
        Coprocessor.accumulator.ir2 = z;
        Coprocessor.accumulator.ir3 = (short)(-y);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        vTransform.rotation.V00 = Coprocessor.accumulator.ir1;
        vTransform.rotation.V10 = Coprocessor.accumulator.ir2;
        vTransform.rotation.V20 = Coprocessor.accumulator.ir3;
        Coprocessor.vector0.vx0 = (short)(-z);
        Coprocessor.vector0.vy0 = 4096;
        Coprocessor.vector0.vz0 = x;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        vTransform.rotation.V01 = Coprocessor.accumulator.ir1;
        vTransform.rotation.V11 = Coprocessor.accumulator.ir2;
        vTransform.rotation.V21 = Coprocessor.accumulator.ir3;
        Coprocessor.vector1.vx1 = y;
        Coprocessor.vector1.vy1 = (short)(-x);
        Coprocessor.vector1.vz1 = 4096;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V1, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        vTransform.rotation.V02 = Coprocessor.accumulator.ir1;
        vTransform.rotation.V12 = Coprocessor.accumulator.ir2;
        vTransform.rotation.V22 = Coprocessor.accumulator.ir3;
    }

    public VigTransform FUN_2AE18()
    {
        VigTransform vigTransform = default(VigTransform);
        vigTransform.rotation = new Matrix3x3
        {
            V00 = 0,
            V01 = (short)(-physics2.M4),
            V02 = physics2.M2,
            V10 = physics2.M4,
            V11 = 0,
            V12 = (short)(-physics2.M0),
            V20 = (short)(-physics2.M2),
            V21 = physics2.M0,
            V22 = 0
        };
        vigTransform.position = new Vector3Int(physics1.X, physics1.Y, physics1.Z);
        VigTransform vigTransform2 = vigTransform;
        vigTransform2.rotation = Utilities.FUN_247C4(vTransform.rotation, vigTransform2.rotation);
        return vigTransform2;
    }

    public VigTransform FUN_2AEAC()
    {
        VigTransform result = default(VigTransform);
        result.rotation.V22 = 0;
        result.rotation.V11 = 0;
        result.rotation.V00 = 0;
        result.rotation.V21 = physics2.M0;
        result.rotation.V12 = (short)(-physics2.M0);
        result.rotation.V02 = physics2.M2;
        result.rotation.V20 = (short)(-physics2.M2);
        result.rotation.V10 = physics2.M4;
        result.rotation.V01 = (short)(-physics2.M4);
        result.position = Utilities.FUN_2426C(vTransform.rotation, physics1);
        return result;
    }

    public void FUN_2AF20()
    {
        int num = physics2.X;
        if (num < 0)
        {
            num += 127;
        }
        int num2 = physics2.Y;
        if (num2 < 0)
        {
            num2 += 127;
        }
        int num3 = physics2.Z;
        if (num3 < 0)
        {
            num3 += 127;
        }
        FUN_24700((short)(num >> 7), (short)(num2 >> 7), (short)(num3 >> 7));
        num = physics1.X;
        if (num < 0)
        {
            num += 127;
        }
        num2 = physics1.Y;
        vTransform.position.x += num >> 7;
        if (num2 < 0)
        {
            num2 += 127;
        }
        num = physics1.Z;
        vTransform.position.y += num2 >> 7;
        if (num < 0)
        {
            num += 127;
        }
        vTransform.position.z += num >> 7;
        vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
    }

    public void FUN_2AFF8(Vector3Int v1, Vector3Int v2, bool noflip = false)
    {
        //Debug.Log(GameManager.instance.forceModifier);
        //Debug.Log(Mathf.RoundToInt(GameManager.instance.forceModifier));

        physics1.X += Mathf.RoundToInt(v1.x); //Fuerza de Friccion y Aceleracion
        //physics1.X += Mathf.RoundToInt(v1.x * GameManager.instance.forceModifier); //Fuerza de Friccion y Aceleracion
        physics1.Y += Mathf.RoundToInt(v1.y); //Gravedad
        //physics1.Y += Mathf.RoundToInt(v1.y * GameManager.instance.forceModifier); //Gravedad
        physics1.Z += Mathf.RoundToInt(v1.z); //Fuerza de Friccion y Aceleracion
        //physics1.Z += Mathf.RoundToInt(v1.z * GameManager.instance.forceModifier); //Fuerza de Friccion y Aceleracion
        int num = v2.x * DAT_A0.x;
        if (num < 0)
        {
            num += 63;
        }
        int num2 = physics2.X + (num >> 6);
        num = -32768;
        if (-32769 < num2)
        {
            num = 32767;
            if (num2 < num)
            {
                num = num2;
            }
        }
        if (!noflip)
        {
            num = num2;
        }
        physics2.X = num;
        num = v2.y * DAT_A0.y;
        if (num < 0)
        {
            num += 63;
        }
        num2 = physics2.Y + (num >> 6);
        num = -32768;
        if (-32769 < num2)
        {
            num = 32767;
            if (num2 < num)
            {
                num = num2;
            }
        }
        if (!noflip)
        {
            num = num2;
        }
        physics2.Y = num;
        num = v2.z * DAT_A0.z;
        if (num < 0)
        {
            num += 63;
        }
        num2 = physics2.Z + (num >> 6);
        num = -32768;
        if (-32769 < num2)
        {
            num = 32767;
            if (num2 < num)
            {
                num = num2;
            }
        }
        if (!noflip)
        {
            num = num2;
        }
        physics2.Z = num;
        if (!noflip)
        {
            num = num2;
            if (physics2.X > 720896)
            {
                physics2.X = 720896;
            }
            else if (physics2.X < -720896)
            {
                physics2.X = -720896;
            }
            if (physics2.Y > 720896)
            {
                physics2.Y = 720896;
            }
            else if (physics2.Y < -720896)
            {
                physics2.Y = -720896;
            }
            if (num > 720896)
            {
                num = 720896;
            }
            else if (num < -720896)
            {
                num = -720896;
            }
        }
        num2 = physics2.X;
        if (num2 < 0)
        {
            num2 += 127;
        }
        int num3 = physics2.Y;
        if (num3 < 0)
        {
            num3 += 127;
        }
        if (num < 0)
        {
            num += 127;
        }
        FUN_24700((short)(num2 >> 7), (short)(num3 >> 7), (short)(num >> 7));
        num = physics1.X;
        if (num < 0)
        {
            num += 127;
        }
        vTransform.position.x += num >> 7;
        num2 = physics1.Y;
        if (num2 < 0)
        {
            num2 += 127;
        }
        vTransform.position.y += num2 >> 7;
        num3 = physics1.Z;
        if (num3 < 0)
        {
            num3 += 127;
        }
        vTransform.position.z += num3 >> 7;
        vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
    }



    public void FUN_2AFF8_2(Vector3Int v1, Vector3Int v2, bool noflip = true)
    {
        physics1.X += v1.x;
        physics1.Y += v1.y;
        physics1.Z += v1.z;
        int num = v2.x * DAT_A0.x;
        if (num < 0)
        {
            num += 63;
        }
        int num2 = physics2.X + (num >> 6);
        num = -32768;
        if (-32769 < num2)
        {
            num = 32767;
            if (num2 < num)
            {
                num = num2;
            }
        }
        if (!noflip)
        {
            num = num2;
        }
        physics2.X = num;
        num = v2.y * DAT_A0.y;
        if (num < 0)
        {
            num += 63;
        }
        num2 = physics2.Y + (num >> 6);
        num = -32768;
        if (-32769 < num2)
        {
            num = 32767;
            if (num2 < num)
            {
                num = num2;
            }
        }
        if (!noflip)
        {
            num = num2;
        }
        physics2.Y = num;
        num = v2.z * DAT_A0.z;
        if (num < 0)
        {
            num += 63;
        }
        num2 = physics2.Z + (num >> 6);
        num = -32768;
        if (-32769 < num2)
        {
            num = 32767;
            if (num2 < num)
            {
                num = num2;
            }
        }
        if (!noflip)
        {
            num = num2;
        }
        physics2.Z = num;
        if (!noflip)
        {
            num = num2;
            if (physics2.X > 720896)
            {
                physics2.X = 720896;
            }
            else if (physics2.X < -720896)
            {
                physics2.X = -720896;
            }
            if (physics2.Y > 720896)
            {
                physics2.Y = 720896;
            }
            else if (physics2.Y < -720896)
            {
                physics2.Y = -720896;
            }
            if (num > 720896)
            {
                num = 720896;
            }
            else if (num < -720896)
            {
                num = -720896;
            }
        }
        num2 = physics2.X;
        if (num2 < 0)
        {
            num2 += 127;
        }
        int num3 = physics2.Y;
        if (num3 < 0)
        {
            num3 += 127;
        }
        if (num < 0)
        {
            num += 127;
        }
        FUN_24700((short)(num2 >> 7), (short)(num3 >> 7), (short)(num >> 7));
        vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
    }

    public void FUN_2B1FC(Vector3Int v1, Vector3Int v2, int shift = 0)
    {
        Vector3Int vector3Int = Utilities.FUN_24094(vTransform.rotation, v1);
        Coprocessor.rotationMatrix.rt11 = (short)((v2.x >> 4) & 0xFFFF);
        Coprocessor.rotationMatrix.rt12 = (short)(v2.x >> 4 >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)((v2.y >> 4) & 0xFFFF);
        Coprocessor.rotationMatrix.rt23 = (short)(v2.y >> 4 >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)(v2.z >> 4);
        Coprocessor.accumulator.ir1 = (short)(v1.x >> 3);
        Coprocessor.accumulator.ir2 = (short)(v1.y >> 3);
        Coprocessor.accumulator.ir3 = (short)(v1.z >> 3);
        Coprocessor.ExecuteOP(12, lm: false);
        physics1.X += vector3Int.x << shift;
        physics1.Y += vector3Int.y << shift;
        physics1.Z += vector3Int.z << shift;
        int mac = Coprocessor.mathsAccumulator.mac1;
        mac *= DAT_A0.x;
        if (mac < 0)
        {
            mac += 63;
        }
        physics2.X += mac >> 6;
        mac = Coprocessor.mathsAccumulator.mac2;
        mac *= DAT_A0.y;
        if (mac < 0)
        {
            mac += 63;
        }
        physics2.Y += mac >> 6;
        mac = Coprocessor.mathsAccumulator.mac3;
        mac *= DAT_A0.z;
        if (mac < 0)
        {
            mac += 63;
        }
        physics2.Z += mac >> 6;
    }

    public void FUN_2B370(Vector3Int v1, Vector3Int v2, int shift = 0)
    {
        int num = v2.x - vTransform.position.x >> 3;
        int num2 = v2.y - vTransform.position.y >> 3;
        int num3 = v2.z - vTransform.position.z >> 3;
        Coprocessor.rotationMatrix.rt11 = (short)num;
        Coprocessor.rotationMatrix.rt12 = (short)(num >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)num2;
        Coprocessor.rotationMatrix.rt23 = (short)(num2 >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)num3;
        Coprocessor.accumulator.ir1 = (short)(v1.x >> 3);
        Coprocessor.accumulator.ir2 = (short)(v1.y >> 3);
        Coprocessor.accumulator.ir3 = (short)(v1.z >> 3);
        Coprocessor.ExecuteOP(12, lm: false);
        physics1.X += v1.x << shift;
        physics1.Y += v1.y << shift;
        physics1.Z += v1.z << shift;
        Vector3Int vector3Int = Utilities.FUN_24238(v3: new Vector3Int(Coprocessor.mathsAccumulator.mac1, Coprocessor.mathsAccumulator.mac2, Coprocessor.mathsAccumulator.mac3), m33: vTransform.rotation);
        int num4 = vector3Int.x * DAT_A0.x;
        if (num4 < 0)
        {
            num4 += 127;
        }
        physics2.X += num4 >> 7 << shift;
        num4 = vector3Int.y * DAT_A0.y;
        if (num4 < 0)
        {
            num4 += 127;
        }
        physics2.Y += num4 >> 7 << shift;
        num4 = vector3Int.z * DAT_A0.z;
        if (num4 < 0)
        {
            num4 += 127;
        }
        physics2.Z += num4 >> 7 << shift;
    }

    public void FUN_2C01C()
    {
        BufferedBinaryReader bufferedBinaryReader = new BufferedBinaryReader(vData.animations);
        if (bufferedBinaryReader.GetBuffer() != null)
        {
            int num = bufferedBinaryReader.ReadInt32((ushort)DAT_1A * 4 + 4);
            if (num != 0)
            {
                bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
            }
            vAnim = bufferedBinaryReader;
        }
        else
        {
            vAnim = null;
        }
        DAT_4A = 0;
    }

    public void FUN_2C05C()
    {
        ushort timer = GameManager.instance.timer;
        BufferedBinaryReader bufferedBinaryReader = new BufferedBinaryReader(vData.animations);
        if (bufferedBinaryReader.GetBuffer() != null)
        {
            int num = bufferedBinaryReader.ReadInt32((ushort)DAT_1A * 4 + 4);
            if (num != 0)
            {
                bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
            }
            vAnim = bufferedBinaryReader;
        }
        else
        {
            vAnim = null;
        }
        DAT_4A = timer;
    }

    public void FUN_2C124(ushort param1)
    {
        GameManager.instance.FUN_1FEB8(vMesh);
        GameManager.instance.FUN_307CC(child2);
        child2 = null;
        FUN_2C344(vData, param1, 8u);
    }

    public void FUN_2C124(ushort param1, Dictionary<int, Type> param2)
    {
        GameManager.instance.FUN_1FEB8(vMesh);
        GameManager.instance.FUN_307CC(child2);
        child2 = null;
        FUN_2C344(vData, param1, 8u, param2);
    }

    public void FUN_2C124_2(ushort param1)
    {
        GameManager.instance.FUN_1FEB8(vMesh);
        GameManager.instance.FUN_307CC(child2);
        child2 = null;
        FUN_2C344_2(vData, param1, 8u);
    }

    public VigObject FUN_2C344(XOBF_DB param1, ushort param2, uint param3)
    {
        ConfigContainer configContainer = param1.ini.configContainers[param2];
        if ((configContainer.flag & 0x7FF) != 2047)
        {
            VigMesh vigMesh = vMesh = param1.FUN_1FD18(base.gameObject, (uint)(configContainer.flag & 0x7FF), init: true);
        }
        else
        {
            vMesh = null;
        }
        if (configContainer.colliderID < 0)
        {
            vCollider = null;
        }
        else
        {
            VigCollider vigCollider = param1.cbbList[configContainer.colliderID];
            vCollider = new VigCollider(vigCollider.buffer);
        }
        vData = param1;
        DAT_1A = (short)param2;
        if ((param3 & 8) == 0)
        {
            vAnim = null;
        }
        else
        {
            BufferedBinaryReader bufferedBinaryReader = vAnim;
            if (bufferedBinaryReader == null)
            {
                bufferedBinaryReader = new BufferedBinaryReader(param1.animations);
                if (bufferedBinaryReader.GetBuffer() != null)
                {
                    int num = bufferedBinaryReader.ReadInt32(param2 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
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
                int num = bufferedBinaryReader.ReadInt32(param2 * 4 + 4);
                if (num != 0)
                {
                    bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                }
                else
                {
                    bufferedBinaryReader = null;
                }
            }
            vAnim = bufferedBinaryReader;
        }
        DAT_4A = GameManager.instance.timer;
        if ((param3 & 2) == 0 && configContainer.next != ushort.MaxValue)
        {
            VigObject vigObject = child2 = param1.ini.FUN_2C17C(configContainer.next, typeof(VigObject), param3 | 0x21);
            if (vigObject != null)
            {
                vigObject.ApplyTransformation();
                child2.parent = this;
            }
        }
        else
        {
            child2 = null;
        }
        return this;
    }

    public VigObject FUN_2C344(XOBF_DB param1, ushort param2, uint param3, Dictionary<int, Type> param4)
    {
        ConfigContainer configContainer = param1.ini.configContainers[param2];
        if ((configContainer.flag & 0x7FF) != 2047)
        {
            VigMesh vigMesh = vMesh = param1.FUN_1FD18(base.gameObject, (uint)(configContainer.flag & 0x7FF), init: true);
        }
        else
        {
            vMesh = null;
        }
        if (configContainer.colliderID < 0)
        {
            vCollider = null;
        }
        else
        {
            VigCollider vigCollider = param1.cbbList[configContainer.colliderID];
            vCollider = new VigCollider(vigCollider.buffer);
        }
        vData = param1;
        DAT_1A = (short)param2;
        if ((param3 & 8) == 0)
        {
            vAnim = null;
        }
        else
        {
            BufferedBinaryReader bufferedBinaryReader = vAnim;
            if (bufferedBinaryReader == null)
            {
                bufferedBinaryReader = new BufferedBinaryReader(param1.animations);
                if (bufferedBinaryReader.GetBuffer() != null)
                {
                    int num = bufferedBinaryReader.ReadInt32(param2 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
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
                int num = bufferedBinaryReader.ReadInt32(param2 * 4 + 4);
                if (num != 0)
                {
                    bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                }
                else
                {
                    bufferedBinaryReader = null;
                }
            }
            vAnim = bufferedBinaryReader;
        }
        DAT_4A = GameManager.instance.timer;
        if ((param3 & 2) == 0 && configContainer.next != ushort.MaxValue)
        {
            VigObject vigObject = child2 = param1.ini.FUN_2C17C(configContainer.next, param4, param3 | 0x21);
            if (vigObject != null)
            {
                vigObject.ApplyTransformation();
                child2.parent = this;
            }
        }
        else
        {
            child2 = null;
        }
        return this;
    }

    public VigObject FUN_2C344_2(XOBF_DB param1, ushort param2, uint param3)
    {
        ConfigContainer configContainer = param1.ini.configContainers[param2];
        if ((configContainer.flag & 0x7FF) != 2047)
        {
            VigMesh vigMesh = vMesh = param1.FUN_1FD18(base.gameObject, configContainer.flag, init: true);
        }
        else
        {
            vMesh = null;
        }
        if (configContainer.colliderID < 0)
        {
            vCollider = null;
        }
        else
        {
            VigCollider vigCollider = param1.cbbList[configContainer.colliderID];
            vCollider = new VigCollider(vigCollider.buffer);
        }
        vData = param1;
        DAT_1A = (short)param2;
        if ((param3 & 8) == 0)
        {
            vAnim = null;
        }
        else
        {
            BufferedBinaryReader bufferedBinaryReader = vAnim;
            if (bufferedBinaryReader == null)
            {
                bufferedBinaryReader = new BufferedBinaryReader(param1.animations);
                if (bufferedBinaryReader.GetBuffer() != null)
                {
                    int num = bufferedBinaryReader.ReadInt32(param2 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
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
                int num = bufferedBinaryReader.ReadInt32(param2 * 4 + 4);
                if (num != 0)
                {
                    bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                }
                else
                {
                    bufferedBinaryReader = null;
                }
            }
            vAnim = bufferedBinaryReader;
        }
        DAT_4A = GameManager.instance.timer;
        if ((param3 & 2) == 0 && configContainer.next != ushort.MaxValue)
        {
            VigObject vigObject = child2 = param1.ini.FUN_2C17C_2(configContainer.next, typeof(Body), param3 | 0x21);
            if (vigObject != null)
            {
                vigObject.ApplyTransformation();
                child2.parent = this;
            }
        }
        else
        {
            child2 = null;
        }
        return this;
    }

    public int FUN_2CFBC(Vector3Int pos, ref Vector3Int normalVector3, out TileData normalTile)
    {
        GameManager instance = GameManager.instance;
        TileData tileByPosition = instance.terrain.GetTileByPosition((uint)pos.x, (uint)pos.z);
        int num = 3080192;
        num = (((tileByPosition.flags & 4) != 0) ? 3143680 : instance.terrain.FUN_1B750((uint)pos.x, (uint)pos.z));
        if (PDAT_74 != null)
        {
            int num2 = PDAT_74.FUN_2F710(num, pos, ref normalVector3);
            if (num2 != 0)
            {
                if (PDAT_78 != null)
                {
                    int num3 = PDAT_78.FUN_2F710(num2, pos, ref normalVector3);
                    if (num3 != 0)
                    {
                        num2 = num3;
                    }
                }
                normalTile = null;
                return num2;
            }
            if (PDAT_78 != null)
            {
                num2 = PDAT_78.FUN_2F710(num, pos, ref normalVector3);
                if (num2 != 0)
                {
                    normalTile = null;
                    return num2;
                }
            }
        }
        normalVector3 = instance.terrain.FUN_1B998((uint)pos.x, (uint)pos.z);
        normalVector3 = Utilities.VectorNormal(normalVector3);
        normalTile = tileByPosition;
        return num;
    }

    public int FUN_2CFBC(Vector3Int pos, ref Vector3Int normalVector3)
    {
        GameManager instance = GameManager.instance;
        TileData tileByPosition = instance.terrain.GetTileByPosition((uint)pos.x, (uint)pos.z);
        int num = 3080192;
        num = (((tileByPosition.flags & 4) != 0) ? 3143680 : instance.terrain.FUN_1B750((uint)pos.x, (uint)pos.z));
        if (PDAT_74 != null)
        {
            int num2 = PDAT_74.FUN_2F710(num, pos, ref normalVector3);
            if (num2 != 0)
            {
                if (PDAT_78 != null)
                {
                    int num3 = PDAT_78.FUN_2F710(num2, pos, ref normalVector3);
                    if (num3 != 0)
                    {
                        num2 = num3;
                    }
                }
                return num2;
            }
            if (PDAT_78 != null)
            {
                num2 = PDAT_78.FUN_2F710(num, pos, ref normalVector3);
                if (num2 != 0)
                {
                    return num2;
                }
            }
        }
        normalVector3 = instance.terrain.FUN_1B998((uint)pos.x, (uint)pos.z);
        normalVector3 = Utilities.VectorNormal(normalVector3);
        return num;
    }

    public int FUN_2CFBC(Vector3Int pos, out TileData normalTile)
    {
        GameManager instance = GameManager.instance;
        TileData tileByPosition = instance.terrain.GetTileByPosition((uint)pos.x, (uint)pos.z);
        int num = 3080192;
        num = (((tileByPosition.flags & 4) != 0) ? 3143680 : instance.terrain.FUN_1B750((uint)pos.x, (uint)pos.z));
        normalTile = tileByPosition;
        if (PDAT_74 != null)
        {
            Vector3Int param = new Vector3Int(0, 0, 0);
            int num2 = PDAT_74.FUN_2F710(num, pos, ref param);
            if (num2 != 0)
            {
                if (PDAT_78 != null)
                {
                    int num3 = PDAT_78.FUN_2F710(num2, pos, ref param);
                    if (num3 != 0)
                    {
                        num2 = num3;
                    }
                }
                return num2;
            }
            if (PDAT_78 != null)
            {
                num2 = PDAT_78.FUN_2F710(num, pos, ref param);
                if (num2 != 0)
                {
                    return num2;
                }
            }
        }
        return num;
    }

    public int FUN_2CFBC(Vector3Int pos)
    {
        GameManager instance = GameManager.instance;
        TileData tileByPosition = instance.terrain.GetTileByPosition((uint)pos.x, (uint)pos.z);
        int num = 3080192;
        num = (((tileByPosition.flags & 4) != 0) ? 3143680 : instance.terrain.FUN_1B750((uint)pos.x, (uint)pos.z));
        if (PDAT_74 != null)
        {
            Vector3Int param = new Vector3Int(0, 0, 0);
            int num2 = PDAT_74.FUN_2F710(num, pos, ref param);
            if (num2 != 0)
            {
                if (PDAT_78 != null)
                {
                    int num3 = PDAT_78.FUN_2F710(num2, pos, ref param);
                    if (num3 != 0)
                    {
                        num2 = num3;
                    }
                }
                return num2;
            }
            if (PDAT_78 != null)
            {
                num2 = PDAT_78.FUN_2F710(num, pos, ref param);
                if (num2 != 0)
                {
                    return num2;
                }
            }
        }
        return num;
    }

    public VigObject FUN_2CCBC()
    {
        VigObject vigObject = parent;
        if (vigObject != null)
        {
            VigObject vigObject2 = child;
            if (vigObject.child2 == this)
            {
                vigObject.child2 = vigObject2;
            }
            else
            {
                vigObject.child = vigObject2;
            }
            if (vigObject2 != null)
            {
                vigObject2.parent = vigObject;
            }
            child = null;
            parent = null;
        }
        return this;
    }

    public VigObject FUN_2CA1C()
    {
        if (FUN_2C9A4() == null)
        {
            return null;
        }
        return null;
    }

    public ConfigContainer FUN_2C5F4(ushort param1)
    {
        VigConfig ini = vData.ini;
        return ini.FUN_2C534(ini.configContainers[DAT_1A].next, param1);
    }

    public ConfigContainer FUN_2C6F8(ushort param1)
    {
        VigConfig ini = vData.ini;
        return ini.FUN_2C638(ini.configContainers[DAT_1A].next, param1);
    }

    public void FUN_2C958()
    {
        FUN_2C7D0();
        VigObject vigObject = child2;
        while (vigObject != null)
        {
            vigObject.FUN_2C958();
            vigObject = vigObject.child;
        }
    }

    public void FUN_2D114(Vector3Int param1, ref VigTransform param2)
    {
        Vector3Int normalVector = default(Vector3Int);
        int y = FUN_2CFBC(param1, ref normalVector);
        param2.position.y = y;
        param2.position.x = param1.x;
        param2.position.z = param1.z;
        param2.rotation = Utilities.FUN_2A5EC(normalVector);
    }

    public int FUN_2D1DC()
    {
        int num = 0;
        int num2 = 0;
        if (vMesh != null)
        {
            num = (int)vMesh.DAT_18;
        }
        VigObject vigObject = child2;
        while (vigObject != null)
        {
            if (vigObject.type != 12)
            {
                int num3 = vigObject.FUN_2D1DC();
                int num4 = Utilities.FUN_29E84(vigObject.vTransform.position);
                num2 = num3 + num4;
                if (num3 + num4 < num)
                {
                    num2 = num;
                }
            }
            vigObject = vigObject.child;
            num = num2;
        }
        DAT_58 = num;
        return num;
    }

    public void FUN_2D368(VigTransform param1)
    {
        if ((flags & 2) == 0)
        {
            VigTransform vigTransform = Utilities.CompMatrixLV(param1, vTransform);
            vigTransform.padding = 0;
            if (param1.padding != 0 || vTransform.padding != 0)
            {
                vigTransform.padding = 1;
            }
            if ((flags & 0x10) != 0)
            {
                if ((flags & 0x400) == 0)
                {
                    if (vigTransform.padding == 0)
                    {
                        vigTransform.rotation = GameManager.instance.DAT_EE0.rotation;
                    }
                    else
                    {
                        vigTransform.rotation = Utilities.FUN_2A4A4(vigTransform.rotation);
                    }
                }
                else
                {
                    vigTransform.rotation = vTransform.rotation;
                }
            }
            if (vMesh != null)
            {
                vMesh.FUN_2D2A8(vigTransform);
            }
            if (child2 != null)
            {
                child2.FUN_2D368(vigTransform);
            }
        }
        if (child != null)
        {
            child.FUN_2D368(param1);
        }
    }

    public void FUN_2D5EC(VigTransform param1, Vector3Int param2, Vector3Int param3)
    {
        if ((flags & 2) == 0)
        {
            VigTransform vigTransform = Utilities.CompMatrixLV(param1, vTransform);
            vigTransform.padding = 0;
            if (param1.padding != 0 || vTransform.padding != 0)
            {
                vigTransform.padding = 1;
            }
            if ((flags & 0x10) != 0)
            {
                if ((flags & 0x400) == 0)
                {
                    if (vigTransform.padding == 0)
                    {
                        vigTransform.rotation.SetValue32(0, 0);
                        vigTransform.rotation.SetValue32(1, 0);
                        vigTransform.rotation.SetValue32(2, 0);
                        vigTransform.rotation.SetValue32(3, 0);
                        vigTransform.rotation.SetValue32(4, 0);
                    }
                    else
                    {
                        vigTransform.rotation = Utilities.FUN_2A4A4(vigTransform.rotation);
                    }
                }
                else
                {
                    vigTransform.rotation = vTransform.rotation;
                }
            }
            if (vMesh != null)
            {
                vMesh.FUN_2D4D4(vigTransform, param2, param3);
            }
            if (child2 != null)
            {
                child2.FUN_2D5EC(vigTransform, param2, param3);
            }
        }
        if (child != null)
        {
            child.FUN_2D5EC(param1, param2, param3);
        }
    }

    public Matrix3x3 FUN_2D884(VigTransform param1)
    {
        if ((flags & 0x1010) == 4096)
        {
            if ((flags & 0x400) == 0)
            {
                if (vTransform.padding == 0)
                {
                    param1.rotation = GameManager.instance.DAT_EE0.rotation;
                }
                else
                {
                    param1.rotation = Utilities.FUN_2A4A4(param1.rotation);
                }
            }
            else
            {
                param1.rotation = GameManager.defaultTransform.rotation;
            }
        }
        vLOD.FUN_21F70(param1);
        VigObject vigObject = child2;
        while (vigObject != null)
        {
            if ((vigObject.flags & 2) == 0 && vigObject.vLOD != null)
            {
                VigTransform param2 = Utilities.CompMatrixLV(param1, vigObject.vTransform);
                param2.padding = 0;
                if (param1.padding != 0 || vigObject.vTransform.padding != 0)
                {
                    param2.padding = 1;
                }
                param2.rotation = vigObject.FUN_2D884(param2);
            }
            vigObject = vigObject.child;
        }
        return param1.rotation;
    }

    public virtual uint OnCollision(HitDetection hit)
    {
        return 0u;
    }

    public void FUN_2E868(uint param1)
    {
        BufferedBinaryReader reader = vCollider.reader;
        int num = 0;
        short num2 = reader.ReadInt16(0);
        while (num2 != 0)
        {
            num2 = reader.ReadInt16(num);
            switch (num2)
            {
                case 1:
                    if ((reader.ReadUInt16(num + 2) & -32769) == (int)param1)
                    {
                        reader.WriteUInt16(num + 2, (ushort)(reader.ReadUInt16(num + 2) & 0x7FFF));
                    }
                    num += 28;
                    num2 = reader.ReadInt16(num);
                    break;
                case 2:
                    num = num + reader.ReadUInt16(num + 2) * 12 + 4;
                    num2 = reader.ReadInt16(num);
                    break;
            }
        }
    }

    public void FUN_2E900(uint param1)
    {
        BufferedBinaryReader reader = vCollider.reader;
        int num = 0;
        short num2 = reader.ReadInt16(0);
        while (num2 != 0)
        {
            num2 = reader.ReadInt16(num);
            switch (num2)
            {
                case 1:
                    if ((reader.ReadUInt16(num + 2) & -32769) == (int)param1)
                    {
                        reader.WriteUInt16(num + 2, (ushort)(reader.ReadUInt16(num + 2) | 0x8000));
                    }
                    num += 28;
                    num2 = reader.ReadInt16(num);
                    break;
                case 2:
                    num = num + reader.ReadUInt16(num + 2) * 12 + 4;
                    num2 = reader.ReadInt16(num);
                    break;
            }
        }
    }

    public uint FUN_2EC7C()
    {
        VigObject vigObject = child2;
        uint num = 0u;
        while (vigObject != null)
        {
            uint num2 = vigObject.FUN_2EC7C();
            vigObject = vigObject.child;
            num |= num2;
        }
        if (num != 0)
        {
            flags |= 2048u;
        }
        return (uint)((int)num | ((vCollider != null) ? 1 : 0));
    }

    public int FUN_2FBC8(ushort param1)
    {
        if (vAnim != null)
        {
            if ((uint)(ushort)(param1 - DAT_4A) < (uint)vAnim.ReadUInt16(0))
            {
                return 0;
            }
            int num = -1;
            int num2 = 0;
            VigMesh vMesh2 = vMesh;
            bool flag = false;
            do
            {
                uint num3 = (uint)vAnim.ReadInt16(2);
                int num4 = 4;
                if ((int)num3 < 0)
                {
                    DAT_4A += vAnim.ReadUInt16(0);
                    vAnim.Seek((int)num3, SeekOrigin.Current);
                    VigObject vigObject = this;
                    int num5;
                    if (!GetType().IsSubclassOf(typeof(VigObject)))
                    {
                        while (!(vigObject.parent == null))
                        {
                            vigObject = Utilities.FUN_2CD78(vigObject);
                            if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
                            {
                                break;
                            }
                        }
                        num5 = 0;
                        if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
                        {
                            num5 = (int)vigObject.UpdateW(5, this);
                        }
                    }
                    else
                    {
                        num5 = (int)vigObject.UpdateW(5, this);
                    }
                    if (num5 < 0)
                    {
                        return num5;
                    }
                    continue;
                }
                if ((num3 & 1) != 0)
                {
                    short z = vAnim.ReadInt16(8);
                    vr.x = vAnim.ReadInt16(4);
                    vr.y = vAnim.ReadInt16(6);
                    vr.z = z;
                    num4 = 12;
                    flag = true;
                }
                if ((num3 & 2) != 0)
                {
                    screen.x = vAnim.ReadInt32(num4);
                    screen.y = vAnim.ReadInt32(num4 + 4);
                    screen.z = vAnim.ReadInt32(num4 + 8);
                    num4 += 12;
                    flag = true;
                }
                if ((num3 & 8) != 0)
                {
                    screen.x += vAnim.ReadInt16(num4);
                    flag = true;
                    screen.y += vAnim.ReadInt16(num4 + 2);
                    num2 = num4 + 4;
                    num4 += 8;
                    screen.z += vAnim.ReadInt16(num2);
                }
                if ((num3 & 0x10) != 0)
                {
                    ushort num6;
                    do
                    {
                        num6 = vAnim.ReadUInt16(num4);
                        ushort num7 = vAnim.ReadUInt16(num4 + 2);
                        num4 += 4;
                        vData.FUN_1F288(num7, vMesh);
                        vMesh.DAT_1C[num6 & 0x7FFF] = num7;
                    }
                    while (-1 < num6 << 16);
                }
                num2 = num4;
                if ((num3 & 0x20) != 0)
                {
                    num2 = num4 + 8;
                    flag = true;
                    num = num4;
                }
                if ((num3 & 0x40) != 0)
                {
                    vMesh.SetVertices(vAnim.GetBuffer(), (int)vAnim.Position + num2 + 4);
                    num2 += vAnim.ReadInt32(num2) * 8 + 4;
                }
                vAnim.Seek(num2, SeekOrigin.Current);
            }
            while ((uint)vAnim.ReadUInt16(0) <= (uint)(ushort)(param1 - DAT_4A));
            if (!flag)
            {
                return 0;
            }
            ApplyTransformation();
            if (num != -1)
            {
                num -= num2;
                Utilities.FUN_245AC(ref vTransform.rotation, new Vector3Int(vAnim.ReadInt16(num), vAnim.ReadInt16(num + 2), vAnim.ReadInt16(num + 4)));
                vTransform.padding = vAnim.ReadInt16(num);
            }
        }
        return 0;
    }

    public bool FUN_3066C()
    {
        ApplyTransformation();
        int num = (int)(GetType().IsSubclassOf(typeof(VigObject)) ? UpdateW(1, 0) : 0);
        bool result = false;
        if (-1 < num)
        {
            if ((flags & 8) != 0)
            {
                if (vShadow == null)
                {
                    FUN_4C98C();
                }
                FUN_4C4F4();
            }
            FUN_305FC();
            result = true;
        }
        return result;
    }

    public VigObject FUN_306FC()
    {
        if (GetType().IsSubclassOf(typeof(VigObject)))
        {
            UpdateW(4, 0);
        }
        if ((flags & 0x80) != 0)
        {
            GameManager.instance.FUN_300B8(GameManager.instance.DAT_1088, this);
        }
        if ((flags & 4) != 0)
        {
            GameManager.instance.FUN_300B8(GameManager.instance.DAT_10A8, this);
        }
        if ((flags & 1) != 0)
        {
            GameManager.instance.FUN_300B8(GameManager.instance.DAT_1110, this);
        }
        return this;
    }

    public void FUN_30B78()
    {
        flags |= 128u;
        GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, this);
    }

    public bool FUN_30BA8()
    {
        if ((flags & 0x80) == 0)
        {
            return false;
        }
        flags &= 4294967167u;
        return GameManager.instance.FUN_300B8(GameManager.instance.DAT_1088, this);
    }

    public void FUN_30BF0()
    {
        flags |= 4u;
        GameManager.instance.FUN_30080(GameManager.instance.DAT_10A8, this);
    }

    public bool FUN_30C20()
    {
        if ((flags & 4) == 0)
        {
            return false;
        }
        flags &= 4294967291u;
        return GameManager.instance.FUN_300B8(GameManager.instance.DAT_10A8, this);
    }

    public bool FUN_30C68()
    {
        if ((flags & 1) == 0)
        {
            return false;
        }
        flags &= 4294967294u;
        return GameManager.instance.FUN_300B8(GameManager.instance.DAT_1110, this);
    }

    public virtual VigObject FUN_31DDC()
    {
        VigObject vigObject = Utilities.FUN_31D30(GetType(), vData, DAT_1A, (flags & 4) << 1);
        ushort num = maxHalfHealth;
        ushort num2 = maxFullHealth;
        vigObject.flags |= flags;
        vigObject.id = id;
        vigObject.tags = tags;
        vigObject.screen = screen;
        vigObject.vr = vr;
        vigObject.DAT_19 = DAT_19;
        if (num != 0 || num2 != 0)
        {
            VigObject vigObject2 = vigObject.child2;
            vigObject.maxHalfHealth = num;
            vigObject.maxFullHealth = num2;
            while (vigObject2 != null)
            {
                vigObject2.maxHalfHealth = num;
                vigObject2 = vigObject2.child;
            }
        }
        vigObject.FUN_2D1DC();
        vigObject.FUN_2C958();
        return vigObject;
    }

    public bool FUN_32B90(uint param1)
    {
        if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
        {
            int num = GameManager.instance.networkObjs.IndexOf(this);
            if (DiscordController.IsOwner())
            {
                if (num != -1 && (flags & 0x8000) == 0 && maxHalfHealth < param1)
                {
                    ClientSend.ObjectDestroyed(num);
                }
            }
            else if (num != -1)
            {
                return false;
            }
        }
        if ((flags & 0x8000) == 0)
        {
            if (maxHalfHealth < param1)
            {
                maxHalfHealth = maxFullHealth;
                if ((flags & 0x40000) == 0)
                {
                    if (FUN_4DC94())
                    {
                        LevelManager.instance.level.UpdateW(this, 18, 0);
                        return true;
                    }
                }
                else
                {
                    int num2 = (int)GameManager.FUN_2AC5C();
                    Vector3Int param2 = default(Vector3Int);
                    param2.x = (num2 * 3051 >> 15) - 1525;
                    param2.y = -4577;
                    num2 = (int)GameManager.FUN_2AC5C();
                    param2.z = (num2 * 3051 >> 15) - 1525;
                    LevelManager.instance.FUN_4AA24((ushort)GameManager.DAT_63FA4[GameManager.instance.DAT_1004], vTransform.position, param2).flags |= 33816576u;
                    flags &= 4294705151u;
                }
            }
            else
            {
                maxHalfHealth -= (ushort)param1;
            }
        }
        return false;
    }

    public void FUN_2B834(HitDetection hit)
    {
        ulong num = (ulong)Utilities.FUN_2AD3C(new Vector3Int(physics1.X, physics1.Y, physics1.Z), hit.normal1);
        uint num2 = ((uint)num >> 15) | ((uint)(num >> 32) << 17);
        if ((int)num2 < 0)
        {
            Vector3Int v = Utilities.FUN_24210(vTransform.rotation, hit.normal1);
            uint num3 = (uint)(-hit.distance);
            uint num4 = (uint)((int)num3 + (int)num2 * -2);
            int num5 = ((int)num3 >> 31) - ((int)(num2 * 2) >> 31) - ((num3 < num2 * 2) ? 1 : 0);
            v.x = ((int)((uint)((long)(uint)v.x * (long)num4) >> 12) | (((int)((ulong)((long)(uint)v.x * (long)num4) >> 32) + v.x * num5 + (int)num4 * (v.x >> 31)) * 1048576));
            v.y = ((int)((uint)((long)(uint)v.y * (long)num4) >> 12) | (((int)((ulong)((long)(uint)v.y * (long)num4) >> 32) + v.y * num5 + (int)num4 * (v.y >> 31)) * 1048576));
            v.z = ((int)((uint)((long)(uint)v.z * (long)num4) >> 12) | (((int)((ulong)((long)(uint)v.z * (long)num4) >> 32) + v.z * num5 + (int)num4 * (v.z >> 31)) * 1048576));
            FUN_2B1FC(v, hit.position);
        }
    }

    public void FUN_2B4F8(BufferedBinaryReader reader)
    {
        uint num = 0u;
        Vector3Int v = new Vector3Int(0, 11520, 0);
        Vector3Int vector3Int = new Vector3Int(0, 0, 0);
        Vector3Int vector3Int2 = default(Vector3Int);
        uint num2 = 0u;
        do
        {
            if (num2 == 0)
            {
                vector3Int2.x = reader.ReadInt32(12);
            }
            else
            {
                vector3Int2.x = reader.ReadInt32(0);
            }
            if ((num & 2) == 0)
            {
                vector3Int2.y = reader.ReadInt32(16);
            }
            else
            {
                vector3Int2.y = reader.ReadInt32(4);
            }
            if ((num & 4) == 0)
            {
                vector3Int2.z = reader.ReadInt32(20);
            }
            else
            {
                vector3Int2.z = reader.ReadInt32(8);
            }
            Vector3Int vector3Int3 = new Vector3Int(0, 0, 0);
            vector3Int2 = Utilities.FUN_24148(vTransform, vector3Int2);
            Vector3Int normalVector = default(Vector3Int);
            int num3 = FUN_2CFBC(vector3Int2, ref normalVector);
            if (0 < vector3Int2.y - num3)
            {
                vector3Int3.x = -physics1.X;
                if (0 < physics1.X)
                {
                    vector3Int3.x += 3;
                }
                vector3Int3.x >>= 2;
                if (2880 < vector3Int3.x)
                {
                    vector3Int3.x = 2880;
                }
                if (vector3Int3.x < -2880)
                {
                    vector3Int3.x = -2880;
                }
                vector3Int3.z = -physics1.Z;
                if (0 < physics1.Z)
                {
                    vector3Int3.z += 3;
                }
                vector3Int3.z >>= 2;
                if (2880 < vector3Int3.z)
                {
                    vector3Int3.z = 2880;
                }
                vector3Int3.y = -(vector3Int2.y - num3);
                if (vector3Int3.z < -2880)
                {
                    vector3Int3.z = -2880;
                }
                if (0 < physics1.Y)
                {
                    vector3Int3.y -= physics1.Y >> 3;
                }
                int num4 = vector3Int2.x - vTransform.position.x >> 4;
                int num5 = vector3Int2.y - vTransform.position.y >> 4;
                int num6 = vector3Int2.z - vTransform.position.z >> 4;
                Coprocessor.rotationMatrix.rt11 = (short)num4;
                Coprocessor.rotationMatrix.rt12 = (short)(num4 >> 16);
                Coprocessor.rotationMatrix.rt22 = (short)num5;
                Coprocessor.rotationMatrix.rt23 = (short)(num5 >> 16);
                Coprocessor.rotationMatrix.rt33 = (short)num6;
                Coprocessor.accumulator.ir1 = (short)(vector3Int3.x >> 3);
                Coprocessor.accumulator.ir2 = (short)(vector3Int3.y >> 3);
                Coprocessor.accumulator.ir3 = (short)(vector3Int3.z >> 3);
                Coprocessor.ExecuteOP(12, lm: false);
                v.x += vector3Int3.x;
                v.y += vector3Int3.y;
                v.z += vector3Int3.z;
                num3 = Coprocessor.mathsAccumulator.mac1;
                vector3Int.x += num3 * 2;
                num3 = Coprocessor.mathsAccumulator.mac2;
                vector3Int.y += num3 * 2;
                num3 = Coprocessor.mathsAccumulator.mac3;
                vector3Int.z += num3 * 2;
            }
            num++;
            num2 = (num & 1);
        }
        while ((int)num < 8);
        vector3Int = Utilities.FUN_2426C(vTransform.rotation, new Matrix2x4(vector3Int.x, vector3Int.y, vector3Int.z, 0));
        FUN_2AFF8(v, vector3Int);
        physics2.X = physics2.X * 3968 >> 12;
        physics2.Y = physics2.Y * 3968 >> 12;
        physics2.Z = physics2.Z * 3968 >> 12;
    }

    public uint FUN_33798(HitDetection param1, int param2)
    {
        uint result;
        if ((flags & 0x4000000) == 0)
        {
            HitDetection hitDetection = new HitDetection(null);
            GameManager.instance.FUN_2FB70(this, param1, hitDetection);
            Vector3Int vector3Int = Utilities.FUN_24238(vTransform.rotation, hitDetection.normal1);
            result = 0u;
            if (2048 < vector3Int.z)
            {
                int num = vTransform.rotation.V02 * param2;
                Vehicle vehicle = (Vehicle)param1.self;
                if (num < 0)
                {
                    num += 31;
                }
                Vector3Int v = default(Vector3Int);
                v.x = vehicle.physics1.X - (num >> 5);
                v.y = vehicle.physics1.Y;
                param2 = vTransform.rotation.V22 * param2;
                if (param2 < 0)
                {
                    param2 += 31;
                }
                v.z = vehicle.physics1.Z - (param2 >> 5);
                long num2 = Utilities.FUN_2AD3C(v, hitDetection.normal1);
                uint num3 = (uint)((int)((uint)num2 >> 11) | ((int)(num2 >> 32) << 21));
                result = 0u;
                if ((int)num3 < 0)
                {
                    uint num4 = (uint)(hitDetection.normal2.x << 16 >> 16);
                    result = (uint)(-((int)num3 + hitDetection.distance));
                    num = -((result != 0) ? 1 : 0) - ((int)num3 + hitDetection.distance >> 31);
                    long num5 = (long)num4 * (long)result;
                    Vector3Int v2 = default(Vector3Int);
                    v2.x = ((int)((uint)num5 >> 12) | (((int)((ulong)num5 >> 32) + (int)num4 * num + (int)result * (hitDetection.normal2.x << 16 >> 31)) * 1048576));
                    num4 = (uint)(hitDetection.normal2.y << 16 >> 16);
                    num5 = (long)num4 * (long)result;
                    v2.y = ((int)((uint)num5 >> 12) | (((int)((ulong)num5 >> 32) + (int)num4 * num + (int)result * (hitDetection.normal2.y << 16 >> 31)) * 1048576));
                    num4 = (uint)(hitDetection.normal2.z << 16 >> 16);
                    num5 = (long)num4 * (long)result;
                    v2.z = ((int)((uint)num5 >> 12) | (((int)((ulong)num5 >> 32) + (int)num4 * num + (int)result * (hitDetection.normal2.z << 16 >> 31)) * 1048576));
                    vehicle.FUN_2B1FC(v2, hitDetection.position);
                    num = ((vehicle.id >= 0) ? ((int)(num3 + 32767) >> 15) : ((int)(num3 + 8191) >> 13));
                    vehicle.FUN_3A020(num, hitDetection.position, param3: true);
                    result = num3;
                }
            }
        }
        else
        {
            result = 0u;
        }
        return result;
    }

    public void FUN_33A28(uint param1)
    {
        short[] array = new short[4];
        BufferedBinaryReader reader = vCollider.reader;
        int num = screen.x + reader.ReadInt32(4);
        if (num < 0)
        {
            num += 65535;
        }
        array[0] = (short)(num >> 16);
        num = screen.z + reader.ReadInt32(12);
        if (num < 0)
        {
            num += 65535;
        }
        array[1] = (short)(num >> 16);
        num = screen.x + reader.ReadInt32(16);
        int num2 = num + 65535;
        if (num2 < 0)
        {
            num2 = num + 131070;
        }
        array[2] = (short)((num2 >> 16) - array[0]);
        num = screen.z + reader.ReadInt32(24);
        int num3 = num + 65535;
        if (num3 < 0)
        {
            num3 = num + 131070;
        }
        array[3] = (short)((num3 >> 16) - array[1]);
        LevelManager.instance.FUN_359CC(array, param1);
    }

    public void FUN_3A368()
    {
        VigObject vigObject = Utilities.FUN_2CD78(this);
        if (!(vigObject != null))
        {
            return;
        }
        int num = 0;
        Vehicle vehicle = (Vehicle)vigObject;
        while (!(vehicle.weapons[num] == this))
        {
            num++;
            if (num >= 3)
            {
                return;
            }
        }
        vehicle.FUN_3A280((uint)num);
    }

    public void FUN_3AC4C()
    {
        int param = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E188(param, vData.sndList, 1);
    }

    public void FUN_3BFC0()
    {
        int x = physics1.X;
        int num = -x;
        physics1.X = num;
        physics1.Z = -physics1.Z;
        physics1.Y = -physics1.Y;
        if (0 < x)
        {
            num += 63;
        }
        x = physics1.Y;
        vTransform.position.x += num >> 6;
        if (x < 0)
        {
            x += 63;
        }
        num = physics1.Z;
        vTransform.position.y += x >> 6;
        if (num < 0)
        {
            num += 63;
        }
        vTransform.position.z += num >> 6;
        TileData tileByPosition = VigTerrain.instance.GetTileByPosition((uint)vTransform.position.x, (uint)vTransform.position.z);
        if (tileByPosition.DAT_10[3] == 7)
        {
            uint num2 = (uint)vTransform.position.x;
            uint num3 = (uint)vTransform.position.z;
            Vector3Int n = new Vector3Int((int)(0 - num2), 0, (int)(0 - num3));
            n = Utilities.VectorNormal(n);
            do
            {
                num2 = (uint)((int)num2 + n.x);
                num3 = (uint)((int)num3 + n.z);
                tileByPosition = VigTerrain.instance.GetTileByPosition(num2, num3);
            }
            while (tileByPosition.DAT_10[3] == 7);
            vTransform.position.x = ((int)num2 & -65536) + 32768;
            vTransform.position.z = ((int)num3 & -65536) + 32768;
        }
    }

    public int FUN_4205C()
    {
        int result = 0;
        if (((GameManager.instance.DAT_28 - DAT_19) & 3) == 0)
        {
            Vehicle vehicle = (Vehicle)Utilities.FUN_2CD78(this);
            int num = 0;
            do
            {
                VigObject vigObject = vehicle.weapons[num];
                if (vigObject != null && vigObject.tags == -tags && (!vigObject.GetType().IsSubclassOf(typeof(VigObject)) || vigObject.UpdateW(16, this) == 0))
                {
                    ushort num2 = vehicle.weapons[num].maxHalfHealth;
                    if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                    {
                        if (vehicle.weapons[num].tags == 7)
                        {
                            if (num2 < GameManager.specialLimit[(int)vehicle.vehicle])
                            {
                                vehicle.weapons[num].maxHalfHealth++;
                            }
                        }
                        else if (num2 < 99)
                        {
                            vehicle.weapons[num].maxHalfHealth++;
                        }
                    }
                    else if (num2 < 99)
                    {
                        vehicle.weapons[num].maxHalfHealth++;
                    }
                }
                num++;
            }
            while (num < 3);
            short num3 = (short)(maxHalfHealth - 1);
            maxHalfHealth = (ushort)num3;
            if (num3 == 0)
            {
                result = GameManager.instance.FUN_1DD9C();
                Vector3Int param = GameManager.instance.FUN_2CE50(this);
                GameManager.instance.FUN_1E628(result, GameManager.instance.DAT_C2C, 45, param);
                VigObject param2 = FUN_2CCBC();
                GameManager.instance.FUN_307CC(param2);
                result = -1;
            }
            else
            {
                result = 0;
            }
        }
        return result;
    }

    private int FUN_4219C(ConfigContainer param1)
    {
        int num = param1.v3_1.x - screen.x;
        int num2 = param1.v3_1.y - screen.y;
        int num3 = param1.v3_1.z - screen.z;
        int num4;
        int num5;
        if (-1 < tags)
        {
            num4 = num;
            if (num < 0)
            {
                num4 = -num;
            }
            num5 = num2;
            if (num2 < 0)
            {
                num5 = -num2;
            }
            if (num5 < num4)
            {
                num5 = num4;
            }
            num4 = num3;
            if (num3 < 0)
            {
                num4 = -num3;
            }
            if (num4 < num5)
            {
                num4 = num5;
            }
            if (num4 < 2049)
            {
                return 1;
            }
        }
        num4 = num;
        if (num < 0)
        {
            num4 = num + 31;
        }
        num5 = num3;
        if (num3 < 0)
        {
            num5 = num3 + 7;
        }
        screen.x += (num4 >> 5) + (num5 >> 3);
        if (num2 < 0)
        {
            num2 += 15;
        }
        screen.y += num2 >> 4;
        if (num3 < 0)
        {
            num3 += 31;
        }
        if (num < 0)
        {
            num += 7;
        }
        screen.z += (num3 >> 5) - (num >> 3);
        vTransform.position = screen;
        int result = 0;
        if (tags < 0)
        {
            result = FUN_4205C();
        }
        return result;
    }

    public int FUN_42330(int param1)
    {
        int num = 1;
        if ((flags & 0x1000000) != 0)
        {
            num = FUN_4219C(CCDAT_74);
            if (param1 < 0 || 0 < num)
            {
                int param2 = GameManager.instance.FUN_1DD9C();
                Vector3Int param3 = GameManager.instance.FUN_2CE50(this);
                GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 49, param3);
                ConfigContainer cCDAT_ = CCDAT_74;
                flags &= 4278190079u;
                screen = cCDAT_.v3_1;
                vTransform.position = screen;
                FUN_30BA8();
                num = 0;
            }
        }
        return num;
    }

    public int FUN_42330(VigObject param1)
    {
        int num = 1;
        if ((flags & 0x1000000) != 0)
        {
            num = FUN_4219C(CCDAT_74);
            if (param1 != null || 0 < num)
            {
                int param2 = GameManager.instance.FUN_1DD9C();
                Vector3Int param3 = GameManager.instance.FUN_2CE50(this);
                GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 49, param3);
                ConfigContainer cCDAT_ = CCDAT_74;
                flags &= 4278190079u;
                screen = cCDAT_.v3_1;
                vTransform.position = screen;
                FUN_30BA8();
                num = 0;
            }
        }
        return num;
    }

    public uint FUN_42638(HitDetection param1, short param2, int param3, int param4 = 11)
    {
        if (param1 == null)
        {
            goto IL_0177;
        }
        if (param1.object2.type == 3)
        {
            return 0u;
        }
        VigObject self = param1.self;
        int num = param3 << 16;
        if (self.type == 8 && self.id > 0 && id > 0)
        {
            return 0u;
        }
        if (self.type == 2)
        {
            Vehicle vehicle = (Vehicle)self;
            int num2 = (maxHalfHealth << param4) / vehicle.DAT_A6;
            num = physics1.Z * num2;
            Vector3Int v = default(Vector3Int);
            if (num < -524288)
            {
                v.x = -524288;
            }
            else
            {
                v.x = 524288;
                if (num < 524289)
                {
                    v.x = num;
                }
            }
            num = physics1.W * num2;
            v.y = -524288;
            if (-524289 < num)
            {
                v.y = 524288;
                if (num < 524289)
                {
                    v.y = num;
                }
            }
            num = physics2.X * num2;
            v.z = -524288;
            if (-524289 < num)
            {
                v.z = 524288;
                if (num < 524289)
                {
                    v.z = num;
                }
            }
            vehicle.FUN_2B370(v, vTransform.position);
            if (vehicle.id < 0)
            {
                GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 2, 128);
            }
            num = param3 << 16;
            if (vehicle.shield != 0)
            {
                param3 = -1;
                goto IL_0177;
            }
        }
        goto IL_017c;
    IL_0177:
        num = param3 << 16;
        goto IL_017c;
    IL_017c:
        if (-1 < num >> 16)
        {
            int param5 = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E628(param5, GameManager.instance.DAT_C2C, num >> 16, vTransform.position);
        }
        LevelManager.instance.FUN_4DE54(vTransform.position, (ushort)param2);
        LevelManager.instance.level.UpdateW(this, 18, 0);
        GameManager.instance.FUN_309A0(this);
        return uint.MaxValue;
    }

    public ConfigContainer FUN_4AE5C(int param1)
    {
        uint num = (uint)((param1 != 7) ? ((param1 - 32752) & 0xFFFF) : 32799);
        return FUN_2C5F4((ushort)num);
    }

    public void FUN_4BAFC(Vector3Int position)
    {
        position.x -= screen.x;
        position.z -= screen.z;
        position.y -= screen.y;
        vr.y = Utilities.Ratan2(position.x, position.z);
        int num = Utilities.LeadingZeros(position.x);
        int num2 = Utilities.LeadingZeros(position.z);
        if (num < num2)
        {
            num2 = num;
        }
        if (num2 < 18)
        {
            uint num3 = (uint)(18 - num2);
            position.x >>= (int)(num3 & 0x1F);
            position.y >>= (int)(num3 & 0x1F);
            position.z >>= (int)(num3 & 0x1F);
        }
        int x = (int)Utilities.SquareRoot(position.x * position.x + position.z * position.z);
        vr.x = Utilities.Ratan2(-position.y, x);
    }

    public void FUN_4C4F4()
    {
        VigTerrain terrain = GameManager.instance.terrain;
        Vector3Int param = default(Vector3Int);
        if (!GameManager.instance.terrain)
        {
            Debug.Log("No se encontro un componente Terrain");
        }
        else
        {

        }
        int num = ((terrain.GetTileByPosition((uint)vTransform.position.x, (uint)vTransform.position.z).flags & 4) != 0) ? 3143680 : terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
        vShadow.vTransform.position.x = vTransform.position.x;
        vShadow.vTransform.position.z = vTransform.position.z;
        int num2;
        if (PDAT_74 != null)
        {
            num2 = PDAT_74.FUN_2F710(num, vTransform.position, ref param);
            if (num2 != 0)
            {
                goto IL_0114;
            }
            if (!(PDAT_78 == null))
            {
                num2 = PDAT_78.FUN_2F710(num, vTransform.position, ref param);
                if (num2 != 0)
                {
                    goto IL_0114;
                }
            }
        }
        vShadow.gameObject.layer = 7;
        vShadow.vTransform.position.y = num;
        param = terrain.FUN_1BB50(vTransform.position.x, vTransform.position.z);
        goto IL_018c;
    IL_0114:
        vShadow.gameObject.layer = 0;
        vShadow.vTransform.position.y = num2;
        goto IL_018c;
    IL_018c:
        if ((vShadow.vMesh.DAT_00 & 8) == 0)
        {
            Matrix3x3 m = default(Matrix3x3);
            m.V00 = 4096;
            m.V01 = 0;
            m.V02 = 0;
            m.V11 = 0;
            m.V20 = 0;
            m.V21 = 0;
            m.V22 = 4096;
            if (param.y == 0)
            {
                m.V10 = (short)(param.x * -16);
            }
            else
            {
                m.V10 = (short)(param.x * -4096 / param.y);
            }
            if (param.y == 0)
            {
                m.V12 = (short)(param.z * -16);
            }
            else
            {
                m.V12 = (short)(param.z * -4096 / param.y);
            }
            Vector3Int v = default(Vector3Int);
            v.x = vShadow.DAT_24;
            if (vTransform.rotation.V11 < 1)
            {
                v.x = -v.x;
            }
            v.y = 0;
            v.z = vShadow.DAT_28;
            Matrix3x3 mout = default(Matrix3x3);
            Utilities.FUN_2449C(vTransform.rotation, v, ref mout);
            vShadow.vTransform.rotation = Utilities.FUN_247C4(m, mout);
            vShadow.eulerAngles = vShadow.vTransform.rotation.Matrix2Quaternion.eulerAngles;
            vShadow.eulerAngles = new Vector3(vShadow.eulerAngles.x, base.transform.eulerAngles.y, vShadow.eulerAngles.z);
        }
        else
        {
            num = vShadow.DAT_24;
            vShadow.vTransform.rotation.V21 = 0;
            vShadow.vTransform.rotation.V20 = 0;
            vShadow.vTransform.rotation.V11 = 0;
            vShadow.vTransform.rotation.V02 = 0;
            vShadow.vTransform.rotation.V01 = 0;
            vShadow.vTransform.rotation.V22 = (short)num;
            vShadow.vTransform.rotation.V00 = (short)num;
            vShadow.vTransform.rotation.V10 = (short)(-param.x * num / param.y);
            vShadow.vTransform.rotation.V12 = (short)(-param.z * num / param.y);
        }
    }

    public void FUN_4C98C()
    {
        GameObject gameObject = new GameObject();
        VigMesh param = GameManager.instance.levelManager.xobfList[18].FUN_2CB74(gameObject, 92u, init: true);
        FUN_4C7E0(param, gameObject); //Llamada Buffer VigCollision
    }

    public void FUN_4C9C8()
    {
        GameObject gameObject = new GameObject();
        VigMesh vigMesh = GameManager.instance.levelManager.xobfList[18].FUN_2CB74(gameObject, 93u, init: true);
        vigMesh.DAT_00 |= 8;
        FUN_4C7E0(vigMesh, gameObject);
    }

    public void FUN_4D8A8(XOBF_DB param1, ushort param2, VigObject param3, bool param4 = false)
    {
        if ((flags & 4) != 0)
        {
            FUN_30C20();
        }
        GameManager.instance.FUN_1FEB8(vMesh);
        GameManager.instance.FUN_307CC(child2);
        if (vLOD != null)
        {
            if (vLOD != vMesh)
            {
                GameManager.instance.FUN_1FEB8(vLOD);
            }
            vLOD.ClearMeshData();
            MeshFilter component = GetComponent<MeshFilter>();
            MeshRenderer component2 = GetComponent<MeshRenderer>();
            if (component != null)
            {
                UnityEngine.Object.DestroyImmediate(component, allowDestroyingAssets: false);
            }
            if (component2 != null)
            {
                UnityEngine.Object.DestroyImmediate(component2, allowDestroyingAssets: false);
            }
            vLOD = null;
            DAT_6C = 0;
        }
        ConfigContainer configContainer;
        ushort num;
        if (param4)
        {
            num = (ushort)(param2 - 1);
            List<ConfigContainer> configContainers;
            ushort num2;
            do
            {
                configContainers = param1.ini.configContainers;
                num2 = num;
                num = (ushort)(num2 - 1);
            }
            while (configContainers[num2].next != ushort.MaxValue);
            num = (ushort)(num + 2);
            screen = Vector3Int.zero;
            vr = Vector3Int.zero;
            ApplyTransformation();
            do
            {
                configContainer = param1.ini.configContainers[num];
                VigTransform m = Utilities.FUN_2C77C(configContainer);
                vTransform = Utilities.CompMatrixLV(vTransform, m);
                screen = vTransform.position;
                num = param1.ini.configContainers[num].next;
            }
            while (num != param2 + 1);
        }
        else
        {
            configContainer = param1.ini.configContainers[param2];
            VigTransform m = Utilities.FUN_2C77C(configContainer);
            vTransform = Utilities.CompMatrixLV(vTransform, m);
            screen = vTransform.position;
        }
        if ((configContainer.flag & 0x7FF) == 2047)
        {
            if (vMesh != null)
            {
                vMesh.ClearMeshData();
                MeshFilter component3 = GetComponent<MeshFilter>();
                MeshRenderer component4 = GetComponent<MeshRenderer>();
                if (component3 != null)
                {
                    UnityEngine.Object.DestroyImmediate(component3, allowDestroyingAssets: false);
                }
                if (component4 != null)
                {
                    UnityEngine.Object.DestroyImmediate(component4, allowDestroyingAssets: false);
                }
            }
            vMesh = null;
        }
        else
        {
            if (vMesh != null)
            {
                vMesh.ClearMeshData();
                MeshFilter component5 = GetComponent<MeshFilter>();
                MeshRenderer component6 = GetComponent<MeshRenderer>();
                if (component5 != null)
                {
                    UnityEngine.Object.DestroyImmediate(component5, allowDestroyingAssets: false);
                }
                if (component6 != null)
                {
                    UnityEngine.Object.DestroyImmediate(component6, allowDestroyingAssets: false);
                }
            }
            VigMesh vigMesh = vMesh = param1.FUN_1FD18(base.gameObject, (uint)(configContainer.flag & 0x7FF), init: true);
        }
        vAnim = null;
        DAT_1A = (short)param2;
        child2 = param3;
        if (param3 != null)
        {
            param3.parent = this;
            Utilities.ParentChildren(this, this);
        }
        if (configContainer.colliderID < 0)
        {
            vCollider = null;
        }
        else
        {
            vCollider = new VigCollider(param1.cbbList[configContainer.colliderID].buffer);
        }
        if (FUN_2EC7C() == 0)
        {
            flags |= 32u;
        }
        num = GameManager.instance.timer;
        bool flag = false;
        if (param3 != null)
        {
            do
            {
                if (param3.vAnim != null)
                {
                    param3.DAT_4A = num;
                    flag = true;
                }
                param3 = param3.child;
            }
            while (param3 != null);
        }
        if (flag)
        {
            FUN_30BF0();
        }
        flags &= 4294934527u;
        FUN_2D1DC();
        if (GetType().IsSubclassOf(typeof(VigObject)))
        {
            UpdateW(9, 1);
        }
    }

    public void FUN_4DB00(XOBF_DB param1, ushort param2)
    {
        if (GetType().IsSubclassOf(typeof(VigObject)))
        {
            UpdateW(9, 0);
        }
        ConfigContainer configContainer = param1.ini.configContainers[param2];
        VigTransform param3 = GameManager.instance.FUN_2CEAC(this, configContainer);
        VigObject param4 = param1.FUN_4D498(configContainer.next, param3, id);
        if (configContainer.objID == 43690 || configContainer.objID == 0)
        {
            FUN_4D8A8(param1, param2, param4);
            return;
        }
        VigObject vigObject = new GameObject().AddComponent<Delay>();
        vigObject.vData = param1;
        vigObject.DAT_1A = (short)param2;
        vigObject.PDAT_74 = this;
        vigObject.child2 = param4;
        DAT_1A = (short)param2;
        flags |= 32768u;
        GameManager.instance.FUN_30CB0(vigObject, configContainer.objID);
    }

    public uint FUN_4DC20()
    {
        VigConfig ini = vData.ini;
        ushort num = ini.configContainers[DAT_1A].next;
        uint num2;
        while (true)
        {
            num2 = num;
            if (num2 == 65535)
            {
                return 0u;
            }
            ConfigContainer configContainer = ini.configContainers[(int)num2];
            if ((uint)configContainer.flag >> 12 == 15)
            {
                break;
            }
            num = configContainer.previous;
        }
        return num2;
    }

    public uint FindConfigParent()
    {
        VigConfig ini = vData.ini;
        ushort num = (ushort)DAT_1A;
        uint result = num;
        for (int i = 0; i < ini.configContainers.Count; i++)
        {
            if (ini.configContainers[i].next == num)
            {
                result = (uint)i;
                break;
            }
        }
        return result;
    }

    public bool FUN_4DC94()
    {
        uint num = FUN_4DC20();
        if (num != 0)
        {
            FUN_4DB00(vData, (ushort)num);
        }
        return num != 0;
    }

    public int FUN_4DCD8()
    {
        int num = (DAT_1A << 3) - DAT_1A << 2;
        int num2 = vData.ini.configContainers[num / 28].next;
        int num3 = 0;
        while (num2 != 65535)
        {
            num = (num2 << 3) - num2 << 2;
            if (vData.ini.configContainers[num / 28].flag >> 12 == 15)
            {
                num2 = vData.ini.configContainers[num / 28].next;
                num3++;
            }
            else
            {
                num2 = vData.ini.configContainers[num / 28].previous;
            }
        }
        return num3;
    }

    public Throwaway FUN_4ECA0(bool param1 = false)
    {
        VigObject obj = Utilities.FUN_2CD78(this);
        VigTransform vigTransform = GameManager.instance.FUN_2CDF4(obj);
        FUN_306FC();
        FUN_2CCBC();
        type = 8;
        PDAT_78 = null;
        IDAT_78 = 0;
        PDAT_74 = null;
        CCDAT_74 = null;
        IDAT_74 = 0;
        flags = (uint)(((int)flags & -16385) | 0x80);
        Throwaway throwaway = Utilities.FUN_52188(this, typeof(Throwaway)) as Throwaway;
        throwaway.state = _THROWAWAY_TYPE.Unspawnable;
        if (throwaway.child2 != null)
        {
            throwaway.child2.parent = throwaway;
        }
        int num = throwaway.vTransform.position.x;
        if (num < 0)
        {
            num += 7;
        }
        int num2 = throwaway.vTransform.position.y;
        throwaway.physics1.Z = num >> 3;
        if (num2 < 0)
        {
            num2 += 7;
        }
        num = throwaway.vTransform.position.z;
        throwaway.physics1.W = num2 >> 3;
        if (num < 0)
        {
            num += 7;
        }
        throwaway.physics2.X = num >> 3;
        if (param1)
        {
            if (throwaway.physics1.Z > 4096)
            {
                throwaway.physics1.Z = 4096;
            }
            else if (throwaway.physics1.Z < -4096)
            {
                throwaway.physics1.Z = -4096;
            }
            if (throwaway.physics1.W > 4096)
            {
                throwaway.physics1.W = 4096;
            }
            else if (throwaway.physics1.W < -4096)
            {
                throwaway.physics1.W = -4096;
            }
            if (throwaway.physics2.X > 4096)
            {
                throwaway.physics2.X = 4096;
            }
            else if (throwaway.physics2.X < -4096)
            {
                throwaway.physics2.X = -4096;
            }
        }
        throwaway.vTransform = Utilities.CompMatrixLV(vigTransform, throwaway.vTransform);
        ushort num3 = (ushort)GameManager.FUN_2AC5C();
        throwaway.physics1.M0 = (short)(num3 & 0xFF);
        num3 = (ushort)GameManager.FUN_2AC5C();
        throwaway.physics1.M1 = (short)(num3 & 0xFF);
        num3 = (ushort)GameManager.FUN_2AC5C();
        throwaway.physics1.M2 = (short)(num3 & 0xFF);
        throwaway.screen = throwaway.vTransform.position;
        throwaway.DAT_87 = 2;
        Vector3Int vector3Int = Utilities.FUN_24094(vigTransform.rotation, new Vector3Int(throwaway.physics1.Z, throwaway.physics1.W, throwaway.physics2.X));
        throwaway.physics1.Z = vector3Int.x;
        throwaway.physics1.W = vector3Int.y;
        throwaway.physics2.X = vector3Int.z;
        throwaway.FUN_3066C();
        return throwaway;
    }

    public void FUN_4EDFC()
    {
        FUN_2D1DC();
        VigTuple vigTuple = TDAT_74 = GameManager.instance.FUN_30080(GameManager.instance.interObjs, this);
        vigTuple = (TDAT_78 = GameManager.instance.FUN_30080(GameManager.instance.DAT_10A8, this));
    }

    public void FUN_4EE8C(List<VigTuple> param1)
    {
        Tuple<List<VigTuple>, VigTuple> param2 = new Tuple<List<VigTuple>, VigTuple>(param1, TDAT_74);
        GameManager.instance.FUN_3094C(param2);
    }

    public bool FUN_2C7D0()
    {
        if (vData != null)
        {
            List<ConfigContainer> configContainers = vData.ini.configContainers;
            int index;
            for (ushort num = configContainers[(ushort)DAT_1A].next; num != ushort.MaxValue; num = configContainers[index].previous)
            {
                index = num;
                if (configContainers[index].flag >> 12 == 12)
                {
                    if ((configContainers[index].flag & 0x800) != 0)
                    {
                        flags |= 4096u;
                    }
                    if ((configContainers[index].flag & 0x7FF) == 2047)
                    {
                        vLOD = null;
                    }
                    else if (((configContainers[index].flag ^ configContainers[(ushort)DAT_1A].flag) & 0x7FF) != 0)
                    {
                        VigMesh vigMesh = vLOD = vData.FUN_1FD18(base.gameObject, (uint)(configContainers[index].flag & 0x7FF), init: true);
                    }
                    else
                    {
                        vLOD = vMesh;
                    }
                    int num2 = configContainers[index].objID * 65536;
                    if (configContainers[index].objID == 0)
                    {
                        num2 = DAT_58 * (short)LevelManager.instance.DAT_C18[0];
                    }
                    num2 *= GameManager.instance.DAT_898;
                    if (num2 < 0)
                    {
                        num2 += 255;
                    }
                    DAT_6C = num2 >> 8;
                    return true;
                }
            }
        }
        vLOD = null;
        DAT_6C = 0;
        return false;
    }

    private ConfigContainer FUN_2C9A4()
    {
        int num = (DAT_1A << 3) - DAT_1A << 2;
        short num2 = (short)vData.ini.configContainers[num / 28].next;
        ConfigContainer configContainer;
        while (true)
        {
            if (num2 == -1)
            {
                return null;
            }
            num = (num2 << 3) - num2 << 2;
            num /= 28;
            configContainer = vData.ini.configContainers[num];
            if ((uint)configContainer.flag >> 12 == 11)
            {
                break;
            }
            num2 = (short)configContainer.previous;
        }
        return configContainer;
    }

    public VigObject FUN_2CD04()
    {
        FUN_306FC();
        vTransform = GameManager.instance.FUN_2CDF4(this);
        return FUN_2CCBC();
    }

    private int FUN_2F16C(VigTransform param1, int param2, Vector3Int param3, ref Vector3Int param4)
    {
        if (vCollider != null)
        {
            using (BinaryReader reader = new BinaryReader(new MemoryStream(vCollider.buffer), Encoding.Default, leaveOpen: true))
            {
                Vector3Int vector3Int = new Vector3Int(param3.x - param1.position.x, param3.y - param1.position.y, param3.z - param1.position.z);
                short num = reader.ReadInt16(0);
                for (int num2 = 0; num != 0; num = reader.ReadInt16(num2))
                {
                    int num4;
                    if (reader.ReadUInt16(num2) == 1)
                    {
                        Vector3Int v = Utilities.FUN_2426C(param1.rotation, new Matrix2x4(vector3Int.x, vector3Int.y, vector3Int.z, 0));
                        int num3 = num2 + 4;
                        if (v.x < reader.ReadInt32(num3 + 12) && reader.ReadInt32(num2 + 4) < v.x && v.z < reader.ReadInt32(num3 + 20) && reader.ReadInt32(num3 + 8) < v.z && v.y < reader.ReadInt32(num3 + 16))
                        {
                            num4 = reader.ReadInt32(num3 + 4);
                            if (v.y < num4 + 10240 && num4 - 20480 < v.y)
                            {
                                if (param1.position.y + num4 >= param2)
                                {
                                    num2 += 28;
                                    if (param2 + 65536 >= param3.y)
                                    {
                                        continue;
                                    }
                                }
                                param4 = new Vector3Int(-param1.rotation.V01, -param1.rotation.V11, -param1.rotation.V21);
                                v.y = reader.ReadInt32(num3 + 4);
                                v = Utilities.FUN_24094(param1.rotation, v);
                                return param1.position.y + v.y;
                            }
                        }
                        num2 += 28;
                        continue;
                    }
                    num4 = 2147418112;
                    if (reader.ReadUInt16(num2) != 2)
                    {
                        continue;
                    }
                    uint num5 = 2147549184u;
                    Utilities.SetRotMatrix(param1.rotation);
                    Vector3Int vector3Int2 = default(Vector3Int);
                    int num6 = 0;
                    if (reader.ReadUInt16(num2 + 2) == 0)
                    {
                        goto IL_040d;
                    }
                    int num7 = 4;
                    int num8 = num2 + num7;
                    while (true)
                    {
                        Coprocessor.vector0.vx0 = reader.ReadInt16(num8);
                        Coprocessor.vector0.vy0 = reader.ReadInt16(num8 + 2);
                        Coprocessor.vector0.vz0 = reader.ReadInt16(num8 + 4);
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
                        uint num9 = (uint)((long)reader.ReadInt32(num8 + 8) * 4096L);
                        int ir = Coprocessor.accumulator.ir1;
                        uint num10 = (uint)((long)ir * (long)vector3Int.x);
                        uint num11 = num9 - num10;
                        int ir2 = Coprocessor.accumulator.ir3;
                        uint num12 = (uint)((long)ir2 * (long)vector3Int.z);
                        int num13 = (int)((ulong)((long)ir2 * (long)vector3Int.z) >> 32);
                        ir2 = (int)(num11 - num12);
                        int num14 = (int)((ulong)((long)reader.ReadInt32(num8 + 8) * 4096L) >> 32) - (int)((ulong)((long)ir * (long)vector3Int.x) >> 32) - ((num9 < num10) ? 1 : 0) - num13 - ((num11 < num12) ? 1 : 0);
                        ir = Coprocessor.accumulator.ir2;
                        if (ir < 0)
                        {
                            ir = Coprocessor.accumulator.ir2;
                            long num15 = Utilities.Divdi3(ir2, num14, ir, ir >> 31);
                            if ((int)num5 < (int)num15)
                            {
                                vector3Int2 = new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
                                num5 = (uint)num15;
                            }
                        }
                        else
                        {
                            ir = Coprocessor.accumulator.ir2;
                            if (ir < 1)
                            {
                                if (num14 < 0)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                ir = Coprocessor.accumulator.ir2;
                                long num15 = Utilities.Divdi3(ir2, num14, ir, ir >> 31);
                                if ((int)num15 < vector3Int.y)
                                {
                                    break;
                                }
                                if ((int)num15 < num4)
                                {
                                    num4 = (int)num15;
                                }
                            }
                        }
                        num7 += 12;
                        num6++;
                        num8 = num2 + num7;
                        if (num6 < reader.ReadUInt16(num2 + 2))
                        {
                            continue;
                        }
                        goto IL_040d;
                    }
                    goto IL_0468;
                IL_040d:
                    if ((int)num5 < num4)
                    {
                        num4 = (int)num5 + param1.position.y;
                        if (num4 < param2 && param3.y - 10240 < num4 && num4 < param3.y + 20480 && vector3Int2.y < -2048)
                        {
                            param4 = vector3Int2;
                            return num4;
                        }
                    }
                    goto IL_0468;
                IL_0468:
                    num2 += reader.ReadUInt16(num2 + 2) * 12 + 4;
                }
            }
        }
        return 0;
    }

    private int FUN_2F16C(VigTransform param1, int param2, Vector3Int param3)
    {
        if (vCollider != null)
        {
            using (BinaryReader reader = new BinaryReader(new MemoryStream(vCollider.buffer), Encoding.Default, leaveOpen: true))
            {
                Vector3Int vector3Int = new Vector3Int(param3.x - param1.position.x, param3.y - param1.position.y, param3.z - param1.position.z);
                short num = reader.ReadInt16(0);
                for (int num2 = 0; num != 0; num = reader.ReadInt16(num2))
                {
                    int num4;
                    if (reader.ReadUInt16(num2) == 1)
                    {
                        Vector3Int v = Utilities.FUN_2426C(param1.rotation, new Matrix2x4(vector3Int.x, vector3Int.y, vector3Int.z, 0));
                        int num3 = num2 + 4;
                        if (v.x < reader.ReadInt32(num3 + 12) && reader.ReadInt32(num2 + 4) < v.x && v.z < reader.ReadInt32(num3 + 20) && reader.ReadInt32(num3 + 8) < v.z && v.y < reader.ReadInt32(num3 + 16))
                        {
                            num4 = reader.ReadInt32(num3 + 4);
                            if (v.y < num4 + 10240 && num4 - 20480 < v.y)
                            {
                                if (param1.position.y + num4 >= param2)
                                {
                                    num2 += 28;
                                    if (param2 + 65536 >= param3.y)
                                    {
                                        continue;
                                    }
                                }
                                v.y = reader.ReadInt32(num3 + 4);
                                v = Utilities.FUN_24094(param1.rotation, v);
                                return param1.position.y + v.y;
                            }
                        }
                        num2 += 28;
                        continue;
                    }
                    num4 = 2147418112;
                    if (reader.ReadUInt16(num2) != 2)
                    {
                        continue;
                    }
                    uint num5 = 2147549184u;
                    Utilities.SetRotMatrix(param1.rotation);
                    Vector3Int vector3Int2 = default(Vector3Int);
                    int num6 = 0;
                    if (reader.ReadUInt16(num2 + 2) == 0)
                    {
                        goto IL_03d7;
                    }
                    int num7 = 4;
                    int num8 = num2 + num7;
                    while (true)
                    {
                        Coprocessor.vector0.vx0 = reader.ReadInt16(num8);
                        Coprocessor.vector0.vy0 = reader.ReadInt16(num8 + 2);
                        Coprocessor.vector0.vz0 = reader.ReadInt16(num8 + 4);
                        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
                        uint num9 = (uint)((long)reader.ReadInt32(num8 + 8) * 4096L);
                        int ir = Coprocessor.accumulator.ir1;
                        uint num10 = (uint)((long)ir * (long)vector3Int.x);
                        uint num11 = num9 - num10;
                        int ir2 = Coprocessor.accumulator.ir3;
                        uint num12 = (uint)((long)ir2 * (long)vector3Int.z);
                        int num13 = (int)((ulong)((long)ir2 * (long)vector3Int.z) >> 32);
                        ir2 = (int)(num11 - num12);
                        int num14 = (int)((ulong)((long)reader.ReadInt32(num8 + 8) * 4096L) >> 32) - (int)((ulong)((long)ir * (long)vector3Int.x) >> 32) - ((num9 < num10) ? 1 : 0) - num13 - ((num11 < num12) ? 1 : 0);
                        ir = Coprocessor.accumulator.ir2;
                        if (ir < 0)
                        {
                            ir = Coprocessor.accumulator.ir2;
                            long num15 = Utilities.Divdi3(ir2, num14, ir, ir >> 31);
                            if ((int)num5 < (int)num15)
                            {
                                vector3Int2 = new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
                                num5 = (uint)num15;
                            }
                        }
                        else
                        {
                            ir = Coprocessor.accumulator.ir2;
                            if (ir < 1)
                            {
                                if (num14 < 0)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                ir = Coprocessor.accumulator.ir2;
                                long num15 = Utilities.Divdi3(ir2, num14, ir, ir >> 31);
                                if ((int)num15 < vector3Int.y)
                                {
                                    break;
                                }
                                if ((int)num15 < num4)
                                {
                                    num4 = (int)num15;
                                }
                            }
                        }
                        num7 += 12;
                        num6++;
                        num8 = num2 + num7;
                        if (num6 < reader.ReadUInt16(num2 + 2))
                        {
                            continue;
                        }
                        goto IL_03d7;
                    }
                    goto IL_0429;
                IL_03d7:
                    if ((int)num5 < num4)
                    {
                        num4 = (int)num5 + param1.position.y;
                        if (num4 < param2 && param3.y - 10240 < num4 && num4 < param3.y + 20480 && vector3Int2.y < -2048)
                        {
                            return num4;
                        }
                    }
                    goto IL_0429;
                IL_0429:
                    num2 += reader.ReadUInt16(num2 + 2) * 12 + 4;
                }
            }
        }
        return 0;
    }

    private int FUN_2F5AC(VigTransform param1, int param2, Vector3Int param3, ref Vector3Int param4)
    {
        VigObject vigObject = child2;
        int num;
        while (true)
        {
            if (vigObject == null)
            {
                return 0;
            }
            if (vigObject.vCollider == null)
            {
                if ((vigObject.flags & 0x800) != 0)
                {
                    VigTransform param5 = Utilities.CompMatrixLV(param1, vigObject.vTransform);
                    num = vigObject.FUN_2F5AC(param5, param2, param3, ref param4);
                    if (num != 0)
                    {
                        return num;
                    }
                }
            }
            else
            {
                VigTransform param5 = Utilities.CompMatrixLV(param1, vigObject.vTransform);
                if (0 < param5.rotation.V11 || 2048 < param5.rotation.V01 * vTransform.rotation.V01 + param5.rotation.V11 * vTransform.rotation.V11 + param5.rotation.V21 * vTransform.rotation.V21)
                {
                    num = vigObject.FUN_2F16C(param5, param2, param3, ref param4);
                    if (num != 0)
                    {
                        return num;
                    }
                }
                if ((vigObject.flags & 0x800) != 0)
                {
                    num = vigObject.FUN_2F5AC(param5, param2, param3, ref param4);
                    if (num != 0)
                    {
                        break;
                    }
                }
            }
            vigObject = vigObject.child;
        }
        return num;
    }

    private int FUN_2F710(int param1, Vector3Int param2, ref Vector3Int param3)
    {
        if ((flags & 0x800) != 0)
        {
            int num = FUN_2F5AC(vTransform, param1, param2, ref param3);
            if (num != 0)
            {
                return num;
            }
        }
        return FUN_2F16C(vTransform, param1, param2, ref param3);
    }

    public void FUN_305FC()
    {
        FUN_2D1DC();
        if ((flags & 4) != 0)
        {
            GameManager.instance.FUN_30080(GameManager.instance.DAT_10A8, this);
        }
        if ((flags & 0x80) != 0)
        {
            GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, this);
        }
        GameManager.instance.FUN_30080(GameManager.instance.worldObjs, this);
    }

    public void FUN_4C7AC(VigMesh param1, GameObject param2)
    {
        VigShadow vigShadow = vShadow = Utilities.FUN_4C44C(param1, 65536, 65536, param2);
    }

    public void FUN_4C7E0(VigMesh param1, GameObject param2)
    {
        bool flag = true;
        if (vCollider == null)
        {
            int dAT_ = DAT_58;
            int param3 = dAT_;
            VigShadow vigShadow = vShadow = Utilities.FUN_4C44C(param1, dAT_, param3, param2);
            return;
        }
        using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(vCollider.buffer), Encoding.Default, leaveOpen: true))
        {
            short num = binaryReader.ReadInt16(0);
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int dAT_ = 0;
            int num5 = 0;
            int param3 = 0;
            while (true)
            {
                switch (num)
                {
                    case 1:
                        if (flag)
                        {
                            num2 = binaryReader.ReadInt32(4);
                            num3 = binaryReader.ReadInt32(8);
                            num4 = binaryReader.ReadInt32(12);
                            dAT_ = binaryReader.ReadInt32(16);
                            num5 = binaryReader.ReadInt32(20);
                            param3 = binaryReader.ReadInt32(24);
                            flag = false;
                            int num6 = 28;
                            binaryReader.BaseStream.Seek(num6, SeekOrigin.Current);
                            num = binaryReader.ReadInt16(0);
                        }
                        else
                        {
                            if (binaryReader.ReadInt32(4) < num2)
                            {
                                num2 = binaryReader.ReadInt32(4);
                            }
                            if (binaryReader.ReadInt32(8) < num3)
                            {
                                num3 = binaryReader.ReadInt32(8);
                            }
                            if (binaryReader.ReadInt32(12) < num4)
                            {
                                num4 = binaryReader.ReadInt32(12);
                            }
                            if (dAT_ < binaryReader.ReadInt32(16))
                            {
                                dAT_ = binaryReader.ReadInt32(16);
                            }
                            if (num5 < binaryReader.ReadInt32(20))
                            {
                                num5 = binaryReader.ReadInt32(20);
                            }
                            if (param3 < binaryReader.ReadInt32(24))
                            {
                                param3 = binaryReader.ReadInt32(24);
                            }
                            int num6 = 14;
                            binaryReader.BaseStream.Seek(num6, SeekOrigin.Current);
                            num = binaryReader.ReadInt16(0);
                        }
                        break;
                    case 0:
                        {
                            VigShadow vigShadow = vShadow = Utilities.FUN_4C44C(param1, dAT_, param3, param2);
                            return;
                        }
                    case 2:
                        {
                            int num6 = binaryReader.ReadUInt16(2) * 6 + 2;
                            binaryReader.BaseStream.Seek(num6, SeekOrigin.Current);
                            num = binaryReader.ReadInt16(0);
                            break;
                        }
                }
            }
        }
    }
}
