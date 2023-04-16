using System.Collections.Generic;
using UnityEngine;

public enum _FIRE3_TYPE
{
	Default,
	Type1
}

public class Pipe3 : VigObject
{
	
	private static Vector3Int DAT_64 = new Vector3Int(0, -2048, 4096);

	public List<VigObject> DAT_98;

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
			Vehicle vehicle = (Vehicle)self;
			Vector3Int v = Utilities.FUN_24094(vTransform.rotation, DAT_64);
			vehicle.FUN_2B370(v, vTransform.position);
			LevelManager.instance.FUN_39AF8(vehicle);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		if (arg1 == 2)
		{
			physics1.M0 = -1;
			result = 0u;
		}
		else if (arg1 < 3)
		{
			result = 0u;
			if (arg1 == 0)
			{
				short num = (short)(physics1.M0 - 1);
				physics1.M0 = num;
				if (num == -1)
				{
					Fire3 fire = GameManager.instance.FUN_4EF80(DAT_98) as Fire3;
					if (fire != null)
					{
						fire.physics1.Z = 0;
						fire.physics1.W = 0;
						fire.flags |= 1040u;
						int num2 = (int)GameManager.FUN_2AC5C();
						fire.physics2.X = physics1.W + (num2 * physics1.W >> 15);
						fire.vTransform = GameManager.FUN_2A39C();
						fire.state = (Fire3._FIRE3_TYPE)_FIRE3_TYPE.Type1;
						Utilities.FUN_2CC48(this, fire);
						Utilities.ParentChildren(this, this);
					}
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
						vigObject.vTransform.position.x += vigObject.physics1.Z;
						vigObject.vTransform.position.y += vigObject.physics1.W;
						vigObject.vTransform.position.z += vigObject.physics2.X;
						vigObject.physics1.W -= 64;
						vigObject.physics2.X -= 32;
						vigObject = vigObject.child;
						result = 0u;
					}
					while (vigObject != null);
				}
			}
		}
		else
		{
			result = 0u;
		}
		return result;
	}
}
