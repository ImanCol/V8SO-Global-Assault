public class Bridge2 : Destructible
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
			LevelManager.instance.FUN_518DC(screen, 0).DAT_08 = ushort.MaxValue;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			vMesh.DAT_02 = 20;
			return 0u;
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		if (FUN_32B90((uint)arg2))
		{
			LevelManager.instance.FUN_518DC(screen, 0).DAT_08 = ushort.MaxValue;
		}
		return 0u;
	}
}
