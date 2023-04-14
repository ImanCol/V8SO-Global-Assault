using UnityEngine;

public class LaunchRocket4 : VigObject
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
		uint result = 0u;
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			Vector3Int v = Utilities.FUN_24094(vTransform.rotation, LaunchRocket3.DAT_C4);
			vehicle.FUN_2B370(v, vTransform.position);
			LevelManager.instance.FUN_39AF8(vehicle);
			result = 0u;
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 == 0)
			{
				vTransform.position.x += screen.x;
				vTransform.position.y += screen.y;
				vTransform.position.z += screen.z;
				int x = screen.x;
				int num = x;
				if (x < 0)
				{
					num = x + 63;
				}
				int z = screen.z;
				screen.x = x - (num >> 6);
				num = z;
				if (z < 0)
				{
					num = z + 63;
				}
				screen.z = z - (num >> 6);
				screen.y -= 8;
				return 0u;
			}
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
