public class Windmill : VigObject
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
		VigObject self = hit.self;
		if (self.type != 8)
		{
			return 0u;
		}
		if (FUN_32B90(self.maxHalfHealth))
		{
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(child2);
			VigObject src = child2.FUN_2CCBC();
			Windmill2 windmill = Utilities.FUN_52188(src, typeof(Windmill2)) as Windmill2;
			FUN_30BA8();
			src = (windmill.DAT_84 = GameManager.instance.FUN_320DC(screen, self.id));
			windmill.id = id;
			windmill.vTransform = vigTransform;
			windmill.screen = vigTransform.position;
			windmill.type = 8;
			windmill.flags = 128u;
			windmill.maxHalfHealth = 100;
			windmill.FUN_305FC();
			windmill.physics1.Z = windmill.vTransform.rotation.V02 << 1;
			windmill.physics1.W = windmill.vTransform.rotation.V12 << 1;
			windmill.physics2.X = windmill.vTransform.rotation.V22 << 1;
			sbyte param = windmill.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, vData.sndList, 3, windmill.vTransform.position, param5: true);
			GameManager.instance.FUN_1DE78(DAT_18);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			short z = (short)GameManager.FUN_2AC5C();
			child2.vr.z = z;
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, (int)DAT_19 % 4 + 8, 0u, param5: true);
			break;
		}
		case 0:
			child2.vr.z += 68;
			if (arg2 != 0)
			{
				child2.ApplyTransformation();
			}
			if (DAT_1A == 1)
			{
				uint volume = GameManager.instance.FUN_1E7A8(screen);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
			}
			break;
		default:
			return 0u;
		case 8:
			if (FUN_32B90((uint)arg2))
			{
				VigTransform vigTransform = GameManager.instance.FUN_2CDF4(child2);
				VigObject src = child2.FUN_2CCBC();
				Windmill2 windmill = Utilities.FUN_52188(src, typeof(Windmill2)) as Windmill2;
				FUN_30BA8();
				src = (windmill.DAT_84 = GameManager.instance.FUN_320DC(screen, 0));
				windmill.id = id;
				windmill.vTransform = vigTransform;
				windmill.screen = vigTransform.position;
				windmill.type = 8;
				windmill.flags = 128u;
				windmill.maxHalfHealth = 100;
				windmill.FUN_305FC();
				windmill.physics1.Z = windmill.vTransform.rotation.V02 << 1;
				windmill.physics1.W = windmill.vTransform.rotation.V12 << 1;
				windmill.physics2.X = windmill.vTransform.rotation.V22 << 1;
				sbyte param = windmill.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, vData.sndList, 3, windmill.vTransform.position, param5: true);
				GameManager.instance.FUN_1DE78(DAT_18);
			}
			break;
		}
		return 0u;
	}
}
