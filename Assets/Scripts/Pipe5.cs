public class Pipe5 : Destructible
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
		if (hit.self.type != 2 || (flags & 0x1000000) == 0)
		{
			FUN_32CF0(hit);
			return 0u;
		}
		if ((hit.self.flags & 0x4000000) != 0 || (hit.self.flags & 0x4000) == 0)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)hit.self;
		sbyte b = (sbyte)vehicle.DAT_DF;
		if (b == 0)
		{
			b = (sbyte)GameManager.instance.FUN_1DD9C();
			vehicle.DAT_DF = (byte)b;
		}
		GameManager.instance.FUN_1E098(b, vData.sndList, 2, 0u, param5: true);
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, vData.sndList, 4, vehicle.vTransform.position);
		GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
		vehicle.state = _VEHICLE_TYPE.Dam;
		vehicle.tags = 8;
		vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
		uint num;
		do
		{
			num = (uint)(((int)(GameManager.FUN_2AC5C() << 2) >> 15) + 60);
			vehicle.DAT_DE = (byte)num;
		}
		while ((num & 0xFF) == id);
		GameManager.instance.FUN_30CB0(vehicle, 60);
		VigCamera vCamera = vehicle.vCamera;
		if (vCamera != null)
		{
			int[] array = new int[16];
			VigObject vigObject = GameManager.instance.FUN_31950(vehicle.DAT_DE);
			array[0] = vCamera.screen.x;
			array[1] = vCamera.screen.y;
			array[2] = vCamera.screen.z;
			array[3] = 120;
			array[4] = 60751872;
			array[6] = 86048768;
			array[5] = 2488320;
			array[7] = 240;
			array[8] = vigObject.screen.x;
			array[9] = vigObject.screen.y - 73728;
			int num2 = -327680;
			if (vigObject.screen.z < 86048768)
			{
				num2 = 327680;
			}
			array[10] = vigObject.screen.z + num2;
			array[11] = 0;
			vCamera.FUN_4BDC4(array);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (3 < arg1)
		{
			if (arg1 != 8)
			{
				return 0u;
			}
			if (GameManager.hit.object1.type == 2)
			{
				int num = GameManager.hit.object1.physics1.X;
				if (vr.y != 0)
				{
					num = -num;
				}
				if (390528 < num)
				{
					num = GameManager.hit.object1.vTransform.position.y + 73728 - screen.y;
					if (num < 0)
					{
						num = -num;
					}
					if (num < 65536)
					{
						num = GameManager.hit.object1.vTransform.position.z - screen.z;
						if (num < 0)
						{
							num = -num;
						}
						if (num < 40960)
						{
							flags |= 16777216u;
							GameManager.instance.FUN_30CB0(this, 0);
							return 1u;
						}
					}
				}
			}
			flags &= 4278190079u;
			FUN_32B90((uint)arg2);
			return 0u;
		}
		if (arg1 != 2)
		{
			return 0u;
		}
		flags &= 4278190079u;
		return 0u;
	}
}
