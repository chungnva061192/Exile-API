using GameOffsets2.Native;
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200002A RID: 42
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct DefaultEnvironmentSettingsOffsets
	{
		// Token: 0x040000F3 RID: 243
		[FieldOffset(2145268290)]
		public NativeUtf16Text Category;

		// Token: 0x040000F4 RID: 244
		[FieldOffset(2136710701)]
		public NativeUtf16Text Name;

		// Token: 0x040000F5 RID: 245
		[FieldOffset(2138480124)]
		public int IndexInGroup;

		// Token: 0x040000F6 RID: 246
		[FieldOffset(2131433190)]
		public Vector3 Value;
	}
}
