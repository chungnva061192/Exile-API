using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.FilesInMemory;
using ExileCore2.PoEMemory.Models;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000324 RID: 804
	public class ItemInfoData : RemoteMemoryObject
	{
		// Token: 0x060015EA RID: 5610 RVA: 0x001B2DEC File Offset: 0x001B2DEC
		public ItemInfoData()
		{
			this;
			this;
			this;
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x001B2E10 File Offset: 0x001B2E10
		public ItemInfoOffsets ItemInfoDataStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x001B2E20 File Offset: 0x001B2E20
		public byte ItemCellsSizeX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x001B2E30 File Offset: 0x001B2E30
		public byte ItemCellsSizeY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x001B2E40 File Offset: 0x001B2E40
		public string Name
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x001B2E58 File Offset: 0x001B2E58
		public BaseItemType BaseItemTypeDat
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x001B2E7C File Offset: 0x001B2E7C
		public List<TagsDat.TagRecord> TagsDat
		{
			get
			{
				this;
				this;
				return 16;
			}
		}

		// Token: 0x040082B6 RID: 33462
		private readonly CachedValue<ItemInfoOffsets> _cachedValue;
	}
}
