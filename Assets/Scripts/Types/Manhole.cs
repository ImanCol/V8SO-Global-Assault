using UnityEngine;

public class Manhole : VigObject
{
	private static byte[] DAT_C4 = new byte[32]
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
		0,
		252,
		255,
		0,
		216,
		255,
		255,
		0,
		40,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		40,
		0,
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
		if (hit.self.type == 2)
		{
			flags |= 32u;
			GameManager.instance.FUN_30CB0(this, 15);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 2:
		{
			Manhole2 manhole = new GameObject().AddComponent<Manhole2>();
			manhole.vTransform = vTransform;
			int y = GameManager.instance.terrain.FUN_1B750((uint)manhole.vTransform.position.x, (uint)manhole.vTransform.position.z);
			manhole.vTransform.position.y = y;
			manhole.DAT_58 = 262144;
			manhole.type = 8;
			manhole.vCollider = new VigCollider(DAT_C4);
			manhole.physics1.M1 = 4;
			manhole.physics1.Y = 512;
			manhole.maxHalfHealth = 2;
			manhole.flags |= 388u;
			manhole.physics1.Z = -2048;
			manhole.physics1.W = 0;
			manhole.FUN_305FC();
			GameManager.instance.FUN_30CB0(manhole, 60);
			FUN_2C05C();
			FUN_30BF0();
			y = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(y, GameManager.instance.DAT_C2C, 67, screen);
			return 0u;
		}
		case 1:
			flags = 256u;
			type = 3;
			return 0u;
		default:
			return 0u;
		}
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			ApplyTransformation();
			flags &= 4294967263u;
			FUN_30C20();
			return uint.MaxValue;
		}
		return 0u;
	}
}
