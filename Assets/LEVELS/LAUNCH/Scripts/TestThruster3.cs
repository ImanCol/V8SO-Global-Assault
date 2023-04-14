using UnityEngine;

public class TestThruster3 : VigObject
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
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			Vector3Int v = default(Vector3Int);
			v.x = vigTransform.rotation.V02 << 3;
			v.z = vigTransform.rotation.V22 << 3;
			v.y = -16768;
			HitDetection hitDetection = new HitDetection(null);
			GameManager.instance.FUN_2FB70(this, hit, hitDetection);
			Vector3Int v2 = default(Vector3Int);
			v2.x = hitDetection.position.x / 2;
			v2.y = hitDetection.position.y / 2;
			v2.z = hitDetection.position.z / 2;
			v2 = Utilities.FUN_24148(vehicle.vTransform, v2);
			vehicle.FUN_2B370(v, v2);
			if (vehicle.id < 0)
			{
				vehicle.FUN_3A064(-1, vTransform.position, param3: true);
			}
			bool num = LevelManager.instance.FUN_39AF8(vehicle);
			result = 0u;
			if (num)
			{
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 69, vTransform.position);
				param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 25, vTransform.position);
				LevelManager.instance.FUN_4DE54(vTransform.position, 35);
				UIManager.instance.FUN_4E414(vTransform.position, new Color32(128, 128, 0, 8));
				result = 0u;
			}
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		if (arg1 == 2)
		{
			if (tags == 0)
			{
				tags = 1;
				GameManager.instance.FUN_30CB0(this, 15);
				screen.x = 4096;
				FUN_30B78();
				result = 0u;
			}
			else if (tags == 1)
			{
				DAT_80.tags = 0;
				GameManager.instance.FUN_309A0(this);
				result = uint.MaxValue;
			}
			else
			{
				result = 0u;
			}
		}
		else if (arg1 < 3)
		{
			result = 0u;
			if (arg1 == 0)
			{
				screen.x -= 245;
				Launch.FUN_5730(param2: new Vector3Int(screen.x, screen.x, screen.x), param1: ref vTransform.rotation);
				result = 0u;
			}
		}
		else
		{
			result = 0u;
		}
		return result;
	}
}
