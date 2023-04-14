using System.Collections.Generic;
using UnityEngine;

public class TestThruster2 : VigObject
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
		VigObject @object = hit.object1;
		VigObject self = hit.self;
		if (@object == this)
		{
			if (self.type == 2)
			{
				Vehicle obj = (Vehicle)self;
				Vector3Int v = default(Vector3Int);
				Vector3Int vector3Int = new Vector3Int
				{
					y = -16768
				};
				v.x = physics1.Y << 7;
				v.z = physics1.W << 7;
				v.y = -16768;
				vector3Int.x = v.x;
				vector3Int.z = v.z;
				HitDetection hitDetection = new HitDetection(null);
				GameManager.instance.FUN_2FB70(this, hit, hitDetection);
				Vector3Int vector3Int2 = Utilities.FUN_24148(v: new Vector3Int
				{
					x = hitDetection.position.x / 2,
					y = hitDetection.position.y / 2,
					z = hitDetection.position.z / 2
				}, transform: obj.vTransform);
				obj.FUN_2B370(v, vector3Int2);
				obj.FUN_3A064(-1, vTransform.position, param3: true);
				LevelManager.instance.FUN_4DE54(vector3Int2, 142);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 24, vector3Int2);
				physics1.Y /= 2;
				physics1.Z /= 2;
				physics1.W /= 2;
				VigObject vigObject = DAT_80 = FUN_6EC();
			}
			else
			{
				if (self.type == 3)
				{
					return 0u;
				}
				GameManager.instance.FUN_2F798(this, hit);
				int num = physics1.Y * hit.normal1.x + physics1.Z * hit.normal1.y + physics1.W * hit.normal1.z;
				if (num < 0)
				{
					num += 4095;
				}
				num >>= 12;
				if (-1 < num)
				{
					return 0u;
				}
				int num2 = num * hit.normal1.x;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				physics1.X += -(num2 >> 12);
				num2 = num * hit.normal1.y;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				physics1.Y += -(num2 >> 12);
				num *= hit.normal1.z;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.Z += -(num >> 12);
			}
		}
		else if (@object.GetType().IsSubclassOf(typeof(VigObject)))
		{
			return @object.OnCollision(hit);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			if (tags == 0)
			{
				FUN_30B78();
				GameManager.instance.FUN_30CB0(this, 720);
				VigObject vigObject = DAT_80 = FUN_6EC();
				screen = vTransform.position;
				tags = 1;
			}
			else
			{
				if (tags != 1)
				{
					return 0u;
				}
				if (GetType().IsSubclassOf(typeof(VigObject)))
				{
					return UpdateW(8, 10000);
				}
			}
		}
		else
		{
			if (arg1 < 3)
			{
				if (arg1 != 0)
				{
					return 0u;
				}
				if (vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < vTransform.position.y)
				{
					LevelManager.instance.FUN_4DE54(vTransform.position, 138);
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 70);
					if (GetType().IsSubclassOf(typeof(VigObject)))
					{
						UpdateW(8, 10000);
					}
					return uint.MaxValue;
				}
				int num = vTransform.rotation.V02 * 3814;
				if (num < 0)
				{
					num += 4095;
				}
				int y = physics1.Y;
				int num2 = y;
				if (y < 0)
				{
					num2 = y + 7;
				}
				physics1.Y = y + -((num >> 12) + (num2 >> 3));
				num = vTransform.rotation.V12 * 3814;
				if (num < 0)
				{
					num += 4095;
				}
				y = physics1.Z;
				num2 = y;
				if (y < 0)
				{
					num2 = y + 7;
				}
				physics1.Z = y + -((num >> 12) + (num2 >> 3));
				num = vTransform.rotation.V22 * 3814;
				if (num < 0)
				{
					num += 4095;
				}
				y = physics1.W;
				num2 = y;
				if (y < 0)
				{
					num2 = y + 7;
				}
				int y2 = physics1.Y;
				physics1.W = y + -((num >> 12) + (num2 >> 3));
				if (y2 < -45776)
				{
					num2 = -45776;
				}
				else
				{
					num2 = 45776;
					if (y2 < 45777)
					{
						num2 = y2;
					}
				}
				physics1.Y = num2;
				num2 = physics1.Z;
				if (num2 < -45776)
				{
					y = -45776;
				}
				else
				{
					y = 45776;
					if (num2 < 45777)
					{
						y = num2;
					}
				}
				num2 = physics1.W;
				physics1.Z = y + 90;
				if (num2 < -45776)
				{
					y = -45776;
				}
				else
				{
					y = 45776;
					if (num2 < 45777)
					{
						y = num2;
					}
				}
				physics1.W = y;
				screen.x += physics1.Y;
				screen.y += physics1.Z;
				screen.z += physics1.W;
				num = vTransform.rotation.V12 * 30;
				if (num < 0)
				{
					num = vTransform.rotation.V12 * -30;
				}
				int num3 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
				if (num3 < screen.y + num + 81920 && -1 < physics1.Z)
				{
					physics1.Z = -physics1.Z;
					if (0 < physics2.X)
					{
						physics2.X = -physics2.X;
					}
					if ((GameManager.FUN_2AC5C() & 3) == 0)
					{
						VigObject vigObject = DAT_80 = FUN_6EC();
					}
				}
				vTransform.position = screen;
				Vector3Int vin = default(Vector3Int);
				Vector3Int v = default(Vector3Int);
				vin.x = screen.x - DAT_80.screen.x;
				vin.y = screen.y + (-(DAT_80.vCollider.reader.ReadInt32(8) / 2) - DAT_80.screen.y);
				vin.z = screen.z - DAT_80.screen.z;
				v.x = vTransform.rotation.V02;
				v.y = vTransform.rotation.V12;
				v.z = vTransform.rotation.V22;
				Utilities.FUN_29FC8(vin, out Vector3Int vout);
				vout = Utilities.FUN_2A1E0(v, vout);
				num = vout.y;
				if (num < 0)
				{
					num += 3;
				}
				num2 = physics2.Y;
				int num4 = (num >> 2) - screen.y;
				if ((num4 ^ num2) < 0)
				{
					y = num2 + 4;
					if (num4 < 1)
					{
						y = num2 - 4;
					}
				}
				else
				{
					y = num2 + 2;
					if (num4 < 1)
					{
						y = num2 - 2;
					}
				}
				physics2.Y = y;
				y = physics2.Y;
				num2 = -64;
				if (-65 < y)
				{
					num2 = 64;
					if (y < 65)
					{
						num2 = y;
					}
				}
				physics2.Y = num2;
				vr.y = (short)(((ushort)vr.y + (ushort)physics2.Y) * 16 >> 4);
				num = Utilities.FUN_24238(vTransform.rotation, vout).x;
				if (num < 0)
				{
					num += 3;
				}
				num2 = physics2.X;
				num4 = (num >> 2) - num2;
				if ((num4 ^ num2) < 0 && num2 != 0)
				{
					physics2.X = 0;
				}
				else
				{
					num2 = ((num4 >= 1) ? (physics2.X + 1) : (physics2.X - 1));
					physics2.X = num2;
				}
				y = physics2.X;
				num2 = -8;
				if (-9 < y)
				{
					num2 = 8;
					if (y < 9)
					{
						num2 = y;
					}
				}
				physics2.X = num2;
				num3 = ((ushort)vr.x + (ushort)physics2.X) * 1048576 >> 20;
				num = -512;
				if (-513 < num3)
				{
					num = 64;
					if (num3 < 65)
					{
						num = num3;
					}
				}
				vr.x = (short)num;
				ApplyRotationMatrix();
				return 0u;
			}
			switch (arg1)
			{
			default:
				return 0u;
			case 8:
				if (!FUN_32B90((uint)arg2))
				{
					return 0u;
				}
				GameManager.instance.FUN_309A0(this);
				return 4294967294u;
			case 3:
				break;
			}
		}
		return 0u;
	}

	private static VigObject FUN_6EC()
	{
		int num = 0;
		List<VigTuple> worldObjs = GameManager.instance.worldObjs;
		for (int i = 0; i < worldObjs.Count; i++)
		{
			VigTuple vigTuple = worldObjs[i];
			if (vigTuple.vObject.type == 2 && vigTuple.vObject.maxHalfHealth != 0)
			{
				num++;
			}
		}
		num = (int)GameManager.FUN_2AC5C() * num >> 15;
		worldObjs = GameManager.instance.worldObjs;
		VigObject vigObject = null;
		for (int j = 0; j < worldObjs.Count; j++)
		{
			VigTuple vigTuple = worldObjs[j];
			vigObject = vigTuple.vObject;
			if (vigObject.type == 2 && vigObject.maxHalfHealth != 0 && --num == -1)
			{
				break;
			}
		}
		return vigObject;
	}
}
