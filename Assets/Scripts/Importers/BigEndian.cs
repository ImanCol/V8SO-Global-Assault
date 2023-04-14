using System;
using System.IO;

public static class BigEndian
{
	public static byte[] Reverse(this byte[] b)
	{
		Array.Reverse(b);
		return b;
	}

	public static ushort ReadUInt16BE(this BinaryReader binRdr)
	{
		return BitConverter.ToUInt16(binRdr.ReadBytesRequired(2).Reverse(), 0);
	}

	public static short ReadInt16BE(this BinaryReader binRdr)
	{
		return BitConverter.ToInt16(binRdr.ReadBytesRequired(2).Reverse(), 0);
	}

	public static uint ReadUInt32BE(this BinaryReader binRdr)
	{
		return BitConverter.ToUInt32(binRdr.ReadBytesRequired(4).Reverse(), 0);
	}

	public static int ReadInt32BE(this BinaryReader binRdr)
	{
		return BitConverter.ToInt32(binRdr.ReadBytesRequired(4).Reverse(), 0);
	}

	public static byte[] ReadBytesRequired(this BinaryReader binRdr, int byteCount)
	{
		byte[] array = binRdr.ReadBytes(byteCount);
		if (array.Length != byteCount)
		{
			throw new EndOfStreamException($"{byteCount} bytes required from stream, but only {array.Length} returned.");
		}
		return array;
	}
}
