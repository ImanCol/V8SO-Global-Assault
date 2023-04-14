public class RevolverBallistic : Ballistic
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
		base.transform.LookAt(LevelManager.instance.defaultCamera.transform);
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		return base.UpdateW(arg1, arg2);
	}
}
