using System.IO;
using System.Text;
using UnityEngine;

public class IMP_XBMP
{
	public static void LoadAsset(string assetPath, string savePath)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			LevelManager levelManager = Object.FindObjectOfType<LevelManager>();
			string str = savePath;
			int num = 0;
			int num2 = 0;
			levelManager.DAT_DF8 = new Material[16];
			long position = binaryReader.BaseStream.Position;
			Utilities.SetFarColor(levelManager.DAT_DDC.r, levelManager.DAT_DDC.g, levelManager.DAT_DDC.b);
			if (savePath.StartsWith(Application.dataPath))
			{
				str = "Assets" + savePath.Substring(Application.dataPath.Length);
			}
			do
			{
				binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);
				MemoryStream memoryStream = new MemoryStream();
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Default, leaveOpen: true))
				{
					binaryWriter.Write(binaryReader.ReadBytes(16));
					int num3 = binaryReader.ReadInt16();
					binaryWriter.Write((short)num3);
					binaryWriter.Write(binaryReader.ReadInt16());
					Utilities.FUN_18C54(binaryReader, num3, binaryWriter, num2);
					binaryWriter.Write(binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position)));
					binaryWriter.BaseStream.Seek(4L, SeekOrigin.Begin);
				}
				using (BinaryReader reader = new BinaryReader(memoryStream, Encoding.Default, leaveOpen: true))
				{
					string path = savePath + "/XBMP_FAR" + num.ToString().PadLeft(2, '0') + ".bmp";
					string text = str + "/XBMP_FAR" + num.ToString().PadLeft(2, '0') + ".bmp";
					string text2 = str + "/XBMP_FAR" + num.ToString().PadLeft(2, '0') + ".mat";
					IMP_TIM.LoadTIM(reader, path);
					Material material = null;
					levelManager.DAT_DF8[num] = material;
				}
				num++;
				num2 += 256;
			}
			while (num < 16);
		}
	}
}
