using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200005E RID: 94
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct PerPlayerSubDataOffsets
	{
		// Token: 0x0400023F RID: 575
		public const int AtlasPassivesListOffset = 368;

		// Token: 0x04000240 RID: 576
		[FieldOffset(2140231831)]
		public long AtlasTreeContainerPtr;

		// Token: 0x04000241 RID: 577
		[FieldOffset(2138837146)]
		public int Gold;

		// Token: 0x04000242 RID: 578
		[FieldOffset(2140230679)]
		public StdVector PlayerStashTabs;

		// Token: 0x04000243 RID: 579
		[FieldOffset(2132463579)]
		public StdVector GuildStashTabs;

		// Token: 0x04000244 RID: 580
		[FieldOffset(2138333820)]
		public NativePtrArray GuildInventories;

		// Token: 0x04000245 RID: 581
		[FieldOffset(2141968513)]
		public long GuildName;
	}
}
