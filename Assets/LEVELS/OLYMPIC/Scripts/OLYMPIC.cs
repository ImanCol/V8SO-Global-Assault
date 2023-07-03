using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OLYMPIC : VigObject
{
	public static Vector2Int podiumPos = new Vector2Int(59014956, 81966952);

	private static short[] ids = new short[2]
	{
		300,
		301
	};

	public List<VigTuple> DAT_80_2;

	public List<VigTuple> DAT_8C;

	public List<VigTuple> DAT_98;

	public List<VigTuple> DAT_A4;

	public VigObject[] DAT_B0;

	public VigObject[] DAT_B8;

	public ushort DAT_D0;

	public ushort DAT_D2;

	public int DAT_D8;

	public int DAT_DC;

	public int DAT_E0;

	public List<Matrix4x4> pole1M;

	public List<Matrix4x4> pole2M;

	public Mesh pole1;

	public Mesh pole2;

	private Vector3[] newVertices;

	private Vector2[] newUVs;

	private Color32[] newColors;

	private int[] newIndicies;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	private void Awake()
	{
		DAT_80_2 = new List<VigTuple>();
		DAT_8C = new List<VigTuple>();
		newVertices = new Vector3[40];
		newUVs = new Vector2[40];
		newColors = new Color32[40];
		newIndicies = new int[40];
		pole1M = new List<Matrix4x4>();
		pole2M = new List<Matrix4x4>();
		GameObject gameObject = new GameObject();
		pole1 = new Mesh();
		gameObject.AddComponent<MeshFilter>().mesh = pole1;
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LevelManager.instance.defaultMaterial;
		GameObject gameObject2 = new GameObject();
		pole2 = new Mesh();
		gameObject2.AddComponent<MeshFilter>().mesh = pole2;
		gameObject2.AddComponent<MeshRenderer>().sharedMaterial = LevelManager.instance.defaultMaterial;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			short num3 = (short)DAT_D2;
			if (num3 == 0)
			{
				if (((DAT_D0 += 32) & 0x7FFF) == 0)
				{
					int num = 0;
					do
					{
						VigObject vigObject = DAT_B0[num];
						ushort num4 = (ushort)(vigObject.DAT_1A | 4);
						vigObject.flags |= 32u;
						vigObject.DAT_1A = (short)num4;
						if (num4 != 0)
						{
							GameManager.instance.FUN_1FEB8(vigObject.vMesh);
							vigObject.DAT_1A = 4;
							VigMesh vigMesh = vigObject.vMesh = vigObject.vData.FUN_2CB74(vigObject.gameObject, 4u, init: true);
						}
						num++;
					}
					while (num < 2);
					DAT_D2 = 1200;
					arg2 = 1;
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
				}
				if (arg2 == 0)
				{
					return 0u;
				}
				FUN_974(DAT_B0[0], DAT_80_2, DAT_D0, param4: true);
				FUN_974(DAT_B0[1], DAT_80_2, (ushort)((DAT_D0 + 32768) * 65536 >> 16), param4: true);
				uint num5 = GameManager.instance.FUN_1E478(DAT_B0[0].screen);
				uint num6 = GameManager.instance.FUN_1E478(DAT_B0[1].screen);
				GameManager.instance.FUN_1E2C8(DAT_18, num5 + num6);
			}
			else
			{
				DAT_D2 = (ushort)(num3 - 1);
				if (num3 == 1)
				{
					sbyte param3 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E098(param3, DAT_B0[0].vData.sndList, 4, 0u, param5: true);
					DAT_B0[0].flags &= 4294967263u;
					DAT_B0[1].flags &= 4294967263u;
				}
			}
			int num7 = 0;
			if (arg2 != 0)
			{
				int num2 = GameManager.instance.DAT_28 << 5;
				do
				{
					VigObject param4 = DAT_B8[num7];
					num3 = (short)num2;
					num7++;
					num2 += 10922;
					FUN_974(param4, DAT_8C, (ushort)num3, param4: false);
				}
				while (num7 < 6);
				return 0u;
			}
			break;
		}
		case 1:
		{
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.2f;
			GameManager.instance.aspectRatioScale = 240f;
			GameManager.instance.DAT_1000 |= 1;
			LevelManager.instance.FUN_359FC(podiumPos.x, podiumPos.y, 0u);
			FUN_D64(DAT_80_2);
			int num = 0;
			DAT_B0 = new VigObject[2];
			do
			{
				Gondola gondola = Utilities.FUN_31D30(typeof(Gondola), LevelManager.instance.xobfList[42], 4, 0u) as Gondola;
				DAT_B0[num] = gondola;
				VigObject vigObject = (num != 0) ? DAT_80_2[DAT_80_2.Count - 1].vObject : DAT_80_2[0].vObject;
				gondola.vr.y = vigObject.vr.y;
				gondola.FUN_3066C();
				FUN_974(gondola, DAT_80_2, (ushort)(num << 31 >> 16), param4: true);
				num++;
			}
			while (num < 2);
			DAT_D2 = 1200;
			FUN_D64(DAT_8C);
			num = 0;
			DAT_B8 = new VigObject[6];
			do
			{
				DragStick dragStick = Utilities.FUN_31D30(typeof(DragStick), LevelManager.instance.xobfList[42], 8, 0u) as DragStick;
				Utilities.ParentChildren(dragStick, dragStick);
				DAT_B8[num] = dragStick;
				DAT_B8[num].FUN_3066C();
				int num2 = num << 16;
				VigObject param = DAT_B8[num];
				num++;
				FUN_974(param, DAT_8C, (ushort)(num2 / 6 * 65536 >> 16), param4: false);
			}
			while (num < 6);
			flags |= 128u;
			DAT_98 = new List<VigTuple>();
			DAT_A4 = new List<VigTuple>();
			DAT_D8 = 1800;
			DAT_E0 = 3600;
			DAT_DC = 131072;
			VigObject param2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param2);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			goto case 2;
		}
		case 2:
			GameManager.instance.FUN_34B34();
			GameManager.instance.FUN_30CB0(this, 240);
			return 0u;
		case 4:
			FUN_1D0(DAT_98);
			FUN_1D0(DAT_A4);
			GameManager.instance.FUN_3001C(DAT_80_2);
			GameManager.instance.FUN_3001C(DAT_8C);
			break;
		case 17:
			FUN_558(DAT_80_2, pole1M, pole1);
			FUN_558(DAT_8C, pole2M, pole2);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, Vector3Int arg3)
	{
		if (arg2 == 10)
		{
			VigObject vigObject = Utilities.FUN_2CD78(arg1);
			if (vigObject == null)
			{
				vigObject = arg1;
			}
			Vector3Int v = new Vector3Int(0, 0, 0);
			v.y = -4096;
			Vector3Int n = GameManager.instance.terrain.FUN_1B998((uint)arg3.x, (uint)arg3.z);
			if (n.x == 0 && n.z == 0)
			{
				return 0u;
			}
			n = Utilities.VectorNormal(n);
			Vector3Int v2 = Utilities.FUN_2A1E0(n, v);
			v = Utilities.FUN_2A1E0(n, v2);
			v = Utilities.VectorNormal(v);
			vigObject.physics1.X += v.x * 2;
			vigObject.physics1.Y += v.y * 2;
			vigObject.physics1.Z += v.z * 2;
		}
		return 0u;
	}

	public override uint UpdateW(VigObject arg1, int arg2, int arg3)
	{
		if (arg2 == 18)
		{
			GameManager.instance.FUN_327CC(arg1);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 25 && arg2.type == 3 && ids.Contains(arg2.id))
		{
			((Pickup)arg2).cannotReach = true;
		}
		return 0u;
	}

	private static void FUN_1D0(List<VigTuple> param1)
	{
		if (param1 != null)
		{
			for (int i = 0; i < param1.Count; i++)
			{
				VigTuple vigTuple = param1[i];
				UnityEngine.Object.Destroy(vigTuple.vObject.gameObject);
				vigTuple.vObject = null;
			}
		}
		GameManager.instance.FUN_3001C(param1);
	}

	private void FUN_558(List<VigTuple> param1, List<Matrix4x4> param2, Mesh param3)
	{
		int translateFactor = GameManager.instance.translateFactor2;
		int num = 0;
		Vector3 vector = default(Vector3);
		Vector3 vector2 = default(Vector3);
		for (int i = 0; i < param1.Count; i++)
		{
			VigTuple vigTuple = param1[i];
			VigObject vObject = vigTuple.vObject;
			int num2 = vObject.vr.y;
			if (num2 < 0)
			{
				num2 = -num2;
			}
			uint num3 = 32768u;
			if (1024 < num2)
			{
				num3 = 32769u;
			}
			ConfigContainer configContainer = vObject.FUN_2C5F4((ushort)num3);
			num3 = 32768u;
			num2 = vObject.vr.y;
			if (num2 < 0)
			{
				num2 = -num2;
			}
			if (num2 < 1025)
			{
				num3 = 32769u;
			}
			ConfigContainer configContainer2 = vObject.FUN_2C5F4((ushort)num3);
			VigTransform vigTransform = Utilities.CompMatrixLV(GameManager.instance.DAT_F00, vObject.vTransform);
			Utilities.SetRotMatrix(vigTransform.rotation);
			Coprocessor.translationVector._trx = vigTransform.position.x >> 8;
			Coprocessor.translationVector._try = vigTransform.position.y >> 8;
			Coprocessor.translationVector._trz = vigTransform.position.z >> 8;
			Coprocessor.vector0.vx0 = (short)(configContainer.v3_1.x >> 8);
			Coprocessor.vector0.vy0 = (short)(configContainer.v3_1.y >> 8);
			Coprocessor.vector0.vz0 = (short)(configContainer.v3_1.z >> 8);
			Vector3 point = new Vector3(Coprocessor.vector0.vx0, -Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
			point = param2[i].MultiplyPoint3x4(point);
			Coprocessor.ExecuteRTPS(12, lm: false);
			Coprocessor.vector0.vx0 = (short)(configContainer2.v3_1.x >> 8);
			Coprocessor.vector0.vy0 = (short)(configContainer2.v3_1.y >> 8);
			Coprocessor.vector0.vz0 = (short)(configContainer2.v3_1.z >> 8);
			Vector3 point2 = new Vector3(Coprocessor.vector0.vx0, -Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
			point2 = param2[i].MultiplyPoint3x4(point2);
			new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
			Coprocessor.ExecuteRTPS(12, lm: false);
			new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
			if (vigTuple != param1[0])
			{
				newVertices[num] = point;
				newVertices[num + 1] = vector;
				newVertices[num + 2] = point2;
				newVertices[num + 3] = vector2;
				newColors[num] = new Color32(0, 0, 0, byte.MaxValue);
				newColors[num + 1] = new Color32(0, 0, 0, byte.MaxValue);
				newColors[num + 2] = new Color32(0, 0, 0, byte.MaxValue);
				newColors[num + 3] = new Color32(0, 0, 0, byte.MaxValue);
				newUVs[num] = new Vector2(0f, 0f);
				newUVs[num + 1] = new Vector2(0f, 0f);
				newUVs[num + 2] = new Vector2(0f, 0f);
				newUVs[num + 3] = new Vector2(0f, 0f);
				newIndicies[num] = num;
				newIndicies[num + 1] = num + 1;
				newIndicies[num + 2] = num + 2;
				newIndicies[num + 3] = num + 3;
				num += 4;
			}
			vector = point;
			vector2 = point2;
		}
		param3.SetVertices(newVertices, 0, num);
		param3.SetColors(newColors, 0, num);
		param3.SetUVs(0, newUVs, 0, num);
		param3.SetIndices(newIndicies, 0, num, MeshTopology.Lines, 0);
	}

	private static void FUN_974(VigObject param1, List<VigTuple> param2, ushort param3, bool param4)
	{
		param1.DAT_4A = param3;
		if ((param3 & 0x7FFF) < 28672)
		{
			short num = (short)param3;
			if (num < 0)
			{
				num = (short)(-num - 4096);
			}
			VigTuple vigTuple = param2[0];
			VigTuple vigTuple2 = null;
			for (int i = 1; i < param2.Count; i++)
			{
				vigTuple = param2[i - 1];
				vigTuple2 = param2[i];
				if (vigTuple2.flag >= (uint)num)
				{
					break;
				}
			}
			VigObject vObject = vigTuple.vObject;
			VigObject vObject2 = vigTuple2.vObject;
			int num2 = vObject.vr.y;
			uint num3 = (uint)(((int)num - (int)vigTuple.flag) * 256) / (vigTuple2.flag - vigTuple.flag);
			if (num2 < 0)
			{
				num2 = -num2;
			}
			uint num4 = 32768u;
			if (1024 < num2)
			{
				num4 = 32769u;
			}
			if (-1 < param3 << 16)
			{
				num4 ^= 1;
			}
			Vector3Int vector3Int = Utilities.FUN_24148(v: vObject.FUN_2C5F4((ushort)num4).v3_1, transform: vObject.vTransform);
			num2 = vObject2.vr.y;
			if (num2 < 0)
			{
				num2 = -num2;
			}
			num4 = 32768u;
			if (1024 < num2)
			{
				num4 = 32769u;
			}
			if (-1 < param3 << 16)
			{
				num4 ^= 1;
			}
			ConfigContainer configContainer = vObject2.FUN_2C5F4((ushort)num4);
			Vector3Int vector3Int2 = Utilities.FUN_24148(vObject2.vTransform, configContainer.v3_1);
			num2 = (vector3Int2.x - vector3Int.x) * (int)num3;
			if (num2 < 0)
			{
				num2 += 255;
			}
			param1.vTransform.position.x = vector3Int.x + (num2 >> 8);
			num2 = (vector3Int2.y - vector3Int.y) * (int)num3;
			if (num2 < 0)
			{
				num2 += 255;
			}
			param1.vTransform.position.y = vector3Int.y + (num2 >> 8);
			num2 = (vector3Int2.z - vector3Int.z) * (int)num3;
			if (num2 < 0)
			{
				num2 += 255;
			}
			param1.vTransform.position.z = vector3Int.z + (num2 >> 8);
		}
		else
		{
			VigTuple vigTuple3 = ((uint)param3 >= 61440u) ? param2[0] : param2[param2.Count - 1];
			VigObject vObject3 = vigTuple3.vObject;
			ConfigContainer configContainer = vObject3.FUN_2C5F4(32768);
			ConfigContainer configContainer2 = vObject3.FUN_2C5F4(32769);
			int num5 = ((-(short)param3 / 2) & 0xFFF) * 4;
			int num6 = configContainer2.v3_1.x - configContainer.v3_1.x;
			int num7 = Utilities.DAT_65C90[num5 / 2 + 1] * num6;
			if (num7 < 0)
			{
				num7 += 8191;
			}
			Vector3Int v = default(Vector3Int);
			v.x = (configContainer.v3_1.x + configContainer2.v3_1.x) / 2 + (num7 >> 13);
			v.y = (configContainer.v3_1.y + configContainer2.v3_1.y) / 2;
			num6 = Utilities.DAT_65C90[num5 / 2] * num6;
			if (num6 < 0)
			{
				num6 += 8191;
			}
			v.z = (configContainer.v3_1.z + configContainer2.v3_1.z) / 2 - (num6 >> 13);
			param1.vTransform.position = Utilities.FUN_24148(vObject3.vTransform, v);
			if (param4)
			{
				param1.vr.y = vObject3.vr.y + -(short)param3 / 2;
				param1.ApplyRotationMatrix();
			}
		}
	}

	public static void FUN_CCC(List<VigTuple> param1, List<Matrix4x4> param2, VigObject param3)
	{
		VigTuple vigTuple = null;
		int i;
		for (i = 0; i < param1.Count; i++)
		{
			vigTuple = param1[i];
			if (param3.screen.z <= vigTuple.vObject.screen.z)
			{
				break;
			}
		}
		Matrix4x4 localToWorldMatrix = param3.GetTransform().localToWorldMatrix;
		param2.Insert(i, localToWorldMatrix);
		param1.Insert(i, new VigTuple(param3, 0u));
	}

	private static void FUN_D64(List<VigTuple> param1)
	{
		VigTuple vigTuple = param1[0];
		int z = vigTuple.vObject.screen.z;
		int num = param1[param1.Count - 1].vObject.screen.z - z;
		if (num < 0)
		{
			num += 255;
		}
		vigTuple.flag = (uint)((vigTuple.vObject.screen.z - z) * 112 / (num >> 8));
		for (int i = 1; i < param1.Count; i++)
		{
			VigTuple vigTuple2 = param1[i];
			vigTuple2.flag = (uint)((vigTuple2.vObject.screen.z - z) * 112 / (num >> 8));
		}
	}
}
