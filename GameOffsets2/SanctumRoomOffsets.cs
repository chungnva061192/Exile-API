using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000067 RID: 103
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct SanctumRoomOffsets
	{
		// Token: 0x04000277 RID: 631
		public const int SanctumRoomDataInElementOffset = 976;

		// Token: 0x04000278 RID: 632
		public const int FightRoomOffset = 0;

		// Token: 0x04000279 RID: 633
		public const int RewardRoomOffset = 16;

		// Token: 0x0400027A RID: 634
		public const int RoomEffectOffset = 32;

		// Token: 0x0400027B RID: 635
		public const int RoomDataStructureSize = 64;
	}
}
