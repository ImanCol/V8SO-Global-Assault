//Falta por Actualizar
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IMP_OBJ
{
    public static bool LoadAsset(string assetPath)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
        {
            if (reader == null) return false;

            LevelManager levelManager = GameObject.FindObjectOfType<LevelManager>();

            levelManager.objData.Add(new OBJ(reader.ReadBytes((int)reader.BaseStream.Length)));
#if UNITY_EDITOR
            EditorUtility.SetDirty(levelManager);
#endif
        }
        return true;
    }

    //FUN_34F8 (LOAD.DLL)
    public static VigObject LoadOBJ(byte[] obj)
    {
        using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(obj), Encoding.Default, leaveOpen: true))
        {
            string a = new string(binaryReader.ReadChars(4));
            VigObject vigObject = null;
            if (a == "OBJ " && binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
            {
                while (binaryReader.BaseStream.Length - binaryReader.BaseStream.Position >= 8)
                {
                    binaryReader.BaseStream.Seek(binaryReader.BaseStream.Position % 2, SeekOrigin.Current);
                    string a2 = new string(binaryReader.ReadChars(4));
                    int size = binaryReader.ReadInt32BE();
                    if (a2 == "HEAD")
                    {
                        vigObject = LoadHEAD(binaryReader, size);
                    }
                    else if (a2 == "BSPI" && vigObject != null)
                    {
                        LoadBSPI(vigObject, binaryReader);
                    }
                    else if (a2 == "LGHT" && vigObject != null)
                    {
                        LoadLGHT(vigObject, binaryReader);
                    }
                    else if (a2 == "STRN" && vigObject != null)
                    {
                        LoadSTRN(vigObject, binaryReader);
                    }
                    if (binaryReader.BaseStream.Position == binaryReader.BaseStream.Length)
                    {
                        break;
                    }
                }
            }
            return vigObject;
        }
    }

    //FUN_2CF0 (LOAD.DLL)
    private static VigObject LoadHEAD(BinaryReader reader, int size)
    {
        LevelManager levelManager = GameManager.instance.levelManager;
        long position = reader.BaseStream.Position;
        int num = (int)reader.ReadByte();
        uint num2 = (uint)reader.ReadByte();
        short num3 = reader.ReadInt16BE();
        uint num4 = reader.ReadUInt32BE();
        uint num5 = num4 & 4294731774U;
        Vector3Int vector3Int = default(Vector3Int);
        vector3Int.x = reader.ReadInt32BE();
        int num6 = reader.ReadInt32BE();
        vector3Int.y = num6 - 1048576;
        vector3Int.z = reader.ReadInt32BE();
        Vector3Int vector3Int2 = default(Vector3Int);
        short num7 = reader.ReadInt16BE();
        vector3Int2.x = (int)num7;
        short num8 = reader.ReadInt16BE();
        vector3Int2.y = (int)num8;
        vector3Int2.z = (int)reader.ReadInt16BE();
        num6 = (int)(reader.ReadInt16BE() + 42);
        num7 = reader.ReadInt16BE();
        ushort num9 = (ushort)reader.ReadInt32BE();
        string text = new string(reader.ReadChars((int)((long)size - (reader.BaseStream.Position - position))));
        Type type = Utilities.FUN_14E1C(0, text);
        if (type == null)
        {
            if (Utilities.levelTypes == null)
            {
                type = null;
            }
            else
            {
                Debug.Log("Type: Antes " + type);
                type = Utilities.FUN_14DAC(Utilities.levelTypes[0], text); //improvised
                //type = Utilities.FUN_14DAC(Utilities.levelTypes[GameManager.instance.map - 1], text);
                Debug.Log("Type: Despues " + type);
            }
            if (type == null)
            {
                type = typeof(Destructible);
            }
        }
        if ((num4 & 2U) != 0U && num2 != 5U)
        {
            if (GameManager.instance.gameMode >= _GAME_MODE.Versus && GameManager.instance.gameMode < _GAME_MODE.Versus2)
            {
                return null;
            }
            num5 = num4 & 4294731772U;
        }
        if ((num5 & 4U) != 0U && levelManager.xobfList[num6].animations.Length != 0)
        {
            int num10 = (int)GameManager.FUN_2AC5C();
            BinaryReader binaryReader = new BinaryReader(new MemoryStream(levelManager.xobfList[num6].animations), Encoding.Default, true);
            GameManager.instance.timer = (ushort)(-(ushort)(num10 * binaryReader.ReadInt32() >> 15));
        }
        if (6U < num2)
        {
            return null;
        }
        byte b = (byte)num2;
        VigObject vigObject = null;
        switch (num2)
        {
            case 0U:
                vigObject = Utilities.FUN_31D30(type, levelManager.xobfList[num6], num7, (num5 & 4U) << 1);
                if (vigObject == null)
                {
                    return null;
                }
                vigObject.gameObject.name = text;
                Utilities.ParentChildren(vigObject, vigObject);
                vigObject.flags = num5;
                vigObject.type = b;
                vigObject.id = num3;
                vigObject.tags = (sbyte)num;
                vigObject.screen = vector3Int;
                vigObject.vr = vector3Int2;
                vigObject.maxFullHealth = num9;
                vigObject.maxHalfHealth = num9;
                b = (byte)GameManager.FUN_2AC5C();
                vigObject.DAT_19 = b;
                vigObject.ApplyTransformation();
                vigObject.FUN_2D1DC();
                vigObject.FUN_2C958();
                if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
                {
                    if (!type.IsSubclassOf(typeof(VigObject)))
                    {
                        GameManager.instance.networkObjs.Add(vigObject);
                    }
                    else if (type == typeof(Destructible))
                    {
                        GameManager.instance.networkObjs.Add(vigObject);
                    }
                }
                if (!type.IsSubclassOf(typeof(VigObject)))
                {
                    num6 = 0;
                }
                else
                {
                    num6 = (int)vigObject.UpdateW(1, 0);
                }
                if (-1 < num6)
                {
                    if ((vigObject.flags & 8U) != 0U && vigObject.vShadow == null)
                    {
                        vigObject.FUN_4C98C();
                    }
                    if ((vigObject.flags & 4U) != 0U)
                    {
                        GameManager.instance.FUN_30080(GameManager.instance.DAT_10A8, vigObject);
                    }
                    if ((vigObject.flags & 128U) != 0U)
                    {
                        GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, vigObject);
                    }
                    vigObject.FUN_2EC7C();
                    GameManager.instance.FUN_30080(GameManager.instance.interObjs, vigObject);
                    return vigObject;
                }
                goto IL_691;
            case 1U:
                return vigObject;
            case 2U:
            case 3U:
                break;
            case 4U:
                num5 &= 65535U;
                break;
            case 5U:
                vigObject = new GameObject(text).AddComponent(type) as VigObject;
                vigObject.DAT_1A = num7;
                vigObject.flags = num5;
                vigObject.type = b;
                vigObject.id = num3;
                vigObject.tags = (sbyte)num;
                vigObject.vData = levelManager.xobfList[num6];
                vigObject.screen = vector3Int;
                vigObject.vr = vector3Int2;
                vigObject.maxFullHealth = num9;
                vigObject.maxHalfHealth = num9;
                b = (byte)GameManager.FUN_2AC5C();
                vigObject.DAT_19 = b;
                vigObject.ApplyTransformation();
                if (!type.IsSubclassOf(typeof(VigObject)))
                {
                    num6 = 0;
                }
                else
                {
                    num6 = (int)vigObject.UpdateW(1, 1);
                }
                if (-1 < num6)
                {
                    List<VigTuple> dat_ = GameManager.instance.DAT_1078;
                    VigTuple vigTuple = null;
                    int num11 = 0;
                    if (dat_ != null)
                    {
                        for (int i = 0; i < dat_.Count; i++)
                        {
                            vigTuple = dat_[i];
                            if (num3 <= vigTuple.vObject.id)
                            {
                                break;
                            }
                            num11 = i + 1;
                        }
                        if (num11 != dat_.Count)
                        {
                            VigObject vigObject2 = vigTuple.vObject;
                            if (num3 == vigObject2.id)
                            {
                                VigObject vigObject3 = vigObject2.child;
                                while (vigObject3 != null)
                                {
                                    vigObject2 = vigObject2.child;
                                    vigObject3 = vigObject2.child;
                                }
                                vigObject2.child = vigObject;
                                vigObject.parent = vigObject2;
                                return vigObject;
                            }
                        }
                    }
                    GameManager.instance.DAT_1078.Insert(num11, new VigTuple(vigObject, 0U));
                    return vigObject;
                }
                goto IL_691;
            case 6U:
                vigObject = new GameObject(text).AddComponent<VigObject>();
                vigObject.flags = num5;
                vigObject.type = b;
                vigObject.id = num3;
                vigObject.tags = (sbyte)num;
                vigObject.screen = vector3Int;
                vigObject.vr = vector3Int2;
                b = (byte)GameManager.FUN_2AC5C();
                vigObject.DAT_19 = b;
                vigObject.ApplyTransformation();
                GameManager.instance.FUN_30080(LevelManager.instance.levelObjs, vigObject);
                return vigObject;
            default:
                goto IL_691;
        }
        vigObject = Utilities.FUN_31D30(type, levelManager.xobfList[num6], num7, (num5 & 4U) << 1);
        if (vigObject == null)
        {
            return null;
        }
        vigObject.gameObject.name = text;
        Utilities.ParentChildren(vigObject, vigObject);
        vigObject.flags = num5;
        vigObject.type = b;
        vigObject.id = num3;
        vigObject.tags = (sbyte)num;
        vigObject.screen = vector3Int;
        vigObject.vr = vector3Int2;
        VigObject vigObject4 = vigObject.child2;
        vigObject.maxFullHealth = num9;
        vigObject.maxHalfHealth = num9;
        while (vigObject4 != null)
        {
            vigObject4.maxFullHealth = num9;
            vigObject4.maxHalfHealth = num9;
            vigObject4 = vigObject4.child;
        }
        b = (byte)GameManager.FUN_2AC5C();
        vigObject.DAT_19 = b;
        vigObject.FUN_2C958();
        if (vigObject.FUN_3066C())
        {
            return vigObject;
        }
        return null;
    IL_691:
        return null;
    }

    private static void LoadBSPI(VigObject param1, BinaryReader reader)
    {
        VigTuple vigTuple = GameManager.instance.FUN_30134(GameManager.instance.interObjs, param1);
        uint num = reader.ReadUInt32BE();
        vigTuple.flag = (uint)((int)num | int.MinValue);
    }

    private static void LoadLGHT(VigObject param1, BinaryReader reader)
    {
        int x = reader.ReadInt32BE();
        param1.physics1.X = x;
        x = reader.ReadInt32BE();
        param1.physics1.Y = x;
        x = reader.ReadInt32BE();
        param1.physics1.Z = x;
        short m = reader.ReadInt16BE();
        param1.physics1.M6 = m;
        m = reader.ReadInt16BE();
        param1.physics1.M7 = m;
        m = reader.ReadInt16BE();
        param1.physics2.M0 = m;
    }


    private static void LoadSTRN(VigObject param1, BinaryReader reader)
    {
        ushort num = (ushort)reader.ReadInt32BE();
        ushort maxFullHealth;
        if (reader.BaseStream.Length < 5)
        {
            param1.maxHalfHealth = num;
            maxFullHealth = num;
        }
        else
        {
            maxFullHealth = (ushort)reader.ReadInt32BE();
            param1.maxHalfHealth = num;
        }
        param1.maxFullHealth = maxFullHealth;
        VigObject vigObject = param1.child2;
        while (vigObject != null)
        {
            if (vigObject.maxHalfHealth == 0)
            {
                vigObject.maxHalfHealth = num;
            }
            vigObject = vigObject.child;
        }
    }
}
