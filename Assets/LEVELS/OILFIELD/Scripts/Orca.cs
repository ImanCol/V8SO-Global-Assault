public class Orca : VigObject
{
	public JUNC_DB DAT_84_2;

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
		if (hit.self.type != 2)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)hit.self;
		if (FUN_33798(hit, 7629) != 0)
		{
			vehicle.FUN_3A064(-13, vTransform.position, param3: true);
		}
		if (DAT_18 == 0)
		{
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 38, vTransform.position);
			GameManager.instance.FUN_30CB0(this, 60);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			uint num6;
			int num2;
			int num3;
			int num;
			if (tags != 3)
			{
				num = physics2.X - vTransform.position.z;
				num2 = vTransform.position.y;
				num3 = physics1.Z - vTransform.position.x;
				if (tags != 0)
				{
					num2 -= 204800;
				}
				num2 = GameManager.instance.DAT_DB0 - num2;
				if (DAT_18 == 0 && tags == 0 && 0 < num2)
				{
					sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 38, vTransform.position);
					GameManager.instance.FUN_30CB0(this, 60);
				}
				int num4 = num;
				if (num < 0)
				{
					num4 = -num;
				}
				int num5 = num3;
				if (num3 < 0)
				{
					num5 = -num3;
				}
				if (num4 < num5)
				{
					num4 = num5;
				}
				if (num4 < 65536)
				{
					num6 = GameManager.FUN_2AC5C();
					JUNC_DB dAT_84_ = DAT_84_2;
					RSEG_DB rSEG_DB = dAT_84_.DAT_1C[num6 & 1];
					DAT_19 = (byte)((dAT_84_ == rSEG_DB.DAT_00[0]) ? 1 : 0);
					JUNC_DB jUNC_DB = DAT_84_2 = rSEG_DB.DAT_00[DAT_19];
					physics1.Z = jUNC_DB.DAT_00.x;
					physics1.W = jUNC_DB.DAT_00.y;
					physics2.X = jUNC_DB.DAT_00.z;
					if ((num6 & 3) == 0)
					{
						tags = (sbyte)(1 - tags);
					}
				}
				num3 = (int)Utilities.Ratan2(num3, num);
				num = (num3 - (ushort)vr.y) * 1048576 >> 20;
				num3 = -22;
				if (-23 < num)
				{
					num3 = 22;
					if (num < 23)
					{
						num3 = num;
					}
				}
				vr.y += (short)num3;
				num3 = -num2 / 20480 * 56;
				num2 = -341;
				if (-342 < num3)
				{
					num2 = 341;
					if (num3 < 342)
					{
						num2 = num3;
					}
				}
				num2 -= vr.x;
				num3 = -5;
				if (-6 < num2)
				{
					num3 = 5;
					if (num2 < 6)
					{
						num3 = num2;
					}
				}
				vr.x += (short)num3;
				ApplyRotationMatrix();
				num2 = vTransform.rotation.V02 * 7629;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				num3 = vTransform.rotation.V12 * 7629;
				vTransform.position.x += num2 >> 12;
				if (num3 < 0)
				{
					num3 += 4095;
				}
				num2 = vTransform.rotation.V22 * 7629;
				vTransform.position.y += num3 >> 12;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				vTransform.position.z += num2 >> 12;
				return 0u;
			}
			num6 = maxHalfHealth;
			maxHalfHealth--;
			switch (num6)
			{
			case 0u:
			{
				uint flags = base.flags;
				tags = 0;
				base.flags = (uint)((int)flags & -33);
				break;
			}
			case 16u:
			{
				int param2 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param2, GameManager.instance.DAT_C2C, 38, vTransform.position);
				uint flags = base.flags;
				base.flags = (uint)((int)flags & -33);
				break;
			}
			}
			num2 = (int)(num6 - 16);
			if (num2 < 0)
			{
				num2 = -num2;
			}
			num3 = (16 - num2) * 227;
			if (num3 < 0)
			{
				num3 += 15;
			}
			vr.x = num3 >> 4;
			ApplyRotationMatrix();
			num3 = vTransform.rotation.V02 * 3814;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			num = vTransform.rotation.V22 * 3814;
			vTransform.position.x += num3 >> 12;
			if (num < 0)
			{
				num += 4095;
			}
			vTransform.position.z += num >> 12;
			vTransform.position.y = GameManager.instance.DAT_DB0 + (16 - num2) * -1920;
			break;
		}
		case 1:
		{
			RSEG_DB rSEG_DB = LevelManager.instance.FUN_518DC(screen, 16);
			JUNC_DB jUNC_DB = DAT_84_2 = rSEG_DB.DAT_00[0];
			physics1.Z = jUNC_DB.DAT_00.x;
			physics1.W = jUNC_DB.DAT_00.y;
			physics2.X = jUNC_DB.DAT_00.z;
			base.flags |= 65924u;
			break;
		}
		case 2:
			DAT_18 = 0;
			break;
		}
		return 0u;
	}
}
