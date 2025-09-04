using System;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x02000088 RID: 136
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct NativeListNode
	{
		// Token: 0x0400033B RID: 827
		public long Next;

		// Token: 0x0400033C RID: 828
		public long Prev;

		// Token: 0x0400033D RID: 829
		public long Ptr1_Unused;

		// Token: 0x0400033E RID: 830
		public long Ptr2_Key;

		// Token: 0x0400033F RID: 831
		public int Value;
	}
}
