using UnityEngine;

public class Furnace3 : VigObject
{
	public XOBF_DB DAT_98;

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
		if (hit.object2.type == 3)
		{
			return 0u;
		}
		if (hit.self.type == 2 && LevelManager.instance.FUN_39AF8((Vehicle)hit.self))
		{
			LevelManager.instance.FUN_4DE54(vTransform.position, 35);
			UIManager.instance.FUN_4E414(vTransform.position, new Color32(128, 128, 0, 8));
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		if (arg1 == 0)
		{
			short num = (short)(physics1.M0 - 1);
			physics1.M0 = num;
			if (num == -1)
			{
				Furnace4 furnace = LevelManager.instance.xobfList[19].ini.FUN_2C17C(113, typeof(Furnace4), 8u) as Furnace4;
				furnace.flags |= 1040u;
				int num2 = (int)GameManager.FUN_2AC5C();
				int w = physics1.W;
				furnace.physics1.W = 0;
				furnace.physics1.Z = w + (num2 * (w / 2) >> 15);
				num2 = (int)GameManager.FUN_2AC5C();
				furnace.physics2.X = physics1.W + (num2 * (physics1.W / 2) >> 15);
				furnace.vTransform = GameManager.FUN_2A39C();
				Utilities.FUN_2CC48(this, furnace);
				Utilities.ParentChildren(this, this);
				physics1.M0 = physics1.M1;
			}
			VigObject vigObject = child2;
			if (vigObject == null)
			{
				GameManager.instance.FUN_309A0(this);
				result = uint.MaxValue;
			}
			else
			{
				do
				{
					if (vigObject.tags == 0)
					{
						vigObject.vTransform.position.y += vigObject.physics1.W;
						vigObject.vTransform.position.x += vigObject.physics1.Z;
						vigObject.physics1.W += 90;
						vigObject.vTransform.position.z += vigObject.physics2.X;
						if (screen.y < vigObject.vTransform.position.y)
						{
							vigObject.vTransform.position.y = screen.y;
							int w = (int)GameManager.FUN_2AC5C();
							vigObject.physics1.Z = vigObject.physics1.Z + (w * 3276 >> 15) - 1638;
							w = (int)GameManager.FUN_2AC5C();
							vigObject.physics1.W = -(vigObject.physics1.W / 2 + (w * 1638 >> 15));
							w = (int)GameManager.FUN_2AC5C();
							vigObject.physics2.X = vigObject.physics2.X + (w * 3276 >> 15) - 1638;
							vigObject.IDAT_78 = 4096;
							vigObject.tags = 1;
							vigObject.FUN_30B78();
							if ((flags & 0x1000000) == 0)
							{
								MoltenSteel moltenSteel = LevelManager.instance.xobfList[42].ini.FUN_2C17C(28, typeof(MoltenSteel), 8u) as MoltenSteel;
								Utilities.ParentChildren(moltenSteel, moltenSteel);
								moltenSteel.flags |= 4u;
								moltenSteel.screen = GameManager.instance.FUN_2CE50(vigObject);
								moltenSteel.physics2.X = 4096;
								moltenSteel.FUN_3066C();
								flags |= 16777216u;
								GameManager.instance.FUN_30CB0(moltenSteel, 120);
							}
						}
					}
					vigObject = vigObject.child;
					result = 0u;
				}
				while (vigObject != null);
			}
		}
		else
		{
			result = 0u;
			if (arg1 == 2)
			{
				physics1.M0 = -1;
				result = 0u;
			}
		}
		return result;
	}
}
