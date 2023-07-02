using UnityEngine;

public class SheetMetalDrum : Destructible
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint OnCollision(HitDetection hit)
	{
		bool num = FUN_32CF0(hit);
		uint result = 0u;
		if (num)
		{
			VigObject child = child2;
			VigTransform vigTransform = child.vTransform = GameManager.instance.FUN_2CDF4(child);
			child.FUN_2CCBC();
			SheetMetalDrum2 sheetMetalDrum = Utilities.FUN_52188(child, typeof(SheetMetalDrum2)) as SheetMetalDrum2;
			sheetMetalDrum.id = 1000;
			int num2 = sheetMetalDrum.screen.y * -12867;
			sheetMetalDrum.flags |= 128u;
			ushort maxFullHealth = base.maxFullHealth;
			sheetMetalDrum.DAT_A8 = -sheetMetalDrum.screen.y;
			sheetMetalDrum.maxHalfHealth = maxFullHealth;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			Vector3Int pos = default(Vector3Int);
			pos.x = sheetMetalDrum.vTransform.position.x;
			sheetMetalDrum.DAT_A4 = (short)(16777216 / (num2 >> 12));
			pos.y = sheetMetalDrum.vTransform.position.y + sheetMetalDrum.DAT_A8;
			pos.z = sheetMetalDrum.vTransform.position.z;
			num2 = sheetMetalDrum.FUN_2CFBC(pos);
			sheetMetalDrum.physics2.W = num2;
			sheetMetalDrum.physics2.Z = num2 - 655;
			sheetMetalDrum.DAT_A0_2 = 240;
			sheetMetalDrum.physics2.Y = 6553;
			sheetMetalDrum.physics1.M6 = 0;
			sheetMetalDrum.physics1.M7 = 0;
			sheetMetalDrum.physics2.M0 = 0;
			sheetMetalDrum.FUN_2D1DC();
			sheetMetalDrum.FUN_4C98C();
			sheetMetalDrum.FUN_305FC();
			GameManager.instance.FUN_4C4BC(sheetMetalDrum.vShadow);
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0u;
		}
		bool num = FUN_32B90((uint)arg2);
		uint result = 0u;
		if (num)
		{
			VigObject child = child2;
			VigTransform vigTransform = child.vTransform = GameManager.instance.FUN_2CDF4(child);
			child.FUN_2CCBC();
			SheetMetalDrum2 sheetMetalDrum = Utilities.FUN_52188(child, typeof(SheetMetalDrum2)) as SheetMetalDrum2;
			sheetMetalDrum.id = 1000;
			int num2 = sheetMetalDrum.screen.y * -12867;
			sheetMetalDrum.flags |= 128u;
			ushort maxFullHealth = base.maxFullHealth;
			sheetMetalDrum.DAT_A8 = -sheetMetalDrum.screen.y;
			sheetMetalDrum.maxHalfHealth = maxFullHealth;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			Vector3Int pos = default(Vector3Int);
			pos.x = sheetMetalDrum.vTransform.position.x;
			sheetMetalDrum.DAT_A4 = (short)(16777216 / (num2 >> 12));
			pos.y = sheetMetalDrum.vTransform.position.y + sheetMetalDrum.DAT_A8;
			pos.z = sheetMetalDrum.vTransform.position.z;
			num2 = sheetMetalDrum.FUN_2CFBC(pos);
			sheetMetalDrum.physics2.W = num2;
			sheetMetalDrum.physics2.Z = num2 - 655;
			sheetMetalDrum.DAT_A0_2 = 240;
			sheetMetalDrum.physics2.Y = 6553;
			sheetMetalDrum.physics1.M6 = 0;
			sheetMetalDrum.physics1.M7 = 0;
			sheetMetalDrum.physics2.M0 = 0;
			sheetMetalDrum.FUN_2D1DC();
			sheetMetalDrum.FUN_4C98C();
			sheetMetalDrum.FUN_305FC();
			GameManager.instance.FUN_4C4BC(sheetMetalDrum.vShadow);
		}
		return result;
	}
}
