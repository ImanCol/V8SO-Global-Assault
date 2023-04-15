public class Catwalk3 : VigObject
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
		if (FUN_32B90(hit.self.maxHalfHealth))
		{
			GameManager.instance.FUN_31924(10, id);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0u;
		}
		if (FUN_32B90((uint)arg2))
		{
			GameManager.instance.FUN_31924(10, id);
		}
		return 0u;
	}
}
