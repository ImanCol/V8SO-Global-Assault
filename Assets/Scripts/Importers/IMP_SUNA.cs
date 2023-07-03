using System.IO;
using UnityEngine;

public class IMP_SUNA
{
	public static void LoadAsset(string assetPath)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			LevelManager levelManager = Object.FindObjectOfType<LevelManager>();
			uint num = (uint)((binaryReader.BaseStream.Length >= 13) ? ((int)((uint)binaryReader.ReadUInt16(12) >> 8) | (binaryReader.ReadByte(12) << 8)) : 4096);
			int num2 = ((int)((uint)binaryReader.ReadUInt16(0) >> 8) | ((binaryReader.ReadUInt16(0) & 0xF) << 8)) * 2;
			int num3 = ((int)((uint)binaryReader.ReadUInt16(2) >> 8) | ((binaryReader.ReadUInt16(2) & 0xF) << 8)) * 2;
			int num4 = Utilities.DAT_65C90[num2 + 1];
			int num5 = Utilities.DAT_65C90[num3] * num4;
			if (num5 < 0)
			{
				num5 += 4095;
			}
			num5 = (num5 >> 12) * (int)num;
			if (num5 < 0)
			{
				num5 += 4095;
			}
			num2 = -Utilities.DAT_65C90[num2] * (int)num;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			num4 = Utilities.DAT_65C90[num3 + 1] * num4;
			if (num4 < 0)
			{
				num4 += 4095;
			}
			num3 = (num4 >> 12) * (int)num;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			levelManager.DAT_10F8 = new Vector3Int(num5 >> 12, num2 >> 12, num3 >> 12);
		}
	}
}
