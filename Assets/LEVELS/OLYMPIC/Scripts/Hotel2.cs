using UnityEngine;

public class Hotel2 : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			VigObject vigObject = child.child2;
			while (vigObject != null)
			{
				if (vigObject.id == id)
				{
					if (!child.GetType().IsSubclassOf(typeof(VigObject)))
					{
						break;
					}
					vigObject.FUN_32B90(100u);
					return 0u;
				}
				vigObject = vigObject.child;
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
		return 0u;
	}
}
