using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2
{
	// Token: 0x02000040 RID: 64
	public class EntityCollectSettingsContainer
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000223 RID: 547 RVA: 0x001709E4 File Offset: 0x001709E4
		// (set) Token: 0x06000224 RID: 548 RVA: 0x001709EC File Offset: 0x001709EC
		public Stack<Entity> NewEntities
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000225 RID: 549 RVA: 0x001709F8 File Offset: 0x001709F8
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00170A00 File Offset: 0x00170A00
		public Queue<uint> DeletedEntityIds
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00170A0C File Offset: 0x00170A0C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00170A14 File Offset: 0x00170A14
		public Func<long> EntitiesCount
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00170A20 File Offset: 0x00170A20
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00170A28 File Offset: 0x00170A28
		public Func<int?> CurrentInstanceId
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00170A34 File Offset: 0x00170A34
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00170A3C File Offset: 0x00170A3C
		public EntityCacheContainer EntityCache
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00170A48 File Offset: 0x00170A48
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00170A50 File Offset: 0x00170A50
		public uint EntitiesVersion
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00170A5C File Offset: 0x00170A5C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00170A64 File Offset: 0x00170A64
		public bool NeedUpdate
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00170A70 File Offset: 0x00170A70
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00170A78 File Offset: 0x00170A78
		public bool Break
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00170A84 File Offset: 0x00170A84
		public EntityCollectSettingsContainer()
		{
			this;
			1;
			this;
		}
	}
}
