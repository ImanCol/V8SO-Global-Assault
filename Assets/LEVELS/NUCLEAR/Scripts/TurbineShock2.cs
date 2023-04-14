using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _TURBINESHOCK2_TYPE
{
    Default,
    Type1 //FUN_19B8 (NUCLEAR.DLL)
}

public class TurbineShock2 : VigObject
{
	public _TURBINESHOCK2_TYPE state;

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
		if (state == _TURBINESHOCK2_TYPE.Type1 && arg1 == 2)
		{
			state = _TURBINESHOCK2_TYPE.Default;
			Utilities.FUN_2CDB0(this).flags &= 4294967263u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (state == _TURBINESHOCK2_TYPE.Type1 && arg1 == 5)
		{
			FUN_30C20();
			flags |= 2u;
			GameManager.instance.FUN_30CB0(this, 120);
		}
		return 0u;
	}
}
