using System;
using UnityEngine;

// Token: 0x0200003B RID: 59
public class Fence : Destructible
{
	// Token: 0x0600011D RID: 285 RVA: 0x0000805E File Offset: 0x0000625E
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00008066 File Offset: 0x00006266
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0001936C File Offset: 0x0001756C
	public override uint OnCollision(HitDetection hit)
	{
		VigObject self = hit.self;
		if (self.type == 2 && this.tags == 0 && (self.flags & 16384U) != 0U && (self.flags & 67108864U) == 0U)
		{
			HitDetection hitDetection = new HitDetection(null);
			GameManager.instance.FUN_2FB70(this, hit, hitDetection);
			int num = 0;
			Vector3Int vector3Int = Utilities.FUN_24148(hit.self.vTransform, hitDetection.position);
			LevelManager.instance.FUN_4DE54(vector3Int, 42);
			int num2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(num2, GameManager.instance.DAT_C2C, 75, vector3Int, false);
			GameManager.instance.FUN_30CB0(this, 60);
			this.tags = 1;
			do
			{
				Throwaway throwaway = LevelManager.instance.xobfList[19].ini.FUN_2C17C(49, typeof(Throwaway), 8U) as Throwaway;
				throwaway.physics1.M0 = 0;
				throwaway.physics1.M1 = 0;
				throwaway.physics1.M2 = 0;
				int num3 = (int)GameManager.FUN_2AC5C();
				throwaway.physics1.Z = (num3 & 4095) - 2048;
				int num4 = (int)GameManager.FUN_2AC5C();
				if (num4 < 0)
				{
					num4 += 15;
				}
				throwaway.physics1.W = -(num4 >> 4);
				num3 = (int)GameManager.FUN_2AC5C();
				throwaway.physics2.X = (num3 & 4095) - 2048;
				throwaway.type = 7;
				throwaway.flags |= 436U;
				short id = this.id;
				num++;
				throwaway.state = _THROWAWAY_TYPE.Type3;
				throwaway.id = id;
				throwaway.vTransform = GameManager.FUN_2A39C();
				throwaway.vTransform.position = vector3Int;
				throwaway.FUN_2D1DC();
				throwaway.DAT_87 = 1;
				throwaway.FUN_305FC();
			}
			while (num < 12);
			Ballistic ballistic = this.vData.ini.FUN_2C17C(17, typeof(Ballistic), 8U) as Ballistic;
			if (ballistic != null)
			{
				VigObject vigObject = Utilities.FUN_2CD78(this);
				if (vigObject == null)
				{
					vigObject = this;
				}
				ballistic.vTransform = vigObject.vTransform;
				ballistic.flags = 4U;
				ballistic.type = 3;
				ballistic.FUN_305FC();
			}
			self.physics1.X = self.physics1.X / 2;
			self.physics1.Z = self.physics1.Z / 2;
			self.FUN_2B1FC(new Vector3Int
			{
				x = hitDetection.normal2.x << 3,
				y = hitDetection.normal2.y * 8 - 585856,
				z = hitDetection.normal2.z << 3
			}, hitDetection.position, 0);
			short num5 = self.id;
			if (num5 < 0)
			{
				UIManager.instance.FUN_4E414(vector3Int, new Color32(0, 0, byte.MaxValue, 8));
				num5 = self.id;
			}
			num2 = -25;
			if (num5 < 0)
			{
				num2 = -100;
			}
			Vehicle vehicle = (Vehicle)self;
			vehicle.FUN_3A064(num2, hitDetection.position, false);
			vehicle.state = _VEHICLE_TYPE.Fence;
			GameManager.instance.FUN_30CB0(vehicle, 15);
		}
		else
		{
			base.FUN_32CF0(hit);
		}
		return 0U;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000196C0 File Offset: 0x000178C0
	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 <= 2)
		{
			if (arg1 != 1)
			{
				if (arg1 == 2)
				{
					this.tags = 0;
				}
			}
			else if (this.tags == 0)
			{
				this.DAT_19 = 1;
			}
			else
			{
				this.tags = 0;
				this.DAT_19 = 0;
			}
		}
		else if (arg1 != 8)
		{
			if (arg1 == 9)
			{
				if (arg2 == 0 && this.DAT_19 != 0)
				{
					base.FUN_33A28(36736U);
				}
			}
		}
		else
		{
			base.FUN_32B90((uint)arg2);
		}
		return 0U;
	}
}
