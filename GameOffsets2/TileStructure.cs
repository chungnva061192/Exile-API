using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000081 RID: 129
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 56)]
	public struct TileStructure
	{
		// Token: 0x04000323 RID: 803
		[FieldOffset(2132284635)]
		public long SubTileDetailsPtr;

		// Token: 0x04000324 RID: 804
		[FieldOffset(2131081045)]
		public long TgtFilePtr;

		// Token: 0x04000325 RID: 805
		[FieldOffset(2137304968)]
		public short TileHeight;

		// Token: 0x04000326 RID: 806
		[FieldOffset(2146585871)]
		public byte RotationSelector;
	}
}
