using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000070 RID: 112
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
	public struct Shortcut
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000025E0 File Offset: 0x000007E0
		public string ModifierText
		{
			get
			{
				string result;
				if (this.Modifier != ShortcutModifier.None)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
					defaultInterpolatedStringHandler.AppendFormatted<ShortcutModifier>(this.Modifier);
					defaultInterpolatedStringHandler.AppendLiteral(" + ");
					result = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002624 File Offset: 0x00000824
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 4);
			defaultInterpolatedStringHandler.AppendFormatted(this.ModifierText);
			defaultInterpolatedStringHandler.AppendFormatted<ConsoleKey>(this.MainKey);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<ShortcutUsage>(this.Usage);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)this.Usage);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040002E6 RID: 742
		[FieldOffset(2138659049)]
		public ConsoleKey MainKey;

		// Token: 0x040002E7 RID: 743
		[FieldOffset(2142509283)]
		public ShortcutModifier Modifier;

		// Token: 0x040002E8 RID: 744
		[FieldOffset(2134295536)]
		public ShortcutUsage Usage;
	}
}
