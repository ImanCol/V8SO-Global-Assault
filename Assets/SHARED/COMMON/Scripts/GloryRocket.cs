using UnityEngine;

public class GloryRocket : VigObject
{
	private static int DAT_30;

	private static int DAT_38;

	private static int DAT_3C = 0;

	private static int DAT_34 = 65536;

	public static int[] DAT_1510 = new int[9]
	{
		171,
		170,
		169,
		157,
		166,
		154,
		162,
		160,
		164
	};

	public static Color32[] DAT_1534 = new Color32[3]
	{
		new Color32(127, 127, 127, 8),
		new Color32(127, 0, 0, 8),
		new Color32(0, 0, 127, 8)
	};

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
		if (hit.self.type == 3)
		{
			return 0u;
		}
		FUN_730();
		GameManager.instance.FUN_309A0(this);
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			FUN_730();
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		Vector3Int v;
		int num7;
		if (arg1 < 3)
		{
			if (arg1 != 0)
			{
				return 0u;
			}
			short m = physics2.M3;
			VigObject vigObject;
			if (physics2.M3 != 0)
			{
				physics2.M3 = (short)(m - 1);
				if (m != 1)
				{
					return 0u;
				}
				vigObject = Utilities.FUN_2CD78(this);
				Vehicle vehicle = Utilities.FUN_2CD78(vigObject) as Vehicle;
				v = new Vector3Int(DAT_30, DAT_34, DAT_38);
				int dAT_3C = DAT_3C;
				if (vehicle != null)
				{
					VigObject vigObject2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C((ushort)DAT_1510[DAT_19 + 3], typeof(VigObject), 8u);
					VigTransform vigTransform = vTransform = GameManager.instance.FUN_2CDF4(this);
					screen = vTransform.position;
					id = vehicle.id;
					VigObject vigObject3 = vehicle.target;
					if (vehicle.target == null)
					{
						vigObject3 = vehicle;
					}
					DAT_84 = vigObject3;
					int num = Utilities.FUN_29F6C(vTransform.position, vigObject3.vTransform.position);
					if (num < 0)
					{
						num += 255;
					}
					num >>= 8;
					int num2 = 4096;
					if (4095 < num)
					{
						num2 = 12288;
						if (num < 12289)
						{
							num2 = num;
						}
					}
					num = vehicle.physics1.X;
					if (num < 0)
					{
						num += 127;
					}
					int num3 = vTransform.rotation.V02 * num2;
					if (num3 < 0)
					{
						num3 += 4095;
					}
					physics1.Z = (num >> 7) + (num3 >> 12);
					num = vehicle.physics1.Y;
					if (num < 0)
					{
						num += 127;
					}
					num3 = vTransform.rotation.V12 * num2;
					if (num3 < 0)
					{
						num3 += 4095;
					}
					physics1.W = (num >> 7) + (num3 >> 12);
					num = vehicle.physics1.Z;
					if (num < 0)
					{
						num += 127;
					}
					num2 = vTransform.rotation.V22 * num2;
					if (num2 < 0)
					{
						num2 += 4095;
					}
					physics2.X = (num >> 7) + (num2 >> 12);
					FUN_2CCBC();
					base.transform.parent = null;
					FUN_2D1DC();
					vigObject2.vTransform = GameManager.FUN_2A39C();
					ConfigContainer configContainer = FUN_2C5F4(32768);
					vigObject2.vTransform.position = configContainer.v3_1;
					Utilities.FUN_2CC9C(this, vigObject2);
					Utilities.ParentChildren(this, this);
					FUN_30BF0();
					GameManager.instance.FUN_30080(GameManager.instance.worldObjs, this);
					if (!GameManager.instance.experimentalDakota)
					{
						if (vigObject.maxHalfHealth == 0 && DAT_19 == 2)
						{
							vigObject.FUN_3A368();
						}
					}
					else if (vigObject.maxHalfHealth == 0)
					{
						vigObject.FUN_3A368();
					}
					num = (int)GameManager.FUN_2AC5C();
					screen.x = (num * 81920 >> 15) - 40960;
					screen.y = 0;
					num = (int)GameManager.FUN_2AC5C();
					screen.z = (num * 81920 >> 15) - 40960;
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param, vigObject.vData.sndList, 3, vTransform.position);
					v = Utilities.FUN_24094(vigObject.vTransform.rotation, v);
					vehicle.FUN_2B1FC(v, screen);
					return 0u;
				}
				VigObject param2 = FUN_2CCBC();
				base.transform.parent = null;
				GameManager.instance.FUN_308C4(param2);
				return uint.MaxValue;
			}
			vTransform.position.x += physics1.Z;
			vTransform.position.y += physics1.W;
			vTransform.position.z += physics2.X;
			vigObject = DAT_84;
			physics1.W += 42;
			Vector3Int vector3Int = default(Vector3Int);
			vector3Int.x = vigObject.screen.x + screen.x;
			vector3Int.y = vigObject.screen.y + screen.y;
			vector3Int.z = vigObject.screen.z + screen.z;
			v = default(Vector3Int);
			v.x = vector3Int.x - vTransform.position.x;
			v.y = vector3Int.y - vTransform.position.y;
			v.z = vector3Int.z - vTransform.position.z;
			long num4 = (long)physics1.W * (long)physics1.W;
			uint num5 = (uint)(v.y * 56);
			uint num6 = (uint)((int)num4 + (int)num5);
			num7 = (int)((ulong)num4 >> 32) + ((int)num5 >> 31) + ((num6 < num5) ? 1 : 0);
			if (!cancel)
			{
				if ((vigObject.flags & 0x4000000) == 0 && -1 < num7)
				{
					int num8 = Utilities.FUN_2ABC4(num6, num7);
					num8 -= physics1.W;
					num7 = num8;
					if (num8 < 0)
					{
						num7 = -num8;
					}
					if (256 < num7)
					{
						num7 = v.x * 56 / num8 - physics1.Z;
						if (num7 < 0)
						{
							num7 += 31;
						}
						physics1.Z += num7 >> 5;
						num7 = v.z * 56 / num8 - physics2.X;
						if (num7 < 0)
						{
							num7 += 31;
						}
						physics2.X += num7 >> 5;
						goto IL_062f;
					}
				}
				cancel = true;
			}
			goto IL_062f;
		}
		if (arg1 != 4)
		{
			return 0u;
		}
		GameManager.instance.DAT_1084--;
		goto IL_07b6;
		IL_07b6:
		return 0u;
		IL_062f:
		v.x = physics1.Z;
		v.y = physics1.W;
		v.z = physics2.X;
		Utilities.FUN_29FC8(v, out Vector3Int vout);
		VigTransform vigTransform2 = GameManager.FUN_2A39C();
		num7 = (ushort)vr.z + (ushort)vr.x;
		vr.z = num7;
		FUN_1370(num7 * 1048576 >> 20, ref vigTransform2.rotation);
		vTransform.rotation = Utilities.FUN_2A724(vout);
		vTransform.rotation = Utilities.FUN_247C4(vTransform.rotation, vigTransform2.rotation);
		if (-1 < physics1.W)
		{
			int num8 = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
			num7 = num8;
			if (vTransform.position.z < GameManager.instance.DAT_DA0)
			{
				num7 = GameManager.instance.DAT_DB0;
				if (num8 < GameManager.instance.DAT_DB0)
				{
					num7 = num8;
				}
			}
			if (num7 < vTransform.position.y + 51200)
			{
				FUN_730();
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
		}
		physics2.M2++;
		goto IL_07b6;
	}

	private static void FUN_1370(int param1, ref Matrix3x3 param2)
	{
		int num2;
		int num;
		if (param1 < 0)
		{
			num = Utilities.DAT_65C90[(-param1 & 0xFFF) * 2];
			num2 = -(short)num;
		}
		else
		{
			num = Utilities.DAT_65C90[(param1 & 0xFFF) * 2];
			num2 = -(short)num;
		}
		num >>= 16;
		short v = param2.V00;
		short v2 = param2.V01;
		short v3 = param2.V02;
		param2.V00 = (short)(num * v - num2 * param2.V10 >> 12);
		param2.V01 = (short)(num * v2 - num2 * param2.V11 >> 12);
		param2.V02 = (short)(num * v3 - num2 * param2.V12 >> 12);
		param2.V10 = (short)(num2 * v + num * param2.V10 >> 12);
		param2.V11 = (short)(num2 * v2 + num * param2.V11 >> 12);
		param2.V12 = (short)(num2 * v3 + num * param2.V12 >> 12);
	}

	private void FUN_730()
	{
		int num = 0;
		int num2 = 0;
		do
		{
			Fireworks fireworks = LevelManager.instance.xobfList[19].ini.FUN_2C17C((ushort)DAT_1510[DAT_19 + 6], typeof(Fireworks), 8u, typeof(VigChild)) as Fireworks;
			Utilities.ParentChildren(fireworks, fireworks);
			VigChild vigChild = fireworks.child2 as VigChild;
			while (vigChild != null)
			{
				vigChild.state = _CHILD_TYPE.Default;
				vigChild = (vigChild.child2 as VigChild);
			}
			VigObject dAT_ = DAT_80;
			fireworks.type = 8;
			fireworks.flags = 1610612738u;
			fireworks.DAT_80 = dAT_;
			fireworks.id = id;
			fireworks.DAT_19 = DAT_19;
			fireworks.screen = vTransform.position;
			int num3;
			if (num != 0)
			{
				num3 = (int)GameManager.FUN_2AC5C();
				fireworks.screen.x = fireworks.screen.x - 92160 + (num3 * 184320 >> 15);
				num3 = (int)GameManager.FUN_2AC5C();
				fireworks.screen.y = fireworks.screen.y - (num3 * 81920 >> 15);
				num3 = (int)GameManager.FUN_2AC5C();
				fireworks.screen.z = fireworks.screen.z - 92160 + (num3 * 184320 >> 15);
			}
			num3 = GameManager.instance.terrain.FUN_1B750((uint)fireworks.screen.x, (uint)fireworks.screen.z);
			if (num3 - 30720 < fireworks.screen.y)
			{
				fireworks.screen.y = num3 - 30720;
			}
			fireworks.maxHalfHealth = 75;
			fireworks.FUN_3066C();
			GameManager.instance.FUN_30CB0(fireworks, num2);
			num++;
			num2 += 15;
		}
		while (num < 3);
		UIManager.instance.FUN_4E414(vTransform.position, DAT_1534[DAT_19]);
		int num4 = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E5D4(num4, vData.sndList, 4, vTransform.position);
		num = (int)GameManager.FUN_2AC5C();
		GameManager.instance.FUN_1E30C(num4, (num << 10 >> 15) + 3584);
	}
}
