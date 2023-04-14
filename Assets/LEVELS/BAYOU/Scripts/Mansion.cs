using UnityEngine;

public class Mansion : Mausoleum
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
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
			FUN_2E900(1u);
			return 0u;
		case 9:
			if (arg2 == 0)
			{
				LevelManager.instance.FUN_359FC(60358656, 80936960, 0u);
				LevelManager.instance.FUN_359FC(59113472, 81723392, 0u);
				VigObject powerup = GameManager.instance.GetPowerup(GameManager.instance.DAT_1078, new Vector3Int(59966876, 2897920, 81648024));
				powerup.screen.y -= 131072;
				powerup.vTransform.position.y = powerup.screen.y;
				powerup = GameManager.instance.GetPowerup(GameManager.instance.DAT_1078, new Vector3Int(59652096, 2897920, 81127216));
				powerup.screen.y -= 131072;
				powerup.vTransform.position.y = powerup.screen.y;
			}
			break;
		}
		return base.UpdateW(arg1, arg2);
	}
}