using System.Collections.Generic;
using UnityEngine;

public class HellGate4 : VigObject
{
	public List<Vehicle> hitList = new List<Vehicle>();

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
		if (!hitList.Contains(vehicle))
		{
			if (LevelManager.instance.FUN_39AF8(vehicle))
			{
				vehicle.physics1.Y -= 976512;
				UIManager.instance.FUN_4E414(vTransform.position, new Color32(byte.MaxValue, byte.MaxValue, 0, 8));
			}
			hitList.Add(vehicle);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			if (tags == 1)
			{
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
			Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(109, typeof(Ballistic), 8u) as Ballistic;
			ballistic.flags = 1040u;
			ballistic.id = 0;
			int num = (int)GameManager.FUN_2AC5C();
			ballistic.screen.x = (num * 3051 >> 15) - 1525;
			ballistic.screen.y = -3051;
			num = (int)GameManager.FUN_2AC5C();
			ballistic.screen.z = (num * 3051 >> 15) - 1525;
			ballistic.screen = Utilities.FUN_24094(ballistic.vTransform.rotation, ballistic.screen);
			Utilities.FUN_2CC9C(this, ballistic);
			ballistic.transform.parent = base.transform;
			sbyte b = (sbyte)(DAT_19 + 1);
			DAT_19 = (byte)b;
			if (b == 1)
			{
				FUN_30B78();
				flags &= 4294967263u;
			}
			if ((uint)DAT_19 < 12u)
			{
				GameManager.instance.FUN_30CB0(this, 3);
			}
		}
		else if (arg1 < 3)
		{
			if (arg1 != 0)
			{
				return 0u;
			}
			VigObject vigObject = child2;
			while (true)
			{
				if (vigObject == null)
				{
					return 0u;
				}
				if (vigObject.id != 0)
				{
					break;
				}
				vigObject.vTransform.position.x += vigObject.screen.x;
				vigObject.vTransform.position.y += vigObject.screen.y;
				vigObject.vTransform.position.z += vigObject.screen.z;
				vigObject = vigObject.child;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 != 5)
		{
			return 0u;
		}
		tags = 1;
		flags |= 32u;
		GameManager.instance.FUN_30CB0(this, 40);
		return 0u;
	}
}
