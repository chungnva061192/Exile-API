using System;
using ExileCore2.PoEMemory.FilesInMemory;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000351 RID: 849
	public class NecropolisCorpse : Component
	{
		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x001B5294 File Offset: 0x001B5294
		public int Level
		{
			get
			{
				this;
				return this + 40L;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x001B52AC File Offset: 0x001B52AC
		public MonsterVariety MonsterVariety
		{
			get
			{
				this;
				return this + 24L;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x001B52D8 File Offset: 0x001B52D8
		public NecropolisCraftingMod CraftingMod
		{
			get
			{
				this;
				return this + 48L;
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x001B5304 File Offset: 0x001B5304
		public NecropolisCorpse()
		{
			this;
		}
	}
}
