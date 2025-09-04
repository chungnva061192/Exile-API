using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000069 RID: 105
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ServerPlayerDataOffsets
	{
		// Token: 0x0400027D RID: 637
		[FieldOffset(2134301680)]
		public StdVector PassiveSkillIds;

		// Token: 0x0400027E RID: 638
		[FieldOffset(2139251780)]
		public byte PlayerClass;

		// Token: 0x0400027F RID: 639
		[FieldOffset(2146592943)]
		public int CharacterLevel;

		// Token: 0x04000280 RID: 640
		[FieldOffset(2137295752)]
		public int QuestPassiveSkillPoints;

		// Token: 0x04000281 RID: 641
		[FieldOffset(2140382615)]
		public int TotalAscendancyPoints;

		// Token: 0x04000282 RID: 642
		[FieldOffset(2141777089)]
		public int SpentAscendancyPoints;
	}
}
