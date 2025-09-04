using System;

namespace ExileCore2.Shared.Interfaces
{
	// Token: 0x0200011B RID: 283
	public interface IPattern
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060008B9 RID: 2233
		string Name { get; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060008BA RID: 2234
		byte[] Bytes { get; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060008BB RID: 2235
		string Mask { get; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060008BC RID: 2236
		int StartOffset { get; }
	}
}
