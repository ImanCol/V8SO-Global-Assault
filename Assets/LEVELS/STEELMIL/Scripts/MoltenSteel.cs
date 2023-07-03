using System.Collections.Generic;
using UnityEngine;

public class MoltenSteel : VigObject
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
		VigObject self = hit.self;
		switch (self.type)
		{
		case 2:
		{
			Vehicle vehicle = (Vehicle)self;
			vehicle.physics1.Y -= 390528;
			flags |= 32u;
			LevelManager.instance.FUN_39AF8(vehicle);
			UIManager.instance.FUN_4E414(vehicle.vTransform.position, new Color32(128, 0, 0, 8));
			LevelManager.instance.FUN_4E8C8(vehicle.vTransform.position, 48);
			break;
		}
		case 3:
			return 0u;
		case 8:
			return 0u;
		}
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 69, self.vTransform.position);
		FUN_14D0();
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			if (SteelMil.instance.DAT_4600 < 4)
			{
				int num3 = physics1.Y;
				physics1.Y = num3 + 1;
				if (num3 < 10801)
				{
					int z;
					int num;
					if (tags == 0)
					{
						num = (vr.y & 0xFFF) * 2;
						num3 = Utilities.DAT_65C90[num] * 457;
						if (num3 < 0)
						{
							num3 += 4095;
						}
						num = Utilities.DAT_65C90[num + 1] * 457;
						num3 = vTransform.position.x + (num3 >> 12);
						if (num < 0)
						{
							num += 4095;
						}
						z = vTransform.position.z;
						num >>= 12;
					}
					else
					{
						if (tags != 1)
						{
							return 0u;
						}
						z = vTransform.position.z;
						num = physics1.W;
						num3 = vTransform.position.x + physics1.Y;
					}
					GameManager.instance.terrain.FUN_2D16C(num3, z + num, ref vTransform);
					if (2894 < vTransform.rotation.V11)
					{
						return 0u;
					}
				}
			}
			FUN_14D0();
			return uint.MaxValue;
		case 1:
		{
			short y = (short)GameManager.FUN_2AC5C();
			vr.y = y;
			SteelMil.instance.DAT_4600++;
			flags |= 128u;
			break;
		}
		case 2:
		{
			Vector3Int vout = default(Vector3Int);
			int num3;
			if (tags == 0)
			{
				VigObject vigObject = null;
				int num = 655360;
				List<VigTuple> worldObjs = GameManager.instance.worldObjs;
				for (int i = 0; i < worldObjs.Count; i++)
				{
					VigObject vObject = worldObjs[i].vObject;
					if (vObject.type == 2 && vObject.maxHalfHealth != 0)
					{
						int num2 = Utilities.FUN_29F6C(vObject.vTransform.position, vTransform.position);
						if (num2 < num)
						{
							num = num2;
							vigObject = vObject;
						}
					}
				}
				if (vigObject == null)
				{
					num3 = (int)GameManager.FUN_2AC5C();
					GameManager.instance.FUN_30CB0(this, (num3 * 45 >> 15) + 75);
					return 0u;
				}
				DAT_80 = vigObject;
				tags++;
				vout.x = vigObject.vTransform.position.x - vTransform.position.x;
				vout.z = vigObject.vTransform.position.z;
			}
			else
			{
				if (tags != 1)
				{
					return 0u;
				}
				VigObject dAT_ = DAT_80;
				num3 = Utilities.FUN_29F6C(dAT_.vTransform.position, vTransform.position);
				if (655359 < num3)
				{
					tags = 0;
					DAT_80 = null;
					num3 = (int)GameManager.FUN_2AC5C();
					GameManager.instance.FUN_30CB0(this, (num3 * 45 >> 15) + 75);
					return 0u;
				}
				vout.x = dAT_.vTransform.position.x - vTransform.position.x;
				vout.z = dAT_.vTransform.position.z;
			}
			vout.y = 0;
			vout.z -= vTransform.position.z;
			Utilities.FUN_2A098(vout, out vout);
			num3 = vout.x * 915;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			physics1.Y = num3 >> 12;
			physics1.Z = 0;
			num3 = vout.z * 915;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			physics1.W = num3 >> 12;
			num3 = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_30CB0(this, (num3 * 45 >> 15) + 60);
			return 0u;
		}
		case 4:
			SteelMil.instance.DAT_4600--;
			break;
		case 8:
			FUN_32B90((uint)arg2);
			return 0u;
		}
		return 0u;
	}

	private void FUN_14D0()
	{
		LevelManager.instance.FUN_4DE54(vTransform.position, 33);
		LevelManager.instance.FUN_4DE54(vTransform.position, 29);
		GameManager.instance.FUN_309A0(this);
	}
}
