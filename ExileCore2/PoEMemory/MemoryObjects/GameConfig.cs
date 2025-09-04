using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001CE RID: 462
	public class GameConfig : StructuredRemoteMemoryObject<GameConfigOffsets>
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x0019B4C4 File Offset: 0x0019B4C4
		public GameConfig()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x0019B4E8 File Offset: 0x0019B4E8
		public Dictionary<string, GameConfigSection> ConfigMap
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04007F6E RID: 32622
		private readonly CachedValue<Dictionary<string, GameConfigSection>> _mapCache;
	}
}
