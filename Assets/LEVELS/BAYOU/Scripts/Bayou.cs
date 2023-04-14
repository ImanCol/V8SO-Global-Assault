using System.Linq;
using UnityEngine;

public class Bayou : VigObject
{
	private static short[] ids = new short[7]
	{
		307,
		309,
		310,
		312,
		313,
		314,
		324
	};

	public static Bayou instance;

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
		flags |= 8192u;
		GameManager.instance.FUN_17F34(51200, 2147418112);
		if (instance == null)
		{
			instance = this;
		}
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 1)
		{
			switch (arg1)
			{
			case 2:
				break;
			default:
				return 0u;
			case 17:
				GameManager.instance.FUN_17EB8();
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
			FUN_7F0(129);
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			int num = (int)GameManager.FUN_2AC5C();
			param = GameManager.instance.FUN_31EDC((num * 5 >> 15) + 1200);
			param.FUN_3066C();
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
			GameManager.instance.FUN_327CC(arg1);
			break;
		case 19:
		{
			uint num = 0u;
			VigObject vigObject = GameManager.instance.FUN_31994(typeof(Mansion));
			if (vigObject != null && vigObject.tags == 1)
			{
				num = 1u;
				vigObject = GameManager.instance.FUN_31994(typeof(Mausoleum));
			}
			ConfigContainer configContainer = vigObject.FUN_2C5F4(32770);
			arg1.vTransform = GameManager.instance.FUN_2CEAC(vigObject, configContainer);
			int num2 = arg1.vTransform.rotation.V02 * 9155;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.X = num2 >> 5;
			num2 = arg1.vTransform.rotation.V12 * 9155;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.Y = num2 >> 5;
			num2 = arg1.vTransform.rotation.V22 * 9155;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.Z = num2 >> 5;
			arg1.physics2.X = 0;
			arg1.physics2.Y = 0;
			arg1.physics2.Z = 0;
			if (vigObject.tags == 0 && vigObject.DAT_1A == 52)
			{
				arg1.physics1.X = -arg1.physics1.X;
				arg1.physics1.Z = -arg1.physics1.Z;
			}
			arg1.screen = arg1.vTransform.position;
			arg1.vr = configContainer.v3_2;
			arg1.vr.y += vigObject.vr.y;
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, arg1.vTransform.position);
			arg1.ApplyTransformation();
			Vehicle vehicle = (Vehicle)arg1;
			if (vehicle.vCamera != null)
			{
				VigObject param2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (int)(num | 0x7D0));
				VigCamera vigCamera = LevelManager.instance.FUN_4B984(vehicle, param2);
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
		}
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, Vector3Int arg3)
	{
		if (arg2 == 10)
		{
			if (arg1.type != 9)
			{
				return 0u;
			}
			Vehicle vehicle = Utilities.FUN_2CD78(arg1) as Vehicle;
			if (vehicle.physics1.W < 4577 && (!(arg1.GetType() == typeof(Wheel)) || ((Wheel)arg1).state != _WHEEL_TYPE.Flatten))
			{
				if ((vehicle.flags & 0x20000) == 0)
				{
					Mud mud = new GameObject().AddComponent<Mud>();
					mud.type = byte.MaxValue;
					mud.child = vehicle;
					mud.FUN_30B78();
					vehicle.flags |= 131072u;
				}
				if (arg1.physics1.Z - arg1.physics2.X < 15360)
				{
					int num = -vehicle.physics1.W + 4577;
					if (num < 0)
					{
						num = -vehicle.physics1.W + 4584;
					}
					arg1.physics2.X -= num >> 3;
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
						return 0u;
					}
					wheel = vehicle.wheels[5];
				}
				if (wheel == null)
				{
					return 0u;
				}
				wheel.physics2.X = wheel.physics1.Z + arg1.physics1.X - arg1.physics1.Z;
			}
		}
		return 0u;
	}

	public override sbyte UpdateW(VigObject arg1, int arg2, TileData arg3)
	{
		if (arg2 == 12)
		{
			int num = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(num, LevelManager.instance.xobfList[42].sndList, 4, 0u, param5: true);
			return (sbyte)num;
		}
		return 0;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 25 && (GameManager.instance.gameMode == _GAME_MODE.Survival || GameManager.instance.gameMode == _GAME_MODE.Survival2) && arg2.DAT_1A == 0 && arg2.type == 3 && ids.Contains(arg2.id))
		{
			arg2.screen.y -= 98304;
			((Pickup)arg2).cannotReach = true;
		}
		return 0u;
	}

	public static void FUN_7F0(int param1)
	{
		Cage cage = null;
		int num = (int)GameManager.FUN_2AC5C();
		int num2 = param1 + (num * 5 >> 15);
		num = num2;
		if (134 < num2)
		{
			num2 -= 6;
			num = num2;
		}
		while (true)
		{
			if (num != param1)
			{
				cage = (GameManager.instance.FUN_31EDC(num) as Cage);
				if (cage != null)
				{
					break;
				}
			}
			int num3 = num + 1;
			if (134 < num3)
			{
				num3 = num - 5;
			}
			num = num3;
			if (num3 == num2)
			{
				if (!(cage == null))
				{
					break;
				}
				cage = (GameManager.instance.FUN_31EDC(param1) as Cage);
				num = param1;
				if (!(cage == null))
				{
					break;
				}
				return;
			}
		}
		cage.id = 100;
		cage.type = 4;
		cage.flags |= 256u;
		cage.FUN_3066C();
		cage.DAT_19 = (byte)num;
		cage.tags = 0;
		cage.physics2.Z = cage.vTransform.position.y;
		Cage cage2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, num) as Cage;
		if (cage2 != null)
		{
			cage2.DAT_8C = cage;
			cage.DAT_8C = cage2;
		}
		ConfigContainer configContainer = cage.FUN_2C5F4(32768);
		if (configContainer != null)
		{
			VigObject vigObject = cage.DAT_90 = cage.vData.ini.FUN_2C17C(19, typeof(VigObject), 8u);
			if (vigObject != null)
			{
				vigObject.vTransform = GameManager.instance.FUN_2CEAC(cage, configContainer);
				cage.DAT_90.flags = 52u;
				cage.DAT_90.FUN_305FC();
				int num4 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(num4, cage.vData.sndList, 2, cage.DAT_90.vTransform.position);
				GameManager.instance.FUN_1E30C(num4, 2304);
			}
		}
	}
}
