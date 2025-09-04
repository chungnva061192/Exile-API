using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000026 RID: 38
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct EntityListOffsets
	{
		// Token: 0x040000C5 RID: 197
		[FieldOffset(2140376471)]
		public long FirstAddr;

		// Token: 0x040000C6 RID: 198
		[FieldOffset(2131080917)]
		public long SecondAddr;

		// Token: 0x040000C7 RID: 199
		[FieldOffset(2139243220)]
		public byte IsEmpty;

		// Token: 0x040000C8 RID: 200
		[FieldOffset(2137304584)]
		public long Entity;
	}
}
