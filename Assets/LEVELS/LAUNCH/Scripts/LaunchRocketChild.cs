using UnityEngine;

public class LaunchRocketChild : VigChild
{
	public Vector3 euler;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
		base.transform.localEulerAngles = euler;
	}

	public override uint OnCollision(HitDetection param1)
	{
		return base.OnCollision(param1);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		return base.UpdateW(arg1, arg2);
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		return base.UpdateW(arg1, arg2);
	}
}
