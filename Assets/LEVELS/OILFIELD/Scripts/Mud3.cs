using UnityEngine;

public class Mud3 : VigObject
{
	public int DAT_80_2;

	public int DAT_84_2;

	public Vehicle DAT_88;

	public int DAT_8C;

	public Vector3Int[] DAT_90 = new Vector3Int[16];

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
			if (tags == 0)
			{
				if (DAT_8C == 0)
				{
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, LevelManager.instance.xobfList[42].sndList, 0, DAT_88.vTransform.position);
				}
				int num = 0;
				int num2 = 2;
				VigTransform transform = DAT_88.FUN_2AE18();
				int dAT_8C = DAT_8C;
				Vehicle dAT_ = DAT_88;
				DAT_90[dAT_8C] = dAT_.vTransform.position;
				DAT_8C = dAT_8C + 1;
				do
				{
					Wheel wheel = DAT_88.wheels[num2];
					if (wheel != null)
					{
						num = Utilities.FUN_29FC8(Utilities.FUN_24148(transform, wheel.vTransform.position), out Vector3Int vout);
						if (58496 < num)
						{
							Vector3Int vector3Int = GameManager.instance.FUN_2CE50(wheel);
							Vector3Int n = GameManager.instance.terrain.FUN_1BB50(vector3Int.x, vector3Int.z);
							n = Utilities.VectorNormal(n);
							uint num3 = GameManager.FUN_2AC5C();
							int param = 17;
							if ((num3 & 1) != 0)
							{
								param = 16;
							}
							Ballistic obj = LevelManager.instance.xobfList[42].ini.FUN_2C17C((ushort)param, typeof(Ballistic), 8u) as Ballistic;
							obj.type = 7;
							obj.flags = 36u;
							Utilities.FUN_2A85C(ref obj.vTransform.rotation, vout, n);
							obj.vTransform.position.x = vector3Int.x;
							obj.vTransform.position.z = vector3Int.z;
							param = GameManager.instance.terrain.FUN_1B750((uint)vector3Int.x, (uint)vector3Int.z);
							obj.vTransform.position.y = param;
							obj.FUN_305FC();
						}
					}
					num2++;
				}
				while (num2 < 4);
				if (DAT_8C < 16)
				{
					int param2;
					if (num == 0)
					{
						param2 = 60;
					}
					else
					{
						param2 = 6;
						if (6 < 6553600 / num)
						{
							param2 = 6553600 / num;
						}
					}
					GameManager.instance.FUN_30CB0(this, param2);
					return 0u;
				}
				DAT_88 = null;
				tags = 1;
				GameManager.instance.FUN_30CB0(this, 300);
				return 0u;
			}
			if (tags == 1)
			{
				GameManager.instance.FUN_300B8(((Oilfield)LevelManager.instance.level).DAT_84_2[DAT_84_2], this);
				DAT_8C = 0;
				UnityEngine.Object.Destroy(base.gameObject);
				return uint.MaxValue;
			}
			return 0u;
		}
		return 0u;
	}
}
