using System.IO;

public class IMP_CAR
{
	public static void LoadAsset(string assetPath, string bmp)
	{
		Path.GetFileName(assetPath);
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			binaryReader.BaseStream.Seek(16L, SeekOrigin.Begin);
			int num = binaryReader.ReadInt32();
			binaryReader.BaseStream.Seek(num, SeekOrigin.Begin);
			binaryReader.ReadInt32();
			int num2 = binaryReader.ReadInt16();
			int num3 = binaryReader.ReadInt16();
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(bmp, FileMode.Create)))
			{
				binaryWriter.Write((short)19778);
				binaryWriter.Write(num2 * num3 * 4 + 56);
				binaryWriter.Write((short)0);
				binaryWriter.Write((short)0);
				binaryWriter.Write(54);
				binaryWriter.Write(40);
				binaryWriter.Write(num2);
				binaryWriter.Write(num3);
				binaryWriter.Write(2097153);
				binaryWriter.Write(0L);
				binaryWriter.Write(2834);
				binaryWriter.Write(2834);
				binaryWriter.Write(0L);
				ushort num4 = 31744;
				ushort num5 = 992;
				ushort num6 = 31;
				for (int i = 0; i < num2 * num3; i++)
				{
					ushort num7 = binaryReader.ReadUInt16();
					byte b = (byte)((num7 & num4) >> 10);
					byte b2 = (byte)((num7 & num5) >> 5);
					byte num8 = (byte)(num7 & num6);
					byte b3 = (byte)(b << 3);
					byte b4 = (byte)(b2 << 3);
					byte b5 = (byte)(num8 << 3);
					byte b6 = byte.MaxValue;
					b6 = (byte)((num7 >> 15 != 0) ? ((b3 != 0 || b4 != 0 || b5 != 0) ? byte.MaxValue : byte.MaxValue) : ((b3 != 0 || b4 != 0 || b5 != 0) ? byte.MaxValue : 0));
					binaryWriter.Write(b3);
					binaryWriter.Write(b4);
					binaryWriter.Write(b5);
					binaryWriter.Write(b6);
				}
				binaryWriter.Write((short)0);
			}
		}
	}
}
