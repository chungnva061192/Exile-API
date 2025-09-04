using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000034 RID: 52
	[StructLayout(LayoutKind.Explicit)]
	public struct ExpeditionDetonatorInfoOffsets
	{
		// Token: 0x04000110 RID: 272
		public const int ExpeditionDetonatorInfoOffset = 800;

		// Token: 0x04000111 RID: 273
		[FieldOffset(2138473084)]
		public long PlacementMarkerPtr;

		// Token: 0x04000112 RID: 274
		[FieldOffset(2139019930)]
		public StdVector PlacedExplosives;

		// Token: 0x04000113 RID: 275
		[FieldOffset(2144842078)]
		public Vector2i DetonatorGridPosition;

		// Token: 0x04000114 RID: 276
		[FieldOffset(2140384151)]
		public Vector2i PlacementIndicatorGridPosition;

		// Token: 0x04000115 RID: 277
		[FieldOffset(2132292443)]
		public byte TotalExplosiveCount;
	}
}
