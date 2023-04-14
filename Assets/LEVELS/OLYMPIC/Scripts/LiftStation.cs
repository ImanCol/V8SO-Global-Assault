public class LiftStation : Destructible
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
		OLYMPIC oLYMPIC = (OLYMPIC)LevelManager.instance.level;
		VigObject self = hit.self;
		if (hit.object1.id == 1 && self.type == 2 && self.id < 0 && (self.flags & 0x3D0900) == 0 && oLYMPIC.DAT_D2 != 0)
		{
			uint num = (uint)vr.y >> 31;
			if (oLYMPIC.DAT_D0 != 0)
			{
				num ^= 1;
			}
			VigObject vigObject = oLYMPIC.DAT_B0[num];
			vigObject.DAT_80 = self;
			((Vehicle)self).state = _VEHICLE_TYPE.Gondola;
			self.flags = (uint)(((int)self.flags & -9) | 0x2000020);
			self.physics1.X = (vigObject.vTransform.position.x - self.vTransform.position.x) * 4;
			self.physics1.Y = (vigObject.vTransform.position.y - (self.vTransform.position.y - 65536)) * 4;
			self.physics1.Z = (vigObject.vTransform.position.z - self.vTransform.position.z) * 4;
			GameManager.instance.FUN_1E2C8(self.DAT_18, 0u);
			GameManager.instance.FUN_30CB0(self, 32);
			oLYMPIC.DAT_D2 = 1200;
			self.FUN_30BA8();
			self.FUN_30B78();
		}
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 1)
		{
			OLYMPIC oLYMPIC = (OLYMPIC)LevelManager.instance.level;
			OLYMPIC.FUN_CCC(oLYMPIC.DAT_8C, oLYMPIC.pole2M, this);
		}
		return base.UpdateW(arg1, arg2);
	}
}
public class Liftstation : Destructible
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
		SKIRESRT instance = SKIRESRT.instance;
		if (hit.object1.id == 0 && hit.self.type == 2 && hit.self.id < 0 && SKIRESRT.instance.DAT_A2 != 0)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
			{
				uint num = (vr.y == 0) ? 1u : 0u;
				VigCamera vCamera = vehicle.vCamera;
				if (SKIRESRT.instance.DAT_A0_2 != 0)
				{
					num ^= 1;
				}
				Gondola2 gondola = SKIRESRT.instance.DAT_98[num];
				gondola.DAT_80 = vehicle;
				vehicle.state = _VEHICLE_TYPE.Gondola2;
				vehicle.PDAT_78 = gondola;
				vehicle.flags = (uint)(((int)vehicle.flags & -9) | 0x2000020);
				vehicle.physics1.X = (gondola.vTransform.position.x - vehicle.vTransform.position.x) * 4;
				vehicle.physics1.Y = (gondola.vTransform.position.y - (vehicle.vTransform.position.y - 65536)) * 4;
				vehicle.physics1.Z = (gondola.vTransform.position.z - vehicle.vTransform.position.z) * 4;
				GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
				GameManager.instance.FUN_30CB0(vehicle, 32);
				instance.DAT_A2 = 1200;
				vehicle.FUN_30BA8();
				vehicle.FUN_30B78();
				if (vCamera != null)
				{
					int[] array = new int[12]
					{
						vCamera.screen.x,
						vCamera.screen.y,
						vCamera.screen.z,
						120,
						gondola.screen.x,
						gondola.screen.y - 204800,
						0,
						0,
						0,
						0,
						0,
						0
					};
					int num2 = (vr.y != 0) ? (-409600) : 409600;
					array[6] = gondola.screen.z + num2;
					array[7] = 0;
					vCamera.FUN_4BDC4(array);
					vCamera.FUN_30BA8();
					vCamera.FUN_30B78();
				}
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, vData.sndList, 5, vehicle.vTransform.position);
			}
		}
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 1)
		{
			SKIRESRT.instance.FUN_13F8(this);
		}
		return base.UpdateW(arg1, arg2);
	}
	
}
