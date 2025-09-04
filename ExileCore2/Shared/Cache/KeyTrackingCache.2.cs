using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x0200016B RID: 363
	public static class KeyTrackingCache
	{
		// Token: 0x0600098C RID: 2444 RVA: 0x0018DBDC File Offset: 0x0018DBDC
		public static KeyTrackingCache<T, TKey> Create<T, TKey>(Func<T> func, Func<TKey> keyFunc)
		{
			return new KeyTrackingCache<T, TKey>(func, keyFunc);
		}
	}
}
