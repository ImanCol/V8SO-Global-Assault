public class Flatbed : TrainEngine2
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
		if (hit.self.type == 8)
		{
			if (child2 != null && (uint)(maxHalfHealth & 0x7F) < (uint)hit.self.maxHalfHealth)
			{
				Throwaway throwaway = child2.FUN_4ECA0();
				throwaway.state = _THROWAWAY_TYPE.Spawnable;
				throwaway.tags = 7;
				throwaway.maxHalfHealth = 0;
				throwaway.physics1.Z = 0;
				throwaway.physics1.W = -3051;
				throwaway.physics2.X = 0;
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 46, throwaway.vTransform.position);
			}
			FUN_32B90(hit.self.maxHalfHealth);
		}
		else if ((flags & 1) == 0 && hit.object1 != this)
		{
			Throwaway throwaway = child2.FUN_4ECA0();
			throwaway.state = _THROWAWAY_TYPE.Spawnable;
			throwaway.maxHalfHealth = 0;
			throwaway.tags = 7;
			GameManager.instance.FUN_30CB0(this, 300);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		switch (arg1)
		{
		case 0:
			if (vMesh == null)
			{
				GameManager.instance.FUN_309A0(this);
				result = uint.MaxValue;
			}
			else
			{
				FUN_750();
				result = 0u;
			}
			break;
		case 1:
			FUN_6AC();
			goto default;
		default:
			result = 0u;
			break;
		case 2:
			result = 0u;
			if (DAT_A8 == null)
			{
				FUN_4DC94();
				result = 0u;
			}
			break;
		case 8:
			FUN_32B90((uint)arg2);
			result = 0u;
			break;
		}
		return result;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 10)
		{
			if (arg2.id != id)
			{
				return 0u;
			}
			flags |= 16777216u;
		}
		return 0u;
	}
}