using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200001C RID: 28
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct StrongboxChestComponentData
	{
		// Token: 0x0400006C RID: 108
		[FieldOffset(2144835166)]
		public bool DestroyingAfterOpen;

		// Token: 0x0400006D RID: 109
		[FieldOffset(2144835150)]
		public bool IsLarge;

		// Token: 0x0400006E RID: 110
		[FieldOffset(2139014714)]
		public bool Stompable;

		// Token: 0x0400006F RID: 111
		[FieldOffset(2138479420)]
		public bool OpenOnDamage;
	}
}
