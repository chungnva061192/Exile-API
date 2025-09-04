using System;
using System.Runtime.InteropServices;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200033B RID: 827
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct HarvestInfrastructureModUnmanaged
	{
		// Token: 0x040082CC RID: 33484
		[FieldOffset(0)]
		public long DatPtrUnused;

		// Token: 0x040082CD RID: 33485
		[FieldOffset(8)]
		public long DatEntryPtr;

		// Token: 0x040082CE RID: 33486
		[FieldOffset(16)]
		public int ModLevel;

		// Token: 0x040082CF RID: 33487
		[FieldOffset(20)]
		public int Unknown;
	}
}
