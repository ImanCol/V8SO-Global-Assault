using UnityEngine;

public class Pipe2 : Destructible
{
	private static byte[] DAT_74 = new byte[32]
	{
		1,
		0,
		0,
		0,
		0,
		216,
		255,
		255,
		0,
		216,
		255,
		255,
		0,
		0,
		0,
		0,
		0,
		40,
		0,
		0,
		0,
		40,
		0,
		0,
		0,
		0,
		4,
		0,
		0,
		0,
		0,
		0
	};

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
		if (FUN_32CF0(hit) && PDAT_74 != null)
		{
			GameManager.instance.FUN_30CB0(PDAT_74, 0);
			GameManager.instance.FUN_30CB0(this, 240);
			PDAT_74 = null;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 2:
		{
			Pipe3 pipe2 = FUN_494();
			GameManager.instance.FUN_30CB0(pipe2, 60);
			GameManager.instance.FUN_30CB0(this, 240);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 67, pipe2.vTransform.position);
			break;
		}
		case 1:
			if (GameManager.instance.screenMode < _SCREEN_MODE.Unknown)
			{
				ConfigContainer configContainer = CCDAT_74 = FUN_2C5F4(32768);
				Pipe3 pipe = (Pipe3)(PDAT_74 = FUN_494());
			}
			break;
		case 8:
			if (FUN_32B90((uint)arg2) && PDAT_74 != null)
			{
				GameManager.instance.FUN_30CB0(PDAT_74, 0);
				GameManager.instance.FUN_30CB0(this, 240);
				PDAT_74 = null;
			}
			break;
		}
		return 0u;
	}

	private Pipe3 FUN_494()
	{
		Pipe3 pipe = new GameObject().AddComponent<Pipe3>();
		pipe.vTransform = Utilities.CompMatrixLV(m1: Utilities.FUN_2C77C(CCDAT_74), m0: vTransform);
		pipe.type = 8;
		pipe.maxHalfHealth = 5;
		pipe.vCollider = new VigCollider(DAT_74);
		pipe.DAT_98 = OILFIELD2.instance.DAT_1160;
		pipe.physics1.M1 = 3;
		pipe.physics1.Y = 0;
		pipe.flags |= 388u;
		pipe.physics1.Z = -512;
		pipe.physics1.W = 3072;
		pipe.FUN_305FC();
		pipe.DAT_58 = 262144;
		return pipe;
	}
}
