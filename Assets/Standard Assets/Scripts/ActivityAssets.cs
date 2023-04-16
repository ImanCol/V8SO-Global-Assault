using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x0200001D RID: 29
	public struct ActivityAssets
	{
		// Token: 0x040000B3 RID: 179
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string LargeImage;

		// Token: 0x040000B4 RID: 180
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string LargeText;

		// Token: 0x040000B5 RID: 181
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string SmallImage;

		// Token: 0x040000B6 RID: 182
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string SmallText;
	}
}
