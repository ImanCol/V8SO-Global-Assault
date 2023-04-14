using UnityEngine;

public class StarPower : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2)
	{
		StarPower starPower = new GameObject().AddComponent<StarPower>();
		starPower.vData = arg1;
		return starPower;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			if (134217728u < (uint)arg2)
			{
				return 0u;
			}
			if (tags < 0)
			{
				return (uint)FUN_4205C();
			}
			VigObject vigObject = Utilities.FUN_2CD78(this);
			StarPower2 starPower = vData.ini.FUN_2C17C(1, typeof(StarPower2), 8u) as StarPower2;
			if ((flags & 0x1000000) != 0)
			{
				ConfigContainer cCDAT_ = CCDAT_74;
				vTransform.position = cCDAT_.v3_1;
				flags &= 4278190079u;
			}
			starPower.type = 8;
			starPower.id = vigObject.id;
			VigTransform vigTransform = starPower.vTransform = GameManager.instance.FUN_2CDF4(this);
			starPower.flags = 1610612900u;
			starPower.maxHalfHealth = 4;
			starPower.DAT_80 = vigObject;
			starPower.DAT_94 = this;
			PDAT_74 = starPower;
			if (starPower.GetType().IsSubclassOf(typeof(VigObject)))
			{
				starPower.UpdateW(1, 0);
			}
			starPower.FUN_305FC();
			FUN_30BA8();
			return 0u;
		}
		case 4:
			GameManager.instance.DAT_1084--;
			if ((flags & 0x1000000) != 0)
			{
				return 0u;
			}
			if (PDAT_74 == null)
			{
				return 0u;
			}
			GameManager.instance.FUN_309A0(PDAT_74);
			PDAT_74 = null;
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		switch (arg1)
		{
		case 1:
			FUN_30B78();
			if (GameManager.instance.gameMode != _GAME_MODE.Versus2)
			{
				maxHalfHealth = 6;
			}
			else
			{
				maxHalfHealth = 3;
			}
			flags |= 16384u;
			break;
		case 12:
		{
			VigObject pDAT_ = PDAT_74;
			if ((flags & 0x1000000) != 0 || pDAT_.tags != 0)
			{
				return 0u;
			}
			sbyte param = pDAT_.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E14C(param, vData.sndList, 3, param4: true);
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(param2, vData.sndList, 2);
			pDAT_.tags = 1;
			pDAT_.id = arg2.id;
			pDAT_.maxHalfHealth = 4;
			if (((Vehicle)arg2).doubleDamage != 0)
			{
				pDAT_.maxHalfHealth = 8;
			}
			pDAT_.DAT_80 = arg2;
			pDAT_.flags |= 536870912u;
			pDAT_.vr.x = pDAT_.vr.x << 20 >> 20;
			VigObject vigObject = ((Vehicle)arg2).target;
			if (vigObject == null)
			{
				vigObject = arg2;
			}
			pDAT_.DAT_84 = vigObject;
			GameManager.instance.DAT_1084++;
			maxHalfHealth--;
			if (-1 < arg2.id)
			{
				return 900u;
			}
			return 600u;
		}
		case 13:
			if (GameManager.instance.DAT_1084 != 0)
			{
				return 0u;
			}
			if ((flags & 0x1000000) == 0)
			{
				if (PDAT_74.tags != 0)
				{
					return 0u;
				}
				return 1u;
			}
			break;
		}
		return 0u;
	}
}
