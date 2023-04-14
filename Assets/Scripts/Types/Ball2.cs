using UnityEngine;

public class Ball2 : VigObject
{
	private static Vector3Int DAT_158 = new Vector3Int(0, 0, 0);

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
		uint num = (uint)(204800 / (int)(ushort)vehicle.DAT_A6);
		int num2 = physics1.X * (int)num;
		int num3 = 1048576;
		if (num2 < 1048576)
		{
			num3 = num2;
		}
		Vector3Int v = default(Vector3Int);
		v.x = -1048576;
		if (-1048576 < num3)
		{
			v.x = num3;
		}
		num2 = physics1.Y * (int)num;
		num3 = 1048576;
		if (num2 < 1048576)
		{
			num3 = num2;
		}
		v.y = -1048576;
		if (-1048576 < num3)
		{
			v.y = num3;
		}
		num2 = physics1.Z * (int)num;
		num3 = 1048576;
		if (num2 < 1048576)
		{
			num3 = num2;
		}
		v.z = -1048576;
		if (-1048576 < num3)
		{
			v.z = num3;
		}
		vehicle.FUN_2B370(v, vTransform.position);
		if ((flags & 0x1000000) != 0)
		{
			return 0u;
		}
		flags |= 16777216u;
		vehicle.FUN_3A020(-6, DAT_158, param3: true);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
			Vector3Int vector3Int = default(Vector3Int);
			Vector3Int normalVector = default(Vector3Int);
			vector3Int.x = vTransform.position.x;
			vector3Int.y = vTransform.position.y + DAT_58;
			vector3Int.z = vTransform.position.z;
			int num = FUN_2CFBC(vector3Int, ref normalVector);
			if (num < vector3Int.y + 2048)
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
					x2 = physics1.Y;
					physics1.Z -= x >> 12;
					if (x2 < 0)
					{
						x2 += 3;
					}
					physics1.Y = x2 >> 2;
					vTransform.position.y = num - DAT_58;
					if (num2 < 457)
					{
						LevelManager.instance.FUN_4DE54(vector3Int, 13);
						int param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E628(param, vData.sndList, 4, vTransform.position);
					}
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
				num2 = physics1.X * (ushort)physics2.M2;
				physics1.M6 = (short)(num >> 12);
				if (num2 < 0)
				{
					num2 += 4095;
				}
				physics2.M0 = (short)(num2 >> 12);
				if (vTransform.position.z < 62259200)
				{
					LevelManager.instance.FUN_4DE54(vTransform.position, 13);
					GameManager.instance.FUN_309A0(this);
					SKIRESRT.instance.DAT_94--;
					return uint.MaxValue;
				}
			}
			else
			{
				physics1.Y += 90;
			}
			vTransform.rotation = Utilities.FUN_2ADB0(vTransform.rotation, new Vector3Int(physics1.M6, physics1.M7, physics2.M0));
			vTransform.position.x += physics1.X;
			vTransform.position.y += physics1.Y;
			int num3 = GameManager.instance.DAT_28 - DAT_19;
			vTransform.position.z += physics1.Z;
			if ((num3 & 0xF) == 0)
			{
				vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
				return 0u;
			}
		}
		return 0u;
	}
}