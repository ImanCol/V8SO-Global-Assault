using UnityEngine;

public class LaunchEntry : VigObject
{
	protected override void Update()
	{
		base.Update();
	}

	protected override void Start()
	{
		base.Start();
	}

	public override uint OnCollision(HitDetection hit)
	{
		VigObject self = hit.self;
		if (self.type != 2 || (self.flags & 0x4000000) != 0 || (self.flags & 0x4000) == 0 || hit.collider1.ReadUInt16(0) != 1 || hit.collider1.ReadUInt16(2) == 0)
		{
			if (hit.self.type != 8)
			{
				return 0u;
			}
			FUN_32B90(hit.self.maxHalfHealth);
			return 0u;
		}
		Vehicle vehicle = (Vehicle)self;
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 36, self.vTransform.position);
		HitDetection hitDetection = new HitDetection(null);
		GameManager.instance.FUN_2FB70(this, hit, hitDetection);
		GameManager.instance.FUN_1E2C8(self.DAT_18, 0u);
		self.tags = 0;
		self.flags = (uint)(((int)self.flags & -3) | 0x6000020);
		self.physics1.X = hitDetection.normal1.x * -143;
		self.physics1.Y = hitDetection.normal1.y * -143;
		self.physics1.Z = hitDetection.normal1.z * -143;
		self.physics2.X = 0;
		self.physics2.Y = 0;
		self.physics2.Z = 0;
		GameManager.instance.FUN_30CB0(self, 64);
		ushort num;
		VigTransform vigTransform;
		if (tags == 0)
		{
			VigObject vigObject = GameManager.instance.FUN_318D0(113);
			if (vigObject != null)
			{
				ConfigContainer configContainer = vigObject.FUN_2C5F4(32768);
				if (configContainer != null)
				{
					vigTransform = GameManager.instance.FUN_2CEAC(vigObject, configContainer);
					num = 2;
					self.screen = vigTransform.position;
					self.screen.y += 327680;
					self.vr = configContainer.v3_2;
					vehicle.state = _VEHICLE_TYPE.LaunchEntry;
					GameManager.instance.FUN_30CB0(this, 0);
					goto IL_026a;
				}
			}
		}
		VigObject vigObject2 = GameManager.instance.FUN_318D0(49);
		num = (ushort)GameManager.FUN_2AC5C();
		num = (ushort)(num & 1);
		ConfigContainer configContainer2 = vigObject2.FUN_2C5F4((ushort)(num + 32768));
		vigTransform = GameManager.instance.FUN_2CEAC(vigObject2, configContainer2);
		self.screen = vigTransform.position;
		self.vr = configContainer2.v3_2;
		vehicle.state = _VEHICLE_TYPE.LaunchEntry2;
		goto IL_026a;
		IL_026a:
		VigCamera vCamera = vehicle.vCamera;
		if (vCamera == null)
		{
			return 0u;
		}
		vCamera.DAT_84 = new Vector3Int(0, 0, 0);
		vCamera.flags |= 201326592u;
		VigObject vigObject3 = self.PDAT_74 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, num + 513);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			int num = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_30CB0(this, (num * 600 >> 15) + 600);
			if (tags == 1)
			{
				VigObject vigObject = GameManager.instance.FUN_302A8(GameManager.instance.worldObjs, typeof(LaunchVehicle));
				if (vigObject != null && vigObject.vTransform.position.z < 79114241)
				{
					return 0u;
				}
			}
			GameManager.instance.FUN_2C0A0(this);
			GameManager.instance.FUN_2FEE8(this, (ushort)(DAT_4A + tags * 2));
			tags = (sbyte)(1 - tags);
			return 0u;
		}
		if (arg1 < 3)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			flags &= 4294967291u;
			GameManager.instance.FUN_30CB0(this, 600);
			GameManager.instance.FUN_2C0A0(this);
			GameManager.instance.FUN_2FEE8(this, DAT_4A);
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
