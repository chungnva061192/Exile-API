using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000051 RID: 81
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct MapElement
	{
		// Token: 0x040001D9 RID: 473
		public const int LargeMapOffset = 816;

		// Token: 0x040001DA RID: 474
		public const int SmallMapOffset = 824;

		// Token: 0x040001DB RID: 475
		public const int MapPropertiesOffset = 672;

		// Token: 0x040001DC RID: 476
		public const int OrangeWordsOffset = 680;

		// Token: 0x040001DD RID: 477
		public const int BlueWordsOffset = 848;
	}
}
