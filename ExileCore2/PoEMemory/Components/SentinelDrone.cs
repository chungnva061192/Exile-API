using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000365 RID: 869
	public class SentinelDrone : Component
	{
		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x001B62B8 File Offset: 0x001B62B8
		public int TimesUsed
		{
			get
			{
				this;
				return this + 32L;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x001B62D0 File Offset: 0x001B62D0
		public int MaxUses
		{
			get
			{
				this;
				this + 16L;
				return new int[]
				{
					16,
					32
				};
			}
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x001B62F8 File Offset: 0x001B62F8
		public SentinelDrone()
		{
			this;
		}
	}
}
