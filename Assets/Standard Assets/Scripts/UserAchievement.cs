using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x0200002A RID: 42
	public struct UserAchievement
	{
		// Token: 0x040000E1 RID: 225
		public long UserId;

		// Token: 0x040000E2 RID: 226
		public long AchievementId;

		// Token: 0x040000E3 RID: 227
		public byte PercentComplete;

		// Token: 0x040000E4 RID: 228
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string UnlockedAt;
	}
}
