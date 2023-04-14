using UnityEngine;

public class GondStation : Destructible
{
	private static byte[] ai_collider = new byte[32]
	{
		1,
		0,
		0,
		0,
		15,
		66,
		253,
		255,
		222,
		134,
		253,
		255,
		38,
		111,
		255,
		255,
		242,
		189,
		0,
		0,
		35,
		121,
		0,
		0,
		0,
		142,
		0,
		0,
		0,
		0,
		0,
		0
	};

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
		VigObject self = hit.self;
		OLYMPIC oLYMPIC = (OLYMPIC)LevelManager.instance.level;
		if ((hit.object1.id == 1 || (hit.object1.id == 2 && self.id >= 0)) && self.type == 2 && (self.flags & 0x4000) != 0 && (self.flags & 0x4000000) == 0 && oLYMPIC.DAT_D2 != 0)
		{
			uint num = (uint)vr.y >> 31;
			if (oLYMPIC.DAT_D0 == 0)
			{
				num ^= 1;
			}
			VigObject vigObject = oLYMPIC.DAT_B0[num];
			vigObject.DAT_80 = self;
			((Vehicle)self).state = _VEHICLE_TYPE.Gondola;
			self.PDAT_78 = vigObject;
			self.flags = (uint)(((int)self.flags & -9) | 0x6000020);
			self.physics1.X = (vigObject.vTransform.position.x - self.vTransform.position.x) * 4;
			self.physics1.Y = (vigObject.vTransform.position.y - (self.vTransform.position.y - 65536)) * 4;
			self.physics1.Z = (vigObject.vTransform.position.z - self.vTransform.position.z) * 4;
			GameManager.instance.FUN_1E2C8(self.DAT_18, 0u);
			GameManager.instance.FUN_30CB0(self, 32);
			oLYMPIC.DAT_D2 = 1200;
			self.FUN_30BA8();
			self.FUN_30B78();
			VigCamera vCamera = ((Vehicle)self).vCamera;
			if (vCamera == null)
			{
				return 0u;
			}
			vCamera.FUN_30BA8();
			vCamera.FUN_30B78();
			return 0u;
		}
		if ((hit.self.type != 2 || hit.object1 == this) && hit.self.type != 8)
		{
			return 0u;
		}
		VigObject self2 = hit.self;
		int param = 10;
		if (self2.type != 2)
		{
			param = self2.maxHalfHealth;
		}
		hit.object1.FUN_32B90((uint)param);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			OLYMPIC oLYMPIC = (OLYMPIC)LevelManager.instance.level;
			OLYMPIC.FUN_CCC(oLYMPIC.DAT_80_2, oLYMPIC.pole1M, this);
			VigObject vigObject = new GameObject().AddComponent<VigObject>();
			vigObject.id = 2;
			vigObject.type = 3;
			vigObject.DAT_1A = 100;
			vigObject.vData = vData;
			vigObject.vCollider = new VigCollider(ai_collider);
			Utilities.FUN_2CC48(this, vigObject);
			vigObject.transform.parent = base.transform;
			vigObject.screen = new Vector3Int(-59000, 112262, -206838);
			vigObject.ApplyTransformation();
			break;
		}
		case 8:
			return 0u;
		case 9:
			if (arg2 == 1)
			{
				VigObject vigObject = new GameObject().AddComponent<VigObject>();
				vigObject.id = 2;
				vigObject.type = 3;
				vigObject.DAT_1A = 100;
				vigObject.vData = vData;
				vigObject.vCollider = new VigCollider(ai_collider);
				Utilities.FUN_2CC48(this, vigObject);
				vigObject.transform.parent = base.transform;
				vigObject.screen = new Vector3Int(-59000, 112262, -206838);
				vigObject.ApplyTransformation();
			}
			break;
		}
		return base.UpdateW(arg1, arg2);
	}
}
