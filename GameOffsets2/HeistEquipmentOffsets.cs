using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000042 RID: 66
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct HeistEquipmentOffsets
	{
		// Token: 0x04000141 RID: 321
		[FieldOffset(2137304072)]
		public long BaseItemKey;

		// Token: 0x04000142 RID: 322
		[FieldOffset(2136710445)]
		public long RequiredJobKey;

		// Token: 0x04000143 RID: 323
		[FieldOffset(2131431462)]
		public int RequiredJobMinimumLevel;
	}
}
