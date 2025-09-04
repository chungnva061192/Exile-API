using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002CD RID: 717
	public class PurchaseWindow : Element
	{
		// Token: 0x0600143E RID: 5182 RVA: 0x001AF7F4 File Offset: 0x001AF7F4
		public PurchaseWindow()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x001AF80C File Offset: 0x001AF80C
		public Element CloseButton
		{
			get
			{
				this;
				return 2;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x001AF818 File Offset: 0x001AF818
		public VendorStashTabContainer TabContainer
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x04008248 RID: 33352
		private readonly CachedValue<PurchaseWindowOffsets> _cache;
	}
}
