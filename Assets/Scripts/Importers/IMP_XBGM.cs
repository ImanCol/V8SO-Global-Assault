using System.IO;
using UnityEngine;

public class IMP_XBGM
{
	public static void LoadAsset(string assetPath, string savePath)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			LevelManager levelManager = Object.FindObjectOfType<LevelManager>();
			Object.FindObjectOfType<VigTerrain>();
			string str = savePath;
			if (savePath.StartsWith(Application.dataPath))
			{
				str = "Assets" + savePath.Substring(Application.dataPath.Length);
			}
			int num = binaryReader.ReadInt32BE();
			binaryReader.ReadInt32();
			string path = savePath + "/XBGM" + 0.ToString().PadLeft(2, '0') + ".bmp";
			string text = str + "/XBGM" + 0.ToString().PadLeft(2, '0') + ".bmp";
			string text2 = str + "/XBGM" + 0.ToString().PadLeft(2, '0') + ".mat";
			IMP_TIM.LoadTIM(binaryReader, path);
			Material material = levelManager.DAT_DD0 = null;
			levelManager.DAT_6398A = (short)(num << 4);
			levelManager.DAT_63972 = (short)((num - levelManager.DAT_DD0.mainTexture.height) * 16);
			levelManager.DAT_6397A = levelManager.DAT_63972;
			levelManager.DAT_63982 = levelManager.DAT_63972;
			levelManager.DAT_63992 = levelManager.DAT_6398A;
			levelManager.DAT_6399A = levelManager.DAT_6398A;
			if (levelManager.DAT_E48 == null)
			{
				levelManager.DAT_E48 = levelManager.DAT_DD0;
			}
		}
	}
}
