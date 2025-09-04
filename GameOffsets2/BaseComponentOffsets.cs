using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000011 RID: 17
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct BaseComponentOffsets
	{
		// Token: 0x0400004A RID: 74
		[FieldOffset(2140376215)]
		public long ItemInfo;

		// Token: 0x0400004B RID: 75
		[FieldOffset(2144835422)]
		public long FlavourTextPtr;

		// Token: 0x0400004C RID: 76
		[FieldOffset(2139015242)]
		public byte CurrencyItemLevel;

		// Token: 0x0400004D RID: 77
		[FieldOffset(2141767905)]
		public byte Influence;

		// Token: 0x0400004E RID: 78
		[FieldOffset(2138477836)]
		public byte Corrupted;

		// Token: 0x0400004F RID: 79
		[FieldOffset(2134295920)]
		public NativeUtf16Text PublicPrice;

		// Token: 0x04000050 RID: 80
		[FieldOffset(2138657897)]
		public int UnspentAbsorbedCorruption;

		// Token: 0x04000051 RID: 81
		[FieldOffset(2138478012)]
		public int ScourgedTier;
	}
}
