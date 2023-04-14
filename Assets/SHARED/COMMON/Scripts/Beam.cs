using UnityEngine;

public class Beam : VigObject
{
	public Beam2[] DAT_84_2;

	public VigObject DAT_C0;

	public MegaCollider DAT_C4;

	public int DAT_C8;

	public int DAT_CC;

	public Vector3Int DAT_D0;

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
			switch (tags)
			{
			case 1:
				tags = 2;
				GameManager.instance.FUN_30CB0(this, 5);
				DAT_CC = 0;
				break;
			case 0:
			{
				int dAT_CC = DAT_CC;
				DAT_84_2[dAT_CC].flags &= 4294967293u;
				if (dAT_CC != 0)
				{
					DAT_C0.FUN_2CCBC();
					ConfigContainer cont = DAT_84_2[dAT_CC].FUN_2C5F4(32768);
					Utilities.FUN_2CA94(DAT_84_2[dAT_CC], cont, DAT_C0);
					Utilities.ParentChildren(DAT_84_2[dAT_CC], DAT_84_2[dAT_CC]);
				}
				if (++DAT_CC < 15)
				{
					GameManager.instance.FUN_30CB0(this, 2);
					break;
				}
				GameManager.instance.FUN_30CB0(this, 60);
				tags = 1;
				break;
			}
			case 2:
				tags = 3;
				GameManager.instance.FUN_30CB0(this, 30);
				DAT_CC = 0;
				DAT_C8 = 4096;
				break;
			case 3:
			{
				FUN_30BA8();
				VigObject param = FUN_2CCBC();
				GameManager.instance.FUN_308C4(param);
				break;
			}
			}
		}
		else if (arg1 < 3)
		{
			if (arg1 == 0)
			{
				Vector3Int dAT_D = DAT_D0;
				VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
				int num = 1;
				DAT_84_2[0].vTransform = vigTransform;
				do
				{
					Beam2 obj = DAT_84_2[num];
					obj.vTransform = vigTransform;
					obj.vTransform.position = Utilities.FUN_24148(vigTransform, dAT_D);
					dAT_D.x += DAT_D0.x;
					dAT_D.y += DAT_D0.y;
					dAT_D.z += DAT_D0.z;
					num++;
					obj.flags ^= 32u;
				}
				while (num < 15);
				int num2;
				if (tags == 3)
				{
					num2 = 0;
					Vector3Int param2 = default(Vector3Int);
					param2.x = DAT_C8 - 129;
					DAT_C8 = param2.x;
					param2.y = DAT_C8;
					param2.z = 4096;
					FUN_B90(ref vTransform.rotation, param2);
					do
					{
						Beam2 obj2 = DAT_84_2[num2];
						num2++;
						FUN_B90(ref obj2.vTransform.rotation, param2);
					}
					while (num2 < 15);
				}
				Vehicle obj3 = (Vehicle)DAT_80;
				num2 = obj3.physics2.X;
				int dAT_CC = num2;
				if (num2 < 0)
				{
					dAT_CC = num2 + 3;
				}
				int y = obj3.physics2.Y;
				obj3.physics2.X = num2 - (dAT_CC >> 2);
				dAT_CC = y;
				if (y < 0)
				{
					dAT_CC = y + 3;
				}
				num2 = obj3.physics2.Z;
				obj3.physics2.Y = y - (dAT_CC >> 2);
				dAT_CC = num2;
				if (num2 < 0)
				{
					dAT_CC = num2 + 3;
				}
				y = obj3.physics1.X;
				obj3.physics2.Z = num2 - (dAT_CC >> 2);
				dAT_CC = y;
				if (y < 0)
				{
					dAT_CC = y + 3;
				}
				num2 = obj3.physics1.Y;
				obj3.physics1.X = y - (dAT_CC >> 2);
				dAT_CC = num2;
				if (num2 < 0)
				{
					dAT_CC = num2 + 3;
				}
				y = obj3.physics1.Z;
				obj3.physics1.Y = num2 - (dAT_CC >> 2);
				dAT_CC = y;
				if (y < 0)
				{
					dAT_CC = y + 3;
				}
				obj3.physics1.Z = y - (dAT_CC >> 2);
			}
		}
		else
		{
			int dAT_CC = 0;
			if (arg1 == 4)
			{
				VigObject vigObject = Utilities.FUN_2CD78(DAT_C4);
				do
				{
					GameManager.instance.FUN_309A0(DAT_84_2[dAT_CC]);
					DAT_84_2[dAT_CC] = null;
					dAT_CC++;
				}
				while (dAT_CC < 15);
				if (vigObject != null && GameManager.instance.FUN_30134(GameManager.instance.worldObjs, vigObject) != null && DAT_C4.maxHalfHealth == 0)
				{
					DAT_C4.FUN_3A368();
				}
				GameManager.instance.DAT_1084--;
			}
		}
		return 0u;
	}

	private static void FUN_B90(ref Matrix3x3 param1, Vector3Int param2)
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
