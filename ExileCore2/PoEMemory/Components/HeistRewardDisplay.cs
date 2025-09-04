using System;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000344 RID: 836
	public class HeistRewardDisplay : Component
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x001B474C File Offset: 0x001B474C
		public Entity RewardItem
		{
			get
			{
				this;
				return 32;
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x001B4758 File Offset: 0x001B4758
		public HeistRewardDisplay()
		{
			this;
		}

		// Token: 0x040082DE RID: 33502
		private const int RewardOffset = 32;
	}
}
