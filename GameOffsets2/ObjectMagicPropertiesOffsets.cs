using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000059 RID: 89
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ObjectMagicPropertiesOffsets
	{
		// Token: 0x0400022E RID: 558
		[FieldOffset(2138475836)]
		public int Rarity;

		// Token: 0x0400022F RID: 559
		[FieldOffset(2139017882)]
		public NativePtrArray Mods;
	}
}
