using System;
using Unity.Burst;
using UnityEngine;


[Serializable]
public struct Primitive
{
    public Vector3 verts;
    public Vector2Int screen;
    public Vector2Int uvs;
}

[BurstCompile]
// Token: 0x020001F1 RID: 497
public class Water : MonoBehaviour
{
    // Token: 0x06000C02 RID: 3074 RVA: 0x000A5504 File Offset: 0x000A3704
    private void Start()
    {
        if (Water.instance == null)
        {
            Water.instance = this;
            this.mesh = new Mesh();
            base.GetComponent<MeshFilter>().mesh = this.mesh;
            int num = 6000;
            this.newVertices = new Vector3[num];
            this.newColors = new Color32[num];
            this.newUVs = new Vector2[num];
            this.newIndices = new int[num];
            this.primitives = new Primitive[num];
            this.DAT_B5D70 = new byte[1024];
            this.DAT_B5570 = new short[1024];
            for (int i = 0; i < num; i += 6)
            {
                this.newColors[i] = new Color32(128, 128, 128, byte.MaxValue);
                this.newColors[i + 1] = new Color32(128, 128, 128, byte.MaxValue);
                this.newColors[i + 2] = new Color32(128, 128, 128, byte.MaxValue);
                this.newColors[i + 3] = new Color32(128, 128, 128, byte.MaxValue);
                this.newColors[i + 4] = new Color32(128, 128, 128, byte.MaxValue);
                this.newColors[i + 5] = new Color32(128, 128, 128, byte.MaxValue);
                this.newIndices[i] = i;
                this.newIndices[i + 1] = i + 1;
                this.newIndices[i + 2] = i + 2;
                this.newIndices[i + 3] = i + 3;
                this.newIndices[i + 4] = i + 4;
                this.newIndices[i + 5] = i + 5;
            }
            this.LOD = new Mesh();
            this.lod.GetComponent<MeshFilter>().mesh = this.LOD;
            int num2 = this.width * this.height * 4;
            this.newLODVertices = new Vector3[num2];
            this.newLODColors = new Color32[num2];
            this.newLODUVs = new Vector2[num2];
            this.newLODIndices = new int[num2 * 2];
            Color32 dat_DE = LevelManager.instance.DAT_DE0;
            dat_DE.a = 128;
            for (int j = 0; j < num2; j += 4)
            {
                this.newLODColors[j] = dat_DE;
                this.newLODColors[j + 1] = dat_DE;
                this.newLODColors[j + 2] = dat_DE;
                this.newLODColors[j + 3] = dat_DE;
                this.newLODUVs[j] = new Vector2(0f, 0f);
                this.newLODUVs[j + 1] = new Vector2(0f, 0f);
                this.newLODUVs[j + 2] = new Vector2(0f, 0f);
                this.newLODUVs[j + 3] = new Vector2(0f, 0f);
            }
            for (int k = 0; k < this.height; k++)
            {
                for (int l = 0; l < this.width; l++)
                {
                    int num3 = l + k * this.height;
                    int num4 = ((l < this.width / 2) ? (-l - 1) : (l - this.width / 2));
                    this.newLODVertices[num3 * 4] = new Vector3((float)(this.cellSize * num4), 0f, (float)(this.cellSize * k));
                    this.newLODVertices[num3 * 4 + 1] = new Vector3((float)(this.cellSize * num4 + this.cellSize), 0f, (float)(this.cellSize * k));
                    this.newLODVertices[num3 * 4 + 2] = new Vector3((float)(this.cellSize * num4), 0f, (float)(this.cellSize * k + this.cellSize));
                    this.newLODVertices[num3 * 4 + 3] = new Vector3((float)(this.cellSize * num4 + this.cellSize), 0f, (float)(this.cellSize * k + this.cellSize));
                }
            }
            int num5 = 0;
            int num6 = 0;
            for (int m = 0; m < num2; m += 4)
            {
                this.newLODIndices[num6] = m + 2;
                this.newLODIndices[num6 + 1] = m + 1;
                this.newLODIndices[num6 + 2] = m;
                this.newLODIndices[num6 + 3] = m + 1;
                this.newLODIndices[num6 + 4] = m + 2;
                this.newLODIndices[num6 + 5] = m + 3;
                num5 = num6 + 6;
                num6 += 6;
            }
            this.LOD.SetVertices(this.newLODVertices, 0, num2);
            this.LOD.SetColors(this.newLODColors, 0, num2);
            this.LOD.SetUVs(0, this.newLODUVs, 0, num2);
            this.LOD.SetIndices(this.newLODIndices, 0, num5, MeshTopology.Triangles, 0, true, 0);
        }
        this.terrain = UnityEngine.Object.FindObjectOfType<VigTerrain>();
        this.mainT = (Texture2D)UnityEngine.Object.FindObjectOfType<LevelManager>().DAT_DC0.mainTexture;
        this.lod2 = UnityEngine.Object.Instantiate<GameObject>(this.lod.gameObject, this.lod).transform;
        this.lod2.localEulerAngles = new Vector3(0f, 180f, 0f);

        Testing = new GameObject("Testing");
        canvasRectTransform = Testing.AddComponent<RectTransform>();

    }
    GameObject Testing;
    RectTransform canvasRectTransform;
    // Token: 0x06000C03 RID: 3075 RVA: 0x0000796D File Offset: 0x00005B6D
    private void Update()
    {
    }

    // Token: 0x06000C04 RID: 3076 RVA: 0x000A5AAC File Offset: 0x000A3CAC
    public void UpdatePosition(Vector3 pos)
    {
        Vector3 vector = new Vector3(pos.x, -pos.y, pos.z);
        Vector3 vector2 = this.masterRotation * Vector3.Scale(vector, this.masterScale) + this.masterPosition;
        base.transform.position = vector2;
        canvasRectTransform.position = vector2; //Actualiza posicion agua
    }

    // Token: 0x06000C05 RID: 3077 RVA: 0x000A5B04 File Offset: 0x000A3D04
    public void FUN_15F28(VigTransform param1, int param2)
    {
        this.masterPosition = new Vector3((float)param1.position.x / (float)GameManager.instance.translateFactor, (float)(-(float)param1.position.y) / (float)GameManager.instance.translateFactor, (float)param1.position.z / (float)GameManager.instance.translateFactor);
        this.masterRotation = param1.rotation.Matrix2Quaternion;
        this.masterRotation.eulerAngles = new Vector3(-this.masterRotation.eulerAngles.x, this.masterRotation.eulerAngles.y, -this.masterRotation.eulerAngles.z);
        this.masterScale = param1.rotation.Scale;
        this.lod_y = (float)GameManager.instance.DAT_DB0 / (float)GameManager.instance.translateFactor;
        Vector3 vector = new Vector3(this.lodOffset.x, -this.lodOffset.y, this.lodOffset.z);
        Vector3 vector2 = this.masterRotation * Vector3.Scale(vector, this.masterScale) + this.masterPosition;
        vector2.y = -this.lod_y;
        this.lod.position = vector2;
        this.lod.localEulerAngles = new Vector3(0f, this.masterRotation.eulerAngles.y, 0f);
        if (!this.topView)
        {
            if (this.lod2.gameObject.activeSelf)
            {
                this.lod2.gameObject.SetActive(false);
            }
            UIManager.instance.Underwater(this.masterPosition.y, this.lod.position.y);
            return;
        }
        if (!this.lod2.gameObject.activeSelf)
        {
            this.lod2.gameObject.SetActive(true);
        }
    }

    // Token: 0x06000C06 RID: 3078 RVA: 0x000A5CF0 File Offset: 0x000A3EF0
    public void FUN_16664(Vector3Int param1, int param2)
    {
        int num = GameManager.instance.DAT_F20;
        int num2 = GameManager.instance.DAT_EDC;
        int num3 = GameManager.instance.DAT_ED8;
        int num4 = 0;
        Utilities.FUN_246BC(GameManager.instance.DAT_F28);
        Vector3Int vector3Int = param1;
        Vector3Int vector3Int2;
        Vector3Int vector3Int3;
        Vector3Int vector3Int4;
        Vector3Int vector3Int5;
        if (vector3Int.z < 4081)
        {
            int num5 = vector3Int.y;
            int num6 = vector3Int.x;
            int num7 = num5;
            if (num5 < 0)
            {
                num7 = -num5;
            }
            int num8 = num6;
            if (num6 < 0)
            {
                num8 = -num6;
            }
            vector3Int2 = default(Vector3Int);
            if (num8 < num7)
            {
                vector3Int2.x = num2 * -256 / 2;
                vector3Int2.z = num3 << 8;
                param2 *= 4096;
                vector3Int2.y = (param2 - num6 * vector3Int2.x - vector3Int.z * vector3Int2.z) / num5;
                vector3Int3 = Utilities.FUN_24008(vector3Int2);
                vector3Int2.x = num2 * 128;
                vector3Int2.y = (param2 - vector3Int.x * vector3Int2.x - vector3Int.z * vector3Int2.z) / vector3Int.y;
                vector3Int4 = Utilities.FUN_24008(vector3Int2);
                vector3Int2.x = num2 * -3072 / 2;
                vector3Int2.z = (num3 << 1) + num3 << 10;
                vector3Int2.y = (param2 - vector3Int.x * vector3Int2.x - vector3Int.z * vector3Int2.z) / vector3Int.y;
                vector3Int5 = Utilities.FUN_24008(vector3Int2);
                vector3Int2.x = num2 * 1536;
                vector3Int2.y = (param2 - vector3Int.x * vector3Int2.x - vector3Int.z * vector3Int2.z) / vector3Int.y;
            }
            else
            {
                vector3Int2.y = num * -256 / 2;
                vector3Int2.z = num3 << 8;
                param2 *= 4096;
                vector3Int2.x = (param2 - num5 * vector3Int2.y - vector3Int.z * vector3Int2.z) / num6;
                vector3Int3 = Utilities.FUN_24008(vector3Int2);
                vector3Int2.y = num * 128;
                vector3Int2.x = (param2 - vector3Int.y * vector3Int2.y - vector3Int.z * vector3Int2.z) / vector3Int.x;
                vector3Int4 = Utilities.FUN_24008(vector3Int2);
                vector3Int2.y = num * -3072 / 2;
                vector3Int2.z = (num3 << 1) + num3 << 10;
                vector3Int2.x = (param2 - vector3Int.y * vector3Int2.y - vector3Int.z * vector3Int2.z) / vector3Int.x;
                vector3Int5 = Utilities.FUN_24008(vector3Int2);
                vector3Int2.y = num * 1536;
                vector3Int2.x = (param2 - vector3Int.y * vector3Int2.y - vector3Int.z * vector3Int2.z) / vector3Int.x;
            }
        }
        else
        {
            vector3Int2 = default(Vector3Int);
            int num7 = -num2;
            param2 = num3 * param2 << 12;
            vector3Int2.z = param2 / (num7 * vector3Int.x / 2 - num * vector3Int.y / 2 + num3 * vector3Int.z);
            vector3Int2.x = num7 * vector3Int2.z / num3;
            vector3Int2.y = -num * vector3Int2.z / num3;
            vector3Int3 = Utilities.FUN_24008(vector3Int2);
            vector3Int2.z = param2 / (num2 * vector3Int.x / 2 - num * vector3Int.y / 2 + num3 * vector3Int.z);
            vector3Int2.x = num2 * vector3Int2.z / num3;
            vector3Int2.y = -num * vector3Int2.z / num3;
            vector3Int4 = Utilities.FUN_24008(vector3Int2);
            vector3Int2.z = param2 / (num7 * vector3Int.x / 2 + num * vector3Int.y / 2 + num3 * vector3Int.z);
            vector3Int2.x = num7 * vector3Int2.z / num3;
            vector3Int2.y = num * vector3Int2.z / num3;
            vector3Int5 = Utilities.FUN_24008(vector3Int2);
            vector3Int2.z = param2 / (num2 * vector3Int.x / 2 + num * vector3Int.y / 2 + num3 * vector3Int.z);
            vector3Int2.x = num2 * vector3Int2.z / num3;
            vector3Int2.y = num * vector3Int2.z / num3;
        }
        Vector3Int vector3Int6 = Utilities.FUN_24008(vector3Int2);
        num2 = vector3Int4.x;
        if (vector3Int3.x < vector3Int4.x)
        {
            num2 = vector3Int3.x;
        }
        num = vector3Int5.x;
        if (num2 < vector3Int5.x)
        {
            num = num2;
        }
        num2 = vector3Int6.x;
        if (num < vector3Int6.x)
        {
            num2 = num;
        }
        int num9 = num2 >> 16;
        num2 = vector3Int4.z;
        if (vector3Int3.z < vector3Int4.z)
        {
            num2 = vector3Int3.z;
        }
        num = vector3Int5.z;
        if (num2 < vector3Int5.z)
        {
            num = num2;
        }
        int num10 = vector3Int6.z;
        if (num < vector3Int6.z)
        {
            num10 = num;
        }
        num10 >>= 16;
        if (vector3Int4.x < vector3Int3.x)
        {
            vector3Int4.x = vector3Int3.x;
        }
        if (vector3Int5.x < vector3Int4.x)
        {
            vector3Int5.x = vector3Int4.x;
        }
        if (vector3Int6.x < vector3Int5.x)
        {
            vector3Int6.x = vector3Int5.x;
        }
        int num11 = vector3Int6.x + 65535 >> 16;
        if (vector3Int4.z < vector3Int3.z)
        {
            vector3Int4.z = vector3Int3.z;
        }
        if (vector3Int5.z < vector3Int4.z)
        {
            vector3Int5.z = vector3Int4.z;
        }
        if (vector3Int6.z < vector3Int5.z)
        {
            vector3Int6.z = vector3Int5.z;
        }
        num2 = GameManager.instance.DAT_DA0 >> 16;
        int num12 = vector3Int6.z + 65535 >> 16;
        if (num12 <= num2 || num10 < num2)
        {
            if (num12 > num2)
            {
                num12 = num2;
            }
            if (31 < num11 - num9)
            {
                num11 = num9 + 31;
            }
            if (31 < num12 - num10)
            {
                num12 = num10 + 31;
            }
            Utilities.SetRotMatrix(GameManager.instance.DAT_F00.rotation);
            vector3Int2.x = num9 << 8;
            vector3Int2.y = GameManager.instance.DAT_DB0;
            if (GameManager.instance.DAT_DB0 < 0)
            {
                vector3Int2.y = GameManager.instance.DAT_DB0 + 255;
            }
            vector3Int2.y >>= 8;
            vector3Int2.z = num10 << 8;
            vector3Int2 = Utilities.FUN_23F7C(vector3Int2);
            int num13 = GameManager.instance.DAT_F00.position.x;
            if (num13 < 0)
            {
                num13 += 255;
            }
            vector3Int2.x += num13 >> 8;
            num13 = GameManager.instance.DAT_F00.position.y;
            if (num13 < 0)
            {
                num13 += 255;
            }
            vector3Int2.y += num13 >> 8;
            num13 = GameManager.instance.DAT_F00.position.z;
            if (num13 < 0)
            {
                num13 += 255;
            }
            vector3Int2.z += num13 >> 8;
            this.UpdatePosition((Vector3)new Vector3Int(vector3Int2.x << 8, vector3Int2.y << 8, vector3Int2.z << 8) / (float)GameManager.instance.translateFactor);
            Coprocessor.translationVector._trx = vector3Int2.x;
            Coprocessor.translationVector._try = vector3Int2.y;
            Coprocessor.translationVector._trz = vector3Int2.z;
            num2 = GameManager.instance.DAT_DB0;
            if (GameManager.instance.DAT_DB0 < 0)
            {
                num2 = GameManager.instance.DAT_DB0 + 2047;
            }
            int num14 = num2 >> 11;
            num = 0;
            if (-1 < num12 - num10)
            {
                num13 = (num3 << 1) + num3 << 2;
                int num7 = 0;
                do
                {
                    Coprocessor.vector0.vz0 = (short)(num << 8);
                    int num6 = 0;
                    if (-1 < num11 - num9)
                    {
                        int num15 = num7;
                        do
                        {
                            Coprocessor.vector0.vx0 = (short)(num6 << 8);
                            Coprocessor.vector0.vy0 = (short)(num6 << 8 >> 16);
                            Coprocessor.ExecuteRTPS(12, false);
                            Cop2SxyFIFO screenXYFIFO = Coprocessor.screenXYFIFO;
                            num7 = (int)Coprocessor.screenXYFIFO.sy2;
                            int num5 = (int)Coprocessor.screenZFIFO.sz3;
                            int num16 = (((int)(this.terrain.vertices[(int)(this.terrain.chunks[(int)(((uint)(num6 + num9) >> 6) * 32U + ((uint)(num + num10) >> 6))] * 4096) + (((num + num10) & 63) * 2 + ((num6 + num9) & 63) * 128) / 2] & 2047) < num14) ? 1 : 0);
                            byte b = 0;
                            num6++;
                            this.DAT_B5D70[num15] = b;
                            num15++;
                        }
                        while (num6 <= num12 - num10);
                    }
                    num++;
                    num7 = num * 32;
                }
                while (num <= num12 - num10);
            }
            int num17 = GameManager.instance.DAT_28 << 12;
            int num18 = (int)((long)num17 * -2004318071L >> 32) + num17;
            num17 >>= 31;
            num18 = (num18 >> 7) - num17;
            int num19 = num10 * 873 + num18;
            num2 = 0;
            if (-1 < num12 - num10)
            {
                num3 = num9 * 873;
                num14 = -1610571775;
                do
                {
                    num17 = GameManager.instance.DAT_28 << 12;
                    num18 = (int)((long)num17 * -2004318071L >> 32) + num17;
                    num17 >>= 31;
                    num18 = (num18 >> 7) - num17;
                    int num20 = num3 + num18;
                    num = 0;
                    int num21 = num2 * 32;
                    int num15 = num2 * 32;
                    if (-1 < num11 - num9)
                    {
                        int num22 = 33 + num2 * 32;
                        do
                        {
                            if ((this.DAT_B5D70[num22] & this.DAT_B5D70[num22 - 1] & this.DAT_B5D70[num15] & this.DAT_B5D70[num22 - 32]) != 0)
                            {
                                byte[] dat_B5D = this.DAT_B5D70;
                                int num23 = num15;
                                dat_B5D[num23] |= 128;
                            }
                            int num24 = num20 & 4095;
                            int num25 = (int)((ulong)((long)(GameManager.DAT_65C90[num24 * 4 / 2] * GameManager.DAT_65C90[(num19 & 4095) * 4 / 2]) * (long)num14) >> 32);
                            num++;
                            num22++;
                            num15++;
                            num20 += 873;
                            num18 = (int)(GameManager.DAT_65C90[num24 * 4 / 2] * GameManager.DAT_65C90[(num19 & 4095) * 4 / 2]);
                            num17 = num25 + num18 >> 14;
                            num17 -= num18 >> 31;
                            this.DAT_B5570[num21] = (short)num17;
                            num21++;
                        }
                        while (num <= num11 - num9);
                    }
                    num2++;
                    num19 += 873;
                }
                while (num2 <= num12 - num10);
            }
            num17 = GameManager.instance.DAT_28 << 12;
            num18 = (int)((long)num17 * -1677082467L >> 32) + num17;
            num17 >>= 31;
            num18 = (num18 >> 8) - num17;
            num19 = num10 * 1456 + num18;
            num2 = 0;
            if (-1 < num12 - num10)
            {
                num3 = num9 * 1456;
                do
                {
                    num = 0;
                    int num26 = num2 * 32;
                    int num15 = num2 * 32;
                    num17 = GameManager.instance.DAT_28 << 12;
                    num18 = (int)((long)num17 * -1677082467L >> 32) + num17;
                    num17 >>= 31;
                    num18 = (num18 >> 8) - num17;
                    int num20 = num3 + num18;
                    if (-1 < num11 - num9)
                    {
                        do
                        {
                            if ((this.DAT_B5D70[num15] & 4) == 0)
                            {
                                int num7 = (int)(GameManager.DAT_65C90[(num20 & 4095) * 4 / 2] * GameManager.DAT_65C90[(num19 & 4095) * 4 / 2]);
                                if (num7 < 0)
                                {
                                    num7 += 131071;
                                }
                                short[] dat_B = this.DAT_B5570;
                                int num27 = num26;
                                dat_B[num27] += (short)(num7 >> 17);
                            }
                            else
                            {
                                this.DAT_B5570[num26] = 0;
                            }
                            num++;
                            num15++;
                            num26++;
                            num20 += 1456;
                        }
                        while (num <= num11 - num9);
                    }
                    num2++;
                    num19 += 1456;
                }
                while (num2 <= num12 - num10);
            }
            num14 = GameManager.instance.DAT_DB0;
            if (GameManager.instance.DAT_DB0 < 0)
            {
                num14 = GameManager.instance.DAT_DB0 + 15;
            }
            num14 >>= 4;
            num2 = 0;
            if (0 < num12 - num10)
            {
                int num28 = 256;
                do
                {
                    int num26 = num2 * 32;
                    int num29 = num2 * 32;
                    num19 = 0;
                    if (0 < num11 - num9)
                    {
                        int num30 = num2 << 8;
                        int num31 = 33 + num2 * 32;
                        int num15 = 33 + num2 * 32;
                        int num24 = 256;
                        int num32 = num4 + 2;
                        int num33 = num2 + num10;
                        int num34 = (int)((int)((uint)num33 >> 6) << 2);
                        int num35 = num28;
                        int num20 = num9;
                        do
                        {
                            if ((this.DAT_B5D70[num29] & 128) == 0)
                            {
                                num = (int)this.DAT_B5570[num26];
                                int num7 = (num19 & 255) * 256;
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                Coprocessor.vector0.vx0 = (short)num7;
                                Coprocessor.vector0.vy0 = (short)(num >> 4);
                                Coprocessor.vector0.vz0 = (short)num30;
                                num = (int)this.DAT_B5570[num31 - 32];
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                Coprocessor.vector1.vx1 = (short)num24;
                                Coprocessor.vector1.vy1 = (short)(num >> 4);
                                Coprocessor.vector1.vz1 = (short)num30;
                                num = (int)this.DAT_B5570[num31 - 1];
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                Coprocessor.vector2.vx2 = (short)num7;
                                Coprocessor.vector2.vy2 = (short)(num >> 4);
                                Coprocessor.vector2.vz2 = (short)num35;
                                Coprocessor.ExecuteRTPT(12, false);
                                num17 = 0;
                                if (num31 - 34 >= 0)
                                {
                                    num17 = (int)this.DAT_B5570[num31 - 34];
                                }
                                num = (int)this.DAT_B5570[num31 - 32] - num17;
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num7 = 0;
                                }
                                else
                                {
                                    num7 = 63;
                                    if (num < 64)
                                    {
                                        num7 = num;
                                    }
                                }
                                num17 = 0;
                                if (num31 - 65 >= 0)
                                {
                                    num17 = (int)this.DAT_B5570[num31 - 65];
                                }
                                num = (int)this.DAT_B5570[num31 - 1] - num17;
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                ushort num36;
                                if (num < 0)
                                {
                                    num = 0;
                                    num36 = (ushort)(num << 8);
                                }
                                else
                                {
                                    num36 = 16128;
                                    if (num < 64)
                                    {
                                        num36 = (ushort)(num << 8);
                                    }
                                }
                                this.primitives[num32 - 2].uvs = new Vector2Int(num7, num36 >> 8);
                                num = (int)(this.DAT_B5570[num31 - 31] - this.DAT_B5570[num26]);
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num7 = 0;
                                }
                                else
                                {
                                    num7 = 63;
                                    if (num < 64)
                                    {
                                        num7 = num;
                                    }
                                }
                                num17 = 0;
                                if (num31 - 64 >= 0)
                                {
                                    num17 = (int)this.DAT_B5570[num31 - 64];
                                }
                                num = (int)this.DAT_B5570[num31] - num17;
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num = 0;
                                    num36 = (ushort)(num << 8);
                                }
                                else
                                {
                                    num36 = 16128;
                                    if (num < 64)
                                    {
                                        num36 = (ushort)(num << 8);
                                    }
                                }
                                this.primitives[num32 - 1].uvs = new Vector2Int(num7, num36 >> 8);
                                num = (int)(this.DAT_B5570[num31] - this.DAT_B5570[num31 - 2]);
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num7 = 0;
                                }
                                else
                                {
                                    num7 = 63;
                                    if (num < 64)
                                    {
                                        num7 = num;
                                    }
                                }
                                num = (int)(this.DAT_B5570[num31 + 31] - this.DAT_B5570[num26]);
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num = 0;
                                    num36 = (ushort)(num << 8);
                                }
                                else
                                {
                                    num36 = 16128;
                                    if (num < 64)
                                    {
                                        num36 = (ushort)(num << 8);
                                    }
                                }
                                this.primitives[num32].uvs = new Vector2Int(num7, num36 >> 8);
                                Coprocessor.ExecuteAVSZ3();
                                if (((this.DAT_B5D70[num15 - 1] | this.DAT_B5D70[num29] | this.DAT_B5D70[num15 - 32]) & 1) == 0)
                                {
                                    this.primitives[num32 - 2].screen = new Vector2Int((int)Coprocessor.screenXYFIFO.sx0, (int)Coprocessor.screenXYFIFO.sy0);
                                    this.primitives[num32 - 2].verts = new Vector3Int((int)Coprocessor.screenXYZFIFO.sx0, (int)Coprocessor.screenXYZFIFO.sy0, (int)Coprocessor.screenXYZFIFO.sz0);
                                    this.primitives[num32 - 1].screen = new Vector2Int((int)Coprocessor.screenXYFIFO.sx1, (int)Coprocessor.screenXYFIFO.sy1);
                                    this.primitives[num32 - 1].verts = new Vector3Int((int)Coprocessor.screenXYZFIFO.sx1, (int)Coprocessor.screenXYZFIFO.sy1, (int)Coprocessor.screenXYZFIFO.sz1);
                                    this.primitives[num32].screen = new Vector2Int((int)Coprocessor.screenXYFIFO.sx2, (int)Coprocessor.screenXYFIFO.sy2);
                                    this.primitives[num32].verts = new Vector3Int((int)Coprocessor.screenXYZFIFO.sx2, (int)Coprocessor.screenXYZFIFO.sy2, (int)Coprocessor.screenXYZFIFO.sz2);
                                    this.newIndices[num4] = num4;
                                    this.newIndices[num4 + 1] = num4 + 1;
                                    this.newIndices[num4 + 2] = num4 + 2;
                                    num = (int)this.DAT_B5570[num31];
                                    if (num < 0)
                                    {
                                        num += 15;
                                    }
                                    Coprocessor.vector0.vx0 = (short)num24;
                                    Coprocessor.vector0.vy0 = (short)(num >> 4);
                                    Coprocessor.vector0.vz0 = (short)num35;
                                    Coprocessor.ExecuteRTPS(12, false);
                                    num = (int)Coprocessor.averageZ;
                                    num32 += 3;
                                    num4 += 3;
                                }
                                else
                                {
                                    num7 = (num20 & 63) * 128;
                                    num = (num33 & 63) * 2;
                                    num = Utilities.FUN_26B80(num4, (int)((this.terrain.vertices[(int)(this.terrain.chunks[(num34 + (int)(((uint)num20 >> 6) * 128U)) / 4] * 4096) + (num + num7) / 2] & 2047) * 128) - num14 - (int)this.DAT_B5570[num26], (int)((this.terrain.vertices[(int)(this.terrain.chunks[(num34 + (int)(((uint)(num20 + 1) >> 6) * 128U)) / 4] * 4096) + (num + ((num20 + 1) & 63) * 128) / 2] & 2047) * 128) - num14 - (int)this.DAT_B5570[num31 - 32], (int)((this.terrain.vertices[(int)(this.terrain.chunks[(int)(((uint)num20 >> 6) * 32U + ((uint)(num33 + 1) >> 6))] * 4096) + (((num33 + 1) & 63) * 2 + num7) / 2] & 2047) * 128) - num14 - (int)this.DAT_B5570[num31 - 1], this.primitives);
                                    num7 = (int)Coprocessor.averageZ;
                                    int num6 = (int)this.DAT_B5570[num31 - 32];
                                    if (num6 < 0)
                                    {
                                        num6 += 15;
                                    }
                                    Coprocessor.vector0.vx0 = (short)num24;
                                    Coprocessor.vector0.vy0 = (short)(num6 >> 4);
                                    Coprocessor.vector0.vz0 = (short)num30;
                                    num7 = (int)this.DAT_B5570[num31 - 1];
                                    if (num7 < 0)
                                    {
                                        num7 += 15;
                                    }
                                    Coprocessor.vector1.vx1 = (short)((num19 & 255) * 256);
                                    Coprocessor.vector1.vy1 = (short)(num7 >> 4);
                                    Coprocessor.vector1.vz1 = (short)num35;
                                    num7 = (int)this.DAT_B5570[num31];
                                    if (num7 < 0)
                                    {
                                        num7 += 15;
                                    }
                                    Coprocessor.vector2.vx2 = (short)num24;
                                    Coprocessor.vector2.vy2 = (short)(num7 >> 4);
                                    Coprocessor.vector2.vz2 = (short)num35;
                                    Coprocessor.ExecuteRTPT(12, false);
                                    if (num != 0)
                                    {
                                        if (num != 4)
                                        {
                                            this.newIndices[num4] = num4;
                                            this.newIndices[num4 + 1] = num4 + 1;
                                            this.newIndices[num4 + 2] = num4 + 2;
                                            num32 += 3;
                                            num4 += 3;
                                        }
                                        else
                                        {
                                            this.primitives[num4 + 5].verts = this.primitives[num4 + 3].verts;
                                            this.primitives[num4 + 4].verts = this.primitives[num4 + 2].verts;
                                            this.primitives[num4 + 3].verts = this.primitives[num4 + 1].verts;
                                            this.primitives[num4 + 5].uvs = this.primitives[num4 + 3].uvs;
                                            this.primitives[num4 + 4].uvs = this.primitives[num4 + 2].uvs;
                                            this.primitives[num4 + 3].uvs = this.primitives[num4 + 1].uvs;
                                            this.newIndices[num4] = num4;
                                            this.newIndices[num4 + 1] = num4 + 1;
                                            this.newIndices[num4 + 2] = num4 + 2;
                                            this.newIndices[num4 + 3] = num4 + 5;
                                            this.newIndices[num4 + 4] = num4 + 4;
                                            this.newIndices[num4 + 5] = num4 + 3;
                                            num32 += 6;
                                            num4 += 6;
                                        }
                                    }
                                }
                                num = (int)(this.DAT_B5570[num31 - 31] - this.DAT_B5570[num26]);
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num7 = 0;
                                }
                                else
                                {
                                    num7 = 63;
                                    if (num < 64)
                                    {
                                        num7 = num;
                                    }
                                }
                                num17 = 0;
                                if (num31 - 64 >= 0)
                                {
                                    num17 = (int)this.DAT_B5570[num31 - 64];
                                }
                                num = (int)this.DAT_B5570[num31] - num17;
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num = 0;
                                    num36 = (ushort)(num << 8);
                                }
                                else
                                {
                                    num36 = 16128;
                                    if (num < 64)
                                    {
                                        num36 = (ushort)(num << 8);
                                    }
                                }
                                this.primitives[num32 - 2].uvs = new Vector2Int(num7, num36 >> 8);
                                num = (int)(this.DAT_B5570[num31] - this.DAT_B5570[num31 - 2]);
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num7 = 0;
                                }
                                else
                                {
                                    num7 = 63;
                                    if (num < 64)
                                    {
                                        num7 = num;
                                    }
                                }
                                num = (int)(this.DAT_B5570[num31 + 31] - this.DAT_B5570[num26]);
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num = 0;
                                    num36 = (ushort)(num << 8);
                                }
                                else
                                {
                                    num36 = 16128;
                                    if (num < 64)
                                    {
                                        num36 = (ushort)(num << 8);
                                    }
                                }
                                this.primitives[num32 - 1].uvs = new Vector2Int(num7, num36 >> 8);
                                num = (int)(this.DAT_B5570[num31 + 1] - this.DAT_B5570[num31 - 1]);
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num7 = 0;
                                }
                                else
                                {
                                    num7 = 63;
                                    if (num < 64)
                                    {
                                        num7 = num;
                                    }
                                }
                                num = (int)(this.DAT_B5570[num31 + 32] - this.DAT_B5570[num31 - 32]);
                                if (num < 0)
                                {
                                    num += 15;
                                }
                                num = (num >> 4) + 32;
                                if (num < 0)
                                {
                                    num = 0;
                                    num36 = (ushort)(num << 8);
                                }
                                else
                                {
                                    num36 = 16128;
                                    if (num < 64)
                                    {
                                        num36 = (ushort)(num << 8);
                                    }
                                }
                                this.primitives[num32].uvs = new Vector2Int(num7, num36 >> 8);
                                Coprocessor.ExecuteAVSZ3();
                                if (((this.DAT_B5D70[num15] | this.DAT_B5D70[num15 - 32] | this.DAT_B5D70[num15 - 1]) & 1) == 0)
                                {
                                    this.primitives[num32 - 2].screen = new Vector2Int((int)Coprocessor.screenXYFIFO.sx0, (int)Coprocessor.screenXYFIFO.sy0);
                                    this.primitives[num32 - 2].verts = new Vector3Int((int)Coprocessor.screenXYZFIFO.sx0, (int)Coprocessor.screenXYZFIFO.sy0, (int)Coprocessor.screenXYZFIFO.sz0);
                                    this.primitives[num32 - 1].screen = new Vector2Int((int)Coprocessor.screenXYFIFO.sx1, (int)Coprocessor.screenXYFIFO.sy1);
                                    this.primitives[num32 - 1].verts = new Vector3Int((int)Coprocessor.screenXYZFIFO.sx1, (int)Coprocessor.screenXYZFIFO.sy1, (int)Coprocessor.screenXYZFIFO.sz1);
                                    this.primitives[num32].screen = new Vector2Int((int)Coprocessor.screenXYFIFO.sx2, (int)Coprocessor.screenXYFIFO.sy2);
                                    this.primitives[num32].verts = new Vector3Int((int)Coprocessor.screenXYZFIFO.sx2, (int)Coprocessor.screenXYZFIFO.sy2, (int)Coprocessor.screenXYZFIFO.sz2);
                                    this.newIndices[num4] = num4 + 2;
                                    this.newIndices[num4 + 1] = num4 + 1;
                                    this.newIndices[num4 + 2] = num4;
                                    num = (int)Coprocessor.averageZ;
                                    num32 += 3;
                                    num4 += 3;
                                }
                                else
                                {
                                    num7 = (int)this.DAT_B5570[num31 - 32];
                                    num = num7;
                                    if (num7 < 0)
                                    {
                                        num = num7 + 15;
                                    }
                                    Coprocessor.vector0.vx0 = (short)num24;
                                    Coprocessor.vector0.vy0 = (short)(num >> 4);
                                    Coprocessor.vector0.vz0 = (short)num30;
                                    int num6 = (int)this.DAT_B5570[num31 - 1];
                                    num = num6;
                                    if (num6 < 0)
                                    {
                                        num = num6 + 15;
                                    }
                                    Coprocessor.vector1.vx1 = (short)((num19 & 255) * 256);
                                    Coprocessor.vector1.vy1 = (short)(num >> 4);
                                    Coprocessor.vector1.vz1 = (short)num35;
                                    int num5 = (int)this.DAT_B5570[num31];
                                    num = num5;
                                    if (num5 < 0)
                                    {
                                        num = num5 + 15;
                                    }
                                    Coprocessor.vector2.vx2 = (short)num24;
                                    Coprocessor.vector2.vy2 = (short)(num >> 4);
                                    Coprocessor.vector2.vz2 = (short)num35;
                                    uint num37 = (uint)(num9 + num19 + 1);
                                    uint num38 = (uint)(num33 + 1) >> 6;
                                    num = ((num33 + 1) & 63) * 2;
                                    num = Utilities.FUN_26B80(num4, (int)((this.terrain.vertices[(int)(checked((IntPtr)(unchecked((long)(this.terrain.chunks[(num34 + (int)((num37 >> 6) * 128U)) / 4] * 4096) + ((long)((num33 & 63) * 2) + (long)((ulong)((num37 & 63U) * 128U))) / 2L))))] & 2047) * 128) - num14 - num7, (int)((this.terrain.vertices[(int)(this.terrain.chunks[(int)(((uint)num20 >> 6) * 32U + num38)] * 4096) + (num + (num20 & 63) * 128) / 2] & 2047) * 128) - num14 - num6, (int)((this.terrain.vertices[(int)(this.terrain.chunks[(int)(((uint)(num20 + 1) >> 6) * 32U + num38)] * 4096) + (num + ((num20 + 1) & 63) * 128) / 2] & 2047) * 128) - num14 - num5, this.primitives);
                                    if (num != 0)
                                    {
                                        if (num != 4)
                                        {
                                            num = (int)Coprocessor.averageZ;
                                            this.newIndices[num4] = num4 + 2;
                                            this.newIndices[num4 + 1] = num4 + 1;
                                            this.newIndices[num4 + 2] = num4;
                                            num32 += 3;
                                            num4 += 3;
                                        }
                                        else
                                        {
                                            this.primitives[num4 + 5].verts = this.primitives[num4 + 3].verts;
                                            this.primitives[num4 + 4].verts = this.primitives[num4 + 2].verts;
                                            this.primitives[num4 + 3].verts = this.primitives[num4 + 1].verts;
                                            this.primitives[num4 + 5].uvs = this.primitives[num4 + 3].uvs;
                                            this.primitives[num4 + 4].uvs = this.primitives[num4 + 2].uvs;
                                            this.primitives[num4 + 3].uvs = this.primitives[num4 + 1].uvs;
                                            this.newIndices[num4] = num4 + 2;
                                            this.newIndices[num4 + 1] = num4 + 1;
                                            this.newIndices[num4 + 2] = num4;
                                            this.newIndices[num4 + 3] = num4 + 3;
                                            this.newIndices[num4 + 4] = num4 + 4;
                                            this.newIndices[num4 + 5] = num4 + 5;
                                            num = (int)Coprocessor.averageZ;
                                            num32 += 6;
                                            num4 += 6;
                                        }
                                    }
                                }
                            }
                            num20++;
                            num24 += 256;
                            num19++;
                            num15++;
                            num31++;
                            num26++;
                            num29++;
                        }
                        while (num19 < num11 - num9);
                    }
                    num2++;
                    num28 += 256;
                }
                while (num2 < num12 - num10);
            }
        }
        int num39 = num4;
        int translateFactor = GameManager.instance.translateFactor2;
        for (int i = 0; i < num39; i++)
        {
            this.newVertices[i] = new Vector3(this.primitives[i].verts.x, -this.primitives[i].verts.y, this.primitives[i].verts.z) / (float)translateFactor;
            this.newUVs[i] = new Vector2((float)this.primitives[i].uvs.x / (float)(this.mainT.width - 1), 1f - (float)this.primitives[i].uvs.y / (float)(this.mainT.height - 1));
        }
        this.mesh.Clear();
        this.mesh.SetVertices(this.newVertices, 0, num39);
        this.mesh.SetColors(this.newColors, 0, num39);
        this.mesh.SetUVs(0, this.newUVs, 0, num39);
        this.mesh.SetTriangles(this.newIndices, 0, num39, 0, true, 0);
    }


    // Token: 0x0400088C RID: 2188
    public static Water instance;


    [SerializeField]
    // Token: 0x0400088D RID: 2189
    public Transform lod;

    // Token: 0x0400088E RID: 2190
    public Vector3 lodOffset;

    // Token: 0x0400088F RID: 2191
    public bool topView;

    // Token: 0x04000890 RID: 2192
    public int width;

    // Token: 0x04000891 RID: 2193
    public int height;

    // Token: 0x04000892 RID: 2194
    public int cellSize;

    // Token: 0x04000893 RID: 2195
    public short[] DAT_B5570;

    // Token: 0x04000894 RID: 2196
    public byte[] DAT_B5D70;

    // Token: 0x04000895 RID: 2197
    public Mesh mesh;

    // Token: 0x04000896 RID: 2198
    public Mesh LOD;

    // Token: 0x04000897 RID: 2199
    private Vector3[] newVertices;

    // Token: 0x04000898 RID: 2200
    public Vector2[] newUVs;

    // Token: 0x04000899 RID: 2201
    public Color32[] newColors;

    // Token: 0x0400089A RID: 2202
    public int[] newIndices;

    // Token: 0x0400089B RID: 2203
    public Vector3[] newLODVertices;

    // Token: 0x0400089C RID: 2204
    public Vector2[] newLODUVs;

    // Token: 0x0400089D RID: 2205
    public Color32[] newLODColors;

    // Token: 0x0400089E RID: 2206
    public int[] newLODIndices;

    // Token: 0x0400089F RID: 2207
    public VigTerrain terrain;

    // Token: 0x040008A0 RID: 2208
    public Primitive[] primitives;

    // Token: 0x040008A1 RID: 2209
    public Texture2D mainT;

    // Token: 0x040008A2 RID: 2210
    public float lod_y;

    // Token: 0x040008A3 RID: 2211
    public Vector3 masterPosition;

    // Token: 0x040008A4 RID: 2212
    public Quaternion masterRotation;

    // Token: 0x040008A5 RID: 2213
    public Vector3 masterScale;

    // Token: 0x040008A6 RID: 2214
    public Transform lod2;
}
