using System;

namespace ExileCore2.Shared.Enums
{
	// Token: 0x02000130 RID: 304
	[Flags]
	public enum ActionFlags
	{
		// Token: 0x04000483 RID: 1155
		None = 0,
		// Token: 0x04000484 RID: 1156
		UsingAbility = 2,
		// Token: 0x04000485 RID: 1157
		AbilityCooldownActive = 16,
		// Token: 0x04000486 RID: 1158
		UsingAbilityAbilityCooldown = 18,
		// Token: 0x04000487 RID: 1159
		Dead = 64,
		// Token: 0x04000488 RID: 1160
		Moving = 128,
		// Token: 0x04000489 RID: 1161
		WashedUpState = 256,
		// Token: 0x0400048A RID: 1162
		HasMines = 2048
	}
}
