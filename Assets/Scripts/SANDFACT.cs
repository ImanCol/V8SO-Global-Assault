using System;

public class SANDFACT : VigObject
{
	public short[] DAT_80_2;

	public uint DAT_84_2;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(1);
			int num = 0;
			uint num2 = 0u;
			short[] array = new short[vigTuple.array[2] * vigTuple.array[3]];
			if (0 < vigTuple.array[3])
			{
				do
				{
					int num3 = 0;
					if (0 < vigTuple.array[2])
					{
						do
						{
							if (VigTerrain.instance.FUN_1CE1C((uint)(vigTuple.array[0] + num3), (uint)(vigTuple.array[1] + num)).DAT_10[3] == 0)
							{
								array[num3 + num * vigTuple.array[2]] = 0;
							}
							else
							{
								uint num4 = (uint)(vigTuple.array[0] + num3);
								uint num5 = (uint)(vigTuple.array[1] + num);
								num4 = (uint)(VigTerrain.instance.vertices[VigTerrain.instance.chunks[((num5 >> 6) * 4 + (num4 >> 6) * 128) / 4u] * 4096 + ((num4 & 0x3F) * 128 + (num5 & 0x3F) * 2) / 2u] & 0x7FF);
								if ((int)num2 < (int)num4)
								{
									num2 = num4;
								}
								array[num3 + num * vigTuple.array[2]] = (short)num4;
							}
							num3++;
						}
						while (num3 < vigTuple.array[2]);
					}
					num++;
				}
				while (num < vigTuple.array[3]);
			}
			num = 0;
			if (0 < vigTuple.array[3])
			{
				do
				{
					short num6 = vigTuple.array[2];
					int num3 = 0;
					if (0 < vigTuple.array[2])
					{
						do
						{
							if (array[num3 + num * num6] != 0)
							{
								uint num4 = (uint)(vigTuple.array[0] + num3);
								uint num5 = (uint)(vigTuple.array[1] + num);
								int num7 = VigTerrain.instance.chunks[((num5 >> 6) * 4 + (num4 >> 6) * 128) / 4u] * 4096 + (int)((num4 & 0x3F) * 128 + (num5 & 0x3F) * 2) / 2;
								ushort num8 = VigTerrain.instance.vertices[num7];
								VigTerrain.instance.vertices[num7] = (ushort)(((int)num2 - (int)(num2 - (num8 & 0x7FF)) / 5) | (num8 & 0xF800));
							}
							num3++;
							num6 = vigTuple.array[2];
						}
						while (num3 < vigTuple.array[2]);
					}
					num++;
				}
				while (num < vigTuple.array[3]);
			}
			DAT_80_2 = array;
			DAT_84_2 = num2;
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.6f;
			GameManager.instance.aspectRatioScale = 240f;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			id = 1;
			goto case 2;
		}
		case 2:
		{
			VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(1);
			short[] dAT_80_ = DAT_80_2;
			int num9 = 0;
			if (0 < vigTuple.array[3])
			{
				do
				{
					short num6 = vigTuple.array[2];
					int num3 = 0;
					if (0 < vigTuple.array[2])
					{
						do
						{
							ushort num8 = (ushort)dAT_80_[num3 + num9 * num6];
							if (num8 != 0)
							{
								uint num2 = (uint)(vigTuple.array[0] + num3);
								uint num4 = (uint)(vigTuple.array[1] + num9);
								int num7 = VigTerrain.instance.chunks[((num4 >> 6) * 4 + (num2 >> 6) * 128) / 4u] * 4096 + (int)((num2 & 0x3F) * 128 + (num4 & 0x3F) * 2) / 2;
								ushort num10 = VigTerrain.instance.vertices[num7];
								if ((uint)num8 < (uint)(num10 & 0x7FF))
								{
									VigTerrain.instance.vertices[num7] = (ushort)(num10 - 1);
								}
							}
							num3++;
							num6 = vigTuple.array[2];
						}
						while (num3 < vigTuple.array[2]);
					}
					num9++;
				}
				while (num9 < vigTuple.array[3]);
			}
			byte b = (byte)tags;
			flags |= 16777216u;
			tags = (sbyte)(b - 1);
			if ((b & 3) == 0)
			{
				GameManager.instance.FUN_34B34();
			}
			GameManager.instance.FUN_30CB0(this, 60);
			return 0u;
		}
		default:
			return 0u;
		case 4:
			DAT_80_2 = null;
			return 0u;
		}
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		if (arg2 == 18)
		{
			if (arg3 == 0 || arg1.type != 8 || (flags & 0x1000000) == 0)
			{
				if (arg1.type == 0 && (uint)((ushort)arg1.id - 114) < 2u)
				{
					VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0((ushort)arg1.id);
					if (vigTuple != null)
					{
						LevelManager.instance.FUN_359CC(vigTuple.array, 0u);
					}
				}
				GameManager.instance.FUN_327CC(arg1);
				return 0u;
			}
			Type type = arg1.GetType();
			if (type == typeof(Flame1) || type == typeof(Flame2) || type == typeof(Flamewall2))
			{
				GameManager.instance.FUN_327CC(arg1);
				return 0u;
			}
			int x = arg1.vTransform.position.x;
			int z = arg1.vTransform.position.z;
			VigTuple2 vigTuple2 = GameManager.instance.FUN_2FF3C((uint)x, (uint)z);
			if (vigTuple2 == null)
			{
				return 0u;
			}
			if (GameManager.instance.terrain.GetTileByPosition((uint)x, (uint)z).DAT_10[3] == 0)
			{
				return 0u;
			}
			uint num = 0u;
			Ballistic ballistic = LevelManager.instance.xobfList[42].ini.FUN_2C17C(84, typeof(Ballistic), 8u) as Ballistic;
			ballistic.type = 7;
			ballistic.flags = 52u;
			int num2 = (int)GameManager.FUN_2AC5C();
			ballistic.screen.x = x + (num2 << 16 >> 15) - 32768;
			x = (int)GameManager.FUN_2AC5C();
			ballistic.screen.z = z + (x << 16 >> 15) - 32768;
			int y = GameManager.instance.terrain.FUN_1B750((uint)ballistic.screen.x, (uint)ballistic.screen.z);
			ballistic.screen.y = y;
			ballistic.FUN_3066C();
			y = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(y, ballistic.vData.sndList, 0, ballistic.screen);
			arg1.flags &= 4278190079u;
			uint num3 = (uint)vigTuple2.array[1];
			bool flag = false;
			if (num3 < (uint)((int)num3 + (int)vigTuple2.array[3]))
			{
				do
				{
					uint num4 = (uint)vigTuple2.array[0];
					uint num5 = num;
					if (num4 < (uint)((int)num4 + (int)vigTuple2.array[2]))
					{
						do
						{
							num = VigTerrain.instance.FUN_1CF5C(num4, num3);
							if ((int)num < (int)num5)
							{
								num = num5;
							}
							num4++;
							num5 = num;
						}
						while (num4 < (uint)(vigTuple2.array[0] + vigTuple2.array[2]));
					}
					num3++;
				}
				while (num3 < (uint)(vigTuple2.array[1] + vigTuple2.array[3]));
				num3 = (uint)vigTuple2.array[1];
			}
			if (num3 < (uint)((int)num3 + (int)vigTuple2.array[3]))
			{
				do
				{
					uint num5 = (uint)vigTuple2.array[0];
					if (num5 < (uint)((int)num5 + (int)vigTuple2.array[2]))
					{
						do
						{
							if (VigTerrain.instance.FUN_1CE1C(num5, num3).DAT_10[3] != 0)
							{
								int num6 = VigTerrain.instance.chunks[((num3 >> 6) * 4 + (num5 >> 6) * 128) / 4u] * 4096 + (int)((num5 & 0x3F) * 128 + (num3 & 0x3F) * 2) / 2;
								ushort num7 = VigTerrain.instance.vertices[num6];
								if ((uint)((num7 + 5) & 0x7FF) < num)
								{
									flag = true;
									VigTerrain.instance.vertices[num6] = (ushort)(num7 + 5);
								}
							}
							num5++;
						}
						while (num5 < (uint)(vigTuple2.array[0] + vigTuple2.array[2]));
					}
					num3++;
				}
				while (num3 < (uint)(vigTuple2.array[1] + vigTuple2.array[3]));
			}
			if (flag)
			{
				return 0u;
			}
			if (vigTuple2.id != 0)
			{
				return 0u;
			}
			LevelManager.instance.FUN_359CC(vigTuple2.array, 36736u);
			GameManager.instance.DAT_10D8.Remove(vigTuple2);
		}
		return 0u;
	}
}
