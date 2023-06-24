using System;

// Token: 0x020000E3 RID: 227
public class Fence2 : Destructible
{
	// Token: 0x0600048C RID: 1164 RVA: 0x0000805E File Offset: 0x0000625E
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00008066 File Offset: 0x00006266
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00008D79 File Offset: 0x00006F79
	public override uint OnCollision(HitDetection hit)
	{
		if (!base.FUN_32CF0(hit))
		{
			return 0U;
		}
		this.FUN_648(36736U);
		return uint.MaxValue;
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00008D92 File Offset: 0x00006F92
	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0U;
		}
		if (!base.FUN_32B90((uint)arg2))
		{
			return 0U;
		}
		this.FUN_648(36736U);
		return uint.MaxValue;
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00039C18 File Offset: 0x00037E18
	private void FUN_648(uint param1)
	{
		short[] array = new short[4];
		BufferedBinaryReader reader = this.vCollider.reader;
		int num = this.screen.x + reader.ReadInt32(4);
		if (num < 0)
		{
			num += 65535;
		}
		array[0] = (short)(num >> 16);
		num = this.screen.z + reader.ReadInt32(12);
		if (num < 0)
		{
			num += 65535;
		}
		array[1] = (short)(num >> 16);
		num = this.screen.x + reader.ReadInt32(16);
		int num2 = num + 65535;
		if (num2 < 0)
		{
			num2 = num + 131070;
		}
		array[2] = (short)((num2 >> 16) - (int)array[0]);
		num = this.screen.z + reader.ReadInt32(24);
		num2 = num + 65535;
		if (num2 < 0)
		{
			num2 = num + 131070;
		}
		array[3] = (short)((num2 >> 16) - (int)array[1]);
		LevelManager.instance.FUN_359CC(array, param1);
	}
}
