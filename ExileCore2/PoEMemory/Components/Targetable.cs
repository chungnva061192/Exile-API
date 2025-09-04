using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000375 RID: 885
	public class Targetable : Component
	{
		// Token: 0x060017B2 RID: 6066 RVA: 0x001B703C File Offset: 0x001B703C
		public Targetable()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x001B7060 File Offset: 0x001B7060
		public TargetableComponentOffsets TargetableComponent
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x001B7070 File Offset: 0x001B7070
		public bool isTargetable
		{
			get
			{
				return this != null;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x001B7080 File Offset: 0x001B7080
		public bool isTargeted
		{
			get
			{
				return this != null;
			}
		}

		// Token: 0x04008318 RID: 33560
		private readonly CachedValue<TargetableComponentOffsets> _cachedValue;
	}
}
