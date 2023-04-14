using System.Collections.Generic;
using UnityEngine;

public class RiftBlade : VigObject
{
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
			FUN_42330(arg2);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result;
		if (arg1 <= 1)
		{
			if (arg1 != 0)
			{
				if (arg1 == 1)
				{
					type = 3;
					maxHalfHealth = 3;
					flags |= 16384u;
				}
				goto IL_004b;
			}
			FUN_42330(arg2);
			result = 0u;
		}
		else if (arg1 != 12)
		{
			if (arg1 != 13)
			{
				goto IL_004b;
			}
			result = 0u;
			if (GameManager.instance.DAT_1084 == 0)
			{
				Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
				result = 0u;
				if ((uint)(vector3Int.z - 102401) < 1327103u)
				{
					if (vector3Int.x < 0)
					{
						vector3Int.x = -vector3Int.x;
					}
					result = ((vector3Int.x * 6 - 65536 < vector3Int.z) ? 1u : 0u);
				}
			}
		}
		else
		{
			if (DAT_19 != 0)
			{
				return 0u;
			}
			RiftBlade2 riftBlade = arg2.vData.ini.FUN_2C17C(2, typeof(RiftBlade2), 8u) as RiftBlade2;
			if (riftBlade == null || (((Vehicle)arg2).DAT_F6 & 0x200) != 0)
			{
				return 0u;
			}
			Utilities.ParentChildren(riftBlade, riftBlade);
			DAT_19 = 0;
			riftBlade.flags = 536870912u;
			short id = arg2.id;
			riftBlade.type = 8;
			riftBlade.DAT_80 = arg2;
			riftBlade.id = id;
			VigTransform vigTransform = riftBlade.DAT_84_2 = GameManager.instance.FUN_2CDF4(arg2);
			riftBlade.vTransform = arg2.vTransform;
			riftBlade.DAT_AC = 409;
			riftBlade.DAT_B0 = 4096;
			riftBlade.FUN_305FC();
			riftBlade.FUN_30B78();
			riftBlade.FUN_30BF0();
			arg2.FUN_30BA8();
			arg2.physics1.W = 0;
			arg2.physics1.X = 0;
			arg2.flags |= 100663328u;
			arg2.physics1.Y = 0;
			arg2.physics1.Z = 0;
			arg2.physics2.X = 0;
			arg2.physics2.Y = 0;
			arg2.physics2.Z = 0;
			GameManager.instance.FUN_30CB0(riftBlade, 29);
			riftBlade.screen = vTransform.position;
			riftBlade.screen.x = -vTransform.position.x >> 12;
			riftBlade.screen.y = -vTransform.position.y >> 12;
			riftBlade.screen.z = -vTransform.position.z >> 12;
			riftBlade.DAT_B4 = 0;
			riftBlade.DAT_BC = new List<Vehicle>();
			riftBlade.vTransform.position = Utilities.FUN_24148(riftBlade.vTransform, vTransform.position);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, arg2.vData.sndList, 4, riftBlade.vTransform.position);
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(param, vData.sndList, 2);
			GameManager.instance.DAT_1084++;
			short num = (short)(maxHalfHealth - 1);
			maxHalfHealth = (ushort)num;
			if (num == 0)
			{
				FUN_3A368();
				return 240u;
			}
			result = 240u;
		}
		goto IL_0343;
		IL_004b:
		result = 0u;
		goto IL_0343;
		IL_0343:
		return result;
	}
}
