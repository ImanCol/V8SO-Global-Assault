using UnityEngine;

public class HQ2 : Destructible
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
		switch (arg1)
		{
		case 1:
		{
			GameObject gameObject = new GameObject();
			VigObject vigObject = gameObject.AddComponent<VigObject>();
			vigObject.vData = vData;
			vigObject.DAT_1A = DAT_1A;
			vigObject.id = id;
			VigMesh vigMesh = vigObject.vMesh = vigObject.vData.FUN_1FD18(gameObject, vMesh.tmdID, init: true);
			GameObject gameObject2 = new GameObject();
			VigObject vigObject2 = gameObject2.AddComponent<VigObject>();
			vigObject2.vData = vData;
			vigObject2.DAT_1A = DAT_1A;
			vigObject2.id = id;
			VigMesh vigMesh2 = vigObject2.vMesh = vigObject.vData.FUN_1FD18(gameObject2, vMesh.tmdID, init: true);
			vMesh.faceStart = 0;
			vMesh.faces = 46;
			vigMesh.faceStart = 46;
			vigMesh.faces = 58;
			vigMesh2.faceStart = 58;
			vigMesh2.faces = 121;
			Utilities.FUN_2CC48(this, vigObject);
			Utilities.FUN_2CC48(this, vigObject2);
			vigObject.transform.parent = base.transform;
			vigObject2.transform.parent = base.transform;
			vigObject.ApplyTransformation();
			vigObject2.ApplyTransformation();
			break;
		}
		case 9:
			if (arg2 == 0)
			{
				VigObject vigObject = GameManager.instance.FUN_31950(400);
				if (vigObject != null)
				{
					vigObject.FUN_4DC94();
				}
			}
			break;
		}
		return base.UpdateW(arg1, arg2);
	}
}
