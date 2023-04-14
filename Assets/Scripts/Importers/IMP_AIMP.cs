using System.IO;
using UnityEngine;

public class IMP_AIMP
{
	public static void LoadAsset(string assetPath)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			LevelManager levelManager = Object.FindObjectOfType<LevelManager>();
			levelManager.aimpSize = (int)binaryReader.BaseStream.Length;
			levelManager.aimpData = new ushort[levelManager.aimpSize / 2];
			int num = 0;
			while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
			{
				levelManager.aimpData[num++] = binaryReader.ReadUInt16();
			}
		}
	}
}
