using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000009 RID: 9
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActiveAnimationOffsets
	{
		// Token: 0x0400002C RID: 44
		[FieldOffset(2141767041)]
		public int AnimationId;

		// Token: 0x0400002D RID: 45
		[FieldOffset(2131079765)]
		public float SlowAnimationSpeed;

		// Token: 0x0400002E RID: 46
		[FieldOffset(2131433446)]
		public float NormalAnimationSpeed;

		// Token: 0x0400002F RID: 47
		[FieldOffset(2132283483)]
		public long SlowAnimationStartStagePtr;

		// Token: 0x04000030 RID: 48
		[FieldOffset(2139013402)]
		public long SlowAnimationEndStagePtr;
	}
}
