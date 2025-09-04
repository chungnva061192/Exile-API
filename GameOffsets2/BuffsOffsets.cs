using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000017 RID: 23
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct BuffsOffsets
	{
		// Token: 0x04000057 RID: 87
		[FieldOffset(2138476412)]
		public NativePtrArray Buffs;
	}
}
