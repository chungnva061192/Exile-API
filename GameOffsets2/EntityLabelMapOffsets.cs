using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000025 RID: 37
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct EntityLabelMapOffsets
	{
		// Token: 0x040000C2 RID: 194
		[FieldOffset(2139025050)]
		public long EntityLabelMap;

		// Token: 0x040000C3 RID: 195
		public const int LabelPtrOffset = 448;

		// Token: 0x040000C4 RID: 196
		public const int LabelOffset = 936;
	}
}
