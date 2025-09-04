using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000035 RID: 53
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct FileInfo
	{
		// Token: 0x04000116 RID: 278
		[FieldOffset(2145268290)]
		public long Name;

		// Token: 0x04000117 RID: 279
		[FieldOffset(2134294640)]
		public long Records;

		// Token: 0x04000118 RID: 280
		[FieldOffset(2139244356)]
		public int AreaChangeCount;
	}
}
