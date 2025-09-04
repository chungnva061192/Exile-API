using System;
using System.Collections.Generic;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002D5 RID: 725
	public class SkillBarElement : Element
	{
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x001AF9D8 File Offset: 0x001AF9D8
		public long TotalSkills
		{
			get
			{
				return this - 1L;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x001AF9E4 File Offset: 0x001AF9E4
		public List<SkillElement> Skills
		{
			get
			{
				this;
				return 1;
			}
		}

		// Token: 0x17000753 RID: 1875
		public SkillElement this[int k]
		{
			get
			{
				this;
				return k;
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x001AFA08 File Offset: 0x001AFA08
		public SkillBarElement()
		{
			this;
		}
	}
}
