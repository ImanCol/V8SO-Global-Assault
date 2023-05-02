using System.Collections.Generic;
using UnityEngine;

public class CANYNLND : VigObject
{
	public static CANYNLND instance;

	public List<VigTuple> DAT_1298;

	public int DAT_12A4;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		default:
			return 0u;
		case 1:
		{
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.35f;
			GameManager.instance.aspectRatioScale = 240f;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			DAT_1298 = new List<VigTuple>();
			DAT_12A4 = 0;
			id = 1;
			break;
		}
		case 2:
			break;
		}
		GameManager.instance.FUN_34B34();
		GameManager.instance.FUN_30CB0(this, 240);
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		if (arg2 != 18)
		{
			return 0u;
		}
		if (arg3 == 0 || arg1.type != 8 || (arg1.flags & 0x20000000) == 0 || -1 < arg1.DAT_80.id)
		{
			GameManager.instance.FUN_327CC(arg1);
			return 0u;
		}
		Vector2Int param = default(Vector2Int);
		Vector2Int param2 = default(Vector2Int);
		param.x = arg1.vTransform.position.x - 1024000;
		param.y = arg1.vTransform.position.x + 1024000;
		param2.x = arg1.vTransform.position.z - 1024000;
		param2.y = arg1.vTransform.position.z + 1024000;
		VigObject vigObject = GameManager.instance.FUN_31B30(GameManager.instance.bspTree, 49, 49, param, param2);
		if (vigObject == null)
		{
			return 0u;
		}
		if (5 < DAT_12A4)
		{
			VigObject vObject = DAT_1298[0].vObject;
			if (vObject.GetType().IsSubclassOf(typeof(VigObject)))
			{
				vObject.UpdateW(2, 0);
			}
		}
		if (!vigObject.GetType().IsSubclassOf(typeof(VigObject)))
		{
			return 0u;
		}
		vigObject.UpdateW(10, 0);
		return 0u;
	}
}
