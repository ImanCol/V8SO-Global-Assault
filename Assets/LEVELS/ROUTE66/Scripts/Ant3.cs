public class Ant3 : VigObject
{
	public VigCamera[] DAT_8C = new VigCamera[2];

	public short[] cameraDefault = new short[2];

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
			int y = physics1.Y;
			int num = -y;
			physics1.Y = num;
			if (y < 0)
			{
				num -= physics1.Z;
				physics1.Y = num;
				if (num < 1)
				{
					GameManager.instance.FUN_307CC(this);
					for (int i = 0; i < DAT_8C.Length; i++)
					{
						if (DAT_8C[i] != null)
						{
							DAT_8C[i].DAT_94 = cameraDefault[i];
						}
					}
					return uint.MaxValue;
				}
				y = physics1.Z;
				num = y;
				if (y < 0)
				{
					num += 31;
				}
				physics1.Z = y - (num >> 5);
			}
			int num2 = 0;
			y = physics1.Y;
			int x = physics1.X;
			Vehicle[] playerObjects = GameManager.instance.playerObjects;
			do
			{
				Vehicle vehicle = playerObjects[num2];
				if (vehicle != null && (vehicle.flags & 0x2000000) == 0 && vehicle.vCamera != null)
				{
					VigCamera vigCamera = DAT_8C[num2];
					if (vigCamera == vehicle.vCamera)
					{
						vigCamera.DAT_94 += (short)(y - x >> 16);
					}
					else
					{
						if (vigCamera != null)
						{
							vigCamera.DAT_94 -= physics1.M1;
						}
						DAT_8C[num2] = vehicle.vCamera;
						cameraDefault[num2] = DAT_8C[num2].DAT_94;
						vehicle.vCamera.DAT_94 += physics1.M3;
					}
				}
				num2++;
			}
			while (num2 < 2);
			physics1.X = physics1.Y;
			GameManager.instance.FUN_30CB0(this, 3);
		}
		return 0u;
	}
}
