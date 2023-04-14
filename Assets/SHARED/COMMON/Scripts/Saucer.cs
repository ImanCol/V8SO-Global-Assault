using System.Collections.Generic;
using UnityEngine;

public class Saucer : VigObject
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
		if (hit.object2.type == 3)
		{
			return 0u;
		}
		VigObject self = hit.self;
		if (self.type != 3)
		{
			GameManager.instance.FUN_2F798(this, hit);
			int num = physics1.Z * hit.normal1.x + physics1.W * hit.normal1.y + physics2.X * hit.normal1.z;
			if (num < 0)
			{
				num += 2047;
			}
			num >>= 11;
			if (-1 < num)
			{
				return 0u;
			}
			if (self.type == 2)
			{
				Vehicle vehicle = (Vehicle)self;
				Vector3Int v = default(Vector3Int);
				v.x = physics1.Z << 3;
				v.y = physics1.W << 3;
				v.z = physics2.X << 3;
				vehicle.FUN_2B370(v, screen);
				if ((flags & 0x8000) == 0)
				{
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 7, screen);
					LevelManager.instance.FUN_4DE54(screen, 142);
					UIManager.instance.FUN_4E414(screen, new Color32(64, 64, 64, 8));
					if (vehicle.id < 0)
					{
						GameManager.instance.FUN_15B00(~vehicle.id, 192, 0, 64);
					}
				}
				flags |= 553680896u;
			}
			int num2 = num * hit.normal1.x;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			physics1.Z -= num2 >> 12;
			num2 = num * hit.normal1.y;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			physics1.W -= num2 >> 12;
			num *= hit.normal1.z;
			if (num < 0)
			{
				num += 4095;
			}
			physics2.X -= num >> 12;
			if (self.type == 8)
			{
				physics1.Z -= self.physics1.Z * 20;
				physics1.W -= self.physics1.W * 20;
				physics2.X -= self.physics2.X * 20;
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
			short num2 = (short)(physics2.M3 - 1);
			physics2.M3 = num2;
			Vector3Int vout;
			if (num2 < 0)
			{
				if (num2 < -120)
				{
					GameManager.instance.FUN_309A0(this);
					GameManager.instance.DAT_1084--;
					return uint.MaxValue;
				}
				vout = new Vector3Int(0, -4096, 0);
			}
			else if (tags == 0)
			{
				Utilities.FUN_2A168(out vout, screen, DAT_84.screen);
			}
			else
			{
				Utilities.FUN_2A168(out vout, screen, new Vector3Int(DAT_80.screen.x, DAT_80.screen.y - 65536, DAT_80.screen.z));
			}
			int num3 = vout.x;
			if (num3 < 0)
			{
				num3 += 15;
			}
			int num = physics1.Z;
			num3 = num + (num3 >> 4);
			if (num < 0)
			{
				num += 127;
			}
			num3 -= num >> 7;
			num = -15258;
			if (-15259 < num3)
			{
				num = 18310;
				if (num3 < 18311)
				{
					num = num3;
				}
			}
			physics1.Z = num;
			num3 = vout.y;
			if (num3 < 0)
			{
				num3 += 15;
			}
			num = physics1.W;
			num3 = num + (num3 >> 4);
			if (num < 0)
			{
				num += 127;
			}
			int num4 = FUN_2CFBC(screen);
			num4 -= screen.y + 10240;
			if (num4 < 0)
			{
				num4 += 15;
			}
			int num5 = 0;
			if (num4 >> 4 < 0)
			{
				num5 = num4 >> 4;
			}
			num5 = num3 - (num >> 7) + num5;
			num3 = -3051;
			if (-3052 < num5)
			{
				num3 = 18310;
				if (num5 < 18311)
				{
					num3 = num5;
				}
			}
			physics1.W = num3;
			num3 = vout.z;
			if (num3 < 0)
			{
				num3 += 15;
			}
			num = physics2.X;
			num3 = num + (num3 >> 4);
			if (num < 0)
			{
				num += 127;
			}
			num3 -= num >> 7;
			num = -15258;
			if (-15259 < num3)
			{
				num = 18310;
				if (num3 < 18311)
				{
					num = num3;
				}
			}
			physics2.X = num;
			screen.x += physics1.Z;
			screen.y += physics1.W;
			screen.z += physics2.X;
			vr.y += 136;
			if (arg2 == 0)
			{
				break;
			}
			ApplyTransformation();
			uint volume = GameManager.instance.FUN_1E7A8(vTransform.position);
			GameManager.instance.FUN_1E2C8(DAT_18, volume);
			uint num6 = (uint)((int)flags & -16809985);
			if ((flags & 0x1000000) != 0)
			{
				num6 |= 0x8000;
			}
			flags = num6;
			if ((num6 & 0x20000000) != 0)
			{
				if (DAT_80.maxHalfHealth != 0)
				{
					return 0u;
				}
				flags = (uint)((int)num6 & -536870913);
			}
			break;
		}
		case 1:
		{
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, 3, 0u, param5: true);
			int num = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_30CB0(this, (num >> 10) * 2 + 200);
			return 0u;
		}
		case 2:
		{
			ShootLaser();
			int num = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_30CB0(this, (num >> 10) * 4);
			break;
		}
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 10)
		{
			if (DAT_84 != arg2)
			{
				return 0u;
			}
			DAT_84 = DAT_80;
		}
		return 0u;
	}

	private Laser2 ShootLaser()
	{
		if (DAT_84 == null)
		{
			return null;
		}
		if (tags == 1)
		{
			VigObject dAT_ = null;
			uint num = uint.MaxValue;
			List<VigTuple> worldObjs = GameManager.instance.worldObjs;
			for (int i = 0; i < worldObjs.Count; i++)
			{
				VigObject vObject = worldObjs[i].vObject;
				if (vObject.type == 2 && vObject.id != base.id && vObject.maxHalfHealth != 0)
				{
					uint num2 = (uint)Utilities.FUN_29F6C(vTransform.position, vObject.screen);
					if (num2 < num)
					{
						dAT_ = vObject;
						num = num2;
					}
				}
			}
			DAT_84 = dAT_;
		}
		VigObject dAT_2 = DAT_84;
		int num3 = Utilities.FUN_29F6C(vTransform.position, dAT_2.screen);
		if (num3 > 262144 && num3 < 786432)
		{
			ushort param = (ushort)(vData.ini.configContainers.Count - 1);
			Laser2 laser = vData.ini.FUN_2C17C(param, typeof(Laser2), 8u) as Laser2;
			short id = base.id;
			laser.type = 8;
			laser.id = id;
			laser.vTransform = vTransform;
			laser.screen = laser.vTransform.position;
			Vector3Int vin = default(Vector3Int);
			vin.x = dAT_2.screen.x - laser.screen.x;
			vin.y = dAT_2.screen.y - laser.screen.y;
			vin.z = dAT_2.screen.z - laser.screen.z;
			Utilities.FUN_29FC8(vin, out Vector3Int vout);
			int num4 = -vout.x;
			if (0 < vout.x)
			{
				num4 += 3;
			}
			int num5 = laser.vTransform.rotation.V02;
			if (num5 < 0)
			{
				num5 += 3;
			}
			vout.x = vout.x + (num4 >> 6) + (num5 >> 6);
			num4 = -vout.y;
			if (0 < vout.y)
			{
				num4 += 3;
			}
			num5 = laser.vTransform.rotation.V12;
			if (num5 < 0)
			{
				num5 += 3;
			}
			vout.y = vout.y + (num4 >> 6) + (num5 >> 6);
			num4 = -vout.z;
			if (0 < vout.z)
			{
				num4 += 3;
			}
			num5 = laser.vTransform.rotation.V22;
			if (num5 < 0)
			{
				num5 += 3;
			}
			vout.z = vout.z + (num4 >> 6) + (num5 >> 6);
			vout = Utilities.VectorNormal(vout);
			laser.vTransform.rotation = Utilities.FUN_2A724(vout);
			laser.flags |= 536871300u;
			laser.maxHalfHealth = (ushort)(maxHalfHealth * 4);
			laser.DAT_80 = DAT_80;
			laser.physics2.M3 = 2;
			laser.physics2.M2 = 8;
			laser.FUN_305FC();
			num3 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E5D4(num3, vData.sndList, 6, vTransform.position);
			num5 = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_1E30C(num3, (num5 << 10 >> 15) + 3584);
			return laser;
		}
		return null;
	}
}
