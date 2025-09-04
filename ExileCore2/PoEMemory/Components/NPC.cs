using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000352 RID: 850
	public class NPC : Component
	{
		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x001B5310 File Offset: 0x001B5310
		public bool HasIconOverhead
		{
			get
			{
				this;
				return this + 72L != 0L;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x001B532C File Offset: 0x001B532C
		public bool IsIgnoreHidden
		{
			get
			{
				this;
				return this + 32L == 1;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x001B5348 File Offset: 0x001B5348
		public bool IsMinMapLabelVisible
		{
			get
			{
				this;
				return this + 33L == 1;
			}
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x001B5364 File Offset: 0x001B5364
		public NPC()
		{
			this;
		}
	}
}
