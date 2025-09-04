using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x02000165 RID: 357
	public class ConditionalCache<T> : CachedValue<T>
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x0018D9BC File Offset: 0x0018D9BC
		public ConditionalCache(Func<T> func, Func<bool> cond) : base(func)
		{
			this._cond = ((T _) => cond());
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0018D9F4 File Offset: 0x0018D9F4
		public ConditionalCache(Func<T> func, Func<T, bool> cond) : base(func)
		{
			this._cond = cond;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0018DA08 File Offset: 0x0018DA08
		protected override bool Update(bool force)
		{
			return this._cond(this.StoredValue) || force;
		}

		// Token: 0x04007D7A RID: 32122
		private readonly Func<T, bool> _cond;
	}
}
