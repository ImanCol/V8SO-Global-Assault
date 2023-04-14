using UnityEngine;

public class WindTunnel2 : VigObject
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
		uint result = 0u;
		VigObject self = hit.self;
		if (hit.collider1.ReadUInt16(0) == 1 && self.type == 2 && (self.flags & 0x4000000) == 0 && (self.flags & 0x4000) != 0)
		{
			Vector3Int vin = default(Vector3Int);
			vin.x = vTransform.position.x - self.vTransform.position.x;
			vin.y = vTransform.position.y - self.vTransform.position.y;
			vin.z = vTransform.position.z - self.vTransform.position.z;
			int num = Utilities.FUN_29FC8(vin, out Vector3Int vout);
			if (num < 786433)
			{
				Vector3Int vector3Int = default(Vector3Int);
				vector3Int.z = (786432 - num) / 384 * 128;
				GameManager.instance.FUN_30CB0(this, 300);
				vector3Int.x = vout.x * vector3Int.z;
				if (vector3Int.x < 0)
				{
					vector3Int.x += 4095;
				}
				vector3Int.y = vout.y * vector3Int.z;
				vector3Int.x >>= 12;
				if (vector3Int.y < 0)
				{
					vector3Int.y += 4095;
				}
				vector3Int.z = vout.z * vector3Int.z;
				vector3Int.y >>= 12;
				if (vector3Int.z < 0)
				{
					vector3Int.z += 4095;
				}
				vector3Int.z >>= 12;
				int x = self.physics1.X;
				int num2 = x;
				if (x < 0)
				{
					num2 = x + 63;
				}
				int y = self.physics1.Y;
				self.physics1.X = x + (vector3Int.x - (num2 >> 6));
				num2 = y;
				if (y < 0)
				{
					num2 = y + 63;
				}
				x = self.physics1.Z;
				self.physics1.Y = y + (vector3Int.y - (num2 >> 6));
				num2 = x;
				if (x < 0)
				{
					num2 = x + 63;
				}
				self.physics1.Z = x + (vector3Int.z - (num2 >> 6));
				num = vin.x;
				if (vin.x < 0)
				{
					num = -vin.x;
				}
				result = 0u;
				Vehicle vehicle = (Vehicle)self;
				if (num < 65537)
				{
					if (vehicle.vCamera != null)
					{
						VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, base.id + 418);
						vehicle.vCamera.flags |= 201326592u;
						if (vigObject != null)
						{
							vehicle.vCamera.screen = vigObject.vTransform.position;
						}
						GameManager.instance.FUN_30CB0(vehicle.vCamera, 60);
					}
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 7, vTransform.position);
					param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
					vehicle.state = _VEHICLE_TYPE.WindTunnel;
					vehicle.physics2.X = 0;
					vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
					vehicle.physics2.Y = 0;
					vehicle.physics2.Z = 43648;
					num = vTransform.rotation.V02 * 24414;
					if (num < 0)
					{
						num += 4095;
					}
					vehicle.physics1.X = num >> 12 << 7;
					int num3 = vTransform.rotation.V12 * 24414;
					num = num3 - 762;
					if (num < 0)
					{
						num = num3 + 3333;
					}
					vehicle.physics1.Y = num >> 12 << 7;
					num = vTransform.rotation.V22 * 24414;
					if (num < 0)
					{
						num += 4095;
					}
					vehicle.physics1.Z = num >> 12 << 7;
					GameManager.instance.FUN_30CB0(vehicle, 18);
					vehicle.vTransform.position = vTransform.position;
					param = -15;
					if (vehicle.id < 0)
					{
						UIManager.instance.FUN_4E338(new Color32(128, 128, 128, 8));
						if (vehicle.id < 0)
						{
							param = -50;
						}
					}
					vehicle.FUN_39DCC(param, LaunchRocket3.DAT_D4, param3: false);
					int id = vehicle.id;
					if (0 < id)
					{
						if (((Launch.instance.DAT_5874 >> id) & 1) != 0)
						{
							return 0u;
						}
						Launch.instance.DAT_5874 |= (byte)(1 << id);
						Launch.instance.DAT_5875++;
						if (Launch.instance.DAT_5875 != 2)
						{
							return 0u;
						}
					}
					result = 0u;
				}
			}
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		if (arg1 == 2)
		{
			FUN_30BA8();
			GameManager.instance.FUN_1DE78(DAT_18);
			GameManager.instance.FUN_309A0(this);
			result = uint.MaxValue;
		}
		else if (arg1 < 3)
		{
			result = 0u;
			if (arg1 == 0 && DAT_18 != 0 && arg2 != 0)
			{
				result = GameManager.instance.FUN_1E7A8(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, result);
				result = 0u;
			}
		}
		else
		{
			result = 0u;
		}
		return result;
	}
}
