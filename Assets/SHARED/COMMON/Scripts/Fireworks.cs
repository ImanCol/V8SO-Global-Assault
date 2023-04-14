using UnityEngine;

public class Fireworks : Destructible
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
		if (hit.object2.type == 3)
		{
			return 0u;
		}
		VigObject self = hit.self;
		FUN_32CF0(hit);
		HitDetection hitDetection = new HitDetection(null);
		GameManager.instance.FUN_2FB70(this, hit, hitDetection);
		Vector3Int vector3Int = Utilities.FUN_24148(v: new Vector3Int(hitDetection.position.x / 2, hitDetection.position.y / 2, hitDetection.position.z / 2), transform: self.vTransform);
		Ballistic obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C((ushort)GloryRocket.DAT_1510[DAT_19], typeof(Ballistic), 8u, typeof(VigChild)) as Ballistic;
		obj.type = 7;
		obj.flags = 36u;
		obj.screen = vector3Int;
		obj.FUN_3066C();
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			Vector3Int vector3Int2 = new Vector3Int(0, 0, 0);
			Vector3Int vector3Int3 = default(Vector3Int);
			vector3Int3.x = (vigTransform.rotation.V02 << 11) / 96;
			vector3Int3.y = (vigTransform.rotation.V12 << 11) / 96;
			vector3Int3.z = (vigTransform.rotation.V22 << 11) / 96;
			vector3Int2 = vector3Int3;
			vehicle.FUN_2B370(vector3Int3, vector3Int);
			vehicle.vTransform.position.y -= 2560;
			int num = (int)GameManager.FUN_2AC5C();
			if (num << 2 >> 15 == 0 && vehicle.GetPowerup(DAT_19) != 0)
			{
				num = (int)GameManager.FUN_2AC5C();
				vector3Int2.x = (num * 3051 >> 15) - 1525;
				vector3Int2.y = -4577;
				num = (int)GameManager.FUN_2AC5C();
				vector3Int2.z = (num * 3051 >> 15) - 1525;
				LevelManager.instance.FUN_4AAC0((uint)(262144 << ((DAT_19 + 1) & 0x1F)), vehicle.vTransform.position, vector3Int2);
				vehicle.SetPowerup(DAT_19, 0);
			}
		}
		flags |= 32u;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			VigChild vigChild = child2 as VigChild;
			DAT_4A = GameManager.instance.timer;
			FUN_30BF0();
			flags &= 4294967293u;
			ushort timer = GameManager.instance.timer;
			while (vigChild != null)
			{
				vigChild.state = _CHILD_TYPE.Child;
				vigChild.DAT_4A = timer;
				vigChild = (vigChild.child2 as VigChild);
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			if (parent != null)
			{
				VigObject param = FUN_2CCBC();
				base.transform.parent = null;
				GameManager.instance.FUN_307CC(param);
				return uint.MaxValue;
			}
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
