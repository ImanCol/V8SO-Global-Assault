using UnityEngine;

public class Snow : VigObject
{
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
		Snow snow = new GameObject().AddComponent<Snow>();
		snow.vData = arg1;
		snow.DAT_1A = (short)arg2;
		return snow;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			int x = 0;
			if (_GAME_MODE.Demo < GameManager.instance.gameMode && GameManager.instance.gameMode < _GAME_MODE.Versus2)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return uint.MaxValue;
			}
			flags |= 160u;
			do
			{
				VigObject vigObject2 = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(VigObject), 0u);
				x++;
				vigObject2.flags |= 1040u;
				int num2 = (int)GameManager.FUN_2AC5C();
				vigObject2.screen.x = num2 << 17 >> 13;
				num2 = (int)GameManager.FUN_2AC5C();
				vigObject2.screen.y = num2 << 17 >> 13;
				num2 = (int)GameManager.FUN_2AC5C();
				vigObject2.screen.z = num2 << 17 >> 13;
				short z2 = (short)GameManager.FUN_2AC5C();
				vigObject2.vr.z = z2;
				vigObject2.vMesh.DAT_02 = 64;
				vigObject2.ApplyTransformation();
				Utilities.FUN_2CC48(this, vigObject2);
			}
			while (x < 64);
			Utilities.ParentChildren(this, this);
			break;
		}
		default:
			return 0u;
		case 0:
		{
			if (arg2 == 0)
			{
				break;
			}
			VigObject vigObject = child2;
			int x = vTransform.position.x;
			int y = vTransform.position.y;
			int num = GameManager.instance.DAT_F28.position.x + GameManager.instance.DAT_F28.rotation.V02 * 64;
			int num2 = GameManager.instance.DAT_F28.position.y + GameManager.instance.DAT_F28.rotation.V12 * 64;
			int num3 = GameManager.instance.DAT_F28.position.z + GameManager.instance.DAT_F28.rotation.V22 * 64;
			vTransform.position.x = num;
			int z = vTransform.position.z;
			vTransform.position.y = num2;
			vTransform.position.z = num3;
			if (vigObject != null)
			{
				do
				{
					vigObject.vTransform.position.x = ((vigObject.vTransform.position.x + (x - num) + 131072) & 0x3FFFF) - 131072;
					vigObject.vTransform.position.y = ((vigObject.vTransform.position.y + (y - num2) + arg2 * 762 + 131072) & 0x3FFFF) - 131072;
					vigObject.vTransform.position.z = ((vigObject.vTransform.position.z + (z - num3) + 131072) & 0x3FFFF) - 131072;
					vigObject = vigObject.child;
				}
				while (vigObject != null);
				return 0u;
			}
			break;
		}
		}
		return 0u;
	}
}
