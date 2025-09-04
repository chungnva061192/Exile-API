using System;
using System.Runtime.InteropServices;
using GameOffsets2.Native;

namespace GameOffsets2.Components.LeagueSpecific
{
	// Token: 0x02000096 RID: 150
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ExpeditionSagaOffsets
	{
		// Token: 0x04000365 RID: 869
		[FieldOffset(2131431718)]
		public byte AreaLevel;

		// Token: 0x04000366 RID: 870
		[FieldOffset(2138478844)]
		public NativePtrArray AreasData;
	}
}
