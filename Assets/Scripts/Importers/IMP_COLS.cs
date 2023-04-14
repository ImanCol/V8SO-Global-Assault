using System.IO;
using UnityEngine;

public class IMP_COLS
{
	public static void LoadAsset(string assetPath)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			LevelManager levelManager = Object.FindObjectOfType<LevelManager>();
			VigTerrain vigTerrain = Object.FindObjectOfType<VigTerrain>();
			int num = 0;
			long num2 = -2078209981L;
			levelManager.DAT_E08 = new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte());
			levelManager.DAT_DA4 = new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte());
			levelManager.DAT_DDC = new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), 48);
			binaryReader.BaseStream.Seek(1L, SeekOrigin.Current);
			levelManager.DAT_E04 = new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte());
			Color32[] dAT_B = vigTerrain.DAT_B9370;
			levelManager.DAT_DAC = new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte());
			levelManager.DAT_DBC = new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte());
			levelManager.DAT_D98 = new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte());
			levelManager.DAT_DE0 = new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte());
			do
			{
				int num3 = (levelManager.DAT_DAC.r - levelManager.DAT_E04.r) * num;
				int num4 = (int)(num3 * num2 >> 32) + num3 >> 4;
				num4 -= num3 >> 31;
				num4 = num4 + levelManager.DAT_E04.r + (num3 >> 31 << 31);
				dAT_B[num].r = (byte)(num4 >> 1);
				num3 = (levelManager.DAT_DAC.g - levelManager.DAT_E04.g) * num;
				num4 = (int)(num3 * num2 >> 32) + num3 >> 4;
				num4 -= num3 >> 31;
				num4 = num4 + levelManager.DAT_E04.g + (num3 >> 31 << 31);
				dAT_B[num].g = (byte)(num4 >> 1);
				num3 = (levelManager.DAT_DAC.b - levelManager.DAT_E04.b) * num;
				num4 = (int)(num3 * num2 >> 32) + num3 >> 4;
				num4 -= num3 >> 31;
				num4 = num4 + levelManager.DAT_E04.b + (num3 >> 31 << 31);
				dAT_B[num].b = (byte)(num4 >> 1);
				dAT_B[num].a = 0;
				num++;
			}
			while (num < 32);
			levelManager.DAT_738 = new Matrix3x3
			{
				V00 = (short)((levelManager.DAT_DAC.r - levelManager.DAT_E04.r) * 16),
				V01 = 0,
				V02 = 0,
				V10 = (short)((levelManager.DAT_DAC.g - levelManager.DAT_E04.g) * 16),
				V11 = 0,
				V12 = 0,
				V20 = (short)((levelManager.DAT_DAC.b - levelManager.DAT_E04.b) * 16),
				V21 = 0,
				V22 = 0
			};
			vigTerrain.DAT_B9314 = new Color32[2]
			{
				levelManager.DAT_E08,
				levelManager.DAT_E08
			};
			vigTerrain.DAT_B932C = new Color32[2]
			{
				levelManager.DAT_DA4,
				levelManager.DAT_DA4
			};
		}
	}
}
