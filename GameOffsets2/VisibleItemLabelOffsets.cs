using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000049 RID: 73
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
	public struct VisibleItemLabelOffsets
	{
		// Token: 0x040001C5 RID: 453
		[FieldOffset(2134295408)]
		public long ElementPtr;

		// Token: 0x040001C6 RID: 454
		[FieldOffset(2140376343)]
		public Vector2 PositionOffset;

		// Token: 0x040001C7 RID: 455
		[FieldOffset(2137304392)]
		public uint EntityId;
	}
}
