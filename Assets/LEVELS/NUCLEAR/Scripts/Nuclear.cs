using UnityEngine;

public class Nuclear : VigObject
{
	public static Nuclear instance;

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
		flags |= 8192u;
		GameManager.instance.FUN_17F34(409600, 134217727);
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
			GameManager.instance.DAT_1000 |= 1;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
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
			int num = 2147418112;
			VigObject vigObject = null;
			int num2 = 0;
			VigTuple2 vigTuple = GameManager.instance.FUN_2FF3C((uint)arg1.vTransform.position.x, (uint)arg1.vTransform.position.z);
			if (vigTuple != null && (uint)((ushort)vigTuple.id - 1) < 2u)
			{
				num2 = ((vigTuple.id - 1) ^ 1) + 514;
				vigObject = GameManager.instance.FUN_31950(num2);
			}
			if (vigObject == null)
			{
				int num3 = 0;
				do
				{
					VigObject vigObject2 = GameManager.instance.FUN_31950(num3 + 49);
					if (vigObject2 != null)
					{
						int num4 = Utilities.FUN_29F6C(arg1.vTransform.position, vigObject2.vTransform.position);
						if (num4 < num)
						{
							num2 = num3 + 512;
							vigObject = vigObject2;
							num = num4;
						}
					}
					num3++;
				}
				while (num3 < 2);
			}
			ConfigContainer param = vigObject.FUN_2C5F4(32768);
			arg1.vTransform = GameManager.instance.FUN_2CEAC(vigObject, param);
			arg1.physics1.X = 0;
			arg1.physics1.Y = 0;
			arg1.physics1.Z = 0;
			int num5 = arg1.vTransform.rotation.V02 * 7629;
			if (num5 < 0)
			{
				num5 += 31;
			}
			arg1.physics1.X = num5 >> 5;
			num5 = arg1.vTransform.rotation.V12 * 7629;
			if (num5 < 0)
			{
				num5 += 31;
			}
			arg1.physics1.Y = num5 >> 5;
			num5 = arg1.vTransform.rotation.V22 * 7629;
			if (num5 < 0)
			{
				num5 += 31;
			}
			arg1.physics1.Z = num5 >> 5;
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param2, GameManager.instance.DAT_C2C, 37, arg1.vTransform.position);
			Vehicle vehicle = (Vehicle)arg1;
			vehicle.state = _VEHICLE_TYPE.NuclearTunnel;
			vehicle.flags |= 67108864u;
			GameManager.instance.FUN_30CB0(vehicle, 30);
			if (vehicle.vCamera != null)
			{
				VigObject param3 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, num2);
				VigCamera vigCamera = LevelManager.instance.FUN_4B984(vehicle, param3);
				vigCamera.maxHalfHealth = 256;
				vehicle.vCamera.flags &= 4227858431u;
				GameManager.instance.FUN_30CB0(vehicle.vCamera, 90);
				vehicle.vCamera = vigCamera;
				LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
				vigCamera.FUN_30B78();
			}
			return uint.MaxValue;
		}
		}
		return 0u;
	}
}
