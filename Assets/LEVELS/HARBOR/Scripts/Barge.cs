using UnityEngine;

public class Barge : VigObject
{
	public RSEG_DB DAT_80_2;

	public int DAT_84_2;

	public int DAT_88;

	public int DAT_8C;

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
			if (self.type != 8)
			{
				return 0u;
			}
			FUN_32B90(self.maxHalfHealth);
			return 0u;
		}
		if (DAT_8C != 0)
		{
			FUN_33798(hit, DAT_84_2 * 2);
		}
		self.PDAT_74 = this;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		switch (arg1)
		{
		case 0:
		{
			int dAT_84_;
			int num;
			switch (tags)
			{
			case 2:
				num = DAT_84_2 + 19;
				dAT_84_ = 4577;
				if (num < 4577)
				{
					dAT_84_ = num;
				}
				DAT_84_2 = dAT_84_;
				break;
			case 1:
				dAT_84_ = ((DAT_88 != 0) ? (268435456 - DAT_8C) : DAT_8C);
				if (dAT_84_ < 0)
				{
					dAT_84_ += 65535;
				}
				dAT_84_ = (dAT_84_ >> 16) * 4577;
				if (dAT_84_ < 0)
				{
					dAT_84_ += 65535;
				}
				num = 305;
				if (305 < dAT_84_ >> 12)
				{
					num = dAT_84_ >> 12;
				}
				DAT_84_2 = num;
				break;
			case 4:
				dAT_84_ = ((DAT_88 != 0) ? (268435456 - DAT_8C) : DAT_8C);
				if (dAT_84_ < 0)
				{
					dAT_84_ += 65535;
				}
				dAT_84_ = (dAT_84_ >> 16) * 4577;
				if (dAT_84_ < 0)
				{
					dAT_84_ += 65535;
				}
				num = 305;
				if (305 < dAT_84_ >> 12)
				{
					num = dAT_84_ >> 12;
				}
				DAT_84_2 = num;
				break;
			case 5:
				num = DAT_84_2 + 19;
				dAT_84_ = 4577;
				if (num < 4577)
				{
					dAT_84_ = num;
				}
				DAT_84_2 = dAT_84_;
				break;
			}
			dAT_84_ = DAT_8C;
			if (dAT_84_ < 0)
			{
				dAT_84_ += 65535;
			}
			DAT_80_2.FUN_285E4(dAT_84_ >> 16, ref vTransform.position, out Vector3Int param);
			vTransform.position.y = GameManager.instance.DAT_DB0;
			if (DAT_88 == 0)
			{
				param.x = -param.x;
				param.z = -param.z;
			}
			Vector3Int n;
			long a = Utilities.VectorNormal2(param, out n);
			vTransform.rotation.V22 = (short)n.z;
			vTransform.rotation.V00 = (short)n.z;
			vTransform.rotation.V02 = (short)n.x;
			vTransform.rotation.V20 = (short)(-n.x);
			dAT_84_ = (int)Utilities.SquareRoot(a);
			num = ((DAT_88 != 0) ? (DAT_84_2 << 16) : (DAT_84_2 * -65536));
			if ((uint)(DAT_8C += num / dAT_84_) >= 268435457u)
			{
				JUNC_DB jUNC_DB = DAT_80_2.DAT_00[DAT_88];
				RSEG_DB rSEG_DB = jUNC_DB.DAT_1C[0];
				if (rSEG_DB == DAT_80_2)
				{
					rSEG_DB = jUNC_DB.DAT_1C[1];
				}
				DAT_80_2 = rSEG_DB;
				JUNC_DB x = rSEG_DB.DAT_00[0];
				DAT_88 = ((x == jUNC_DB) ? 1 : 0);
				DAT_8C = (-((!(x == jUNC_DB) || 1 == 0) ? 1 : 0) & 0x10000000);
				if ((jUNC_DB.DAT_10 & 0x40) != 0)
				{
					CraneLarge craneLarge;
					switch (tags = (sbyte)jUNC_DB.DAT_12)
					{
					case 2:
						result = 120u;
						goto IL_039c;
					case 3:
					{
						DrawBridge drawBridge = (DrawBridge)GameManager.instance.FUN_318D0(50);
						if (drawBridge.GetType().IsSubclassOf(typeof(VigObject)))
						{
							drawBridge.UpdateW(10, 0);
						}
						break;
					}
					case 5:
						{
							result = 121u;
							goto IL_039c;
						}
						IL_039c:
						craneLarge = (CraneLarge)GameManager.instance.FUN_318D0((int)result);
						if (craneLarge.GetType().IsSubclassOf(typeof(VigObject)))
						{
							craneLarge.UpdateW(20, this);
						}
						FUN_30BA8();
						break;
					}
				}
			}
			result = 0u;
			if (arg2 != 0)
			{
				result = GameManager.instance.FUN_1E7A8(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, result);
				result = 0u;
			}
			break;
		}
		case 1:
		{
			RSEG_DB rSEG_DB2 = DAT_80_2 = LevelManager.instance.FUN_518DC(screen, 16);
			DAT_88 = 1;
			int dAT_84_ = rSEG_DB2.FUN_51334(screen);
			DAT_8C = dAT_84_ << 16;
			DAT_84_2 = 6103;
			flags |= 384u;
			ConfigContainer cont = FUN_2C5F4(32768);
			VigObject obj = FUN_1F64();
			Utilities.FUN_2CA94(this, cont, obj);
			cont = FUN_2C5F4(32770);
			obj = FUN_1F64();
			Utilities.FUN_2CA94(this, cont, obj);
			Utilities.ParentChildren(this, this);
			sbyte param2 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param2, vData.sndList, 3, 0u, param5: true);
			result = 0u;
			break;
		}
		case 2:
		{
			result = 121u;
			if (tags == 2)
			{
				DrawBridge drawBridge = (DrawBridge)GameManager.instance.FUN_318D0(49);
				if (drawBridge.GetType().IsSubclassOf(typeof(VigObject)))
				{
					drawBridge.UpdateW(10, 0);
				}
				result = 120u;
			}
			CraneLarge craneLarge = (CraneLarge)GameManager.instance.FUN_318D0((int)result);
			if (craneLarge.GetType().IsSubclassOf(typeof(VigObject)))
			{
				craneLarge.UpdateW(20, null);
			}
			FUN_30B78();
			result = 0u;
			break;
		}
		default:
			result = 0u;
			break;
		case 4:
		{
			GameManager.instance.FUN_1DE78(DAT_18);
			CraneLarge craneLarge = (CraneLarge)GameManager.instance.FUN_318D0(120);
			if (craneLarge.GetType().IsSubclassOf(typeof(VigObject)))
			{
				craneLarge.UpdateW(20, null);
			}
			craneLarge = (CraneLarge)GameManager.instance.FUN_318D0(121);
			if (craneLarge.GetType().IsSubclassOf(typeof(VigObject)))
			{
				craneLarge.UpdateW(20, null);
			}
			goto default;
		}
		case 8:
			FUN_32B90((uint)arg2);
			result = 0u;
			break;
		case 9:
			result = 0u;
			if (arg2 != 0)
			{
				GameManager.instance.FUN_309A0(this);
				result = uint.MaxValue;
			}
			break;
		}
		return result;
	}

	public static VigObject FUN_1F64()
	{
		VigObject vigObject = LevelManager.instance.xobfList[42].ini.FUN_2C17C(2, typeof(VigObject), 0u);
		vigObject.vLOD = vigObject.vMesh;
		return vigObject;
	}
}
