using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEditor;

public class XOBF_DB : MonoBehaviour
{
    [Serializable]
    public class TMD
    {
        public int vertices;

        public ushort flag;

        public int normals;

        public int faces;

        public byte DAT_18;

        public byte DAT_19;

        public ushort DAT_1A;

        public byte[] vertexStream;

        public byte[] normalStream;

        public byte[] faceStream;
    }

    public List<TMD> tmdList = new List<TMD>();

    public List<VigCollider> cbbList = new List<VigCollider>();

    public List<Texture2D> timList = new List<Texture2D>();

    public VigConfig ini;

    public byte[] animations;

    public List<AudioClip> sndList = new List<AudioClip>();

    public List<_MATERIAL> materialList = new List<_MATERIAL>();

    public List<_RENDER> renderList = new List<_RENDER>();

    private string prefabPath;

    private string prefabName;

    private BufferedBinaryReader r;

    private Texture2D atlas;

    private Material matAtlas;

    private Material additive;

    private Material billboard;

    private Material subtractive;

    private Material billboard2;

    private Material subtractive2;

    private Material billboard3;

    private Material additive2;

    private Material transparent;

    private Material billboard4;

    private Material backface;

    private Rect[] rects;

    private void Reset()
    {
#if UNITY_EDITOR
        prefabName = name;
        prefabPath = Application.dataPath.Remove(Application.dataPath.Length - 6, 6)
            + Path.GetDirectoryName(AssetDatabase.GetAssetPath(gameObject));
        prefabPath = prefabPath.Replace("\\", "/");
#endif
    }

    public void SetAtlas()
    {
        Texture2D[] array = new Texture2D[timList.Count];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = timList[i];

            //FIX - Activar la opción "Readable" en la textura
            //string path = AssetDatabase.GetAssetPath(array[i]);
            //TextureImporter importer = (TextureImporter)AssetImporter.GetAtPath(path);
            //importer.isReadable = true;
            //AssetDatabase.ImportAsset(path);
        }

        atlas = new Texture2D(1024, 1024);

        Debug.Log("rects: " + rects);
        Debug.Log("array: " + array); //Texture2D
        Debug.Log("atlas.PackTextures: " + atlas.PackTextures(array, 0, 1024));

        rects = atlas.PackTextures(array, 0, 1024);

        atlas.wrapMode = TextureWrapMode.Clamp;
        atlas.filterMode = FilterMode.Point;

        matAtlas = new Material(Shader.Find("PSXEffects/PS1Shader"));
        matAtlas.mainTexture = atlas;
        matAtlas.SetFloat("_ColorOnly", 0f);
        matAtlas.SetFloat("_Unlit", 1f);
        matAtlas.SetFloat("_OffsetFactor", 0.5f);
        matAtlas.SetFloat("_OffsetUnits", 0.5f);
        matAtlas.SetFloat("_RenderMode", 2f);
        matAtlas.SetFloat("_Cul", 1f);
        matAtlas.SetFloat("_DrawDist", 0f);

        additive = new Material(Shader.Find("PSXEffects/PS1Additive"));
        additive.mainTexture = atlas;
        additive.SetFloat("_ColorOnly", 0f);
        additive.SetFloat("_Unlit", 1f);
        additive.SetFloat("_OffsetFactor", -2f);
        additive.SetFloat("_OffsetUnits", -2f);
        additive.SetFloat("_RenderMode", 2f);
        additive.SetFloat("_Cul", 2f);
        additive.SetFloat("_DrawDist", 0f);

        billboard = new Material(Shader.Find("PSXEffects/PS1Billboard"));
        billboard.mainTexture = atlas;
        billboard.SetFloat("_ColorOnly", 0f);
        billboard.SetFloat("_Unlit", 1f);
        billboard.SetFloat("_OffsetFactor", -2f);
        billboard.SetFloat("_OffsetUnits", -2f);
        billboard.SetFloat("_RenderMode", 2f);
        billboard.SetFloat("_Cul", 1f);
        billboard.SetFloat("_DrawDist", 0f);

        subtractive = new Material(Shader.Find("PSXEffects/PS1Subtractive"));
        subtractive.mainTexture = atlas;
        subtractive.SetFloat("_ColorOnly", 0f);
        subtractive.SetFloat("_Unlit", 1f);
        subtractive.SetFloat("_OffsetFactor", -2f);
        subtractive.SetFloat("_OffsetUnits", -2f);
        subtractive.SetFloat("_RenderMode", 2f);
        subtractive.SetFloat("_Cul", 1f);
        subtractive.SetFloat("_DrawDist", 0f);

        billboard2 = new Material(Shader.Find("PSXEffects/PS1Billboard2"));
        billboard2.mainTexture = atlas;
        billboard2.SetFloat("_ColorOnly", 0f);
        billboard2.SetFloat("_Unlit", 1f);
        billboard2.SetFloat("_OffsetFactor", -2f);
        billboard2.SetFloat("_OffsetUnits", -2f);
        billboard2.SetFloat("_RenderMode", 2f);
        billboard2.SetFloat("_Cul", 1f);
        billboard2.SetFloat("_DrawDist", 0f);

        subtractive2 = new Material(Shader.Find("PSXEffects/PS1SubtractiveBB"));
        subtractive2.mainTexture = atlas;
        subtractive2.SetFloat("_ColorOnly", 0f);
        subtractive2.SetFloat("_Unlit", 1f);
        subtractive2.SetFloat("_OffsetFactor", -2f);
        subtractive2.SetFloat("_OffsetUnits", -2f);
        subtractive2.SetFloat("_RenderMode", 2f);
        subtractive2.SetFloat("_Cul", 1f);
        subtractive2.SetFloat("_DrawDist", 0f);

        billboard3 = new Material(Shader.Find("PSXEffects/PS1Billboard3"));
        billboard3.mainTexture = atlas;
        billboard3.SetFloat("_ColorOnly", 0f);
        billboard3.SetFloat("_Unlit", 1f);
        billboard3.SetFloat("_OffsetFactor", -2f);
        billboard3.SetFloat("_OffsetUnits", -2f);
        billboard3.SetFloat("_RenderMode", 2f);
        billboard3.SetFloat("_Cul", 1f);
        billboard3.SetFloat("_DrawDist", 0f);

        additive2 = new Material(Shader.Find("PSXEffects/PS1Additive2"));
        additive2.mainTexture = atlas;
        additive2.SetFloat("_ColorOnly", 0f);
        additive2.SetFloat("_Unlit", 1f);
        additive2.SetFloat("_OffsetFactor", -2f);
        additive2.SetFloat("_OffsetUnits", -2f);
        additive2.SetFloat("_RenderMode", 2f);
        additive2.SetFloat("_Cul", 2f);
        additive2.SetFloat("_DrawDist", 0f);

        transparent = new Material(Shader.Find("PSXEffects/PS1Transparent"));
        transparent.mainTexture = atlas;
        transparent.SetFloat("_ColorOnly", 0f);
        transparent.SetFloat("_Unlit", 1f);
        transparent.SetFloat("_OffsetFactor", -2f);
        transparent.SetFloat("_OffsetUnits", -2f);
        transparent.SetFloat("_RenderMode", 1f);
        transparent.SetFloat("_Cul", 1f);
        transparent.SetFloat("_DrawDist", 0f);
        transparent.SetInt("_SrcBlend", 5);
        transparent.SetInt("_DstBlend", 10);
        transparent.SetInt("_ZWrite", 1);

        billboard4 = new Material(Shader.Find("PSXEffects/PS1Billboard4"));
        billboard4.mainTexture = atlas;
        billboard4.SetFloat("_ColorOnly", 0f);
        billboard4.SetFloat("_Unlit", 1f);
        billboard4.SetFloat("_OffsetFactor", 1f);
        billboard4.SetFloat("_OffsetUnits", 1f);
        billboard4.SetFloat("_RenderMode", 2f);
        billboard4.SetFloat("_Cul", 1f);
        billboard4.SetFloat("_DrawDist", 0f);

        backface = new Material(Shader.Find("PSXEffects/PS1Shader"));
        backface.mainTexture = atlas;
        backface.SetFloat("_ColorOnly", 0f);
        backface.SetFloat("_Unlit", 1f);
        backface.SetFloat("_OffsetFactor", 0.5f);
        backface.SetFloat("_OffsetUnits", 0.5f);
        backface.SetFloat("_RenderMode", 2f);
        backface.SetFloat("_Cul", 0f);
        backface.SetFloat("_DrawDist", 0f);
    }

    public Material[] GetMaterialList(VigMesh mesh, int tmdID)
    {
        List<Material> list = new List<Material>();
        List<int> list2 = new List<int>();
        list.Add(LevelManager.instance.defaultMaterial);
        mesh.subMeshCount = 2;
        int item = 0;
        switch (materialList[tmdID])
        {
            case _MATERIAL.Cutout:
                list.Add(matAtlas);
                break;
            case _MATERIAL.Additive:
                list.Add(additive);
                break;
            case _MATERIAL.Billboard:
                list.Add(billboard);
                break;
            case _MATERIAL.Lines:
                mesh.topology = MeshTopology.Lines;
                mesh.subMeshCount = 1;
                break;
            case _MATERIAL.Mirror:
                list.Add(additive);
                mesh.mirror = true;
                break;
            case _MATERIAL.CutAdd:
                list.Add(matAtlas);
                list.Add(additive);
                mesh.subMeshCount = 3;
                break;
            case _MATERIAL.Subtractive:
                list.Add(subtractive);
                break;
            case _MATERIAL.Lines2:
                mesh.topology = MeshTopology.Lines;
                list.Add(matAtlas);
                list.Add(LevelManager.instance.defaultMaterial);
                mesh.subMeshCount = 3;
                break;
            case _MATERIAL.Billboard2:
                list.Add(billboard2);
                break;
        }
        using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(mesh.faceStream), Encoding.Default, leaveOpen: true))
        {
            if (0 < mesh.faces)
            {
                for (int i = 0; i < mesh.faces; i++)
                {
                    long num = binaryReader.BaseStream.Position;
                    byte b = binaryReader.ReadByte(3);
                    switch (((uint)b >> 2) & 0xF)
                    {
                        case 1u:
                        case 5u:
                            item = (binaryReader.ReadUInt16(22) & 0x3FFF);
                            break;
                        case 9u:
                            item = (binaryReader.ReadUInt16(26) & 0x3FFF);
                            break;
                        case 10u:
                            {
                                int num2 = 0;
                                int num3 = binaryReader.ReadUInt16(10);
                                if (num3 != 0)
                                {
                                    int num4 = 16;
                                    do
                                    {
                                        item = (binaryReader.ReadUInt16(num4 - 2) & 0x3FFF);
                                        if (!list2.Contains(item))
                                        {
                                            list2.Add(item);
                                        }
                                        num4 += 8;
                                        num2++;
                                    }
                                    while (num2 < num3);
                                }
                                num += binaryReader.ReadUInt16(10) * 8;
                                break;
                            }
                        case 12u:
                            item = (((binaryReader.ReadUInt16(16) & 0x3FFF) != 16382) ? (((binaryReader.ReadUInt16(16) & 0x3FFF) != 16383) ? (binaryReader.ReadUInt16(16) & 0x3FFF) : 16383) : 16382);
                            break;
                        case 13u:
                            item = ((binaryReader.ReadUInt16(22) != ushort.MaxValue) ? (binaryReader.ReadUInt16(22) & 0x3FFF) : 65535);
                            break;
                    }
                    if (!list2.Contains(item))
                    {
                        list2.Add(item);
                    }
                    binaryReader.BaseStream.Seek(num, SeekOrigin.Begin);
                    binaryReader.BaseStream.Seek(GameManager.DAT_854[(b >> 2) & 0xF], SeekOrigin.Current);
                }
            }
        }
        mesh.materialIDs = new Dictionary<int, int>();
        for (int j = 0; j < list2.Count; j++)
        {
            if (list2[j] != 65535 && list2[j] != 16383 && list2[j] != 16382)
            {
                mesh.materialIDs.Add(list2[j], (int)(renderList[list2[j]] + 1));
            }
        }
        mesh.mainT = rects;
        mesh.atlas = atlas;
        return list.ToArray();
    }

    public Smoke5 InstantiateSmoke(short param1, Vector3Int param2)
    {
        Smoke5 smoke = new GameObject().AddComponent<Smoke5>();
        smoke.flags = 32u;
        smoke.screen = param2;
        smoke.DAT_58 = 65536;
        smoke.ApplyTransformation();
        smoke.physics1.M1 = 7;
        smoke.DAT_98 = this;
        smoke.physics2.M3 = param1;
        smoke.physics1.Y = 256;
        smoke.physics1.Z = -512;
        smoke.physics1.W = 0;
        smoke.physics2.X = 4194304;
        smoke.physics2.M2 = 32;
        return smoke;
    }

    public Smoke3 FUN_4F730(short param1, Vector3Int param2)
    {
        Smoke3 smoke = new GameObject().AddComponent<Smoke3>();
        smoke.flags = 32u;
        smoke.screen = param2;
        smoke.DAT_58 = 65536;
        smoke.ApplyTransformation();
        smoke.physics1.M1 = 4;
        smoke.physics1.Y = 512;
        smoke.DAT_98 = this;
        smoke.physics2.M3 = param1;
        smoke.physics1.Z = -1536;
        smoke.physics1.W = 0;
        return smoke;
    }

    public Smoke FUN_4F438(short param1, Vector3Int param2)
    {
        Smoke smoke = new GameObject().AddComponent<Smoke>();
        smoke.flags = 32u;
        smoke.screen = param2;
        smoke.DAT_58 = 65536;
        smoke.ApplyTransformation();
        smoke.physics1.M1 = 7;
        smoke.DAT_98 = this;
        smoke.physics2.M3 = param1;
        smoke.physics1.Y = 256;
        smoke.physics1.Z = -512;
        smoke.physics1.W = 0;
        smoke.physics2.X = 4194304;
        smoke.physics2.M2 = 32;
        return smoke;
    }

    public Particle8 FUN_4EC2C(short param1, sbyte param2)
    {
        Particle8 particle = new GameObject().AddComponent<Particle8>();
        particle.vData = this;
        particle.DAT_1A = param1;
        particle.tags = param2;
        GameManager.instance.FUN_30CB0(particle, 0);
        return particle;
    }

    public VigObject FUN_4D498(ushort param1, VigTransform param2, int param3)
    {
        VigObject vigObject = null;
        VigObject vigObject2 = vigObject;
        if (param1 != ushort.MaxValue)
        {
            do
            {
                ConfigContainer configContainer = ini.configContainers[param1];
                VigTransform m = Utilities.FUN_2C77C(configContainer);
                m = Utilities.CompMatrixLV(param2, m);
                vigObject = vigObject2;
                if ((configContainer.flag & 0x7FF) == 2047 && param3 != 0)
                {
                    Particle6 particle = ini.FUN_2C17C(param1, typeof(Particle6), 8u) as Particle6;
                    if (particle != null)
                    {
                        particle.ApplyTransformation();
                        if (particle.vAnim != null)
                        {
                            particle.state = _PARTICLE6_TYPE.Type1;
                        }
                        vigObject = particle;
                        if (vigObject2 != null)
                        {
                            particle.child = vigObject2;
                            vigObject2.parent = particle;
                        }
                    }
                }
                else
                {
                    ushort num;
                    switch ((uint)configContainer.flag >> 12)
                    {
                        case 0u:
                            if (param3 != 0 && configContainer.objID != 43690)
                            {
                                Particle6 particle = ini.FUN_2C17C(param1, typeof(Particle6), 8u) as Particle6;
                                particle.ApplyTransformation();
                                if (configContainer.objID == 0 && particle.vAnim != null)
                                {
                                    particle.state = _PARTICLE6_TYPE.Type1;
                                }
                                vigObject = particle;
                                if (vigObject2 != null)
                                {
                                    particle.child = vigObject2;
                                    vigObject2.parent = particle;
                                }
                                goto IL_0448;
                            }
                            vigObject2 = ini.FUN_2BF44(configContainer, typeof(Throwaway));
                            goto IL_017a;
                        case 8u:
                        case 9u:
                        case 14u:
                            if (configContainer.objID == 43690 || configContainer.objID == 0)
                            {
                                LevelManager.instance.FUN_4D16C(this, param1, m);
                            }
                            else
                            {
                                vigObject2 = new GameObject().AddComponent<Particle7>();
                                vigObject2.vTransform = m;
                                vigObject2.vData = this;
                                vigObject2.DAT_1A = (short)param1;
                                GameManager.instance.FUN_30CB0(vigObject2, configContainer.objID);
                            }
                            goto IL_0448;
                        case 13u:
                            vigObject2 = ini.FUN_2BF44(configContainer, typeof(Throwaway));
                            if (configContainer.objID == 0)
                            {
                                vigObject2.physics1.M0 = 0;
                                vigObject2.physics1.M1 = 0;
                                vigObject2.physics1.M2 = 0;
                                break;
                            }
                            goto IL_017a;
                        default:
                            goto IL_0448;
                        IL_017a:
                            num = (ushort)GameManager.FUN_2AC5C();
                            vigObject2.physics1.M0 = (short)(num & 0xFF);
                            num = (ushort)GameManager.FUN_2AC5C();
                            vigObject2.physics1.M1 = (short)(num & 0xFF);
                            num = (ushort)GameManager.FUN_2AC5C();
                            vigObject2.physics1.M2 = (short)(num & 0xFF);
                            break;
                    }
                    uint num2 = 384u;
                    vigObject2.type = 7;
                    if (vigObject2.vAnim != null)
                    {
                        num2 = 388u;
                    }
                    uint num3 = vigObject2.flags;
                    if (vigObject2.vCollider == null)
                    {
                        num3 |= 0x20;
                    }
                    vigObject2.flags = (num3 | num2);
                    vigObject2.id = (short)param3;
                    if ((num3 & 0x10) == 0)
                    {
                        ((Throwaway)vigObject2).state = _THROWAWAY_TYPE.Unspawnable;
                    }
                    else
                    {
                        ((Throwaway)vigObject2).state = _THROWAWAY_TYPE.Type3;
                    }
                    vigObject2.physics1.Z = configContainer.v3_1.x << 8 >> 12;
                    vigObject2.physics1.W = configContainer.v3_1.y << 8 >> 12;
                    vigObject2.physics2.X = configContainer.v3_1.z << 8 >> 12;
                    Vector3Int vector3Int = Utilities.FUN_24094(param2.rotation, new Vector3Int(vigObject2.physics1.Z, vigObject2.physics1.W, vigObject2.physics2.X));
                    vigObject2.physics1.Z = vector3Int.x;
                    vigObject2.physics1.W = vector3Int.y;
                    vigObject2.physics2.X = vector3Int.z;
                    vigObject2.vTransform = m;
                    vigObject2.FUN_305FC();
                    byte dAT_ = 3;
                    if (10239 < vigObject2.DAT_58)
                    {
                        dAT_ = 1;
                        if (vigObject2.DAT_58 < 30720)
                        {
                            dAT_ = 2;
                        }
                    }
                    ((Throwaway)vigObject2).DAT_87 = dAT_;
                    ConfigContainer configContainer2 = ini.FUN_2C5CC(configContainer, 34338);
                    if (configContainer2 != null)
                    {
                        Particle8 particle2 = LevelManager.instance.xobfList[19].FUN_4EC2C(109, 8);
                        Utilities.FUN_2CA94(vigObject2, configContainer2, particle2);
                        particle2.transform.parent = vigObject2.transform;
                    }
                }
                goto IL_0448;
            IL_0448:
                param1 = configContainer.previous;
                vigObject2 = vigObject;
            }
            while (param1 != ushort.MaxValue);
        }
        return vigObject;
    }

    public Vehicle FUN_3C464(ushort param1, VehicleData param2, Type param3, bool bodyParts = false)
    {
        ushort @int = param1; //Wheels
        Vehicle vehicle = bodyParts ? (ini.FUN_2C17C_2(param1, param3, (uint)(((animations.Length != 0) ? 1 : 0) << 3)) as Vehicle) : (ini.FUN_2C17C(param1, param3, (uint)(((animations.Length != 0) ? 1 : 0) << 3)) as Vehicle);
        uint num = param2.DAT_0C;
        if ((param2.DAT_0C & 0xF0) == 0)
        {
            num |= 0x30;
        }
        vehicle.id = 0;
        vehicle.type = 2;
        vehicle.maxHalfHealth = param2.maxHalfHealth;
        _VEHICLE vehicleID = param2.vehicleID;
        vehicle.DAT_E0 = 1024;
        vehicle.vehicle = vehicleID;
        vehicle.lightness = param2.lightness;
        if (animations.Length != 0)
        {
            vehicle.flags |= 4u;
        }
        vehicle.DAT_E4 = -vehicle.screen.y;
        VigObject child = vehicle.child2;
        vehicle.body = new VigObject[4];
        Utilities.ParentChildren(vehicle, vehicle);
        VigObject vigObject = child;
        while (vigObject != null)
        {
            child = vigObject.child;
            if ((ushort)vigObject.id < 4)
            {
                vehicle.body[vigObject.id] = vigObject;
                sbyte b = (sbyte)vigObject.FUN_4DCD8();
                vigObject.tags = (sbyte)(b + 1);
                vigObject.maxHalfHealth = param2.maxHalfHealth;
            }
            vigObject = child;
        }
        vehicle.wheels = new Wheel[6];
        for (int i = 0; i < vehicle.wheels.Length; i++)
        {
            ConfigContainer configContainer = ini.FUN_2C590(@int, (i - 32768) & 0xFFFF);
            if (configContainer == null)
            {
                continue;
            }
            ConfigContainer configContainer2 = ini.FUN_2C6D0(configContainer, 0);
            uint num2;
            if (configContainer2 == null)
            {
                num2 = 12u;
                if ((GameManager.instance.DAT_40 & 1) == 0)
                {
                    num2 = (ushort)param2.DAT_00[((i < 2) ? 1 : 0) ^ 1];
                }
                child = LevelManager.instance.xobfList[18].ini.FUN_2C17C((ushort)num2, typeof(Wheel), 8u);
                Utilities.ParentChildren(child, child);
                child.physics2.X = -LevelManager.instance.xobfList[18].ini.configContainers[(int)num2].v3_1.y;
                short x = (short)GameManager.FUN_2AC5C();
                child.vr = new Vector3Int(x, 0, (i & 1) << 11);
            }
            else
            {
                short x = (short)ini.FUN_2C73C(configContainer2);
                child = ini.FUN_2C17C((ushort)x, typeof(Wheel), 8u);
                Utilities.ParentChildren(child, child);
                child.physics2.X = -(vehicle.screen.y + configContainer.v3_1.y + configContainer2.v3_1.y);
            }
            child.transform.parent = vehicle.transform;
            child.id = child.DAT_1A;
            child.screen = configContainer.v3_1;
            Utilities.FUN_2CC48(vehicle, child);
            vehicle.wheels[i] = (Wheel)child;
            configContainer = ini.FUN_2C5CC(configContainer, 32768);
            child.type = 9;
            if (configContainer == null)
            {
                child.physics1.X = 0;
            }
            else
            {
                child.physics1.X = configContainer.v3_1.y;
            }
            child.physics1.Y = child.screen.y;
            child.physics1.M6 = param2.DAT_00[(i >> 1) + 2];
            //Fallo en la Matriz al modificar vehiculos
            Debug.Log("pym7: " + param2.DAT_00[(i >> 1)]);
            if (param2.DAT_00[(i >> 1)] != 64)
                child.physics1.M7 = param2.DAT_00[(i >> 1) + 4];
            else
            {
                Debug.Log("Supera 64");
                child.physics1.M7 = param2.DAT_00[(i >> 1)];
            }
            if (child.vMesh != null)
            {
                if ((child.flags & 0x10) == 0)
                {
                    int num3 = child.physics2.X * 25734;
                    if (num3 < 0)
                    {
                        num3 += 4095;
                    }
                    child.physics2.Y = 16777216 / (num3 >> 12);
                }
                else
                {
                    child.flags &= 4294967279u;
                    child.physics2.Y = 0;
                }
            }
            if ((GameManager.instance.DAT_40 & 0x40000) != 0)
            {
                child.physics1.Y += 10240;
            }
            child.physics1.Z = child.physics2.X;
            if (child.vAnim != null)
            {
                child.FUN_2FBC8(GameManager.instance.timer);
            }
            num2 = (uint)(((num & (16 << i)) != 0L) ? ((i << 28) | 0x2000020) : ((i << 28) | 0x20));
            child.flags |= (uint)(((((int)num >> i) & 1) << 24) | (int)num2);
            child.ApplyTransformation();
        }
        vehicle.DAT_A0 = param2.DAT_24;
        vehicle.DAT_A6 = param2.DAT_2A;
        vehicle.wheelsType = _WHEELS.Ground;
        vehicle.direction = 1;
        vehicle.DAT_B3 = param2.DAT_13;
        vehicle.DAT_B1 = param2.DAT_0E;
        vehicle.DAT_B2 = param2.DAT_0F;
        vehicle.DAT_AF = param2.DAT_15;
        vehicle.DAT_C3 = param2.DAT_10;
        vehicle.DAT_C4 = param2.DAT_11;
        vehicle.DAT_C5 = param2.DAT_12;
        vehicle.peelSpeed = param2.peelout;
        byte[] array = new byte[4];
        Array.Copy(GameManager.DAT_A14, array, 4);
        int num4;
        do
        {
            num4 = 0;
            int num3 = num4;
            do
            {
                num3++;
                byte b2 = array[num3 - 1];
                byte b3 = array[num3];
                if (param2.DAT_2C[b2] < param2.DAT_2C[b3])
                {
                    num4 = 1;
                    array[num3 - 1] = b3;
                    array[num3] = b2;
                }
            }
            while (num3 < 3);
        }
        while (num4 != 0);
        vehicle.DAT_C0 = (byte)(array[0] | (array[1] << 2) | (array[2] << 4) | (array[3] << 6));
        child = (vehicle.PDAT_7C = vehicle.FUN_2CA1C());
        return vehicle;
    }

    public VigMesh FUN_2CB74(GameObject param1, uint param2, bool init)
    {
        return FUN_1FD18(param1, (uint)(ini.configContainers[(int)(param2 & 0xFFFF)].flag & 0x7FF), init);
    }

    public VigMesh FUN_2CB74_2(GameObject param1, uint param2)
    {
        return FUN_1FD18_2(param1, (uint)(ini.configContainers[(int)(param2 & 0xFFFF)].flag & 0x7FF));
    }

    public BufferedBinaryReader FUN_2CBB0(int param1)
    {
        if (r == null)
        {
            r = new BufferedBinaryReader(animations);
        }
        BufferedBinaryReader bufferedBinaryReader = r;
        bufferedBinaryReader.Seek(0L, SeekOrigin.Begin);
        int num = 0;
        if (bufferedBinaryReader.Length != 0L)
        {
            int num2 = bufferedBinaryReader.ReadInt32((param1 & 0xFFFF) * 4 + 4);
            if (num2 != 0)
            {
                num += num2;
            }
        }
        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
        return bufferedBinaryReader;
    }

    public void LoadDB(string assetPath, string identifier)
    {
        Debug.Log("Paso LoadDB...");
        using (BinaryReader reader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
        {
            Debug.Log("Leyendo Binario...");
            if (reader != null)
            {
                string headerString = new string(reader.ReadChars(4));

                if (headerString == "XOBF")
                {
                    Debug.Log("Leyendo XOBF...");
                    do
                    {
                        headerString = new string(reader.ReadChars(4));
                        int size = reader.ReadInt32BE();
                        size += size % 2;

                        if (headerString == identifier)
                        {
                            if (identifier == "BIN ")
                            {
                                Debug.Log("Leyendo BIN...");
                                LoadBIN(reader);
                            }
                            else if (identifier == "ANM ")
                            {
                                Debug.Log("Leyendo ANM...");
                                animations = reader.ReadBytes(size);
#if UNITY_EDITOR
                                EditorUtility.SetDirty(gameObject);
                                PrefabUtility.RecordPrefabInstancePropertyModifications(gameObject);
#endif
                            }
                            else if (identifier == "SND ")
                            {
                                Debug.Log("Leyendo SND...");
                                LoadSND(reader);
                            }
                            break;
                        }
                        else
                        {
                            Debug.Log("Que paso? A1...");
                            reader.BaseStream.Seek(size, SeekOrigin.Current);
                        }
                    } while (reader.BaseStream.Position != reader.BaseStream.Length);
                }
            }
        }
    }

    public void LoadDB2(string assetPath, string identifier)
    {
        using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
        {
            if (binaryReader != null && new string(binaryReader.ReadChars(4)) == "XOBF")
            {
                int num;
                while (true)
                {
                    string a = new string(binaryReader.ReadChars(4));
                    num = binaryReader.ReadInt32BE();
                    num += num % 2;
                    if (a == identifier)
                    {
                        break;
                    }
                    binaryReader.BaseStream.Seek(num, SeekOrigin.Current);
                    if (binaryReader.BaseStream.Position == binaryReader.BaseStream.Length)
                    {
                        return;
                    }
                }
                if (identifier == "BIN ")
                {
                    LoadBIN2(binaryReader);
                }
                else if (identifier == "ANM ")
                {
                    animations = binaryReader.ReadBytes(num);
                }
                else if (identifier == "SND ")
                {
                    LoadSND(binaryReader);
                }
            }
        }
    }

    private void LoadBIN(BinaryReader reader)
    {

        byte bVar1;
        bool bVar2;
        byte bVar6;
        long lVar9;
        ushort uVar12;
        long begin = reader.BaseStream.Position;
        int tmdElements = reader.ReadInt32();
        int tmdOffset = reader.ReadInt32();
        long tmdPosition = begin + tmdOffset;
        int cbbElements = reader.ReadInt32();
        int cbbOffset = reader.ReadInt32();
        long cbbPosition = begin + cbbOffset;
        int timElements = reader.ReadInt32();
        int timOffset = reader.ReadInt32();
        long timPosition = begin + timOffset;
        int iniElements = reader.ReadInt32();
        long iniPosition = reader.BaseStream.Position;

        reader.BaseStream.Seek(tmdPosition, SeekOrigin.Begin);

        if (0 < tmdElements)
        {
            Debug.Log("Leyendo tmdElements...");
            for (int i = 0; i < tmdElements; i++)
            {
                Debug.Log("tmdElements: " + tmdElements);
                reader.BaseStream.Seek(tmdPosition + i * 4, SeekOrigin.Begin);
                int elementOffset = reader.ReadInt32();
                long elementPosition = reader.BaseStream.Seek(tmdPosition + elementOffset, SeekOrigin.Begin);
                TMD newTMD = new TMD();
                newTMD.vertices = reader.ReadInt32();
                int verticesOffset = reader.ReadInt32();
                newTMD.normals = reader.ReadInt32();
                int normalsOffset = reader.ReadInt32();
                newTMD.faces = reader.ReadInt32();
                int facesOffset = reader.ReadInt32();
                newTMD.DAT_18 = reader.ReadByte();
                newTMD.DAT_19 = reader.ReadByte();
                newTMD.DAT_1A = reader.ReadUInt16();
                bVar2 = false;

                if (0 < newTMD.faces)
                {
                    Debug.Log("newTMD.faces...");
                    reader.BaseStream.Seek(elementPosition + facesOffset, SeekOrigin.Begin);
                    MemoryStream stream = new MemoryStream();

                    using (BinaryWriter writer = new BinaryWriter(stream, Encoding.Default, true))
                    {
                        for (int j = 0; j < newTMD.faces; j++)
                        {
                            lVar9 = reader.BaseStream.Position;
                            writer.Write(reader.ReadByte());
                            writer.Write(reader.ReadByte());
                            writer.Write(reader.ReadByte());
                            bVar1 = reader.ReadByte();
                            bVar6 = (byte)((bVar1 & 15) << 2);

                            if ((bVar1 & 0x80) != 0)
                                bVar6 |= 0x40;

                            if ((bVar1 & 0x10) != 0)
                                bVar6 |= 2;

                            if ((bVar1 & 0x40) != 0)
                                bVar6 |= 0x80;

                            writer.Write(bVar6);
                            writer.Write((short)(reader.ReadInt16() << 3));
                            writer.Write((short)(reader.ReadInt16() << 3));
                            writer.Write((short)(reader.ReadInt16() << 3));

                            switch (bVar6 >> 2 & 15)
                            {
                                case 1:
                                case 3:
                                    writer.Write(reader.ReadBytes(17));
                                    writer.Write((byte)0x34);
                                    reader.ReadByte();
                                    writer.Write(reader.ReadBytes(3));
                                    writer.Write((byte)0x34);
                                    reader.ReadByte();
                                    break;
                                case 2:
                                    writer.Write(reader.ReadBytes(5));
                                    writer.Write((byte)0x30);
                                    reader.ReadByte();
                                    writer.Write(reader.ReadBytes(3));
                                    writer.Write((byte)0x30);
                                    reader.ReadByte();
                                    break;
                                case 4:
                                case 5:
                                case 7:
                                    bVar2 = true;
                                    writer.Write((short)(reader.ReadInt16() << 3));
                                    break;
                                case 8:
                                case 9:
                                case 11:
                                    bVar2 = true;
                                    writer.Write((short)(reader.ReadInt16() << 3));
                                    writer.Write((short)(reader.ReadInt16() << 3));
                                    writer.Write((short)(reader.ReadInt16() << 3));
                                    break;
                                case 12:
                                    writer.Write((short)(reader.ReadInt16() << 3));
                                    writer.Write((short)(reader.ReadInt16() << 3));
                                    writer.Write((short)(reader.ReadInt16() << 3));
                                    break;
                                case 10:
                                    uVar12 = reader.ReadUInt16();
                                    writer.Write(uVar12);
                                    writer.Write(reader.ReadBytes(uVar12 * 8));
                                    lVar9 += uVar12 * 8;
                                    break;
                            }

                            int remain = GameManager.DAT_854[bVar6 >> 2 & 15] -
                                (int)(reader.BaseStream.Position - lVar9);
                            writer.Write(reader.ReadBytes(remain));
                        }
                    }

                    if (bVar2)
                        newTMD.flag |= 0x8000;

                    newTMD.faceStream = stream.ToArray();
                }

                if (0 < newTMD.vertices)
                {
                    Debug.Log("newTMD.vertices...");
                    reader.BaseStream.Seek(elementPosition + verticesOffset, SeekOrigin.Begin);
                    MemoryStream stream = new MemoryStream();

                    using (BinaryWriter writer = new BinaryWriter(stream, Encoding.Default, true))
                    {
                        for (int j = 0; j < newTMD.vertices; j++)
                            writer.Write(reader.ReadBytes(8));
                    }

                    newTMD.vertexStream = stream.ToArray();
                }

                if (0 < newTMD.normals)
                {
                    Debug.Log("newTMD.normals...");
                    reader.BaseStream.Seek(elementPosition + normalsOffset, SeekOrigin.Begin);
                    MemoryStream stream = new MemoryStream();

                    using (BinaryWriter writer = new BinaryWriter(stream, Encoding.Default, true))
                    {
                        for (int j = 0; j < newTMD.normals; j++)
                            writer.Write(reader.ReadBytes(8));
                    }

                    newTMD.normalStream = stream.ToArray();
                }

                tmdList.Add(newTMD);
            }
        }

        reader.BaseStream.Seek(cbbPosition, SeekOrigin.Begin);

        if (0 < cbbElements)
        {
            Debug.Log("Leyendo cbbElements...");
            for (int i = 0; i < cbbElements; i++)
            {
                Debug.Log("cbbElements: " + cbbElements);
                reader.BaseStream.Seek(cbbPosition + i * 4, SeekOrigin.Begin);
                int elementOffset = reader.ReadInt32();
                int elementSize = reader.ReadInt32() - elementOffset;
                long elementPosition = reader.BaseStream.Seek(cbbPosition + elementOffset, SeekOrigin.Begin);
                cbbList.Add(new VigCollider(reader.ReadBytes(elementSize)));
            }
        }

        reader.BaseStream.Seek(timPosition, SeekOrigin.Begin);
        string relativePath = prefabPath;

        if (prefabPath.StartsWith(Application.dataPath))
            relativePath = "Assets" + prefabPath.Substring(Application.dataPath.Length);

        if (0 < timElements)
        {
            Debug.Log("Leyendo timElements...");
            for (int i = 0; i < timElements; i++)
            {
                Debug.Log("timElements: " + timElements);
                reader.BaseStream.Seek(timPosition + i * 4, SeekOrigin.Begin);
                int elementOffset = reader.ReadInt32();
                int elementSize = reader.ReadInt32() - elementOffset;
                long elementPosition = reader.BaseStream.Seek(timPosition + elementOffset, SeekOrigin.Begin);
                string bmpApsolute = prefabPath + "/Textures/" + prefabName + "_" + i.ToString().PadLeft(4, '0') + ".bmp";
                string bmpRelative = relativePath + "/Textures/" + prefabName + "_" + i.ToString().PadLeft(4, '0') + ".bmp";
                reader.ReadInt32();
                IMP_TIM.LoadTIM(reader, bmpApsolute);
                Material newMaterial = null;
#if UNITY_EDITOR
                AssetDatabase.Refresh();
                newMaterial = new Material(AssetDatabase.LoadAssetAtPath(relativePath + "/default.mat", typeof(Material)) as Material);
                newMaterial.mainTexture = AssetDatabase.LoadAssetAtPath(bmpRelative, typeof(Texture2D)) as Texture2D;
                Utilities.SaveObjectToFile(newMaterial, prefabPath);
                timList.Add(AssetDatabase.LoadAssetAtPath(bmpRelative, typeof(Texture2D)) as Texture2D);
#endif
            }
        }

        reader.BaseStream.Seek(iniPosition, SeekOrigin.Begin);

        Debug.Log("Leyendo iniElements...");
        if (0 < iniElements)
        {
            Debug.Log("iniElements: " + iniElements);
            VigConfig newConfig = gameObject.AddComponent<VigConfig>();
            ini = newConfig;
            newConfig.configContainers = new List<ConfigContainer>();
            newConfig.xobf = this;

            for (int i = 0; i < iniElements; i++)
            {
                ConfigContainer newContainer = new ConfigContainer();
                newContainer.flag = reader.ReadUInt16();
                newContainer.colliderID = reader.ReadInt16();
                newContainer.v3_1 = new Vector3Int(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
                newContainer.v3_2 = new Vector3Int(reader.ReadInt16(), reader.ReadInt16(), reader.ReadInt16());
                newContainer.objID = reader.ReadUInt16();
                newContainer.previous = reader.ReadUInt16();
                newContainer.next = reader.ReadUInt16();
                newConfig.configContainers.Add(newContainer);
            }
        }

#if UNITY_EDITOR
        Debug.Log("Llegamos hasta aqui?...");
        EditorUtility.SetDirty(gameObject);
        PrefabUtility.RecordPrefabInstancePropertyModifications(gameObject);
#endif
    }

    private void LoadBIN2(BinaryReader reader)
    {
        long position = reader.BaseStream.Position;
        int num = reader.ReadInt32();
        int num2 = reader.ReadInt32();
        long num3 = position + num2;
        int num4 = reader.ReadInt32();
        int num5 = reader.ReadInt32();
        long num6 = position + num5;
        int num7 = reader.ReadInt32();
        int num8 = reader.ReadInt32();
        long num9 = position + num8;
        int num10 = reader.ReadInt32();
        long position2 = reader.BaseStream.Position;
        reader.BaseStream.Seek(num3, SeekOrigin.Begin);
        if (0 < num)
        {
            for (int i = 0; i < num; i++)
            {
                reader.BaseStream.Seek(num3 + i * 4, SeekOrigin.Begin);
                int num11 = reader.ReadInt32();
                long num12 = reader.BaseStream.Seek(num3 + num11, SeekOrigin.Begin);
                TMD tMD = new TMD();
                tMD.vertices = reader.ReadInt32();
                int num13 = reader.ReadInt32();
                tMD.normals = reader.ReadInt32();
                int num14 = reader.ReadInt32();
                tMD.faces = reader.ReadInt32();
                int num15 = reader.ReadInt32();
                tMD.DAT_18 = reader.ReadByte();
                tMD.DAT_19 = reader.ReadByte();
                tMD.DAT_1A = reader.ReadUInt16();
                bool flag = false;
                if (0 < tMD.faces)
                {
                    reader.BaseStream.Seek(num12 + num15, SeekOrigin.Begin);
                    MemoryStream memoryStream = new MemoryStream();
                    using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Default, leaveOpen: true))
                    {
                        for (int j = 0; j < tMD.faces; j++)
                        {
                            long num16 = reader.BaseStream.Position;
                            binaryWriter.Write(reader.ReadByte());
                            binaryWriter.Write(reader.ReadByte());
                            binaryWriter.Write(reader.ReadByte());
                            byte num17 = reader.ReadByte();
                            byte b = (byte)((num17 & 0xF) << 2);
                            if ((num17 & 0x80) != 0)
                            {
                                b = (byte)(b | 0x40);
                            }
                            if ((num17 & 0x10) != 0)
                            {
                                b = (byte)(b | 2);
                            }
                            if ((num17 & 0x40) != 0)
                            {
                                b = (byte)(b | 0x80);
                            }
                            binaryWriter.Write(b);
                            binaryWriter.Write((short)(reader.ReadInt16() << 3));
                            binaryWriter.Write((short)(reader.ReadInt16() << 3));
                            binaryWriter.Write((short)(reader.ReadInt16() << 3));
                            switch ((b >> 2) & 0xF)
                            {
                                case 1:
                                case 3:
                                    binaryWriter.Write(reader.ReadBytes(13));
                                    binaryWriter.Write((byte)52);
                                    reader.ReadByte();
                                    binaryWriter.Write(reader.ReadBytes(3));
                                    binaryWriter.Write((byte)52);
                                    reader.ReadByte();
                                    break;
                                case 2:
                                    binaryWriter.Write(reader.ReadBytes(5));
                                    binaryWriter.Write((byte)48);
                                    reader.ReadByte();
                                    binaryWriter.Write(reader.ReadBytes(3));
                                    binaryWriter.Write((byte)48);
                                    reader.ReadByte();
                                    break;
                                case 4:
                                    flag = true;
                                    binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                    break;
                                case 5:
                                case 7:
                                    flag = true;
                                    binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                    binaryWriter.Write(reader.ReadBytes(2));
                                    binaryWriter.Write((short)0);
                                    binaryWriter.Write(reader.ReadBytes(2));
                                    binaryWriter.Write((short)0);
                                    binaryWriter.Write(reader.ReadBytes(4));
                                    break;
                                case 8:
                                    flag = true;
                                    binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                    binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                    binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                    break;
                                case 9:
                                case 11:
                                    flag = true;
                                    binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                    binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                    binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                    binaryWriter.Write(reader.ReadBytes(2));
                                    binaryWriter.Write((short)0);
                                    binaryWriter.Write(reader.ReadBytes(2));
                                    binaryWriter.Write((short)0);
                                    binaryWriter.Write(reader.ReadBytes(4));
                                    break;
                                case 12:
                                    {
                                        binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                        binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                        binaryWriter.Write((short)(reader.ReadInt16() << 3));
                                        int num19 = reader.ReadUInt16();
                                        if (num19 == 16383)
                                        {
                                            num19 = 16381;
                                        }
                                        binaryWriter.Write((ushort)num19);
                                        binaryWriter.Write(reader.ReadBytes(2));
                                        binaryWriter.Write(0);
                                        break;
                                    }
                                case 10:
                                    {
                                        ushort num18 = reader.ReadUInt16();
                                        binaryWriter.Write(num18);
                                        for (int k = 0; k < num18; k++)
                                        {
                                            binaryWriter.Write(reader.ReadBytes(4));
                                            binaryWriter.Write(0);
                                        }
                                        num16 += num18 * 4;
                                        break;
                                    }
                                case 13:
                                case 15:
                                    binaryWriter.Write((byte)(reader.ReadByte() | 1));
                                    binaryWriter.Write(reader.ReadByte());
                                    binaryWriter.Write(reader.ReadBytes(2));
                                    binaryWriter.Write((short)0);
                                    binaryWriter.Write(reader.ReadBytes(2));
                                    binaryWriter.Write((short)0);
                                    binaryWriter.Write(reader.ReadBytes(4));
                                    break;
                            }
                            int num20 = GameManager.DAT_854_2[(b & 0x3C) / 2] - (int)(reader.BaseStream.Position - num16);
                            if (num20 > 0)
                            {
                                binaryWriter.Write(reader.ReadBytes(num20));
                            }
                        }
                    }
                    if (flag)
                    {
                        tMD.flag |= 32768;
                    }
                    tMD.faceStream = memoryStream.ToArray();
                }
                if (0 < tMD.vertices)
                {
                    reader.BaseStream.Seek(num12 + num13, SeekOrigin.Begin);
                    MemoryStream memoryStream2 = new MemoryStream();
                    using (BinaryWriter binaryWriter2 = new BinaryWriter(memoryStream2, Encoding.Default, leaveOpen: true))
                    {
                        for (int l = 0; l < tMD.vertices; l++)
                        {
                            binaryWriter2.Write(reader.ReadBytes(8));
                        }
                    }
                    tMD.vertexStream = memoryStream2.ToArray();
                }
                if (0 < tMD.normals)
                {
                    reader.BaseStream.Seek(num12 + num14, SeekOrigin.Begin);
                    MemoryStream memoryStream3 = new MemoryStream();
                    using (BinaryWriter binaryWriter3 = new BinaryWriter(memoryStream3, Encoding.Default, leaveOpen: true))
                    {
                        for (int m = 0; m < tMD.normals; m++)
                        {
                            binaryWriter3.Write(reader.ReadBytes(8));
                        }
                    }
                    tMD.normalStream = memoryStream3.ToArray();
                }
                tmdList.Add(tMD);
            }
        }
        reader.BaseStream.Seek(num6, SeekOrigin.Begin);
        if (0 < num4)
        {
            for (int n = 0; n < num4; n++)
            {
                reader.BaseStream.Seek(num6 + n * 4, SeekOrigin.Begin);
                int num21 = reader.ReadInt32();
                int count = reader.ReadInt32() - num21;
                reader.BaseStream.Seek(num6 + num21, SeekOrigin.Begin);
                cbbList.Add(new VigCollider(reader.ReadBytes(count)));
            }
        }
        reader.BaseStream.Seek(num9, SeekOrigin.Begin);
        string text = prefabPath;
        if (prefabPath.StartsWith(Application.dataPath))
        {
            text = "Assets" + prefabPath.Substring(Application.dataPath.Length);
        }
        if (0 < num7)
        {
            for (int num22 = 0; num22 < num7; num22++)
            {
                reader.BaseStream.Seek(num9 + num22 * 4, SeekOrigin.Begin);
                int num23 = reader.ReadInt32();
                reader.ReadInt32();
                reader.BaseStream.Seek(num9 + num23, SeekOrigin.Begin);
                string path = prefabPath + "/Textures/" + prefabName + "_" + num22.ToString().PadLeft(4, '0') + ".bmp";
                string text2 = text + "/Textures/" + prefabName + "_" + num22.ToString().PadLeft(4, '0') + ".bmp";
                reader.ReadInt32();
                IMP_TIM.LoadTIM(reader, path);
            }
        }
        reader.BaseStream.Seek(position2, SeekOrigin.Begin);
        if (0 < num10)
        {
            VigConfig vigConfig = ini = base.gameObject.AddComponent<VigConfig>();
            vigConfig.configContainers = new List<ConfigContainer>();
            vigConfig.xobf = this;
            for (int num24 = 0; num24 < num10; num24++)
            {
                ConfigContainer configContainer = new ConfigContainer();
                configContainer.flag = reader.ReadUInt16();
                configContainer.colliderID = reader.ReadInt16();
                configContainer.v3_1 = new Vector3Int(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
                configContainer.v3_2 = new Vector3Int(reader.ReadInt16(), reader.ReadInt16(), reader.ReadInt16());
                configContainer.objID = reader.ReadUInt16();
                configContainer.previous = reader.ReadUInt16();
                configContainer.next = reader.ReadUInt16();
                vigConfig.configContainers.Add(configContainer);
            }
        }
    }



    private void LoadSND(BinaryReader reader)
    {
#if UNITY_EDITOR
        long startPosition = reader.BaseStream.Position;
        int elementsCount = reader.ReadUInt16();
        int eof = reader.ReadUInt16() * 8;
        long elementsPosition = reader.BaseStream.Position + elementsCount * 4;
        double[,] f = { {   0.0, 0.0 },
                        {  60.0 / 64.0, 0.0 },
                        { 115.0 / 64.0, -52.0 / 64.0 },
                        {  98.0 / 64.0, -55.0 / 64.0 },
                        { 122.0 / 64.0, -60.0 / 64.0 } };
        double[] samples = new double[28];
        prefabName = name;
        prefabPath = Application.dataPath.Remove(Application.dataPath.Length - 6, 6)
            + Path.GetDirectoryName(AssetDatabase.GetAssetPath(gameObject));
        prefabPath = prefabPath.Replace("\\", "/");
        string relativePath = prefabPath;

        if (prefabPath.StartsWith(Application.dataPath))
            relativePath = "Assets" + prefabPath.Substring(Application.dataPath.Length);

        for (int i = 0; i < elementsCount; i++)
        {
            int samplesCount = 0;
            int loopBegin = 0;
            int loopEnd = 0;
            double s_1 = 0.0;
            double s_2 = 0.0;
            string wavApsolute = prefabPath + "/Sounds/" + prefabName + "_" + i.ToString().PadLeft(4, '0') + ".wav";
            string wavRelative = relativePath + "/Sounds/" + prefabName + "_" + i.ToString().PadLeft(4, '0') + ".wav";

            using (BinaryWriter writer = new BinaryWriter(File.Open(wavApsolute, FileMode.Create)))
            {
                reader.BaseStream.Seek(startPosition, SeekOrigin.Begin);
                reader.BaseStream.Seek(i * 4 + 4, SeekOrigin.Current);
                int elementOffset = reader.ReadUInt16() * 8;
                uint samp_freq = reader.ReadUInt16() * 11U;
                int nextOffset = reader.ReadUInt16() * 8;
                if (i == elementsCount - 1) nextOffset = eof;
                reader.BaseStream.Seek(elementsPosition + elementOffset, SeekOrigin.Begin);
                //reader.BaseStream.Seek(16, SeekOrigin.Current); //vag name?
                writer.Write(0x46464952); //RIFF
                writer.Write(0); //skip file size for now
                writer.Write(0x45564157); //WAVE
                writer.Write(0x20746D66); //fmt
                writer.Write(0x10);
                writer.Write((short)1);
                writer.Write((short)1);
                writer.Write((byte)samp_freq);
                writer.Write((byte)(samp_freq >> 8));
                writer.Write((short)0);
                writer.Write(samp_freq * 2);
                writer.Write((short)2);
                writer.Write((short)16);
                writer.Write(0x6C706D73); //smpl
                writer.Write(60);
                writer.Write(0);
                writer.Write(0);
                writer.Write(0);
                writer.Write(60);
                writer.Write(0);
                writer.Write(0);
                writer.Write(0);
                writer.Write(1);
                writer.Write(0);
                writer.Write(1);
                writer.Write(1);
                writer.Write(0);
                writer.Write(0);
                writer.Write(0);
                writer.Write(0);
                writer.Write(0x61746164); //data
                writer.Write(0); //skip SubChunk2Size for now

                while (reader.BaseStream.Position < elementsPosition + nextOffset)
                {
                    int predict_nr = reader.ReadByte();
                    int shift_factor = predict_nr & 0xf;
                    predict_nr >>= 4;
                    int flags = reader.ReadByte();

                    if (flags == 7)
                        break;
                    else if (flags == 6)
                        loopBegin = samplesCount;
                    else if (flags == 3)
                        loopEnd = samplesCount + 28;

                    for (int j = 0; j < 28; j += 2)
                    {
                        int d = reader.ReadByte();
                        int s = (d & 0xf) << 12;

                        if ((s & 0x8000) != 0)
                            s |= -0x10000;

                        samples[j] = s >> shift_factor;
                        s = (d & 0xf0) << 8;

                        if ((s & 0x8000) != 0)
                            s |= -0x10000;

                        samples[j + 1] = s >> shift_factor;
                    }

                    for (int j = 0; j < 28; j++)
                    {
                        samplesCount++;
                        samples[j] = samples[j] + s_1 * f[predict_nr, 0] + s_2 * f[predict_nr, 1];
                        s_2 = s_1;
                        s_1 = samples[j];
                        int d = (int)(samples[j] + 0.5);
                        writer.Write((short)d);
                    }
                }

                if (loopEnd == 0)
                    loopEnd = samplesCount;

                long sz = writer.BaseStream.Length;
                writer.BaseStream.Seek(4, SeekOrigin.Begin);
                writer.Write((int)(sz - 8));
                writer.BaseStream.Seek(108, SeekOrigin.Begin);
                writer.Write((int)(sz - 44));
                writer.BaseStream.Seek(88, SeekOrigin.Begin);
                writer.Write(loopBegin);
                writer.Write(loopEnd);
            }

            AssetDatabase.Refresh();
            sndList.Add(AssetDatabase.LoadAssetAtPath(wavRelative, typeof(AudioClip)) as AudioClip);
        }
        EditorUtility.SetDirty(gameObject);
        PrefabUtility.RecordPrefabInstancePropertyModifications(gameObject);
#endif
    }

    private void FUN_1F2FC(uint param2)
    {
        //load VRAM data

    }

    private void FUN_1F6AC(TMD param1)
    {
        MemoryStream memoryStream = new MemoryStream(param1.faceStream);
        param1.flag |= 16384;
        using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.Default, leaveOpen: true))
        {
            using (BinaryWriter writer = new BinaryWriter(memoryStream, Encoding.Default, leaveOpen: true))
            {
                if (0 < param1.faces)
                {
                    for (int i = 0; i < param1.faces; i++)
                    {
                        long num = binaryReader.BaseStream.Position;
                        binaryReader.BaseStream.Seek(3L, SeekOrigin.Current);
                        byte b = binaryReader.ReadByte();
                        if ((b & 0x80) != 0)
                        {
                            writer.Write(-4, (byte)0);
                            writer.Write(-3, (byte)0);
                            writer.Write(-2, (byte)0);
                        }
                        switch (((uint)b >> 2) & 0xF)
                        {
                            case 10u:
                                num += binaryReader.ReadUInt16(6) * 8;
                                break;
                        }
                        binaryReader.BaseStream.Seek(num, SeekOrigin.Begin);
                        binaryReader.BaseStream.Seek(GameManager.DAT_854[(b >> 2) & 0xF], SeekOrigin.Current);
                    }
                }
            }
        }
    }

    public void FUN_1F288(uint param1, VigMesh param2)
    {
        if (!param2.materialIDs.ContainsKey((int)param1))
        {
            param2.materialIDs.Add((int)param1, param2.render[(int)renderList[(int)param1]]);
        }
    }

    public VigMesh FUN_1FD18(GameObject param1, uint param2, bool init)
    {
        LevelManager levelManager = LevelManager.instance;
        List<int> list = new List<int>();
        int[] array = new int[4];
        if (levelManager == null)
        {
            levelManager = UnityEngine.Object.FindObjectOfType<LevelManager>();
        }
        TMD tMD = tmdList[(int)(param2 & 0xFFFF)];
        VigMesh vigMesh = param1.AddComponent<VigMesh>();
        vigMesh.tmdID = param2;
        vigMesh.topology = MeshTopology.Triangles;
        MeshFilter component = param1.GetComponent<MeshFilter>();
        MeshRenderer meshRenderer = param1.GetComponent<MeshRenderer>();
        vigMesh.subMeshCount = 2;
        vigMesh.render = array;
        bool flag = false;
        if (component == null)
        {
            param1.AddComponent<MeshFilter>().mesh = new Mesh();
            meshRenderer = param1.AddComponent<MeshRenderer>();
            meshRenderer.receiveShadows = false;
            meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
        }
        List<Material> list2 = new List<Material>();
        list2.Add(levelManager.defaultMaterial);
        switch (materialList[(int)param2])
        {
            case _MATERIAL.Cutout:
                list2.Add(matAtlas);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                break;
            case _MATERIAL.Additive:
                list2.Add(additive);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.Billboard:
                list2.Add(billboard);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.Lines:
                vigMesh.topology = MeshTopology.Lines;
                vigMesh.subMeshCount = 1;
                vigMesh.linesSubmeshID = 0;
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                break;
            case _MATERIAL.Mirror:
                list2.Add(additive);
                vigMesh.mirror = true;
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.CutAdd:
                list2.Add(matAtlas);
                list2.Add(additive);
                vigMesh.subMeshCount = 3;
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.Subtractive:
                list2.Add(subtractive);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.Lines2:
                vigMesh.topology = MeshTopology.Lines;
                list2.Add(matAtlas);
                list2.Add(levelManager.defaultMaterial);
                vigMesh.subMeshCount = 3;
                vigMesh.linesSubmeshID = 2;
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                break;
            case _MATERIAL.Billboard2:
                list2.Add(billboard2);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.Subtractive2:
                list2.Add(subtractive2);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.Billboard3:
                list2.Add(billboard3);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.Additive2:
                list2.Add(additive2);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.Transparent:
                list2.Add(transparent);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                break;
            case _MATERIAL.OpaqueTransparent:
                list2.Add(matAtlas);
                list2.Add(transparent);
                vigMesh.subMeshCount = 3;
                array[0] = 1;
                array[1] = 2;
                array[2] = 1;
                array[3] = 1;
                break;
            case _MATERIAL.AddSub:
                list2.Add(billboard);
                list2.Add(subtractive2);
                vigMesh.subMeshCount = 3;
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 2;
                param1.layer = 1;
                break;
            case _MATERIAL.Billboard4:
                list2.Add(billboard4);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.IgnoreLOD:
                list2.Add(matAtlas);
                flag = true;
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                break;
            case _MATERIAL.Backface:
                list2.Add(backface);
                array[0] = 1;
                array[1] = 1;
                array[2] = 1;
                array[3] = 1;
                break;
            case _MATERIAL.CutSub:
                list2.Add(matAtlas);
                list2.Add(subtractive);
                vigMesh.subMeshCount = 3;
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;
                array[3] = 1;
                param1.layer = 1;
                break;
            case _MATERIAL.LinesTransparent:
                vigMesh.topology = MeshTopology.Lines;
                list2.Add(matAtlas);
                list2.Add(transparent);
                list2.Add(levelManager.defaultMaterial);
                vigMesh.subMeshCount = 4;
                vigMesh.linesSubmeshID = 3;
                array[0] = 1;
                array[1] = 2;
                array[2] = 1;
                array[3] = 1;
                break;
        }
        int num = 0;
        vigMesh.DAT_1C = new int[16];
        if (tMD.DAT_19 != 0)
        {
            for (int i = 0; i < tMD.DAT_19; i++)
            {
                vigMesh.DAT_1C[i] = 0;
                if (!list.Contains(vigMesh.DAT_1C[i]))
                {
                    list.Add(vigMesh.DAT_1C[i]);
                }
            }
        }
        vigMesh.DAT_00 = (byte)(((uint)(short)tMD.flag >> 15) & 1);
        vigMesh.vertices = (ushort)tMD.vertices;
        vigMesh.vertexStream = tMD.vertexStream;
        vigMesh.normalStream = tMD.normalStream;
        vigMesh.faces = (ushort)tMD.faces;
        vigMesh.faceStream = tMD.faceStream;
        byte dAT_ = tMD.DAT_18;
        vigMesh.DAT_02 = 0;
        vigMesh.DAT_01 = dAT_;
        ushort dAT_1A = tMD.DAT_1A;
        dAT_ = tMD.DAT_18;
        vigMesh.DAT_14 = null;
        vigMesh.DAT_18 = (uint)(dAT_1A << 16 - dAT_);
        if ((tMD.flag & 0x4000) == 0)
        {
            FUN_1F6AC(tMD);
        }
        MemoryStream memoryStream = new MemoryStream(vigMesh.faceStream);
        List<OcclusionCamera> list3 = new List<OcclusionCamera>();
        if (init)
        {
            vigMesh.Initialize();
        }
        using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.Default, leaveOpen: true))
        {
            using (BinaryWriter writer = new BinaryWriter(memoryStream, Encoding.Default, leaveOpen: true))
            {
                if (0 < vigMesh.faces)
                {
                    for (int j = 0; j < vigMesh.faces; j++)
                    {
                        long num2 = binaryReader.BaseStream.Position;
                        dAT_ = binaryReader.ReadByte(3);
                        switch (((uint)dAT_ >> 2) & 0xF)
                        {
                            case 1u:
                            case 5u:
                                num = (binaryReader.ReadUInt16(22) & 0x3FFF);
                                break;
                            case 9u:
                                num = (binaryReader.ReadUInt16(26) & 0x3FFF);
                                break;
                            case 10u:
                                {
                                    int num3 = 0;
                                    int num4 = binaryReader.ReadUInt16(10);
                                    if (num4 != 0)
                                    {
                                        int num5 = 16;
                                        int offset = binaryReader.ReadInt16(4);
                                        int id = binaryReader.ReadInt16(6);
                                        OcclusionCamera component2 = UnityEngine.Object.Instantiate(UIManager.instance.occlusionPrefab.gameObject, param1.transform).GetComponent<OcclusionCamera>();
                                        Vector3 vector = (Vector3)vigMesh.GetVertexBuffer().ReadSVector(offset) / (float)GameManager.instance.translateFactor2;
                                        vector = new Vector3(vector.x, 0f - vector.y, vector.z);
                                        component2.transform.localPosition = vector;
                                        component2.id = id;
                                        list3.Add(component2);
                                        LensFlaresPreset lensFlaresPreset = ScriptableObject.CreateInstance<LensFlaresPreset>();
                                        lensFlaresPreset.presets = new LensFlares.FlarePreset[num4];
                                        do
                                        {
                                            num = (binaryReader.ReadUInt16(num5 - 2) & 0x3FFF);
                                            LensFlares.FlarePreset flarePreset = new LensFlares.FlarePreset();
                                            flarePreset.sprite = timList[num];
                                            flarePreset.position = 0f - ((float)binaryReader.ReadInt16(num5 - 4) / 4096f - 1f) + 1f;
                                            flarePreset.startAngle = -90f;
                                            lensFlaresPreset.presets[num3] = flarePreset;
                                            if (!list.Contains(num))
                                            {
                                                list.Add(num);
                                            }
                                            num5 += 8;
                                            num3++;
                                        }
                                        while (num3 < num4);
                                        LensFlares lensFlares = component2.lensFlare = UnityEngine.Object.Instantiate(UIManager.instance.lensFlarePrefab, UIManager.instance.flaresRect);
                                        component2.AwakeW();
                                        lensFlares._presets = lensFlaresPreset;
                                        lensFlares._material = new Material(lensFlares._material);
                                        lensFlares._material.SetTexture("_OcclusionMap", component2._camera.targetTexture);
                                        lensFlares.color = new Color32(binaryReader.ReadByte(0), binaryReader.ReadByte(1), binaryReader.ReadByte(2), byte.MaxValue);
                                        UIManager.instance.flares.Add(lensFlares);
                                        lensFlares.AwakeW();
                                    }
                                    num2 += binaryReader.ReadUInt16(10) * 8;
                                    break;
                                }
                            case 12u:
                                {
                                    Texture texture;
                                    if ((binaryReader.ReadUInt16(16) & 0x3FFF) == 16382)
                                    {
                                        num = 16382;
                                        texture = LevelManager.instance.DAT_E58.mainTexture;
                                    }
                                    else if ((binaryReader.ReadUInt16(16) & 0x3FFF) == 16381)
                                    {
                                        num = 16381;
                                        texture = LevelManager.instance.DAT_DD0.mainTexture;
                                    }
                                    else if ((binaryReader.ReadUInt16(16) & 0x3FFF) == 16383)
                                    {
                                        num = 16383;
                                        texture = LevelManager.instance.DAT_E48.mainTexture;
                                    }
                                    else
                                    {
                                        num = (binaryReader.ReadUInt16(16) & 0x3FFF);
                                        texture = timList[num];
                                    }
                                    int num3 = Utilities.FUN_29BD0(texture.width);
                                    writer.Write(18, (byte)(12 - (num3 - 1)));
                                    sbyte b = (sbyte)texture.height;
                                    writer.Write(19, (byte)(b - ((1 << num3 - 1) + 1)));
                                    break;
                                }
                            case 13u:
                                num = ((binaryReader.ReadUInt16(22) != ushort.MaxValue) ? (binaryReader.ReadUInt16(22) & 0x3FFF) : 65535);
                                break;
                        }
                        if (!list.Contains(num))
                        {
                            list.Add(num);
                        }
                        binaryReader.BaseStream.Seek(num2, SeekOrigin.Begin);
                        binaryReader.BaseStream.Seek(GameManager.DAT_854[(dAT_ >> 2) & 0xF], SeekOrigin.Current);
                    }
                }
            }
        }
        if (init)
        {
            vigMesh.materialIDs = new Dictionary<int, int>();
            if (vigMesh.mainT != rects)
            {
                vigMesh.mainT = rects;
                vigMesh.atlas = atlas;
                vigMesh.occlusions = list3.ToArray();
            }
            for (int k = 0; k < list.Count; k++)
            {
                if (list[k] == 65535 || list[k] == 16383)
                {
                    list2.Add(levelManager.DAT_E48);
                    vigMesh.materialIDs.Add(list[k], list2.Count - 1);
                    vigMesh.subMeshCount++;
                    vigMesh.reflections = (Texture2D)levelManager.DAT_E48.mainTexture;
                }
                else if (list[k] == 16382)
                {
                    list2.Add(levelManager.DAT_E58);
                    vigMesh.materialIDs.Add(list[k], list2.Count - 1);
                    vigMesh.subMeshCount++;
                    vigMesh.glossiness = (Texture2D)levelManager.DAT_E58.mainTexture;
                }
                else if (list[k] == 16381)
                {
                    list2.Add(levelManager.DAT_DD0);
                    vigMesh.materialIDs.Add(list[k], list2.Count - 1);
                    vigMesh.subMeshCount++;
                    vigMesh.reflections = (Texture2D)levelManager.DAT_DD0.mainTexture;
                }
                else
                {
                    vigMesh.materialIDs.Add(list[k], array[(int)renderList[list[k]]]);
                }
            }
            if (!flag)
            {
                meshRenderer.sharedMaterials = list2.ToArray();
            }
        }
        return vigMesh;
    }

    public VigMesh FUN_1FD18_2(GameObject param1, uint param2)
    {
        LevelManager instance = LevelManager.instance;
        List<int> list = new List<int>();
        if (instance == null)
        {
            UnityEngine.Object.FindObjectOfType<LevelManager>();
        }
        TMD tMD = tmdList[(int)(param2 & 0xFFFF)];
        VigMesh vigMesh = param1.AddComponent<VigMesh>();
        vigMesh.tmdID = param2;
        vigMesh.topology = MeshTopology.Triangles;
        vigMesh.subMeshCount = 1;
        vigMesh.DAT_1C = new int[16];
        if (tMD.DAT_19 != 0)
        {
            for (int i = 0; i < tMD.DAT_19; i++)
            {
                vigMesh.DAT_1C[i] = 0;
                if (!list.Contains(vigMesh.DAT_1C[i]))
                {
                    list.Add(vigMesh.DAT_1C[i]);
                }
            }
        }
        vigMesh.DAT_00 = (byte)(((uint)(short)tMD.flag >> 15) & 1);
        vigMesh.vertices = (ushort)tMD.vertices;
        vigMesh.vertexStream = tMD.vertexStream;
        vigMesh.normalStream = tMD.normalStream;
        vigMesh.faces = (ushort)tMD.faces;
        vigMesh.faceStream = tMD.faceStream;
        byte dAT_ = tMD.DAT_18;
        vigMesh.DAT_02 = 0;
        vigMesh.DAT_01 = dAT_;
        ushort dAT_1A = tMD.DAT_1A;
        dAT_ = tMD.DAT_18;
        vigMesh.DAT_14 = null;
        vigMesh.DAT_18 = (uint)(dAT_1A << 16 - dAT_);
        if ((tMD.flag & 0x4000) == 0)
        {
            FUN_1F6AC(tMD);
        }
        vigMesh.Initialize2();
        return vigMesh;
    }
}
