using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002E2 RID: 738
	public class TooltipItemFrameElement : Element
	{
		// Token: 0x060014A7 RID: 5287 RVA: 0x001B03E8 File Offset: 0x001B03E8
		public TooltipItemFrameElement()
		{
			this;
			this;
			this;
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x001B0400 File Offset: 0x001B0400
		public string CopyText
		{
			get
			{
				this;
				this;
				return 1;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x001B0424 File Offset: 0x001B0424
		public bool IsAdvancedTooltipText
		{
			get
			{
				return this != null;
			}
		}

		// Token: 0x04008260 RID: 33376
		private readonly CachedValue<TooltipItemFrameElementOffsets> _cachedValue;
	}
}
