using System;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x0200008C RID: 140
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct StdListNode
	{
		// Token: 0x0400034B RID: 843
		public IntPtr Next;

		// Token: 0x0400034C RID: 844
		public IntPtr Previous;
	}
}
