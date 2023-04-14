using UnityEngine;

public class StarPower2 : VigObject
{
	public VigObject DAT_94;

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
		if ((GameManager.FUN_2AC5C() & 0x1F) != 0)
		{
			return 0u;
		}
		HitDetection hitDetection = new HitDetection(null);
		GameManager.instance.FUN_2FB70(this, hit, hitDetection);
		Vector3Int param = Utilities.FUN_24148(self.vTransform, hitDetection.position);
		UIManager.instance.FUN_4E414(param, new Color32(128, 0, 0, 8));
		LevelManager.instance.FUN_4DE54(param, 143);
		if (self.type != 2)
		{
			return 0u;
		}
		if (-1 < self.id)
		{
			return 0u;
		}
		GameManager.instance.FUN_15ADC(~self.id, 32);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int z;
			int num2;
			int num;
			if (base.tags == 0)
			{
				Vector3Int vector3Int = GameManager.instance.FUN_2CE50(DAT_94);
				z = physics1.Z;
				num = z;
				if (z < 0)
				{
					num = z + 63;
				}
				num2 = vector3Int.x - vTransform.position.x;
				if (num2 < 0)
				{
					num2 += 255;
				}
				z = z - (num >> 6) + (num2 >> 8);
				num = -9155;
				if (-9156 < z)
				{
					num = 9155;
					if (z < 9156)
					{
						num = z;
					}
				}
				z = physics1.W;
				physics1.Z = num;
				num = z;
				if (z < 0)
				{
					num = z + 63;
				}
				num2 = vector3Int.y - vTransform.position.y;
				if (num2 < 0)
				{
					num2 += 255;
				}
				z = z - (num >> 6) + (num2 >> 8);
				num = -9155;
				if (-9156 < z)
				{
					num = 9155;
					if (z < 9156)
					{
						num = z;
					}
				}
				z = physics2.X;
				physics1.W = num;
				num = z;
				if (z < 0)
				{
					num = z + 63;
				}
				num2 = vector3Int.z - vTransform.position.z;
				if (num2 < 0)
				{
					num2 += 255;
				}
				z = z - (num >> 6) + (num2 >> 8);
				num = -9155;
				if (-9156 < z)
				{
					num = 9155;
					if (z < 9156)
					{
						num = z;
					}
				}
				physics2.X = num;
				vTransform.position.x += physics1.Z;
				vTransform.position.y += physics1.W;
				vTransform.position.z += physics2.X;
				vr.x += 22;
				vr.y += 34;
				if (arg2 != 0)
				{
					ApplyRotationMatrix();
					return 0u;
				}
				break;
			}
			num = DAT_84.screen.x - vTransform.position.x;
			z = DAT_84.screen.z - vTransform.position.z;
			num2 = num;
			if (num < 0)
			{
				num2 = num + 7;
			}
			num2 >>= 3;
			int z2 = -9155;
			if (-9156 < num2)
			{
				z2 = 9155;
				if (num2 < 9156)
				{
					z2 = num2;
				}
			}
			physics1.Z = z2;
			num2 = z;
			if (z < 0)
			{
				num2 = z + 7;
			}
			num2 >>= 3;
			z2 = -9155;
			if (-9156 < num2)
			{
				z2 = 9155;
				if (num2 < 9156)
				{
					z2 = num2;
				}
			}
			physics2.X = z2;
			vTransform.position.x += physics1.Z;
			vTransform.position.z += physics2.X;
			num2 = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
			z2 = num2 - (vTransform.position.y + 196608);
			if (z2 < 0)
			{
				z2 += 15;
			}
			vTransform.position.y += z2 >> 4;
			if (arg2 != 0)
			{
				ApplyRotationMatrix();
			}
			sbyte tags = base.tags;
			if (tags == 2)
			{
				if (arg2 != 0)
				{
					VigObject pDAT_2 = PDAT_74;
					pDAT_2.vTransform.position.x = vTransform.position.x;
					pDAT_2.vTransform.position.y = num2;
					pDAT_2.vTransform.position.z = vTransform.position.z;
					Vector3Int vector3Int2 = GameManager.instance.terrain.FUN_1BB50(vTransform.position.x, vTransform.position.z);
					pDAT_2.vTransform.rotation.V22 = 4096;
					pDAT_2.vTransform.rotation.V00 = 4096;
					pDAT_2.vTransform.rotation.V21 = 0;
					pDAT_2.vTransform.rotation.V20 = 0;
					pDAT_2.vTransform.rotation.V11 = 0;
					pDAT_2.vTransform.rotation.V02 = 0;
					pDAT_2.vTransform.rotation.V01 = 0;
					pDAT_2.vTransform.rotation.V10 = (short)(vector3Int2.x * -4096 / vector3Int2.y);
					pDAT_2.vTransform.rotation.V12 = (short)(vector3Int2.z * -4096 / vector3Int2.y);
				}
				tags = (sbyte)(DAT_19 - 1);
				DAT_19 = (byte)tags;
				if (tags != 0)
				{
					if (num < 0)
					{
						num = -num;
					}
					if (65535 < num)
					{
						return 0u;
					}
					if (z < 0)
					{
						z = -z;
					}
					if (65535 < z)
					{
						return 0u;
					}
				}
				GameManager.instance.FUN_1E14C(DAT_18, vData.sndList, 4);
				GameManager.instance.FUN_309A0(PDAT_74);
				VigObject param = child2.FUN_2CCBC();
				GameManager.instance.FUN_307CC(param);
				ConfigContainer cont = FUN_2C5F4(32768);
				VigObject obj = vData.ini.FUN_2C17C(4, typeof(VigObject), 8u);
				Utilities.FUN_2CB04(this, cont, obj);
				Utilities.ParentChildren(this, this);
				base.tags = 3;
				GameManager.instance.FUN_30CB0(this, 12);
				return 0u;
			}
			VigObject pDAT_;
			if (tags < 3)
			{
				if (tags != 1)
				{
					return 0u;
				}
				z = vr.x;
				num = z;
				if (z < 0)
				{
					num = z + 15;
				}
				int num3 = (num >> 4 != 0) ? (z - (num >> 4)) : ((z >= 0) ? (z - 1) : (z + 1));
				vr.x = num3;
				if ((num3 & 0xFFFF) != 0)
				{
					return 0u;
				}
				VigObject param = vData.ini.FUN_2C17C(3, typeof(VigObject), 8u);
				pDAT_ = vData.ini.FUN_2C17C(2, typeof(VigObject), 8u);
				Utilities.ParentChildren(pDAT_, pDAT_);
				ConfigContainer cont2 = FUN_2C5F4(32768);
				Utilities.FUN_2CB04(this, cont2, param);
				Utilities.ParentChildren(this, this);
				base.tags = 2;
				DAT_19 = 95;
				PDAT_74 = pDAT_;
				pDAT_.flags = 4u;
				pDAT_.FUN_305FC();
				return 0u;
			}
			if (tags >= 6)
			{
				break;
			}
			if (tags < 4)
			{
				return 0u;
			}
			pDAT_ = child2;
			if (vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < num2)
			{
				if (base.tags == 5)
				{
					base.tags = 4;
					GameManager.instance.FUN_309A0(pDAT_.PDAT_74);
					pDAT_.PDAT_74 = null;
				}
				tags = (sbyte)(DAT_19 - 1);
				DAT_19 = (byte)tags;
				if (tags != -1)
				{
					return 0u;
				}
				Vector3Int vector3Int3 = default(Vector3Int);
				vector3Int3.x = vTransform.position.x;
				vector3Int3.y = GameManager.instance.DAT_DB0;
				vector3Int3.z = vTransform.position.z;
				LevelManager.instance.FUN_4DE54(vector3Int3, 138);
				int param2 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 70, vector3Int3);
			}
			else
			{
				VigObject vigObject;
				if (base.tags == 4)
				{
					vigObject = vData.ini.FUN_2C17C(5, typeof(VigObject), 8u);
					Utilities.ParentChildren(vigObject, vigObject);
					vigObject.flags = 36u;
					vigObject.FUN_305FC();
					pDAT_.PDAT_74 = vigObject;
					base.tags = 5;
				}
				else
				{
					vigObject = pDAT_.PDAT_74;
				}
				Vector3Int vector3Int2 = GameManager.instance.terrain.FUN_1B998((uint)vTransform.position.x, (uint)vTransform.position.z);
				vector3Int2 = Utilities.VectorNormal(vector3Int2);
				vigObject.vTransform.rotation = Utilities.FUN_2A5EC(vector3Int2);
				vigObject.vTransform.position.x = vTransform.position.x;
				vigObject.vTransform.position.y = num2;
				vigObject.vTransform.position.z = vTransform.position.z;
				num = vTransform.position.x;
				if (num < 0)
				{
					num += 65535;
				}
				num2 = vTransform.position.z;
				if (num2 < 0)
				{
					num2 += 65535;
				}
				VigTerrain terrain = GameManager.instance.terrain;
				terrain.vertices[terrain.chunks[(((uint)(num2 >> 16) >> 6) * 4 + ((uint)(num >> 16) >> 6) * 128) / 4u] * 4096 + (((num >> 16) & 0x3F) * 128 + ((num2 >> 16) & 0x3F) * 2) / 2] &= 2047;
				tags = (sbyte)(DAT_19 - 1);
				DAT_19 = (byte)tags;
				if (tags != -1)
				{
					return 0u;
				}
				flags |= 536870912u;
				if ((GameManager.FUN_2AC5C() & 1) != 0)
				{
					StarPower3 obj2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C(152, typeof(StarPower3), 8u) as StarPower3;
					GameManager.FUN_2AC5C();
					uint num4 = GameManager.FUN_2AC5C();
					num = (int)((((num4 & 0xFF) - 128) & 0xFFF) * 2);
					z2 = (int)((((num4 & 0xFF) - 128) & 0xFFF) * 2);
					num2 = GameManager.DAT_65C90[num] * GameManager.DAT_65C90[z2 + 1];
					if (num2 < 0)
					{
						num2 += 4095;
					}
					num = -GameManager.DAT_65C90[num + 1] * GameManager.DAT_65C90[z2 + 1];
					if (num < 0)
					{
						num += 4095;
					}
					Vector3Int vector3Int3 = Utilities.ApplyMatrixSV(v3: new Vector3Int
					{
						x = num2 >> 12,
						y = num >> 12,
						z = -GameManager.DAT_65C90[z2]
					}, m33: vigObject.vTransform.rotation);
					obj2.vTransform.rotation = Utilities.FUN_2A724(vector3Int3);
					obj2.vTransform.position = vigObject.vTransform.position;
					obj2.flags = 164u;
					obj2.FUN_305FC();
				}
			}
			num = (int)GameManager.FUN_2AC5C();
			DAT_19 = (byte)((num * 5 >> 15) + 5);
			break;
		}
		case 2:
			base.tags = 4;
			flags = (uint)(((int)flags & -33) | 0x800);
			FUN_2D1DC();
			return 0u;
		case 4:
			if (base.tags == 2)
			{
				VigObject pDAT_ = PDAT_74;
				GameManager.instance.FUN_309A0(pDAT_);
			}
			else if (base.tags == 5 && child2 != null)
			{
				VigObject pDAT_ = child2.PDAT_74;
				if (pDAT_ != null)
				{
					GameManager.instance.FUN_309A0(pDAT_);
				}
			}
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			if (tags < 3)
			{
				return 0u;
			}
			VigObject child = child2;
			if (tags == 5)
			{
				GameManager.instance.FUN_309A0(child.PDAT_74);
				child.PDAT_74 = null;
			}
			GameManager.instance.FUN_1DE78(DAT_18);
			DAT_18 = 0;
			GameManager.instance.DAT_1084--;
			if (DAT_94.maxHalfHealth == 0)
			{
				DAT_94.FUN_3A368();
			}
			else
			{
				VigObject param = child.FUN_2CCBC();
				GameManager.instance.FUN_307CC(param);
				tags = 0;
				flags |= 32u;
			}
			return 4294967294u;
		}
		return 0u;
	}
}
