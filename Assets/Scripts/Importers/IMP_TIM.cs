using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

public static class IMP_TIM
{
	private struct RECT
	{
		public short x;

		public short y;

		public short w;

		public short h;
	}

	private struct RGB
	{
		public byte r;

		public byte g;

		public byte b;

		public byte a;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass15_0
	{
		public BinaryReader reader;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass15_1
	{
		public ushort[] fastRam;

		public short[] m_scale_table;

		public short[,] m_blocks;

		public uint[] m_block_rgb;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass15_2
	{
		public BinaryWriter writer;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass15_3
	{
		public uint uVar1;

		public uint uVar3;

		public int iVar6;

		public uint uVar4;

		public int iVar7;

		public uint uVar5;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass15_4
	{
		public BinaryReader reader2;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass15_5
	{
		public int m_current_coefficient;

		public int m_current_block;

		public int m_remaining_halfwords;

		public ushort m_current_q_scale;
	}

	private static int LZCS = 0;

	private static int LZCR = 0;

	private static uint FLAG = 0u;

	private static long POS_CLUT_RECT = 0L;

	private static long POS_CLUT_COLORS = 0L;

	private static long POS_IMG_RECT = 0L;

	private static long POS_IMG_INDICES = 0L;

	private static long POS_IMG_INDICES2 = 0L;

	private static readonly int NUM_BLOCKS = 6;

	private static readonly byte[] BYTES = new byte[214]
	{
		7,
		1,
		6,
		1,
		1,
		2,
		5,
		1,
		2,
		2,
		9,
		1,
		0,
		4,
		8,
		1,
		16,
		1,
		5,
		2,
		0,
		7,
		2,
		3,
		1,
		4,
		15,
		1,
		14,
		1,
		4,
		2,
		0,
		11,
		8,
		2,
		4,
		3,
		0,
		10,
		2,
		4,
		7,
		2,
		21,
		1,
		20,
		1,
		0,
		9,
		19,
		1,
		18,
		1,
		1,
		5,
		3,
		3,
		0,
		8,
		6,
		2,
		17,
		1,
		10,
		2,
		9,
		2,
		5,
		3,
		3,
		4,
		2,
		5,
		1,
		7,
		1,
		6,
		0,
		15,
		0,
		14,
		0,
		13,
		0,
		12,
		26,
		1,
		25,
		1,
		24,
		1,
		23,
		1,
		22,
		1,
		0,
		31,
		0,
		30,
		0,
		29,
		0,
		28,
		0,
		27,
		0,
		26,
		0,
		25,
		0,
		24,
		0,
		23,
		0,
		22,
		0,
		21,
		0,
		20,
		0,
		19,
		0,
		18,
		0,
		17,
		0,
		16,
		0,
		40,
		0,
		39,
		0,
		38,
		0,
		37,
		0,
		36,
		0,
		35,
		0,
		34,
		0,
		33,
		0,
		32,
		1,
		14,
		1,
		13,
		1,
		12,
		1,
		11,
		1,
		10,
		1,
		9,
		1,
		8,
		1,
		18,
		1,
		17,
		1,
		16,
		1,
		15,
		6,
		3,
		16,
		2,
		15,
		2,
		14,
		2,
		13,
		2,
		12,
		2,
		11,
		2,
		31,
		1,
		30,
		1,
		29,
		1,
		28,
		1,
		27,
		1,
		13,
		1,
		0,
		6,
		12,
		1,
		11,
		1,
		3,
		2,
		1,
		3,
		0,
		5,
		10,
		1,
		0,
		3,
		4,
		1,
		3,
		1
	};

	private static readonly byte[] QUANT_TABLE = new byte[128]
	{
		2,
		16,
		16,
		19,
		16,
		19,
		22,
		22,
		22,
		22,
		22,
		22,
		26,
		24,
		26,
		27,
		27,
		27,
		26,
		26,
		26,
		26,
		27,
		27,
		27,
		29,
		29,
		29,
		34,
		34,
		34,
		29,
		29,
		29,
		27,
		27,
		29,
		29,
		32,
		32,
		34,
		34,
		37,
		38,
		37,
		35,
		35,
		34,
		35,
		38,
		38,
		40,
		40,
		40,
		48,
		48,
		46,
		46,
		56,
		56,
		58,
		69,
		69,
		83,
		2,
		16,
		16,
		19,
		16,
		19,
		22,
		22,
		22,
		22,
		22,
		22,
		26,
		24,
		26,
		27,
		27,
		27,
		26,
		26,
		26,
		26,
		27,
		27,
		27,
		29,
		29,
		29,
		34,
		34,
		34,
		29,
		29,
		29,
		27,
		27,
		29,
		29,
		32,
		32,
		34,
		34,
		37,
		38,
		37,
		35,
		35,
		34,
		35,
		38,
		38,
		40,
		40,
		40,
		48,
		48,
		46,
		46,
		56,
		56,
		58,
		69,
		69,
		83
	};

	private static readonly ushort[] SCALE_TABLE = new ushort[64]
	{
		23170,
		23170,
		23170,
		23170,
		23170,
		23170,
		23170,
		23170,
		32138,
		27245,
		18204,
		6392,
		59143,
		47331,
		38290,
		33397,
		30273,
		12539,
		52996,
		35262,
		35262,
		52996,
		12539,
		30273,
		27245,
		59143,
		33397,
		47331,
		18204,
		32138,
		6392,
		38290,
		23170,
		42365,
		42365,
		23170,
		23170,
		42365,
		42365,
		23170,
		18204,
		33397,
		6392,
		27245,
		38290,
		59143,
		32138,
		47331,
		12539,
		35262,
		30273,
		52996,
		52996,
		30273,
		35262,
		12539,
		6392,
		47331,
		27245,
		33397,
		32138,
		38290,
		18204,
		59143
	};

	private static readonly byte[] ZAGZIG = new byte[64]
	{
		0,
		1,
		8,
		16,
		9,
		2,
		3,
		10,
		17,
		24,
		32,
		25,
		18,
		11,
		4,
		5,
		12,
		19,
		26,
		33,
		40,
		48,
		41,
		34,
		27,
		20,
		13,
		6,
		7,
		14,
		21,
		28,
		35,
		42,
		49,
		56,
		57,
		50,
		43,
		36,
		29,
		22,
		15,
		23,
		30,
		37,
		44,
		51,
		58,
		59,
		52,
		45,
		38,
		31,
		39,
		46,
		53,
		60,
		61,
		54,
		47,
		55,
		62,
		63
	};

	public static void LoadAsset(string assetPath, string bmp)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		_003C_003Ec__DisplayClass15_.reader = new BinaryReader(File.Open(assetPath, FileMode.Open));
		try
		{
			int num = _003C_003Ec__DisplayClass15_.reader.ReadInt32();
			if (num >> 24 == 8)
			{
				LoadTIM(_003C_003Ec__DisplayClass15_.reader, bmp);
			}
			else if (num != 16)
			{
				_003C_003Ec__DisplayClass15_.reader.BaseStream.Seek(0L, SeekOrigin.Begin);
				short num2 = _003C_003Ec__DisplayClass15_.reader.ReadInt16();
				short num3 = _003C_003Ec__DisplayClass15_.reader.ReadInt16();
				long offset = _003C_003Ec__DisplayClass15_.reader.BaseStream.Position;
				int num4 = _003C_003Ec__DisplayClass15_.reader.ReadInt32();
				int num5 = 0;
				if (num4 == 16)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(bmp);
					string path = bmp.Replace(fileNameWithoutExtension, fileNameWithoutExtension + "_1");
					LoadTIM(_003C_003Ec__DisplayClass15_.reader, path);
					offset = POS_IMG_INDICES2;
					num5 |= 0xA;
				}
				_003C_003Ec__DisplayClass15_.reader.BaseStream.Seek(offset, SeekOrigin.Begin);
				RECT rECT = default(RECT);
				rECT.x = 0;
				rECT.y = 0;
				rECT.w = num2;
				rECT.h = num3;
				RECT rECT2 = rECT;
				int num6 = num5 & 1;
				int num7 = num6 + 2;
				int num8 = (rECT2.h + 15) & -16;
				int num9 = num7 * 16;
				num9 = num8 * num9;
				int num10 = 0;
				int num11 = 0;
				byte[] array = new byte[64];
				byte[] array2 = new byte[64];
				_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_2 = default(_003C_003Ec__DisplayClass15_1);
				_003C_003Ec__DisplayClass15_2.m_scale_table = new short[SCALE_TABLE.Length];
				for (int i = 0; i < _003C_003Ec__DisplayClass15_2.m_scale_table.Length; i++)
				{
					_003C_003Ec__DisplayClass15_2.m_scale_table[i] = (short)SCALE_TABLE[i];
				}
				int num12 = 0;
				int num13 = 0;
				new Queue<ushort>();
				Queue<uint> queue = new Queue<uint>();
				_003C_003Ec__DisplayClass15_2.m_blocks = new short[NUM_BLOCKS, 64];
				_003C_003Ec__DisplayClass15_2.m_block_rgb = new uint[256];
				for (int j = 0; j < 64; j++)
				{
					array[j] = QUANT_TABLE[j];
					array2[j] = QUANT_TABLE[j + 64];
				}
				_003C_003Ec__DisplayClass15_2.fastRam = new ushort[214];
				for (int k = 0; k < _003C_003Ec__DisplayClass15_2.fastRam.Length; k += 2)
				{
					int num14 = BYTES[k] << 10;
					int num15 = num14 | BYTES[k + 1];
					int num16 = num14 | ((num15 * -1) & 0x3FF);
					_003C_003Ec__DisplayClass15_2.fastRam[k] = (ushort)num15;
					_003C_003Ec__DisplayClass15_2.fastRam[k + 1] = (ushort)num16;
				}
				using (MemoryStream memoryStream = new MemoryStream())
				{
					_003C_003Ec__DisplayClass15_2 _003C_003Ec__DisplayClass15_3 = default(_003C_003Ec__DisplayClass15_2);
					_003C_003Ec__DisplayClass15_3.writer = new BinaryWriter(memoryStream, Encoding.Default, leaveOpen: true);
					try
					{
						_003C_003Ec__DisplayClass15_3 _003C_003Ec__DisplayClass15_4 = default(_003C_003Ec__DisplayClass15_3);
						_003C_003Ec__DisplayClass15_4.uVar1 = _003C_003Ec__DisplayClass15_.reader.ReadUInt32();
						uint num17 = _003C_003Ec__DisplayClass15_.reader.ReadUInt32();
						_003C_003Ec__DisplayClass15_4.uVar3 = _003C_003Ec__DisplayClass15_.reader.ReadUInt32();
						_003C_003Ec__DisplayClass15_4.uVar4 = _003C_003Ec__DisplayClass15_.reader.ReadUInt32();
						_003C_003Ec__DisplayClass15_4.uVar5 = _003C_003Ec__DisplayClass15_.reader.ReadUInt32();
						_003C_003Ec__DisplayClass15_4.iVar6 = 0;
						_003C_003Ec__DisplayClass15_4.iVar7 = 0;
						_003C_003Ec__DisplayClass15_4.uVar3 = ((_003C_003Ec__DisplayClass15_4.uVar3 >> 16) | (_003C_003Ec__DisplayClass15_4.uVar3 << 16));
						_003C_003Ec__DisplayClass15_4.uVar4 = ((_003C_003Ec__DisplayClass15_4.uVar4 >> 16) | (_003C_003Ec__DisplayClass15_4.uVar4 << 16));
						_003C_003Ec__DisplayClass15_3.writer.Write(_003C_003Ec__DisplayClass15_4.uVar1);
						_003C_003Ec__DisplayClass15_4.uVar1 = (_003C_003Ec__DisplayClass15_4.uVar1 & 0xFFFF) << 2;
						int num18 = (int)(_003C_003Ec__DisplayClass15_4.uVar1 + 4);
						if (((num17 >> 16) ^ 3) != 0)
						{
							num17 = (num17 & 0x3F) << 10;
							_003C_003Ec__DisplayClass15_4.uVar1 = ((_003C_003Ec__DisplayClass15_4.uVar3 >> 22) | num17);
							_003C_003Ec__DisplayClass15_4.iVar6 = 10;
							_003CLoadAsset_003Eg__Huffman_007C15_0(ref _003C_003Ec__DisplayClass15_, ref _003C_003Ec__DisplayClass15_2, ref _003C_003Ec__DisplayClass15_3, ref _003C_003Ec__DisplayClass15_4);
							while (true)
							{
								_003C_003Ec__DisplayClass15_4.uVar1 >>= 22;
								if ((_003C_003Ec__DisplayClass15_4.uVar1 ^ 0x1FF) == 0)
								{
									break;
								}
								_003C_003Ec__DisplayClass15_4.uVar1 |= num17;
								_003C_003Ec__DisplayClass15_4.iVar6 = 12;
								_003CLoadAsset_003Eg__Huffman_007C15_0(ref _003C_003Ec__DisplayClass15_, ref _003C_003Ec__DisplayClass15_2, ref _003C_003Ec__DisplayClass15_3, ref _003C_003Ec__DisplayClass15_4);
							}
						}
						_003C_003Ec__DisplayClass15_4.uVar1 = 65024u;
						while (_003C_003Ec__DisplayClass15_3.writer.BaseStream.Length != num18)
						{
							_003C_003Ec__DisplayClass15_3.writer.Write((ushort)_003C_003Ec__DisplayClass15_4.uVar1);
						}
						using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.Default, leaveOpen: true))
						{
							_003C_003Ec__DisplayClass15_3.writer.BaseStream.Seek(0L, SeekOrigin.Begin);
							int num19 = num5 & 3;
							uint value = (uint)(((num19 & 1) != 0) ? ((int)binaryReader.ReadUInt32() & -134217729) : ((int)(binaryReader.ReadUInt32() | 0x8000000)));
							_003C_003Ec__DisplayClass15_3.writer.BaseStream.Seek(0L, SeekOrigin.Begin);
							_003C_003Ec__DisplayClass15_3.writer.Write(value);
							binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
							value = (uint)(((num19 & 2) != 0) ? ((int)(binaryReader.ReadUInt32() | 0x2000000)) : ((int)binaryReader.ReadUInt32() & -33554433));
							_003C_003Ec__DisplayClass15_3.writer.BaseStream.Seek(0L, SeekOrigin.Begin);
							_003C_003Ec__DisplayClass15_3.writer.Write(value);
							string extension = Path.GetExtension(bmp);
							using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(bmp.Replace(extension, ".txt"), FileMode.Create)))
							{
								while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
								{
									byte b = 0;
									byte num20 = binaryReader.ReadByte();
									byte b2 = 0;
									b = (byte)((uint)num20 >> 4);
									char ch;
									if ((uint)b < 10u)
									{
										ch = (char)(48 + b);
									}
									else
									{
										b = (byte)(b - 10);
										ch = (char)(65 + b);
									}
									b2 = (byte)(num20 & 0xF);
									char ch2;
									if ((uint)b2 < 10u)
									{
										ch2 = (char)(48 + b2);
									}
									else
									{
										b2 = (byte)(b2 - 10);
										ch2 = (char)(65 + b2);
									}
									binaryWriter.Write(ch);
									binaryWriter.Write(ch2);
									binaryWriter.Write((byte)32);
								}
							}
							binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
						}
					}
					finally
					{
						if (_003C_003Ec__DisplayClass15_3.writer != null)
						{
							((IDisposable)_003C_003Ec__DisplayClass15_3.writer).Dispose();
						}
					}
					if (num6 == 0)
					{
						num11 = rECT2.x;
					}
					else
					{
						int num21 = (rECT2.x << 16 >> 16) + (int)((uint)(rECT2.x << 16) >> 31) >> 1;
						num11 = (num21 << 1) + num21;
					}
					short num22 = (short)(num7 << 3);
					if (num6 == 0)
					{
						num6 = num11 + rECT2.w;
					}
					else
					{
						int num23 = (rECT2.w << 16 >> 16) + (int)((uint)(rECT2.w << 16) >> 31) >> 1;
						num6 = (num23 << 1) + num23;
					}
					num7 = (num7 << 3) * num8 + (int)((uint)((num7 << 3) * num8) >> 31);
					_003C_003Ec__DisplayClass15_4 _003C_003Ec__DisplayClass15_5 = default(_003C_003Ec__DisplayClass15_4);
					_003C_003Ec__DisplayClass15_5.reader2 = new BinaryReader(memoryStream, Encoding.Default, leaveOpen: true);
					try
					{
						int number = _003C_003Ec__DisplayClass15_5.reader2.ReadInt32();
						num12 = BitExtracted(number, 2, 27);
						BitExtracted(number, 1, 26);
						num13 = BitExtracted(number, 1, 25);
						_003C_003Ec__DisplayClass15_5 _003C_003Ec__DisplayClass15_6 = default(_003C_003Ec__DisplayClass15_5);
						_003C_003Ec__DisplayClass15_6.m_remaining_halfwords = BitExtracted(number, 16, 0) * 2;
						_003C_003Ec__DisplayClass15_6.m_current_block = 0;
						_003C_003Ec__DisplayClass15_6.m_current_coefficient = 64;
						_003C_003Ec__DisplayClass15_6.m_current_q_scale = 0;
						while (_003C_003Ec__DisplayClass15_6.m_remaining_halfwords > 0)
						{
							bool flag = false;
							while (_003C_003Ec__DisplayClass15_6.m_current_block < NUM_BLOCKS)
							{
								if (!_003CLoadAsset_003Eg__rl_decode_block_007C15_1(_003C_003Ec__DisplayClass15_2.m_blocks, (_003C_003Ec__DisplayClass15_6.m_current_block >= 2) ? array : array2, ref _003C_003Ec__DisplayClass15_5, ref _003C_003Ec__DisplayClass15_6))
								{
									flag = true;
									break;
								}
								_003CLoadAsset_003Eg__IDCT_007C15_2(_003C_003Ec__DisplayClass15_2.m_blocks, ref _003C_003Ec__DisplayClass15_2, ref _003C_003Ec__DisplayClass15_6);
								int current_block = _003C_003Ec__DisplayClass15_6.m_current_block;
								_003C_003Ec__DisplayClass15_6.m_current_block = current_block + 1;
							}
							if (flag)
							{
								break;
							}
							_003C_003Ec__DisplayClass15_6.m_current_block = 0;
							_003C_003Ec__DisplayClass15_6.m_current_coefficient = 64;
							_003C_003Ec__DisplayClass15_6.m_current_q_scale = 0;
							_003CLoadAsset_003Eg__yuv_to_rgb_007C15_3(0, 0, _003C_003Ec__DisplayClass15_2.m_blocks, 0, 1, 2, ref _003C_003Ec__DisplayClass15_2);
							_003CLoadAsset_003Eg__yuv_to_rgb_007C15_3(8, 0, _003C_003Ec__DisplayClass15_2.m_blocks, 0, 1, 3, ref _003C_003Ec__DisplayClass15_2);
							_003CLoadAsset_003Eg__yuv_to_rgb_007C15_3(0, 8, _003C_003Ec__DisplayClass15_2.m_blocks, 0, 1, 4, ref _003C_003Ec__DisplayClass15_2);
							_003CLoadAsset_003Eg__yuv_to_rgb_007C15_3(8, 8, _003C_003Ec__DisplayClass15_2.m_blocks, 0, 1, 5, ref _003C_003Ec__DisplayClass15_2);
							switch (num12)
							{
							case 0:
								for (int m = 0; m < 64; m += 8)
								{
									uint num40 = _003C_003Ec__DisplayClass15_2.m_block_rgb[m] >> 4;
									num40 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[m + 1] >> 4 << 4;
									num40 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[m + 2] >> 4 << 8;
									num40 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[m + 3] >> 4 << 12;
									num40 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[m + 4] >> 4 << 16;
									num40 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[m + 5] >> 4 << 20;
									num40 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[m + 6] >> 4 << 24;
									num40 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[m + 7] >> 4 << 28;
									queue.Enqueue(num40);
								}
								break;
							case 1:
								for (int l = 0; l < 64; l += 4)
								{
									uint num35 = _003C_003Ec__DisplayClass15_2.m_block_rgb[l];
									num35 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[l + 1] << 8;
									num35 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[l + 2] << 16;
									num35 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[l + 3] << 24;
									queue.Enqueue(num35);
								}
								break;
							case 2:
							{
								int num36 = 0;
								int num37 = 0;
								uint num38 = 0u;
								while (num36 < _003C_003Ec__DisplayClass15_2.m_block_rgb.Length)
								{
									switch (num37)
									{
									case 0:
										num38 = _003C_003Ec__DisplayClass15_2.m_block_rgb[num36++];
										num37 = 1;
										break;
									case 1:
										num38 |= (_003C_003Ec__DisplayClass15_2.m_block_rgb[num36] & 0xFF) << 24;
										queue.Enqueue(num38);
										num38 = _003C_003Ec__DisplayClass15_2.m_block_rgb[num36] >> 8;
										num36++;
										num37 = 2;
										break;
									case 2:
										num38 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[num36] << 16;
										queue.Enqueue(num38);
										num38 = _003C_003Ec__DisplayClass15_2.m_block_rgb[num36] >> 16;
										num36++;
										num37 = 3;
										break;
									case 3:
										num38 |= _003C_003Ec__DisplayClass15_2.m_block_rgb[num36] << 8;
										queue.Enqueue(num38);
										num36++;
										num37 = 0;
										break;
									}
								}
								break;
							}
							case 3:
							{
								ushort num24 = (ushort)num13;
								int num25 = 0;
								while (num25 < _003C_003Ec__DisplayClass15_2.m_block_rgb.Length)
								{
									uint num27 = _003C_003Ec__DisplayClass15_2.m_block_rgb[num25++];
									ushort num28 = (ushort)((num27 >> 3) & 0x1F);
									ushort num29 = (ushort)((num27 >> 11) & 0x1F);
									ushort num30 = (ushort)((num27 >> 19) & 0x1F);
									ushort num31 = (ushort)(num28 | (num29 << 5) | (num30 << 10) | (num24 << 15));
									uint num33 = _003C_003Ec__DisplayClass15_2.m_block_rgb[num25++];
									num28 = (ushort)((num33 >> 3) & 0x1F);
									num29 = (ushort)((num33 >> 11) & 0x1F);
									num30 = (ushort)((num33 >> 19) & 0x1F);
									ushort num34 = (ushort)(num28 | (num29 << 5) | (num30 << 10) | (num24 << 15));
									queue.Enqueue((uint)(num31 | (num34 << 16)));
								}
								break;
							}
							}
						}
					}
					finally
					{
						if (_003C_003Ec__DisplayClass15_5.reader2 != null)
						{
							((IDisposable)_003C_003Ec__DisplayClass15_5.reader2).Dispose();
						}
					}
				}
				RGB[,] array3 = new RGB[num2 / 16, 16 * num3];
				for (int n = 0; n < num2 / 16; n++)
				{
					ushort num41 = 31744;
					ushort num42 = 992;
					ushort num43 = 31;
					if (num12 == 3)
					{
						int num44 = 0;
						while (num44 < 16 * num3)
						{
							uint num45 = queue.Dequeue();
							ushort[] array4 = new ushort[2]
							{
								(ushort)(num45 & 0xFFFF),
								(ushort)(num45 >> 16)
							};
							int num46 = 0;
							while (num46 < array4.Length)
							{
								byte b3 = (byte)((array4[num46] & num41) >> 10);
								byte b4 = (byte)((array4[num46] & num42) >> 5);
								byte num47 = (byte)(array4[num46] & num43);
								byte a = (byte)((array4[num46] >> 15 == 1) ? 128 : 255);
								byte r = (byte)(b3 << 3);
								byte g = (byte)(b4 << 3);
								byte b5 = (byte)(num47 << 3);
								array3[n, num44].r = r;
								array3[n, num44].g = g;
								array3[n, num44].b = b5;
								array3[n, num44].a = a;
								num46++;
								num44++;
							}
						}
					}
				}
				string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(bmp);
				using (BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(bmp.Replace(fileNameWithoutExtension2, fileNameWithoutExtension2 + "_2"), FileMode.Create)))
				{
					binaryWriter2.Write((short)19778);
					binaryWriter2.Write(num2 * num3 * 4 + 56);
					binaryWriter2.Write((short)0);
					binaryWriter2.Write((short)0);
					binaryWriter2.Write(54);
					binaryWriter2.Write(40);
					binaryWriter2.Write((int)num2);
					binaryWriter2.Write((int)num3);
					binaryWriter2.Write(2097153);
					binaryWriter2.Write(0L);
					binaryWriter2.Write(2834);
					binaryWriter2.Write(2834);
					binaryWriter2.Write(0L);
					List<RGB> list = new List<RGB>();
					RGB item = default(RGB);
					for (int num48 = 0; num48 < num3; num48++)
					{
						for (int num49 = 0; num49 < num2 / 16; num49++)
						{
							for (int num50 = 0; num50 < 16; num50++)
							{
								item.r = array3[num49, num50 + num48 * 16].r;
								item.g = array3[num49, num50 + num48 * 16].g;
								item.b = array3[num49, num50 + num48 * 16].b;
								item.a = array3[num49, num50 + num48 * 16].a;
								list.Add(item);
							}
						}
					}
					int num51 = 0;
					int num52 = list.Count - num2;
					while (num51 < list.Count)
					{
						for (int num53 = 0; num53 < num2; num53++)
						{
							binaryWriter2.Write(list[num52 + num53].r);
							binaryWriter2.Write(list[num52 + num53].g);
							binaryWriter2.Write(list[num52 + num53].b);
							binaryWriter2.Write(list[num52 + num53].a);
						}
						num51 += num2;
						num52 -= num2;
					}
					binaryWriter2.Write((short)0);
				}
			}
			else
			{
				LoadTIM(_003C_003Ec__DisplayClass15_.reader, bmp);
			}
		}
		finally
		{
			if (_003C_003Ec__DisplayClass15_.reader != null)
			{
				((IDisposable)_003C_003Ec__DisplayClass15_.reader).Dispose();
			}
		}
	}

	public static void LoadTIM(BinaryReader reader, string path)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short num4 = 0;
		ushort[] array = new ushort[16];
		InitGlobals(reader);
		if (FLAG == 18)
		{
			FLAG = 18u;
		}
		if (POS_CLUT_RECT != 0L)
		{
			if ((FLAG & 0x20) == 0)
			{
				reader.BaseStream.Seek(POS_CLUT_RECT + 4, SeekOrigin.Begin);
				num = reader.ReadInt16();
				num2 = reader.ReadInt16();
			}
			else
			{
				num = 16;
				if (16 < reader.ReadInt16())
				{
					num = 256;
				}
			}
			array = new ushort[num2 * num];
			reader.BaseStream.Seek(POS_CLUT_COLORS, SeekOrigin.Begin);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = reader.ReadUInt16();
			}
		}
		reader.BaseStream.Seek(POS_IMG_RECT + 4, SeekOrigin.Begin);
		num3 = reader.ReadInt16();
		num4 = reader.ReadInt16();
		byte[] array2;
		if ((FLAG & 0x10) == 0)
		{
			array2 = new byte[num3 * num4 * 2];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = reader.ReadByte();
			}
		}
		else
		{
			reader.BaseStream.Seek(POS_IMG_INDICES, SeekOrigin.Begin);
			RECT rECT = default(RECT);
			rECT.x = 0;
			rECT.y = 0;
			rECT.w = num3;
			rECT.h = num4;
			RECT rect = rECT;
			array2 = Decompressor(reader, rect).ToArray();
		}
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
		{
			if (FLAG == 18)
			{
				binaryWriter.Write((short)19778);
				binaryWriter.Write(num3 * num4 * 4 + 56);
				binaryWriter.Write((short)0);
				binaryWriter.Write((short)0);
				binaryWriter.Write(54);
				binaryWriter.Write(40);
				binaryWriter.Write((int)num3);
				binaryWriter.Write((int)num4);
				binaryWriter.Write(2097153);
				binaryWriter.Write(0L);
				binaryWriter.Write(2834);
				binaryWriter.Write(2834);
				binaryWriter.Write(0L);
				array = new ushort[num3 * num4];
				for (int k = 0; k < array2.Length; k += 2)
				{
					array[k / 2] = (ushort)((array2[k + 1] << 8) | array2[k]);
				}
				ushort num5 = 31744;
				ushort num6 = 992;
				ushort num7 = 31;
				RGB[] array3 = new RGB[num3 * num4];
				for (int l = 0; l < array3.Length; l++)
				{
					byte b = (byte)((array[l] & num5) >> 10);
					byte b2 = (byte)((array[l] & num6) >> 5);
					byte num8 = (byte)(array[l] & num7);
					byte b3 = (byte)(b << 3);
					byte b4 = (byte)(b2 << 3);
					byte b5 = (byte)(num8 << 3);
					byte b6 = byte.MaxValue;
					b6 = (byte)((array[l] >> 15 != 0) ? ((b3 != 0 || b4 != 0 || b5 != 0) ? 127 : 127) : ((b3 != 0 || b4 != 0 || b5 != 0) ? byte.MaxValue : 0));
					array3[l].r = b3;
					array3[l].g = b4;
					array3[l].b = b5;
					array3[l].a = b6;
					binaryWriter.Write(array3[l].r);
					binaryWriter.Write(array3[l].g);
					binaryWriter.Write(array3[l].b);
					binaryWriter.Write(array3[l].a);
				}
				binaryWriter.Write((short)0);
			}
			else if ((FLAG & 1) == 0)
			{
				binaryWriter.Write((short)19778);
				binaryWriter.Write(num3 * num4 * 16 + 56);
				binaryWriter.Write((short)0);
				binaryWriter.Write((short)0);
				binaryWriter.Write(54);
				binaryWriter.Write(40);
				binaryWriter.Write(num3 * 4);
				binaryWriter.Write((int)num4);
				binaryWriter.Write(2097153);
				binaryWriter.Write(0L);
				binaryWriter.Write(2834);
				binaryWriter.Write(2834);
				binaryWriter.Write(0L);
				ushort num9 = 31744;
				ushort num10 = 992;
				ushort num11 = 31;
				RGB[] array4 = new RGB[num3 * num4 * 4];
				for (int m = 0; m < array4.Length; m++)
				{
					int num12 = (m % 2 == 0) ? (array2[m / 2] & 0xF) : (array2[m / 2] >> 4);
					byte b7 = (byte)((array[num12] & num9) >> 10);
					byte b8 = (byte)((array[num12] & num10) >> 5);
					byte num13 = (byte)(array[num12] & num11);
					byte b9 = (byte)(b7 << 3);
					byte b10 = (byte)(b8 << 3);
					byte b11 = (byte)(num13 << 3);
					byte b12 = byte.MaxValue;
					b12 = (byte)((array[num12] >> 15 != 0) ? ((b9 != 0 || b10 != 0 || b11 != 0) ? 127 : 127) : ((b9 != 0 || b10 != 0 || b11 != 0) ? byte.MaxValue : 0));
					array4[m].r = b9;
					array4[m].g = b10;
					array4[m].b = b11;
					array4[m].a = b12;
				}
				int num14 = num3 * 4;
				int num15 = 0;
				int num16 = array4.Length - num14;
				while (num15 < array4.Length)
				{
					for (int n = 0; n < num14; n++)
					{
						binaryWriter.Write(array4[num16 + n].r);
						binaryWriter.Write(array4[num16 + n].g);
						binaryWriter.Write(array4[num16 + n].b);
						binaryWriter.Write(array4[num16 + n].a);
					}
					num15 += num14;
					num16 -= num14;
				}
				binaryWriter.Write((short)0);
			}
			else
			{
				binaryWriter.Write((short)19778);
				binaryWriter.Write(num3 * num4 * 16 + 56);
				binaryWriter.Write((short)0);
				binaryWriter.Write((short)0);
				binaryWriter.Write(54);
				binaryWriter.Write(40);
				binaryWriter.Write(num3 * 2);
				binaryWriter.Write((int)num4);
				binaryWriter.Write(2097153);
				binaryWriter.Write(0L);
				binaryWriter.Write(2834);
				binaryWriter.Write(2834);
				binaryWriter.Write(0L);
				ushort num17 = 31744;
				ushort num18 = 992;
				ushort num19 = 31;
				RGB[] array5 = new RGB[num3 * num4 * 2];
				for (int num20 = 0; num20 < array5.Length; num20++)
				{
					int num21 = array2[num20];
					byte b13 = (byte)((array[num21] & num17) >> 10);
					byte b14 = (byte)((array[num21] & num18) >> 5);
					byte num22 = (byte)(array[num21] & num19);
					byte b15 = (byte)(b13 << 3);
					byte b16 = (byte)(b14 << 3);
					byte b17 = (byte)(num22 << 3);
					byte b18 = byte.MaxValue;
					b18 = (byte)((array[num21] >> 15 != 0) ? ((b15 != 0 || b16 != 0 || b17 != 0) ? 127 : 127) : ((b15 != 0 || b16 != 0 || b17 != 0) ? byte.MaxValue : 0));
					array5[num20].r = b15;
					array5[num20].g = b16;
					array5[num20].b = b17;
					array5[num20].a = b18;
				}
				int num23 = num3 * 2;
				int num24 = 0;
				int num25 = array5.Length - num23;
				while (num24 < array5.Length)
				{
					for (int num26 = 0; num26 < num23; num26++)
					{
						binaryWriter.Write(array5[num25 + num26].r);
						binaryWriter.Write(array5[num25 + num26].g);
						binaryWriter.Write(array5[num25 + num26].b);
						binaryWriter.Write(array5[num25 + num26].a);
					}
					num24 += num23;
					num25 -= num23;
				}
				binaryWriter.Write((short)0);
			}
		}
	}

	private static void InitGlobals(BinaryReader reader)
	{
		if (((FLAG = reader.ReadUInt32()) & 8) == 0)
		{
			POS_CLUT_COLORS = 0L;
			POS_CLUT_RECT = 0L;
		}
		else
		{
			POS_CLUT_RECT = reader.BaseStream.Position + 4;
			POS_CLUT_COLORS = reader.BaseStream.Position + 12;
			int num = reader.ReadInt32() - 4;
			reader.BaseStream.Seek(num, SeekOrigin.Current);
		}
		POS_IMG_RECT = reader.BaseStream.Position + 4;
		POS_IMG_INDICES = reader.BaseStream.Position + 12;
		int num2 = reader.ReadInt32();
		POS_IMG_INDICES2 = ((reader.BaseStream.Position - 12 + num2 + 11) & -4);
	}

	private static List<byte> Decompressor(BinaryReader reader, RECT rect)
	{
		long position = reader.BaseStream.Position;
		byte[] array = new byte[2848];
		int num = 0;
		int num2 = 0;
		uint num3 = 256u;
		short num4 = rect.y;
		short h = rect.h;
		List<byte> list = new List<byte>();
		int num5 = rect.w * 2;
		do
		{
			int num6 = num2 + (rect.y + rect.h - num4) * num5;
			int num7 = 2048;
			if (num6 < 2048)
			{
				num7 = num6;
			}
			int num8 = 400 + num;
			do
			{
				if ((num3 & 0x100) != 0)
				{
					num3 = (uint)((reader.ReadByte() << 24) | 1);
				}
				if ((int)num3 < 0)
				{
					byte b = reader.ReadByte();
					num++;
					array[num8] = b;
					num8++;
				}
				else
				{
					byte num9 = reader.ReadByte();
					uint num10 = reader.ReadByte();
					num10 <<= 8;
					uint num11 = num9 | num10;
					uint num12 = num11 >> 5;
					uint num13 = num11 & 0x1F;
					if (num < (int)num12 && 2048 < (int)(num12 + num13 + 2))
					{
						int num14 = (int)(num13 + 1);
						while (num14 != -1)
						{
							num13 = (num12 & 0x7FF);
							num12++;
							num++;
							num14--;
							byte b2 = array[num8] = array[400 + num13];
							num8++;
						}
					}
					else
					{
						int num15 = (int)(num13 + 1);
						while (num15 != -1)
						{
							byte b3 = array[400 + num12];
							num12++;
							num++;
							num15--;
							array[num8] = b3;
							num8++;
						}
					}
				}
				num3 <<= 1;
			}
			while (num < num7);
			int num16 = (num7 - num2) / num5;
			h = (short)num16;
			if (((num16 << 16 >> 16) & 1) != 0 && (num5 & 2) != 0 && num4 + num16 < rect.y + rect.h)
			{
				h = (short)(num16 - 1);
			}
			for (int i = 0; i < num5 * h; i++)
			{
				list.Add(array[400 + num2 + i]);
			}
			num4 = (short)(h + num4);
			num2 += (h << 16 >> 16) * num5;
			InitBuffer(array, 400 + num2 - 2048, 400 + num2, num - num2);
			num2 -= 2048;
			num -= 2048;
		}
		while (num4 < rect.y + rect.h);
		return list;
	}

	private static int InitBuffer(byte[] buffer, int begin, int end, int previousLength)
	{
		int result = begin;
		if (previousLength != 0)
		{
			while ((end & 3) != 0)
			{
				buffer[begin++] = buffer[end++];
				previousLength--;
				if (previousLength == 0)
				{
					return result;
				}
			}
			int num3 = begin & 3;
			previousLength -= 16;
			if (num3 == 0)
			{
				while (-1 < previousLength)
				{
					int num4 = 0;
					while (num4 < 16)
					{
						buffer[begin++] = buffer[end++];
						num4++;
						previousLength--;
					}
				}
				previousLength += 12;
				while (-1 < previousLength)
				{
					int num7 = 0;
					while (num7 < 4)
					{
						buffer[begin++] = buffer[end++];
						num7++;
						previousLength--;
					}
				}
				previousLength += 3;
				if (-1 < previousLength)
				{
					end += previousLength;
					begin += previousLength;
					if (end % 4 == 0)
					{
						buffer[begin] = buffer[end];
					}
					else if (end % 4 == 2)
					{
						buffer[begin] = buffer[end];
						buffer[begin - 1] = buffer[end - 1];
						buffer[begin - 2] = buffer[end - 2];
					}
					else if (end % 4 == 1)
					{
						buffer[begin] = buffer[end];
						buffer[begin - 1] = buffer[end - 1];
					}
					else if (end % 4 == 3)
					{
						buffer[begin] = buffer[end];
						buffer[begin - 1] = buffer[end - 1];
						buffer[begin - 2] = buffer[end - 2];
						buffer[begin - 3] = buffer[end - 3];
					}
					return result;
				}
			}
			else
			{
				while (-1 < previousLength)
				{
					int num10 = 0;
					while (num10 < 16)
					{
						buffer[begin++] = buffer[end++];
						num10++;
						previousLength--;
					}
				}
				previousLength += 12;
				while (-1 < previousLength)
				{
					int num13 = 0;
					while (num13 < 4)
					{
						buffer[begin++] = buffer[end++];
						num13++;
						previousLength--;
					}
				}
				for (previousLength += 4; previousLength != 0; previousLength--)
				{
					buffer[begin++] = buffer[end++];
				}
			}
		}
		return result;
	}

	private static int BitExtracted(int number, int k, int p)
	{
		return ((1 << k) - 1) & (number >> p);
	}

	private static int SignedNBits(int value, int NBITS)
	{
		int num = 32 - NBITS;
		return value << num >> num;
	}

	[CompilerGenerated]
	private static void _003CLoadAsset_003Eg__Huffman_007C15_0(ref _003C_003Ec__DisplayClass15_0 P_0, ref _003C_003Ec__DisplayClass15_1 P_1, ref _003C_003Ec__DisplayClass15_2 P_2, ref _003C_003Ec__DisplayClass15_3 P_3)
	{
		while (true)
		{
			P_2.writer.Write((ushort)P_3.uVar1);
			P_3.uVar3 <<= P_3.iVar6;
			P_3.uVar3 |= P_3.uVar4 >> P_3.iVar6 * -1;
			P_3.iVar7 += P_3.iVar6;
			P_3.uVar4 <<= P_3.iVar6;
			if (-1 < P_3.iVar7 - 32)
			{
				P_3.iVar7 -= 32;
				P_3.uVar1 = P_3.uVar5 << 16;
				P_3.uVar5 = ((P_3.uVar5 >> 16) | P_3.uVar1);
				P_3.uVar3 |= ((-P_3.iVar7 != 0) ? (P_3.uVar5 >> -P_3.iVar7) : 0);
				P_3.uVar4 = P_3.uVar5 << P_3.iVar7;
				if (P_0.reader.BaseStream.Position != P_0.reader.BaseStream.Length)
				{
					P_3.uVar5 = P_0.reader.ReadUInt32();
				}
				else
				{
					P_3.uVar5 = 0u;
				}
			}
			if ((int)P_3.uVar3 >= 0)
			{
				if ((int)(P_3.uVar3 << 1) < 0)
				{
					if ((int)(P_3.uVar3 << 2) < 0)
					{
						P_3.iVar6 = 4;
						P_3.uVar1 = 1025u;
						if ((int)(P_3.uVar3 << 3) < 0)
						{
							P_3.uVar1 = 2047u;
						}
						continue;
					}
					P_3.iVar6 = 5;
					if ((int)(P_3.uVar3 << 3) < 0)
					{
						P_3.uVar1 = 2049u;
						if ((int)(P_3.uVar3 << 4) < 0)
						{
							P_3.uVar1 = 3071u;
						}
					}
					else
					{
						P_3.uVar1 = 2u;
						if ((int)(P_3.uVar3 << 4) < 0)
						{
							P_3.uVar1 = 1022u;
						}
					}
					continue;
				}
				if ((int)(P_3.uVar3 << 2) < 0)
				{
					if (P_3.uVar3 << 3 >> 30 == 0)
					{
						P_3.uVar1 = (uint)(short)P_1.fastRam[192 + ((P_3.uVar3 >> 22) & 0x1E) / 2u];
						P_3.iVar6 = 9;
					}
					else
					{
						P_3.uVar1 = (uint)(short)P_1.fastRam[206 + ((P_3.uVar3 >> 25) & 0xE) / 2u];
						P_3.iVar6 = 6;
					}
					continue;
				}
				LZCS = (int)P_3.uVar3;
				LZCR = Utilities.LeadingZeros(LZCS);
				P_3.iVar6 = LZCR;
				if (P_3.uVar3 >> 26 == 1)
				{
					P_3.uVar1 = ((P_3.uVar3 >> 10) & 0xFFFF);
					P_3.iVar6 = 22;
					continue;
				}
				uint num = P_3.uVar3 << P_3.iVar6;
				if ((int)((P_3.uVar3 >> 26) - 1) < 0)
				{
					if (P_3.iVar6 - 6 < 1)
					{
						num = ((num >> 26) & 0x1E);
						P_3.uVar1 = (uint)(short)P_1.fastRam[16 + num / 2u];
						P_3.iVar6 = 11;
					}
					else
					{
						P_3.uVar1 = (uint)(P_3.iVar6 - 6 << 6);
						num = ((num >> 25) & 0x3E) + P_3.uVar1;
						P_3.uVar1 = (uint)(short)P_1.fastRam[num / 2u];
						P_3.iVar6 += 6;
					}
				}
				else
				{
					P_3.uVar1 = (uint)(P_3.iVar6 - 3 << 4);
					num = ((num >> 27) & 0xE) + P_3.uVar1;
					P_3.uVar1 = (uint)(short)P_1.fastRam[num / 2u];
					P_3.iVar6 += 4;
				}
			}
			else
			{
				if (-1 < (int)(P_3.uVar3 << 1))
				{
					break;
				}
				P_3.iVar6 = 3;
				P_3.uVar1 = 1u;
				if ((int)(P_3.uVar3 << 2) < 0)
				{
					P_3.uVar1 = 1023u;
				}
			}
		}
		P_2.writer.Write((ushort)65024);
		P_3.uVar1 = P_3.uVar3 << 2;
	}

	[CompilerGenerated]
	private static bool _003CLoadAsset_003Eg__rl_decode_block_007C15_1(short[,] blk, byte[] qt, ref _003C_003Ec__DisplayClass15_4 P_2, ref _003C_003Ec__DisplayClass15_5 P_3)
	{
		if (P_3.m_current_coefficient == 64)
		{
			for (int i = 0; i < 64; i++)
			{
				blk[P_3.m_current_block, i] = 0;
			}
			ushort num;
			do
			{
				if (P_3.m_remaining_halfwords == 0)
				{
					return false;
				}
				num = P_2.reader2.ReadUInt16();
				P_3.m_remaining_halfwords--;
			}
			while (num == 65024);
			P_3.m_current_coefficient = 0;
			P_3.m_current_q_scale = (ushort)((num >> 10) & 0x3F);
			int val = SignedNBits(num & 0x3FF, 10) * qt[P_3.m_current_coefficient];
			if (P_3.m_current_q_scale == 0)
			{
				val = SignedNBits(num & 0x3FF, 10) * 2;
			}
			val = val.Clamp(-1024, 1023);
			if (P_3.m_current_q_scale > 0)
			{
				blk[P_3.m_current_block, ZAGZIG[P_3.m_current_coefficient]] = (short)val;
			}
			else if (P_3.m_current_q_scale == 0)
			{
				blk[P_3.m_current_block, P_3.m_current_coefficient] = (short)val;
			}
		}
		while (P_3.m_remaining_halfwords > 0)
		{
			ushort num2 = P_2.reader2.ReadUInt16();
			P_3.m_remaining_halfwords--;
			P_3.m_current_coefficient += ((num2 >> 10) & 0x3F) + 1;
			if (P_3.m_current_coefficient >= 64)
			{
				P_3.m_current_coefficient = 64;
				return true;
			}
			int val2 = (SignedNBits(num2 & 0x3FF, 10) * qt[P_3.m_current_coefficient] * P_3.m_current_q_scale + 4) / 8;
			if (P_3.m_current_q_scale == 0)
			{
				val2 = SignedNBits(num2 & 0x3FF, 10) * 2;
			}
			val2 = val2.Clamp(-1024, 1023);
			if (P_3.m_current_q_scale > 0)
			{
				blk[P_3.m_current_block, ZAGZIG[P_3.m_current_coefficient]] = (short)val2;
			}
			else if (P_3.m_current_q_scale == 0)
			{
				blk[P_3.m_current_block, P_3.m_current_coefficient] = (short)val2;
			}
		}
		return false;
	}

	[CompilerGenerated]
	private static void _003CLoadAsset_003Eg__IDCT_007C15_2(short[,] blk, ref _003C_003Ec__DisplayClass15_1 P_1, ref _003C_003Ec__DisplayClass15_5 P_2)
	{
		long[] array = new long[64];
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				long num = 0L;
				for (int k = 0; k < 8; k++)
				{
					num += blk[P_2.m_current_block, k * 8 + i] * P_1.m_scale_table[k * 8 + j];
				}
				array[i + j * 8] = num;
			}
		}
		for (int l = 0; l < 8; l++)
		{
			for (int m = 0; m < 8; m++)
			{
				long num2 = 0L;
				for (int n = 0; n < 8; n++)
				{
					num2 += array[n + m * 8] * P_1.m_scale_table[n * 8 + l];
				}
				blk[P_2.m_current_block, l + m * 8] = (short)SignedNBits((int)((num2 >> 32) + ((num2 >> 31) & 1)), 9).Clamp(-128, 127);
			}
		}
	}

	[CompilerGenerated]
	private static void _003CLoadAsset_003Eg__yuv_to_rgb_007C15_3(int xx, int yy, short[,] blk, int Crblk, int Cbblk, int Yblk, ref _003C_003Ec__DisplayClass15_1 P_6)
	{
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				short num = P_6.m_blocks[Crblk, (j + xx) / 2 + (i + yy) / 2 * 8];
				short num2 = P_6.m_blocks[Cbblk, (j + xx) / 2 + (i + yy) / 2 * 8];
				short num3 = (short)(-0.3437f * (float)num2 + -0.7143f * (float)num);
				num = (short)(1.402f * (float)num);
				num2 = (short)(1.772f * (float)num2);
				short num4 = P_6.m_blocks[Yblk, j + i * 8];
				num = (short)(num4 + num).Clamp(-128, 127);
				num3 = (short)(num4 + num3).Clamp(-128, 127);
				num2 = (short)(num4 + num2).Clamp(-128, 127);
				num = (short)(num + 128);
				num3 = (short)(num3 + 128);
				num2 = (short)(num2 + 128);
				P_6.m_block_rgb[j + xx + (i + yy) * 16] = (uint)((ushort)num | ((ushort)num3 << 8) | ((ushort)num2 << 16));
			}
		}
	}
}
