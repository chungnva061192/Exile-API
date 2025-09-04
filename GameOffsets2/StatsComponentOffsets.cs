using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200007A RID: 122
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct StatsComponentOffsets
	{
		// Token: 0x04000310 RID: 784
		[FieldOffset(2131081045)]
		public long Owner;

		// Token: 0x04000311 RID: 785
		[FieldOffset(2131075541)]
		public long SubStatsPtr;

		// Token: 0x04000312 RID: 786
		[FieldOffset(2145264706)]
		public int ActiveWeaponSetIndex;

		// Token: 0x04000313 RID: 787
		[FieldOffset(2142503203)]
		public long SubStats2Ptr;
	}
}
