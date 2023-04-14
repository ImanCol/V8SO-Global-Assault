public class Tomb : VigObject
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
		if (!FUN_32B90(hit.self.maxHalfHealth))
		{
			return 0u;
		}
		int param = 60;
		GameManager.instance.FUN_30CB0(this, param);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		int param;
		if (arg1 < 4)
		{
			if (arg1 != 2)
			{
				return 0u;
			}
			Ghost ghost = vData.ini.FUN_2C17C(28, typeof(Ghost), 8u) as Ghost;
			ghost.screen = screen;
			ghost.vr.x = 113;
			ghost.flags = 388u;
			ghost.type = 8;
			ghost.maxHalfHealth = 150;
			ghost.FUN_3066C();
			ghost.DAT_80 = ghost;
			ghost.screen.y -= 81920;
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, vData.sndList, 6, screen);
			param = 120;
			GameManager.instance.FUN_30CB0(ghost, param);
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		if (!FUN_32B90((uint)arg2))
		{
			return 0u;
		}
		param = 60;
		GameManager.instance.FUN_30CB0(this, param);
		return 0u;
	}
}