using System.Collections.Generic;
using UnityEngine;

public class Route66 : VigObject
{
	public static Meteorite DAT_5304;

	public static Vector3Int[] DAT_5268 = new Vector3Int[32];

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 1)
		{
			if (arg1 != 2)
			{
				goto IL_0147;
			}
		}
		else
		{
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.4f;
			GameManager.instance.aspectRatioScale = 240f;
			GameManager.instance.DAT_1000 |= 1;
			DAT_5304 = new GameObject().AddComponent<Meteorite>();
			DAT_5304.id = 0;
			GameManager.instance.FUN_30CB0(DAT_5304, 900);
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			List<VigTuple> dAT_ = GameManager.instance.DAT_1078;
			for (int i = 0; i < dAT_.Count; i++)
			{
				x = dAT_[i].vObject;
				if ((uint)((ushort)x.id - 400) < 13u)
				{
					int num = (ushort)x.id - 400;
					DAT_5268[num] = x.screen;
				}
			}
		}
		GameManager.instance.FUN_34B34();
		GameManager.instance.FUN_30CB0(this, 240);
		goto IL_0147;
		IL_0147:
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
}
