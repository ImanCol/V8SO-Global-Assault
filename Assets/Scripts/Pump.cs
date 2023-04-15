using UnityEngine;

public class Pump : Destructible
{
	private static byte[] DAT_B8 = new byte[32]
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
		if (FUN_32CF0(hit) && (flags & 1) == 0 && GameManager.instance.screenMode < _SCREEN_MODE.Unknown)
		{
			GameManager.instance.FUN_30CB0(this, 240);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 != 2)
			{
				return 0u;
			}
			Pump2 pump = new GameObject().AddComponent<Pump2>();
			pump.vTransform = vTransform;
			int y = GameManager.instance.terrain.FUN_1B750((uint)pump.vTransform.position.x, (uint)pump.vTransform.position.z);
			pump.vTransform.position.y = y;
			pump.DAT_58 = 262144;
			pump.type = 8;
			pump.maxHalfHealth = 10;
			pump.vCollider = new VigCollider(DAT_B8);
			pump.DAT_98 = OILFIELD2.instance.DAT_1160;
			pump.physics1.M1 = 4;
			pump.physics1.Y = 512;
			pump.flags |= 388u;
			pump.physics1.Z = -1536;
			pump.physics1.W = 0;
			pump.FUN_305FC();
			GameManager.instance.FUN_30CB0(pump, 60);
			GameManager.instance.FUN_30CB0(this, 900);
			y = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(y, GameManager.instance.DAT_C2C, 67, pump.vTransform.position);
			return 0u;
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		if (FUN_32B90((uint)arg2) && (flags & 1) == 0 && GameManager.instance.screenMode < _SCREEN_MODE.Unknown)
		{
			GameManager.instance.FUN_30CB0(this, 240);
		}
		return 0u;
	}
}
