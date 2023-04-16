using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000019 RID: 25
	public struct OAuth2Token
	{
		// Token: 0x040000A9 RID: 169
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string AccessToken;

		// Token: 0x040000AA RID: 170
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string Scopes;

		// Token: 0x040000AB RID: 171
		public long Expires;
	}
}
