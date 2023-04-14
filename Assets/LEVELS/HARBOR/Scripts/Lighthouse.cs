using UnityEngine;

public class Lighthouse : VigObject
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
		if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) != 0 && hit.self.type == 2)
		{
			ConfigContainer configContainer = FUN_2C5F4(32768);
			if (configContainer != null)
			{
				Vehicle vehicle = (Vehicle)hit.self;
				if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
				{
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, vehicle.vTransform.position);
					GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
					vehicle.state = _VEHICLE_TYPE.Lighthouse;
					vehicle.tags = 0;
					vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
					VigTransform vigTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
					vehicle.screen = vigTransform.position;
					vehicle.vr = configContainer.v3_2;
					vehicle.vr.y += vr.y;
					GameManager.instance.FUN_2F798(this, hit);
					vehicle.physics1.X = hit.normal1.x * 476;
					vehicle.physics1.Y = hit.normal1.y * 476;
					vehicle.physics1.Z = hit.normal1.z * 476;
					vehicle.physics2.X = 0;
					vehicle.physics2.Y = 0;
					vehicle.physics2.Z = 0;
					VigCamera vCamera = vehicle.vCamera;
					if (vCamera != null)
					{
						vCamera.DAT_84 = new Vector3Int(0, 0, 0);
						vCamera.flags |= 201326592u;
					}
					GameManager.instance.FUN_30CB0(vehicle, 64);
					return 0u;
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
			VigObject child = child2;
			while (child != null)
			{
				child.maxHalfHealth = 100;
				child = child.child2;
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
