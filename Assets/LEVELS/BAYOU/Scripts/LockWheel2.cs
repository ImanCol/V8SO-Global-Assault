using UnityEngine;

public class LockWheel2 : VigObject
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
		case 2:
			FUN_30B78();
			tags = 1;
			break;
		case 0:
			if (tags == 0)
			{
				GameManager.instance.DAT_DB0 -= 68;
				if (GameManager.instance.DAT_DB0 < 2979840)
				{
					GameManager.instance.FUN_30CB0(this, 300);
					FUN_30BA8();
				}
				break;
			}
			GameManager.instance.DAT_DB0 += 68;
			if (3092480 < GameManager.instance.DAT_DB0)
			{
				VigObject child = base.child;
				VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(child.id);
				if (vigTuple != null)
				{
					LevelManager.instance.FUN_359CC(vigTuple.array, 36736u);
				}
				child.ApplyTransformation();
				child.tags = 0;
				VigObject pDAT_ = child.PDAT_74;
				pDAT_.ApplyTransformation();
				pDAT_.tags = 0;
				UnityEngine.Object.Destroy(FUN_306FC());
			}
			break;
		case 4:
			LevelManager.instance.level.flags &= 4278190079u;
			break;
		}
		return 0u;
	}
}
