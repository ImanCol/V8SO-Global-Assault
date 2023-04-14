public class Pine : Destructible2
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
		uint num2 = 0u;
		if (num)
		{
			num2 = (uint)FUN_4DCD8();
			if (num2 == 0)
			{
				SKIRESRT.instance.DAT_2200++;
				num2 = (uint)(SKIRESRT.instance.DAT_2200 & 1);
				if (num2 != 0)
				{
					int param = 512;
					if ((uint)(VigTerrain.instance.DAT_DE4 + VigTerrain.instance.DAT_DE8) >> 1 < screen.x)
					{
						param = 513;
					}
					num2 = GameManager.instance.FUN_31A24(10, param);
				}
			}
		}
		return num2;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return base.UpdateW(arg1, arg2);
		}
		bool num = FUN_32B90((uint)arg2);
		uint num2 = 0u;
		if (num)
		{
			num2 = (uint)FUN_4DCD8();
			if (num2 == 0)
			{
				SKIRESRT.instance.DAT_2200++;
				num2 = (uint)(SKIRESRT.instance.DAT_2200 & 1);
				if (num2 != 0)
				{
					int param = 512;
					if ((uint)(VigTerrain.instance.DAT_DE4 + VigTerrain.instance.DAT_DE8) >> 1 < screen.x)
					{
						param = 513;
					}
					num2 = GameManager.instance.FUN_31A24(10, param);
				}
			}
		}
		return num2;
	}
}
