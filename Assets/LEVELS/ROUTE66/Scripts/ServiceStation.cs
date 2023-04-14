using UnityEngine;

public class ServiceStation : Destructible
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
		if (self.type == 2 && (self.flags & 0x4000) != 0 && tags != 0 && hit.object1.type == 3)
		{
			Vehicle vehicle = (Vehicle)(PDAT_74 = (Vehicle)self);
			if (tags != 1)
			{
				return 0u;
			}
			FUN_30B78();
			tags = 2;
			DAT_19 = 0;
			return 0u;
		}
		if (self.type != 8)
		{
			return 0u;
		}
		if (!hit.object1.FUN_32B90(self.maxHalfHealth))
		{
			return 0u;
		}
		if (hit.object1.id != 1)
		{
			return 0u;
		}
		hit.object1.id = 0;
		self = child2;
		int num = 0;
		while (self != null)
		{
			if (self.id == 1)
			{
				num++;
			}
			self = self.child;
		}
		if (num != 0)
		{
			return 0u;
		}
		FUN_30C68();
		tags = 0;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			Vehicle vehicle = PDAT_74 as Vehicle;
			if (vehicle != null)
			{
				sbyte b = (sbyte)(DAT_19 + 1);
				DAT_19 = (byte)b;
				if (b != 30)
				{
					return 0u;
				}
				DAT_19 = 0;
				if (vehicle.body[0] == null)
				{
					if (vehicle.maxFullHealth <= vehicle.maxHalfHealth)
					{
						goto IL_0125;
					}
				}
				else if (vehicle.maxFullHealth <= vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth)
				{
					tags = 0;
					goto IL_012c;
				}
				vehicle.FUN_3A0C0(60);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 44, vTransform.position);
				UIManager.instance.FUN_4E414(vTransform.position, new Color32(0, 128, 0, 8));
				PDAT_74 = null;
				if (++tags < 8)
				{
					return 0u;
				}
			}
			goto IL_0125;
		}
		case 1:
		{
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				switch (vigObject.id)
				{
				case 1:
					vigObject.maxHalfHealth = 100;
					break;
				case 2:
					vigObject.maxHalfHealth = 50;
					break;
				case 4:
					vigObject.type = 3;
					break;
				}
				vigObject = vigObject.child;
			}
			goto case 2;
		}
		case 2:
			tags = 1;
			break;
		case 8:
			{
				if (!FUN_32B90((uint)arg2))
				{
					return 0u;
				}
				FUN_30C68();
				tags = 0;
				break;
			}
			IL_012c:
			FUN_30BA8();
			GameManager.instance.FUN_30CB0(this, 1800);
			return 0u;
			IL_0125:
			tags = 0;
			goto IL_012c;
		}
		return 0u;
	}
}
