using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct AreaLoadingStateOffsets
	{
		// Token: 0x04000035 RID: 53
		[FieldOffset(2131444774)]
		public long IsLoading;

		// Token: 0x04000036 RID: 54
		[FieldOffset(2132327387)]
		public uint TotalLoadingScreenTimeMs;

		// Token: 0x04000037 RID: 55
		[FieldOffset(2138448252)]
		public long AreaPtr;
	}
}
