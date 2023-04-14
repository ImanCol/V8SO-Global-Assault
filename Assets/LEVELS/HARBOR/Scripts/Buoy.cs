public class Buoy : VigObject
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
		if (hit.self.type != 8)
		{
			return 0u;
		}
		if (maxHalfHealth < hit.self.maxHalfHealth)
		{
			ushort param = (ushort)child2.DAT_1A;
			maxHalfHealth = maxFullHealth;
			if (child2.FUN_4DC94())
			{
				BufferedBinaryReader reader = vData.FUN_2CBB0(param);
				child2.vAnim = new BufferedBinaryReader(null);
				child2.vAnim.ChangeBuffer(reader);
			}
		}
		else
		{
			maxHalfHealth -= hit.self.maxHalfHealth;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0u;
		}
		if (maxHalfHealth < arg2)
		{
			ushort param = (ushort)child2.DAT_1A;
			maxHalfHealth = maxFullHealth;
			if (child2.FUN_4DC94())
			{
				BufferedBinaryReader reader = vData.FUN_2CBB0(param);
				child2.vAnim = new BufferedBinaryReader(null);
				child2.vAnim.ChangeBuffer(reader);
			}
		}
		else
		{
			maxHalfHealth -= (ushort)arg2;
		}
		return 0u;
	}
}
