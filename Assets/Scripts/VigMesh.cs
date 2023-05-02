using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class VigMesh : MonoBehaviour
{
	public byte DAT_00;

	public byte DAT_01;

	public short DAT_02;

	public ushort vertices;

	public ushort faces;

	public byte[] vertexStream;

	public byte[] normalStream;

	public byte[] faceStream;

	public byte[] DAT_14;

	public uint DAT_18;

	public int[] DAT_1C;

	public Rect[] mainT;

	public Texture2D atlas;

	public Texture2D reflections;

	public Texture2D glossiness;

	public int linesSubmeshID;

	public Dictionary<int, int> materialIDs;

	public bool initAtStart;

	public MeshTopology topology;

	public int subMeshCount;

	public uint tmdID;

	public bool mirror;

	public XOBF_DB xobf;

	public OcclusionCamera[] occlusions;

	public int[] render;

	public int faceStart;

	private VigMesh instance;

	private Mesh mesh;

	private static Vector3[] newVertices = new Vector3[4095];

	private static Vector2[] newUVs = new Vector2[4095];

	private static Color32[] newColors = new Color32[4095];

	private static int[][] newTriangles = new int[4][]
	{
		new int[4095],
		new int[4095],
		new int[4095],
		new int[4095]
	};

	private int index;

	private int[] index2 = new int[4];

	private float scale;

	private BufferedBinaryReader brVar3;

	private BufferedBinaryReader brVar4;

	private BufferedBinaryReader brVar6;

	private BufferedBinaryReader brVar13;

	private new MeshRenderer renderer;

	private static uint[] DAT_22FEC = new uint[64]
	{
		2147623500u,
		2147623552u,
		2147623652u,
		2147623728u,
		2147624096u,
		2147624364u,
		2147624460u,
		2147624564u,
		2147625072u,
		2147625548u,
		2147625732u,
		2147625852u,
		2147626068u,
		2147626540u,
		2147626940u,
		2147626616u,
		2147623372u,
		2147623552u,
		2147623652u,
		2147623728u,
		2147623920u,
		2147624196u,
		2147624460u,
		2147624564u,
		2147624876u,
		2147625376u,
		2147625732u,
		2147625852u,
		2147626068u,
		2147626408u,
		2147626940u,
		2147626616u,
		2147623500u,
		2147623552u,
		2147623652u,
		2147623728u,
		2147624044u,
		2147624320u,
		2147624460u,
		2147624512u,
		2147625000u,
		2147625500u,
		2147625732u,
		2147625796u,
		2147626068u,
		2147626540u,
		2147626940u,
		2147626616u,
		2147623372u,
		2147623552u,
		2147623652u,
		2147623728u,
		2147623892u,
		2147624168u,
		2147624460u,
		2147624512u,
		2147624732u,
		2147625232u,
		2147625732u,
		2147625796u,
		2147626068u,
		2147626408u,
		2147626940u,
		2147626616u
	};

	private void Awake()
	{
	}

	private void Start()
	{
		if (initAtStart)
		{
			Initialize();
			renderer.sharedMaterials = xobf.GetMaterialList(this, (int)tmdID);
		}
	}

	public Mesh GetMesh()
	{
		return mesh;
	}

	public MeshRenderer GetRenderer()
	{
		return renderer;
	}

	public BufferedBinaryReader GetVertexBuffer()
	{
		return brVar3;
	}

	public void SetVertices(byte[] newBuffer, int start)
	{
		brVar3.ChangeBuffer(newBuffer);
		brVar3.Seek(start, SeekOrigin.Begin);
	}

	public void Initialize()
	{
		byte[] buffer = (DAT_14 == null) ? new byte[0] : DAT_14;
		brVar13 = new BufferedBinaryReader(faceStream);
		brVar3 = new BufferedBinaryReader(vertexStream);
		brVar4 = new BufferedBinaryReader(normalStream);
		brVar6 = new BufferedBinaryReader(buffer);
		renderer = GetComponent<MeshRenderer>();
		mesh = GetComponent<MeshFilter>().mesh;
	}

	public void Initialize2()
	{
		byte[] buffer = (DAT_14 == null) ? new byte[0] : DAT_14;
		brVar13 = new BufferedBinaryReader(faceStream);
		brVar3 = new BufferedBinaryReader(vertexStream);
		brVar4 = new BufferedBinaryReader(normalStream);
		brVar6 = new BufferedBinaryReader(buffer);
		mesh = new Mesh();
	}

	private void Update()
	{
	}

	public void ClearMeshData()
	{
		if (index == 0)
		{
			return;
		}
		for (int i = 0; i < index; i++)
		{
			newVertices[i] = new Vector3(0f, 0f, 0f);
			newUVs[i] = new Vector2(0f, 0f);
		}
		for (int j = 0; j < mesh.subMeshCount; j++)
		{
			for (int k = 0; k < index2[j]; k++)
			{
				newTriangles[j][k] = 0;
			}
		}
		index = 0;
		for (int l = 0; l < index2.Length; l++)
		{
			index2[l] = 0;
		}
		mesh.Clear();
	}

	public void CreateMeshData()
	{
		if (mirror)
		{
			index *= 2;
			index2[1] *= 2;
			int num = index / 2;
			int num2 = 0;
			while (num < index)
			{
				newVertices[num] = new Vector3(0f - newVertices[num2].x, newVertices[num2].y, 0f - newVertices[num2].z);
				newColors[num] = newColors[num2];
				newUVs[num] = newUVs[num2];
				num++;
				num2++;
			}
			for (int i = index / 2; i < index; i += 3)
			{
				newTriangles[1][i] = i + 2;
				newTriangles[1][i + 1] = i + 1;
				newTriangles[1][i + 2] = i;
			}
		}
		for (int j = 0; j < index; j++)
		{
			newVertices[j] = new Vector3(newVertices[j].x, 0f - newVertices[j].y, newVertices[j].z) * scale;
		}
		mesh.subMeshCount = subMeshCount;
		mesh.SetVertices(newVertices, 0, index);
		mesh.SetColors(newColors, 0, index);
		mesh.SetUVs(0, newUVs, 0, index);
		for (int k = 0; k < mesh.subMeshCount; k++)
		{
			MeshTopology meshTopology = (k == linesSubmeshID) ? topology : MeshTopology.Triangles;
			mesh.SetIndices(newTriangles[k], 0, index2[k], meshTopology, k, calculateBounds: false);
		}
	}

	public void FUN_2D2A8(VigTransform param1)
	{
		Vector3Int vector3Int = Utilities.FUN_24148(GameManager.instance.DAT_F28, param1.position);
		int num = GameManager.instance.DAT_DB0 - vector3Int.y;
		int num2 = num;
		if (num < 0)
		{
			num2 = -num;
		}
		if (num2 < DAT_18)
		{
			FUN_21F70(param1);
		}
		else
		{
			FUN_21F70(param1);
		}
	}

	public void FUN_2D4D4(VigTransform param1, Vector3Int param2, Vector3Int param3)
	{
		VigTransform vigTransform = Utilities.CompMatrixLV(GameManager.instance.DAT_F28, param1);
		int num = (param3.x - vigTransform.position.x) * param2.x + (param3.y - vigTransform.position.y) * param2.y + (param3.z - vigTransform.position.z) * param2.z;
		int num2 = -num;
		if (0 < num)
		{
			num2 += 4095;
		}
		num2 >>= 12;
		num = num2;
		if (num2 < 0)
		{
			num = -num2;
		}
		if (num < DAT_18)
		{
			Utilities.FUN_24238(vigTransform.rotation, param2);
			FUN_21F70(param1);
		}
		else
		{
			FUN_21F70(param1);
		}
	}

	public void FUN_21F70(VigTransform param1)
	{
		int translateFactor = GameManager.instance.translateFactor2;
		float pixelSnapMin = GameManager.instance.pixelSnapMin;
		float pixelSnapMax = GameManager.instance.pixelSnapMax;
		int num = 0;
		ClearMeshData();
		byte dAT_ = DAT_00;
		int num2 = 0;
		if ((dAT_ & 4) != 0)
		{
			num2 = 32;
		}
		if (param1.position.z < DAT_18 * 5)
		{
			num2 += 16;
			dAT_ = DAT_00;
		}
		if ((dAT_ & 1) != 0)
		{
			Matrix3x3 dAT_F = GameManager.instance.DAT_F48;
			Coprocessor.rotationMatrix.rt11 = dAT_F.V00;
			Coprocessor.rotationMatrix.rt12 = dAT_F.V01;
			Coprocessor.rotationMatrix.rt13 = dAT_F.V02;
			Coprocessor.rotationMatrix.rt21 = dAT_F.V10;
			Coprocessor.rotationMatrix.rt22 = dAT_F.V11;
			Coprocessor.rotationMatrix.rt23 = dAT_F.V12;
			Coprocessor.rotationMatrix.rt31 = dAT_F.V20;
			Coprocessor.rotationMatrix.rt32 = dAT_F.V21;
			Coprocessor.rotationMatrix.rt33 = dAT_F.V22;
			Coprocessor.accumulator.ir1 = param1.rotation.V00;
			Coprocessor.accumulator.ir2 = param1.rotation.V10;
			Coprocessor.accumulator.ir3 = param1.rotation.V20;
			Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
			int ir = Coprocessor.accumulator.ir1;
			int ir2 = Coprocessor.accumulator.ir2;
			int ir3 = Coprocessor.accumulator.ir3;
			Coprocessor.accumulator.ir1 = param1.rotation.V01;
			Coprocessor.accumulator.ir2 = param1.rotation.V11;
			Coprocessor.accumulator.ir3 = param1.rotation.V21;
			Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
			int ir4 = Coprocessor.accumulator.ir1;
			int ir5 = Coprocessor.accumulator.ir2;
			int ir6 = Coprocessor.accumulator.ir3;
			Coprocessor.accumulator.ir1 = param1.rotation.V02;
			Coprocessor.accumulator.ir2 = param1.rotation.V12;
			Coprocessor.accumulator.ir3 = param1.rotation.V22;
			Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
			Coprocessor.lightMatrix.l11 = (short)ir;
			Coprocessor.lightMatrix.l12 = (short)ir4;
			Coprocessor.lightMatrix.l31 = (short)ir3;
			Coprocessor.lightMatrix.l32 = (short)ir6;
			ir = Coprocessor.accumulator.ir1;
			ir3 = Coprocessor.accumulator.ir2;
			int ir7 = Coprocessor.accumulator.ir3;
			Coprocessor.lightMatrix.l13 = (short)ir;
			Coprocessor.lightMatrix.l21 = (short)ir2;
			Coprocessor.lightMatrix.l22 = (short)ir5;
			Coprocessor.lightMatrix.l23 = (short)ir3;
			Coprocessor.lightMatrix.l33 = (short)ir7;
		}
		Coprocessor.rotationMatrix.rt11 = param1.rotation.V00;
		Coprocessor.rotationMatrix.rt12 = param1.rotation.V01;
		Coprocessor.rotationMatrix.rt13 = param1.rotation.V02;
		Coprocessor.rotationMatrix.rt21 = param1.rotation.V10;
		Coprocessor.rotationMatrix.rt22 = param1.rotation.V11;
		Coprocessor.rotationMatrix.rt23 = param1.rotation.V12;
		Coprocessor.rotationMatrix.rt31 = param1.rotation.V20;
		Coprocessor.rotationMatrix.rt32 = param1.rotation.V21;
		Coprocessor.rotationMatrix.rt33 = param1.rotation.V22;
		uint num3 = (uint)(16 - DAT_01);
		int num4 = ((dAT_ & 2) == 0) ? (DAT_01 - 7) : 16;
		Coprocessor.translationVector._trx = param1.position.x >> (int)num3;
		Coprocessor.translationVector._try = param1.position.y >> (int)num3;
		Coprocessor.translationVector._trz = param1.position.z >> (int)num3;
		float p = DAT_01 - 8;
		float num5 = Mathf.Pow(2f, p);
		scale = 1f / num5;
		brVar13.Seek(0L, SeekOrigin.Begin);
		brVar4.Seek(0L, SeekOrigin.Begin);
		brVar6.Seek(0L, SeekOrigin.Begin);
		for (int i = 0; i < faces; i++)
		{
			int num6 = brVar13.ReadUInt16(4);
			int num7 = brVar13.ReadUInt16(6);
			int num8 = brVar13.ReadUInt16(8);
			Coprocessor.vector0.vx0 = brVar3.ReadInt16(num6);
			Coprocessor.vector0.vy0 = brVar3.ReadInt16(num6 + 2);
			Coprocessor.vector0.vz0 = brVar3.ReadInt16(num6 + 4);
			Coprocessor.vector1.vx1 = brVar3.ReadInt16(num7);
			Coprocessor.vector1.vy1 = brVar3.ReadInt16(num7 + 2);
			Coprocessor.vector1.vz1 = brVar3.ReadInt16(num7 + 4);
			Coprocessor.vector2.vx2 = brVar3.ReadInt16(num8);
			Coprocessor.vector2.vy2 = brVar3.ReadInt16(num8 + 2);
			Coprocessor.vector2.vz2 = brVar3.ReadInt16(num8 + 4);
			Coprocessor.ExecuteRTPT(12, lm: false);
			uint num9 = DAT_22FEC[(brVar13.ReadByte(3) & 0x3C) / 4 + num2];
			int num54;
			if (num9 <= 2147624564u)
			{
				if (num9 <= 2147624044u)
				{
					if (num9 <= 2147623652u)
					{
						if (num9 <= 2147623500u)
						{
							if (num9 != 2147623372u)
							{
								if (num9 != 2147623500u)
								{
									continue;
								}
								Coprocessor.ExecuteNCLIP();
								if (i < faceStart)
								{
									brVar13.Seek(12L, SeekOrigin.Current);
									continue;
								}
								Color32 color = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
								newColors[index] = color;
								newColors[index + 1] = color;
								newColors[index + 2] = color;
								newUVs[index] = new Vector2(0f, 0f);
								newUVs[index + 1] = new Vector2(0f, 0f);
								newUVs[index + 2] = new Vector2(0f, 0f);
								newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
								newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
								newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
								newTriangles[0][index2[0]] = index;
								newTriangles[0][index2[0] + 1] = index + 1;
								newTriangles[0][index2[0] + 2] = index + 2;
								index += 3;
								index2[0] += 3;
								brVar13.Seek(12L, SeekOrigin.Current);
							}
							else
							{
								Coprocessor.ExecuteNCLIP();
								if (i < faceStart)
								{
									brVar13.Seek(12L, SeekOrigin.Current);
									continue;
								}
								Color32 color2 = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
								newColors[index] = color2;
								newColors[index + 1] = color2;
								newColors[index + 2] = color2;
								newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
								newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
								newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
								newUVs[index] = new Vector2(0f, 0f);
								newUVs[index + 1] = new Vector2(0f, 0f);
								newUVs[index + 2] = new Vector2(0f, 0f);
								newTriangles[0][index2[0]] = index;
								newTriangles[0][index2[0] + 1] = index + 1;
								newTriangles[0][index2[0] + 2] = index + 2;
								index += 3;
								index2[0] += 3;
								brVar13.Seek(12L, SeekOrigin.Current);
							}
						}
						else if (num9 != 2147623552u)
						{
							if (num9 != 2147623652u)
							{
								continue;
							}
							Coprocessor.ExecuteNCLIP();
							if (i < faceStart)
							{
								brVar13.Seek(20L, SeekOrigin.Current);
								continue;
							}
							newColors[index] = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							newColors[index + 1] = new Color32(brVar13.ReadByte(12), brVar13.ReadByte(13), brVar13.ReadByte(14), brVar13.ReadByte(15));
							newColors[index + 2] = new Color32(brVar13.ReadByte(20), brVar13.ReadByte(21), brVar13.ReadByte(22), brVar13.ReadByte(23));
							newUVs[index] = new Vector2(0f, 0f);
							newUVs[index + 1] = new Vector2(0f, 0f);
							newUVs[index + 2] = new Vector2(0f, 0f);
							newTriangles[0][index2[0]] = index;
							newTriangles[0][index2[0] + 1] = index + 1;
							newTriangles[0][index2[0] + 2] = index + 2;
							index += 3;
							index2[0] += 3;
							brVar13.Seek(20L, SeekOrigin.Current);
						}
						else
						{
							Coprocessor.ExecuteNCLIP();
							if (i < faceStart)
							{
								brVar13.Seek(32L, SeekOrigin.Current);
								continue;
							}
							newColors[index] = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
							int num10 = brVar13.ReadByte(22);
							Rect rect = mainT[num10];
							float num11 = Mathf.Clamp((float)atlas.width * rect.width - 1f, 1f, atlas.width);
							float num12 = Mathf.Clamp((float)atlas.height * rect.height - 1f, 1f, atlas.height);
							newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num11, pixelSnapMin, pixelSnapMax) * rect.width + rect.x, -1f + (rect.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num12, pixelSnapMin, pixelSnapMax) * rect.height) + rect.y + 1f);
							newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num11, pixelSnapMin, pixelSnapMax) * rect.width + rect.x, -1f + (rect.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num12, pixelSnapMin, pixelSnapMax) * rect.height) + rect.y + 1f);
							newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num11, pixelSnapMin, pixelSnapMax) * rect.width + rect.x, -1f + (rect.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num12, pixelSnapMin, pixelSnapMax) * rect.height) + rect.y + 1f);
							newColors[index + 1] = new Color32(brVar13.ReadByte(24), brVar13.ReadByte(25), brVar13.ReadByte(26), brVar13.ReadByte(27));
							newColors[index + 2] = new Color32(brVar13.ReadByte(28), brVar13.ReadByte(29), brVar13.ReadByte(30), brVar13.ReadByte(31));
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							newTriangles[1][index2[1]] = index + 2;
							newTriangles[1][index2[1] + 1] = index + 1;
							newTriangles[1][index2[1] + 2] = index;
							index += 3;
							index2[1] += 3;
							brVar13.Seek(32L, SeekOrigin.Current);
						}
					}
					else if (num9 <= 2147623892u)
					{
						if (num9 != 2147623728u)
						{
							if (num9 != 2147623892u)
							{
								continue;
							}
							Coprocessor.ExecuteNCLIP();
							if (i < faceStart)
							{
								brVar13.Seek(12L, SeekOrigin.Current);
								brVar6.Seek(4L, SeekOrigin.Current);
								continue;
							}
							Color32 color3 = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
							newColors[index] = color3;
							newColors[index + 1] = color3;
							newColors[index + 2] = color3;
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							newUVs[index] = new Vector2(0f, 0f);
							newUVs[index + 1] = new Vector2(0f, 0f);
							newUVs[index + 2] = new Vector2(0f, 0f);
							newTriangles[0][index2[0]] = index;
							newTriangles[0][index2[0] + 1] = index + 1;
							newTriangles[0][index2[0] + 2] = index + 2;
							index += 3;
							index2[0] += 3;
							brVar13.Seek(12L, SeekOrigin.Current);
							brVar6.Seek(4L, SeekOrigin.Current);
						}
						else
						{
							Coprocessor.ExecuteNCLIP();
							if (i < faceStart)
							{
								brVar13.Seek(32L, SeekOrigin.Current);
								continue;
							}
							newColors[index] = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
							newColors[index + 1] = new Color32(brVar13.ReadByte(24), brVar13.ReadByte(25), brVar13.ReadByte(26), brVar13.ReadByte(27));
							newColors[index + 2] = new Color32(brVar13.ReadByte(28), brVar13.ReadByte(29), brVar13.ReadByte(30), brVar13.ReadByte(31));
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							int num13 = DAT_1C[brVar13.ReadUInt16(22) & 0x3FFF];
							int num14 = materialIDs[num13];
							Rect rect2 = mainT[num13];
							float num15 = Mathf.Clamp((float)atlas.width * rect2.width - 1f, 1f, atlas.width);
							float num16 = Mathf.Clamp((float)atlas.height * rect2.height - 1f, 1f, atlas.height);
							newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num15, pixelSnapMin, pixelSnapMax) * rect2.width + rect2.x, -1f + (rect2.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num16, pixelSnapMin, pixelSnapMax) * rect2.height) + rect2.y + 1f);
							newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num15, pixelSnapMin, pixelSnapMax) * rect2.width + rect2.x, -1f + (rect2.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num16, pixelSnapMin, pixelSnapMax) * rect2.height) + rect2.y + 1f);
							newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num15, pixelSnapMin, pixelSnapMax) * rect2.width + rect2.x, -1f + (rect2.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num16, pixelSnapMin, pixelSnapMax) * rect2.height) + rect2.y + 1f);
							newTriangles[num14][index2[num14]] = index + 2;
							newTriangles[num14][index2[num14] + 1] = index + 1;
							newTriangles[num14][index2[num14] + 2] = index;
							index += 3;
							index2[num14] += 3;
							brVar13.Seek(32L, SeekOrigin.Current);
						}
					}
					else if (num9 != 2147623920u)
					{
						if (num9 != 2147624044u)
						{
							continue;
						}
						Coprocessor.ExecuteNCLIP();
						if (i < faceStart)
						{
							brVar13.Seek(12L, SeekOrigin.Current);
							brVar6.Seek(4L, SeekOrigin.Current);
							continue;
						}
						Color32 color4 = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
						newColors[index] = color4;
						newColors[index + 1] = color4;
						newColors[index + 2] = color4;
						newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
						newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
						newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
						newUVs[index] = new Vector2(0f, 0f);
						newUVs[index + 1] = new Vector2(0f, 0f);
						newUVs[index + 2] = new Vector2(0f, 0f);
						newTriangles[0][index2[0]] = index;
						newTriangles[0][index2[0] + 1] = index + 1;
						newTriangles[0][index2[0] + 2] = index + 2;
						index += 3;
						index2[0] += 3;
						brVar13.Seek(12L, SeekOrigin.Current);
						brVar6.Seek(4L, SeekOrigin.Current);
					}
					else
					{
						Coprocessor.ExecuteNCLIP();
						if (i >= faceStart)
						{
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							Coprocessor.colorCode.r = brVar13.ReadByte(0);
							Coprocessor.colorCode.g = brVar13.ReadByte(1);
							Coprocessor.colorCode.b = brVar13.ReadByte(2);
							Coprocessor.colorCode.code = (byte)(brVar13.ReadByte(3) + 16);
							num6 = brVar13.ReadInt16(10);
							Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
							Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
							Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
							Coprocessor.ExecuteNCCS(12, lm: true);
							Color32 color5 = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, byte.MaxValue);
							newColors[index] = color5;
							newColors[index + 1] = color5;
							newColors[index + 2] = color5;
							newUVs[index] = new Vector2(0f, 0f);
							newUVs[index + 1] = new Vector2(0f, 0f);
							newUVs[index + 2] = new Vector2(0f, 0f);
							newTriangles[0][index2[0]] = index;
							newTriangles[0][index2[0] + 1] = index + 1;
							newTriangles[0][index2[0] + 2] = index + 2;
							index += 3;
							index2[0] += 3;
							brVar13.Seek(12L, SeekOrigin.Current);
						}
						else
						{
							brVar13.Seek(12L, SeekOrigin.Current);
						}
					}
				}
				else if (num9 <= 2147624320u)
				{
					if (num9 <= 2147624168u)
					{
						if (num9 != 2147624096u)
						{
							if (num9 != 2147624168u)
							{
								continue;
							}
							Coprocessor.ExecuteNCLIP();
							if (i < faceStart)
							{
								brVar13.Seek(24L, SeekOrigin.Current);
								brVar6.Seek(4L, SeekOrigin.Current);
								continue;
							}
							Color32 color6 = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
							newColors[index] = color6;
							newColors[index + 1] = color6;
							newColors[index + 2] = color6;
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							int num17 = brVar13.ReadByte(22);
							int num18 = materialIDs[num17];
							Rect rect3 = mainT[num17];
							float num19 = Mathf.Clamp((float)atlas.width * rect3.width - 1f, 1f, atlas.width);
							float num20 = Mathf.Clamp((float)atlas.height * rect3.height - 1f, 1f, atlas.height);
							newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num19, pixelSnapMin, pixelSnapMax) * rect3.width + rect3.x, -1f + (rect3.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num20, pixelSnapMin, pixelSnapMax) * rect3.height) + rect3.y + 1f);
							newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num19, pixelSnapMin, pixelSnapMax) * rect3.width + rect3.x, -1f + (rect3.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num20, pixelSnapMin, pixelSnapMax) * rect3.height) + rect3.y + 1f);
							newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num19, pixelSnapMin, pixelSnapMax) * rect3.width + rect3.x, -1f + (rect3.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num20, pixelSnapMin, pixelSnapMax) * rect3.height) + rect3.y + 1f);
							newTriangles[num18][index2[num18]] = index + 2;
							newTriangles[num18][index2[num18] + 1] = index + 1;
							newTriangles[num18][index2[num18] + 2] = index;
							index += 3;
							index2[num18] += 3;
							brVar13.Seek(24L, SeekOrigin.Current);
							brVar6.Seek(4L, SeekOrigin.Current);
						}
						else
						{
							Coprocessor.ExecuteNCLIP();
							if (i < faceStart)
							{
								brVar13.Seek(12L, SeekOrigin.Current);
								continue;
							}
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							Coprocessor.colorCode.r = brVar13.ReadByte(0);
							Coprocessor.colorCode.g = brVar13.ReadByte(1);
							Coprocessor.colorCode.b = brVar13.ReadByte(2);
							Coprocessor.colorCode.code = (byte)(brVar13.ReadByte(3) + 16);
							num6 = brVar13.ReadInt16(10);
							Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
							Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
							Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
							Coprocessor.ExecuteNCCS(12, lm: true);
							Color32 color7 = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, byte.MaxValue);
							newColors[index] = color7;
							newColors[index + 1] = color7;
							newColors[index + 2] = color7;
							newUVs[index] = new Vector2(0f, 0f);
							newUVs[index + 1] = new Vector2(0f, 0f);
							newUVs[index + 2] = new Vector2(0f, 0f);
							newTriangles[0][index2[0]] = index;
							newTriangles[0][index2[0] + 1] = index + 1;
							newTriangles[0][index2[0] + 2] = index + 2;
							index += 3;
							index2[0] += 3;
							brVar13.Seek(12L, SeekOrigin.Current);
						}
					}
					else if (num9 != 2147624196u)
					{
						if (num9 != 2147624320u)
						{
							continue;
						}
						Coprocessor.ExecuteNCLIP();
						if (i < faceStart)
						{
							brVar13.Seek(24L, SeekOrigin.Current);
							brVar6.Seek(4L, SeekOrigin.Current);
							continue;
						}
						Color32 color8 = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
						newColors[index] = color8;
						newColors[index + 1] = color8;
						newColors[index + 2] = color8;
						newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
						newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
						newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
						int num21 = brVar13.ReadByte(22);
						int num22 = materialIDs[num21];
						Rect rect4 = mainT[num21];
						float num23 = Mathf.Clamp((float)atlas.width * rect4.width - 1f, 1f, atlas.width);
						float num24 = Mathf.Clamp((float)atlas.height * rect4.height - 1f, 1f, atlas.height);
						newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num23, pixelSnapMin, pixelSnapMax) * rect4.width + rect4.x, -1f + (rect4.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num24, pixelSnapMin, pixelSnapMax) * rect4.height) + rect4.y + 1f);
						newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num23, pixelSnapMin, pixelSnapMax) * rect4.width + rect4.x, -1f + (rect4.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num24, pixelSnapMin, pixelSnapMax) * rect4.height) + rect4.y + 1f);
						newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num23, pixelSnapMin, pixelSnapMax) * rect4.width + rect4.x, -1f + (rect4.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num24, pixelSnapMin, pixelSnapMax) * rect4.height) + rect4.y + 1f);
						newTriangles[num22][index2[num22]] = index + 2;
						newTriangles[num22][index2[num22] + 1] = index + 1;
						newTriangles[num22][index2[num22] + 2] = index;
						index += 3;
						index2[num22] += 3;
						brVar13.Seek(24L, SeekOrigin.Current);
						brVar6.Seek(4L, SeekOrigin.Current);
					}
					else
					{
						Coprocessor.ExecuteNCLIP();
						if (i < faceStart)
						{
							brVar13.Seek(24L, SeekOrigin.Current);
							continue;
						}
						newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
						newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
						newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
						Coprocessor.colorCode.r = brVar13.ReadByte(0);
						Coprocessor.colorCode.g = brVar13.ReadByte(1);
						Coprocessor.colorCode.b = brVar13.ReadByte(2);
						Coprocessor.colorCode.code = brVar13.ReadByte(3);
						num6 = brVar13.ReadInt16(10);
						Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
						Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
						Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
						Coprocessor.ExecuteNCCS(12, lm: true);
						int num25 = brVar13.ReadByte(22);
						int num26 = materialIDs[num25];
						Rect rect5 = mainT[num25];
						float num27 = Mathf.Clamp((float)atlas.width * rect5.width - 1f, 1f, atlas.width);
						float num28 = Mathf.Clamp((float)atlas.height * rect5.height - 1f, 1f, atlas.height);
						newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num27, pixelSnapMin, pixelSnapMax) * rect5.width + rect5.x, -1f + (rect5.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num28, pixelSnapMin, pixelSnapMax) * rect5.height) + rect5.y + 1f);
						newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num27, pixelSnapMin, pixelSnapMax) * rect5.width + rect5.x, -1f + (rect5.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num28, pixelSnapMin, pixelSnapMax) * rect5.height) + rect5.y + 1f);
						newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num27, pixelSnapMin, pixelSnapMax) * rect5.width + rect5.x, -1f + (rect5.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num28, pixelSnapMin, pixelSnapMax) * rect5.height) + rect5.y + 1f);
						Color32 color9 = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, byte.MaxValue);
						newColors[index] = color9;
						newColors[index + 1] = color9;
						newColors[index + 2] = color9;
						newTriangles[num26][index2[num26]] = index + 2;
						newTriangles[num26][index2[num26] + 1] = index + 1;
						newTriangles[num26][index2[num26] + 2] = index;
						index += 3;
						index2[num26] += 3;
						brVar13.Seek(24L, SeekOrigin.Current);
					}
				}
				else if (num9 <= 2147624460u)
				{
					if (num9 != 2147624364u)
					{
						if (num9 == 2147624460u)
						{
							Color32 color10 = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
							newColors[index] = color10;
							newColors[index + 1] = color10;
							newUVs[index] = new Vector2(0f, 0f);
							newUVs[index + 1] = new Vector2(0f, 0f);
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newTriangles[linesSubmeshID][index2[linesSubmeshID]] = index;
							newTriangles[linesSubmeshID][index2[linesSubmeshID] + 1] = index + 1;
							index += 2;
							index2[linesSubmeshID] += 2;
							brVar13.Seek(12L, SeekOrigin.Current);
						}
						continue;
					}
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(24L, SeekOrigin.Current);
						continue;
					}
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					Coprocessor.colorCode.r = brVar13.ReadByte(0);
					Coprocessor.colorCode.g = brVar13.ReadByte(1);
					Coprocessor.colorCode.b = brVar13.ReadByte(2);
					Coprocessor.colorCode.code = (byte)(brVar13.ReadByte(3) + 16);
					num6 = brVar13.ReadInt16(10);
					Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
					Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
					Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
					Coprocessor.ExecuteNCCS(12, lm: true);
					int num29 = brVar13.ReadByte(22);
					Rect rect6 = mainT[num29];
					float num30 = Mathf.Clamp((float)atlas.width * rect6.width - 1f, 1f, atlas.width);
					float num31 = Mathf.Clamp((float)atlas.height * rect6.height - 1f, 1f, atlas.height);
					newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num30, pixelSnapMin, pixelSnapMax) * rect6.width + rect6.x, -1f + (rect6.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num31, pixelSnapMin, pixelSnapMax) * rect6.height) + rect6.y + 1f);
					newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num30, pixelSnapMin, pixelSnapMax) * rect6.width + rect6.x, -1f + (rect6.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num31, pixelSnapMin, pixelSnapMax) * rect6.height) + rect6.y + 1f);
					newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num30, pixelSnapMin, pixelSnapMax) * rect6.width + rect6.x, -1f + (rect6.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num31, pixelSnapMin, pixelSnapMax) * rect6.height) + rect6.y + 1f);
					Color32 color11 = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, byte.MaxValue);
					newColors[index] = color11;
					newColors[index + 1] = color11;
					newColors[index + 2] = color11;
					newTriangles[1][index2[1]] = index + 2;
					newTriangles[1][index2[1] + 1] = index + 1;
					newTriangles[1][index2[1] + 2] = index;
					index += 3;
					index2[1] += 3;
					brVar13.Seek(24L, SeekOrigin.Current);
				}
				else if (num9 != 2147624512u)
				{
					if (num9 != 2147624564u)
					{
						continue;
					}
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(24L, SeekOrigin.Current);
						continue;
					}
					brVar13.Seek(24L, SeekOrigin.Current);
				}
				else
				{
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(24L, SeekOrigin.Current);
						brVar6.Seek(4L, SeekOrigin.Current);
						continue;
					}
					Color32 color12 = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					newColors[index] = color12;
					newColors[index + 1] = color12;
					newColors[index + 2] = color12;
					int num32 = DAT_1C[brVar13.ReadUInt16(22) & 0x3FFF];
					int num33 = materialIDs[num32];
					Rect rect7 = mainT[num32];
					float num34 = Mathf.Clamp((float)atlas.width * rect7.width - 1f, 1f, atlas.width);
					float num35 = Mathf.Clamp((float)atlas.height * rect7.height - 1f, 1f, atlas.height);
					newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num34, pixelSnapMin, pixelSnapMax) * rect7.width + rect7.x, -1f + (rect7.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num35, pixelSnapMin, pixelSnapMax) * rect7.height) + rect7.y + 1f);
					newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num34, pixelSnapMin, pixelSnapMax) * rect7.width + rect7.x, -1f + (rect7.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num35, pixelSnapMin, pixelSnapMax) * rect7.height) + rect7.y + 1f);
					newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num34, pixelSnapMin, pixelSnapMax) * rect7.width + rect7.x, -1f + (rect7.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num35, pixelSnapMin, pixelSnapMax) * rect7.height) + rect7.y + 1f);
					newTriangles[num33][index2[num33]] = index + 2;
					newTriangles[num33][index2[num33] + 1] = index + 1;
					newTriangles[num33][index2[num33] + 2] = index;
					index += 3;
					index2[num33] += 3;
					brVar13.Seek(24L, SeekOrigin.Current);
					brVar6.Seek(4L, SeekOrigin.Current);
				}
			}
			else if (num9 <= 2147625548u)
			{
				if (num9 > 2147625072u)
				{
					switch (num9)
					{
					case 2147625376u:
					case 2147625548u:
						Coprocessor.ExecuteNCLIP();
						if (i >= faceStart)
						{
							Coprocessor.ExecuteAVSZ3();
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							Coprocessor.colorCode.r = brVar13.ReadByte(0);
							Coprocessor.colorCode.g = brVar13.ReadByte(1);
							Coprocessor.colorCode.b = brVar13.ReadByte(2);
							Coprocessor.colorCode.code = (byte)(brVar13.ReadByte(3) + 16);
							num6 = brVar13.ReadInt16(10);
							num7 = brVar13.ReadInt16(12);
							num8 = brVar13.ReadInt16(14);
							Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
							Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
							Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
							Coprocessor.vector1.vx1 = brVar4.ReadInt16(num7);
							Coprocessor.vector1.vy1 = brVar4.ReadInt16(num7 + 2);
							Coprocessor.vector1.vz1 = brVar4.ReadInt16(num7 + 4);
							Coprocessor.vector2.vx2 = brVar4.ReadInt16(num8);
							Coprocessor.vector2.vy2 = brVar4.ReadInt16(num8 + 2);
							Coprocessor.vector2.vz2 = brVar4.ReadInt16(num8 + 4);
							Coprocessor.ExecuteNCCT(12, lm: true);
							ushort averageZ = Coprocessor.averageZ;
							int num44 = brVar13.ReadByte(26);
							Rect rect10 = mainT[num44];
							float num45 = Mathf.Clamp((float)atlas.width * rect10.width - 1f, 1f, atlas.width);
							float num46 = Mathf.Clamp((float)atlas.height * rect10.height - 1f, 1f, atlas.height);
							newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num45, pixelSnapMin, pixelSnapMax) * rect10.width + rect10.x, -1f + (rect10.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num46, pixelSnapMin, pixelSnapMax) * rect10.height) + rect10.y + 1f);
							newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num45, pixelSnapMin, pixelSnapMax) * rect10.width + rect10.x, -1f + (rect10.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num46, pixelSnapMin, pixelSnapMax) * rect10.height) + rect10.y + 1f);
							newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(24) / num45, pixelSnapMin, pixelSnapMax) * rect10.width + rect10.x, -1f + (rect10.height - Mathf.Clamp((float)(int)brVar13.ReadByte(25) / num46, pixelSnapMin, pixelSnapMax) * rect10.height) + rect10.y + 1f);
							newColors[index] = new Color32(Coprocessor.colorFIFO.r0, Coprocessor.colorFIFO.g0, Coprocessor.colorFIFO.b0, byte.MaxValue);
							newColors[index + 1] = new Color32(Coprocessor.colorFIFO.r1, Coprocessor.colorFIFO.g1, Coprocessor.colorFIFO.b1, byte.MaxValue);
							newColors[index + 2] = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, byte.MaxValue);
							newTriangles[1][index2[1]] = index + 2;
							newTriangles[1][index2[1] + 1] = index + 1;
							newTriangles[1][index2[1] + 2] = index;
							index += 3;
							index2[1] += 3;
							brVar13.Seek(28L, SeekOrigin.Current);
						}
						else
						{
							brVar13.Seek(28L, SeekOrigin.Current);
						}
						break;
					case 2147625500u:
						Coprocessor.ExecuteNCLIP();
						if (i >= faceStart)
						{
							newColors[index] = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
							newColors[index + 1] = new Color32(brVar6.ReadByte(4), brVar6.ReadByte(5), brVar6.ReadByte(6), byte.MaxValue);
							newColors[index + 2] = new Color32(brVar6.ReadByte(8), brVar6.ReadByte(9), brVar6.ReadByte(10), byte.MaxValue);
							Coprocessor.ExecuteAVSZ3();
							ushort averageZ2 = Coprocessor.averageZ;
							int num40 = brVar13.ReadByte(26);
							int num41 = materialIDs[num40];
							Rect rect9 = mainT[num40];
							float num42 = Mathf.Clamp((float)atlas.width * rect9.width - 1f, 1f, atlas.width);
							float num43 = Mathf.Clamp((float)atlas.height * rect9.height - 1f, 1f, atlas.height);
							newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num42, pixelSnapMin, pixelSnapMax) * rect9.width + rect9.x, -1f + (rect9.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num43, pixelSnapMin, pixelSnapMax) * rect9.height) + rect9.y + 1f);
							newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num42, pixelSnapMin, pixelSnapMax) * rect9.width + rect9.x, -1f + (rect9.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num43, pixelSnapMin, pixelSnapMax) * rect9.height) + rect9.y + 1f);
							newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(24) / num42, pixelSnapMin, pixelSnapMax) * rect9.width + rect9.x, -1f + (rect9.height - Mathf.Clamp((float)(int)brVar13.ReadByte(25) / num43, pixelSnapMin, pixelSnapMax) * rect9.height) + rect9.y + 1f);
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							newTriangles[num41][index2[num41]] = index + 2;
							newTriangles[num41][index2[num41] + 1] = index + 1;
							newTriangles[num41][index2[num41] + 2] = index;
							index += 3;
							index2[num41] += 3;
							brVar13.Seek(28L, SeekOrigin.Current);
							brVar6.Seek(12L, SeekOrigin.Current);
						}
						else
						{
							brVar13.Seek(28L, SeekOrigin.Current);
							brVar6.Seek(12L, SeekOrigin.Current);
						}
						break;
					case 2147625232u:
						Coprocessor.ExecuteNCLIP();
						if (i >= faceStart)
						{
							newColors[index] = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
							newColors[index + 1] = new Color32(brVar6.ReadByte(4), brVar6.ReadByte(5), brVar6.ReadByte(6), byte.MaxValue);
							newColors[index + 2] = new Color32(brVar6.ReadByte(8), brVar6.ReadByte(9), brVar6.ReadByte(10), byte.MaxValue);
							int num36 = brVar13.ReadByte(26);
							int num37 = materialIDs[num36];
							Rect rect8 = mainT[num36];
							float num38 = Mathf.Clamp((float)atlas.width * rect8.width - 1f, 1f, atlas.width);
							float num39 = Mathf.Clamp((float)atlas.height * rect8.height - 1f, 1f, atlas.height);
							newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num38, pixelSnapMin, pixelSnapMax) * rect8.width + rect8.x, -1f + (rect8.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num39, pixelSnapMin, pixelSnapMax) * rect8.height) + rect8.y + 1f);
							newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num38, pixelSnapMin, pixelSnapMax) * rect8.width + rect8.x, -1f + (rect8.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num39, pixelSnapMin, pixelSnapMax) * rect8.height) + rect8.y + 1f);
							newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(24) / num38, pixelSnapMin, pixelSnapMax) * rect8.width + rect8.x, -1f + (rect8.height - Mathf.Clamp((float)(int)brVar13.ReadByte(25) / num39, pixelSnapMin, pixelSnapMax) * rect8.height) + rect8.y + 1f);
							newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
							newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
							newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
							newTriangles[num37][index2[num37]] = index + 2;
							newTriangles[num37][index2[num37] + 1] = index + 1;
							newTriangles[num37][index2[num37] + 2] = index;
							index += 3;
							index2[num37] += 3;
							brVar13.Seek(28L, SeekOrigin.Current);
							brVar6.Seek(12L, SeekOrigin.Current);
						}
						else
						{
							brVar13.Seek(28L, SeekOrigin.Current);
							brVar6.Seek(12L, SeekOrigin.Current);
						}
						break;
					}
					continue;
				}
				if (num9 <= 2147624876u)
				{
					if (num9 != 2147624732u)
					{
						if (num9 != 2147624876u)
						{
							continue;
						}
						goto IL_1e51;
					}
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(16L, SeekOrigin.Current);
						brVar6.Seek(12L, SeekOrigin.Current);
						continue;
					}
					newColors[index] = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
					newColors[index + 1] = new Color32(brVar6.ReadByte(4), brVar6.ReadByte(5), brVar6.ReadByte(6), byte.MaxValue);
					newColors[index + 2] = new Color32(brVar6.ReadByte(8), brVar6.ReadByte(9), brVar6.ReadByte(10), byte.MaxValue);
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					newUVs[index] = new Vector2(0f, 0f);
					newUVs[index + 1] = new Vector2(0f, 0f);
					newUVs[index + 2] = new Vector2(0f, 0f);
					newTriangles[0][index2[0]] = index;
					newTriangles[0][index2[0] + 1] = index + 1;
					newTriangles[0][index2[0] + 2] = index + 2;
					index += 3;
					index2[0] += 3;
					brVar13.Seek(16L, SeekOrigin.Current);
					brVar6.Seek(12L, SeekOrigin.Current);
				}
				else
				{
					if (num9 != 2147625000u)
					{
						if (num9 != 2147625072u)
						{
							continue;
						}
						goto IL_1e51;
					}
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(16L, SeekOrigin.Current);
						brVar6.Seek(12L, SeekOrigin.Current);
						continue;
					}
					newColors[index] = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
					newColors[index + 1] = new Color32(brVar6.ReadByte(4), brVar6.ReadByte(5), brVar6.ReadByte(6), byte.MaxValue);
					newColors[index + 2] = new Color32(brVar6.ReadByte(8), brVar6.ReadByte(9), brVar6.ReadByte(10), byte.MaxValue);
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					newUVs[index] = new Vector2(0f, 0f);
					newUVs[index + 1] = new Vector2(0f, 0f);
					newUVs[index + 2] = new Vector2(0f, 0f);
					newTriangles[0][index2[0]] = index;
					newTriangles[0][index2[0] + 1] = index + 1;
					newTriangles[0][index2[0] + 2] = index + 2;
					index += 3;
					index2[0] += 3;
					brVar13.Seek(16L, SeekOrigin.Current);
					brVar6.Seek(12L, SeekOrigin.Current);
				}
			}
			else if (num9 <= 2147626068u)
			{
				if (num9 <= 2147625796u)
				{
					if (num9 == 2147625732u)
					{
						int num47 = brVar13.ReadUInt16(10) * 8;
						if (i >= faceStart)
						{
							occlusions[num++].UpdateW();
						}
						brVar13.Seek(num47 + 12, SeekOrigin.Current);
						continue;
					}
					if (num9 != 2147625796u)
					{
						continue;
					}
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(28L, SeekOrigin.Current);
						brVar6.Seek(12L, SeekOrigin.Current);
						continue;
					}
					newColors[index] = new Color32(brVar6.ReadByte(0), brVar6.ReadByte(1), brVar6.ReadByte(2), byte.MaxValue);
					newColors[index + 1] = new Color32(brVar6.ReadByte(4), brVar6.ReadByte(5), brVar6.ReadByte(6), byte.MaxValue);
					newColors[index + 2] = new Color32(brVar6.ReadByte(8), brVar6.ReadByte(9), brVar6.ReadByte(10), byte.MaxValue);
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					int num49 = DAT_1C[brVar13.ReadUInt16(26) & 0x3FFF];
					int num50 = materialIDs[num49];
					Rect rect11 = mainT[num49];
					float num51 = Mathf.Clamp((float)atlas.width * rect11.width - 1f, 1f, atlas.width);
					float num52 = Mathf.Clamp((float)atlas.height * rect11.height - 1f, 1f, atlas.height);
					newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num51, pixelSnapMin, pixelSnapMax) * rect11.width + rect11.x, -1f + (rect11.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num52, pixelSnapMin, pixelSnapMax) * rect11.height) + rect11.y + 1f);
					newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num51, pixelSnapMin, pixelSnapMax) * rect11.width + rect11.x, -1f + (rect11.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num52, pixelSnapMin, pixelSnapMax) * rect11.height) + rect11.y + 1f);
					newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(24) / num51, pixelSnapMin, pixelSnapMax) * rect11.width + rect11.x, -1f + (rect11.height - Mathf.Clamp((float)(int)brVar13.ReadByte(25) / num52, pixelSnapMin, pixelSnapMax) * rect11.height) + rect11.y + 1f);
					newTriangles[num50][index2[num50]] = index + 2;
					newTriangles[num50][index2[num50] + 1] = index + 1;
					newTriangles[num50][index2[num50] + 2] = index;
					index += 3;
					index2[num50] += 3;
					brVar13.Seek(28L, SeekOrigin.Current);
					brVar6.Seek(12L, SeekOrigin.Current);
				}
				else if (num9 != 2147625852u)
				{
					if (num9 != 2147626068u)
					{
						continue;
					}
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(24L, SeekOrigin.Current);
						continue;
					}
					int num53 = brVar13.ReadUInt16(16) & 0x3FFF;
					num54 = materialIDs[num53];
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					Color32 color13 = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
					newColors[index] = color13;
					newColors[index + 1] = color13;
					newColors[index + 2] = color13;
					if (num53 != 16381)
					{
						num6 = brVar13.ReadInt16(10);
						Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
						Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
						Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
						Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
						int num55 = brVar13.ReadUInt16(18);
						int num56 = num55 << 16 >> 24;
						int num57 = Coprocessor.mathsAccumulator.mac2 >> num55;
						int num58 = Coprocessor.mathsAccumulator.mac1 >> num55;
						if (num56 - num57 < 0)
						{
							num57 = num56;
						}
						num58 += num57 << 8;
						num6 = brVar13.ReadInt16(12);
						Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
						Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
						Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
						num58 += (int)(1052672u >> num55);
						Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
						Vector2Int vector2Int = new Vector2Int(num58 & 0xFF, (num58 >> 8) & 0xFF);
						num57 = Coprocessor.mathsAccumulator.mac2 >> num55;
						num58 = Coprocessor.mathsAccumulator.mac1 >> num55;
						if (num56 - num57 < 0)
						{
							num57 = num56;
						}
						num58 += num57 << 8;
						num6 = brVar13.ReadInt16(14);
						Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
						Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
						Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
						num58 += (int)(1052672u >> num55);
						Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
						Vector2Int vector2Int2 = new Vector2Int(num58 & 0xFF, (num58 >> 8) & 0xFF);
						num57 = Coprocessor.mathsAccumulator.mac2 >> num55;
						num58 = Coprocessor.mathsAccumulator.mac1 >> num55;
						if (num56 - num57 < 0)
						{
							num57 = num56;
						}
						num58 += num57 << 8;
						num58 += (int)(1052672u >> num55);
						Vector2Int vector2Int3 = new Vector2Int(num58 & 0xFF, (num58 >> 8) & 0xFF);
						float num59 = 64f;
						float num60 = 64f;
						if (num53 == 16383 || num53 == 65535)
						{
							num59 = reflections.width - 1;
							num60 = reflections.height - 1;
						}
						else
						{
							if (num53 != 16382)
							{
								Rect rect12 = mainT[num53];
								num59 = Mathf.Clamp((float)atlas.width * rect12.width - 1f, 1f, atlas.width);
								num60 = Mathf.Clamp((float)atlas.height * rect12.height - 1f, 1f, atlas.height);
								newUVs[index] = new Vector2(Mathf.Clamp((float)vector2Int.x / num59, pixelSnapMin, pixelSnapMax) * rect12.width + rect12.x, -1f + (rect12.height - Mathf.Clamp((float)vector2Int.y / num60, pixelSnapMin, pixelSnapMax) * rect12.height) + rect12.y + 1f);
								newUVs[index + 1] = new Vector2(Mathf.Clamp((float)vector2Int2.x / num59, pixelSnapMin, pixelSnapMax) * rect12.width + rect12.x, -1f + (rect12.height - Mathf.Clamp((float)vector2Int2.y / num60, pixelSnapMin, pixelSnapMax) * rect12.height) + rect12.y + 1f);
								newUVs[index + 2] = new Vector2(Mathf.Clamp((float)vector2Int3.x / num59, pixelSnapMin, pixelSnapMax) * rect12.width + rect12.x, -1f + (rect12.height - Mathf.Clamp((float)vector2Int3.y / num60, pixelSnapMin, pixelSnapMax) * rect12.height) + rect12.y + 1f);
								goto IL_3e4c;
							}
							num59 = glossiness.width - 1;
							num60 = glossiness.height - 1;
						}
						newUVs[index] = new Vector2((float)vector2Int.x / num59, 1f - (float)vector2Int.y / num60);
						newUVs[index + 1] = new Vector2((float)vector2Int2.x / num59, 1f - (float)vector2Int2.y / num60);
						newUVs[index + 2] = new Vector2((float)vector2Int3.x / num59, 1f - (float)vector2Int3.y / num60);
						goto IL_3e4c;
					}
					num6 = brVar13.ReadUInt16(4);
					Coprocessor.vector0.vx0 = brVar3.ReadInt16(num6);
					Coprocessor.vector0.vy0 = brVar3.ReadInt16(num6 + 2);
					Coprocessor.vector0.vz0 = brVar3.ReadInt16(num6 + 4);
					Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.TR, 12, lm: false);
					int mac = Coprocessor.mathsAccumulator.mac1;
					int mac2 = Coprocessor.mathsAccumulator.mac2;
					int ir5 = Coprocessor.mathsAccumulator.mac3;
					num6 = brVar13.ReadInt16(10);
					Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
					Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
					Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
					Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
					int ir3 = Coprocessor.mathsAccumulator.mac1;
					int ir = Coprocessor.mathsAccumulator.mac2;
					int ir2 = Coprocessor.mathsAccumulator.mac3;
					ir = ir3 * mac + ir * mac2 + ir2 * ir5 >> 11;
					ir3 = Coprocessor.mathsAccumulator.mac1;
					mac += ir * ir3 >> 12;
					ir3 = Coprocessor.mathsAccumulator.mac2;
					mac2 += ir * ir3 >> 12;
					ir3 = Coprocessor.mathsAccumulator.mac3;
					ir5 += ir * ir3 >> 12;
					num6 = brVar13.ReadUInt16(6);
					Coprocessor.vector0.vx0 = brVar3.ReadInt16(num6);
					Coprocessor.vector0.vy0 = brVar3.ReadInt16(num6 + 2);
					Coprocessor.vector0.vz0 = brVar3.ReadInt16(num6 + 4);
					ir3 = mac;
					if (mac < 0)
					{
						ir3 = -mac;
					}
					Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.TR, 12, lm: false);
					ir = ir5;
					if (ir5 < 0)
					{
						ir = -ir5;
					}
					sbyte b = (ir3 >= ir) ? ((sbyte)(ir5 * 128 / mac)) : ((sbyte)(mac * 128 / ir5));
					Vector2Int vector2Int4 = default(Vector2Int);
					vector2Int4.y = (byte)(b - 128);
					ir3 = mac2;
					if (mac2 < 0)
					{
						ir3 = -mac2;
					}
					ir = ir5;
					if (ir5 < 0)
					{
						ir = -ir5;
					}
					mac2 = ((ir3 >= ir) ? (ir5 * 128 / mac2) : (mac2 * 128 / ir5));
					mac2 = brVar13.ReadByte(19) - mac2;
					if (mac2 < 0)
					{
						mac2 = 0;
					}
					vector2Int4.x = (byte)(mac2 + brVar13.ReadByte(18));
					mac = Coprocessor.mathsAccumulator.mac1;
					mac2 = Coprocessor.mathsAccumulator.mac2;
					ir5 = Coprocessor.mathsAccumulator.mac3;
					num6 = brVar13.ReadInt16(12);
					Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
					Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
					Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
					Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
					ir3 = Coprocessor.mathsAccumulator.mac1;
					ir = Coprocessor.mathsAccumulator.mac2;
					ir2 = Coprocessor.mathsAccumulator.mac3;
					ir = ir3 * mac + ir * mac2 + ir2 * ir5 >> 11;
					ir3 = Coprocessor.mathsAccumulator.mac1;
					mac += ir * ir3 >> 12;
					ir3 = Coprocessor.mathsAccumulator.mac2;
					mac2 += ir * ir3 >> 12;
					ir3 = Coprocessor.mathsAccumulator.mac3;
					ir5 += ir * ir3 >> 12;
					num6 = brVar13.ReadUInt16(8);
					Coprocessor.vector0.vx0 = brVar3.ReadInt16(num6);
					Coprocessor.vector0.vy0 = brVar3.ReadInt16(num6 + 2);
					Coprocessor.vector0.vz0 = brVar3.ReadInt16(num6 + 4);
					ir3 = mac;
					if (mac < 0)
					{
						ir3 = -mac;
					}
					Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.TR, 12, lm: false);
					ir = ir5;
					if (ir5 < 0)
					{
						ir = -ir5;
					}
					b = ((ir3 >= ir) ? ((sbyte)(ir5 * 128 / mac)) : ((sbyte)(mac * 128 / ir5)));
					Vector2Int vector2Int5 = default(Vector2Int);
					vector2Int5.y = (byte)(b - 128);
					ir3 = mac2;
					if (mac2 < 0)
					{
						ir3 = -mac2;
					}
					ir = ir5;
					if (ir5 < 0)
					{
						ir = -ir5;
					}
					mac2 = ((ir3 >= ir) ? (ir5 * 128 / mac2) : (mac2 * 128 / ir5));
					mac2 = brVar13.ReadByte(19) - mac2;
					if (mac2 < 0)
					{
						mac2 = 0;
					}
					vector2Int5.x = (byte)(mac2 + brVar13.ReadByte(18));
					mac = Coprocessor.mathsAccumulator.mac1;
					mac2 = Coprocessor.mathsAccumulator.mac2;
					ir5 = Coprocessor.mathsAccumulator.mac3;
					num6 = brVar13.ReadInt16(14);
					Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
					Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
					Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
					Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
					ir3 = Coprocessor.mathsAccumulator.mac1;
					ir = Coprocessor.mathsAccumulator.mac2;
					ir2 = Coprocessor.mathsAccumulator.mac3;
					ir = ir3 * mac + ir * mac2 + ir2 * ir5 >> 11;
					ir3 = Coprocessor.mathsAccumulator.mac1;
					mac += ir * ir3 >> 12;
					ir3 = Coprocessor.mathsAccumulator.mac2;
					mac2 += ir * ir3 >> 12;
					ir3 = Coprocessor.mathsAccumulator.mac3;
					ir5 += ir * ir3 >> 12;
					ir3 = mac;
					if (mac < 0)
					{
						ir3 = -mac;
					}
					ir = ir5;
					if (ir5 < 0)
					{
						ir = -ir5;
					}
					b = ((ir3 >= ir) ? ((sbyte)(ir5 * 128 / mac)) : ((sbyte)(mac * 128 / ir5)));
					Vector2Int vector2Int6 = default(Vector2Int);
					vector2Int6.y = (byte)(b - 128);
					ir3 = mac2;
					if (mac2 < 0)
					{
						ir3 = -mac2;
					}
					ir = ir5;
					if (ir5 < 0)
					{
						ir = -ir5;
					}
					mac2 = ((ir3 >= ir) ? (ir5 * 128 / mac2) : (mac2 * 128 / ir5));
					mac2 = brVar13.ReadByte(19) - mac2;
					if (mac2 < 0)
					{
						mac2 = 0;
					}
					vector2Int6.x = (byte)(mac2 + brVar13.ReadByte(18));
					float num61 = 64f;
					float num62 = 64f;
					if (num53 == 16381)
					{
						num61 = reflections.width - 1;
						num62 = reflections.height - 1;
						newUVs[index] = new Vector2((float)vector2Int4.x / num61, 1f - (float)vector2Int4.y / num62);
						newUVs[index + 1] = new Vector2((float)vector2Int5.x / num61, 1f - (float)vector2Int5.y / num62);
						newUVs[index + 2] = new Vector2((float)vector2Int6.x / num61, 1f - (float)vector2Int6.y / num62);
					}
					else
					{
						Rect rect13 = mainT[num53];
						num61 = Mathf.Clamp((float)atlas.width * rect13.width - 1f, 1f, atlas.width);
						num62 = Mathf.Clamp((float)atlas.height * rect13.height - 1f, 1f, atlas.height);
						vector2Int4.x %= (int)num61;
						vector2Int4.y %= (int)num62;
						vector2Int5.x %= (int)num61;
						vector2Int5.y %= (int)num62;
						vector2Int6.x %= (int)num61;
						vector2Int6.y %= (int)num62;
						newUVs[index] = new Vector2(Mathf.Clamp((float)vector2Int4.x / num61, pixelSnapMin, pixelSnapMax) * rect13.width + rect13.x, -1f + (rect13.height - Mathf.Clamp((float)vector2Int4.y / num62, pixelSnapMin, pixelSnapMax) * rect13.height) + rect13.y + 1f);
						newUVs[index + 1] = new Vector2(Mathf.Clamp((float)vector2Int5.x / num61, pixelSnapMin, pixelSnapMax) * rect13.width + rect13.x, -1f + (rect13.height - Mathf.Clamp((float)vector2Int5.y / num62, pixelSnapMin, pixelSnapMax) * rect13.height) + rect13.y + 1f);
						newUVs[index + 2] = new Vector2(Mathf.Clamp((float)vector2Int6.x / num61, pixelSnapMin, pixelSnapMax) * rect13.width + rect13.x, -1f + (rect13.height - Mathf.Clamp((float)vector2Int6.y / num62, pixelSnapMin, pixelSnapMax) * rect13.height) + rect13.y + 1f);
					}
					newTriangles[num54][index2[num54]] = index;
					newTriangles[num54][index2[num54] + 1] = index + 1;
					newTriangles[num54][index2[num54] + 2] = index + 2;
					index += 3;
					index2[num54] += 3;
					brVar13.Seek(24L, SeekOrigin.Current);
				}
				else
				{
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(28L, SeekOrigin.Current);
						continue;
					}
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					Coprocessor.colorCode.r = brVar13.ReadByte(0);
					Coprocessor.colorCode.g = brVar13.ReadByte(1);
					Coprocessor.colorCode.b = brVar13.ReadByte(2);
					Coprocessor.colorCode.code = (byte)(brVar13.ReadByte(3) + 8);
					num6 = brVar13.ReadInt16(10);
					num7 = brVar13.ReadInt16(12);
					num8 = brVar13.ReadInt16(14);
					Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
					Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
					Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
					Coprocessor.vector1.vx1 = brVar4.ReadInt16(num7);
					Coprocessor.vector1.vy1 = brVar4.ReadInt16(num7 + 2);
					Coprocessor.vector1.vz1 = brVar4.ReadInt16(num7 + 4);
					Coprocessor.vector2.vx2 = brVar4.ReadInt16(num8);
					Coprocessor.vector2.vy2 = brVar4.ReadInt16(num8 + 2);
					Coprocessor.vector2.vz2 = brVar4.ReadInt16(num8 + 4);
					Coprocessor.ExecuteNCCT(12, lm: true);
					newColors[index] = new Color32(Coprocessor.colorFIFO.r0, Coprocessor.colorFIFO.g0, Coprocessor.colorFIFO.b0, byte.MaxValue);
					newColors[index + 1] = new Color32(Coprocessor.colorFIFO.r1, Coprocessor.colorFIFO.g1, Coprocessor.colorFIFO.b1, byte.MaxValue);
					newColors[index + 2] = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, byte.MaxValue);
					int num63 = DAT_1C[brVar13.ReadUInt16(26) & 0x3FFF];
					int num64 = materialIDs[num63];
					Rect rect14 = mainT[num63];
					float num65 = Mathf.Clamp((float)atlas.width * rect14.width - 1f, 1f, atlas.width);
					float num66 = Mathf.Clamp((float)atlas.height * rect14.height - 1f, 1f, atlas.height);
					newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num65, pixelSnapMin, pixelSnapMax) * rect14.width + rect14.x, -1f + (rect14.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num66, pixelSnapMin, pixelSnapMax) * rect14.height) + rect14.y + 1f);
					newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num65, pixelSnapMin, pixelSnapMax) * rect14.width + rect14.x, -1f + (rect14.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num66, pixelSnapMin, pixelSnapMax) * rect14.height) + rect14.y + 1f);
					newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(24) / num65, pixelSnapMin, pixelSnapMax) * rect14.width + rect14.x, -1f + (rect14.height - Mathf.Clamp((float)(int)brVar13.ReadByte(25) / num66, pixelSnapMin, pixelSnapMax) * rect14.height) + rect14.y + 1f);
					newTriangles[num64][index2[num64]] = index + 2;
					newTriangles[num64][index2[num64] + 1] = index + 1;
					newTriangles[num64][index2[num64] + 2] = index;
					index += 3;
					index2[num64] += 3;
					brVar13.Seek(28L, SeekOrigin.Current);
				}
			}
			else if (num9 <= 2147626540u)
			{
				if (num9 != 2147626408u)
				{
					if (num9 != 2147626540u)
					{
						continue;
					}
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(24L, SeekOrigin.Current);
						continue;
					}
					Color32 color14 = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
					newColors[index] = color14;
					newColors[index + 1] = color14;
					newColors[index + 2] = color14;
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					int num67 = brVar13.ReadByte(22);
					int num68 = materialIDs[num67];
					Rect rect15 = mainT[num67];
					float num69 = Mathf.Clamp((float)atlas.width * rect15.width - 1f, 1f, atlas.width);
					float num70 = Mathf.Clamp((float)atlas.height * rect15.height - 1f, 1f, atlas.height);
					newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num69, pixelSnapMin, pixelSnapMax) * rect15.width + rect15.x, -1f + (rect15.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num70, pixelSnapMin, pixelSnapMax) * rect15.height) + rect15.y + 1f);
					newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num69, pixelSnapMin, pixelSnapMax) * rect15.width + rect15.x, -1f + (rect15.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num70, pixelSnapMin, pixelSnapMax) * rect15.height) + rect15.y + 1f);
					newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num69, pixelSnapMin, pixelSnapMax) * rect15.width + rect15.x, -1f + (rect15.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num70, pixelSnapMin, pixelSnapMax) * rect15.height) + rect15.y + 1f);
					newTriangles[num68][index2[num68]] = index + 2;
					newTriangles[num68][index2[num68] + 1] = index + 1;
					newTriangles[num68][index2[num68] + 2] = index;
					index += 3;
					index2[num68] += 3;
					brVar13.Seek(24L, SeekOrigin.Current);
				}
				else
				{
					Coprocessor.ExecuteNCLIP();
					if (i < faceStart)
					{
						brVar13.Seek(24L, SeekOrigin.Current);
						continue;
					}
					Color32 color15 = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
					newColors[index] = color15;
					newColors[index + 1] = color15;
					newColors[index + 2] = color15;
					newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
					newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
					newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
					int num71 = brVar13.ReadByte(22);
					int num72 = materialIDs[num71];
					Rect rect16 = mainT[num71];
					float num73 = Mathf.Clamp((float)atlas.width * rect16.width - 1f, 1f, atlas.width);
					float num74 = Mathf.Clamp((float)atlas.height * rect16.height - 1f, 1f, atlas.height);
					newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num73, pixelSnapMin, pixelSnapMax) * rect16.width + rect16.x, -1f + (rect16.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num74, pixelSnapMin, pixelSnapMax) * rect16.height) + rect16.y + 1f);
					newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num73, pixelSnapMin, pixelSnapMax) * rect16.width + rect16.x, -1f + (rect16.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num74, pixelSnapMin, pixelSnapMax) * rect16.height) + rect16.y + 1f);
					newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num73, pixelSnapMin, pixelSnapMax) * rect16.width + rect16.x, -1f + (rect16.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num74, pixelSnapMin, pixelSnapMax) * rect16.height) + rect16.y + 1f);
					newTriangles[num72][index2[num72]] = index + 2;
					newTriangles[num72][index2[num72] + 1] = index + 1;
					newTriangles[num72][index2[num72] + 2] = index;
					index += 3;
					index2[num72] += 3;
					brVar13.Seek(24L, SeekOrigin.Current);
				}
			}
			else
			{
				if (num9 != 2147626616u)
				{
					if (num9 != 2147626940u)
					{
						continue;
					}
					return;
				}
				Coprocessor.ExecuteNCLIP();
				if (i < faceStart)
				{
					brVar13.Seek(24L, SeekOrigin.Current);
					continue;
				}
				Color32 color16 = new Color32(brVar13.ReadByte(0), brVar13.ReadByte(1), brVar13.ReadByte(2), byte.MaxValue);
				newColors[index] = color16;
				newColors[index + 1] = color16;
				newColors[index + 2] = color16;
				newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
				newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
				newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
				int num75 = DAT_1C[brVar13.ReadUInt16(22) & 0x3FFF];
				int num76 = materialIDs[num75];
				Rect rect17 = mainT[num75];
				float num77 = Mathf.Clamp((float)atlas.width * rect17.width - 1f, 1f, atlas.width);
				float num78 = Mathf.Clamp((float)atlas.height * rect17.height - 1f, 1f, atlas.height);
				newUVs[index] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(12) / num77, pixelSnapMin, pixelSnapMax) * rect17.width + rect17.x, -1f + (rect17.height - Mathf.Clamp((float)(int)brVar13.ReadByte(13) / num78, pixelSnapMin, pixelSnapMax) * rect17.height) + rect17.y + 1f);
				newUVs[index + 1] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(16) / num77, pixelSnapMin, pixelSnapMax) * rect17.width + rect17.x, -1f + (rect17.height - Mathf.Clamp((float)(int)brVar13.ReadByte(17) / num78, pixelSnapMin, pixelSnapMax) * rect17.height) + rect17.y + 1f);
				newUVs[index + 2] = new Vector2(Mathf.Clamp((float)(int)brVar13.ReadByte(20) / num77, pixelSnapMin, pixelSnapMax) * rect17.width + rect17.x, -1f + (rect17.height - Mathf.Clamp((float)(int)brVar13.ReadByte(21) / num78, pixelSnapMin, pixelSnapMax) * rect17.height) + rect17.y + 1f);
				newTriangles[num76][index2[num76]] = index + 2;
				newTriangles[num76][index2[num76] + 1] = index + 1;
				newTriangles[num76][index2[num76] + 2] = index;
				index += 3;
				index2[num76] += 3;
				brVar13.Seek(24L, SeekOrigin.Current);
			}
			goto IL_76fd;
			IL_76fd:
			Coprocessor.ExecuteAVSZ3();
			ushort averageZ3 = Coprocessor.averageZ;
			continue;
			IL_1e51:
			Coprocessor.ExecuteNCLIP();
			if (i >= faceStart)
			{
				Coprocessor.ExecuteAVSZ3();
				newVertices[index] = new Vector3(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0) / translateFactor;
				newVertices[index + 1] = new Vector3(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1) / translateFactor;
				newVertices[index + 2] = new Vector3(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2) / translateFactor;
				Coprocessor.colorCode.r = brVar13.ReadByte(0);
				Coprocessor.colorCode.g = brVar13.ReadByte(1);
				Coprocessor.colorCode.b = brVar13.ReadByte(2);
				Coprocessor.colorCode.code = (byte)(brVar13.ReadByte(3) + 16);
				num6 = brVar13.ReadInt16(10);
				num7 = brVar13.ReadInt16(12);
				num8 = brVar13.ReadInt16(14);
				Coprocessor.vector0.vx0 = brVar4.ReadInt16(num6);
				Coprocessor.vector0.vy0 = brVar4.ReadInt16(num6 + 2);
				Coprocessor.vector0.vz0 = brVar4.ReadInt16(num6 + 4);
				Coprocessor.vector1.vx1 = brVar4.ReadInt16(num7);
				Coprocessor.vector1.vy1 = brVar4.ReadInt16(num7 + 2);
				Coprocessor.vector1.vz1 = brVar4.ReadInt16(num7 + 4);
				Coprocessor.vector2.vx2 = brVar4.ReadInt16(num8);
				Coprocessor.vector2.vy2 = brVar4.ReadInt16(num8 + 2);
				Coprocessor.vector2.vz2 = brVar4.ReadInt16(num8 + 4);
				Coprocessor.ExecuteNCCT(12, lm: true);
				ushort averageZ4 = Coprocessor.averageZ;
				newColors[index] = new Color32(Coprocessor.colorFIFO.r0, Coprocessor.colorFIFO.g0, Coprocessor.colorFIFO.b0, byte.MaxValue);
				newColors[index + 1] = new Color32(Coprocessor.colorFIFO.r1, Coprocessor.colorFIFO.g1, Coprocessor.colorFIFO.b1, byte.MaxValue);
				newColors[index + 2] = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, byte.MaxValue);
				newUVs[index] = new Vector2(0f, 0f);
				newUVs[index + 1] = new Vector2(0f, 0f);
				newUVs[index + 2] = new Vector2(0f, 0f);
				newTriangles[0][index2[0]] = index;
				newTriangles[0][index2[0] + 1] = index + 1;
				newTriangles[0][index2[0] + 2] = index + 2;
				index += 3;
				index2[0] += 3;
				brVar13.Seek(16L, SeekOrigin.Current);
			}
			else
			{
				brVar13.Seek(16L, SeekOrigin.Current);
			}
			continue;
			IL_3e4c:
			newTriangles[num54][index2[num54]] = index;
			newTriangles[num54][index2[num54] + 1] = index + 1;
			newTriangles[num54][index2[num54] + 2] = index + 2;
			index += 3;
			index2[num54] += 3;
			brVar13.Seek(24L, SeekOrigin.Current);
			goto IL_76fd;
		}
		CreateMeshData();
	}

	public void FUN_39A8(DELEGATE_79A0 param1)
	{
		int num = 0;
		MemoryStream memoryStream = new MemoryStream(faceStream);
		if (0 < faces)
		{
			using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.Default, leaveOpen: true))
			{
				for (int i = 0; i < faces; i++)
				{
					long num2 = binaryReader.BaseStream.Position;
					binaryReader.BaseStream.Seek(3L, SeekOrigin.Current);
					byte b = binaryReader.ReadByte();
					switch (((uint)b >> 2) & 0xF)
					{
					case 4u:
					case 5u:
					case 7u:
						num++;
						break;
					case 8u:
					case 9u:
					case 11u:
						num += 3;
						break;
					case 10u:
						binaryReader.BaseStream.Seek(6L, SeekOrigin.Current);
						num2 += binaryReader.ReadUInt16() * 8;
						break;
					}
					binaryReader.BaseStream.Seek(num2 + GameManager.DAT_854[((uint)b >> 2) & 0xF], SeekOrigin.Begin);
				}
				binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
			}
		}
		byte[] array = new byte[num << 2];
		MemoryStream memoryStream2 = new MemoryStream(array);
		DAT_14 = array;
		if (0 < faces)
		{
			using (BinaryReader binaryReader2 = new BinaryReader(memoryStream, Encoding.Default, leaveOpen: true))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream2, Encoding.Default, leaveOpen: true))
				{
					long num2;
					for (int j = 0; j < faces; binaryReader2.BaseStream.Seek(num2 + GameManager.DAT_854[(binaryReader2.ReadByte(3) >> 2) & 0xF], SeekOrigin.Begin), j++)
					{
						num2 = binaryReader2.BaseStream.Position;
						uint num3;
						MemoryStream memoryStream5;
						uint num4;
						long offset;
						byte b;
						MemoryStream memoryStream4;
						MemoryStream memoryStream3;
						switch (((uint)binaryReader2.ReadByte(3) >> 2) & 0xF)
						{
						case 4u:
							binaryWriter.Write(3, (byte)((binaryReader2.ReadByte(3) & 3) | 0x20));
							num3 = binaryReader2.ReadUInt16(4);
							memoryStream5 = new MemoryStream(vertexStream);
							num4 = binaryReader2.ReadUInt16(10);
							offset = binaryWriter.BaseStream.Position + 4;
							break;
						case 5u:
							binaryWriter.Write(3, (byte)((binaryReader2.ReadByte(3) & 3) | 0x24));
							num3 = binaryReader2.ReadUInt16(4);
							memoryStream5 = new MemoryStream(vertexStream);
							num4 = binaryReader2.ReadUInt16(10);
							offset = binaryWriter.BaseStream.Position + 4;
							break;
						case 7u:
							binaryWriter.Write(3, (byte)((binaryReader2.ReadByte(3) & 3) | 0x24));
							num3 = binaryReader2.ReadUInt16(4);
							memoryStream5 = new MemoryStream(vertexStream);
							num4 = binaryReader2.ReadUInt16(10);
							offset = binaryWriter.BaseStream.Position + 4;
							break;
						case 8u:
							b = (byte)((binaryReader2.ReadByte(3) & 3) | 0x30);
							goto IL_02a1;
						case 9u:
						case 11u:
							b = (byte)((binaryReader2.ReadByte(3) & 3) | 0x34);
							goto IL_02a1;
						case 10u:
							num2 += binaryReader2.ReadUInt16(10) * 8;
							continue;
						default:
							continue;
							IL_02a1:
							binaryWriter.Write(11, b);
							binaryWriter.Write(7, b);
							binaryWriter.Write(3, b);
							memoryStream3 = new MemoryStream(vertexStream);
							memoryStream3.Seek(binaryReader2.ReadUInt16(4), SeekOrigin.Begin);
							memoryStream4 = new MemoryStream(normalStream);
							memoryStream4.Seek(binaryReader2.ReadUInt16(10), SeekOrigin.Begin);
							param1(memoryStream2, memoryStream, memoryStream3, memoryStream4);
							binaryWriter.Seek(1, SeekOrigin.Current);
							memoryStream3.Seek(binaryReader2.ReadUInt16(6), SeekOrigin.Begin);
							memoryStream4.Seek(binaryReader2.ReadUInt16(12), SeekOrigin.Begin);
							param1(memoryStream2, memoryStream, memoryStream3, memoryStream4);
							binaryWriter.Seek(1, SeekOrigin.Current);
							offset = binaryWriter.BaseStream.Position + 4;
							num3 = binaryReader2.ReadUInt16(8);
							memoryStream5 = new MemoryStream(vertexStream);
							num4 = binaryReader2.ReadUInt16(14);
							break;
						}
						memoryStream5.Seek(num3, SeekOrigin.Begin);
						memoryStream3 = new MemoryStream(normalStream);
						memoryStream3.Seek(num4, SeekOrigin.Begin);
						param1(memoryStream2, memoryStream, memoryStream5, memoryStream3);
						binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
					}
				}
			}
		}
	}
}
