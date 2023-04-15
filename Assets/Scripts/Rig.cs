public class Rig : Destructible
{
	public ushort id2;

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
			DAT_1A = 92;
			VigTransform vTransform = base.vTransform;
			vData = LevelManager.instance.xobfList[44];
			FUN_4D8A8(vData, (ushort)DAT_1A, null);
			base.vTransform = vTransform;
			FUN_2C958();
			VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(25, typeof(VigObject), 8u);
			vigObject.vCollider = null;
			int num = (int)GameManager.FUN_2AC5C();
			BufferedBinaryReader bufferedBinaryReader = new BufferedBinaryReader(LevelManager.instance.xobfList[19].animations);
			vigObject.DAT_4A = (ushort)(bufferedBinaryReader.ReadInt32(0) * num >> 15);
			ConfigContainer cont = FUN_2C5F4(32768);
			Utilities.FUN_2CA94(this, cont, vigObject);
			Utilities.ParentChildren(this, this);
			flags |= 4u;
		}
		return base.UpdateW(arg1, arg2);
	}
}
