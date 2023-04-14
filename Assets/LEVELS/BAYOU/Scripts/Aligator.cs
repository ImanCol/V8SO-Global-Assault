using System.Collections.Generic;
using UnityEngine;

public class Aligator : VigObject
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
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			if (DAT_1A == 27)
			{
				GameManager.instance.FUN_2F798(this, hit);
				Vector3Int vector3Int = Utilities.FUN_24148(vTransform, hit.position);
				LevelManager.instance.FUN_4DE54(vector3Int, 142);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 24, vector3Int);
				param = -25;
				if (vehicle.id < 0)
				{
					param = -100;
				}
				vehicle.FUN_3A064(param, vector3Int, param3: true);
				flags |= 32u;
				Vector3Int v = new Vector3Int(0, -4587, 0);
				vector3Int.x = vector3Int.x / 2 + hit.self.vTransform.position.x / 2;
				vector3Int.y = vector3Int.y / 2 + hit.self.vTransform.position.y / 2;
				vector3Int.z = vector3Int.z / 2 + hit.self.vTransform.position.z / 2;
				vehicle.FUN_2B370(v, vector3Int);
				if (vehicle.shield == 0)
				{
					vehicle.physics1.Y = -585856;
					vehicle.physics2.Z = 52000;
					vehicle.flip += 10;
				}
				return 0u;
			}
			if (tags != 1)
			{
				return 0u;
			}
			if (DAT_1A != 26)
			{
				return 0u;
			}
			HitDetection hitDetection = new HitDetection(null);
			GameManager.instance.FUN_2FB70(this, hit, hitDetection);
			if (2048 < Utilities.FUN_24238(vTransform.rotation, hitDetection.normal1).z)
			{
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, vData.sndList, 5, vTransform.position);
				flags |= 32u;
				FUN_2C124(27);
				Utilities.ParentChildren(this, this);
				GameManager.instance.FUN_30CB0(this, 20);
				return 0u;
			}
			return 0u;
		}
		int num;
		VigObject vigObject;
		if (self.type == 8 && tags == 0)
		{
			tags = 2;
			num = (int)GameManager.FUN_2AC5C();
			vigObject = (DAT_80 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (num * 5 >> 15) + 1200));
			FUN_30B78();
			FUN_30BF0();
			return 0u;
		}
		if (self.id != 100)
		{
			return 0u;
		}
		if (tags != 1)
		{
			return 0u;
		}
		tags = 2;
		num = (int)GameManager.FUN_2AC5C();
		vigObject = (DAT_80 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (num * 5 >> 15) + 1200));
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int num3 = DAT_80.vTransform.position.x - vTransform.position.x;
			int num4 = DAT_80.vTransform.position.z - vTransform.position.z;
			int num5 = Utilities.Ratan2(num3, num4);
			int num6 = (num5 - (ushort)vr.y) * 1048576 >> 20;
			num5 = -22;
			if (-23 < num6)
			{
				num5 = 22;
				if (num6 < 23)
				{
					num5 = num6;
				}
			}
			int num7 = (ushort)vr.y + num5;
			vr.y = (short)num7;
			Vector3Int v = default(Vector3Int);
			v.x = GameManager.DAT_65C90[(num7 & 0xFFF) * 2];
			v.z = GameManager.DAT_65C90[(vr.y & 0xFFF) * 2 + 1];
			if (DAT_1A == 25)
			{
				num5 = v.x * 3051;
				if (num5 < 0)
				{
					num5 += 4095;
				}
				vTransform.position.x += num5 >> 12;
				num5 = v.z * 3051;
			}
			else
			{
				num5 = v.x * 4577;
				if (num5 < 0)
				{
					num5 += 4095;
				}
				vTransform.position.x += num5 >> 12;
				num5 = v.z * 4577;
			}
			if (num5 < 0)
			{
				num5 += 4095;
			}
			vTransform.position.z += num5 >> 12;
			Vector3Int n = GameManager.instance.terrain.FUN_1BB50(vTransform.position.x, vTransform.position.z);
			n = Utilities.VectorNormal(n);
			v.y = -(v.x * n.x + v.z * n.z) / n.y;
			Vector3Int vector3Int = Utilities.FUN_2A1E0(n, v);
			vTransform.rotation.V00 = (short)(-vector3Int.x);
			vTransform.rotation.V10 = (short)(-vector3Int.y);
			vTransform.rotation.V20 = (short)(-vector3Int.z);
			vTransform.rotation.V01 = (short)(-n.x);
			vTransform.rotation.V11 = (short)(-n.y);
			vTransform.rotation.V21 = (short)(-n.z);
			vTransform.rotation.V02 = (short)v.x;
			vTransform.rotation.V12 = (short)v.y;
			vTransform.rotation.V22 = (short)v.z;
			num5 = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
			if (GameManager.instance.DAT_DB0 < num5)
			{
				if (1u < (uint)((ushort)DAT_1A - 26))
				{
					FUN_2C124(26);
					Utilities.ParentChildren(this, this);
					flags |= 65536u;
				}
				if (((GameManager.instance.DAT_28 - DAT_19) & 3) == 0)
				{
					Particle1 particle = LevelManager.instance.FUN_4DE54(vTransform.position, 146);
					short y = (short)GameManager.FUN_2AC5C();
					particle.vr.y = y;
					particle.flags &= 4294967279u;
					particle.ApplyTransformation();
				}
				vTransform.position.y = GameManager.instance.DAT_DB0;
				break;
			}
			if (DAT_1A != 25)
			{
				if (base.tags == 1 && DAT_1A == 26)
				{
					base.tags = 2;
					num6 = (int)GameManager.FUN_2AC5C();
					VigObject vigObject2 = DAT_80 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (num6 * 5 >> 15) + 1200);
					FUN_30C68();
				}
				FUN_2C124(25);
				flags &= 4294901759u;
			}
			if (1 < base.tags)
			{
				if (num3 < 0)
				{
					num3 = -num3;
				}
				if (num3 < 65536)
				{
					if (num4 < 0)
					{
						num4 = -num4;
					}
					if (num4 < 65536)
					{
						FUN_2C124(24);
						FUN_30C20();
						FUN_30BA8();
						GameManager.instance.FUN_30CB0(this, 60);
						Utilities.ParentChildren(this, this);
						base.tags = 0;
					}
				}
			}
			vTransform.position.y = num5;
			break;
		}
		case 1:
			if (arg2 == 0)
			{
				flags |= 256u;
				GameManager.instance.FUN_30CB0(this, 60);
				return 0u;
			}
			return 0u;
		case 2:
		{
			short dAT_1A = DAT_1A;
			VigObject vigObject = null;
			if (dAT_1A == 27)
			{
				flags &= 4294967263u;
				return 0u;
			}
			uint num = uint.MaxValue;
			bool flag = false;
			if ((LevelManager.instance.level.flags & 0x1000000) != 0)
			{
				switch (dAT_1A)
				{
				case 24:
					if (GameManager.instance.DAT_DB0 < vTransform.position.y)
					{
						flag = true;
					}
					break;
				default:
					flag = true;
					break;
				case 25:
					break;
				}
			}
			List<VigTuple> worldObjs = GameManager.instance.worldObjs;
			for (int i = 0; i < worldObjs.Count; i++)
			{
				VigObject vObject = worldObjs[i].vObject;
				if (vObject.type != 2 || vObject.maxHalfHealth == 0)
				{
					continue;
				}
				if (!flag)
				{
					VigTuple2 vigTuple = GameManager.instance.FUN_2FF3C((uint)vObject.vTransform.position.x, (uint)vObject.vTransform.position.z);
					if (vigTuple == null || vigTuple.id != 1)
					{
						continue;
					}
				}
				uint num2 = (uint)Utilities.FUN_29F6C(vTransform.position, vObject.screen);
				if (num2 < num)
				{
					vigObject = vObject;
					num = num2;
				}
			}
			sbyte tags = base.tags;
			if (tags != 1)
			{
				if (1 < tags)
				{
					if (tags != 2)
					{
						return 0u;
					}
					GameManager.instance.FUN_30CB0(this, 60);
					if (vigObject != null)
					{
						base.tags = 1;
						DAT_80 = vigObject;
						return 0u;
					}
					return 0u;
				}
				if (tags != 0)
				{
					return 0u;
				}
				if (vigObject != null)
				{
					base.tags = 1;
					DAT_80 = vigObject;
					FUN_30B78();
					FUN_30BF0();
				}
				GameManager.instance.FUN_30CB0(this, 60);
				return 0u;
			}
			if (vigObject != null)
			{
				DAT_80 = vigObject;
				GameManager.instance.FUN_30CB0(this, 60);
				return 0u;
			}
			base.tags = 2;
			int num3 = (int)GameManager.FUN_2AC5C();
			VigObject vigObject2 = DAT_80 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (num3 * 5 >> 15) + 1200);
			break;
		}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			if (DAT_1A != 27)
			{
				return 0u;
			}
			FUN_2C124(26);
			Utilities.ParentChildren(this, this);
			if ((flags & 0x20) != 0)
			{
				flags &= 4294967263u;
				tags = 2;
				int num = (int)GameManager.FUN_2AC5C();
				VigObject vigObject = DAT_80 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (num * 5 >> 15) + 1200);
				GameManager.instance.FUN_30CB0(this, 120);
				return 0u;
			}
		}
		return 0u;
	}
}
