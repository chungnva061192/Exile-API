using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000076 RID: 118
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct StashElementOffsets
	{
		// Token: 0x04000303 RID: 771
		public const int StashTabContainerOffset2 = 928;

		// Token: 0x04000304 RID: 772
		[FieldOffset(2139254212)]
		public long StashTitlePanelPtr;

		// Token: 0x04000305 RID: 773
		[FieldOffset(2145263042)]
		public long ExitButtonPtr;

		// Token: 0x04000306 RID: 774
		[FieldOffset(2131070421)]
		public long StashTabContainerPtr1;
	}
}
