using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001D8 RID: 472
	public class EscapeState : GameState
	{
		// Token: 0x06000D94 RID: 3476 RVA: 0x0019C000 File Offset: 0x0019C000
		public EscapeState()
		{
			this;
			this;
			this;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0019C018 File Offset: 0x0019C018
		public bool WasEverActive
		{
			get
			{
				return this != 0;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0019C030 File Offset: 0x0019C030
		public bool IsActive
		{
			get
			{
				return this == 0;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0019C048 File Offset: 0x0019C048
		public TimeSpan TotalActiveTime
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x0019C064 File Offset: 0x0019C064
		public Element HoveredElement
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0019C07C File Offset: 0x0019C07C
		public Element UIRoot
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x04007F8D RID: 32653
		private readonly FrameCache<EscapeStateOffsets> _cache;
	}
}
