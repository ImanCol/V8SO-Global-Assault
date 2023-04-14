using System.IO;
using UnityEngine;

public class IMP_TEXT
{
	public static void LoadAsset(string assetPath)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			Object.FindObjectOfType<LevelManager>().desc = new string(binaryReader.ReadChars((int)binaryReader.BaseStream.Length - 1));
		}
	}
}
