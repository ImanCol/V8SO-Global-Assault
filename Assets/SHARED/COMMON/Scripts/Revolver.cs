using UnityEngine;

public class Revolver : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2)
	{
		return arg1.ini.FUN_2C17C((ushort)arg2, typeof(Revolver), 8u, typeof(Revolver2));
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
		uint result;
		if (arg1 <= 1)
		{
			if (arg1 != 0)
			{
				if (arg1 == 1)
				{
					maxHalfHealth = 6;
				}
				goto IL_0032;
			}
			FUN_42330(arg2);
			result = 0u;
		}
		else if (arg1 != 12)
		{
			if (arg1 != 13)
			{
				goto IL_0032;
			}
			Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
			result = 0u;
			if ((uint)(vector3Int.z - 1) < 511999u)
			{
				if (vector3Int.x < 0)
				{
					vector3Int.x = -vector3Int.x;
				}
				result = ((vector3Int.x << 3 < vector3Int.z) ? 1u : 0u);
			}
		}
		else
		{
			bool flag = (GameManager.FUN_2AC5C() & 3) == 0;
			Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(3, typeof(Ballistic), 8u) as Ballistic;
			int num = 3;
			if (flag)
			{
				num = 2;
			}
			Revolver3 revolver = LevelManager.instance.FUN_42408(arg2, this, (ushort)num, typeof(Revolver3), ballistic) as Revolver3;
			Vector3Int v = default(Vector3Int);
			v.x = 0;
			v.y = 0;
			if (flag)
			{
				v.z = -1572864;
			}
			else
			{
				v.z = -65536;
			}
			revolver.flags = 1610612868u;
			revolver.tags = (sbyte)(flag ? 1 : 0);
			ushort num2 = revolver.maxHalfHealth = (ushort)((!flag) ? 250 : 450);
			if (((Vehicle)arg2).doubleDamage != 0)
			{
				revolver.maxHalfHealth = (ushort)(num2 * 2);
			}
			revolver.physics2.M2 = 60;
			int num3 = arg2.physics1.X;
			if (num3 < 0)
			{
				num3 += 127;
			}
			revolver.physics1.Z = (num3 >> 7) + revolver.vTransform.rotation.V02 * 6;
			num3 = arg2.physics1.Y;
			if (num3 < 0)
			{
				num3 += 127;
			}
			revolver.physics1.W = (num3 >> 7) + revolver.vTransform.rotation.V12 * 6;
			num3 = arg2.physics1.Z;
			if (num3 < 0)
			{
				num3 += 127;
			}
			revolver.physics2.X = (num3 >> 7) + revolver.vTransform.rotation.V22 * 6;
			revolver.FUN_305FC();
			GameManager.instance.FUN_30CB0(revolver, 120);
			ballistic.FUN_30BF0();
			if ((child2.flags & 0x80) == 0)
			{
				child2.FUN_30B78();
			}
			child2.maxHalfHealth = 90;
			arg2.FUN_2B1FC(v, screen);
			num = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(num, vData.sndList, 3, revolver.screen);
			num = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(num, vData.sndList, 2);
			if (arg2.id < 0)
			{
				GameManager.instance.FUN_15B00(~arg2.id, byte.MaxValue, (byte)((flag ? 1 : 0) << 5), 64);
			}
			short num4 = (short)(maxHalfHealth - 1);
			maxHalfHealth = (ushort)num4;
			result = 60u;
			if (num4 == 0)
			{
				FUN_3A368();
				result = 60u;
			}
		}
		goto IL_033c;
		IL_0032:
		result = 0u;
		goto IL_033c;
		IL_033c:
		return result;
	}
}
