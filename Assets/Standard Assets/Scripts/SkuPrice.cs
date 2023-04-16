using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000027 RID: 39
	public struct SkuPrice
	{
		// Token: 0x040000D9 RID: 217
		public uint Amount;

		// Token: 0x040000DA RID: 218
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string Currency;
	}
}
