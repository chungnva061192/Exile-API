using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000065 RID: 101
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct SanctumFloorWindowOffsets
	{
		// Token: 0x04000267 RID: 615
		[FieldOffset(2139025690)]
		public long InSanctumDataPtr;

		// Token: 0x04000268 RID: 616
		[FieldOffset(2146596975)]
		public long OutOfSanctumDataPtr;
	}
}
