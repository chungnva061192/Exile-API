using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000072 RID: 114
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct GemInformation
	{
		// Token: 0x040002F0 RID: 752
		[FieldOffset(2139243076)]
		public int SocketColor;

		// Token: 0x040002F1 RID: 753
		[FieldOffset(2139014554)]
		public long SkillGemPtr;

		// Token: 0x040002F2 RID: 754
		[FieldOffset(2138660265)]
		public int MaxLevel;

		// Token: 0x040002F3 RID: 755
		[FieldOffset(2134296240)]
		public int LimitLevel;
	}
}
