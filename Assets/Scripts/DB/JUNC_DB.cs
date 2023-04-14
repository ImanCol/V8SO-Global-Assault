using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public delegate void DELEGATE_79A0(MemoryStream param1, MemoryStream param2, MemoryStream param3, MemoryStream param4);

public class JUNC_DB : MonoBehaviour
{
	public Vector3Int DAT_00;

	public XOBF_DB DAT_0C;

	public byte DAT_10;

	public byte DAT_11;

	public short DAT_12;

	public short DAT_14;

	public short DAT_16;

	public VigMesh DAT_18;

	public RSEG_DB[] DAT_1C;

	public bool LoadDB(string assetPath)
	{
		LevelManager levelManager = UnityEngine.Object.FindObjectOfType<LevelManager>();
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			if (binaryReader == null)
			{
				return false;
			}
			long num = binaryReader.BaseStream.Length;
			VigTerrain vigTerrain = UnityEngine.Object.FindObjectOfType<VigTerrain>();
			int num2 = binaryReader.ReadInt32BE();
			int num3 = binaryReader.ReadInt32BE();
			byte b = binaryReader.ReadByte();
			int num4 = binaryReader.ReadByte();
			DAT_00.x = num2;
			DAT_00.z = num3;
			DAT_10 = b;
			DAT_11 = (byte)num4;
			if ((b & 0x40) == 0)
			{
				DAT_12 = 0;
			}
			else
			{
				short num5 = DAT_12 = binaryReader.ReadInt16BE();
				num -= 2;
			}
			int y;
			if ((b & 2) == 0)
			{
				y = vigTerrain.FUN_1B750((uint)num2, (uint)num3);
				DAT_00.y = y;
			}
			else
			{
				y = binaryReader.ReadInt32BE();
				DAT_00.y = y - 1048576;
				num -= 4;
			}
			y = 0;
			if (0 < num4)
			{
				DAT_1C = new RSEG_DB[num4];
				do
				{
					DAT_1C[y] = null;
					y++;
				}
				while (y < num4);
			}
			if (num < 11)
			{
				DAT_18 = null;
			}
			else
			{
				num4 = binaryReader.ReadInt16BE();
				DAT_0C = levelManager.xobfList[num4 + 42];
				short num5 = DAT_14 = binaryReader.ReadInt16BE();
				num5 = (DAT_16 = binaryReader.ReadInt16BE());
				VigMesh vigMesh = DAT_0C.FUN_2CB74(base.gameObject, (ushort)DAT_14, init: false);
				vigMesh.xobf = DAT_0C;
				vigMesh.initAtStart = true;
				DAT_18 = vigMesh;
				vigMesh.DAT_00 = (byte)((vigMesh.DAT_00 & 0xFE) | 4);
				MemoryStream input = new MemoryStream(DAT_18.vertexStream);
				byte[] array = new byte[DAT_18.vertices << 3];
				MemoryStream output = new MemoryStream(array);
				b = DAT_18.DAT_01;
				DAT_18.DAT_02 = 16;
				DAT_18.vertexStream = array;
				uint num6 = (uint)(16 - b);
				if (0 < DAT_18.vertices)
				{
					using (BinaryReader binaryReader2 = new BinaryReader(input, Encoding.Default, leaveOpen: true))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(output, Encoding.Default, leaveOpen: true))
						{
							for (int i = 0; i < DAT_18.vertices; i++)
							{
								y = ((ushort)DAT_16 & 0xFFF) * 2;
								short num7 = binaryReader2.ReadInt16();
								binaryReader2.BaseStream.Seek(2L, SeekOrigin.Current);
								short num8 = binaryReader2.ReadInt16();
								y = GameManager.DAT_65C90[y + 1] * num7 + GameManager.DAT_65C90[y] * num8;
								if (y < 0)
								{
									y += 4095;
								}
								short num9 = (short)(y >> 12);
								binaryWriter.Write(num9);
								y = ((ushort)DAT_16 & 0xFFF) * 2;
								y = -GameManager.DAT_65C90[y] * num7 + GameManager.DAT_65C90[y + 1] * num8;
								if (y < 0)
								{
									y += 4095;
								}
								short num10 = (short)(y >> 12);
								y = vigTerrain.FUN_1B750((uint)(DAT_00.x + (num9 << (int)num6)), (uint)(DAT_00.z + (num10 << (int)num6)));
								binaryReader2.BaseStream.Seek(2L, SeekOrigin.Current);
								binaryWriter.Write((short)(y - DAT_00.y >> (int)num6));
								binaryWriter.Write(num10);
								binaryWriter.Write((short)0);
							}
						}
					}
				}
				Utilities.SetRotMatrix(GameManager.FUN_2A39C().rotation);
				Coprocessor.translationVector._trx = num2;
				Coprocessor.translationVector._try = DAT_00.y;
				Coprocessor.translationVector._trz = num3;
				DELEGATE_79A0 param = FUN_78CC;
				DAT_18.FUN_39A8(param);
			}
		}
		levelManager.juncList.Add(this);
		return true;
	}

	private void Update()
	{
		base.transform.localPosition = new Vector3((float)DAT_00.x / (float)GameManager.instance.translateFactor, (float)(-DAT_00.y) / (float)GameManager.instance.translateFactor, (float)DAT_00.z / (float)GameManager.instance.translateFactor);
	}

	private static void FUN_78CC(MemoryStream param1, MemoryStream param2, MemoryStream param3, MemoryStream param4)
	{
		long position4 = param1.Position;
		long position = param2.Position;
		long position2 = param3.Position;
		long position3 = param4.Position;
		VigTerrain vigTerrain = UnityEngine.Object.FindObjectOfType<VigTerrain>();
		Vector3Int vector3Int;
		using (BinaryReader binaryReader = new BinaryReader(param3, Encoding.Default, leaveOpen: true))
		{
			vector3Int = Utilities.FUN_23F58(new Vector3Int(binaryReader.ReadInt16(), binaryReader.ReadInt16(), binaryReader.ReadInt16()));
		}
		if (vector3Int.x < 0)
		{
			vector3Int.x += 65535;
		}
		if (vector3Int.z < 0)
		{
			vector3Int.z += 65535;
		}
		int num = vigTerrain.vertices[(((long)(vector3Int.z >> 16) & 63L) * 2 + ((long)(vector3Int.x >> 16) & 63L) * 128) / 2 + 4096 * vigTerrain.chunks[(((uint)(vector3Int.z >> 16) >> 6) * 4 + ((uint)(vector3Int.x >> 16) >> 6) * 128) / 4u]] >> 11;
		using (BinaryWriter binaryWriter = new BinaryWriter(param1, Encoding.Default, leaveOpen: true))
		{
			binaryWriter.Write(vigTerrain.DAT_B9370[num].r);
			binaryWriter.Write(vigTerrain.DAT_B9370[num].g);
			binaryWriter.Write(vigTerrain.DAT_B9370[num].b);
		}
		param2.Seek(position, SeekOrigin.Begin);
		param3.Seek(position2, SeekOrigin.Begin);
		param4.Seek(position3, SeekOrigin.Begin);
	}
}
