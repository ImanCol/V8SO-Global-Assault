
public enum _PALM_TYPE
{
	Destructible,
	Fire
}

public class Palm : Destructible2
{
	public _PALM_TYPE state;

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
		if (state == _PALM_TYPE.Destructible)
		{
			return base.OnCollision(hit);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (state == _PALM_TYPE.Destructible)
		{
			switch (arg1)
			{
			case 1:
				if (tags == 0)
				{
					state = _PALM_TYPE.Destructible;
					base.UpdateW(arg1, arg2);
					return 0u;
				}
				GameManager.instance.FUN_1FEB8(vMesh);
				vMesh = null;
				FUN_2C344(LevelManager.instance.xobfList[19], 25, 8u);
				vLOD = null;
				DAT_6C = 0;
				Utilities.ParentChildren(this, this);
				flags |= 52u;
				state = _PALM_TYPE.Fire;
				break;
			case 8:
				return base.UpdateW(arg1, arg2);
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (state == _PALM_TYPE.Fire && arg1 == 5)
		{
			GameManager.instance.FUN_1E8B0(GameManager.instance.DAT_C2C, 67, screen);
		}
		return 0u;
	}
}