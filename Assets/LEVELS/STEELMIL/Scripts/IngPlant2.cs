using UnityEngine;

public class IngPlant2 : Destructible
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
		if (hit.self.type == 2 && LevelManager.instance.FUN_39AF8((Vehicle)hit.self))
		{
			LevelManager.instance.FUN_4DE54(vTransform.position, 33);
			LevelManager.instance.FUN_4DE54(vTransform.position, 29);
			UIManager.instance.FUN_4E414(vTransform.position, new Color32(128, 0, 0, 8));
			return 0u;
		}
		if (!FUN_32CF0(hit))
		{
			return 0u;
		}
		MoltenSteel moltenSteel = LevelManager.instance.xobfList[42].ini.FUN_2C17C(28, typeof(MoltenSteel), 8u) as MoltenSteel;
		Utilities.ParentChildren(moltenSteel, moltenSteel);
		moltenSteel.flags |= 4u;
		moltenSteel.screen = vTransform.position;
		moltenSteel.FUN_3066C();
		GameManager.instance.FUN_30CB0(moltenSteel, 120);
		LevelManager.instance.FUN_4DE54(vTransform.position, 33);
		LevelManager.instance.FUN_4DE54(vTransform.position, 29);
		GameManager.instance.FUN_309A0(this);
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
			flags |= 384u;
			return 0u;
		case 0:
			GameManager.instance.terrain.FUN_2D16C(vTransform.position.x - 6103, vTransform.position.z, ref vTransform);
			if (57528319 < vTransform.position.x)
			{
				return 0u;
			}
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		default:
			return 0u;
		case 8:
			FUN_32B90((uint)arg2);
			return 0u;
		}
	}
}
