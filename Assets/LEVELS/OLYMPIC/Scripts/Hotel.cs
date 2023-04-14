using UnityEngine;

public class Hotel : VigObject
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
		if (hit.collider1.ReadUInt16(0) == 1)
		{
			uint num = hit.collider1.ReadUInt16(2);
			if ((num == 1 || num == 2) && hit.self.type == 2)
			{
				ConfigContainer configContainer = FUN_2C5F4((ushort)((num - 32768) & 0xFFFF));
				if (configContainer != null)
				{
					Vehicle vehicle = (Vehicle)hit.self;
					if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
					{
						VigObject vigObject = Utilities.FUN_2CD78(this);
						if (vigObject == null)
						{
							vigObject = this;
						}
						int param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, vehicle.vTransform.position);
						GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
						vehicle.state = _VEHICLE_TYPE.Hotel;
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
							VigObject vigObject2 = vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (int)(num + 511));
						}
						GameManager.instance.FUN_30CB0(vehicle, 64);
						short num2 = 1;
						if (num == 1)
						{
							num2 = 2;
						}
						VigObject vigObject3 = vigObject.child2;
						while (true)
						{
							if (vigObject3 == null)
							{
								return 0u;
							}
							if (vigObject3.id == num2)
							{
								break;
							}
							vigObject3 = vigObject3.child;
						}
						Hotel2 hotel = new GameObject().AddComponent<Hotel2>();
						hotel.type = byte.MaxValue;
						hotel.id = num2;
						hotel.child = vigObject;
						GameManager.instance.FUN_30CB0(hotel, 90);
						return 0u;
					}
				}
			}
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
				if (vigObject.id - 1 < 2)
				{
					vigObject.maxHalfHealth = 30;
				}
				vigObject = vigObject.child;
			}
			return 0u;
		}
		return 0u;
	}
}
