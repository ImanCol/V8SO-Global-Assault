using UnityEngine;

public class Pesticide : VigObject
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
		if (self.type == 2)
		{
			((Vehicle)self).FUN_3A064(-100, vTransform.position, param3: true);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 61, vTransform.position);
			Color32 param2 = new Color32(0, 128, 0, 8);
			UIManager.instance.FUN_4E414(vTransform.position, param2);
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
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
				int num = (int)GameManager.FUN_2AC5C() % 8;
				Pesticide2 pesticide = LevelManager.instance.xobfList[19].ini.FUN_2C17C(224, typeof(Pesticide2), 0u) as Pesticide2;
				BufferedBinaryReader reader = vData.FUN_2CBB0(11);
				pesticide.vAnim = new BufferedBinaryReader(null);
				pesticide.vAnim.ChangeBuffer(reader);
				Utilities.ParentChildren(pesticide, pesticide);
				pesticide.type = 8;
				pesticide.flags = 1073743764u;
				pesticide.id = id;
				pesticide.lenght = num + 1;
				pesticide.screen = vTransform.position;
				pesticide.maxHalfHealth = maxHalfHealth;
				pesticide.FUN_3066C();
				GameManager.instance.FUN_30CB0(pesticide, 60);
			}
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
