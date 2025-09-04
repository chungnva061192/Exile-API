using System;
using System.Runtime.InteropServices;

namespace GameOffsets2.Components
{
	// Token: 0x02000094 RID: 148
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ComponentHeader
	{
		// Token: 0x04000362 RID: 866
		[FieldOffset(2134295408)]
		public long StaticPtr;

		// Token: 0x04000363 RID: 867
		[FieldOffset(2137304072)]
		public long EntityPtr;
	}
}
