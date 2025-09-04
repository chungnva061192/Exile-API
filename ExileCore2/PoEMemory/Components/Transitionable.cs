using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000378 RID: 888
	public class Transitionable : Component
	{
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x001B710C File Offset: 0x001B710C
		public byte Flag1
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x001B7128 File Offset: 0x001B7128
		public byte Flag2
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x001B7144 File Offset: 0x001B7144
		public Transitionable()
		{
			this;
		}
	}
}
