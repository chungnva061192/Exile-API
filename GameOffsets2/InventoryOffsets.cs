using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000047 RID: 71
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct InventoryOffsets
	{
		// Token: 0x040001B0 RID: 432
		public const int ComplexStashFirstLevelServerInventoryOffset = 88;

		// Token: 0x040001B1 RID: 433
		public const int DefaultServerInventoryOffset = 1552;

		// Token: 0x040001B2 RID: 434
		public const int CurrencyStashFirstLevelServerInventoryOffset = 1072;

		// Token: 0x040001B3 RID: 435
		public const int GemStashFirstLevelServerInventoryOffset = 1136;

		// Token: 0x040001B4 RID: 436
		public const int CurrencyStashSecondLevelServerInventoryOffset = 32;

		// Token: 0x040001B5 RID: 437
		[FieldOffset(2131071701)]
		public int ItemHoverState;

		// Token: 0x040001B6 RID: 438
		[FieldOffset(2141776769)]
		public long HoverItem;

		// Token: 0x040001B7 RID: 439
		[FieldOffset(2144844766)]
		public Vector2i FakePos;

		// Token: 0x040001B8 RID: 440
		[FieldOffset(2145256130)]
		public Vector2i RealPos;

		// Token: 0x040001B9 RID: 441
		[FieldOffset(2144838942)]
		public int CursorInInventory;

		// Token: 0x040001BA RID: 442
		[FieldOffset(2138640617)]
		public long ItemCount;

		// Token: 0x040001BB RID: 443
		[FieldOffset(2131088597)]
		public Vector2i InventorySize;

		// Token: 0x040001BC RID: 444
		[FieldOffset(2138490172)]
		public long CursorPtr;
	}
}
