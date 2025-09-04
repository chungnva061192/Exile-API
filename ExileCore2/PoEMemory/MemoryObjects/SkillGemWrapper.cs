using System;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x02000211 RID: 529
	public class SkillGemWrapper : RemoteMemoryObject
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x001A2CFC File Offset: 0x001A2CFC
		public string Name
		{
			get
			{
				this;
				this;
				this;
				return 1;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x001A2D20 File Offset: 0x001A2D20
		public ActiveSkillWrapper ActiveSkill
		{
			get
			{
				this;
				return this + 79L;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x001A2D34 File Offset: 0x001A2D34
		public long ActiveSkillSubId
		{
			get
			{
				this;
				int[] array = this + 87L;
				int[] array2 = new int[2];
				array2[0] = 48;
				return this / (array - array2);
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x001A2D6C File Offset: 0x001A2D6C
		public SkillGemWrapper()
		{
			this;
		}

		// Token: 0x0400805F RID: 32863
		private const int ActiveSkillOffset = 79;

		// Token: 0x04008060 RID: 32864
		private const int ActiveSkillSubIdOffset1 = 87;

		// Token: 0x04008061 RID: 32865
		private const int ActiveSkillSubIdOffset2 = 48;

		// Token: 0x04008062 RID: 32866
		private const int ActiveSkillSubIdRecordLength = 342;
	}
}
