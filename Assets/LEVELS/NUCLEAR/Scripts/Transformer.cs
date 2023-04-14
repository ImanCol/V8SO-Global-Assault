using UnityEngine;

public class Transformer : VigObject
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
		if (hit.collider1.ReadUInt16(2) == 1 && (uint)((byte)tags - 1) < 2u)
		{
			if (hit.self.type != 2)
			{
				return 0u;
			}
			Vehicle vehicle = (Vehicle)hit.self;
			Vector3Int vin = default(Vector3Int);
			vin.x = vTransform.position.x - vehicle.vTransform.position.x;
			vin.y = vTransform.position.y - vehicle.vTransform.position.y;
			vin.z = vTransform.position.z - vehicle.vTransform.position.z;
			int num = Utilities.FUN_29FC8(vin, out Vector3Int vout);
			int num2 = -num + 327680;
			if (327680 < num)
			{
				return 0u;
			}
			if (num2 < 0)
			{
				num2 = -num + 327683;
			}
			num2 >>= 2;
			vin.x = vout.x * num2 >> 12;
			vin.y = vout.y * num2 >> 12;
			vin.z = vout.z * num2 >> 12;
			num2 = vehicle.physics1.X;
			num = num2;
			if (num2 < 0)
			{
				num = num2 + 31;
			}
			int y = vehicle.physics1.Y;
			vehicle.physics1.X = num2 + (vin.x - (num >> 5));
			num = y;
			if (y < 0)
			{
				num = y + 31;
			}
			num2 = vehicle.physics1.Z;
			vehicle.physics1.Y = y + (vin.y - (num >> 5));
			num = num2;
			if (num2 < 0)
			{
				num = num2 + 31;
			}
			vehicle.physics1.Z = num2 + (vin.z - (num >> 5));
			if (tags == 1)
			{
				FUN_30B78();
				tags = 2;
			}
			PDAT_78 = hit.self;
			return 0u;
		}
		if (hit.object1 == this || hit.self.type != 2 || 1u < (uint)((byte)tags - 1))
		{
			if (hit.self.type == 8)
			{
				if (!FUN_32B90(hit.self.maxHalfHealth))
				{
					return 0u;
				}
				return 1u;
			}
			return 0u;
		}
		Vehicle vehicle2 = (Vehicle)hit.self;
		if ((vehicle2.flags & 0x4000) != 0 && (vehicle2.flags & 0x4000000) == 0)
		{
			FUN_30BA8();
			HitDetection hitDetection = new HitDetection(null);
			GameManager.instance.FUN_2FB70(this, hit, hitDetection);
			int num3 = 0;
			Vector3Int vin = Utilities.FUN_24148(hit.self.vTransform, hitDetection.position);
			LevelManager.instance.FUN_4DE54(vin, 42);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 75, vin);
			GameManager.instance.FUN_30CB0(this, 60);
			do
			{
				Throwaway obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(49, typeof(Throwaway), 8u) as Throwaway;
				obj.physics1.M0 = 0;
				obj.physics1.M1 = 0;
				obj.physics1.M2 = 0;
				uint num4 = GameManager.FUN_2AC5C();
				obj.physics1.Z = (int)((num4 & 0xFFF) - 2048);
				int num = (int)GameManager.FUN_2AC5C();
				if (num < 0)
				{
					num += 15;
				}
				obj.physics1.W = -(num >> 4);
				num4 = GameManager.FUN_2AC5C();
				obj.physics2.X = (int)((num4 & 0xFFF) - 2048);
				obj.type = 7;
				obj.flags |= 436u;
				short id = base.id;
				num3++;
				obj.state = _THROWAWAY_TYPE.Type3;
				obj.id = id;
				obj.vTransform = GameManager.FUN_2A39C();
				obj.vTransform.position = vin;
				obj.FUN_2D1DC();
				obj.DAT_87 = 1;
				obj.FUN_305FC();
			}
			while (num3 < 12);
			Ballistic ballistic = vData.ini.FUN_2C17C(15, typeof(Ballistic), 8u) as Ballistic;
			if (ballistic != null)
			{
				VigObject vigObject = Utilities.FUN_2CD78(this);
				if (vigObject == null)
				{
					vigObject = this;
				}
				ballistic.vTransform = vigObject.vTransform;
				ballistic.flags = 4u;
				ballistic.type = 3;
				ballistic.FUN_305FC();
			}
			vehicle2.physics1.X /= 2;
			vehicle2.physics1.Z /= 2;
			Vector3Int v = default(Vector3Int);
			v.x = hitDetection.normal2.x << 3;
			v.y = hitDetection.normal2.y * 8 - 585856;
			v.z = hitDetection.normal2.z << 3;
			vehicle2.FUN_2B1FC(v, hitDetection.position);
			param = -25;
			if (vehicle2.id < 0)
			{
				UIManager.instance.FUN_4E414(vin, new Color32(0, 0, byte.MaxValue, 8));
				param = -25;
				if (vehicle2.id < 0)
				{
					param = -100;
				}
			}
			vehicle2.FUN_3A064(param, hitDetection.position, param3: false);
			vehicle2.state = _VEHICLE_TYPE.Transformer;
			GameManager.instance.FUN_30CB0(vehicle2, 15);
			num3 = 60;
			tags = 3;
			GameManager.instance.FUN_30CB0(this, num3);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			sbyte tags = base.tags;
			if (-1 >= tags)
			{
				break;
			}
			if (tags < 2)
			{
				return 0u;
			}
			if (tags != 2)
			{
				return 0u;
			}
			if (arg2 == 0)
			{
				return 0u;
			}
			if (PDAT_78 == null)
			{
				return 0u;
			}
			if ((GameManager.FUN_2AC5C() & 1) != 0)
			{
				Magnet2 magnet = LevelManager.instance.xobfList[19].ini.FUN_2C17C(49, typeof(Magnet2), 8u) as Magnet2;
				VigObject pDAT_ = PDAT_78;
				int num = (int)GameManager.FUN_2AC5C();
				magnet.screen.x = pDAT_.vTransform.position.x + num * 2;
				num = (int)GameManager.FUN_2AC5C();
				magnet.screen.y = pDAT_.vTransform.position.y + num * 2;
				num = (int)GameManager.FUN_2AC5C();
				magnet.screen.z = pDAT_.vTransform.position.z + num * 2;
				Vector3Int vin = default(Vector3Int);
				vin.x = vTransform.position.x - magnet.screen.x;
				vin.y = vTransform.position.y - magnet.screen.y;
				vin.z = vTransform.position.z - magnet.screen.z;
				Utilities.FUN_29FC8(vin, out Vector3Int vout);
				num = vout.x;
				if (num < 0)
				{
					num += 7;
				}
				magnet.physics1.Z = num >> 3;
				num = vout.y;
				if (num < 0)
				{
					num += 7;
				}
				magnet.physics1.W = num >> 3;
				num = vout.z;
				if (num < 0)
				{
					num += 7;
				}
				magnet.physics2.X = num >> 3;
				magnet.flags = 180u;
				magnet.FUN_3066C();
				PDAT_78 = null;
			}
			break;
		}
		case 1:
		{
			VigObject vigObject = child2;
			if (vigObject != null)
			{
				do
				{
					if (vigObject.id == 1)
					{
						vigObject.type = 3;
					}
					else if (vigObject.id == 2)
					{
						vigObject.flags |= 2u;
					}
					vigObject = vigObject.child;
				}
				while (vigObject != null);
				vigObject = child2;
			}
			while (vigObject != null)
			{
				if (vigObject.id == -21846)
				{
					vigObject.FUN_2CCBC();
					Utilities.FUN_2CC9C(this, vigObject);
					vigObject.transform.parent = base.transform;
					break;
				}
				vigObject = vigObject.child;
			}
			base.tags = 0;
			int num = (int)GameManager.FUN_2AC5C();
			num = (num * 420 >> 15) + 180;
			GameManager.instance.FUN_30CB0(this, num);
			break;
		}
		case 2:
		{
			sbyte tags = base.tags;
			if (tags == 0)
			{
				VigObject vigObject = child2;
				while (vigObject != null)
				{
					if (vigObject.id == 2)
					{
						vigObject.flags &= 4294967293u;
						break;
					}
					vigObject = vigObject.child;
				}
				int num = (int)GameManager.FUN_2AC5C();
				GameManager.instance.FUN_30CB0(this, (num * 420 >> 15) + 420);
				base.tags = 1;
			}
			else
			{
				if (-1 >= tags)
				{
					break;
				}
				if (3 < tags)
				{
					return 0u;
				}
				VigObject vigObject = child2;
				while (vigObject != null)
				{
					if (vigObject.id == 2)
					{
						vigObject.flags |= 2u;
						break;
					}
					vigObject = vigObject.child;
				}
				FUN_30BA8();
				int num = (int)GameManager.FUN_2AC5C();
				GameManager.instance.FUN_30CB0(this, (num * 420 >> 15) + 420);
				PDAT_78 = null;
				base.tags = 0;
			}
			break;
		}
		case 8:
			FUN_32B90((uint)arg2);
			return 0u;
		}
		return 0u;
	}
}
