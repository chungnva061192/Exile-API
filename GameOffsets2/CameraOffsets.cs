using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000019 RID: 25
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct CameraOffsets
	{
		// Token: 0x04000060 RID: 96
		[FieldOffset(2132280539)]
		public Matrix4x4 MatrixBytes;

		// Token: 0x04000061 RID: 97
		[FieldOffset(2136706029)]
		public Vector3 Position;

		// Token: 0x04000062 RID: 98
		[FieldOffset(2141775297)]
		public float ZFar;

		// Token: 0x04000063 RID: 99
		[FieldOffset(2136718253)]
		public int Width;

		// Token: 0x04000064 RID: 100
		[FieldOffset(2131071125)]
		public int Height;
	}
}
