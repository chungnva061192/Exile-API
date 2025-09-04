using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200005A RID: 90
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct PathEntityOffsets
	{
		// Token: 0x04000230 RID: 560
		[FieldOffset(2146586351)]
		public PathEntityOffsets.StringPtr Path;

		// Token: 0x04000231 RID: 561
		[FieldOffset(2139014682)]
		public long Length;

		// Token: 0x0200005B RID: 91
		[StructLayout(LayoutKind.Explicit, Pack = 1)]
		public struct StringPtr
		{
			// Token: 0x04000232 RID: 562
			[FieldOffset(2138478972)]
			public long Ptr;
		}
	}
}
