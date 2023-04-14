using UnityEngine;

public class Gondola2 : Destructible
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
		if (self.type == 3 && DAT_80 != null)
		{
			hit.self = DAT_80;
			if (self.GetType().IsSubclassOf(typeof(VigObject)))
			{
				self.OnCollision(hit);
			}
			return 1u;
		}
		FUN_32CF0(hit);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		SKIRESRT sKIRESRT = (SKIRESRT)LevelManager.instance.level;
		switch (arg1)
		{
		case 1:
		{
			Gondola2 x = sKIRESRT.DAT_98[0];
			flags |= 264u;
			int num = (x != null) ? 1 : 0;
			sKIRESRT.DAT_98[num] = this;
			vr.y = num << 11;
			break;
		}
		case 2:
			flags &= 4294967263u;
			break;
		case 8:
			FUN_32B90((uint)arg2);
			return 0u;
		}
		return 0u;
	}

	public void FUN_5DC(ushort param1)
	{
		DAT_4A = param1;
		if ((param1 & 0x7FFF) < 28672)
		{
			uint num = (uint)(short)param1;
			if ((int)num < 0)
			{
				num = (uint)(-4096 - (int)num);
			}
			VigTuple vigTuple = null;
			VigTuple vigTuple2 = null;
			for (int i = 0; i < SKIRESRT.instance.DAT_80_2.Count; i++)
			{
				vigTuple = SKIRESRT.instance.DAT_80_2[i];
				if (i + 1 >= SKIRESRT.instance.DAT_80_2.Count)
				{
					break;
				}
				vigTuple2 = SKIRESRT.instance.DAT_80_2[i + 1];
				if (vigTuple2.flag >= num)
				{
					break;
				}
			}
			VigObject vObject = vigTuple.vObject;
			VigObject vObject2 = vigTuple2.vObject;
			int num2 = vObject.vr.y;
			num = (num - vigTuple.flag) * 256 / (vigTuple2.flag - vigTuple.flag);
			if (num2 < 0)
			{
				num2 = -num2;
			}
			uint num3 = 32768u;
			if (1024 < num2)
			{
				num3 = 32769u;
			}
			if (-1 < param1 << 16)
			{
				num3 ^= 1;
			}
			Vector3Int vector3Int = Utilities.FUN_24148(v: vObject.FUN_2C5F4((ushort)num3).v3_1, transform: vObject.vTransform);
			num2 = vObject2.vr.y;
			if (num2 < 0)
			{
				num2 = -num2;
			}
			num3 = 32768u;
			if (1024 < num2)
			{
				num3 = 32769u;
			}
			if (-1 < param1 << 16)
			{
				num3 ^= 1;
			}
			ConfigContainer configContainer = vObject2.FUN_2C5F4((ushort)num3);
			Vector3Int vector3Int2 = Utilities.FUN_24148(vObject2.vTransform, configContainer.v3_1);
			num2 = (vector3Int2.x - vector3Int.x) * (int)num;
			if (num2 < 0)
			{
				num2 += 255;
			}
			screen.x = vector3Int.x + (num2 >> 8);
			num2 = (vector3Int2.y - vector3Int.y) * (int)num;
			if (num2 < 0)
			{
				num2 += 255;
			}
			screen.y = vector3Int.y + (num2 >> 8);
			num2 = (vector3Int2.z - vector3Int.z) * (int)num;
			if (num2 < 0)
			{
				num2 += 255;
			}
			screen.z = vector3Int.z + (num2 >> 8);
		}
		else
		{
			VigTuple vigTuple3 = ((uint)param1 >= 61440u) ? SKIRESRT.instance.DAT_80_2[0] : SKIRESRT.instance.DAT_80_2[SKIRESRT.instance.DAT_80_2.Count - 1];
			VigObject vObject3 = vigTuple3.vObject;
			ConfigContainer configContainer = vObject3.FUN_2C5F4(32768);
			ConfigContainer configContainer2 = vObject3.FUN_2C5F4(32769);
			Vector3Int v = new Vector3Int
			{
				x = (configContainer.v3_1.x + configContainer2.v3_1.x) / 2,
				y = (configContainer.v3_1.y + configContainer2.v3_1.y) / 2
			};
			int num4 = configContainer2.v3_1.x - configContainer.v3_1.x;
			v.z = (configContainer.v3_1.z + configContainer2.v3_1.z) / 2;
			v = Utilities.FUN_24148(vObject3.vTransform, v);
			uint num = (uint)(-((short)param1 / 2));
			if ((uint)param1 < 61440u)
			{
				num += 2048;
			}
			vr.y = (int)num;
			int num2 = GameManager.DAT_65C90[(num & 0xFFF) * 2 + 1] * num4;
			if (num2 < 0)
			{
				num2 += 8191;
			}
			screen.x = v.x + (num2 >> 13);
			screen.y = v.y;
			num4 = GameManager.DAT_65C90[(vr.y & 0xFFF) * 2] * num4;
			if (num4 < 0)
			{
				num4 += 8191;
			}
			screen.z = v.z - (num4 >> 13);
		}
		ApplyTransformation();
	}
}
