using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

public struct Primitive
{
    public Vector3 verts;
    public Vector2Int screen;
    public Vector2Int uvs;
}

[BurstCompile]
public class Water : MonoBehaviour
{
    public static Water instance;

    public Transform lod;

    public Vector3 lodOffset;

    public bool topView;

    public int width;

    public int height;

    public int cellSize;

    public short[] DAT_B5570;

    public byte[] DAT_B5D70;

    private Mesh mesh;

    private Mesh LOD;

    private Vector3[] newVertices;

    private Vector2[] newUVs;

    private Color32[] newColors;

    private int[] newIndices;

    private Vector3[] newLODVertices;

    private Vector2[] newLODUVs;

    private Color32[] newLODColors;

    private int[] newLODIndices;

    private VigTerrain terrain;

    private Primitive[] primitives;

    private Texture2D mainT;

    private float lod_y;

    private Vector3 masterPosition;

    private Quaternion masterRotation;

    private Vector3 masterScale;

    private Transform lod2;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
            mesh = new Mesh();
            GetComponent<MeshFilter>().mesh = mesh;
            int num = 6000;
            newVertices = new Vector3[num];
            newColors = new Color32[num];
            newUVs = new Vector2[num];
            newIndices = new int[num];
            primitives = new Primitive[num];
            DAT_B5D70 = new byte[1024];
            DAT_B5570 = new short[1024];
            for (int i = 0; i < num; i += 6)
            {
                newColors[i] = new Color32(128, 128, 128, byte.MaxValue);
                newColors[i + 1] = new Color32(128, 128, 128, byte.MaxValue);
                newColors[i + 2] = new Color32(128, 128, 128, byte.MaxValue);
                newColors[i + 3] = new Color32(128, 128, 128, byte.MaxValue);
                newColors[i + 4] = new Color32(128, 128, 128, byte.MaxValue);
                newColors[i + 5] = new Color32(128, 128, 128, byte.MaxValue);
                newIndices[i] = i;
                newIndices[i + 1] = i + 1;
                newIndices[i + 2] = i + 2;
                newIndices[i + 3] = i + 3;
                newIndices[i + 4] = i + 4;
                newIndices[i + 5] = i + 5;
            }
            LOD = new Mesh();
            lod.GetComponent<MeshFilter>().mesh = LOD;
            int num2 = width * height * 4;
            newLODVertices = new Vector3[num2];
            newLODColors = new Color32[num2];
            newLODUVs = new Vector2[num2];
            newLODIndices = new int[num2 * 2];
            Color32 dAT_DE = LevelManager.instance.DAT_DE0;
            dAT_DE.a = 128;
            for (int j = 0; j < num2; j += 4)
            {
                newLODColors[j] = dAT_DE;
                newLODColors[j + 1] = dAT_DE;
                newLODColors[j + 2] = dAT_DE;
                newLODColors[j + 3] = dAT_DE;
                newLODUVs[j] = new Vector2(0f, 0f);
                newLODUVs[j + 1] = new Vector2(0f, 0f);
                newLODUVs[j + 2] = new Vector2(0f, 0f);
                newLODUVs[j + 3] = new Vector2(0f, 0f);
            }
            for (int k = 0; k < height; k++)
            {
                for (int l = 0; l < width; l++)
                {
                    int num3 = l + k * height;
                    int num4 = (l < width / 2) ? (-l - 1) : (l - width / 2);
                    newLODVertices[num3 * 4] = new Vector3(cellSize * num4, 0f, cellSize * k);
                    newLODVertices[num3 * 4 + 1] = new Vector3(cellSize * num4 + cellSize, 0f, cellSize * k);
                    newLODVertices[num3 * 4 + 2] = new Vector3(cellSize * num4, 0f, cellSize * k + cellSize);
                    newLODVertices[num3 * 4 + 3] = new Vector3(cellSize * num4 + cellSize, 0f, cellSize * k + cellSize);
                }
            }
            int indicesLength = 0;
            int num5 = 0;
            for (int m = 0; m < num2; m += 4)
            {
                newLODIndices[num5] = m + 2;
                newLODIndices[num5 + 1] = m + 1;
                newLODIndices[num5 + 2] = m;
                newLODIndices[num5 + 3] = m + 1;
                newLODIndices[num5 + 4] = m + 2;
                newLODIndices[num5 + 5] = m + 3;
                indicesLength = num5 + 6;
                num5 += 6;
            }
            LOD.SetVertices(newLODVertices, 0, num2);
            LOD.SetColors(newLODColors, 0, num2);
            LOD.SetUVs(0, newLODUVs, 0, num2);
            LOD.SetIndices(newLODIndices, 0, indicesLength, MeshTopology.Triangles, 0);
        }
        terrain = UnityEngine.Object.FindObjectOfType<VigTerrain>();
        mainT = (Texture2D)UnityEngine.Object.FindObjectOfType<LevelManager>().DAT_DC0.mainTexture;
        lod2 = UnityEngine.Object.Instantiate(lod.gameObject, lod).transform;
        lod2.localEulerAngles = new Vector3(0f, 180f, 0f);
    }

    private void Update()
    {
    }

    public void UpdatePosition(Vector3 pos)
    {
        Vector3 a = new Vector3(pos.x, 0f - pos.y, pos.z);
        Vector3 position = masterRotation * Vector3.Scale(a, masterScale) + masterPosition;
        base.transform.position = position;
    }

    public void FUN_15F28(VigTransform param1, int param2)
    {
        masterPosition = new Vector3((float)param1.position.x / (float)GameManager.instance.translateFactor, (float)(-param1.position.y) / (float)GameManager.instance.translateFactor, (float)param1.position.z / (float)GameManager.instance.translateFactor);
        masterRotation = param1.rotation.Matrix2Quaternion;
        masterRotation.eulerAngles = new Vector3(0f - masterRotation.eulerAngles.x, masterRotation.eulerAngles.y, 0f - masterRotation.eulerAngles.z);
        masterScale = param1.rotation.Scale;
        lod_y = (float)GameManager.instance.DAT_DB0 / (float)GameManager.instance.translateFactor;
        Vector3 a = new Vector3(lodOffset.x, 0f - lodOffset.y, lodOffset.z);
        Vector3 position = masterRotation * Vector3.Scale(a, masterScale) + masterPosition;
        position.y = 0f - lod_y;
        lod.position = position;
        lod.localEulerAngles = new Vector3(0f, masterRotation.eulerAngles.y, 0f);
        if (!topView)
        {
            if (lod2.gameObject.activeSelf)
            {
                lod2.gameObject.SetActive(value: false);
            }
            UIManager.instance.Underwater(masterPosition.y, lod.position.y);
        }
        else if (!lod2.gameObject.activeSelf)
        {
            lod2.gameObject.SetActive(value: true);
        }
    }

    public void FUN_16664(Vector3Int param1, int param2)
    {
        int dAT_F = GameManager.instance.DAT_F20;
        int dAT_EDC = GameManager.instance.DAT_EDC;
        int dAT_ED = GameManager.instance.DAT_ED8;
        int num = 0;
        int num2 = 0;
        Utilities.FUN_246BC(GameManager.instance.DAT_F28);
        Vector3Int vector3Int = param1;
        Vector3Int vector3Int2;
        Vector3Int vector3Int3;
        Vector3Int vector3Int4;
        Vector3Int v;
        if (vector3Int.z < 4081)
        {
            int y = vector3Int.y;
            int x = vector3Int.x;
            int num3 = y;
            if (y < 0)
            {
                num3 = -y;
            }
            int num4 = x;
            if (x < 0)
            {
                num4 = -x;
            }
            v = default(Vector3Int);
            if (num4 < num3)
            {
                v.x = dAT_EDC * -256 / 2;
                v.z = dAT_ED << 8;
                param2 *= 4096;
                v.y = (param2 - x * v.x - vector3Int.z * v.z) / y;
                vector3Int2 = Utilities.FUN_24008(v);
                v.x = dAT_EDC * 128;
                v.y = (param2 - vector3Int.x * v.x - vector3Int.z * v.z) / vector3Int.y;
                vector3Int3 = Utilities.FUN_24008(v);
                v.x = dAT_EDC * -3072 / 2;
                v.z = (dAT_ED << 1) + dAT_ED << 10;
                v.y = (param2 - vector3Int.x * v.x - vector3Int.z * v.z) / vector3Int.y;
                vector3Int4 = Utilities.FUN_24008(v);
                v.x = dAT_EDC * 1536;
                v.y = (param2 - vector3Int.x * v.x - vector3Int.z * v.z) / vector3Int.y;
            }
            else
            {
                v.y = dAT_F * -256 / 2;
                v.z = dAT_ED << 8;
                param2 *= 4096;
                v.x = (param2 - y * v.y - vector3Int.z * v.z) / x;
                vector3Int2 = Utilities.FUN_24008(v);
                v.y = dAT_F * 128;
                v.x = (param2 - vector3Int.y * v.y - vector3Int.z * v.z) / vector3Int.x;
                vector3Int3 = Utilities.FUN_24008(v);
                v.y = dAT_F * -3072 / 2;
                v.z = (dAT_ED << 1) + dAT_ED << 10;
                v.x = (param2 - vector3Int.y * v.y - vector3Int.z * v.z) / vector3Int.x;
                vector3Int4 = Utilities.FUN_24008(v);
                v.y = dAT_F * 1536;
                v.x = (param2 - vector3Int.y * v.y - vector3Int.z * v.z) / vector3Int.x;
            }
        }
        else
        {
            v = default(Vector3Int);
            int num3 = -dAT_EDC;
            param2 = dAT_ED * param2 << 12;
            v.z = param2 / (num3 * vector3Int.x / 2 - dAT_F * vector3Int.y / 2 + dAT_ED * vector3Int.z);
            v.x = num3 * v.z / dAT_ED;
            v.y = -dAT_F * v.z / dAT_ED;
            vector3Int2 = Utilities.FUN_24008(v);
            v.z = param2 / (dAT_EDC * vector3Int.x / 2 - dAT_F * vector3Int.y / 2 + dAT_ED * vector3Int.z);
            v.x = dAT_EDC * v.z / dAT_ED;
            v.y = -dAT_F * v.z / dAT_ED;
            vector3Int3 = Utilities.FUN_24008(v);
            v.z = param2 / (num3 * vector3Int.x / 2 + dAT_F * vector3Int.y / 2 + dAT_ED * vector3Int.z);
            v.x = num3 * v.z / dAT_ED;
            v.y = dAT_F * v.z / dAT_ED;
            vector3Int4 = Utilities.FUN_24008(v);
            v.z = param2 / (dAT_EDC * vector3Int.x / 2 + dAT_F * vector3Int.y / 2 + dAT_ED * vector3Int.z);
            v.x = dAT_EDC * v.z / dAT_ED;
            v.y = dAT_F * v.z / dAT_ED;
        }
        Vector3Int vector3Int5 = Utilities.FUN_24008(v);
        dAT_EDC = vector3Int3.x;
        if (vector3Int2.x < vector3Int3.x)
        {
            dAT_EDC = vector3Int2.x;
        }
        dAT_F = vector3Int4.x;
        if (dAT_EDC < vector3Int4.x)
        {
            dAT_F = dAT_EDC;
        }
        dAT_EDC = vector3Int5.x;
        if (dAT_F < vector3Int5.x)
        {
            dAT_EDC = dAT_F;
        }
        int num5 = dAT_EDC >> 16;
        dAT_EDC = vector3Int3.z;
        if (vector3Int2.z < vector3Int3.z)
        {
            dAT_EDC = vector3Int2.z;
        }
        dAT_F = vector3Int4.z;
        if (dAT_EDC < vector3Int4.z)
        {
            dAT_F = dAT_EDC;
        }
        int num6 = vector3Int5.z;
        if (dAT_F < vector3Int5.z)
        {
            num6 = dAT_F;
        }
        num6 >>= 16;
        if (vector3Int3.x < vector3Int2.x)
        {
            vector3Int3.x = vector3Int2.x;
        }
        if (vector3Int4.x < vector3Int3.x)
        {
            vector3Int4.x = vector3Int3.x;
        }
        if (vector3Int5.x < vector3Int4.x)
        {
            vector3Int5.x = vector3Int4.x;
        }
        int num7 = vector3Int5.x + 65535 >> 16;
        if (vector3Int3.z < vector3Int2.z)
        {
            vector3Int3.z = vector3Int2.z;
        }
        if (vector3Int4.z < vector3Int3.z)
        {
            vector3Int4.z = vector3Int3.z;
        }
        if (vector3Int5.z < vector3Int4.z)
        {
            vector3Int5.z = vector3Int4.z;
        }
        dAT_EDC = GameManager.instance.DAT_DA0 >> 16;
        int num8 = vector3Int5.z + 65535 >> 16;
        if (num8 <= dAT_EDC || num6 < dAT_EDC)
        {
            if (num8 > dAT_EDC)
            {
                num8 = dAT_EDC;
            }
            if (31 < num7 - num5)
            {
                num7 = num5 + 31;
            }
            if (31 < num8 - num6)
            {
                num8 = num6 + 31;
            }
            Utilities.SetRotMatrix(GameManager.instance.DAT_F00.rotation);
            v.x = num5 << 8;
            v.y = GameManager.instance.DAT_DB0;
            if (GameManager.instance.DAT_DB0 < 0)
            {
                v.y = GameManager.instance.DAT_DB0 + 255;
            }
            v.y >>= 8;
            v.z = num6 << 8;
            v = Utilities.FUN_23F7C(v);
            int num9 = GameManager.instance.DAT_F00.position.x;
            if (num9 < 0)
            {
                num9 += 255;
            }
            v.x += num9 >> 8;
            num9 = GameManager.instance.DAT_F00.position.y;
            if (num9 < 0)
            {
                num9 += 255;
            }
            v.y += num9 >> 8;
            num9 = GameManager.instance.DAT_F00.position.z;
            if (num9 < 0)
            {
                num9 += 255;
            }
            v.z += num9 >> 8;
            UpdatePosition((Vector3)new Vector3Int(v.x << 8, v.y << 8, v.z << 8) / (float)GameManager.instance.translateFactor);
            Coprocessor.translationVector._trx = v.x;
            Coprocessor.translationVector._try = v.y;
            Coprocessor.translationVector._trz = v.z;
            dAT_EDC = GameManager.instance.DAT_DB0;
            if (GameManager.instance.DAT_DB0 < 0)
            {
                dAT_EDC = GameManager.instance.DAT_DB0 + 2047;
            }
            int num10 = dAT_EDC >> 11;
            dAT_F = 0;
            if (-1 < num8 - num6)
            {
                num9 = (dAT_ED << 1) + dAT_ED << 2;
                int num3 = 0;
                do
                {
                    Coprocessor.vector0.vz0 = (short)(dAT_F << 8);
                    int x = 0;
                    if (-1 < num7 - num5)
                    {
                        int num11 = num3;
                        do
                        {
                            Coprocessor.vector0.vx0 = (short)(x << 8);
                            Coprocessor.vector0.vy0 = (short)(x << 8 >> 16);
                            Coprocessor.ExecuteRTPS(12, lm: false);
                            Cop2SxyFIFO screenXYFIFO = Coprocessor.screenXYFIFO;
                            num3 = Coprocessor.screenXYFIFO.sy2;
                            int y = Coprocessor.screenZFIFO.sz3;
                            byte b = (byte)(((terrain.vertices[terrain.chunks[((uint)(x + num5) >> 6) * 32 + ((uint)(dAT_F + num6) >> 6)] * 4096 + (((dAT_F + num6) & 0x3F) * 2 + ((x + num5) & 0x3F) * 128) / 2] & 0x7FF) < num10) ? 1 : 0);
                            b = 0;
                            x++;
                            DAT_B5D70[num11] = b;
                            num11++;
                        }
                        while (x <= num8 - num6);
                    }
                    dAT_F++;
                    num3 = dAT_F * 32;
                }
                while (dAT_F <= num8 - num6);
            }
            int num12 = GameManager.instance.DAT_28 << 12;
            int num13 = (int)((long)num12 * -2004318071L >> 32) + num12;
            num12 >>= 31;
            num13 = (num13 >> 7) - num12;
            int num14 = num6 * 873 + num13;
            dAT_EDC = 0;
            if (-1 < num8 - num6)
            {
                dAT_ED = num5 * 873;
                num10 = -1610571775;
                do
                {
                    num12 = GameManager.instance.DAT_28 << 12;
                    num13 = (int)((long)num12 * -2004318071L >> 32) + num12;
                    num12 >>= 31;
                    num13 = (num13 >> 7) - num12;
                    int num15 = dAT_ED + num13;
                    dAT_F = 0;
                    int num16 = dAT_EDC * 32;
                    int num11 = dAT_EDC * 32;
                    if (-1 < num7 - num5)
                    {
                        int num17 = 33 + dAT_EDC * 32;
                        do
                        {
                            if ((DAT_B5D70[num17] & DAT_B5D70[num17 - 1] & DAT_B5D70[num11] & DAT_B5D70[num17 - 32]) != 0)
                            {
                                DAT_B5D70[num11] |= 128;
                            }
                            int num18 = num15 & 0xFFF;
                            int num19 = (int)((ulong)((long)(GameManager.DAT_65C90[num18 * 4 / 2] * GameManager.DAT_65C90[(num14 & 0xFFF) * 4 / 2]) * (long)num10) >> 32);
                            dAT_F++;
                            num17++;
                            num11++;
                            num15 += 873;
                            num13 = GameManager.DAT_65C90[num18 * 4 / 2] * GameManager.DAT_65C90[(num14 & 0xFFF) * 4 / 2];
                            num12 = num19 + num13 >> 14;
                            num12 -= num13 >> 31;
                            DAT_B5570[num16] = (short)num12;
                            num16++;
                        }
                        while (dAT_F <= num7 - num5);
                    }
                    dAT_EDC++;
                    num14 += 873;
                }
                while (dAT_EDC <= num8 - num6);
            }
            num12 = GameManager.instance.DAT_28 << 12;
            num13 = (int)((long)num12 * -1677082467L >> 32) + num12;
            num12 >>= 31;
            num13 = (num13 >> 8) - num12;
            num14 = num6 * 1456 + num13;
            dAT_EDC = 0;
            if (-1 < num8 - num6)
            {
                dAT_ED = num5 * 1456;
                do
                {
                    dAT_F = 0;
                    int num20 = dAT_EDC * 32;
                    int num11 = dAT_EDC * 32;
                    num12 = GameManager.instance.DAT_28 << 12;
                    num13 = (int)((long)num12 * -1677082467L >> 32) + num12;
                    num12 >>= 31;
                    num13 = (num13 >> 8) - num12;
                    int num15 = dAT_ED + num13;
                    if (-1 < num7 - num5)
                    {
                        do
                        {
                            if ((DAT_B5D70[num11] & 4) == 0)
                            {
                                int num3 = GameManager.DAT_65C90[(num15 & 0xFFF) * 4 / 2] * GameManager.DAT_65C90[(num14 & 0xFFF) * 4 / 2];
                                if (num3 < 0)
                                {
                                    num3 += 131071;
                                }
                                DAT_B5570[num20] += (short)(num3 >> 17);
                            }
                            else
                            {
                                DAT_B5570[num20] = 0;
                            }
                            dAT_F++;
                            num11++;
                            num20++;
                            num15 += 1456;
                        }
                        while (dAT_F <= num7 - num5);
                    }
                    dAT_EDC++;
                    num14 += 1456;
                }
                while (dAT_EDC <= num8 - num6);
            }
            num10 = GameManager.instance.DAT_DB0;
            if (GameManager.instance.DAT_DB0 < 0)
            {
                num10 = GameManager.instance.DAT_DB0 + 15;
            }
            num10 >>= 4;
            dAT_EDC = 0;
            if (0 < num8 - num6)
            {
                int num21 = 256;
                do
                {
                    int num20 = dAT_EDC * 32;
                    int num22 = dAT_EDC * 32;
                    num14 = 0;
                    if (0 < num7 - num5)
                    {
                        int num23 = dAT_EDC << 8;
                        int num24 = 33 + dAT_EDC * 32;
                        int num11 = 33 + dAT_EDC * 32;
                        int num18 = 256;
                        num2 = num + 2;
                        int num25 = dAT_EDC + num6;
                        int num26 = (int)((uint)num25 >> 6 << 2);
                        int num27 = num21;
                        int num15 = num5;
                        do
                        {
                            if ((DAT_B5D70[num22] & 0x80) == 0)
                            {
                                dAT_F = DAT_B5570[num20];
                                int num3 = (num14 & 0xFF) * 256;
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                Coprocessor.vector0.vx0 = (short)num3;
                                Coprocessor.vector0.vy0 = (short)(dAT_F >> 4);
                                Coprocessor.vector0.vz0 = (short)num23;
                                dAT_F = DAT_B5570[num24 - 32];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                Coprocessor.vector1.vx1 = (short)num18;
                                Coprocessor.vector1.vy1 = (short)(dAT_F >> 4);
                                Coprocessor.vector1.vz1 = (short)num23;
                                dAT_F = DAT_B5570[num24 - 1];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                Coprocessor.vector2.vx2 = (short)num3;
                                Coprocessor.vector2.vy2 = (short)(dAT_F >> 4);
                                Coprocessor.vector2.vz2 = (short)num27;
                                Coprocessor.ExecuteRTPT(12, lm: false);
                                num12 = 0;
                                if (num24 - 34 >= 0)
                                {
                                    num12 = DAT_B5570[num24 - 34];
                                }
                                dAT_F = DAT_B5570[num24 - 32] - num12;
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    num3 = 0;
                                }
                                else
                                {
                                    num3 = 63;
                                    if (dAT_F < 64)
                                    {
                                        num3 = dAT_F;
                                    }
                                }
                                num12 = 0;
                                if (num24 - 65 >= 0)
                                {
                                    num12 = DAT_B5570[num24 - 65];
                                }
                                dAT_F = DAT_B5570[num24 - 1] - num12;
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                ushort num28;
                                if (dAT_F < 0)
                                {
                                    dAT_F = 0;
                                    num28 = (ushort)(dAT_F << 8);
                                }
                                else
                                {
                                    num28 = 16128;
                                    if (dAT_F < 64)
                                    {
                                        num28 = (ushort)(dAT_F << 8);
                                    }
                                }
                                primitives[num2 - 2].uvs = new Vector2Int(num3, num28 >> 8);
                                dAT_F = DAT_B5570[num24 - 31] - DAT_B5570[num20];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    num3 = 0;
                                }
                                else
                                {
                                    num3 = 63;
                                    if (dAT_F < 64)
                                    {
                                        num3 = dAT_F;
                                    }
                                }
                                num12 = 0;
                                if (num24 - 64 >= 0)
                                {
                                    num12 = DAT_B5570[num24 - 64];
                                }
                                dAT_F = DAT_B5570[num24] - num12;
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    dAT_F = 0;
                                    num28 = (ushort)(dAT_F << 8);
                                }
                                else
                                {
                                    num28 = 16128;
                                    if (dAT_F < 64)
                                    {
                                        num28 = (ushort)(dAT_F << 8);
                                    }
                                }
                                primitives[num2 - 1].uvs = new Vector2Int(num3, num28 >> 8);
                                dAT_F = DAT_B5570[num24] - DAT_B5570[num24 - 2];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    num3 = 0;
                                }
                                else
                                {
                                    num3 = 63;
                                    if (dAT_F < 64)
                                    {
                                        num3 = dAT_F;
                                    }
                                }
                                dAT_F = DAT_B5570[num24 + 31] - DAT_B5570[num20];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    dAT_F = 0;
                                    num28 = (ushort)(dAT_F << 8);
                                }
                                else
                                {
                                    num28 = 16128;
                                    if (dAT_F < 64)
                                    {
                                        num28 = (ushort)(dAT_F << 8);
                                    }
                                }
                                primitives[num2].uvs = new Vector2Int(num3, num28 >> 8);
                                Coprocessor.ExecuteAVSZ3();
                                if (((DAT_B5D70[num11 - 1] | DAT_B5D70[num22] | DAT_B5D70[num11 - 32]) & 1) == 0)
                                {
                                    primitives[num2 - 2].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx0, Coprocessor.screenXYFIFO.sy0);
                                    primitives[num2 - 2].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx0, Coprocessor.screenXYZFIFO.sy0, Coprocessor.screenXYZFIFO.sz0);
                                    primitives[num2 - 1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx1, Coprocessor.screenXYFIFO.sy1);
                                    primitives[num2 - 1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx1, Coprocessor.screenXYZFIFO.sy1, Coprocessor.screenXYZFIFO.sz1);
                                    primitives[num2].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx2, Coprocessor.screenXYFIFO.sy2);
                                    primitives[num2].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx2, Coprocessor.screenXYZFIFO.sy2, Coprocessor.screenXYZFIFO.sz2);
                                    newIndices[num] = num;
                                    newIndices[num + 1] = num + 1;
                                    newIndices[num + 2] = num + 2;
                                    dAT_F = DAT_B5570[num24];
                                    if (dAT_F < 0)
                                    {
                                        dAT_F += 15;
                                    }
                                    Coprocessor.vector0.vx0 = (short)num18;
                                    Coprocessor.vector0.vy0 = (short)(dAT_F >> 4);
                                    Coprocessor.vector0.vz0 = (short)num27;
                                    Coprocessor.ExecuteRTPS(12, lm: false);
                                    dAT_F = Coprocessor.averageZ;
                                    num2 += 3;
                                    num += 3;
                                }
                                else
                                {
                                    num3 = (num15 & 0x3F) * 128;
                                    dAT_F = (num25 & 0x3F) * 2;
                                    dAT_F = Utilities.FUN_26B80(num, (terrain.vertices[terrain.chunks[(num26 + (int)(((uint)num15 >> 6) * 128)) / 4] * 4096 + (dAT_F + num3) / 2] & 0x7FF) * 128 - num10 - DAT_B5570[num20], (terrain.vertices[terrain.chunks[(num26 + (int)(((uint)(num15 + 1) >> 6) * 128)) / 4] * 4096 + (dAT_F + ((num15 + 1) & 0x3F) * 128) / 2] & 0x7FF) * 128 - num10 - DAT_B5570[num24 - 32], (terrain.vertices[terrain.chunks[((uint)num15 >> 6) * 32 + ((uint)(num25 + 1) >> 6)] * 4096 + (((num25 + 1) & 0x3F) * 2 + num3) / 2] & 0x7FF) * 128 - num10 - DAT_B5570[num24 - 1], primitives);
                                    num3 = Coprocessor.averageZ;
                                    int x = DAT_B5570[num24 - 32];
                                    if (x < 0)
                                    {
                                        x += 15;
                                    }
                                    Coprocessor.vector0.vx0 = (short)num18;
                                    Coprocessor.vector0.vy0 = (short)(x >> 4);
                                    Coprocessor.vector0.vz0 = (short)num23;
                                    num3 = DAT_B5570[num24 - 1];
                                    if (num3 < 0)
                                    {
                                        num3 += 15;
                                    }
                                    Coprocessor.vector1.vx1 = (short)((num14 & 0xFF) * 256);
                                    Coprocessor.vector1.vy1 = (short)(num3 >> 4);
                                    Coprocessor.vector1.vz1 = (short)num27;
                                    num3 = DAT_B5570[num24];
                                    if (num3 < 0)
                                    {
                                        num3 += 15;
                                    }
                                    Coprocessor.vector2.vx2 = (short)num18;
                                    Coprocessor.vector2.vy2 = (short)(num3 >> 4);
                                    Coprocessor.vector2.vz2 = (short)num27;
                                    Coprocessor.ExecuteRTPT(12, lm: false);
                                    switch (dAT_F)
                                    {
                                        default:
                                            newIndices[num] = num;
                                            newIndices[num + 1] = num + 1;
                                            newIndices[num + 2] = num + 2;
                                            num2 += 3;
                                            num += 3;
                                            break;
                                        case 4:
                                            primitives[num + 5].verts = primitives[num + 3].verts;
                                            primitives[num + 4].verts = primitives[num + 2].verts;
                                            primitives[num + 3].verts = primitives[num + 1].verts;
                                            primitives[num + 5].uvs = primitives[num + 3].uvs;
                                            primitives[num + 4].uvs = primitives[num + 2].uvs;
                                            primitives[num + 3].uvs = primitives[num + 1].uvs;
                                            newIndices[num] = num;
                                            newIndices[num + 1] = num + 1;
                                            newIndices[num + 2] = num + 2;
                                            newIndices[num + 3] = num + 5;
                                            newIndices[num + 4] = num + 4;
                                            newIndices[num + 5] = num + 3;
                                            num2 += 6;
                                            num += 6;
                                            break;
                                        case 0:
                                            break;
                                    }
                                }
                                dAT_F = DAT_B5570[num24 - 31] - DAT_B5570[num20];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    num3 = 0;
                                }
                                else
                                {
                                    num3 = 63;
                                    if (dAT_F < 64)
                                    {
                                        num3 = dAT_F;
                                    }
                                }
                                num12 = 0;
                                if (num24 - 64 >= 0)
                                {
                                    num12 = DAT_B5570[num24 - 64];
                                }
                                dAT_F = DAT_B5570[num24] - num12;
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    dAT_F = 0;
                                    num28 = (ushort)(dAT_F << 8);
                                }
                                else
                                {
                                    num28 = 16128;
                                    if (dAT_F < 64)
                                    {
                                        num28 = (ushort)(dAT_F << 8);
                                    }
                                }
                                primitives[num2 - 2].uvs = new Vector2Int(num3, num28 >> 8);
                                dAT_F = DAT_B5570[num24] - DAT_B5570[num24 - 2];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    num3 = 0;
                                }
                                else
                                {
                                    num3 = 63;
                                    if (dAT_F < 64)
                                    {
                                        num3 = dAT_F;
                                    }
                                }
                                dAT_F = DAT_B5570[num24 + 31] - DAT_B5570[num20];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    dAT_F = 0;
                                    num28 = (ushort)(dAT_F << 8);
                                }
                                else
                                {
                                    num28 = 16128;
                                    if (dAT_F < 64)
                                    {
                                        num28 = (ushort)(dAT_F << 8);
                                    }
                                }
                                primitives[num2 - 1].uvs = new Vector2Int(num3, num28 >> 8);
                                dAT_F = DAT_B5570[num24 + 1] - DAT_B5570[num24 - 1];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    num3 = 0;
                                }
                                else
                                {
                                    num3 = 63;
                                    if (dAT_F < 64)
                                    {
                                        num3 = dAT_F;
                                    }
                                }
                                dAT_F = DAT_B5570[num24 + 32] - DAT_B5570[num24 - 32];
                                if (dAT_F < 0)
                                {
                                    dAT_F += 15;
                                }
                                dAT_F = (dAT_F >> 4) + 32;
                                if (dAT_F < 0)
                                {
                                    dAT_F = 0;
                                    num28 = (ushort)(dAT_F << 8);
                                }
                                else
                                {
                                    num28 = 16128;
                                    if (dAT_F < 64)
                                    {
                                        num28 = (ushort)(dAT_F << 8);
                                    }
                                }
                                primitives[num2].uvs = new Vector2Int(num3, num28 >> 8);
                                Coprocessor.ExecuteAVSZ3();
                                if (((DAT_B5D70[num11] | DAT_B5D70[num11 - 32] | DAT_B5D70[num11 - 1]) & 1) == 0)
                                {
                                    primitives[num2 - 2].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx0, Coprocessor.screenXYFIFO.sy0);
                                    primitives[num2 - 2].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx0, Coprocessor.screenXYZFIFO.sy0, Coprocessor.screenXYZFIFO.sz0);
                                    primitives[num2 - 1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx1, Coprocessor.screenXYFIFO.sy1);
                                    primitives[num2 - 1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx1, Coprocessor.screenXYZFIFO.sy1, Coprocessor.screenXYZFIFO.sz1);
                                    primitives[num2].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx2, Coprocessor.screenXYFIFO.sy2);
                                    primitives[num2].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx2, Coprocessor.screenXYZFIFO.sy2, Coprocessor.screenXYZFIFO.sz2);
                                    newIndices[num] = num + 2;
                                    newIndices[num + 1] = num + 1;
                                    newIndices[num + 2] = num;
                                    dAT_F = Coprocessor.averageZ;
                                    num2 += 3;
                                    num += 3;
                                }
                                else
                                {
                                    num3 = DAT_B5570[num24 - 32];
                                    dAT_F = num3;
                                    if (num3 < 0)
                                    {
                                        dAT_F = num3 + 15;
                                    }
                                    Coprocessor.vector0.vx0 = (short)num18;
                                    Coprocessor.vector0.vy0 = (short)(dAT_F >> 4);
                                    Coprocessor.vector0.vz0 = (short)num23;
                                    int x = DAT_B5570[num24 - 1];
                                    dAT_F = x;
                                    if (x < 0)
                                    {
                                        dAT_F = x + 15;
                                    }
                                    Coprocessor.vector1.vx1 = (short)((num14 & 0xFF) * 256);
                                    Coprocessor.vector1.vy1 = (short)(dAT_F >> 4);
                                    Coprocessor.vector1.vz1 = (short)num27;
                                    int y = DAT_B5570[num24];
                                    dAT_F = y;
                                    if (y < 0)
                                    {
                                        dAT_F = y + 15;
                                    }
                                    Coprocessor.vector2.vx2 = (short)num18;
                                    Coprocessor.vector2.vy2 = (short)(dAT_F >> 4);
                                    Coprocessor.vector2.vz2 = (short)num27;
                                    uint num29 = (uint)(num5 + num14 + 1);
                                    uint num30 = (uint)(num25 + 1) >> 6;
                                    dAT_F = ((num25 + 1) & 0x3F) * 2;
                                    switch (Utilities.FUN_26B80(num, (terrain.vertices[(long)checked((IntPtr)unchecked(terrain.chunks[(num26 + (int)((num29 >> 6) * 128)) / 4] * 4096 + ((num25 & 0x3F) * 2 + (num29 & 0x3F) * 128) / 2))] & 0x7FF) * 128 - num10 - num3, (terrain.vertices[terrain.chunks[((uint)num15 >> 6) * 32 + num30] * 4096 + (dAT_F + (num15 & 0x3F) * 128) / 2] & 0x7FF) * 128 - num10 - x, (terrain.vertices[terrain.chunks[((uint)(num15 + 1) >> 6) * 32 + num30] * 4096 + (dAT_F + ((num15 + 1) & 0x3F) * 128) / 2] & 0x7FF) * 128 - num10 - y, primitives))
                                    {
                                        default:
                                            dAT_F = Coprocessor.averageZ;
                                            newIndices[num] = num + 2;
                                            newIndices[num + 1] = num + 1;
                                            newIndices[num + 2] = num;
                                            num2 += 3;
                                            num += 3;
                                            break;
                                        case 4:
                                            primitives[num + 5].verts = primitives[num + 3].verts;
                                            primitives[num + 4].verts = primitives[num + 2].verts;
                                            primitives[num + 3].verts = primitives[num + 1].verts;
                                            primitives[num + 5].uvs = primitives[num + 3].uvs;
                                            primitives[num + 4].uvs = primitives[num + 2].uvs;
                                            primitives[num + 3].uvs = primitives[num + 1].uvs;
                                            newIndices[num] = num + 2;
                                            newIndices[num + 1] = num + 1;
                                            newIndices[num + 2] = num;
                                            newIndices[num + 3] = num + 3;
                                            newIndices[num + 4] = num + 4;
                                            newIndices[num + 5] = num + 5;
                                            dAT_F = Coprocessor.averageZ;
                                            num2 += 6;
                                            num += 6;
                                            break;
                                        case 0:
                                            break;
                                    }
                                }
                            }
                            num15++;
                            num18 += 256;
                            num14++;
                            num11++;
                            num24++;
                            num20++;
                            num22++;
                        }
                        while (num14 < num7 - num5);
                    }
                    dAT_EDC++;
                    num21 += 256;
                }
                while (dAT_EDC < num8 - num6);
            }
        }
        int num31 = num;
        int translateFactor = GameManager.instance.translateFactor2;
        for (int i = 0; i < num31; i++)
        {
            newVertices[i] = new Vector3(primitives[i].verts.x, 0f - primitives[i].verts.y, primitives[i].verts.z) / translateFactor;
            newUVs[i] = new Vector2((float)primitives[i].uvs.x / (float)(mainT.width - 1), 1f - (float)primitives[i].uvs.y / (float)(mainT.height - 1));
        }
        mesh.Clear();
        mesh.SetVertices(newVertices, 0, num31);
        mesh.SetColors(newColors, 0, num31);
        mesh.SetUVs(0, newUVs, 0, num31);
        mesh.SetTriangles(newIndices, 0, num31, 0);
    }
}
