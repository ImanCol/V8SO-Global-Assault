using System.Collections.Generic;
using UnityEngine;

public class MegaCollider : VigObject
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
			FUN_42330(arg2);
			return 0u;
		case 4:
			GameManager.instance.DAT_1084--;
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		switch (arg1)
		{
		case 0:
			FUN_42330(arg2);
			return 0u;
		case 1:
			type = 3;
			maxHalfHealth = 3;
			break;
		case 12:
		{
			if (DAT_19 != 0 && maxHalfHealth != 0)
			{
				return 0u;
			}
			Beam beam = arg2.vData.ini.FUN_2C17C(3, typeof(Beam), 8u) as Beam;
			if (beam != null)
			{
				uint num = 0u;
				beam.flags = 1610613248u;
				ushort num2 = (ushort)arg2.id;
				beam.type = 8;
				beam.DAT_80 = arg2;
				beam.id = (short)num2;
				VigTransform vigTransform = beam.vTransform = GameManager.instance.FUN_2CDF4(arg2);
				ConfigContainer cont = FUN_2C5F4(32768);
				Utilities.FUN_2CA94(this, cont, beam);
				Utilities.ParentChildren(this, this);
				beam.FUN_30BF0();
				beam.FUN_30B78();
				VigTransform vigTransform2 = GameManager.instance.FUN_2CDF4(beam);
				Vector3Int v = default(Vector3Int);
				beam.DAT_84_2 = new Beam2[15];
				do
				{
					Beam2 beam2 = arg2.vData.ini.FUN_2C17C(1, typeof(Beam2), 8u) as Beam2;
					if (beam2 != null)
					{
						beam2.flags = 1610612742u;
						num2 = (ushort)arg2.id;
						beam2.type = 3;
						beam2.DAT_80 = arg2;
						beam2.DAT_A0 = (ushort)((15 - num) * 4);
						beam2.DAT_A8 = 4;
						if (((Vehicle)arg2).doubleDamage != 0)
						{
							beam2.DAT_A0 = (ushort)((15 - num) * 8);
							beam2.DAT_A8 = 8;
						}
						beam2.id = (short)num2;
						beam2.vTransform = vigTransform2;
						if (num == 0)
						{
							ConfigContainer configContainer = beam2.FUN_2C5F4(32768);
							beam.DAT_D0 = configContainer.v3_1;
							v = beam.DAT_D0;
						}
						else
						{
							beam2.vTransform.position = Utilities.FUN_24148(vigTransform2, v);
							v.x += beam.DAT_D0.x;
							v.y += beam.DAT_D0.y;
							v.z += beam.DAT_D0.z;
						}
						if ((num & 1) != 0)
						{
							beam2.flags |= 32u;
						}
						beam2.FUN_305FC();
						beam.DAT_84_2[num] = beam2;
						beam2.DAT_A4 = new List<VigObject>();
					}
					num++;
				}
				while ((int)num < 15);
				VigObject vigObject = arg2.vData.ini.FUN_2C17C(2, typeof(VigObject), 8u);
				if (vigObject != null)
				{
					vigObject.flags = 536870912u;
					num2 = (ushort)arg2.id;
					vigObject.type = 3;
					vigObject.id = (short)num2;
					vigObject.vTransform = GameManager.FUN_2A39C();
					cont = beam.DAT_84_2[0].FUN_2C5F4(32768);
					Utilities.FUN_2CA94(beam.DAT_84_2[0], cont, vigObject);
					Utilities.ParentChildren(beam.DAT_84_2[0], beam.DAT_84_2[0]);
					beam.DAT_C0 = vigObject;
				}
				maxHalfHealth--;
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, arg2.vData.sndList, 3, arg2.vTransform.position);
				param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param, arg2.vData.sndList, 2);
				GameManager.instance.FUN_30CB0(beam, 2);
				beam.DAT_C4 = this;
				GameManager.instance.DAT_1084++;
			}
			return 360u;
		}
		case 13:
			if (GameManager.instance.DAT_1084 != 0)
			{
				return 0u;
			}
			if (arg2.physics1.W < 3051 && (arg2.flags & 0x20000000) != 0)
			{
				Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
				if (1458174u < (uint)(vector3Int.z - 102401))
				{
					return 0u;
				}
				if (vector3Int.x < 0)
				{
					vector3Int.x = -vector3Int.x;
				}
				if (vector3Int.x * 6 >= vector3Int.z)
				{
					return 0u;
				}
				return 1u;
			}
			break;
		}
		return 0u;
	}
}
