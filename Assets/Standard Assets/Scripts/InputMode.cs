using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000029 RID: 41
	public struct InputMode
	{
		// Token: 0x040000DF RID: 223
		public InputModeType Type;

		// Token: 0x040000E0 RID: 224
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Shortcut;
	}
}
