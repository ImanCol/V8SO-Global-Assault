public class Bonfire : Destructible
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
		if (hit.self.type == 2)
		{
			LevelManager.instance.FUN_39AF8((Vehicle)hit.self);
		}
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 1)
		{
			VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(25, typeof(VigObject), 8u);
			vigObject.type = 3;
			int num = (int)GameManager.FUN_2AC5C();
			BufferedBinaryReader bufferedBinaryReader = new BufferedBinaryReader(LevelManager.instance.xobfList[19].animations);
			vigObject.DAT_4A = (ushort)(num * bufferedBinaryReader.ReadInt32(0) >> 15);
			ConfigContainer cont = FUN_2C5F4(32768);
			Utilities.FUN_2CA94(this, cont, vigObject);
			Utilities.ParentChildren(this, this);
			flags |= 4u;
		}
		return base.UpdateW(arg1, arg2);
	}
}
