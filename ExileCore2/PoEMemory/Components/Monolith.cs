using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200034E RID: 846
	public class Monolith : Component
	{
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x001B5204 File Offset: 0x001B5204
		public int OpenStage
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x001B5220 File Offset: 0x001B5220
		public bool IsOpened
		{
			get
			{
				return this == 4;
			}
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x001B522C File Offset: 0x001B522C
		public Monolith()
		{
			this;
		}
	}
}
