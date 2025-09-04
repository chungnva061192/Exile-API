using System;
using System.Collections.Generic;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x02000169 RID: 361
	public class KeyTrackingCache<T, TKey> : CachedValue<T>
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x0018DB04 File Offset: 0x0018DB04
		public KeyTrackingCache(Func<T> func, Func<TKey> keyFunc) : base(func)
		{
			this._keyFunc = keyFunc;
			this._first = true;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0018DB20 File Offset: 0x0018DB20
		public KeyTrackingCache(Func<TKey, T> func, Func<TKey> keyFunc) : base(() => func(keyFunc()))
		{
			this._keyFunc = keyFunc;
			this._first = true;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0018DB68 File Offset: 0x0018DB68
		protected override bool Update(bool force)
		{
			TKey tkey = this._keyFunc();
			bool result = this._first || !EqualityComparer<TKey>.Default.Equals(tkey, this._lastKey);
			this._lastKey = tkey;
			this._first = false;
			return result;
		}

		// Token: 0x04007D7F RID: 32127
		private readonly Func<TKey> _keyFunc;

		// Token: 0x04007D80 RID: 32128
		private TKey _lastKey;

		// Token: 0x04007D81 RID: 32129
		private bool _first;
	}
}
