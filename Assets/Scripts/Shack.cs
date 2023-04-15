public class Shack : VigObject
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
		bool num = FUN_32B90(hit.self.maxHalfHealth);
		uint result = 0u;
		if (num)
		{
			VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(id);
			if (vigTuple != null)
			{
				LevelManager.instance.FUN_359CC(vigTuple.array, 36736u);
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
			VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(id);
			if (vigTuple != null)
			{
				LevelManager.instance.FUN_359CC(vigTuple.array, 36736u);
			}
			result = uint.MaxValue;
		}
		return result;
	}
}