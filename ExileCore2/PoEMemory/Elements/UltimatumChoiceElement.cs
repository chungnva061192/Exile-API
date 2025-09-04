using System;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002EA RID: 746
	public class UltimatumChoiceElement : Element
	{
		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x001B07B0 File Offset: 0x001B07B0
		public bool IsSelectedChoice
		{
			get
			{
				return this + this > 0;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x001B07D0 File Offset: 0x001B07D0
		public int Votes
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x001B07EC File Offset: 0x001B07EC
		public int LockedVotes
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x001B0808 File Offset: 0x001B0808
		public UltimatumChoiceElement()
		{
			this;
		}
	}
}
