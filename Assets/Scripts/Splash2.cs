using UnityEngine;

public class Splash2 : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2, uint arg3)
	{
		LevelManager.instance.level.vData = arg1;
		return new GameObject().AddComponent<Splash>();
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return uint.MaxValue;
		}
		return 0u;
	}
}
