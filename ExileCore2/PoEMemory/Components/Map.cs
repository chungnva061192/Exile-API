using System;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200034A RID: 842
	public class Map : Component
	{
		// Token: 0x060016BB RID: 5819 RVA: 0x001B4B34 File Offset: 0x001B4B34
		public Map()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x001B4B6C File Offset: 0x001B4B6C
		public MapComponentInner MapInformation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x001B4B7C File Offset: 0x001B4B7C
		public byte Tier
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040082E3 RID: 33507
		private readonly Lazy<MapComponentBase> _mapBase;

		// Token: 0x040082E4 RID: 33508
		private readonly Lazy<MapComponentInner> _mapInner;
	}
}
