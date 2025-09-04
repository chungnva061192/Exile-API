using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x0200008A RID: 138
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct NativeUtf8Text
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002844 File Offset: 0x00000A44
		public string CacheString
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.Buffer, "X16");
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.Reserved8Bytes, "X16");
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Length);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x04000343 RID: 835
		[FieldOffset(2131431974)]
		public long Buffer;

		// Token: 0x04000344 RID: 836
		[FieldOffset(2144834782)]
		public long Reserved8Bytes;

		// Token: 0x04000345 RID: 837
		[FieldOffset(2134295152)]
		public int Length;

		// Token: 0x04000346 RID: 838
		[FieldOffset(2146586607)]
		public int LengthWithNullTerminator;
	}
}
