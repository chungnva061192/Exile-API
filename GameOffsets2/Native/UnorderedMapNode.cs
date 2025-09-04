using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x02000091 RID: 145
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct UnorderedMapNode<TKey, TValue> where TKey : unmanaged where TValue : unmanaged
    {
		// Token: 0x04000358 RID: 856
		public long PreviousNodePtr;

		// Token: 0x04000359 RID: 857
		public long NextNodePtr;

		// Token: 0x0400035A RID: 858
		public TKey Key;

		// Token: 0x0400035B RID: 859
		public TValue Value;
	}
}
