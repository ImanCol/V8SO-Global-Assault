using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001EF RID: 495
public class VigTerrain : MonoBehaviour
{
    // Token: 0x06000BE7 RID: 3047 RVA: 0x0009ECD0 File Offset: 0x0009CED0
    private void Awake()
    {
        if (VigTerrain.instance == null)
        {
            VigTerrain.instance = this;
        }
        if (base.GetComponent<MeshFilter>() != null)
        {
            this.terrainMesh = new Mesh();
            this.terrainMesh.subMeshCount = 17;
            this.canvasSky = GameObject.Find("CanvasSky").GetComponent<RectTransform>();
            this.sbParent = GameObject.Find("SB").GetComponent<RectTransform>();
            this.skybox = GameObject.Find("SkyBox").GetComponent<RectTransform>();
            this.skyboxRight = GameObject.Find("SkyBoxRight").GetComponent<RectTransform>();
            this.skyboxLeft = GameObject.Find("SkyBoxLeft").GetComponent<RectTransform>();
            this.sbTop = GameObject.Find("SB_Top").GetComponent<RectTransform>();
            this.sbTopRight = GameObject.Find("SB_TopRight").GetComponent<RectTransform>();
            this.sbTopLeft = GameObject.Find("SB_TopLeft").GetComponent<RectTransform>();
            this.sbBottom = GameObject.Find("SB_Bottom").GetComponent<RectTransform>();
            this.sbBottomRight = GameObject.Find("SB_BottomRight").GetComponent<RectTransform>();
            this.sbBottomLeft = GameObject.Find("SB_BottomLeft").GetComponent<RectTransform>();
            this.skyboxMat = this.skybox.GetComponent<Image>().material;
            base.GetComponent<MeshFilter>().mesh = this.terrainMesh;
            Material material = base.GetComponent<MeshRenderer>().materials[1];
            VigTerrain.mainT = base.GetComponent<MeshRenderer>().materials[1].mainTexture;
            this.DAT_BDFF0 = new VigTransform[2];
        }
        if (this.tileData == null || this.tileData.Count == 0)
        {
            this.tileData = new List<TileData>();
            TileData tileData = new TileData();
            tileData.DAT_10 = new short[6];
            this.tileData.Add(tileData);
        }
    }

    // Token: 0x06000BE8 RID: 3048 RVA: 0x0009EE98 File Offset: 0x0009D098
    private void Start()
    {
        if (GameManager.instance.inMenu)
        {
            return;
        }
        VigTerrain.newVertices = new Vector3[32768];
        VigTerrain.newColors = new Color32[32768];
        VigTerrain.newUVs = new Vector2[32768];
        VigTerrain.newTriangles = new int[17][];
        VigTerrain.newTriangles[0] = new int[32768];
        VigTerrain.index2 = new int[16];
        VigTerrain.newTriangles[1] = new int[32768];
        VigTerrain._tileData = this.tileData;
        VigTerrain._tiles = this.tiles;
        VigTerrain._vertices = this.vertices;
        VigTerrain._chunks = this.chunks;
        VigTerrain.mainWidth = VigTerrain.mainT.width;
        VigTerrain.mainHeight = VigTerrain.mainT.height;
    }

    // Token: 0x06000BE9 RID: 3049 RVA: 0x0009EF64 File Offset: 0x0009D164
    public void UpdatePosition(Vector3 pos)
    {
        base.transform.position = pos;
        base.transform.position = new Vector3(pos.x, -pos.y, pos.z);
    }

    // Token: 0x06000BEA RID: 3050 RVA: 0x0009EFA0 File Offset: 0x0009D1A0
    public void ClearTerrainData()
    {
        for (int i = 0; i < VigTerrain.index; i++)
        {
            VigTerrain.newVertices[i] = new Vector3(0f, 0f, 0f);
            VigTerrain.newUVs[i] = new Vector2(0f, 0f);
        }
        for (int j = 0; j < VigTerrain.index3; j++)
        {
            VigTerrain.newTriangles[0][j] = 0;
        }
        for (int k = 0; k < 16; k++)
        {
            for (int l = 0; l < VigTerrain.index2[k]; l++)
            {
                VigTerrain.newTriangles[k + 1][l] = 0;
            }
        }
        VigTerrain.index = 0;
        VigTerrain.index3 = 0;
        for (int m = 0; m < VigTerrain.index2.Length; m++)
        {
            VigTerrain.index2[m] = 0;
        }
        this.terrainMesh.Clear();
    }

    // Token: 0x06000BEB RID: 3051 RVA: 0x0009F074 File Offset: 0x0009D274
    public void CreateTerrainMesh()
    {
        this.terrainMesh.subMeshCount = 17;
        for (int i = 0; i < VigTerrain.newVertices.Length; i++)
        {
            VigTerrain.newVertices[i] = new Vector3(VigTerrain.newVertices[i].x, -VigTerrain.newVertices[i].y, VigTerrain.newVertices[i].z);
        }
        this.terrainMesh.SetVertices(VigTerrain.newVertices, 0, VigTerrain.index);
        this.terrainMesh.SetColors(VigTerrain.newColors, 0, VigTerrain.index);
        this.terrainMesh.SetUVs(0, VigTerrain.newUVs, 0, VigTerrain.index);
        this.terrainMesh.SetTriangles(VigTerrain.newTriangles[0], 0, VigTerrain.index3, 0, true, 0);
        for (int j = 1; j < 17; j++)
        {
            this.terrainMesh.SetTriangles(VigTerrain.newTriangles[j], 0, VigTerrain.index2[j - 1], j, false, 0);
        }
    }

    // Token: 0x06000BEC RID: 3052 RVA: 0x0009F16C File Offset: 0x0009D36C
    private bool InsideCircle(Tile center, Tile tile, float radius)
    {
        float num = center.x - tile.x;
        float num2 = center.y - tile.y;
        return num * num + num2 * num2 <= radius * radius;
    }

    // Token: 0x06000BED RID: 3053 RVA: 0x0009F1A4 File Offset: 0x0009D3A4
    private List<Tile> BreadthFirstSearch(Tile start, float radius)
    {
        Queue<Tile> queue = new Queue<Tile>();
        queue.Enqueue(start);
        List<Tile> list = new List<Tile>();
        list.Add(start);
        while (queue.Count > 0)
        {
            foreach (Tile tile in queue.Dequeue().neighbours)
            {
                if (!list.Contains(tile) && this.InsideCircle(start, tile, radius))
                {
                    queue.Enqueue(tile);
                    list.Add(tile);
                }
            }
        }
        return list;
    }

    // Token: 0x06000BEE RID: 3054 RVA: 0x0009F21C File Offset: 0x0009D41C
    public void SetNumberOfZones()
    {
        this.vertices = new ushort[this.zoneCount * 4096];
        this.tiles = new byte[this.zoneCount * 4096];
        this.chunks = new ushort[1024];
        for (int i = 0; i < 4096; i++)
        {
            this.vertices[i] = this.defaultVertex;
            this.tiles[i] = this.defaultTile;
        }
    }

    // Token: 0x06000BEF RID: 3055 RVA: 0x0009F294 File Offset: 0x0009D494
    public void FUN_1C910()
    {
        float num = LevelManager.instance.defaultCamera.transform.eulerAngles.x;
        float num2 = LevelManager.instance.defaultCamera.transform.eulerAngles.y / 180f * GameManager.instance.offsetFactor;
        this.skyboxMat.mainTextureOffset = new Vector2(num2 + GameManager.instance.offsetStart, 0f);
        if (num > 180f)
        {
            num -= 360f;
        }
        else if (num < -180f)
        {
            num += 360f;
        }
        float num3 = 0.5f + num / 30f + GameManager.instance.angleOffset;
        this.skybox.pivot = new Vector2(0.5f, num3);
        this.skyboxLeft.pivot = new Vector2(0.5f, num3);
        this.skyboxRight.pivot = new Vector2(0.5f, num3);
        this.sbTop.anchorMin = new Vector2(0f, Mathf.Clamp(num3, 0f, 1f));
        this.sbTopLeft.anchorMin = new Vector2(-1f, Mathf.Clamp(num3, 0f, 1f));
        this.sbTopRight.anchorMin = new Vector2(1f, Mathf.Clamp(num3, 0f, 1f));
        this.sbBottom.anchorMax = new Vector2(1f, Mathf.Clamp(num3, 0f, 1f));
        this.sbBottomLeft.anchorMax = new Vector2(0f, Mathf.Clamp(num3, 0f, 1f));
        this.sbBottomRight.anchorMax = new Vector2(2f, Mathf.Clamp(num3, 0f, 1f));
        Vector3 localEulerAngles = this.canvasSky.localEulerAngles;
        localEulerAngles = new Vector3(0f, 0f, -localEulerAngles.z);
        this.sbParent.localRotation = Quaternion.Euler(localEulerAngles);
        float num4 = (LevelManager.instance.defaultCamera.aspect - 1.33333f) * GameManager.instance.aspectRatioScale;
        this.sbParent.SetLeft(num4);
        this.sbParent.SetRight(num4);
    }

    // Token: 0x06000BF0 RID: 3056 RVA: 0x0000B50F File Offset: 0x0000970F
    public ushort FUN_1CF5C(uint param1, uint param2)
    {
        checked
        {
            return (ushort)(this.vertices[(int)((IntPtr)(unchecked((long)(this.chunks[(int)((param1 >> 6) * 32U + (param2 >> 6))] * 4096) + (long)((ulong)(((param2 & 63U) * 128U + (param1 & 63U) * 2U) / 2U)))))] & 2047);
        }
    }

    // Token: 0x06000BF1 RID: 3057 RVA: 0x0000B54D File Offset: 0x0000974D
    public TileData FUN_1CE1C(uint param1, uint param2)
    {
        return this.tileData[(int)this.tiles[(int)((uint)(this.chunks[(int)((param1 >> 6) * 32U + (param2 >> 6))] * 4096) + (param2 & 63U) + (param1 & 63U) * 64U)]];
    }

    // Token: 0x06000BF2 RID: 3058 RVA: 0x0009F4D4 File Offset: 0x0009D6D4
    public static void FUN_1BE68(int param1, int param2, int param3)
    {
        if (param1 < param2)
        {
            int num = 0;
            do
            {
                VigTerrain.FUN_288E0((uint)param1, (uint)param3, num++);
                param1 += 4;
            }
            while (param1 < param2);
        }
    }

    // Token: 0x06000BF3 RID: 3059 RVA: 0x0009F4FC File Offset: 0x0009D6FC
    public Vector3Int FUN_1B998(uint x, uint z)
    {
        if (x <= 0U || z <= 0U || x >= 117440512U || z >= 117440512U)
        {
            return new Vector3Int(4096, 4096, 4096);
        }
        uint num = x >> 16;
        uint num2 = z >> 16;
        if ((x & 65535U) + (z & 65535U) < 65536U)
        {
            uint num3 = z >> 22 << 2;
            x = x >> 22 << 7;
            uint num4 = (num2 & 63U) << 1;
            uint num5 = (num & 63U) << 7;
            int num6 = (int)this.chunks[(int)((num3 + x) / 4U)];
            int num7 = (int)((num4 + num5) / 2U);
            uint num8 = num + 1U;
            num3 += num8 >> 6 << 7;
            int num9 = (int)this.chunks[(int)(num3 / 4U)];
            num8 = (num8 & 63U) << 7;
            int num10 = (int)((num4 + num8) / 2U);
            int num11 = (int)(this.vertices[num6 * 4096 + num7] & 2047);
            int num12 = (int)(this.vertices[num9 * 4096 + num10] & 2047);
            num8 = num2 + 1U;
            int num13 = (int)this.chunks[(int)(((num8 >> 6 << 2) + x) / 4U)];
            num8 = (num8 & 63U) << 1;
            int num14 = (int)((num8 + num5) / 2U);
            int num15 = (int)(this.vertices[num13 * 4096 + num14] & 2047);
            return new Vector3Int(num12 - num11, -32, num15 - num11);
        }
        uint num16 = num + 1U;
        uint num17 = num2 + 1U;
        uint num18 = num17 >> 6 << 2;
        uint num19 = num16 >> 6 << 7;
        uint num20 = (num17 & 63U) << 1;
        num16 = (num16 & 63U) << 7;
        int num21 = (int)this.chunks[(int)((num18 + num19) / 4U)];
        int num22 = (int)((num20 + num16) / 2U);
        num18 += x >> 22 << 7;
        int num23 = (int)this.chunks[(int)(num18 / 4U)];
        int num24 = (int)((num20 + ((num & 63U) << 7)) / 2U);
        int num25 = (int)(this.vertices[num21 * 4096 + num22] & 2047);
        int num26 = (int)(this.vertices[num23 * 4096 + num24] & 2047);
        num18 = (num2 & 63U) << 1;
        int num27 = (int)this.chunks[(int)(((z >> 22 << 2) + num19) / 4U)];
        int num28 = (int)((num18 + num16) / 2U);
        int num29 = (int)(this.vertices[num27 * 4096 + num28] & 2047);
        return new Vector3Int(num25 - num26, -32, num25 - num29);
    }

    // Token: 0x06000BF4 RID: 3060 RVA: 0x0009F72C File Offset: 0x0009D92C
    public TileData GetTileByPosition(uint x, uint z)
    {
        if (x > 0U && z > 0U && x < 117440512U && z < 117440512U)
        {
            uint num = z >> 16;
            z = z >> 22 << 2;
            z += x >> 22 << 7;
            num &= 63U;
            x = (x >> 10) & 4032U;
            int num2 = (int)(z / 4U);
            if (num2 >= this.chunks.Length)
            {
                num2 = 0;
                num = 0U;
            }
            else
            {
                num += x;
            }
            int num3 = (int)this.chunks[num2];
            checked
            {
                return this.tileData[(int)this.tiles[(int)((IntPtr)(unchecked((long)(num3 * 4096) + (long)((ulong)num))))]];
            }
        }
        return this.tileData[0];
    }

    // Token: 0x06000BF5 RID: 3061 RVA: 0x0009F7C8 File Offset: 0x0009D9C8
    public Tile GetTileByPosition2(uint x, uint z)
    {
        if (x > 0U && z > 0U && x < 117440512U && z < 117440512U)
        {
            uint num = z >> 16;
            z = z >> 22 << 2;
            z += x >> 22 << 7;
            num &= 63U;
            x = (x >> 10) & 4032U;
            int num2 = (int)this.chunks[(int)(z / 4U)];
            num += x;
            return this.tilesDict[num2 * 4096 + (int)num];
        }
        return this.tilesDict[0];
    }

    // Token: 0x06000BF6 RID: 3062 RVA: 0x0009F848 File Offset: 0x0009DA48
    public int FUN_1B750(uint x, uint z)
    {
        if (x <= 0U || z <= 0U || x >= 117440512U || z >= 117440512U)
        {
            return 0;
        }
        int num = (int)(x & 65535U);
        int num2 = num;
        uint num3 = z & 65535U;
        int num4 = (int)num3;
        uint num5 = x >> 16;
        uint num6 = z >> 16;
        if ((long)num + (long)((ulong)num3) < 65536L)
        {
            uint num7 = z >> 22 << 2;
            x = x >> 22 << 7;
            uint num8 = (num6 & 63U) << 1;
            uint num9 = (num5 & 63U) << 7;
            int num10 = (int)this.chunks[(int)((num7 + x) / 4U)];
            int num11 = (int)(num8 + num9);
            num7 += num5 + 1U >> 6 << 7;
            num8 += ((num5 + 1U) & 63U) << 7;
            checked
            {
                num7 = (uint)(this.vertices[(int)((IntPtr)(unchecked((long)(this.chunks[(int)(num7 / 4U)] * 4096) + (long)((ulong)(num8 / 2U)))))] & 2047);
            }
            num8 = (uint)(this.vertices[num10 * 4096 + num11 / 2] & 2047);
            int num12 = (int)(num7 - num8);
            num12 = num * num12;
            num10 = (int)this.chunks[(int)(((num6 + 1U >> 6 << 2) + x) / 4U)];
            num11 = (int)((((num6 + 1U) & 63U) << 1) + num9);
            int num13 = (int)((uint)(this.vertices[num10 * 4096 + num11 / 2] & 2047) - num8);
            num13 = num12 + (int)(num3 * (uint)num13);
            num13 += (int)((int)num8 << 16);
            if (num13 < 0)
            {
                num13 += 31;
            }
            return num13 >> 5;
        }
        uint num14 = num5 + 1U;
        uint num15 = num6 + 1U;
        uint num16 = num15 >> 6 << 2;
        uint num17 = num14 >> 6 << 7;
        uint num18 = (num15 & 63U) << 1;
        num14 = (num14 & 63U) << 7;
        int num19 = (int)this.chunks[(int)((num16 + num17) / 4U)];
        int num20 = (int)(num18 + num14);
        int num21 = (int)this.chunks[(int)((num16 + (x >> 22 << 7)) / 4U)];
        int num22 = (int)((num18 + ((num5 & 63U) << 7)) / 2U);
        int num23 = (int)(this.vertices[num21 * 4096 + num22] & 2047);
        num16 = (z >> 22 << 2) + num17;
        int num24 = 65536;
        int num25 = (int)(this.vertices[num19 * 4096 + num20 / 2] & 2047);
        int num26 = num24 - num2;
        num23 -= num25;
        int num27 = num26 * num23;
        int num28 = (int)this.chunks[(int)(num16 / 4U)];
        num24 -= num4;
        int num29 = (int)(((num6 & 63U) << 1) + num14);
        int num30 = (int)(this.vertices[num28 * 4096 + num29 / 2] & 2047);
        num30 -= num25;
        num25 <<= 16;
        num30 = num27 + num24 * num30;
        num30 = num25 + num30;
        if (num30 < 0)
        {
            num30 += 31;
        }
        return num30 >> 5;
    }

    // Token: 0x06000BF7 RID: 3063 RVA: 0x0009FAD0 File Offset: 0x0009DCD0
    public Vector3Int FUN_1BB50(int param1, int param2)
    {
        Vector3Int vector3Int = default(Vector3Int);
        if (param1 > 0 && param2 > 0 && param1 < 117440512 && param2 < 117440512)
        {
            int num = param1 - 32768;
            int num2 = param2 - 32768;
            int num3 = num;
            if (num < 0)
            {
                num3 = param1 + 32767;
            }
            uint num4 = (uint)(num3 >> 16);
            num += (int)(num4 * 4294901760U);
            num3 = num2;
            if (num2 < 0)
            {
                num3 = param2 + 32767;
            }
            uint num5 = (uint)(num3 >> 16);
            num2 += (int)(num5 * 4294901760U);
            uint num6 = num5 >> 6;
            uint num7 = num4 >> 6;
            num3 = (int)((num5 & 63U) * 2U);
            int num8 = (int)((num4 & 63U) * 128U);
            int num9 = 65536 - num;
            uint num10 = num4 + 1U >> 6;
            int num11 = (int)(((num4 + 1U) & 63U) * 128U);
            uint num12 = (uint)(this.vertices[(int)(this.chunks[(int)(num7 * 32U + num6)] * 4096) + (num3 + num8) / 2] & 2047);
            uint num13 = (uint)(this.vertices[(int)(this.chunks[(int)(num10 * 32U + num6)] * 4096) + (num3 + num11) / 2] & 2047);
            uint num14 = num4 + 2U >> 6;
            int num15 = (int)(((num4 + 2U) & 63U) * 128U);
            num4 = num5 + 1U >> 6;
            int num16 = (int)(((num5 + 1U) & 63U) * 2U);
            num3 = (int)((num13 - num12) * (uint)num9 + ((uint)(this.vertices[(int)(this.chunks[(int)(num14 * 32U + num6)] * 4096) + (num3 + num15) / 2] & 2047) - num13) * (uint)num);
            uint num17 = (uint)(this.vertices[(int)(this.chunks[(int)(num7 * 32U + num4)] * 4096) + (num16 + num8) / 2] & 2047);
            num6 = (uint)(this.vertices[(int)(this.chunks[(int)(num10 * 32U + num4)] * 4096) + (num16 + num11) / 2] & 2047);
            if (num3 < 0)
            {
                num3 += 65535;
            }
            int num18 = 65536 - num2;
            num16 = (int)((num6 - num17) * (uint)num9 + ((uint)(this.vertices[(int)(this.chunks[(int)(num14 * 32U + num4)] * 4096) + (num16 + num15) / 2] & 2047) - num6) * (uint)num);
            if (num16 < 0)
            {
                num16 += 65535;
            }
            num3 = (num3 >> 16) * num18 + (num16 >> 16) * num2;
            int num19 = num3 >> 16;
            if (num3 < 0)
            {
                num19 = num3 + 65535 >> 16;
            }
            vector3Int.x = num19;
            vector3Int.y = -32;
            num4 = num5 + 2U >> 6;
            num16 = (int)(((num5 + 2U) & 63U) * 2U);
            num3 = (int)((num17 - num12) * (uint)num18 + ((uint)(this.vertices[(int)(this.chunks[(int)(num7 * 32U + num4)] * 4096) + (num16 + num8) / 2] & 2047) - num17) * (uint)num2);
            if (num3 < 0)
            {
                num3 += 65535;
            }
            num2 = (int)((num6 - num13) * (uint)num18 + ((uint)(this.vertices[(int)(this.chunks[(int)(num10 * 32U + num4)] * 4096) + (num16 + num11) / 2] & 2047) - num6) * (uint)num2);
            if (num2 < 0)
            {
                num2 += 65535;
            }
            num3 = (num3 >> 16) * num9 + (num2 >> 16) * num;
            num19 = num3 >> 16;
            if (num3 < 0)
            {
                num19 = num3 + 65535 >> 16;
            }
            vector3Int.z = num19;
            return vector3Int;
        }
        return new Vector3Int(1, 1, 1);
    }

    // Token: 0x06000BF8 RID: 3064 RVA: 0x0009FE2C File Offset: 0x0009E02C
    public void FUN_2D16C(int param1, int param2, ref VigTransform param3)
    {
        Vector3Int vector3Int = this.FUN_1B998((uint)param1, (uint)param2);
        vector3Int = Utilities.VectorNormal(vector3Int);
        param3.position.x = param1;
        int num = this.FUN_1B750((uint)param1, (uint)param2);
        param3.position.y = num;
        param3.position.z = param2;
        param3.rotation = Utilities.FUN_2A5EC(vector3Int);
    }

    // Token: 0x06000BF9 RID: 3065 RVA: 0x0009FE84 File Offset: 0x0009E084
    private static void FUN_288E0(uint param1, uint param2, int param3)
    {
        int num = (int)((param1 >> 6) * 32U + (param2 >> 6));
        int num2 = (int)(((param2 & 63U) + (param1 & 63U) * 64U) * 2U);
        VigTerrain.puVar14 = (int)(VigTerrain._chunks[num] * 4096) + num2 / 2;
        uint num3 = (param1 + 4U) & 63U;
        VigTerrain.puVar15 = VigTerrain.puVar14 + 256;
        if (num3 == 0U)
        {
            VigTerrain.puVar15 = (int)(VigTerrain._chunks[32 + num] * 4096) + (num2 - 7680) / 2;
        }
        VigTerrain.puVar16 = VigTerrain.puVar14 + 4;
        VigTerrain.puVar17 = VigTerrain.puVar15 + 4;
        if (((param2 + 4U) & 63U) == 0U)
        {
            VigTerrain.puVar16 = (int)(VigTerrain._chunks[1 + num] * 4096) + (num2 - 120) / 2;
            VigTerrain.puVar17 = VigTerrain.puVar16 + 256;
            if (num3 == 0U)
            {
                VigTerrain.puVar17 = (int)(VigTerrain._chunks[33 + num] * 4096);
            }
        }
        num = (int)(param2 * 256U + (uint)GameManager.DAT_1f800084.z);
        uint num4 = (param1 * 256U + (uint)GameManager.DAT_1f800084.x) & 65535U;
        num2 = GameManager.DAT_1f800084.y * 65536;
        Coprocessor3.vector0.vx0 = (short)num4;
        Coprocessor3.vector0.vy0 = (short)((int)(VigTerrain._vertices[VigTerrain.puVar14] & 2047) * 524288 + num2 >> 16);
        Coprocessor3.vector0.vz0 = (short)num;
        VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
        Coprocessor3.ExecuteRTPS(12, false);
        num3 = (uint)GameManager.DAT_1f800098;
        uint num5 = (num4 + 1024U) & 65535U;
        uint sz = (uint)Coprocessor3.screenZFIFO.sz3;
        GameManager.terrainScreen[0].ir0 = (int)Coprocessor3.accumulator.ir0;
        Coprocessor3.vector0.vx0 = (short)num5;
        Coprocessor3.vector0.vy0 = (short)((int)(VigTerrain._vertices[VigTerrain.puVar15] & 2047) * 524288 + num2 >> 16);
        Coprocessor3.vector0.vz0 = (short)num;
        VigTerrain.terrainVertices[1] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
        Coprocessor3.ExecuteRTPS(12, false);
        uint num6 = ((sz < num3) ? 1U : 0U);
        uint sz2 = (uint)Coprocessor3.screenZFIFO.sz3;
        GameManager.terrainScreen[4].ir0 = (int)Coprocessor3.accumulator.ir0;
        Coprocessor3.vector0.vx0 = (short)num4;
        Coprocessor3.vector0.vy0 = (short)((int)(VigTerrain._vertices[VigTerrain.puVar16] & 2047) * 524288 + num2 >> 16);
        Coprocessor3.vector0.vz0 = (short)(num + 1024);
        Vector2Int vector2Int = new Vector2Int((int)Coprocessor3.screenXYFIFO.sx1, (int)Coprocessor3.screenXYFIFO.sy1);
        VigTerrain.terrainVertices[2] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
        Coprocessor3.ExecuteRTPS(12, false);
        uint num7 = ((sz2 < num3) ? 1U : 0U) << 1;
        uint num8 = num6 | num7;
        uint sz3 = (uint)Coprocessor3.screenZFIFO.sz3;
        GameManager.terrainScreen[20].ir0 = (int)Coprocessor3.accumulator.ir0;
        Coprocessor3.ExecuteNCLIP();
        Coprocessor3.vector0.vx0 = (short)num5;
        Coprocessor3.vector0.vy0 = (short)((int)(VigTerrain._vertices[VigTerrain.puVar17] & 2047) * 524288 + num2 >> 16);
        Coprocessor3.vector0.vz0 = (short)(num + 1024);
        VigTerrain.terrainVertices[3] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
        num2 = Coprocessor3.mathsAccumulator.mac0;
        Coprocessor3.ExecuteRTPS(12, false);
        num5 = ((sz3 < num3) ? 1U : 0U) << 2;
        uint sz4 = (uint)Coprocessor3.screenZFIFO.sz3;
        GameManager.terrainScreen[24].ir0 = (int)Coprocessor3.accumulator.ir0;
        Coprocessor3.ExecuteAVSZ4();
        num3 = ((sz4 < num3) ? 1U : 0U) << 3;
        uint num9 = num8 | num5 | num3;
        Coprocessor3.colorCode.r = LevelManager.instance.DAT_DDC.r;
        Coprocessor3.colorCode.g = LevelManager.instance.DAT_DDC.g;
        Coprocessor3.colorCode.b = LevelManager.instance.DAT_DDC.b;
        Coprocessor3.colorCode.code = LevelManager.instance.DAT_DDC.a;
        if (num9 == 15U)
        {
            GameManager.terrainScreen[0].vert.z = (int)Coprocessor3.screenZFIFO.sz0;
            GameManager.terrainScreen[4].vert.z = (int)Coprocessor3.screenZFIFO.sz1;
            GameManager.terrainScreen[20].vert.z = (int)Coprocessor3.screenZFIFO.sz2;
            GameManager.terrainScreen[24].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
            VigTerrain.terrainWorld[0].z = (float)VigTerrain.terrainVertices[0].z;
            VigTerrain.terrainWorld[0].x = (float)VigTerrain.terrainVertices[0].x;
            VigTerrain.terrainWorld[0].y = (float)VigTerrain.terrainVertices[0].y;
            VigTerrain.terrainWorld[4].z = (float)VigTerrain.terrainVertices[1].z;
            VigTerrain.terrainWorld[20].z = (float)VigTerrain.terrainVertices[2].z;
            VigTerrain.terrainWorld[24].z = (float)VigTerrain.terrainVertices[3].z;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar14] >> 11 << 7);
            Coprocessor3.ExecuteCC(12, true);
            GameManager.terrainScreen[4].vert.x = (int)Coprocessor3.screenXYFIFO.sx0;
            GameManager.terrainScreen[4].vert.y = (int)Coprocessor3.screenXYFIFO.sy0;
            VigTerrain.terrainWorld[4].x = (float)VigTerrain.terrainVertices[1].x;
            VigTerrain.terrainWorld[4].y = (float)VigTerrain.terrainVertices[1].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar15] >> 11 << 7);
            GameManager.terrainScreen[0].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteCC(12, true);
            GameManager.terrainScreen[20].vert.x = (int)Coprocessor3.screenXYFIFO.sx1;
            GameManager.terrainScreen[20].vert.y = (int)Coprocessor3.screenXYFIFO.sy1;
            VigTerrain.terrainWorld[20].x = (float)VigTerrain.terrainVertices[2].x;
            VigTerrain.terrainWorld[20].y = (float)VigTerrain.terrainVertices[2].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar16] >> 11 << 7);
            GameManager.terrainScreen[4].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteCC(12, true);
            GameManager.terrainScreen[24].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[24].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
            VigTerrain.terrainWorld[24].x = (float)VigTerrain.terrainVertices[3].x;
            VigTerrain.terrainWorld[24].y = (float)VigTerrain.terrainVertices[3].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar17] >> 11 << 7);
            GameManager.terrainScreen[20].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteCC(12, true);
            num3 = (uint)(GameManager.DAT_1f800084.y * 65536);
            Coprocessor3.vector0.vz0 = (short)num;
            Coprocessor3.vector1.vz1 = (short)(num + 512);
            Coprocessor3.vector2.vz2 = (short)(num + 1024);
            num5 = ((num4 + 512U) & 65535U) | num3;
            uint num10 = (uint)(VigTerrain._vertices[VigTerrain.puVar14 + 128] & 2047) * 524288U + num5;
            uint num11 = (uint)(VigTerrain._vertices[VigTerrain.puVar14 + 130] & 2047) * 524288U + num5;
            uint num12 = (uint)(VigTerrain._vertices[VigTerrain.puVar16 + 128] & 2047) * 524288U + num5;
            Coprocessor3.vector0.vx0 = (short)num10;
            Coprocessor3.vector0.vy0 = (short)(num10 >> 16);
            Coprocessor3.vector1.vx1 = (short)num11;
            Coprocessor3.vector1.vy1 = (short)(num11 >> 16);
            Coprocessor3.vector2.vx2 = (short)num12;
            Coprocessor3.vector2.vy2 = (short)(num12 >> 16);
            VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
            VigTerrain.terrainVertices[1] = new Vector3Int((int)Coprocessor3.vector1.vx1, (int)Coprocessor3.vector1.vy1, (int)Coprocessor3.vector1.vz1);
            VigTerrain.terrainVertices[2] = new Vector3Int((int)Coprocessor3.vector2.vx2, (int)Coprocessor3.vector2.vy2, (int)Coprocessor3.vector2.vz2);
            GameManager.terrainScreen[24].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteRTPT(12, false);
            GameManager.terrainScreen[2].vert.x = (int)Coprocessor3.screenXYFIFO.sx0;
            GameManager.terrainScreen[2].vert.y = (int)Coprocessor3.screenXYFIFO.sy0;
            GameManager.terrainScreen[22].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[22].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
            VigTerrain.terrainWorld[2].x = (float)VigTerrain.terrainVertices[0].x;
            VigTerrain.terrainWorld[2].y = (float)VigTerrain.terrainVertices[0].y;
            VigTerrain.terrainWorld[22].x = (float)VigTerrain.terrainVertices[2].x;
            VigTerrain.terrainWorld[22].y = (float)VigTerrain.terrainVertices[2].y;
            Coprocessor3.vector0.vx0 = (short)num4;
            Coprocessor3.vector0.vy0 = (short)((long)((int)(VigTerrain._vertices[VigTerrain.puVar14 + 2] & 2047) * 524288) + (long)((ulong)num3) >> 16);
            num12 = (uint)(VigTerrain._vertices[VigTerrain.puVar15 + 2] & 2047) * 524288U + (((num4 + 1024U) & 65535U) | num3);
            Coprocessor3.vector2.vx2 = (short)num12;
            Coprocessor3.vector2.vy2 = (short)(num12 >> 16);
            Coprocessor3.vector0.vz0 = (short)(num + 512);
            Coprocessor3.vector2.vz2 = (short)(num + 512);
            GameManager.terrainScreen[2].vert.z = (int)Coprocessor3.screenZFIFO.sz1;
            GameManager.terrainScreen[22].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
            VigTerrain.terrainWorld[2].z = (float)VigTerrain.terrainVertices[0].z;
            VigTerrain.terrainWorld[22].z = (float)VigTerrain.terrainVertices[2].z;
            VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
            VigTerrain.terrainVertices[2] = new Vector3Int((int)Coprocessor3.vector2.vx2, (int)Coprocessor3.vector2.vy2, (int)Coprocessor3.vector2.vz2);
            Coprocessor3.ExecuteRTPT(12, false);
            GameManager.terrainScreen[10].vert.x = (int)Coprocessor3.screenXYFIFO.sx0;
            GameManager.terrainScreen[10].vert.y = (int)Coprocessor3.screenXYFIFO.sy0;
            GameManager.terrainScreen[12].vert.x = (int)Coprocessor3.screenXYFIFO.sx1;
            GameManager.terrainScreen[12].vert.y = (int)Coprocessor3.screenXYFIFO.sy1;
            VigTerrain.terrainWorld[10].x = (float)VigTerrain.terrainVertices[0].x;
            VigTerrain.terrainWorld[10].y = (float)VigTerrain.terrainVertices[0].y;
            VigTerrain.terrainWorld[12].x = (float)VigTerrain.terrainVertices[1].x;
            VigTerrain.terrainWorld[12].y = (float)VigTerrain.terrainVertices[1].y;
            num10 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 128] >> 11 << 7;
            num11 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 130] >> 11 << 7;
            num12 = (uint)VigTerrain._vertices[VigTerrain.puVar16 + 128] >> 11 << 7;
            Coprocessor3.vector0.vx0 = (short)num10;
            Coprocessor3.vector0.vy0 = (short)(num10 >> 16);
            Coprocessor3.vector1.vx1 = (short)num11;
            Coprocessor3.vector1.vy1 = (short)(num11 >> 16);
            Coprocessor3.vector2.vx2 = (short)num12;
            Coprocessor3.vector2.vy2 = (short)(num12 >> 16);
            GameManager.terrainScreen[10].vert.z = (int)Coprocessor3.screenZFIFO.sz1;
            GameManager.terrainScreen[12].vert.z = (int)Coprocessor3.screenZFIFO.sz2;
            VigTerrain.terrainWorld[10].z = (float)VigTerrain.terrainVertices[0].z;
            VigTerrain.terrainWorld[12].z = (float)VigTerrain.terrainVertices[1].z;
            Coprocessor3.ExecuteNCCT(12, true);
            GameManager.terrainScreen[2].color = new Color32(Coprocessor3.colorFIFO.r0, Coprocessor3.colorFIFO.g0, Coprocessor3.colorFIFO.b0, Coprocessor3.colorFIFO.cd0);
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar14 + 2] >> 11 << 7);
            GameManager.terrainScreen[12].color = new Color32(Coprocessor3.colorFIFO.r1, Coprocessor3.colorFIFO.g1, Coprocessor3.colorFIFO.b1, Coprocessor3.colorFIFO.cd1);
            GameManager.terrainScreen[22].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteCC(12, true);
            GameManager.terrainScreen[10].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar15 + 2] >> 11 << 7);
            GameManager.terrainScreen[14].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[14].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
            GameManager.terrainScreen[14].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
            VigTerrain.terrainWorld[14].x = (float)VigTerrain.terrainVertices[2].x;
            VigTerrain.terrainWorld[14].y = (float)VigTerrain.terrainVertices[2].y;
            VigTerrain.terrainWorld[14].z = (float)VigTerrain.terrainVertices[2].z;
            Coprocessor3.ExecuteCC(12, true);
            num3 = (num4 + 512U) & 65535U;
            num += 512;
            GameManager.terrainScreen[14].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            GameManager.terrainScreen[0].vert.x = vector2Int.x;
            GameManager.terrainScreen[0].vert.y = vector2Int.y;
            int num13 = VigTerrain.puVar15;
            VigTerrain.puVar14 += 130;
            VigTerrain.puVar15 += 2;
            VigTerrain.puVar16 += 128;
            VigTerrain.FUN_290A8(num3, num, param3, 12);
            VigTerrain.puVar14 -= 128;
            VigTerrain.puVar16 -= 128;
            VigTerrain.puVar15 = VigTerrain.puVar14 + 128;
            VigTerrain.puVar17 = VigTerrain.puVar16 + 128;
            num3 = (num3 - 512U) & 65535U;
            VigTerrain.FUN_290A8(num3, num, param3, 10);
            VigTerrain.puVar14 += 126;
            VigTerrain.puVar15 = num13;
            VigTerrain.puVar16 = VigTerrain.puVar14 + 2;
            VigTerrain.puVar17 = VigTerrain.puVar15 + 2;
            num3 = (num3 + 512U) & 65535U;
            num -= 512;
            VigTerrain.FUN_290A8(num3, num, param3, 2);
            VigTerrain.puVar14 -= 128;
            VigTerrain.puVar15 = VigTerrain.puVar14 + 128;
            VigTerrain.puVar16 = VigTerrain.puVar14 + 2;
            VigTerrain.puVar17 = VigTerrain.puVar15 + 2;
            num3 = (num3 - 512U) & 65535U;
            VigTerrain.FUN_290A8(num3, num, param3, 0);
            return;
        }
        uint averageZ = (uint)Coprocessor3.averageZ;
        Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[0].ir0;
        Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar14] >> 11 << 7);
        Coprocessor3.ExecuteCDP(12, true);
        Vector2Int vector2Int2 = new Vector2Int((int)Coprocessor3.screenXYFIFO.sx0, (int)Coprocessor3.screenXYFIFO.sy0);
        Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[4].ir0;
        Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar15] >> 11 << 7);
        VigTerrain.puVar18 = GameManager.DAT_1f800080 + (int)(averageZ >> 1);
        Coprocessor3.ExecuteCDP(12, true);
        Vector2Int vector2Int3 = new Vector2Int((int)Coprocessor3.screenXYFIFO.sx1, (int)Coprocessor3.screenXYFIFO.sy1);
        Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[20].ir0;
        Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar16] >> 11 << 7);
        Coprocessor3.ExecuteCDP(12, true);
        int translateFactor = GameManager.instance.translateFactor2;
        if (num9 == 0U)
        {
            VigTerrain.newVertices[VigTerrain.index] = (Vector3)VigTerrain.terrainVertices[0] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 1] = (Vector3)VigTerrain.terrainVertices[1] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 2] = (Vector3)VigTerrain.terrainVertices[2] / (float)translateFactor;
            VigTerrain.newColors[VigTerrain.index] = new Color32(Coprocessor3.colorFIFO.r0, Coprocessor3.colorFIFO.g0, Coprocessor3.colorFIFO.b0, Coprocessor3.colorFIFO.cd0);
            VigTerrain.newColors[VigTerrain.index + 1] = new Color32(Coprocessor3.colorFIFO.r1, Coprocessor3.colorFIFO.g1, Coprocessor3.colorFIFO.b1, Coprocessor3.colorFIFO.cd1);
            VigTerrain.newColors[VigTerrain.index + 2] = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
            VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index + 2;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index;
            VigTerrain.index += 3;
            VigTerrain.index3 += 3;
            Coprocessor3.ExecuteNCLIP();
            num = Coprocessor3.mathsAccumulator.mac0;
            Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[24].ir0;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar17] >> 11 << 7);
            Coprocessor3.ExecuteCDP(12, true);
            VigTerrain.newVertices[VigTerrain.index] = (Vector3)VigTerrain.terrainVertices[1] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 1] = (Vector3)VigTerrain.terrainVertices[2] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 2] = (Vector3)VigTerrain.terrainVertices[3] / (float)translateFactor;
            VigTerrain.newColors[VigTerrain.index] = new Color32(Coprocessor3.colorFIFO.r0, Coprocessor3.colorFIFO.g0, Coprocessor3.colorFIFO.b0, Coprocessor3.colorFIFO.cd0);
            VigTerrain.newColors[VigTerrain.index + 1] = new Color32(Coprocessor3.colorFIFO.r1, Coprocessor3.colorFIFO.g1, Coprocessor3.colorFIFO.b1, Coprocessor3.colorFIFO.cd1);
            VigTerrain.newColors[VigTerrain.index + 2] = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
            VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index + 2;
            VigTerrain.index += 3;
            VigTerrain.index3 += 3;
            return;
        }
        GameManager.terrainScreen[24].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
        GameManager.terrainScreen[24].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
        VigTerrain.terrainWorld[24].x = (float)VigTerrain.terrainVertices[3].x;
        VigTerrain.terrainWorld[24].y = (float)VigTerrain.terrainVertices[3].y;
        Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[24].ir0;
        Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar17] >> 11 << 7);
        GameManager.terrainScreen[0].vert.z = (int)Coprocessor3.screenZFIFO.sz0;
        GameManager.terrainScreen[4].vert.z = (int)Coprocessor3.screenZFIFO.sz1;
        GameManager.terrainScreen[20].vert.z = (int)Coprocessor3.screenZFIFO.sz2;
        GameManager.terrainScreen[24].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
        VigTerrain.terrainWorld[0].z = (float)VigTerrain.terrainVertices[0].z;
        VigTerrain.terrainWorld[0].x = (float)VigTerrain.terrainVertices[0].x;
        VigTerrain.terrainWorld[0].y = (float)VigTerrain.terrainVertices[0].y;
        VigTerrain.terrainWorld[4].z = (float)VigTerrain.terrainVertices[1].z;
        VigTerrain.terrainWorld[4].x = (float)VigTerrain.terrainVertices[1].x;
        VigTerrain.terrainWorld[4].y = (float)VigTerrain.terrainVertices[1].y;
        VigTerrain.terrainWorld[20].z = (float)VigTerrain.terrainVertices[2].z;
        VigTerrain.terrainWorld[20].x = (float)VigTerrain.terrainVertices[2].x;
        VigTerrain.terrainWorld[20].y = (float)VigTerrain.terrainVertices[2].y;
        VigTerrain.terrainWorld[24].z = (float)VigTerrain.terrainVertices[3].z;
        GameManager.terrainScreen[0].color = new Color32(Coprocessor3.colorFIFO.r0, Coprocessor3.colorFIFO.g0, Coprocessor3.colorFIFO.b0, Coprocessor3.colorFIFO.cd0);
        GameManager.terrainScreen[4].color = new Color32(Coprocessor3.colorFIFO.r1, Coprocessor3.colorFIFO.g1, Coprocessor3.colorFIFO.b1, Coprocessor3.colorFIFO.cd1);
        GameManager.terrainScreen[20].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
        Coprocessor3.ExecuteCDP(12, true);
        GameManager.terrainScreen[24].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
        num2 = GameManager.DAT_1f800084.y * 65536;
        if ((num9 & 3U) != 0U)
        {
            Coprocessor3.vector0.vx0 = (short)((num4 + 512U) & 65535U);
            Coprocessor3.vector0.vy0 = (short)((int)(VigTerrain._vertices[VigTerrain.puVar14 + 128] & 2047) * 524288 + num2 >> 16);
            Coprocessor3.vector0.vz0 = (short)num;
            VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
            Coprocessor3.ExecuteRTPS(12, false);
            GameManager.terrainScreen[2].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[2].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
            VigTerrain.terrainWorld[2].x = (float)VigTerrain.terrainVertices[0].x;
            VigTerrain.terrainWorld[2].y = (float)VigTerrain.terrainVertices[0].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar14 + 128] >> 11 << 7);
            GameManager.terrainScreen[2].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
            VigTerrain.terrainWorld[2].z = (float)VigTerrain.terrainVertices[0].z;
            Coprocessor3.ExecuteCDP(12, true);
        }
        if ((num9 & 5U) != 0U)
        {
            Coprocessor3.vector0.vx0 = (short)num4;
            Coprocessor3.vector0.vy0 = (short)((int)(VigTerrain._vertices[VigTerrain.puVar14 + 2] & 2047) * 524288 + num2 >> 16);
            Coprocessor3.vector0.vz0 = (short)(num + 512);
            VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
            Color32 color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteRTPS(12, false);
            if (num8 != 0U)
            {
                GameManager.terrainScreen[2].color = color;
            }
            GameManager.terrainScreen[10].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[10].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
            VigTerrain.terrainWorld[10].x = (float)VigTerrain.terrainVertices[0].x;
            VigTerrain.terrainWorld[10].y = (float)VigTerrain.terrainVertices[0].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar14 + 2] >> 11 << 7);
            GameManager.terrainScreen[10].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
            VigTerrain.terrainWorld[10].z = (float)VigTerrain.terrainVertices[0].z;
            Coprocessor3.ExecuteCDP(12, true);
        }
        if ((num9 & 10U) != 0U)
        {
            Coprocessor3.vector0.vx0 = (short)((num4 + 1024U) & 65535U);
            Coprocessor3.vector0.vy0 = (short)((int)(VigTerrain._vertices[VigTerrain.puVar15 + 2] & 2047) * 524288 + num2 >> 16);
            Coprocessor3.vector0.vz0 = (short)(num + 512);
            VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
            Color32 color2 = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteRTPS(12, false);
            Color32 color = color2;
            if ((num6 | num5) == 0U)
            {
                color = GameManager.terrainScreen[10].color;
                if (num8 != 0U)
                {
                    GameManager.terrainScreen[2].color = color2;
                }
            }
            GameManager.terrainScreen[10].color = color;
            GameManager.terrainScreen[14].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[14].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
            VigTerrain.terrainWorld[14].x = (float)VigTerrain.terrainVertices[0].x;
            VigTerrain.terrainWorld[14].y = (float)VigTerrain.terrainVertices[0].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar15 + 2] >> 11 << 7);
            GameManager.terrainScreen[14].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
            VigTerrain.terrainWorld[14].z = (float)VigTerrain.terrainVertices[0].z;
            Coprocessor3.ExecuteCDP(12, true);
        }
        if ((num9 & 12U) == 0U)
        {
            if ((num7 | num3) == 0U)
            {
                if ((num6 | num5) == 0U)
                {
                    if (num8 != 0U)
                    {
                        GameManager.terrainScreen[2].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
                    }
                }
                else
                {
                    GameManager.terrainScreen[10].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
                }
            }
            else
            {
                GameManager.terrainScreen[14].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            }
        }
        else
        {
            Coprocessor3.vector0.vx0 = (short)((num4 + 512U) & 65535U);
            Coprocessor3.vector0.vy0 = (short)((int)(VigTerrain._vertices[VigTerrain.puVar16 + 128] & 2047) * 524288 + num2 >> 16);
            Coprocessor3.vector0.vz0 = (short)(num + 1024);
            VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
            Color32 color3 = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteRTPS(12, false);
            GameManager.terrainScreen[22].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[22].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
            VigTerrain.terrainWorld[22].x = (float)VigTerrain.terrainVertices[0].x;
            VigTerrain.terrainWorld[22].y = (float)VigTerrain.terrainVertices[0].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)VigTerrain._vertices[VigTerrain.puVar16 + 128] >> 11 << 7);
            GameManager.terrainScreen[22].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
            VigTerrain.terrainWorld[22].z = (float)VigTerrain.terrainVertices[0].z;
            Coprocessor3.ExecuteCDP(12, true);
            Color32 color = GameManager.terrainScreen[10].color;
            Color32 color2 = color3;
            if ((num7 | num3) == 0U)
            {
                color = color3;
                color2 = GameManager.terrainScreen[14].color;
                if ((num6 | num5) == 0U)
                {
                    color = GameManager.terrainScreen[10].color;
                    if (num8 != 0U)
                    {
                        GameManager.terrainScreen[2].color = color3;
                    }
                }
            }
            GameManager.terrainScreen[14].color = color2;
            GameManager.terrainScreen[10].color = color;
            GameManager.terrainScreen[22].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
        }
        GameManager.terrainScreen[0].vert.x = vector2Int.x;
        GameManager.terrainScreen[0].vert.y = vector2Int.y;
        GameManager.terrainScreen[4].vert.x = vector2Int2.x;
        GameManager.terrainScreen[4].vert.y = vector2Int2.y;
        GameManager.terrainScreen[20].vert.x = vector2Int3.x;
        GameManager.terrainScreen[20].vert.y = vector2Int3.y;
        VigTerrain.in_t1 = GameManager.DAT_639EC[(int)((num9 - 1U) * 2U)];
        VigTerrain.in_t0 = GameManager.DAT_639EC[(int)((num9 - 1U) * 2U + 1U)];
        VigTerrain.FUN_297E8(num4, num, 0);
    }

    // Token: 0x06000BFA RID: 3066 RVA: 0x000A23B0 File Offset: 0x000A05B0

    //dibujado de terreno y distancia?
    private static void FUN_290A8(uint param1, int param2, int param3, int param4)
    {
        int translateFactor = GameManager.instance.translateFactor2;
        uint num = (uint)((ushort)GameManager.DAT_1f80009a);
        int num2 = GameManager.terrainScreen[param4].vert.z;
        int num3 = GameManager.terrainScreen[param4 + 2].vert.z;
        int z = GameManager.terrainScreen[param4 + 10].vert.z;
        uint num4 = ((z < (int)num) ? 1U : 0U) << 2;
        int z2 = GameManager.terrainScreen[param4 + 12].vert.z;
        num = ((num2 < (int)num) ? 1U : 0U) | (((num3 < (int)num) ? 1U : 0U) << 1) | num4 | (((z2 < (int)num) ? 1U : 0U) << 3);
        if (num == 0U)
        {
            Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[param4].vert.x;
            Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[param4].vert.y;
            Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[param4 + 2].vert.x;
            Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[param4 + 2].vert.y;
            Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[param4 + 10].vert.x;
            Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[param4 + 10].vert.y;
            Coprocessor3.ExecuteNCLIP();
            int dat_1f = GameManager.DAT_1f800080;
            Color32 color = GameManager.terrainScreen[param4 + 2].color;
            Color32 color2 = GameManager.terrainScreen[param4 + 10].color;
            num3 = Coprocessor3.mathsAccumulator.mac0;
            Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[param4 + 12].vert.x;
            Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[param4 + 12].vert.y;
            VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[param4] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[param4 + 2] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[param4 + 10] / (float)translateFactor;
            Color32 color3 = GameManager.terrainScreen[param4].color;
            VigTerrain.newColors[VigTerrain.index] = color3;
            VigTerrain.newColors[VigTerrain.index + 1] = color;
            VigTerrain.newColors[VigTerrain.index + 2] = color2;
            VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
            VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index + 2;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index;
            VigTerrain.index += 3;
            VigTerrain.index3 += 3;
            Coprocessor3.ExecuteNCLIP();
            num3 = Coprocessor3.mathsAccumulator.mac0;
            VigTerrain.newColors[VigTerrain.index] = GameManager.terrainScreen[param4 + 12].color;
            VigTerrain.newColors[VigTerrain.index + 1] = color;
            VigTerrain.newColors[VigTerrain.index + 2] = color2;
            VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
            VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[param4 + 12] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[param4 + 2] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[param4 + 10] / (float)translateFactor;
            VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index + 2;
            VigTerrain.index += 3;
            VigTerrain.index3 += 3;
            return;
        }
        int num7;
        int num8;
        int num9;
        if (num == 15U)
        {
            short num5;
            if (GameManager.terrainScreen[param4].vert.x < 1 && GameManager.terrainScreen[param4 + 2].vert.x < 1 && GameManager.terrainScreen[param4 + 10].vert.x < 1)
            {
                num5 = GameManager.DAT_1f800094;
            }
            else
            {
                num5 = GameManager.DAT_1f800094;
            }
            short num6;
            if (GameManager.terrainScreen[param4].vert.x < (int)num5 || GameManager.terrainScreen[param4 + 2].vert.x < (int)num5 || GameManager.terrainScreen[param4 + 10].vert.x < (int)num5)
            {
                num6 = (short)GameManager.terrainScreen[param4].vert.y;
            }
            else
            {
                num6 = (short)GameManager.terrainScreen[param4].vert.y;
            }
            num5 = (short)GameManager.terrainScreen[param4 + 2].vert.y;
            if (num6 < 1 && num5 < 1 && GameManager.terrainScreen[param4 + 10].vert.y < 1)
            {
                num6 = GameManager.DAT_1f800096;
            }
            else
            {
                num6 = GameManager.DAT_1f800096;
            }
            if (num5 == 0 && num6 <= num5 && (int)num6 <= GameManager.terrainScreen[param4 + 10].vert.y)
            {
                num2 = GameManager.DAT_1f800084.y;
            }
            else
            {
                num2 = GameManager.DAT_1f800084.y;
            }
            Coprocessor3.vector0.vz0 = (short)param2;
            num = (uint)(num2 * 65536);
            Coprocessor3.vector1.vz1 = (short)(param2 + 256);
            Coprocessor3.vector2.vz2 = (short)(param2 + 512);
            num4 = ((param1 + 256U) & 65535U) | num;
            num7 = (int)((uint)(VigTerrain._vertices[VigTerrain.puVar14 + 64] & 2047) * 524288U + num4);
            num8 = (int)((uint)(VigTerrain._vertices[VigTerrain.puVar14 + 65] & 2047) * 524288U + num4);
            num9 = (int)((uint)(VigTerrain._vertices[VigTerrain.puVar16 + 64] & 2047) * 524288U + num4);
            Coprocessor3.vector0.vx0 = (short)num7;
            Coprocessor3.vector0.vy0 = (short)(num7 >> 16);
            Coprocessor3.vector1.vx1 = (short)num8;
            Coprocessor3.vector1.vy1 = (short)(num8 >> 16);
            Coprocessor3.vector2.vx2 = (short)num9;
            Coprocessor3.vector2.vy2 = (short)(num9 >> 16);
            VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
            VigTerrain.terrainVertices[1] = new Vector3Int((int)Coprocessor3.vector1.vx1, (int)Coprocessor3.vector1.vy1, (int)Coprocessor3.vector1.vz1);
            VigTerrain.terrainVertices[2] = new Vector3Int((int)Coprocessor3.vector2.vx2, (int)Coprocessor3.vector2.vy2, (int)Coprocessor3.vector2.vz2);
            Coprocessor3.ExecuteRTPT(12, false);
            num5 = (short)VigTerrain._vertices[VigTerrain.puVar14 + 1];
            num6 = (short)VigTerrain._vertices[VigTerrain.puVar15 + 1];
            GameManager.terrainScreen[param4 + 1].vert.x = (int)Coprocessor3.screenXYFIFO.sx0;
            GameManager.terrainScreen[param4 + 1].vert.y = (int)Coprocessor3.screenXYFIFO.sy0;
            GameManager.terrainScreen[param4 + 11].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[param4 + 11].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
            VigTerrain.terrainWorld[param4 + 1] = VigTerrain.terrainVertices[0];
            VigTerrain.terrainWorld[param4 + 11] = VigTerrain.terrainVertices[2];
            Coprocessor3.vector0.vx0 = (short)param1;
            Coprocessor3.vector0.vy0 = (short)((long)((int)((long)num5 & 2047L) * 524288) + (long)((ulong)num) >> 16);
            num9 = (int)((long)num6 & 2047L) * 524288 + (int)(((param1 + 512U) & 65535U) | num);
            Coprocessor3.vector2.vx2 = (short)num9;
            Coprocessor3.vector2.vy2 = (short)(num9 >> 16);
            Coprocessor3.vector0.vz0 = (short)(param2 + 256);
            Coprocessor3.vector2.vz2 = (short)(param2 + 256);
            VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
            VigTerrain.terrainVertices[2] = new Vector3Int((int)Coprocessor3.vector2.vx2, (int)Coprocessor3.vector2.vy2, (int)Coprocessor3.vector2.vz2);
            GameManager.terrainScreen[param4 + 1].vert.z = (int)Coprocessor3.screenZFIFO.sz1;
            GameManager.terrainScreen[param4 + 11].vert.z = (int)Coprocessor3.screenZFIFO.sz3;
            Coprocessor3.ExecuteRTPT(12, false);
            GameManager.terrainScreen[param4 + 5].vert = new Vector3Int((int)Coprocessor3.screenXYFIFO.sx0, (int)Coprocessor3.screenXYFIFO.sy0, (int)Coprocessor3.screenZFIFO.sz1);
            GameManager.terrainScreen[param4 + 6].vert = new Vector3Int((int)Coprocessor3.screenXYFIFO.sx1, (int)Coprocessor3.screenXYFIFO.sy1, (int)Coprocessor3.screenZFIFO.sz2);
            GameManager.terrainScreen[param4 + 7].vert = new Vector3Int((int)Coprocessor3.screenXYFIFO.sx2, (int)Coprocessor3.screenXYFIFO.sy2, (int)Coprocessor3.screenZFIFO.sz3);
            VigTerrain.terrainWorld[param4 + 5] = VigTerrain.terrainVertices[0];
            VigTerrain.terrainWorld[param4 + 6] = VigTerrain.terrainVertices[1];
            VigTerrain.terrainWorld[param4 + 7] = VigTerrain.terrainVertices[2];
            VigTerrain.in_t0 = (uint)VigTerrain._vertices[VigTerrain.puVar14];
            VigTerrain.in_t1 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 64];
            VigTerrain.in_t2 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 1];
            VigTerrain.in_t3 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 65];
            VigTerrain.in_t4 = (int)VigTerrain._tiles[VigTerrain.puVar14];
            VigTerrain.FUN_29520((int)param1, param2, param3, param4);
            VigTerrain.in_t0 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 64];
            VigTerrain.in_t1 = (uint)VigTerrain._vertices[VigTerrain.puVar15];
            VigTerrain.in_t2 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 65];
            VigTerrain.in_t3 = (uint)VigTerrain._vertices[VigTerrain.puVar15 + 1];
            VigTerrain.in_t4 = (int)VigTerrain._tiles[VigTerrain.puVar14 + 64];
            param4++;
            VigTerrain.FUN_29520((int)param1, param2, param3, param4);
            VigTerrain.in_t0 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 1];
            VigTerrain.in_t1 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 65];
            VigTerrain.in_t2 = (uint)VigTerrain._vertices[VigTerrain.puVar16];
            VigTerrain.in_t3 = (uint)VigTerrain._vertices[VigTerrain.puVar16 + 64];
            VigTerrain.in_t4 = (int)VigTerrain._tiles[VigTerrain.puVar14 + 1];
            param4 += 4;
            VigTerrain.FUN_29520((int)param1, param2, param3, param4);
            VigTerrain.in_t0 = (uint)VigTerrain._vertices[VigTerrain.puVar14 + 65];
            VigTerrain.in_t1 = (uint)VigTerrain._vertices[VigTerrain.puVar15 + 1];
            VigTerrain.in_t2 = (uint)VigTerrain._vertices[VigTerrain.puVar16 + 64];
            VigTerrain.in_t3 = (uint)VigTerrain._vertices[VigTerrain.puVar17];
            VigTerrain.in_t4 = (int)VigTerrain._tiles[VigTerrain.puVar14 + 65];
            param4++;
            VigTerrain.FUN_29520((int)param1, param2, param3, param4);
            return;
        }
        num4 = (uint)((uint)GameManager.DAT_1f800084.y << 16);
        num7 = (int)((uint)(VigTerrain._vertices[VigTerrain.puVar14 + 1] & 2047) * 524288U + (num4 | param1));
        Coprocessor3.vector0.vx0 = (short)num7;
        Coprocessor3.vector0.vy0 = (short)(num7 >> 16);
        Coprocessor3.vector0.vz0 = (short)(param2 + 256);
        VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
        Coprocessor3.ExecuteRTPS(12, false);
        Coprocessor3.vector1.vz1 = (short)(param2 + 512);
        Coprocessor3.vector2.vz2 = (short)(param2 + 256);
        uint num10 = ((param1 + 256U) & 65535U) | num4;
        uint num11 = ((param1 + 512U) & 65535U) | num4;
        Coprocessor3.vector0.vz0 = (short)param2;
        num7 = (int)((uint)(VigTerrain._vertices[VigTerrain.puVar14 + 64] & 2047) * 524288U + num10);
        Coprocessor3.vector0.vx0 = (short)num7;
        Coprocessor3.vector0.vy0 = (short)(num7 >> 16);
        num8 = (int)((uint)(VigTerrain._vertices[VigTerrain.puVar16 + 64] & 2047) * 524288U + num10);
        Coprocessor3.vector1.vx1 = (short)num8;
        Coprocessor3.vector1.vy1 = (short)(num8 >> 16);
        num9 = (int)((uint)(VigTerrain._vertices[VigTerrain.puVar15 + 1] & 2047) * 524288U + num11);
        Coprocessor3.vector2.vx2 = (short)num9;
        Coprocessor3.vector2.vy2 = (short)(num9 >> 16);
        GameManager.terrainScreen[param4 + 5].vert = new Vector3Int((int)Coprocessor3.screenXYFIFO.sx2, (int)Coprocessor3.screenXYFIFO.sy2, (int)Coprocessor3.screenZFIFO.sz3);
        VigTerrain.terrainWorld[param4 + 5] = VigTerrain.terrainVertices[0];
        VigTerrain.terrainVertices[0] = new Vector3Int((int)Coprocessor3.vector0.vx0, (int)Coprocessor3.vector0.vy0, (int)Coprocessor3.vector0.vz0);
        VigTerrain.terrainVertices[1] = new Vector3Int((int)Coprocessor3.vector1.vx1, (int)Coprocessor3.vector1.vy1, (int)Coprocessor3.vector1.vz1);
        VigTerrain.terrainVertices[2] = new Vector3Int((int)Coprocessor3.vector2.vx2, (int)Coprocessor3.vector2.vy2, (int)Coprocessor3.vector2.vz2);
        Coprocessor3.ExecuteRTPT(12, false);
        GameManager.terrainScreen[param4 + 5].color = VigTerrain.DAT_BA4F0[VigTerrain._vertices[VigTerrain.puVar14 + 1] >> 11];
        GameManager.terrainScreen[param4 + 1].color = VigTerrain.DAT_BA4F0[VigTerrain._vertices[VigTerrain.puVar14 + 64] >> 11];
        GameManager.terrainScreen[param4 + 11].color = VigTerrain.DAT_BA4F0[VigTerrain._vertices[VigTerrain.puVar16 + 64] >> 11];
        GameManager.terrainScreen[param4 + 7].color = VigTerrain.DAT_BA4F0[VigTerrain._vertices[VigTerrain.puVar15 + 1] >> 11];
        VigTerrain.in_t1 = GameManager.DAT_639EC[(int)((num - 1U) * 2U)] >> 1;
        VigTerrain.in_t0 = GameManager.DAT_639EC[(int)((num - 1U) * 2U + 1U)] >> 1;
        GameManager.terrainScreen[param4 + 1].vert.x = (int)Coprocessor3.screenXYFIFO.sx0;
        GameManager.terrainScreen[param4 + 1].vert.y = (int)Coprocessor3.screenXYFIFO.sy0;
        GameManager.terrainScreen[param4 + 11].vert.x = (int)Coprocessor3.screenXYFIFO.sx1;
        GameManager.terrainScreen[param4 + 11].vert.y = (int)Coprocessor3.screenXYFIFO.sy1;
        GameManager.terrainScreen[param4 + 7].vert.x = (int)Coprocessor3.screenXYFIFO.sx2;
        GameManager.terrainScreen[param4 + 7].vert.y = (int)Coprocessor3.screenXYFIFO.sy2;
        VigTerrain.terrainWorld[param4 + 1] = VigTerrain.terrainVertices[0];
        VigTerrain.terrainWorld[param4 + 11] = VigTerrain.terrainVertices[1];
        VigTerrain.terrainWorld[param4 + 7] = VigTerrain.terrainVertices[2];
        VigTerrain.FUN_297E8(param1, param2, param4);
    }

    // Token: 0x06000BFB RID: 3067 RVA: 0x000A34C4 File Offset: 0x000A16C4
    private static void FUN_29520(int param1, int param2, int param3, int param4)
    {
        int translateFactor = GameManager.instance.translateFactor2;
        int num = (int)((ushort)GameManager.DAT_1f80009a - 4096);
        int num2 = VigTerrain.in_t4;
        param3 = Mathf.Clamp(param3, 1, 16);
        if ((VigTerrain._tileData[num2].flags & 1) == 0)
        {
            uint num3 = (uint)GameManager.terrainScreen[param4].vert.z;
            if (GameManager.terrainScreen[param4].vert.z < GameManager.terrainScreen[param4 + 1].vert.z)
            {
                num3 = (uint)GameManager.terrainScreen[param4 + 1].vert.z;
            }
            int num4 = (int)(VigTerrain.in_t1 >> 11);
            if (num3 < (uint)GameManager.terrainScreen[param4 + 5].vert.z)
            {
                num3 = (uint)GameManager.terrainScreen[param4 + 5].vert.z;
            }
            uint z = (uint)GameManager.terrainScreen[param4 + 6].vert.z;
            int num5 = (int)(VigTerrain.in_t2 >> 11);
            if (num3 < z)
            {
                num3 = z;
            }
            Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[param4].vert.x;
            Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[param4].vert.y;
            if (0U < num3)
            {
                Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[param4 + 1].vert.x;
                Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[param4 + 1].vert.y;
                Color32 color;
                Color32 color3;
                if ((VigTerrain._tileData[num2].flags & 2) == 0)
                {
                    Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[param4 + 5].vert.x;
                    Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[param4 + 5].vert.y;
                    num = (int)(num3 - (uint)num);
                    Coprocessor3.ExecuteNCLIP();
                    ushort dat_DA = GameManager.instance.DAT_DA8;
                    if (0 < num)
                    {
                        ushort dat_DA2 = GameManager.instance.DAT_DA8;
                    }
                    color = GameManager.DAT_1f800000[num4];
                    num = Coprocessor3.mathsAccumulator.mac0;
                    Color32 color2 = GameManager.DAT_1f800000[num5];
                    color3 = GameManager.DAT_1f800000[(int)(VigTerrain.in_t0 >> 11)];
                    VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[param4] / (float)translateFactor;
                    VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[param4 + 1] / (float)translateFactor;
                    VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[param4 + 5] / (float)translateFactor;
                    param3 = (int)Mathf.Clamp(Vector3.Distance(new Vector3(0f, 0f, 0f), new Vector3(VigTerrain.newVertices[VigTerrain.index + 2].x, 0f, VigTerrain.newVertices[VigTerrain.index + 2].z)) / 16f, 1f, 16f);
                    param3 = 1;
                    VigTerrain.newColors[VigTerrain.index] = color3;
                    VigTerrain.newColors[VigTerrain.index + 1] = color;
                    VigTerrain.newColors[VigTerrain.index + 2] = color2;
                    VigTerrain.newUVs[VigTerrain.index] = new Vector2((float)VigTerrain._tileData[num2].uv1_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv1_y / (float)(VigTerrain.mainHeight - 1));
                    VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2((float)VigTerrain._tileData[num2].uv2_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv2_y / (float)(VigTerrain.mainHeight - 1));
                    VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2((float)VigTerrain._tileData[num2].uv3_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv3_y / (float)(VigTerrain.mainHeight - 1));
                    VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1]] = VigTerrain.index + 2;
                    VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1] + 1] = VigTerrain.index + 1;
                    VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1] + 2] = VigTerrain.index;
                    VigTerrain.index += 3;
                    VigTerrain.index2[param3 - 1] += 3;
                    Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[param4 + 6].vert.x;
                    Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[param4 + 6].vert.y;
                    Coprocessor3.ExecuteNCLIP();
                    color3 = GameManager.DAT_1f800000[(int)(VigTerrain.in_t3 >> 11)];
                    VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[param4 + 6] / (float)translateFactor;
                    VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[param4 + 1] / (float)translateFactor;
                    VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[param4 + 5] / (float)translateFactor;
                    VigTerrain.newColors[VigTerrain.index] = color3;
                    VigTerrain.newColors[VigTerrain.index + 1] = color;
                    VigTerrain.newColors[VigTerrain.index + 2] = color2;
                    VigTerrain.newUVs[VigTerrain.index] = new Vector2((float)VigTerrain._tileData[num2].uv4_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv4_y / (float)(VigTerrain.mainHeight - 1));
                    VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2((float)VigTerrain._tileData[num2].uv2_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv2_y / (float)(VigTerrain.mainHeight - 1));
                    VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2((float)VigTerrain._tileData[num2].uv3_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv3_y / (float)(VigTerrain.mainHeight - 1));
                    VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1]] = VigTerrain.index;
                    VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1] + 1] = VigTerrain.index + 1;
                    VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1] + 2] = VigTerrain.index + 2;
                    VigTerrain.index += 3;
                    VigTerrain.index2[param3 - 1] += 3;
                    return;
                }
                Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[param4 + 6].vert.x;
                Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[param4 + 6].vert.y;
                num = (int)(num3 - (uint)num);
                Coprocessor3.ExecuteNCLIP();
                ushort dat_DA3 = GameManager.instance.DAT_DA8;
                if (0 < num)
                {
                    ushort dat_DA4 = GameManager.instance.DAT_DA8;
                }
                color3 = GameManager.DAT_1f800000[(int)(VigTerrain.in_t0 >> 11)];
                Color32 color4 = GameManager.DAT_1f800000[(int)(VigTerrain.in_t3 >> 11)];
                color = GameManager.DAT_1f800000[num4];
                VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[param4] / (float)translateFactor;
                VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[param4 + 1] / (float)translateFactor;
                VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[param4 + 6] / (float)translateFactor;
                param3 = (int)Mathf.Clamp(Vector3.Distance(new Vector3(0f, 0f, 0f), new Vector3(VigTerrain.newVertices[VigTerrain.index + 2].x, 0f, VigTerrain.newVertices[VigTerrain.index + 2].z)) / 16f, 1f, 16f);
                param3 = 1;
                VigTerrain.newColors[VigTerrain.index] = color3;
                VigTerrain.newColors[VigTerrain.index + 1] = color;
                VigTerrain.newColors[VigTerrain.index + 2] = color4;
                VigTerrain.newUVs[VigTerrain.index] = new Vector2((float)VigTerrain._tileData[num2].uv1_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv1_y / (float)(VigTerrain.mainHeight - 1));
                VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2((float)VigTerrain._tileData[num2].uv2_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv2_y / (float)(VigTerrain.mainHeight - 1));
                VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2((float)VigTerrain._tileData[num2].uv4_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv4_y / (float)(VigTerrain.mainHeight - 1));
                VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1]] = VigTerrain.index + 2;
                VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1] + 1] = VigTerrain.index + 1;
                VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1] + 2] = VigTerrain.index;
                VigTerrain.index += 3;
                VigTerrain.index2[param3 - 1] += 3;
                Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[param4 + 5].vert.x;
                Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[param4 + 5].vert.y;
                Color32 color5 = GameManager.DAT_1f800000[num5];
                Coprocessor3.ExecuteNCLIP();
                VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[param4] / (float)translateFactor;
                VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[param4 + 5] / (float)translateFactor;
                VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[param4 + 6] / (float)translateFactor;
                VigTerrain.newColors[VigTerrain.index] = color3;
                VigTerrain.newColors[VigTerrain.index + 1] = color5;
                VigTerrain.newColors[VigTerrain.index + 2] = color4;
                VigTerrain.newUVs[VigTerrain.index] = new Vector2((float)VigTerrain._tileData[num2].uv1_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv1_y / (float)(VigTerrain.mainHeight - 1));
                VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2((float)VigTerrain._tileData[num2].uv3_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv3_y / (float)(VigTerrain.mainHeight - 1));
                VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2((float)VigTerrain._tileData[num2].uv4_x / (float)(VigTerrain.mainWidth - 1), 1f - (float)VigTerrain._tileData[num2].uv4_y / (float)(VigTerrain.mainHeight - 1));
                VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1]] = VigTerrain.index;
                VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1] + 1] = VigTerrain.index + 1;
                VigTerrain.newTriangles[param3][VigTerrain.index2[param3 - 1] + 2] = VigTerrain.index + 2;
                VigTerrain.index += 3;
                VigTerrain.index2[param3 - 1] += 3;
            }
        }
    }

    // Token: 0x06000BFC RID: 3068 RVA: 0x000A4140 File Offset: 0x000A2340
    private static void FUN_297E8(uint param1, int param2, int param4)
    {
        int translateFactor = GameManager.instance.translateFactor2;
        int num = (int)((VigTerrain.in_t1 & 31U) + (uint)param4);
        int num2 = (int)(((VigTerrain.in_t1 >> 1) & 496U) / 16U + (uint)param4);
        int num3 = (int)(((VigTerrain.in_t1 >> 6) & 496U) / 16U + (uint)param4);
        Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[num].vert.x;
        Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[num].vert.y;
        Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[num2].vert.x;
        Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[num2].vert.y;
        Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[num3].vert.x;
        Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[num3].vert.y;
        Color32 color = GameManager.terrainScreen[num2].color;
        Coprocessor3.ExecuteNCLIP();
        Color32 color2 = GameManager.terrainScreen[num3].color;
        VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[num] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[num2] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[num3] / (float)translateFactor;
        VigTerrain.newColors[VigTerrain.index] = GameManager.terrainScreen[num].color;
        VigTerrain.newColors[VigTerrain.index + 1] = color;
        VigTerrain.newColors[VigTerrain.index + 2] = color2;
        VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
        VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index + 2;
        VigTerrain.index += 3;
        VigTerrain.index3 += 3;
        int num4 = num3;
        num3 = (int)(((VigTerrain.in_t1 >> 11) & 496U) / 16U + (uint)param4);
        Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[num3].vert.x;
        Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[num3].vert.y;
        Color32 color3 = GameManager.terrainScreen[num3].color;
        Coprocessor3.ExecuteNCLIP();
        int num5 = (int)(((VigTerrain.in_t1 >> 16) & 496U) / 16U + (uint)param4);
        Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[num5].vert.x;
        Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[num5].vert.y;
        Color32 color4 = GameManager.terrainScreen[num5].color;
        VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[num3] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[num2] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[num4] / (float)translateFactor;
        VigTerrain.newColors[VigTerrain.index] = color3;
        VigTerrain.newColors[VigTerrain.index + 1] = color;
        VigTerrain.newColors[VigTerrain.index + 2] = color2;
        VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
        VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index + 2;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index;
        VigTerrain.index += 3;
        VigTerrain.index3 += 3;
        Coprocessor3.ExecuteNCLIP();
        VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[num3] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[num5] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[num4] / (float)translateFactor;
        VigTerrain.newColors[VigTerrain.index] = color3;
        VigTerrain.newColors[VigTerrain.index + 1] = color4;
        VigTerrain.newColors[VigTerrain.index + 2] = color2;
        VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
        VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index + 2;
        VigTerrain.index += 3;
        VigTerrain.index3 += 3;
        num2 = (int)((VigTerrain.in_t0 & 31U) + (uint)param4);
        num3 = (int)(((VigTerrain.in_t0 >> 1) & 496U) / 16U + (uint)param4);
        num5 = (int)(((VigTerrain.in_t0 >> 6) & 496U) / 16U + (uint)param4);
        Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[num2].vert.x;
        Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[num2].vert.y;
        Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[num3].vert.x;
        Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[num3].vert.y;
        Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[num5].vert.x;
        Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[num5].vert.y;
        color3 = GameManager.terrainScreen[num3].color;
        Coprocessor3.ExecuteNCLIP();
        color = GameManager.terrainScreen[num5].color;
        uint num6 = (VigTerrain.in_t0 >> 11) & 496U;
        num = (int)(num6 / 16U + (uint)param4);
        if (num6 == 0U)
        {
            VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[num2] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[num3] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[num5] / (float)translateFactor;
            VigTerrain.newColors[VigTerrain.index] = GameManager.terrainScreen[num2].color;
            VigTerrain.newColors[VigTerrain.index + 1] = color3;
            VigTerrain.newColors[VigTerrain.index + 2] = color;
            VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
            VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index + 2;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index;
            VigTerrain.index += 3;
            VigTerrain.index3 += 3;
            return;
        }
        VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[num2] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[num3] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[num5] / (float)translateFactor;
        VigTerrain.newColors[VigTerrain.index] = GameManager.terrainScreen[num2].color;
        VigTerrain.newColors[VigTerrain.index + 1] = color3;
        VigTerrain.newColors[VigTerrain.index + 2] = color;
        VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
        VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index + 2;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index;
        VigTerrain.index += 3;
        VigTerrain.index3 += 3;
        Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[num].vert.x;
        Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[num].vert.y;
        Color color5 = GameManager.terrainScreen[num].color;
        Coprocessor3.ExecuteNCLIP();
        uint num7 = (VigTerrain.in_t0 >> 16) & 496U;
        param4 = (int)(num7 / 16U + (uint)param4);
        if (num7 == 0U)
        {
            VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[num] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[num3] / (float)translateFactor;
            VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[num5] / (float)translateFactor;
            VigTerrain.newColors[VigTerrain.index] = color5;
            VigTerrain.newColors[VigTerrain.index + 1] = color3;
            VigTerrain.newColors[VigTerrain.index + 2] = color;
            VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
            VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
            VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
            VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index + 2;
            VigTerrain.index += 3;
            VigTerrain.index3 += 3;
            return;
        }
        Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[param4].vert.x;
        Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[param4].vert.y;
        color4 = GameManager.terrainScreen[param4].color;
        VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[num] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[num3] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[num5] / (float)translateFactor;
        VigTerrain.newColors[VigTerrain.index] = color5;
        VigTerrain.newColors[VigTerrain.index + 1] = color3;
        VigTerrain.newColors[VigTerrain.index + 2] = color;
        VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
        VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index + 2;
        VigTerrain.index += 3;
        VigTerrain.index3 += 3;
        Coprocessor3.ExecuteNCLIP();
        VigTerrain.newVertices[VigTerrain.index] = VigTerrain.terrainWorld[num] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 1] = VigTerrain.terrainWorld[param4] / (float)translateFactor;
        VigTerrain.newVertices[VigTerrain.index + 2] = VigTerrain.terrainWorld[num5] / (float)translateFactor;
        VigTerrain.newColors[VigTerrain.index] = color5;
        VigTerrain.newColors[VigTerrain.index + 1] = color4;
        VigTerrain.newColors[VigTerrain.index + 2] = color;
        VigTerrain.newUVs[VigTerrain.index] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 1] = new Vector2(0f, 0f);
        VigTerrain.newUVs[VigTerrain.index + 2] = new Vector2(0f, 0f);
        VigTerrain.newTriangles[0][VigTerrain.index3] = VigTerrain.index + 2;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 1] = VigTerrain.index + 1;
        VigTerrain.newTriangles[0][VigTerrain.index3 + 2] = VigTerrain.index;
        VigTerrain.index += 3;
        VigTerrain.index3 += 3;
    }

    // Token: 0x06000BFD RID: 3069 RVA: 0x000A5050 File Offset: 0x000A3250
    public void FUN_45B00(int param1, int param2, int param3, int param4)
    {
        int num = param1 - param3 + 65535;
        if (num < 0)
        {
            num = param1 - param3 + 131070;
        }
        int num2 = param1 + param3;
        uint num3 = (uint)(num >> 16);
        if (num2 < 0)
        {
            num2 += 65535;
        }
        num = param2 - param3 + 65535;
        if (num < 0)
        {
            num = param2 - param3 + 131070;
        }
        uint num4 = (uint)(num >> 16);
        num = param2 + param3;
        if (num < 0)
        {
            num += 65535;
        }
        uint num5 = (uint)(num >> 16);
        Crater crater = new GameObject().AddComponent<Crater>();
        crater.indices = new ushort[((num2 >> 16) - (int)num3 + 1) * (int)(num5 - num4 + 1U)];
        crater.screen.x = param1;
        crater.screen.z = param2;
        int num6 = (param3 >> 8) * (param3 >> 8);
        int num7 = 0;
        crater.DAT_58 = param3;
        if (param4 < 0)
        {
            param4 += 2047;
        }
        while (num3 < (uint)(num2 >> 16))
        {
            if (num4 <= num5)
            {
                int num8 = (int)(num3 * 65536U - (uint)param1) >> 8;
                uint num9 = num4;
                do
                {
                    if (this.FUN_1CE1C(num3, num9).DAT_10[3] == 0)
                    {
                        int num10 = (int)(num9 * 65536U - (uint)param2) >> 8;
                        num10 = num8 * num8 + num10 * num10;
                        if (num10 <= num6)
                        {
                            int num11 = (int)((uint)(this.chunks[(int)((num3 >> 6) * 32U + (num9 >> 6))] * 4096) + ((num3 & 63U) * 128U + (num9 & 63U) * 2U) / 2U);
                            ushort num12 = (ushort)((num6 - num10) * (param4 >> 11) / num6);
                            ushort[] array = this.vertices;
                            int num13 = num11;
                            array[num13] += num12;
                            ushort[] array2 = this.vertices;
                            int num14 = num11;
                            array2[num14] &= 2047;
                            crater.indices[num7] = num12;
                        }
                        else
                        {
                            crater.indices[num7] = 0;
                        }
                    }
                    else
                    {
                        crater.indices[num7] = 0;
                    }
                    num9 += 1U;
                    num7++;
                }
                while (num9 <= num5);
            }
            num3 += 1U;
        }
        this.FUN_50E40(param1, param2, param3);
        GameManager.instance.FUN_30CB0(crater, 60);
    }

    // Token: 0x06000BFE RID: 3070 RVA: 0x000A5248 File Offset: 0x000A3448
    public void FUN_50E40(int param1, int param2, int param3)
    {
        List<Junction> roadList = LevelManager.instance.roadList;
        for (int i = 0; i < roadList.Count; i++)
        {
            Junction junction = roadList[i];
            int num = junction.pos.z - param2;
            if (num < 0)
            {
                num = -num;
            }
            int num2 = junction.pos.x - param1;
            if (num2 < 0)
            {
                num2 = -num2;
            }
            if (num < num2)
            {
                num = num2;
            }
            if (num < junction.DAT_18 + param3)
            {
                this.FUN_50C5C(junction);
            }
        }
    }

    // Token: 0x06000BFF RID: 3071 RVA: 0x000A52C0 File Offset: 0x000A34C0
    public void FUN_50C5C(Junction param1)
    {
        int num = 0;
        if (-1 < param1.DAT_1C)
        {
            do
            {
                int num2 = param1.pos.x + param1._DAT_20[num].x * 256;
                int num3 = param1.pos.z + param1._DAT_20[num].z * 256;
                int num4 = this.FUN_1B750((uint)num2, (uint)num3);
                param1._DAT_20[num] = new Vector3Int(param1._DAT_20[num].x, num4 - param1.pos.y >> 8, param1._DAT_20[num].z);
                if (num2 < 0)
                {
                    num2 += 65535;
                }
                if (num3 < 0)
                {
                    num3 += 65535;
                }
                param1._DAT_26[num] = (short)(this.vertices[(int)(this.chunks[(int)(((uint)(num2 >> 16) >> 6) * 32U + ((uint)(num3 >> 16) >> 6))] * 4096) + (((num3 >> 16) & 63) * 2 + ((num2 >> 16) & 63) * 128) / 2] >> 11 << 2);
                num3 = param1.pos.x + param1._DAT_28[num].x * 256;
                num2 = param1.pos.z + param1._DAT_28[num].z * 256;
                num4 = this.FUN_1B750((uint)num3, (uint)num2);
                param1._DAT_28[num] = new Vector3Int(param1._DAT_28[num].x, num4 - param1.pos.y >> 8, param1._DAT_28[num].z);
                if (num3 < 0)
                {
                    num3 += 65535;
                }
                if (num2 < 0)
                {
                    num2 += 65535;
                }
                param1._DAT_2E[num] = (short)(this.vertices[(int)(this.chunks[(int)(((uint)(num3 >> 16) >> 6) * 32U + ((uint)(num2 >> 16) >> 6))] * 4096) + (((num2 >> 16) & 63) * 2 + ((num3 >> 16) & 63) * 128) / 2] >> 11 << 2);
                num++;
            }
            while (num <= param1.DAT_1C);
        }
    }

    // Token: 0x04000849 RID: 2121
    public static VigTerrain instance;

    // Token: 0x0400084A RID: 2122
    public int bitmapID;

    // Token: 0x0400084B RID: 2123
    public List<TileData> tileData;

    // Token: 0x0400084C RID: 2124
    public ushort[] vertices;

    // Token: 0x0400084D RID: 2125
    public byte[] tiles;

    // Token: 0x0400084E RID: 2126
    public ushort defaultVertex;

    // Token: 0x0400084F RID: 2127
    public byte defaultTile;

    // Token: 0x04000850 RID: 2128
    public ushort[] chunks;

    // Token: 0x04000851 RID: 2129
    public int DAT_DE4;

    // Token: 0x04000852 RID: 2130
    public int DAT_DE8;

    // Token: 0x04000853 RID: 2131
    public int DAT_DEC;

    // Token: 0x04000854 RID: 2132
    public int DAT_DF0;

    // Token: 0x04000855 RID: 2133
    public int tileXZ;

    // Token: 0x04000856 RID: 2134
    public int tileY;

    // Token: 0x04000857 RID: 2135
    public int zoneCount;

    // Token: 0x04000858 RID: 2136
    public float drawDistance;

    // Token: 0x04000859 RID: 2137
    public Vector3Int[,] DAT_B9270 = new Vector3Int[2, 8];

    // Token: 0x0400085A RID: 2138
    public Color32[] DAT_B9314;

    // Token: 0x0400085B RID: 2139
    public Color32[] DAT_B932C;

    // Token: 0x0400085C RID: 2140
    public short[,] DAT_B9318 = new short[2, 20];

    // Token: 0x0400085D RID: 2141
    public Color32[] DAT_B9370 = new Color32[32];

    // Token: 0x0400085E RID: 2142
    public static Color32[] DAT_BA4F0 = new Color32[32];

    // Token: 0x0400085F RID: 2143
    public VigTransform[] DAT_BDFF0 = new VigTransform[2];

    // Token: 0x04000860 RID: 2144
    private static Vector3[] terrainWorld = new Vector3[40];

    // Token: 0x04000861 RID: 2145
    private static Vector3Int[] terrainVertices = new Vector3Int[4];

    // Token: 0x04000862 RID: 2146
    private Dictionary<int, List<int>> verticesDict;

    // Token: 0x04000863 RID: 2147
    private Dictionary<int, Tile> tilesDict;

    // Token: 0x04000864 RID: 2148
    private Mesh terrainMesh;

    // Token: 0x04000865 RID: 2149
    private static Vector3[] newVertices;

    // Token: 0x04000866 RID: 2150
    private static Vector2[] newUVs;

    // Token: 0x04000867 RID: 2151
    private static Color32[] newColors;

    // Token: 0x04000868 RID: 2152
    private static int[][] newTriangles;

    // Token: 0x04000869 RID: 2153
    private static Texture mainT;

    // Token: 0x0400086A RID: 2154
    private static int mainWidth;

    // Token: 0x0400086B RID: 2155
    private static int mainHeight;

    // Token: 0x0400086C RID: 2156
    private static int index;

    // Token: 0x0400086D RID: 2157
    private static int[] index2;

    // Token: 0x0400086E RID: 2158
    private static int index3;

    // Token: 0x0400086F RID: 2159
    private static uint in_t0;

    // Token: 0x04000870 RID: 2160
    private static uint in_t1;

    // Token: 0x04000871 RID: 2161
    private static uint in_t2;

    // Token: 0x04000872 RID: 2162
    private static uint in_t3;

    // Token: 0x04000873 RID: 2163
    private static int in_t4;

    // Token: 0x04000874 RID: 2164
    private static int puVar14;

    // Token: 0x04000875 RID: 2165
    private static int puVar15;

    // Token: 0x04000876 RID: 2166
    private static int puVar16;

    // Token: 0x04000877 RID: 2167
    private static int puVar17;

    // Token: 0x04000878 RID: 2168
    private static int puVar18;

    // Token: 0x04000879 RID: 2169
    private static List<TileData> _tileData;

    // Token: 0x0400087A RID: 2170
    private static ushort[] _vertices;

    // Token: 0x0400087B RID: 2171
    private static byte[] _tiles;

    // Token: 0x0400087C RID: 2172
    private static ushort[] _chunks;

    // Token: 0x0400087D RID: 2173
    private RectTransform canvasSky;

    // Token: 0x0400087E RID: 2174
    private RectTransform sbParent;

    // Token: 0x0400087F RID: 2175
    private RectTransform skybox;

    // Token: 0x04000880 RID: 2176
    private RectTransform skyboxRight;

    // Token: 0x04000881 RID: 2177
    private RectTransform skyboxLeft;

    // Token: 0x04000882 RID: 2178
    private RectTransform sbTop;

    // Token: 0x04000883 RID: 2179
    private RectTransform sbTopRight;

    // Token: 0x04000884 RID: 2180
    private RectTransform sbTopLeft;

    // Token: 0x04000885 RID: 2181
    private RectTransform sbBottom;

    // Token: 0x04000886 RID: 2182
    private RectTransform sbBottomRight;

    // Token: 0x04000887 RID: 2183
    private RectTransform sbBottomLeft;

    // Token: 0x04000888 RID: 2184
    private Material skyboxMat;
}
