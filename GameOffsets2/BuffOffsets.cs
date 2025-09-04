using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000018 RID: 24
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct BuffOffsets
	{
		// Token: 0x04000058 RID: 88
		[FieldOffset(2138658921)]
		public long BuffDatPtr;

		// Token: 0x04000059 RID: 89
		[FieldOffset(2137304328)]
		public float MaxTime;

		// Token: 0x0400005A RID: 90
		[FieldOffset(2136710509)]
		public float Timer;

		// Token: 0x0400005B RID: 91
		[FieldOffset(2139014810)]
		public uint SourceEntityId;

		// Token: 0x0400005C RID: 92
		[FieldOffset(2142510211)]
		public ushort Charges;

		// Token: 0x0400005D RID: 93
		[FieldOffset(2136709357)]
		public ushort FlaskSlot;

		// Token: 0x0400005E RID: 94
		[FieldOffset(2139244516)]
		public ushort SourceSkillId;

		// Token: 0x0400005F RID: 95
		[FieldOffset(2138480060)]
		public ushort SourceSkillId2;
	}
}
