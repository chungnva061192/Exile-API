using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000058 RID: 88
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ObjectHeaderOffsets
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002584 File Offset: 0x00000784
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
			defaultInterpolatedStringHandler.AppendLiteral("MainObject: ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.MainObject);
			defaultInterpolatedStringHandler.AppendLiteral(" ComponentList:");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.ComponentLookUpPtr);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0400022B RID: 555
		[FieldOffset(2132284635)]
		public long MainObject;

		// Token: 0x0400022C RID: 556
		[FieldOffset(2131432102)]
		public long Name;

		// Token: 0x0400022D RID: 557
		[FieldOffset(2139014938)]
		public long ComponentLookUpPtr;
	}
}
