public class Transformer2 : VigObject
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
		if ((flags & 0x1000000) == 0)
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 75, hit.self.vTransform.position);
			LevelManager.instance.FUN_4E8C8(hit.self.vTransform.position, 48);
		}
		flags |= 50331648u;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			type = 8;
			maxHalfHealth = 10;
			flags |= 128u;
			screen.y -= 40960;
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, 1, 0u, param5: true);
			break;
		}
		case 0:
			if (arg2 != 0)
			{
				vTransform.position.y = screen.y + GameManager.DAT_65C90[(((GameManager.instance.DAT_28 + DAT_19) * 128) & 0x3F80) / 2] * 10;
				if ((flags & 0x2000000) == 0)
				{
					flags &= 4278190079u;
				}
				flags &= 4261412863u;
				uint volume = GameManager.instance.FUN_1E7A8(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
			}
			break;
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		}
		return 0u;
	}
}
