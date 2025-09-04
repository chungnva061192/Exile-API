using GameOffsets2.Native;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200005D RID: 93
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct PerPlayerServerDataOffsets
	{
		// Token: 0x04000237 RID: 567
		public const int QuestFlagsOffset = 560;

		// Token: 0x04000238 RID: 568
		[FieldOffset(2137306120)]
		public long QuestFlagsPtr;

		// Token: 0x04000239 RID: 569
		[FieldOffset(2139248964)]
		public long SubData;

        // Token: 0x0400023A RID: 570
        [FieldOffset(2130955093)]
        public Buffer13<(ushort Id, ushort Id2)> SkillBarIds;

        // Token: 0x0400023B RID: 571
        [FieldOffset(2131597990)]
		public Vector2 WorldMousePosition;

		// Token: 0x0400023C RID: 572
		[FieldOffset(2144417630)]
		public NativePtrArray PlayerInventories;

		// Token: 0x0400023D RID: 573
		[FieldOffset(2136811437)]
		public NativePtrArray NPCInventories;

		// Token: 0x0400023E RID: 574
		[FieldOffset(2146708207)]
		public long PlayerRelatedData;
	}
}
