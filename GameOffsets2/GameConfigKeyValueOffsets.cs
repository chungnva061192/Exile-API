using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000039 RID: 57
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct GameConfigKeyValueOffsets
	{
		// Token: 0x0400011D RID: 285
		[FieldOffset(2132284635)]
		public NativeUtf16Text Key;

		// Token: 0x0400011E RID: 286
		[FieldOffset(2138659561)]
		public NativeUtf16Text Value;
	}
}
