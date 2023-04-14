public class WeighSign : Destructible
{
	public Vehicle DAT_80_2;

	public int DAT_84_2;

	public int DAT_88;

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
		if (tags != 0 || hit.self.type != 2)
		{
			if (hit.self.type != 8)
			{
				return 0u;
			}
			if (hit.collider1.ReadUInt16(0) != 1 || hit.collider1.ReadUInt16(2) == 0)
			{
				VigObject self = hit.self;
				type = 0;
				BufferedBinaryReader collider = hit.collider2;
				VigObject @object = hit.object2;
				hit.self = this;
				hit.collider2 = hit.collider1;
				hit.collider1 = collider;
				hit.object2 = hit.object1;
				hit.object1 = @object;
				uint result = self.OnCollision(hit);
				type = 3;
				FUN_32B90(self.maxHalfHealth);
				return result;
			}
			return 0u;
		}
		if (DAT_80_2 == null)
		{
			DAT_84_2 = 30;
			DAT_80_2 = (Vehicle)hit.self;
			FUN_30B78();
		}
		else if (DAT_80_2 != hit.self)
		{
			return 0u;
		}
		DAT_88 = GameManager.instance.DAT_28;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		switch (arg1)
		{
		case 0:
		{
			int num = DAT_88 - GameManager.instance.DAT_28;
			if (num < 0)
			{
				num = -num;
			}
			if (num < 4 && tags != 1)
			{
				if (++DAT_84_2 < 31)
				{
					return 0u;
				}
				Vehicle dAT_80_ = DAT_80_2;
				DAT_84_2 = 0;
				int num2 = (!(dAT_80_.body[0] == null)) ? (dAT_80_.body[0].maxHalfHealth + dAT_80_.body[1].maxHalfHealth) : dAT_80_.maxHalfHealth;
				if (dAT_80_.maxFullHealth <= num2)
				{
					return 0u;
				}
				dAT_80_.FUN_3A0C0(60);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 44, vTransform.position);
				return 0u;
			}
			DAT_80_2 = null;
			goto IL_0248;
		}
		case 1:
			tags = 1;
			type = 3;
			flags &= 4294967291u;
			GameManager.instance.FUN_30CB0(this, 600);
			FUN_2C01C();
			child2.FUN_2C01C();
			child2.child.FUN_2C01C();
			GameManager.instance.FUN_2FEE8(this, 0);
			result = 0u;
			break;
		case 2:
			if (tags == 0)
			{
				tags = 1;
				int num = (int)GameManager.FUN_2AC5C();
				GameManager.instance.FUN_30CB0(this, (num * 600 >> 15) + 600);
				GameManager.instance.FUN_2C0A0(this);
				GameManager.instance.FUN_2FEE8(this, DAT_4A);
				result = 0u;
				break;
			}
			result = 0u;
			if (tags == 1)
			{
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, vData.sndList, 4, vTransform.position);
				tags = 0;
				GameManager.instance.FUN_30CB0(this, 600);
				GameManager.instance.FUN_2FEE8(this, (ushort)(DAT_4A + vAnim.ReadUInt16(0)));
				result = 0u;
			}
			break;
		default:
			result = 0u;
			break;
		case 8:
			FUN_32B90((uint)arg2);
			result = 0u;
			break;
		case 9:
			{
				if (arg2 != 0)
				{
					return 0u;
				}
				tags = 2;
				goto IL_0248;
			}
			IL_0248:
			FUN_30BA8();
			result = 0u;
			break;
		}
		return result;
	}
}
