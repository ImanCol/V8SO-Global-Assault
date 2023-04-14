public class WindTunnel : Destructible
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
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 2:
		{
			int num = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_30CB0(this, (num * 300 >> 15) + 600);
			ConfigContainer configContainer = FUN_2C5F4(32768);
			if (configContainer != null)
			{
				WindTunnel2 windTunnel = vData.ini.FUN_2C17C(10, typeof(WindTunnel2), 8u) as WindTunnel2;
				if (windTunnel != null)
				{
					Utilities.ParentChildren(windTunnel, windTunnel);
					windTunnel.vTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
					windTunnel.type = 3;
					windTunnel.flags = 900u;
					windTunnel.id = id;
					num = (int)GameManager.FUN_2AC5C();
					GameManager.instance.FUN_30CB0(windTunnel, (num * 180 >> 15) + 300);
					windTunnel.FUN_305FC();
					windTunnel.tags = 0;
					windTunnel.DAT_19 = 0;
					windTunnel.DAT_58 = 655360;
					sbyte param = windTunnel.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, windTunnel.vData.sndList, 5, windTunnel.vTransform.position, param5: true);
				}
			}
			break;
		}
		case 1:
		{
			int num = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_30CB0(this, num * 600 >> 15);
			break;
		}
		case 8:
			FUN_32B90((uint)arg2);
			break;
		}
		return 0u;
	}
}
