using System.Collections.Generic;
using UnityEngine;

public class SKIRESRT : VigObject
{
	public static SKIRESRT instance;

	public int DAT_2200;

	public List<VigTuple> DAT_80_2;

	public int DAT_94;

	public Gondola2[] DAT_98;

	public ushort DAT_A0_2;

	public short DAT_A2;

	public List<Matrix4x4> poleM;

	public Mesh pole;

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
		if (instance == null)
		{
			instance = this;
			DAT_80_2 = new List<VigTuple>();
			DAT_98 = new Gondola2[2];
			newVertices = new Vector3[40];
			newUVs = new Vector2[40];
			newColors = new Color32[40];
			newIndicies = new int[40];
			poleM = new List<Matrix4x4>();
			GameObject gameObject = new GameObject();
			pole = new Mesh();
			gameObject.AddComponent<MeshFilter>().mesh = pole;
			gameObject.AddComponent<MeshRenderer>().sharedMaterial = LevelManager.instance.defaultMaterial;
		}
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			short dAT_A = DAT_A2;
			if (dAT_A == 0)
			{
				ushort num4 = DAT_A0_2 += 32;
				int num5 = 0;
				if ((num4 & 0x7FFF) == 0)
				{
					do
					{
						DAT_98[num5].flags |= 32u;
						num4 = (ushort)(DAT_98[num5].DAT_1A | 0x55);
						DAT_98[num5].DAT_1A = (short)num4;
						if (num4 != 0)
						{
							GameManager.instance.FUN_1FEB8(DAT_98[num5].vMesh);
							Gondola2 gondola = DAT_98[num5];
							gondola.DAT_1A = 85;
							VigMesh vigMesh = gondola.vMesh = gondola.vData.FUN_2CB74(gondola.gameObject, 85u, init: true);
						}
						num5++;
					}
					while (num5 < 2);
					DAT_A2 = 1200;
					GameManager.instance.FUN_1DE78(DAT_18);
					arg2 = 1;
					DAT_18 = 0;
				}
				if (arg2 == 0)
				{
					return 0u;
				}
				DAT_98[0].FUN_5DC(DAT_A0_2);
				DAT_98[1].FUN_5DC((ushort)((DAT_A0_2 + 32768) * 65536 >> 16));
				uint num6 = GameManager.instance.FUN_1E478(DAT_98[0].screen);
				uint num7 = GameManager.instance.FUN_1E478(DAT_98[1].screen);
				GameManager.instance.FUN_1E2C8(DAT_18, num6 + num7);
				return 0u;
			}
			DAT_A2 = (short)(dAT_A - 1);
			if (dAT_A != 1)
			{
				return 0u;
			}
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, DAT_98[0].vData.sndList, 0, 0u, param5: true);
			DAT_98[0].flags &= 4294967263u;
			DAT_98[1].flags &= 4294967263u;
			break;
		}
		case 1:
		{
			int z = DAT_80_2[0].vObject.screen.z;
			int num5 = DAT_80_2[DAT_80_2.Count - 1].vObject.screen.z - z;
			int num2 = 0;
			if (num5 < 0)
			{
				num5 += 255;
			}
			List<VigTuple> dAT_80_ = DAT_80_2;
			for (int j = 0; j < dAT_80_.Count; j++)
			{
				VigTuple vigTuple2 = dAT_80_[j];
				vigTuple2.flag = (uint)((vigTuple2.vObject.screen.z - z) * 112 / (num5 >> 8));
				num2++;
			}
			num2 <<= 1;
			DAT_A2 = 1200;
			flags |= 128u;
			DAT_98[0].FUN_5DC(0);
			DAT_98[1].FUN_5DC(32768);
			GameManager.instance.offsetFactor = 2.5f;
			GameManager.instance.offsetStart = 0f;
			GameManager.instance.angleOffset = 0.35f;
			GameManager.instance.aspectRatioScale = 240f;
			VigObject param2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 256);
			VigObject x = GameManager.instance.FUN_4AC1C(4261412864u, param2);
			GameManager.instance.DAT_1038 = ((x != null) ? 1 : 0);
			goto case 2;
		}
		case 2:
			GameManager.instance.FUN_34B34();
			GameManager.instance.FUN_30CB0(this, 240);
			return 0u;
		case 17:
		{
			int translateFactor = GameManager.instance.translateFactor2;
			List<VigTuple> dAT_80_ = DAT_80_2;
			int num = 0;
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			for (int i = 0; i < dAT_80_.Count; i++)
			{
				VigTuple vigTuple = dAT_80_[i];
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
				point = poleM[i].MultiplyPoint3x4(point);
				Coprocessor.ExecuteRTPS(12, lm: false);
				Coprocessor.vector0.vx0 = (short)(configContainer2.v3_1.x >> 8);
				Coprocessor.vector0.vy0 = (short)(configContainer2.v3_1.y >> 8);
				Coprocessor.vector0.vz0 = (short)(configContainer2.v3_1.z >> 8);
				Vector3 point2 = new Vector3(Coprocessor.vector0.vx0, -Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
				point2 = poleM[i].MultiplyPoint3x4(point2);
				new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
				Coprocessor.ExecuteRTPS(12, lm: false);
				new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
				if (vigTuple != DAT_80_2[0])
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
			pole.SetVertices(newVertices, 0, num);
			pole.SetColors(newColors, 0, num);
			pole.SetUVs(0, newUVs, 0, num);
			pole.SetIndices(newIndicies, 0, num, MeshTopology.Lines, 0);
			break;
		}
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

	public void FUN_13F8(VigObject param1)
	{
		List<VigTuple> dAT_80_ = DAT_80_2;
		int i;
		for (i = 0; i < dAT_80_.Count; i++)
		{
			VigTuple vigTuple = dAT_80_[i];
			if (param1.screen.z <= vigTuple.vObject.screen.z)
			{
				break;
			}
		}
		Matrix4x4 localToWorldMatrix = param1.GetTransform().localToWorldMatrix;
		poleM.Insert(i, localToWorldMatrix);
		dAT_80_.Insert(i, new VigTuple(param1, 0u));
	}
}
