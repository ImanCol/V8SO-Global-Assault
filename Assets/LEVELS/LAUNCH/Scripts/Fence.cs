using UnityEngine;

public class Fence : Destructible
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
		if (self.type == 2 && tags == 0 && (self.flags & 0x4000) != 0 && (self.flags & 0x4000000) == 0)
		{
			HitDetection hitDetection = new HitDetection(null);
			GameManager.instance.FUN_2FB70(this, hit, hitDetection);
			int num = 0;
			Vector3Int vector3Int = Utilities.FUN_24148(hit.self.vTransform, hitDetection.position);
			LevelManager.instance.FUN_4DE54(vector3Int, 42);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 75, vector3Int);
			GameManager.instance.FUN_30CB0(this, 60);
			tags = 1;
			do
			{
				Throwaway obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(49, typeof(Throwaway), 8u) as Throwaway;
				obj.physics1.M0 = 0;
				obj.physics1.M1 = 0;
				obj.physics1.M2 = 0;
				int num2 = (int)GameManager.FUN_2AC5C();
				obj.physics1.Z = (num2 & 0xFFF) - 2048;
				int num3 = (int)GameManager.FUN_2AC5C();
				if (num3 < 0)
				{
					num3 += 15;
				}
				obj.physics1.W = -(num3 >> 4);
				num2 = (int)GameManager.FUN_2AC5C();
				obj.physics2.X = (num2 & 0xFFF) - 2048;
				obj.type = 7;
				obj.flags |= 436u;
				short id = base.id;
				num++;
				obj.state = _THROWAWAY_TYPE.Type3;
				obj.id = id;
				obj.vTransform = GameManager.FUN_2A39C();
				obj.vTransform.position = vector3Int;
				obj.FUN_2D1DC();
				obj.DAT_87 = 1;
				obj.FUN_305FC();
			}
			while (num < 12);
			Ballistic ballistic = vData.ini.FUN_2C17C(17, typeof(Ballistic), 8u) as Ballistic;
			if (ballistic != null)
			{
				VigObject vigObject = Utilities.FUN_2CD78(this);
				if (vigObject == null)
				{
					vigObject = this;
				}
				ballistic.vTransform = vigObject.vTransform;
				ballistic.flags = 4u;
				ballistic.type = 3;
				ballistic.FUN_305FC();
			}
			self.physics1.X = self.physics1.X / 2;
			self.physics1.Z = self.physics1.Z / 2;
			Vector3Int v = default(Vector3Int);
			v.x = hitDetection.normal2.x << 3;
			v.y = hitDetection.normal2.y * 8 - 585856;
			v.z = hitDetection.normal2.z << 3;
			self.FUN_2B1FC(v, hitDetection.position);
			short id2 = self.id;
			if (id2 < 0)
			{
				UIManager.instance.FUN_4E414(vector3Int, new Color32(0, 0, byte.MaxValue, 8));
				id2 = self.id;
			}
			param = -25;
			if (id2 < 0)
			{
				param = -100;
			}
			Vehicle vehicle = (Vehicle)self;
			vehicle.FUN_3A064(param, hitDetection.position, param3: false);
			vehicle.state = _VEHICLE_TYPE.Fence;
			GameManager.instance.FUN_30CB0(vehicle, 15);
		}
		else
		{
			FUN_32CF0(hit);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
			if (tags == 0)
			{
				DAT_19 = 1;
				break;
			}
			tags = 0;
			DAT_19 = 0;
			break;
		case 2:
			tags = 0;
			break;
		case 8:
			FUN_32B90((uint)arg2);
			break;
		case 9:
			if (arg2 == 0 && DAT_19 != 0)
			{
				FUN_33A28(36736u);
			}
			break;
		}
		return 0u;
	}
}
