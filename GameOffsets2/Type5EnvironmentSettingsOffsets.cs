using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200002F RID: 47
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 8)]
	public struct Type5EnvironmentSettingsOffsets
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002484 File Offset: 0x00000684
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.Value);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.Override);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040000FF RID: 255
		[FieldOffset(2131081173)]
		public byte Value;

		// Token: 0x04000100 RID: 256
		[FieldOffset(2132284619)]
		public byte Override;
	}
}
