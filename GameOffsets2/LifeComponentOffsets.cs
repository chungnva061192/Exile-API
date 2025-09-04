using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200004B RID: 75
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct LifeComponentOffsets
	{
		// Token: 0x040001CA RID: 458
		[FieldOffset(2139014298)]
		public long Owner;

		// Token: 0x040001CB RID: 459
		[FieldOffset(2131440166)]
		public VitalStruct Mana;

		// Token: 0x040001CC RID: 460
		[FieldOffset(2131072085)]
		public VitalStruct EnergyShield;

		// Token: 0x040001CD RID: 461
		[FieldOffset(2146588015)]
		public VitalStruct Health;

		// Token: 0x040001CE RID: 462
		[FieldOffset(2131430822)]
		public bool Invulnerable;
	}
}
