using System;
using ExileCore2.Shared.Enums;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001E9 RID: 489
	public class PlayerInventory : Inventory
	{
		// Token: 0x06000E83 RID: 3715 RVA: 0x0019E6B4 File Offset: 0x0019E6B4
		protected override InventoryType GetInvType()
		{
			return InventoryType.PlayerInventory;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x0019E6B8 File Offset: 0x0019E6B8
		protected override Element OffsetContainerElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0019E6BC File Offset: 0x0019E6BC
		public PlayerInventory()
		{
			this;
		}
	}
}
