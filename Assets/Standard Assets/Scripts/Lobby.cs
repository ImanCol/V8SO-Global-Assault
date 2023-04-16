using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000024 RID: 36
	public struct Lobby
	{
		// Token: 0x040000CD RID: 205
		public long Id;

		// Token: 0x040000CE RID: 206
		public LobbyType Type;

		// Token: 0x040000CF RID: 207
		public long OwnerId;

		// Token: 0x040000D0 RID: 208
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string Secret;

		// Token: 0x040000D1 RID: 209
		public uint Capacity;

		// Token: 0x040000D2 RID: 210
		public bool Locked;
	}
}
