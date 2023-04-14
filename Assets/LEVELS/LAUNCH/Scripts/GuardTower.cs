using System;
using System.Collections.Generic;

public class GuardTower : Destructible
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
		return base.OnCollision(hit);
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2, uint arg3)
	{
		Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
		dictionary.Add(849, typeof(GuardTower2));
		return arg1.ini.FUN_2C17C((ushort)arg2, typeof(GuardTower), arg3, dictionary);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			VigObject vigObject = child2;
			if (!(vigObject != null))
			{
				break;
			}
			while (vigObject.id != 1)
			{
				vigObject = vigObject.child;
				if (!(vigObject != null))
				{
					break;
				}
			}
			if (vigObject != null)
			{
				((GuardTower2)vigObject).state = _GUARDTOWER2_TYPE.Type1;
				GameManager.instance.FUN_30CB0(vigObject, 8);
			}
			break;
		}
		case 8:
			FUN_32B90((uint)arg2);
			break;
		}
		return 0u;
	}
}
