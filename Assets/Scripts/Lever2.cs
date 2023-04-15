public class Lever2 : VigObject
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
		if (hit.self.type == 2)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			vehicle.physics1.Y = -585856;
			if ((flags & 0x1000000) == 0)
			{
				flags |= 16777216u;
				LevelManager.instance.FUN_4E8C8(vehicle.vTransform.position, 48);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 75, vehicle.vTransform.position);
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			vTransform.position.z -= 15258;
			if (arg2 != 0)
			{
				uint volume = GameManager.instance.FUN_1E7A8(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
			}
			break;
		case 1:
		{
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, 1, 0u, param5: true);
			break;
		}
		case 2:
			GameManager.instance.FUN_309A0(this);
			break;
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		}
		return 0u;
	}
}