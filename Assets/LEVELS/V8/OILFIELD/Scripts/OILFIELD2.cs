using System.Collections.Generic;

public class OILFIELD2 : VigObject
{
	public static OILFIELD2 instance;

	public List<VigObject> DAT_1160;

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
			DAT_1160 = new List<VigObject>();
			DAT_1160.Add(null);
		}
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 2)
		{
			if (2 < arg1)
			{
				if (arg1 == 4)
				{
					GameManager.instance.FUN_2C4B4(DAT_1160[0]);
					return 0u;
				}
				return 0u;
			}
			if (arg1 != 1)
			{
				return 0u;
			}
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.6f;
			GameManager.instance.aspectRatioScale = 240f;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			GameManager.instance.FUN_4EEB0(DAT_1160, LevelManager.instance.xobfList[19], 21, typeof(Fire3), 128);
			id = 1;
		}
		GameManager.instance.FUN_34B34();
		GameManager.instance.FUN_30CB0(this, 240);
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		if (arg2 == 18)
		{
			GameManager.instance.FUN_327CC(arg1);
			return 0u;
		}
		return 0u;
	}
}
