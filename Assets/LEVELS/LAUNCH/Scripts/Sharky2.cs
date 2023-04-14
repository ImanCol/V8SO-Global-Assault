using System.Collections.Generic;

public class Sharky2 : VigObject
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
		if (arg1 == 2)
		{
			List<VigTuple> worldObjs = GameManager.instance.worldObjs;
			for (int i = 0; i < worldObjs.Count; i++)
			{
				VigObject vObject = worldObjs[i].vObject;
				if (vObject.type != 2 || vObject.id >= 0 || vObject.maxHalfHealth == 0)
				{
					continue;
				}
				int num = GameManager.instance.terrain.FUN_1B750((uint)vObject.vTransform.position.x, (uint)vObject.vTransform.position.z);
				if (3041280 >= num)
				{
					continue;
				}
				int num2 = int.MaxValue;
				int num3 = 0;
				JUNC_DB jUNC_DB = null;
				JUNC_DB jUNC_DB2;
				if (0 < LevelManager.instance.DAT_1184)
				{
					do
					{
						jUNC_DB2 = LevelManager.instance.juncList[num3];
						if (jUNC_DB2.DAT_12 - 16 < 4)
						{
							int num4 = Utilities.FUN_29F6C(vObject.vTransform.position, jUNC_DB2.DAT_00);
							if (num4 < num2)
							{
								jUNC_DB = jUNC_DB2;
								num2 = num4;
							}
						}
						num3++;
					}
					while (num3 < LevelManager.instance.DAT_1184);
				}
				if (num == 0)
				{
					continue;
				}
				Sharky sharky = GameManager.instance.FUN_30250(GameManager.instance.worldObjs, jUNC_DB.DAT_12) as Sharky;
				if (!(sharky != null) || sharky.tags >= 3)
				{
					continue;
				}
				JUNC_DB jUNC_DB3;
				if (sharky.DAT_19 == 0)
				{
					jUNC_DB2 = sharky.DAT_84_2;
					jUNC_DB3 = jUNC_DB2.DAT_1C[0].DAT_00[1];
				}
				else
				{
					jUNC_DB3 = sharky.DAT_84_2;
					jUNC_DB2 = jUNC_DB3.DAT_1C[jUNC_DB3.DAT_11 - 1].DAT_00[0];
				}
				bool flag = jUNC_DB3 == jUNC_DB;
				if (flag)
				{
					sharky.tags = 2;
				}
				else
				{
					JUNC_DB jUNC_DB4 = jUNC_DB2;
					JUNC_DB jUNC_DB5 = jUNC_DB3;
					if (jUNC_DB2 == jUNC_DB)
					{
						sharky.tags = 2;
					}
					else
					{
						while (!(flag = (jUNC_DB4.DAT_11 == 1)) && jUNC_DB5.DAT_11 != 1)
						{
							RSEG_DB rSEG_DB = jUNC_DB4.DAT_1C[1];
							jUNC_DB5 = jUNC_DB5.DAT_1C[0].DAT_00[1];
							flag = (jUNC_DB5 == jUNC_DB);
							if (flag)
							{
								break;
							}
							jUNC_DB4 = rSEG_DB.DAT_00[0];
							if (rSEG_DB.DAT_00[0] == jUNC_DB)
							{
								break;
							}
						}
						sharky.tags = 1;
					}
				}
				sharky.DAT_80 = vObject;
				sharky.DAT_19 = (byte)(flag ? 1 : 0);
				if (flag)
				{
					sharky.DAT_84_2 = jUNC_DB3;
				}
				else
				{
					sharky.DAT_84_2 = jUNC_DB2;
				}
				JUNC_DB dAT_84_ = sharky.DAT_84_2;
				sharky.physics1.Z = dAT_84_.DAT_00.x;
				sharky.physics1.W = dAT_84_.DAT_00.y;
				sharky.physics2.X = dAT_84_.DAT_00.z;
			}
			GameManager.instance.FUN_30CB0(this, 60);
		}
		return 0u;
	}
}
