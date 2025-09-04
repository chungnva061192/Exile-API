using System;
using System.Runtime.InteropServices;

namespace GameOffsets2.Components
{
	// Token: 0x02000093 RID: 147
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct AreaTransitionComponentOffsets
	{
		// Token: 0x04000360 RID: 864
		[FieldOffset(2142509571)]
		public byte TransitionType;

		// Token: 0x04000361 RID: 865
		[FieldOffset(2145269314)]
		public long WorldAreaInfoPtr;
	}
}
