using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200000D RID: 13
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct AtlasPanelOffsets
	{
		// Token: 0x04000038 RID: 56
		[FieldOffset(2145282114)]
		public StdVector Descriptions;

		// Token: 0x04000039 RID: 57
		[FieldOffset(2140393879)]
		public StdVector Points;

		// Token: 0x0400003A RID: 58
		[FieldOffset(2141755649)]
		public StdVector EffectSources;
	}
}
