using System.IO;
using UnityEngine;

public class RECT_DB : MonoBehaviour
{
	public short type;

	public short id;

	public short[] array;

	private void Awake()
	{
		VigTuple2 item = new VigTuple2(type, id, array);
		GameManager.instance.DAT_10D8.Add(item);
	}

	public bool LoadDB(string assetPath)
	{
		Object.FindObjectOfType<LevelManager>();
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			if (binaryReader == null)
			{
				return false;
			}
			array = new short[4];
			short num = binaryReader.ReadInt16BE();
			array[0] = num;
			num = binaryReader.ReadInt16BE();
			array[1] = num;
			short num2 = binaryReader.ReadInt16BE();
			array[2] = (short)(num2 - array[0] + 1);
			num2 = binaryReader.ReadInt16BE();
			array[3] = (short)(num2 - array[1] + 1);
			binaryReader.ReadInt16BE();
			num = (type = binaryReader.ReadInt16BE());
			num = (id = binaryReader.ReadInt16BE());
		}
		return true;
	}
}
