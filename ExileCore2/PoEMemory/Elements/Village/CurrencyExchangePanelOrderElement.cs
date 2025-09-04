using System;
using System.Runtime.InteropServices;
using ExileCore2.Shared.Cache;

namespace ExileCore2.PoEMemory.Elements.Village
{
	// Token: 0x020002EC RID: 748
	public class CurrencyExchangePanelOrderElement : Element
	{
		// Token: 0x060014D5 RID: 5333 RVA: 0x001B08DC File Offset: 0x001B08DC
		public CurrencyExchangePanelOrderElement()
		{
			this;
			this;
			this;
		}

		// Token: 0x0400826D RID: 33389
		private CachedValue<CurrencyExchangePanelOrderElement.Offsets> _cache;

		// Token: 0x020002ED RID: 749
		[StructLayout(LayoutKind.Explicit)]
		public struct Offsets
		{
			// Token: 0x0400826E RID: 33390
			[FieldOffset(776)]
			public int OrderId;
		}
	}
}
