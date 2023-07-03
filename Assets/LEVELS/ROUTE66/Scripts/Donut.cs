using UnityEngine;

public class Donut : VigObject
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
		VigObject self = hit.self;
		if (self.type == 8)
		{
			FUN_32B90(self.maxHalfHealth);
			return 0u;
		}
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			GameManager.instance.FUN_2F798(this, hit);
			Vector3Int vector3Int = Utilities.FUN_24148(vTransform, hit.position);
			Vector3Int v = default(Vector3Int);
			v.x = (vehicle.vTransform.position.x - vTransform.position.x) * 8;
			v.y = (vehicle.vTransform.position.y - vTransform.position.y) * 8;
			v.z = (vehicle.vTransform.position.z - vTransform.position.z) * 8;
			vehicle.FUN_2B370(v, vector3Int);
			int param = GameManager.instance.FUN_1DD9C();
			uint num = GameManager.FUN_2AC5C();
			int param2 = 25;
			if ((num & 1) != 0)
			{
				param2 = 24;
			}
			GameManager.instance.FUN_1E5D4(param, GameManager.instance.DAT_C2C, param2, vector3Int);
			UIManager.instance.FUN_4E414(vector3Int, new Color32(128, 128, 128, 8));
			LevelManager.instance.FUN_4DE54(vector3Int, 142);
			vehicle.FUN_3A064(-3, vector3Int, param3: true);
			return 0u;
		}
		HitDetection hitDetection = new HitDetection(null);
		GameManager.instance.FUN_2FB70(self, hit, hitDetection);
		int num2 = physics1.X * hitDetection.normal1.x + physics1.Y * hitDetection.normal1.y + physics1.Z * hitDetection.normal1.z;
		if (0 < num2)
		{
			int num3 = (num2 >> 12) * 2;
			num2 = num3 * hitDetection.normal1.x;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			physics1.X -= num2 >> 12;
			num2 = num3 * hitDetection.normal1.y;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			physics1.Y -= num2 >> 12;
			num3 *= hitDetection.normal1.z;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			physics1.Z -= num3 >> 12;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 != 0)
			{
				return 0u;
			}
			Vector3Int pos = default(Vector3Int);
			pos.x = vTransform.position.x;
			pos.y = vTransform.position.y + DAT_58;
			pos.z = vTransform.position.z;
			Vector3Int normalVector = default(Vector3Int);
			int num = FUN_2CFBC(pos, ref normalVector);
			if (num < pos.y + 2048)
			{
				int x = normalVector.x;
				int x2 = physics1.X;
				int num2 = x2 * x + physics1.Y * normalVector.y + physics1.Z * normalVector.z;
				if (num2 < 0)
				{
					num2 += 2047;
				}
				num2 >>= 11;
				if (num2 < 0)
				{
					x = num2 * x;
					if (x < 0)
					{
						x += 4095;
					}
					physics1.X = x2 - (x >> 12);
					x = num2 * normalVector.y;
					if (x < 0)
					{
						x += 4095;
					}
					physics1.Y = (physics1.Y - (x >> 12)) / 2;
					num2 *= normalVector.z;
					if (num2 < 0)
					{
						num2 += 4095;
					}
					physics1.Z -= num2 >> 12;
					vTransform.position.y = num - DAT_58;
				}
				else
				{
					x *= 90;
					if (x < 0)
					{
						x += 4095;
					}
					physics1.X = x2 + (x >> 12);
					num = normalVector.z * 90;
					if (num < 0)
					{
						num += 4095;
					}
					physics1.Z += num >> 12;
				}
				int y = (int)Utilities.Ratan2(physics1.X, physics1.Z);
				vr.y = y;
				num = (int)Utilities.SquareRoot(physics1.X * physics1.X + physics1.Z * physics1.Z);
				if (physics2.Y == 0)
				{
					physics1.M6 = (short)((num << 12) / -1);
				}
				else
				{
					physics1.M6 = (short)((num << 12) / physics2.Y);
				}
				if (num < 457)
				{
					FUN_4DC94();
					return uint.MaxValue;
				}
			}
			else
			{
				physics1.Y += 90;
			}
			vr.x -= physics1.M6;
			vTransform.position.x += physics1.X;
			vTransform.position.y += physics1.Y;
			vTransform.position.z += physics1.Z;
			if (arg2 != 0)
			{
				num = (int)GameManager.instance.FUN_1E7A8(vTransform.position);
				if (num == 0)
				{
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
				}
				else if (DAT_18 == 0)
				{
					sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E098(param, LevelManager.instance.xobfList[42].sndList, 7, (uint)num, param5: true);
				}
				else
				{
					GameManager.instance.FUN_1E2C8(DAT_18, (uint)num);
				}
				ApplyRotationMatrix();
				return 0u;
			}
		}
		else
		{
			switch (arg1)
			{
			default:
				return 0u;
			case 9:
				if (arg2 == 0)
				{
					return 0u;
				}
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			case 4:
				break;
			}
			GameManager.instance.FUN_1DE78(DAT_18);
		}
		return 0u;
	}
}
