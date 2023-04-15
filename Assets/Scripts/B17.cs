using System.IO;
using UnityEngine;

public class B17 : VigObject
{
	public _B17_TYPE state;

	public VigObject DAT_A8;

	public int DAT_AC;

	public bool loop;

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
		return arg1.ini.FUN_2C17C((ushort)(arg2 & 0xFFFF), typeof(B17), 0u);
	}

	public override uint OnCollision(HitDetection hit)
	{
		if (state == _B17_TYPE.Type1)
		{
			VigObject self = hit.self;
			sbyte b;
			if (hit.collider1.ReadUInt16(2) == 0)
			{
				b = (sbyte)self.type;
			}
			else
			{
				b = (sbyte)self.type;
				if (b == 2)
				{
					Vehicle vehicle = (Vehicle)self;
					GameManager.instance.FUN_2F798(this, hit);
					Vector3Int v = default(Vector3Int);
					v.x = 327680;
					if (hit.position.x < 0)
					{
						v.x = -327680;
					}
					v.y = -163840;
					v.z = 163840;
					v = Utilities.FUN_24094(vTransform.rotation, v);
					hit.position = Utilities.FUN_24148(vTransform, hit.position);
					vehicle.FUN_2B370(v, hit.position);
					if (DAT_AC == 0 || !GameManager.instance.IsAudioPlaying(DAT_AC, vData.sndList[3]))
					{
						int param = DAT_AC = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E580(param, vData.sndList, 3, hit.position);
					}
					LevelManager.instance.FUN_4E8C8(hit.position, 49);
					hit.position = Utilities.FUN_24304(vehicle.vTransform, hit.position);
					vehicle.FUN_3A020(-100, hit.position, param3: true);
					return 0u;
				}
			}
			if (b != 8)
			{
				return 0u;
			}
			int maxHalfHealth = self.maxHalfHealth;
			if (-1 < tags && FUN_32B90((uint)maxHalfHealth))
			{
				int num = 0;
				tags = -1;
				physics1.X <<= 7;
				physics1.Z <<= 7;
				physics1.Y <<= 7;
				GameManager.instance.FUN_30CB0(this, 300);
				Vector3Int param2 = default(Vector3Int);
				do
				{
					num++;
					int num2 = (int)GameManager.FUN_2AC5C();
					param2.x = (num2 * 3051 >> 15) - 1525;
					param2.y = -4577;
					num2 = (int)GameManager.FUN_2AC5C();
					param2.z = (num2 * 3051 >> 15) - 1525;
					LevelManager.instance.FUN_4AAC0(4269277184u, screen, param2);
				}
				while (num < 3);
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		int num2;
		VigObject vigObject;
		int num;
		switch (state)
		{
		case _B17_TYPE.Type1:
		{
			uint result;
			switch (arg1)
			{
			case 0:
			{
				if (-1 < tags)
				{
					screen.x += physics1.X;
					screen.y += physics1.Y;
					screen.z += physics1.Z;
					vTransform.position = screen;
				}
				int num6;
				switch (((byte)tags + 1) * 16777216 >> 24)
				{
				case 0:
				{
					vCollider.reader.Seek(4L, SeekOrigin.Current);
					FUN_2B4F8(vCollider.reader);
					vCollider.reader.Seek(-4L, SeekOrigin.Current);
					if (((GameManager.instance.DAT_28 - DAT_19) & 3) != 0)
					{
						return 0u;
					}
					PlaneSmoke obj2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C(18, typeof(PlaneSmoke), 8u) as PlaneSmoke;
					num6 = GameManager.instance.DAT_28;
					obj2.flags |= 1204u;
					obj2.screen = vTransform.position;
					obj2.vr.z = num6 * 96;
					obj2.FUN_3066C();
					return 0u;
				}
				case 1:
					num6 = physics1.X;
					physics1.X = num6 + 32;
					if (15258 < num6 + 32)
					{
						tags = 1;
					}
					break;
				case 2:
					vr.z++;
					vr.y++;
					ApplyTransformation();
					if (-1983 < physics1.Y)
					{
						physics1.Y -= 6;
					}
					num6 = vTransform.rotation.V02 * 15258;
					if (num6 < 0)
					{
						num6 += 4095;
					}
					physics1.X = num6 >> 12;
					num6 = vTransform.rotation.V22 * 15258;
					if (num6 < 0)
					{
						num6 += 4095;
					}
					physics1.Z = num6 >> 12;
					if (341 < vr.z)
					{
						tags = 2;
					}
					break;
				case 3:
					if ((uint)(VigTerrain.instance.DAT_DE8 + 4194304) < (uint)screen.x)
					{
						vr = new Vector3Int(0, -1024, 0);
						physics1.X = -15258;
						physics1.Y = 1983;
						physics1.Z = 0;
						screen.x = 80939368;
						num6 = GameManager.instance.terrain.FUN_1B750(67207168u, 63242240u);
						screen.z = 63242240;
						screen.y = num6 + physics1.Y * -900;
						tags = 3;
						ApplyTransformation();
					}
					break;
				case 4:
					num6 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
					if (num6 <= screen.y)
					{
						physics1.Y = 0;
						tags = 4;
					}
					break;
				case 5:
					num6 = physics1.X;
					physics1.X = num6 + 24;
					if (-3052 < num6 + 24)
					{
						tags = 5;
					}
					break;
				case 6:
					if (screen.x < 61098793)
					{
						tags = 6;
					}
					break;
				case 7:
					vr.y -= 8;
					ApplyTransformation();
					num6 = vTransform.rotation.V02 * 3051;
					if (num6 < 0)
					{
						num6 += 4095;
					}
					physics1.X = num6 >> 12;
					num6 = vTransform.rotation.V22 * 3051;
					if (num6 < 0)
					{
						num6 += 4095;
					}
					physics1.Z = num6 >> 12;
					if (vr.y < -2047)
					{
						tags = 7;
					}
					break;
				case 8:
					if (screen.z < 60476201)
					{
						tags = 8;
					}
					break;
				case 9:
					vr.y -= 8;
					ApplyTransformation();
					num6 = vTransform.rotation.V02 * 3051;
					if (num6 < 0)
					{
						num6 += 4095;
					}
					physics1.X = num6 >> 12;
					num6 = vTransform.rotation.V22 * 3051;
					if (num6 < 0)
					{
						num6 += 4095;
					}
					physics1.Z = num6 >> 12;
					if (vr.y < -3071)
					{
						tags = 0;
					}
					break;
				}
				result = 0u;
				if (arg2 == 0)
				{
					break;
				}
				VigObject vigObject2 = child2;
				while (vigObject2 != null)
				{
					if (vigObject2.id == 0)
					{
						vigObject2.vr.z += arg2 * 256;
						vigObject2.ApplyTransformation();
					}
					vigObject2 = vigObject2.child;
				}
				num6 = (int)GameManager.instance.FUN_1E7A8(screen);
				GameManager.instance.FUN_1E2C8(DAT_18, (uint)(num6 << 1));
				result = 0u;
				break;
			}
			case 1:
			{
				DAT_A0 = new Vector3Int(64, 64, 64);
				if (tags == 0)
				{
					flags |= 392u;
					sbyte param4 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E098(param4, vData.sndList, 1, 0u, param5: true);
				}
				else
				{
					state = _B17_TYPE.Type2;
					tags = 0;
					flags |= 298u;
					GameManager.instance.FUN_30CB0(this, 60);
				}
				GameObject gameObject = new GameObject();
				VigMesh param5 = vData.FUN_2CB74(gameObject, 224u, init: true);
				FUN_4C7AC(param5, gameObject);
				result = 0u;
				break;
			}
			case 2:
			{
				int num6 = DAT_58;
				FUN_4DC94();
				if (GameManager.instance.gameMode != _GAME_MODE.Survival && GameManager.instance.gameMode != _GAME_MODE.Survival2)
				{
					GameManager.instance.FUN_309A0(this);
					result = uint.MaxValue;
					break;
				}
				FUN_2C344(vData, 225, 0u);
				Utilities.ParentChildren(this, this);
				screen.x = 80939368;
				screen.z = 63242240;
				ApplyTransformation();
				tags = 2;
				flags &= 4294967263u;
				DAT_58 = num6;
				sbyte param4 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E098(param4, vData.sndList, 1, 0u, param5: true);
				result = 0u;
				break;
			}
			case 8:
				if (-1 < tags && FUN_32B90((uint)arg2))
				{
					int num6 = 0;
					tags = -1;
					physics1.X <<= 7;
					physics1.Z <<= 7;
					physics1.Y <<= 7;
					GameManager.instance.FUN_30CB0(this, 300);
					Vector3Int param3 = default(Vector3Int);
					do
					{
						num6++;
						num = (int)GameManager.FUN_2AC5C();
						param3.x = (num * 3051 >> 15) - 1525;
						param3.y = -4577;
						num = (int)GameManager.FUN_2AC5C();
						param3.z = (num * 3051 >> 15) - 1525;
						LevelManager.instance.FUN_4AAC0(4269277184u, screen, param3);
					}
					while (num6 < 3);
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
				}
				goto default;
			default:
				result = 0u;
				break;
			case 4:
				GameManager.instance.FUN_1DE78(DAT_18);
				goto default;
			}
			return result;
		}
		case _B17_TYPE.Type2:
			{
				switch (arg1)
				{
				default:
					return 0u;
				case 2:
				{
					if ((flags & 0x80) != 0)
					{
						if (loop)
						{
							tags = 2;
							flags &= 4294967261u;
							return 0u;
						}
						FUN_30BA8();
						GameManager.instance.FUN_1DE78(DAT_18);
						DAT_18 = 0;
						flags |= 34u;
						vr.y ^= 2048;
						num = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
						screen.y = num - 409600;
					}
					num = 0;
					VigTuple2 vigTuple;
					Vehicle vehicle;
					int param;
					while ((vehicle = GameManager.instance.playerObjects[num]) == null || (vigTuple = GameManager.instance.FUN_2FF3C((uint)vehicle.vTransform.position.x, (uint)vehicle.vTransform.position.z)) == null || vigTuple.id != 0)
					{
						num++;
						if (1 < num)
						{
							tags = 0;
							param = 60;
							GameManager.instance.FUN_30CB0(this, param);
							return 0u;
						}
					}
					if (++tags != 1)
					{
						DAT_A8 = vehicle;
						flags &= 4294967261u;
						sbyte param2 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E098(param2, vData.sndList, 1, 0u, param5: true);
						FUN_30B78();
						return 0u;
					}
					param = 120;
					GameManager.instance.FUN_30CB0(this, param);
					return 0u;
				}
				case 0:
					break;
				}
				if (tags == 0)
				{
					num2 = -vr.z >> 4;
					num = -16;
					if (-17 < num2)
					{
						num = 16;
						if (num2 < 17)
						{
							num = num2;
						}
					}
					num = vr.z + num;
					vr.z = num;
					vr.y += num * 65536 >> 22;
					screen.y -= 3051;
				}
				else
				{
					VigObject dAT_A = DAT_A8;
					num = dAT_A.screen.x - screen.x;
					num2 = dAT_A.screen.z - screen.z;
					int num3 = Utilities.Ratan2(num, num2);
					num3 = (num3 - vr.y) * 1048576 >> 16;
					int num4 = -512;
					if (-513 < num3)
					{
						num4 = 512;
						if (num3 < 513)
						{
							num4 = num3;
						}
					}
					int num5 = num4 - vr.z >> 4;
					num4 = -16;
					if (-17 < num5)
					{
						num4 = 16;
						if (num5 < 17)
						{
							num4 = num5;
						}
					}
					num4 = vr.z + num4;
					vr.z = num4;
					if (num < 0)
					{
						num = -num;
					}
					vr.y += num4 * 65536 >> 22;
					if (loop)
					{
						num += 1048576;
					}
					if (num < 2048000)
					{
						if (num2 < 0)
						{
							num2 = -num2;
						}
						if (loop)
						{
							num2 += 1048576;
						}
						if (2047999 < num2)
						{
							if (dAT_A.screen.y - 409600 < screen.y)
							{
								screen.y -= 3051;
							}
						}
						else
						{
							if ((GameManager.instance.DAT_28 & 0x1F) == 0)
							{
								Bomb obj = vData.ini.FUN_2C17C(219, typeof(Bomb), 0u) as Bomb;
								obj.type = 8;
								obj.flags |= 128u;
								obj.maxHalfHealth = 100;
								obj.id = id;
								obj.screen = screen;
								obj.vr.y = vr.y;
								num = vTransform.rotation.V02 * 7629;
								if (num < 0)
								{
									num += 4095;
								}
								obj.physics1.Z = num >> 12;
								num = vTransform.rotation.V22 * 7629;
								if (num < 0)
								{
									num += 4095;
								}
								obj.physics2.X = num >> 12;
								obj.physics1.W = 0;
								obj.FUN_3066C();
							}
							if (screen.y < dAT_A.screen.y - 143360)
							{
								screen.y += 1525;
							}
						}
					}
					else if (dAT_A.screen.y - 409600 < screen.y)
					{
						screen.y -= 3051;
					}
					if (dAT_A.maxHalfHealth != 0)
					{
						if (num3 < 0)
						{
							num3 = -num3;
						}
						if (num3 < 16385 || loop)
						{
							goto IL_0df0;
						}
					}
					tags = 0;
					GameManager.instance.FUN_30CB0(this, 600);
				}
				goto IL_0df0;
			}
			IL_0df0:
			num = vTransform.rotation.V02 * 7629;
			if (num < 0)
			{
				num += 4095;
			}
			num2 = vTransform.rotation.V22 * 7629;
			screen.x += num >> 12;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			screen.z += num2 >> 12;
			ApplyTransformation();
			if (arg2 == 0)
			{
				break;
			}
			vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id == 0)
				{
					vigObject.vr.z += arg2 * 256;
					vigObject.ApplyTransformation();
				}
				vigObject = vigObject.child;
			}
			num = (int)GameManager.instance.FUN_1E7A8(screen);
			GameManager.instance.FUN_1E2C8(DAT_18, (uint)(num << 1));
			break;
		}
		return 0u;
	}
}
