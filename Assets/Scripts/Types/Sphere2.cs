using UnityEngine;

public class Sphere2 : VigObject
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
			if (!FUN_32B90(self.maxHalfHealth))
			{
				return 0u;
			}
		}
		else
		{
			if (self.type != 2)
			{
				GameManager.instance.FUN_2F798(this, hit);
				int num = physics1.X * hit.normal1.x + physics1.Y * hit.normal1.y + physics1.Z * hit.normal1.z;
				if (num < 0)
				{
					num += 2047;
				}
				num >>= 11;
				if (-1 < num)
				{
					return 0u;
				}
				int num2 = num * hit.normal1.x;
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
			Vector3Int vector3Int = default(Vector3Int);
			vector3Int.x = (self.vTransform.position.x - vTransform.position.x) * 8;
			vector3Int.y = (self.vTransform.position.y - vTransform.position.y) * 8;
			vector3Int.z = (self.vTransform.position.z - vTransform.position.z) * 8;
			FUN_4DC94();
		}
		GameManager.instance.FUN_309A0(this);
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
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
