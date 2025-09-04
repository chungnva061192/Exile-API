using System;
using ExileCore2.Shared.Enums;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001E8 RID: 488
	public class VendorInventory : Inventory
	{
		// Token: 0x06000E80 RID: 3712 RVA: 0x0019E6A0 File Offset: 0x0019E6A0
		protected override InventoryType GetInvType()
		{
			return InventoryType.VendorInventory;
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x0019E6A4 File Offset: 0x0019E6A4
		protected override Element OffsetContainerElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0019E6A8 File Offset: 0x0019E6A8
		public VendorInventory()
		{
			this;
		}
	}
}
