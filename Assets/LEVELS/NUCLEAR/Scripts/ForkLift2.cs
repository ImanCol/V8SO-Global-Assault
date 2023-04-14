using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _FORKLIFT2_TYPE
{
    Default,
    Type1 //FUN_2640 (NUCLEAR.DLL)
}

public class ForkLift2 : VigObject
{
	public _FORKLIFT2_TYPE state;

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
		if (hit.self.type == 3)
		{
			return 0u;
		}
		FUN_4DC94();
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (state == _FORKLIFT2_TYPE.Type1)
		{
			if (arg1 != 2)
			{
				if (arg1 < 3)
				{
					if (arg1 != 0)
					{
						return 0u;
					}
					vCollider.reader.Seek(4L, SeekOrigin.Current);
					FUN_2B4F8(vCollider.reader);
					vCollider.reader.Seek(-4L, SeekOrigin.Current);
					return 0u;
				}
				switch (arg1)
				{
				default:
					return 0u;
				case 9:
					if (arg2 == 0)
					{
						Vector3Int vector3Int = GameManager.instance.FUN_2CE50(this);
						ForkLift3 forkLift = LevelManager.instance.xobfList[42].ini.FUN_2C17C(26, typeof(ForkLift3), 8u) as ForkLift3;
						Utilities.ParentChildren(forkLift, forkLift);
						short num = forkLift.id = ((!(parent == null)) ? Utilities.FUN_2CD78(this).id : id);
						forkLift.type = 8;
						forkLift.flags |= 788u;
						forkLift.screen = vector3Int;
						forkLift.maxHalfHealth = 150;
						forkLift.FUN_3066C();
						forkLift.DAT_58 = forkLift.vCollider.reader.ReadInt32(16);
						LevelManager.instance.FUN_4DE54(vector3Int, 140);
						int param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E5D4(param, LevelManager.instance.xobfList[42].sndList, 2, vector3Int);
						return 0u;
					}
					if (parent != null)
					{
						VigObject param2 = FUN_2CCBC();
						GameManager.instance.FUN_307CC(param2);
						return uint.MaxValue;
					}
					GameManager.instance.FUN_309A0(this);
					return uint.MaxValue;
				case 3:
					break;
				}
			}
			FUN_4DC94();
			return 0u;
		}
		return 0u;
	}
}
