using System;
using System.Runtime.CompilerServices;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002DC RID: 732
	public class VendorStashTabContainerInventory : StashTabContainerInventory
	{
		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x001AFEDC File Offset: 0x001AFEDC
		public virtual VendorInventory Inventory
		{
			[PreserveBaseOverrides]
			get
			{
				return this;
			}
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x001AFEEC File Offset: 0x001AFEEC
		public VendorStashTabContainerInventory()
		{
			this;
		}
	}
}
