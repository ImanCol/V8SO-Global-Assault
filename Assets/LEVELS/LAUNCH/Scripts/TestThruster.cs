using System;
using System.Collections.Generic;

public class TestThruster : VigObject
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
		if (hit.collider1.ReadUInt16(2) != 0)
		{
			if (tags != 0)
			{
				return 0u;
			}
			if (hit.self.type != 2)
			{
				return 0u;
			}
			vigObject = child2;
			while (vigObject != null && vigObject.id != 1)
			{
				vigObject = vigObject.child;
			}
			tags = 1;
			ConfigContainer configContainer = vigObject.FUN_2C5F4(32768);
			if (configContainer == null)
			{
				return 0u;
			}
			TestThruster3 testThruster = vData.ini.FUN_2C17C(24, typeof(TestThruster3), 8u) as TestThruster3;
			Utilities.ParentChildren(testThruster, testThruster);
			if (testThruster == null)
			{
				return 0u;
			}
			testThruster.vTransform = GameManager.instance.FUN_2CEAC(vigObject, configContainer);
			testThruster.flags = 4u;
			testThruster.type = 3;
			testThruster.FUN_305FC();
			GameManager.instance.FUN_30CB0(testThruster, 72);
			testThruster.tags = 0;
			testThruster.DAT_80 = this;
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, vData.sndList, 1, vTransform.position);
			return 0u;
		}
		vigObject = hit.self;
		if (vigObject.type != 8)
		{
			return 0u;
		}
		if ((ushort)vigObject.id - 114 < 3)
		{
			return 0u;
		}
		FUN_32B90(vigObject.maxHalfHealth);
		return 0u;
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2, uint arg3)
	{
		Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
		dictionary.Add(599, typeof(VigChild));
		VigObject vigObject = arg1.ini.FUN_2C17C((ushort)arg2, typeof(TestThruster), arg3, dictionary);
		((VigChild)vigObject.child2).state = _CHILD_TYPE.Default;
		return vigObject;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			VigChild vigChild = child2 as VigChild;
			DAT_58 = 1690828;
			while (vigChild != null)
			{
				vigChild.type = 3;
				vigChild.state = _CHILD_TYPE.Child;
				vigChild = (vigChild.child as VigChild);
			}
			return 0u;
		}
		switch (arg1)
		{
		default:
			return 0u;
		case 9:
		{
			if (arg2 != 0)
			{
				return 0u;
			}
			if (1 < tags)
			{
				return 0u;
			}
			VigObject vigObject = child2;
			tags = 2;
			if (vigObject == null)
			{
				return 0u;
			}
			while (vigObject.id != 1)
			{
				vigObject = vigObject.child;
				if (!(vigObject != null))
				{
					break;
				}
			}
			if (vigObject == null)
			{
				return 0u;
			}
			VigTransform vigTransform = vigObject.vTransform = GameManager.instance.FUN_2CDF4(vigObject);
			short id = base.id;
			vigObject.type = 4;
			vigObject.id = id;
			vigObject.FUN_2CCBC();
			vigObject.vr = Utilities.FUN_2A2E0(vigObject.vTransform.rotation);
			vigObject.ApplyRotationMatrix();
			TestThruster2 testThruster = Utilities.FUN_52188(vigObject, typeof(TestThruster2)) as TestThruster2;
			testThruster.tags = 0;
			testThruster.flags = (uint)(((int)testThruster.flags & -33) | 0x800);
			if (testThruster.child2 != null)
			{
				testThruster.child2.parent = testThruster;
			}
			testThruster.FUN_305FC();
			GameManager.instance.FUN_30CB0(testThruster, 30);
			ConfigContainer configContainer = testThruster.FUN_2C5F4(32768);
			if (configContainer == null)
			{
				return 0u;
			}
			TestThruster3 testThruster2 = testThruster.vData.ini.FUN_2C17C(24, typeof(TestThruster3), 8u) as TestThruster3;
			if (testThruster2 == null)
			{
				return 0u;
			}
			testThruster2.vTransform = Utilities.FUN_2C77C(configContainer);
			testThruster2.type = 3;
			Utilities.FUN_2CA94(testThruster, configContainer, testThruster2);
			Utilities.ParentChildren(testThruster, testThruster);
			testThruster2.FUN_30BF0();
			testThruster2.tags = 0;
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, vData.sndList, 1, vTransform.position);
			testThruster.DAT_58 = 1690828;
			testThruster2.DAT_58 = 1690828;
			return 0u;
		}
		case 8:
			FUN_32B90((uint)arg2);
			return 0u;
		}
	}
}
