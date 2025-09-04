using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200001D RID: 29
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ComponentArrayStructure
	{
		// Token: 0x04000070 RID: 112
		public long NamePtr;

		// Token: 0x04000071 RID: 113
		public int Index;

		// Token: 0x04000072 RID: 114
		public int deadcode;
	}
}
