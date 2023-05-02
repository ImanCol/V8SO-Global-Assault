using Unity.Mathematics;
using UnityEngine;

internal struct MyVertex
{
	public float3 position;

	public float4 color;

	public float2 uv;

	public MyVertex(Vector3 p, Color32 c, Vector2 t)
	{
		position = p;
		color = new float4((int)c.r, (int)c.g, (int)c.b, (int)c.a) / 255f;
		uv = t;
	}
}
