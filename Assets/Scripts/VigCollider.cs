using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct BoundingBox
{
    public Vector3Int min, max;
}

public struct Radius
{
    public Vector3Int matrixSV;
    public int contactOffset;
}

public class HitDetection
{
    public VigObject self;

    public BufferedBinaryReader collider1;

    public BufferedBinaryReader collider2;

    public VigObject object1;

    public VigObject object2;

    public Vector3Int position;

    public Vector3Int normal1;

    public Vector3Int normal2;

    public int distance;

//Colision hacia los objetos. Priorizar
    public HitDetection(byte[] b)
    {
        self = null;
        collider1 = new BufferedBinaryReader(b);
        collider2 = new BufferedBinaryReader(b);
        object1 = null;
        object2 = null;
        position = default(Vector3Int);
        normal1 = default(Vector3Int);
        normal2 = default(Vector3Int);
        distance = 0;
    }
}

[Serializable]
public class VigCollider
{
    public byte[] buffer;

    public BufferedBinaryReader reader;

    public VigCollider(byte[] b)
    {
        buffer = b;
        reader = new BufferedBinaryReader(buffer);
    }

    public void GetReader()
    {
        if (reader == null)
        {
            reader = new BufferedBinaryReader(buffer);
        }
    }
}
