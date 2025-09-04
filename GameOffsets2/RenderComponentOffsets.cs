using GameOffsets2.Native;
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000063 RID: 99
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct RenderComponentOffsets
	{
		// Token: 0x04000261 RID: 609
		[FieldOffset(2132287451)]
		public Vector3 Pos;

		// Token: 0x04000262 RID: 610
		[FieldOffset(2131082261)]
		public Vector3 Bounds;

		// Token: 0x04000263 RID: 611
		[FieldOffset(2138477820)]
		public NativeUtf16Text Name;

		// Token: 0x04000264 RID: 612
		[FieldOffset(2145271106)]
		public Vector3 Rotation;

		// Token: 0x04000265 RID: 613
		[FieldOffset(2146590511)]
		public float Height;
	}
}
