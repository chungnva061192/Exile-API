using System;
using System.Collections.Generic;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000335 RID: 821
	public class EffectPack : Component
	{
		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x001B3A28 File Offset: 0x001B3A28
		private StdVector EffectVector
		{
			get
			{
				this;
				return this + 24L;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x001B3A40 File Offset: 0x001B3A40
		private List<long> EffectPtrList
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x001B3A60 File Offset: 0x001B3A60
		private List<EffectPack.Effect> Effects
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x001B3A80 File Offset: 0x001B3A80
		public EffectPack()
		{
			this;
		}

		// Token: 0x02000336 RID: 822
		public class Effect : RemoteMemoryObject
		{
			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x06001654 RID: 5716 RVA: 0x001B3A8C File Offset: 0x001B3A8C
			public string Name
			{
				get
				{
					this;
					this + 8L;
					return this;
				}
			}

			// Token: 0x06001655 RID: 5717 RVA: 0x001B3AB0 File Offset: 0x001B3AB0
			public Effect()
			{
				this;
			}
		}
	}
}
