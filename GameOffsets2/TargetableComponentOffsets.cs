using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200007D RID: 125
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct TargetableComponentOffsets
	{
		// Token: 0x04000316 RID: 790
		[FieldOffset(2142510131)]
		public bool isTargetable;

		// Token: 0x04000317 RID: 791
		[FieldOffset(2138659913)]
		public bool isHighlightable;

		// Token: 0x04000318 RID: 792
		[FieldOffset(2145269362)]
		public bool isTargeted;
	}
}
