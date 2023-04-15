using UnityEngine;

public class Blimp2 : VigObject
{
	public XOBF_DB DAT_98;

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
		if (arg1 == 0)
		{
			short num = (short)(physics1.M0 - 1);
			physics1.M0 = num;
			if (num == -1)
			{
				Smoke4 obj = DAT_98.ini.FUN_2C17C((ushort)physics2.M3, typeof(Smoke4), 8u) as Smoke4;
				int num2 = (int)((GameManager.FUN_2AC5C() & 0xFFF) * 2);
				obj.flags |= 1204u;
				int num3 = physics1.Y * GameManager.DAT_65C90[num2];
				if (num3 < 0)
				{
					num3 += 4095;
				}
				obj.physics1.Z = num3 >> 12;
				num2 = physics1.Y * GameManager.DAT_65C90[num2 + 1];
				if (num2 < 0)
				{
					num2 += 4095;
				}
				obj.physics2.X = num2 >> 12;
				num2 = (int)GameManager.FUN_2AC5C();
				obj.physics1.W = physics1.Z + (num2 * physics1.Z >> 15);
				Vector3Int position = GameManager.instance.FUN_2CE50(this);
				obj.vTransform.position = position;
				obj.FUN_305FC();
				physics1.M0 = physics1.M1;
			}
		}
		return 0u;
	}
}
