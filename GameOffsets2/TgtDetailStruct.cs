using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200007F RID: 127
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct TgtDetailStruct
	{
		// Token: 0x04000320 RID: 800
		[FieldOffset(2131431974)]
		public NativeUtf16Text name;
	}
}
