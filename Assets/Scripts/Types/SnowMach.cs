using UnityEngine;

public class SnowMach : Destructible
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
		if (FUN_32CF0(hit))
		{
			FUN_30BA8();
			GameManager.instance.FUN_1DE78(DAT_18);
			DAT_18 = 0;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			if (--tags == -1)
			{
				VigObject child = base.child2;
				int num = (int)GameManager.FUN_2AC5C();
				int num2 = (num << 8 >> 15) + 4096;
				VigTransform vigTransform = Utilities.CompMatrixLV(m1: Utilities.FUN_2C77C(child.FUN_2C5F4(32768)), m0: child.vTransform);
				Smoke2 smoke = LevelManager.instance.xobfList[19].ini.FUN_2C17C(13, typeof(Smoke2), 8u) as Smoke2;
				smoke.flags |= 1040u;
				num = vigTransform.rotation.V02 * num2;
				if (num < 0)
				{
					num += 4095;
				}
				smoke.physics1.Z = num >> 12;
				num = vigTransform.rotation.V12 * num2;
				if (num < 0)
				{
					num += 4095;
				}
				smoke.physics1.W = num >> 12;
				num2 = vigTransform.rotation.V22 * num2;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				smoke.physics2.X = num2 >> 12;
				Vector3Int r = default(Vector3Int);
				r.x = 0;
				r.y = 0;
				r.z = (int)GameManager.FUN_2AC5C();
				smoke.vTransform.rotation = Utilities.RotMatrixYXZ_gte(r);
				smoke.vTransform.position = vigTransform.position;
				Utilities.FUN_2CC48(this, smoke);
				Utilities.ParentChildren(this, this);
				tags = 8;
			}
			VigObject child2 = base.child2.child;
			while (child2 != null)
			{
				int z = child2.physics1.Z;
				child2.vTransform.position.x += z;
				child2.vTransform.position.y += child2.physics1.W;
				child2.vTransform.position.z += child2.physics2.X;
				int num2 = z;
				if (z < 0)
				{
					num2 = z + 63;
				}
				int x = child2.physics2.X;
				child2.physics1.Z = z - (num2 >> 6);
				num2 = x;
				if (x < 0)
				{
					num2 = x + 63;
				}
				child2.physics2.X = x - (num2 >> 6);
				child2.physics1.W += 56;
				child2 = child2.child;
			}
			if (arg2 != 0)
			{
				uint volume = GameManager.instance.FUN_1E7A8(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
			}
			break;
		}
		case 1:
		{
			tags = (sbyte)(DAT_19 & 7);
			flags |= 128u;
			int num = 262144;
			if (262144 < DAT_58)
			{
				num = DAT_58;
			}
			DAT_58 = num;
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E1B0(param, vData.sndList, 3, 0u, param5: true);
			break;
		}
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		case 8:
			if (FUN_32B90((uint)arg2))
			{
				FUN_30BA8();
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
			}
			break;
		}
		return 0u;
	}
}