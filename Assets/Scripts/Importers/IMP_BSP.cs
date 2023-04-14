using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class IMP_BSP
{
	public static void LoadAsset(string assetPath)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			Object.FindObjectOfType<LevelManager>().bspData = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
		}
	}

	public static void LoadData(byte[] bytes)
	{
		using (BinaryReader reader = new BinaryReader(new MemoryStream(bytes), Encoding.Default, leaveOpen: true))
		{
			GameManager.instance.bspTree = FUN_26F0(reader);
		}
	}

	private static BSP FUN_26F0(BinaryReader reader)
	{
		int num = reader.ReadUInt16BE();
		BSP bSP;
		if (num == 0)
		{
			bSP = new BSP();
			bSP.LDAT_04 = new List<VigTuple>();
			bSP.DAT_00 = 0;
			bSP.DAT_08 = null;
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
