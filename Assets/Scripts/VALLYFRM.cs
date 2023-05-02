using System.Linq;
using UnityEngine;

public class VALLYFRM : VigObject
{
	public static VALLYFRM instance;

	public int DAT_14C0;

	public int DAT_14C8;

	public int DAT_80_2;

	public uint DAT_84_2;

	public short[] DAT_88;

	private static short[] ids = new short[6]
	{
		295,
		296,
		284,
		288,
		407,
		408
	};

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			if (arg2 != 0 && (DAT_80_2 -= arg2) < 0)
			{
				do
				{
					uint dAT_84_ = DAT_84_2;
					int num = (int)((dAT_84_ & 7) * 64) / 2;
					int num2 = num + 32;
					DAT_80_2 += 6;
					int num3 = 50;
					TileData tileData = VigTerrain.instance.tileData[num3];
					do
					{
						int num4 = ((DAT_88[num + 1] & 1) != 0) ? 128 : 0;
						tileData.uv1_x = ((((DAT_88[num + 1] - 10) & 0xF) / 2 << 8) | (((ushort)DAT_88[num] & 0xFF) + num4));
						tileData.uv1_y = (ushort)DAT_88[num] >> 8;
						tileData.uv2_x = ((((DAT_88[num + 3] - 10) & 0xF) / 2 << 8) | (((ushort)DAT_88[num + 2] & 0xFF) + num4));
						tileData.uv2_y = (ushort)DAT_88[num + 2] >> 8;
						tileData.uv3_x = ((((DAT_88[num + 5] - 10) & 0xF) / 2 << 8) | (((ushort)DAT_88[num + 4] & 0xFF) + num4));
						tileData.uv3_y = (ushort)DAT_88[num + 4] >> 8;
						tileData.uv4_x = ((((DAT_88[num + 7] - 10) & 0xF) / 2 << 8) | (((ushort)DAT_88[num + 6] & 0xFF) + num4));
						tileData.uv4_y = (ushort)DAT_88[num + 6] >> 8;
						num += 8;
						tileData = VigTerrain.instance.tileData[++num3];
					}
					while (num != num2);
					DAT_84_2 = dAT_84_ + 1;
				}
				while (DAT_80_2 < 0);
			}
			DAT_14C0 = (int)GameManager.FUN_2AC5C();
			break;
		case 1:
		{
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.5f;
			GameManager.instance.aspectRatioScale = 240f;
			flags = 128u;
			id = 1;
			short[] dAT_ = FUN_100(50);
			ChangeTiles();
			DAT_88 = dAT_;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			DAT_14C8 = 0;
			goto case 2;
		}
		case 2:
			GameManager.instance.FUN_34B34();
			GameManager.instance.FUN_30CB0(this, 240);
			break;
		}
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, Vector3Int arg3)
	{
		if (arg2 == 10 && arg1.type == 9)
		{
			DAT_14C0++;
			if ((DAT_14C0 & 0xF) == 0)
			{
				VigObject vigObject = Utilities.FUN_2CD78(arg1);
				ushort param;
				if (vigObject.physics1.W < 3814)
				{
					param = 395;
				}
				else
				{
					param = 394;
					if ((arg1.flags & 0x10000000) != 0)
					{
						param = 393;
					}
				}
				Ballistic obj = LevelManager.instance.xobfList[42].ini.FUN_2C17C(param, typeof(Ballistic), 8u) as Ballistic;
				obj.type = 7;
				obj.flags = 36u;
				obj.screen = arg3;
				short y = Utilities.FUN_2A27C(vigObject.vTransform.rotation);
				obj.vr.y = y;
				obj.FUN_3066C();
			}
		}
		return 0u;
	}

	public override sbyte UpdateW(VigObject arg1, int arg2, TileData arg3)
	{
		if (arg2 == 12)
		{
			int num = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(num, LevelManager.instance.xobfList[42].sndList, 5, 0u, param5: true);
			return (sbyte)num;
		}
		return 0;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 25 && arg2.type == 3 && ids.Contains(arg2.id))
		{
			((Pickup)arg2).cannotReach = true;
		}
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		if (arg2 == 18)
		{
			if (arg1.id == 97)
			{
				VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(97);
				if (vigTuple != null)
				{
					LevelManager.instance.FUN_359CC(vigTuple.array, 36736u);
				}
			}
			GameManager.instance.FUN_327CC(arg1);
		}
		return 0u;
	}

	private static void ChangeTiles()
	{
		int[] source = new int[6]
		{
			189,
			167,
			166,
			165,
			48,
			11
		};
		for (int i = 0; i < VigTerrain.instance.tileData.Count; i++)
		{
			if (source.Contains(i))
			{
				VigTerrain.instance.tileData[i].DAT_10[1] = 255;
			}
		}
	}

	private static short[] FUN_100(int param1)
	{
		short[] array = new short[4];
		short[] array2 = new short[256];
		LevelManager.instance.FUN_21594(array, 138, 0, 30788);
		int num = param1;
		if (param1 < 0)
		{
			num = param1 + 15;
		}
		uint num2 = (ushort)LevelManager.instance.DAT_DBA;
		uint num3 = 0u;
		int num4 = 0;
		do
		{
			uint num5 = num3;
			if ((int)num3 < 0)
			{
				num5 = num3 + 3;
			}
			uint num6 = num3 & 2;
			int num7 = (param1 + (num >> 4) * -16) * (int)num2 + array[0] * 2 + (((int)num5 >> 2) * 2 + (int)(num3 & 1)) * (ushort)LevelManager.instance.DAT_DBA / 2;
			num3++;
			num5 = (uint)((num >> 4) * (int)num2 + array[1] + ((int)(num6 * (ushort)LevelManager.instance.DAT_DBA) >> 2));
			ushort num8 = (ushort)((ushort)((int)(num5 & 0x100) >> 4) | ((ushort)(num7 - (num7 >> 31) >> 7) & 0xF) | 0x80 | (ushort)((num5 & 0x200) << 2));
			short num9 = (short)(((ushort)num7 & 0x7F) + (short)num5 * 256);
			ushort num10 = (ushort)((uint)(ushort)LevelManager.instance.DAT_DBA >> 1);
			short num11 = (short)(num10 - 1);
			array2[num4 + 7] = (short)num8;
			array2[num4 + 5] = (short)num8;
			array2[num4 + 3] = (short)num8;
			array2[num4 + 1] = (short)num8;
			array2[num4 + 4] = num9;
			array2[num4] = (short)(num9 + num11 * 256);
			array2[num4 + 2] = (short)(array2[num4 + 4] + num11 * 257);
			array2[num4 + 6] = (short)(array2[num4 + 4] - 1 + (short)num10);
			num4 += 8;
		}
		while ((int)num3 < 32);
		return array2;
	}
}
