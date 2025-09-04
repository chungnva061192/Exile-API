using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001D0 RID: 464
	public class GameConfigSection : StructuredRemoteMemoryObject<GameConfigSectionOffsets>
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x0019B554 File Offset: 0x0019B554
		public GameConfigSection()
		{
			this;
			this;
			this;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0019B578 File Offset: 0x0019B578
		public string SectionKey
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0019B590 File Offset: 0x0019B590
		public Dictionary<string, string> SectionConfig
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04007F71 RID: 32625
		private readonly CachedValue<Dictionary<string, string>> _configCache;
	}
}
