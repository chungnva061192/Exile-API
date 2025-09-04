using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000004 RID: 4
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
	public struct ActorDeployedObjectOffsets
	{
		// Token: 0x0400000B RID: 11
		[FieldOffset(2140376471)]
		public uint EntityId;

		// Token: 0x0400000C RID: 12
		[FieldOffset(2144834590)]
		public ushort SkillId;

		// Token: 0x0400000D RID: 13
		[FieldOffset(2134295312)]
		public ushort SkillId2;

		// Token: 0x0400000E RID: 14
		[FieldOffset(2138658921)]
		public ushort ObjectType;
	}
}
