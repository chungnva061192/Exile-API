using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000033 RID: 51
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct EscapeStateOffsets
	{
		// Token: 0x0400010B RID: 267
		[FieldOffset(2138998170)]
		public byte WasEverActive;

		// Token: 0x0400010C RID: 268
		[FieldOffset(2138489340)]
		public long UIRootPtr;

		// Token: 0x0400010D RID: 269
		[FieldOffset(2142519587)]
		public long HoveredElementPtr;

		// Token: 0x0400010E RID: 270
		[FieldOffset(2132327387)]
		public uint TotalActiveTimeMs;

		// Token: 0x0400010F RID: 271
		[FieldOffset(2137266568)]
		public byte IsUnpaused;
	}
}
