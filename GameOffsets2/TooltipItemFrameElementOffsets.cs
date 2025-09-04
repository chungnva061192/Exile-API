using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000082 RID: 130
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct TooltipItemFrameElementOffsets
	{
		// Token: 0x04000327 RID: 807
		[FieldOffset(2144845406)]
		public long CopyTextPtr;

		// Token: 0x04000328 RID: 808
		[FieldOffset(2141776001)]
		public bool IsAdvancedTooltipText;
	}
}
