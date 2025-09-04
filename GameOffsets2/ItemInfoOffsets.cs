using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000010 RID: 16
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ItemInfoOffsets
	{
		// Token: 0x04000045 RID: 69
		[FieldOffset(2136710573)]
		public byte ItemCellsSizeX;

		// Token: 0x04000046 RID: 70
		[FieldOffset(2146586495)]
		public byte ItemCellsSizeY;

		// Token: 0x04000047 RID: 71
		[FieldOffset(2134294640)]
		public NativeUtf16Text Name;

		// Token: 0x04000048 RID: 72
		[FieldOffset(2139244100)]
		public long BaseItemType;

		// Token: 0x04000049 RID: 73
		[FieldOffset(2136709805)]
		public StdVector Tags;
	}
}
