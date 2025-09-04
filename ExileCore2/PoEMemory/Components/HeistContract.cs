using System;
using ExileCore2.PoEMemory.MemoryObjects.Heist;
using ExileCore2.PoEMemory.Models;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000341 RID: 833
	public class HeistContract : Component
	{
		// Token: 0x06001685 RID: 5765 RVA: 0x001B4428 File Offset: 0x001B4428
		public HeistContract()
		{
			this;
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x001B4484 File Offset: 0x001B4484
		private HeistContractObjectiveOffsets Objectives
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x001B4494 File Offset: 0x001B4494
		private HeistContractRequirementOffsets Requirements
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x001B44A4 File Offset: 0x001B44A4
		public BaseItemType TargetItem
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x001B44C8 File Offset: 0x001B44C8
		public string Client
		{
			get
			{
				this;
				this;
				return 1;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x001B44E8 File Offset: 0x001B44E8
		public HeistJobRecord RequiredJob
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x001B450C File Offset: 0x001B450C
		public byte RequiredJobLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040082D5 RID: 33493
		private readonly CachedValue<HeistContractComponentOffsets> _ContractData;

		// Token: 0x040082D6 RID: 33494
		private readonly CachedValue<HeistContractObjectiveOffsets> _ObjectivesData;

		// Token: 0x040082D7 RID: 33495
		private readonly CachedValue<HeistContractRequirementOffsets> _RequirementData;
	}
}
