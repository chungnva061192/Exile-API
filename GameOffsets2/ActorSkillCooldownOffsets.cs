using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000005 RID: 5
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActorSkillCooldownOffsets
	{
		// Token: 0x0400000F RID: 15
		[FieldOffset(2138479100)]
		public int SkillSubId;

		// Token: 0x04000010 RID: 16
		[FieldOffset(2140376215)]
		public StdVector Cooldowns;

		// Token: 0x04000011 RID: 17
		[FieldOffset(2142509987)]
		public int MaxUses;

		// Token: 0x04000012 RID: 18
		[FieldOffset(2134294704)]
		public ushort SkillId;
	}
}
