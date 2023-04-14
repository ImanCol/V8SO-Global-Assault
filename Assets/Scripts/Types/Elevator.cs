using UnityEngine;

public class Elevator : VigObject
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
		sbyte b = (sbyte)self.type;
		if (b == 2 && hit.object1 == child2 && tags == 0 && (flags & 0x80) != 0)
		{
			Vector3Int param = GameManager.instance.FUN_2CE50(hit.object1);
			GameManager.instance.FUN_1E580(DAT_18, vData.sndList, 1, param);
			DAT_18 = 0;
			FUN_30BA8();
			tags = 1;
			GameManager.instance.FUN_30CB0(this, 30);
			b = (sbyte)self.type;
		}
		if (b != 8)
		{
			return 0u;
		}
		if (FUN_32B90(self.maxHalfHealth))
		{
			tags = -1;
			if ((flags & 0x80) != 0)
			{
				FUN_30BA8();
			}
			GameManager.instance.FUN_1DE78(DAT_18);
			DAT_18 = 0;
		}
		if (tags == 0)
		{
			uint num = (uint)(DAT_19 + self.maxHalfHealth);
			DAT_19 = (byte)num;
			if (49 < (num & 0xFF))
			{
				DAT_19 = 0;
				if (child2 != null && (flags & 0x80) == 0)
				{
					FUN_30B78();
					int param2 = GameManager.instance.FUN_1DD9C();
					Vector3Int param3 = GameManager.instance.FUN_2CE50(child2);
					GameManager.instance.FUN_1E580(param2, vData.sndList, 1, param3);
					b = (DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C());
					GameManager.instance.FUN_1E098(b, vData.sndList, 3, 0u, param5: true);
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
		{
			VigObject child = child2;
			Vector3Int param4;
			if (arg2 != 0)
			{
				param4 = GameManager.instance.FUN_2CE50(child);
				uint volume = GameManager.instance.FUN_1E7A8(param4);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
			}
			if (tags == 0)
			{
				int num2 = child.vTransform.position.y + 915;
				child.vTransform.position.y = num2;
				if (num2 < -32767)
				{
					return 0u;
				}
			}
			else
			{
				int num2 = child.vTransform.position.y - 915;
				child.vTransform.position.y = num2;
				if (child.screen.y <= num2)
				{
					return 0u;
				}
			}
			param4 = GameManager.instance.FUN_2CE50(child);
			GameManager.instance.FUN_1E580(DAT_18, vData.sndList, 1, param4);
			DAT_18 = 0;
			FUN_30BA8();
			if ((tags = (sbyte)(1 - tags)) != 0)
			{
				GameManager.instance.FUN_30CB0(this, 300);
			}
			break;
		}
		case 2:
			if (child2 != null && (flags & 0x80) == 0)
			{
				FUN_30B78();
				int param = GameManager.instance.FUN_1DD9C();
				Vector3Int param2 = GameManager.instance.FUN_2CE50(child2);
				GameManager.instance.FUN_1E580(param, vData.sndList, 1, param2);
				sbyte param3 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E098(param3, vData.sndList, 3, 0u, param5: true);
			}
			break;
		case 8:
		{
			if (FUN_32B90((uint)arg2))
			{
				tags = -1;
				if ((flags & 0x80) != 0)
				{
					FUN_30BA8();
				}
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
			}
			if (tags != 0)
			{
				break;
			}
			uint num = (uint)(DAT_19 + arg2);
			DAT_19 = (byte)num;
			if (49 < (num & 0xFF))
			{
				DAT_19 = 0;
				if (child2 != null && (flags & 0x80) == 0)
				{
					FUN_30B78();
					int param = GameManager.instance.FUN_1DD9C();
					Vector3Int param2 = GameManager.instance.FUN_2CE50(child2);
					GameManager.instance.FUN_1E580(param, vData.sndList, 1, param2);
					sbyte param3 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E098(param3, vData.sndList, 3, 0u, param5: true);
				}
			}
			break;
		}
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		}
		return 0u;
	}
}
