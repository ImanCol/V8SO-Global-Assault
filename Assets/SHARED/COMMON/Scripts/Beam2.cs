using System.Collections.Generic;
using UnityEngine;

public class Beam2 : VigObject
{
	public new int DAT_A0;

	public List<VigObject> DAT_A4;

	public int DAT_A8;

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
		HitDetection hitDetection = new HitDetection(null);
		GameManager.instance.FUN_2FB70(this, hit, hitDetection);
		Vector3Int v = default(Vector3Int);
		v.x = hitDetection.position.x / 2;
		v.y = hitDetection.position.y / 2;
		v.z = hitDetection.position.z / 2;
		v = Utilities.FUN_24148(self.vTransform, v);
		if (self.type == 2)
		{
			Vehicle obj = (Vehicle)self;
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			obj.FUN_2B370(new Vector3Int
			{
				x = vigTransform.rotation.V02 << 7,
				z = vigTransform.rotation.V22 << 7,
				y = vigTransform.rotation.V12 << 7
			}, v);
			if (self.id < 0)
			{
				GameManager.instance.FUN_15ADC(~self.id, 20);
			}
			self.vTransform.position.y -= 10240;
			if (physics2.M2 == 0)
			{
				physics2.M2 = 1;
				LevelManager.instance.FUN_4DE54(v, 145);
				UIManager.instance.FUN_4E414(v, new Color32(128, 64, 0, 8));
			}
		}
		if (hit.self.type != 3)
		{
			VigObject self2 = hit.self;
			if (hit.self.type == 2)
			{
				if (!DAT_A4.Contains(hit.self))
				{
					maxHalfHealth = (ushort)DAT_A0;
					DAT_A4.Add(hit.self);
				}
				else
				{
					maxHalfHealth = (ushort)DAT_A8;
				}
			}
			type = 8;
			BufferedBinaryReader collider = hit.collider2;
			VigObject @object = hit.object2;
			hit.self = this;
			hit.collider2 = hit.collider1;
			hit.collider1 = collider;
			hit.object2 = hit.object1;
			hit.object1 = @object;
			uint result = self2.OnCollision(hit);
			type = 3;
			maxHalfHealth = (ushort)DAT_A8;
			return result;
		}
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
