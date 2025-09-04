using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000057 RID: 87
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct NormalInventoryItemOffsets
	{
		// Token: 0x04000229 RID: 553
		[FieldOffset(2134280560)]
		public long Item;

		// Token: 0x0400022A RID: 554
		[FieldOffset(2141753857)]
		public Vector2i Size;
	}
}
