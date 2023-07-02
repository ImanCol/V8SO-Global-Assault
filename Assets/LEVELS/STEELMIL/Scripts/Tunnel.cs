using UnityEngine;

public class Tunnel : Destructible
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
		if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) != 0 && hit.self.type == 2 && (hit.self.flags & 0x4000000) == 0)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
			{
				uint num2;
				int num;
				do
				{
					num = (int)GameManager.FUN_2AC5C();
					num2 = (uint)((num * 3 >> 15) + 40);
					vehicle.DAT_DE = (byte)num2;
				}
				while ((num2 & 0xFF) == id);
				GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
				vehicle.state = _VEHICLE_TYPE.Tunnel;
				vehicle.tags = 0;
				vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
				num = vTransform.rotation.V02 * 4577;
				if (num < 0)
				{
					num += 31;
				}
				vehicle.physics1.X = num >> 5;
				num = vTransform.rotation.V12 * 4577;
				if (num < 0)
				{
					num += 31;
				}
				vehicle.physics1.Y = num >> 5;
				num = vTransform.rotation.V22 * 4577;
				if (num < 0)
				{
					num += 31;
				}
				vehicle.physics1.Z = num >> 5;
				GameManager.instance.FUN_30CB0(vehicle, 120);
				VigCamera vCamera = vehicle.vCamera;
				if (vCamera != null)
				{
					vCamera.DAT_84 = new Vector3Int(0, 0, 0);
					vCamera.flags |= 201326592u;
					VigObject vigObject = vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, vehicle.DAT_DE + 472);
				}
			}
			return 1u;
		}
		FUN_32CF0(hit);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 8)
		{
			FUN_32B90((uint)arg2);
		}
		return 0u;
	}
}
