using System;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001B4 RID: 436
	public class SkillCooldown : RemoteMemoryObject
	{
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0019768C File Offset: 0x0019768C
		public float Remaining
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x001976A0 File Offset: 0x001976A0
		public float TotalCooldown
		{
			get
			{
				this;
				return this + 8L;
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x001976B8 File Offset: 0x001976B8
		public SkillCooldown()
		{
			this;
		}
	}
}
