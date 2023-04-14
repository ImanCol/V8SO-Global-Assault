using System.Collections.Generic;
using UnityEngine;

public class Oilfield : VigObject
{
	private static Vector3Int glacierSpawn = new Vector3Int(84864369, 3007958, 61345153);

	public static Oilfield instance;

	public VigTuple2 DAT_80_2;

	public List<VigTuple>[] DAT_84_2;

	public int DAT_9C;

	public int DAT_A0_2;

	public int DAT_A4;

	public int DAT_A8;

	public int DAT_AC;

	private int DAT_B0;

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
		GameManager.instance.FUN_17F34(133120, 71434240);
		DAT_84_2 = new List<VigTuple>[2]
		{
			new List<VigTuple>(),
			new List<VigTuple>()
		};
		DAT_9C = 0;
		DAT_A0_2 = 0;
		DAT_A4 = 0;
		DAT_A8 = 65536;
		DAT_AC = 32768;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.4f;
			GameManager.instance.aspectRatioScale = 240f;
			LevelManager.instance.FUN_359FC(82247680, 69009408, 0u);
			LevelManager.instance.FUN_359FC(81723392, 69009408, 0u);
			Color32 dAT_DE = LevelManager.instance.DAT_DE0;
			dAT_DE.a = 128;
			UIManager.instance.underwater.color = dAT_DE;
			VigTuple2 vigTuple = DAT_80_2 = GameManager.instance.FUN_2FFD0(1);
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			goto case 2;
		}
		case 2:
		{
			GameManager.instance.FUN_34B34();
			GameManager.instance.FUN_30CB0(this, 240);
			int num = 0;
			while (DAT_A4 <= 16 && num < 3)
			{
				int num2 = Random.Range(0, 3);
				GlacierSmall glacierSmall = LevelManager.instance.xobfList[42].ini.FUN_2C17C((ushort)Glacier.DAT_29D0[num2], typeof(GlacierSmall), 8u) as GlacierSmall;
				int num3 = Random.Range(-40, 41);
				Vector3Int screen = default(Vector3Int);
				screen.x = num3 * DAT_A8 + glacierSpawn.x;
				screen.y = glacierSpawn.y;
				screen.z = glacierSpawn.z;
				glacierSmall.screen = screen;
				glacierSmall.tags = 1;
				glacierSmall.id = (short)DAT_B0;
				glacierSmall.flags |= 128u;
				num2 = Random.Range(-4, 3);
				num3 = Random.Range(0, 21);
				glacierSmall.physics1.X = num2 * DAT_AC;
				glacierSmall.physics1.Z = num3 * DAT_AC;
				short y = (short)GameManager.FUN_2AC5C();
				glacierSmall.vr.y = y;
				num3 = (int)GameManager.FUN_2AC5C();
				GameManager.instance.FUN_30CB0(glacierSmall, (num3 * 840 >> 15) + 1800);
				glacierSmall.FUN_3066C();
				DAT_A4++;
				DAT_B0++;
				num++;
			}
			if (DAT_B0 >= 16)
			{
				DAT_B0 = 0;
			}
			if (DAT_9C != 0)
			{
				return 0u;
			}
			GameManager.FUN_2AC5C();
			int num4 = 166;
			if ((num4 & 1) != 0)
			{
				num4 = 161;
			}
			VigObject x = GameManager.instance.FUN_31EDC(num4);
			x.flags |= 128u;
			x.FUN_3066C();
			DAT_9C++;
			break;
		}
		case 4:
			FUN_4F4(DAT_84_2[0]);
			FUN_4F4(DAT_84_2[1]);
			break;
		case 17:
			GameManager.instance.FUN_17EB8();
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		switch (arg2)
		{
		case 18:
			if (arg3 != 0 && arg1.type == 8 && GameManager.instance.terrain.GetTileByPosition((uint)arg1.vTransform.position.x, (uint)arg1.vTransform.position.z).DAT_10[3] == 1)
			{
				Spark2 spark = new GameObject().AddComponent<Spark2>();
				VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(153, typeof(VigObject), 8u);
				VigObject vigObject2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C(51, typeof(VigObject), 8u);
				int num3 = 1;
				if (DAT_80_2.array[0] <= arg1.vTransform.position.x >> 16 && DAT_80_2.array[1] <= arg1.vTransform.position.z >> 16 && arg1.vTransform.position.x >> 16 <= DAT_80_2.array[0] + DAT_80_2.array[2])
				{
					num3 = ((DAT_80_2.array[1] + DAT_80_2.array[3] < arg1.vTransform.position.z >> 16) ? 1 : 0);
				}
				Mud3 mud = FUN_848(DAT_84_2[num3], arg1.vTransform.position);
				vigObject2.vTransform = GameManager.FUN_2A39C();
				vigObject.vTransform = GameManager.FUN_2A39C();
				vigObject.flags = 16u;
				Utilities.FUN_2CC9C(spark, vigObject);
				Utilities.FUN_2CC9C(spark, vigObject2);
				Utilities.ParentChildren(spark, spark);
				spark.flags = 132u;
				spark.type = 3;
				spark.screen = arg1.vTransform.position;
				spark.physics1.M6 = 4096;
				spark.vCollider = new VigCollider(vigObject.vCollider.reader.GetBuffer());
				Vector3Int n;
				int num4;
				if (mud == null)
				{
					uint num = GameManager.FUN_2AC5C();
					n = default(Vector3Int);
					n.x = (short)(num >> 3);
					n.y = 0;
					num4 = (int)GameManager.FUN_2AC5C();
					n.z = (short)(num4 << 12 >> 15);
					n = Utilities.VectorNormal(n);
				}
				else if (mud.DAT_8C == 0)
				{
					Utilities.FUN_2A168(out n, spark.screen, mud.DAT_88.screen);
				}
				else
				{
					spark.DAT_90 = 0;
					spark.tags = 1;
					spark.DAT_94 = mud;
					Utilities.FUN_2A168(out n, spark.screen, mud.DAT_90[spark.DAT_90]);
				}
				num4 = n.x * 9155;
				if (num4 < 0)
				{
					num4 += 4095;
				}
				spark.physics1.X = num4 >> 12;
				spark.physics1.Y = 0;
				num4 = n.z * 9155;
				if (num4 < 0)
				{
					num4 += 4095;
				}
				spark.physics1.Z = num4 >> 12;
				spark.FUN_3066C();
				return 0u;
			}
			GameManager.instance.FUN_327CC(arg1);
			return 0u;
		case 19:
		{
			uint num = GameManager.FUN_2AC5C();
			int param = 100;
			if ((num & 1) != 0)
			{
				param = 99;
			}
			VigObject vigObject = GameManager.instance.FUN_318D0(param);
			ConfigContainer param2 = vigObject.FUN_2C5F4(32768);
			arg1.vTransform = GameManager.instance.FUN_2CEAC(vigObject, param2);
			int num2 = arg1.vTransform.rotation.V02 * 11444;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.X = num2 >> 5;
			num2 = arg1.vTransform.rotation.V12 * 11444;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.Y = num2 >> 5;
			num2 = arg1.vTransform.rotation.V22 * 11444;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.Z = num2 >> 5;
			arg1.physics2.X = 0;
			arg1.physics2.Y = 0;
			arg1.physics2.Z = 0;
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, arg1.vTransform.position);
			Vehicle vehicle = (Vehicle)arg1;
			if (vehicle.vCamera != null)
			{
				param = 513;
				if (vigObject.id != 99)
				{
					param = 514;
				}
				VigObject param3 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, param);
				VigCamera vigCamera = LevelManager.instance.FUN_4B984(vehicle, param3);
				vigCamera.maxHalfHealth = 256;
				vehicle.vCamera.flags &= 4227858431u;
				GameManager.instance.FUN_30CB0(vehicle.vCamera, 90);
				vehicle.vCamera = vigCamera;
				LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
				vigCamera.FUN_30B78();
			}
			vehicle.FUN_41FEC();
			return uint.MaxValue;
		}
		default:
			return 0u;
		}
	}

	public override uint UpdateW(VigObject arg1, int arg2, Vector3Int arg3)
	{
		Vehicle vehicle;
		int num;
		if (arg2 == 10)
		{
			vehicle = (Vehicle)Utilities.FUN_2CDB0(arg1);
			if (vehicle.wheelsType == _WHEELS.Air)
			{
				return 0u;
			}
			if (arg1.GetType() == typeof(Wheel) && ((Wheel)arg1).state == _WHEEL_TYPE.Flatten)
			{
				return 0u;
			}
			if (arg1.vMesh != null)
			{
				VigTuple2 dAT_80_ = DAT_80_2;
				num = 0;
				if (arg3.x >> 16 < dAT_80_.array[0] || arg3.z >> 16 < dAT_80_.array[1] || dAT_80_.array[0] + dAT_80_.array[2] < arg3.x >> 16 || dAT_80_.array[1] + dAT_80_.array[3] < arg3.z >> 16)
				{
					num = 1;
				}
				if (vehicle.physics1.W < 4577)
				{
					if ((vehicle.flags & 0x20000) == 0)
					{
						Mud2 mud = new GameObject().AddComponent<Mud2>();
						mud.type = byte.MaxValue;
						mud.child = vehicle;
						mud.FUN_30B78();
						vehicle.flags |= 131072u;
					}
					if (arg1.physics1.Z - arg1.physics2.X < 15360)
					{
						int num2 = -vehicle.physics1.W + 4577;
						if (num2 < 0)
						{
							num2 = -vehicle.physics1.W + 4584;
						}
						arg1.physics2.X -= num2 >> 3;
					}
					Wheel wheel;
					if (arg1 == vehicle.wheels[2])
					{
						wheel = vehicle.wheels[4];
					}
					else
					{
						if (arg1 != vehicle.wheels[3])
						{
							goto IL_01eb;
						}
						wheel = vehicle.wheels[5];
					}
					if (wheel != null)
					{
						wheel.physics2.X = wheel.physics1.Z + arg1.physics2.X - arg1.physics1.Z;
					}
				}
				goto IL_01eb;
			}
		}
		return 0u;
		IL_01eb:
		List<VigTuple> list = DAT_84_2[num];
		Mud3 mud2;
		int dAT_;
		for (int i = 0; i < list.Count; i++)
		{
			mud2 = (Mud3)list[i].vObject;
			if (mud2.DAT_88 == vehicle)
			{
				if (GameManager.instance.DAT_28 == mud2.DAT_80_2)
				{
					return 0u;
				}
				dAT_ = GameManager.instance.DAT_28;
				mud2.DAT_8C = 0;
				mud2.DAT_80_2 = dAT_;
				GameManager.instance.FUN_30CB0(mud2, 30);
				return 0u;
			}
		}
		mud2 = new GameObject().AddComponent<Mud3>();
		GameManager.instance.FUN_30080(DAT_84_2[num], mud2);
		mud2.tags = 0;
		mud2.DAT_88 = vehicle;
		mud2.DAT_84_2 = num;
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, LevelManager.instance.xobfList[42].sndList, 0, vehicle.vTransform.position);
		dAT_ = GameManager.instance.DAT_28;
		mud2.DAT_8C = 0;
		mud2.DAT_80_2 = dAT_;
		GameManager.instance.FUN_30CB0(mud2, 30);
		return 0u;
	}

	private static void FUN_4F4(List<VigTuple> param1)
	{
		for (int i = 0; i < param1.Count; i++)
		{
			VigTuple vigTuple = param1[i];
			vigTuple.vObject.FUN_30C68();
			UnityEngine.Object.Destroy(vigTuple.vObject.gameObject);
			vigTuple.vObject = null;
		}
		GameManager.instance.FUN_3001C(param1);
	}

	private static Mud3 FUN_848(List<VigTuple> param1, Vector3Int param2)
	{
		VigObject vigObject = null;
		int num = 2147418112;
		for (int i = 0; i < param1.Count; i++)
		{
			VigTuple vigTuple = param1[i];
			Vehicle dAT_ = ((Mud3)vigTuple.vObject).DAT_88;
			if (dAT_ != null && dAT_.maxHalfHealth != 0)
			{
				int num2 = Utilities.FUN_29F6C(param2, dAT_.screen);
				if (num2 < num)
				{
					vigObject = vigTuple.vObject;
					num = num2;
				}
			}
		}
		return vigObject as Mud3;
	}
}
