using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000046 RID: 70
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct InitObjectOffsets
	{
		// Token: 0x040001AE RID: 430
		public long vTable;

		// Token: 0x040001AF RID: 431
		public long ParentObjectPtr;
	}
}
