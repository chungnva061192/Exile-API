using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000073 RID: 115
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct SocketsComponentOffsets
	{
		// Token: 0x040002F4 RID: 756
		[FieldOffset(2138659177)]
		public SocketColorList Sockets;

		// Token: 0x040002F5 RID: 757
		[FieldOffset(2140376727)]
		public SocketedGemList SocketedGems;

		// Token: 0x040002F6 RID: 758
		[FieldOffset(2144834142)]
		public StdVector LinkSizes;
	}
}
