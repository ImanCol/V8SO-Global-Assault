using System.Collections.Generic;
using UnityEngine;

public class RiftBlade2 : VigObject
{
	public VigTransform DAT_84_2;

	public int DAT_A4;

	public int DAT_A8;

	public int DAT_AC;

	public int DAT_B0;

	public int DAT_B4;

	public VigObject DAT_B8;

	public List<Vehicle> DAT_BC;

	public bool chain;

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
		if (hit.object2.type == 3)
		{
			return 0u;
		}
		VigObject dAT_ = DAT_80;
		if (hit.self.type == 3)
		{
			return 0u;
		}
		if (hit.self.type == 8)
		{
			return 0u;
		}
		DAT_A8 = DAT_A4;
		if (hit.self == DAT_B8)
		{
			return 0u;
		}
		new Vector3Int(0, -4096, 0);
		DAT_B8 = hit.self;
		DAT_A8 = DAT_A4;
		GameManager.instance.FUN_2F798(this, hit);
		Vector3Int vector3Int = Utilities.FUN_24148(vTransform, hit.position);
		LevelManager.instance.FUN_4EAE8(vector3Int, hit.normal1, 148);
		UIManager.instance.FUN_4E414(vector3Int, new Color32(128, 128, 128, 8));
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, dAT_.vData.sndList, 3, vector3Int);
		if (hit.self.type != 2)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)hit.self;
		if (DAT_BC.Contains(vehicle))
		{
			return 0u;
		}
		DAT_BC.Add(vehicle);
		Vehicle vehicle2 = (Vehicle)dAT_;
		param = -500;
		if (vehicle2.doubleDamage != 0)
		{
			param = -1000;
		}
		param = vehicle.FUN_3B078(DAT_80, (ushort)DAT_1A, param, 1u);
		vehicle.FUN_3A020(param, new Vector3Int(0, 0, 0), param3: true);
		if (1u < (uint)(DAT_19 - 1))
		{
			return 0u;
		}
		if (vehicle2.id < 0)
		{
			if ((InputManager.controllers[~vehicle2.id].actions & 0x20) != 0)
			{
				vehicle2.target = vehicle2.FUN_3CF7C(vehicle2);
				vehicle2.targetList.Add(vehicle2.target);
				param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 0);
				chain = true;
			}
			else
			{
				DAT_19 = 4;
				param = 6;
				GameManager.instance.FUN_30CB0(this, param);
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		VigObject dAT_ = DAT_80;
		Vector3Int v;
		Vector3Int v2;
		int dAT_B;
		if (arg1 != 2)
		{
			if (arg1 < 3)
			{
				if (arg1 != 0)
				{
					return 0u;
				}
				byte dAT_2 = DAT_19;
				DAT_A4++;
				if (4 < dAT_2)
				{
					if (dAT_2 != 5)
					{
						return 0u;
					}
					v = new Vector3Int(DAT_AC, DAT_AC, DAT_AC);
					v2 = new Vector3Int(DAT_B0, DAT_B0, DAT_B0);
					Utilities.FUN_2449C(DAT_84_2.rotation, v, ref vTransform.rotation);
					Utilities.FUN_2449C(DAT_84_2.rotation, v2, ref dAT_.vTransform.rotation);
					int dAT_AC = DAT_AC - 245;
					dAT_B = DAT_B0 + 245;
					DAT_AC = dAT_AC;
					DAT_B0 = dAT_B;
					return 0u;
				}
				if (dAT_2 == 0)
				{
					Vector3Int v3 = new Vector3Int(DAT_AC, DAT_AC, DAT_AC);
					Vector3Int v4 = new Vector3Int(DAT_B0, DAT_B0, DAT_B0);
					Utilities.FUN_2449C(DAT_84_2.rotation, v3, ref vTransform.rotation);
					Utilities.FUN_2449C(DAT_84_2.rotation, v4, ref dAT_.vTransform.rotation);
					int dAT_AC = DAT_AC + 122;
					dAT_B = DAT_B0 - 122;
					DAT_AC = dAT_AC;
					DAT_B0 = dAT_B;
				}
				v = new Vector3Int(vTransform.rotation.V02, 0, vTransform.rotation.V22);
				if (DAT_19 == 1)
				{
					dAT_B = DAT_B4 + 1017;
				}
				else
				{
					if (DAT_19 != 3)
					{
						goto IL_01ca;
					}
					dAT_B = DAT_B4 - 2034;
				}
				DAT_B4 = dAT_B;
				goto IL_01ca;
			}
			return 0u;
		}
		int param;
		switch (DAT_19)
		{
		case 0:
			DAT_19++;
			dAT_.flags |= 2u;
			GameManager.instance.FUN_30CB0(this, 50);
			flags &= 4294967263u;
			return 0u;
		case 1:
			param = 30;
			DAT_19++;
			break;
		case 2:
			param = 15;
			DAT_19++;
			break;
		case 3:
		case 4:
			if (DAT_A4 - DAT_A8 < 5)
			{
				param = 5;
				DAT_19 = 4;
				DAT_B4 = 4577;
				break;
			}
			param = 15;
			DAT_19 = 5;
			DAT_AC = 4096;
			DAT_B0 = 409;
			DAT_84_2 = vTransform;
			dAT_.flags &= 4294967293u;
			break;
		case 5:
			dAT_.FUN_30B78();
			dAT_.flags &= 4194303967u;
			GameManager.instance.FUN_309A0(this);
			GameManager.instance.DAT_1084--;
			goto default;
		default:
			return 0u;
		}
		GameManager.instance.FUN_30CB0(this, param);
		return 0u;
		IL_01ca:
		Vector3Int vector3Int = default(Vector3Int);
		vector3Int.x = v.x * DAT_B4 >> 12;
		vector3Int.z = v.z * DAT_B4 >> 12;
		vector3Int.y = 65536;
		v2 = default(Vector3Int);
		v2.x = vTransform.position.x + vector3Int.x;
		v2.y = vTransform.position.y + 65536;
		v2.z = vTransform.position.z + vector3Int.z;
		if (GameManager.instance.terrain.GetTileByPosition((uint)v2.x, (uint)v2.z).DAT_10[3] != 7)
		{
			vTransform.position = v2;
		}
		dAT_B = FUN_2CFBC(vTransform.position);
		if (dAT_B - 20480 < vTransform.position.y)
		{
			vTransform.position.y = dAT_B - 20480;
		}
		if (GameManager.instance.DAT_DB0 != 0 && dAT_B > GameManager.instance.DAT_DB0)
		{
			vTransform.position.y = GameManager.instance.DAT_DB0;
		}
		dAT_.vTransform.position = Utilities.FUN_24148(vTransform, screen);
		VigObject target = ((Vehicle)dAT_).target;
		if (target != null)
		{
			Vector3Int vin = default(Vector3Int);
			vin.x = target.screen.x - vTransform.position.x;
			vin.y = target.screen.y - vTransform.position.y;
			vin.z = target.screen.z - vTransform.position.z;
			Utilities.FUN_29FC8(vin, out Vector3Int vout);
			Vector3Int vector3Int2 = new Vector3Int(vout.z, 0, -vout.x);
			dAT_B = vout.y * vector3Int2.z;
			if (dAT_B < 0)
			{
				dAT_B += 4095;
			}
			int z = vout.z;
			int num = z * z - vout.x * vector3Int2.z;
			Vector3Int vector3Int3 = default(Vector3Int);
			vector3Int3.x = dAT_B >> 12;
			if (num < 0)
			{
				num += 4095;
			}
			z = -vout.y * z;
			vector3Int3.y = num >> 12;
			if (z < 0)
			{
				z += 4095;
			}
			vector3Int3.z = z >> 12;
			Matrix3x3 m = default(Matrix3x3);
			m.V00 = (short)vector3Int2.x;
			m.V01 = (short)vector3Int3.x;
			m.V02 = (short)vout.x;
			m.V10 = (short)vector3Int2.y;
			m.V11 = (short)vector3Int3.y;
			m.V12 = (short)vout.y;
			m.V20 = (short)vector3Int2.z;
			m.V21 = (short)vector3Int3.z;
			m.V22 = (short)vout.z;
			m = Utilities.MatrixNormal(m);
			Utilities.FUN_248C4(vTransform.rotation, m, out m);
			dAT_B = 64;
			if (DAT_19 == 2)
			{
				dAT_B = 256;
			}
			if (chain)
			{
				dAT_B = 512;
			}
			z = m.V02;
			num = -dAT_B;
			if (-dAT_B <= z)
			{
				num = dAT_B;
				if (z <= dAT_B)
				{
					num = z;
				}
			}
			z = -m.V01;
			int num2 = -dAT_B;
			if (-dAT_B <= z)
			{
				num2 = dAT_B;
				if (z <= dAT_B)
				{
					num2 = z;
				}
			}
			FUN_24700(0, (short)num, (short)num2);
			vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
		}
		Utilities.FUN_2449C(v3: new Vector3Int(DAT_B0, DAT_B0, DAT_B0), m33: vTransform.rotation, mout: ref dAT_.vTransform.rotation);
		if ((DAT_A4 & 3) != 0)
		{
			return 0u;
		}
		Ballistic obj = vData.ini.FUN_2C17C(1, typeof(Ballistic), 8u) as Ballistic;
		obj.type = 7;
		obj.flags = 36u;
		obj.screen = vTransform.position;
		obj.FUN_3066C();
		obj.vTransform = vTransform;
		return 0u;
	}
}
