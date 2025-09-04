using GameOffsets2.Native;
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000060 RID: 96
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct PositionedComponentOffsets
	{
		// Token: 0x0400024E RID: 590
		[FieldOffset(2138658921)]
		public long OwnerAddress;

		// Token: 0x0400024F RID: 591
		[FieldOffset(2142504579)]
		public byte Reaction;

		// Token: 0x04000250 RID: 592
		[FieldOffset(2138474236)]
		public int Size;

		// Token: 0x04000251 RID: 593
		[FieldOffset(2139023066)]
		public Vector2i RawVelocity;

		// Token: 0x04000252 RID: 594
		[FieldOffset(2132301403)]
		public float SpeedReverseFactor;

		// Token: 0x04000253 RID: 595
		[FieldOffset(2137298440)]
		public Vector2 PrevPosition;

		// Token: 0x04000254 RID: 596
		[FieldOffset(2146568495)]
		public Vector2 TravelStart;

		// Token: 0x04000255 RID: 597
		[FieldOffset(2145286850)]
		public Vector2 TravelTarget;

		// Token: 0x04000256 RID: 598
		[FieldOffset(2139256900)]
		public float TravelProgress;

		// Token: 0x04000257 RID: 599
		[FieldOffset(2134309936)]
		public Vector2i GridPosition;

		// Token: 0x04000258 RID: 600
		[FieldOffset(2139028442)]
		public float Rotation;

		// Token: 0x04000259 RID: 601
		[FieldOffset(2146570095)]
		public float Scale;

		// Token: 0x0400025A RID: 602
		[FieldOffset(2140393239)]
		public Vector2 WorldPosition;
	}
}
