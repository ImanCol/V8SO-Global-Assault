using UnityEngine;

public class Ghost : VigObject
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
		VigObject self = hit.self;
		if (self.type == 2)
		{
			Vehicle obj = (Vehicle)self;
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, vData.sndList, 6, vTransform.position);
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 24, vTransform.position);
			LevelManager.instance.FUN_4DE54(vTransform.position, 144);
			UIManager.instance.FUN_4E414(vTransform.position, new Color32(0, 128, 0, 8));
			obj.FUN_2B370(new Vector3Int
			{
				x = physics1.Y << 6,
				y = physics1.Z << 6,
				z = physics1.W << 6
			}, vTransform.position);
			DAT_80 = this;
			flags |= 32u;
			screen.y -= 1024000;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 2:
		{
			switch (tags = (sbyte)(tags + 1))
			{
			case 1:
			{
				VigObject vigObject = DAT_80 = GameManager.instance.FUN_320DC(vTransform.position, 0);
				break;
			}
			case 6:
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
			GameManager.instance.FUN_30CB0(this, 60);
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, vData.sndList, 8, vTransform.position);
			break;
		}
		case 0:
		{
			VigObject dAT_ = DAT_80;
			Vector3Int v = default(Vector3Int);
			v.x = dAT_.screen.x;
			v.z = dAT_.screen.z;
			v.y = dAT_.screen.y - 20480;
			v = Utilities.FUN_24304(vTransform, v);
			int num = v.y * -2048 / v.z;
			int num2;
			if (num < -512)
			{
				num2 = -512;
			}
			else
			{
				num2 = 512;
				if (num < 513)
				{
					num2 = num;
				}
			}
			short y = -512;
			if (0 < v.x)
			{
				y = 512;
			}
			FUN_24700((short)num2, y, 0);
			num = vTransform.rotation.V02 * 15258;
			if (num < 0)
			{
				num += 4095;
			}
			num = (num >> 12) - physics1.Y;
			if (num < 0)
			{
				num += 15;
			}
			num >>= 4;
			num2 = -256;
			if (-257 < num)
			{
				num2 = 256;
				if (num < 257)
				{
					num2 = num;
				}
			}
			num = vTransform.rotation.V12 * 15258;
			physics1.Y += num2;
			if (num < 0)
			{
				num += 4095;
			}
			num = (num >> 12) - physics1.Z;
			if (num < 0)
			{
				num += 7;
			}
			physics1.Z += num >> 3;
			num = vTransform.rotation.V22 * 15258;
			if (num < 0)
			{
				num += 4095;
			}
			num = (num >> 12) - physics1.W;
			if (num < 0)
			{
				num += 15;
			}
			num >>= 4;
			num2 = -256;
			if (-257 < num)
			{
				num2 = 256;
				if (num < 257)
				{
					num2 = num;
				}
			}
			physics1.W += num2;
			vTransform.position.x += physics1.Y;
			vTransform.position.y += physics1.Z;
			vTransform.position.z += physics1.W;
			int num3 = GameManager.instance.DAT_28 - DAT_19;
			if ((num3 & 0x1F) == 0)
			{
				vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
			}
			if ((num3 & 3) == 0)
			{
				Ballistic obj = vData.ini.FUN_2C17C(29, typeof(Ballistic), 8u) as Ballistic;
				obj.flags = 36u;
				obj.vTransform = vTransform;
				obj.FUN_305FC();
			}
			break;
		}
		}
		return 0u;
	}
}
