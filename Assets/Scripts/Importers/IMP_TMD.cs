using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class IMP_TMD
{
	public static Mesh LoadAsset(string assetPath, Material[] collection, MeshRenderer renderer)
	{
		Mesh mesh = new Mesh();
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			binaryReader.ReadInt32();
			int num = binaryReader.ReadInt32();
			binaryReader.ReadInt32();
			int num2 = binaryReader.ReadInt32();
			int num3 = binaryReader.ReadInt32();
			binaryReader.ReadInt32();
			binaryReader.ReadInt16();
			binaryReader.ReadInt16();
			List<Vector3> list = new List<Vector3>();
			List<Vector3> list2 = new List<Vector3>();
			List<Vector2> list3 = new List<Vector2>();
			List<Color32> list4 = new List<Color32>();
			List<List<int>> list5 = new List<List<int>>();
			List<int> list6 = new List<int>();
			list5.Add(new List<int>());
			list6.Add(0);
			int i = 0;
			int num4 = 0;
			for (; i < num3; i++)
			{
				byte b = binaryReader.ReadByte();
				byte b2 = binaryReader.ReadByte();
				byte b3 = binaryReader.ReadByte();
				byte a = 0;
				int num5 = binaryReader.ReadByte();
				if (b == byte.MaxValue && b2 == byte.MaxValue && b3 == byte.MaxValue)
				{
					a = byte.MaxValue;
				}
				if (b == 128 && b2 == 128 && b3 == 128)
				{
					a = byte.MaxValue;
				}
				switch (num5)
				{
				case 4:
					list.AddRange(GetVertices(binaryReader, 3, num));
					list2.AddRange(GetNormalsByIndex(binaryReader, 3, num2, binaryReader.ReadInt16()));
					list3.AddRange(GetEmptyUVs(3));
					list5[0].Add(num4 * 3);
					list5[0].Add(num4 * 3 + 1);
					list5[0].Add(num4 * 3 + 2);
					num4++;
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					break;
				case 5:
				{
					list.AddRange(GetVertices(binaryReader, 3, num));
					list2.AddRange(GetEmptyNormals(3));
					binaryReader.ReadInt16();
					list3.AddRange(GetUVs(binaryReader, 3, collection));
					int item2 = binaryReader.ReadInt16() + 1;
					if (!list6.Contains(item2))
					{
						list6.Add(item2);
						list5.Add(new List<int>());
						mesh.subMeshCount++;
					}
					list5[list6.IndexOf(item2)].Add(num4 * 3);
					list5[list6.IndexOf(item2)].Add(num4 * 3 + 1);
					list5[list6.IndexOf(item2)].Add(num4 * 3 + 2);
					num4++;
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					break;
				}
				case 6:
					list.AddRange(GetVertices(binaryReader, 3, num));
					list2.AddRange(GetEmptyNormals(3));
					list3.AddRange(GetEmptyUVs(3));
					binaryReader.ReadInt16();
					list5[0].Add(num4 * 3);
					list5[0].Add(num4 * 3 + 1);
					list5[0].Add(num4 * 3 + 2);
					num4++;
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					break;
				case 8:
					list.AddRange(GetVertices(binaryReader, 3, num));
					list2.AddRange(GetNormals(binaryReader, 3, num2));
					list3.AddRange(GetEmptyUVs(3));
					list5[0].Add(num4 * 3);
					list5[0].Add(num4 * 3 + 1);
					list5[0].Add(num4 * 3 + 2);
					num4++;
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					break;
				case 9:
				{
					list.AddRange(GetVertices(binaryReader, 3, num));
					list2.AddRange(GetNormals(binaryReader, 3, num2));
					list3.AddRange(GetUVs(binaryReader, 3, collection));
					int item4 = binaryReader.ReadInt16() + 1;
					if (!list6.Contains(item4))
					{
						list6.Add(item4);
						list5.Add(new List<int>());
						mesh.subMeshCount++;
					}
					list5[list6.IndexOf(item4)].Add(num4 * 3);
					list5[list6.IndexOf(item4)].Add(num4 * 3 + 1);
					list5[list6.IndexOf(item4)].Add(num4 * 3 + 2);
					num4++;
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					break;
				}
				case 11:
				{
					list.AddRange(GetVertices(binaryReader, 3, num));
					list2.AddRange(GetNormals(binaryReader, 3, num2));
					list3.AddRange(GetUVsByIndex(binaryReader, 3, collection, 3));
					int item3 = 4;
					if (!list6.Contains(item3))
					{
						list6.Add(item3);
						list5.Add(new List<int>());
						mesh.subMeshCount++;
					}
					list5[list6.IndexOf(item3)].Add(num4 * 3);
					list5[list6.IndexOf(item3)].Add(num4 * 3 + 1);
					list5[list6.IndexOf(item3)].Add(num4 * 3 + 2);
					num4++;
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					break;
				}
				case 12:
					list.AddRange(GetVertices(binaryReader, 3, num));
					list2.AddRange(GetNormals(binaryReader, 3, num2));
					list3.AddRange(GetEmptyUVs(3));
					binaryReader.ReadInt16();
					binaryReader.ReadInt16();
					binaryReader.ReadInt32();
					list5[0].Add(num4 * 3);
					list5[0].Add(num4 * 3 + 1);
					list5[0].Add(num4 * 3 + 2);
					num4++;
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					break;
				case 28:
					binaryReader.BaseStream.Seek(20L, SeekOrigin.Current);
					break;
				case 31:
				{
					list.AddRange(GetVertices(binaryReader, 3, num));
					list2.AddRange(GetEmptyNormals(3));
					binaryReader.ReadInt16();
					list3.AddRange(GetUVs(binaryReader, 3, collection));
					int item = binaryReader.ReadByte() + 1;
					binaryReader.ReadByte();
					if (!list6.Contains(item))
					{
						list6.Add(item);
						list5.Add(new List<int>());
						mesh.subMeshCount++;
					}
					list5[list6.IndexOf(item)].Add(num4 * 3);
					list5[list6.IndexOf(item)].Add(num4 * 3 + 1);
					list5[list6.IndexOf(item)].Add(num4 * 3 + 2);
					num4++;
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					list4.Add(new Color32(b, b2, b3, a));
					break;
				}
				default:
					UnityEngine.Debug.LogError("Unkown header detected! Stream Position: " + binaryReader.BaseStream.Position.ToString());
					return null;
				}
			}
			mesh.SetVertices(list);
			mesh.SetColors(list4);
			mesh.SetNormals(list2);
			mesh.SetUVs(0, list3);
			for (int j = 0; j < list5.Count; j++)
			{
				mesh.SetTriangles(list5[j], j);
			}
			Material[] array = new Material[list6.Count];
			for (int k = 0; k < list6.Count; k++)
			{
				array[k] = collection[list6[k]];
			}
			renderer.sharedMaterials = array;
			UnityEngine.Debug.Log("Generated polys: " + mesh.triangles.Length.ToString());
			return mesh;
		}
	}

	private static List<Vector3> GetVertices(BinaryReader reader, int numIndices, long vertPosition)
	{
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		int translateFactor = GameManager.instance.translateFactor2;
		for (int i = 0; i < numIndices; i++)
		{
			list2.Add(reader.ReadInt16());
		}
		long position = reader.BaseStream.Position;
		for (int j = 0; j < numIndices; j++)
		{
			reader.BaseStream.Seek(vertPosition, SeekOrigin.Begin);
			reader.BaseStream.Seek(list2[j] * 8, SeekOrigin.Current);
			float x = (float)(reader.ReadInt16() << 8) / (float)translateFactor;
			float y = (0f - (float)(reader.ReadInt16() << 8)) / (float)translateFactor;
			float z = (float)(reader.ReadInt16() << 8) / (float)translateFactor;
			list.Add(new Vector3(x, y, z));
		}
		reader.BaseStream.Seek(position, SeekOrigin.Begin);
		return list;
	}

	private static List<Vector3> GetNormals(BinaryReader reader, int numIndices, long normalPosition)
	{
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		int translateFactor = GameManager.instance.translateFactor2;
		for (int i = 0; i < numIndices; i++)
		{
			list2.Add(reader.ReadInt16());
		}
		long position = reader.BaseStream.Position;
		for (int j = 0; j < numIndices; j++)
		{
			reader.BaseStream.Seek(normalPosition, SeekOrigin.Begin);
			reader.BaseStream.Seek(list2[j] * 8, SeekOrigin.Current);
			float x = (float)(reader.ReadInt16() << 8) / (float)translateFactor;
			float y = (0f - (float)(reader.ReadInt16() << 8)) / (float)translateFactor;
			float z = (float)(reader.ReadInt16() << 8) / (float)translateFactor;
			list.Add(new Vector3(x, y, z));
		}
		reader.BaseStream.Seek(position, SeekOrigin.Begin);
		return list;
	}

	private static List<Vector3> GetNormalsByIndex(BinaryReader reader, int numIndices, long normalPosition, int index)
	{
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		int translateFactor = GameManager.instance.translateFactor2;
		for (int i = 0; i < numIndices; i++)
		{
			list2.Add(index);
		}
		long position = reader.BaseStream.Position;
		for (int j = 0; j < numIndices; j++)
		{
			reader.BaseStream.Seek(normalPosition, SeekOrigin.Begin);
			reader.BaseStream.Seek(list2[j] * 8, SeekOrigin.Current);
			float x = (float)(reader.ReadInt16() << 8) / (float)translateFactor;
			float y = (0f - (float)(reader.ReadInt16() << 8)) / (float)translateFactor;
			float z = (float)(reader.ReadInt16() << 8) / (float)translateFactor;
			list.Add(new Vector3(x, y, z));
		}
		reader.BaseStream.Seek(position, SeekOrigin.Begin);
		return list;
	}

	private static List<Vector2> GetUVs(BinaryReader reader, int numIndices, Material[] materials)
	{
		List<Vector2> list = new List<Vector2>();
		long position = reader.BaseStream.Position;
		reader.BaseStream.Seek(numIndices * 4 - 2, SeekOrigin.Current);
		int num = reader.ReadByte() + 1;
		reader.BaseStream.Seek(position, SeekOrigin.Begin);
		for (int i = 0; i < numIndices; i++)
		{
			float x = (float)(int)reader.ReadByte() / (float)(materials[num].mainTexture.width - 1);
			float y = 1f - (float)(int)reader.ReadByte() / (float)(materials[num].mainTexture.height - 1);
			list.Add(new Vector2(x, y));
			reader.ReadInt16();
		}
		reader.BaseStream.Seek(-2L, SeekOrigin.Current);
		return list;
	}

	private static List<Vector2> GetUVsByIndex(BinaryReader reader, int numIndices, Material[] materials, int index)
	{
		List<Vector2> list = new List<Vector2>();
		long position = reader.BaseStream.Position;
		int num = index + 1;
		reader.BaseStream.Seek(position, SeekOrigin.Begin);
		for (int i = 0; i < numIndices; i++)
		{
			float x = (float)(int)reader.ReadByte() / (float)(materials[num].mainTexture.width - 1);
			float y = 1f - (float)(int)reader.ReadByte() / (float)(materials[num].mainTexture.height - 1);
			list.Add(new Vector2(x, y));
			reader.ReadInt16();
		}
		return list;
	}

	private static List<Vector3> GetEmptyNormals(int numIndices)
	{
		List<Vector3> list = new List<Vector3>();
		Vector3 item = new Vector3(0f, 0f, 0f);
		for (int i = 0; i < numIndices; i++)
		{
			list.Add(item);
		}
		return list;
	}

	private static List<Vector2> GetEmptyUVs(int numIndices)
	{
		List<Vector2> list = new List<Vector2>();
		Vector2 item = new Vector2(0f, 0f);
		for (int i = 0; i < numIndices; i++)
		{
			list.Add(item);
		}
		return list;
	}
}
