public class Biker : VigObject
{
	private Vehicle vehicle;

	public static uint LoadDakota(Vehicle param1, int param2, int param3, bool param4)
	{
		if (param2 == 1)
		{
			Biker biker = param1.vData.ini.FUN_2C17C(1, typeof(Biker), 8u) as Biker;
			Utilities.ParentChildren(biker, biker);
			biker.flags |= 4u;
			ConfigContainer cont = param1.FUN_2C5F4(33026);
			Utilities.FUN_2CA94(param1, cont, biker);
			Utilities.ParentChildren(param1, biker);
			biker.FUN_30B78();
			biker.vehicle = param1;
			if (param4)
			{
				GameManager.instance.FUN_30CB0(biker, 0);
				param1.FUN_367A4(param2, param3);
			}
		}
		return 0u;
	}

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
		uint result;
		if (arg1 == 0)
		{
			result = 0u;
			if (arg2 != 0)
			{
				Vehicle vehicle = (Vehicle)Utilities.FUN_2CD78(this);
				uint flags = base.flags;
				int num = (vehicle.turning << 3) / 682 + 8;
				base.flags = (flags | 4);
				if (num == tags)
				{
					result = 0u;
					if (num == 8)
					{
						byte dAT_ = DAT_19;
						if (dAT_ == 0)
						{
							if (DAT_1A == 3)
							{
								return 0u;
							}
							if (0 < vehicle.physics1.Y)
							{
								if ((vehicle.flags & 0x10000000) != 0)
								{
									return 0u;
								}
								if ((flags & 0x1000000) != 0)
								{
									return 0u;
								}
								base.flags = (flags | 0x1000004);
								FUN_2C124(3);
								Utilities.ParentChildren(this, this);
								return 0u;
							}
						}
						else
						{
							DAT_19 = (byte)(dAT_ - 1);
							if (dAT_ != 1)
							{
								return 0u;
							}
							FUN_2C124(2);
							Utilities.ParentChildren(this, this);
							GameManager.instance.FUN_30080(GameManager.instance.DAT_10A8, this);
							base.flags &= 4278190079u;
						}
						result = 0u;
					}
				}
				else
				{
					if (DAT_1A == 1)
					{
						if (num < tags)
						{
							GameManager.instance.FUN_2C0A0(child2);
						}
					}
					else
					{
						FUN_2C124(1);
						Utilities.ParentChildren(this, this);
						GameManager.instance.FUN_300B8(GameManager.instance.DAT_10A8, this);
					}
					DAT_19 = 15;
					tags = (sbyte)num;
					GameManager.instance.FUN_2FEE8(this, (ushort)(child2.DAT_4A + num * 2));
					result = 0u;
				}
			}
		}
		else
		{
			if (arg1 == 2 && GameManager.instance.experimentalDakota)
			{
				Biker2 obj = this.vehicle.vData.FUN_3C464(0, GameManager.vehicleConfigs[2], typeof(Biker2)) as Biker2;
				obj.leader = this.vehicle;
				obj.bikerID = 0;
				obj.UpdateW(1, 1);
				Biker2 obj2 = this.vehicle.vData.FUN_3C464(0, GameManager.vehicleConfigs[2], typeof(Biker2)) as Biker2;
				obj2.leader = this.vehicle;
				obj2.bikerID = 1;
				obj2.UpdateW(1, 1);
			}
			result = 0u;
		}
		return result;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result = 0u;
		if (arg1 == 5)
		{
			result = 0u;
			if (DAT_1A == 3)
			{
				FUN_2C124(2);
				Utilities.ParentChildren(this, this);
				result = 4294967294u;
			}
		}
		return result;
	}
}
