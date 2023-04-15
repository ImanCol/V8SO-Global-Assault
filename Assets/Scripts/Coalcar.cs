public class Coalcar : TrainEngine2
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
		if (FUN_32CF0(hit))
		{
			GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 10, this);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			if (vMesh == null)
			{
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
			FUN_750();
			return 0u;
		case 1:
			FUN_6AC();
			break;
		case 2:
			FUN_4DC94();
			return 0u;
		case 8:
			if (FUN_32B90((uint)arg2))
			{
				GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 10, this);
				return 0u;
			}
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 10)
		{
			if (arg2.id != id)
			{
				return 0u;
			}
			flags |= 16777216u;
		}
		return 0u;
	}
}