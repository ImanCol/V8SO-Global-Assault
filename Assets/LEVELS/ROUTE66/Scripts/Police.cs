using UnityEngine;

public class Police : Vehicle
{
	private static VehicleData DAT_5230 = new VehicleData
	{
		DAT_00 = new short[6]
		{
			4,
			4,
			50,
			50,
			200,
			200
		},
		DAT_0C = 12,
		vehicleID = _VEHICLE.NONE,
		DAT_0E = 14,
		DAT_0F = 0,
		DAT_10 = 32,
		DAT_11 = 32,
		DAT_12 = 32,
		DAT_13 = 120,
		DAT_15 = 46,
		maxHalfHealth = 900,
		lightness = 3458,
		DAT_24 = new Vector3Int(100, 64, 100),
		DAT_2A = 20480,
		DAT_2C = new byte[4]
		{
			17,
			10,
			10,
			12
		}
	};

	public int counter;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2, uint arg3)
	{
		return arg1.FUN_3C464((ushort)arg2, DAT_5230, typeof(Police));
	}

	public override uint OnCollision(HitDetection hit)
	{
		VigObject self = hit.self;
		if (self.type != 8)
		{
			if (self.type == 2)
			{
				Vehicle vehicle = (Vehicle)self;
				short id = vehicle.id;
				if ((GameManager.FUN_2AC5C() & 1) != 0)
				{
					vehicle.FUN_39714(vTransform.position);
				}
			}
			return (uint)FUN_3B424(this, hit);
		}
		if ((self.flags & 0x20000000) != 0)
		{
			VigObject dAT_ = self.DAT_80;
			int num = Utilities.FUN_29F6C(dAT_.vTransform.position, vTransform.position);
			if ((int)(GameManager.FUN_2AC5C() * 10) >> 15 == 0 && counter == 0)
			{
				uint param = (uint)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580((int)param, LevelManager.instance.xobfList[42].sndList, 4, vTransform.position);
				counter = 400;
			}
			if (tags == 2)
			{
				if (num < 1024000 && (uint)maxFullHealth >> 2 < maxHalfHealth && GetType().IsSubclassOf(typeof(VigObject)))
				{
					UpdateW(20, dAT_);
				}
			}
			else if (num < 2048000 && (uint)maxFullHealth >> 2 < maxHalfHealth && GetType().IsSubclassOf(typeof(VigObject)))
			{
				UpdateW(20, dAT_);
			}
		}
		FUN_32B90(self.maxHalfHealth);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		VigObject target;
		short num;
		int num5;
		int num4;
		int num3;
		int num2;
		switch (arg1)
		{
		case 0:
			if (counter != 0)
			{
				counter--;
			}
			if (((GameManager.instance.DAT_28 - DAT_19) & 0x7F) == 0 && (ai.DAT_00 < 1 || (flags & 0x20000000) != 0))
			{
				target = base.target;
				if (tags == 1)
				{
					int num9 = vTransform.position.x - target.vTransform.position.x;
					if (num9 < 0)
					{
						num9 = -num9;
					}
					if (num9 < 40960)
					{
						FUN_30BA8();
						tags = 0;
						if (DAT_1A != 20)
						{
							GameManager.instance.FUN_1FEB8(vMesh);
							DAT_1A = 20;
							VigMesh vigMesh = vMesh = vData.FUN_2CB74(base.gameObject, 20u, init: true);
							maxHalfHealth = maxFullHealth;
						}
						FUN_30C68();
						return 0u;
					}
					num9 = vTransform.position.z - target.vTransform.position.z;
					if (num9 < 0)
					{
						num9 = -num9;
					}
					if (num9 < 40960)
					{
						FUN_30BA8();
						tags = 0;
						if (DAT_1A != 20)
						{
							GameManager.instance.FUN_1FEB8(vMesh);
							DAT_1A = 20;
							VigMesh vigMesh = vMesh = vData.FUN_2CB74(base.gameObject, 20u, init: true);
							maxHalfHealth = maxFullHealth;
						}
						FUN_30C68();
						return 0u;
					}
				}
				else
				{
					int num9 = vTransform.position.x - target.vTransform.position.x;
					if (num9 < 0)
					{
						num9 = -num9;
					}
					if (num9 < 3072001)
					{
						num9 = vTransform.position.z - target.vTransform.position.z;
						if (num9 < 0)
						{
							num9 = -num9;
						}
						if (num9 < 3072001)
						{
							goto IL_02fe;
						}
					}
					VigObject child = child2;
					num3 = 0;
					child.FUN_30C20();
					FUN_30C68();
					child.flags |= 2u;
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
					tags = 1;
					num2 = (int)GameManager.FUN_2AC5C();
					DAT_F4 = (short)((num2 * 3 >> 15) + 97);
					while (!((base.target = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, DAT_F4)) != null))
					{
						if (99 < DAT_F4++ + 1)
						{
							DAT_F4 = 97;
						}
						num3++;
						if (num3 >= 3)
						{
							break;
						}
					}
					if (base.target == null)
					{
						child = (base.target = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 1));
					}
				}
				goto IL_02fe;
			}
			goto IL_0327;
		case 1:
			if (arg2 != 0)
			{
				if (id != 97)
				{
					return 0u;
				}
				FUN_31DDC().FUN_3066C();
				return 0u;
			}
			type = 10;
			num2 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
			screen.y = num2 - DAT_E4;
			vTransform.position.y = num2 - DAT_E4;
			flags |= 264u;
			child2.flags |= 2u;
			DAT_F4 = id;
			break;
		case 2:
			target = child2;
			num3 = 0;
			target.FUN_30C20();
			target.flags |= 2u;
			GameManager.instance.FUN_1DE78(DAT_18);
			DAT_18 = 0;
			tags = 1;
			num2 = (int)GameManager.FUN_2AC5C();
			DAT_F4 = (short)((num2 * 3 >> 15) + 97);
			while (!((base.target = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, DAT_F4)) != null))
			{
				if (99 < DAT_F4++ + 1)
				{
					DAT_F4 = 97;
				}
				num3++;
				if (num3 >= 3)
				{
					break;
				}
			}
			if (base.target != null)
			{
				return 0u;
			}
			target = (base.target = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 1));
			break;
		case 4:
			if (type == 5)
			{
				return 0u;
			}
			GameManager.instance.FUN_1DE78(DAT_18);
			FUN_38484();
			break;
		case 8:
			{
				FUN_32B90((uint)arg2);
				return 0u;
			}
			IL_0327:
			direction = 1;
			num = (short)ai.FUN_51CFC(this, physics1.W * 32 + 65536);
			num2 = num;
			num3 = -682;
			if (-683 < num2)
			{
				num3 = 682;
				if (num2 < 683)
				{
					num3 = num2;
				}
			}
			turning = (short)num3;
			num4 = physics1.W * DAT_B2;
			if (num4 < 0)
			{
				num4 += 4095;
			}
			num5 = DAT_B1 + (num4 >> 12);
			num4 = 0;
			if (0 < num5)
			{
				num4 = num5;
			}
			num3 *= num4;
			if (num3 < 0)
			{
				num3 += 15;
			}
			physics2.Y += num3 >> 4;
			if (num2 < 0)
			{
				num2 = -num2;
			}
			if (num2 < 342 || physics1.W < 3052)
			{
				if (physics1.W < 7630)
				{
					num2 = 0;
					if (0 < base.acceleration)
					{
						num2 = base.acceleration;
					}
					uint dAT_B = DAT_B3;
					num2++;
					bool num6 = num2 < (int)dAT_B;
					short acceleration = (short)dAT_B;
					if (num6)
					{
						acceleration = (short)num2;
					}
					base.acceleration = acceleration;
				}
				else
				{
					num3 = base.acceleration - 1;
					num2 = -DAT_B3;
					if (-DAT_B3 < num3)
					{
						num2 = num3;
					}
					base.acceleration = (short)num2;
				}
			}
			else
			{
				num2 = 0;
				if (base.acceleration < 0)
				{
					num2 = base.acceleration;
				}
				num2--;
				uint dAT_B = (uint)(-DAT_B3);
				bool num7 = (int)dAT_B < num2;
				short acceleration = (short)dAT_B;
				if (num7)
				{
					acceleration = (short)num2;
				}
				base.acceleration = acceleration;
			}
			FUN_41AE8();
			if (arg2 != 0)
			{
				uint num8 = (uint)((int)flags & -16809985);
				if ((flags & 0x1000000) != 0)
				{
					num8 |= 0x8000;
				}
				flags = num8;
				uint volume = GameManager.instance.FUN_1E478(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
				return 0u;
			}
			break;
			IL_02fe:
			ai.FUN_51C54(vTransform.position, target.vTransform.position, 141120u, 0u);
			goto IL_0327;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 20)
		{
			target = arg2;
			if (tags == 0)
			{
				flags &= 4294966527u;
				FUN_30B78();
			}
			if (tags < 2)
			{
				child2.flags &= 4294967293u;
				child2.FUN_30BF0();
				sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E098(param, LevelManager.instance.xobfList[42].sndList, 5, 0u, param5: true);
				GameManager.instance.FUN_30CB0(this, 2700);
			}
			tags = 2;
		}
		return 0u;
	}
}
