using UnityEngine;

public class Wave : VigObject
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
		if (hit.self.type != 2)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)hit.self;
		sbyte tags = base.tags;
		int x;
		int num;
		if (tags == 1)
		{
			x = vehicle.physics1.X;
			num = -78080;
			goto IL_0075;
		}
		if (tags < 2)
		{
			if (tags == 0)
			{
				vehicle.physics1.Z -= 78080;
			}
		}
		else if (tags == 2)
		{
			x = vehicle.physics1.X;
			num = 78080;
			goto IL_0075;
		}
		goto IL_0083;
		IL_0083:
		if ((GameManager.FUN_2AC5C() & 0x1F) == 0)
		{
			vehicle.FUN_39BC4();
			vehicle.FUN_3A020(-150, Vector3Int.zero, param3: true);
		}
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E628(param, vData.sndList, 0, vTransform.position);
		return 0u;
		IL_0075:
		physics1.X = x + num;
		goto IL_0083;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			flags = 132u;
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, 4, 0u, param5: true);
			return 0u;
		}
		case 0:
			switch (tags)
			{
			case 1:
			{
				int num = vTransform.position.x - 7629;
				vTransform.position.x = num;
				if (num < 54394880)
				{
					GameManager.instance.FUN_309A0(this);
					return uint.MaxValue;
				}
				break;
			}
			case 0:
			{
				int z = vTransform.position.z;
				int num = z - 7629;
				vTransform.position.z = num;
				if ((num < 81002496 && 81002496 < z) || (num < 78970880 && 78970880 < z))
				{
					screen = vTransform.position;
					VigObject vigObject = FUN_31DDC();
					vigObject.tags = 1;
					vigObject.vr.y = 1024;
					vigObject.FUN_3066C();
					VigObject vigObject2 = FUN_31DDC();
					vigObject2.tags = 2;
					vigObject2.vr.y = -1024;
					vigObject2.FUN_3066C();
				}
				else if (vTransform.position.z < 78184448)
				{
					VALLYFRM.instance.DAT_14C8--;
					GameManager.instance.FUN_309A0(this);
					return uint.MaxValue;
				}
				break;
			}
			case 2:
			{
				int num = vTransform.position.x + 7629;
				vTransform.position.x = num;
				if (59899904 < num)
				{
					GameManager.instance.FUN_309A0(this);
					return uint.MaxValue;
				}
				break;
			}
			}
			if (((GameManager.instance.DAT_28 - DAT_19) & 3) == 0)
			{
				Wave2 wave = LevelManager.instance.xobfList[19].ini.FUN_2C17C(13, typeof(Wave2), 8u) as Wave2;
				wave.flags = 16u;
				wave.vTransform = GameManager.FUN_2A39C();
				uint num2 = GameManager.FUN_2AC5C();
				wave.vTransform.position.x = (int)(((num2 & 0xFF) - 128) * 1024);
				wave.vTransform.position.y = 0;
				wave.vTransform.position.z = -81920;
				Utilities.FUN_2CC48(this, wave);
				Utilities.ParentChildren(this, this);
			}
			if (arg2 != 0)
			{
				uint volume = GameManager.instance.FUN_1E478(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
				return 0u;
			}
			return 0u;
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			return 0u;
		default:
			return 0u;
		}
	}
}