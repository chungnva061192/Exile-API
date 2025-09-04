using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements.Sanctum
{
	// Token: 0x020002F7 RID: 759
	public class SanctumRewardWindow : Element
	{
		// Token: 0x06001508 RID: 5384 RVA: 0x001B0FB0 File Offset: 0x001B0FB0
		public SanctumRewardWindow()
		{
			this;
			this;
			this;
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x001B0FC8 File Offset: 0x001B0FC8
		public List<Element> RewardElements
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x0400827C RID: 33404
		private readonly CachedValue<SanctumRewardWindowOffsets> _cachedValue;
	}
}
