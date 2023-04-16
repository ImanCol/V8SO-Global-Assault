using System.Collections.Generic;

public class Pipe4 : Destructible
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
		if (FUN_32CF0(hit))
		{
			short[] array = new short[4];
			int x = vTransform.position.x;
			array[0] = (short)(x >> 16);
			if (x < 0)
			{
				array[0] = (short)(x + 65535 >> 16);
			}
			x = vTransform.position.z;
			if (x < 0)
			{
				x += 65535;
			}
			array[1] = (short)(x >> 16);
			array[2] = 1;
			array[3] = 1;
			LevelManager.instance.FUN_359CC(array, 36736u);
			List<VigTuple> dAT_ = GameManager.instance.DAT_1078;
			for (int i = 0; i < dAT_.Count; i++)
			{
				VigObject vObject = dAT_[i].vObject;
				if (vObject.id == id)
				{
					vObject.flags &= 4294967293u;
				}
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0u;
		}
		if (FUN_32B90((uint)arg2))
		{
			short[] array = new short[4];
			int x = vTransform.position.x;
			array[0] = (short)(x >> 16);
			if (x < 0)
			{
				array[0] = (short)(x + 65535 >> 16);
			}
			x = vTransform.position.z;
			if (x < 0)
			{
				x += 65535;
			}
			array[1] = (short)(x >> 16);
			array[2] = 1;
			array[3] = 1;
			LevelManager.instance.FUN_359CC(array, 36736u);
			List<VigTuple> dAT_ = GameManager.instance.DAT_1078;
			for (int i = 0; i < dAT_.Count; i++)
			{
				VigObject vObject = dAT_[i].vObject;
				if (vObject.id == id)
				{
					vObject.flags &= 4294967293u;
				}
			}
		}
		return 0u;
	}
}
