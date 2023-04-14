using UnityEngine;

public class Meteorite2 : Destructible
{
	private static Vector3Int DAT_C0 = new Vector3Int(8192, 8192, 8192);

	private static Vector3Int DAT_D0 = new Vector3Int(16384, 16384, 16384);

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
		FUN_32CF0(hit);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			FUN_2AF20();
			if (vTransform.position.y < screen.y)
			{
				sbyte b = (sbyte)(DAT_19 - 1);
				DAT_19 = (byte)b;
				if (b == 0)
				{
					Ballistic obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(109, typeof(Ballistic), 8u) as Ballistic;
					obj.vTransform.rotation = new Matrix3x3
					{
						V00 = 4096,
						V01 = 0,
						V02 = 0,
						V10 = 0,
						V11 = 4096,
						V12 = 0,
						V20 = 0,
						V21 = 0,
						V22 = 4096
					};
					uint num = GameManager.FUN_2AC5C();
					DAT_19 = (byte)((sbyte)(num & 3) + 5);
					obj.flags = 1076u;
					obj.id = 0;
					obj.vTransform.position.x = vTransform.position.x + (int)(((num & 3) - 2) * 32768);
					obj.vTransform.position.y = vTransform.position.y;
					obj.vTransform.position.z = vTransform.position.z + ((((int)num >> 2) & 3) - 2) * 32768;
					Ant2.FUN_50F0(ref obj.vTransform.rotation, DAT_D0);
					obj.FUN_305FC();
				}
			}
			else
			{
				Particle2 particle = LevelManager.instance.FUN_4E128(screen, 79, 40);
				particle.FUN_2D114(particle.screen, ref particle.vTransform);
				Ant2.FUN_50F0(ref particle.vTransform.rotation, DAT_C0);
				Particle2 particle2 = LevelManager.instance.FUN_4E128(screen, 53, 0);
				particle2.flags |= 16u;
				particle2.FUN_2D114(particle2.screen, ref particle2.vTransform);
				int num2 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(num2, GameManager.instance.DAT_C2C, 66, particle2.vTransform.position);
				GameManager.instance.FUN_1E30C(num2, 3645);
				Meteorite3 meteorite = new GameObject().AddComponent<Meteorite3>();
				meteorite.screen = particle.vTransform.position;
				meteorite.flags = 160u;
				meteorite.FUN_3066C();
				FUN_30BA8();
				FUN_4DC94();
			}
			break;
		case 8:
			FUN_32B90((uint)arg2);
			break;
		case 9:
			if (arg2 != 0)
			{
				GameManager.instance.FUN_309A0(this);
			}
			break;
		}
		return 0u;
	}
}
