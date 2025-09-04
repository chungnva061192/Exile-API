using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200000E RID: 14
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct AtlasPanelNodeOffsets
	{
		// Token: 0x0400003B RID: 59
		[FieldOffset(2145262530)]
		public long WorldAreaPtr;

		// Token: 0x0400003C RID: 60
		[FieldOffset(2138665705)]
		public byte MapId;

		// Token: 0x0400003D RID: 61
		[FieldOffset(2138485372)]
		public ushort EncounterFlags;

		// Token: 0x0400003E RID: 62
		[FieldOffset(2146592095)]
		public byte BiomeId;
	}
}
