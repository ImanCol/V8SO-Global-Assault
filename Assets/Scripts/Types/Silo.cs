using System.Collections.Generic;

public class Silo : Destructible
{
	public ConfigContainer CCDAT_78;

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
		if (hit.object1 == child2)
		{
			bool flag = false;
			if (hit.self.type == 8)
			{
				flag = hit.object1.FUN_32B90(hit.self.maxHalfHealth);
			}
			if (!flag)
			{
				return 0u;
			}
			tags = 30;
			DAT_4A = GameManager.instance.timer;
			FUN_30BF0();
			GameManager.instance.FUN_30CB0(this, 120);
			return 0u;
		}
		if (hit.self.type != 8)
		{
			return 0u;
		}
		ConfigContainer cCDAT_ = CCDAT_78;
		ushort flag2 = cCDAT_.flag;
		if ((flags & 4) != 0)
		{
			cCDAT_.flag = 0;
		}
		FUN_32B90(hit.self.maxHalfHealth);
		cCDAT_.flag = flag2;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			FUN_30C20();
			child2.FUN_30BF0();
			child2.maxHalfHealth = 14;
			int index = (int)FUN_4DC20();
			CCDAT_78 = vData.ini.configContainers[index];
			int y = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
			screen.y = y;
			break;
		}
		case 2:
		{
			List<VigTuple> worldObjs = GameManager.instance.worldObjs;
			VigTuple vigTuple = null;
			if (worldObjs != null)
			{
				int num = 0;
				while (true)
				{
					if (num < worldObjs.Count)
					{
						VigTuple vigTuple2 = worldObjs[num];
						VigObject vObject = vigTuple2.vObject;
						if (vObject.type == 2 && vObject.maxHalfHealth != 0)
						{
							int index = Utilities.FUN_29F6C(vObject.vTransform.position, screen);
							vigTuple = vigTuple2;
							if (index < 307200)
							{
								break;
							}
						}
						num++;
						continue;
					}
					vigTuple = null;
					break;
				}
				if (vigTuple != null)
				{
					tags = 1;
					if (tags-- != 1)
					{
						int y = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E628(y, vData.sndList, 1, vTransform.position);
						return 0u;
					}
					ConfigContainer cCDAT_ = CCDAT_78;
					ushort flag = cCDAT_.flag;
					cCDAT_.flag = 0;
					FUN_4DC94();
					cCDAT_.flag = flag;
					return uint.MaxValue;
				}
			}
			GameManager.instance.FUN_30CB0(this, 15);
			return 0u;
		}
		case 8:
		{
			ConfigContainer cCDAT_ = CCDAT_78;
			ushort flag = cCDAT_.flag;
			if ((flags & 4) != 0)
			{
				cCDAT_.flag = 0;
			}
			FUN_32B90((uint)arg2);
			cCDAT_.flag = flag;
			break;
		}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			if (tags-- << 24 != 1)
			{
				if ((child2.flags & 0x20) != 0)
				{
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param, vData.sndList, 1, vTransform.position);
				}
				return 0u;
			}
			ConfigContainer cCDAT_ = CCDAT_78;
			ushort flag = cCDAT_.flag;
			cCDAT_.flag = 0;
			FUN_4DC94();
			cCDAT_.flag = flag;
			return uint.MaxValue;
		}
		return 0u;
	}
}
