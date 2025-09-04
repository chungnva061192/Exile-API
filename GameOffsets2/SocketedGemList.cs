using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000075 RID: 117
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SocketedGemList
	{
		// Token: 0x040002FD RID: 765
		public long Socket1GemPtr;

		// Token: 0x040002FE RID: 766
		public long Socket2GemPtr;

		// Token: 0x040002FF RID: 767
		public long Socket3GemPtr;

		// Token: 0x04000300 RID: 768
		public long Socket4GemPtr;

		// Token: 0x04000301 RID: 769
		public long Socket5GemPtr;

		// Token: 0x04000302 RID: 770
		public long Socket6GemPtr;
	}
}
