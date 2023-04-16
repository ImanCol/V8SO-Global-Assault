using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class OBJ
{
    public byte[] buffer;

    public OBJ(byte[] b)
    {
        buffer = b;
    }
}

public class LevelManager : MonoBehaviour
{
	private void Awake()
	{
		if (LevelManager.instance == null)
		{
			LevelManager.instance = this;
		}
		this.ainav = new Navigation();
		this.levelObjs = new List<VigTuple>();
		for (int i = 0; i < this.xobfList.Count; i++)
		{
			if (this.xobfList[i] != null)
			{
				this.xobfList[i].SetAtlas();
			}
		}
	}

	private void Start()
	{
		GameManager.instance.levelManager = this;
		GameManager.instance.terrain = this.terrain;
		if (GameManager.instance.inMenu)
		{
			return;
		}
		PSXEffects component = this.defaultCamera.GetComponent<PSXEffects>();
		switch (GameManager.instance.ditheringMethod)
		{
		case _DITHERING.None:
			component.colorDepth = 16;
			component.resolutionFactor = 1;
			component.dithering = false;
			break;
		case _DITHERING.Standard:
			component.colorDepth = 5;
			component.resolutionFactor = 2;
			component.dithering = true;
			component.ditherType = 1;
			break;
		case _DITHERING.PSX:
			component.colorDepth = 5;
			component.resolutionFactor = 2;
			component.dithering = true;
			component.ditherType = 0;
			break;
		}
		if ((GameManager.instance.DAT_40 & 64) != 0)
		{
			this.DAT_C18[4] = 0;
		}
		this.LoadData();
		GameManager.DAT_63970[0].y = (int)this.DAT_63972;
		GameManager.DAT_63970[1].y = (int)this.DAT_6397A;
		GameManager.DAT_63970[2].y = (int)this.DAT_63982;
		GameManager.DAT_63970[3].y = (int)this.DAT_6398A;
		GameManager.DAT_63970[4].y = (int)this.DAT_63992;
		GameManager.DAT_63970[5].y = (int)this.DAT_6399A;
		int num = 0;
		do
		{
			VigMesh vigMesh = this.xobfList[18].FUN_2CB74_2(base.gameObject, (uint)GameManager.DAT_63A7C[num]);
			GameManager.instance.DAT_1150[num] = vigMesh;
			vigMesh.topology = MeshTopology.Lines;
			num++;
		}
		while (num < 4);
		GameManager.instance.targetHUD = new Material(Shader.Find("PSXEffects/PS1Screen"));
		int num2 = 1;
		if (_GAME_MODE.Demo < GameManager.instance.gameMode)
		{
			num2 = 4;
			if (GameManager.instance.gameMode < _GAME_MODE.Unk2)
			{
				num2 = 2;
			}
		}
		int num3 = 0;
		if (num2 != 0)
		{
			do
			{
				int num4 = (int)GameManager.instance.vehicles[num3];
				num3++;
			}
			while (num3 < num2);
		}
		GameManager.instance.timer = 0;
		Vector3Int param = new Vector3Int(this.DAT_10F8.x * 6144 >> 12, this.DAT_10F8.y * 6144 >> 12, this.DAT_10F8.z * 6144 >> 12);
		GameManager.instance.FUN_2DE84(0, param, this.DAT_DAC);
		GameManager.instance.FUN_2DE84(1, LevelManager.DAT_15F0, this.DAT_D98);
		param = new Vector3Int(-this.DAT_10F8.x, this.DAT_10F8.y, -this.DAT_10F8.z);
		GameManager.instance.FUN_2DE84(2, param, this.DAT_DBC);
		num = GameManager.instance.interObjs.Count;
		Utilities.SetColorMatrix(GameManager.instance.DAT_FA8);
		Utilities.SetLightMatrix(GameManager.instance.DAT_F68);
		Utilities.SetBackColor(64, 64, 64);
		if (GameManager.instance.interObjs.Count > 0)
		{
			List<VigTuple> interObjs = GameManager.instance.interObjs;
			do
			{
				VigTuple vigTuple = interObjs[0];
				VigObject vObject = vigTuple.vObject;
				interObjs.RemoveAt(0);
				this.FUN_3C8C(vObject, GameManager.defaultTransform);
				if (vigTuple.flag == 0u)
				{
					this.FUN_278C(GameManager.instance.bspTree, vigTuple);
				}
				else
				{
					this.FUN_284C((int)(vigTuple.flag & 2147483647u)).LDAT_04.Add(vigTuple);
				}
			}
			while (GameManager.instance.interObjs.Count > 0);
		}
		if (GameManager.instance.gameMode != _GAME_MODE.Quest)
		{
			_GAME_MODE gameMode = GameManager.instance.gameMode;
		}
		if (GameManager.instance.playerObjects[0] == null)
		{
			if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
			{
				GameManager.instance.playerObjects[0] = GameManager.instance.FUN_3208C(-1, ~DiscordController.GetMemberId());
				GameManager.instance.playerObjects[0].userId = DiscordController.GetUserId();
				GameManager gameManager = GameManager.instance;
				gameManager.playerSpawns -= 1;
			}
			else
			{
				GameManager.instance.playerObjects[0] = GameManager.instance.FUN_3208C(-1);
			}
			if (GameManager.instance.playerObjects[0] != null)
			{
				if (GameManager.instance.gameMode < _GAME_MODE.Versus2)
				{
					num = 1;
					GameManager.instance.playerObjects[0].flags = ((GameManager.instance.playerObjects[0].flags & 33554431u) | 2147483648u);
					for (;;)
					{
						num2 = (int)GameManager.FUN_2AC5C();
						uint num5 = 16777216u << (num2 * 7 >> 15) + 1;
						if ((GameManager.instance.playerObjects[0].flags & num5) == 0u)
						{
							GameManager.instance.playerObjects[0].flags |= num5;
							num++;
							if (num >= 3)
							{
								break;
							}
						}
					}
				}
				GameManager.instance.playerObjects[0].FUN_3066C();
			}
		}
		this.FUN_3D94(GameManager.instance.playerObjects[0]);
		GameManager.instance.DAT_CC4 = 0;
		GameManager.instance.inDebug = false;
		this.level.UpdateW(1, 0);
		if ((this.level.flags & 128u) != 0u)
		{
			GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, this.level);
		}
		ClientSend.Spawn();
		DiscordController.instance.sceneLoaded = true;
	}

	private void Update()
	{
	}

	public void LoadData()
	{
		IMP_BSP.LoadData(this.bspData);
		for (int i = 0; i < this.objData.Count; i++)
		{
			IMP_OBJ.LoadOBJ(this.objData[i].buffer);
		}
	}

	public int FUN_9C10(uint param1, int param2, uint param3, int param4)
	{
		int result = 0;
		if (param4 < param2)
		{
			result = 2;
			if (param2 <= param4)
			{
				if (param1 < param3)
				{
					result = 0;
				}
				else
				{
					result = 2;
					if (param1 <= param3)
					{
						result = 1;
					}
				}
			}
		}
		return result;
	}

	public void FUN_7E6C()
	{
		this.counter = 0;
		if (0 < this.DAT_1184)
		{
			for (int i = 0; i < this.DAT_1184; i++)
			{
				JUNC_DB junc_DB = this.juncList[i];
				if (junc_DB.DAT_11 != 0)
				{
					for (int j = 0; j < (int)junc_DB.DAT_11; j++)
					{
						RSEG_DB rseg_DB = junc_DB.DAT_1C[j];
						if (junc_DB == rseg_DB.DAT_00[0] && (rseg_DB.DAT_0C & 16) == 0 && this.xrtpList[(int)rseg_DB.DAT_0A].timFarList.Count > 0)
						{
							this.FUN_719C(rseg_DB);
						}
					}
				}
			}
		}
		if (0 < this.DAT_1180)
		{
			for (int k = 0; k < this.DAT_1180; k++)
			{
				if (this.xrtpList[k].timFarList != null)
				{
					this.FUN_50F0(this.xrtpList[k]);
				}
			}
		}
	}

	public void FUN_21594(short[] param1, ushort param2, ushort param3, ushort param4)
	{
		uint num = (uint)param2 >> 7 & 3u;
		if (param1 != null)
		{
			param1[0] = (short)((param2 & 15) * 64 + (ushort)((short)((byte)param3 >> (int)(2u - num))));
			param1[1] = (short)((uint)((param2 & 16) * 16) + ((uint)param3 >> 8));
			param1[2] = (short)(this.DAT_DF8[0].mainTexture.width >> (int)(2u - num));
			param1[3] = (short)this.DAT_DF8[0].mainTexture.height;
		}
	}

	public uint FUN_35778(int param1, int param2)
	{
		uint num = (uint)((uint)param1 << 5);
		param2 <<= 5;
		int num2 = 0;
		uint num3;
		for (;;)
		{
			num3 = num >> 31;
			if (param2 < 0)
			{
				num3 |= 2u;
			}
			ushort num4 = this.aimpData[(int)(checked((IntPtr)(unchecked((long)num2 + (long)((ulong)num3) + 1L))))];
			num3 = (uint)num4;
			if (num3 == 0u || (num4 & 32768) != 0)
			{
				break;
			}
			num2 += (int)(num3 * 5u);
			num <<= 1;
			param2 <<= 1;
		}
		return num3;
	}

	public void FUN_359CC(short[] param1, uint param2)
	{
		this.FUN_357D4(param1, param2, 0, 0, 0, 2048, this.aimpData);
	}

	public void FUN_357D4(short[] param1, uint param2, int param3, int param4, int param5, int param6, ushort[] param7)
	{
		param6 >>= 1;
		ushort num = (ushort)param2;
		if ((int)param1[1] < param5 + param6)
		{
			if ((int)param1[0] < param4 + param6)
			{
				ushort num2 = param7[param3 + 1];
				if (num2 == 0 || (num2 & 32768) != 0)
				{
					param7[param3 + 1] = num;
				}
				else
				{
					this.FUN_357D4(param1, param2, param3 + (int)(num2 * 5), param4, param5, param6, param7);
				}
			}
			if (param4 + param6 < (int)(param1[0] + param1[2]))
			{
				ushort num2 = param7[param3 + 2];
				if (num2 == 0 || (num2 & 32768) != 0)
				{
					param7[param3 + 2] = num;
				}
				else
				{
					this.FUN_357D4(param1, param2, param3 + (int)(num2 * 5), param4 + param6, param5, param6, param7);
				}
			}
		}
		if (param5 + param6 < (int)(param1[1] + param1[3]))
		{
			if ((int)param1[0] < param4 + param6)
			{
				ushort num2 = param7[param3 + 3];
				if (num2 == 0 || (num2 & 32768) != 0)
				{
					param7[param3 + 3] = num;
				}
				else
				{
					this.FUN_357D4(param1, param2, param3 + (int)(num2 * 5), param4, param5 + param6, param6, param7);
				}
			}
			if (param4 + param6 < (int)(param1[0] + param1[2]))
			{
				ushort num2 = param7[param3 + 4];
				if (num2 == 0 || (num2 & 32768) != 0)
				{
					param7[param3 + 4] = num;
					return;
				}
				this.FUN_357D4(param1, param2, param3 + (int)(num2 * 5), param4 + param6, param5 + param6, param6, param7);
			}
		}
	}

	public void FUN_309C8(VigObject param1, int param2)
	{
		this.level.UpdateW(param1, 18, param2);
		GameManager.instance.FUN_309A0(param1);
	}

	public void FUN_359FC(int param1, int param2, uint param3)
	{
		if (param1 < 0)
		{
			param1 += 65535;
		}
		if (param2 < 0)
		{
			param2 += 65535;
		}
		this.FUN_357D4(new short[]
		{
			(short)(param1 >> 16),
			(short)(param2 >> 16),
			1,
			1
		}, param3, 0, 0, 0, 2048, this.aimpData);
	}

	public void FUN_38EF4(int param1, int param2)
	{
		Vector3Int param3 = new Vector3Int(param1, GameManager.instance.DAT_DB0, param2);
		this.FUN_4DE54(param3, 147).flags &= 4294967279u;
	}

	public void FUN_38F38(int param1, int param2)
	{
		Vector3Int param3 = new Vector3Int(param1, GameManager.instance.DAT_DB0, param2);
		this.FUN_4DE54(param3, 146).flags &= 4294967279u;
	}

	public Fire1 FUN_399FC(Vehicle param1, XOBF_DB param2, short param3)
	{
		Fire1 fire;
		if ((param1.DAT_F6 & 8) == 0 && (param1.DAT_F6 & 256) == 0)
		{
			fire = null;
			if (param1.shield == 0)
			{
				fire = new GameObject().AddComponent<Fire1>();
				fire.DAT_58 = 65536;
				fire.physics1.M1 = 4;
				fire.DAT_98 = param2;
				fire.physics2.M3 = param3;
				fire.maxHalfHealth = 2;
				fire.flags |= 32u;
				fire.vTransform = GameManager.FUN_2A39C();
				fire.physics1.Y = 512;
				fire.physics1.Z = -1536;
				fire.physics1.W = 0;
				Utilities.FUN_2CC9C(param1, fire);
				fire.transform.parent = param1.transform;
				fire.FUN_30B78();
				GameManager.instance.FUN_30CB0(fire, 600);
				param1.DAT_F6 |= 8;
			}
		}
		else
		{
			fire = null;
		}
		return fire;
	}

	public bool FUN_39AF8(Vehicle param1)
	{
		Fire1 x = this.FUN_399FC(param1, this.xobfList[19], 22);
		if (x != null)
		{
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 68, param1.vTransform.position, false);
		}
		return x != null;
	}

	public VigObject FUN_42408(VigObject param1, VigObject param2, ushort param3, Type param4, VigObject param5)
	{
		ConfigContainer configContainer;
		if (param2.vData == null)
		{
			configContainer = null;
		}
		else
		{
			configContainer = param2.FUN_2C5F4(32768);
		}
		VigObject vigObject;
		if ((int)param3 << 16 < 0)
		{
			vigObject = (new GameObject().AddComponent(param4) as VigObject);
		}
		else
		{
			vigObject = param2.vData.ini.FUN_2C17C(param3, param4, 8u);
		}
		vigObject.DAT_80 = param1;
		vigObject.flags = 536870912u;
		ushort num = (ushort)param1.id;
		vigObject.type = 8;
		vigObject.id = (short)num;
		if (configContainer == null)
		{
			VigTransform vTransform = GameManager.instance.FUN_2CDF4(param2);
			vigObject.vTransform = vTransform;
		}
		else
		{
			vigObject.vTransform = GameManager.instance.FUN_2CEAC(param2, configContainer);
		}
		vigObject.screen = vigObject.vTransform.position;
		if (param5 != null)
		{
			Utilities.FUN_2CA94(param2, configContainer, param5);
			param5.transform.parent = param2.transform;
		}
		return vigObject;
	}

	public VigObject FUN_42560(VigObject param1, VigObject param2, VigObject param3, VigObject param4)
	{
		param3.DAT_80 = param1;
		param3.flags = 536870912u;
		short id = param1.id;
		param3.type = 8;
		param3.id = id;
		param3.vTransform = GameManager.instance.FUN_2CDF4(param2);
		param3.screen = param3.vTransform.position;
		if (param4 != null)
		{
			param4.vTransform = GameManager.FUN_2A39C();
			Utilities.FUN_2CC48(param2, param4);
			param4.transform.parent = param2.transform;
		}
		return param3;
	}

	public void FUN_4AAC0(uint param1, Vector3Int param2, Vector3Int param3)
	{
		int num = (int)GameManager.instance.FUN_4A970(param1, 0u);
		this.FUN_4AA24((ushort)GameManager.DAT_63FA4[num], param2, param3);
	}

	public Pickup FUN_4AA24(ushort param1, Vector3Int param2, Vector3Int param3)
	{
		Pickup pickup = this.DAT_1178.ini.FUN_2C17C(param1, typeof(Pickup), 0u) as Pickup;
		pickup.state = _PICKUP_TYPE.Type2;
		pickup.screen = param2;
		pickup.physics1.Z = param3.x;
		pickup.physics1.W = param3.y;
		pickup.physics2.X = param3.z;
		pickup.DAT_87 = 2;
		pickup.FUN_3066C();
		return pickup;
	}

	public Pickup FUN_4AD24(short param1)
	{
		Pickup pickup = Utilities.FUN_31D30(typeof(Pickup), this.DAT_1178, param1, 0u) as Pickup;
		pickup.FUN_2C7D0();
		return pickup;
	}

	public Pickup FUN_4AD78(uint param1)
	{
		int num = (int)GameManager.instance.FUN_4A970(param1, 0u);
		return this.FUN_4AD24(GameManager.DAT_63FA4[num]);
	}

	public Pickup FUN_4AE08(uint param1, Vector3Int param2)
	{
		Pickup pickup = this.FUN_4AD78(param1);
		pickup.screen = param2;
		pickup.FUN_3066C();
		return pickup;
	}

	public VigCamera FUN_4B984(VigObject param1, VigObject param2)
	{
		VigCamera vigCamera = new GameObject().AddComponent<VigCamera>();
		vigCamera.DAT_80 = param1;
		vigCamera.id = param2.id;
		vigCamera.screen = param2.screen;
		vigCamera.vr = param2.vr;
		vigCamera.state = _CAMERA_TYPE.Teleport;
		vigCamera.maxHalfHealth = param2.maxHalfHealth;
		vigCamera.ApplyTransformation();
		if (param1.type == 2)
		{
			param1.flags = ((param1.flags & 4294967293u) | 33554432u);
		}
		return vigCamera;
	}

	public void FUN_4DF20(Vector3Int param1, ushort param2, short param3)
	{
		Particle1 particle = this.FUN_4DE54(param1, param2);
		Vector3Int sv = new Vector3Int((int)param3, (int)param3, (int)param3);
		Utilities.FUN_245AC(ref particle.vTransform.rotation, sv);
		particle.vTransform.padding = param3;
	}

	public Particle1 FUN_4DE54(Vector3Int param1, ushort param2)
	{
		Particle1 particle = this.xobfList[19].ini.FUN_2C17C(param2, typeof(Particle1), 8u) as Particle1;
		Utilities.ParentChildren(particle, particle);
		particle.type = 7;
		particle.flags = 52u;
		particle.screen = param1;
		VigObject vigObject = particle.child2;
		while (vigObject != null)
		{
			vigObject.flags = 16u;
			vigObject = vigObject.child;
		}
		particle.ApplyTransformation();
		particle.FUN_2D1DC();
		VigTuple vigTuple = GameManager.instance.FUN_30080(GameManager.instance.interObjs, particle);
		particle.TDAT_74 = vigTuple;
		vigTuple = GameManager.instance.FUN_30080(GameManager.instance.DAT_10A8, particle);
		particle.TDAT_78 = vigTuple;
		return particle;
	}

	public void FUN_4D16C(XOBF_DB param1, ushort param2, VigTransform param3)
	{
		ConfigContainer configContainer = param1.ini.configContainers[(int)param2];
		ushort flag = configContainer.flag;
		uint num = (uint)flag;
		uint num2 = (uint)((int)num >> 12);
		if (num2 == 9u)
		{
			int param4 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param4, GameManager.instance.DAT_C2C, (int)GameManager.DAT_BC0[(int)(checked((IntPtr)(unchecked((long)GameManager.DAT_640C8[(flag >> 6 & 60) / 4] + (long)((ulong)(num & 255u))))))], param3.position, false);
		}
		else if (num2 < 10u)
		{
			if (num2 == 8u)
			{
				if (num - 33792u < 61u)
				{
					if (GameManager.DAT_63FE4[(int)(num - 33792u)] != -1)
					{
						VigCollider vigCollider;
						if (configContainer.colliderID < 0)
						{
							vigCollider = null;
						}
						else
						{
							vigCollider = param1.cbbList[(int)configContainer.colliderID];
							vigCollider.GetReader();
						}
						this.FUN_4DF74(param3.position, (int)GameManager.DAT_63FE4[(int)(num - 33792u)], vigCollider);
					}
				}
				else
				{
					num2 = num - 34048u;
					if (num2 < 21u)
					{
						if (num < 34058u)
						{
							this.FUN_4E56C(param3, (int)GameManager.DAT_6405C[(int)num2]);
						}
						else
						{
							this.FUN_4E8C8(param3.position, GameManager.DAT_6405C[(int)num2]);
						}
					}
					else if (num - 34560u < 21u)
					{
						this.FUN_4E128(param3.position, (ushort)GameManager.DAT_64084[(int)(num - 34560u)], 100);
					}
					else if (num - 34816u < 8u)
					{
						UIManager.instance.FUN_4E414(param3.position, GameManager.DAT_640AC[(int)(num - 34816u)]);
					}
				}
			}
		}
		else if (num2 == 14u)
		{
			configContainer.flag = ((ushort)(flag & 4095));
			Particle5 particle = param1.ini.FUN_2C17C((ushort)(param2 & ushort.MaxValue), typeof(Particle5), 0u) as Particle5;
			ConfigContainer configContainer2 = configContainer;
			configContainer2.flag |= 57344;
			particle.type = 7;
			particle.flags |= 16777344u;
			particle.vTransform = param3;
			particle.vr.y = 12;
			particle.FUN_2D1DC();
			particle.FUN_305FC();
		}
		if (configContainer.next != 65535)
		{
			param1.FUN_4D498(configContainer.next, param3, 0);
		}
	}

	public Ballistic FUN_4DD54(VigObject param1, Vector3Int param2, ushort param3)
	{
		Ballistic ballistic = this.xobfList[19].ini.FUN_2C17C(param3, typeof(Ballistic), 8u) as Ballistic;
		ballistic.type = 7;
		ballistic.flags = 48u;
		ballistic.vTransform = GameManager.FUN_2A39C();
		ballistic.vTransform.position = param2;
		VigObject vigObject = ballistic.child2;
		while (vigObject != null)
		{
			vigObject.flags = 16u;
			vigObject = vigObject.child;
		}
		ballistic.FUN_30BF0();
		Utilities.FUN_2CC9C(param1, ballistic);
		Utilities.ParentChildren(ballistic, ballistic);
		ballistic.transform.parent = param1.transform;
		return ballistic;
	}

	public void FUN_4DF74(Vector3Int param1, int param2, VigCollider param3)
	{
		Particle1 particle = this.FUN_4DE54(param1, (ushort)param2);
		if (param3 != null && param3.reader.ReadUInt16(0) == 1)
		{
			VigCollider vCollider = particle.vCollider;
			if (vCollider != null && vCollider.reader.ReadUInt16(0) == 1)
			{
				int num = (param3.reader.ReadInt32(16) - param3.reader.ReadInt32(4)) * 4096 / (vCollider.reader.ReadInt32(16) - vCollider.reader.ReadInt32(4));
				int num2 = 32767;
				if (num < 32767)
				{
					num2 = num;
				}
				Vector3Int sv = new Vector3Int(num2, num2, num2);
				Utilities.FUN_245AC(ref particle.vTransform.rotation, sv);
				particle.vTransform.padding = (short)num2;
			}
		}
	}

	public Particle2 FUN_4E128(Vector3Int param1, ushort param2, int param3)
	{
		Particle2 particle = this.xobfList[19].ini.FUN_2C17C(param2, typeof(Particle2), 8u) as Particle2;
		Utilities.ParentChildren(particle, particle);
		particle.type = 8;
		uint flags;
		if (param3 == 0)
		{
			flags = (particle.flags | 804u);
		}
		else
		{
			flags = (particle.flags | 772u);
		}
		particle.flags = flags;
		particle.screen = param1;
		particle.maxHalfHealth = (ushort)(param3 / 12);
		particle.FUN_3066C();
		BufferedBinaryReader reader = particle.vCollider.reader;
		particle.DAT_58 = reader.ReadInt32(16);
		return particle;
	}

	public Particle3 FUN_4E56C(VigTransform param1, int param2)
	{
		Particle3 particle = new GameObject().AddComponent<Particle3>();
		VigConfig ini = this.xobfList[19].ini;
		particle.flags |= 160u;
		particle.screen = param1.position;
		particle.DAT_58 = 65536;
		particle.ApplyTransformation();
		Utilities.SetRotMatrix(param1.rotation);
		ushort num = ini.configContainers[param2].next;
		for (uint num2 = (uint)num; num2 != 65535u; num2 = (uint)num)
		{
			VigObject vigObject = this.xobfList[19].ini.FUN_2C17C((ushort)num2, typeof(VigObject), 0u);
			Vector3Int vector3Int = Utilities.FUN_23F7C(vigObject.screen);
			vigObject.physics1.Z = vector3Int.x;
			vigObject.physics1.W = vector3Int.y;
			vigObject.physics2.X = vector3Int.z;
			int num3 = vigObject.physics1.Z;
			if (num3 < 0)
			{
				num3 += 3;
			}
			int num4 = vigObject.physics1.W;
			vigObject.physics1.Z = num3 >> 2;
			if (num4 < 0)
			{
				num4 += 3;
			}
			num3 = vigObject.physics2.X;
			vigObject.physics1.W = num4 >> 2;
			if (num3 < 0)
			{
				num3 += 3;
			}
			vigObject.physics2.X = num3 >> 2;
			num = (ushort)GameManager.FUN_2AC5C();
			vigObject.physics1.M0 = (short)(num & 31);
			num = (ushort)GameManager.FUN_2AC5C();
			vigObject.physics1.M1 = (short)(num & 31);
			num = (ushort)GameManager.FUN_2AC5C();
			vigObject.physics1.M2 = (short)(num & 31);
			vigObject.screen = new Vector3Int(0, 0, 0);
			vigObject.ApplyTransformation();
			num3 = (int)GameManager.FUN_2AC5C();
			vigObject.physics2.Y = (num3 * 30 >> 15) + 30;
			Utilities.FUN_2CC48(particle, vigObject);
			vigObject.transform.parent = particle.transform;
			num = this.xobfList[19].ini.configContainers[(int)num2].previous;
		}
		particle.FUN_3066C();
		return particle;
	}

	public Particle4 FUN_4E8C8(Vector3Int param1, short param2)
	{
		Particle4 particle = new GameObject().AddComponent<Particle4>();
		particle.flags = 164u;
		particle.DAT_1A = param2;
		particle.screen = param1;
		particle.FUN_3066C();
		return particle;
	}

	public Particle9 FUN_4EAE8(Vector3Int param1, Vector3Int param2, short param3)
	{
		Particle9 particle = new GameObject().AddComponent<Particle9>();
		particle.type = 8;
		particle.flags = 164u;
		particle.DAT_1A = param3;
		particle.screen = param1;
		particle.maxHalfHealth = 4096;
		particle.FUN_3066C();
		particle.vTransform.rotation = Utilities.FUN_2A5EC(param2);
		return particle;
	}

	public JUNC_DB FUN_51B74(int param1)
	{
		int num = 0;
		if (0 < this.DAT_1184)
		{
			JUNC_DB junc_DB;
			for (;;)
			{
				junc_DB = this.juncList[num];
				if ((int)junc_DB.DAT_12 == param1 && (junc_DB.DAT_10 & 64) != 0)
				{
					break;
				}
				num++;
				if (num >= this.DAT_1184)
				{
					goto IL_3B;
				}
			}
			return junc_DB;
		}
		IL_3B:
		return null;
	}

	public RSEG_DB FUN_518DC(Vector3Int param1, int param2)
	{
		int num = int.MaxValue;
		int num2 = 0;
		RSEG_DB result = null;
		List<JUNC_DB> list = this.juncList;
		if (0 < this.DAT_1184)
		{
			do
			{
				JUNC_DB junc_DB = list[num2];
				int num3 = 0;
				if (junc_DB.DAT_11 != 0)
				{
					do
					{
						RSEG_DB rseg_DB = junc_DB.DAT_1C[num3];
						if (rseg_DB.DAT_00[0] == junc_DB && (param2 == -1 || (int)((short)rseg_DB.DAT_08) == param2))
						{
							int num4 = (rseg_DB.DAT_00[1].DAT_00.x < junc_DB.DAT_00.x) ? 1 : 0;
							int num5 = param1.x - rseg_DB.DAT_00[1 - num4].DAT_00.x;
							int num6 = (rseg_DB.DAT_00[1].DAT_00.z < junc_DB.DAT_00.z) ? 1 : 0;
							int num7 = 0;
							if (0 < num5)
							{
								num7 = num5;
							}
							int num8 = param1.x - rseg_DB.DAT_00[num4].DAT_00.x;
							num5 = 0;
							if (num8 < 0)
							{
								num5 = num8;
							}
							int num9 = param1.z - rseg_DB.DAT_00[1 - num6].DAT_00.z;
							num8 = 0;
							if (0 < num9)
							{
								num8 = num9;
							}
							int num10 = param1.z - rseg_DB.DAT_00[num6].DAT_00.z;
							num9 = 0;
							if (num10 < 0)
							{
								num9 = num10;
							}
							num7 = num7 - num5 + (num8 - num9);
							if (num7 < num)
							{
								num = num7;
								result = rseg_DB;
							}
						}
						num3++;
					}
					while (num3 < (int)junc_DB.DAT_11);
				}
				num2++;
			}
			while (num2 < this.DAT_1184);
		}
		return result;
	}

	private void FUN_278C(BSP param1, VigTuple param2)
	{
		int dat_ = param1.DAT_00;
		BSP param3;
		if (dat_ == 1)
		{
			if (param2.vObject.screen.x <= param1.DAT_04)
			{
				param3 = param1.DAT_08;
				goto IL_69;
			}
		}
		else
		{
			if (dat_ == 0)
			{
				param1.LDAT_04.Add(param2);
				return;
			}
			if (dat_ != 2)
			{
				return;
			}
			if (param2.vObject.screen.z <= param1.DAT_04)
			{
				param3 = param1.DAT_08;
				goto IL_69;
			}
		}
		param3 = param1.DAT_0C;
		IL_69:
		this.FUN_278C(param3, param2);
	}

	private BSP FUN_284C(int param1)
	{
		BSP bsp = GameManager.instance.bspTree;
		if (0 < param1)
		{
			param1 <<= 1;
			while (0 < param1)
			{
				param1 <<= 1;
			}
		}
		param1 <<= 1;
		while (bsp.DAT_00 != 0)
		{
			if (param1 < 0)
			{
				bsp = bsp.DAT_0C;
			}
			else
			{
				bsp = bsp.DAT_08;
			}
			param1 <<= 1;
		}
		return bsp;
	}

	private uint FUN_3630(VigObject param1, Vector3Int param2, Vector3Int param3)
	{
		Vector3Int v = new Vector3Int((int)param1.vTransform.rotation.V01, (int)param1.vTransform.rotation.V11, (int)param1.vTransform.rotation.V21);
		int num = Utilities.FUN_29C5C(param3, v);
		uint num2 = 0u;
		if (num < 0)
		{
			uint num3 = (uint)((ushort)GameManager.DAT_65C90[(int)((param1.physics1.M7 & 4095) * 2 + 1)]);
			ushort num4 = (ushort)GameManager.DAT_65C90[(int)((param1.physics1.M6 & 4095) * 2 + 1)];
			Vector3Int vector3Int = new Vector3Int(param2.x - param1.screen.x, param2.y - param1.screen.y, param2.z - param1.screen.z);
			num2 = (uint)Utilities.FUN_29E84(vector3Int);
			Vector3Int v2;
			Utilities.FUN_29FC8(vector3Int, out v2);
			int num5 = Utilities.FUN_29C5C(v2, v);
			if (num5 < 0)
			{
				num5 += 4095;
			}
			uint z = (uint)param1.physics1.Z;
			if (num2 < z)
			{
				int num6 = -num;
				if (num3 < (uint)(num5 >> 12))
				{
					if (0 < num)
					{
						num6 += 4095;
					}
					num2 = (z - num2) / (z - (uint)param1.physics1.Y >> 12);
					if (4096u < num2)
					{
						num2 = 4096u;
					}
					num = (num6 >> 12) * (int)num2;
					if (num < 0)
					{
						num += 4095;
					}
					num5 = (int)(((ulong)num3 - (ulong)((long)(num5 >> 12))) * 4096UL) / (int)(num3 - (uint)num4);
					if (4096 < num5)
					{
						num5 = 4096;
					}
					num5 = (num >> 12) * num5;
					if (num5 < 0)
					{
						num5 += 4095;
					}
					num = (num5 >> 12) * (int)((ushort)param1.physics2.M0);
					if (num < 0)
					{
						num += 4095;
					}
					num2 = (uint)(num >> 12 & 65535);
				}
				else
				{
					num2 = 0u;
				}
			}
			else
			{
				num2 = 0u;
			}
		}
		return num2;
	}

	private void FUN_3828(MemoryStream param1, MemoryStream param2, MemoryStream param3, MemoryStream param4)
	{
		Vector3Int param5;
		using (BinaryReader binaryReader = new BinaryReader(param3, Encoding.Default, true))
		{
			param5 = Utilities.FUN_23F58(new Vector3Int((int)binaryReader.ReadInt16(0), (int)binaryReader.ReadInt16(2), (int)binaryReader.ReadInt16(4)));
		}
		Vector3Int vector3Int;
		using (BinaryReader binaryReader2 = new BinaryReader(param4, Encoding.Default, true))
		{
			vector3Int = Utilities.FUN_23EA0(new Vector3Int((int)binaryReader2.ReadInt16(0), (int)binaryReader2.ReadInt16(2), (int)binaryReader2.ReadInt16(4)));
		}
		Color32 color;
		using (BinaryReader binaryReader3 = new BinaryReader(param2, Encoding.Default, true))
		{
			color = Utilities.NormalColorCol(vector3Int, new Color32(binaryReader3.ReadByte(0), binaryReader3.ReadByte(1), binaryReader3.ReadByte(2), binaryReader3.ReadByte(3)));
		}
		uint num = (uint)color.r;
		uint num2 = (uint)color.g;
		uint num3 = (uint)color.b;
		if (this.levelObjs != null)
		{
			for (int i = 0; i < this.levelObjs.Count; i++)
			{
				VigObject vObject = this.levelObjs[i].vObject;
				uint num4 = this.FUN_3630(vObject, param5, vector3Int);
				num4 &= 65535u;
				if (num4 != 0u)
				{
					int num5 = (int)(num4 * (uint)((byte)vObject.physics1.M0));
					if (num5 < 0)
					{
						num5 += 4095;
					}
					num += (uint)(num5 >> 12);
					int num6 = (int)(num4 * (uint)((byte)(vObject.physics1.M0 >> 8)));
					if (num6 < 0)
					{
						num6 += 4095;
					}
					num2 += (uint)(num6 >> 12);
					int num7 = (int)(num4 * (uint)((byte)vObject.physics1.M1));
					if (num7 < 0)
					{
						num7 += 4095;
					}
					num3 += (uint)(num7 >> 12);
				}
			}
		}
		using (BinaryWriter binaryWriter = new BinaryWriter(param1, Encoding.Default, true))
		{
			uint num4 = 255u;
			if (num < 255u)
			{
				num4 = num;
			}
			binaryWriter.Write((byte)num4);
			num = 255u;
			if (num2 < 255u)
			{
				num = num2;
			}
			binaryWriter.Write((byte)num);
			num = 255u;
			if (num3 < 255u)
			{
				num = num3;
			}
			binaryWriter.Write((byte)num);
		}
	}

	private void FUN_3C8C(VigObject param1, VigTransform param2)
	{
		do
		{
			VigTransform vigTransform = Utilities.CompMatrixLV(param2, param1.vTransform);
			Utilities.FUN_246BC(vigTransform);
			VigMesh vigMesh = param1.vMesh;
			DELEGATE_79A0 param3 = new DELEGATE_79A0(this.FUN_3828);
			if (vigMesh != null && (vigMesh.DAT_00 & 1) != 0)
			{
				vigMesh.FUN_39A8(param3);
				vigMesh.Initialize();
				VigMesh vigMesh2 = vigMesh;
				vigMesh2.DAT_00 &= 254;
				VigMesh vigMesh3 = vigMesh;
				vigMesh3.DAT_00 |= 4;
			}
			vigMesh = param1.vLOD;
			if (vigMesh != null && (vigMesh.DAT_00 & 1) != 0)
			{
				vigMesh.FUN_39A8(new DELEGATE_79A0(this.FUN_3828));
				vigMesh.Initialize();
				VigMesh vigMesh4 = vigMesh;
				vigMesh4.DAT_00 &= 254;
				VigMesh vigMesh5 = vigMesh;
				vigMesh5.DAT_00 |= 4;
			}
			if (param1.child2 != null)
			{
				this.FUN_3C8C(param1.child2, vigTransform);
			}
			param1 = param1.child;
		}
		while (param1 != null);
	}

	public void FUN_3D94(Vehicle param1)
	{
		param1.FUN_3CCD4(true, false);
		VigCamera vigCamera = GameManager.instance.FUN_4B914(param1, 256, this.defaultCamera);
		param1.vCamera = vigCamera;
		GameManager.instance.cameraObjects[(int)(~(int)param1.id)] = vigCamera;
		if (param1.vehicle == _VEHICLE.Livingston)
		{
			param1.vCamera.DAT_9C += 102400;
		}
		param1.view = _CAR_VIEW.Far;
		param1.vCamera.FUN_30B78();
		param1.vCamera.FUN_4BC0C();
		param1.FUN_38408();
		param1.FUN_3C9C4((int)(~(int)param1.id));
		if (GameManager.instance.DAT_C6E < 2)
		{
			int num;
			if (GameManager.instance.DAT_C6E == 0)
			{
				num = (int)param1.maxHalfHealth << 1;
			}
			else
			{
				num = param1.maxHalfHealth * 3 >> 1;
			}
			param1.FUN_3C404((ushort)num);
		}
		GameObject gameObject = new GameObject();
		VigObject closeViewer = gameObject.AddComponent<VigObject>();
		gameObject.transform.parent = param1.transform;
		param1.closeViewer = closeViewer;
		ConfigContainer configContainer = param1.FUN_2C5F4(33024);
		if (configContainer == null)
		{
			param1.closeViewer.screen.y = -21845;
			param1.closeViewer.ApplyTransformation();
			Utilities.FUN_2CC48(param1, param1.closeViewer);
		}
		else
		{
			Utilities.FUN_2CA94(param1, configContainer, param1.closeViewer);
		}
		if ((GameManager.instance.DAT_40 & 32768) != 0)
		{
			param1.DAT_A6 = 20480;
		}
		if ((GameManager.instance.DAT_40 & 65536) != 0)
		{
			param1.lightness = 0;
		}
	}

	private void FUN_719C(RSEG_DB param1)
	{
		VigTerrain vigTerrain = UnityEngine.Object.FindObjectOfType<VigTerrain>();
		int[,] array = new int[3, 4];
		array[0, 0] = param1.DAT_00[0].DAT_00.x;
		array[0, 1] = param1.DAT_00[0].DAT_00.y;
		array[0, 2] = param1.DAT_00[0].DAT_00.z;
		array[0, 3] = param1.DAT_00[0].DAT_00.x + param1.DAT_10[0];
		array[1, 1] = param1.DAT_00[0].DAT_00.z + param1.DAT_14[0];
		array[1, 2] = param1.DAT_00[1].DAT_00.x + param1.DAT_10[1];
		array[2, 0] = param1.DAT_00[1].DAT_00.z + param1.DAT_14[1];
		array[2, 1] = param1.DAT_00[1].DAT_00.x;
		array[2, 2] = param1.DAT_00[1].DAT_00.y;
		array[2, 3] = param1.DAT_00[1].DAT_00.z;
		int[,] array2 = array;
		int[,] array3 = new int[3, 4];
		Array.Copy(array2, array3, array2.Length);
		int num = 0;
		for (int i = 0; i < 2; i++)
		{
			JUNC_DB junc_DB = param1.DAT_00[i];
			if (junc_DB.DAT_18 == null)
			{
				if ((junc_DB.DAT_10 & 1) == 0)
				{
					int num2 = 0;
					if (((int)param1.DAT_0C & 2 << i) == 0)
					{
						byte dat_ = junc_DB.DAT_11;
						int num3 = 0;
						if (dat_ != 0)
						{
							int num4 = num3;
							do
							{
								num3 = num4;
								if ((short)junc_DB.DAT_1C[num2].DAT_08 < (short)param1.DAT_08)
								{
									num3 = this.xrtpList[(int)junc_DB.DAT_1C[num2].DAT_0A].DAT_24 / 2;
									if (num3 < num4)
									{
										num3 = num4;
									}
								}
								num2++;
								num4 = num3;
							}
							while (num2 < (int)dat_);
						}
						if (num3 != 0)
						{
							this.FUN_6604(array3, i, num3);
						}
					}
				}
			}
			else
			{
				VigConfig ini = junc_DB.DAT_0C.ini;
				array2[1, 1] = 0;
				array2[1, 0] = param1.DAT_10[i];
				array2[1, 3] = 0;
				array2[1, 2] = param1.DAT_14[i];
				array2[0, 0] = param1.DAT_10[i];
				array2[0, 1] = 0;
				array2[0, 2] = param1.DAT_14[i];
				array2[0, 3] = 0;
				int num5 = 0;
				ushort num6 = ini.configContainers[(int)junc_DB.DAT_14].next;
				int num2 = (int)((junc_DB.DAT_16 & 4095) * 2);
				int num4 = (int)GameManager.DAT_65C90[num2 + 1];
				int num3 = (int)GameManager.DAT_65C90[num2];
				while (num6 != 65535)
				{
					ConfigContainer configContainer = ini.configContainers[(int)num6];
					int[,] array4 = new int[4, 4];
					array4[0, 0] = array2[0, 0];
					array4[0, 1] = array2[0, 1];
					array4[0, 2] = array2[0, 2];
					array4[0, 3] = array2[0, 3];
					array4[1, 0] = array2[1, 0];
					array4[1, 1] = array2[1, 1];
					array4[1, 2] = array2[1, 2];
					array4[1, 3] = array2[1, 3];
					array4[2, 0] = array2[2, 0];
					array4[2, 1] = array2[2, 1];
					array4[2, 2] = array2[2, 2];
					array4[2, 3] = array2[2, 3];
					array2 = array4;
					num2 = num4 * configContainer.v3_1.x + num3 * configContainer.v3_1.z;
					if (num2 < 0)
					{
						num2 += 4095;
					}
					array2[2, 0] = num2 >> 12;
					num2 = -num3 * configContainer.v3_1.x + num4 * configContainer.v3_1.z;
					if (num2 < 0)
					{
						num2 += 4095;
					}
					array2[2, 2] = num2 >> 12;
					array2[2, 1] = array2[3, 1];
					array2[2, 3] = array2[3, 3];
					array2[3, 0] = array2[2, 0];
					array2[3, 2] = array2[2, 2];
					Vector2Int vector2Int = Utilities.FUN_2ACD0(new Vector3Int(array2[2, 0], array2[2, 1], array2[2, 2]), new Vector3Int(array2[0, 0], array2[0, 1], array2[0, 2]));
					num2 = Utilities.FUN_29E84(new Vector3Int(array2[2, 0], array2[2, 1], array2[2, 2]));
					int num7 = Utilities.FUN_29E84(new Vector3Int(array2[0, 0], array2[0, 1], array2[0, 2]));
					if (num2 < 0)
					{
						num2 += 4095;
					}
					num7 = (num2 >> 12) * num7;
					long num8 = Utilities.Divdi3(vector2Int.x, vector2Int.y, num7, num7 >> 31);
					if (num5 < (int)num8)
					{
						num5 = (int)num8;
						array2[1, 0] = array2[2, 0];
						array2[1, 1] = array2[2, 1];
						array2[1, 2] = array2[2, 2];
						array2[1, 3] = array2[2, 3];
					}
					num6 = ini.configContainers[(int)num6].previous;
					num2 = num;
					num = num2;
				}
				array3[num, i] = junc_DB.DAT_00.x + array2[1, 0];
				array3[num, 2 + i] = junc_DB.DAT_00.z + array2[1, 2];
				int num9 = vigTerrain.FUN_1B750((uint)array3[num, i], (uint)array3[num, 2 + i]);
				array3[num, 1 + i] = num9;
			}
			num += 2;
		}
		this.FUN_630C(array3, this.xrtpList[(int)param1.DAT_0A], param1.DAT_0C);
	}

	private Junction FUN_50C0(int param1)
	{
		GameObject gameObject = new GameObject("ROAD" + this.counter.ToString().PadLeft(2, '0'));
		Junction junction = gameObject.AddComponent<Junction>();
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		junction.DAT_1C = param1;
		junction.DAT_20 = new List<Vector3Int>();
		junction.DAT_26 = new List<short>();
		junction.DAT_28 = new List<Vector3Int>();
		junction.DAT_2E = new List<short>();
		return junction;
	}

	private void FUN_50F0(XRTP_DB param1)
	{
		int num = param1.DAT_28 >> 8;
		int num2 = param1.DAT_24 >> 8;
		short num3 = (short)Utilities.SquareRoot((long)(num * num + num2 * num2));
		param1.DAT_30 = (short)(num3 - 128);
		param1.DAT_20 = 0;
		param1.DAT_18 = 0;
	}

	private int FUN_57AC(int[] param1)
	{
		int num = 1;
		int num2 = 3;
		int num3 = param1[2];
		int num4 = param1[2];
		int num5 = param1[0];
		int num6 = param1[0];
		int num7;
		int num8;
		int num9;
		int num10;
		do
		{
			num7 = param1[num2];
			num8 = num7;
			if (num5 < num7)
			{
				num8 = num5;
			}
			if (num7 < num6)
			{
				num7 = num6;
			}
			num9 = param1[num2 + 2];
			num10 = num9;
			if (num3 < num9)
			{
				num10 = num3;
			}
			if (num9 < num4)
			{
				num9 = num4;
			}
			num++;
			num2 += 3;
			num3 = num10;
			num4 = num9;
			num5 = num8;
			num6 = num7;
		}
		while (num < 3);
		num3 = num9 - num10;
		if (num9 - num10 < num7 - num8)
		{
			num3 = num7 - num8;
		}
		return num3;
	}

	private Junction FUN_5850(int[,] param1, XRTP_DB param2, ushort param3)
	{
		VigTerrain vigTerrain = UnityEngine.Object.FindObjectOfType<VigTerrain>();
		int num = param1[0, 3] * 3 - param1[0, 0] + param1[1, 2] * -3 + param1[2, 1];
		if (num < 0)
		{
			num += 15;
		}
		int num2 = param1[1, 1] * 3 - param1[0, 2] + param1[2, 0] * -3 + param1[2, 3];
		if (num2 < 0)
		{
			num2 += 15;
		}
		int num3 = param1[0, 0] * 3 + param1[0, 3] * -6 + param1[1, 2] * 3;
		if (num3 < 0)
		{
			num3 += 15;
		}
		int num4 = param1[0, 2] * 3 + param1[1, 1] * -6 + param1[2, 0] * 3;
		if (num4 < 0)
		{
			num4 += 15;
		}
		int num5 = param1[0, 3] * 3 + param1[0, 0] * -3;
		if (num5 < 0)
		{
			num5 += 15;
		}
		num5 >>= 4;
		int num6 = param1[1, 1] * 3 + param1[0, 2] * -3;
		if (num6 < 0)
		{
			num6 += 15;
		}
		num6 >>= 4;
		int num7 = param1[0, 0];
		int num8 = param1[0, 2];
		uint num9 = (uint)((num >> 4) * 3);
		uint num10 = (uint)((num2 >> 4) * 3);
		int num11 = (num3 >> 4) * 2;
		int num12 = (num4 >> 4) * 2;
		Vector3Int vector3Int = new Vector3Int((int)((short)num7), num7 >> 16, num8);
		int num13 = 0;
		if ((param3 & 1) != 0)
		{
			vector3Int = vigTerrain.FUN_1BB50(param1[0, 0], param1[0, 1]);
			vector3Int = Utilities.VectorNormal(vector3Int);
		}
		int num14 = 0;
		int num15 = 0;
		int num16;
		do
		{
			num16 = num14 * num14;
			if (num16 < 0)
			{
				num16 += 4095;
			}
			int num17 = (int)(num9 * (uint)(num16 >> 12) + (uint)(num11 * num14));
			if (num17 < 0)
			{
				num17 += 4095;
			}
			num17 = (num17 >> 12) + num5;
			if (num17 < 0)
			{
				num17 += 255;
			}
			num16 = (int)(num10 * (uint)(num16 >> 12) + (uint)(num12 * num14));
			if (num16 < 0)
			{
				num16 += 4095;
			}
			num16 = (num16 >> 12) + num6;
			if (num16 < 0)
			{
				num16 += 255;
			}
			num16 = (int)Utilities.SquareRoot((long)((num17 >> 8) * (num17 >> 8) + (num16 >> 8) * (num16 >> 8)));
			num15++;
			num14 += param2.DAT_28 / num16;
		}
		while (num14 < 4096);
		int num18 = 0;
		param2.DAT_14 += num15 * 2;
		Junction junction = this.FUN_50C0(num15);
		num16 = (param1[0, 0] + param1[2, 1]) / 2;
		int num19 = (param1[0, 2] + param1[2, 3]) / 2;
		uint y = (uint)vigTerrain.FUN_1B750((uint)num16, (uint)num19);
		junction.pos = new Vector3Int(num16, (int)y, num19);
		junction.xrtp = param2;
		junction.GetComponent<MeshRenderer>().materials = junction.xrtp.timFarList.ToArray();
		num16 = 0;
		if (-1 < num15)
		{
			int num20 = 0;
			int num21 = 0;
			int num22 = 0;
			do
			{
				int num17 = num16 * num16;
				if (num17 < 0)
				{
					num17 += 4095;
				}
				num17 >>= 12;
				num19 = num17 * num16;
				if (num19 < 0)
				{
					num19 += 4095;
				}
				int num23 = (num >> 4) * (num19 >> 12) + (num3 >> 4) * num17 + num5 * num16;
				if (num23 < 0)
				{
					num23 += 255;
				}
				int num24 = (num2 >> 4) * (num19 >> 12) + (num4 >> 4) * num17 + num6 * num16;
				num19 = (num23 >> 8) + num7;
				if (num24 < 0)
				{
					num24 += 255;
				}
				num23 = (int)(num9 * (uint)num17 + (uint)(num11 * num16));
				num24 = (num24 >> 8) + num8;
				if (num23 < 0)
				{
					num23 += 4095;
				}
				num23 = (num23 >> 12) + num5;
				if (num23 < 0)
				{
					num23 += 255;
				}
				num17 = (int)(num10 * (uint)num17 + (uint)(num12 * num16));
				num23 >>= 8;
				if (num17 < 0)
				{
					num17 += 4095;
				}
				num17 = (num17 >> 12) + num6;
				if (num17 < 0)
				{
					num17 += 255;
				}
				num17 >>= 8;
				int num25 = (int)Utilities.SquareRoot((long)(num23 * num23 + num17 * num17));
				int num26 = num17 * param2.DAT_24 / 2 / num25;
				int num27 = num23 * param2.DAT_24 / 2 / num25;
				num17 = num19 - num26;
				num19 += num26;
				num23 = num24 + num27;
				num24 -= num27;
				if ((param3 & 1) == 0)
				{
					Vector2Int vector2Int = default(Vector2Int);
					Vector2Int vector2Int2 = default(Vector2Int);
					vector2Int.x = num17 - junction.pos.x >> 8;
					num26 = vigTerrain.FUN_1B750((uint)num17, (uint)num23);
					vector2Int.y = num26 - junction.pos.y >> 8;
					num26 = num23 - junction.pos.z;
					vector2Int2.x = num26 >> 8;
					if (num17 < 0)
					{
						num17 += 65535;
					}
					if (num23 < 0)
					{
						num23 += 65535;
					}
					vector2Int2.y = (int)((int)((uint)vigTerrain.vertices[(int)(vigTerrain.chunks[(int)((((uint)(num23 >> 16) >> 6) * 4u + ((uint)(num17 >> 16) >> 6) * 128u) / 4u)] * 4096) + ((num23 >> 16 & 63) * 2 + (num17 >> 16 & 63) * 128) / 2] >> 11) << 2);
					junction.DAT_20.Add(new Vector3Int(vector2Int.x, vector2Int.y, vector2Int2.x));
					junction.DAT_26.Add((short)vector2Int2.y);
					vector2Int.x = num19 - junction.pos.x >> 8;
					num17 = vigTerrain.FUN_1B750((uint)num19, (uint)num24);
					vector2Int.y = num17 - junction.pos.y >> 8;
					num17 = num24 - junction.pos.z;
					if (num19 < 0)
					{
						num19 += 65535;
					}
					if (num24 < 0)
					{
						num24 += 65535;
					}
					vector2Int2.x = num17 >> 8;
					vector2Int2.y = (int)((int)((uint)vigTerrain.vertices[(int)(vigTerrain.chunks[(int)((((uint)(num24 >> 16) >> 6) * 4u + ((uint)(num19 >> 16) >> 6) * 128u) / 4u)] * 4096) + ((num24 >> 16 & 63) * 2 + (num19 >> 16 & 63) * 128) / 2] >> 11) << 2);
					junction.DAT_28.Add(new Vector3Int(vector2Int.x, vector2Int.y, vector2Int2.x));
					junction.DAT_2E.Add((short)vector2Int2.y);
				}
				else
				{
					long num28 = (long)(4096 - num16) * (long)param1[0, 1];
					uint num29 = (uint)((long)num16 * (long)param1[2, 2]);
					int num30 = (int)((ulong)((long)num16 * (long)param1[2, 2]) >> 32);
					uint num31 = (uint)((long)((int)num28) + (long)((ulong)num29));
					num27 = (int)((ulong)num28 >> 32) + num30 + ((num31 < num29) ? 1 : 0);
					num26 = this.FUN_9C10(num31, num27, 0u, 0);
					if (num26 < 1)
					{
						num31 += 4095u;
						num27 += ((num31 < 4095u) ? 1 : 0);
					}
					num31 = (num31 >> 12 | (uint)((uint)num27 << 20));
					Vector2Int vector2Int = default(Vector2Int);
					Vector2Int vector2Int2 = default(Vector2Int);
					vector2Int.x = num17 - junction.pos.x >> 8;
					vector2Int.y = (int)(num31 - (uint)junction.pos.y) >> 8;
					vector2Int2.x = num23 - junction.pos.z >> 8;
					num23 = Utilities.FUN_29C5C(vector3Int, this.DAT_10F8);
					num17 = 0;
					if (0 < num23)
					{
						num17 = num23;
					}
					if (num17 < 0)
					{
						num17 += 131071;
					}
					num23 = (num17 >> 17) + 32;
					num17 = 128;
					if (num23 < 128)
					{
						num17 = num23;
					}
					vector2Int2.y = num17;
					junction.DAT_20.Add(new Vector3Int(vector2Int.x, vector2Int.y, vector2Int2.x));
					junction.DAT_26.Add((short)vector2Int2.y);
					vector2Int.x = num19 - junction.pos.x >> 8;
					vector2Int.y = (int)(num31 - (uint)junction.pos.y) >> 8;
					vector2Int2.x = num24 - junction.pos.z >> 8;
					num19 = Utilities.FUN_29C5C(vector3Int, this.DAT_10F8);
					num17 = 0;
					if (0 < num19)
					{
						num17 = num19;
					}
					if (num17 < 0)
					{
						num17 += 131071;
					}
					num19 = (num17 >> 17) + 32;
					num17 = 128;
					if (num19 < 128)
					{
						num17 = num19;
					}
					vector2Int2.y = num17;
					junction.DAT_28.Add(new Vector3Int(vector2Int.x, vector2Int.y, vector2Int2.x));
					junction.DAT_2E.Add((short)vector2Int2.y);
				}
				num17 = Utilities.FUN_29DDC(junction.DAT_20[num20]);
				if (num17 < num13)
				{
					num17 = num13;
				}
				num13 = Utilities.FUN_29DDC(junction.DAT_28[num20]);
				if (num13 < num17)
				{
					num13 = num17;
				}
				if (num18 == num15 - 1)
				{
					num16 = 4096;
				}
				else
				{
					num16 += param2.DAT_28 / num25;
				}
				num20++;
				num21++;
				num22++;
				num18++;
			}
			while (num18 <= num15);
		}
		num = (int)Utilities.SquareRoot((long)num13);
		junction.DAT_18 = num << 8;
		return junction;
	}

	private void FUN_630C(int[,] param1, XRTP_DB param2, ushort param3)
	{
		int num = this.FUN_57AC(new int[]
		{
			param1[0, 0],
			param1[0, 1],
			param1[0, 2],
			param1[0, 3],
			param1[1, 0],
			param1[1, 1],
			param1[1, 2],
			param1[1, 3],
			param1[2, 0],
			param1[2, 1],
			param1[2, 2],
			param1[2, 3]
		});
		if (num < 1048576)
		{
			Junction item = this.FUN_5850(param1, param2, param3);
			this.counter++;
			this.roadList.Add(item);
			return;
		}
		num = (param1[0, 3] + param1[1, 2]) / 2;
		int num2 = (param1[1, 1] + param1[2, 0]) / 2;
		Vector3Int vector3Int = new Vector3Int(param1[0, 0], param1[0, 1], param1[0, 2]);
		Vector3Int vector3Int2 = new Vector3Int(param1[2, 1], param1[2, 2], param1[2, 3]);
		Vector3Int vector3Int3 = new Vector3Int((param1[0, 0] + param1[0, 3]) / 2, 0, (param1[0, 2] + param1[1, 1]) / 2);
		Vector3Int vector3Int4 = new Vector3Int((vector3Int3.x + num) / 2, 0, (vector3Int3.z + num2) / 2);
		Vector3Int vector3Int5 = new Vector3Int((param1[1, 2] + param1[2, 1]) / 2, 0, (param1[2, 0] + param1[2, 3]) / 2);
		Vector3Int vector3Int6 = new Vector3Int((vector3Int5.x + num) / 2, 0, (vector3Int5.z + num2) / 2);
		Vector3Int vector3Int7 = new Vector3Int((vector3Int4.x + vector3Int6.x) / 2, (param1[0, 1] + param1[2, 2]) / 2, (vector3Int4.z + vector3Int6.z) / 2);
		Vector3Int vector3Int8 = vector3Int7;
		int[,] array = new int[3, 4];
		array[0, 0] = vector3Int.x;
		array[0, 1] = vector3Int.y;
		array[0, 2] = vector3Int.z;
		array[0, 3] = vector3Int3.x;
		array[1, 0] = vector3Int3.y;
		array[1, 1] = vector3Int3.z;
		array[1, 2] = vector3Int4.x;
		array[1, 3] = vector3Int4.y;
		array[2, 0] = vector3Int4.z;
		array[2, 1] = vector3Int7.x;
		array[2, 2] = vector3Int7.y;
		array[2, 3] = vector3Int7.z;
		this.FUN_630C(array, param2, param3);
		int[,] array2 = new int[3, 4];
		array2[0, 0] = vector3Int8.x;
		array2[0, 1] = vector3Int8.y;
		array2[0, 2] = vector3Int8.z;
		array2[0, 3] = vector3Int6.x;
		array2[1, 0] = vector3Int6.y;
		array2[1, 1] = vector3Int6.z;
		array2[1, 2] = vector3Int5.x;
		array2[1, 3] = vector3Int5.y;
		array2[2, 0] = vector3Int5.z;
		array2[2, 1] = vector3Int2.x;
		array2[2, 2] = vector3Int2.y;
		array2[2, 3] = vector3Int2.z;
		this.FUN_630C(array2, param2, param3);
	}

	private void FUN_6604(int[,] param1, int param2, int param3)
	{
		uint[] array = new uint[32];
		uint num = 0u;
		uint num2 = 32768u;
		int num3 = 0;
		uint num4 = 65536u;
		uint num5;
		do
		{
			num5 = (uint)param1[0, 3];
			uint num6 = 65536u - num2;
			int num7 = -((65536u < num2) ? 1 : 0) - num3;
			uint num8 = (uint)param1[1, 2];
			uint num9 = (uint)((ulong)num2 * (ulong)num8);
			uint num10 = (uint)((int)((ulong)num6 * (ulong)num5) + (int)num9);
			array[26] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)num6 * (ulong)num5 >> 32) + (int)(num6 * (uint)((int)num5 >> 31)) + (int)(num5 * (uint)num7) + (int)((ulong)num2 * (ulong)num8 >> 32) + (int)(num2 * (uint)((int)num8 >> 31)) + (int)(num8 * (uint)num3) + ((num10 < num9) ? 1 : 0), 65536, 0);
			num5 = (uint)param1[1, 1];
			num8 = (uint)param1[2, 0];
			num9 = (uint)((ulong)num2 * (ulong)num8);
			num10 = (uint)((int)((ulong)num6 * (ulong)num5) + (int)num9);
			array[25] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)num6 * (ulong)num5 >> 32) + (int)(num6 * (uint)((int)num5 >> 31)) + (int)(num5 * (uint)num7) + (int)((ulong)num2 * (ulong)num8 >> 32) + (int)(num2 * (uint)((int)num8 >> 31)) + (int)(num8 * (uint)num3) + ((num10 < num9) ? 1 : 0), 65536, 0);
			array[24] = array[26];
			array[0] = (uint)param1[0, 0];
			array[1] = (uint)param1[0, 1];
			array[2] = (uint)param1[0, 2];
			array[21] = (uint)param1[2, 1];
			array[22] = (uint)param1[2, 2];
			array[23] = (uint)param1[2, 3];
			num5 = (uint)param1[0, 0];
			num8 = (uint)param1[0, 3];
			num9 = (uint)((ulong)num2 * (ulong)num8);
			num10 = (uint)((int)((ulong)num6 * (ulong)num5) + (int)num9);
			array[27] = array[25];
			array[28] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)num6 * (ulong)num5 >> 32) + (int)(num6 * (uint)((int)num5 >> 31)) + (int)(num5 * (uint)num7) + (int)((ulong)num2 * (ulong)num8 >> 32) + (int)(num2 * (uint)((int)num8 >> 31)) + (int)(num8 * (uint)num3) + ((num10 < num9) ? 1 : 0), 65536, 0);
			array[29] = 0u;
			num5 = (uint)param1[0, 2];
			num8 = (uint)param1[1, 1];
			num9 = (uint)((ulong)num2 * (ulong)num8);
			num10 = (uint)((int)((ulong)num6 * (ulong)num5) + (int)num9);
			array[5] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)num6 * (ulong)num5 >> 32) + (int)(num6 * (uint)((int)num5 >> 31)) + (int)(num5 * (uint)num7) + (int)((ulong)num2 * (ulong)num8 >> 32) + (int)(num2 * (uint)((int)num8 >> 31)) + (int)(num8 * (uint)num3) + ((num10 < num9) ? 1 : 0), 65536, 0);
			array[3] = array[28];
			array[4] = array[29];
			num10 = (uint)((ulong)num2 * (ulong)array[24]);
			num5 = (uint)((int)((ulong)num6 * (ulong)array[28]) + (int)num10);
			array[30] = array[5];
			array[26] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)num6 * (ulong)array[28] >> 32) + (int)(num6 * (uint)((int)array[28] >> 31)) + (int)(array[28] * (uint)num7) + (int)((ulong)num2 * (ulong)array[24] >> 32) + (int)(num2 * (uint)((int)array[24] >> 31)) + (int)(array[24] * (uint)num3) + ((num5 < num10) ? 1 : 0), 65536, 0);
			num10 = (uint)((ulong)num2 * (ulong)array[25]);
			array[27] = 0u;
			num5 = (uint)((int)((ulong)num6 * (ulong)array[5]) + (int)num10);
			array[8] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)num6 * (ulong)array[5] >> 32) + (int)(num6 * (uint)((int)array[5] >> 31)) + (int)(array[5] * (uint)num7) + (int)((ulong)num2 * (ulong)array[25] >> 32) + (int)(num2 * (uint)((int)array[25] >> 31)) + (int)(array[25] * (uint)num3) + ((num5 < num10) ? 1 : 0), 65536, 0);
			array[6] = array[26];
			array[7] = array[27];
			num5 = (uint)param1[2, 1];
			num8 = (uint)param1[1, 2];
			num9 = (uint)((ulong)num6 * (ulong)num8);
			num10 = (uint)((int)((ulong)num2 * (ulong)num5) + (int)num9);
			array[28] = array[8];
			array[26] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)num2 * (ulong)num5 >> 32) + (int)(num2 * (uint)((int)num5 >> 31)) + (int)(num5 * (uint)num3) + (int)((ulong)num6 * (ulong)num8 >> 32) + (int)(num6 * (uint)((int)num8 >> 31)) + (int)(num8 * (uint)num7) + ((num10 < num9) ? 1 : 0), 65536, 0);
			array[27] = 0u;
			num5 = (uint)param1[2, 3];
			num8 = (uint)param1[2, 0];
			num9 = (uint)((ulong)num6 * (ulong)num8);
			num10 = (uint)((int)((ulong)num2 * (ulong)num5) + (int)num9);
			array[20] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)num2 * (ulong)num5 >> 32) + (int)(num2 * (uint)((int)num5 >> 31)) + (int)(num5 * (uint)num3) + (int)((ulong)num6 * (ulong)num8 >> 32) + (int)(num6 * (uint)((int)num8 >> 31)) + (int)(num8 * (uint)num7) + ((num10 < num9) ? 1 : 0), 65536, 0);
			array[18] = array[26];
			array[19] = array[27];
			num10 = (uint)((ulong)num6 * (ulong)array[24]);
			num5 = (uint)((int)((ulong)num2 * (ulong)array[26]) + (int)num10);
			array[28] = array[20];
			array[26] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)num2 * (ulong)array[26] >> 32) + (int)(num2 * (uint)((int)array[26] >> 31)) + (int)(array[26] * (uint)num3) + (int)((ulong)num6 * (ulong)array[24] >> 32) + (int)(num6 * (uint)((int)array[24] >> 31)) + (int)(array[24] * (uint)num7) + ((num5 < num10) ? 1 : 0), 65536, 0);
			num10 = (uint)((ulong)num6 * (ulong)array[25]);
			array[27] = 0u;
			num5 = (uint)((int)((ulong)num2 * (ulong)array[20]) + (int)num10);
			array[17] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)num2 * (ulong)array[20] >> 32) + (int)(num2 * (uint)((int)array[20] >> 31)) + (int)(array[20] * (uint)num3) + (int)((ulong)num6 * (ulong)array[25] >> 32) + (int)(num6 * (uint)((int)array[25] >> 31)) + (int)(array[25] * (uint)num7) + ((num5 < num10) ? 1 : 0), 65536, 0);
			array[15] = array[26];
			array[16] = array[27];
			num10 = (uint)((ulong)num2 * (ulong)array[26]);
			num5 = (uint)((int)((ulong)num6 * (ulong)array[6]) + (int)num10);
			array[28] = array[17];
			array[26] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)num6 * (ulong)array[6] >> 32) + (int)(num6 * (uint)((int)array[6] >> 31)) + (int)(array[6] * (uint)num7) + (int)((ulong)num2 * (ulong)array[26] >> 32) + (int)(num2 * (uint)((int)array[26] >> 31)) + (int)(array[26] * (uint)num3) + ((num5 < num10) ? 1 : 0), 65536, 0);
			num5 = (uint)param1[0, 1];
			num8 = (uint)param1[2, 2];
			num9 = (uint)((ulong)num2 * (ulong)num8);
			num10 = (uint)((int)((ulong)num6 * (ulong)num5) + (int)num9);
			array[27] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)num6 * (ulong)num5 >> 32) + (int)(num6 * (uint)((int)num5 >> 31)) + (int)(num5 * (uint)num7) + (int)((ulong)num2 * (ulong)num8 >> 32) + (int)(num2 * (uint)((int)num8 >> 31)) + (int)(num8 * (uint)num3) + ((num10 < num9) ? 1 : 0), 65536, 0);
			num10 = (uint)((ulong)num2 * (ulong)array[17]);
			num5 = (uint)((int)((ulong)num6 * (ulong)array[8]) + (int)num10);
			array[28] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)num6 * (ulong)array[8] >> 32) + (int)(num6 * (uint)((int)array[8] >> 31)) + (int)(array[8] * (uint)num7) + (int)((ulong)num2 * (ulong)array[17] >> 32) + (int)(num2 * (uint)((int)array[17] >> 31)) + (int)(array[17] * (uint)num3) + ((num5 < num10) ? 1 : 0), 65536, 0);
			array[12] = array[26];
			array[13] = array[27];
			array[14] = array[28];
			array[9] = array[26];
			array[10] = array[27];
			array[11] = array[28];
			num5 = num2;
			if (param2 == 0)
			{
				long num11 = (long)(array[26] - (uint)param1[0, 0]) * (long)(array[26] - (uint)param1[0, 0]);
				long num12 = (long)(array[28] - (uint)param1[0, 2]) * (long)(array[28] - (uint)param1[0, 2]);
				uint num13 = (uint)num12;
				int num14 = (int)((ulong)num12 >> 32);
				num7 = (int)((ulong)((long)param3 * (long)param3) >> 32);
				num10 = (uint)((long)((int)num11) + (long)((ulong)num13));
				num3 = (int)((ulong)num11 >> 32) + num14 + ((num10 < num13) ? 1 : 0);
				if (num3 <= num7 && (num3 != num7 || num10 <= (uint)((long)param3 * (long)param3)))
				{
					num5 = num4;
					num = num2;
				}
			}
			else
			{
				long num15 = (long)(array[26] - (uint)param1[2, 1]) * (long)(array[26] - (uint)param1[2, 1]);
				long num16 = (long)(array[28] - (uint)param1[2, 3]) * (long)(array[28] - (uint)param1[2, 3]);
				uint num13 = (uint)num16;
				int num14 = (int)((ulong)num16 >> 32);
				num7 = (int)((ulong)((long)param3 * (long)param3) >> 32);
				num10 = (uint)((long)((int)num15) + (long)((ulong)num13));
				num3 = (int)((ulong)num15 >> 32) + num14 + ((num10 < num13) ? 1 : 0);
				if (num7 < num3 || (num3 == num7 && (uint)((long)param3 * (long)param3) < num10))
				{
					num5 = num4;
					num = num2;
				}
			}
			num3 = (int)(num + num5);
			num2 = (uint)(num3 / 2);
			num3 = num3 - (int)((uint)num3 >> 31) >> 31;
			num4 = num5;
		}
		while (num5 - num >= 2u);
		int i = 0;
		if (param2 == 0)
		{
			i = 12;
			int num17 = 0;
			while (i < 24)
			{
				num4 = array[i + 1];
				num = array[i + 2];
				num2 = array[i + 3];
				param1[num17, 0] = (int)array[i];
				param1[num17, 1] = (int)num4;
				param1[num17, 2] = (int)num;
				param1[num17, 3] = (int)num2;
				i += 4;
				num17++;
			}
			return;
		}
		int num18 = 0;
		while (i < 12)
		{
			num4 = array[i + 1];
			num = array[i + 2];
			num2 = array[i + 3];
			param1[num18, 0] = (int)array[i];
			param1[num18, 1] = (int)num4;
			param1[num18, 2] = (int)num;
			param1[num18, 3] = (int)num2;
			i += 4;
			num18++;
		}
	}

	public static LevelManager instance;

	private static Vector3Int DAT_15F0 = new Vector3Int(0, 4096, 0);

	public string title;

	public string desc;

	public short DAT_63972;

	public short DAT_6397A;

	public short DAT_63982;

	public short DAT_6398A;

	public short DAT_63992;

	public short DAT_6399A;

	public Material defaultMaterial;

	public Camera defaultCamera;

	public VigTerrain terrain;

	public Matrix3x3 DAT_738;

	public ushort[] DAT_C18;

	public Color32 DAT_D98;

	public Color32 DAT_DA4;

	public Color32 DAT_DAC;

	public short DAT_DBA;

	public Color32 DAT_DBC;

	public Material DAT_DC0;

	public Material DAT_DD0;

	public Color32 DAT_DDC;

	public Color32 DAT_DE0;

	public Material[] DAT_DF8;

	public Color32 DAT_E04;

	public Color32 DAT_E08;

	public Material DAT_E48;

	public Material DAT_E58;

	public Vector3Int DAT_10F8;

	public XOBF_DB DAT_1178;

	public int DAT_117C;

	public int DAT_1180;

	public int DAT_1184;

	public int DAT_118C;

	public byte[] bspData;

	public List<OBJ> objData;

	public int aimpSize;

	public ushort[] aimpData;

	public VigObject level;

	public AudioSource music;

	public List<Junction> roadList = new List<Junction>();

	public List<XRTP_DB> xrtpList = new List<XRTP_DB>();

	public List<JUNC_DB> juncList = new List<JUNC_DB>();

	public List<XOBF_DB> xobfList = new List<XOBF_DB>();

	public Navigation ainav;

	public List<VigTuple> levelObjs;

	private int counter;
}
