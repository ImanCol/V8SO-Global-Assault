public class DrawBridge : Destructible
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
			sbyte b = tags = (sbyte)((arg1 == 10) ? 1 : 2);
			DAT_19 = 240;
			FUN_30B78();
			return 0u;
		}
		case 0:
		{
			VigObject child = base.child2;
			VigObject child2 = child.child;
			short z;
			if (tags == 1)
			{
				child.vr.z -= 2;
				z = (short)(child2.vr.z + 2);
			}
			else
			{
				child.vr.z += 2;
				z = (short)(child2.vr.z - 2);
			}
			child2.vr.z = z;
			if (arg2 != 0)
			{
				child.ApplyTransformation();
				child2.ApplyTransformation();
			}
			sbyte b2 = (sbyte)(DAT_19 - 1);
			DAT_19 = (byte)b2;
			if (b2 != 0)
			{
				return 0u;
			}
			FUN_30BA8();
			if (tags == 1)
			{
				GameManager.instance.FUN_30CB0(this, 300);
				return 0u;
			}
			tags = 0;
			return 0u;
		}
		case 10:
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, vData.sndList, 5, vTransform.position);
			sbyte b = tags = (sbyte)((arg1 == 10) ? 1 : 2);
			DAT_19 = 240;
			FUN_30B78();
			return 0u;
		}
		default:
			return base.UpdateW(arg1, arg2);
		}
	}
}
