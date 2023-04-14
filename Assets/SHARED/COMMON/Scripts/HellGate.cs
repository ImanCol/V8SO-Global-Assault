using System.Collections.Generic;
using UnityEngine;

public class HellGate : VigObject
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
		HellGate hellGate = new GameObject().AddComponent<HellGate>();
		hellGate.vData = arg1;
		return hellGate;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			if ((flags & 0x1000000) != 0)
			{
				if (-1 < tags)
				{
					ConfigContainer cCDAT_ = CCDAT_74;
					base.vTransform.position = cCDAT_.v3_1;
				}
				CCDAT_74 = null;
				PDAT_74 = null;
				flags &= 4278190079u;
			}
			if (PDAT_74 == null)
			{
				VigObject dAT_ = Utilities.FUN_2CD78(this);
				VigTransform vTransform = GameManager.instance.FUN_2CDF4(this);
				int num = 0;
				VigObject vigObject2 = this;
				Demon param2;
				do
				{
					num++;
					param2 = (base.vData.ini.FUN_2C17C(2, typeof(Demon), 8u) as Demon);
					param2.flags = 164u;
					param2.vTransform = vTransform;
					param2.DAT_80 = dAT_;
					param2.DAT_94 = this;
					vigObject2.PDAT_74 = param2;
					param2.FUN_305FC();
					vigObject2 = param2;
				}
				while (num < 3);
				param2.PDAT_74 = null;
				if (-1 < tags)
				{
					FUN_30BA8();
				}
			}
			return (uint)FUN_4205C();
		case 4:
		{
			VigObject pDAT_ = PDAT_74;
			if (pDAT_ == null)
			{
				return 0u;
			}
			do
			{
				GameManager.instance.FUN_309A0(pDAT_);
				pDAT_ = pDAT_.PDAT_74;
			}
			while (pDAT_ != null);
			break;
		}
		case 10:
		{
			if (arg2 != 12820)
			{
				break;
			}
			Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
			if (vehicle == null || id != 0)
			{
				return 0u;
			}
			VigObject vigObject;
			int param;
			if ((vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth) * 3 < vehicle.maxFullHealth)
			{
				List<ushort> list = new List<ushort>();
				list.Add(0);
				vigObject = GameManager.instance.FUN_34120_3(GameManager.instance.worldObjs, list, vehicle.vTransform.position);
				if (vigObject == null)
				{
					list = new List<ushort>();
					for (int i = 0; i < 3; i++)
					{
						if (vehicle.weapons[i] != null)
						{
							switch (vehicle.weapons[i].tags)
							{
							case 1:
								list.Add(12);
								break;
							case 2:
								list.Add(10);
								break;
							case 3:
								list.Add(11);
								break;
							case 4:
								list.Add(14);
								break;
							case 5:
								list.Add(13);
								break;
							case 6:
								list.Add(15);
								break;
							case 7:
								list.Add(6);
								break;
							}
						}
					}
					vigObject = ((!(vehicle.weapons[1] == null) && !(vehicle.weapons[2] == null)) ? GameManager.instance.FUN_34120_3(GameManager.instance.worldObjs, list, vehicle.vTransform.position) : GameManager.instance.FUN_34120_2(GameManager.instance.worldObjs, 4261412864u, vehicle.vTransform.position));
					if (vigObject == null)
					{
						param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 1);
						return 0u;
					}
				}
			}
			else
			{
				List<ushort> list = new List<ushort>();
				for (int j = 0; j < 3; j++)
				{
					if (vehicle.weapons[j] != null)
					{
						switch (vehicle.weapons[j].tags)
						{
						case 1:
							list.Add(12);
							break;
						case 2:
							list.Add(10);
							break;
						case 3:
							list.Add(11);
							break;
						case 4:
							list.Add(14);
							break;
						case 5:
							list.Add(13);
							break;
						case 6:
							list.Add(15);
							break;
						case 7:
							list.Add(6);
							break;
						}
					}
				}
				vigObject = ((!(vehicle.weapons[1] == null) && !(vehicle.weapons[2] == null)) ? GameManager.instance.FUN_34120_3(GameManager.instance.worldObjs, list, vehicle.vTransform.position) : GameManager.instance.FUN_34120_2(GameManager.instance.worldObjs, 4261412864u, vehicle.vTransform.position));
				if (vigObject == null)
				{
					param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 1);
					return 0u;
				}
			}
			if ((flags & 0x1000000) != 0 || (vehicle.flags & 0x30000000) != 805306368 || vigObject.screen.x < VigTerrain.instance.DAT_DE4 || VigTerrain.instance.DAT_DF0 < vigObject.screen.x || vigObject.screen.z < VigTerrain.instance.DAT_DEC || VigTerrain.instance.DAT_DF0 < vigObject.screen.z || VigTerrain.instance.GetTileByPosition((uint)vigObject.screen.x, (uint)vigObject.screen.z).DAT_10[3] == 7 || (vehicle.DAT_F6 & 0x200) != 0)
			{
				return 0u;
			}
			if (vehicle.id < 0)
			{
				GameManager.instance.FUN_15B00(~vehicle.id, 128, 64, 64);
			}
			if (maxHalfHealth < 4)
			{
				Demon param2 = (Demon)PDAT_74;
				PDAT_74 = PDAT_74.PDAT_74;
				GameManager.instance.FUN_309A0(param2);
			}
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, base.vData.sndList, 4, vehicle.vTransform.position);
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			Vector3Int n = GameManager.instance.terrain.FUN_1B998((uint)vigTransform.position.x, (uint)vigTransform.position.z);
			n = Utilities.VectorNormal(n);
			HellGate2 hellGate = new GameObject().AddComponent<HellGate2>();
			hellGate.flags = 164u;
			XOBF_DB vData = base.vData;
			hellGate.DAT_80 = vehicle;
			hellGate.DAT_94 = this;
			hellGate.vData = vData;
			hellGate.DAT_84 = vigObject;
			hellGate.vTransform.rotation = Utilities.FUN_2A5EC(n);
			hellGate.vTransform.position = vigTransform.position;
			hellGate.FUN_305FC();
			if (hellGate.GetType().IsSubclassOf(typeof(VigObject)))
			{
				hellGate.UpdateW(2, 0);
			}
			vehicle.FUN_30BA8();
			vehicle.flags |= 100663328u;
			maxHalfHealth--;
			if (-1 < vehicle.id)
			{
				id = 900;
				return 900u;
			}
			id = 480;
			return 480u;
		}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		switch (arg1)
		{
		case 1:
			FUN_30B78();
			maxHalfHealth = 3;
			flags |= 16384u;
			break;
		case 12:
		{
			VigObject vigObject = ((Vehicle)arg2).target;
			if ((vigObject == null && (vigObject = arg2) == null) || (flags & 0x1000000) != 0 || (arg2.flags & 0x30000000) != 805306368 || vigObject.screen.x < VigTerrain.instance.DAT_DE4 || VigTerrain.instance.DAT_DF0 < vigObject.screen.x || vigObject.screen.z < VigTerrain.instance.DAT_DEC || VigTerrain.instance.DAT_DF0 < vigObject.screen.z || VigTerrain.instance.GetTileByPosition((uint)vigObject.screen.x, (uint)vigObject.screen.z).DAT_10[3] == 7 || (((Vehicle)arg2).DAT_F6 & 0x200) != 0)
			{
				return 0u;
			}
			if (arg2.id < 0)
			{
				GameManager.instance.FUN_15B00(~arg2.id, 128, 64, 64);
			}
			if (maxHalfHealth < 4)
			{
				Demon param = (Demon)PDAT_74;
				PDAT_74 = PDAT_74.PDAT_74;
				GameManager.instance.FUN_309A0(param);
			}
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param2, base.vData.sndList, 4, arg2.vTransform.position);
			param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(param2, base.vData.sndList, 2);
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			Vector3Int n = GameManager.instance.terrain.FUN_1B998((uint)vigTransform.position.x, (uint)vigTransform.position.z);
			n = Utilities.VectorNormal(n);
			HellGate2 hellGate = new GameObject().AddComponent<HellGate2>();
			hellGate.flags = 164u;
			XOBF_DB vData = base.vData;
			hellGate.DAT_80 = arg2;
			hellGate.DAT_94 = this;
			hellGate.vData = vData;
			if (vigObject == null)
			{
				vigObject = arg2;
			}
			hellGate.DAT_84 = vigObject;
			hellGate.vTransform.rotation = Utilities.FUN_2A5EC(n);
			hellGate.vTransform.position = vigTransform.position;
			hellGate.FUN_305FC();
			if (hellGate.GetType().IsSubclassOf(typeof(VigObject)))
			{
				hellGate.UpdateW(2, 0);
			}
			arg2.FUN_30BA8();
			arg2.flags |= 100663328u;
			GameManager.instance.DAT_1084++;
			maxHalfHealth--;
			if (-1 < arg2.id)
			{
				return 900u;
			}
			return 480u;
		}
		case 13:
		{
			if (GameManager.instance.DAT_1084 != 0)
			{
				return 0u;
			}
			if ((flags & 0x1000000) != 0)
			{
				return 0u;
			}
			VigObject pDAT_ = ((Vehicle)arg2).target;
			if ((arg2.flags & pDAT_.flags & 0x30000000) != 805306368)
			{
				return 0u;
			}
			if (1524 < pDAT_.physics1.W)
			{
				return 0u;
			}
			int num = Utilities.FUN_29F6C(arg2.screen, pDAT_.screen);
			if (409600 >= num)
			{
				return 0u;
			}
			return 1u;
		}
		case 16:
		{
			VigObject pDAT_ = arg2.PDAT_74;
			arg2.PDAT_74 = pDAT_.PDAT_74;
			if (2 < maxHalfHealth)
			{
				GameManager.instance.FUN_309A0(pDAT_);
				return 0u;
			}
			pDAT_.PDAT_74 = PDAT_74;
			PDAT_74 = pDAT_;
			((Demon)pDAT_).DAT_94 = this;
			break;
		}
		}
		return 0u;
	}
}
