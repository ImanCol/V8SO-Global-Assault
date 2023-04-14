using System.IO;
using UnityEngine;

public class TrainEngine2 : Destructible
{
	private static Vector3Int DAT_13C = new Vector3Int(0, 0, 0);

	public RSEG_DB DAT_A8;

	public int DAT_AC;

	public int[] DAT_B0;

	public int DAT_B4;

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
		if (self.type == 8)
		{
			if (tags < 0)
			{
				return 0u;
			}
			if (FUN_32B90(self.maxHalfHealth))
			{
				int num = vTransform.rotation.V02 * DAT_AC;
				DAT_A8 = null;
				tags = -1;
				flags &= 4294967039u;
				if (num < 0)
				{
					num += 31;
				}
				physics1.X = num >> 5;
				physics1.Y = 0;
				num = vTransform.rotation.V22 * DAT_AC;
				if (num < 0)
				{
					num += 31;
				}
				physics1.Z = num >> 5;
				GameManager.instance.FUN_30CB0(this, 300);
				physics1.Y = 30000;
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
				GameManager.instance.FUN_30CB0(this, 300);
				GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 10, this);
				return 0u;
			}
		}
		else
		{
			if (self.type == 2)
			{
				HitDetection hitDetection = new HitDetection(null);
				GameManager.instance.FUN_2FB70(this, hit, hitDetection);
				if (Utilities.FUN_24238(vTransform.rotation, hitDetection.normal1).z < 2049)
				{
					return 0u;
				}
				int num = vTransform.rotation.V02 * DAT_AC;
				if (num < 0)
				{
					num += 31;
				}
				Vector3Int v = default(Vector3Int);
				v.x = self.physics1.X - (num >> 5);
				v.y = self.physics1.Y;
				num = vTransform.rotation.V22 * DAT_AC;
				if (num < 0)
				{
					num += 31;
				}
				v.z = self.physics1.Z - (num >> 5);
				long num2 = Utilities.FUN_2AD3C(v, hitDetection.normal1);
				uint num3 = (uint)((int)((uint)num2 >> 11) | ((int)(num2 >> 32) << 21));
				if (-1 < (int)num3)
				{
					return 0u;
				}
				uint num4 = (uint)(hitDetection.normal2.x << 16 >> 16);
				uint num5 = (uint)(-((int)num3 + hitDetection.distance));
				num = -((num5 != 0) ? 1 : 0) - ((int)num3 + hitDetection.distance >> 31);
				long num6 = (long)num4 * (long)num5;
				Vector3Int v2 = default(Vector3Int);
				v2.x = ((int)((uint)num6 >> 12) | (((int)((ulong)num6 >> 32) + (int)num4 * num + (int)num5 * (hitDetection.normal2.x << 16 >> 31)) * 1048576));
				num4 = (uint)(hitDetection.normal2.y << 16 >> 16);
				num6 = (long)num4 * (long)num5;
				v2.y = ((int)((uint)num6 >> 12) | (((int)((ulong)num6 >> 32) + (int)num4 * num + (int)num5 * (hitDetection.normal2.y << 16 >> 31)) * 1048576));
				num4 = (uint)(hitDetection.normal2.z << 16 >> 16);
				num6 = (long)num4 * (long)num5;
				v2.z = ((int)((uint)num6 >> 12) | (((int)((ulong)num6 >> 32) + (int)num4 * num + (int)num5 * (hitDetection.normal2.z << 16 >> 31)) * 1048576));
				Vehicle obj = (Vehicle)self;
				obj.FUN_2B1FC(v2, hitDetection.position);
				obj.FUN_3A020((int)(num3 + 8191) >> 13, hitDetection.position, param3: true);
				Vector3Int vector3Int = Utilities.FUN_24148(obj.vTransform, hitDetection.position);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 7, vector3Int);
				LevelManager.instance.FUN_4E8C8(vector3Int, 48);
				return 0u;
			}
			if (self.GetType().IsSubclassOf(typeof(VigObject)))
			{
				self.UpdateW(8, 1000);
				return 0u;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			if (FUN_750() != 0 && DAT_A8 != null && (DAT_A8.DAT_0C & 0x100) != 0)
			{
				int param2 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param2, vData.sndList, 6, vTransform.position);
			}
			if (tags < 0)
			{
				if (((GameManager.instance.DAT_28 - DAT_19) & 3) != 0)
				{
					return 0u;
				}
				TrainSmoke obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(18, typeof(TrainSmoke), 8u) as TrainSmoke;
				int dAT_ = GameManager.instance.DAT_28;
				obj.flags |= 1204u;
				obj.screen = screen;
				obj.vr.z = dAT_ * 96;
				obj.FUN_3066C();
				return 0u;
			}
			if (arg2 == 0)
			{
				return 0u;
			}
			uint volume = GameManager.instance.FUN_1E7A8(vTransform.position);
			GameManager.instance.FUN_1E2C8(DAT_18, volume);
			return 0u;
		}
		case 1:
		{
			FUN_6AC();
			ConfigContainer configContainer = FUN_2C5F4(32768);
			if (configContainer != null)
			{
				Smoke smoke = LevelManager.instance.xobfList[19].FUN_4F438(5, DAT_13C);
				Utilities.FUN_2CA94(this, configContainer, smoke);
				Utilities.ParentChildren(this, this);
				smoke.FUN_30B78();
				if ((flags & 4) == 0)
				{
					smoke.FUN_30BF0();
				}
				sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E098(param, vData.sndList, 0, 0u, param5: true);
				return 0u;
			}
			break;
		}
		case 2:
			if (tags < 0)
			{
				FUN_4DC94();
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
			tags = -1;
			FUN_4DC94();
			GameManager.instance.FUN_1DE78(DAT_18);
			DAT_18 = 0;
			GameManager.instance.FUN_30CB0(this, 300);
			return uint.MaxValue;
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		}
		return 0u;
	}

	public void FUN_6AC()
	{
		RSEG_DB rSEG_DB = DAT_A8 = LevelManager.instance.FUN_518DC(screen, -1);
		DAT_B0 = new int[1];
		DAT_B0[0] = 1;
		int num = rSEG_DB.FUN_51334(screen);
		DAT_B4 = num << 16;
		DAT_AC = 3814;
		PDAT_78 = null;
		PDAT_74 = null;
		physics2.X = 0;
		flags |= 384u;
		physics2.Y = 0;
		physics2.Z = 0;
		DAT_A0 = new Vector3Int(16, 32, 64);
	}

	public int FUN_750()
	{
		int result;
		if (DAT_A8 == null)
		{
			vCollider.reader.Seek(4L, SeekOrigin.Current);
			FUN_2B4F8(vCollider.reader);
			vCollider.reader.Seek(-4L, SeekOrigin.Current);
			result = 0;
		}
		else
		{
			int num;
			int dAT_AC;
			if ((flags & 0x1000000) != 0)
			{
				num = DAT_AC - 14;
				dAT_AC = 0;
				if (0 < num)
				{
					dAT_AC = num;
				}
				DAT_AC = dAT_AC;
			}
			dAT_AC = DAT_B4;
			if (dAT_AC < 0)
			{
				dAT_AC += 65535;
			}
			DAT_A8.FUN_285E4(dAT_AC >> 16, ref vTransform.position, out Vector3Int param);
			param.y = 0;
			if (DAT_B0[0] == 0)
			{
				param.x = -param.x;
				param.z = -param.z;
			}
			Utilities.VectorNormal2(param, out Vector3Int n);
			vTransform.rotation.V22 = (short)n.z;
			vTransform.rotation.V00 = (short)n.z;
			vTransform.rotation.V02 = (short)n.x;
			vTransform.rotation.V20 = (short)(-n.x);
			dAT_AC = (int)Utilities.SquareRoot(param.x * param.x + param.z * param.z);
			num = ((DAT_B0[0] != 0) ? DAT_AC : (-DAT_AC));
			int num2 = DAT_B4 += (num << 16) / dAT_AC;
			result = 0;
			if (268435456u < (uint)num2)
			{
				if ((DAT_A8 = DAT_A8.FUN_512A8(DAT_B0)) == null)
				{
					dAT_AC = vTransform.rotation.V02 * DAT_AC;
					flags &= 4294967039u;
					if (dAT_AC < 0)
					{
						dAT_AC += 31;
					}
					physics1.X = dAT_AC >> 5;
					physics1.Y = 0;
					dAT_AC = vTransform.rotation.V22 * DAT_AC;
					if (dAT_AC < 0)
					{
						dAT_AC += 31;
					}
					physics1.Z = dAT_AC >> 5;
					GameManager.instance.FUN_30CB0(this, 120);
				}
				else
				{
					DAT_B4 = (-((DAT_B0[0] == 0) ? 1 : 0) & 0x10000000);
				}
				result = 1;
			}
		}
		return result;
	}
}
