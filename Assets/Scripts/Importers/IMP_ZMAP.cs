using System.IO;
using UnityEngine;

public class IMP_ZMAP
{
	public static void LoadAsset(string assetPath)
	{
		VigTerrain vigTerrain = Object.FindObjectOfType<VigTerrain>();
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			vigTerrain.chunks = new ushort[1024];
			int num = 0;
			int num2 = 4194304;
			vigTerrain.DAT_DEC = 134217728;
			vigTerrain.DAT_DE4 = 134217728;
			vigTerrain.DAT_DE8 = 0;
			vigTerrain.DAT_DF0 = 0;
			do
			{
				int num3 = 0;
				uint num4 = 4194304u;
				int num5 = num << 2;
				do
				{
					uint num6 = binaryReader.ReadUInt16();
					uint num7 = num6 >> 8;
					num6 = (num6 & 0xFF) << 8;
					num7 |= num6;
					num6 = num7 << 2;
					int num8 = (int)num7;
					vigTerrain.chunks[num5 / 4] = (ushort)num8;
					if (num7 != 0)
					{
						num7 = (uint)(num3 << 22);
						if (vigTerrain.DAT_DE4 < num7)
						{
							num7 = (uint)vigTerrain.DAT_DE4;
						}
						vigTerrain.DAT_DE4 = (int)num7;
						int dAT_DE = (int)num4;
						if (num4 < vigTerrain.DAT_DE8)
						{
							dAT_DE = vigTerrain.DAT_DE8;
						}
						vigTerrain.DAT_DE8 = dAT_DE;
						num7 = (uint)(num << 22);
						if (vigTerrain.DAT_DEC < num7)
						{
							num7 = (uint)vigTerrain.DAT_DEC;
						}
						vigTerrain.DAT_DEC = (int)num7;
						dAT_DE = num2;
						if (num2 < vigTerrain.DAT_DF0)
						{
							dAT_DE = vigTerrain.DAT_DF0;
						}
						vigTerrain.DAT_DF0 = dAT_DE;
					}
					uint num9 = 4194304u;
					num4 += num9;
					num3++;
					num5 += 128;
				}
				while (num3 < 32);
				num++;
				num2 += 4194304;
			}
			while (num < 32);
		}
	}
}
