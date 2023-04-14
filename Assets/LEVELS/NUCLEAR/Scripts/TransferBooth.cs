using UnityEngine;

public class TransferBooth : VigObject
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
		if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) == 1)
		{
			if (hit.self.type != 2)
			{
				return 0u;
			}
			Vehicle vehicle = (Vehicle)hit.self;
			if ((vehicle.flags & 0x6000000) != 0 || (vehicle.flags & 0x4000) == 0)
			{
				return 0u;
			}
			Utilities.FUN_2CD78(this);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, vehicle.vTransform.position);
			GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
			vehicle.state = _VEHICLE_TYPE.TransferBooth;
			vehicle.tags = 0;
			vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
			int num = id - 49;
			uint num2 = GameManager.FUN_2AC5C();
			num2 &= 3;
			int param2 = 0;
			if ((int)num2 < 2)
			{
				num = (int)((num2 ^ 1) + 49);
				param2 = (int)((num2 ^ 1) + 512);
			}
			else if ((int)num2 < 4)
			{
				num = (int)(num2 + 512);
				param2 = num;
			}
			VigObject vigObject = GameManager.instance.FUN_31950(num);
			if (vigObject != null)
			{
				ConfigContainer configContainer = vigObject.FUN_2C5F4(32768);
				if (configContainer != null)
				{
					VigTransform vigTransform = GameManager.instance.FUN_2CEAC(vigObject, configContainer);
					vehicle.screen = vigTransform.position;
					vehicle.vr = configContainer.v3_2;
					vehicle.vr.y += vigObject.vr.y;
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
						VigObject vigObject2 = vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, param2);
					}
				}
			}
			GameManager.instance.FUN_30CB0(vehicle, 64);
			return 0u;
		}
		if (hit.self.type != 8)
		{
			return 0u;
		}
		hit.object1.FUN_32B90(hit.self.maxHalfHealth);
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
				if (vigObject.id != 0)
				{
					vigObject.type = 3;
				}
				vigObject = vigObject.child;
			}
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
