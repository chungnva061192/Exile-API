using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200001E RID: 30
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ComponentLookUpStruct
	{
		// Token: 0x04000073 RID: 115
		[FieldOffset(2139242948)]
		public IntPtr ComponentArray;

		// Token: 0x04000074 RID: 116
		[FieldOffset(2139014938)]
		public IntPtr ComponentArrayEnd;

		// Token: 0x04000075 RID: 117
		[FieldOffset(2145269314)]
		public long Capacity;

		// Token: 0x04000076 RID: 118
		[FieldOffset(2146585455)]
		public long Count;
	}
}
