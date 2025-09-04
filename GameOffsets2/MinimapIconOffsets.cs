using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000053 RID: 83
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct MinimapIconOffsets
	{
		// Token: 0x040001E3 RID: 483
		[FieldOffset(2139014682)]
		public long NamePtr;

		// Token: 0x040001E4 RID: 484
		[FieldOffset(2141767553)]
		public byte IsVisible;

		// Token: 0x040001E5 RID: 485
		[FieldOffset(2131431782)]
		public byte IsHide;
	}
}
