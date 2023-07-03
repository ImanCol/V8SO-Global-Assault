using System.Collections.Generic;
using UnityEngine;

public class Sharky : VigObject
{
	public JUNC_DB DAT_84_2;

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
		if (self.type == 2 && self.id != 0)
		{
			Vehicle vehicle = (Vehicle)self;
			uint flags;
			if (tags == 3)
			{
				GameManager.instance.FUN_2F798(this, hit);
				Vector3Int vector3Int = Utilities.FUN_24148(vTransform, hit.position);
				LevelManager.instance.FUN_4DE54(vector3Int, 142);
				UIManager.instance.FUN_4E414(vector3Int, new Color32(128, 128, 128, 8));
				LevelManager.instance.FUN_4EAE8(vector3Int, hit.normal1, 148);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 24, vector3Int);
				vehicle.FUN_3A064(-100, vector3Int, param3: true);
				vehicle.physics1.Y += 1953024;
				int num = vTransform.rotation.V02 * 3814;
				if (num < 0)
				{
					num += 31;
				}
				vehicle.physics1.X += num >> 5;
				num = vTransform.rotation.V22 * 3814;
				if (num < 0)
				{
					num += 31;
				}
				vehicle.physics1.Z += num >> 5;
				flags = base.flags;
			}
			else
			{
				if (tags == 0)
				{
					return 0u;
				}
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 38, vTransform.position);
				GameManager.instance.FUN_1E30C(param, 6500);
				flags = base.flags;
				tags = 3;
				maxHalfHealth = 32;
			}
			base.flags = (flags | 0x20);
			return 0u;
		}
		if (self.type != 8)
		{
			return 0u;
		}
		if (tags != 0)
		{
			tags = 0;
			return 0u;
		}
		int num2 = 0;
		if (DAT_84_2.DAT_11 == 2)
		{
			num2 = DAT_19;
		}
		RSEG_DB obj = DAT_84_2.DAT_1C[num2];
		num2 = 1 - DAT_19;
		DAT_19 = (byte)num2;
		JUNC_DB jUNC_DB = DAT_84_2 = obj.DAT_00[num2];
		physics1.Z = jUNC_DB.DAT_00.x;
		physics1.W = jUNC_DB.DAT_00.y;
		physics2.X = jUNC_DB.DAT_00.z;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		JUNC_DB jUNC_DB;
		uint num5;
		short num7;
		short num8;
		int num;
		int num2;
		int num3;
		switch (arg1)
		{
		case 1:
		{
			RSEG_DB rSEG_DB = LevelManager.instance.FUN_518DC(screen, id);
			jUNC_DB = (DAT_84_2 = rSEG_DB.DAT_00[0]);
			physics1.Z = jUNC_DB.DAT_00.x;
			physics1.W = jUNC_DB.DAT_00.y;
			physics2.X = jUNC_DB.DAT_00.z;
			base.flags |= 65924u;
			if (id == 16)
			{
				Sharky2 sharky = new GameObject().AddComponent<Sharky2>();
				sharky.type = byte.MaxValue;
				GameManager.instance.FUN_30CB0(sharky, 60);
				num = LevelManager.instance.DAT_1184;
				num2 = 0;
				List<JUNC_DB> juncList = LevelManager.instance.juncList;
				if (0 < LevelManager.instance.DAT_1184)
				{
					do
					{
						JUNC_DB jUNC_DB2 = juncList[num2];
						int num6 = 0;
						if (jUNC_DB2.DAT_11 != 0)
						{
							do
							{
								RSEG_DB rSEG_DB2 = jUNC_DB2.DAT_1C[num6];
								if (rSEG_DB2.DAT_08 - 16 < 4)
								{
									jUNC_DB2.DAT_12 = (short)rSEG_DB2.DAT_08;
									if (jUNC_DB2 == rSEG_DB2.DAT_00[0] && jUNC_DB2.DAT_1C[0] != rSEG_DB2)
									{
										jUNC_DB2.DAT_1C[1] = jUNC_DB2.DAT_1C[0];
										jUNC_DB2.DAT_1C[0] = rSEG_DB2;
										break;
									}
								}
								num6++;
							}
							while (num6 < jUNC_DB2.DAT_11);
						}
						num2++;
					}
					while (num2 < num);
				}
			}
			GameManager.instance.FUN_30CB0(this, 60);
			return 0u;
		}
		case 0:
			{
				sbyte tags = base.tags;
				if (tags != 3)
				{
					num = physics1.Z - vTransform.position.x;
					num2 = physics2.X - vTransform.position.z;
					if (tags == 1)
					{
						num3 = num2;
						if (num2 < 0)
						{
							num3 = -num2;
						}
						int num4 = num;
						if (num < 0)
						{
							num4 = -num;
						}
						if (num3 < num4)
						{
							num3 = num4;
						}
						if (65535 >= num3)
						{
							num3 = ((DAT_84_2.DAT_11 == 2) ? (1 - DAT_19) : 0);
							jUNC_DB = (DAT_84_2 = DAT_84_2.DAT_1C[num3].DAT_00[DAT_19]);
							goto IL_03d4;
						}
					}
					else if (1 < tags)
					{
						if (tags == 2)
						{
							num3 = num2;
							if (num2 < 0)
							{
								num3 = -num2;
							}
							int num4 = num;
							if (num < 0)
							{
								num4 = -num;
							}
							if (num3 < num4)
							{
								num3 = num4;
							}
							if (num3 < 1024001 && 3041279 < GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z))
							{
								num = DAT_80.vTransform.position.x - vTransform.position.x;
								num2 = DAT_80.vTransform.position.z - vTransform.position.z;
							}
							else
							{
								base.tags = 0;
							}
						}
					}
					else if (tags == 0)
					{
						num3 = num2;
						if (num2 < 0)
						{
							num3 = -num2;
						}
						int num4 = num;
						if (num < 0)
						{
							num4 = -num;
						}
						if (num3 < num4)
						{
							num3 = num4;
						}
						if (65535 >= num3)
						{
							JUNC_DB dAT_84_ = DAT_84_2;
							if (dAT_84_.DAT_11 == 2)
							{
								num5 = GameManager.FUN_2AC5C();
								num4 = (int)(num5 & 1);
							}
							else
							{
								num4 = 0;
							}
							RSEG_DB rSEG_DB = dAT_84_.DAT_1C[num4];
							DAT_19 = (byte)((dAT_84_ == rSEG_DB.DAT_00[0]) ? 1 : 0);
							jUNC_DB = (DAT_84_2 = rSEG_DB.DAT_00[DAT_19]);
							goto IL_03d4;
						}
					}
					goto IL_0419;
				}
				num5 = maxHalfHealth;
				maxHalfHealth--;
				uint flags;
				if (num5 == 0)
				{
					flags = base.flags;
					base.tags = 0;
				}
				else
				{
					if (num5 != 16)
					{
						goto IL_05a6;
					}
					flags = base.flags;
				}
				base.flags = (uint)((int)flags & -33);
				goto IL_05a6;
			}
			IL_03d4:
			physics1.Z = jUNC_DB.DAT_00.x;
			physics1.W = jUNC_DB.DAT_00.y;
			physics2.X = jUNC_DB.DAT_00.z;
			goto IL_0419;
			IL_0419:
			num = (int)Utilities.Ratan2(num, num2);
			num2 = (num - (ushort)vr.y) * 1048576 >> 20;
			num = -45;
			if (-46 < num2)
			{
				num = 45;
				if (num2 < 46)
				{
					num = num2;
				}
			}
			vr.y += num;
			num = (vr.y & 0xFFF) * 2;
			num7 = Utilities.DAT_65C90[num];
			num8 = Utilities.DAT_65C90[num + 1];
			num = num7 * 7629;
			if (num < 0)
			{
				num += 4095;
			}
			num2 = num8 * 7629;
			vTransform.position.x += num >> 12;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			vTransform.rotation.V20 = (short)(-num7);
			num = GameManager.instance.DAT_DB0;
			vTransform.rotation.V22 = num8;
			vTransform.rotation.V00 = num8;
			vTransform.rotation.V02 = num7;
			vTransform.position.z += num2 >> 12;
			vTransform.position.y = num;
			return 0u;
			IL_05a6:
			num = (int)(num5 - 16);
			if (num < 0)
			{
				num = -num;
			}
			num2 = (16 - num) * 227;
			if (num2 < 0)
			{
				num2 += 15;
			}
			vr.x = num2 >> 4;
			ApplyRotationMatrix();
			num2 = vTransform.rotation.V02 * 3814;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			num3 = vTransform.rotation.V22 * 3814;
			vTransform.position.x += num2 >> 12;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			vTransform.position.z += num3 >> 12;
			vTransform.position.y = GameManager.instance.DAT_DB0 + (16 - num) * -1920;
			break;
		}
		return 0u;
	}
}
