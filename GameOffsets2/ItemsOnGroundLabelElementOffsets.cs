using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000048 RID: 72
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ItemsOnGroundLabelElementOffsets
	{
		// Token: 0x040001BD RID: 445
		public const int SecondConfigOffset = 936;

		// Token: 0x040001BE RID: 446
		[FieldOffset(2144842846)]
		public long ConfigPtr;

		// Token: 0x040001BF RID: 447
		[FieldOffset(2134305264)]
		public StdVector VisibleItemLabels;

		// Token: 0x040001C0 RID: 448
		[FieldOffset(2134287088)]
		public long LabelOnHoverPtr;

		// Token: 0x040001C1 RID: 449
		[FieldOffset(2131088853)]
		public long ItemOnHoverPtr;

		// Token: 0x040001C2 RID: 450
		[FieldOffset(2138664169)]
		public long LabelsOnGroundListPtr;

		// Token: 0x040001C3 RID: 451
		[FieldOffset(2145259074)]
		public long LabelCount;

		// Token: 0x040001C4 RID: 452
		[FieldOffset(2131451430)]
		public long LabelCount2;
	}
}
