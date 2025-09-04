using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000083 RID: 131
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct TreePassiveElementOffsets
	{
		// Token: 0x04000329 RID: 809
		[FieldOffset(2140382359)]
		public long PassiveSkillPtr;

		// Token: 0x0400032A RID: 810
		[FieldOffset(2142519683)]
		public byte IsAllocatedForPlan;

		// Token: 0x0400032B RID: 811
		[FieldOffset(2145283058)]
		public byte CanAllocate;

		// Token: 0x0400032C RID: 812
		[FieldOffset(2138636681)]
		public byte CanDeallocate;
	}
}
