using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000078 RID: 120
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	public struct StashTabContainerInventoryOffsets
	{
		// Token: 0x0400030C RID: 780
		[FieldOffset(2136710317)]
		public long InventoryPtr;

		// Token: 0x0400030D RID: 781
		[FieldOffset(2132284507)]
		public long StashButtonPtr;
	}
}
