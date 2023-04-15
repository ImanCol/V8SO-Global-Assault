using UnityEngine;

public class WILDWEST : VigObject
{
	public static WILDWEST instance;

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
			flags |= 8192u;
		}
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 1)
		{
			if (arg1 != 2)
			{
				goto IL_00af;
			}
		}
		else
		{
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.5f;
			GameManager.instance.aspectRatioScale = 240f;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			id = 1;
		}
		GameManager.instance.FUN_34B34();
		GameManager.instance.FUN_30CB0(this, 240);
		goto IL_00af;
		IL_00af:
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, Vector3Int arg3)
	{
		if (arg2 == 10 && arg1.type == 9)
		{
			VigObject vigObject = Utilities.FUN_2CD78(arg1);
			if (vigObject.id < 0 && 3051 < vigObject.physics1.W)
			{
				GameManager.instance.FUN_15ADC(~vigObject.id, 4);
			}
		}
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

	public override sbyte UpdateW(VigObject arg1, int arg2, TileData arg3)
	{
		if (arg2 == 12)
		{
			int num = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(num, LevelManager.instance.xobfList[42].sndList, 5, 0u, param5: true);
			return (sbyte)num;
		}
		return 0;
	}
}
