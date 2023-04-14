using UnityEngine;

public class Tantrum2 : VigObject
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
		uint result = 0u;
		if (hit.object2.type != 3)
		{
			VigObject self = hit.self;
			if (self.type != 3)
			{
				Particle1 particle = LevelManager.instance.FUN_4DE54(screen, 34);
				particle.flags |= 1024u;
				short z = (short)GameManager.FUN_2AC5C();
				particle.vr.z = z;
				particle.ApplyTransformation();
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 66, screen);
				if (self.type == 2)
				{
					Vehicle vehicle = (Vehicle)self;
					Vector3Int v = default(Vector3Int);
					v.x = physics1.Z << 4;
					v.y = physics1.W << 4;
					v.z = physics2.X << 4;
					vehicle.FUN_2B370(v, vTransform.position);
					if (vehicle.id < 0)
					{
						GameManager.instance.FUN_15ADC(~vehicle.id, 10);
					}
					if ((GameManager.FUN_2AC5C() & 7) == 0 && vehicle.shield == 0)
					{
						int num = (int)(GameManager.FUN_2AC5C() * 3) >> 15;
						VigObject vigObject = vehicle.weapons[num];
						if (vigObject != null && vigObject.tags < 8)
						{
							if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || vehicle.id == -1)
							{
								if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
								{
									//ClientSend.DropWeapon(vigObject.tags);
								}
								Vector3Int param2 = GameManager.instance.FUN_2CE50(vigObject);
								LevelManager.instance.FUN_4DE54(param2, 142);
								vehicle.FUN_3A280((uint)num);
							}
							//else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
							else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && vehicle.id > 0)
							{
								//ClientSend.DropWeaponAI(vehicle.id, vigObject.tags);
								Vector3Int param2 = GameManager.instance.FUN_2CE50(vigObject);
								LevelManager.instance.FUN_4DE54(param2, 142);
								vehicle.FUN_3A280((uint)num);
							}
						}
					}
				}
				LevelManager.instance.FUN_309C8(this, 0);
			}
			result = uint.MaxValue;
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
			screen.x += physics1.Z;
			screen.y += physics1.W;
			screen.z += physics2.X;
			vTransform.position.x = screen.x;
			vTransform.position.y = screen.y;
			vTransform.position.z = screen.z;
			short num = (short)(physics2.M2 - 1);
			physics2.M2 = num;
			if (num == -1 || GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z) < screen.y)
			{
				Particle1 particle = LevelManager.instance.FUN_4DE54(screen, 34);
				short z = (short)GameManager.FUN_2AC5C();
				particle.vr.z = z;
				particle.ApplyTransformation();
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 66, screen);
				LevelManager.instance.FUN_309C8(this, 1);
				return 0u;
			}
			return 0u;
		}
		return 0u;
	}
}
