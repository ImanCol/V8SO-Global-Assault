using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000028 RID: 40
	public struct Sku
	{
		// Token: 0x040000DB RID: 219
		public long Id;

		// Token: 0x040000DC RID: 220
		public SkuType Type;

		// Token: 0x040000DD RID: 221
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Name;

		// Token: 0x040000DE RID: 222
		public SkuPrice Price;
	}
}
