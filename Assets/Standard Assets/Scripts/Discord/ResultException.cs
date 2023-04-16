using System;

namespace Discord
{
	// Token: 0x0200002E RID: 46
	public class ResultException : Exception
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00003B01 File Offset: 0x00001D01
		public ResultException(Result result)
			: base(result.ToString())
		{
		}

		// Token: 0x040000EB RID: 235
		public readonly Result Result;
	}
}
