using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200002E RID: 46
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2)]
	public struct Type4EnvironmentSettingsOffsets
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002438 File Offset: 0x00000638
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.Value);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.Override);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040000FD RID: 253
		[FieldOffset(2131431974)]
		public byte Value;

		// Token: 0x040000FE RID: 254
		[FieldOffset(2138659065)]
		public byte Override;
	}
}
