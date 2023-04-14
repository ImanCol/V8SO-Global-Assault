using UnityEngine;

public class Afterburner : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			Vehicle vehicle = (Vehicle)PDAT_78;
			if ((vehicle.flags & 0x4000000) != 0)
			{
				return 0u;
			}
			id--;
			VigObject vigObject;
			if (id == -1)
			{
				vehicle.DAT_F6 &= 65279;
				vigObject = Utilities.FUN_2CD78(this);
				Throwaway obj = vData.ini.FUN_2C17C(197, typeof(Throwaway), 0u) as Throwaway;
				ConfigContainer param = vigObject.FUN_2C5F4(32769);
				obj.vTransform = GameManager.instance.FUN_2CEAC(vigObject, param);
				obj.type = 4;
				obj.flags = 160u;
				int num = obj.vTransform.rotation.V02;
				obj.state = _THROWAWAY_TYPE.Unspawnable;
				if (num < 0)
				{
					num += 3;
				}
				int num2 = obj.vTransform.rotation.V12;
				obj.physics1.Z = num >> 2;
				if (num2 < 0)
				{
					num2 += 3;
				}
				obj.physics1.W = num2 >> 2;
				num = obj.vTransform.rotation.V22;
				if (num < 0)
				{
					num += 3;
				}
				obj.physics2.X = num >> 2;
				obj.DAT_87 = 2;
				obj.FUN_305FC();
				VigObject param2 = FUN_2CCBC();
				GameManager.instance.FUN_307CC(param2);
				if (vigObject.maxHalfHealth != 0)
				{
					return uint.MaxValue;
				}
				vigObject.FUN_3A368();
				return uint.MaxValue;
			}
			vehicle.physics1.X += vehicle.vTransform.rotation.V02 * 4;
			vehicle.physics1.Y += vehicle.vTransform.rotation.V12 * 4;
			vehicle.physics1.Z += vehicle.vTransform.rotation.V22 * 4;
			if (((ushort)id & 3) != 0)
			{
				return 0u;
			}
			Vector3Int param3 = GameManager.instance.FUN_2CE50(this);
			vigObject = LevelManager.instance.FUN_4DE54(param3, 7);
			vigObject.flags |= 1024u;
			vigObject.vr.z = id * 96;
			vigObject.ApplyTransformation();
			break;
		}
		case 4:
		{
			Vehicle vehicle = (Vehicle)PDAT_78;
			vehicle.DAT_F6 &= 65279;
			break;
		}
		}
		return 0u;
	}
}
