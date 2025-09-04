using System;

namespace ExileCore2.Shared.Interfaces
{
	// Token: 0x0200011A RID: 282
	public interface INativePtrArray
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008B5 RID: 2229
		IntPtr First { get; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008B6 RID: 2230
		IntPtr Last { get; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060008B7 RID: 2231
		IntPtr End { get; }

		// Token: 0x060008B8 RID: 2232
		string ToString();
	}
}
