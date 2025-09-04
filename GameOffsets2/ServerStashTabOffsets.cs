using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200006D RID: 109
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ServerStashTabOffsets
	{
		// Token: 0x040002B6 RID: 694
		public const int StructSize = 104;

		// Token: 0x040002B7 RID: 695
		[FieldOffset(2141766657)]
		public NativeUtf16Text Name;

		// Token: 0x040002B8 RID: 696
		[FieldOffset(2146585775)]
		public uint Color;

		// Token: 0x040002B9 RID: 697
		[FieldOffset(2136711149)]
		public uint OfficerFlags;

		// Token: 0x040002BA RID: 698
		[FieldOffset(2131431782)]
		public uint TabType;

		// Token: 0x040002BB RID: 699
		[FieldOffset(2142509859)]
		public ushort DisplayIndex;

		// Token: 0x040002BC RID: 700
		[FieldOffset(2146586031)]
		public uint MemberFlags;

		// Token: 0x040002BD RID: 701
		[FieldOffset(2142509939)]
		public byte Flags;
	}
}
