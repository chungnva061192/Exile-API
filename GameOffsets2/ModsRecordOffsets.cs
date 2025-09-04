using GameOffsets2.Native;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000054 RID: 84
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ModsRecordOffsets
	{
		// Token: 0x040001E6 RID: 486
		[FieldOffset(2136710317)]
		public long KeyPtr;

		// Token: 0x040001E7 RID: 487
		[FieldOffset(2140376343)]
		public short Hash;

		// Token: 0x040001E8 RID: 488
		[FieldOffset(2139243492)]
		public long TypePtr;

		// Token: 0x040001E9 RID: 489
		[FieldOffset(2138659145)]
		public int MinLevel;

		// Token: 0x040001EA RID: 490
		[FieldOffset(2138478748)]
		public long Stat1Ptr;

		// Token: 0x040001EB RID: 491
		[FieldOffset(2141767265)]
		public long Stat2Ptr;

		// Token: 0x040001EC RID: 492
		[FieldOffset(2139242660)]
		public long Stat3Ptr;

		// Token: 0x040001ED RID: 493
		[FieldOffset(2134296464)]
		public long Stat4Ptr;

		// Token: 0x040001EE RID: 494
		[FieldOffset(2142510403)]
		public int Domain;

		// Token: 0x040001EF RID: 495
		[FieldOffset(2137303720)]
		public long UserFriendlyName;

		// Token: 0x040001F0 RID: 496
		[FieldOffset(2146584783)]
		public int AffixType;

        // Token: 0x040001F1 RID: 497
        [FieldOffset(2136709709)]
        public (long Count, long Ptr) Group;

        // Token: 0x040001F2 RID: 498
        [FieldOffset(2139243556)]
		public long Something;

		// Token: 0x040001F3 RID: 499
		[FieldOffset(2144834494)]
		public Vector2i Stat1Range;

		// Token: 0x040001F4 RID: 500
		[FieldOffset(2146584079)]
		public Vector2i Stat2Range;

		// Token: 0x040001F5 RID: 501
		[FieldOffset(2146584207)]
		public Vector2i Stat3Range;

		// Token: 0x040001F6 RID: 502
		[FieldOffset(2131434310)]
		public Vector2i Stat4Range;

		// Token: 0x040001F7 RID: 503
		[FieldOffset(2142507331)]
		public long Tags;

		// Token: 0x040001F8 RID: 504
		[FieldOffset(2146583567)]
		public long ta;

		// Token: 0x040001F9 RID: 505
		[FieldOffset(2131082549)]
		public int TagChances;

		// Token: 0x040001FA RID: 506
		[FieldOffset(2142507971)]
		public long tc;

		// Token: 0x040001FB RID: 507
		[FieldOffset(2141769569)]
		public long BuffDefinitionsPtr;

		// Token: 0x040001FC RID: 508
		[FieldOffset(2134298384)]
		public long BuffDefinitions;

		// Token: 0x040001FD RID: 509
		[FieldOffset(2136707149)]
		public int BuffValue;

		// Token: 0x040001FE RID: 510
		[FieldOffset(2137301416)]
		public long tgcCount;

		// Token: 0x040001FF RID: 511
		[FieldOffset(2138657865)]
		public long tgcPtr;

		// Token: 0x04000200 RID: 512
		[FieldOffset(2139247140)]
		public Vector2i Stat5Range;

		// Token: 0x04000201 RID: 513
		[FieldOffset(2131428294)]
		public long Stat5Ptr;

		// Token: 0x04000202 RID: 514
		[FieldOffset(2131428822)]
		public Vector2i Stat6Range;

		// Token: 0x04000203 RID: 515
		[FieldOffset(2141773041)]
		public long Stat6Ptr;

		// Token: 0x04000204 RID: 516
		[FieldOffset(2141773729)]
		public byte IsEssence;

		// Token: 0x04000205 RID: 517
		[FieldOffset(2139250628)]
		public Vector2i Stat7Range;

		// Token: 0x04000206 RID: 518
		[FieldOffset(2145267314)]
		public long Tier;

		// Token: 0x04000207 RID: 519
		[FieldOffset(2136703405)]
		public long Stat7Ptr;

		// Token: 0x04000208 RID: 520
		[FieldOffset(2138474364)]
		public long Stat8Ptr;

		// Token: 0x04000209 RID: 521
		[FieldOffset(2131077333)]
		public Vector2i Stat8Range;

		// Token: 0x0400020A RID: 522
		[FieldOffset(2136703789)]
		public int InfluenceTypes;

		// Token: 0x0400020B RID: 523
		[FieldOffset(2146592831)]
		public uint Hash32;
	}
}
