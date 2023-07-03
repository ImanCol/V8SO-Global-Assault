using System.Collections.Generic;
using UnityEngine;

public class Turret : VigObject
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
		if (hit.self.type != 8)
		{
			return 0u;
		}
		if (FUN_32B90(hit.self.maxHalfHealth))
		{
			FUN_30C68();
			FUN_30BA8();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		int num;
		switch (arg1)
		{
		case 0:
		{
			VigObject child = child2;
			VigObject pDAT_ = PDAT_78;
			Vector3Int vector3Int = Utilities.FUN_24304(GameManager.instance.FUN_2CDF4(child), pDAT_.screen);
			num = (int)Utilities.Ratan2(vector3Int.x, vector3Int.z);
			int num2 = num << 20 >> 20;
			num = (int)Utilities.Ratan2(vector3Int.y, vector3Int.z);
			num = num * -1048576 >> 20;
			if (num2 < 0)
			{
				num2 += 3;
			}
			child.vr.y += num2 >> 2;
			if (num < 0)
			{
				num += 3;
			}
			num2 = child.vr.x + (num >> 2);
			num = -341;
			if (-342 < num2)
			{
				num = 341;
				if (num2 < 342)
				{
					num = num2;
				}
			}
			child.vr.x = num;
			child.ApplyTransformation();
			if (vector3Int.z < 1024001 && pDAT_.maxHalfHealth != 0)
			{
				return 0u;
			}
			PDAT_78 = null;
			FUN_30BA8();
			return 0u;
		}
		case 1:
			num = DAT_19 + 30;
			goto IL_02cc;
		case 2:
			if (PDAT_78 == null)
			{
				if (GameManager.instance.worldObjs != null)
				{
					List<VigTuple> worldObjs = GameManager.instance.worldObjs;
					for (int i = 0; i < worldObjs.Count; i++)
					{
						VigObject vObject = worldObjs[i].vObject;
						if (vObject.type == 2 && vObject.maxHalfHealth != 0)
						{
							num = Utilities.FUN_29F6C(screen, vObject.screen);
							if (num < 819200)
							{
								PDAT_78 = vObject;
								FUN_30B78();
								int param = GameManager.instance.FUN_1DD9C();
								GameManager.instance.FUN_1E580(param, vData.sndList, 4, screen);
								break;
							}
						}
					}
				}
			}
			else
			{
				Ballistic ballistic = vData.ini.FUN_2C17C(526, typeof(Ballistic), 8u) as Ballistic;
				Turret2 turret = LevelManager.instance.FUN_42408(this, child2, 524, typeof(Turret2), ballistic) as Turret2;
				turret.flags = 132u;
				turret.maxHalfHealth = 50;
				turret.physics2.M3 = 4;
				turret.physics2.M2 = 8;
				turret.FUN_305FC();
				ballistic.flags = 16u;
				ballistic.FUN_30BF0();
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, vData.sndList, 1, turret.vTransform.position);
			}
			num = 60;
			goto IL_02cc;
		case 8:
			{
				if (FUN_32B90((uint)arg2))
				{
					FUN_30C68();
					FUN_30BA8();
				}
				break;
			}
			IL_02cc:
			GameManager.instance.FUN_30CB0(this, num);
			break;
		}
		return 0u;
	}
}
