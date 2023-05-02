using UnityEngine;

public class HOOVRDAM : VigObject
{
	private static Vector3Int DAT_A0_2 = new Vector3Int(0, 0, 0);

	public static HOOVRDAM instance;

	public int DAT_1C30;

	public int DAT_80_2;

	public uint DAT_84_2;

	public short[] DAT_88;

	public Thunder2 DAT_90;

	public int destroyedObjects;

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
			flags |= 8192u;
			vData = LevelManager.instance.xobfList[42];
		}
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int num4;
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
						num4 = (((DAT_88[num + 1] & 1) != 0) ? 128 : 0);
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
			DAT_1C30 = (int)GameManager.FUN_2AC5C();
			if (((GameManager.instance.DAT_28 - DAT_19) & 0xFFF) >= 127)
			{
				break;
			}
			num4 = (int)GameManager.FUN_2AC5C();
			if ((num4 & 0x1F) == 0)
			{
				UIManager.instance.FUN_4E338(new Color32(128, 128, 128, 10));
				if (!DAT_90.trigger && DAT_90.DAT_18 == 0)
				{
					num4 = (int)GameManager.FUN_2AC5C();
					DAT_90.tags = (sbyte)(num4 & 1);
					DAT_90.trigger = true;
					GameManager.instance.FUN_30CB0(DAT_90, (DAT_90.tags ^ 1) * 180);
				}
			}
			break;
		}
		case 1:
		{
			GameObject gameObject = new GameObject();
			DAT_90 = gameObject.AddComponent<Thunder2>();
			DAT_90.flags = 128u;
			GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, DAT_90);
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.4f;
			GameManager.instance.aspectRatioScale = 240f;
			flags = 128u;
			DAT_19 = (byte)GameManager.FUN_2AC5C();
			short[] array = DAT_88 = FUN_1A0(50);
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			id = 1;
			goto case 2;
		}
		case 2:
			GameManager.instance.FUN_34B34();
			GameManager.instance.FUN_30CB0(this, 240);
			break;
		case 4:
			DAT_88 = null;
			break;
		}
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, Vector3Int arg3)
	{
		if (arg2 == 10)
		{
			uint result;
			if ((uint)(arg3.z + -82575360) < 5505025u)
			{
				result = 0u;
				if (arg1.type == 9)
				{
					DAT_1C30++;
					result = 0u;
					if ((DAT_1C30 & 0xF) == 0)
					{
						Vehicle vehicle = (Vehicle)Utilities.FUN_2CD78(arg1);
						Ballistic ballistic;
						if (vehicle.physics1.W < 3814)
						{
							ballistic = (vData.ini.FUN_2C17C(607, typeof(Ballistic), 8u) as Ballistic);
						}
						else
						{
							result = 606u;
							if ((arg1.flags & 0x10000000) != 0)
							{
								result = 605u;
							}
							ballistic = (vData.ini.FUN_2C17C((ushort)result, typeof(Ballistic), 8u) as Ballistic);
							short y = Utilities.FUN_2A27C(vehicle.vTransform.rotation);
							ballistic.vr.y = y;
						}
						ballistic.type = 7;
						ballistic.flags = 36u;
						ballistic.screen = arg3;
						ballistic.FUN_3066C();
						result = 0u;
					}
				}
			}
			else
			{
				Vehicle vehicle = (Vehicle)Utilities.FUN_2CDB0(arg1);
				result = 0u;
				if ((vehicle.flags & 0x24000000) == 536870912 && (vehicle.flags & 0x4000) != 0)
				{
					vehicle.FUN_3A020(-150, DAT_A0_2, param3: false);
					FUN_510(vehicle.vTransform.position, vData, 609, 608, 0, 4, 60);
					VigObject vigObject = vehicle.child2;
					while (vigObject != null)
					{
						if (vigObject.vMesh != null)
						{
							vigObject.vMesh.DAT_02 = 64;
						}
						vigObject = vigObject.child;
					}
					if (vehicle.vLOD != null)
					{
						vehicle.vLOD.DAT_02 = 64;
					}
					sbyte b = (sbyte)vehicle.DAT_DF;
					if (b == 0)
					{
						b = (sbyte)GameManager.instance.FUN_1DD9C();
						vehicle.DAT_DF = (byte)b;
					}
					GameManager.instance.FUN_1E098(b, LevelManager.instance.xobfList[42].sndList, 2, 0u, param5: true);
					GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
					vehicle.state = _VEHICLE_TYPE.Dam;
					vehicle.tags = 0;
					vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
					int num = (int)GameManager.FUN_2AC5C();
					vehicle.DAT_DE = (byte)((num << 2 >> 15) + 60);
					vehicle.physics1.X = 0;
					vehicle.physics1.Y = 117120;
					vehicle.physics1.Z = 0;
					GameManager.instance.FUN_30CB0(vehicle, 60);
					VigCamera vCamera = vehicle.vCamera;
					result = 0u;
					if (vCamera != null)
					{
						int[] array = new int[16];
						VigObject vigObject2 = GameManager.instance.FUN_31950(vehicle.DAT_DE);
						array[0] = vCamera.screen.x;
						array[1] = vCamera.screen.y;
						array[2] = vCamera.screen.z;
						array[3] = 120;
						array[4] = 60751872;
						array[6] = 88539136;
						array[5] = 2160640;
						array[7] = 360;
						array[8] = vigObject2.screen.x;
						array[9] = vigObject2.screen.y - 73728;
						array[10] = vigObject2.screen.z + 327680;
						array[11] = 0;
						vCamera.FUN_4BDC4(array);
						result = 0u;
					}
				}
			}
			return result;
		}
		return 0u;
	}

	public override sbyte UpdateW(VigObject arg1, int arg2, TileData arg3)
	{
		if (arg2 == 12)
		{
			int num = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(num, vData.sndList, 6, 0u, param5: true);
			return (sbyte)num;
		}
		return 0;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		if (arg2 == 18)
		{
			if (arg3 == 0 || arg1.type != 8 || GameManager.instance.terrain.GetTileByPosition((uint)arg1.vTransform.position.x, (uint)arg1.vTransform.position.z).DAT_10[3] != 1)
			{
				if (arg1.type == 0)
				{
					destroyedObjects++;
				}
				GameManager.instance.FUN_327CC(arg1);
				return 0u;
			}
			FUN_510(arg1.vTransform.position, vData, 609, 608, 0, 4, 60);
			return 0u;
		}
		return 0u;
	}

	private static Water2 FUN_510(Vector3Int param1, XOBF_DB param2, ushort param3, short param4, int param5, short param6, int param7)
	{
		Water2 water = param2.ini.FUN_2C17C(param3, typeof(Water2), 8u) as Water2;
		water.vTransform = GameManager.FUN_2A39C();
		water.vTransform.position = param1;
		water.DAT_58 = 32768;
		water.DAT_98 = param2;
		water.physics2.M3 = param4;
		water.flags |= 164u;
		water.physics1.M1 = param6;
		water.FUN_305FC();
		GameManager.instance.FUN_30CB0(water, param7);
		int param8 = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param8, param2.sndList, param5, param1);
		return water;
	}

	private static short[] FUN_1A0(int param1)
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
