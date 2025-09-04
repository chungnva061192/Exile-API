using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000002 RID: 2
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActionWrapperOffsets
	{
		// Token: 0x04000001 RID: 1
		[FieldOffset(2132285531)]
		public long Skill;

		// Token: 0x04000002 RID: 2
		[FieldOffset(2136706221)]
		public long Target;

		// Token: 0x04000003 RID: 3
		[FieldOffset(2142504995)]
		public Vector2i Destination;
	}
}
