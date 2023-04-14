using UnityEngine;

public class Launch : VigObject
{
	public static Launch instance;

	public byte DAT_5874;

	public byte DAT_5875;

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
		GameManager.instance.FUN_17F34(194560, 2147418112);
		if (instance == null)
		{
			instance = this;
		}
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 1)
		{
			switch (arg1)
			{
			case 2:
				break;
			case 17:
				GameManager.instance.FUN_17EB8();
				return 0u;
			default:
				return 0u;
			}
		}
		else
		{
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.4f;
			GameManager.instance.aspectRatioScale = 240f;
			Color32 dAT_DE = LevelManager.instance.DAT_DE0;
			dAT_DE.a = 128;
			UIManager.instance.underwater.color = dAT_DE;
			VigObject param = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			DAT_5875 = 0;
			DAT_5874 = 0;
			GameManager.instance.DAT_1000 |= 4;
		}
		GameManager.instance.FUN_34B34();
		GameManager.instance.FUN_30CB0(this, 240);
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		switch (arg2)
		{
		case 18:
			GameManager.instance.FUN_327CC(arg1);
			break;
		case 19:
		{
			VigObject vigObject = GameManager.instance.FUN_318D0(49);
			ushort num = (ushort)((vigObject.screen.x < arg1.vTransform.position.x) ? 1 : 0);
			ConfigContainer param = vigObject.FUN_2C5F4((ushort)(num + 32768));
			arg1.vTransform = GameManager.instance.FUN_2CEAC(vigObject, param);
			int num2 = arg1.vTransform.rotation.V02 * 15258;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.X = num2 >> 5;
			num2 = arg1.vTransform.rotation.V12 * 15258;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.Y = num2 >> 5;
			num2 = arg1.vTransform.rotation.V22 * 15258;
			if (num2 < 0)
			{
				num2 += 31;
			}
			arg1.physics1.Z = num2 >> 5;
			arg1.physics2.X = 0;
			arg1.physics2.Y = 0;
			arg1.physics2.Z = 0;
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param2, GameManager.instance.DAT_C2C, 37, arg1.vTransform.position);
			Vehicle vehicle = (Vehicle)arg1;
			if (vehicle.vCamera != null)
			{
				VigObject param3 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, num + 513);
				VigCamera vigCamera = LevelManager.instance.FUN_4B984(vehicle, param3);
				vigCamera.maxHalfHealth = 256;
				vehicle.vCamera.flags &= 4093640703u;
				GameManager.instance.FUN_30CB0(vehicle.vCamera, 90);
				vehicle.vCamera = vigCamera;
				LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
				vigCamera.FUN_30B78();
			}
			vehicle.FUN_41FEC();
			return uint.MaxValue;
		}
		}
		return 0u;
	}

	public static void FUN_5730(ref Matrix3x3 param1, Vector3Int param2)
	{
		int x = param2.x;
		int y = param2.y;
		int z = param2.z;
		param1.V00 = (short)(param1.V00 * x >> 12);
		param1.V01 = (short)(param1.V01 * y >> 12);
		param1.V02 = (short)(param1.V02 * z >> 12);
		param1.V10 = (short)(param1.V10 * x >> 12);
		param1.V11 = (short)(param1.V11 * y >> 12);
		param1.V12 = (short)(param1.V12 * z >> 12);
		param1.V20 = (short)(param1.V20 * x >> 12);
		param1.V21 = (short)(param1.V21 * y >> 12);
		param1.V22 = (short)(param1.V22 * z >> 12);
	}
}
