using System;
using System.Runtime.InteropServices;
using SharpGen.Runtime;

namespace ExileCore2
{
	// Token: 0x0200005E RID: 94
	public static class ImguiVariadic
	{
		// Token: 0x06000352 RID: 850
		[DllImport("cimgui", CallingConvention = 2)]
		public unsafe static extern void igTextWrapped(byte* fmt, __arglist);

		// Token: 0x06000353 RID: 851 RVA: 0x00174F4C File Offset: 0x00174F4C
		public unsafe static void TextWrappedUnformatted(string text)
		{
			ImguiVariadic.igTextWrapped(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.EE50C235AF5866F1C9006029AD5406AB89842BF85D9FF778A70C3F9DA747D15E), 3).GetPointerUnsafe<byte>(), text);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00174F68 File Offset: 0x00174F68
		public unsafe static void TextWrappedUnformatted(string text1, string text2)
		{
			ImguiVariadic.igTextWrapped(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.DB637963BF086395DC5B4A3369240414184806045C3F6408C7D76F0C43808EB3), 5).GetPointerUnsafe<byte>(), text1, text2);
		}
	}
}
