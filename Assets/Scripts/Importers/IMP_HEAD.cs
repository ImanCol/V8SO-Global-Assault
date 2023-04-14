using System.IO;
using UnityEngine;

public class IMP_HEAD
{
	public static void LoadAsset(string assetPath)
	{
		LevelManager levelManager = Object.FindObjectOfType<LevelManager>();
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			ushort num = binaryReader.ReadUInt16BE();
			ushort param = binaryReader.ReadUInt16BE();
			ushort param2 = binaryReader.ReadUInt16BE();
			binaryReader.ReadUInt16BE();
			binaryReader.ReadUInt16BE();
			int num2 = (int)(binaryReader.BaseStream.Length - 10) / 2;
			if (0 < num2)
			{
				levelManager.DAT_C18 = new ushort[num2];
				for (int i = 0; i < num2; i++)
				{
					ushort num3 = binaryReader.ReadUInt16BE();
					levelManager.DAT_C18[i] = num3;
				}
			}
			levelManager.DAT_DBA = (short)num;
			FUN_508AC(param, param2);
		}
	}

	private static void FUN_508AC(int param1, int param2)
	{
		LevelManager levelManager = Object.FindObjectOfType<LevelManager>();
		levelManager.DAT_118C = 0;
		levelManager.DAT_1180 = param1;
		levelManager.DAT_1184 = param2;
	}
}
