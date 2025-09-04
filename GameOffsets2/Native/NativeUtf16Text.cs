using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x0200008B RID: 139
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct NativeUtf16Text
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000020FC File Offset: 0x000002FC
		public long ByteLength
		{
			get
			{
				return this.Length * 2L;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000028B0 File Offset: 0x00000AB0
		public string CacheString
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.Buffer, "X16");
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.Reserved8Bytes, "X16");
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.Length);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x04000347 RID: 839
		public long Buffer;

		// Token: 0x04000348 RID: 840
		public long Reserved8Bytes;

		// Token: 0x04000349 RID: 841
		public long Length;

		// Token: 0x0400034A RID: 842
		public long LengthWithNullTerminator;
	}
}
