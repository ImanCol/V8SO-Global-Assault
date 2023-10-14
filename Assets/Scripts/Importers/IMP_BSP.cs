using System.IO;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IMP_BSP
{
    public static void LoadAsset(string assetPath)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
        {
            LevelManager levelManager = GameObject.FindObjectOfType<LevelManager>();

            levelManager.bspData = reader.ReadBytes((int)reader.BaseStream.Length);
#if UNITY_EDITOR
            EditorUtility.SetDirty(levelManager);
#endif
        }
    }

    //FUN_2BB4 (LOAD.DLL)
    public static void LoadData(byte[] bytes)
    {
        MemoryStream stream = new MemoryStream(bytes);

        using (BinaryReader reader = new BinaryReader(stream, Encoding.Default, true))
        {
            GameManager.instance.bspTree = FUN_26F0(reader);
        }
    }

    //FUN_26F0 (LOAD.DLL)
    private static BSP FUN_26F0(BinaryReader reader)
    {
        int num = reader.ReadUInt16BE();
        BSP bSP;
        if (num == 0)
        {
            bSP = new BSP();
            bSP.LDAT_04 = new List<VigTuple>();
            bSP.DAT_00 = 0; //not sure
            bSP.DAT_08 = null; //not sure
        }
        else
        {
            bSP = new BSP();
            bSP.DAT_00 = num;
            num = (bSP.DAT_04 = reader.ReadInt32BE());
            BSP bSP2 = bSP.DAT_08 = FUN_26F0(reader);
            bSP2 = (bSP.DAT_0C = FUN_26F0(reader));
        }
        return bSP;
    }
}