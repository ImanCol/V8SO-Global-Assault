using UnityEngine;

public class SmogPipe : VigObject
{
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
			FUN_42330(arg2);
			return 0u;
		case 11:
			vr.x = 0;
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		switch (arg1)
		{
		case 0:
			FUN_42330(arg2);
			return 0u;
		case 1:
			if (GameManager.instance.gameMode != _GAME_MODE.Versus2)
			{
				maxHalfHealth = 40;
			}
			else
			{
				maxHalfHealth = 50;
			}
			break;
		case 11:
			vr.x = 0;
			break;
		case 12:
		{
			ConfigContainer configContainer = FUN_2C5F4(32768);
			Smog smog = LevelManager.instance.xobfList[19].ini.FUN_2C17C(11, typeof(Smog), 8u) as Smog;
			smog.flags = 1610614676u;
			short id = arg2.id;
			smog.type = 8;
			smog.maxHalfHealth = 40;
			if (((Vehicle)arg2).doubleDamage != 0)
			{
				smog.maxHalfHealth = 80;
			}
			smog.DAT_80 = arg2;
			smog.id = id;
			if (configContainer == null)
			{
				VigTransform vigTransform = smog.vTransform = GameManager.instance.FUN_2CDF4(this);
			}
			else
			{
				smog.vTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
			}
			smog.screen = smog.vTransform.position;
			int num = arg2.physics1.X;
			if (num < 0)
			{
				num += 127;
			}
			smog.physics1.Z = (num >> 7) - (((ushort)smog.vTransform.rotation.V02 << 16 >> 16) - ((ushort)smog.vTransform.rotation.V02 << 16 >> 31) >> 1);
			num = arg2.physics1.Y;
			if (num < 0)
			{
				num += 127;
			}
			int num2 = smog.vTransform.rotation.V12 << 16;
			smog.physics1.W = (num >> 7) - ((num2 >> 16) - (num2 >> 31) >> 1);
			num = arg2.physics1.Z;
			if (num < 0)
			{
				num += 127;
			}
			smog.physics2.X = (num >> 7) - (((ushort)smog.vTransform.rotation.V22 << 16 >> 16) - ((ushort)smog.vTransform.rotation.V22 << 16 >> 31) >> 1);
			num = (int)GameManager.FUN_2AC5C();
			smog.physics2.M3 = (short)((num * 68 >> 15) - 34);
			smog.FUN_305FC();
			short num3 = (short)(vr.x + 1);
			vr.x = num3;
			if (num3 == 1)
			{
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param, vData.sndList, 2);
			}
			num3 = (short)(maxHalfHealth - 1);
			maxHalfHealth = (ushort)num3;
			if (num3 == 0)
			{
				FUN_3A368();
			}
			if (-1 < arg2.id && 19 < vr.x)
			{
				flags &= 4227858431u;
				return 180u;
			}
			flags |= 67108864u;
			return 10u;
		}
		case 13:
		{
			if (vr.x != 0)
			{
				if (vr.x >= 20)
				{
					return 0u;
				}
				return 1u;
			}
			if (GameManager.instance.DAT_1084 != 0)
			{
				return 0u;
			}
			Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
			if (-1 < vector3Int.z)
			{
				return 0u;
			}
			if (vector3Int.z < -307199)
			{
				return 0u;
			}
			int num = Utilities.Ratan2(vector3Int.x, vector3Int.z);
			num = num << 20 >> 20;
			if (num < 0)
			{
				num = -num;
			}
			if (1365 >= num)
			{
				return 0u;
			}
			return 1u;
		}
		}
		return 0u;
	}
}
