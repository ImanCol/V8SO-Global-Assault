using System;
using System.Collections.Generic;
using UnityEngine;

public class ForkLift : VigObject
{
	public RSEG_DB DAT_80_2;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2, uint arg3)
	{
		Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
		dictionary.Add(921, typeof(ForkLift2));
		dictionary.Add(919, typeof(ForkLift2));
		dictionary.Add(913, typeof(ForkLift2));
		return arg1.ini.FUN_2C17C((ushort)arg2, typeof(ForkLift), arg3, dictionary);
	}

	public override uint OnCollision(HitDetection hit)
	{
		VigObject self = hit.self;
		if (self.type == 2)
		{
			if (FUN_33798(hit, physics1.W) != 0)
			{
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 7, self.vTransform.position);
				return 0u;
			}
			return 0u;
		}
		if (self.type != 8)
		{
			return 0u;
		}
		int maxHalfHealth = self.maxHalfHealth;
		ushort maxHalfHealth2 = base.maxHalfHealth;
		self = null;
		if (maxHalfHealth2 < maxHalfHealth)
		{
			VigObject vigObject = child2;
			base.maxHalfHealth = maxFullHealth;
			while (vigObject != null)
			{
				if (3 < vigObject.id && (self == null || vigObject.id < self.id))
				{
					self = vigObject;
				}
				vigObject = vigObject.child;
			}
			if (self != null)
			{
				uint num = GameManager.FUN_2AC5C();
				self.FUN_306FC();
				self.FUN_2CCBC();
				short id = base.id;
				self.type = 10;
				self.id = id;
				self.flags |= 128u;
				self = Utilities.FUN_52188(self, typeof(ForkLift2));
				((ForkLift2)self).state = _FORKLIFT2_TYPE.Type1;
				int param = ((num & 1) != 0) ? 390528 : (-390528);
				self.physics1.X = param;
				self.physics1.Y = -195200;
				self.physics1.Z = 0;
				self.physics2.X = 0;
				self.physics2.Y = 0;
				param = (((num & 1) != 0) ? 32768 : (-32768));
				self.physics2.Z = param;
				self.DAT_A0 = new Vector3Int(16, 32, 64);
				self.vTransform = Utilities.CompMatrixLV(vTransform, self.vTransform);
				Vector3Int vector3Int = Utilities.FUN_24094(vTransform.rotation, new Vector3Int(self.physics1.X, self.physics1.Y, self.physics1.Z));
				self.physics1.X = vector3Int.x;
				self.physics1.Y = vector3Int.y;
				self.physics1.Z = vector3Int.z;
				self.FUN_305FC();
				GameManager.instance.FUN_30CB0(self, 1800);
				return 0u;
			}
			FUN_4DC94();
			return 0u;
		}
		base.maxHalfHealth = (ushort)(maxHalfHealth2 - maxHalfHealth);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int num = physics1.Z;
			if (num < 0)
			{
				num += 65535;
			}
			num = (int)Utilities.SquareRoot(DAT_80_2.FUN_5105C(num >> 16, physics1.Y != 0, ref vTransform));
			int num2 = (physics1.Y != 0) ? (physics1.W << 16) : (physics1.W * -65536);
			int num3 = physics1.Z + num2 / num;
			physics1.Z = num3;
			if ((uint)num3 < 268435457u)
			{
				return 0u;
			}
			JUNC_DB jUNC_DB = DAT_80_2.DAT_00[physics1.Y];
			if (jUNC_DB.DAT_11 != 1)
			{
				num3 = (((DAT_80_2 = jUNC_DB.DAT_1C[(jUNC_DB.DAT_1C[0] == DAT_80_2) ? 1 : 0]).DAT_00[0] == jUNC_DB) ? 1 : 0);
				physics1.Y = num3;
				physics1.Z = (-((num3 == 0) ? 1 : 0) & 0x10000000);
				return 0u;
			}
			goto IL_0337;
		}
		case 2:
		{
			uint num4 = GameManager.FUN_2AC5C();
			VigObject vigObject = GameManager.instance.FUN_318D0((int)((num4 & 1) + 49));
			screen = vigObject.screen;
			flags &= 4294967261u;
			Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
			dictionary.Add(921, typeof(ForkLift2));
			dictionary.Add(919, typeof(ForkLift2));
			dictionary.Add(913, typeof(ForkLift2));
			FUN_2C124(25, dictionary);
			Utilities.ParentChildren(this, this);
			FUN_30B78();
			goto case 1;
		}
		case 1:
		{
			int num = (DAT_80_2 = LevelManager.instance.FUN_518DC(screen, 16)).FUN_51334(screen);
			VigObject vigObject3 = child2;
			physics1.Z = num << 16;
			physics1.Y = 1;
			physics1.W = 4577;
			base.maxHalfHealth = 50;
			maxFullHealth = 50;
			flags |= 392u;
			while (vigObject3 != null)
			{
				if (3 < vigObject3.id)
				{
					((ForkLift2)vigObject3).state = _FORKLIFT2_TYPE.Type1;
				}
				vigObject3 = vigObject3.child;
			}
			break;
		}
		case 8:
		{
			ushort maxHalfHealth = base.maxHalfHealth;
			VigObject vigObject = null;
			if (maxHalfHealth < arg2)
			{
				VigObject vigObject2 = child2;
				base.maxHalfHealth = maxFullHealth;
				while (vigObject2 != null)
				{
					if (3 < vigObject2.id && (vigObject == null || vigObject2.id < vigObject.id))
					{
						vigObject = vigObject2;
					}
					vigObject2 = vigObject2.child;
				}
				if (vigObject != null)
				{
					vigObject.FUN_2CD04();
					vigObject.FUN_305FC();
					vigObject.FUN_4DC94();
					return 0u;
				}
				FUN_4DC94();
				return 0u;
			}
			base.maxHalfHealth = (ushort)(maxHalfHealth - arg2);
			break;
		}
		case 9:
			{
				if (arg2 == 0)
				{
					return 0u;
				}
				goto IL_0337;
			}
			IL_0337:
			flags |= 34u;
			FUN_30BA8();
			GameManager.instance.FUN_30CB0(this, 300);
			return 0u;
		}
		return 0u;
	}
}
