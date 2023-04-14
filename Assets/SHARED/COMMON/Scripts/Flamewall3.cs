using UnityEngine;

public class Flamewall3 : VigObject
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
		Color32 param2;
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			vehicle.FUN_3A064(-200, vTransform.position, param3: true);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 63, vTransform.position);
			LevelManager.instance.FUN_39AF8(vehicle);
			LevelManager.instance.FUN_4DE54(vTransform.position, 35);
			param2 = new Color32(128, 128, 0, 8);
		}
		else
		{
			LevelManager.instance.FUN_4DE54(vTransform.position, 35);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 63, vTransform.position);
			param2 = new Color32(128, 0, 0, 8);
		}
		UIManager.instance.FUN_4E414(vTransform.position, param2);
		GameManager.instance.FUN_309A0(this);
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
			vTransform.position.x += physics1.Z;
			vTransform.position.y += physics1.W;
			int dAT_DA = GameManager.instance.DAT_DA0;
			vTransform.position.z += physics2.X;
			physics1.W += 56;
			if (vTransform.position.z < dAT_DA && GameManager.instance.DAT_DB0 < vTransform.position.y)
			{
				LevelManager.instance.FUN_4DE54(vTransform.position, 138);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 70);
			}
			else
			{
				dAT_DA = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
				if (vTransform.position.y <= dAT_DA)
				{
					return 0u;
				}
				uint num = GameManager.FUN_2AC5C();
				uint num2 = 27u;
				if ((num & 1) != 0)
				{
					num2 = 31u;
				}
				VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C((ushort)num2, typeof(Flamewall2), 8u, typeof(VigChild));
				Utilities.ParentChildren(vigObject, vigObject);
				vigObject.type = 8;
				vigObject.flags = 276u;
				vigObject.id = id;
				vigObject.screen = vTransform.position;
				vigObject.maxHalfHealth = 3;
				vigObject.FUN_3066C();
				if (tags == 0)
				{
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 68, vigObject.screen);
				}
			}
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
