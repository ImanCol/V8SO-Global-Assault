using System;
using System.Collections.Generic;

public class Disco : VigObject
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
			break;
		case 4:
			GameManager.instance.DAT_1084--;
			break;
		case 10:
		{
			if (arg2 != 5170)
			{
				break;
			}
			Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
			if (vehicle == null || id != 0)
			{
				return 0u;
			}
			ConfigContainer configContainer = FUN_2C5F4(32768);
			Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
			dictionary.Add(vData.ini.GetContainerIndex(4, 0), typeof(Disco3));
			dictionary.Add(vData.ini.GetContainerIndex(4, 2), typeof(Disco3));
			Disco2 disco = vData.ini.FUN_2C17C(4, typeof(Disco2), 8u, dictionary) as Disco2;
			Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(1, typeof(Ballistic), 8u) as Ballistic;
			disco.id = vehicle.id;
			disco.tags = 1;
			disco.screen = configContainer.v3_1;
			Disco3 disco2 = disco.child2 as Disco3;
			disco.maxHalfHealth = 28;
			if (vehicle.doubleDamage != 0)
			{
				disco.maxHalfHealth = 56;
			}
			disco.physics1.W -= 2048;
			VigObject target = vehicle.target;
			disco.DAT_80 = vehicle;
			disco.DAT_84 = target;
			while (disco2 != null)
			{
				if ((disco2.flags & 0x10) != 0)
				{
					disco2.flags |= 1024u;
				}
				disco2 = (disco2.child as Disco3);
			}
			disco.FUN_2D1DC();
			disco.FUN_30B78();
			Utilities.FUN_2CC48(this, disco);
			ballistic.flags |= 16u;
			Utilities.FUN_2CA94(this, configContainer, ballistic);
			Utilities.ParentChildren(this, this);
			child2.FUN_2C05C();
			id = 690;
			uint result = 690u;
			maxHalfHealth--;
			flags |= 134217728u;
			GameManager.instance.DAT_1084++;
			if (vehicle.id < 0)
			{
				id = 480;
				result = 480u;
			}
			return result;
		}
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
					maxHalfHealth = 3;
					flags |= 16384u;
				}
				goto IL_0049;
			}
			FUN_42330(arg2);
			result = 0u;
		}
		else if (arg1 != 5)
		{
			if (arg1 != 12)
			{
				if (arg1 != 13)
				{
					goto IL_0049;
				}
				result = 0u;
				if (GameManager.instance.DAT_1084 == 0)
				{
					int num = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
					if (num < 1228800)
					{
						result = ((204800 < num) ? 1u : 0u);
					}
				}
			}
			else
			{
				ConfigContainer configContainer = FUN_2C5F4(32768);
				Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
				dictionary.Add(vData.ini.GetContainerIndex(4, 0), typeof(Disco3));
				dictionary.Add(vData.ini.GetContainerIndex(4, 2), typeof(Disco3));
				Disco2 disco = vData.ini.FUN_2C17C(4, typeof(Disco2), 8u, dictionary) as Disco2;
				Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(1, typeof(Ballistic), 8u) as Ballistic;
				disco.id = arg2.id;
				disco.screen = configContainer.v3_1;
				Disco3 disco2 = disco.child2 as Disco3;
				disco.maxHalfHealth = 28;
				if (((Vehicle)arg2).doubleDamage != 0)
				{
					disco.maxHalfHealth = 56;
				}
				disco.physics1.W -= 2048;
				VigObject target = ((Vehicle)arg2).target;
				disco.DAT_80 = arg2;
				disco.DAT_84 = target;
				while (disco2 != null)
				{
					if ((disco2.flags & 0x10) != 0)
					{
						disco2.flags |= 1024u;
					}
					disco2 = (disco2.child as Disco3);
				}
				disco.FUN_2D1DC();
				disco.FUN_30B78();
				Utilities.FUN_2CC48(this, disco);
				ballistic.flags |= 16u;
				Utilities.FUN_2CA94(this, configContainer, ballistic);
				Utilities.ParentChildren(this, this);
				child2.FUN_2C05C();
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param, vData.sndList, 2);
				result = 540u;
				maxHalfHealth--;
				flags |= 134217728u;
				GameManager.instance.DAT_1084++;
				if (arg2.id < 0)
				{
					result = 360u;
				}
			}
		}
		else
		{
			child2.vAnim = null;
			FUN_30C20();
			result = uint.MaxValue;
		}
		goto IL_02b3;
		IL_02b3:
		return result;
		IL_0049:
		result = 0u;
		goto IL_02b3;
	}
}
