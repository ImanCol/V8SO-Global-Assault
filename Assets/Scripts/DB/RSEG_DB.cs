using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RSEG_DB : MonoBehaviour
{
    public JUNC_DB DAT_00; //0x00
    public JUNC_DB DAT_04; //0x04
    public ushort DAT_08; //0x08
    public ushort DAT_0A; //0x0A
    public ushort DAT_0C; //0x0C
    public int DAT_10; //0x10
    public int DAT_14; //0x14
    public int DAT_18; //0x18
    public int DAT_1C; //0x1C
    public int DAT_20; //0x20
    public int DAT_24; //0x24
    public int DAT_28; //0x28
    public int DAT_2C; //0x2C
    public int DAT_30; //0x30
    public int DAT_34; //0x34

    public void LoadDB(string assetPath)
    {
        ushort uVar1;
        int iVar3;
        RSEG_DB dbVar4;
        int iVar5;
        JUNC_DB dbVar6;
        JUNC_DB dbVar7;

        LevelManager levelManager = GameObject.Find("GameControl").GetComponent<LevelManager>();

        using (BinaryReader reader = new BinaryReader(File.Open(assetPath, FileMode.Open)))
        {
            if (reader.BaseStream.Length == 22)
            {
                uVar1 = reader.ReadByte();
                DAT_0A = uVar1;
                uVar1 = reader.ReadByte();
                DAT_08 = uVar1;
                DAT_0C = 0;
            }
            else
            {
                uVar1 = reader.ReadUInt16BE();
                DAT_0A = uVar1;
                uVar1 = reader.ReadUInt16BE();
                DAT_08 = uVar1;
                uVar1 = reader.ReadUInt16BE();
                DAT_0C = uVar1;
            }

            iVar3 = reader.ReadUInt16BE();
            dbVar7 = levelManager.juncList[iVar3];
            DAT_00 = dbVar7;
            iVar3 = reader.ReadUInt16BE();
            dbVar6 = levelManager.juncList[iVar3];
            DAT_04 = dbVar6;
            iVar3 = reader.ReadInt32BE();
            DAT_10 = iVar3;
            iVar3 = reader.ReadInt32BE();
            DAT_14 = iVar3;
            iVar3 = reader.ReadInt32BE();
            DAT_18 = iVar3;
            iVar3 = reader.ReadInt32BE();
            DAT_1C = iVar3;
            dbVar4 = dbVar7.DAT_1C[0];
            iVar5 = 0;

            while(dbVar4 != null)
            {
                dbVar4 = dbVar7.DAT_1C[iVar5 + 1];
                iVar5++;
            }

            dbVar7.DAT_1C[iVar5] = this;
            dbVar4 = dbVar6.DAT_1C[0];
            iVar5 = 0;

            while (dbVar4 != null)
            {
                dbVar4 = dbVar6.DAT_1C[iVar5 + 1];
                iVar5++;
            }

            dbVar6.DAT_1C[iVar5] = this;
            FUN_50EFC();
        }
    }

    private void FUN_50EFC()
    {
        int iVar1;
        int iVar2;
        int iVar3;

        iVar1 = DAT_00.DAT_00 - DAT_04.DAT_00 << 1; //r4
        iVar2 = DAT_10 - DAT_18; //r3
        iVar3 = (iVar2 << 1) + iVar2; //r2
        iVar3 = iVar1 + iVar3;

        if (iVar3 < 0)
            iVar3 += 15;

        DAT_20 = iVar3 >> 4;
        iVar1 = DAT_00.DAT_08 - DAT_04.DAT_08 << 1; //r4
        iVar2 = DAT_14 - DAT_1C; //r3
        iVar3 = (iVar2 << 1) + iVar2; //r2
        iVar3 = iVar1 + iVar3;

        if (iVar3 < 0)
            iVar3 += 15;

        DAT_24 = iVar3 >> 4;
        iVar3 = DAT_04.DAT_00 - DAT_00.DAT_00; //r2
        iVar2 = (iVar3 << 1) + iVar3; //r3
        iVar3 = (DAT_10 << 1) + DAT_10 << 1;
        iVar2 -= iVar3;
        iVar3 = iVar2 + ((DAT_18 << 1) + DAT_18);

        if (iVar3 < 0)
            iVar3 += 15;

        DAT_28 = iVar3 >> 4;
        iVar3 = DAT_04.DAT_08 - DAT_00.DAT_08; //r2
        iVar2 = (iVar3 << 1) + iVar3; //r3
        iVar3 = (DAT_14 << 1) + DAT_14 << 1;
        iVar2 -= iVar3;
        iVar2 = iVar2 + ((DAT_1C << 1) + DAT_1C);

        if (iVar2 < 0)
            iVar2 += 15;

        DAT_2C = iVar2 >> 4;
        iVar2 = (DAT_10 << 1) + DAT_10; //r3

        if (iVar2 < 0)
            iVar2 += 15;

        DAT_30 = iVar2 >> 4;
        iVar2 = DAT_14 << 1; //r3
        iVar3 = iVar2 + iVar3; //r2

        if (iVar3 < 0)
            iVar3 += 15;

        DAT_34 = iVar3 >> 4;
    }
}