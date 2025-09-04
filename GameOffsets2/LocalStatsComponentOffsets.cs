using GameOffsets2.Components;
using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200004D RID: 77
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct LocalStatsComponentOffsets
	{
		// Token: 0x040001D4 RID: 468
		[FieldOffset(2144834654)]
		public ComponentHeader Header;

		// Token: 0x040001D5 RID: 469
		[FieldOffset(2146585711)]
		public StdVector StatsPtr;
	}
}
