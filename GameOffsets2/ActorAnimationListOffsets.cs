using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200000A RID: 10
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActorAnimationListOffsets
	{
		// Token: 0x04000031 RID: 49
		[FieldOffset(2137304456)]
		public NativePtrArray AnimationList;
	}
}
