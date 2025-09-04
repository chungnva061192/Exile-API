using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200033D RID: 829
	public class HarvestWorldObject : Component
	{
		// Token: 0x06001672 RID: 5746 RVA: 0x001B4018 File Offset: 0x001B4018
		public HarvestWorldObject()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x001B4030 File Offset: 0x001B4030
		public List<HarvestSeedSpawnDescriptor> Seeds
		{
			get
			{
				this;
				this;
				return 24;
			}
		}

		// Token: 0x040082D2 RID: 33490
		private readonly CachedValue<HarvestWorldObjectComponentOffsets> _cacheValue;
	}
}
