using System;
using System.Collections.Generic;
using UnityEngine;

public class Freezer2 : VigObject
{
	public VigTransform DAT_84_2;

	public int DAT_A4;

	public Vector3Int DAT_A8;

	public int DAT_B4;

	public VigObject DAT_B8;

	public int DAT_BC;

	public List<VigTuple> DAT_C0;

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
		uint result = 0u;
		if (hit.object2.type != 3 && hit.self.type != 3)
		{
			FUN_5F4();
			result = uint.MaxValue;
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		switch (arg1)
		{
		case 0:
		{
			byte dAT_ = DAT_19;
			if (dAT_ == 1)
			{
				vTransform.position.x += DAT_A8.x;
				vTransform.position.y += DAT_A8.y;
				vTransform.position.z += DAT_A8.z;
				if (0 < --DAT_B4)
				{
					int num = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
					if (vTransform.position.y <= num)
					{
						return 0u;
					}
				}
				FUN_5F4();
				return 0u;
			}
			if (tags == 1 && DAT_C0 != null && (DAT_BC & 0x14) == 0)
			{
				int x = vTransform.position.x;
				int z = vTransform.position.z;
				FUN_2E8(GameManager.instance.worldObjs, x, z);
			}
			if (dAT_ < 2)
			{
				if (dAT_ != 0)
				{
					return 0u;
				}
				Utilities.FUN_2449C(v3: new Vector3Int(DAT_A4, DAT_A4, DAT_A4), m33: DAT_84_2.rotation, mout: ref vTransform.rotation);
				DAT_A4 += 122;
			}
			else
			{
				if (3 < dAT_)
				{
					return 0u;
				}
				FUN_570();
				if ((DAT_C0.Count == 0 && 2 < DAT_19 && tags == 0) || (tags == 1 && DAT_BC < 0))
				{
					UIManager.instance.FUN_4E338(new Color32(128, 128, 128, 4));
					GameManager.instance.FUN_309A0(this);
					return 0u;
				}
				if (arg2 != 0)
				{
					uint num2 = 64u;
					if (tags == 1)
					{
						num2 = 128u;
					}
					uint num3 = ((Color32)UIManager.instance.flash.color).b + num2;
					uint num4 = 128u;
					if (num3 < 128)
					{
						num4 = num3;
					}
					uint num5 = (uint)(((Color32)UIManager.instance.flash.color).g + 64);
					num3 = 128u;
					if (num5 < 128)
					{
						num3 = num5;
					}
					Color32 c = default(Color32);
					c.b = (byte)num4;
					c.g = (byte)num3;
					num4 = (uint)(((Color32)UIManager.instance.flash.color).r + 64);
					c.r = 128;
					if (num4 < 128)
					{
						c.r = (byte)num4;
					}
					c.a = byte.MaxValue;
					UIManager.instance.flash.color = c;
				}
			}
			goto default;
		}
		default:
			result = 0u;
			break;
		case 2:
		{
			sbyte b = (sbyte)(DAT_19 + 1);
			DAT_19 = (byte)b;
			result = 0u;
			if (b == 1)
			{
				VigObject dAT_2 = DAT_80;
				Vector3Int v2 = new Vector3Int(0, 0, 0)
				{
					z = 4096
				};
				VigObject dAT_B = DAT_B8;
				VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
				v2 = Utilities.ApplyMatrixSV(vigTransform.rotation, v2);
				if (tags == 0)
				{
					DAT_B4 = 120;
				}
				int num = dAT_2.physics1.X;
				if (num < 0)
				{
					num += 127;
				}
				DAT_A8.x = (num >> 7) + v2.x * 4;
				num = dAT_2.physics1.Y;
				if (num < 0)
				{
					num += 127;
				}
				DAT_A8.y = (num >> 7) + v2.y * 4;
				num = dAT_2.physics1.Z;
				if (num < 0)
				{
					num += 127;
				}
				DAT_A8.z = (num >> 7) + v2.z * 4;
				FUN_2CCBC();
				base.transform.parent = null;
				vTransform = vigTransform;
				GameManager.instance.FUN_30080(GameManager.instance.worldObjs, this);
				UIManager.instance.FUN_4E414(vTransform.position, new Color32(0, 64, 0, 8));
				Particle1 particle = LevelManager.instance.FUN_4DE54(vTransform.position, 138);
				if (particle != null)
				{
					particle.id = id;
				}
				result = 0u;
				if (dAT_B.maxHalfHealth == 0)
				{
					dAT_B.FUN_3A368();
					result = 0u;
				}
			}
			break;
		}
		case 4:
			if (DAT_18 != 0)
			{
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
			}
			GameManager.instance.FUN_300B8(GameManager.instance.DAT_1068, this);
			result = 0u;
			break;
		}
		return result;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 != 1)
		{
			if (arg1 == 10)
			{
				GameManager.instance.FUN_300B8(DAT_C0, arg2);
				return 0u;
			}
		}
		else
		{
			type = 3;
		}
		return 0u;
	}

	private void FUN_5F4()
	{
		Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E628(param, DAT_80.vData.sndList, 5, vTransform.position);
		sbyte param2 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E14C(param2, DAT_80.vData.sndList, 3, param4: true);
		Particle1 particle = LevelManager.instance.FUN_4DE54(vTransform.position, 140);
		if (particle != null)
		{
			particle.id = base.id;
		}
		VigConfig ini = vData.ini;
		dictionary.Add(ini.GetContainerIndex(2, 0), typeof(VigChild));
		dictionary.Add(ini.GetContainerIndex(2, 1), typeof(FreezerChild));
		dictionary.Add(ini.GetContainerIndex(2, 2), typeof(VigChild));
		Ballistic ballistic = DAT_80.vData.ini.FUN_2C17C(2, typeof(Ballistic), 8u, dictionary) as Ballistic;
		if (ballistic != null)
		{
			short id = base.id;
			ballistic.type = 7;
			ballistic.flags = 36u;
			ballistic.id = id;
			ballistic.screen = vTransform.position;
			ballistic.FUN_3066C();
		}
		Utilities.ParentChildren(ballistic, ballistic);
		DAT_19 = 2;
		flags |= 34u;
		DAT_C0 = new List<VigTuple>();
		GameManager.instance.FUN_30CB0(this, 90);
		if (tags == 0)
		{
			FUN_47C();
		}
		GameManager.instance.FUN_30080(GameManager.instance.DAT_1068, this);
		UIManager.instance.FUN_4E414(vTransform.position, new Color32(128, 128, 128, 8));
	}

	private void FUN_570()
	{
		if (--DAT_BC >= 1)
		{
			return;
		}
		List<VigTuple> dAT_C = DAT_C0;
		if (DAT_C0 == null)
		{
			return;
		}
		for (int i = 0; i < dAT_C.Count; i++)
		{
			VigObject vObject = dAT_C[i].vObject;
			FUN_20C(vObject, param2: false);
			if (GameManager.instance.FUN_300B8(DAT_C0, vObject))
			{
				i--;
			}
		}
	}

	private void FUN_47C()
	{
		BSP[] array = new BSP[255];
		int x = vTransform.position.x;
		int z = vTransform.position.z;
		DAT_BC = 240;
		FUN_2E8(GameManager.instance.worldObjs, x, z);
		BSP bSP = GameManager.instance.bspTree;
		int num = 0;
		do
		{
			if (bSP.DAT_00 == 0)
			{
				FUN_2E8(bSP.LDAT_04, x, z);
			}
			else if (bSP.DAT_00 < 4)
			{
				array[num] = bSP.DAT_08;
				array[num + 1] = bSP.DAT_0C;
				num += 2;
			}
			num--;
			if (num > 0)
			{
				bSP = array[num];
			}
		}
		while (num >= 0);
	}

	private void FUN_2E8(List<VigTuple> param1, int param2, int param3)
	{
		int num = 240;
		int num2 = num;
		for (int i = 0; i < param1.Count; i++)
		{
			num2 = num;
			VigObject vObject = param1[i].vObject;
			num = num2;
			if (DAT_C0.ContainsTupleObject(vObject) || vObject.id == id || (vObject.type == 2 && ((Vehicle)vObject).shield != 0) || (tags == 1 && vObject.type == 2))
			{
				continue;
			}
			int num3 = param2 - vObject.vTransform.position.x >> 16;
			int num4 = param3 - vObject.vTransform.position.z >> 16;
			num3 = num3 * num3 + num4 * num4;
			if (num3 < 100)
			{
				GameManager.instance.FUN_30080(DAT_C0, vObject);
				FUN_A0(vObject, num2, param3: false);
			}
			if (vObject.type == 2)
			{
				num = (int)Utilities.SquareRoot(num3);
				num = (10 - num) * 24 + 240;
				if (num < num2)
				{
					num = num2;
				}
			}
			else if (vObject.type == 8)
			{
				ushort maxHalfHealth = vObject.maxHalfHealth;
				vObject.maxHalfHealth = 0;
				vObject.maxFullHealth = maxHalfHealth;
			}
		}
		if (tags == 0)
		{
			if (num2 < DAT_BC)
			{
				num2 = DAT_BC;
			}
			DAT_BC = num2;
		}
	}

	private static void FUN_20C(VigObject param1, bool param2)
	{
		if (param1.type == 8)
		{
			ushort maxFullHealth = param1.maxFullHealth;
			param1.maxFullHealth = 0;
			param1.maxHalfHealth = maxFullHealth;
		}
		if (!(param1 != null))
		{
			return;
		}
		do
		{
			bool flag = false;
			if ((param1.flags & 0x80) != 0)
			{
				flag = FUN_1B0(GameManager.instance.DAT_1088, param1);
			}
			if ((param1.flags & 4) != 0)
			{
				bool flag2 = FUN_1B0(GameManager.instance.DAT_10A8, param1);
				flag |= flag2;
			}
			if (!flag && param1.child2 != null)
			{
				FUN_20C(param1.child2, param2: true);
			}
			param1 = param1.child;
		}
		while (param2 && param1 != null);
	}

	private static bool FUN_1B0(List<VigTuple> param1, VigObject param2)
	{
		for (int i = 0; i < param1.Count; i++)
		{
			if (param1[i].vObject == param2)
			{
				return true;
			}
		}
		GameManager.instance.FUN_30080(param1, param2);
		return false;
	}

	private static void FUN_A0(VigObject param1, int param2, bool param3)
	{
		if (!(param1 != null))
		{
			return;
		}
		do
		{
			if ((param1.flags & 0x80) != 0)
			{
				GameManager.instance.FUN_300B8(GameManager.instance.DAT_1088, param1);
			}
			param1.DAT_4A += (ushort)param2;
			if ((param1.flags & 4) != 0 && !GameManager.instance.FUN_300B8(GameManager.instance.DAT_10A8, param1))
			{
				param1.flags &= 4294967291u;
			}
			if ((param1.flags & 1) != 0)
			{
				VigTuple vigTuple = GameManager.instance.FUN_30134(GameManager.instance.DAT_1110, param1);
				if (vigTuple != null)
				{
					GameManager.instance.FUN_30CB0(param1, (int)vigTuple.flag + param2 - GameManager.instance.DAT_28);
				}
			}
			if (param1.child2 != null)
			{
				FUN_A0(param1.child2, param2, param3: true);
			}
			param1 = param1.child;
		}
		while (param3 && param1 != null);
	}
}
