public class Lightning3 : VigObject
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
		if (arg1 == 4)
		{
			if ((flags & 0x2000000) == 0 && PDAT_78 != null)
			{
				if (!(((Lightning2)PDAT_78).DAT_88 == null))
				{
					((Lightning2)PDAT_78).DAT_94++;
					return 0u;
				}
				flags |= 16777216u;
				VigObject param = PDAT_78.FUN_2CCBC();
				GameManager.instance.FUN_308C4(param);
				PDAT_78 = null;
			}
			if (PDAT_74 != null && GameManager.instance.FUN_30134(GameManager.instance.worldObjs, PDAT_74) != null)
			{
				PDAT_74.flags &= 4227858431u;
				((Vehicle)PDAT_74).DAT_F6 &= 65023;
				PDAT_74 = null;
			}
		}
		return 0u;
	}
}
