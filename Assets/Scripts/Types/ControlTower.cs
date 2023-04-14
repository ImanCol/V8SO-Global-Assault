public enum _B17_TYPE
{
	Type1,
	Type2
}

public class ControlTower : Destructible
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
		VigObject @object = hit.object1;
		if (@object.type == 3 && hit.self.type == 2 && (flags & 0x80) != 0)
		{
			@object.flags |= 32u;
			FUN_2FBC8((ushort)(DAT_4A + vAnim.ReadUInt16(0)));
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, vData.sndList, 2, screen);
			B17 b = GameManager.instance.FUN_30250(GameManager.instance.worldObjs, 113) as B17;
			if (b != null)
			{
				Vehicle vehicle = (Vehicle)hit.self;
				b.tags = 2;
				Vehicle vehicle2 = (Vehicle)vehicle.target;
				if (vehicle2 == null)
				{
					vehicle2 = vehicle;
				}
				b.DAT_A8 = vehicle2;
				b.flags &= 4294967261u;
				b.FUN_30C68();
				if ((b.flags & 0x80) == 0)
				{
					sbyte param2 = b.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E098(param2, b.vData.sndList, 1, 0u, param5: true);
					b.FUN_30B78();
				}
			}
			tags = 1;
			return 0u;
		}
		if (FUN_32CF0(hit))
		{
			FUN_30BA8();
			FUN_30C68();
			if (++AIRGRAVE.instance.destroyedTowers == 2 && (GameManager.instance.gameMode == _GAME_MODE.Survival || GameManager.instance.gameMode == _GAME_MODE.Survival2))
			{
				B17 b = GameManager.instance.FUN_30250(GameManager.instance.worldObjs, 113) as B17;
				if (b != null)
				{
					b.tags = 2;
					Vehicle vehicle2 = (Vehicle)(b.DAT_A8 = GameManager.instance.playerObjects[0]);
					b.flags &= 4294967261u;
					b.loop = true;
					b.FUN_30C68();
					if ((b.flags & 0x80) == 0)
					{
						b.FUN_30B78();
					}
				}
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			child2.vr.y += 34;
			if (arg2 != 0)
			{
				child2.ApplyTransformation();
			}
			break;
		case 1:
			child2.child.type = 3;
			GameManager.instance.FUN_30CB0(this, 1800);
			FUN_2C05C();
			FUN_2FBC8(GameManager.instance.timer);
			break;
		case 2:
			if ((flags & 0x80) == 0)
			{
				child2.child.flags &= 4294967263u;
				FUN_30B78();
			}
			else
			{
				child2.child.flags |= 32u;
				tags = 0;
				FUN_30BA8();
				FUN_2C05C();
				FUN_2FBC8(GameManager.instance.timer);
			}
			child2.vMesh.DAT_00 ^= 5;
			GameManager.instance.FUN_30CB0(this, 1800);
			break;
		case 8:
		{
			if (!FUN_32B90((uint)arg2))
			{
				break;
			}
			FUN_30BA8();
			FUN_30C68();
			if (++AIRGRAVE.instance.destroyedTowers != 2 || (GameManager.instance.gameMode != _GAME_MODE.Survival && GameManager.instance.gameMode != _GAME_MODE.Survival2))
			{
				break;
			}
			B17 b = GameManager.instance.FUN_30250(GameManager.instance.worldObjs, 113) as B17;
			if (b != null)
			{
				b.tags = 2;
				Vehicle vehicle = (Vehicle)(b.DAT_A8 = GameManager.instance.playerObjects[0]);
				b.flags &= 4294967261u;
				b.loop = true;
				b.FUN_30C68();
				if ((b.flags & 0x80) == 0)
				{
					b.FUN_30B78();
				}
			}
			break;
		}
		}
		return 0u;
	}
}
