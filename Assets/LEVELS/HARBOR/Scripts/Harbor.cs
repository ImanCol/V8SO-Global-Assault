using UnityEngine;

public class Harbor : VigObject
{
	public static Harbor instance;

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
		GameManager.instance.FUN_17F34(122880, 2147418112);
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
			CraneSmall craneSmall = null;
			int num2 = 113;
			do
			{
				CraneSmall craneSmall2 = GameManager.instance.FUN_30250(GameManager.instance.worldObjs, num2) as CraneSmall;
				if (craneSmall2 != null && craneSmall2.tags == 0)
				{
					int num3 = Utilities.FUN_29F6C(arg1.vTransform.position, craneSmall2.vTransform.position);
					if (num3 < num)
					{
						craneSmall = craneSmall2;
						num = num3;
					}
				}
				num2++;
			}
			while (num2 < 116);
			if (craneSmall == null)
			{
				craneSmall = (GameManager.instance.FUN_30250(GameManager.instance.worldObjs, 113) as CraneSmall);
			}
			else
			{
				craneSmall.DAT_A4 = 30;
				craneSmall.tags = 1;
				craneSmall.DAT_80 = arg1;
				craneSmall.DAT_B4 = 7;
				craneSmall.FUN_30B78();
				sbyte param = craneSmall.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, craneSmall.vData.sndList, 1, craneSmall.vTransform.position, param5: true);
			}
			VigObject child = craneSmall.child2.child2.child2;
			ConfigContainer param2 = child.FUN_2C5F4(32768);
			arg1.vTransform = GameManager.instance.FUN_2CEAC(child, param2);
			num2 = GameManager.instance.DAT_DB0 + 61440;
			num = GameManager.instance.terrain.FUN_1B750((uint)arg1.vTransform.position.x, (uint)arg1.vTransform.position.z);
			int y = num - 40960;
			if (num2 < num - 40960)
			{
				y = num2;
			}
			arg1.vTransform.position.y = y;
			arg1.physics1.X = 0;
			arg1.physics1.Y = 0;
			arg1.physics1.Z = 0;
			arg1.physics2.X = 0;
			arg1.physics2.Y = 0;
			arg1.physics2.Z = 0;
			int param3 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param3, GameManager.instance.DAT_C2C, 37, arg1.vTransform.position);
			Vehicle vehicle = (Vehicle)arg1;
			vehicle.state = _VEHICLE_TYPE.Harbor;
			GameManager.instance.FUN_30CB0(vehicle, 60);
			vehicle.flags &= 4261412863u;
			if (vehicle.vCamera != null)
			{
				GameManager.instance.FUN_30CB0(vehicle.vCamera, 1);
			}
			return uint.MaxValue;
		}
		}
		return 0u;
	}
}
