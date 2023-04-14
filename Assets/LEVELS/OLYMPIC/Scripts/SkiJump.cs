using UnityEngine;

public class SkiJump : VigObject
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
		VigObject vigObject;
		int param;
		if (hit.collider1.ReadUInt16(0) == 1)
		{
			short num = hit.collider1.ReadInt16(2);
			if (num == 1)
			{
				if (hit.self.type != 2)
				{
					return 0u;
				}
				ConfigContainer configContainer = FUN_2C5F4(32768);
				if (configContainer == null)
				{
					return 0u;
				}
				Vehicle vehicle = (Vehicle)hit.self;
				if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
				{
					Utilities.FUN_2CD78(this);
					param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, vehicle.vTransform.position);
					GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
					vehicle.state = _VEHICLE_TYPE.SkiJump;
					vehicle.tags = 0;
					vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
					VigTransform vigTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
					vehicle.screen = vigTransform.position;
					vehicle.vr = configContainer.v3_2;
					vehicle.vr.y += vr.y;
					HitDetection hitDetection = new HitDetection(null);
					GameManager.instance.FUN_2FB70(this, hit, hitDetection);
					vehicle.physics1.X = hitDetection.normal1.x * -143;
					vehicle.physics1.Y = hitDetection.normal1.y * -143;
					vehicle.physics1.Z = hitDetection.normal1.z * -143;
					vehicle.physics2.X = 0;
					vehicle.physics2.Y = 0;
					vehicle.physics2.Z = 0;
					VigCamera vCamera = vehicle.vCamera;
					if (vCamera != null)
					{
						vCamera.DAT_84 = new Vector3Int(0, 0, 0);
						vCamera.flags |= 201326592u;
						vigObject = (vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 514));
					}
					GameManager.instance.FUN_30CB0(vehicle, 64);
					return 0u;
				}
			}
			switch (num)
			{
			case 2:
			{
				vigObject = hit.self;
				if (vigObject.type != 2)
				{
					return 0u;
				}
				VigTransform vigTransform2 = GameManager.instance.FUN_2CDF4(hit.object1);
				vigObject.physics1.X += vigTransform2.rotation.V02 * 4;
				vigObject.physics1.Y += vigTransform2.rotation.V12 * 4;
				vigObject.physics1.Z += vigTransform2.rotation.V22 * 4;
				return 0u;
			}
			case 3:
			{
				if (hit.self.type != 2)
				{
					return 0u;
				}
				Vehicle vehicle = (Vehicle)hit.self;
				VigTransform vigTransform2 = GameManager.instance.FUN_2CDF4(hit.object1);
				vehicle.physics1.X += vigTransform2.rotation.V02 * 32;
				vehicle.physics1.Y += vigTransform2.rotation.V12 * 32;
				vehicle.physics1.Z += vigTransform2.rotation.V22 * 32;
				if (vehicle.state != _VEHICLE_TYPE.Vehicle)
				{
					return 0u;
				}
				vehicle.state = _VEHICLE_TYPE.SkiJump2;
				param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, vData.sndList, 0, vehicle.vTransform.position);
				return 0u;
			}
			}
		}
		if ((hit.self.type != 2 || hit.object1 == this) && hit.self.type != 8)
		{
			return 0u;
		}
		vigObject = hit.self;
		param = 10;
		if (vigObject.type != 2)
		{
			param = vigObject.maxHalfHealth;
		}
		hit.object1.FUN_32B90((uint)param);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id == 1)
				{
					vigObject.maxHalfHealth = 30;
				}
				else if ((uint)(ushort)((ushort)vigObject.id - 2) < 2u)
				{
					vigObject.type = 3;
				}
				vigObject = vigObject.child;
			}
			return 0u;
		}
		if (arg1 == 9 && arg2 == 1)
		{
			LevelManager.instance.FUN_359FC(53936128, 88604672, 0u);
			return 0u;
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		FUN_32B90((uint)arg2);
		return 0u;
	}
}
