using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000021 RID: 33
	public struct Activity
	{
		// Token: 0x040000BE RID: 190
		public ActivityType Type;

		// Token: 0x040000BF RID: 191
		public long ApplicationId;

		// Token: 0x040000C0 RID: 192
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string Name;

		// Token: 0x040000C1 RID: 193
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string State;

		// Token: 0x040000C2 RID: 194
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string Details;

		// Token: 0x040000C3 RID: 195
		public ActivityTimestamps Timestamps;

		// Token: 0x040000C4 RID: 196
		public ActivityAssets Assets;

		// Token: 0x040000C5 RID: 197
		public ActivityParty Party;

		// Token: 0x040000C6 RID: 198
		public ActivitySecrets Secrets;

		// Token: 0x040000C7 RID: 199
		public bool Instance;
	}
}
