using System;
using System.Runtime.InteropServices;
using GameOffsets2.Native;

namespace GameOffsets2.Components.LeagueSpecific
{
	// Token: 0x02000095 RID: 149
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ExpeditionAreaDataOffsets
	{
		// Token: 0x04000364 RID: 868
		[FieldOffset(2131431462)]
		public NativePtrArray ModsData;
	}
}
