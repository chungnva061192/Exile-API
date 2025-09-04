using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.Elements.InventoryElements;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002CF RID: 719
	public class RitualWindow : Element
	{
		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x001AF864 File Offset: 0x001AF864
		public VendorInventory InventoryElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x001AF874 File Offset: 0x001AF874
		public List<NormalInventoryItem> Items
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x001AF888 File Offset: 0x001AF888
		public RitualWindow()
		{
			this;
		}

		// Token: 0x04008249 RID: 33353
		private const int InventoryOffset = 960;
	}
}
