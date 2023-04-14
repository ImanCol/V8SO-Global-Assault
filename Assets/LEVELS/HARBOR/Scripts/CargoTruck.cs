using UnityEngine;

public class CargoTruck : VigObject
{
	public RSEG_DB DAT_88;

	public int DAT_8C;

	public int DAT_90;

	public int DAT_94;

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
		VigObject self = hit.self;
		if (self.type != 2)
		{
			if (self.type == 8)
			{
				FUN_32B90(self.maxHalfHealth);
				return 0u;
			}
			return 0u;
		}
		if (FUN_33798(hit, DAT_8C) == 0)
		{
			return 0u;
		}
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 7, self.vTransform.position);
		if (tags != 12)
		{
			return 0u;
		}
		int num = DAT_8C - 1525;
		int num2 = 0;
		if (0 < num)
		{
			num2 = num;
		}
		DAT_8C = num2;
		if (num2 != 0)
		{
			return 0u;
		}
		FUN_30BA8();
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			RSEG_DB rSEG_DB2 = DAT_88 = LevelManager.instance.FUN_518DC(screen, id - 100);
			DAT_90 = 1;
			int num = rSEG_DB2.FUN_51334(screen);
			DAT_94 = num << 16;
			DAT_8C = 6103;
			flags |= 136u;
			return 0u;
		}
		case 2:
		{
			int y = 120;
			if (id == 117)
			{
				y = 121;
			}
			CraneLarge craneLarge = (CraneLarge)GameManager.instance.FUN_318D0(y);
			if (craneLarge.GetType().IsSubclassOf(typeof(VigObject)))
			{
				craneLarge.UpdateW(21, null);
			}
			FUN_30B78();
			return 0u;
		}
		case 4:
		{
			int y = 120;
			if (id == 117)
			{
				y = 121;
			}
			CraneLarge craneLarge = (CraneLarge)GameManager.instance.FUN_318D0(y);
			if (!craneLarge.GetType().IsSubclassOf(typeof(VigObject)))
			{
				return 0u;
			}
			craneLarge.UpdateW(21, null);
			return 0u;
		}
		default:
			return 0u;
		case 8:
			FUN_32B90((uint)arg2);
			return 0u;
		case 9:
			if (arg2 != 0)
			{
				GameManager.instance.FUN_309A0(this);
				return 0u;
			}
			return 0u;
		case 0:
		{
			int num;
			int dAT_8C;
			switch (((byte)tags - 1) * 16777216 >> 24)
			{
			case 0:
			case 8:
				num = DAT_8C + 33;
				goto IL_02c5;
			case 1:
			case 4:
				if (!(DAT_84 == null))
				{
					if (DAT_84.tags == 0)
					{
						goto case 2;
					}
					num = ((DAT_90 != 0) ? (268435456 - DAT_94) : DAT_94);
					if (num < 0)
					{
						num += 65535;
					}
					num = (num >> 16) * 4577;
					if (num < 0)
					{
						num += 4095;
					}
					goto IL_028d;
				}
				goto case 12;
			case 2:
			case 5:
				if (!(DAT_84 == null) && DAT_84.tags != 0)
				{
					break;
				}
				goto case 12;
			case 6:
			case 7:
				num = ((DAT_90 != 0) ? (268435456 - DAT_94) : DAT_94);
				if (num < 0)
				{
					num += 65535;
				}
				num = (num >> 16) * 4577;
				if (num < 0)
				{
					num += 4095;
				}
				goto IL_028d;
			case 11:
				num = DAT_8C + 3;
				goto IL_02c5;
			case 12:
				{
					num = DAT_8C + 33;
					goto IL_02c5;
				}
				IL_028d:
				dAT_8C = 305;
				if (305 < num >> 12)
				{
					dAT_8C = num >> 12;
				}
				DAT_8C = dAT_8C;
				break;
				IL_02c5:
				dAT_8C = 6103;
				if (num < 6103)
				{
					dAT_8C = num;
				}
				DAT_8C = dAT_8C;
				break;
			}
			num = DAT_94;
			int y = vTransform.position.y;
			if (num < 0)
			{
				num += 65535;
			}
			DAT_88.FUN_285E4(num >> 16, ref vTransform.position, out Vector3Int param);
			vTransform.position.y = y;
			Vector3Int normalVector = default(Vector3Int);
			y = FUN_2CFBC(vTransform.position, ref normalVector);
			vTransform.position.y = y;
			if (DAT_90 == 0)
			{
				param.x = -param.x;
				param.z = -param.z;
			}
			param.y = -(param.x * normalVector.x + param.z * normalVector.z) / normalVector.y;
			num = (int)Utilities.SquareRoot(Utilities.VectorNormal2(param, out Vector3Int n));
			dAT_8C = ((DAT_90 != 0) ? (DAT_8C << 16) : (DAT_8C * -65536));
			DAT_94 += dAT_8C / num;
			Vector3Int vector3Int = Utilities.FUN_2A1E0(normalVector, n);
			vTransform.rotation.V00 = (short)(-vector3Int.x);
			vTransform.rotation.V10 = (short)(-vector3Int.y);
			vTransform.rotation.V20 = (short)(-vector3Int.z);
			vTransform.rotation.V01 = (short)(-normalVector.x);
			vTransform.rotation.V11 = (short)(-normalVector.y);
			vTransform.rotation.V22 = (short)(-normalVector.z);
			vTransform.rotation.V02 = (short)n.x;
			vTransform.rotation.V12 = (short)n.y;
			vTransform.rotation.V22 = (short)n.z;
			if ((uint)DAT_94 < 268435457u)
			{
				return 0u;
			}
			RSEG_DB dAT_ = DAT_88;
			JUNC_DB jUNC_DB = dAT_.DAT_00[DAT_90];
			dAT_8C = 0;
			RSEG_DB rSEG_DB = null;
			if (jUNC_DB.DAT_11 != 0)
			{
				do
				{
					rSEG_DB = jUNC_DB.DAT_1C[dAT_8C];
					if (rSEG_DB != dAT_ && rSEG_DB.DAT_08 == dAT_.DAT_08)
					{
						break;
					}
					dAT_8C++;
				}
				while (dAT_8C < jUNC_DB.DAT_11);
			}
			DAT_88 = rSEG_DB;
			JUNC_DB x = rSEG_DB.DAT_00[0];
			DAT_90 = ((x == jUNC_DB) ? 1 : 0);
			DAT_94 = ((!(x == jUNC_DB) || 1 == 0) ? 1 : 0) << 28;
			if ((jUNC_DB.DAT_10 & 0x40) == 0)
			{
				return 0u;
			}
			VigObject param2;
			switch (tags = (sbyte)jUNC_DB.DAT_12)
			{
			case 1:
			{
				FUN_30BA8();
				GameManager.instance.FUN_30CB0(this, 600);
				y = 120;
				if (id == 117)
				{
					y = 121;
				}
				CraneLarge craneLarge = (CraneLarge)GameManager.instance.FUN_318D0(y);
				if (craneLarge.GetType().IsSubclassOf(typeof(VigObject)))
				{
					craneLarge.UpdateW(21, this);
				}
				break;
			}
			case 2:
				y = 49;
				goto IL_06b8;
			case 3:
			case 6:
				if (DAT_84 != null)
				{
					if (DAT_84.tags != 0)
					{
						DAT_8C = 0;
						return 0u;
					}
					return 0u;
				}
				break;
			case 4:
				if (DAT_80 == null)
				{
					ConfigContainer cont = FUN_2C5F4(32768);
					Utilities.FUN_2CB04(this, cont, DAT_80 = Barge.FUN_1F64());
					Utilities.ParentChildren(this, this);
					return 0u;
				}
				return 0u;
			case 5:
				y = 50;
				goto IL_06b8;
			case 9:
				FUN_30BA8();
				GameManager.instance.FUN_30CB0(this, 180);
				return 0u;
			case 10:
				{
					if (DAT_80 == null)
					{
						return 0u;
					}
					param2 = DAT_80.FUN_2CCBC();
					GameManager.instance.FUN_307CC(param2);
					DAT_80 = null;
					break;
				}
				IL_06b8:
				param2 = (DAT_84 = GameManager.instance.FUN_318D0(y));
				break;
			}
			return 0u;
		}
		}
	}
}
