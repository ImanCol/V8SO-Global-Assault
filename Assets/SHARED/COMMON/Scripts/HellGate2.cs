using UnityEngine;

public class HellGate2 : VigObject
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

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			VigObject vigObject = DAT_80;
			if (tags < 20)
			{
				Vector3Int v = default(Vector3Int);
				v.x = 0;
				v.z = 0;
				v.y = (vigObject.vCollider.reader.ReadInt32(8) + vigObject.vCollider.reader.ReadInt32(20)) / 2;
				v = Utilities.FUN_24148(vigObject.vTransform, v);
				v.x = vTransform.position.x - v.x;
				v.y = vTransform.position.y - v.y;
				v.z = vTransform.position.z - v.z;
				int num7 = v.x;
				if (v.x < 0)
				{
					num7 = v.x + 7;
				}
				int x = vigObject.physics1.X;
				int num3 = x;
				if (x < 0)
				{
					num3 = x + 31;
				}
				vigObject.physics1.X = x + ((num7 >> 3) - (num3 >> 5));
				num7 = v.y;
				if (v.y < 0)
				{
					num7 = v.y + 7;
				}
				x = vigObject.physics1.Y;
				num3 = x;
				if (x < 0)
				{
					num3 = x + 31;
				}
				vigObject.physics1.Y = x + ((num7 >> 3) - (num3 >> 5));
				num7 = v.z;
				if (v.z < 0)
				{
					num7 = v.z + 7;
				}
				x = vigObject.physics1.Z;
				num3 = x;
				if (x < 0)
				{
					num3 = x + 31;
				}
				vigObject.physics1.Z = x + ((num7 >> 3) - (num3 >> 5));
				Utilities.FUN_248C4(vigObject.vTransform.rotation, vTransform.rotation, out Matrix3x3 m2);
				num7 = m2.V11 * -4 - vigObject.physics2.X;
				if (num7 < 0)
				{
					num7 += 31;
				}
				vigObject.physics2.X += num7 >> 5;
				num7 = m2.V01 * 4 - vigObject.physics2.Y;
				if (num7 < 0)
				{
					num7 += 31;
				}
				num3 = vigObject.physics2.Z;
				vigObject.physics2.Y += num7 >> 5;
				num7 = -num3;
				if (0 < num3)
				{
					num7 += 31;
				}
				vigObject.physics2.Z = num3 + (num7 >> 5);
			}
			Vehicle vehicle2 = (Vehicle)vigObject;
			vehicle2.FUN_2AF20();
			vigObject = child2;
			if (vigObject != null)
			{
				do
				{
					vigObject.vr.y += (short)vigObject.maxHalfHealth;
					vigObject.screen.y += 455;
					vigObject.maxHalfHealth += 4;
					vigObject.maxFullHealth -= 34;
					vigObject.ApplyTransformation();
					Utilities.FUN_245AC(sv: new Vector3Int((short)vigObject.maxFullHealth, (short)vigObject.maxFullHealth, (short)vigObject.maxFullHealth), m33: ref vigObject.vTransform.rotation);
					vigObject = vigObject.child;
				}
				while (vigObject != null);
				return 0u;
			}
			return 0u;
		}
		default:
			return 0u;
		case 2:
			if (++tags < 20)
			{
				HellGate3 hellGate = vData.ini.FUN_2C17C(1, typeof(HellGate3), 8u) as HellGate3;
				Utilities.ParentChildren(hellGate, hellGate);
				hellGate.maxFullHealth = 4096;
				hellGate.vTransform = GameManager.FUN_2A39C();
				Utilities.FUN_2CC9C(this, hellGate);
				hellGate.transform.parent = base.transform;
				GameManager.instance.FUN_30CB0(hellGate, 90);
				GameManager.instance.FUN_30CB0(this, 7);
			}
			switch (((byte)tags - 20) * 16777216 >> 24)
			{
			case 0:
			{
				Vehicle vehicle = (Vehicle)DAT_80;
				vehicle.physics1.X = vehicle.vTransform.rotation.V02 * 143;
				vehicle.physics1.Y = vehicle.vTransform.rotation.V12 * 143;
				vehicle.physics1.Z = vehicle.vTransform.rotation.V22 * 143;
				VigCamera vCamera = vehicle.vCamera;
				if (vCamera != null)
				{
					vCamera.DAT_84 = new Vector3Int(0, 0, 0);
					vCamera.flags |= 67108864u;
				}
				if (vehicle.id < 0)
				{
					GameManager.instance.FUN_15AA8(~vehicle.id, 30, byte.MaxValue, 0, 64);
				}
				int num2 = 0;
				vehicle.physics2.X = 0;
				vehicle.physics2.Y = 0;
				vehicle.physics2.Z = 0;
				vehicle.flags |= 131072u;
				GameManager.instance.FUN_30CB0(this, 30);
				Vector3Int vector3Int = default(Vector3Int);
				Vector3Int param = default(Vector3Int);
				Vector3Int param2 = default(Vector3Int);
				vector3Int.y = GameManager.instance.terrain.FUN_1B750((uint)vehicle.vTransform.position.x, (uint)vehicle.vTransform.position.z);
				do
				{
					num2++;
					int num3 = (int)GameManager.FUN_2AC5C();
					param.y = vector3Int.y - 20480;
					param.x = vehicle.vTransform.position.x + (num3 * 122880 >> 15) - 61440;
					num3 = (int)GameManager.FUN_2AC5C();
					param2.z = vehicle.vTransform.position.z + (num3 * 122880 >> 15) - 61440;
					param2.x = param.x;
					param2.y = param.y;
					param.z = param2.z;
					LevelManager.instance.FUN_4DE54(param2, 33);
				}
				while (num2 < 3);
				param.x = vehicle.vTransform.position.x;
				param.z = vehicle.vTransform.position.z;
				param.y = vector3Int.y;
				vector3Int.x = param.x;
				vector3Int.z = param.z;
				LevelManager.instance.FUN_4DE54(param, 39);
				return 0u;
			}
			case 1:
			{
				Vehicle vehicle = (Vehicle)DAT_80;
				UIManager.instance.FUN_4E414(vTransform.position, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1));
				VigObject vigObject = DAT_84;
				if (vigObject == null)
				{
					vigObject = DAT_80;
				}
				vehicle.vTransform.position = vigObject.screen;
				vehicle.physics1.X = 0;
				vehicle.flags |= 33554434u;
				vehicle.physics1.Y = 0;
				vehicle.physics1.Z = 0;
				VigCamera vCamera = vehicle.vCamera;
				if (vCamera != null)
				{
					vCamera.screen.x = vehicle.vTransform.position.x;
					vCamera.screen.y = vehicle.vTransform.position.y - 307200;
					vCamera.screen.z = vehicle.vTransform.position.z - 307200;
				}
				GameManager.instance.FUN_30CB0(this, 60);
				return 0u;
			}
			case 2:
				GameManager.instance.FUN_30CB0(this, 30);
				return 0u;
			case 3:
			{
				Vehicle vehicle = (Vehicle)DAT_80;
				int num3 = 0;
				HellGate4 hellGate2 = vData.ini.FUN_2C17C(3, typeof(HellGate4), 8u) as HellGate4;
				Utilities.ParentChildren(hellGate2, hellGate2);
				VigObject vigObject = DAT_84;
				if (vigObject == null)
				{
					vigObject = DAT_80;
				}
				vTransform.position = vigObject.screen;
				vTransform.position.y = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
				Vector3Int param2 = GameManager.instance.terrain.FUN_1B998((uint)vTransform.position.x, (uint)vTransform.position.z);
				param2 = Utilities.VectorNormal(param2);
				vTransform.rotation = Utilities.FUN_2A5EC(param2);
				vehicle.flags |= 33554434u;
				vehicle.vTransform.position = vTransform.position;
				vehicle.vTransform.rotation = Utilities.FUN_2A724(param2);
				vehicle.physics1.X = 0;
				vehicle.physics1.Y = 0;
				vehicle.physics1.Z = 0;
				int num = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(num, vData.sndList, 3, vTransform.position);
				num = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(num, GameManager.instance.DAT_C2C, 67, vTransform.position);
				hellGate2.vTransform = vTransform;
				hellGate2.flags = 1610612772u;
				hellGate2.type = 8;
				short id = vehicle.id;
				hellGate2.maxHalfHealth = 300;
				if (((Vehicle)DAT_80).doubleDamage != 0)
				{
					hellGate2.maxHalfHealth = 600;
				}
				hellGate2.DAT_80 = vehicle;
				hellGate2.id = id;
				hellGate2.FUN_305FC();
				GameManager.instance.FUN_30CB0(hellGate2, 45);
				GameManager.instance.FUN_30CB0(this, 45);
				Vector3Int param3 = default(Vector3Int);
				Vector3Int param4 = default(Vector3Int);
				Vector3Int param5 = default(Vector3Int);
				param3.y = GameManager.instance.terrain.FUN_1B750((uint)vehicle.vTransform.position.x, (uint)vehicle.vTransform.position.z);
				do
				{
					num3++;
					int num2 = (int)GameManager.FUN_2AC5C();
					param4.y = param3.y - 20480;
					param4.x = vehicle.vTransform.position.x + (num2 * 122880 >> 15) - 61440;
					num2 = (int)GameManager.FUN_2AC5C();
					param5.z = vehicle.vTransform.position.z + (num2 * 122880 >> 15) - 61440;
					param5.x = param4.x;
					param5.y = param4.y;
					param4.z = param5.z;
					LevelManager.instance.FUN_4DE54(param5, 39);
				}
				while (num3 < 3);
				param4.x = vehicle.vTransform.position.x;
				param4.z = vehicle.vTransform.position.z;
				param4.y = param3.y;
				param3.x = param4.x;
				param3.z = param4.z;
				LevelManager.instance.FUN_4DE54(param4, 39);
				for (int i = 0; i < 4; i++)
				{
					Matrix3x3 m = Utilities.RotMatrixYXZ_gte(new Vector3Int(0, i * 512, 0));
					ConfigContainer param6 = FUN_2C5F4(32768);
					uint num4 = 0u;
					uint num5 = 65024u;
					GameManager.instance.FUN_2CF00(out param3, this, param6);
					Vector3Int vector3Int = new Vector3Int(0, 0, 0);
					vector3Int.y = 2048;
					do
					{
						if (num4 != 0 && num4 != 1)
						{
							Flamewall3 flamewall = LevelManager.instance.xobfList[19].ini.FUN_2C17C(113, typeof(Flamewall3), 8u) as Flamewall3;
							flamewall.flags = 1610614452u;
							short id2 = vehicle.id;
							flamewall.type = 8;
							flamewall.maxHalfHealth = 100;
							flamewall.DAT_80 = vehicle;
							flamewall.id = id2;
							flamewall.vTransform.position = hellGate2.vTransform.position;
							flamewall.vTransform.position.y -= 131072;
							if (i != 0)
							{
								flamewall.tags = 1;
							}
							if ((num4 & 1) == 0)
							{
								vector3Int.x = (short)num5;
							}
							else
							{
								vector3Int.x = (short)num4 * 1024 - 512;
							}
							Vector3Int vector3Int2 = Utilities.ApplyMatrixSV(m, vector3Int);
							int num6 = 256;
							if (num6 < 0)
							{
								num6 += 127;
							}
							flamewall.physics1.Z = (num6 >> 7) * vector3Int2.x;
							num6 = -65536;
							if (num6 < 0)
							{
								num6 += 127;
							}
							flamewall.physics1.W = (num6 >> 7) + vector3Int2.y;
							num6 = 256;
							if (num6 < 0)
							{
								num6 += 127;
							}
							flamewall.physics2.X = (num6 >> 7) * vector3Int2.z;
							flamewall.FUN_305FC();
						}
						num4++;
						num5 -= 1024;
					}
					while (5 >= (int)num4);
				}
				return 0u;
			}
			case 4:
			{
				Vehicle vehicle2 = (Vehicle)DAT_80;
				Quake quake = new GameObject().AddComponent<Quake>();
				if (vehicle2.id < 0)
				{
					GameManager.instance.FUN_15AA8(~vehicle2.id, 30, byte.MaxValue, 0, 64);
				}
				vehicle2.flags &= 4261412829u;
				vehicle2.physics1.X = vehicle2.vTransform.rotation.V02 * 143;
				vehicle2.physics1.Y = vehicle2.vTransform.rotation.V12 * 143;
				vehicle2.physics1.Z = vehicle2.vTransform.rotation.V22 * 143;
				vehicle2.physics2.X = -10368;
				quake.screen = vTransform.position;
				quake.flags = 160u;
				quake.FUN_3066C();
				int num = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(num, vData.sndList, 3, vTransform.position);
				GameManager.instance.FUN_1E30C(num, 4595);
				GameManager.instance.FUN_30CB0(this, 45);
				return 0u;
			}
			case 5:
			{
				Vehicle vehicle = (Vehicle)DAT_80;
				VigCamera vCamera = vehicle.vCamera;
				int num = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(num, vData.sndList, 3, vTransform.position);
				GameManager.instance.FUN_1E30C(num, 3649);
				if (vCamera != null)
				{
					vCamera.flags = (uint)(((int)vCamera.flags & -67108865) | 0x8000000);
				}
				if (DAT_94.maxHalfHealth == 0)
				{
					DAT_94.FUN_3A368();
				}
				vehicle.FUN_30B78();
				GameManager.instance.DAT_1084--;
				vehicle.flags &= 4194172927u;
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
			default:
				return 0u;
			}
		}
	}
}
