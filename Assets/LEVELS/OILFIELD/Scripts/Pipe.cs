using UnityEngine;

public class Pipe : Destructible
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
		if (id < 99 && hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) == 1)
		{
			if (hit.self.type == 2 && (hit.self.flags & 0x4000000) == 0)
			{
				Vehicle vehicle = (Vehicle)hit.self;
				if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
				{
					int num;
					if (id == 98)
					{
						num = (int)GameManager.FUN_2AC5C();
						num = (num << 1 >> 15) + 99;
					}
					else
					{
						num = (int)GameManager.FUN_2AC5C();
						num = (num * 3 >> 15) + 98;
					}
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, vehicle.vTransform.position);
					GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
					vehicle.state = _VEHICLE_TYPE.Pipe;
					vehicle.tags = 0;
					vehicle.DAT_19 = (byte)num;
					vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
					param = 401;
					if (num == 100 && id != 98)
					{
						param = 400;
					}
					VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, param);
					if (id == 98 && num == 100)
					{
						vehicle.DAT_19 = 102;
					}
					vehicle.screen = vigObject.screen;
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
						VigObject vigObject2 = vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 514);
					}
					GameManager.instance.FUN_30CB0(vehicle, 64);
				}
			}
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
		{
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id == 1)
				{
					vigObject.type = 3;
				}
				vigObject = vigObject.child;
			}
			break;
		}
		case 8:
			FUN_32B90((uint)arg2);
			break;
		case 9:
			if (arg2 != 0)
			{
				child2.type = 3;
			}
			break;
		}
		return 0u;
	}
}
