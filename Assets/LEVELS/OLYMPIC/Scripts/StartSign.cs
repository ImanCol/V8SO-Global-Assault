using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _STARTSIGN_TYPE
{
    Default, //FUN_3BA4
    Type1 //FUN_3900
}

public class StartSign : Destructible
{
	public _STARTSIGN_TYPE state;

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
		case _STARTSIGN_TYPE.Default:
		{
			if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) != 0)
			{
				VigObject self = hit.self;
				if (self.type == 2)
				{
					Vehicle vehicle = (Vehicle)self;
					List<VigTuple> dAT_A = ((OLYMPIC)LevelManager.instance.level).DAT_98;
					VigObject vigObject = null;
					for (int j = 0; j < dAT_A.Count; j++)
					{
						vigObject = dAT_A[j].vObject;
						if (vigObject.id == vehicle.id)
						{
							if (vigObject.DAT_19 != 34 || 180 < GameManager.instance.DAT_28 - vigObject.maxHalfHealth)
							{
								GameManager.instance.FUN_300B8(dAT_A, vigObject);
								UnityEngine.Object.Destroy(vigObject.gameObject);
								vigObject = null;
							}
							break;
						}
						vigObject = null;
					}
					if (vigObject == null)
					{
						vigObject = new GameObject().AddComponent<VigObject>();
						if (vigObject != null)
						{
							GameManager.instance.FUN_30080(dAT_A, vigObject);
							short id = vehicle.id;
							vigObject.DAT_19 = 34;
							vigObject.id = id;
							vigObject.maxHalfHealth = (ushort)GameManager.instance.DAT_28;
							int param = GameManager.instance.FUN_1DD9C();
							GameManager.instance.FUN_1E580(param, vData.sndList, 2, vTransform.position);
						}
					}
					return 0u;
				}
			}
			if (!FUN_32CF0(hit))
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
		case _STARTSIGN_TYPE.Type1:
		{
			if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) != 0)
			{
				VigObject self = hit.self;
				if (self.type == 2)
				{
					Vehicle vehicle = (Vehicle)self;
					List<VigTuple> dAT_A = ((OLYMPIC)LevelManager.instance.level).DAT_A4;
					VigObject vigObject = null;
					for (int i = 0; i < dAT_A.Count; i++)
					{
						vigObject = dAT_A[i].vObject;
						if (vigObject.id == vehicle.id)
						{
							if (vigObject.DAT_19 != 97 || 180 < GameManager.instance.DAT_28 - vigObject.maxHalfHealth)
							{
								GameManager.instance.FUN_300B8(dAT_A, vigObject);
								UnityEngine.Object.Destroy(vigObject.gameObject);
								vigObject = null;
							}
							break;
						}
						vigObject = null;
					}
					if (vigObject == null)
					{
						vigObject = new GameObject().AddComponent<VigObject>();
						if (vigObject != null)
						{
							GameManager.instance.FUN_30080(dAT_A, vigObject);
							short id = vehicle.id;
							vigObject.DAT_19 = 97;
							vigObject.id = id;
							vigObject.maxHalfHealth = (ushort)GameManager.instance.DAT_28;
							int param = GameManager.instance.FUN_1DD9C();
							GameManager.instance.FUN_1E580(param, vData.sndList, 2, vTransform.position);
						}
					}
					return 0u;
				}
			}
			if (!FUN_32CF0(hit))
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
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (state)
		{
		case _STARTSIGN_TYPE.Default:
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
				if (id == 40)
				{
					state = _STARTSIGN_TYPE.Type1;
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
		case _STARTSIGN_TYPE.Type1:
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
