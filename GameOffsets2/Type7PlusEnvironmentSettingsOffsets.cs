using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000031 RID: 49
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
	public struct Type7PlusEnvironmentSettingsOffsets
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002538 File Offset: 0x00000738
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<Vector4>(this.Value);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<Vector4>(this.Value2);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x04000106 RID: 262
		[FieldOffset(2131081173)]
		public Vector4 Value;

		// Token: 0x04000107 RID: 263
		[FieldOffset(2140375447)]
		public Vector4 Value2;
	}
}
