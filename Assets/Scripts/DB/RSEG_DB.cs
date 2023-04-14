using System.IO;
using UnityEngine;

public class RSEG_DB : MonoBehaviour
{
	public JUNC_DB[] DAT_00;

	public ushort DAT_08;

	public ushort DAT_0A;

	public ushort DAT_0C;

	public int[] DAT_10;

	public int[] DAT_14;

	public int DAT_20;

	public int DAT_24;

	public int DAT_28;

	public int DAT_2C;

	public int DAT_30;

	public int DAT_34;

	public bool LoadDB(string assetPath)
	{
		LevelManager levelManager = UnityEngine.Object.FindObjectOfType<LevelManager>();
		using (BinaryReader binaryReader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
		{
			if (binaryReader == null)
			{
				return false;
			}
			if (binaryReader.BaseStream.Length != 22)
			{
				ushort num = DAT_0A = binaryReader.ReadUInt16BE();
				num = (DAT_08 = binaryReader.ReadUInt16BE());
				num = (DAT_0C = binaryReader.ReadUInt16BE());
			}
			else
			{
				ushort num = DAT_0A = binaryReader.ReadByte();
				num = (DAT_08 = binaryReader.ReadByte());
				DAT_0C = 0;
			}
			int index = binaryReader.ReadUInt16BE();
			DAT_00 = new JUNC_DB[2];
			JUNC_DB jUNC_DB = levelManager.juncList[index];
			DAT_00[0] = jUNC_DB;
			index = binaryReader.ReadUInt16BE();
			JUNC_DB jUNC_DB2 = levelManager.juncList[index];
			DAT_00[1] = jUNC_DB2;
			DAT_10 = new int[2];
			index = binaryReader.ReadInt32BE();
			DAT_10[0] = index;
			DAT_14 = new int[2];
			index = binaryReader.ReadInt32BE();
			DAT_14[0] = index;
			index = binaryReader.ReadInt32BE();
			DAT_10[1] = index;
			index = binaryReader.ReadInt32BE();
			DAT_14[1] = index;
			RSEG_DB x = jUNC_DB.DAT_1C[0];
			int num2 = 0;
			while (x != null)
			{
				x = jUNC_DB.DAT_1C[num2 + 1];
				num2++;
			}
			jUNC_DB.DAT_1C[num2] = this;
			x = jUNC_DB2.DAT_1C[0];
			num2 = 0;
			while (x != null)
			{
				x = jUNC_DB2.DAT_1C[num2 + 1];
				num2++;
			}
			jUNC_DB2.DAT_1C[num2] = this;
			FUN_50EFC();
			return true;
		}
	}

	public void FUN_50EFC()
	{
		int num = DAT_00[0].DAT_00.x - DAT_00[1].DAT_00.x << 1;
		int num2 = DAT_10[0] - DAT_10[1];
		int num3 = (num2 << 1) + num2;
		num3 = num + num3;
		if (num3 < 0)
		{
			num3 += 15;
		}
		DAT_20 = num3 >> 4;
		int num4 = DAT_00[0].DAT_00.z - DAT_00[1].DAT_00.z << 1;
		num2 = DAT_14[0] - DAT_14[1];
		num3 = (num2 << 1) + num2;
		num3 = num4 + num3;
		if (num3 < 0)
		{
			num3 += 15;
		}
		DAT_24 = num3 >> 4;
		num3 = DAT_00[1].DAT_00.x - DAT_00[0].DAT_00.x;
		num2 = (num3 << 1) + num3;
		num3 = (DAT_10[0] << 1) + DAT_10[0] << 1;
		num2 -= num3;
		num3 = num2 + ((DAT_10[1] << 1) + DAT_10[1]);
		if (num3 < 0)
		{
			num3 += 15;
		}
		DAT_28 = num3 >> 4;
		num3 = DAT_00[1].DAT_00.z - DAT_00[0].DAT_00.z;
		num2 = (num3 << 1) + num3;
		num3 = (DAT_14[0] << 1) + DAT_14[0] << 1;
		num2 -= num3;
		num2 += (DAT_14[1] << 1) + DAT_14[1];
		if (num2 < 0)
		{
			num2 += 15;
		}
		DAT_2C = num2 >> 4;
		num2 = (DAT_10[0] << 1) + DAT_10[0];
		if (num2 < 0)
		{
			num2 += 15;
		}
		DAT_30 = num2 >> 4;
		num3 = (DAT_14[0] << 1) + DAT_14[0];
		if (num3 < 0)
		{
			num3 += 15;
		}
		DAT_34 = num3 >> 4;
	}

	public void FUN_285E4(int param1, ref Vector3Int param2, out Vector3Int param3)
	{
		int dAT_ = DAT_30;
		JUNC_DB jUNC_DB = DAT_00[0];
		int num = DAT_20 * param1 >> 12;
		int num2 = DAT_28 + num;
		int x = param2.x = (((num2 * param1 >> 12) + dAT_) * param1 >> 8) + jUNC_DB.DAT_00.x;
		num = ((num + num2 * 2) * param1 >> 12) + dAT_;
		if (num < 0)
		{
			num += 255;
		}
		param3 = default(Vector3Int);
		param3.x = num >> 8;
		dAT_ = DAT_34;
		num = DAT_24 * param1 >> 12;
		num2 = DAT_2C + num;
		int z = param2.z = (((num2 * param1 >> 12) + dAT_) * param1 >> 8) + jUNC_DB.DAT_00.z;
		ushort dAT_0C = DAT_0C;
		num = ((num + num2 * 2) * param1 >> 12) + dAT_;
		param3.y = 0;
		if (num < 0)
		{
			num += 255;
		}
		param3.z = num >> 8;
		if ((dAT_0C & 8) != 0)
		{
			param2.y = jUNC_DB.DAT_00.y;
		}
		else if ((dAT_0C & 1) != 0)
		{
			param2.y = jUNC_DB.DAT_00.y + (param1 * (DAT_00[1].DAT_00.y - jUNC_DB.DAT_00.y) >> 12);
		}
		else
		{
			num = (param2.y = GameManager.instance.terrain.FUN_1B750((uint)x, (uint)z));
		}
	}

	public long FUN_5105C(int param1, bool param2, ref VigTransform param3)
	{
		FUN_285E4(param1, ref param3.position, out Vector3Int param4);
		long result;
		Vector3Int n2;
		Vector3Int n;
		if ((DAT_0C & 1) == 0)
		{
			if ((DAT_0C & 8) == 0)
			{
				n = GameManager.instance.terrain.FUN_1B998((uint)param3.position.x, (uint)param3.position.z);
				n = Utilities.VectorNormal(n);
				param4.y = -(param4.x * n.x + param4.z * n.z) / n.y;
			}
			else
			{
				n = new Vector3Int(0, -4096, 0);
				param4.y = 0;
			}
			result = Utilities.VectorNormal2(param4, out n2);
		}
		else
		{
			param4.y = DAT_00[1].DAT_00.y - DAT_00[0].DAT_00.y;
			result = Utilities.VectorNormal2(param4, out n2);
			int x = n2.x;
			int num = x * n2.y;
			if (num < 0)
			{
				num += 4095;
			}
			int z = n2.z;
			n = new Vector3Int
			{
				x = num >> 12
			};
			num = x * x - z * z;
			z *= n2.y;
			if (num < 0)
			{
				num += 4095;
			}
			n.y = num >> 12;
			if (z < 0)
			{
				z += 4095;
			}
			n.z = z >> 12;
			n = Utilities.VectorNormal(n);
		}
		if (!param2)
		{
			n2.x = -n2.x;
			n2.y = -n2.y;
			n2.z = -n2.z;
		}
		Vector3Int vector3Int = Utilities.FUN_2A1E0(n, n2);
		param3.rotation.V00 = (short)(-vector3Int.x);
		param3.rotation.V10 = (short)(-vector3Int.y);
		param3.rotation.V20 = (short)(-vector3Int.z);
		param3.rotation.V01 = (short)(-n.x);
		param3.rotation.V11 = (short)(-n.y);
		param3.rotation.V21 = (short)(-n.z);
		param3.rotation.V02 = (short)n2.x;
		param3.rotation.V12 = (short)n2.y;
		param3.rotation.V22 = (short)n2.z;
		return result;
	}

	public int FUN_51334(Vector3Int param1)
	{
		int[] array = new int[17];
		int num = DAT_00[0].DAT_00.x;
		int num2 = DAT_00[0].DAT_00.z;
		int num3 = DAT_00[0].DAT_00.x + DAT_10[0];
		int num4 = DAT_00[0].DAT_00.z + DAT_14[0];
		int num5 = 0;
		int num6 = DAT_00[1].DAT_00.x + DAT_10[1];
		int num7 = 4096;
		int num8 = DAT_00[1].DAT_00.z + DAT_14[1];
		int num9 = 0;
		int num10 = DAT_00[1].DAT_00.x;
		int num11 = DAT_00[1].DAT_00.z;
		do
		{
			array[16] = (num3 + num6) / 2;
			int num12 = (num4 + num8) / 2;
			array[0] = num;
			array[1] = num2;
			array[14] = num10;
			array[15] = num11;
			array[2] = (num + num3) / 2;
			array[3] = (num2 + num4) / 2;
			array[4] = (array[2] + array[16]) / 2;
			array[5] = (array[3] + num12) / 2;
			num6 = (num6 + num10) / 2;
			num8 = (num8 + num11) / 2;
			array[12] = num6;
			array[13] = num8;
			num3 = (num6 + array[16]) / 2;
			num4 = (num8 + num12) / 2;
			array[10] = num3;
			array[11] = num4;
			array[8] = (array[4] + num3) / 2;
			array[9] = (array[5] + num4) / 2;
			array[6] = array[8];
			array[7] = array[9];
			num12 = 0;
			if (array[8] < num)
			{
				num12 = 3;
			}
			int num13 = 0;
			if (array[9] < num2)
			{
				num13 = 3;
			}
			int x = param1.x;
			int num14 = x - array[(3 - num12) * 2];
			int num15 = 0;
			if (0 < num14)
			{
				num15 = num14;
			}
			num14 = x - array[num12 * 2];
			num12 = 0;
			if (num14 < 0)
			{
				num12 = num14;
			}
			int z = param1.z;
			num14 = 0;
			if (0 < z - array[(3 - num13) * 2 + 1])
			{
				num14 = z - array[(3 - num13) * 2 + 1];
			}
			int num16 = 0;
			if (z - array[num13 * 2 + 1] < 0)
			{
				num16 = z - array[num13 * 2 + 1];
			}
			num13 = 0;
			if (num10 < array[8])
			{
				num13 = 3;
			}
			int num17 = 0;
			if (num11 < array[9])
			{
				num17 = 3;
			}
			int num18 = x - array[(3 - num13) * 2 + 8];
			int num19 = 0;
			if (0 < num18)
			{
				num19 = num18;
			}
			x -= array[num13 * 2 + 8];
			num13 = 0;
			if (x < 0)
			{
				num13 = x;
			}
			x = 0;
			if (0 < z - array[(3 - num17) * 2 + 9])
			{
				x = z - array[(3 - num17) * 2 + 9];
			}
			num18 = 0;
			if (z - array[num17 * 2 + 9] < 0)
			{
				num18 = z - array[num17 * 2 + 9];
			}
			if (num15 - num12 + (num14 - num16) < num19 - num13 + (x - num18))
			{
				num7 = (num5 + num7) / 2;
				num3 = array[2];
				num4 = array[3];
				num6 = array[4];
				num8 = array[5];
				num10 = array[8];
				num11 = array[9];
			}
			else
			{
				num5 = (num5 + num7) / 2;
				num = array[8];
				num2 = array[9];
			}
			num9++;
		}
		while (num9 < 8);
		return (num5 + num7) / 2;
	}

	public RSEG_DB FUN_512A8(int[] param1)
	{
		JUNC_DB jUNC_DB = DAT_00[param1[0]];
		int num = 0;
		if (jUNC_DB.DAT_11 != 0)
		{
			do
			{
				RSEG_DB rSEG_DB = jUNC_DB.DAT_1C[num];
				if (rSEG_DB != this && rSEG_DB.DAT_08 == DAT_08)
				{
					param1[0] = ((rSEG_DB.DAT_00[0] == jUNC_DB) ? 1 : 0);
					return jUNC_DB.DAT_1C[num];
				}
				num++;
			}
			while (num < jUNC_DB.DAT_11);
		}
		return null;
	}
}
