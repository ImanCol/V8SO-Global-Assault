using UnityEngine;

public class SheetMetalDrum2 : VigObject
{
	private static Vector3Int DAT_F4 = new Vector3Int(0, 0, 0);

	public int DAT_A0_2;

	public short DAT_A4;

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
		if (self.type == 8)
		{
			if (!FUN_32B90(self.maxHalfHealth))
			{
				return 0u;
			}
			GameManager.instance.FUN_309A0(this);
		}
		else
		{
			if (self.type != 2)
			{
				return 0u;
			}
			Vehicle vehicle = (Vehicle)self;
			if (-1 < physics2.Y * (vehicle.vTransform.position.z - vTransform.position.z))
			{
				GameManager.instance.FUN_2F798(this, hit);
				Vector3Int vector3Int = Utilities.FUN_24148(vTransform, hit.position);
				LevelManager.instance.FUN_4DE54(vector3Int, 142);
				if (vehicle.physics1.Z * physics2.Y < 0)
				{
					vehicle.physics1.Z = -vehicle.physics1.Z;
				}
				Vector3Int v = default(Vector3Int);
				v.x = 0;
				v.y = -195200;
				v.z = physics2.Y << 5;
				DAT_A0_2 = 60;
				physics2.Y = -physics2.Y;
				vehicle.FUN_2B370(v, vector3Int);
				vehicle.FUN_3A020(-100, DAT_F4, param3: true);
				return uint.MaxValue;
			}
		}
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, vData.sndList, 4, vTransform.position);
		}
		else
		{
			if (2 < arg1)
			{
				if (arg1 != 8)
				{
					return 0u;
				}
				FUN_32B90((uint)arg2);
				return 0u;
			}
			if (arg1 != 0)
			{
				return 0u;
			}
			if (DAT_A0_2 != 0)
			{
				DAT_A0_2--;
			}
			Vector3Int pos = default(Vector3Int);
			pos.x = vTransform.position.x;
			pos.y = vTransform.position.y + DAT_A8;
			pos.z = vTransform.position.z;
			int num = FUN_2CFBC(pos);
			int num2 = num - physics2.Z;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 < 3276 && DAT_A0_2 == 0)
			{
				num2 += 3276;
				DAT_A0_2 = 240;
				physics2.Y = -physics2.Y;
				GameManager.instance.FUN_30CB0(this, 60);
			}
			int num3 = physics2.W - num;
			if (num3 < 0)
			{
				num3 = -num3;
			}
			vTransform.position.y = num - DAT_A8;
			num2 /= 12;
			if (physics2.Y < 0)
			{
				num2 = -num2;
				num3 = -num3;
			}
			num3 = -(num2 + num3) * DAT_A4;
			vTransform.position.z += num2;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			short num4 = (short)(num3 >> 12);
			physics1.M6 = num4;
			num2 = num4;
			if (num2 < 0)
			{
				num2 += 3;
			}
			vr.x += num2 >> 2;
			ApplyRotationMatrix();
			physics2.W = num;
		}
		return 0u;
	}
}
