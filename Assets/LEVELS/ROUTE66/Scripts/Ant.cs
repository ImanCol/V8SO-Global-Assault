using System.Collections.Generic;
using UnityEngine;

public class Ant : VigObject
{
	private static int DAT_E0;

	private static int DAT_E8;

	private static int DAT_EC = 0;

	private static int DAT_E4 = 4096;

	public VigObject DAT_8C;

	public VigObject DAT_90;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2, uint arg3)
	{
		return arg1.ini.FUN_2C17C_2((ushort)arg2, typeof(Ant), arg3);
	}

	public override uint OnCollision(HitDetection hit)
	{
		VigObject self = hit.self;
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			Utilities.FUN_2A168(out Vector3Int vout, vTransform.position, vehicle.vTransform.position);
			Vector3Int v = default(Vector3Int);
			v.y = -917504;
			int num = vout.x * 5120;
			v.x = vout.x << 5;
			v.z = vout.z << 5;
			if (num < 0)
			{
				num += 4095;
			}
			Vector3Int v2 = default(Vector3Int);
			v2.x = vehicle.vTransform.position.x + (num >> 12);
			v2.y = vehicle.vTransform.position.y;
			num = vout.y * 5120;
			if (num < 0)
			{
				num += 4095;
			}
			v2.z = vehicle.vTransform.position.z + (num >> 12);
			vehicle.FUN_2B370(v, v2);
			if (tags != 0)
			{
				tags = 0;
			}
			flags |= 32u;
			return 0u;
		}
		if (self.type != 8)
		{
			return 0u;
		}
		return UpdateW(8, self.maxHalfHealth);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int num4;
			if (physics1.X < 65536)
			{
				num4 = physics1.X + physics1.Y;
				VigObject vigObject2 = child2;
				physics1.X = num4;
				if (num4 < 0)
				{
					num4 += 15;
				}
				short num3 = (short)(num4 >> 4);
				vigObject2.vTransform.rotation.V22 = num3;
				vigObject2.vTransform.rotation.V11 = num3;
				vigObject2.vTransform.rotation.V00 = num3;
			}
			if (arg2 != 0)
			{
				uint volume = GameManager.instance.FUN_1E7A8(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
			}
			sbyte tags = base.tags;
			int num2;
			if (tags == 1)
			{
				if (DAT_90.maxHalfHealth == 0)
				{
					base.tags = 0;
				}
				num4 = DAT_90.vTransform.position.x - vTransform.position.x;
				num2 = DAT_90.vTransform.position.z - vTransform.position.z;
				FUN_1CC8(num4, num2);
				FUN_1F60(DAT_90.vTransform.position);
				if (num4 < 0)
				{
					num4 = -num4;
				}
				if (num4 < 819200)
				{
					if (num2 < 0)
					{
						num2 = -num2;
					}
					if (num2 < 819200)
					{
						base.tags = 2;
						GameManager.instance.FUN_30CB0(this, 0);
						return 0u;
					}
				}
				if (num4 < 294912001)
				{
					num4 = physics2.Y - vTransform.position.x;
					num2 = physics2.W - vTransform.position.z;
					if (num4 < 0)
					{
						num4 = -num4;
					}
					if (2293759 < num4)
					{
						return 0u;
					}
					if (num2 < 0)
					{
						num2 = -num2;
					}
					if (2293759 < num2)
					{
						return 0u;
					}
				}
				base.tags = 0;
				return 0u;
			}
			if (1 < tags)
			{
				if (4 < tags)
				{
					return 0u;
				}
				FUN_1CC8(DAT_90.vTransform.position.x - vTransform.position.x, DAT_90.vTransform.position.z - vTransform.position.z);
				FUN_1F60(DAT_90.vTransform.position);
			}
			if (tags != 0)
			{
				return 0u;
			}
			num4 = physics2.Y - vTransform.position.x;
			num2 = physics2.W - vTransform.position.z;
			FUN_1CC8(num4, num2);
			FUN_1F60(new Vector3Int(physics2.Y, physics2.Z, physics2.W));
			if (num4 < 0)
			{
				num4 = -num4;
			}
			if (491519 < num4)
			{
				return 0u;
			}
			if (num2 < 0)
			{
				num2 = -num2;
			}
			if (491519 < num2)
			{
				return 0u;
			}
			VigObject vigObject3 = null;
			uint num5 = 2147418112u;
			if (GameManager.instance.worldObjs != null)
			{
				List<VigTuple> worldObjs = GameManager.instance.worldObjs;
				for (int i = 0; i < worldObjs.Count; i++)
				{
					VigTuple vigTuple = worldObjs[i];
					VigObject vObject = vigTuple.vObject;
					if (vObject.type == 2 && vObject.maxHalfHealth != 0)
					{
						Vector3Int v = default(Vector3Int);
						v.x = vObject.screen.x - screen.x;
						v.y = vObject.screen.y - screen.y;
						v.z = vObject.screen.z - screen.z;
						Vector2Int vector2Int = Utilities.FUN_2A1C0(v);
						uint num6 = (uint)((int)((uint)vector2Int.x >> 16) | (vector2Int.y << 16));
						if ((int)num6 < (int)num5)
						{
							vigObject3 = vigTuple.vObject;
							num5 = num6;
						}
					}
				}
			}
			DAT_90 = vigObject3;
			if (vigObject3 == null)
			{
				return 0u;
			}
			break;
		}
		case 1:
		{
			FUN_2D1DC();
			GameObject gameObject = new GameObject();
			VigMesh param2 = LevelManager.instance.xobfList[18].FUN_2CB74(gameObject, 93u, init: true);
			int num2 = DAT_58;
			int num4 = num2;
			if (num2 < 0)
			{
				num4 = num2 + 7;
			}
			if (num2 < 0)
			{
				num2 += 3;
			}
			VigShadow vigShadow = vShadow = Utilities.FUN_4C44C(param2, num4 >> 3, num2 >> 2, gameObject);
			base.maxHalfHealth = 300;
			physics1.Z = 50;
			flags |= 8u;
			return 0u;
		}
		case 2:
		{
			sbyte tags = base.tags;
			if (tags < 2)
			{
				return 0u;
			}
			if (tags < 4)
			{
				if ((flags & 0x1000000) == 0)
				{
					FUN_1A60();
				}
				base.tags++;
				int num4 = (int)GameManager.FUN_2AC5C();
				num4 = num4 * 36 >> 15;
				num4 = ((base.tags != 4) ? (num4 + 42) : (num4 + 240));
				GameManager.instance.FUN_30CB0(this, num4);
				return 0u;
			}
			if (tags != 4)
			{
				return 0u;
			}
			break;
		}
		case 8:
		{
			VigObject vigObject = Utilities.FUN_2CDB0(this);
			if (vigObject == null)
			{
				vigObject = this;
			}
			ushort maxHalfHealth = vigObject.maxHalfHealth;
			int num = maxHalfHealth;
			if (arg2 < maxHalfHealth)
			{
				num = arg2;
			}
			vigObject.maxHalfHealth = (ushort)(maxHalfHealth - num);
			int num2 = vigObject.physics1.Z - num;
			vigObject.physics1.Z = num2;
			if (0 < num2)
			{
				return 0u;
			}
			if ((vigObject.flags & 0x1000000) != 0)
			{
				return 0u;
			}
			vigObject.physics1.Z = 50;
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, vigObject.vData.sndList, 3, vigObject.vTransform.position);
			vigObject.FUN_2C124_2(17);
			Utilities.ParentChildren(vigObject, vigObject);
			vigObject.flags |= 16777216u;
			VigObject vigObject2 = vigObject.child2.child2.child2;
			while (vigObject2 != null && vigObject2.id != 1)
			{
				vigObject2 = vigObject2.child;
			}
			((Ant)vigObject).DAT_8C = vigObject2;
			((Body)vigObject2.child2).state = _BODY_TYPE.Ant;
			num2 = vigObject.physics1.X;
			if (num2 < 65536)
			{
				vigObject = vigObject.child2;
				if (num2 < 0)
				{
					num2 += 15;
				}
				short num3 = (short)(num2 >> 4);
				vigObject.vTransform.rotation.V22 = num3;
				vigObject.vTransform.rotation.V11 = num3;
				vigObject.vTransform.rotation.V00 = num3;
				return 0u;
			}
			return 0u;
		}
		default:
			return 0u;
		case 9:
			if (arg2 != 0)
			{
				GameManager.instance.FUN_309A0(this);
				if (DAT_18 != 0)
				{
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
				}
				FUN_134C();
				return 0u;
			}
			return 0u;
		}
		base.tags = 1;
		return 0u;
	}

	public static Ant2 FUN_134C()
	{
		Vector3Int n = new Vector3Int(DAT_E0, DAT_E4, DAT_E8);
		int dAT_EC = DAT_EC;
		Ant2 ant = LevelManager.instance.xobfList[42].ini.FUN_2C17C(12, typeof(Ant2), 0u) as Ant2;
		if (ant == null)
		{
			return null;
		}
		VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 49);
		if (vigObject == null)
		{
			return null;
		}
		ant.screen = vigObject.screen;
		ant.id = 1000;
		ant.maxHalfHealth = 100;
		ant.DAT_19 = 1;
		ant.state = _ANT2_TYPE.Ant2;
		ant.flags |= 256u;
		n = Utilities.VectorNormal(n);
		ant.vTransform.position.x = ant.screen.x + n.x * -1750;
		ant.vTransform.position.y = ant.screen.y + n.y * -1750;
		ant.vTransform.position.z = ant.screen.z + n.z * -1750;
		int num = n.x * 30517;
		if (num < 0)
		{
			num += 4095;
		}
		ant.physics1.X = num >> 12 << 7;
		num = n.y * 30517;
		if (num < 0)
		{
			num += 4095;
		}
		ant.physics1.Y = num >> 12 << 7;
		num = n.z * 30517;
		if (num < 0)
		{
			num += 4095;
		}
		ant.physics1.Z = num >> 12 << 7;
		ant.physics2.Z = 32640;
		ant.FUN_2D1DC();
		ant.ApplyRotationMatrix();
		ant.FUN_305FC();
		GameManager.instance.FUN_30CB0(ant, 360);
		return ant;
	}

	private Laser FUN_1A60()
	{
		VigObject child = DAT_8C.child2;
		ConfigContainer configContainer = child.FUN_2C5F4(32768);
		Laser laser = vData.ini.FUN_2C17C(18, typeof(Laser), 8u) as Laser;
		Ballistic ballistic = vData.ini.FUN_2C17C(19, typeof(Ballistic), 8u) as Ballistic;
		short id = base.id;
		laser.type = 8;
		laser.id = id;
		laser.vTransform = GameManager.instance.FUN_2CEAC(child, configContainer);
		laser.screen = laser.vTransform.position;
		VigObject dAT_ = DAT_90;
		Vector3Int vin = default(Vector3Int);
		vin.x = dAT_.screen.x - laser.screen.x;
		vin.y = dAT_.screen.y - laser.screen.y;
		vin.z = dAT_.screen.z - laser.screen.z;
		Utilities.FUN_29FC8(vin, out Vector3Int vout);
		int num = -vout.x;
		if (0 < vout.x)
		{
			num += 3;
		}
		int num2 = laser.vTransform.rotation.V02;
		if (num2 < 0)
		{
			num2 += 3;
		}
		vout.x = vout.x + (num >> 2) + (num2 >> 2);
		num = -vout.y;
		if (0 < vout.y)
		{
			num += 3;
		}
		num2 = laser.vTransform.rotation.V12;
		if (num2 < 0)
		{
			num2 += 3;
		}
		vout.y = vout.y + (num >> 2) + (num2 >> 2);
		num = -vout.z;
		if (0 < vout.z)
		{
			num += 3;
		}
		num2 = laser.vTransform.rotation.V22;
		if (num2 < 0)
		{
			num2 += 3;
		}
		vout.z = vout.z + (num >> 2) + (num2 >> 2);
		vout = Utilities.VectorNormal(vout);
		laser.vTransform.rotation = Utilities.FUN_2A724(vout);
		Utilities.FUN_2CA94(child, configContainer, ballistic);
		Utilities.ParentChildren(child, child);
		laser.flags = 132u;
		laser.maxHalfHealth = 100;
		laser.physics2.M3 = 2;
		laser.physics2.M2 = 8;
		laser.FUN_305FC();
		ballistic.flags = 16u;
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E5D4(param, vData.sndList, 1, vTransform.position);
		return laser;
	}

	private int FUN_1CC8(int param1, int param2)
	{
		int num = 5340;
		if (tags < 2)
		{
			num = 6103;
		}
		int result = -1;
		if ((flags & 0x1000000) == 0)
		{
			int num2 = Utilities.Ratan2(param1, param2);
			int num3 = (num2 - (ushort)vr.y) * 1048576 >> 20;
			num2 = num3;
			if (num3 < 0)
			{
				num2 = -num3;
			}
			if (2 < num2)
			{
				num2 = -22;
				if (-23 < num3)
				{
					num2 = 22;
					if (num3 < 23)
					{
						num2 = num3;
					}
				}
				num3 = num2;
				if (num2 < 0)
				{
					num3 = -num2;
				}
				vr.y += num2;
				num -= num3 * 3051 / 22;
			}
			Vector3Int v = default(Vector3Int);
			v.x = GameManager.DAT_65C90[(vr.y & 0xFFF) * 2];
			num2 = v.x * num;
			v.z = GameManager.DAT_65C90[(vr.y & 0xFFF) * 2 + 1];
			if (num2 < 0)
			{
				num2 += 4095;
			}
			vTransform.position.x += num2 >> 12;
			num = v.z * num;
			if (num < 0)
			{
				num += 4095;
			}
			num = vTransform.position.z + (num >> 12);
			vTransform.position.z = num;
			Vector3Int n = GameManager.instance.terrain.FUN_1BB50(vTransform.position.x, num);
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
			result = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
			vTransform.position.y = result;
			result = 0;
		}
		return result;
	}

	private void FUN_1F60(Vector3Int param1)
	{
		VigObject dAT_8C = DAT_8C;
		VigTransform vigTransform = GameManager.instance.FUN_2CDF4(dAT_8C);
		Vector3Int vector3Int = default(Vector3Int);
		vector3Int.x = param1.x - vigTransform.position.x;
		vector3Int.y = param1.y - vigTransform.position.y;
		vector3Int.z = param1.z - vigTransform.position.z;
		vector3Int = Utilities.FUN_2426C(vigTransform.rotation, new Matrix2x4(vector3Int.x, vector3Int.y, vector3Int.z, 0));
		short num = (short)Utilities.Ratan2(vector3Int.x, vector3Int.z);
		uint num2 = (uint)((long)vector3Int.z * (long)vector3Int.z);
		int num3 = (int)((ulong)((long)vector3Int.z * (long)vector3Int.z) >> 32);
		uint num4 = (uint)((int)((long)vector3Int.x * (long)vector3Int.x) + (int)num2);
		int num5 = Utilities.Ratan2(x: Utilities.FUN_2ABC4(num4, (int)((ulong)((long)vector3Int.x * (long)vector3Int.x) >> 32) + num3 + ((num4 < num2) ? 1 : 0)), y: vector3Int.y);
		int num6 = num5 << 20 >> 20;
		num5 = -128;
		if (-129 < num6)
		{
			num5 = 256;
			if (num6 < 257)
			{
				num5 = num6;
			}
		}
		int num7 = num - dAT_8C.vr.y;
		num6 = num7;
		if (num7 < 0)
		{
			num6 = -num7;
		}
		if (11 < num6)
		{
			if (num7 < 0)
			{
				num7 += 3;
			}
			dAT_8C.vr.y += num7 >> 2;
		}
		num5 -= dAT_8C.vr.x;
		num6 = num5;
		if (num5 < 0)
		{
			num6 = -num5;
		}
		if (11 < num6)
		{
			if (num5 < 0)
			{
				num5 += 3;
			}
			dAT_8C.vr.x += num5 >> 2;
		}
		dAT_8C.ApplyTransformation();
	}
}
