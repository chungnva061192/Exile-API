using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200003C RID: 60
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct HeistBlueprintComponentOffsets
	{
		// Token: 0x0400012D RID: 301
		public static readonly int WingRecordSize = 80;

		// Token: 0x0400012E RID: 302
		public static readonly int JobRecordSize = 24;

		// Token: 0x0400012F RID: 303
		public static readonly int RoomRecordSize = 24;

		// Token: 0x04000130 RID: 304
		public static readonly int NpcRecordSize = 16;

		// Token: 0x04000131 RID: 305
		[FieldOffset(2134295536)]
		public long Owner;

		// Token: 0x04000132 RID: 306
		[FieldOffset(2140376151)]
		public byte AreaLevel;

		// Token: 0x04000133 RID: 307
		[FieldOffset(2132284731)]
		public byte IsConfirmed;

		// Token: 0x04000134 RID: 308
		[FieldOffset(2139242820)]
		public NativePtrArray Wings;
	}
}
