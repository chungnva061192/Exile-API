using System;
using ExileCore2.PoEMemory.FilesInMemory;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Cache;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000315 RID: 789
	public class Animated : Component
	{
		// Token: 0x0600159A RID: 5530 RVA: 0x001B2358 File Offset: 0x001B2358
		public Animated()
		{
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x001B2388 File Offset: 0x001B2388
		public Entity BaseAnimatedObjectEntity
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x001B2398 File Offset: 0x001B2398
		public MiscAnimatedDat MiscAnimated
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040082A3 RID: 33443
		private const int BaseAnimatedObjectEntityOffset = 776;

		// Token: 0x040082A4 RID: 33444
		private readonly CachedValue<Entity> _baseAnimatedObjectEntityCache;
	}
}
