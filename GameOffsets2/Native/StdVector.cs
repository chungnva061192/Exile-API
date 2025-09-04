using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x0200008E RID: 142
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct StdVector
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000291C File Offset: 0x00000B1C
		public readonly long TotalElements(int elementSize)
		{
			return (this.Last - this.First) / (long)elementSize;
		}

        // Token: 0x06000025 RID: 37 RVA: 0x00002940 File Offset: 0x00000B40
        public readonly long ElementCount<T>() where T : unmanaged
        {
            return TotalElements(Unsafe.SizeOf<T>());
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00002960 File Offset: 0x00000B60
        public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.First, "X");
			defaultInterpolatedStringHandler.AppendLiteral(" - ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.Last, "X");
			defaultInterpolatedStringHandler.AppendLiteral(" - ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.TotalElements(1));
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x04000350 RID: 848
		public long First;

		// Token: 0x04000351 RID: 849
		public long Last;

		// Token: 0x04000352 RID: 850
		public long End;
	}
}
