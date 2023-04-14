using UnityEngine;

public class Crane2 : VigObject
{
	private static Vector3Int DAT_54 = new Vector3Int(0, 65536, 0);

	private static Vector3Int DAT_60 = new Vector3Int(0, 0, 0);

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
		VigObject self = hit.self;
		if (self.type == 2)
		{
			if (hit.object1 != child2.child2)
			{
				return 0u;
			}
			Vehicle obj = (Vehicle)self;
			obj.FUN_2B370(v2: GameManager.instance.FUN_2CDF4(hit.object1).position, v1: DAT_54);
			obj.FUN_3A020(-12, DAT_60, param3: true);
			return 0u;
		}
		if (self.type != 8)
		{
			return 0u;
		}
		int maxHalfHealth = self.maxHalfHealth;
		if (base.maxHalfHealth < maxHalfHealth)
		{
			VigObject child = child2;
			self = child.child2;
			if (child.tags != 0 && self != null)
			{
				byte b = (byte)self.tags;
				int y = self.vTransform.position.y;
				int x = self.screen.x;
				int z = self.screen.z;
				child.FUN_4DC94();
				self = child.child2;
				if (self == null || child.tags-- == 1)
				{
					FUN_30BA8();
					base.maxHalfHealth = 0;
				}
				else
				{
					self.tags = (sbyte)b;
					self.vTransform.position.y = y;
					self.screen.x = x;
					self.screen.z = z;
					base.maxHalfHealth = maxFullHealth;
				}
			}
		}
		else
		{
			base.maxHalfHealth -= (ushort)maxHalfHealth;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			VigObject child3 = base.child2;
			VigObject child = child3.child2;
			int num = child.vTransform.position.y + child.screen.x;
			child.vTransform.position.y = num;
			if (child.tags == 0)
			{
				child.screen.x += 270;
				if (child.screen.z < child.vTransform.position.y)
				{
					child.vTransform.position.y = child.screen.z;
					sbyte tags = child3.tags;
					ushort maxFullHealth = base.maxFullHealth;
					sbyte tags2 = base.tags;
					ushort maxHalfHealth = base.maxHalfHealth;
					child.tags = 1;
					child.screen.x = (maxFullHealth * (tags - 1) + maxHalfHealth) * -6103 / (maxFullHealth * (tags2 - 1));
					VigTransform vigTransform = GameManager.instance.FUN_2CDF4(child);
					int y = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(y, vData.sndList, 0, vigTransform.position);
					LevelManager.instance.FUN_4DE54(vigTransform.position, 13);
				}
			}
			else if (num < child.screen.y)
			{
				child.vTransform.position.y = child.screen.y;
				child.screen.x = 0;
				child.tags = 0;
			}
			if (base.maxHalfHealth != 0 && (base.flags & 0x4000) != 0)
			{
				Vehicle vehicle = GameManager.instance.playerObjects[DAT_19];
				if (vehicle != null)
				{
					short num2 = (short)Utilities.Ratan2(vehicle.screen.x - screen.x, vehicle.screen.z - screen.z);
					child3.vr.y += (short)((num2 - vr.y - (child3.vr.y - 2048)) * 16) >> 8;
					child3.ApplyTransformation();
				}
			}
			break;
		}
		case 1:
		{
			VigObject child4 = base.child2;
			VigObject child3 = child4.child2;
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(child3);
			int num3 = GameManager.instance.terrain.FUN_1B750((uint)vigTransform.position.x, (uint)vigTransform.position.z);
			child3.screen.z = num3 - vigTransform.position.y + child3.screen.y;
			base.tags = (sbyte)((child4.tags = (sbyte)child4.FUN_4DCD8()) + 1);
			uint flags = base.flags;
			base.flags = (uint)(((int)flags & -5) | 0x80);
			if ((flags & 0x4000) == 0)
			{
				return 0u;
			}
			goto case 2;
		}
		case 2:
		{
			byte b = DAT_19 = (byte)FUN_274(screen);
			GameManager.instance.FUN_30CB0(this, 60);
			break;
		}
		case 8:
			if (base.maxHalfHealth < arg2)
			{
				VigObject child = base.child2;
				VigObject child2 = child.child2;
				if (child.tags != 0 && child2 != null)
				{
					byte b = (byte)child2.tags;
					int y = child2.vTransform.position.y;
					int x = child2.screen.x;
					int z = child2.screen.z;
					child.FUN_4DC94();
					child2 = child.child2;
					if (child2 == null || child.tags-- == 1)
					{
						FUN_30BA8();
						base.maxHalfHealth = 0;
						break;
					}
					child2.tags = (sbyte)b;
					child2.vTransform.position.y = y;
					child2.screen.x = x;
					child2.screen.z = z;
					base.maxHalfHealth = base.maxFullHealth;
				}
			}
			else
			{
				base.maxHalfHealth -= (ushort)arg2;
			}
			break;
		}
		return 0u;
	}

	private static int FUN_274(Vector3Int param1)
	{
		int result = 0;
		uint num = uint.MaxValue;
		int num2 = 0;
		do
		{
			Vehicle vehicle = GameManager.instance.playerObjects[num2];
			if (vehicle != null && vehicle.maxHalfHealth != 0)
			{
				uint num3 = (uint)Utilities.FUN_29F6C(param1, vehicle.screen);
				if (num3 < num)
				{
					num = num3;
					result = num2;
				}
			}
			num2++;
		}
		while (num2 < 2);
		return result;
	}
}
