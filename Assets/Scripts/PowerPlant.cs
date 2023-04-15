public class PowerPlant : Destructible
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
		bool num = FUN_32CF0(hit);
		uint result = 0u;
		if (num)
		{
			VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(id + 1000);
			if (vigTuple != null)
			{
				LevelManager.instance.FUN_359CC(vigTuple.array, 0u);
			}
			result = uint.MaxValue;
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0u;
		}
		bool num = FUN_32B90((uint)arg2);
		uint result = 0u;
		if (num)
		{
			VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(id + 1000);
			if (vigTuple != null)
			{
				LevelManager.instance.FUN_359CC(vigTuple.array, 0u);
			}
			result = uint.MaxValue;
		}
		return result;
	}
}