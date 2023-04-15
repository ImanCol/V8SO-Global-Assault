using UnityEngine;

public class Boulder2 : VigObject
{
	private static Vector3Int DAT_4C = new Vector3Int(0, 0, 0);

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
		int num;
		if (self.type != 8)
		{
			if ((flags & 0x80) == 0)
			{
				return 0u;
			}
			int num2;
			if (self.type != 2)
			{
				GameManager.instance.FUN_2F798(this, hit);
				num = physics1.X * hit.normal1.x + physics1.Y * hit.normal1.y + physics1.Z * hit.normal1.z;
				if (num < 0)
				{
					num += 2047;
				}
				num >>= 11;
				if (num < 0)
				{
					num2 = num * hit.normal1.x;
					if (num2 < 0)
					{
						num2 += 4095;
					}
					physics1.X -= num2 >> 12;
					num2 = num * hit.normal1.y;
					if (num2 < 0)
					{
						num2 += 4095;
					}
					physics1.Y -= num2 >> 12;
					num *= hit.normal1.z;
					if (num < 0)
					{
						num += 4095;
					}
					physics1.Z -= num >> 12;
					return 0u;
				}
				return 0u;
			}
			Vehicle vehicle = (Vehicle)self;
			int num3 = 65536 / (int)(ushort)vehicle.DAT_A6;
			Vector2Int vector2Int = Utilities.FUN_2ACD0(new Vector3Int(physics1.X, physics1.Y, physics1.Z), new Vector3Int(vehicle.physics1.X, vehicle.physics1.Y, vehicle.physics1.Z));
			if (0 < vector2Int.y)
			{
				return 0u;
			}
			if (vector2Int.y == 0 && vector2Int.x != 0)
			{
				return 0u;
			}
			Vector3Int v = default(Vector3Int);
			num2 = physics1.X * num3;
			if (num2 < -1048576)
			{
				v.x = -1048576;
			}
			else
			{
				v.x = 1048576;
				if (num2 < 1048577)
				{
					v.x = num2;
				}
			}
			num2 = physics1.Y * num3;
			v.y = -1048576;
			if (-1048577 < num2)
			{
				v.y = 1048576;
				if (num2 < 1048577)
				{
					v.y = num2;
				}
			}
			num2 = physics1.Z * num3;
			v.z = -1048576;
			if (-1048577 < num2)
			{
				v.z = 1048576;
				if (num2 < 1048577)
				{
					v.z = num2;
				}
			}
			vehicle.FUN_2B370(v, vTransform.position);
			((Vehicle)hit.self).FUN_3A020(-100, DAT_4C, param3: true);
			return 0u;
		}
		if (!FUN_32B90(self.maxHalfHealth))
		{
			return 0u;
		}
		num = DAT_58;
		if (num != 0)
		{
			VigShadow vShadow = base.vShadow;
			if (num < 0)
			{
				num += 15;
			}
			vShadow.DAT_28 = num >> 4;
			vShadow.DAT_24 = num >> 4;
			num = DAT_58 * 2364;
			if (num < 0)
			{
				num += 4095;
			}
			DAT_58 = num >> 12;
			num = (num >> 12) * 12867;
			if (num < 0)
			{
				num += 4095;
			}
			physics2.M2 = (short)(16777216 / (num >> 12));
			if ((flags & 0x80) != 0)
			{
				return 0u;
			}
			FUN_30B78();
			return 0u;
		}
		GameManager.instance.FUN_300B8(CANYNLND.instance.DAT_1298, this);
		GameManager.instance.FUN_309A0(this);
		CANYNLND.instance.DAT_12A4--;
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 2)
		{
			if (arg1 < 3)
			{
				if (arg1 != 0)
				{
					return 0u;
				}
				Vector3Int pos = default(Vector3Int);
				Vector3Int normalVector = default(Vector3Int);
				pos.x = vTransform.position.x;
				pos.y = vTransform.position.y + DAT_58;
				pos.z = vTransform.position.z;
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
						physics1.Y -= x >> 12;
						x = num2 * normalVector.z;
						if (x < 0)
						{
							x += 4095;
						}
						physics1.Z -= x >> 12;
						physics1.Y /= 2;
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
					num = -physics1.Z * (ushort)physics2.M2;
					if (num < 0)
					{
						num += 4095;
					}
					x = physics1.X * (ushort)physics2.M2;
					physics1.M6 = (short)(num >> 12);
					if (x < 0)
					{
						x += 4095;
					}
					physics2.M0 = (short)(x >> 12);
					if (normalVector.y < -3686)
					{
						num = physics1.Y;
						x = physics1.X;
						if (num < 0)
						{
							num = -num;
						}
						if (x < 0)
						{
							x = -x;
						}
						if (num < x)
						{
							num = x;
						}
						x = physics1.Z;
						if (x < 0)
						{
							x = -x;
						}
						if (x < num)
						{
							x = num;
						}
						if (x < 1068)
						{
							FUN_30BA8();
							goto IL_02f9;
						}
					}
					if (num2 < -457)
					{
						int param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E628(param, vData.sndList, 1, vTransform.position);
					}
				}
				else
				{
					physics1.Y += 90;
				}
				goto IL_02f9;
			}
			return 0u;
		}
		GameManager.instance.FUN_300B8(CANYNLND.instance.DAT_1298, this);
		GameManager.instance.FUN_309A0(this);
		CANYNLND.instance.DAT_12A4--;
		return uint.MaxValue;
		IL_02f9:
		vTransform.rotation = Utilities.FUN_2ADB0(vTransform.rotation, new Vector3Int(physics1.M6, physics1.M7, physics2.M0));
		vTransform.position.x += physics1.X;
		vTransform.position.y += physics1.Y;
		int num3 = GameManager.instance.DAT_28 - DAT_19;
		vTransform.position.z += physics1.Z;
		if ((num3 & 0xF) != 0)
		{
			return 0u;
		}
		vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
		return 0u;
	}
}