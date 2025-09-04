using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200005C RID: 92
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct PathfindingComponentOffsets
	{
		// Token: 0x04000233 RID: 563
		public static readonly int PathNodeStart = 212;

		// Token: 0x04000234 RID: 564
		[FieldOffset(2140396567)]
		public int DestinationNodes;

		// Token: 0x04000235 RID: 565
		[FieldOffset(2138639977)]
		public Vector2i WantMoveToPosition;

		// Token: 0x04000236 RID: 566
		[FieldOffset(2146572591)]
		public float StayTime;
	}
}
