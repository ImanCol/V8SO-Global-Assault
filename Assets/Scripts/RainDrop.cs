using UnityEngine;
public class RainDrop : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		Vector3 eulerAngles = LevelManager.instance.defaultCamera.transform.rotation.eulerAngles;
		base.Update();
		base.transform.localEulerAngles += eulerAngles;
	}
}