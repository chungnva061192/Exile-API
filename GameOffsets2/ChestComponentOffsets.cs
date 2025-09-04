using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200001B RID: 27
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ChestComponentOffsets
	{
		// Token: 0x04000067 RID: 103
		[FieldOffset(2145264834)]
		public long StrongboxData;

		// Token: 0x04000068 RID: 104
		[FieldOffset(2139248068)]
		public bool IsOpened;

		// Token: 0x04000069 RID: 105
		[FieldOffset(2145264722)]
		public bool IsLocked;

		// Token: 0x0400006A RID: 106
		[FieldOffset(2139248004)]
		public readonly byte quality;

		// Token: 0x0400006B RID: 107
		[FieldOffset(2139020954)]
		public bool IsStrongbox;
	}
}
