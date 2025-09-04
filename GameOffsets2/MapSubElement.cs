using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000052 RID: 82
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct MapSubElement
	{
		// Token: 0x040001DE RID: 478
		public const int MapShift = 792;

		// Token: 0x040001DF RID: 479
		public const int MapShiftX = 792;

		// Token: 0x040001E0 RID: 480
		public const int MapShiftY = 796;

		// Token: 0x040001E1 RID: 481
		public const int DefaultMapShift = 800;

		// Token: 0x040001E2 RID: 482
		public const int MapZoom = 860;
	}
}
