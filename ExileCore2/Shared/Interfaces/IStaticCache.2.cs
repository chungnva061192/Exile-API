using System;

namespace ExileCore2.Shared.Interfaces
{
	// Token: 0x02000120 RID: 288
	public interface IStaticCache<T> : IStaticCache, IDisposable
	{
		// Token: 0x060008F1 RID: 2289
		T Read(string addr, Func<T> func);
	}
}
