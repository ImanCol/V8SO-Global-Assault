using UnityEngine;

public class Warehouse : VigObject
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
			ushort num = hit.collider1.ReadUInt16(2);
			uint num2 = num;
			if (num2 != 0 && hit.self.type == 2)
			{
				ConfigContainer configContainer = FUN_2C5F4((ushort)((num2 - 32768) & 0xFFFF));
				if (configContainer != null)
				{
					Vehicle vehicle = (Vehicle)hit.self;
					if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
					{
						int param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, vehicle.vTransform.position);
						GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
						vehicle.state = _VEHICLE_TYPE.Warehouse;
						vehicle.tags = 0;
						vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
						VigTransform vigTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
						vehicle.screen = vigTransform.position;
						vehicle.vr = configContainer.v3_2;
						vehicle.DAT_DE = (byte)num;
						if (num2 - 2 < 3)
						{
							if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || vehicle.id == -1)
							{
								vehicle.FUN_3E32C(_WHEELS.Sea, 500);
								if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
								{
									ClientSend.Pickup(8, 0, 0);
								}
							}
							else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
							{
								vehicle.FUN_3E32C(_WHEELS.Sea, 500);
								ClientSend.PickupAI(vehicle.id, 8, 0, 0);
							}
						}
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
							VigObject vigObject = vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (int)(num2 + 511));
						}
						GameManager.instance.FUN_30CB0(vehicle, 64);
						return 0u;
					}
				}
			}
		}
		if (hit.self.type != 8)
		{
			return 0u;
		}
		FUN_32B90(hit.self.maxHalfHealth);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0u;
		}
		FUN_32B90((uint)arg2);
		return 0u;
	}
}
