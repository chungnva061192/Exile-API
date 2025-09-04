using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x02000163 RID: 355
	public class CacheUtils
	{
		// Token: 0x0600097A RID: 2426 RVA: 0x0018D944 File Offset: 0x0018D944
		public static Func<T> RememberLastValue<T>(Func<T, T> valueProducer, T initialValue = default(T))
		{
			return () => initialValue = valueProducer(initialValue);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0018D978 File Offset: 0x0018D978
		public CacheUtils()
		{
			this;
		}
	}
}
