using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200003D RID: 61
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct HeistContractComponentOffsets
	{
		// Token: 0x04000135 RID: 309
		[FieldOffset(2131081045)]
		public long Owner;

		// Token: 0x04000136 RID: 310
		[FieldOffset(2141767297)]
		public long ObjectiveKey;

		// Token: 0x04000137 RID: 311
		[FieldOffset(2131431718)]
		public NativePtrArray Requirements;

		// Token: 0x04000138 RID: 312
		[FieldOffset(2138479356)]
		public NativePtrArray Crew;
	}
}
