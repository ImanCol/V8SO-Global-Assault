public class Barracade : Destructible
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
			short[] array = new short[4];
			int x = screen.x;
			array[0] = (short)(x >> 16);
			if (x < 0)
			{
				array[0] = (short)(x + 65535 >> 16);
			}
			x = screen.z;
			if (x < 0)
			{
				x += 65535;
			}
			array[1] = (short)(x >> 16);
			array[2] = 1;
			array[3] = 1;
			LevelManager.instance.FUN_359CC(array, 36736u);
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
			short[] array = new short[4];
			int x = screen.x;
			array[0] = (short)(x >> 16);
			if (x < 0)
			{
				array[0] = (short)(x + 65535 >> 16);
			}
			x = screen.z;
			if (x < 0)
			{
				x += 65535;
			}
			array[1] = (short)(x >> 16);
			array[2] = 1;
			array[3] = 1;
			LevelManager.instance.FUN_359CC(array, 36736u);
		}
		return 0u;
	}
}