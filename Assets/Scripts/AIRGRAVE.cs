public class AIRGRAVE : VigObject
{
	public static AIRGRAVE instance;

	public int destroyedTowers;

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
			destroyedTowers = 0;
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
			GameManager.instance.angleOffset = 0.45f;
			GameManager.instance.aspectRatioScale = 240f;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
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
		if ((uint)((ushort)arg1.id - 104) < 3u && (arg1.flags & 0x4000) != 0)
		{
			VigObject vigObject = GameManager.instance.FUN_318F8(arg1.id, arg1);
			if (vigObject != null)
			{
				VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(vigObject.id);
				if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
				{
					vigObject.UpdateW(8, -1);
				}
				if (vigTuple != null)
				{
					LevelManager.instance.FUN_359CC(vigTuple.array, 36736u);
				}
			}
		}
		GameManager.instance.FUN_327CC(arg1);
		return 0u;
	}
}
