using UnityEngine;

public class TrainBoxcar : TrainEngine
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
		if (FUN_32CF0(hit))
		{
			int num = 0;
			Vector3Int param = default(Vector3Int);
			do
			{
				num++;
				int num2 = (int)GameManager.FUN_2AC5C();
				param.x = (num2 * 3051 >> 15) - 1525;
				param.y = -4577;
				num2 = (int)GameManager.FUN_2AC5C();
				param.z = (num2 * 3051 >> 15) - 1525;
				LevelManager.instance.FUN_4AAC0(4261412864u, screen, param);
			}
			while (num < 6);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		switch (arg1)
		{
		case 0:
			FUN_3AD0();
			result = 0u;
			break;
		case 1:
			FUN_3754();
			result = 0u;
			break;
		case 2:
			FUN_4DC94();
			result = 0u;
			break;
		case 4:
			FUN_38FC();
			goto default;
		default:
			result = 0u;
			break;
		case 8:
			if (FUN_32B90((uint)arg2))
			{
				int num = 0;
				Vector3Int param = default(Vector3Int);
				do
				{
					num++;
					int num2 = (int)GameManager.FUN_2AC5C();
					param.x = (num2 * 3051 >> 15) - 1525;
					param.y = -4577;
					num2 = (int)GameManager.FUN_2AC5C();
					param.z = (num2 * 3051 >> 15) - 1525;
					LevelManager.instance.FUN_4AAC0(4261412864u, screen, param);
				}
				while (num < 6);
			}
			result = 0u;
			break;
		case 9:
			result = 0u;
			if (arg2 != 0)
			{
				result = 0u;
				if (vMesh == null)
				{
					GameManager.instance.FUN_309A0(this);
					result = 0u;
				}
			}
			break;
		}
		return result;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 20)
		{
			FUN_3838((TrainEngine)arg2);
			return 0u;
		}
		return 0u;
	}
}
