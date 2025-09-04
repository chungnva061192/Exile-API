using GameOffsets2.Native;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000030 RID: 48
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 80)]
	public struct Type6EnvironmentSettingsOffsets
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000024D0 File Offset: 0x000006D0
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 3);
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Value1);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Value2);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.Override);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x04000101 RID: 257
		[FieldOffset(2138478972)]
		public NativeUtf16Text Name;

		// Token: 0x04000102 RID: 258
		[FieldOffset(2134294896)]
		public NativeUtf16Text Category;

		// Token: 0x04000103 RID: 259
		[FieldOffset(2132283611)]
		public float Value1;

		// Token: 0x04000104 RID: 260
		[FieldOffset(2138479932)]
		public float Value2;

		// Token: 0x04000105 RID: 261
		[FieldOffset(2131080021)]
		public byte Override;
	}
}
