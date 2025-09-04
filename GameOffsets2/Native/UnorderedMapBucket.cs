using System;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x02000090 RID: 144
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct UnorderedMapBucket
	{
		// Token: 0x04000356 RID: 854
		[FieldOffset(2142509219)]
		public long LastNodePtr;

		// Token: 0x04000357 RID: 855
		[FieldOffset(2138479100)]
		public long FirstNodePtr;
	}
}
