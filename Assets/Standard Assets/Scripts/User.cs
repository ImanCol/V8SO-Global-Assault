using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000018 RID: 24
	public struct User
	{
		// Token: 0x040000A4 RID: 164
		public long Id;

		// Token: 0x040000A5 RID: 165
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Username;

		// Token: 0x040000A6 RID: 166
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
		public string Discriminator;

		// Token: 0x040000A7 RID: 167
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string Avatar;

		// Token: 0x040000A8 RID: 168
		public bool Bot;
	}
}
