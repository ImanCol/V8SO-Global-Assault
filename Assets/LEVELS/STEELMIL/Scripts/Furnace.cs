using System.Collections.Generic;
using UnityEngine;

public class Furnace : Destructible
{
	public static byte[] DAT_144 = new byte[32]
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
		0,
		40,
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
		if (FUN_32CF0(hit))
		{
			FUN_30C68();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			if (SteelMil.instance.DAT_4600 < 3)
			{
				List<VigTuple> worldObjs = GameManager.instance.worldObjs;
				for (int i = 0; i < worldObjs.Count; i++)
				{
					VigObject vObject = worldObjs[i].vObject;
					if (vObject.type == 2 && vObject.maxHalfHealth != 0)
					{
						int num = Utilities.FUN_29F6C(screen, vObject.vTransform.position);
						if (num < 245760)
						{
							Furnace2 furnace = FUN_1B30();
							GameManager.instance.FUN_30CB0(furnace, 60);
							int param = GameManager.instance.FUN_1DD9C();
							GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 67, furnace.vTransform.position);
							break;
						}
					}
				}
				GameManager.instance.FUN_30CB0(this, 240);
			}
		}
		else if (arg1 < 3)
		{
			if (arg1 == 1)
			{
				int num = (int)GameManager.FUN_2AC5C();
				GameManager.instance.FUN_30CB0(this, num * 240 >> 15);
			}
		}
		else
		{
			if (arg1 != 8)
			{
				return 0u;
			}
			if (FUN_32B90((uint)arg2))
			{
				FUN_30C68();
			}
		}
		return 0u;
	}

	private Furnace2 FUN_1B30()
	{
		Furnace2 furnace = new GameObject().AddComponent<Furnace2>();
		VigTransform m = Utilities.FUN_2C77C(FUN_2C5F4(32768));
		furnace.vTransform = Utilities.CompMatrixLV(vTransform, m);
		furnace.type = 8;
		furnace.maxHalfHealth = 5;
		furnace.flags |= 388u;
		furnace.vCollider = new VigCollider(DAT_144);
		XOBF_DB dAT_ = LevelManager.instance.xobfList[19];
		furnace.physics2.M3 = 21;
		furnace.physics1.M1 = 3;
		furnace.DAT_98 = dAT_;
		int num = GameManager.instance.terrain.FUN_1B750((uint)furnace.vTransform.position.x, (uint)furnace.vTransform.position.z);
		furnace.physics1.Y = 0;
		furnace.screen.y = num - furnace.vTransform.position.y;
		furnace.physics1.Z = -512;
		furnace.physics1.W = 3072;
		furnace.FUN_305FC();
		furnace.DAT_58 = 262144;
		furnace.vTransform.rotation.V00 = 4096;
		furnace.vTransform.rotation.V11 = 4096;
		furnace.vTransform.rotation.V22 = 4096;
		return furnace;
	}
}
