using UnityEngine;

public class LockWheel : VigObject
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
		if ((flags & 0x80) == 0)
		{
			VigObject vigObject = GameManager.instance.FUN_318F8(id, this);
			if (vigObject.tags < 6)
			{
				VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(vigObject.id);
				if (vigTuple != null)
				{
					LevelManager.instance.FUN_359CC(vigTuple.array, 0u);
				}
				PDAT_74 = vigObject;
				if ((vigObject.flags & 0x80) == 0)
				{
					GameManager.instance.FUN_30CB0(vigObject, 0);
				}
				maxHalfHealth = 90;
				FUN_30B78();
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, vData.sndList, 3, screen);
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
			vr.x += (short)maxHalfHealth * 2;
			if (arg2 != 0)
			{
				ApplyTransformation();
			}
			VigObject pDAT_ = PDAT_74;
			pDAT_.vTransform.position.y -= maxHalfHealth * 20480 / 8100;
			short num = (short)(maxHalfHealth - 1);
			maxHalfHealth = (ushort)num;
			if (num == 0)
			{
				FUN_30BA8();
				if (pDAT_.tags++ + 1 == 6 && pDAT_.PDAT_74.tags == 6)
				{
					LockWheel2 lockWheel = new GameObject().AddComponent<LockWheel2>();
					lockWheel.type = byte.MaxValue;
					lockWheel.child = pDAT_;
					lockWheel.FUN_30B78();
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, vData.sndList, 9, screen);
					LevelManager.instance.level.flags |= 16777216u;
				}
			}
		}
		return 0u;
	}
}
