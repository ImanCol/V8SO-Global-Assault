using UnityEngine;

public class Bird2 : VigObject
{
	public Bird DAT_94;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
			physics1.Z = 1525;
			break;
		case 0:
		{
			int z = physics1.Z;
			int num = vTransform.rotation.V02 * z;
			if (num < 0)
			{
				num += 4095;
			}
			int num2 = vTransform.rotation.V12 * z;
			vTransform.position.x += num >> 12;
			if (num2 < 0)
			{
				num2 += 4095;
			}
			num = vTransform.rotation.V22 * z;
			vTransform.position.y += num2 >> 12;
			if (num < 0)
			{
				num += 4095;
			}
			vTransform.position.z += num >> 12;
			if (DAT_19 < 2)
			{
				Vector3Int vector3Int;
				if (DAT_19 == 0)
				{
					vector3Int = GameManager.instance.FUN_2CE50(DAT_94);
				}
				else
				{
					VigObject dAT_ = DAT_84;
					if (dAT_ == null)
					{
						dAT_ = DAT_80;
					}
					vector3Int = default(Vector3Int);
					vector3Int.x = dAT_.screen.x;
					vector3Int.z = dAT_.screen.z;
					vector3Int.y = dAT_.screen.y - 204800;
				}
				Vector3Int vector3Int2 = default(Vector3Int);
				vector3Int2.x = vector3Int.x - vTransform.position.x;
				vector3Int2.y = vector3Int.y - vTransform.position.y;
				vector3Int2.z = vector3Int.z - vTransform.position.z;
				vector3Int2 = Utilities.FUN_2426C(vTransform.rotation, new Matrix2x4(vector3Int2.x, vector3Int2.y, vector3Int2.z, 0));
				Utilities.FUN_29FC8(vector3Int2, out Vector3Int vout);
				num2 = 6103;
				num = vector3Int2.z;
				if (vector3Int2.z < 0)
				{
					num = vector3Int2.z + 15;
				}
				num >>= 4;
				if (DAT_19 != 0)
				{
					num2 = 12207;
				}
				int num3 = 1525;
				if (1524 < num)
				{
					num3 = num2;
					if (num <= num2)
					{
						num3 = num;
					}
				}
				if (vout.y < 1)
				{
					if (vr.x < 341)
					{
						vr.x += 22;
					}
				}
				else if (-341 < vr.x)
				{
					vr.x -= 22;
				}
				if (vout.x < 0)
				{
					if (-341 < vr.z)
					{
						vr.z -= 22;
					}
				}
				else if (vr.z < 341)
				{
					vr.z += 22;
				}
				num = vr.z;
				if (num < 0)
				{
					num += 15;
				}
				vr.y += num >> 4;
				if (tags == 0)
				{
					if (z + 305 < num3)
					{
						tags = 1;
						FUN_2C124(1);
						Utilities.ParentChildren(this, this);
					}
					num = physics1.Z - 25;
				}
				else
				{
					if (num3 < z - 610)
					{
						tags = 0;
						FUN_2C124(2);
						Utilities.ParentChildren(this, this);
					}
					num = physics1.Z + 25;
				}
				physics1.Z = num;
				if (DAT_19 != 0)
				{
					if (arg2 != 0)
					{
						DAT_4A -= (ushort)arg2;
					}
					if (3072 < vout.z && vector3Int2.z < 204800)
					{
						int param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E580(param, vData.sndList, 4, vTransform.position);
						vr.x = -341;
						DAT_19 = 2;
					}
				}
				ApplyRotationMatrix();
				return 0u;
			}
			if (DAT_84 == null)
			{
				GameManager.instance.FUN_30CB0(this, 0);
				return 0u;
			}
			if (DAT_84.type == 2)
			{
				if ((GameManager.instance.DAT_28 & 1) != 0)
				{
					Ballistic obj = vData.ini.FUN_2C17C(3, typeof(Ballistic), 8u) as Ballistic;
					obj.flags = 36u;
					obj.vTransform = vTransform;
					obj.FUN_305FC();
				}
				num = FUN_2CFBC(vTransform.position);
				if (num - 61440 < vTransform.position.y)
				{
					Tornado tornado = vData.ini.FUN_2C17C(7, typeof(Tornado), 8u) as Tornado;
					Utilities.ParentChildren(tornado, tornado);
					tornado.type = 3;
					tornado.flags = 1610613124u;
					tornado.screen = vTransform.position;
					tornado.DAT_80 = DAT_80;
					tornado.DAT_84 = DAT_84;
					short v = vTransform.rotation.V02;
					tornado.physics1.W = 12207;
					tornado.physics1.Z = v;
					tornado.physics2.X = vTransform.rotation.V22;
					tornado.FUN_3066C();
					GameManager.instance.FUN_30CB0(tornado, 330);
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, vData.sndList, 3, vTransform.position);
					GameManager.instance.FUN_30CB0(this, 0);
					return 0u;
				}
			}
			else if (DAT_84.type == 3)
			{
				((Pickup)DAT_84).OnCollision(new HitDetection(null)
				{
					self = DAT_80
				});
			}
			break;
		}
		default:
			return 0u;
		case 2:
		{
			VigObject dAT_ = DAT_94;
			GameManager.instance.DAT_1084--;
			if (dAT_.maxHalfHealth == 0)
			{
				dAT_.FUN_3A368();
				return uint.MaxValue;
			}
			dAT_.id += 240;
			DAT_19 = 0;
			break;
		}
		}
		return 0u;
	}
}
