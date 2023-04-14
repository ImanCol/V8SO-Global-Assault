using UnityEngine;

public class Tumble : VigObject
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
		int num;
		Vehicle vehicle;
		if (self.type == 2 && (flags & 1) == 0)
		{
			vehicle = (Vehicle)self;
			Vector3Int v = default(Vector3Int);
			v.x = vTransform.position.x - vehicle.vTransform.position.x;
			v.y = vTransform.position.y - vehicle.vTransform.position.y;
			v.z = vTransform.position.z - vehicle.vTransform.position.z;
			Utilities.FUN_243B4(vehicle.vTransform.rotation);
			vTransform.position = Utilities.FUN_23F7C(v);
			vTransform.rotation = Utilities.FUN_247F4(vTransform.rotation);
			GameManager.instance.FUN_300B8(GameManager.instance.worldObjs, this);
			Utilities.FUN_2CC48(vehicle, this);
			base.transform.parent = vehicle.transform;
			vehicle.lightness <<= 2;
			num = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_30CB0(this, (num * 360 >> 15) + 360);
			return 1u;
		}
		GameManager.instance.FUN_2F798(this, hit);
		num = physics1.X * hit.normal1.x + physics1.Y * hit.normal1.y + physics1.Z * hit.normal1.z;
		if (num < 0)
		{
			num += 2047;
		}
		num >>= 11;
		int num3;
		if (num < 0)
		{
			uint num2 = GameManager.FUN_2AC5C();
			num3 = num * (hit.normal1.x + (int)(num2 & 0xFF));
			if (num3 < 0)
			{
				num3 += 4095;
			}
			physics1.X -= num3 >> 12;
			num3 = num * hit.normal1.y;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			physics1.Y -= num3 >> 12;
			num *= hit.normal1.z;
			if (num < 0)
			{
				num += 4095;
			}
			physics1.Z -= num >> 12;
		}
		if (parent == null)
		{
			return 0u;
		}
		vehicle = (Vehicle)Utilities.FUN_2CD78(this);
		num3 = vehicle.lightness;
		if (num3 < 0)
		{
			num3 += 3;
		}
		vehicle.lightness = num3 >> 2;
		VigTransform vigTransform = vTransform = GameManager.instance.FUN_2CDF4(this);
		VigObject param = FUN_2CCBC();
		base.transform.parent = null;
		GameManager.instance.FUN_30080(GameManager.instance.worldObjs, param);
		GameManager.instance.FUN_30CB0(this, 120);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			if (parent != null)
			{
				return 0u;
			}
			Vector3Int pos = default(Vector3Int);
			pos.x = vTransform.position.x;
			pos.y = vTransform.position.y + DAT_58;
			pos.z = vTransform.position.z;
			Vector3Int normalVector = default(Vector3Int);
			int num2 = FUN_2CFBC(pos, ref normalVector);
			if (num2 < pos.y + 2048)
			{
				int x = normalVector.x;
				int x2 = physics1.X;
				int num = x2 * x + physics1.Y * normalVector.y + physics1.Z * normalVector.z;
				if (num < 0)
				{
					num += 2047;
				}
				num >>= 11;
				if (num < 0)
				{
					x = num * x;
					if (x < 0)
					{
						x += 4095;
					}
					physics1.X = x2 - (x >> 12);
					x = num * normalVector.y;
					if (x < 0)
					{
						x += 4095;
					}
					x = (physics1.Y - (x >> 12)) * 3;
					if (x < 0)
					{
						x += 3;
					}
					physics1.Y = x >> 2;
					x = num * normalVector.z;
					if (x < 0)
					{
						x += 4095;
					}
					physics1.Z -= x >> 12;
					vTransform.position.y = num2 - DAT_58;
					if (num < -457)
					{
						GameManager.instance.FUN_1E8B0(vData.sndList, 3, vTransform.position);
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
					num2 = normalVector.z * 90;
					if (num2 < 0)
					{
						num2 += 4095;
					}
					physics1.Z += num2 >> 12;
				}
				num2 = -physics1.Z * (ushort)physics2.M2;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				num = physics1.X * (ushort)physics2.M2;
				physics1.M6 = (short)(num2 >> 12);
				if (num < 0)
				{
					num += 4095;
				}
				physics2.M0 = (short)(num >> 12);
				num2 = physics1.X * 15;
				if (num2 < 0)
				{
					num2 += 15;
				}
				physics1.X = num2 >> 4;
				num2 = physics1.Y * 15;
				if (num2 < 0)
				{
					num2 += 15;
				}
				physics1.Y = num2 >> 4;
				num2 = physics1.Z * 15;
				if (num2 < 0)
				{
					num2 += 15;
				}
				num2 >>= 4;
			}
			else
			{
				num2 = physics1.X * 31;
				physics1.Y += 90;
				if (num2 < 0)
				{
					num2 += 31;
				}
				physics1.X = num2 >> 5;
				num2 = physics1.Y * 31;
				if (num2 < 0)
				{
					num2 += 31;
				}
				physics1.Y = num2 >> 5;
				num2 = physics1.Z * 31;
				if (num2 < 0)
				{
					num2 += 31;
				}
				num2 >>= 5;
			}
			physics1.Z = num2;
			vTransform.rotation = Utilities.FUN_2ADB0(vTransform.rotation, new Vector3Int(physics1.M6, physics1.M7, physics2.M0));
			vTransform.position.x += physics1.X;
			vTransform.position.y += physics1.Y;
			vTransform.position.z += physics1.Z;
			int num3 = GameManager.instance.DAT_28 - DAT_19;
			physics1.Z -= 128;
			if ((num3 & 0xF) == 0)
			{
				vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
			}
			if (VigTerrain.instance.DAT_DEC <= vTransform.position.z)
			{
				return 0u;
			}
			ApplyTransformation();
			physics1.X = 0;
			physics1.Y = 0;
			physics1.Z = 0;
			physics1.M6 = 0;
			physics1.M7 = 0;
			physics2.M0 = 0;
			break;
		}
		case 1:
		{
			FUN_2D1DC();
			int num2 = DAT_58 * 2364;
			flags |= 128u;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			DAT_58 = num2 >> 12;
			num2 = (num2 >> 12) * 12867;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			physics2.M2 = (short)(16777216 / (num2 >> 12));
			break;
		}
		case 2:
		{
			if (parent == null)
			{
				return 0u;
			}
			Vehicle obj = (Vehicle)Utilities.FUN_2CD78(this);
			int num = obj.lightness;
			if (num < 0)
			{
				num += 3;
			}
			obj.lightness = num >> 2;
			VigTransform vigTransform = vTransform = GameManager.instance.FUN_2CDF4(this);
			VigObject param = FUN_2CCBC();
			base.transform.parent = null;
			GameManager.instance.FUN_30080(GameManager.instance.worldObjs, param);
			GameManager.instance.FUN_30CB0(this, 120);
			return 0u;
		}
		}
		return 0u;
	}
}
