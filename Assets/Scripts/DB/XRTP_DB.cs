using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class XRTP_DB : MonoBehaviour
{
	public List<Material> timFarList;

	public Vector3[] V3_DAT_0C;

	public Color32[] C32_DAT_0C;

	public Vector3[] V3_DAT_10;

	public Color32[] C32_DAT_10;

	public int DAT_14;

	public int DAT_18;

	public int DAT_1C;

	public int DAT_20;

	public int DAT_24;

	public int DAT_28;

	public ushort DAT_2C;

	public short DAT_2E;

	public short DAT_30;

	private string prefabPath;

	private string prefabName;

	private string apsolutePath;

	private void Reset()
	{
	}

	public void LoadDB(string assetPath)
	{
		LevelManager levelManager = UnityEngine.Object.FindObjectOfType<LevelManager>();
		string text = prefabPath;
		if (prefabPath.StartsWith(Application.dataPath))
		{
			text = "Assets" + prefabPath.Substring(Application.dataPath.Length);
		}
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			levelManager.xrtpList.Add(this);
			int num = DAT_24 = binaryReader.ReadInt32BE();
			num = (DAT_28 = binaryReader.ReadInt32BE());
			num = (DAT_1C = binaryReader.ReadUInt16BE());
			ushort num2 = DAT_2C = binaryReader.ReadUInt16BE();
			DAT_14 = 0;
			V3_DAT_0C = null;
			V3_DAT_10 = null;
			if (DAT_1C < 16)
			{
				DAT_1C = 48;
			}
			int num3 = DAT_28 >> 8;
			int num4 = DAT_24 >> 8;
			short num5 = (short)Utilities.SquareRoot(num3 * num3 + num4 * num4);
			num3 = DAT_24;
			DAT_30 = (short)(num5 - 128);
			if (num3 < 0)
			{
				num3 += 255;
			}
			num4 = DAT_28;
			if (num4 < 0)
			{
				num4 += 255;
			}
			num3 = (num3 >> 8) * (num4 >> 8);
			if (num3 < 0)
			{
				num3 += 127;
			}
			DAT_2E = (short)(num3 >> 7);
			if (12 < binaryReader.BaseStream.Length)
			{
				long position = binaryReader.BaseStream.Position;
				num4 = 0;
				timFarList = new List<Material>();
				Utilities.SetFarColor(levelManager.DAT_DDC.r, levelManager.DAT_DDC.g, levelManager.DAT_DDC.b);
				for (int i = 0; i < 16; i++)
				{
					binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);
					MemoryStream memoryStream = new MemoryStream();
					using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Default, leaveOpen: true))
					{
						binaryWriter.Write(binaryReader.ReadBytes(16));
						short num6 = binaryReader.ReadInt16();
						binaryWriter.Write(num6);
						binaryWriter.Write(binaryReader.ReadInt16());
						Utilities.FUN_18C54(binaryReader, num6, binaryWriter, num4);
						binaryWriter.Write(binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position)));
						binaryWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
					}
					using (BinaryReader binaryReader2 = new BinaryReader(memoryStream, Encoding.Default, leaveOpen: true))
					{
						string path = prefabPath + "/" + prefabName + "_FAR" + i.ToString().PadLeft(2, '0') + ".bmp";
						string text2 = text + "/" + prefabName + "_FAR" + i.ToString().PadLeft(2, '0') + ".bmp";
						string text3 = text + "/" + prefabName + "_FAR" + i.ToString().PadLeft(2, '0') + ".mat";
						binaryReader2.ReadInt32();
						IMP_TIM.LoadTIM(binaryReader2, path);
					}
					num4 += 256;
				}
			}
		}
	}
}
