using System;
using UnityEngine;

public class Mausoleum : VigObject
{
	public VigObject[] DAT_88 = new VigObject[2];

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
		if (physics1.X != 0)
		{
			physics1.X = 0;
		}
		if (hit.collider1.ReadUInt16(0) != 1 || hit.collider1.ReadUInt16(2) == 0)
		{
			if ((hit.self.type != 2 || hit.object1 == this) && hit.self.type != 8)
			{
				return 0u;
			}
			hit.object1.FUN_32B90(hit.self.maxHalfHealth);
			return 0u;
		}
		if (tags != 1)
		{
			return 0u;
		}
		if (hit.self.type != 2)
		{
			return 0u;
		}
		ConfigContainer configContainer = DAT_84.FUN_2C5F4(32770);
		if (configContainer == null)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)hit.self;
		if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, vehicle.vTransform.position);
			GameManager.instance.FUN_1E2C8(vehicle.DAT_18, 0u);
			vehicle.state = _VEHICLE_TYPE.Mansion;
			vehicle.tags = 0;
			vehicle.flags = (uint)(((int)vehicle.flags & -3) | 0x6000020);
			VigTransform vigTransform = GameManager.instance.FUN_2CEAC(DAT_84, configContainer);
			vehicle.screen = vigTransform.position;
			vehicle.vr = configContainer.v3_2;
			vehicle.vr.y += DAT_84.vr.y;
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
				param = 2000;
				if (GetType() == typeof(Mansion))
				{
					param = 2001;
				}
				VigObject vigObject = vehicle.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, param);
			}
			GameManager.instance.FUN_30CB0(vehicle, 58);
			if (-1 < vehicle.id)
			{
				return 0u;
			}
			UIManager.instance.FUN_4E3A8(new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 2));
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 <= 2)
		{
			if (arg1 != 1)
			{
				if (arg1 == 2)
				{
					sbyte tags = base.tags;
					if (tags == 0)
					{
						base.tags = 1;
						GameManager.instance.FUN_30CB0(this, 600);
						int num = 0;
						do
						{
							ConfigContainer configContainer = FUN_2C5F4((ushort)((num - 32768) & 0xFFFF));
							if (configContainer != null)
							{
								VigObject vigObject = vData.ini.FUN_2C17C(19, typeof(VigObject), 8u);
								if (vigObject != null)
								{
									vigObject.vTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
									vigObject.flags = 52u;
									vigObject.FUN_305FC();
									DAT_88[num] = vigObject;
									int param = GameManager.instance.FUN_1DD9C();
									GameManager.instance.FUN_1E580(param, vData.sndList, 2, vigObject.vTransform.position);
								}
							}
							num++;
						}
						while (num < 2);
						FUN_2E868(1u);
						return 0u;
					}
					if (0 < tags)
					{
						if (tags != 1)
						{
							return 0u;
						}
						int num = 0;
						do
						{
							if (DAT_88[num] != null)
							{
								GameManager.instance.FUN_309A0(DAT_88[num]);
								DAT_88[num] = null;
							}
							num++;
						}
						while (num < 2);
						num = (int)GameManager.FUN_2AC5C();
						GameManager.instance.FUN_30CB0(DAT_84, (num * 300 >> 15) + 300);
						base.tags = 0;
						FUN_2E900(1u);
						return 0u;
					}
					if (tags != -1)
					{
						return 0u;
					}
					if (DAT_84 == null)
					{
						Type typeFromHandle = typeof(Mansion);
						if (GetType() == typeof(Mansion))
						{
							typeFromHandle = typeof(Mausoleum);
						}
						VigObject vigObject = DAT_84 = GameManager.instance.FUN_31994(typeFromHandle);
						if (vigObject != null)
						{
							vigObject.DAT_84 = this;
							int num = (int)GameManager.FUN_2AC5C();
							GameManager.instance.FUN_30CB0(this, (num * 300 >> 15) + 300);
						}
					}
					base.tags = 0;
					goto IL_026f;
				}
			}
			else
			{
				VigObject vigObject = child2;
				while (vigObject != null)
				{
					if (vigObject.id == 1)
					{
						vigObject.maxHalfHealth = 1;
						break;
					}
					vigObject = vigObject.child2;
				}
				base.tags = -1;
				GameManager.instance.FUN_30CB0(this, 2);
			}
		}
		else if (arg1 != 8)
		{
			if (arg1 == 9)
			{
				if (arg2 == 0)
				{
					return 0u;
				}
				if (base.tags != 0)
				{
					return 0u;
				}
				goto IL_026f;
			}
		}
		else
		{
			physics1.X = arg2;
		}
		return 0u;
		IL_026f:
		FUN_2E900(1u);
		return 0u;
	}
}
