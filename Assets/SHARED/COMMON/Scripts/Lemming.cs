using System.Collections.Generic;
using UnityEngine;

public class Lemming : VigObject
{
	public bool cancel;

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
		GameManager.instance.FUN_2F798(this, hit);
		if (hit.self.type == 2)
		{
			Ballistic ballistic = vData.ini.FUN_2C17C(2, typeof(Ballistic), 8u) as Ballistic;
			ballistic.flags = 36u;
			ballistic.screen = screen;
			ballistic.vTransform.rotation = Utilities.FUN_2A5EC(hit.normal1);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 65, ballistic.screen);
			ballistic.FUN_305FC();
			tags = 1;
			uint num = flags |= 34u;
			GameManager.instance.FUN_30CB0(this, 75);
			return 0u;
		}
		if (hit.self.type == 3)
		{
			return 0u;
		}
		flags |= 256u;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		Vector3Int vin;
		Vector3Int vout;
		int num;
		Lemming3 lemming2;
		int param;
		uint num3;
		switch (arg1)
		{
		case 0:
		{
			if (tags == 0)
			{
				short m = physics2.M3;
				VigObject vigObject;
				if (physics2.M3 != 0)
				{
					physics2.M3 = (short)(m - 1);
					if (m != 1)
					{
						return 0u;
					}
					VigObject obj = Utilities.FUN_2CD78(this);
					vigObject = Utilities.FUN_2CD78(obj);
					Vehicle vehicle = Utilities.FUN_2CD78(vigObject) as Vehicle;
					if (vehicle != null)
					{
						VigObject vigObject2 = vData.ini.FUN_2C17C(1, typeof(VigObject), 8u);
						VigTransform vigTransform = vTransform = GameManager.instance.FUN_2CDF4(this);
						screen = vTransform.position;
						id = vehicle.id;
						VigObject vigObject3 = vehicle.target;
						if (vehicle.target == null)
						{
							vigObject3 = vehicle;
						}
						DAT_84 = vigObject3;
						int num4 = Utilities.FUN_29F6C(vTransform.position, vigObject3.vTransform.position);
						if (num4 < 0)
						{
							num4 += 255;
						}
						num4 >>= 8;
						int num5 = 4096;
						if (4095 < num4)
						{
							num5 = 8192;
							if (num4 < 8193)
							{
								num5 = num4;
							}
						}
						num4 = vehicle.physics1.X;
						if (num4 < 0)
						{
							num4 += 127;
						}
						int num6 = vTransform.rotation.V02 * num5;
						if (num6 < 0)
						{
							num6 += 4095;
						}
						physics1.Z = (num4 >> 7) + (num6 >> 12);
						num4 = vehicle.physics1.Y;
						if (num4 < 0)
						{
							num4 += 127;
						}
						num6 = vTransform.rotation.V12 * num5;
						if (num6 < 0)
						{
							num6 += 4095;
						}
						physics1.W = (num4 >> 7) + (num6 >> 12);
						int num7 = vehicle.physics1.Z;
						if (num7 < 0)
						{
							num7 += 127;
						}
						num5 = vTransform.rotation.V22 * num5;
						if (num5 < 0)
						{
							num5 += 4095;
						}
						physics2.X = (num7 >> 7) + (num5 >> 12);
						FUN_2CCBC();
						base.transform.parent = null;
						vigObject2.vTransform = GameManager.FUN_2A39C();
						ConfigContainer configContainer = FUN_2C5F4(32768);
						vigObject2.vTransform.position = configContainer.v3_1;
						Utilities.FUN_2CC9C(this, vigObject2);
						Utilities.ParentChildren(this, this);
						FUN_30BF0();
						GameManager.instance.FUN_30080(GameManager.instance.worldObjs, this);
						if (vigObject.maxHalfHealth == 0)
						{
							vigObject.FUN_3A368();
						}
						param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E580(param, vigObject.vData.sndList, 3, vTransform.position);
						return 0u;
					}
					obj = FUN_2CCBC();
					GameManager.instance.FUN_308C4(obj);
					return uint.MaxValue;
				}
				screen.x += physics1.Z;
				screen.y += physics1.W;
				screen.z += physics2.X;
				vTransform.position = screen;
				vigObject = DAT_84;
				physics1.W += 42;
				vin = default(Vector3Int);
				vin.x = vigObject.vTransform.position.x - screen.x;
				vin.y = vigObject.vTransform.position.y - screen.y;
				vin.z = vigObject.vTransform.position.z - screen.z;
				long num8 = (long)physics1.W * (long)physics1.W;
				num3 = (uint)(vin.y * 112);
				uint num9 = (uint)((int)num8 + (int)num3);
				num = (int)((ulong)num8 >> 32) + ((int)num3 >> 31) + ((num9 < num3) ? 1 : 0);
				if (!cancel)
				{
					if ((vigObject.flags & 0x4000000) == 0 && -1 < num)
					{
						int num7 = Utilities.FUN_2ABC4(num9, num);
						num7 -= physics1.W;
						num = num7;
						if (num7 < 0)
						{
							num = -num7;
						}
						if (256 < num)
						{
							num = vin.x * 56 / num7 - physics1.Z;
							if (num < 0)
							{
								num += 15;
							}
							physics1.Z += num >> 4;
							num = vin.z * 56 / num7 - physics2.X;
							if (num < 0)
							{
								num += 15;
							}
							physics2.X += num >> 4;
							goto IL_0520;
						}
					}
					cancel = true;
				}
				goto IL_0520;
			}
			if (tags != 1)
			{
				return 0u;
			}
			List<VigTuple> worldObjs = GameManager.instance.worldObjs;
			for (int l = 0; l < worldObjs.Count; l++)
			{
				VigTuple vigTuple = worldObjs[l];
				VigObject vObject = vigTuple.vObject;
				if (vObject.type == 2 && (vObject.flags & 0x4000000) == 0 && vObject.maxHalfHealth != 0)
				{
					vObject.flags |= 134217728u;
					vObject = vigTuple.vObject;
					vObject.screen = DAT_84.vTransform.position;
				}
			}
			break;
		}
		case 2:
			GameManager.instance.FUN_309A0(this);
			GameManager.instance.DAT_1084--;
			return uint.MaxValue;
		case 4:
			{
				List<VigTuple> worldObjs = GameManager.instance.worldObjs;
				for (int i = 0; i < worldObjs.Count; i++)
				{
					VigTuple vigTuple = worldObjs[i];
					VigObject vObject = vigTuple.vObject;
					if (vObject.type == 2 && vObject.maxHalfHealth != 0)
					{
						vObject.flags &= 4160749567u;
					}
				}
				break;
			}
			IL_0520:
			vin = new Vector3Int(physics1.Z, physics1.W, physics2.X);
			Utilities.FUN_29FC8(vin, out vout);
			vTransform.rotation = Utilities.FUN_2A724(vout);
			num = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
			if (vTransform.position.y <= num)
			{
				if (physics1.W < 1)
				{
					ushort num2 = (ushort)physics2.M2;
					physics2.M2 = (short)(num2 + 1);
					if ((num2 & 0xF) == 0)
					{
						List<VigTuple> worldObjs = GameManager.instance.worldObjs;
						for (int j = 0; j < worldObjs.Count; j++)
						{
							VigTuple vigTuple = worldObjs[j];
							VigObject vObject = vigTuple.vObject;
							if (vObject.type == 2 && (vObject.flags & 0x4000000) == 0 && vObject.maxHalfHealth != 0 && (vObject == DAT_84 || vObject == DAT_80))
							{
								vObject.flags |= 134217728u;
								vObject = vigTuple.vObject;
								vObject.screen = screen;
							}
							else
							{
								if (vObject.type != 8 || vObject.id == id || !(vObject.DAT_84 == DAT_80))
								{
									continue;
								}
								if (vObject.GetType() == typeof(Shell))
								{
									if (vObject.physics2.M2 > 10)
									{
										vObject.id = id;
										vObject.DAT_80 = DAT_80;
										vObject.DAT_84 = DAT_84;
									}
								}
								else if (vObject.GetType() == typeof(Missile))
								{
									if (vObject.physics2.M2 < 460 && ((Missile)vObject).state == _MISSILE_TYPE.Projectile)
									{
										vObject.id = id;
										vObject.DAT_80 = DAT_80;
										vObject.DAT_84 = DAT_84;
									}
								}
								else if (vObject.GetType() == typeof(Saucer) || vObject.GetType() == typeof(StarPower2) || vObject.GetType() == typeof(Tornado))
								{
									vObject.id = id;
									vObject.DAT_80 = DAT_80;
									vObject.DAT_84 = DAT_84;
								}
								else if (vObject.GetType() == typeof(GloryRocket) && vObject.physics2.M2 > 30)
								{
									vObject.id = id;
									vObject.DAT_80 = DAT_80;
									vObject.DAT_84 = DAT_84;
								}
							}
						}
					}
				}
				else
				{
					List<VigTuple> worldObjs = GameManager.instance.worldObjs;
					for (int k = 0; k < worldObjs.Count; k++)
					{
						VigTuple vigTuple = worldObjs[k];
						VigObject vObject = vigTuple.vObject;
						if (vObject.type == 2 && (vObject.flags & 0x4000000) == 0 && vObject.maxHalfHealth != 0 && (vObject == DAT_84 || vObject == DAT_80))
						{
							vObject.flags |= 134217728u;
							vObject = vigTuple.vObject;
							vObject.screen = DAT_84.vTransform.position;
						}
					}
				}
				if ((physics2.M2 & 7) != 0)
				{
					return 0u;
				}
				Lemming2 lemming = LevelManager.instance.xobfList[19].ini.FUN_2C17C(7, typeof(Lemming2), 8u) as Lemming2;
				Utilities.ParentChildren(lemming, lemming);
				lemming.type = 4;
				lemming.flags = 1204u;
				lemming.screen = screen;
				lemming.vr.z = physics2.M2 * 96;
				num = vTransform.rotation.V02 * -341;
				if (num < 0)
				{
					num += 4095;
				}
				lemming.physics1.Z = num >> 12;
				num = vTransform.rotation.V12 * -341;
				if (num < 0)
				{
					num += 4095;
				}
				lemming.physics1.W = num >> 12;
				num = vTransform.rotation.V22 * -341;
				if (num < 0)
				{
					num += 4095;
				}
				lemming.physics2.X = num >> 12;
				lemming.FUN_3066C();
				return 0u;
			}
			lemming2 = (vData.ini.FUN_2C17C(2, typeof(Lemming3), 8u, typeof(VigChild)) as Lemming3);
			Utilities.ParentChildren(lemming2, lemming2);
			lemming2.type = 8;
			lemming2.flags = 1610612740u;
			lemming2.id = id;
			lemming2.screen = screen;
			lemming2.maxHalfHealth = (ushort)((int)maxHalfHealth / 25);
			lemming2.DAT_80 = DAT_80;
			lemming2.FUN_2D114(lemming2.screen, ref lemming2.vTransform);
			UIManager.instance.FUN_4E414(lemming2.screen, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 8));
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 65, lemming2.screen);
			lemming2.FUN_305FC();
			tags = 1;
			num3 = (flags |= 2u);
			GameManager.instance.FUN_30CB0(this, 75);
			return 0u;
		}
		return 0u;
	}
}
