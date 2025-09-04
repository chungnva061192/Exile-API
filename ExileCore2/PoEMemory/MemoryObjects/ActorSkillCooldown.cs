using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001B3 RID: 435
	public class ActorSkillCooldown : RemoteMemoryObject
	{
		// Token: 0x06000C78 RID: 3192 RVA: 0x00197558 File Offset: 0x00197558
		public ActorSkillCooldown()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0019757C File Offset: 0x0019757C
		public ushort Id
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00197590 File Offset: 0x00197590
		public int SkillSubId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x001975A4 File Offset: 0x001975A4
		private StdVector CooldownUses
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x001975B8 File Offset: 0x001975B8
		public int MaxUses
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x001975CC File Offset: 0x001975CC
		public List<SkillCooldown> SkillCooldowns
		{
			get
			{
				this;
				this;
				this;
				16;
				return null;
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x001975F4 File Offset: 0x001975F4
		public override string ToString()
		{
			3;
			4;
			this;
			"/";
			this;
			" ";
			this;
			" ";
			this;
			return "X";
		}

		// Token: 0x04007EED RID: 32493
		private readonly CachedValue<ActorSkillCooldownOffsets> _cache;
	}
}
