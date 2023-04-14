public class Fence2 : Destructible
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
		if (!FUN_32CF0(hit))
		{
			return 0u;
		}
		FUN_648(36736u);
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0u;
		}
		if (!FUN_32B90((uint)arg2))
		{
			return 0u;
		}
		FUN_648(36736u);
		return uint.MaxValue;
	}

	private void FUN_648(uint param1)
	{
		short[] array = new short[4];
		BufferedBinaryReader reader = vCollider.reader;
		int num = screen.x + reader.ReadInt32(4);
		if (num < 0)
		{
			num += 65535;
		}
		array[0] = (short)(num >> 16);
		num = screen.z + reader.ReadInt32(12);
		if (num < 0)
		{
			num += 65535;
		}
		array[1] = (short)(num >> 16);
		num = screen.x + reader.ReadInt32(16);
		int num2 = num + 65535;
		if (num2 < 0)
		{
			num2 = num + 131070;
		}
		array[2] = (short)((num2 >> 16) - array[0]);
		num = screen.z + reader.ReadInt32(24);
		num2 = num + 65535;
		if (num2 < 0)
		{
			num2 = num + 131070;
		}
		array[3] = (short)((num2 >> 16) - array[1]);
		LevelManager.instance.FUN_359CC(array, param1);
	}
}
