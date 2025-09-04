using System;

namespace ExileCore2.Shared.Enums
{
	// Token: 0x0200013E RID: 318
	[Flags]
	public enum Influence : byte
	{
		// Token: 0x040063AF RID: 25519
		None = 0,
		// Token: 0x040063B0 RID: 25520
		Shaper = 1,
		// Token: 0x040063B1 RID: 25521
		Elder = 2,
		// Token: 0x040063B2 RID: 25522
		Crusader = 4,
		// Token: 0x040063B3 RID: 25523
		Redeemer = 8,
		// Token: 0x040063B4 RID: 25524
		Hunter = 16,
		// Token: 0x040063B5 RID: 25525
		Warlord = 32
	}
}
