using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x0200001F RID: 31
	public struct ActivityParty
	{
		// Token: 0x040000B9 RID: 185
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string Id;

		// Token: 0x040000BA RID: 186
		public PartySize Size;
	}
}
