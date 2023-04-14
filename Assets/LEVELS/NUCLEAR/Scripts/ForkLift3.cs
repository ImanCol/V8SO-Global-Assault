using UnityEngine;

public class ForkLift3 : VigObject
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
		if (hit.self.type != 2)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)hit.self;
		Utilities.FUN_2A168(out Vector3Int vout, vTransform.position, vehicle.vTransform.position);
		Vector3Int v = default(Vector3Int);
		v.x = vout.x << 4;
		v.z = vout.z << 4;
		v.y = vout.y << 1;
		vehicle.FUN_2B370(v, vTransform.position);
		if (vehicle.id < 0)
		{
			GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 2, 128);
		}
		FUN_2444(vehicle);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 2:
			flags |= 32u;
			break;
		default:
			return 0u;
		case 1:
			GameManager.instance.FUN_30CB0(this, 2);
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 != 5)
		{
			return 0u;
		}
		GameManager.instance.FUN_309A0(this);
		return 4294967294u;
	}

	private static void FUN_2444(Vehicle param1)
	{
		Fire1 fire = LevelManager.instance.FUN_399FC(param1, LevelManager.instance.xobfList[19], 23);
		if (fire != null)
		{
			sbyte param2 = fire.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param2, LevelManager.instance.xobfList[42].sndList, 0, param1.vTransform.position, param5: true);
			UIManager.instance.FUN_4E414(param1.vTransform.position, new Color32(0, 128, 0, 8));
			int param3 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param3, LevelManager.instance.xobfList[42].sndList, 3, param1.vTransform.position);
			param1.physics1.Y -= 585856;
			short id = param1.id;
		}
	}
}
