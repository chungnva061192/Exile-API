using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000008 RID: 8
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct AnimationControllerOffsets
	{
		// Token: 0x04000022 RID: 34
		[FieldOffset(2139242820)]
		public NativePtrArray ActiveAnimationsArrayPtr;

		// Token: 0x04000023 RID: 35
		[FieldOffset(2140378519)]
		public long ActorAnimationArrayPtr;

		// Token: 0x04000024 RID: 36
		[FieldOffset(2146588527)]
		public int AnimationInActorId;

		// Token: 0x04000025 RID: 37
		[FieldOffset(2145265794)]
		public float AnimationProgress;

		// Token: 0x04000026 RID: 38
		[FieldOffset(2138653289)]
		public int CurrentAnimationStage;

		// Token: 0x04000027 RID: 39
		[FieldOffset(2139021018)]
		public float NextAnimationPoint;

		// Token: 0x04000028 RID: 40
		[FieldOffset(2138653673)]
		public float AnimationSpeedMultiplier1;

		// Token: 0x04000029 RID: 41
		[FieldOffset(2140377751)]
		public float AnimationSpeedMultiplier2;

		// Token: 0x0400002A RID: 42
		[FieldOffset(2131078229)]
		public float MaxAnimationProgressOffset;

		// Token: 0x0400002B RID: 43
		[FieldOffset(2146588079)]
		public float MaxAnimationProgress;
	}
}
