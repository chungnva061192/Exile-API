using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000084 RID: 132
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct UltimatumPanelOffsets
	{
		// Token: 0x0400032D RID: 813
		public const int VotesOffset = 1124;

		// Token: 0x0400032E RID: 814
		public const int LockedVotesOffset = 1128;

		// Token: 0x0400032F RID: 815
		public const int IsSelectedOffset = 1120;

		// Token: 0x04000330 RID: 816
		[FieldOffset(2144845150)]
		public StdVector OfferedModifiers;

		// Token: 0x04000331 RID: 817
		[FieldOffset(2134305264)]
		public int SelectedModifierIndex;
	}
}
