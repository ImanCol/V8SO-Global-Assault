using System.Collections.Generic;

public class Bobsled : Destructible
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
		if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) != 0 && hit.self.type == 2)
		{
			List<VigTuple> dAT_ = ((OLYMPIC)LevelManager.instance.level).DAT_98;
			for (int i = 0; i < dAT_.Count; i++)
			{
				VigObject vObject = dAT_[i].vObject;
				if (vObject.id == hit.self.id)
				{
					if (vObject.DAT_19 != id)
					{
						return 0u;
					}
					vObject.DAT_19++;
					int num = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(num, vData.sndList, 2, vTransform.position);
					GameManager.instance.FUN_1E30C(num, (id - 33) * 250 + 4096);
					return 0u;
				}
			}
		}
		else if (FUN_32CF0(hit))
		{
			VigObject vObject = child2;
			while (vObject != null)
			{
				if (vObject.id == 1)
				{
					vObject.type = 3;
				}
				vObject = vObject.child;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id == 1)
				{
					vigObject.type = 3;
				}
				vigObject = vigObject.child;
			}
			break;
		}
		case 8:
		{
			if (!FUN_32B90((uint)arg2))
			{
				break;
			}
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id == 1)
				{
					vigObject.type = 3;
				}
				vigObject = vigObject.child;
			}
			break;
		}
		}
		return 0u;
	}
}
