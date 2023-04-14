public class Gondola : Destructible
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
		VigObject self = hit.self;
		if (self.type == 3 && DAT_80 != null)
		{
			hit.self = DAT_80;
			if (self.GetType().IsSubclassOf(typeof(VigObject)))
			{
				self.OnCollision(hit);
			}
			return 1u;
		}
		FUN_32CF0(hit);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint flags;
		if (arg1 != 1)
		{
			if (arg1 != 2)
			{
				if (arg1 != 8)
				{
					goto IL_0036;
				}
				FUN_32B90((uint)arg2);
				return 0u;
			}
			flags = (uint)((int)base.flags & -33);
		}
		else
		{
			maxHalfHealth = 24;
			flags = (base.flags | 0x108);
		}
		base.flags = flags;
		goto IL_0036;
		IL_0036:
		return 0u;
	}
}
