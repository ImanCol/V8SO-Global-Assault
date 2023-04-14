using System.Collections.Generic;
using UnityEngine;

public class Revolver3 : VigObject
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
		if (hit.object2.type != 3)
		{
			VigObject self = hit.self;
			if (self.type == 8 && self.GetType() == typeof(Bullet))
			{
				return 0u;
			}
			GameManager.instance.FUN_2F798(this, hit);
			FUN_60(hit.normal1);
			if (self.type == 2)
			{
				Vehicle vehicle = (Vehicle)self;
				Vector3Int v = default(Vector3Int);
				if (tags == 0)
				{
					v.x = physics1.Z << 6;
					v.y = physics1.W << 6;
					v.z = physics2.X << 6;
				}
				else
				{
					v.x = physics1.Z * 96;
					v.y = physics1.W * 96;
					v.z = physics2.X * 96;
				}
				vehicle.FUN_2B370(v, vTransform.position);
				vehicle.physics1.Y = -292864;
				if (vehicle.id < 0)
				{
					GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 8, 32);
				}
				if (tags == 0)
				{
					vehicle.physics2.Z *= 24;
					vehicle.physics2.X *= 24;
				}
				else
				{
					UIManager.instance.FUN_4E414(vTransform.position, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 8));
					vehicle.physics2.Z <<= 4;
					vehicle.physics2.X <<= 4;
				}
			}
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 63, vTransform.position);
			LevelManager.instance.FUN_4DE54(vTransform.position, 13);
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		if (arg1 < 3)
		{
			if (arg1 != 0)
			{
				return 0u;
			}
			vTransform.position.x += physics1.Z;
			vTransform.position.y += physics1.W;
			vTransform.position.z += physics2.X;
			if (GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z) < vTransform.position.y)
			{
				Vector3Int n = GameManager.instance.terrain.FUN_1B998((uint)vTransform.position.x, (uint)vTransform.position.z);
				n = Utilities.VectorNormal(n);
				FUN_60(n);
				LevelManager.instance.FUN_309C8(this, 1);
				return uint.MaxValue;
			}
		}
		return 0u;
	}

	private void FUN_60(Vector3Int param1)
	{
		Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(141, typeof(Ballistic), 8u, typeof(VigChild)) as Ballistic;
		ballistic.flags = 52u;
		ballistic.screen = vTransform.position;
		ballistic.FUN_3066C();
		int param2;
		int param3;
		List<AudioClip> param4;
		if (tags == 0)
		{
			param2 = GameManager.instance.FUN_1DD9C();
			param3 = 65;
			param4 = GameManager.instance.DAT_C2C;
		}
		else
		{
			ballistic = (vData.ini.FUN_2C17C(1, typeof(RevolverBallistic), 8u, typeof(VigChild)) as Ballistic);
			Utilities.ParentChildren(ballistic, ballistic);
			ballistic.flags = 52u;
			ballistic.screen = vTransform.position;
			ballistic.FUN_3066C();
			param2 = GameManager.instance.FUN_1DD9C();
			param3 = 4;
			param4 = vData.sndList;
		}
		GameManager.instance.FUN_1E628(param2, param4, param3, vTransform.position);
		LevelManager.instance.FUN_4EAE8(vTransform.position, param1, 148);
	}
}
