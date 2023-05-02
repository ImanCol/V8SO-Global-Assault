using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

public class Junction : MonoBehaviour
{
	private struct JunctionJob : IJob
	{
		public NativeArray<int> indicies;

		public int DAT_1C;

		public ushort DAT_2C;

		public short DAT_2E;

		public NativeArray<Vector3Int> _DAT_20;

		public NativeArray<short> _DAT_26;

		public NativeArray<Vector3Int> _DAT_28;

		public NativeArray<short> _DAT_2E;

		public Vector3Int local_18;

		public Matrix3x3 m33;

		public NativeArray<MyVertex> vertexBuffer;

		public NativeArray<ushort> indexBuffer;

		public void Execute()
		{
			int translateFactor = GameManager.instance.translateFactor2;
			VigTerrain terrain = LevelManager.instance.terrain;
			int num = 0;
			Utilities.SetRotMatrix2(m33);
			Coprocessor2.translationVector._trx = local_18.x >> 8;
			Coprocessor2.translationVector._try = local_18.y >> 8;
			Coprocessor2.translationVector._trz = local_18.z >> 8;
			int num2 = 0;
			uint num3 = 44u;
			if ((DAT_2C & 2) != 0)
			{
				num3 = 60u;
			}
			if ((DAT_2C & 0x100) != 0)
			{
				num3 |= 2;
			}
			ushort num4 = (ushort)DAT_2E;
			for (int i = 0; i < 32; i++)
			{
				local_f0[i] = new Color32(terrain.DAT_B9370[i].r, terrain.DAT_B9370[i].g, terrain.DAT_B9370[i].b, (byte)num3);
			}
			Coprocessor2.vector0.vx0 = (short)_DAT_20[0].x;
			Coprocessor2.vector0.vy0 = (short)_DAT_20[0].y;
			Coprocessor2.vector0.vz0 = (short)_DAT_20[0].z;
			Coprocessor2.ExecuteRTPS(12, lm: false);
			Coprocessor2.vector0.vx0 = (short)_DAT_28[0].x;
			Coprocessor2.vector0.vy0 = (short)_DAT_28[0].y;
			Coprocessor2.vector0.vz0 = (short)_DAT_28[0].z;
			Coprocessor2.ExecuteRTPS(12, lm: false);
			if (0 < DAT_1C)
			{
				for (int j = 0; j < DAT_1C; j++)
				{
					int num5 = j + 1;
					Coprocessor2.vector0.vx0 = (short)_DAT_20[num5].x;
					Coprocessor2.vector0.vy0 = (short)_DAT_20[num5].y;
					Coprocessor2.vector0.vz0 = (short)_DAT_20[num5].z;
					Coprocessor2.ExecuteRTPS(12, lm: false);
					Coprocessor2.ExecuteNCLIP();
					int mac = Coprocessor2.mathsAccumulator.mac0;
					mac = Coprocessor2.screenZFIFO.sz2;
					if (mac < num4)
					{
						mac = Coprocessor2.screenZFIFO.sz1;
						if (-1 < mac || -1 < Coprocessor2.screenZFIFO.sz2 || -1 < Coprocessor2.screenZFIFO.sz3)
						{
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy0 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx0);
							Vector3 vector = new Vector3(Coprocessor2.screenXYZFIFO.sx0, -Coprocessor2.screenXYZFIFO.sy0, Coprocessor2.screenXYZFIFO.sz0) / translateFactor;
							verts[2] = vector;
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy1 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx1);
							vector = new Vector3(Coprocessor2.screenXYZFIFO.sx1, -Coprocessor2.screenXYZFIFO.sy1, Coprocessor2.screenXYZFIFO.sz1) / translateFactor;
							verts[18] = vector;
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy2 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx2);
							vector = new Vector3(Coprocessor2.screenXYZFIFO.sx2, -Coprocessor2.screenXYZFIFO.sy2, Coprocessor2.screenXYZFIFO.sz2) / translateFactor;
							verts[34] = vector;
							uint num6 = (uint)(((Coprocessor2.screenXYFIFO.sy0 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx0) << 16 >> 16);
							num3 = (uint)(((Coprocessor2.screenXYFIFO.sy1 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx1) << 16 >> 16);
							uint num7 = num3;
							if ((int)num6 < (int)num3)
							{
								num7 = num6;
							}
							if ((int)num3 < (int)num6)
							{
								num3 = num6;
							}
							num6 = (uint)(((Coprocessor2.screenXYFIFO.sy2 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx2) << 16 >> 16);
							uint num8 = num6;
							if ((int)num7 < (int)num6)
							{
								num8 = num7;
							}
							if ((int)num6 < (int)num3)
							{
								num6 = num3;
							}
							int sz = Coprocessor2.screenZFIFO.sz1;
							mac = Coprocessor2.screenZFIFO.sz2;
							int sz2 = Coprocessor2.screenZFIFO.sz3;
							int num9 = sz * 4 + (mac - sz) + (sz2 - sz);
							Coprocessor2.vector0.vx0 = (short)_DAT_28[num5].x;
							Coprocessor2.vector0.vy0 = (short)_DAT_28[num5].y;
							Coprocessor2.vector0.vz0 = (short)_DAT_28[num5].z;
							Coprocessor2.vector1.vx1 = (short)((_DAT_20[num2].x + _DAT_28[num5 - 1].x) / 2);
							Coprocessor2.vector1.vy1 = (short)((_DAT_20[num5 - 1].y + _DAT_28[num5 - 1].y) / 2);
							Coprocessor2.vector1.vz1 = (short)((_DAT_20[num5 - 1].z + _DAT_28[num5 - 1].z) / 2);
							int num10 = (_DAT_20[num5 - 1].y + _DAT_20[num5].y) / 2;
							Coprocessor2.vector2.vx2 = (short)((_DAT_20[num2].x + _DAT_20[num5].x) / 2);
							Coprocessor2.vector2.vy2 = (short)num10;
							Coprocessor2.vector2.vz2 = (short)((_DAT_20[num5 - 1].z + _DAT_20[num5].z) / 2);
							Coprocessor2.ExecuteRTPT(12, lm: false);
							colors[1] = local_f0[_DAT_26[num5 - 1] >> 2];
							colors[17] = local_f0[_DAT_2E[num5 - 1] >> 2];
							colors[33] = local_f0[_DAT_26[num5] >> 2];
							colors[49] = local_f0[_DAT_2E[num5] >> 2];
							num3 = (uint)(((Coprocessor2.screenXYFIFO.sy0 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx0) << 16 >> 16);
							num7 = num3;
							if ((int)num8 < (int)num3)
							{
								num7 = num8;
							}
							if (((int)num3 < (int)num6) ? true : false)
							{
								num3 = num6;
							}
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy0 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx0);
							vector = new Vector3(Coprocessor2.screenXYZFIFO.sx0, -Coprocessor2.screenXYZFIFO.sy0, Coprocessor2.screenXYZFIFO.sz0) / translateFactor;
							verts[50] = vector;
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy1 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx1);
							vector = new Vector3(Coprocessor2.screenXYZFIFO.sx1, -Coprocessor2.screenXYZFIFO.sy1, Coprocessor2.screenXYZFIFO.sz1) / translateFactor;
							verts[15] = vector;
							verts[5] = vector;
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy2 << 16) | (ushort)Coprocessor2.screenXYFIFO.sy2);
							vector = new Vector3(Coprocessor2.screenXYZFIFO.sx2, -Coprocessor2.screenXYZFIFO.sy2, Coprocessor2.screenXYZFIFO.sz2) / translateFactor;
							verts[28] = vector;
							verts[8] = vector;
							num10 = 0;
							if (0 < num9)
							{
								num10 = num9;
							}
							num10 = num9 + (mac - sz) * 2;
							mac = 0;
							if (0 < num10)
							{
								mac = num10;
							}
							sz2 = (sz2 - sz) * 2;
							num9 += sz2;
							mac = 0;
							if (0 < num9)
							{
								mac = num9;
							}
							num10 += sz2;
							mac = 0;
							if (0 < num10)
							{
								mac = num10;
							}
							Coprocessor2.vector0.vx0 = (short)((_DAT_28[num5 - 1].x + _DAT_28[num5].x) / 2);
							Coprocessor2.vector0.vy0 = (short)((_DAT_28[num5 - 1].y + _DAT_28[num5].y) / 2);
							Coprocessor2.vector0.vz0 = (short)((_DAT_28[num5 - 1].z + _DAT_28[num5].z) / 2);
							num10 = (_DAT_20[num5].y + _DAT_28[num5].y) / 2;
							Coprocessor2.vector1.vx1 = (short)((_DAT_20[num5].x + _DAT_28[num5].x) / 2);
							Coprocessor2.vector1.vy1 = (short)num10;
							Coprocessor2.vector1.vz1 = (short)((_DAT_20[num5].z + _DAT_28[num5].z) / 2);
							Coprocessor2.vector2.vx2 = (short)((_DAT_28[num5 - 1].x + _DAT_20[num5].x) / 2);
							Coprocessor2.vector2.vy2 = (short)((_DAT_28[num5 - 1].y + _DAT_20[num5].y) / 2);
							Coprocessor2.vector2.vz2 = (short)((_DAT_28[num5 - 1].z + _DAT_20[num5].z) / 2);
							Coprocessor2.ExecuteRTPT(12, lm: false);
							Color32 color = local_f0[_DAT_26[num5 - 1] + _DAT_2E[num5 - 1] >> 3];
							colors[14] = color;
							colors[4] = color;
							color = local_f0[_DAT_26[num5 - 1] + _DAT_26[num5] >> 3];
							colors[27] = color;
							colors[7] = color;
							color = local_f0[_DAT_26[num5] + _DAT_2E[num5] >> 3];
							colors[46] = color;
							colors[36] = color;
							color = local_f0[_DAT_2E[num5 - 1] + _DAT_2E[num5] >> 3];
							colors[43] = color;
							colors[23] = color;
							color = local_f0[_DAT_2E[num5 - 1] + _DAT_26[num5] >> 3];
							colors[40] = color;
							colors[30] = color;
							colors[20] = color;
							colors[10] = color;
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy0 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx0);
							vector = new Vector3(Coprocessor2.screenXYZFIFO.sx0, -Coprocessor2.screenXYZFIFO.sy0, Coprocessor2.screenXYZFIFO.sz0) / translateFactor;
							verts[44] = vector;
							verts[24] = vector;
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy1 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx1);
							vector = new Vector3(Coprocessor2.screenXYZFIFO.sx1, -Coprocessor2.screenXYZFIFO.sy1, Coprocessor2.screenXYZFIFO.sz1) / translateFactor;
							verts[47] = vector;
							verts[37] = vector;
							num3 = (uint)((Coprocessor2.screenXYFIFO.sy2 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx2);
							vector = new Vector3(Coprocessor2.screenXYZFIFO.sx2, -Coprocessor2.screenXYZFIFO.sy2, Coprocessor2.screenXYZFIFO.sz2) / translateFactor;
							verts[41] = vector;
							verts[31] = vector;
							verts[21] = vector;
							verts[11] = vector;
							Mathf.Clamp(Vector3.Distance(position + verts[11], cameraPosition) / 18f, 0f, 15f);
							vertexBuffer[num] = new MyVertex(verts[2], colors[1], new Vector2(0f, 0f));
							vertexBuffer[num + 1] = new MyVertex(verts[5], colors[4], new Vector2(0.5f, 0f));
							vertexBuffer[num + 2] = new MyVertex(verts[8], colors[7], new Vector2(0f, 0.5f));
							num += 3;
							vertexBuffer[num] = new MyVertex(verts[5], colors[4], new Vector2(0.5f, 0f));
							vertexBuffer[num + 1] = new MyVertex(verts[8], colors[7], new Vector2(0f, 0.5f));
							vertexBuffer[num + 2] = new MyVertex(verts[11], colors[10], new Vector2(0.5f, 0.5f));
							num += 3;
							vertexBuffer[num] = new MyVertex(verts[15], colors[14], new Vector2(0.5f, 0f));
							vertexBuffer[num + 1] = new MyVertex(verts[18], colors[17], new Vector2(1f, 0f));
							vertexBuffer[num + 2] = new MyVertex(verts[21], colors[20], new Vector2(0.5f, 0.5f));
							num += 3;
							vertexBuffer[num] = new MyVertex(verts[18], colors[17], new Vector2(1f, 0f));
							vertexBuffer[num + 1] = new MyVertex(verts[21], colors[20], new Vector2(0.5f, 0.5f));
							vertexBuffer[num + 2] = new MyVertex(verts[24], colors[23], new Vector2(1f, 0.5f));
							num += 3;
							vertexBuffer[num] = new MyVertex(verts[28], colors[27], new Vector2(0f, 0.5f));
							vertexBuffer[num + 1] = new MyVertex(verts[31], colors[30], new Vector2(0.5f, 0.5f));
							vertexBuffer[num + 2] = new MyVertex(verts[34], colors[33], new Vector2(0f, 1f));
							num += 3;
							vertexBuffer[num] = new MyVertex(verts[31], colors[30], new Vector2(0.5f, 0.5f));
							vertexBuffer[num + 1] = new MyVertex(verts[34], colors[33], new Vector2(0f, 1f));
							vertexBuffer[num + 2] = new MyVertex(verts[37], colors[36], new Vector2(0.5f, 1f));
							num += 3;
							vertexBuffer[num] = new MyVertex(verts[41], colors[40], new Vector2(0.5f, 0.5f));
							vertexBuffer[num + 1] = new MyVertex(verts[44], colors[43], new Vector2(1f, 0.5f));
							vertexBuffer[num + 2] = new MyVertex(verts[47], colors[46], new Vector2(0.5f, 1f));
							num += 3;
							vertexBuffer[num] = new MyVertex(verts[44], colors[43], new Vector2(1f, 0.5f));
							vertexBuffer[num + 1] = new MyVertex(verts[47], colors[46], new Vector2(0.5f, 1f));
							vertexBuffer[num + 2] = new MyVertex(verts[50], colors[49], new Vector2(1f, 1f));
							num += 3;
							Coprocessor2.vector0.vx0 = (short)_DAT_28[num5 - 1].x;
							Coprocessor2.vector0.vy0 = (short)_DAT_28[num5 - 1].y;
							Coprocessor2.vector0.vz0 = (short)_DAT_28[num5 - 1].z;
							Coprocessor2.vector1.vx1 = (short)_DAT_20[num5].x;
							Coprocessor2.vector1.vy1 = (short)_DAT_20[num5].y;
							Coprocessor2.vector1.vz1 = (short)_DAT_20[num5].z;
							Coprocessor2.vector2.vx2 = (short)_DAT_28[num5].x;
							Coprocessor2.vector2.vy2 = (short)_DAT_28[num5].y;
							Coprocessor2.vector2.vz2 = (short)_DAT_28[num5].z;
							Coprocessor2.ExecuteRTPT(12, lm: false);
						}
					}
					else
					{
						num3 = (uint)((Coprocessor2.screenXYFIFO.sy0 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx0);
						Vector3 vector = new Vector3(Coprocessor2.screenXYZFIFO.sx0, -Coprocessor2.screenXYZFIFO.sy0, Coprocessor2.screenXYZFIFO.sz0) / translateFactor;
						verts[15] = vector;
						num3 = (uint)((Coprocessor2.screenXYFIFO.sy1 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx1);
						vector = new Vector3(Coprocessor2.screenXYZFIFO.sx1, -Coprocessor2.screenXYZFIFO.sy1, Coprocessor2.screenXYZFIFO.sz1) / translateFactor;
						verts[18] = vector;
						num3 = (uint)((Coprocessor2.screenXYFIFO.sy2 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx2);
						vector = new Vector3(Coprocessor2.screenXYZFIFO.sx2, -Coprocessor2.screenXYZFIFO.sy2, Coprocessor2.screenXYZFIFO.sz2) / translateFactor;
						verts[21] = vector;
						Coprocessor2.vector0.vx0 = (short)_DAT_28[num5].x;
						Coprocessor2.vector0.vy0 = (short)_DAT_28[num5].y;
						Coprocessor2.vector0.vz0 = (short)_DAT_28[num5].z;
						Coprocessor2.ExecuteRTPS(12, lm: false);
						colors[14] = local_f0[_DAT_26[num5 - 1] >> 2];
						colors[17] = local_f0[_DAT_2E[num5 - 1] >> 2];
						colors[20] = local_f0[_DAT_26[num5] >> 2];
						colors[23] = local_f0[_DAT_2E[num5] >> 2];
						num3 = (uint)((Coprocessor2.screenXYFIFO.sy2 << 16) | (ushort)Coprocessor2.screenXYFIFO.sx2);
						vector = new Vector3(Coprocessor2.screenXYZFIFO.sx2, -Coprocessor2.screenXYZFIFO.sy2, Coprocessor2.screenXYZFIFO.sz2) / translateFactor;
						verts[24] = vector;
						Mathf.Clamp(Vector3.Distance(position + verts[15], cameraPosition) / 18f, 0f, 15f);
						vertexBuffer[num] = new MyVertex(verts[15], colors[14], new Vector2(0f, 0f));
						vertexBuffer[num + 1] = new MyVertex(verts[18], colors[17], new Vector2(1f, 0f));
						vertexBuffer[num + 2] = new MyVertex(verts[21], colors[20], new Vector2(0f, 1f));
						num += 3;
						vertexBuffer[num] = new MyVertex(verts[18], colors[17], new Vector2(1f, 0f));
						vertexBuffer[num + 1] = new MyVertex(verts[21], colors[20], new Vector2(0f, 1f));
						vertexBuffer[num + 2] = new MyVertex(verts[24], colors[23], new Vector2(1f, 1f));
						num += 3;
						Coprocessor2.ExecuteAVSZ4();
						mac = Coprocessor2.accumulator.ir0;
						if (mac < 0)
						{
							mac += 255;
						}
						mac = Coprocessor2.averageZ;
					}
					num2++;
				}
			}
			indicies[0] = num;
		}
	}

	public VigTransform vTransform;

	public XRTP_DB xrtp;

	public Vector3Int pos;

	public int DAT_18;

	public int DAT_1C;

	public List<Vector3Int> DAT_20;

	public List<short> DAT_26;

	public List<Vector3Int> DAT_28;

	public List<short> DAT_2E;

	private Mesh mesh;

	private Texture mainT;

	public NativeArray<Vector3Int> _DAT_20;

	public NativeArray<short> _DAT_26;

	public NativeArray<Vector3Int> _DAT_28;

	public NativeArray<short> _DAT_2E;

	private int VertexCount;

	private NativeArray<int> indicies;

	private NativeArray<ushort> indexBuffer;

	private NativeArray<MyVertex> vertexBuffer;

	private static Color32[] local_f0 = new Color32[32];

	private static Vector3[] verts = new Vector3[64];

	private static Color32[] colors = new Color32[64];

	private static Vector3 position;

	private static Vector3 cameraPosition;

	private static JunctionJob junctionJob;

	public static JobHandle junctionHandle;

	private void OnDestroy()
	{
		DisposeBuffers();
		_DAT_20.Dispose();
		_DAT_26.Dispose();
		_DAT_28.Dispose();
		_DAT_2E.Dispose();
	}

	private void Awake()
	{
		if (xrtp.timFarList.Count > 0)
		{
			mainT = xrtp.timFarList[0].mainTexture;
		}
		mesh = new Mesh();
		GetComponent<MeshFilter>().mesh = mesh;
		mesh.subMeshCount = 16;
	}

	private void Start()
	{
		VertexCount = 24 * DAT_1C;
		_DAT_20 = new NativeArray<Vector3Int>(DAT_20.ToArray(), Allocator.Persistent);
		_DAT_26 = new NativeArray<short>(DAT_26.ToArray(), Allocator.Persistent);
		_DAT_28 = new NativeArray<Vector3Int>(DAT_28.ToArray(), Allocator.Persistent);
		_DAT_2E = new NativeArray<short>(DAT_2E.ToArray(), Allocator.Persistent);
		AllocateBuffers();
		InitializeMesh();
	}

	private void Update()
	{
		base.transform.localPosition = new Vector3((float)vTransform.position.x / (float)GameManager.instance.translateFactor, (float)(-vTransform.position.y) / (float)GameManager.instance.translateFactor, (float)vTransform.position.z / (float)GameManager.instance.translateFactor);
	}

	private void DisposeBuffers()
	{
		if (indexBuffer.IsCreated)
		{
			indexBuffer.Dispose();
		}
		if (vertexBuffer.IsCreated)
		{
			vertexBuffer.Dispose();
		}
		if (indicies.IsCreated)
		{
			indicies.Dispose();
		}
	}

	private void AllocateBuffers()
	{
		indexBuffer = new NativeArray<ushort>(VertexCount, Allocator.Persistent);
		vertexBuffer = new NativeArray<MyVertex>(VertexCount, Allocator.Persistent);
		indicies = new NativeArray<int>(1, Allocator.Persistent);
		for (int i = 0; i < VertexCount; i += 6)
		{
			indexBuffer[i + 2] = (ushort)i;
			indexBuffer[i + 1] = (ushort)(i + 1);
			indexBuffer[i] = (ushort)(i + 2);
			indexBuffer[i + 5] = (ushort)(i + 5);
			indexBuffer[i + 4] = (ushort)(i + 4);
			indexBuffer[i + 3] = (ushort)(i + 3);
		}
	}

	private void InitializeMesh()
	{
		mesh.SetVertexBufferParams(VertexCount, new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3, 0), new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.Float32, 4), new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float32, 2));
		mesh.SetVertexBufferData(vertexBuffer, 0, 0, VertexCount);
		mesh.SetIndexBufferParams(VertexCount, IndexFormat.UInt16);
		mesh.SetIndexBufferData(indexBuffer, 0, 0, VertexCount);
		mesh.SetSubMesh(0, new SubMeshDescriptor(0, VertexCount));
	}

	private void UpdateMesh()
	{
		mesh.SetVertexBufferData(vertexBuffer, 0, 0, VertexCount);
		mesh.RecalculateBounds();
	}

	public void ClearRoadData()
	{
		for (int i = 0; i < indicies[0]; i++)
		{
			vertexBuffer[i] = new MyVertex(new Vector3(0f, 0f, 0f), default(Color32), new Vector2(0f, 0f));
		}
	}

	public void CreateRoadData()
	{
		UpdateMesh();
	}

	public void FUN_4F804(Vector3Int param1)
	{
		ClearRoadData();
		Camera defaultCamera = LevelManager.instance.defaultCamera;
		JunctionJob jobData = default(JunctionJob);
		jobData.indicies = indicies;
		jobData.DAT_1C = DAT_1C;
		jobData.DAT_2C = xrtp.DAT_2C;
		jobData.DAT_2E = xrtp.DAT_2E;
		jobData._DAT_20 = _DAT_20;
		jobData._DAT_26 = _DAT_26;
		jobData._DAT_28 = _DAT_28;
		jobData._DAT_2E = _DAT_2E;
		jobData.local_18 = param1;
		jobData.m33 = GameManager.instance.DAT_F00.rotation;
		jobData.vertexBuffer = vertexBuffer;
		jobData.indexBuffer = indexBuffer;
		junctionHandle = jobData.Schedule(junctionHandle);
		GameManager.updateJunc.Add(this);
	}
}
