using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200002B RID: 43
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 8)]
	public struct Type1EnvironmentSettingsOffsets
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002354 File Offset: 0x00000554
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Value);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.Override);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040000F7 RID: 247
		[FieldOffset(2131431974)]
		public float Value;

		// Token: 0x040000F8 RID: 248
		[FieldOffset(2139014234)]
		public byte Override;
	}
}
