using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000006 RID: 6
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActorSkillOffsets
	{
		// Token: 0x04000013 RID: 19
		[FieldOffset(2132284507)]
		public byte SkillUseStage;

		// Token: 0x04000014 RID: 20
		[FieldOffset(2139243396)]
		public byte CastType;

		// Token: 0x04000015 RID: 21
		[FieldOffset(2139243076)]
		public SubActorSkillOffsets SubData;
	}
}
