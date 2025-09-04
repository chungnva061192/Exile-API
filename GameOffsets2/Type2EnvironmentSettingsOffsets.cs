using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200002C RID: 44
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 8)]
	public struct Type2EnvironmentSettingsOffsets
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000023A0 File Offset: 0x000005A0
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Value);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.Override);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040000F9 RID: 249
		[FieldOffset(2145268418)]
		public float Value;

		// Token: 0x040000FA RID: 250
		[FieldOffset(2137304264)]
		public byte Override;
	}
}
