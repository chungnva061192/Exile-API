using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000038 RID: 56
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct GameConfigSectionOffsets
	{
		// Token: 0x0400011B RID: 283
		[FieldOffset(2146586223)]
		public NativeUtf16Text SectionKey;

		// Token: 0x0400011C RID: 284
		[FieldOffset(2140376983)]
		public UnorderedMap SectionMap;
	}
}
