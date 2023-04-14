using UnityEngine;

public class NASA : VigObject
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
		if (hit.collider1.ReadUInt16(0) == 1 && hit.collider1.ReadUInt16(2) == 2)
		{
			if (hit.self.type != 2)
			{
				return 0u;
			}
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, vData.sndList, 7, vTransform.position);
			UIManager.instance.FUN_4E338(new Color32(128, 128, 128, 8));
			VigObject child = child2;
			LaunchVehicle launchVehicle;
			while (true)
			{
				if (child == null)
				{
					launchVehicle = (GameManager.instance.FUN_302A8(GameManager.instance.worldObjs, typeof(LaunchVehicle)) as LaunchVehicle);
					if (launchVehicle == null)
					{
						return 0u;
					}
					if (launchVehicle.tags == 0)
					{
						if ((launchVehicle.flags & 0x1000000) == 0)
						{
							launchVehicle.physics1.W = 0;
							launchVehicle.FUN_30B78();
							sbyte param2 = launchVehicle.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
							GameManager.instance.FUN_1E628(param2, launchVehicle.vData.sndList, 0, launchVehicle.vTransform.position, param5: true);
						}
						else
						{
							GameManager.instance.FUN_1DE78(launchVehicle.DAT_18);
							launchVehicle.DAT_18 = 0;
							launchVehicle.FUN_30BA8();
						}
						launchVehicle.flags ^= 16777216u;
					}
					else if (launchVehicle.tags == 1 && (launchVehicle.flags & 0x1000000) == 0)
					{
						launchVehicle.flags |= 16777216u;
						GameManager.instance.FUN_30CB0(launchVehicle, 3);
					}
					GameManager.instance.FUN_30CB0(this, 180);
					return 0u;
				}
				if (child.id == 2)
				{
					break;
				}
				child = child.child2;
			}
			child.flags |= 32u;
			launchVehicle = (GameManager.instance.FUN_302A8(GameManager.instance.worldObjs, typeof(LaunchVehicle)) as LaunchVehicle);
			if (launchVehicle == null)
			{
				return 0u;
			}
			if (launchVehicle.tags == 0)
			{
				if ((launchVehicle.flags & 0x1000000) == 0)
				{
					launchVehicle.physics1.W = 0;
					launchVehicle.FUN_30B78();
					sbyte param2 = launchVehicle.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param2, launchVehicle.vData.sndList, 0, launchVehicle.vTransform.position, param5: true);
				}
				else
				{
					GameManager.instance.FUN_1DE78(launchVehicle.DAT_18);
					launchVehicle.DAT_18 = 0;
					launchVehicle.FUN_30BA8();
				}
				launchVehicle.flags ^= 16777216u;
			}
			else if (launchVehicle.tags == 1 && (launchVehicle.flags & 0x1000000) == 0)
			{
				launchVehicle.flags |= 16777216u;
				GameManager.instance.FUN_30CB0(launchVehicle, 3);
			}
			GameManager.instance.FUN_30CB0(this, 180);
			return 0u;
		}
		if (hit.self.type != 8)
		{
			return 0u;
		}
		hit.object1.FUN_32B90(hit.self.maxHalfHealth);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			VigObject child = child2;
			while (child != null)
			{
				if (child.id == 2)
				{
					child.flags &= 4294967263u;
					return 0u;
				}
				child = child.child2;
			}
		}
		else
		{
			if (arg1 < 3)
			{
				if (arg1 == 1)
				{
					VigObject child = child2;
					while (child != null)
					{
						if (child.id == 1)
						{
							child.maxHalfHealth = 100;
						}
						else if (child.id == 2)
						{
							child.type = 3;
						}
						child = child.child2;
					}
				}
			}
			else if (arg1 != 8)
			{
				return 0u;
			}
			FUN_32B90((uint)arg2);
		}
		return 0u;
	}
}
