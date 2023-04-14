using UnityEngine;

public class Demon : VigObject
{
	public VigObject DAT_94;

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
			Vector3Int vout = default(Vector3Int);
			vout.x = GameManager.DAT_65C90[((ushort)vr.y & 0xFFF) * 2] * 7;
			vout.y = 0;
			vout.z = GameManager.DAT_65C90[((ushort)vr.x & 0xFFF) * 2 + 1] * 7;
			if ((GameManager.FUN_2AC5C() & 0x1F) == 0)
			{
				short y = (short)GameManager.FUN_2AC5C();
				vr.y = y;
			}
			Vector3Int vin = Utilities.FUN_23ED0(GameManager.instance.FUN_2CDF4(DAT_94), vout);
			vin.x -= vTransform.position.x;
			vin.y -= vTransform.position.y;
			vin.z -= vTransform.position.z;
			Utilities.FUN_29FC8(vin, out vout);
			int num = vout.x;
			if (num < 0)
			{
				num += 15;
			}
			int z = physics1.Z;
			int num2 = z;
			if (z < 0)
			{
				num2 = z + 255;
			}
			physics1.Z = z + ((num >> 4) - (num2 >> 8));
			num = vout.y;
			if (num < 0)
			{
				num += 15;
			}
			z = physics1.W;
			num2 = z;
			if (z < 0)
			{
				num2 = z + 63;
			}
			physics1.W = z + ((num >> 4) - (num2 >> 6));
			num = vout.z;
			if (num < 0)
			{
				num += 15;
			}
			z = physics2.X;
			num2 = z;
			if (z < 0)
			{
				num2 = z + 255;
			}
			physics2.X = z + ((num >> 4) - (num2 >> 8));
			vTransform.position.x += physics1.Z;
			vTransform.position.y += physics1.W;
			vTransform.position.z += physics2.X;
			Utilities.FUN_29FC8(new Vector3Int(physics1.Z, physics1.W, physics2.X), out vout);
			vTransform.rotation = Utilities.FUN_2A724(vout);
		}
		return 0u;
	}
}
