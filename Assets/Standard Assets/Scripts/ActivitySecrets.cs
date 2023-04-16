using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000020 RID: 32
	public struct ActivitySecrets
	{
		// Token: 0x040000BB RID: 187
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string Match;

		// Token: 0x040000BC RID: 188
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string Join;

		// Token: 0x040000BD RID: 189
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string Spectate;
	}
}
