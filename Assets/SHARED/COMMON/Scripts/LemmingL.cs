public class LemmingL : VigObject
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
		VigObject child;
		if (arg1 == 0)
		{
			if (FUN_42330(arg2) == 0)
			{
				return 0u;
			}
			if (arg2 < 0)
			{
				return 0u;
			}
			child = child2;
			short x;
			if (DAT_19 < 30)
			{
				x = (short)(child.vr.x + 22);
			}
			else
			{
				if (DAT_19 < 61)
				{
					goto IL_0060;
				}
				x = (short)(child.vr.x - 22);
			}
			child.vr.x = x;
			goto IL_0060;
		}
		return 0u;
		IL_0060:
		if (arg2 != 0)
		{
			child.ApplyTransformation();
		}
		sbyte b = (sbyte)(DAT_19 + 1);
		DAT_19 = (byte)b;
		if (b != 91)
		{
			return 0u;
		}
		FUN_30BA8();
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int id = FUN_42330(arg2);
			return 0u;
		}
		case 1:
			maxHalfHealth = 3;
			flags |= 16384u;
			break;
		case 12:
			if ((flags & 0x80) == 0)
			{
				VigObject vigObject = child2.child2;
				Lemming lemming = vigObject.vData.ini.FUN_2C17C((ushort)vigObject.DAT_1A, typeof(Lemming), 0u) as Lemming;
				lemming.id = 3;
				lemming.vTransform = vigObject.vTransform;
				lemming.type = 8;
				lemming.maxHalfHealth = 100;
				if (((Vehicle)arg2).doubleDamage != 0)
				{
					lemming.maxHalfHealth = 200;
				}
				lemming.DAT_80 = arg2;
				lemming.flags |= 1610612768u;
				VigObject dAT_ = ((Vehicle)arg2).target;
				if (((Vehicle)arg2).target == null)
				{
					dAT_ = arg2;
				}
				lemming.DAT_84 = dAT_;
				lemming.physics2.M3 = 30;
				lemming.FUN_30B78();
				if (maxHalfHealth < 4)
				{
					VigObject obj = vigObject.FUN_2CCBC();
					vigObject.transform.parent = null;
					GameManager.instance.FUN_2C4B4(obj);
				}
				Utilities.FUN_2CC48(child2, lemming);
				Utilities.ParentChildren(child2, child2);
				GameManager.instance.DAT_1084++;
				maxHalfHealth--;
				DAT_19 = 0;
				FUN_30B78();
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param, vData.sndList, 2);
				if (-1 < arg2.id)
				{
					return 780u;
				}
				return 540u;
			}
			return 0u;
		case 13:
		{
			if (GameManager.instance.DAT_1084 != 0)
			{
				return 0u;
			}
			int id = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
			if (4095999 < id)
			{
				return 0u;
			}
			if (614400 >= id)
			{
				return 0u;
			}
			return 1u;
		}
		case 16:
		{
			int id = child2.child2.id;
			if (id != 0)
			{
				VigObject vigObject = arg2.child2.child2;
				for (short id2 = vigObject.id; id2 != id - 1; id2 = vigObject.id)
				{
					vigObject = vigObject.child;
				}
				VigObject obj = vigObject.FUN_2CCBC();
				vigObject.transform.parent = null;
				Utilities.FUN_2CC9C(child2, obj);
				Utilities.ParentChildren(child2, child2);
				return 0u;
			}
			break;
		}
		}
		return 0u;
	}
}
