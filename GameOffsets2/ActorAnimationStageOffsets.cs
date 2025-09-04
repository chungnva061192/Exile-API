using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActorAnimationStageOffsets
	{
		// Token: 0x04000032 RID: 50
		[FieldOffset(2140376535)]
		public float StageStart;

		// Token: 0x04000033 RID: 51
		[FieldOffset(2136710189)]
		public int ActorAnimationListIndex;

		// Token: 0x04000034 RID: 52
		[FieldOffset(2136710445)]
		public NativeUtf8Text StageName;
	}
}
