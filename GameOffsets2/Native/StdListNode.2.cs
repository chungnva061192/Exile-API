using System;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x0200008D RID: 141
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct StdListNode<TValue> where TValue : struct
	{
		// Token: 0x0400034D RID: 845
		public IntPtr Next;

		// Token: 0x0400034E RID: 846
		public IntPtr Previous;

		// Token: 0x0400034F RID: 847
		public TValue Data;
	}
}
