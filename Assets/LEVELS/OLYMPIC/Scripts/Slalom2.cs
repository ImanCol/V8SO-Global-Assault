using System.Collections.Generic;
using UnityEngine;

public class Slalom2 : Destructible
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
		VigObject vigObject;
		if (hit.collider1.ReadUInt16(0) != 1 || hit.collider1.ReadUInt16(2) == 0 || hit.self.type != 2)
		{
			if (!FUN_32CF0(hit))
			{
				return 0u;
			}
			vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id == 1)
				{
					vigObject.type = 3;
				}
				vigObject = vigObject.child;
			}
			return 0u;
		}
		List<VigTuple> dAT_A = ((OLYMPIC)LevelManager.instance.level).DAT_A4;
		vigObject = null;
		int num = 0;
		while (true)
		{
			if (num < dAT_A.Count)
			{
				vigObject = dAT_A[num].vObject;
				if (vigObject.id == hit.self.id)
				{
					break;
				}
				num++;
				continue;
			}
			return 0u;
		}
		ushort dAT_ = vigObject.DAT_19;
		if (dAT_ == 97)
		{
			if (base.id == 65)
			{
				vigObject.DAT_19 = 65;
			}
			dAT_ = vigObject.DAT_19;
		}
		if (dAT_ != base.id)
		{
			return 0u;
		}
		vigObject.DAT_19 = (byte)(dAT_ + 1);
		int num2 = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(num2, vData.sndList, 2, vTransform.position);
		GameManager.instance.FUN_1E30C(num2, (base.id - 64) * 250 + 4096);
		if ((GameManager.FUN_2AC5C() & 1) == 0)
		{
			return 0u;
		}
		int id = base.id;
		if (id < 67)
		{
			return 0u;
		}
		if (71 < id)
		{
			return 0u;
		}
		vigObject = GameManager.instance.FUN_318D0(id + 1);
		if (vigObject == null)
		{
			return 0u;
		}
		vigObject = vigObject.child2;
		if (vigObject == null)
		{
			return 0u;
		}
		while (vigObject.id != 1)
		{
			vigObject = vigObject.child2;
			if (!(vigObject != null))
			{
				break;
			}
		}
		if (vigObject != null)
		{
			Vector3Int param = GameManager.instance.FUN_2CE50(vigObject);
			LevelManager.instance.FUN_4AAC0(4261412864u, param, Slalom.DAT_194);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		VigObject vigObject;
		if (arg1 < 4)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id == 1)
				{
					vigObject.type = 3;
				}
				vigObject = vigObject.child;
			}
			return 0u;
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		if (!FUN_32B90((uint)arg2))
		{
			return 0u;
		}
		vigObject = child2;
		while (vigObject != null)
		{
			if (vigObject.id == 1)
			{
				vigObject.type = 3;
			}
			vigObject = vigObject.child;
		}
		return 0u;
	}
}
