using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000055 RID: 85
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ModsComponentStatsOffsets
	{
		// Token: 0x0400020C RID: 524
		[FieldOffset(2136710189)]
		public StdVector ImplicitStatsArray;

		// Token: 0x0400020D RID: 525
		[FieldOffset(2131080021)]
		public StdVector EnchantedStatsArray;

		// Token: 0x0400020E RID: 526
		[FieldOffset(2138478076)]
		public StdVector CrucibleStatsArray;

		// Token: 0x0400020F RID: 527
		[FieldOffset(2146590447)]
		public StdVector ExplicitStatsArray;

		// Token: 0x04000210 RID: 528
		[FieldOffset(2139248580)]
		public StdVector CraftedStatsArray;

		// Token: 0x04000211 RID: 529
		[FieldOffset(2131078997)]
		public StdVector FracturedStatsArray;
	}
}
