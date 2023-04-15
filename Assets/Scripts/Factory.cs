using UnityEngine;

public class Factory : VigObject
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
					BufferedBinaryReader collider = hit.collider1;
					VigCamera vCamera = vehicle.vCamera;
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, vData.sndList, 5, vehicle.vTransform.position);
					GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
					vehicle.state = _VEHICLE_TYPE.Factory;
					vehicle.physics1.X = 0;
					vehicle.flags |= 100663330u;
					vehicle.physics1.Y = 117120;
					vehicle.physics1.Z = 0;
					if (vCamera != null)
					{
						vCamera.DAT_84 = new Vector3Int(0, -457, -3051);
						vCamera.flags |= 201326592u;
					}
					Vector3Int v = default(Vector3Int);
					v.x = (collider.ReadInt32(4) + collider.ReadInt32(16)) / 2;
					v.y = collider.ReadInt32(20);
					v.z = (collider.ReadInt32(12) + collider.ReadInt32(24)) / 2;
					v = Utilities.FUN_24148(vTransform, v);
					vehicle.physics1.X = (v.x - vehicle.vTransform.position.x) * 2;
					vehicle.physics1.Y = (v.y - vehicle.vTransform.position.y) * 2;
					vehicle.physics1.Z = (v.z - vehicle.vTransform.position.z) * 2;
					VigTransform vigTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
					vehicle.screen = vigTransform.position;
					vehicle.vr = configContainer.v3_2;
					GameManager.instance.FUN_30CB0(vehicle, 64);
					return 0u;
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
