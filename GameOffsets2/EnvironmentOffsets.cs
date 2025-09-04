using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000032 RID: 50
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct EnvironmentOffsets
	{
		// Token: 0x04000108 RID: 264
		[FieldOffset(2131081173)]
		public ushort Key;

		// Token: 0x04000109 RID: 265
		[FieldOffset(2131431942)]
		public ushort Value0;

		// Token: 0x0400010A RID: 266
		[FieldOffset(2131432038)]
		public float Value1;
	}
}
