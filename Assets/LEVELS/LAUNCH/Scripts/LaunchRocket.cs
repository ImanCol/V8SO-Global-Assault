using UnityEngine;

public class LaunchRocket : VigObject
{
	private static Vector3Int DAT_E0 = new Vector3Int(12288, 12288, 12288);

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
			tags++;
		}
		else if (arg1 < 3)
		{
			if (arg1 != 0)
			{
				return 0u;
			}
			switch (tags)
			{
			case 0:
			case 10:
			{
				if ((GameManager.FUN_2AC5C() & 7) != 0)
				{
					return 0u;
				}
				Vector3Int position = vTransform.position;
				Particle1 particle2 = LevelManager.instance.FUN_4DE54(position, 5);
				particle2.state = _PARTICLE1_TYPE.LaunchRocket;
				particle2.flags |= 1024u;
				int num3 = (int)GameManager.FUN_2AC5C();
				particle2.screen.x = (num3 & 0x7FF) - 1024;
				particle2.screen.y = -112;
				num3 = (int)GameManager.FUN_2AC5C();
				particle2.screen.z = (num3 & 0x7FF) - 1024;
				Launch.FUN_5730(ref particle2.vTransform.rotation, DAT_E0);
				particle2.FUN_30B78();
				return 0u;
			}
			case 1:
			case 11:
			{
				if ((GameManager.FUN_2AC5C() & 7) == 0)
				{
					Vector3Int param = default(Vector3Int);
					param.x = vTransform.position.x;
					param.y = vTransform.position.y + 307200;
					param.z = vTransform.position.z;
					Particle1 particle = LevelManager.instance.FUN_4DE54(param, 5);
					particle.state = _PARTICLE1_TYPE.LaunchRocket;
					particle.flags |= 1024u;
					int num3 = (int)GameManager.FUN_2AC5C();
					particle.screen.x = (num3 & 0x7FF) - 1024;
					particle.screen.y = -112;
					num3 = (int)GameManager.FUN_2AC5C();
					particle.screen.z = (num3 & 0x7FF) - 1024;
					Launch.FUN_5730(ref particle.vTransform.rotation, DAT_E0);
					particle.FUN_30B78();
				}
				int num = physics1.X - 42;
				physics1.X = num;
				int num2 = -76294;
				if (-76294 < num)
				{
					num2 = num;
				}
				physics1.X = num2;
				if (tags == 1)
				{
					num2 = vTransform.position.y + num2;
					vTransform.position.y = num2;
					if (num2 < 1505281)
					{
						tags = 2;
					}
					break;
				}
				num2 = vTransform.position.y + num2;
				vTransform.position.y = num2;
				if (num2 >= 2119681)
				{
					break;
				}
				FUN_4DC94();
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
			case 2:
			{
				int num = physics1.X - 42;
				physics1.X = num;
				int num2 = -76294;
				if (-76294 < num)
				{
					num2 = num;
				}
				physics1.X = num2;
				num2 = vTransform.position.y + num2;
				vTransform.position.y = num2;
				if (num2 < -3000319)
				{
					GameManager.instance.FUN_309A0(this);
					return uint.MaxValue;
				}
				break;
			}
			}
		}
		else
		{
			if (arg1 != 4)
			{
				return 0u;
			}
			if (DAT_18 == 0)
			{
				return 0u;
			}
			GameManager.instance.FUN_1DE78(DAT_18);
			DAT_18 = 0;
		}
		return 0u;
	}
}
