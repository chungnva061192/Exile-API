using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000079 RID: 121
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct StateMachineComponentOffsets
	{
		// Token: 0x0400030E RID: 782
		[FieldOffset(2146589679)]
		public long StatesPtr;

		// Token: 0x0400030F RID: 783
		[FieldOffset(2142506659)]
		public NativePtrArray StatesValues;
	}
}
