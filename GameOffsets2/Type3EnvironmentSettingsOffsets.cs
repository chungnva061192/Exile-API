using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200002D RID: 45
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	public struct Type3EnvironmentSettingsOffsets
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000023EC File Offset: 0x000005EC
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<Vector3>(this.Value);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.Override);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040000FB RID: 251
		[FieldOffset(2140376471)]
		public Vector3 Value;

		// Token: 0x040000FC RID: 252
		[FieldOffset(2132284443)]
		public byte Override;
	}
}
