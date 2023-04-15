using UnityEngine;

public class Thunder : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
		base.transform.localScale = new Vector3(8f, (float)physics1.X / 2048f, (float)physics1.X / 2048f);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			if (arg2 != 0 && physics1.X > 0)
			{
				physics1.X -= 128;
			}
			return 0u;
		default:
			return 0u;
		case 2:
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
	}
}
