using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000066 RID: 102
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct SanctumFloorWindowDataOffsets
	{
		// Token: 0x04000269 RID: 617
		public const long OutOfSanctumFloorDataOffset = 352L;

		// Token: 0x0400026A RID: 618
		public const long InSanctumFloorDataType1Offset = 448L;

		// Token: 0x0400026B RID: 619
		public const long InSanctumFloorDataType2Offset = 376L;

		// Token: 0x0400026C RID: 620
		public const long InspirationOffset = 84L;

		// Token: 0x0400026D RID: 621
		public const long MaxResolveOffset = 82L;

		// Token: 0x0400026E RID: 622
		public const long CurrentResolveOffset = 80L;

		// Token: 0x0400026F RID: 623
		public const long GoldOffset = 72L;

		// Token: 0x04000270 RID: 624
		public const long RoomChoiceHistoryOffset = 56L;

		// Token: 0x04000271 RID: 625
		[FieldOffset(2141769985)]
		public int Gold;

		// Token: 0x04000272 RID: 626
		[FieldOffset(2139247940)]
		public int CurrentResolve;

		// Token: 0x04000273 RID: 627
		[FieldOffset(2137307848)]
		public int MaxResolve;

		// Token: 0x04000274 RID: 628
		[FieldOffset(2140379927)]
		public int Inspiration;

		// Token: 0x04000275 RID: 629
		[FieldOffset(2137296536)]
		public bool Flag1;

		// Token: 0x04000276 RID: 630
		[FieldOffset(2136718989)]
		public bool Flag2;
	}
}
