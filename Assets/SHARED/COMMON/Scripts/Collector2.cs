using UnityEngine;

public class Collector2 : VigObject
{
	private static Vector3Int DAT_20 = new Vector3Int(0, 0, 0);

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
		if (self.type != 2)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)self;
		if ((vehicle.flags & 0x4004000) != 16384)
		{
			return 0u;
		}
		ConfigContainer cont = FUN_2C5F4(32768);
		VigObject vigObject = new GameObject().AddComponent<VigObject>();
		VigObject vigObject2 = Utilities.FUN_2CD78(this);
		PDAT_74 = vehicle;
		PDAT_78 = vigObject;
		Utilities.FUN_2CA94(this, cont, vigObject);
		Utilities.ParentChildren(this, this);
		int param;
		if (vehicle.DAT_58 < 65536)
		{
			vigObject.type = 4;
			if ((flags & 0x10000000) != 0)
			{
				DAT_19 = 35;
				param = 15;
				goto IL_01ab;
			}
			DAT_19 = 3;
		}
		else
		{
			short v = vigObject.vTransform.rotation.V00;
			vigObject.vTransform.rotation.V00 = vigObject.vTransform.rotation.V02;
			short v2 = vigObject.vTransform.rotation.V10;
			short v3 = vigObject.vTransform.rotation.V20;
			vigObject.vTransform.rotation.V02 = (short)(-v);
			vigObject.vTransform.rotation.V10 = vigObject.vTransform.rotation.V12;
			vigObject.vTransform.rotation.V12 = (short)(-v2);
			vigObject.vTransform.rotation.V20 = vigObject.vTransform.rotation.V22;
			vigObject.vTransform.rotation.V22 = (short)(-v3);
			byte dAT_ = 16;
			if ((flags & 0x10000000) != 0)
			{
				dAT_ = 48;
			}
			DAT_19 = dAT_;
		}
		param = 63;
		goto IL_01ab;
		IL_01ab:
		GameManager.instance.FUN_30CB0(this, param);
		FUN_30B78();
		flags |= 536870944u;
		vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
		vigObject2.flags &= 4294965247u;
		vehicle.FUN_30BA8();
		vehicle.state = _VEHICLE_TYPE.Collector;
		vehicle.DAT_F6 |= 2048;
		vehicle.PDAT_74 = this;
		vehicle.physics1.X = 0;
		vehicle.physics1.Y = 0;
		vehicle.physics1.Z = 0;
		vehicle.physics2.X = 0;
		vehicle.physics2.Y = 0;
		vehicle.physics2.Z = 0;
		VigCamera vCamera = vehicle.vCamera;
		if (vCamera != null)
		{
			vCamera.target = vigObject2;
			vCamera.DAT_92 = 1024;
			vCamera.DAT_9C = 245760;
		}
		param = -150;
		if (((Vehicle)vigObject2).doubleDamage != 0)
		{
			param = -300;
		}
		param = vehicle.FUN_3B078(vigObject2, (ushort)DAT_1A, param, 1u);
		vehicle.FUN_3A020(param, DAT_20, param3: true);
		if (vehicle.id < 0)
		{
			GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 0, 64);
		}
		return 1u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int num = FUN_42330(arg2);
			if (num < 1)
			{
				return 0u;
			}
			if (arg2 < 0)
			{
				return 0u;
			}
			VigObject vigObject = child2;
			VigObject pDAT_2;
			VigTransform vigTransform2;
			int num4;
			VigObject pDAT_;
			sbyte b;
			sbyte b2;
			short x;
			int num3;
			int num7;
			int num6;
			switch (DAT_19)
			{
			case 0:
				vr.x -= 64;
				x = (short)(vigObject.vr.x - 64);
				goto IL_017c;
			default:
				return 0u;
			case 2:
				vr.x += 64;
				x = (short)(vigObject.vr.x + 64);
				goto IL_017c;
			case 3:
				pDAT_2 = PDAT_74;
				vigTransform2 = GameManager.instance.FUN_2CDF4(PDAT_78);
				Utilities.FUN_248C4(pDAT_2.vTransform.rotation, vigTransform2.rotation, out Matrix3x3 m3);
				num = -m3.V12;
				if (0 < m3.V12)
				{
					num += 7;
				}
				num3 = m3.V02 - m3.V20;
				num >>= 3;
				if (num3 < 0)
				{
					num3 += 7;
				}
				num4 = m3.V10;
				num3 >>= 3;
				goto IL_0863;
			case 4:
				vr.x += 32;
				pDAT_ = PDAT_78;
				vigObject.vr.x += 32;
				pDAT_.vr.x -= 32;
				if (arg2 == 0)
				{
					return 0u;
				}
				ApplyRotationMatrix();
				vigObject.ApplyRotationMatrix();
				pDAT_.ApplyRotationMatrix();
				break;
			case 5:
			case 38:
			{
				pDAT_ = PDAT_78;
				num = pDAT_.vTransform.rotation.V02 * 1525;
				if (num < 0)
				{
					num += 4095;
				}
				int num2 = pDAT_.vTransform.rotation.V12 * 1525;
				pDAT_.vTransform.position.x += num >> 12;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				num = pDAT_.vTransform.rotation.V22 * 1525;
				pDAT_.vTransform.position.y += num2 >> 12;
				if (num < 0)
				{
					num += 4095;
				}
				pDAT_.vTransform.position.z += num >> 12;
				if (arg2 == 0)
				{
					return 0u;
				}
				break;
			}
			case 6:
			case 40:
			{
				vigObject = Utilities.FUN_2CD78(this);
				if ((vigObject.flags & 0x4000000) == 0)
				{
					uint num5 = GameManager.FUN_2AC5C();
					if ((num5 & 7) == 0)
					{
						num6 = (int)GameManager.FUN_2AC5C();
						vigObject.physics1.X += ((num6 * 1524 >> 15) - 762) * 128;
						num6 = (int)GameManager.FUN_2AC5C();
						vigObject.physics1.Y += ((num6 * 1524 >> 15) - 762) * 128;
						num6 = (int)GameManager.FUN_2AC5C();
						vigObject.physics1.Z += ((num6 * 1524 >> 15) - 762) * 128;
					}
				}
				Vehicle vehicle = (Vehicle)PDAT_74;
				vehicle.vTransform.position = vigObject.vTransform.position;
				vehicle.screen = vehicle.vTransform.position;
				int num2 = -2;
				if (((Vehicle)vigObject).doubleDamage != 0)
				{
					num2 = -4;
				}
				vehicle.FUN_3A020(num2, DAT_20, param3: false);
				if (vehicle.shield == 0)
				{
					vehicle = (Vehicle)DAT_80;
					if (vehicle.body[0] == null)
					{
						if (vehicle.maxFullHealth <= vehicle.maxHalfHealth)
						{
							return 0u;
						}
					}
					else if (vehicle.maxFullHealth <= vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth)
					{
						return 0u;
					}
					vehicle.FUN_3A0C0(-num2);
				}
				return 0u;
			}
			case 7:
			case 41:
			{
				pDAT_ = PDAT_74;
				num = pDAT_.physics1.X;
				if (num < 0)
				{
					num += 127;
				}
				int num2 = pDAT_.physics1.Y;
				pDAT_.vTransform.position.x += num >> 7;
				if (num2 < 0)
				{
					num2 += 127;
				}
				num = pDAT_.physics1.Z;
				pDAT_.vTransform.position.y += num2 >> 7;
				if (num < 0)
				{
					num += 127;
				}
				pDAT_.vTransform.position.z += num >> 7;
				return 0u;
			}
			case 16:
			case 48:
				pDAT_2 = PDAT_74;
				vigTransform2 = GameManager.instance.FUN_2CDF4(PDAT_78);
				Utilities.FUN_248C4(pDAT_2.vTransform.rotation, vigTransform2.rotation, out Matrix3x3 m2);
				num = -m2.V12;
				if (0 < m2.V12)
				{
					num += 7;
				}
				num3 = m2.V02 - m2.V20;
				num >>= 3;
				if (num3 < 0)
				{
					num3 += 7;
				}
				num4 = m2.V10;
				num3 >>= 3;
				goto IL_0863;
			case 17:
			case 19:
			case 21:
			case 23:
				vr.x += 32;
				vigObject.vr.x += 32;
				if (arg2 == 0)
				{
					return 0u;
				}
				ApplyTransformation();
				vigObject.ApplyTransformation();
				b = (sbyte)DAT_19;
				b2 = 23;
				goto IL_0aa6;
			case 18:
			case 20:
			case 22:
				vr.x -= 64;
				vigObject.vr.x -= 64;
				if (arg2 == 0)
				{
					return 0u;
				}
				ApplyTransformation();
				vigObject.ApplyTransformation();
				b = (sbyte)DAT_19;
				b2 = 22;
				goto IL_0aa6;
			case 32:
				do
				{
					x = -21;
					if (vigObject.id != 0)
					{
						x = 21;
					}
					vigObject.vr.y += x;
					vigObject.child2.vr.y += x;
					if (arg2 != 0)
					{
						vigObject.ApplyTransformation();
						vigObject.child2.ApplyTransformation();
					}
					vigObject = vigObject.child;
				}
				while (vigObject != null);
				return 0u;
			case 34:
			case 55:
				do
				{
					x = 21;
					if (vigObject.id != 0)
					{
						x = -21;
					}
					vigObject.vr.y += x;
					vigObject.child2.vr.y += x;
					if (arg2 != 0)
					{
						vigObject.ApplyTransformation();
						vigObject.child2.ApplyTransformation();
					}
					vigObject = vigObject.child;
				}
				while (vigObject != null);
				return 0u;
			case 35:
				do
				{
					x = 21;
					if (vigObject.id != 0)
					{
						x = -21;
					}
					vigObject.vr.y += x;
					vigObject.child2.vr.y += x;
					if (arg2 != 0)
					{
						vigObject.ApplyTransformation();
						vigObject.child2.ApplyTransformation();
					}
					vigObject = vigObject.child;
				}
				while (vigObject.type == 0);
				goto case 36;
			case 36:
				pDAT_2 = PDAT_74;
				vigTransform2 = GameManager.instance.FUN_2CDF4(PDAT_78);
				Utilities.FUN_248C4(pDAT_2.vTransform.rotation, vigTransform2.rotation, out Matrix3x3 m);
				num = -m.V12;
				if (0 < m.V12)
				{
					num += 7;
				}
				num3 = m.V02 - m.V20;
				num >>= 3;
				if (num3 < 0)
				{
					num3 += 7;
				}
				num4 = m.V10;
				num3 >>= 3;
				goto IL_0863;
			case 37:
				pDAT_ = PDAT_78;
				vr.x += 32;
				if (arg2 == 0)
				{
					return 0u;
				}
				ApplyRotationMatrix();
				break;
			case 39:
				vr.x -= 64;
				if (arg2 == 0)
				{
					return 0u;
				}
				ApplyTransformation();
				return 0u;
			case 49:
			case 51:
			case 53:
				vr.x += 32;
				if (arg2 == 0)
				{
					return 0u;
				}
				ApplyTransformation();
				goto IL_0aac;
			case 50:
			case 52:
			case 54:
				{
					vr.x -= 64;
					if (arg2 == 0)
					{
						return 0u;
					}
					ApplyTransformation();
					b = (sbyte)DAT_19;
					b2 = 54;
					goto IL_0aa6;
				}
				IL_017c:
				vigObject.vr.x = x;
				if (arg2 == 0)
				{
					return 0u;
				}
				ApplyRotationMatrix();
				vigObject.ApplyRotationMatrix();
				return 0u;
				IL_0aa6:
				if (b == b2)
				{
					return 0u;
				}
				goto IL_0aac;
				IL_0aac:
				pDAT_ = PDAT_78;
				break;
				IL_0863:
				if (num4 < 0)
				{
					num4 += 7;
				}
				pDAT_2.FUN_24700((short)num, (short)num3, (short)(num4 >> 3));
				num = vigTransform2.position.x - pDAT_2.vTransform.position.x;
				if (num < 0)
				{
					num += 7;
				}
				num >>= 3;
				pDAT_2.vTransform.position.x += num;
				num7 = vigTransform2.position.y - pDAT_2.vTransform.position.y;
				if (num7 < 0)
				{
					num7 += 7;
				}
				num7 >>= 3;
				pDAT_2.vTransform.position.y += num7;
				num6 = vigTransform2.position.z - pDAT_2.vTransform.position.z;
				if (num6 < 0)
				{
					num6 += 7;
				}
				num6 >>= 3;
				pDAT_2.vTransform.position.z += num6;
				if ((flags & 0x20000000) != 0)
				{
					if (num < 0)
					{
						num = -num;
					}
					if (num < 2048)
					{
						if (num7 < 0)
						{
							num7 = -num7;
						}
						if (num7 < 2048)
						{
							if (num6 < 0)
							{
								num6 = -num6;
							}
							if (num6 < 2048)
							{
								flags &= 3758096383u;
								int param = GameManager.instance.FUN_1DD9C();
								Vector3Int param2 = GameManager.instance.FUN_2CE50(pDAT_2);
								GameManager.instance.FUN_1E628(param, vData.sndList, 6, param2);
							}
						}
					}
				}
				pDAT_2.vTransform.rotation = Utilities.MatrixNormal(pDAT_2.vTransform.rotation);
				return 0u;
			}
			VigTransform vTransform = GameManager.instance.FUN_2CDF4(pDAT_);
			vigObject = PDAT_74;
			vigObject.vTransform = vTransform;
			return 0u;
		}
		case 4:
		{
			if (DAT_19 == 0)
			{
				return 0u;
			}
			if (PDAT_78 != null)
			{
				VigObject vigObject2 = PDAT_78.FUN_2CCBC();
				UnityEngine.Object.Destroy(vigObject2.gameObject);
				PDAT_78 = null;
			}
			VigObject vigObject = PDAT_74;
			if (vigObject != null)
			{
				Vehicle vehicle = (Vehicle)vigObject;
				vehicle.FUN_41FEC();
				vehicle.DAT_F6 &= 63487;
				uint num5 = vehicle.flags;
				vehicle.flags = (uint)((int)num5 & -35);
				if ((num5 & 0x80) == 0)
				{
					vehicle.FUN_30B78();
				}
				if (vehicle.vCamera != null)
				{
					vehicle.vCamera.target = vehicle;
					vehicle.vCamera.FUN_4B898();
				}
				PDAT_74 = null;
			}
			GameManager.instance.FUN_1DE78(DAT_18);
			return 0u;
		}
		default:
			return 0u;
		case 2:
		{
			ApplyTransformation();
			child2.ApplyTransformation();
			sbyte b = (sbyte)(DAT_19 + 1);
			DAT_19 = (byte)b;
			Vehicle vehicle;
			int param;
			Vector3Int param2;
			switch (b)
			{
			case 1:
			case 33:
			{
				FUN_30BA8();
				GameManager.instance.FUN_30CB0(this, 128);
				flags &= 4294967263u;
				VigObject vigObject = Utilities.FUN_2CD78(this);
				vigObject.flags |= 2048u;
				break;
			}
			case 2:
			case 34:
			{
				FUN_30B78();
				GameManager.instance.FUN_30CB0(this, 16);
				flags |= 32u;
				VigObject vigObject = Utilities.FUN_2CD78(this);
				vigObject.flags &= 4294965247u;
				param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, vData.sndList, 4, vigObject.vTransform.position);
				break;
			}
			case 3:
			case 35:
				FUN_30BA8();
				DAT_19 = 0;
				if (maxHalfHealth == 0)
				{
					FUN_3A368();
					return 0u;
				}
				break;
			case 4:
			case 37:
				param = 32;
				goto IL_13f1;
			case 5:
			case 38:
				LevelManager.instance.FUN_4DE54(PDAT_74.vTransform.position, 138);
				GameManager.instance.FUN_30CB0(this, 24);
				param = GameManager.instance.FUN_1DD9C();
				param2 = GameManager.instance.FUN_2CE50(this);
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, param2);
				break;
			case 6:
			case 40:
			{
				VigObject pDAT_ = PDAT_74;
				vehicle = (Vehicle)Utilities.FUN_2CD78(this);
				pDAT_.flags |= 2u;
				b = (DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C());
				GameManager.instance.FUN_1E580(b, vData.sndList, 3, pDAT_.vTransform.position, param5: true);
				if (pDAT_.id < 0)
				{
					GameManager.instance.FUN_15AA8(~pDAT_.id, byte.MaxValue, byte.MaxValue, byte.MaxValue, 64);
				}
				if (vehicle.id < 0)
				{
					GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, byte.MaxValue, 64);
				}
				VigObject vigObject2 = PDAT_78.FUN_2CCBC();
				UnityEngine.Object.Destroy(vigObject2.gameObject);
				PDAT_78 = null;
				GameManager.instance.FUN_30CB0(this, 256);
				VigObject vigObject3 = vehicle.body[1].child2;
				if (!(vigObject3 != null))
				{
					break;
				}
				do
				{
					if (vigObject3.id - 16 < 2)
					{
						if (vigObject3.GetType() == typeof(Body))
						{
							((Body)vigObject3).state = _BODY_TYPE.Collector;
						}
						else if (vigObject3.GetType() == typeof(Particle6))
						{
							((Particle6)vigObject3).state = _PARTICLE6_TYPE.Collector;
						}
						vigObject3.tags = (sbyte)((byte)vigObject3.id & 1);
						GameManager.instance.FUN_30CB0(vigObject3, 232);
					}
					vigObject3 = vigObject3.child;
				}
				while (vigObject3 != null);
				return 0u;
			}
			case 7:
			case 41:
			{
				VigObject pDAT_ = PDAT_74;
				pDAT_.flags &= 4294967293u;
				ConfigContainer param3 = FUN_2C5F4(32769);
				pDAT_.vTransform = GameManager.instance.FUN_2CEAC(this, param3);
				int num = pDAT_.vTransform.rotation.V02 * 4577;
				if (num < 0)
				{
					num += 31;
				}
				pDAT_.physics1.X = num >> 5;
				num = pDAT_.vTransform.rotation.V12 * 4577;
				if (num < 0)
				{
					num += 31;
				}
				pDAT_.physics1.Y = num >> 5;
				num = pDAT_.vTransform.rotation.V22 * 4577;
				if (num < 0)
				{
					num += 31;
				}
				pDAT_.physics1.Z = num >> 5;
				GameManager.instance.FUN_30CB0(this, 24);
				GameManager.instance.FUN_1E580(DAT_18, GameManager.instance.DAT_C2C, 37, pDAT_.vTransform.position);
				DAT_18 = 0;
				break;
			}
			case 8:
			case 42:
				vehicle = (Vehicle)PDAT_74;
				vehicle.FUN_41FEC();
				vehicle.DAT_F6 &= 63487;
				vehicle.flags &= 4261412831u;
				vehicle.FUN_30B78();
				PDAT_74 = null;
				goto IL_1381;
			case 19:
			case 21:
			case 51:
			case 53:
				param = GameManager.instance.FUN_1DD9C();
				param2 = GameManager.instance.FUN_2CE50(this);
				GameManager.instance.FUN_1E628(param, vData.sndList, 5, param2);
				goto case 17;
			case 17:
			case 49:
			{
				VigObject vigObject2 = Utilities.FUN_2CD78(this);
				param = -150;
				if (((Vehicle)vigObject2).doubleDamage != 0)
				{
					param = -300;
				}
				param = ((Vehicle)PDAT_74).FUN_3B078(vigObject2, (ushort)DAT_1A, param, 1u);
				((Vehicle)PDAT_74).FUN_3A020(param, DAT_20, param3: true);
				goto case 23;
			}
			case 23:
				param = 32;
				goto IL_13f1;
			case 22:
			case 54:
			{
				VigObject pDAT_ = PDAT_78;
				VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
				VigObject vigObject = Utilities.FUN_2CD78(this);
				Vector3Int vector3Int = Utilities.FUN_24094(v: new Vector3Int(0, pDAT_.vTransform.position.z, -pDAT_.vTransform.position.y), rot: vigTransform.rotation);
				Vehicle obj = (Vehicle)PDAT_74;
				obj.FUN_41FEC();
				obj.DAT_F6 &= 63487;
				obj.physics1.X = vigObject.physics1.X + vector3Int.x * 16;
				obj.physics1.Y = vigObject.physics1.Y + vector3Int.y * 16;
				obj.physics1.Z = vigObject.physics1.Z + vector3Int.z * 16;
				obj.physics2.Z = -32768;
				obj.flags &= 4294967263u;
				obj.FUN_30B78();
				param = GameManager.instance.FUN_1DD9C();
				param2 = GameManager.instance.FUN_2CE50(this);
				GameManager.instance.FUN_1E628(param, vData.sndList, 4, param2);
				VigObject vigObject2 = PDAT_78.FUN_2CCBC();
				UnityEngine.Object.Destroy(vigObject2.gameObject);
				PDAT_78 = null;
				param = -150;
				if (((Vehicle)vigObject).doubleDamage != 0)
				{
					param = -300;
				}
				param = obj.FUN_3B078(vigObject, (ushort)DAT_1A, param, 1u);
				obj.FUN_3A020(param, DAT_20, param3: true);
				goto case 18;
			}
			case 18:
			case 20:
			case 50:
			case 52:
			{
				int id = PDAT_74.id;
				if (id < 0)
				{
					GameManager.instance.FUN_15B00(~id, byte.MaxValue, 0, 64);
				}
				param = 16;
				goto IL_13f1;
			}
			case 24:
			case 56:
				vehicle = (Vehicle)PDAT_74;
				PDAT_74 = null;
				vehicle.flags &= 4261412831u;
				goto IL_1381;
			case 36:
				GameManager.instance.FUN_30CB0(this, 48);
				break;
			case 39:
				param = 16;
				PDAT_74.flags |= 2u;
				goto IL_13f1;
			case 55:
				{
					GameManager.instance.FUN_30CB0(this, 16);
					break;
				}
				IL_13f1:
				GameManager.instance.FUN_30CB0(this, param);
				param = GameManager.instance.FUN_1DD9C();
				param2 = GameManager.instance.FUN_2CE50(this);
				GameManager.instance.FUN_1E628(param, vData.sndList, 4, param2);
				break;
				IL_1381:
				DAT_19 = 0;
				FUN_30BA8();
				if (maxHalfHealth == 0)
				{
					FUN_3A368();
				}
				if (vehicle.vCamera != null)
				{
					vehicle.vCamera.target = vehicle;
					vehicle.vCamera.FUN_4B898();
				}
				break;
			}
			return 0u;
		}
		}
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		switch (arg1)
		{
		case 0:
			FUN_42330(arg2);
			return 0u;
		case 1:
			type = 3;
			if (GameManager.instance.gameMode != _GAME_MODE.Versus2)
			{
				maxHalfHealth = 6;
			}
			else
			{
				maxHalfHealth = 3;
			}
			if ((((Vehicle)arg2).DAT_F6 & 0x400) != 0)
			{
				flags |= 268435456u;
				return 0u;
			}
			if (-1 < arg2.id)
			{
				if (GameManager.instance.vehicles[arg2.id + 1] == 13)
				{
					return 0u;
				}
			}
			else if (GameManager.instance.vehicles[~arg2.id] == 13)
			{
				return 0u;
			}
			flags |= 268435456u;
			return 0u;
		default:
			return 0u;
		case 12:
			if (DAT_19 == 0)
			{
				arg2.tags = 3;
				PDAT_74 = null;
				DAT_80 = arg2;
				DAT_19 = (byte)((((flags & 0x10000000) != 0) ? 1 : 0) << 5);
				FUN_30B78();
				GameManager.instance.FUN_30CB0(this, 15);
				int param = GameManager.instance.FUN_1DD9C();
				Vector3Int param2 = GameManager.instance.FUN_2CE50(this);
				GameManager.instance.FUN_1E628(param, vData.sndList, 4, param2);
				param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param, vData.sndList, 2);
				maxHalfHealth--;
			}
			else
			{
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 1);
			}
			if (-1 < arg2.id)
			{
				return 900u;
			}
			return 480u;
		case 13:
		{
			if (DAT_19 != 0)
			{
				return 0u;
			}
			Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
			if (143358u < (uint)(vector3Int.z - 1))
			{
				return 0u;
			}
			if (vector3Int.x < 0)
			{
				vector3Int.x = -vector3Int.x;
			}
			bool flag = vector3Int.x < 65536;
			if (65536 < vector3Int.z)
			{
				flag = (vector3Int.x < vector3Int.z);
			}
			if (!flag)
			{
				return 0u;
			}
			return 1u;
		}
		}
	}
}
