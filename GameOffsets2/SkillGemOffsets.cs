using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000071 RID: 113
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct SkillGemOffsets
	{
		// Token: 0x040002E9 RID: 745
		[FieldOffset(2134295408)]
		public InitObjectOffsets Head;

		// Token: 0x040002EA RID: 746
		[FieldOffset(2146586607)]
		public long AdvanceInformation;

		// Token: 0x040002EB RID: 747
		[FieldOffset(2138659561)]
		public uint TotalExpGained;

		// Token: 0x040002EC RID: 748
		[FieldOffset(2136710893)]
		public uint Level;

		// Token: 0x040002ED RID: 749
		[FieldOffset(2138479612)]
		public uint ExperiencePrevLevel;

		// Token: 0x040002EE RID: 750
		[FieldOffset(2139242884)]
		public uint ExperienceMaxLevel;

		// Token: 0x040002EF RID: 751
		[FieldOffset(2145268098)]
		public uint QualityType;
	}
}
