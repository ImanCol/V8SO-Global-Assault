using UnityEngine;

public class Tantrum : VigObject
{
	private static Vector3Int DAT_20 = new Vector3Int(0, 0, -32768);

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
		if (arg1 == 0)
		{
			FUN_42330(arg2);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint num;
		switch (arg1)
		{
		case 0:
		{
			int num2 = FUN_42330(arg2);
			num = 0u;
			if (0 >= num2)
			{
				break;
			}
			VigObject child2 = base.child2;
			VigTransform transform = GameManager.instance.FUN_2CDF4(child2);
			VigObject target = ((Vehicle)arg2).target;
			if (target == null)
			{
				child2.vr.y = (int)Mathf.Lerp(child2.vr.y, 0f, 0.2f);
				child2.vr.x = (int)Mathf.Lerp(child2.vr.x, 0f, 0.2f);
				child2.ApplyRotationMatrix();
				return 0u;
			}
			Vector3Int vector3Int = Utilities.FUN_24304(transform, target.screen);
			int num4 = (int)Utilities.Ratan2(vector3Int.x, vector3Int.z);
			int num7 = num4 << 20 >> 20;
			num4 = (int)Utilities.Ratan2(vector3Int.y, vector3Int.z);
			num4 = num4 * -1048576 >> 20;
			if (num7 < 0)
			{
				num7 += 3;
			}
			child2.vr.y += num7 >> 2;
			if (num4 < 0)
			{
				num4 += 3;
			}
			int num5 = child2.vr.x + (num4 >> 2);
			num4 = -341;
			if (-342 < num4)
			{
				num4 = 341;
				if (num5 < 342)
				{
					num4 = num5;
				}
			}
			child2.vr.x = num4;
			child2.ApplyTransformation();
			num = 0u;
			if (id != 0)
			{
				child2.child2.vr.z += 42;
				child2.child2.ApplyTransformation();
				num = 0u;
			}
			break;
		}
		case 1:
		{
			maxHalfHealth = 50;
			uint num3 = flags |= 16384u;
			num = 0u;
			break;
		}
		default:
			num = 0u;
			break;
		case 11:
		{
			vr.x = 0;
			uint num3 = flags &= 4261412863u;
			if (arg2 != null)
			{
				int param = GameManager.instance.FUN_1DD9C();
				Vector3Int param2 = GameManager.instance.FUN_2CE50(this);
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 48, param2);
			}
			num = 0u;
			break;
		}
		case 12:
		{
			VigObject child = base.child2;
			Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(9, typeof(Ballistic), 8u) as Ballistic;
			Utilities.ParentChildren(ballistic, ballistic);
			Tantrum2 tantrum = LevelManager.instance.FUN_42408(arg2, child, 2, typeof(Tantrum2), ballistic) as Tantrum2;
			Throwaway obj = vData.ini.FUN_2C17C(1, typeof(Throwaway), 0u) as Throwaway;
			num = 640u;
			if (vr.x == 0)
			{
				num = 1610613376u;
			}
			tantrum.maxHalfHealth = 20;
			if (((Vehicle)arg2).doubleDamage != 0)
			{
				tantrum.maxHalfHealth = 40;
			}
			tantrum.flags = num;
			tantrum.FUN_305FC();
			int num4 = arg2.physics1.X;
			if (num4 < 0)
			{
				num4 += 127;
			}
			tantrum.physics1.Z = (num4 >> 7) + tantrum.vTransform.rotation.V02 * 6;
			num4 = arg2.physics1.Y;
			if (num4 < 0)
			{
				num4 += 127;
			}
			tantrum.physics1.W = (num4 >> 7) + tantrum.vTransform.rotation.V12 * 6;
			num4 = arg2.physics1.Z;
			if (num4 < 0)
			{
				num4 += 127;
			}
			tantrum.physics2.X = (num4 >> 7) + tantrum.vTransform.rotation.V22 * 6;
			tantrum.physics2.M2 = 180;
			if ((arg2.flags & 4) == 0)
			{
				ballistic.FUN_30BF0();
			}
			ConfigContainer param3 = child.FUN_2C5F4(32769);
			obj.vTransform = GameManager.instance.FUN_2CEAC(child, param3);
			obj.type = 4;
			obj.flags = 160u;
			num4 = obj.vTransform.rotation.V02;
			obj.state = _THROWAWAY_TYPE.Unspawnable;
			obj.vCollider = null;
			if (num4 < 0)
			{
				num4 += 3;
			}
			int num5 = obj.vTransform.rotation.V12;
			obj.physics1.Z = num4 >> 2;
			if (num5 < 0)
			{
				num5 += 3;
			}
			num4 = obj.vTransform.rotation.V22;
			obj.physics1.W = num5 >> 2;
			if (num4 < 0)
			{
				num4 += 3;
			}
			obj.physics2.X = num4 >> 2;
			obj.DAT_87 = 2;
			obj.FUN_305FC();
			Vector3Int v = Utilities.FUN_24094(child.vTransform.rotation, DAT_20);
			arg2.FUN_2B1FC(v, screen);
			int param4;
			if ((flags & 0x2000000) == 0)
			{
				flags |= 33554432u;
				param4 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param4, vData.sndList, 2);
			}
			param4 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param4, vData.sndList, 3, tantrum.screen);
			short num6 = (short)(maxHalfHealth - 1);
			maxHalfHealth = (ushort)num6;
			if (num6 == 0)
			{
				FUN_3A368();
			}
			if (arg2.id < 0)
			{
				num = 12u;
				flags |= 67108864u;
				break;
			}
			num6 = (short)(vr.x + 1);
			vr.x = num6;
			if (num6 < 8)
			{
				num = 12u;
				flags |= 67108864u;
			}
			else
			{
				num = 180u;
				flags &= 4227858431u;
			}
			break;
		}
		case 13:
		{
			num = 0u;
			if (GameManager.instance.DAT_1084 != 0)
			{
				return 0u;
			}
			int num2 = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
			if (204799 < num2)
			{
				return 0u;
			}
			if (3050 < arg2.physics1.W)
			{
				return 0u;
			}
			num = 1u;
			break;
		}
		}
		return num;
	}
}
