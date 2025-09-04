using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200001F RID: 31
	[StructLayout(LayoutKind.Explicit)]
	public struct CurrencyExchangePanelOffsets
	{
		// Token: 0x04000077 RID: 119
		[FieldOffset(2136711469)]
		public long WantedItemTypePtr;

		// Token: 0x04000078 RID: 120
		[FieldOffset(2142512931)]
		public long OfferedItemTypePtr;

		// Token: 0x04000079 RID: 121
		[FieldOffset(2140392791)]
		public uint Stock1TypeHash;

		// Token: 0x0400007A RID: 122
		[FieldOffset(2137320840)]
		public uint Stock2TypeHash;

		// Token: 0x0400007B RID: 123
		[FieldOffset(2141750529)]
		public StdVector Stock1;

		// Token: 0x0400007C RID: 124
		[FieldOffset(2131448102)]
		public StdVector Stock2;

		// Token: 0x0400007D RID: 125
		[FieldOffset(2138997146)]
		public short MarketRateGet;

		// Token: 0x0400007E RID: 126
		[FieldOffset(2138496220)]
		public short MarketRateGive;

		// Token: 0x0400007F RID: 127
		[FieldOffset(2138642153)]
		public long CurrencyPickerPtr;

		// Token: 0x04000080 RID: 128
		[FieldOffset(2140397207)]
		public long OrderListContainerPtr;

		// Token: 0x04000081 RID: 129
		[FieldOffset(2137323528)]
		public StdVector OrderList;
	}
}
