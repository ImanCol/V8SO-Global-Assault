using UnityEngine;

public class Beamup : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint OnCollision(HitDetection hit)
	{
		if (hit.self.type == 2)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
			{
				VigCamera vCamera = vehicle.vCamera;
				GameManager.instance.FUN_309A0(PDAT_74);
				flags |= 32u;
				PDAT_78 = hit.self;
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, vData.sndList, 0, screen);
				GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
				vehicle.state = _VEHICLE_TYPE.Beamup;
				vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000000);
				vehicle.physics1.X = (screen.x - vehicle.vTransform.position.x) * 128 / 120;
				vehicle.physics1.Y = (screen.y - vehicle.vTransform.position.y) * 128 / 120;
				vehicle.physics1.Z = (screen.z - vehicle.vTransform.position.z) * 128 / 120;
				vehicle.physics2.X = 0;
				vehicle.physics2.Y = 32768;
				vehicle.physics2.Z = 0;
				if (vCamera != null)
				{
					int num = vCamera.vTransform.rotation.V02 * -1525;
					vCamera.flags |= 201326592u;
					if (num < 0)
					{
						num += 4095;
					}
					vCamera.DAT_84.x = num >> 12;
					vCamera.DAT_84.y = -3051;
					num = vCamera.vTransform.rotation.V22 * -1525;
					if (num < 0)
					{
						num += 4095;
					}
					vCamera.DAT_84.z = num >> 12;
				}
				flags &= 4294967293u;
				FUN_30C68();
				FUN_2C05C();
				FUN_30BF0();
				return uint.MaxValue;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		int param;
		if (arg1 == 2)
		{
			sbyte tags = base.tags;
			if (tags == 1)
			{
				GameManager.instance.FUN_309A0(PDAT_74);
				GameManager.instance.FUN_30CB0(this, 1800);
				base.tags = 0;
				flags |= 32u;
				return 0u;
			}
			if (tags < 2)
			{
				if (tags == 0)
				{
					Beamup2 beamup = vData.ini.FUN_2C17C(758, typeof(Beamup2), 8u) as Beamup2;
					beamup.screen.x = screen.x;
					beamup.screen.y = screen.y - 81920;
					beamup.screen.z = screen.z;
					beamup.FUN_3066C();
					PDAT_74 = beamup;
					flags &= 4294967263u;
					GameManager.instance.FUN_30CB0(this, 900);
					base.tags = 1;
					return 0u;
				}
				return 0u;
			}
			if (tags != 2)
			{
				return 0u;
			}
			Vehicle obj = (Vehicle)PDAT_78;
			Ballistic ballistic = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(Ballistic), 8u) as Ballistic;
			ballistic.flags = 36u;
			VigObject pDAT_ = PDAT_74;
			ballistic.screen = pDAT_.screen;
			ballistic.FUN_3066C();
			UIManager.instance.FUN_4E414(ballistic.screen, new Color32(0, byte.MaxValue, 0, 8));
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, vData.sndList, 0, ballistic.screen);
			obj.vTransform.position.x = ballistic.screen.x;
			obj.vTransform.position.y = ballistic.screen.y - 409600;
			obj.vTransform.position.z = ballistic.screen.z;
			obj.physics1.X = 0;
			obj.physics1.Y = 0;
			obj.physics1.Z = 0;
			obj.flags &= 4194303965u;
			obj.FUN_41FEC();
			param = 1800;
			base.tags = 0;
		}
		else
		{
			if (arg1 >= 3)
			{
				return 0u;
			}
			if (arg1 != 1)
			{
				return 0u;
			}
			param = 1800;
			type = 3;
			flags = 34u;
		}
		GameManager.instance.FUN_30CB0(this, param);
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 != 5)
		{
			return 0u;
		}
		if (this != arg2)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)PDAT_78;
		VigCamera vCamera = vehicle.vCamera;
		flags |= 2u;
		FUN_30C20();
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 42, screen);
		UIManager.instance.FUN_4E414(screen, new Color32(0, byte.MaxValue, 0, 8));
		vehicle.flags |= 34u;
		int num = (int)GameManager.FUN_2AC5C();
		VigObject vigObject = PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (num * 3 >> 15) - 25);
		vehicle.physics1.X = (vigObject.screen.x - vehicle.vTransform.position.x) * 128 / 300;
		vehicle.physics1.Y = (PDAT_74.screen.y - (vehicle.vTransform.position.y + 409600)) * 128 / 300;
		vehicle.physics1.Z = (PDAT_74.screen.z - vehicle.vTransform.position.z) * 128 / 300;
		vehicle.physics2.M2 = 0;
		if (vCamera != null)
		{
			vCamera.flags &= 4227858431u;
		}
		tags = 2;
		param = 300;
		GameManager.instance.FUN_30CB0(this, param);
		return 0u;
	}
}
