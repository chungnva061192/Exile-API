using GameOffsets2.Native;
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200004A RID: 74
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 72)]
	public struct VisibleItemLabelGroupOffsets
	{
		// Token: 0x040001C8 RID: 456
		[FieldOffset(2134295408)]
		public StdVector Labels;

		// Token: 0x040001C9 RID: 457
		[FieldOffset(2139243204)]
		public Vector2 GroupPosition;
	}
}
