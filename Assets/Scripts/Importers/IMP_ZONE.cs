using System.IO;
using UnityEngine;

public class IMP_ZONE
{
	public static void LoadAsset(string assetPath)
	{
		VigTerrain vigTerrain = Object.FindObjectOfType<VigTerrain>();
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(assetPath);
		int num = fileNameWithoutExtension[4] - 48 + (fileNameWithoutExtension[5] - 48) + (fileNameWithoutExtension[6] - 48) + (fileNameWithoutExtension[7] - 48);
		num++;
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			int num2 = 0;
			do
			{
				int num3 = 0;
				int num4 = num2 << 6;
				long num5 = binaryReader.BaseStream.Position + 3;
				do
				{
					ushort num6 = binaryReader.ReadUInt16(0);
					int num7 = num3 + num2 * 64;
					num3++;
					vigTerrain.vertices[num * 4096 + num4] = (ushort)((((num6 >> 8) | (ushort)((num6 & 0xFF) << 8)) - 512) | ((ushort)((uint)binaryReader.ReadByte(2) >> 3) << 11));
					byte b = binaryReader.ReadByte(3);
					num5 += 4;
					binaryReader.BaseStream.Seek(4L, SeekOrigin.Current);
					vigTerrain.tiles[num * 4096 + num7] = b;
					num4++;
				}
				while (num3 < 64);
				num2++;
			}
			while (num2 < 64);
		}
	}
}
