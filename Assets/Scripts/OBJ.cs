using System;

[Serializable]
public class OBJ
{
	public byte[] buffer;

	public OBJ(byte[] b)
	{
		buffer = b;
	}
}
