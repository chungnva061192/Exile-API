using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000007 RID: 7
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct SubActorSkillOffsets
	{
		// Token: 0x04000016 RID: 22
		[FieldOffset(2134295152)]
		public ushort Id;

		// Token: 0x04000017 RID: 23
		[FieldOffset(2134295120)]
		public ushort Id2;

		// Token: 0x04000018 RID: 24
		[FieldOffset(2136710445)]
		public long EffectsPerLevelPtr;

		// Token: 0x04000019 RID: 25
		[FieldOffset(2131082837)]
		public int TotalUses;

		// Token: 0x0400001A RID: 26
		[FieldOffset(2142507555)]
		public int Cooldown;

		// Token: 0x0400001B RID: 27
		[FieldOffset(2141769665)]
		public int SoulsPerUse;

		// Token: 0x0400001C RID: 28
		[FieldOffset(2145271362)]
		public long StatsPtr;

		// Token: 0x0400001D RID: 29
		[FieldOffset(2144830558)]
		public StdVector Stats2Ptr;

		// Token: 0x0400001E RID: 30
		[FieldOffset(2139017354)]
		public byte UsageFlag1;

		// Token: 0x0400001F RID: 31
		[FieldOffset(2138475996)]
		public byte UsageFlag2;

		// Token: 0x04000020 RID: 32
		[FieldOffset(2139017370)]
		public byte UsageFlag3;

		// Token: 0x04000021 RID: 33
		[FieldOffset(2139017418)]
		public byte UsageFlag4;
	}
}
