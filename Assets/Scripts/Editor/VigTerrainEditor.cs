using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(VigTerrain))]
public class TerrainEditor : Editor
{
    //
    [Header("VigTerrain")]
    public SerializedProperty bitmapID;
    public SerializedProperty tileData;
    public SerializedProperty vertices;
    public SerializedProperty tiles;
    public SerializedProperty defaultVertex;
    public SerializedProperty defaultTile;
    public SerializedProperty chunks;
    public SerializedProperty DAT_DE4;
    public SerializedProperty DAT_DE8;
    public SerializedProperty DAT_DEC;
    public SerializedProperty DAT_DF0;
    public SerializedProperty tileXZ;
    public SerializedProperty tileY;
    public SerializedProperty zoneCount;
    public SerializedProperty drawDistance;
    public SerializedProperty DAT_B9270;
    public SerializedProperty DAT_B9314;
    public SerializedProperty DAT_B932C;
    public SerializedProperty DAT_B9318;
    public SerializedProperty DAT_B9370;
    public SerializedProperty DAT_BA4F0;
    public SerializedProperty DAT_BDFF0;
    public SerializedProperty terrainWorld;
    public SerializedProperty terrainVertices;
    public SerializedProperty vert;
    public SerializedProperty tilesDict;
    public SerializedProperty terrainMesh;
    public SerializedProperty newVertices;
    public SerializedProperty newUVs;
    public SerializedProperty newColors;
    public SerializedProperty newTriangles;
    public SerializedProperty mainT;
    public SerializedProperty mainWidth;
    public SerializedProperty mainHeight;
    public SerializedProperty index;
    public SerializedProperty index2;
    public SerializedProperty index3;
    public SerializedProperty in_t0;
    public SerializedProperty in_t1;
    public SerializedProperty in_t2;
    public SerializedProperty in_t3;
    public SerializedProperty in_t4;
    public SerializedProperty puVar14;
    public SerializedProperty puVar15;
    public SerializedProperty puVar16;
    public SerializedProperty puVar17;
    public SerializedProperty puVar18;
    public SerializedProperty _tileData;
    public SerializedProperty _vertices;
    public SerializedProperty _tiles;
    public SerializedProperty _chunks;
    public SerializedProperty canvasSky;
    public SerializedProperty sbParent;
    public SerializedProperty skybox;
    public SerializedProperty skyboxRight;
    public SerializedProperty skyboxLeft;
    public SerializedProperty sbTop;
    public SerializedProperty sbTopRight;
    public SerializedProperty sbTopLeft;
    public SerializedProperty sbBottom;
    public SerializedProperty sbBottomRight;
    public SerializedProperty sbBottomLeft;
    public SerializedProperty skyboxMat;

    //
    public VigTerrain terrain;
    public GameManager gameManager;
    public SerializedProperty bitmap;
    public SerializedProperty chunkNum;


    SerializedObject serializedObject2;


    private void OnEnable()
    {
        terrain = GameObject.FindObjectOfType<VigTerrain>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
        bitmap = serializedObject.FindProperty("bitmapID");
        defaultVertex = serializedObject.FindProperty("defaultVertex");
        defaultTile = serializedObject.FindProperty("defaultTile");
        chunkNum = serializedObject.FindProperty("zoneCount");
        tileXZ = serializedObject.FindProperty("tileXZ");
        tileY = serializedObject.FindProperty("tileY");
        //
        bitmapID = serializedObject.FindProperty("bitmapID");
        tileData = serializedObject.FindProperty("tileData");
        vertices = serializedObject.FindProperty("vertices");
        tiles = serializedObject.FindProperty("tiles");
        defaultVertex = serializedObject.FindProperty("defaultVertex");
        defaultTile = serializedObject.FindProperty("defaultTile");
        chunks = serializedObject.FindProperty("chunks");
        DAT_DE4 = serializedObject.FindProperty("DAT_DE4");
        DAT_DE8 = serializedObject.FindProperty("DAT_DE8");
        DAT_DEC = serializedObject.FindProperty("DAT_DEC");
        DAT_DF0 = serializedObject.FindProperty("DAT_DF0");
        tileXZ = serializedObject.FindProperty("tileXZ");
        tileY = serializedObject.FindProperty("tileY");
        zoneCount = serializedObject.FindProperty("zoneCount");
        drawDistance = serializedObject.FindProperty("drawDistance");
        //DAT_B9270 = serializedObject.FindProperty("DAT_B9270");
        //DAT_B9314 = serializedObject.FindProperty("DAT_B9314");
        //DAT_B932C = serializedObject.FindProperty("DAT_B932C");
        //DAT_B9318 = serializedObject.FindProperty("DAT_B9318");
        //DAT_B9370 = serializedObject.FindProperty("DAT_B9370");
        //DAT_BA4F0 = serializedObject.FindProperty("DAT_BA4F0");
        //DAT_BDFF0 = serializedObject.FindProperty("DAT_BDFF0");
        terrainWorld = serializedObject.FindProperty("terrainWorld");
        terrainVertices = serializedObject.FindProperty("terrainVertices");
        //vert = serializedObject.FindProperty("vert");
        //tilesDict = serializedObject.FindProperty("tilesDict");
        terrainMesh = serializedObject.FindProperty("terrainMesh");
        newVertices = serializedObject.FindProperty("newVertices");
        newUVs = serializedObject.FindProperty("newUVs");
        newColors = serializedObject.FindProperty("newColors");
        //newTriangles = serializedObject.FindProperty("newTriangles");
        mainT = serializedObject.FindProperty("mainT");
        mainWidth = serializedObject.FindProperty("mainWidth");
        mainHeight = serializedObject.FindProperty("mainHeight");
        index = serializedObject.FindProperty("index");
        index2 = serializedObject.FindProperty("index2");
        index3 = serializedObject.FindProperty("index3");
        in_t0 = serializedObject.FindProperty("in_t0");
        in_t1 = serializedObject.FindProperty("in_t1");
        in_t2 = serializedObject.FindProperty("in_t2");
        in_t3 = serializedObject.FindProperty("in_t3");
        in_t4 = serializedObject.FindProperty("in_t4");
        puVar14 = serializedObject.FindProperty("puVar14");
        puVar15 = serializedObject.FindProperty("puVar15");
        puVar16 = serializedObject.FindProperty("puVar16");
        puVar17 = serializedObject.FindProperty("puVar17");
        puVar18 = serializedObject.FindProperty("puVar18");
        _tileData = serializedObject.FindProperty("_tileData");
        _vertices = serializedObject.FindProperty("_vertices");
        _tiles = serializedObject.FindProperty("_tiles");
        _chunks = serializedObject.FindProperty("_chunks");
        canvasSky = serializedObject.FindProperty("canvasSky");
        sbParent = serializedObject.FindProperty("sbParent");
        skybox = serializedObject.FindProperty("skybox");
        skyboxRight = serializedObject.FindProperty("skyboxRight");
        skyboxLeft = serializedObject.FindProperty("skyboxLeft");
        sbTop = serializedObject.FindProperty("sbTop");
        sbTopRight = serializedObject.FindProperty("sbTopRight");
        sbTopLeft = serializedObject.FindProperty("sbTopLeft");
        sbBottom = serializedObject.FindProperty("sbBottom");
        sbBottomRight = serializedObject.FindProperty("sbBottomRight");
        sbBottomLeft = serializedObject.FindProperty("sbBottomLeft");
        skyboxMat = serializedObject.FindProperty("skyboxMat");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(bitmap);
        EditorGUILayout.PropertyField(defaultVertex);
        EditorGUILayout.PropertyField(defaultTile);
        EditorGUILayout.PropertyField(tileXZ);
        EditorGUILayout.PropertyField(tileY);
        EditorGUILayout.PropertyField(chunkNum);
        //
        EditorGUILayout.PropertyField(bitmapID);
        EditorGUILayout.PropertyField(tileData);
        EditorGUILayout.PropertyField(vertices);
        EditorGUILayout.PropertyField(tiles);
        EditorGUILayout.PropertyField(defaultVertex);
        EditorGUILayout.PropertyField(defaultTile);
        EditorGUILayout.PropertyField(chunks);
        EditorGUILayout.PropertyField(DAT_DE4);
        EditorGUILayout.PropertyField(DAT_DE8);
        EditorGUILayout.PropertyField(DAT_DEC);
        EditorGUILayout.PropertyField(DAT_DF0);
        EditorGUILayout.PropertyField(tileXZ);
        EditorGUILayout.PropertyField(tileY);
        EditorGUILayout.PropertyField(zoneCount);
        EditorGUILayout.PropertyField(drawDistance);
        //EditorGUILayout.PropertyField(DAT_B9270);
        //EditorGUILayout.PropertyField(DAT_B9314);
        //EditorGUILayout.PropertyField(DAT_B932C);
        //EditorGUILayout.PropertyField(DAT_B9318);
        //EditorGUILayout.PropertyField(DAT_B9370);
        //EditorGUILayout.PropertyField(DAT_BA4F0);
        //EditorGUILayout.PropertyField(DAT_BDFF0);
        EditorGUILayout.PropertyField(terrainWorld);
        EditorGUILayout.PropertyField(terrainVertices);
        //EditorGUILayout.PropertyField(vert);
        //EditorGUILayout.PropertyField(tilesDict);
        EditorGUILayout.PropertyField(terrainMesh);
        EditorGUILayout.PropertyField(newVertices);
        EditorGUILayout.PropertyField(newUVs);
        EditorGUILayout.PropertyField(newColors);
        //EditorGUILayout.PropertyField(newTriangles);
        EditorGUILayout.PropertyField(mainT);
        EditorGUILayout.PropertyField(mainWidth);
        EditorGUILayout.PropertyField(mainHeight);
        EditorGUILayout.PropertyField(index);
        EditorGUILayout.PropertyField(index2);
        EditorGUILayout.PropertyField(index3);
        EditorGUILayout.PropertyField(in_t0);
        EditorGUILayout.PropertyField(in_t1);
        EditorGUILayout.PropertyField(in_t2);
        EditorGUILayout.PropertyField(in_t3);
        EditorGUILayout.PropertyField(in_t4);
        EditorGUILayout.PropertyField(puVar14);
        EditorGUILayout.PropertyField(puVar15);
        EditorGUILayout.PropertyField(puVar16);
        EditorGUILayout.PropertyField(puVar17);
        EditorGUILayout.PropertyField(puVar18);
        EditorGUILayout.PropertyField(_tileData);
        EditorGUILayout.PropertyField(_vertices);
        EditorGUILayout.PropertyField(_tiles);
        EditorGUILayout.PropertyField(_chunks);
        EditorGUILayout.PropertyField(canvasSky);
        EditorGUILayout.PropertyField(sbParent);
        EditorGUILayout.PropertyField(skybox);
        EditorGUILayout.PropertyField(skyboxRight);
        EditorGUILayout.PropertyField(skyboxLeft);
        EditorGUILayout.PropertyField(sbTop);
        EditorGUILayout.PropertyField(sbTopRight);
        EditorGUILayout.PropertyField(sbTopLeft);
        EditorGUILayout.PropertyField(sbBottom);
        EditorGUILayout.PropertyField(sbBottomRight);
        EditorGUILayout.PropertyField(sbBottomLeft);
        EditorGUILayout.PropertyField(skyboxMat);
        //
        serializedObject.ApplyModifiedProperties();

        if (GUILayout.Button("Set # Chunks"))
        {
            terrain.SetNumberOfZones();
            EditorUtility.SetDirty(terrain);
        }

        EditorGUILayout.LabelField("Import Asset");

        if (GUILayout.Button("TIN"))
        {
            string file = EditorUtility.OpenFilePanel("Open TIN file to load asset", "", "");
            IMP_TIN.LoadAsset(file);
            EditorUtility.SetDirty(terrain);
        }

        if (GUILayout.Button("ZONE"))
        {
            string file = EditorUtility.OpenFilePanel("Open ZONE file to load asset", "", "");
            IMP_ZONE.LoadAsset(file);
            EditorUtility.SetDirty(terrain);
        }

        if (GUILayout.Button("ZMAP"))
        {
            string file = EditorUtility.OpenFilePanel("Open ZMAP file to load asset", "", "");
            IMP_ZMAP.LoadAsset(file);
            EditorUtility.SetDirty(terrain);
        }

        if (GUILayout.Button("Generate Mesh"))
        {
            Mesh levelMesh = GenerateMesh();
            terrain.GetComponent<MeshFilter>().sharedMesh = levelMesh;

            levelMesh.name = "newGeo";
            Debug.Log("New Level Geometry Generated Successfuly! Polys: " + levelMesh.triangles.Length);
        }
    }

    private Mesh GenerateMesh()
    {
        Mesh mesh = new Mesh();
        List<Vector3> newVertices = new List<Vector3>();
        List<Vector2> newUV = new List<Vector2>();
        List<int> newTriangles = new List<int>();
        terrain = GameObject.FindObjectOfType<VigTerrain>();
        Material mat = terrain.GetComponent<MeshRenderer>().sharedMaterial;
        int vertIndex = 0;

        mesh.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;

        for (int i = 0; i < terrain.chunks.Length; i++)
        {
            int tFactor = 4096; //GameManager.instance.translateFactor
            int tileXZ = terrain.tileXZ;
            int tileY = terrain.tileY;

            if (terrain.chunks[i] == 0 || terrain.zoneCount <= terrain.chunks[i])
                continue;

            int zone = terrain.chunks[i];

            for (int x = 0; x < 64; x++)
            {
                for (int y = 0; y < 64; y++)
                {
                    float vert1_x = Utilities.MoveDecimal((long)x * tileXZ + (long)tileXZ * 64 * (i / 32), tFactor);
                    float vert1_y = -Utilities.MoveDecimal((long)((int)((short)terrain.vertices[zone * 4096 + x * 64 + y] & 0x7FF)) * tileY, tFactor);
                    float vert1_z = Utilities.MoveDecimal((long)y * tileXZ + (long)tileXZ * 64 * (i % 32), tFactor);
                    newVertices.Add(new Vector3(vert1_x, vert1_y, vert1_z));

                    float vert2_x = Utilities.MoveDecimal((long)(x + 1) * tileXZ + (long)tileXZ * 64 * (i / 32), tFactor);
                    int nextZone = x + 1 < 64 ? zone : terrain.chunks[i + 32];
                    int nextX = x + 1 < 64 ? x + 1 : 0;
                    float vert2_y = -Utilities.MoveDecimal((long)((int)((short)terrain.vertices[nextZone * 4096 + nextX * 64 + y] & 0x7FF)) * tileY, tFactor);
                    float vert2_z = Utilities.MoveDecimal((long)y * tileXZ + (long)tileXZ * 64 * (i % 32), tFactor);
                    newVertices.Add(new Vector3(vert2_x, vert2_y, vert2_z));

                    float vert3_x = Utilities.MoveDecimal((long)x * tileXZ + (long)tileXZ * 64 * (i / 32), tFactor);
                    nextZone = y + 1 < 64 ? zone : terrain.chunks[i + 1];
                    int nextY = y + 1 < 64 ? y + 1 : 0;
                    float vert3_y = -Utilities.MoveDecimal((long)((int)((short)terrain.vertices[nextZone * 4096 + x * 64 + nextY] & 0x7FF)) * tileY, tFactor);
                    float vert3_z = Utilities.MoveDecimal((long)(y + 1) * tileXZ + (long)tileXZ * 64 * (i % 32), tFactor);
                    newVertices.Add(new Vector3(vert3_x, vert3_y, vert3_z));

                    float vert4_x = Utilities.MoveDecimal((long)(x + 1) * tileXZ + (long)tileXZ * 64 * (i / 32), tFactor);
                    if (x + 1 >= 64 && y + 1 >= 64)
                    {
                        nextZone = terrain.chunks[i + 33];
                        nextX = 0;
                        nextY = 0;
                    }
                    else if (x + 1 >= 64)
                    {
                        nextZone = terrain.chunks[i + 32];
                        nextX = 0;
                        nextY = y + 1;
                    }
                    else if (y + 1 >= 64)
                    {
                        nextZone = terrain.chunks[i + 1];
                        nextX = x + 1;
                        nextY = 0;
                    }
                    else
                    {
                        nextZone = zone;
                        nextX = x + 1;
                        nextY = y + 1;
                    }
                    float vert4_y = -Utilities.MoveDecimal((long)((int)((short)terrain.vertices[nextZone * 4096 + nextX * 64 + nextY] & 0x7FF)) * tileY, tFactor);
                    float vert4_z = Utilities.MoveDecimal((long)(y + 1) * tileXZ + (long)tileXZ * 64 * (i % 32), tFactor);
                    newVertices.Add(new Vector3(vert4_x, vert4_y, vert4_z));

                    int tileIndex = zone * 4096 + x * 64 + y;

                    Debug.Log("uv1_x: " + terrain.tileData[terrain.tiles[tileIndex]].uv1_x);
                    Debug.Log("width: " + mat.mainTexture.width);
                    float uv1_x = (float)terrain.tileData[terrain.tiles[tileIndex]].uv1_x / (mat.mainTexture.width - 1);
                    float uv1_y = 1.0f - (float)terrain.tileData[terrain.tiles[tileIndex]].uv1_y / (mat.mainTexture.height - 1);

                    float uv2_x = (float)terrain.tileData[terrain.tiles[tileIndex]].uv2_x / (mat.mainTexture.width - 1);
                    float uv2_y = 1.0f - (float)terrain.tileData[terrain.tiles[tileIndex]].uv2_y / (mat.mainTexture.height - 1);

                    float uv3_x = (float)terrain.tileData[terrain.tiles[tileIndex]].uv3_x / (mat.mainTexture.width - 1);
                    float uv3_y = 1.0f - (float)terrain.tileData[terrain.tiles[tileIndex]].uv3_y / (mat.mainTexture.height - 1);

                    float uv4_x = (float)terrain.tileData[terrain.tiles[tileIndex]].uv4_x / (mat.mainTexture.width - 1);
                    float uv4_y = 1.0f - (float)terrain.tileData[terrain.tiles[tileIndex]].uv4_y / (mat.mainTexture.height - 1);

                    newUV.Add(new Vector2(uv1_x, uv1_y));
                    newUV.Add(new Vector2(uv2_x, uv2_y));
                    newUV.Add(new Vector2(uv3_x, uv3_y));
                    newUV.Add(new Vector2(uv4_x, uv4_y));

                    newTriangles.Add(vertIndex + 2);
                    newTriangles.Add(vertIndex + 1);
                    newTriangles.Add(vertIndex + 0);
                    newTriangles.Add(vertIndex + 3);
                    newTriangles.Add(vertIndex + 1);
                    newTriangles.Add(vertIndex + 2);

                    vertIndex += 4;
                }
            }
        }

        mesh.SetVertices(newVertices);
        mesh.SetUVs(0, newUV);
        mesh.SetTriangles(newTriangles, 0);

        return mesh;
    }
}
