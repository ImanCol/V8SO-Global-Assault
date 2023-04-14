using System.Collections.Generic;
using UnityEngine;

public class Cauldron : Destructible
{
	public VigTuple2 DAT_80_2;

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
		if (!FUN_32CF0(hit))
		{
			return 0u;
		}
		FUN_30C68();
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			VigObject child;
			switch (((byte)base.tags - 1) * 16777216 >> 24)
			{
			case 0:
			{
				VigTuple2 dAT_80_ = DAT_80_2;
				VigObject dAT_ = DAT_84;
				Vector3Int vector3Int = new Vector3Int(0, 0, 0);
				Vector3Int vout = default(Vector3Int);
				vout.x = dAT_.vTransform.position.x - vTransform.position.x;
				vout.z = dAT_.vTransform.position.z - vTransform.position.z;
				vout.y = vector3Int.y;
				int num4 = vout.x;
				if (vout.x < 0)
				{
					num4 = -vout.x;
				}
				int num5;
				int num2;
				if (20480 < num4)
				{
					num4 = dAT_80_.array[0] << 16;
					if (num4 < dAT_.vTransform.position.x)
					{
						num4 = dAT_.vTransform.position.x;
					}
					num5 = (dAT_80_.array[0] + dAT_80_.array[2]) * 65536;
					if (num4 < num5)
					{
						num5 = num4;
					}
					num4 = dAT_80_.array[1] << 16;
					num5 -= vTransform.position.x;
					if (num4 < dAT_.vTransform.position.z)
					{
						num4 = dAT_.vTransform.position.z;
					}
					num2 = (dAT_80_.array[1] + dAT_80_.array[3]) * 65536;
					if (num4 < num2)
					{
						num2 = num4;
					}
					num2 -= vTransform.position.z;
					num4 = -3051;
					if (-3052 < num5)
					{
						num4 = 3051;
						if (num5 < 3052)
						{
							num4 = num5;
						}
					}
					vTransform.position.x += num4;
					num4 = -3051;
					if (-3052 < num2)
					{
						num4 = 3051;
						if (num2 < 3052)
						{
							num4 = num2;
						}
					}
					vTransform.position.z += num4;
					vector3Int.x = vout.x;
					vector3Int.z = vout.z;
					Utilities.FUN_2A098(vout, out vout);
					num4 = vout.z * vTransform.rotation.V02 - vout.x * vTransform.rotation.V22;
					if (num4 < 0)
					{
						num4 += 4095;
					}
					num4 >>= 12;
					num2 = num4;
					if (num4 < 0)
					{
						num2 = -num4;
					}
					if (20 < num2)
					{
						num2 = -num4;
						if (0 < num4)
						{
							num2 += 15;
						}
						FUN_24700(0, (short)(num2 >> 4), 0);
					}
					if (((GameManager.instance.DAT_28 - DAT_19) & 0xF) == 0)
					{
						vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
						return 0u;
					}
					return 0u;
				}
				num4 = vout.z;
				if (vout.z < 0)
				{
					num4 = -vout.z;
				}
				if (20480 >= num4)
				{
					break;
				}
				num4 = dAT_80_.array[0] << 16;
				if (num4 < dAT_.vTransform.position.x)
				{
					num4 = dAT_.vTransform.position.x;
				}
				num5 = (dAT_80_.array[0] + dAT_80_.array[2]) * 65536;
				if (num4 < num5)
				{
					num5 = num4;
				}
				num4 = dAT_80_.array[1] << 16;
				num5 -= vTransform.position.x;
				if (num4 < dAT_.vTransform.position.z)
				{
					num4 = dAT_.vTransform.position.z;
				}
				num2 = (dAT_80_.array[1] + dAT_80_.array[3]) * 65536;
				if (num4 < num2)
				{
					num2 = num4;
				}
				num2 -= vTransform.position.z;
				num4 = -3051;
				if (-3052 < num5)
				{
					num4 = 3051;
					if (num5 < 3052)
					{
						num4 = num5;
					}
				}
				vTransform.position.x += num4;
				num4 = -3051;
				if (-3052 < num2)
				{
					num4 = 3051;
					if (num2 < 3052)
					{
						num4 = num2;
					}
				}
				vTransform.position.z += num4;
				vector3Int.x = vout.x;
				vector3Int.z = vout.z;
				Utilities.FUN_2A098(vout, out vout);
				num4 = vout.z * vTransform.rotation.V02 - vout.x * vTransform.rotation.V22;
				if (num4 < 0)
				{
					num4 += 4095;
				}
				num4 >>= 12;
				num2 = num4;
				if (num4 < 0)
				{
					num2 = -num4;
				}
				if (20 < num2)
				{
					num2 = -num4;
					if (0 < num4)
					{
						num2 += 15;
					}
					FUN_24700(0, (short)(num2 >> 4), 0);
				}
				if (((GameManager.instance.DAT_28 - DAT_19) & 0xF) == 0)
				{
					vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
					return 0u;
				}
				return 0u;
			}
			case 1:
			{
				child = child2;
				short num3 = (short)(child.vr.x - 17);
				child.vr.x = num3;
				if (num3 < -511)
				{
					base.tags++;
				}
				goto IL_0690;
			}
			case 2:
			{
				Furnace3 furnace = FUN_2458();
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 67, furnace.vTransform.position);
				if (furnace != null)
				{
					GameManager.instance.FUN_30CB0(furnace, 60);
				}
				FUN_30BA8();
				GameManager.instance.FUN_30CB0(this, 120);
				break;
			}
			default:
				return 0u;
			case 4:
				{
					child = child2;
					short num = (short)(child.vr.x + 17);
					child.vr.x = num;
					if (0 < num << 16)
					{
						base.tags = 0;
						int num2 = (int)GameManager.FUN_2AC5C();
						GameManager.instance.FUN_30CB0(this, (num2 * 120 >> 15) + 180);
						FUN_30BA8();
					}
					goto IL_0690;
				}
				IL_0690:
				child.ApplyTransformation();
				return 0u;
			}
			goto IL_0699;
		}
		case 1:
			flags |= 256u;
			if ((DAT_80_2 = GameManager.instance.FUN_2FFD0(1)) != null)
			{
				int num4 = (int)GameManager.FUN_2AC5C();
				GameManager.instance.FUN_30CB0(this, num4 * 60 >> 15);
			}
			vTransform.position.y = 2816000;
			break;
		case 2:
		{
			sbyte tags = base.tags;
			if (tags == 1)
			{
				VigTuple2 dAT_80_2 = DAT_80_2;
				VigObject dAT_ = DAT_84;
				if (dAT_.maxHalfHealth == 0 || dAT_.vTransform.position.x <= dAT_80_2.array[0] << 16 || (dAT_80_2.array[0] + dAT_80_2.array[2]) * 65536 <= dAT_.vTransform.position.x || dAT_.vTransform.position.z <= dAT_80_2.array[1] << 16 || (dAT_80_2.array[1] + dAT_80_2.array[3]) * 65536 <= dAT_.vTransform.position.z)
				{
					FUN_30BA8();
					tags = (base.tags = 5);
				}
				int num4 = (int)GameManager.FUN_2AC5C();
				GameManager.instance.FUN_30CB0(this, num4 * 60 >> 15);
				return 0u;
			}
			if (tags < 2)
			{
				if (tags != 0)
				{
					return 0u;
				}
				VigObject vigObject = null;
				uint num6 = uint.MaxValue;
				VigTuple2 dAT_80_2 = DAT_80_2;
				List<VigTuple> worldObjs = GameManager.instance.worldObjs;
				for (int i = 0; i < worldObjs.Count; i++)
				{
					VigObject dAT_ = worldObjs[i].vObject;
					if (dAT_.type == 2 && dAT_.maxHalfHealth != 0 && dAT_80_2.array[0] << 16 < dAT_.vTransform.position.x && dAT_.vTransform.position.x < (dAT_80_2.array[0] + dAT_80_2.array[2]) * 65536 && dAT_80_2.array[1] << 16 < dAT_.vTransform.position.z && dAT_.vTransform.position.z < (dAT_80_2.array[1] + dAT_80_2.array[3]) * 65536)
					{
						uint num7 = (uint)Utilities.FUN_29F6C(vTransform.position, dAT_.screen);
						if (num7 < num6)
						{
							vigObject = dAT_;
							num6 = num7;
						}
					}
				}
				int num4;
				if (vigObject != null)
				{
					DAT_84 = vigObject;
					FUN_30B78();
					tags = ++base.tags;
					num4 = (int)GameManager.FUN_2AC5C();
					GameManager.instance.FUN_30CB0(this, num4 * 60 >> 15);
					return 0u;
				}
				num4 = (int)GameManager.FUN_2AC5C();
				GameManager.instance.FUN_30CB0(this, num4 * 60 >> 15);
				return 0u;
			}
			if (tags != 4)
			{
				if (tags == 5)
				{
					int num4 = (int)GameManager.FUN_2AC5C();
					GameManager.instance.FUN_30CB0(this, num4 * 60 >> 15);
					base.tags = 0;
					return 0u;
				}
				return 0u;
			}
			FUN_30B78();
			goto IL_0699;
		}
		case 8:
			{
				if (!FUN_32B90((uint)arg2))
				{
					return 0u;
				}
				FUN_30C68();
				break;
			}
			IL_0699:
			base.tags++;
			break;
		}
		return 0u;
	}

	private Furnace3 FUN_2458()
	{
		Furnace3 furnace = new GameObject().AddComponent<Furnace3>();
		ConfigContainer param = child2.FUN_2C5F4(32768);
		VigTransform vigTransform = GameManager.instance.FUN_2CEAC(child2, param);
		furnace.vTransform = vTransform;
		furnace.vTransform.position = vigTransform.position;
		furnace.type = 8;
		furnace.maxHalfHealth = 5;
		furnace.vCollider = new VigCollider(Furnace.DAT_144);
		furnace.flags |= 388u;
		XOBF_DB dAT_ = LevelManager.instance.xobfList[19];
		furnace.physics2.M3 = 21;
		furnace.physics1.M1 = 4;
		furnace.DAT_98 = dAT_;
		int num = GameManager.instance.terrain.FUN_1B750((uint)furnace.vTransform.position.x, (uint)furnace.vTransform.position.z);
		furnace.screen.y = num - furnace.vTransform.position.y;
		Vector3Int vector3Int = Utilities.FUN_24094(v: new Vector3Int(0, 0, 256), rot: furnace.vTransform.rotation);
		furnace.physics1.Y = vector3Int.x;
		furnace.physics1.Z = vector3Int.y;
		furnace.physics1.W = vector3Int.z;
		furnace.FUN_305FC();
		furnace.DAT_58 = 262144;
		return furnace;
	}
}
