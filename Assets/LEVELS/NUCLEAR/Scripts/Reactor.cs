using System.Collections.Generic;
using UnityEngine;

public class Reactor : VigObject
{
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
		if (hit.self.type != 8)
		{
			return 0u;
		}
		if (!FUN_32B90(hit.self.maxHalfHealth))
		{
			if (DAT_18 != 0)
			{
				GameManager.instance.FUN_1E30C(DAT_18, (maxFullHealth - maxHalfHealth) * 4999 / (int)maxFullHealth + 2298);
			}
			DAT_19 = (byte)((maxFullHealth - maxHalfHealth) * 5 / (int)maxFullHealth);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			if (arg2 != 0)
			{
				int num = (int)GameManager.instance.FUN_1E7A8(screen);
				if (num == 0)
				{
					if (DAT_18 == 0)
					{
						GameManager.instance.FUN_1DE78(0);
						DAT_18 = 0;
					}
				}
				else if (DAT_18 == 0)
				{
					sbyte param2 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E098(param2, vData.sndList, 0, (uint)num, param5: true);
					GameManager.instance.FUN_1E30C(DAT_18, (maxFullHealth - maxHalfHealth) * 4999 / (int)maxFullHealth + 2298);
				}
				else
				{
					GameManager.instance.FUN_1E2C8(DAT_18, (uint)num);
				}
			}
			child2.DAT_4A -= DAT_19;
			break;
		case 1:
			DAT_19 = 0;
			flags |= 128u;
			break;
		case 2:
			switch (tags++)
			{
			case 0:
			{
				List<VigTuple> worldObjs = GameManager.instance.worldObjs;
				for (int i = 0; i < worldObjs.Count; i++)
				{
					VigTuple vigTuple = worldObjs[i];
					if (vigTuple.vObject.type == 2 && vigTuple.vObject.maxHalfHealth != 0 && (vigTuple.vObject.flags & 0x4000000) == 0 && ((Vehicle)vigTuple.vObject).shield == 0)
					{
						((Vehicle)vigTuple.vObject).FUN_39BC4();
					}
				}
				ForkLift3 forkLift = LevelManager.instance.xobfList[42].ini.FUN_2C17C(27, typeof(ForkLift3), 8u) as ForkLift3;
				Utilities.ParentChildren(forkLift, forkLift);
				forkLift.type = 8;
				forkLift.flags = 788u;
				forkLift.screen = screen;
				forkLift.maxHalfHealth = 500;
				forkLift.FUN_3066C();
				forkLift.DAT_58 = forkLift.vCollider.reader.ReadInt32(16);
				UIManager.instance.FUN_4E338(new Color32(byte.MaxValue, 128, 64, 24));
				GameManager.instance.FUN_30CB0(this, 60);
				break;
			}
			case 1:
			{
				int param = 53;
				if (id == 98)
				{
					param = 51;
				}
				GameManager.instance.FUN_318D0(param).FUN_4DC94();
				param = 54;
				if (id == 98)
				{
					param = 52;
				}
				GameManager.instance.FUN_318D0(param).FUN_4DC94();
				break;
			}
			}
			break;
		case 8:
			if (!FUN_32B90((uint)arg2))
			{
				if (DAT_18 != 0)
				{
					GameManager.instance.FUN_1E30C(DAT_18, (maxFullHealth - maxHalfHealth) * 4999 / (int)maxFullHealth + 2298);
				}
				DAT_19 = (byte)((maxFullHealth - maxHalfHealth) * 5 / (int)maxFullHealth);
			}
			break;
		case 9:
			if (arg2 != 0)
			{
				FUN_30BA8();
				GameManager.instance.FUN_1DE78(DAT_18);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E14C(param, LevelManager.instance.xobfList[42].sndList, 1);
				param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E14C(param, LevelManager.instance.xobfList[42].sndList, 2);
				UIManager.instance.FUN_4E338(new Color32(byte.MaxValue, byte.MaxValue, 128, 8));
				Ballistic obj = LevelManager.instance.xobfList[42].ini.FUN_2C17C(33, typeof(Ballistic), 8u) as Ballistic;
				obj.screen = screen;
				obj.flags = 36u;
				obj.FUN_3066C();
				GameManager.instance.FUN_30CB0(this, 30);
			}
			break;
		}
		return 0u;
	}
}
