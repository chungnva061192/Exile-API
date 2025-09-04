using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000077 RID: 119
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct StashTabContainerOffsets
	{
		// Token: 0x04000307 RID: 775
		[FieldOffset(2138987674)]
		public long TabSwitchBarPtr;

		// Token: 0x04000308 RID: 776
		[FieldOffset(2138700393)]
		public long ViewAllStashesButtonPtr;

		// Token: 0x04000309 RID: 777
		[FieldOffset(2136686381)]
		public long PinStashTabListButtonPtr;

		// Token: 0x0400030A RID: 778
		[FieldOffset(2142551971)]
		public StdVector Stashes;

		// Token: 0x0400030B RID: 779
		[FieldOffset(2131475110)]
		public int VisibleStashIndex;
	}
}
