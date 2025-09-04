using System;
using ExileCore2.PoEMemory.FilesInMemory;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002E5 RID: 741
	public class TreePassiveElement : Element
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x001B04FC File Offset: 0x001B04FC
		public TreePassiveElement()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x001B0514 File Offset: 0x001B0514
		public PassiveSkill PassiveSkill
		{
			get
			{
				this;
				return this + 8L;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x001B0548 File Offset: 0x001B0548
		public bool IsAllocatedForPlan
		{
			get
			{
				return this != 0;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x001B0560 File Offset: 0x001B0560
		public bool CanAllocate
		{
			get
			{
				return this != 0;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x001B0578 File Offset: 0x001B0578
		public bool CanDeallocate
		{
			get
			{
				return this != 0;
			}
		}

		// Token: 0x04008266 RID: 33382
		private readonly CachedValue<TreePassiveElementOffsets> _cache;
	}
}
