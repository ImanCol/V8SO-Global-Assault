public class Gantry : Destructible
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
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 1 && (GameManager.instance.gameMode == _GAME_MODE.Survival || GameManager.instance.gameMode == _GAME_MODE.Survival2))
		{
			flags |= 32768u;
		}
		return base.UpdateW(arg1, arg2);
	}
}
