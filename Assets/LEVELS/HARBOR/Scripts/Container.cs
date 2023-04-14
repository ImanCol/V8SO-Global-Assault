using UnityEngine;

public class Container : Destructible
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
		FUN_32CF0(hit);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 2:
			FUN_4DC94();
			break;
		case 8:
			FUN_32B90((uint)arg2);
			break;
		case 9:
			if (arg2 == 0)
			{
				Vector2Int param = new Vector2Int(screen.x, screen.x);
				Vector2Int param2 = new Vector2Int(screen.z, screen.z);
				short id = base.id;
				base.id = 0;
				VigObject vigObject = GameManager.instance.FUN_31C98(id, id, param, param2);
				if (vigObject != null && vigObject.screen.y < screen.y)
				{
					GameManager.instance.FUN_30CB0(vigObject, 30);
				}
				base.id = id;
				LevelManager.instance.FUN_359FC(screen.x, screen.z, 36736u);
			}
			break;
		}
		return 0u;
	}
}
