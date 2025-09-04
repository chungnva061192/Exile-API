using System;
using System.Collections.Concurrent;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2
{
	// Token: 0x02000041 RID: 65
	public class EntityCacheContainer
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00170A94 File Offset: 0x00170A94
		public EntityCacheContainer()
		{
			this;
			this;
			this;
		}

		// Token: 0x04000132 RID: 306
		public readonly ConcurrentDictionary<uint, Entity> Entities;

		// Token: 0x04000133 RID: 307
		public DateTime LastUsedDate;

		// Token: 0x04000134 RID: 308
		public int InstanceId;
	}
}
