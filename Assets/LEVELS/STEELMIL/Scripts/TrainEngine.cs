using System.IO;
using UnityEngine;

public class TrainEngine : Destructible
{
	public TrainEngine DAT_A8;

	public TrainEngine DAT_AC;

	public int DAT_B0;

	public int DAT_B4;

	public RSEG_DB DAT_B8;

	public int DAT_BC;

	public int DAT_C0;

	public int DAT_C4;

	public int DAT_C8;

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
		byte type = self.type;
		uint result;
		switch (type)
		{
		case 8:
			FUN_32B90(self.maxHalfHealth);
			result = 0u;
			break;
		case 2:
		{
			uint num = FUN_33798(hit, DAT_BC);
			result = 0u;
			if (num != 0)
			{
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 7, self.vTransform.position);
				result = 0u;
			}
			break;
		}
		default:
			result = 0u;
			if (type != 3 && self != DAT_A8 && self != DAT_AC)
			{
				FUN_4DC94();
				self.FUN_4DC94();
			}
			break;
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		switch (arg1)
		{
		case 0:
			if (FUN_3AD0() == 0 || DAT_B8 == null || (DAT_B8.DAT_0C & 0x100) == 0)
			{
				result = 0u;
				if (arg2 != 0 && DAT_B8 != null)
				{
					result = GameManager.instance.FUN_1E7A8(vTransform.position);
					GameManager.instance.FUN_1E2C8(DAT_18, result);
					result = 0u;
				}
			}
			else
			{
				int param2 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param2, vData.sndList, 3, vTransform.position);
				result = 0u;
			}
			break;
		case 1:
		{
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, 2, 0u, param5: true);
			tags = 2;
			FUN_3754();
			result = 0u;
			break;
		}
		case 2:
			result = 0u;
			if (vMesh != null)
			{
				FUN_4DC94();
				result = 0u;
			}
			break;
		case 4:
			FUN_38FC();
			GameManager.instance.FUN_1DE78(DAT_18);
			goto default;
		default:
			result = 0u;
			break;
		case 8:
			FUN_32B90((uint)arg2);
			result = 0u;
			break;
		case 9:
			result = 0u;
			if (arg2 != 0)
			{
				GameManager.instance.FUN_309A0(this);
				result = 0u;
			}
			break;
		}
		return result;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 20)
		{
			FUN_3838((TrainEngine)arg2);
			return 0u;
		}
		return 0u;
	}

	public void FUN_3754()
	{
		DAT_A8 = null;
		DAT_B0 = vCollider.reader.ReadInt32(24) + 20480;
		DAT_B4 = vCollider.reader.ReadInt32(12) - 20480;
		RSEG_DB rSEG_DB = DAT_B8 = LevelManager.instance.FUN_518DC(screen, -1);
		DAT_C0 = 1;
		int num = rSEG_DB.FUN_51334(screen);
		DAT_C4 = num << 16;
		if (tags != 0)
		{
			DAT_BC = 3814;
			flags |= 128u;
		}
		physics2.X = 0;
		flags |= 256u;
		physics2.Y = 0;
		physics2.Z = 0;
		DAT_A0 = new Vector3Int(16, 32, 64);
		GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 20, this);
	}

	public void FUN_3838(TrainEngine param1)
	{
		Vector3Int vector3Int = Utilities.FUN_24304(vTransform, param1.vTransform.position);
		if (vector3Int.x < 0)
		{
			vector3Int.x = -vector3Int.x;
		}
		if (vector3Int.x >= 65537)
		{
			return;
		}
		if (vector3Int.z < 0)
		{
			if (-vector3Int.z < param1.DAT_B0 - DAT_B4 + 65536)
			{
				param1.DAT_A8 = this;
				DAT_AC = param1;
			}
		}
		else if (vector3Int.z < DAT_B0 - param1.DAT_B4 + 65536)
		{
			DAT_A8 = param1;
			param1.DAT_AC = this;
		}
	}

	public void FUN_38FC()
	{
		TrainEngine dAT_A = DAT_A8;
		if (dAT_A != null)
		{
			DAT_A8 = null;
			dAT_A.DAT_AC = null;
		}
		dAT_A = DAT_AC;
		if (dAT_A != null)
		{
			DAT_AC = null;
			dAT_A.DAT_A8 = null;
		}
	}

	public void FUN_3934(JUNC_DB param1)
	{
		DAT_C4 = (((DAT_C0 = (((DAT_B8 = param1.DAT_1C[0]).DAT_00[0] == param1) ? 1 : 0)) == 0) ? 1 : 0) << 28;
	}

	public long FUN_3964()
	{
		int num = DAT_C4;
		if (num < 0)
		{
			num += 65535;
		}
		DAT_B8.FUN_285E4(num >> 16, ref vTransform.position, out Vector3Int param);
		if (DAT_C0 == 0)
		{
			param.x = -param.x;
			param.z = -param.z;
		}
		long result = Utilities.VectorNormal2(param, out param);
		vTransform.rotation.V22 = (short)param.z;
		vTransform.rotation.V00 = (short)param.z;
		vTransform.rotation.V02 = (short)param.x;
		vTransform.rotation.V20 = (short)(-param.x);
		return result;
	}

	public JUNC_DB FUN_3A00()
	{
		JUNC_DB jUNC_DB2;
		if (DAT_A8 == null)
		{
			flags &= 4294967261u;
			FUN_30B78();
			JUNC_DB jUNC_DB = DAT_B8.DAT_00[DAT_C0];
			int num;
			do
			{
				num = ((int)(GameManager.FUN_2AC5C() * 3) >> 15) + 40;
				SteelMil.instance.DAT_4614 = num;
			}
			while ((num & 0xFF) == jUNC_DB.DAT_12);
			jUNC_DB2 = LevelManager.instance.FUN_51B74(num & 0xFF);
		}
		else
		{
			jUNC_DB2 = DAT_A8.FUN_3A00();
		}
		FUN_3934(jUNC_DB2);
		FUN_3964();
		return jUNC_DB2;
	}

	public int FUN_3AD0()
	{
		if (DAT_B8 == null)
		{
			if (vCollider != null)
			{
				vCollider.reader.Seek(4L, SeekOrigin.Current);
				FUN_2B4F8(vCollider.reader);
				vCollider.reader.Seek(-4L, SeekOrigin.Current);
				return 0;
			}
			GameManager.instance.FUN_309A0(this);
			return 0;
		}
		long a = FUN_3964();
		TrainEngine dAT_A = DAT_A8;
		int dAT_C;
		int num;
		int num2;
		if (dAT_A == null)
		{
			if (tags < 2 && (DAT_BC -= 14) < 0)
			{
				TrainEngine trainEngine = this;
				do
				{
					trainEngine.tags = 0;
					trainEngine.FUN_30BA8();
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
					trainEngine = trainEngine.DAT_AC;
				}
				while (trainEngine != null);
			}
			num = (int)Utilities.SquareRoot(a);
			dAT_C = DAT_C4;
			if (DAT_C0 == 0)
			{
				goto IL_0255;
			}
			num2 = DAT_BC << 16;
		}
		else if ((dAT_A.flags & 2) == 0)
		{
			dAT_C = dAT_A.vTransform.rotation.V02 * dAT_A.DAT_B4;
			if (dAT_C < 0)
			{
				dAT_C += 4095;
			}
			num2 = dAT_A.vTransform.rotation.V22 * dAT_A.DAT_B4;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			num = vTransform.rotation.V02 * (dAT_A.vTransform.position.x + (dAT_C >> 12) - vTransform.position.x) + vTransform.rotation.V22 * (dAT_A.vTransform.position.z + (num2 >> 12) - vTransform.position.z) + DAT_B0 * -4096;
			num2 = 0;
			if (0 < num)
			{
				num2 = num;
			}
			num = num2;
			if (num2 < 0)
			{
				num = num2 + 4095;
			}
			DAT_BC = num >> 12;
			num = (int)Utilities.SquareRoot(a);
			dAT_C = DAT_C4;
			num2 = ((DAT_C0 != 0) ? (num2 << 4) : (num2 * -16));
		}
		else
		{
			num = (int)Utilities.SquareRoot(a);
			dAT_C = DAT_C4;
			if (DAT_C0 == 0)
			{
				goto IL_0255;
			}
			num2 = DAT_BC << 16;
		}
		goto IL_0263;
		IL_0263:
		DAT_C4 = dAT_C + num2 / num;
		dAT_A = DAT_AC;
		if (dAT_A != null && (dAT_A.flags & 2) != 0)
		{
			dAT_C = (dAT_A.DAT_C8 += DAT_BC);
			if (dAT_A.DAT_B0 - DAT_B4 < dAT_C)
			{
				dAT_A.flags &= 4294967261u;
				dAT_A.FUN_30B78();
			}
		}
		int result = 0;
		if (268435456u < (uint)DAT_C4)
		{
			RSEG_DB dAT_B = DAT_B8;
			JUNC_DB jUNC_DB = dAT_B.DAT_00[DAT_C0];
			RSEG_DB rSEG_DB = null;
			if (jUNC_DB.DAT_11 == 1)
			{
				FUN_30BA8();
				DAT_C8 = 0;
				flags |= 34u;
				if (DAT_AC == null)
				{
					FUN_3A00();
				}
				result = -1;
			}
			else
			{
				if (jUNC_DB.DAT_11 == 2)
				{
					rSEG_DB = jUNC_DB.DAT_1C[0];
					if (rSEG_DB == dAT_B)
					{
						rSEG_DB = jUNC_DB.DAT_1C[1];
					}
					if (rSEG_DB.DAT_08 == ushort.MaxValue)
					{
						FUN_38FC();
						num = vTransform.rotation.V02 * DAT_BC;
						rSEG_DB = null;
						flags &= 4294967039u;
						if (num < 0)
						{
							num += 31;
						}
						physics1.X = num >> 5;
						physics1.Y = 0;
						num = vTransform.rotation.V22 * DAT_BC;
						if (num < 0)
						{
							num += 31;
						}
						physics1.Z = num >> 5;
						GameManager.instance.FUN_30CB0(this, 300);
					}
					else
					{
						DAT_C0 = ((rSEG_DB.DAT_00[0] == jUNC_DB) ? 1 : 0);
					}
				}
				else
				{
					num2 = 0;
					RSEG_DB rSEG_DB2 = rSEG_DB;
					if (jUNC_DB.DAT_11 != 0)
					{
						do
						{
							rSEG_DB = jUNC_DB.DAT_1C[num2];
							if (rSEG_DB != dAT_B && DAT_C0 == ((rSEG_DB.DAT_00[0] == jUNC_DB) ? 1 : 0))
							{
								rSEG_DB2 = rSEG_DB;
								if (((rSEG_DB.DAT_08 != dAT_B.DAT_08) ? 1 : 0) == SteelMil.instance.DAT_4618[jUNC_DB.DAT_12])
								{
									break;
								}
							}
							rSEG_DB = rSEG_DB2;
							num2++;
							rSEG_DB2 = rSEG_DB;
						}
						while (num2 < jUNC_DB.DAT_11);
					}
					if (DAT_A8 != null && DAT_A8.DAT_B8 != rSEG_DB)
					{
						FUN_38FC();
					}
				}
				DAT_B8 = rSEG_DB;
				DAT_C4 = ((DAT_C0 == 0) ? 1 : 0) << 28;
				if (rSEG_DB != null)
				{
					if (tags != 2)
					{
						return 1;
					}
					if (rSEG_DB.DAT_00[DAT_C0].DAT_11 != 1)
					{
						return 1;
					}
					if (rSEG_DB.DAT_00[DAT_C0].DAT_12 != 0)
					{
						return 1;
					}
					tags = 1;
				}
				result = 1;
			}
		}
		return result;
		IL_0255:
		num2 = DAT_BC * -65536;
		goto IL_0263;
	}
}
