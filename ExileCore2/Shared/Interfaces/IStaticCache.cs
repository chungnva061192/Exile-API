using System;

namespace ExileCore2.Shared.Interfaces
{
	// Token: 0x0200011F RID: 287
	public interface IStaticCache : IDisposable
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060008E9 RID: 2281
		int Count { get; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060008EA RID: 2282
		int DeletedCache { get; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060008EB RID: 2283
		int ReadCache { get; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060008EC RID: 2284
		int ReadMemory { get; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060008ED RID: 2285
		string CoeffString { get; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060008EE RID: 2286
		float Coeff { get; }

		// Token: 0x060008EF RID: 2287
		void UpdateCache();

		// Token: 0x060008F0 RID: 2288
		bool Remove(string key);
	}
}
