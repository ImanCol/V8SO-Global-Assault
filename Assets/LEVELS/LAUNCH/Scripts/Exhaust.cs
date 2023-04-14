using UnityEngine;

public class Exhaust : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			FUN_1E78();
			GameManager.instance.FUN_307CC(this);
		}
		return 0u;
	}

	private static void FUN_1E78()
	{
		VigObject vigObject = GameManager.instance.FUN_318D0(49);
		int num = 0;
		if (!(vigObject != null))
		{
			return;
		}
		do
		{
			ConfigContainer configContainer = vigObject.FUN_2C5F4((ushort)((num - 32768) & 0xFFFF));
			if (configContainer != null)
			{
				LaunchRocket3 launchRocket = new GameObject().AddComponent<LaunchRocket3>();
				if (launchRocket != null)
				{
					VigCollider vCollider = null;
					if (-1 < configContainer.colliderID)
					{
						vCollider = new VigCollider(vigObject.vData.cbbList[configContainer.colliderID].buffer);
					}
					launchRocket.vCollider = vCollider;
					launchRocket.vTransform = GameManager.instance.FUN_2CEAC(vigObject, configContainer);
					launchRocket.flags = 386u;
					launchRocket.type = 3;
					launchRocket.FUN_305FC();
					launchRocket.DAT_58 = 851968;
					GameManager.instance.FUN_30CB0(launchRocket, 180);
				}
			}
			num++;
		}
		while (num < 2);
	}
}
