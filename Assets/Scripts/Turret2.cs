using UnityEngine;

public class Turret2 : VigObject
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
		LevelManager.instance.FUN_4E8C8(screen, 48);
		flags |= 32u;
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 75, vTransform.position);
		UIManager.instance.FUN_4E414(vTransform.position, new Color32(0, 192, 192, 8));
		if (hit.self.type == 2 && hit.self.id < 0)
		{
			GameManager.instance.FUN_15ADC(~hit.self.id, 20);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
			short m = physics2.M3;
			physics2.M3 = (short)(m - 1);
			if (m == 1)
			{
				if (physics2.M2 == 0)
				{
					return 0u;
				}
				Turret2 obj = vData.ini.FUN_2C17C(524, typeof(Turret2), 8u) as Turret2;
				ConfigContainer configContainer = FUN_2C5F4(32768);
				obj.type = 8;
				obj.flags = 132u;
				obj.id = id;
				ushort num = obj.maxHalfHealth = maxHalfHealth;
				obj.FUN_3066C();
				m = physics2.M2;
				obj.physics2.M3 = 4;
				obj.physics2.M2 = (short)(m - 1);
				obj.physics1.Z = physics1.Z;
				obj.physics1.W = physics1.W;
				obj.physics2.X = physics2.X;
				obj.vTransform = vTransform;
				obj.vTransform.position = Utilities.FUN_24148(vTransform, configContainer.v3_1);
				return 0u;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
