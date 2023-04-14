using UnityEngine;

public class Furnace2 : VigObject
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
		switch (arg1)
		{
		case 0:
		{
			short num = (short)(physics1.M0 - 1);
			physics1.M0 = num;
			if (num == -1)
			{
				Smoke2 smoke = DAT_98.ini.FUN_2C17C((ushort)physics2.M3, typeof(Smoke2), 8u) as Smoke2;
				smoke.physics1.Z = 0;
				smoke.physics1.W = 0;
				smoke.flags |= 1040u;
				int num2 = (int)GameManager.FUN_2AC5C();
				smoke.physics2.X = physics1.W + (num2 * physics1.W >> 15);
				smoke.vTransform = GameManager.FUN_2A39C();
				Utilities.FUN_2CC48(this, smoke);
				Utilities.ParentChildren(this, this);
				physics1.M0 = physics1.M2;
			}
			VigObject vigObject = child2;
			if (vigObject == null)
			{
				GameManager.instance.FUN_309A0(this);
				break;
			}
			do
			{
				vigObject.vTransform.position.x += vigObject.physics1.Z;
				vigObject.vTransform.position.y += vigObject.physics1.W;
				vigObject.vTransform.position.z += vigObject.physics2.X;
				vigObject.physics1.W += 90;
				vigObject.physics2.X -= 32;
				if (screen.y < vigObject.vTransform.position.y)
				{
					vigObject.vTransform.position.y = screen.y;
					vigObject.physics1.Z = 0;
					vigObject.physics1.W = 0;
					vigObject.physics2.X = 0;
				}
				vigObject = vigObject.child;
			}
			while (vigObject != null);
			break;
		}
		case 2:
			physics1.M0 = -1;
			break;
		}
		return 0u;
	}
}
