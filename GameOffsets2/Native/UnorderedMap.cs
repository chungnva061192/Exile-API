using System;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x0200008F RID: 143
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct UnorderedMap
	{
		// Token: 0x04000353 RID: 851
		[FieldOffset(2138479100)]
		public long InvalidBucketPtr;

		// Token: 0x04000354 RID: 852
		[FieldOffset(2142509347)]
		public StdVector Buckets;

		// Token: 0x04000355 RID: 853
		[FieldOffset(2131431718)]
		public ulong BucketIndexMask;
	}
}
