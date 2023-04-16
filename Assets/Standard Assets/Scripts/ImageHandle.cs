using System;

namespace Discord
{
	// Token: 0x0200001A RID: 26
	public struct ImageHandle
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00003701 File Offset: 0x00001901
		public static ImageHandle User(long id)
		{
			return ImageHandle.User(id, 128U);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003710 File Offset: 0x00001910
		public static ImageHandle User(long id, uint size)
		{
			return new ImageHandle
			{
				Type = ImageType.User,
				Id = id,
				Size = size
			};
		}

		// Token: 0x040000AC RID: 172
		public ImageType Type;

		// Token: 0x040000AD RID: 173
		public long Id;

		// Token: 0x040000AE RID: 174
		public uint Size;
	}
}
