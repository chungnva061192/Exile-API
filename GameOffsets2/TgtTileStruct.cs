using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000080 RID: 128
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct TgtTileStruct
	{
		// Token: 0x04000321 RID: 801
		[FieldOffset(2138479100)]
		public NativeUtf16Text TgtPath;

		// Token: 0x04000322 RID: 802
		[FieldOffset(2137304968)]
		public long TgtDetailPtr;
	}
}
