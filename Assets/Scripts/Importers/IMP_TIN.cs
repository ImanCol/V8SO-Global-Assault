using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class IMP_TIN
{
	public static void LoadAsset(string assetPath)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			LevelManager levelManager = Object.FindObjectOfType<LevelManager>();
			VigTerrain vigTerrain = Object.FindObjectOfType<VigTerrain>();
			byte[] array = new byte[64]
			{
				0,
				31,
				31,
				31,
				0,
				0,
				31,
				0,
				31,
				31,
				0,
				31,
				31,
				0,
				0,
				0,
				0,
				0,
				0,
				31,
				31,
				0,
				31,
				31,
				0,
				31,
				0,
				0,
				31,
				31,
				31,
				0,
				31,
				0,
				0,
				0,
				31,
				31,
				0,
				31,
				0,
				0,
				31,
				0,
				0,
				31,
				31,
				31,
				31,
				31,
				31,
				0,
				0,
				31,
				0,
				0,
				31,
				0,
				31,
				31,
				0,
				0,
				0,
				31
			};
			int num = 0;
			if (vigTerrain.tileData == null)
			{
				vigTerrain.tileData = new List<TileData>();
			}
			vigTerrain.tileData.Clear();
			do
			{
				int num2 = 0;
				int num3 = num << 3;
				do
				{
					sbyte b = (sbyte)((array[num3] != 0) ? ((sbyte)((byte)levelManager.DAT_DBA - 1)) : 0);
					array[num3] = (byte)b;
					b = (sbyte)((array[num3 + 1] != 0) ? ((sbyte)((byte)levelManager.DAT_DBA - 1)) : 0);
					array[num3 + 1] = (byte)b;
					num2++;
					num3 += 2;
				}
				while (num2 < 4);
				num++;
			}
			while (num < 8);
			int num4 = (int)(binaryReader.BaseStream.Position + 34);
			num = 0;
			do
			{
				uint num5 = (uint)((binaryReader.ReadByte(num4 - 32) & 0xF) * (ushort)levelManager.DAT_DBA);
				short num6 = (short)(((uint)binaryReader.ReadByte(num4 - 32) >> 4) * (ushort)levelManager.DAT_DBA);
				byte b2 = binaryReader.ReadByte(num4 - 31);
				int num3 = (b2 & 7) * 8;
				ushort num7 = (ushort)(num5 & 0x7F);
				ushort num8 = binaryReader.ReadUInt16(num4 - 34);
				TileData tileData = new TileData();
				vigTerrain.tileData.Add(tileData);
				tileData.uv1_x = array[num3] + num7;
				tileData.uv1_y = array[num3 + 1] + num6;
				tileData.uv2_x = array[num3 + 2] + num7;
				tileData.uv2_y = array[num3 + 3] + num6;
				tileData.uv3_x = array[num3 + 4] + num7;
				tileData.uv3_y = array[num3 + 5] + num6;
				tileData.uv4_x = array[num3 + 6] + num7;
				tileData.uv4_y = array[num3 + 7] + num6;
				uint num9;
				if (((num8 >> 8) & 0x10) == 0)
				{
					num9 = num5 >> 7 << (vigTerrain.bitmapID & 3) + 5;
					num9 = num9 / 64u * 128;
					tileData.uv4_x += (int)num9;
				}
				else
				{
					num9 = 0u;
				}
				int num2 = 0;
				tileData.flags = (byte)(((byte)((uint)num8 >> 12) & 1) | (byte)((uint)(b2 & 0x18) >> 2));
				tileData.uv3_x += (int)num9;
				tileData.uv2_x += (int)num9;
				tileData.uv1_x += (int)num9;
				int num10 = num4 - 34;
				tileData.DAT_10 = new short[6];
				do
				{
					int offset = num10 + 4;
					num10 += 2;
					tileData.DAT_10[num2] = (short)((int)((uint)binaryReader.ReadUInt16(offset) >> 8) | ((binaryReader.ReadUInt16(offset) & 0xFF) << 8));
					num2++;
				}
				while (num2 < 6);
				num += 32;
				tileData.DAT_1C = binaryReader.ReadByte(num4 - 2);
				tileData.DAT_1D = binaryReader.ReadByte(num4 - 1);
				tileData.DAT_1E = binaryReader.ReadByte(num4);
				num4 += 36;
			}
			while (num < 8192);
		}
	}
}
