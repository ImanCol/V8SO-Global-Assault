using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class RectTransformExtensions
{
    public static void SetLeft(this RectTransform rt, float left)
    {
        rt.offsetMin = new Vector2(left, rt.offsetMin.y);
    }

    public static void SetRight(this RectTransform rt, float right)
    {
        rt.offsetMax = new Vector2(0f - right, rt.offsetMax.y);
    }

    public static void SetTop(this RectTransform rt, float top)
    {
        rt.offsetMax = new Vector2(rt.offsetMax.x, 0f - top);
    }

    public static void SetBottom(this RectTransform rt, float bottom)
    {
        rt.offsetMin = new Vector2(rt.offsetMin.x, bottom);
    }
}

[Serializable]
public class TileData
{
    public int uv1_x, uv1_y;
    public int uv2_x, uv2_y;
    public int uv3_x, uv3_y;
    public int uv4_x, uv4_y;

    public short[] DAT_10;

    public byte DAT_1C; // 0x1C
    public byte DAT_1D; // 0x1D
    public byte DAT_1E; // 0x1E
    public byte flags; // 0x1F
}

public class Tile
{
    public Tile[] neighbours = new Tile[4];
    //0 - Up
    //1 - Down
    //2 - Left
    //3 - Right

    public int[] indices = new int[4];
    public float x, y;
}

public struct TerrainScreen
{
    public int ir0; //0x00
    public Vector3Int vert; //0x04
    public Color32 color; //0x0C
}

public struct ScreenPoly
{
    public int index;
    public Vector2Int v1, v2, v3;
    public Color32 clr1, clr2, clr3;
}



public class VigTerrain : MonoBehaviour
{
    public static VigTerrain instance;

    public int bitmapID;

    public List<TileData> tileData;

    public ushort[] vertices;

    public byte[] tiles;

    public ushort defaultVertex;

    public byte defaultTile;

    public ushort[] chunks;

    public int DAT_DE4;

    public int DAT_DE8;

    public int DAT_DEC;

    public int DAT_DF0;

    public int tileXZ;

    public int tileY;

    public int zoneCount;

    public float drawDistance;

    public Vector3Int[,] DAT_B9270 = new Vector3Int[2, 8];

    public Color32[] DAT_B9314;

    public Color32[] DAT_B932C;

    public short[,] DAT_B9318 = new short[2, 20];

    public Color32[] DAT_B9370 = new Color32[32];

    public static Color32[] DAT_BA4F0 = new Color32[32];

    public VigTransform[] DAT_BDFF0 = new VigTransform[2];

    private static Vector3[] terrainWorld = new Vector3[40];

    private static Vector3Int[] terrainVertices = new Vector3Int[4];

    private Dictionary<int, List<int>> verticesDict;

    private Dictionary<int, Tile> tilesDict;

    private Mesh terrainMesh;

    private static Vector3[] newVertices;

    private static Vector2[] newUVs;

    private static Color32[] newColors;

    private static int[][] newTriangles;

    private static Texture mainT;

    private static int mainWidth;

    private static int mainHeight;

    private static int index;

    private static int[] index2;

    private static int index3;

    private static uint in_t0;

    private static uint in_t1;

    private static uint in_t2;

    private static uint in_t3;

    private static int in_t4;

    private static int puVar14;

    private static int puVar15;

    private static int puVar16;

    private static int puVar17;

    private static int puVar18;

    private static List<TileData> _tileData;

    private static ushort[] _vertices;

    private static byte[] _tiles;

    private static ushort[] _chunks;

    private RectTransform canvasSky;

    private RectTransform sbParent;

    private RectTransform skybox;

    private RectTransform skyboxRight;

    private RectTransform skyboxLeft;

    private RectTransform sbTop;

    private RectTransform sbTopRight;

    private RectTransform sbTopLeft;

    private RectTransform sbBottom;

    private RectTransform sbBottomRight;

    private RectTransform sbBottomLeft;

    private Material skyboxMat;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        if (GetComponent<MeshFilter>() != null)
        {
            terrainMesh = new Mesh();
            terrainMesh.subMeshCount = 17;
            canvasSky = GameObject.Find("CanvasSky").GetComponent<RectTransform>();
            sbParent = GameObject.Find("SB").GetComponent<RectTransform>();
            skybox = GameObject.Find("SkyBox").GetComponent<RectTransform>();
            skyboxRight = GameObject.Find("SkyBoxRight").GetComponent<RectTransform>();
            skyboxLeft = GameObject.Find("SkyBoxLeft").GetComponent<RectTransform>();
            sbTop = GameObject.Find("SB_Top").GetComponent<RectTransform>();
            sbTopRight = GameObject.Find("SB_TopRight").GetComponent<RectTransform>();
            sbTopLeft = GameObject.Find("SB_TopLeft").GetComponent<RectTransform>();
            sbBottom = GameObject.Find("SB_Bottom").GetComponent<RectTransform>();
            sbBottomRight = GameObject.Find("SB_BottomRight").GetComponent<RectTransform>();
            sbBottomLeft = GameObject.Find("SB_BottomLeft").GetComponent<RectTransform>();
            skyboxMat = skybox.GetComponent<Image>().material;
            GetComponent<MeshFilter>().mesh = terrainMesh;
            Material material = GetComponent<MeshRenderer>().materials[1];
            mainT = GetComponent<MeshRenderer>().materials[1].mainTexture;
            DAT_BDFF0 = new VigTransform[2];
        }
        if (this.tileData == null || this.tileData.Count == 0)
        {
            this.tileData = new List<TileData>();
            TileData tileData = new TileData();
            tileData.DAT_10 = new short[6];
            this.tileData.Add(tileData);
        }
    }

    private void Start()
    {
        if (!GameManager.instance.inMenu)
        {
            newVertices = new Vector3[32768];
            newColors = new Color32[32768];
            newUVs = new Vector2[32768];
            newTriangles = new int[17][];
            newTriangles[0] = new int[32768];
            index2 = new int[16];
            newTriangles[1] = new int[32768];
            _tileData = tileData;
            _tiles = tiles;
            _vertices = vertices;
            _chunks = chunks;
            mainWidth = mainT.width;
            mainHeight = mainT.height;
        }
    }

    public void UpdatePosition(Vector3 pos)
    {
        base.transform.position = pos;
        base.transform.position = new Vector3(pos.x, 0f - pos.y, pos.z);
    }

    public void ClearTerrainData()
    {
        for (int i = 0; i < index; i++)
        {
            newVertices[i] = new Vector3(0f, 0f, 0f);
            newUVs[i] = new Vector2(0f, 0f);
        }
        for (int j = 0; j < index3; j++)
        {
            newTriangles[0][j] = 0;
        }
        for (int k = 0; k < 16; k++)
        {
            for (int l = 0; l < index2[k]; l++)
            {
                newTriangles[k + 1][l] = 0;
            }
        }
        index = 0;
        index3 = 0;
        for (int m = 0; m < index2.Length; m++)
        {
            index2[m] = 0;
        }
        terrainMesh.Clear();
    }

    public void CreateTerrainMesh()
    {
        terrainMesh.subMeshCount = 17;
        for (int i = 0; i < newVertices.Length; i++)
        {
            newVertices[i] = new Vector3(newVertices[i].x, 0f - newVertices[i].y, newVertices[i].z);
        }
        terrainMesh.SetVertices(newVertices, 0, index);
        terrainMesh.SetColors(newColors, 0, index);
        terrainMesh.SetUVs(0, newUVs, 0, index);
        terrainMesh.SetTriangles(newTriangles[0], 0, index3, 0);
        for (int j = 1; j < 17; j++)
        {
            terrainMesh.SetTriangles(newTriangles[j], 0, index2[j - 1], j, calculateBounds: false);
        }
    }

    private bool InsideCircle(Tile center, Tile tile, float radius)
    {
        float num = center.x - tile.x;
        float num2 = center.y - tile.y;
        return num * num + num2 * num2 <= radius * radius;
    }

    private List<Tile> BreadthFirstSearch(Tile start, float radius)
    {
        Queue<Tile> queue = new Queue<Tile>();
        queue.Enqueue(start);
        List<Tile> list = new List<Tile>();
        list.Add(start);
        while (queue.Count > 0)
        {
            Tile[] neighbours = queue.Dequeue().neighbours;
            foreach (Tile tile in neighbours)
            {
                if (!list.Contains(tile) && InsideCircle(start, tile, radius))
                {
                    queue.Enqueue(tile);
                    list.Add(tile);
                }
            }
        }
        return list;
    }

    public void SetNumberOfZones()
    {
        vertices = new ushort[zoneCount * 4096];
        tiles = new byte[zoneCount * 4096];
        chunks = new ushort[1024];
        for (int i = 0; i < 4096; i++)
        {
            vertices[i] = defaultVertex;
            tiles[i] = defaultTile;
        }
    }

    public void FUN_1C910()
    {
        float num = LevelManager.instance.defaultCamera.transform.eulerAngles.x;
        float num2 = LevelManager.instance.defaultCamera.transform.eulerAngles.y / 180f * GameManager.instance.offsetFactor;
        skyboxMat.mainTextureOffset = new Vector2(num2 + GameManager.instance.offsetStart, 0f);
        if (num > 180f)
        {
            num -= 360f;
        }
        else if (num < -180f)
        {
            num += 360f;
        }
        float num3 = 0.5f + num / 30f + GameManager.instance.angleOffset;
        skybox.pivot = new Vector2(0.5f, num3);
        skyboxLeft.pivot = new Vector2(0.5f, num3);
        skyboxRight.pivot = new Vector2(0.5f, num3);
        sbTop.anchorMin = new Vector2(0f, Mathf.Clamp(num3, 0f, 1f));
        sbTopLeft.anchorMin = new Vector2(-1f, Mathf.Clamp(num3, 0f, 1f));
        sbTopRight.anchorMin = new Vector2(1f, Mathf.Clamp(num3, 0f, 1f));
        sbBottom.anchorMax = new Vector2(1f, Mathf.Clamp(num3, 0f, 1f));
        sbBottomLeft.anchorMax = new Vector2(0f, Mathf.Clamp(num3, 0f, 1f));
        sbBottomRight.anchorMax = new Vector2(2f, Mathf.Clamp(num3, 0f, 1f));
        Vector3 localEulerAngles = canvasSky.localEulerAngles;
        localEulerAngles = new Vector3(0f, 0f, 0f - localEulerAngles.z);
        sbParent.localRotation = Quaternion.Euler(localEulerAngles);
        float num4 = (LevelManager.instance.defaultCamera.aspect - 1.33333f) * GameManager.instance.aspectRatioScale;
        sbParent.SetLeft(num4);
        sbParent.SetRight(num4);
    }

    public ushort FUN_1CF5C(uint param1, uint param2)
    {
        return (ushort)(vertices[chunks[(param1 >> 6) * 32 + (param2 >> 6)] * 4096 + ((param2 & 0x3F) * 128 + (param1 & 0x3F) * 2) / 2u] & 0x7FF);
    }

    public TileData FUN_1CE1C(uint param1, uint param2)
    {
        return tileData[tiles[chunks[(param1 >> 6) * 32 + (param2 >> 6)] * 4096 + (int)(param2 & 0x3F) + (int)((param1 & 0x3F) * 64)]];
    }

    public static void FUN_1BE68(int param1, int param2, int param3)
    {
        if (param1 < param2)
        {
            int num = 0;
            do
            {
                FUN_288E0((uint)param1, (uint)param3, num++);
                param1 += 4;
            }
            while (param1 < param2);
        }
    }

    public Vector3Int FUN_1B998(uint x, uint z)
    {
        if ((int)x > 0 && (int)z > 0 && (int)x < 117440512 && (int)z < 117440512)
        {
            uint num = x >> 16;
            uint num2 = z >> 16;
            if ((x & 0xFFFF) + (z & 0xFFFF) < 65536)
            {
                uint num3 = z >> 22 << 2;
                x = x >> 22 << 7;
                uint num4 = (num2 & 0x3F) << 1;
                uint num5 = (num & 0x3F) << 7;
                int num6 = chunks[(num3 + x) / 4u];
                int num7 = (int)(num4 + num5) / 2;
                uint num8 = num + 1;
                num3 += num8 >> 6 << 7;
                int num9 = chunks[num3 / 4u];
                num8 = (num8 & 0x3F) << 7;
                int num10 = (int)(num4 + num8) / 2;
                int num11 = vertices[num6 * 4096 + num7] & 0x7FF;
                int num12 = vertices[num9 * 4096 + num10] & 0x7FF;
                num8 = num2 + 1;
                int num13 = chunks[((num8 >> 6 << 2) + x) / 4u];
                num8 = (num8 & 0x3F) << 1;
                int num14 = (int)(num8 + num5) / 2;
                int num15 = vertices[num13 * 4096 + num14] & 0x7FF;
                return new Vector3Int(num12 - num11, -32, num15 - num11);
            }
            uint num16 = num + 1;
            uint num17 = num2 + 1;
            uint num18 = num17 >> 6 << 2;
            uint num19 = num16 >> 6 << 7;
            uint num20 = (num17 & 0x3F) << 1;
            num16 = (num16 & 0x3F) << 7;
            int num21 = chunks[(num18 + num19) / 4u];
            int num22 = (int)(num20 + num16) / 2;
            num18 += x >> 22 << 7;
            int num23 = chunks[num18 / 4u];
            int num24 = (int)(num20 + ((num & 0x3F) << 7)) / 2;
            int num25 = vertices[num21 * 4096 + num22] & 0x7FF;
            int num26 = vertices[num23 * 4096 + num24] & 0x7FF;
            num18 = (num2 & 0x3F) << 1;
            int num27 = chunks[((z >> 22 << 2) + num19) / 4u];
            int num28 = (int)(num18 + num16) / 2;
            int num29 = vertices[num27 * 4096 + num28] & 0x7FF;
            return new Vector3Int(num25 - num26, -32, num25 - num29);
        }
        return new Vector3Int(4096, 4096, 4096);
    }

    public TileData GetTileByPosition(uint x, uint z)
    {
        if ((int)x > 0 && (int)z > 0 && (int)x < 117440512 && (int)z < 117440512)
        {
            uint num = z >> 16;
            z = z >> 22 << 2;
            z += x >> 22 << 7;
            num &= 0x3F;
            x = ((x >> 10) & 0xFC0);
            int num2 = (int)(z / 4u);
            if (num2 >= chunks.Length)
            {
                num2 = 0;
                num = 0u;
            }
            else
            {
                num += x;
            }
            int num3 = chunks[num2];
            return tileData[tiles[num3 * 4096 + num]];
        }
        return tileData[0];
    }

    public Tile GetTileByPosition2(uint x, uint z)
    {
        if ((int)x > 0 && (int)z > 0 && (int)x < 117440512 && (int)z < 117440512)
        {
            uint num = z >> 16;
            z = z >> 22 << 2;
            z += x >> 22 << 7;
            num &= 0x3F;
            x = ((x >> 10) & 0xFC0);
            int num2 = chunks[z / 4u];
            num += x;
            return tilesDict[num2 * 4096 + (int)num];
        }
        return tilesDict[0];
    }

    public int FUN_1B750(uint x, uint z)
    {
        if ((int)x > 0 && (int)z > 0 && (int)x < 117440512 && (int)z < 117440512)
        {
            int num = (int)(x & 0xFFFF);
            int num2 = num;
            uint num3 = z & 0xFFFF;
            int num4 = (int)num3;
            uint num5 = x >> 16;
            uint num6 = z >> 16;
            if (num + num3 < 65536)
            {
                uint num7 = z >> 22 << 2;
                x = x >> 22 << 7;
                uint num8 = (num6 & 0x3F) << 1;
                uint num9 = (num5 & 0x3F) << 7;
                int num10 = chunks[(num7 + x) / 4u];
                int num11 = (int)(num8 + num9);
                num7 += num5 + 1 >> 6 << 7;
                num8 += ((num5 + 1) & 0x3F) << 7;
                num7 = (uint)(vertices[chunks[num7 / 4u] * 4096 + num8 / 2u] & 0x7FF);
                num8 = (uint)(vertices[num10 * 4096 + num11 / 2] & 0x7FF);
                int num12 = (int)(num7 - num8);
                num12 = num * num12;
                num10 = chunks[(int)((num6 + 1 >> 6 << 2) + x) / 4];
                num11 = (int)((((num6 + 1) & 0x3F) << 1) + num9);
                int num13 = (vertices[num10 * 4096 + num11 / 2] & 0x7FF) - (int)num8;
                num13 = num12 + (int)num3 * num13;
                num13 += (int)(num8 << 16);
                if (num13 < 0)
                {
                    num13 += 31;
                }
                return num13 >> 5;
            }
            uint num14 = num5 + 1;
            uint num15 = num6 + 1;
            uint num16 = num15 >> 6 << 2;
            uint num17 = num14 >> 6 << 7;
            uint num18 = (num15 & 0x3F) << 1;
            num14 = (num14 & 0x3F) << 7;
            int num19 = chunks[(num16 + num17) / 4u];
            int num20 = (int)(num18 + num14);
            int num21 = chunks[(num16 + (x >> 22 << 7)) / 4u];
            int num22 = (int)(num18 + ((num5 & 0x3F) << 7)) / 2;
            int num23 = vertices[num21 * 4096 + num22] & 0x7FF;
            num16 = (z >> 22 << 2) + num17;
            int num24 = 65536;
            int num25 = vertices[num19 * 4096 + num20 / 2] & 0x7FF;
            int num26 = num24 - num2;
            num23 -= num25;
            int num27 = num26 * num23;
            int num28 = chunks[num16 / 4u];
            num24 -= num4;
            int num29 = (int)(((num6 & 0x3F) << 1) + num14);
            int num30 = vertices[num28 * 4096 + num29 / 2] & 0x7FF;
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
        return 0;
    }

    public Vector3Int FUN_1BB50(int param1, int param2)
    {
        Vector3Int result = default(Vector3Int);
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
            num += (int)num4 * -65536;
            num3 = num2;
            if (num2 < 0)
            {
                num3 = param2 + 32767;
            }
            uint num5 = (uint)(num3 >> 16);
            num2 += (int)num5 * -65536;
            uint num6 = num5 >> 6;
            uint num7 = num4 >> 6;
            num3 = (int)((num5 & 0x3F) * 2);
            int num8 = (int)((num4 & 0x3F) * 128);
            int num9 = 65536 - num;
            uint num10 = num4 + 1 >> 6;
            int num11 = (int)(((num4 + 1) & 0x3F) * 128);
            uint num12 = (uint)(vertices[chunks[num7 * 32 + num6] * 4096 + (num3 + num8) / 2] & 0x7FF);
            uint num13 = (uint)(vertices[chunks[num10 * 32 + num6] * 4096 + (num3 + num11) / 2] & 0x7FF);
            uint num14 = num4 + 2 >> 6;
            int num15 = (int)(((num4 + 2) & 0x3F) * 128);
            num4 = num5 + 1 >> 6;
            int num16 = (int)(((num5 + 1) & 0x3F) * 2);
            num3 = (int)(num13 - num12) * num9 + ((vertices[chunks[num14 * 32 + num6] * 4096 + (num3 + num15) / 2] & 0x7FF) - (int)num13) * num;
            uint num17 = (uint)(vertices[chunks[num7 * 32 + num4] * 4096 + (num16 + num8) / 2] & 0x7FF);
            num6 = (uint)(vertices[chunks[num10 * 32 + num4] * 4096 + (num16 + num11) / 2] & 0x7FF);
            if (num3 < 0)
            {
                num3 += 65535;
            }
            int num18 = 65536 - num2;
            num16 = (int)(num6 - num17) * num9 + ((vertices[chunks[num14 * 32 + num4] * 4096 + (num16 + num15) / 2] & 0x7FF) - (int)num6) * num;
            if (num16 < 0)
            {
                num16 += 65535;
            }
            num3 = (num3 >> 16) * num18 + (num16 >> 16) * num2;
            int x = num3 >> 16;
            if (num3 < 0)
            {
                x = num3 + 65535 >> 16;
            }
            result.x = x;
            result.y = -32;
            num4 = num5 + 2 >> 6;
            num16 = (int)(((num5 + 2) & 0x3F) * 2);
            num3 = (int)(num17 - num12) * num18 + ((vertices[chunks[num7 * 32 + num4] * 4096 + (num16 + num8) / 2] & 0x7FF) - (int)num17) * num2;
            if (num3 < 0)
            {
                num3 += 65535;
            }
            num2 = (int)(num6 - num13) * num18 + ((vertices[chunks[num10 * 32 + num4] * 4096 + (num16 + num11) / 2] & 0x7FF) - (int)num6) * num2;
            if (num2 < 0)
            {
                num2 += 65535;
            }
            num3 = (num3 >> 16) * num9 + (num2 >> 16) * num;
            x = num3 >> 16;
            if (num3 < 0)
            {
                x = num3 + 65535 >> 16;
            }
            result.z = x;
            return result;
        }
        return new Vector3Int(1, 1, 1);
    }

    public void FUN_2D16C(int param1, int param2, ref VigTransform param3)
    {
        Vector3Int n = FUN_1B998((uint)param1, (uint)param2);
        n = Utilities.VectorNormal(n);
        param3.position.x = param1;
        int y = FUN_1B750((uint)param1, (uint)param2);
        param3.position.y = y;
        param3.position.z = param2;
        param3.rotation = Utilities.FUN_2A5EC(n);
    }

    private static void FUN_288E0(uint param1, uint param2, int param3)
    {
        int num = (int)((param1 >> 6) * 32 + (param2 >> 6));
        int num2 = (int)(((param2 & 0x3F) + (param1 & 0x3F) * 64) * 2);
        puVar14 = _chunks[num] * 4096 + num2 / 2;
        uint num3 = (param1 + 4) & 0x3F;
        puVar15 = puVar14 + 256;
        if (num3 == 0)
        {
            puVar15 = _chunks[32 + num] * 4096 + (num2 - 7680) / 2;
        }
        puVar16 = puVar14 + 4;
        puVar17 = puVar15 + 4;
        if (((param2 + 4) & 0x3F) == 0)
        {
            puVar16 = _chunks[1 + num] * 4096 + (num2 - 120) / 2;
            puVar17 = puVar16 + 256;
            if (num3 == 0)
            {
                puVar17 = _chunks[33 + num] * 4096;
            }
        }
        num = (int)(param2 * 256) + GameManager.DAT_1f800084.z;
        uint num4 = (uint)(((int)(param1 * 256) + GameManager.DAT_1f800084.x) & 0xFFFF);
        num2 = GameManager.DAT_1f800084.y * 65536;
        Coprocessor3.vector0.vx0 = (short)num4;
        Coprocessor3.vector0.vy0 = (short)((_vertices[puVar14] & 0x7FF) * 524288 + num2 >> 16);
        Coprocessor3.vector0.vz0 = (short)num;
        terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
        Coprocessor3.ExecuteRTPS(12, lm: false);
        num3 = (uint)GameManager.DAT_1f800098;
        uint num5 = (num4 + 1024) & 0xFFFF;
        short sz = Coprocessor3.screenZFIFO.sz3;
        GameManager.terrainScreen[0].ir0 = Coprocessor3.accumulator.ir0;
        Coprocessor3.vector0.vx0 = (short)num5;
        Coprocessor3.vector0.vy0 = (short)((_vertices[puVar15] & 0x7FF) * 524288 + num2 >> 16);
        Coprocessor3.vector0.vz0 = (short)num;
        terrainVertices[1] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
        Coprocessor3.ExecuteRTPS(12, lm: false);
        uint num6 = ((int)sz < (int)num3) ? 1u : 0u;
        short sz2 = Coprocessor3.screenZFIFO.sz3;
        GameManager.terrainScreen[4].ir0 = Coprocessor3.accumulator.ir0;
        Coprocessor3.vector0.vx0 = (short)num4;
        Coprocessor3.vector0.vy0 = (short)((_vertices[puVar16] & 0x7FF) * 524288 + num2 >> 16);
        Coprocessor3.vector0.vz0 = (short)(num + 1024);
        Vector2Int vector2Int = new Vector2Int(Coprocessor3.screenXYFIFO.sx1, Coprocessor3.screenXYFIFO.sy1);
        terrainVertices[2] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
        Coprocessor3.ExecuteRTPS(12, lm: false);
        uint num7 = (uint)((((int)sz2 < (int)num3) ? 1 : 0) << 1);
        uint num8 = num6 | num7;
        short sz3 = Coprocessor3.screenZFIFO.sz3;
        GameManager.terrainScreen[20].ir0 = Coprocessor3.accumulator.ir0;
        Coprocessor3.ExecuteNCLIP();
        Coprocessor3.vector0.vx0 = (short)num5;
        Coprocessor3.vector0.vy0 = (short)((_vertices[puVar17] & 0x7FF) * 524288 + num2 >> 16);
        Coprocessor3.vector0.vz0 = (short)(num + 1024);
        terrainVertices[3] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
        num2 = Coprocessor3.mathsAccumulator.mac0;
        Coprocessor3.ExecuteRTPS(12, lm: false);
        num5 = (uint)((((int)sz3 < (int)num3) ? 1 : 0) << 2);
        short sz4 = Coprocessor3.screenZFIFO.sz3;
        GameManager.terrainScreen[24].ir0 = Coprocessor3.accumulator.ir0;
        Coprocessor3.ExecuteAVSZ4();
        num3 = (uint)((((int)sz4 < (int)num3) ? 1 : 0) << 3);
        uint num9 = num8 | num5 | num3;
        Coprocessor3.colorCode.r = LevelManager.instance.DAT_DDC.r;
        Coprocessor3.colorCode.g = LevelManager.instance.DAT_DDC.g;
        Coprocessor3.colorCode.b = LevelManager.instance.DAT_DDC.b;
        Coprocessor3.colorCode.code = LevelManager.instance.DAT_DDC.a;
        if (num9 == 15)
        {
            GameManager.terrainScreen[0].vert.z = Coprocessor3.screenZFIFO.sz0;
            GameManager.terrainScreen[4].vert.z = Coprocessor3.screenZFIFO.sz1;
            GameManager.terrainScreen[20].vert.z = Coprocessor3.screenZFIFO.sz2;
            GameManager.terrainScreen[24].vert.z = Coprocessor3.screenZFIFO.sz3;
            terrainWorld[0].z = terrainVertices[0].z;
            terrainWorld[0].x = terrainVertices[0].x;
            terrainWorld[0].y = terrainVertices[0].y;
            terrainWorld[4].z = terrainVertices[1].z;
            terrainWorld[20].z = terrainVertices[2].z;
            terrainWorld[24].z = terrainVertices[3].z;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar14] >> 11 << 7);
            Coprocessor3.ExecuteCC(12, lm: true);
            GameManager.terrainScreen[4].vert.x = Coprocessor3.screenXYFIFO.sx0;
            GameManager.terrainScreen[4].vert.y = Coprocessor3.screenXYFIFO.sy0;
            terrainWorld[4].x = terrainVertices[1].x;
            terrainWorld[4].y = terrainVertices[1].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar15] >> 11 << 7);
            GameManager.terrainScreen[0].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteCC(12, lm: true);
            GameManager.terrainScreen[20].vert.x = Coprocessor3.screenXYFIFO.sx1;
            GameManager.terrainScreen[20].vert.y = Coprocessor3.screenXYFIFO.sy1;
            terrainWorld[20].x = terrainVertices[2].x;
            terrainWorld[20].y = terrainVertices[2].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar16] >> 11 << 7);
            GameManager.terrainScreen[4].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteCC(12, lm: true);
            GameManager.terrainScreen[24].vert.x = Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[24].vert.y = Coprocessor3.screenXYFIFO.sy2;
            terrainWorld[24].x = terrainVertices[3].x;
            terrainWorld[24].y = terrainVertices[3].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar17] >> 11 << 7);
            GameManager.terrainScreen[20].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteCC(12, lm: true);
            num3 = (uint)(GameManager.DAT_1f800084.y * 65536);
            Coprocessor3.vector0.vz0 = (short)num;
            Coprocessor3.vector1.vz1 = (short)(num + 512);
            Coprocessor3.vector2.vz2 = (short)(num + 1024);
            num5 = (((num4 + 512) & 0xFFFF) | num3);
            uint num10 = (uint)((_vertices[puVar14 + 128] & 0x7FF) * 524288 + (int)num5);
            uint num11 = (uint)((_vertices[puVar14 + 130] & 0x7FF) * 524288 + (int)num5);
            uint num12 = (uint)((_vertices[puVar16 + 128] & 0x7FF) * 524288 + (int)num5);
            Coprocessor3.vector0.vx0 = (short)num10;
            Coprocessor3.vector0.vy0 = (short)(num10 >> 16);
            Coprocessor3.vector1.vx1 = (short)num11;
            Coprocessor3.vector1.vy1 = (short)(num11 >> 16);
            Coprocessor3.vector2.vx2 = (short)num12;
            Coprocessor3.vector2.vy2 = (short)(num12 >> 16);
            terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
            terrainVertices[1] = new Vector3Int(Coprocessor3.vector1.vx1, Coprocessor3.vector1.vy1, Coprocessor3.vector1.vz1);
            terrainVertices[2] = new Vector3Int(Coprocessor3.vector2.vx2, Coprocessor3.vector2.vy2, Coprocessor3.vector2.vz2);
            GameManager.terrainScreen[24].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteRTPT(12, lm: false);
            GameManager.terrainScreen[2].vert.x = Coprocessor3.screenXYFIFO.sx0;
            GameManager.terrainScreen[2].vert.y = Coprocessor3.screenXYFIFO.sy0;
            GameManager.terrainScreen[22].vert.x = Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[22].vert.y = Coprocessor3.screenXYFIFO.sy2;
            terrainWorld[2].x = terrainVertices[0].x;
            terrainWorld[2].y = terrainVertices[0].y;
            terrainWorld[22].x = terrainVertices[2].x;
            terrainWorld[22].y = terrainVertices[2].y;
            Coprocessor3.vector0.vx0 = (short)num4;
            Coprocessor3.vector0.vy0 = (short)((_vertices[puVar14 + 2] & 0x7FF) * 524288 + num3 >> 16);
            num12 = (uint)((_vertices[puVar15 + 2] & 0x7FF) * 524288 + (int)(((num4 + 1024) & 0xFFFF) | num3));
            Coprocessor3.vector2.vx2 = (short)num12;
            Coprocessor3.vector2.vy2 = (short)(num12 >> 16);
            Coprocessor3.vector0.vz0 = (short)(num + 512);
            Coprocessor3.vector2.vz2 = (short)(num + 512);
            GameManager.terrainScreen[2].vert.z = Coprocessor3.screenZFIFO.sz1;
            GameManager.terrainScreen[22].vert.z = Coprocessor3.screenZFIFO.sz3;
            terrainWorld[2].z = terrainVertices[0].z;
            terrainWorld[22].z = terrainVertices[2].z;
            terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
            terrainVertices[2] = new Vector3Int(Coprocessor3.vector2.vx2, Coprocessor3.vector2.vy2, Coprocessor3.vector2.vz2);
            Coprocessor3.ExecuteRTPT(12, lm: false);
            GameManager.terrainScreen[10].vert.x = Coprocessor3.screenXYFIFO.sx0;
            GameManager.terrainScreen[10].vert.y = Coprocessor3.screenXYFIFO.sy0;
            GameManager.terrainScreen[12].vert.x = Coprocessor3.screenXYFIFO.sx1;
            GameManager.terrainScreen[12].vert.y = Coprocessor3.screenXYFIFO.sy1;
            terrainWorld[10].x = terrainVertices[0].x;
            terrainWorld[10].y = terrainVertices[0].y;
            terrainWorld[12].x = terrainVertices[1].x;
            terrainWorld[12].y = terrainVertices[1].y;
            num10 = (uint)_vertices[puVar14 + 128] >> 11 << 7;
            num11 = (uint)_vertices[puVar14 + 130] >> 11 << 7;
            num12 = (uint)_vertices[puVar16 + 128] >> 11 << 7;
            Coprocessor3.vector0.vx0 = (short)num10;
            Coprocessor3.vector0.vy0 = (short)(num10 >> 16);
            Coprocessor3.vector1.vx1 = (short)num11;
            Coprocessor3.vector1.vy1 = (short)(num11 >> 16);
            Coprocessor3.vector2.vx2 = (short)num12;
            Coprocessor3.vector2.vy2 = (short)(num12 >> 16);
            GameManager.terrainScreen[10].vert.z = Coprocessor3.screenZFIFO.sz1;
            GameManager.terrainScreen[12].vert.z = Coprocessor3.screenZFIFO.sz2;
            terrainWorld[10].z = terrainVertices[0].z;
            terrainWorld[12].z = terrainVertices[1].z;
            Coprocessor3.ExecuteNCCT(12, lm: true);
            GameManager.terrainScreen[2].color = new Color32(Coprocessor3.colorFIFO.r0, Coprocessor3.colorFIFO.g0, Coprocessor3.colorFIFO.b0, Coprocessor3.colorFIFO.cd0);
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar14 + 2] >> 11 << 7);
            GameManager.terrainScreen[12].color = new Color32(Coprocessor3.colorFIFO.r1, Coprocessor3.colorFIFO.g1, Coprocessor3.colorFIFO.b1, Coprocessor3.colorFIFO.cd1);
            GameManager.terrainScreen[22].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteCC(12, lm: true);
            GameManager.terrainScreen[10].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar15 + 2] >> 11 << 7);
            GameManager.terrainScreen[14].vert.x = Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[14].vert.y = Coprocessor3.screenXYFIFO.sy2;
            GameManager.terrainScreen[14].vert.z = Coprocessor3.screenZFIFO.sz3;
            terrainWorld[14].x = terrainVertices[2].x;
            terrainWorld[14].y = terrainVertices[2].y;
            terrainWorld[14].z = terrainVertices[2].z;
            Coprocessor3.ExecuteCC(12, lm: true);
            num3 = ((num4 + 512) & 0xFFFF);
            num += 512;
            GameManager.terrainScreen[14].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            GameManager.terrainScreen[0].vert.x = vector2Int.x;
            GameManager.terrainScreen[0].vert.y = vector2Int.y;
            int num13 = puVar15;
            puVar14 += 130;
            puVar15 += 2;
            puVar16 += 128;
            FUN_290A8(num3, num, param3, 12);
            puVar14 -= 128;
            puVar16 -= 128;
            puVar15 = puVar14 + 128;
            puVar17 = puVar16 + 128;
            num3 = ((num3 - 512) & 0xFFFF);
            FUN_290A8(num3, num, param3, 10);
            puVar14 += 126;
            puVar15 = num13;
            puVar16 = puVar14 + 2;
            puVar17 = puVar15 + 2;
            num3 = ((num3 + 512) & 0xFFFF);
            num -= 512;
            FUN_290A8(num3, num, param3, 2);
            puVar14 -= 128;
            puVar15 = puVar14 + 128;
            puVar16 = puVar14 + 2;
            puVar17 = puVar15 + 2;
            num3 = ((num3 - 512) & 0xFFFF);
            FUN_290A8(num3, num, param3, 0);
            return;
        }
        uint averageZ = Coprocessor3.averageZ;
        Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[0].ir0;
        Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar14] >> 11 << 7);
        Coprocessor3.ExecuteCDP(12, lm: true);
        Vector2Int vector2Int2 = new Vector2Int(Coprocessor3.screenXYFIFO.sx0, Coprocessor3.screenXYFIFO.sy0);
        Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[4].ir0;
        Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar15] >> 11 << 7);
        puVar18 = GameManager.DAT_1f800080 + (int)(averageZ >> 1);
        Coprocessor3.ExecuteCDP(12, lm: true);
        Vector2Int vector2Int3 = new Vector2Int(Coprocessor3.screenXYFIFO.sx1, Coprocessor3.screenXYFIFO.sy1);
        Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[20].ir0;
        Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar16] >> 11 << 7);
        Coprocessor3.ExecuteCDP(12, lm: true);
        int translateFactor = GameManager.instance.translateFactor2;
        if (num9 == 0)
        {
            newVertices[index] = (Vector3)terrainVertices[0] / (float)translateFactor;
            newVertices[index + 1] = (Vector3)terrainVertices[1] / (float)translateFactor;
            newVertices[index + 2] = (Vector3)terrainVertices[2] / (float)translateFactor;
            newColors[index] = new Color32(Coprocessor3.colorFIFO.r0, Coprocessor3.colorFIFO.g0, Coprocessor3.colorFIFO.b0, Coprocessor3.colorFIFO.cd0);
            newColors[index + 1] = new Color32(Coprocessor3.colorFIFO.r1, Coprocessor3.colorFIFO.g1, Coprocessor3.colorFIFO.b1, Coprocessor3.colorFIFO.cd1);
            newColors[index + 2] = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            newUVs[index] = new Vector2(0f, 0f);
            newUVs[index + 1] = new Vector2(0f, 0f);
            newUVs[index + 2] = new Vector2(0f, 0f);
            newTriangles[0][index3] = index + 2;
            newTriangles[0][index3 + 1] = index + 1;
            newTriangles[0][index3 + 2] = index;
            index += 3;
            index3 += 3;
            Coprocessor3.ExecuteNCLIP();
            num = Coprocessor3.mathsAccumulator.mac0;
            Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[24].ir0;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar17] >> 11 << 7);
            Coprocessor3.ExecuteCDP(12, lm: true);
            newVertices[index] = (Vector3)terrainVertices[1] / (float)translateFactor;
            newVertices[index + 1] = (Vector3)terrainVertices[2] / (float)translateFactor;
            newVertices[index + 2] = (Vector3)terrainVertices[3] / (float)translateFactor;
            newColors[index] = new Color32(Coprocessor3.colorFIFO.r0, Coprocessor3.colorFIFO.g0, Coprocessor3.colorFIFO.b0, Coprocessor3.colorFIFO.cd0);
            newColors[index + 1] = new Color32(Coprocessor3.colorFIFO.r1, Coprocessor3.colorFIFO.g1, Coprocessor3.colorFIFO.b1, Coprocessor3.colorFIFO.cd1);
            newColors[index + 2] = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            newUVs[index] = new Vector2(0f, 0f);
            newUVs[index + 1] = new Vector2(0f, 0f);
            newUVs[index + 2] = new Vector2(0f, 0f);
            newTriangles[0][index3] = index;
            newTriangles[0][index3 + 1] = index + 1;
            newTriangles[0][index3 + 2] = index + 2;
            index += 3;
            index3 += 3;
            return;
        }
        GameManager.terrainScreen[24].vert.x = Coprocessor3.screenXYFIFO.sx2;
        GameManager.terrainScreen[24].vert.y = Coprocessor3.screenXYFIFO.sy2;
        terrainWorld[24].x = terrainVertices[3].x;
        terrainWorld[24].y = terrainVertices[3].y;
        Coprocessor3.accumulator.ir0 = (short)GameManager.terrainScreen[24].ir0;
        Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar17] >> 11 << 7);
        GameManager.terrainScreen[0].vert.z = Coprocessor3.screenZFIFO.sz0;
        GameManager.terrainScreen[4].vert.z = Coprocessor3.screenZFIFO.sz1;
        GameManager.terrainScreen[20].vert.z = Coprocessor3.screenZFIFO.sz2;
        GameManager.terrainScreen[24].vert.z = Coprocessor3.screenZFIFO.sz3;
        terrainWorld[0].z = terrainVertices[0].z;
        terrainWorld[0].x = terrainVertices[0].x;
        terrainWorld[0].y = terrainVertices[0].y;
        terrainWorld[4].z = terrainVertices[1].z;
        terrainWorld[4].x = terrainVertices[1].x;
        terrainWorld[4].y = terrainVertices[1].y;
        terrainWorld[20].z = terrainVertices[2].z;
        terrainWorld[20].x = terrainVertices[2].x;
        terrainWorld[20].y = terrainVertices[2].y;
        terrainWorld[24].z = terrainVertices[3].z;
        GameManager.terrainScreen[0].color = new Color32(Coprocessor3.colorFIFO.r0, Coprocessor3.colorFIFO.g0, Coprocessor3.colorFIFO.b0, Coprocessor3.colorFIFO.cd0);
        GameManager.terrainScreen[4].color = new Color32(Coprocessor3.colorFIFO.r1, Coprocessor3.colorFIFO.g1, Coprocessor3.colorFIFO.b1, Coprocessor3.colorFIFO.cd1);
        GameManager.terrainScreen[20].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
        Coprocessor3.ExecuteCDP(12, lm: true);
        GameManager.terrainScreen[24].color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
        num2 = GameManager.DAT_1f800084.y * 65536;
        if ((num9 & 3) != 0)
        {
            Coprocessor3.vector0.vx0 = (short)((num4 + 512) & 0xFFFF);
            Coprocessor3.vector0.vy0 = (short)((_vertices[puVar14 + 128] & 0x7FF) * 524288 + num2 >> 16);
            Coprocessor3.vector0.vz0 = (short)num;
            terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
            Coprocessor3.ExecuteRTPS(12, lm: false);
            GameManager.terrainScreen[2].vert.x = Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[2].vert.y = Coprocessor3.screenXYFIFO.sy2;
            terrainWorld[2].x = terrainVertices[0].x;
            terrainWorld[2].y = terrainVertices[0].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar14 + 128] >> 11 << 7);
            GameManager.terrainScreen[2].vert.z = Coprocessor3.screenZFIFO.sz3;
            terrainWorld[2].z = terrainVertices[0].z;
            Coprocessor3.ExecuteCDP(12, lm: true);
        }
        if ((num9 & 5) != 0)
        {
            Coprocessor3.vector0.vx0 = (short)num4;
            Coprocessor3.vector0.vy0 = (short)((_vertices[puVar14 + 2] & 0x7FF) * 524288 + num2 >> 16);
            Coprocessor3.vector0.vz0 = (short)(num + 512);
            terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
            Color32 color = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteRTPS(12, lm: false);
            if (num8 != 0)
            {
                GameManager.terrainScreen[2].color = color;
            }
            GameManager.terrainScreen[10].vert.x = Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[10].vert.y = Coprocessor3.screenXYFIFO.sy2;
            terrainWorld[10].x = terrainVertices[0].x;
            terrainWorld[10].y = terrainVertices[0].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar14 + 2] >> 11 << 7);
            GameManager.terrainScreen[10].vert.z = Coprocessor3.screenZFIFO.sz3;
            terrainWorld[10].z = terrainVertices[0].z;
            Coprocessor3.ExecuteCDP(12, lm: true);
        }
        if ((num9 & 0xA) != 0)
        {
            Coprocessor3.vector0.vx0 = (short)((num4 + 1024) & 0xFFFF);
            Coprocessor3.vector0.vy0 = (short)((_vertices[puVar15 + 2] & 0x7FF) * 524288 + num2 >> 16);
            Coprocessor3.vector0.vz0 = (short)(num + 512);
            terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
            Color32 color2 = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteRTPS(12, lm: false);
            Color32 color = color2;
            if ((num6 | num5) == 0)
            {
                color = GameManager.terrainScreen[10].color;
                if (num8 != 0)
                {
                    GameManager.terrainScreen[2].color = color2;
                }
            }
            GameManager.terrainScreen[10].color = color;
            GameManager.terrainScreen[14].vert.x = Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[14].vert.y = Coprocessor3.screenXYFIFO.sy2;
            terrainWorld[14].x = terrainVertices[0].x;
            terrainWorld[14].y = terrainVertices[0].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar15 + 2] >> 11 << 7);
            GameManager.terrainScreen[14].vert.z = Coprocessor3.screenZFIFO.sz3;
            terrainWorld[14].z = terrainVertices[0].z;
            Coprocessor3.ExecuteCDP(12, lm: true);
        }
        if ((num9 & 0xC) == 0)
        {
            if ((num7 | num3) == 0)
            {
                if ((num6 | num5) == 0)
                {
                    if (num8 != 0)
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
            Coprocessor3.vector0.vx0 = (short)((num4 + 512) & 0xFFFF);
            Coprocessor3.vector0.vy0 = (short)((_vertices[puVar16 + 128] & 0x7FF) * 524288 + num2 >> 16);
            Coprocessor3.vector0.vz0 = (short)(num + 1024);
            terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
            Color32 color3 = new Color32(Coprocessor3.colorFIFO.r2, Coprocessor3.colorFIFO.g2, Coprocessor3.colorFIFO.b2, Coprocessor3.colorFIFO.cd2);
            Coprocessor3.ExecuteRTPS(12, lm: false);
            GameManager.terrainScreen[22].vert.x = Coprocessor3.screenXYFIFO.sx2;
            GameManager.terrainScreen[22].vert.y = Coprocessor3.screenXYFIFO.sy2;
            terrainWorld[22].x = terrainVertices[0].x;
            terrainWorld[22].y = terrainVertices[0].y;
            Coprocessor3.accumulator.ir1 = (short)((uint)_vertices[puVar16 + 128] >> 11 << 7);
            GameManager.terrainScreen[22].vert.z = Coprocessor3.screenZFIFO.sz3;
            terrainWorld[22].z = terrainVertices[0].z;
            Coprocessor3.ExecuteCDP(12, lm: true);
            Color32 color = GameManager.terrainScreen[10].color;
            Color32 color2 = color3;
            if ((num7 | num3) == 0)
            {
                color = color3;
                color2 = GameManager.terrainScreen[14].color;
                if ((num6 | num5) == 0)
                {
                    color = GameManager.terrainScreen[10].color;
                    if (num8 != 0)
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
        in_t1 = GameManager.DAT_639EC[(num9 - 1) * 2];
        in_t0 = GameManager.DAT_639EC[(num9 - 1) * 2 + 1];
        FUN_297E8(num4, num, 0);
    }

    private static void FUN_290A8(uint param1, int param2, int param3, int param4)
    {
        int translateFactor = GameManager.instance.translateFactor2;
        uint num = (ushort)GameManager.DAT_1f80009a;
        int z = GameManager.terrainScreen[param4].vert.z;
        int z2 = GameManager.terrainScreen[param4 + 2].vert.z;
        int z3 = GameManager.terrainScreen[param4 + 10].vert.z;
        uint num2 = (uint)(((z3 < (int)num) ? 1 : 0) << 2);
        int z4 = GameManager.terrainScreen[param4 + 12].vert.z;
        num = (uint)(((z < (int)num) ? 1 : 0) | (((z2 < (int)num) ? 1 : 0) << 1) | (int)num2 | (((z4 < (int)num) ? 1 : 0) << 3));
        switch (num)
        {
            case 0u:
                {
                    Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[param4].vert.x;
                    Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[param4].vert.y;
                    Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[param4 + 2].vert.x;
                    Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[param4 + 2].vert.y;
                    Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[param4 + 10].vert.x;
                    Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[param4 + 10].vert.y;
                    Coprocessor3.ExecuteNCLIP();
                    int dAT_1f = GameManager.DAT_1f800080;
                    Color32 color = GameManager.terrainScreen[param4 + 2].color;
                    Color32 color2 = GameManager.terrainScreen[param4 + 10].color;
                    z2 = Coprocessor3.mathsAccumulator.mac0;
                    Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[param4 + 12].vert.x;
                    Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[param4 + 12].vert.y;
                    newVertices[index] = terrainWorld[param4] / translateFactor;
                    newVertices[index + 1] = terrainWorld[param4 + 2] / translateFactor;
                    newVertices[index + 2] = terrainWorld[param4 + 10] / translateFactor;
                    Color32 color3 = GameManager.terrainScreen[param4].color;
                    newColors[index] = color3;
                    newColors[index + 1] = color;
                    newColors[index + 2] = color2;
                    newUVs[index] = new Vector2(0f, 0f);
                    newUVs[index + 1] = new Vector2(0f, 0f);
                    newUVs[index + 2] = new Vector2(0f, 0f);
                    newTriangles[0][index3] = index + 2;
                    newTriangles[0][index3 + 1] = index + 1;
                    newTriangles[0][index3 + 2] = index;
                    index += 3;
                    index3 += 3;
                    Coprocessor3.ExecuteNCLIP();
                    z2 = Coprocessor3.mathsAccumulator.mac0;
                    newColors[index] = GameManager.terrainScreen[param4 + 12].color;
                    newColors[index + 1] = color;
                    newColors[index + 2] = color2;
                    newUVs[index] = new Vector2(0f, 0f);
                    newUVs[index + 1] = new Vector2(0f, 0f);
                    newUVs[index + 2] = new Vector2(0f, 0f);
                    newVertices[index] = terrainWorld[param4 + 12] / translateFactor;
                    newVertices[index + 1] = terrainWorld[param4 + 2] / translateFactor;
                    newVertices[index + 2] = terrainWorld[param4 + 10] / translateFactor;
                    newTriangles[0][index3] = index;
                    newTriangles[0][index3 + 1] = index + 1;
                    newTriangles[0][index3 + 2] = index + 2;
                    index += 3;
                    index3 += 3;
                    break;
                }
            case 15u:
                {
                    short num8 = (GameManager.terrainScreen[param4].vert.x >= 1 || GameManager.terrainScreen[param4 + 2].vert.x >= 1 || GameManager.terrainScreen[param4 + 10].vert.x >= 1) ? GameManager.DAT_1f800094 : GameManager.DAT_1f800094;
                    short num9 = (GameManager.terrainScreen[param4].vert.x >= num8 && GameManager.terrainScreen[param4 + 2].vert.x >= num8 && GameManager.terrainScreen[param4 + 10].vert.x >= num8) ? ((short)GameManager.terrainScreen[param4].vert.y) : ((short)GameManager.terrainScreen[param4].vert.y);
                    num8 = (short)GameManager.terrainScreen[param4 + 2].vert.y;
                    num9 = ((num9 >= 1 || num8 >= 1 || GameManager.terrainScreen[param4 + 10].vert.y >= 1) ? GameManager.DAT_1f800096 : GameManager.DAT_1f800096);
                    z = ((num8 != 0 || num9 > num8 || num9 > GameManager.terrainScreen[param4 + 10].vert.y) ? GameManager.DAT_1f800084.y : GameManager.DAT_1f800084.y);
                    Coprocessor3.vector0.vz0 = (short)param2;
                    num = (uint)(z * 65536);
                    Coprocessor3.vector1.vz1 = (short)(param2 + 256);
                    Coprocessor3.vector2.vz2 = (short)(param2 + 512);
                    num2 = (((param1 + 256) & 0xFFFF) | num);
                    int num3 = (_vertices[puVar14 + 64] & 0x7FF) * 524288 + (int)num2;
                    int num6 = (_vertices[puVar14 + 65] & 0x7FF) * 524288 + (int)num2;
                    int num7 = (_vertices[puVar16 + 64] & 0x7FF) * 524288 + (int)num2;
                    Coprocessor3.vector0.vx0 = (short)num3;
                    Coprocessor3.vector0.vy0 = (short)(num3 >> 16);
                    Coprocessor3.vector1.vx1 = (short)num6;
                    Coprocessor3.vector1.vy1 = (short)(num6 >> 16);
                    Coprocessor3.vector2.vx2 = (short)num7;
                    Coprocessor3.vector2.vy2 = (short)(num7 >> 16);
                    terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
                    terrainVertices[1] = new Vector3Int(Coprocessor3.vector1.vx1, Coprocessor3.vector1.vy1, Coprocessor3.vector1.vz1);
                    terrainVertices[2] = new Vector3Int(Coprocessor3.vector2.vx2, Coprocessor3.vector2.vy2, Coprocessor3.vector2.vz2);
                    Coprocessor3.ExecuteRTPT(12, lm: false);
                    num8 = (short)_vertices[puVar14 + 1];
                    num9 = (short)_vertices[puVar15 + 1];
                    GameManager.terrainScreen[param4 + 1].vert.x = Coprocessor3.screenXYFIFO.sx0;
                    GameManager.terrainScreen[param4 + 1].vert.y = Coprocessor3.screenXYFIFO.sy0;
                    GameManager.terrainScreen[param4 + 11].vert.x = Coprocessor3.screenXYFIFO.sx2;
                    GameManager.terrainScreen[param4 + 11].vert.y = Coprocessor3.screenXYFIFO.sy2;
                    terrainWorld[param4 + 1] = terrainVertices[0];
                    terrainWorld[param4 + 11] = terrainVertices[2];
                    Coprocessor3.vector0.vx0 = (short)param1;
                    Coprocessor3.vector0.vy0 = (short)((int)((long)num8 & 2047L) * 524288 + num >> 16);
                    num7 = (int)((long)num9 & 2047L) * 524288 + (int)(((param1 + 512) & 0xFFFF) | num);
                    Coprocessor3.vector2.vx2 = (short)num7;
                    Coprocessor3.vector2.vy2 = (short)(num7 >> 16);
                    Coprocessor3.vector0.vz0 = (short)(param2 + 256);
                    Coprocessor3.vector2.vz2 = (short)(param2 + 256);
                    terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
                    terrainVertices[2] = new Vector3Int(Coprocessor3.vector2.vx2, Coprocessor3.vector2.vy2, Coprocessor3.vector2.vz2);
                    GameManager.terrainScreen[param4 + 1].vert.z = Coprocessor3.screenZFIFO.sz1;
                    GameManager.terrainScreen[param4 + 11].vert.z = Coprocessor3.screenZFIFO.sz3;
                    Coprocessor3.ExecuteRTPT(12, lm: false);
                    GameManager.terrainScreen[param4 + 5].vert = new Vector3Int(Coprocessor3.screenXYFIFO.sx0, Coprocessor3.screenXYFIFO.sy0, Coprocessor3.screenZFIFO.sz1);
                    GameManager.terrainScreen[param4 + 6].vert = new Vector3Int(Coprocessor3.screenXYFIFO.sx1, Coprocessor3.screenXYFIFO.sy1, Coprocessor3.screenZFIFO.sz2);
                    GameManager.terrainScreen[param4 + 7].vert = new Vector3Int(Coprocessor3.screenXYFIFO.sx2, Coprocessor3.screenXYFIFO.sy2, Coprocessor3.screenZFIFO.sz3);
                    terrainWorld[param4 + 5] = terrainVertices[0];
                    terrainWorld[param4 + 6] = terrainVertices[1];
                    terrainWorld[param4 + 7] = terrainVertices[2];
                    in_t0 = _vertices[puVar14];
                    in_t1 = _vertices[puVar14 + 64];
                    in_t2 = _vertices[puVar14 + 1];
                    in_t3 = _vertices[puVar14 + 65];
                    in_t4 = _tiles[puVar14];
                    FUN_29520((int)param1, param2, param3, param4);
                    in_t0 = _vertices[puVar14 + 64];
                    in_t1 = _vertices[puVar15];
                    in_t2 = _vertices[puVar14 + 65];
                    in_t3 = _vertices[puVar15 + 1];
                    in_t4 = _tiles[puVar14 + 64];
                    param4++;
                    FUN_29520((int)param1, param2, param3, param4);
                    in_t0 = _vertices[puVar14 + 1];
                    in_t1 = _vertices[puVar14 + 65];
                    in_t2 = _vertices[puVar16];
                    in_t3 = _vertices[puVar16 + 64];
                    in_t4 = _tiles[puVar14 + 1];
                    param4 += 4;
                    FUN_29520((int)param1, param2, param3, param4);
                    in_t0 = _vertices[puVar14 + 65];
                    in_t1 = _vertices[puVar15 + 1];
                    in_t2 = _vertices[puVar16 + 64];
                    in_t3 = _vertices[puVar17];
                    in_t4 = _tiles[puVar14 + 65];
                    param4++;
                    FUN_29520((int)param1, param2, param3, param4);
                    break;
                }
            default:
                {
                    num2 = (uint)(GameManager.DAT_1f800084.y << 16);
                    int num3 = (_vertices[puVar14 + 1] & 0x7FF) * 524288 + (int)(num2 | param1);
                    Coprocessor3.vector0.vx0 = (short)num3;
                    Coprocessor3.vector0.vy0 = (short)(num3 >> 16);
                    Coprocessor3.vector0.vz0 = (short)(param2 + 256);
                    terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
                    Coprocessor3.ExecuteRTPS(12, lm: false);
                    Coprocessor3.vector1.vz1 = (short)(param2 + 512);
                    Coprocessor3.vector2.vz2 = (short)(param2 + 256);
                    uint num4 = ((param1 + 256) & 0xFFFF) | num2;
                    uint num5 = ((param1 + 512) & 0xFFFF) | num2;
                    Coprocessor3.vector0.vz0 = (short)param2;
                    num3 = (_vertices[puVar14 + 64] & 0x7FF) * 524288 + (int)num4;
                    Coprocessor3.vector0.vx0 = (short)num3;
                    Coprocessor3.vector0.vy0 = (short)(num3 >> 16);
                    int num6 = (_vertices[puVar16 + 64] & 0x7FF) * 524288 + (int)num4;
                    Coprocessor3.vector1.vx1 = (short)num6;
                    Coprocessor3.vector1.vy1 = (short)(num6 >> 16);
                    int num7 = (_vertices[puVar15 + 1] & 0x7FF) * 524288 + (int)num5;
                    Coprocessor3.vector2.vx2 = (short)num7;
                    Coprocessor3.vector2.vy2 = (short)(num7 >> 16);
                    GameManager.terrainScreen[param4 + 5].vert = new Vector3Int(Coprocessor3.screenXYFIFO.sx2, Coprocessor3.screenXYFIFO.sy2, Coprocessor3.screenZFIFO.sz3);
                    terrainWorld[param4 + 5] = terrainVertices[0];
                    terrainVertices[0] = new Vector3Int(Coprocessor3.vector0.vx0, Coprocessor3.vector0.vy0, Coprocessor3.vector0.vz0);
                    terrainVertices[1] = new Vector3Int(Coprocessor3.vector1.vx1, Coprocessor3.vector1.vy1, Coprocessor3.vector1.vz1);
                    terrainVertices[2] = new Vector3Int(Coprocessor3.vector2.vx2, Coprocessor3.vector2.vy2, Coprocessor3.vector2.vz2);
                    Coprocessor3.ExecuteRTPT(12, lm: false);
                    GameManager.terrainScreen[param4 + 5].color = DAT_BA4F0[_vertices[puVar14 + 1] >> 11];
                    GameManager.terrainScreen[param4 + 1].color = DAT_BA4F0[_vertices[puVar14 + 64] >> 11];
                    GameManager.terrainScreen[param4 + 11].color = DAT_BA4F0[_vertices[puVar16 + 64] >> 11];
                    GameManager.terrainScreen[param4 + 7].color = DAT_BA4F0[_vertices[puVar15 + 1] >> 11];
                    in_t1 = GameManager.DAT_639EC[(num - 1) * 2] >> 1;
                    in_t0 = GameManager.DAT_639EC[(num - 1) * 2 + 1] >> 1;
                    GameManager.terrainScreen[param4 + 1].vert.x = Coprocessor3.screenXYFIFO.sx0;
                    GameManager.terrainScreen[param4 + 1].vert.y = Coprocessor3.screenXYFIFO.sy0;
                    GameManager.terrainScreen[param4 + 11].vert.x = Coprocessor3.screenXYFIFO.sx1;
                    GameManager.terrainScreen[param4 + 11].vert.y = Coprocessor3.screenXYFIFO.sy1;
                    GameManager.terrainScreen[param4 + 7].vert.x = Coprocessor3.screenXYFIFO.sx2;
                    GameManager.terrainScreen[param4 + 7].vert.y = Coprocessor3.screenXYFIFO.sy2;
                    terrainWorld[param4 + 1] = terrainVertices[0];
                    terrainWorld[param4 + 11] = terrainVertices[1];
                    terrainWorld[param4 + 7] = terrainVertices[2];
                    FUN_297E8(param1, param2, param4);
                    break;
                }
        }
    }

    private static void FUN_29520(int param1, int param2, int param3, int param4)
    {
        int translateFactor = GameManager.instance.translateFactor2;
        int num = (ushort)GameManager.DAT_1f80009a - 4096;
        int num2 = in_t4;
        param3 = Mathf.Clamp(param3, 1, 16);
        if ((_tileData[num2].flags & 1) != 0)
        {
            return;
        }
        uint num3 = (uint)GameManager.terrainScreen[param4].vert.z;
        if (GameManager.terrainScreen[param4].vert.z < GameManager.terrainScreen[param4 + 1].vert.z)
        {
            num3 = (uint)GameManager.terrainScreen[param4 + 1].vert.z;
        }
        int num4 = (int)(in_t1 >> 11);
        if ((int)num3 < GameManager.terrainScreen[param4 + 5].vert.z)
        {
            num3 = (uint)GameManager.terrainScreen[param4 + 5].vert.z;
        }
        uint z = (uint)GameManager.terrainScreen[param4 + 6].vert.z;
        int num5 = (int)(in_t2 >> 11);
        if ((int)num3 < (int)z)
        {
            num3 = z;
        }
        Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[param4].vert.x;
        Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[param4].vert.y;
        if (0 >= (int)num3)
        {
            return;
        }
        Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[param4 + 1].vert.x;
        Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[param4 + 1].vert.y;
        if ((_tileData[num2].flags & 2) == 0)
        {
            Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[param4 + 5].vert.x;
            Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[param4 + 5].vert.y;
            num = (int)num3 - num;
            Coprocessor3.ExecuteNCLIP();
            ushort dAT_DA = GameManager.instance.DAT_DA8;
            if (0 < num)
            {
                ushort dAT_DA2 = GameManager.instance.DAT_DA8;
            }
            Color32 color = GameManager.DAT_1f800000[num4];
            num = Coprocessor3.mathsAccumulator.mac0;
            Color32 color2 = GameManager.DAT_1f800000[num5];
            Color32 color3 = GameManager.DAT_1f800000[in_t0 >> 11];
            newVertices[index] = terrainWorld[param4] / translateFactor;
            newVertices[index + 1] = terrainWorld[param4 + 1] / translateFactor;
            newVertices[index + 2] = terrainWorld[param4 + 5] / translateFactor;
            param3 = (int)Mathf.Clamp(Vector3.Distance(new Vector3(0f, 0f, 0f), new Vector3(newVertices[index + 2].x, 0f, newVertices[index + 2].z)) / 16f, 1f, 16f);
            param3 = 1;
            newColors[index] = color3;
            newColors[index + 1] = color;
            newColors[index + 2] = color2;
            newUVs[index] = new Vector2((float)_tileData[num2].uv1_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv1_y / (float)(mainHeight - 1));
            newUVs[index + 1] = new Vector2((float)_tileData[num2].uv2_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv2_y / (float)(mainHeight - 1));
            newUVs[index + 2] = new Vector2((float)_tileData[num2].uv3_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv3_y / (float)(mainHeight - 1));
            newTriangles[param3][index2[param3 - 1]] = index + 2;
            newTriangles[param3][index2[param3 - 1] + 1] = index + 1;
            newTriangles[param3][index2[param3 - 1] + 2] = index;
            index += 3;
            index2[param3 - 1] += 3;
            Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[param4 + 6].vert.x;
            Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[param4 + 6].vert.y;
            Coprocessor3.ExecuteNCLIP();
            color3 = GameManager.DAT_1f800000[in_t3 >> 11];
            newVertices[index] = terrainWorld[param4 + 6] / translateFactor;
            newVertices[index + 1] = terrainWorld[param4 + 1] / translateFactor;
            newVertices[index + 2] = terrainWorld[param4 + 5] / translateFactor;
            newColors[index] = color3;
            newColors[index + 1] = color;
            newColors[index + 2] = color2;
            newUVs[index] = new Vector2((float)_tileData[num2].uv4_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv4_y / (float)(mainHeight - 1));
            newUVs[index + 1] = new Vector2((float)_tileData[num2].uv2_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv2_y / (float)(mainHeight - 1));
            newUVs[index + 2] = new Vector2((float)_tileData[num2].uv3_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv3_y / (float)(mainHeight - 1));
            newTriangles[param3][index2[param3 - 1]] = index;
            newTriangles[param3][index2[param3 - 1] + 1] = index + 1;
            newTriangles[param3][index2[param3 - 1] + 2] = index + 2;
            index += 3;
            index2[param3 - 1] += 3;
        }
        else
        {
            Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[param4 + 6].vert.x;
            Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[param4 + 6].vert.y;
            num = (int)num3 - num;
            Coprocessor3.ExecuteNCLIP();
            ushort dAT_DA3 = GameManager.instance.DAT_DA8;
            if (0 < num)
            {
                ushort dAT_DA4 = GameManager.instance.DAT_DA8;
            }
            Color32 color3 = GameManager.DAT_1f800000[in_t0 >> 11];
            Color32 color4 = GameManager.DAT_1f800000[in_t3 >> 11];
            Color32 color = GameManager.DAT_1f800000[num4];
            newVertices[index] = terrainWorld[param4] / translateFactor;
            newVertices[index + 1] = terrainWorld[param4 + 1] / translateFactor;
            newVertices[index + 2] = terrainWorld[param4 + 6] / translateFactor;
            param3 = (int)Mathf.Clamp(Vector3.Distance(new Vector3(0f, 0f, 0f), new Vector3(newVertices[index + 2].x, 0f, newVertices[index + 2].z)) / 16f, 1f, 16f);
            param3 = 1;
            newColors[index] = color3;
            newColors[index + 1] = color;
            newColors[index + 2] = color4;
            newUVs[index] = new Vector2((float)_tileData[num2].uv1_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv1_y / (float)(mainHeight - 1));
            newUVs[index + 1] = new Vector2((float)_tileData[num2].uv2_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv2_y / (float)(mainHeight - 1));
            newUVs[index + 2] = new Vector2((float)_tileData[num2].uv4_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv4_y / (float)(mainHeight - 1));
            newTriangles[param3][index2[param3 - 1]] = index + 2;
            newTriangles[param3][index2[param3 - 1] + 1] = index + 1;
            newTriangles[param3][index2[param3 - 1] + 2] = index;
            index += 3;
            index2[param3 - 1] += 3;
            Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[param4 + 5].vert.x;
            Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[param4 + 5].vert.y;
            Color32 color5 = GameManager.DAT_1f800000[num5];
            Coprocessor3.ExecuteNCLIP();
            newVertices[index] = terrainWorld[param4] / translateFactor;
            newVertices[index + 1] = terrainWorld[param4 + 5] / translateFactor;
            newVertices[index + 2] = terrainWorld[param4 + 6] / translateFactor;
            newColors[index] = color3;
            newColors[index + 1] = color5;
            newColors[index + 2] = color4;
            newUVs[index] = new Vector2((float)_tileData[num2].uv1_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv1_y / (float)(mainHeight - 1));
            newUVs[index + 1] = new Vector2((float)_tileData[num2].uv3_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv3_y / (float)(mainHeight - 1));
            newUVs[index + 2] = new Vector2((float)_tileData[num2].uv4_x / (float)(mainWidth - 1), 1f - (float)_tileData[num2].uv4_y / (float)(mainHeight - 1));
            newTriangles[param3][index2[param3 - 1]] = index;
            newTriangles[param3][index2[param3 - 1] + 1] = index + 1;
            newTriangles[param3][index2[param3 - 1] + 2] = index + 2;
            index += 3;
            index2[param3 - 1] += 3;
        }
    }

    private static void FUN_297E8(uint param1, int param2, int param4)
    {
        int translateFactor = GameManager.instance.translateFactor2;
        int num = (int)(in_t1 & 0x1F) + param4;
        int num2 = (int)((in_t1 >> 1) & 0x1F0) / 16 + param4;
        int num3 = (int)((in_t1 >> 6) & 0x1F0) / 16 + param4;
        Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[num].vert.x;
        Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[num].vert.y;
        Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[num2].vert.x;
        Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[num2].vert.y;
        Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[num3].vert.x;
        Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[num3].vert.y;
        Color32 color = GameManager.terrainScreen[num2].color;
        Coprocessor3.ExecuteNCLIP();
        Color32 color2 = GameManager.terrainScreen[num3].color;
        newVertices[index] = terrainWorld[num] / translateFactor;
        newVertices[index + 1] = terrainWorld[num2] / translateFactor;
        newVertices[index + 2] = terrainWorld[num3] / translateFactor;
        newColors[index] = GameManager.terrainScreen[num].color;
        newColors[index + 1] = color;
        newColors[index + 2] = color2;
        newUVs[index] = new Vector2(0f, 0f);
        newUVs[index + 1] = new Vector2(0f, 0f);
        newUVs[index + 2] = new Vector2(0f, 0f);
        newTriangles[0][index3] = index;
        newTriangles[0][index3 + 1] = index + 1;
        newTriangles[0][index3 + 2] = index + 2;
        index += 3;
        index3 += 3;
        int num4 = num3;
        num3 = (int)((in_t1 >> 11) & 0x1F0) / 16 + param4;
        Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[num3].vert.x;
        Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[num3].vert.y;
        Color32 color3 = GameManager.terrainScreen[num3].color;
        Coprocessor3.ExecuteNCLIP();
        int num5 = (int)((in_t1 >> 16) & 0x1F0) / 16 + param4;
        Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[num5].vert.x;
        Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[num5].vert.y;
        Color32 color4 = GameManager.terrainScreen[num5].color;
        newVertices[index] = terrainWorld[num3] / translateFactor;
        newVertices[index + 1] = terrainWorld[num2] / translateFactor;
        newVertices[index + 2] = terrainWorld[num4] / translateFactor;
        newColors[index] = color3;
        newColors[index + 1] = color;
        newColors[index + 2] = color2;
        newUVs[index] = new Vector2(0f, 0f);
        newUVs[index + 1] = new Vector2(0f, 0f);
        newUVs[index + 2] = new Vector2(0f, 0f);
        newTriangles[0][index3] = index + 2;
        newTriangles[0][index3 + 1] = index + 1;
        newTriangles[0][index3 + 2] = index;
        index += 3;
        index3 += 3;
        Coprocessor3.ExecuteNCLIP();
        newVertices[index] = terrainWorld[num3] / translateFactor;
        newVertices[index + 1] = terrainWorld[num5] / translateFactor;
        newVertices[index + 2] = terrainWorld[num4] / translateFactor;
        newColors[index] = color3;
        newColors[index + 1] = color4;
        newColors[index + 2] = color2;
        newUVs[index] = new Vector2(0f, 0f);
        newUVs[index + 1] = new Vector2(0f, 0f);
        newUVs[index + 2] = new Vector2(0f, 0f);
        newTriangles[0][index3] = index;
        newTriangles[0][index3 + 1] = index + 1;
        newTriangles[0][index3 + 2] = index + 2;
        index += 3;
        index3 += 3;
        num2 = (int)(in_t0 & 0x1F) + param4;
        num3 = (int)((in_t0 >> 1) & 0x1F0) / 16 + param4;
        num5 = (int)((in_t0 >> 6) & 0x1F0) / 16 + param4;
        Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[num2].vert.x;
        Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[num2].vert.y;
        Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[num3].vert.x;
        Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[num3].vert.y;
        Coprocessor3.screenXYFIFO.sx2 = (short)GameManager.terrainScreen[num5].vert.x;
        Coprocessor3.screenXYFIFO.sy2 = (short)GameManager.terrainScreen[num5].vert.y;
        color3 = GameManager.terrainScreen[num3].color;
        Coprocessor3.ExecuteNCLIP();
        color = GameManager.terrainScreen[num5].color;
        uint num6 = (in_t0 >> 11) & 0x1F0;
        num = (int)num6 / 16 + param4;
        if (num6 != 0)
        {
            newVertices[index] = terrainWorld[num2] / translateFactor;
            newVertices[index + 1] = terrainWorld[num3] / translateFactor;
            newVertices[index + 2] = terrainWorld[num5] / translateFactor;
            newColors[index] = GameManager.terrainScreen[num2].color;
            newColors[index + 1] = color3;
            newColors[index + 2] = color;
            newUVs[index] = new Vector2(0f, 0f);
            newUVs[index + 1] = new Vector2(0f, 0f);
            newUVs[index + 2] = new Vector2(0f, 0f);
            newTriangles[0][index3] = index + 2;
            newTriangles[0][index3 + 1] = index + 1;
            newTriangles[0][index3 + 2] = index;
            index += 3;
            index3 += 3;
            Coprocessor3.screenXYFIFO.sx0 = (short)GameManager.terrainScreen[num].vert.x;
            Coprocessor3.screenXYFIFO.sy0 = (short)GameManager.terrainScreen[num].vert.y;
            Color c = GameManager.terrainScreen[num].color;
            Coprocessor3.ExecuteNCLIP();
            uint num7 = (in_t0 >> 16) & 0x1F0;
            param4 = (int)num7 / 16 + param4;
            if (num7 == 0)
            {
                newVertices[index] = terrainWorld[num] / translateFactor;
                newVertices[index + 1] = terrainWorld[num3] / translateFactor;
                newVertices[index + 2] = terrainWorld[num5] / translateFactor;
                newColors[index] = c;
                newColors[index + 1] = color3;
                newColors[index + 2] = color;
                newUVs[index] = new Vector2(0f, 0f);
                newUVs[index + 1] = new Vector2(0f, 0f);
                newUVs[index + 2] = new Vector2(0f, 0f);
                newTriangles[0][index3] = index;
                newTriangles[0][index3 + 1] = index + 1;
                newTriangles[0][index3 + 2] = index + 2;
                index += 3;
                index3 += 3;
                return;
            }
            Coprocessor3.screenXYFIFO.sx1 = (short)GameManager.terrainScreen[param4].vert.x;
            Coprocessor3.screenXYFIFO.sy1 = (short)GameManager.terrainScreen[param4].vert.y;
            color4 = GameManager.terrainScreen[param4].color;
            newVertices[index] = terrainWorld[num] / translateFactor;
            newVertices[index + 1] = terrainWorld[num3] / translateFactor;
            newVertices[index + 2] = terrainWorld[num5] / translateFactor;
            newColors[index] = c;
            newColors[index + 1] = color3;
            newColors[index + 2] = color;
            newUVs[index] = new Vector2(0f, 0f);
            newUVs[index + 1] = new Vector2(0f, 0f);
            newUVs[index + 2] = new Vector2(0f, 0f);
            newTriangles[0][index3] = index;
            newTriangles[0][index3 + 1] = index + 1;
            newTriangles[0][index3 + 2] = index + 2;
            index += 3;
            index3 += 3;
            Coprocessor3.ExecuteNCLIP();
            newVertices[index] = terrainWorld[num] / translateFactor;
            newVertices[index + 1] = terrainWorld[param4] / translateFactor;
            newVertices[index + 2] = terrainWorld[num5] / translateFactor;
            newColors[index] = c;
            newColors[index + 1] = color4;
            newColors[index + 2] = color;
            newUVs[index] = new Vector2(0f, 0f);
            newUVs[index + 1] = new Vector2(0f, 0f);
            newUVs[index + 2] = new Vector2(0f, 0f);
            newTriangles[0][index3] = index + 2;
            newTriangles[0][index3 + 1] = index + 1;
            newTriangles[0][index3 + 2] = index;
            index += 3;
            index3 += 3;
        }
        else
        {
            newVertices[index] = terrainWorld[num2] / translateFactor;
            newVertices[index + 1] = terrainWorld[num3] / translateFactor;
            newVertices[index + 2] = terrainWorld[num5] / translateFactor;
            newColors[index] = GameManager.terrainScreen[num2].color;
            newColors[index + 1] = color3;
            newColors[index + 2] = color;
            newUVs[index] = new Vector2(0f, 0f);
            newUVs[index + 1] = new Vector2(0f, 0f);
            newUVs[index + 2] = new Vector2(0f, 0f);
            newTriangles[0][index3] = index + 2;
            newTriangles[0][index3 + 1] = index + 1;
            newTriangles[0][index3 + 2] = index;
            index += 3;
            index3 += 3;
        }
    }

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
        crater.indices = new ushort[((num2 >> 16) - (int)num3 + 1) * (int)(num5 - num4 + 1)];
        crater.screen.x = param1;
        crater.screen.z = param2;
        int num6 = (param3 >> 8) * (param3 >> 8);
        int num7 = 0;
        crater.DAT_58 = param3;
        if (param4 < 0)
        {
            param4 += 2047;
        }
        for (; num3 < (uint)(num2 >> 16); num3++)
        {
            if (num4 > num5)
            {
                continue;
            }
            int num8 = (int)(num3 * 65536) - param1 >> 8;
            uint num9 = num4;
            do
            {
                if (FUN_1CE1C(num3, num9).DAT_10[3] == 0)
                {
                    int num10 = (int)(num9 * 65536) - param2 >> 8;
                    num10 = num8 * num8 + num10 * num10;
                    if (num10 <= num6)
                    {
                        int num11 = chunks[(num3 >> 6) * 32 + (num9 >> 6)] * 4096 + (int)((num3 & 0x3F) * 128 + (num9 & 0x3F) * 2) / 2;
                        ushort num12 = (ushort)((num6 - num10) * (param4 >> 11) / num6);
                        vertices[num11] += num12;
                        vertices[num11] &= 2047;
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
                num9++;
                num7++;
            }
            while (num9 <= num5);
        }
        FUN_50E40(param1, param2, param3);
        GameManager.instance.FUN_30CB0(crater, 60);
    }

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
                FUN_50C5C(junction);
            }
        }
    }

    public void FUN_50C5C(Junction param1)
    {
        int num = 0;
        if (-1 >= param1.DAT_1C)
        {
            return;
        }
        do
        {
            int num2 = param1.pos.x + param1._DAT_20[num].x * 256;
            int num3 = param1.pos.z + param1._DAT_20[num].z * 256;
            int num4 = FUN_1B750((uint)num2, (uint)num3);
            param1._DAT_20[num] = new Vector3Int(param1._DAT_20[num].x, num4 - param1.pos.y >> 8, param1._DAT_20[num].z);
            if (num2 < 0)
            {
                num2 += 65535;
            }
            if (num3 < 0)
            {
                num3 += 65535;
            }
            param1._DAT_26[num] = (short)(vertices[chunks[((uint)(num2 >> 16) >> 6) * 32 + ((uint)(num3 >> 16) >> 6)] * 4096 + (((num3 >> 16) & 0x3F) * 2 + ((num2 >> 16) & 0x3F) * 128) / 2] >> 11 << 2);
            num3 = param1.pos.x + param1._DAT_28[num].x * 256;
            num2 = param1.pos.z + param1._DAT_28[num].z * 256;
            num4 = FUN_1B750((uint)num3, (uint)num2);
            param1._DAT_28[num] = new Vector3Int(param1._DAT_28[num].x, num4 - param1.pos.y >> 8, param1._DAT_28[num].z);
            if (num3 < 0)
            {
                num3 += 65535;
            }
            if (num2 < 0)
            {
                num2 += 65535;
            }
            param1._DAT_2E[num] = (short)(vertices[chunks[((uint)(num3 >> 16) >> 6) * 32 + ((uint)(num2 >> 16) >> 6)] * 4096 + (((num2 >> 16) & 0x3F) * 2 + ((num3 >> 16) & 0x3F) * 128) / 2] >> 11 << 2);
            num++;
        }
        while (num <= param1.DAT_1C);
    }
}
