using UnityEngine;

public class Destructible2 : Destructible
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint OnCollision(HitDetection hit)
	{
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 1)
		{
			GameObject gameObject = new GameObject();
			VigObject vigObject = gameObject.AddComponent<VigObject>();
			Utilities.FUN_2CC48(this, vigObject);
			vigObject.transform.parent = base.transform;
			vigObject.vTransform.rotation = new Matrix3x3
			{
				V00 = 4096,
				V01 = 0,
				V02 = 0,
				V10 = 0,
				V11 = 4096,
				V12 = 0,
				V20 = 0,
				V21 = 0,
				V22 = 4096
			};
			vigObject.DAT_58 = DAT_58;
			vigObject.DAT_4A = DAT_4A;
			vigObject.vData = vData;
			vigObject.vLOD = vData.FUN_1FD18(gameObject, vLOD.tmdID, init: true);
			UnityEngine.Object.Destroy(vLOD);
			vLOD = vigObject.vLOD;
			uint tmdID = vMesh.tmdID;
			UnityEngine.Object.Destroy(vMesh);
			vMesh = vData.FUN_1FD18(base.gameObject, tmdID, init: true);
		}
		return base.UpdateW(arg1, arg2);
	}
}
