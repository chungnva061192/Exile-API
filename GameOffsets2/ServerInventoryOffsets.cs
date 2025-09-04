using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200006C RID: 108
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ServerInventoryOffsets
	{
		// Token: 0x040002AC RID: 684
		[FieldOffset(2139248452)]
		public byte InventType;

		// Token: 0x040002AD RID: 685
		[FieldOffset(2131075989)]
		public byte InventSlot;

		// Token: 0x040002AE RID: 686
		[FieldOffset(2137307272)]
		public byte IsRequested;

		// Token: 0x040002AF RID: 687
		[FieldOffset(2139017434)]
		public int Columns;

		// Token: 0x040002B0 RID: 688
		[FieldOffset(2142506403)]
		public int Rows;

		// Token: 0x040002B1 RID: 689
		[FieldOffset(2142506915)]
		public StdVector InventoryItems;

		// Token: 0x040002B2 RID: 690
		[FieldOffset(2138472956)]
		public long InventorySlotItemsPtr;

		// Token: 0x040002B3 RID: 691
		[FieldOffset(2139249220)]
		public long ItemCount;

		// Token: 0x040002B4 RID: 692
		[FieldOffset(2139019930)]
		public int ServerRequestCounter;

		// Token: 0x040002B5 RID: 693
		[FieldOffset(2141772545)]
		public long Hash;
	}
}
