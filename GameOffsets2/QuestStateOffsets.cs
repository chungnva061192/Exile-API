using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000062 RID: 98
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct QuestStateOffsets
	{
		// Token: 0x0400025C RID: 604
		[FieldOffset(2132284635)]
		public long QuestAddress;

		// Token: 0x0400025D RID: 605
		[FieldOffset(2145268546)]
		public long Base;

		// Token: 0x0400025E RID: 606
		[FieldOffset(2132284891)]
		public byte QuestStateId;

		// Token: 0x0400025F RID: 607
		[FieldOffset(2138479164)]
		public long QuestStateTextAddress;

		// Token: 0x04000260 RID: 608
		[FieldOffset(2131431910)]
		public long QuestProgressTextAddress;
	}
}
