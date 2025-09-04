using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements.Village
{
	// Token: 0x020002EF RID: 751
	public class CurrencyExchangeCurrencyPickerElement : Element
	{
		// Token: 0x060014E2 RID: 5346 RVA: 0x001B0AF0 File Offset: 0x001B0AF0
		public CurrencyExchangeCurrencyPickerElement()
		{
			this;
			this;
			this;
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x001B0B08 File Offset: 0x001B0B08
		public bool IsPickingWantedCurrency
		{
			get
			{
				return this == 0;
			}
		}

		// Token: 0x04008270 RID: 33392
		private readonly CachedValue<CurrencyExchangeCurrencyPickerElementOffsets> _cache;
	}
}
