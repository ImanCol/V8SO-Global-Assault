using UnityEngine;

public class Observatory : VigObject
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
		VigObject vigObject2;
		int param;
		if (hit.collider1.ReadUInt16(0) == 1)
		{
			short num = hit.collider1.ReadInt16(2);
			switch (num)
			{
			case 3:
			case 4:
			{
				if (hit.self.type != 2)
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
					vehicle.tags = 0;
					vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
					if (num == 3)
					{
						ConfigContainer configContainer = FUN_2C5F4(32773);
						if (configContainer != null)
						{
							VigTransform vigTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
							vehicle.state = _VEHICLE_TYPE.Observatory;
							vehicle.screen = vigTransform.position;
							vehicle.vr = configContainer.v3_2;
							vehicle.vr.y += vr.y;
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
								vehicle.PDAT_74 = null;
								vehicle.IDAT_74 = 0;
								vehicle.CCDAT_74 = null;
							}
							GameManager.instance.FUN_30CB0(vehicle, 64);
							return 0u;
						}
					}
					int num2 = 0;
					uint num3 = GameManager.FUN_2AC5C();
					if ((num3 & 3) != 0)
					{
						num2 = (int)((num3 & 3) - 1);
					}
					VigObject vigObject = GameManager.instance.FUN_31950(num2 + 81);
					if (vigObject != null)
					{
						ConfigContainer configContainer2 = vigObject.FUN_2C5F4(32768);
						if (configContainer2 != null)
						{
							VigTransform vigTransform = GameManager.instance.FUN_2CEAC(vigObject, configContainer2);
							vehicle.state = _VEHICLE_TYPE.Observatory2;
							vehicle.screen = vigTransform.position;
							vehicle.vr = configContainer2.v3_2;
							vehicle.vr.y += vigObject.vr.y;
							BufferedBinaryReader collider = hit.collider1;
							Vector3Int v2 = Utilities.FUN_24148(GameManager.instance.FUN_2CDF4(this), new Vector3Int
							{
								x = (collider.ReadInt32(4) + collider.ReadInt32(16)) / 2,
								y = (collider.ReadInt32(8) + collider.ReadInt32(20)) / 2,
								z = (collider.ReadInt32(12) + collider.ReadInt32(24)) / 2
							});
							Utilities.FUN_2A168(out Vector3Int vout2, vehicle.vTransform.position, v2);
							vehicle.physics1.X = vout2.x * 143;
							vehicle.physics1.Y = vout2.y * 143;
							vehicle.physics1.Z = vout2.z * 143;
							vehicle.physics2.X = 0;
							vehicle.physics2.Y = 0;
							vehicle.physics2.Z = 0;
							VigCamera vCamera = vehicle.vCamera;
							if (vCamera != null)
							{
								vCamera.DAT_84 = new Vector3Int(0, 0, 0);
								vCamera.flags |= 201326592u;
								vigObject2 = (vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, num2 + 513));
							}
						}
					}
					GameManager.instance.FUN_30CB0(vehicle, 64);
				}
				return 0u;
			}
			case 5:
				if (hit.self.type != 2)
				{
					return 0u;
				}
				PDAT_78 = hit.self;
				GameManager.instance.FUN_30CB0(this, 30);
				return 0u;
			}
		}
		if ((hit.self.type != 2 || hit.object1 == this) && hit.self.type != 8)
		{
			return 0u;
		}
		vigObject2 = hit.self;
		param = 10;
		if (vigObject2.type != 2)
		{
			param = vigObject2.maxHalfHealth;
		}
		if (hit.object1.FUN_32B90((uint)param) && Utilities.FUN_2CD78(hit.object1) == null)
		{
			Ant.FUN_134C();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			PDAT_78 = null;
			return 0u;
		}
		if (arg1 < 3)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				if ((ushort)vigObject.id - 1 < 2)
				{
					vigObject.maxHalfHealth = 30;
				}
				else if (vigObject.id != 0)
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
		if (FUN_32B90((uint)arg2))
		{
			VigObject vigObject = Utilities.FUN_2CD78(this);
			if (vigObject == null)
			{
				Ant.FUN_134C();
			}
		}
		return 0u;
	}
}
