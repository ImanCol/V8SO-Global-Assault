public class HangerDoor : Destructible
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
		if (arg1 == 1)
		{
			DAT_1A = 423;
			VigTransform vTransform = base.vTransform;
			vData = LevelManager.instance.xobfList[44];
			FUN_4D8A8(vData, (ushort)DAT_1A, null);
			base.vTransform = vTransform;
			FUN_2C958();
		}
		return base.UpdateW(arg1, arg2);
	}
}
