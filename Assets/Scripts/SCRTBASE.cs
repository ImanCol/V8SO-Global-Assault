using System.Collections.Generic;

public class SCRTBASE : VigObject
{
	public static SCRTBASE instance;

	public int DAT_2C74;

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
			DAT_2C74 = 0;
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.4f;
			GameManager.instance.aspectRatioScale = 240f;
			id = 1;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			tags = 30;
			break;
		}
		case 2:
			break;
		}
		if ((maxHalfHealth++ & 3) == 0)
		{
			GameManager.instance.FUN_34B34();
		}
		sbyte b = --tags;
		int param2;
		if (b == 0)
		{
			param2 = 1;
			goto IL_017a;
		}
		if (-1 >= b)
		{
			List<VigTuple> worldObjs = GameManager.instance.worldObjs;
			for (int i = 0; i < worldObjs.Count; i++)
			{
				VigObject x = worldObjs[i].vObject;
				if (x.type == 2 && x.maxHalfHealth != 0 && x.screen.z < 78848000)
				{
					GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 10, x);
				}
			}
			if (tags == -4)
			{
				int num = (int)GameManager.FUN_2AC5C();
				tags = (sbyte)((num * 30 >> 15) + 30);
				param2 = 0;
				goto IL_017a;
			}
		}
		goto IL_019c;
		IL_017a:
		GameManager.instance.FUN_312DC(GameManager.instance.bspTree, FUN_1D0, param2);
		goto IL_019c;
		IL_019c:
		GameManager.instance.FUN_30CB0(this, 60);
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		if (arg2 == 18)
		{
			GameManager.instance.FUN_327CC(arg1);
		}
		return 0u;
	}

	public static uint FUN_1D0(VigTuple param1, int param2)
	{
		VigObject vObject = param1.vObject;
		if (vObject.id == 118 && vObject.GetType().IsSubclassOf(typeof(VigObject)))
		{
			return vObject.UpdateW(10, param2);
		}
		return 0u;
	}
}