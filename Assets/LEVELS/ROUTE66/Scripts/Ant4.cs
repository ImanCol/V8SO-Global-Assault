using UnityEngine;

public class Ant4 : VigObject
{
	private static Vector3Int DAT_120 = new Vector3Int(0, -1310720, 0);

	private static Vector3Int DAT_12C = new Vector3Int(0, 0, 0);

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
			Vector3Int v = default(Vector3Int);
			int num = (int)GameManager.FUN_2AC5C();
			int num2 = num << 2;
			num2 += num;
			num2 <<= 11;
			num2 >>= 15;
			num2 -= 5120;
			num = (int)GameManager.FUN_2AC5C();
			v.x = vehicle.vTransform.position.x + num2;
			v.z = vehicle.vTransform.position.z + (num << 2 << 11 >> 15) - 5120;
			v.y = vehicle.vTransform.position.y;
			vehicle.FUN_2B370(DAT_120, v);
			vehicle.FUN_3A064(500, DAT_12C, param3: true);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result = 0u;
		if (arg1 == 5)
		{
			GameManager.instance.FUN_309A0(this);
			result = uint.MaxValue;
		}
		return result;
	}
}
