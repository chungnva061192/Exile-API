using System;
using System.Runtime.InteropServices;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000267 RID: 615
	[StructLayout(LayoutKind.Explicit, Size = 168)]
	public struct StatDescriptionStringContainer
	{
		// Token: 0x0400813D RID: 33085
		[FieldOffset(0)]
		public StdVector StatRangeVector;

		// Token: 0x0400813E RID: 33086
		[FieldOffset(48)]
		public StdVector StatConverionVector;

		// Token: 0x0400813F RID: 33087
		[FieldOffset(112)]
		public long StringPtr;
	}
}
