using UnityEngine;

public class MineEntry : VigObject
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
			if ((vehicle.flags & 0x4000000) != 0 || (vehicle.flags & 0x4000) == 0)
			{
				return 0u;
			}
			Utilities.FUN_2CD78(this);
			int num = 0;
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, vehicle.vTransform.position);
			GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
			vehicle.state = _VEHICLE_TYPE.Observatory2;
			vehicle.tags = 0;
			vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
			int num2 = id;
			int param2 = 0;
			if (num2 == 81)
			{
				uint num3 = GameManager.FUN_2AC5C();
				if ((num3 & 2) != 0)
				{
					num2 = (int)((num3 & 1) + 82);
				}
			}
			switch (num2)
			{
			case 82:
				param2 = 515;
				num2 = 83;
				break;
			case 81:
				param2 = 516;
				num = 4;
				num2 = 33;
				break;
			case 83:
				param2 = 514;
				num2 = 82;
				break;
			}
			VigObject vigObject = GameManager.instance.FUN_31950(num2);
			if (vigObject != null)
			{
				ConfigContainer configContainer = vigObject.FUN_2C5F4((ushort)((num - 32768) & 0xFFFC));
				if (configContainer != null)
				{
					if (num2 == 33)
					{
						VigObject vigObject2 = vigObject.child2;
						while (vigObject2 != null)
						{
							if (vigObject2.id == 1)
							{
								vigObject2.FUN_4DC94();
							}
							vigObject2 = vigObject2.child;
						}
					}
					VigTransform vigTransform = GameManager.instance.FUN_2CEAC(vigObject, configContainer);
					vehicle.screen = vigTransform.position;
					vehicle.vr = configContainer.v3_2;
					vehicle.vr.y += vigObject.vr.y;
					BufferedBinaryReader collider = hit.collider1;
					Vector3Int v = Utilities.FUN_24148(GameManager.instance.FUN_2CDF4(this), new Vector3Int
					{
						x = (collider.ReadInt32(4) + collider.ReadInt32(16)) / 2,
						y = (collider.ReadInt32(8) + collider.ReadInt32(20)) / 2,
						z = (collider.ReadInt32(12) + collider.ReadInt32(24)) / 2
					});
					Utilities.FUN_2A168(out Vector3Int vout, vehicle.vTransform.position, v);
					vehicle.physics1.X = vout.x * 143;
					vehicle.physics1.Y = vout.y * 143;
					vehicle.physics1.Z = vout.z * 143;
					vehicle.physics2.X = 0;
					vehicle.physics2.Y = 0;
					vehicle.physics2.Z = 0;
					VigCamera vCamera = vehicle.vCamera;
					if (vCamera != null)
					{
						vCamera.DAT_84 = new Vector3Int(0, 0, 0);
						vCamera.flags |= 201326592u;
						VigObject vigObject3 = vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, param2);
					}
				}
			}
			GameManager.instance.FUN_30CB0(vehicle, 64);
			return 0u;
		}
		if (hit.self.type != 0)
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
