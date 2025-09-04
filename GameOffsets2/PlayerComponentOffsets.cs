using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200005F RID: 95
	[StructLayout(LayoutKind.Explicit)]
	public struct PlayerComponentOffsets
	{
		// Token: 0x04000246 RID: 582
		[FieldOffset(2146588143)]
		public NativeUtf16Text PlayerName;

		// Token: 0x04000247 RID: 583
		[FieldOffset(2144832094)]
		public uint Xp;

		// Token: 0x04000248 RID: 584
		[FieldOffset(2137305992)]
		public Buffer3<int> Attributes;

		// Token: 0x04000249 RID: 585
		[FieldOffset(2136718445)]
		public byte Level;

		// Token: 0x0400024A RID: 586
		[FieldOffset(2141774929)]
		public byte PantheonMinor;

		// Token: 0x0400024B RID: 587
		[FieldOffset(2138487196)]
		public byte PantheonMajor;

		// Token: 0x0400024C RID: 588
		[FieldOffset(2138668521)]
		public long HideoutPtr;

		// Token: 0x0400024D RID: 589
		[FieldOffset(2142518179)]
		public StdVector Flags;
	}
}
