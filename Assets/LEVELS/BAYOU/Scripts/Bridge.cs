public class Bridge : VigObject
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
		FUN_32B90(hit.self.maxHalfHealth);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			return 0u;
		}
		if (arg1 == 9 && arg2 == 0)
		{
			if (screen.z == 83230512)
			{
				LevelManager.instance.FUN_359FC(53215232, 82575360, 0u);
				return 0u;
			}
			if (screen.z == 84476112)
			{
				LevelManager.instance.FUN_359FC(53280768, 85065728, 0u);
				return 0u;
			}
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		FUN_32B90((uint)arg2);
		return 0u;
	}
}
