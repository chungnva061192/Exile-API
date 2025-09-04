using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000056 RID: 86
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ModsComponentOffsets
	{
		// Token: 0x04000212 RID: 530
		public static readonly int HumanStats = 32;

		// Token: 0x04000213 RID: 531
		public static readonly int ItemModRecordSize = 40;

		// Token: 0x04000214 RID: 532
		public static readonly int NameRecordSize = 16;

		// Token: 0x04000215 RID: 533
		public static readonly int NameOffset = 4;

		// Token: 0x04000216 RID: 534
		public static readonly int StatRecordSize = 32;

		// Token: 0x04000217 RID: 535
		[FieldOffset(2131432358)]
		public StdVector UniqueName;

		// Token: 0x04000218 RID: 536
		[FieldOffset(2137302408)]
		public bool Identified;

		// Token: 0x04000219 RID: 537
		[FieldOffset(2131082485)]
		public byte FracturedModsCount;

		// Token: 0x0400021A RID: 538
		[FieldOffset(2145270658)]
		public int ItemRarity;

		// Token: 0x0400021B RID: 539
		[FieldOffset(2138477692)]
		public NativePtrArray implicitMods;

		// Token: 0x0400021C RID: 540
		[FieldOffset(2146584047)]
		public NativePtrArray explicitMods;

		// Token: 0x0400021D RID: 541
		[FieldOffset(2139015834)]
		public NativePtrArray enchantMods;

		// Token: 0x0400021E RID: 542
		[FieldOffset(2131082709)]
		public NativePtrArray ScourgeMods;

		// Token: 0x0400021F RID: 543
		[FieldOffset(2142505635)]
		public NativePtrArray crucibleMods;

		// Token: 0x04000220 RID: 544
		[FieldOffset(2134302448)]
		public long ModsComponentStatsPtr;

		// Token: 0x04000221 RID: 545
		[FieldOffset(2144843102)]
		public StdVector GrantedSkills;

		// Token: 0x04000222 RID: 546
		[FieldOffset(2134303216)]
		public StdVector GrantedSkills2;

		// Token: 0x04000223 RID: 547
		[FieldOffset(2134304496)]
		public NativePtrArray GetSynthesizedStats;

		// Token: 0x04000224 RID: 548
		[FieldOffset(2144841822)]
		public int ItemLevel;

		// Token: 0x04000225 RID: 549
		[FieldOffset(2132291739)]
		public int RequiredLevel;

		// Token: 0x04000226 RID: 550
		[FieldOffset(2137295576)]
		public byte IsMirrored;

		// Token: 0x04000227 RID: 551
		[FieldOffset(2139021690)]
		public byte IsSplit;

		// Token: 0x04000228 RID: 552
		[FieldOffset(2144842030)]
		public byte IsUsable;
	}
}
