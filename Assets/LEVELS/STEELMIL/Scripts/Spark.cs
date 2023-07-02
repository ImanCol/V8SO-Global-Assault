using UnityEngine;

public class Spark : VigObject
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
		if (hit.self.type == 2)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			vehicle.physics1.Y -= 390528;
			flags |= 32u;
			LevelManager.instance.FUN_39AF8(vehicle);
			vehicle.FUN_3A064(-25, vTransform.position, param3: true);
			UIManager.instance.FUN_4E414(vTransform.position, new Color32(128, 0, 0, 8));
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 69, vTransform.position);
			LevelManager.instance.FUN_4E8C8(vTransform.position, 48);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 != 0)
			{
				return 0u;
			}
			if ((flags & 0x20) == 0)
			{
				vTransform.position.x += physics1.X;
				vTransform.position.z += physics1.Z;
				int y = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
				vTransform.position.y = y;
				Vector3Int n = GameManager.instance.terrain.FUN_1B998((uint)vTransform.position.x, (uint)vTransform.position.z);
				n = Utilities.VectorNormal(n);
				child2.vTransform.rotation = Utilities.FUN_2A5EC(n);
				if (GameManager.instance.terrain.GetTileByPosition((uint)vTransform.position.x, (uint)vTransform.position.z).DAT_10[3] == 1)
				{
					return 0u;
				}
				flags |= 32u;
			}
			else
			{
				short m = physics1.M6;
				physics1.M6 = (short)(m - 136);
				vTransform.rotation.V22 = m;
				vTransform.rotation.V11 = m;
				vTransform.rotation.V00 = m;
				if (m - 136 < 205)
				{
					GameManager.instance.FUN_309A0(this);
					return uint.MaxValue;
				}
			}
		}
		else
		{
			if (arg1 != 4)
			{
				return 0u;
			}
			GameManager.instance.FUN_1DE78(DAT_18);
		}
		return 0u;
	}
}
