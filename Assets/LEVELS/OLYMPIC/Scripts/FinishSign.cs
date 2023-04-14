using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _FINISHSIGN_TYPE
{
    Default, //FUN_41B0
    Type1 //FUN_3E58
}

public class FinishSign : Destructible
{
	public _FINISHSIGN_TYPE state;

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
		switch (state)
		{
		case _FINISHSIGN_TYPE.Default:
		{
			OLYMPIC oLYMPIC = (OLYMPIC)LevelManager.instance.level;
			if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) != 0)
			{
				VigObject self = hit.self;
				if (self.type == 2)
				{
					Vehicle vehicle = (Vehicle)self;
					List<VigTuple> dAT_A = oLYMPIC.DAT_98;
					int num3 = 0;
					while (num3 < dAT_A.Count)
					{
						VigTuple vigTuple = dAT_A[num3];
						VigObject vigObject;
						VigObject vObject;
						if (vigTuple.vObject.id == vehicle.id)
						{
							vigObject = GameManager.instance.FUN_318D0(81);
							vObject = vigTuple.vObject;
							if (vObject.DAT_19 == id)
							{
								int num2 = GameManager.instance.DAT_28 - vObject.maxHalfHealth;
								if (oLYMPIC.DAT_D8 <= num2)
								{
									sbyte b = vigObject.tags = 3;
									int param = GameManager.instance.FUN_1DD9C();
									GameManager.instance.FUN_1E580(param, vData.sndList, 1, vTransform.position);
								}
								else
								{
									oLYMPIC.DAT_D8 = num2;
									vigObject.tags = 1;
									int param = GameManager.instance.FUN_1DD9C();
									GameManager.instance.FUN_1E580(param, vData.sndList, 0, vTransform.position);
									VigObject vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 400);
									Pickup param2 = LevelManager.instance.FUN_4AE08(2147483648u, vigObject2.screen);
									GameManager.instance.FUN_30CB0(param2, 1200);
									vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 401);
									param2 = LevelManager.instance.FUN_4AE08(4261412864u, vigObject2.screen);
									GameManager.instance.FUN_30CB0(param2, 1200);
									vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 402);
									param2 = LevelManager.instance.FUN_4AE08(4261412864u, vigObject2.screen);
									GameManager.instance.FUN_30CB0(param2, 1200);
									if (vehicle.id < 0)
									{
										vigObject.DAT_19 = 0;
										goto IL_027e;
									}
								}
							}
							else
							{
								sbyte b = vigObject.tags = 2;
								int param = GameManager.instance.FUN_1DD9C();
								GameManager.instance.FUN_1E580(param, vData.sndList, 1, vTransform.position);
							}
							vigObject.DAT_19 = 0;
							goto IL_027e;
						}
						num3++;
						continue;
						IL_027e:
						GameManager.instance.FUN_30CB0(vigObject, 6);
						GameManager.instance.FUN_300B8(oLYMPIC.DAT_98, vObject);
						UnityEngine.Object.Destroy(vObject.gameObject);
						return 0u;
					}
					return 0u;
				}
			}
			if (!FUN_32CF0(hit))
			{
				break;
			}
			VigObject vigObject3 = child2;
			while (vigObject3 != null)
			{
				if (vigObject3.id == 1)
				{
					vigObject3.type = 3;
				}
				vigObject3 = vigObject3.child;
			}
			break;
		}
		case _FINISHSIGN_TYPE.Type1:
		{
			OLYMPIC oLYMPIC = (OLYMPIC)LevelManager.instance.level;
			VigObject vigObject2;
			if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) != 0)
			{
				VigObject self = hit.self;
				if (self.type != 2)
				{
					break;
				}
				Vehicle vehicle = (Vehicle)self;
				List<VigTuple> dAT_A = oLYMPIC.DAT_A4;
				int num = 0;
				while (num < dAT_A.Count)
				{
					VigTuple vigTuple = dAT_A[num];
					VigObject vigObject;
					VigObject vObject;
					if (vigTuple.vObject.id == vehicle.id)
					{
						vigObject = GameManager.instance.FUN_318D0(81);
						vObject = vigTuple.vObject;
						if (vObject.DAT_19 == 73 || vObject.DAT_19 == 105)
						{
							if (vObject.DAT_19 != 73)
							{
								sbyte b = 2;
							}
							int num2 = GameManager.instance.DAT_28 - vObject.maxHalfHealth;
							if (oLYMPIC.DAT_E0 <= num2)
							{
								sbyte b = vigObject.tags = 3;
								int param = GameManager.instance.FUN_1DD9C();
								GameManager.instance.FUN_1E580(param, vData.sndList, 1, vTransform.position);
							}
							else
							{
								oLYMPIC.DAT_E0 = num2;
								vigObject.tags = 1;
								int param = GameManager.instance.FUN_1DD9C();
								GameManager.instance.FUN_1E580(param, vData.sndList, 0, vTransform.position);
								vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 400);
								Pickup param2 = LevelManager.instance.FUN_4AE08(2147483648u, vigObject2.screen);
								GameManager.instance.FUN_30CB0(param2, 1200);
								vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 401);
								param2 = LevelManager.instance.FUN_4AE08(4261412864u, vigObject2.screen);
								GameManager.instance.FUN_30CB0(param2, 1200);
								vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 402);
								param2 = LevelManager.instance.FUN_4AE08(4261412864u, vigObject2.screen);
								GameManager.instance.FUN_30CB0(param2, 1200);
								if (vehicle.id < 0)
								{
									vigObject.DAT_19 = 0;
									goto IL_057a;
								}
							}
						}
						else
						{
							sbyte b = vigObject.tags = 2;
							int param = GameManager.instance.FUN_1DD9C();
							GameManager.instance.FUN_1E580(param, vData.sndList, 1, vTransform.position);
						}
						vigObject.DAT_19 = 0;
						goto IL_057a;
					}
					num++;
					continue;
					IL_057a:
					GameManager.instance.FUN_30CB0(vigObject, 6);
					GameManager.instance.FUN_300B8(oLYMPIC.DAT_A4, vObject);
					UnityEngine.Object.Destroy(vObject.gameObject);
					return 0u;
				}
				return 0u;
			}
			if (!FUN_32CF0(hit))
			{
				break;
			}
			vigObject2 = child2;
			while (vigObject2 != null)
			{
				if (vigObject2.id == 1)
				{
					vigObject2.type = 3;
				}
				vigObject2 = vigObject2.child;
			}
			break;
		}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (state)
		{
		case _FINISHSIGN_TYPE.Default:
			switch (arg1)
			{
			case 1:
			{
				VigObject vigObject2 = child2;
				while (vigObject2 != null)
				{
					if (vigObject2.id == 1)
					{
						vigObject2.type = 3;
					}
					vigObject2 = vigObject2.child;
				}
				if (id == 41)
				{
					state = _FINISHSIGN_TYPE.Type1;
				}
				break;
			}
			case 8:
			{
				if (!FUN_32B90((uint)arg2))
				{
					break;
				}
				VigObject vigObject2 = child2;
				while (vigObject2 != null)
				{
					if (vigObject2.id == 1)
					{
						vigObject2.type = 3;
					}
					vigObject2 = vigObject2.child;
				}
				break;
			}
			}
			break;
		case _FINISHSIGN_TYPE.Type1:
			switch (arg1)
			{
			case 1:
			{
				VigObject vigObject = child2;
				while (vigObject != null)
				{
					if (vigObject.id == 1)
					{
						vigObject.type = 3;
					}
					vigObject = vigObject.child;
				}
				break;
			}
			case 8:
			{
				if (!FUN_32B90((uint)arg2))
				{
					break;
				}
				VigObject vigObject = child2;
				while (vigObject != null)
				{
					if (vigObject.id == 1)
					{
						vigObject.type = 3;
					}
					vigObject = vigObject.child;
				}
				break;
			}
			}
			break;
		}
		return 0u;
	}
}
