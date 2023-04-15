using System.Collections.Generic;
using UnityEngine;

public class Rain : VigObject
{
	public bool thunder;

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
		Rain rain = new GameObject().AddComponent<Rain>();
		rain.vData = arg1;
		rain.DAT_1A = (short)arg2;
		return rain;
	}
	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 1)
		{
			int num = 0;
			if (_GAME_MODE.Demo < GameManager.instance.gameMode && GameManager.instance.gameMode < _GAME_MODE.Versus2)
			{
				UnityEngine.Object.Destroy(this);
				return uint.MaxValue;
			}
			flags |= 160u;
			int num2 = GameManager.instance.FUN_1DD9C();
			DAT_18 = (sbyte)num2;
			GameManager.instance.FUN_1E188(DAT_18, LevelManager.instance.xobfList[42].sndList, 14, param4: true);
			do
			{
				VigObject vigObject = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(RainDrop), 0u);
				num++;
				vigObject.flags |= 1040u;
				num2 = (int)GameManager.FUN_2AC5C();
				vigObject.screen.x = num2 << 17 >> 13;
				num2 = (int)GameManager.FUN_2AC5C();
				vigObject.screen.y = num2 << 17 >> 13;
				num2 = (int)GameManager.FUN_2AC5C();
				vigObject.screen.z = num2 << 17 >> 13;
				vigObject.vMesh.DAT_02 = 64;
				vigObject.ApplyTransformation();
				Utilities.FUN_2CC48(this, vigObject);
			}
			while (num < 64);
			Utilities.ParentChildren(this, this);
		}
		else
		{
			if (arg1 == 2)
			{
				this.thunder = false;
			}
			if (arg1 == 4)
			{
				GameManager.instance.FUN_1DE78(DAT_18);
			}
			if (arg1 != 0)
			{
				return 0u;
			}
			if (((GameManager.instance.DAT_28 - DAT_19) & 0x7F) == 0 && !this.thunder)
			{
				int num = (int)GameManager.FUN_2AC5C();
				if ((num & 0x3F) < HOOVRDAM.instance.destroyedObjects)
				{
					Vehicle vehicle = GameManager.instance.playerObjects[0];
					if (vehicle != null && GameManager.instance.worldObjs != null)
					{
						List<VigTuple> worldObjs = GameManager.instance.worldObjs;
						for (int i = 0; i < worldObjs.Count; i++)
						{
							VigObject vObject = worldObjs[i].vObject;
							if (vObject.type == 2 && vObject.maxHalfHealth != 0 && vObject != vehicle)
							{
								int num3 = Utilities.FUN_29F6C(vehicle.vTransform.position, vObject.vTransform.position);
								if (num3 < 262144)
								{
									Thunder thunder = LevelManager.instance.xobfList[42].ini.FUN_2C17C(610, typeof(Thunder), 0u) as Thunder;
									Vector3Int b = (vehicle.vTransform.position - vObject.vTransform.position) / 2;
									b = (thunder.screen = vehicle.vTransform.position - b);
									thunder.flags |= 132u;
									thunder.vr.z = 1024;
									thunder.screen.y -= 262144;
									thunder.vAnim = thunder.vData.FUN_2CBB0(600);
									thunder.FUN_3066C();
									thunder.physics1.X = 8192;
									LevelManager.instance.FUN_4E128(b, 81, 200);
									UIManager.instance.FUN_4E338(new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 3));
									GameManager.instance.FUN_30CB0(this, 400);
									GameManager.instance.FUN_30CB0(thunder, 60);
									int num2 = GameManager.instance.FUN_1DD9C();
									GameManager.instance.FUN_1E580(num2, thunder.vData.sndList, 7, b);
									this.thunder = true;
								}
							}
						}
					}
				}
			}
			if (arg2 != 0)
			{
				int num2 = GameManager.instance.DAT_F28.position.x + GameManager.instance.DAT_F28.rotation.V02 * 64;
				int num4 = vTransform.position.x - num2 + arg2 * 1525;
				Vector3Int b = default(Vector3Int);
				b.x = num4 / arg2;
				int num5 = GameManager.instance.DAT_F28.position.y + GameManager.instance.DAT_F28.rotation.V12 * 64;
				int num6 = vTransform.position.y - num5 + arg2 * 7629;
				b.y = num6 / arg2;
				int num = GameManager.instance.DAT_F28.position.z + GameManager.instance.DAT_F28.rotation.V22 * 64;
				int num3 = vTransform.position.z - num;
				b.z = num3 / arg2;
				b = Utilities.FUN_24094(GameManager.instance.DAT_F00.rotation, b);
				vTransform.position.x = num2;
				vTransform.position.y = num5;
				vTransform.position.z = num;
				Vector3Int r = default(Vector3Int);
				r.x = Utilities.Ratan2(b.z, b.y);
				r.y = 0;
				r.z = Utilities.Ratan2(b.x, b.y);
				r.z = -r.z;
				Matrix3x3 rotation = Utilities.RotMatrixYXZ_gte(r);
				VigObject vigObject2 = child2;
				if (vigObject2 != null)
				{
					do
					{
						vigObject2.vTransform.rotation = rotation;
						vigObject2.vTransform.position.x = ((vigObject2.vTransform.position.x + num4 + 131072) & 0x3FFFF) - 131072;
						vigObject2.vTransform.position.y = ((vigObject2.vTransform.position.y + num6 + 131072) & 0x3FFFF) - 131072;
						vigObject2.vTransform.position.z = ((vigObject2.vTransform.position.z + num3 + 131072) & 0x3FFFF) - 131072;
						vigObject2 = vigObject2.child;
					}
					while (vigObject2 != null);
					return 0u;
				}
			}
		}
		return 0u;
	}
}