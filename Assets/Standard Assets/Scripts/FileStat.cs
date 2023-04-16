using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000025 RID: 37
	public struct FileStat
	{
		// Token: 0x040000D3 RID: 211
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string Filename;

		// Token: 0x040000D4 RID: 212
		public ulong Size;

		// Token: 0x040000D5 RID: 213
		public ulong LastModified;
	}
}
