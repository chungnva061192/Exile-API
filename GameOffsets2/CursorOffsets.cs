using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000021 RID: 33
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct CursorOffsets
	{
		// Token: 0x04000083 RID: 131
		[FieldOffset(2139014170)]
		public int vTable;

		// Token: 0x04000084 RID: 132
		[FieldOffset(2145261058)]
		public int Clicks;

		// Token: 0x04000085 RID: 133
		[FieldOffset(2131096917)]
		public int Action;

		// Token: 0x04000086 RID: 134
		[FieldOffset(2134280176)]
		public NativeUtf16Text ActionSound;

		// Token: 0x04000087 RID: 135
		[FieldOffset(2139000730)]
		public NativeUtf16Text ActionString;
	}
}
