using System.Linq;
using UnityEngine;

public class SteelMil : VigObject
{
	private static short[] ids = new short[1]
	{
		301
	};

	public static SteelMil instance;

	public int DAT_4600;

	public int DAT_4614;

	public byte[] DAT_4618 = new byte[20];

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
		GameManager.instance.FUN_17F34(92160, 92471296);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 1)
		{
			switch (arg1)
			{
			case 2:
				break;
			case 17:
				GameManager.instance.FUN_17EB8();
				return 0u;
			default:
				return 0u;
			}
		}
		else
		{
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.4f;
			GameManager.instance.aspectRatioScale = 240f;
			Color32 dAT_DE = LevelManager.instance.DAT_DE0;
			dAT_DE.a = 128;
			UIManager.instance.underwater.color = dAT_DE;
			FUN_34FC();
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			DAT_4600 = 0;
			LevelManager.instance.FUN_359FC(65063955, 92026473, 0u);
		}
		GameManager.instance.FUN_34B34();
		GameManager.instance.FUN_30CB0(this, 240);
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		switch (arg2)
		{
		case 18:
			if (arg3 != 0 && arg1.type == 8 && GameManager.instance.terrain.GetTileByPosition((uint)arg1.vTransform.position.x, (uint)arg1.vTransform.position.z).DAT_10[3] == 1)
			{
				Spark spark = new GameObject().AddComponent<Spark>();
				VigObject vigObject2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C(153, typeof(VigObject), 8u);
				Utilities.ParentChildren(vigObject2, vigObject2);
				VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(51, typeof(VigObject), 8u);
				Utilities.ParentChildren(vigObject, vigObject);
				VigObject vigObject3 = GameManager.instance.FUN_320DC(arg1.vTransform.position, 0);
				vigObject.vTransform = GameManager.FUN_2A39C();
				vigObject2.vTransform = GameManager.FUN_2A39C();
				vigObject2.flags = 16u;
				Utilities.FUN_2CC9C(spark, vigObject2);
				vigObject2.transform.parent = spark.transform;
				Utilities.FUN_2CC9C(spark, vigObject);
				vigObject.transform.parent = spark.transform;
				spark.flags = 132u;
				spark.type = 3;
				spark.screen = arg1.vTransform.position;
				VigCollider vCollider = new VigCollider(vigObject2.vCollider.reader.GetBuffer());
				spark.physics1.M6 = 4096;
				spark.vCollider = vCollider;
				Utilities.FUN_2A168(out Vector3Int vout, arg1.vTransform.position, vigObject3.vTransform.position);
				int num = vout.x * 3051;
				if (num < 0)
				{
					num += 4095;
				}
				spark.physics1.X = num >> 12;
				spark.physics1.Y = 0;
				num = vout.z * 3051;
				if (num < 0)
				{
					num += 4095;
				}
				spark.physics1.Z = num >> 12;
				spark.FUN_3066C();
				sbyte param3 = spark.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param3, LevelManager.instance.xobfList[42].sndList, 0, arg1.vTransform.position, param5: true);
				return 0u;
			}
			GameManager.instance.FUN_327CC(arg1);
			return 0u;
		case 19:
		{
			int num = (int)GameManager.FUN_2AC5C();
			VigObject vigObject = GameManager.instance.FUN_318D0((num * 3 >> 15) + 40);
			ConfigContainer param = vigObject.FUN_2C5F4(32768);
			arg1.vTransform = GameManager.instance.FUN_2CEAC(vigObject, param);
			arg1.screen = arg1.vTransform.position;
			num = arg1.vTransform.rotation.V02 * 7629;
			arg1.flags |= 32u;
			if (num < 0)
			{
				num += 31;
			}
			arg1.physics1.X = num >> 5;
			num = arg1.vTransform.rotation.V12 * 7629;
			if (num < 0)
			{
				num += 31;
			}
			arg1.physics1.Y = num >> 5;
			num = arg1.vTransform.rotation.V22 * 7629;
			if (num < 0)
			{
				num += 31;
			}
			arg1.physics1.Z = num >> 5;
			arg1.physics2.X = 0;
			arg1.physics2.Y = 0;
			arg1.physics2.Z = 0;
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param2, GameManager.instance.DAT_C2C, 37, arg1.vTransform.position);
			Vehicle vehicle = (Vehicle)arg1;
			VigCamera vCamera = vehicle.vCamera;
			if (vCamera != null)
			{
				vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, vigObject.id + 472);
				vigObject.tags = 90;
				vigObject.maxHalfHealth = 256;
				GameManager.instance.FUN_30CB0(vCamera, vigObject.tags);
				vCamera.screen = vigObject.screen;
				VigCamera vigCamera = vehicle.vCamera = LevelManager.instance.FUN_4B984(vehicle, vigObject);
				LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
				vigCamera.FUN_30B78();
			}
			vehicle.state = _VEHICLE_TYPE.MilTunnel;
			GameManager.instance.FUN_30CB0(vehicle, 30);
			return uint.MaxValue;
		}
		default:
			return 0u;
		}
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 25 && arg2.type == 3 && ids.Contains(arg2.id))
		{
			((Pickup)arg2).cannotReach = true;
		}
		return 0u;
	}

	private static void FUN_34FC()
	{
		int num = 0;
		if (0 >= LevelManager.instance.DAT_1184)
		{
			return;
		}
		do
		{
			JUNC_DB jUNC_DB = LevelManager.instance.juncList[num];
			if (jUNC_DB.DAT_18 != null && (jUNC_DB.DAT_10 & 0x40) != 0)
			{
				int num2 = (jUNC_DB.DAT_16 & 0xFFF) * 2;
				int num3 = -GameManager.DAT_65C90[num2];
				num2 = GameManager.DAT_65C90[num2 + 1];
				int num4 = jUNC_DB.DAT_11 - 1;
				if (-1 < num4)
				{
					do
					{
						RSEG_DB rSEG_DB = jUNC_DB.DAT_1C[num4];
						int num5 = (jUNC_DB == rSEG_DB.DAT_00[1]) ? 1 : 0;
						long num6 = (long)num2 * (long)rSEG_DB.DAT_10[num5];
						long num7 = (long)num3 * (long)rSEG_DB.DAT_14[num5];
						uint num8 = (uint)num7;
						uint num9 = (uint)((int)num6 + (int)num8);
						int num10 = (int)((ulong)num6 >> 32) + (int)((ulong)num7 >> 32) + ((num9 < num8) ? 1 : 0);
						if (FUN_45C0(num9, num10, 0u, 0) < 1)
						{
							num9 += 4095;
							num10 += ((num9 < 4095) ? 1 : 0);
						}
						num9 = (uint)((int)(num9 >> 12) | (num10 << 20));
						long num11 = (long)num2 * (long)(int)num9;
						num8 = (uint)num11;
						num10 = (int)((ulong)num11 >> 32);
						if (FUN_45C0(num8, num10, 0u, 0) < 1)
						{
							num8 += 4095;
							num10 += ((num8 < 4095) ? 1 : 0);
						}
						long num12 = (long)num3 * (long)(int)num9;
						num9 = (uint)num12;
						int num13 = (int)((ulong)num12 >> 32);
						rSEG_DB.DAT_10[num5] = ((int)(num8 >> 12) | (num10 << 20));
						if (FUN_45C0(num9, num13, 0u, 0) < 1)
						{
							num9 += 4095;
							num13 += ((num9 < 4095) ? 1 : 0);
						}
						rSEG_DB.DAT_14[num5] = ((int)(num9 >> 12) | (num13 << 20));
						rSEG_DB.FUN_50EFC();
						num4--;
					}
					while (-1 < num4);
				}
			}
			num++;
		}
		while (num < LevelManager.instance.DAT_1184);
	}

	private static int FUN_45C0(uint param1, int param2, uint param3, int param4)
	{
		int result = 0;
		if (param4 <= param2)
		{
			result = 2;
			if (param2 <= param4)
			{
				if (param1 < param3)
				{
					result = 0;
				}
				else
				{
					result = 2;
					if (param1 <= param3)
					{
						result = 1;
					}
				}
			}
		}
		return result;
	}
}
