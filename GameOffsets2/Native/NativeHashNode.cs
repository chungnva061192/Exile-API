using System;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x02000087 RID: 135
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct NativeHashNode
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000026A8 File Offset: 0x000008A8
		public override string ToString()
		{
			return "NativeHashNode";
		}

		// Token: 0x04000335 RID: 821
		[FieldOffset(2132284635)]
		public readonly long Previous;

		// Token: 0x04000336 RID: 822
		[FieldOffset(2131432102)]
		public readonly long Root;

		// Token: 0x04000337 RID: 823
		[FieldOffset(2141767041)]
		public readonly long Next;

		// Token: 0x04000338 RID: 824
		[FieldOffset(2141766929)]
		public readonly byte IsNull;

		// Token: 0x04000339 RID: 825
		[FieldOffset(2141767297)]
		public int Key;

		// Token: 0x0400033A RID: 826
		[FieldOffset(2146585839)]
		public long Value1;
	}
}
