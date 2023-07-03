using UnityEngine;

public class Manhole2 : VigObject
{
	private static Vector3Int DAT_AC = new Vector3Int(0, -8192, 0);

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
			((Vehicle)hit.self).FUN_2B370(DAT_AC, vTransform.position);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 2:
			physics1.M0 = -1;
			return 0u;
		case 0:
		{
			short num = (short)(physics1.M0 - 1);
			physics1.M0 = num;
			if (num == -1)
			{
				Smoke2 smoke = LevelManager.instance.xobfList[19].ini.FUN_2C17C(5, typeof(Smoke2), 8u) as Smoke2;
				if (smoke != null)
				{
					int num2 = (int)((GameManager.FUN_2AC5C() & 0xFFF) * 2);
					smoke.flags |= 1040u;
					int num3 = physics1.Y * Utilities.DAT_65C90[num2];
					if (num3 < 0)
					{
						num3 += 4095;
					}
					smoke.physics1.Z = num3 >> 12;
					num2 = physics1.Y * Utilities.DAT_65C90[num2 + 1];
					if (num2 < 0)
					{
						num2 += 4095;
					}
					smoke.physics2.X = num2 >> 12;
					num2 = (int)GameManager.FUN_2AC5C();
					num3 = physics1.Z;
					smoke.screen.x = 0;
					smoke.physics1.W = num3 + (num2 * num3 >> 15);
					smoke.screen.y = 0;
					smoke.screen.z = 0;
					Utilities.FUN_2CC48(this, smoke);
					Utilities.ParentChildren(this, this);
				}
				physics1.M0 = physics1.M1;
			}
			VigObject vigObject = child2;
			if (vigObject == null)
			{
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
			do
			{
				vigObject.vr.z += 32;
				vigObject.screen.x += vigObject.physics1.Z;
				vigObject.screen.y += vigObject.physics1.W;
				vigObject.screen.z += vigObject.physics2.X;
				if (arg2 != 0)
				{
					vigObject.ApplyTransformation();
				}
				vigObject = vigObject.child;
			}
			while (vigObject != null);
			break;
		}
		}
		return 0u;
	}
}