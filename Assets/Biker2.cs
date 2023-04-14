using UnityEngine;

public class Biker2 : Vehicle
{
	public Vehicle leader;

	public int bikerID;

	public VigObject bikePosition;

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
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 1 && arg2 == 1)
		{
			ushort maxHalfHealth = leader.maxHalfHealth;
			ushort maxFullHealth = leader.maxFullHealth;
			base.flags |= leader.flags;
			id = leader.id;
			tags = leader.tags;
			screen = leader.screen;
			vr = leader.vr;
			DAT_19 = leader.DAT_19;
			if (maxHalfHealth != 0 || maxFullHealth != 0)
			{
				VigObject vigObject = child2;
				base.maxHalfHealth = maxHalfHealth;
				base.maxFullHealth = maxFullHealth;
				while (vigObject != null)
				{
					vigObject.maxHalfHealth = maxHalfHealth;
					vigObject = vigObject.child;
				}
			}
			FUN_2D1DC();
			FUN_2C958();
			FUN_3066C();
			uint flags = base.flags;
			tags = 2;
			type = 13;
			state = _VEHICLE_TYPE.Vehicle;
			base.flags = ((flags & 0xFFFF) | 0x16088);
			int y = screen.y;
			screen.y = y - 32768;
			uint num = 16777216u;
			for (int i = 0; i < 3; i++)
			{
				if (leader.weapons[i].tags == 7)
				{
					num = (uint)((int)num | int.MinValue);
					((GloryRockets)leader.weapons[i]).bikers.Add(this);
				}
			}
			FUN_3A500(num);
			if ((flags & 0x1840000) != 0)
			{
				vTransform.position.y -= 16384;
				_WHEELS param = _WHEELS.Snow;
				if ((flags & 0x800000) == 0 && (flags & 0x1000000) != 0)
				{
					param = _WHEELS.Sea;
				}
				FUN_3E32C(param, 500);
			}
			VigObject vigObject2 = new GameObject().AddComponent<VigObject>();
			if (bikerID == 0)
			{
				vigObject2.screen = new Vector3Int(65536, 0, -65536);
			}
			else
			{
				vigObject2.screen = new Vector3Int(-65536, 0, -65536);
			}
			vigObject2.ApplyTransformation();
			Utilities.FUN_2CC9C(leader, vigObject2);
			vigObject2.transform.parent = base.transform;
			vigObject2.type = 14;
			bikePosition = vigObject2;
			vTransform.position = Utilities.FUN_24148(leader.vTransform, bikePosition.vTransform.position);
			return Biker.LoadDakota(this, arg1, arg2, param4: false);
		}
		switch (state)
		{
		case _VEHICLE_TYPE.Vehicle:
			switch (arg1)
			{
			case 2:
				FUN_41AE8();
				return 0u;
			case 0:
			{
				if (leader.maxHalfHealth == 0)
				{
					DestroyBike();
					return 0u;
				}
				if (leader.wheelsType == _WHEELS.Snow)
				{
					if (wheelsType != _WHEELS.Snow)
					{
						FUN_3E32C(_WHEELS.Snow, 500);
					}
				}
				else if (leader.wheelsType == _WHEELS.Ground && wheelsType == _WHEELS.Snow)
				{
					FUN_3E32C(_WHEELS.Ground, 0);
				}
				if (GameManager.instance.DAT_DB0 != 0 && GameManager.instance.DAT_DB0 + 20480 < vTransform.position.y && wheelsType != _WHEELS.Sea)
				{
					FUN_3E32C(_WHEELS.Sea, 500);
				}
				short ignition = base.ignition;
				if (ignition == 0)
				{
					if (!GameManager.instance.noAI)
					{
						target = leader.target;
						Actions();
					}
				}
				else
				{
					base.ignition--;
					if (ignition == 1)
					{
						GameManager.instance.FUN_1E580(DAT_18, GameManager.instance.DAT_C2C, 32, vTransform.position);
						DAT_18 = 0;
						DAT_F6 &= 65519;
					}
					else
					{
						if (arg2 == 0)
						{
							return 0u;
						}
						uint num = GameManager.instance.FUN_1E478(vTransform.position);
						GameManager.instance.FUN_1E2C8(DAT_18, num);
					}
				}
				if (arg2 != 0)
				{
					uint flags = (uint)((int)base.flags & -16809985);
					if ((base.flags & 0x1000000) != 0)
					{
						flags |= 0x8000;
					}
					base.flags = flags;
				}
				if (id != 0)
				{
					GameManager.instance.FUN_30CB0(this, 0);
					return 0u;
				}
				break;
			}
			}
			break;
		case _VEHICLE_TYPE.Chasis:
			return base.UpdateW(arg1, arg2);
		}
		return 0u;
	}

	private void Actions()
	{
		switch (tags)
		{
		case 1:
			FUN_33AF8();
			break;
		case 2:
			FollowLeader();
			break;
		case 3:
			FollowLeader();
			break;
		case 4:
			FUN_33BE4();
			break;
		}
	}

	private void FUN_33BE4()
	{
		if (60 < GameManager.instance.DAT_28)
		{
			tags = 1;
		}
		turning = 0;
		acceleration = 60;
	}

	private void FUN_33AF8()
	{
		if ((short)LevelManager.instance.FUN_35778(vTransform.position.x, vTransform.position.z) != 0)
		{
			ai.FUN_51C54(vTransform.position, leader.vTransform.position, 141120u, 0u);
			tags = 3;
			flags &= 4294967263u;
		}
		VigObject mgun = base.mgun;
		direction = 1;
		turning = 0;
		acceleration = 60;
		int arg = 12;
		if (mgun.tags == 0 && target != null && target != leader)
		{
			int num = (int)(mgun.GetType().IsSubclassOf(typeof(VigObject)) ? mgun.UpdateW(13, this) : 0);
			arg = 12;
			if (num == 0)
			{
				arg = 4;
			}
		}
		if (!(target == null) && !(target == leader) && mgun.GetType().IsSubclassOf(typeof(VigObject)))
		{
			mgun.UpdateW(arg, this);
		}
	}

	private void FollowLeader()
	{
		if (((GameManager.instance.DAT_28 - DAT_19) & 0x7F) == 0 && (ai.DAT_00 < 1 || (flags & 0x20000000) != 0))
		{
			Vector3Int param = Utilities.FUN_24148(leader.vTransform, bikePosition.vTransform.position);
			ai.FUN_51C54(vTransform.position, param, 141120u, 0u);
		}
		direction = 1;
		int num;
		int num2 = num = (short)ai.FUN_51CFC(this, physics1.W * 32 + 65536);
		int num3 = -682;
		if (-683 < num)
		{
			num3 = 682;
			if (num < 683)
			{
				num3 = num;
			}
		}
		turning = (short)num3;
		num = physics1.W * DAT_B2;
		if (num < 0)
		{
			num += 4095;
		}
		int num4 = DAT_B1 + (num >> 12);
		num = 0;
		if (0 < num4)
		{
			num = num4;
		}
		num3 *= num;
		if (num3 < 0)
		{
			num3 += 15;
		}
		physics2.Y += num3 >> 4;
		num3 = num2;
		if (num3 < 0)
		{
			num3 = -num3;
		}
		if (num3 < 342 || physics1.W < 3052)
		{
			if (physics1.W < 6867)
			{
				num3 = 0;
				if (0 < base.acceleration)
				{
					num3 = base.acceleration;
				}
				uint dAT_B = DAT_B3;
				num3++;
				bool num5 = num3 < (int)dAT_B;
				short acceleration = (short)dAT_B;
				if (num5)
				{
					acceleration = (short)num3;
				}
				base.acceleration = acceleration;
			}
			else
			{
				num = base.acceleration - 1;
				num3 = -DAT_B3;
				if (-DAT_B3 < num)
				{
					num3 = num;
				}
				base.acceleration = (short)num3;
			}
		}
		else
		{
			num3 = 0;
			if (base.acceleration < 0)
			{
				num3 = base.acceleration;
			}
			num3--;
			uint dAT_B = (uint)(-DAT_B3);
			bool num6 = (int)dAT_B < num3;
			short acceleration = (short)dAT_B;
			if (num6)
			{
				acceleration = (short)num3;
			}
			base.acceleration = acceleration;
		}
		if (ai.rubberTimer != 0)
		{
			if (DAT_B3 < 40)
			{
				base.acceleration = (short)(DAT_B3 * 2);
			}
			ai.rubberTimer--;
		}
		num3 = 0;
		VigObject mgun = base.mgun;
		if (mgun.tags != 0 || !(target != null) || !(target != leader))
		{
			goto IL_0296;
		}
		int arg;
		if (num3 != 0)
		{
			arg = 4;
		}
		else
		{
			num = (int)(mgun.GetType().IsSubclassOf(typeof(VigObject)) ? mgun.UpdateW(13, this) : 0);
			arg = 4;
			if (num != 0)
			{
				goto IL_0296;
			}
		}
		goto IL_02bc;
		IL_02bc:
		if (mgun.GetType().IsSubclassOf(typeof(VigObject)))
		{
			mgun.UpdateW(arg, this);
		}
		return;
		IL_0296:
		if (target == null || target == leader)
		{
			return;
		}
		arg = 12;
		goto IL_02bc;
	}

	private void DestroyBike()
	{
		int num = (int)FUN_4DC20();
		short param;
		if (num == 0)
		{
			param = 0;
		}
		else
		{
			ConfigContainer configContainer = vData.ini.configContainers[num];
			VigTransform param2 = GameManager.instance.FUN_2CEAC(this, configContainer);
			vData.FUN_4D498(configContainer.next, param2, id);
			param = 0;
			if (configContainer.objID != 43690)
			{
				param = (short)configContainer.objID;
			}
		}
		num = 0;
		GameManager.instance.FUN_30CB0(this, param);
		state = _VEHICLE_TYPE.Chasis;
		UnityEngine.Object.Destroy(unit);
		unit = null;
		maxHalfHealth = 0;
		acceleration = 0;
		physics1 = leader.physics1;
		physics2 = leader.physics2;
		DAT_C8 = 0;
		flags = (uint)(((int)flags & -16385) | 0x8000);
		GameManager.instance.FUN_1DE78(DAT_18);
		GameManager.instance.FUN_1DE78(DAT_DF);
		ai.FUN_51CC0();
	}
}
