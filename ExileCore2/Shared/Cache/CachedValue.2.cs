using System;
using System.Diagnostics;
using System.Threading;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x02000161 RID: 353
	public abstract class CachedValue<T> : CachedValue
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x0018D774 File Offset: 0x0018D774
		protected CachedValue(Func<T> func)
		{
			if (func == null)
			{
				throw new ArgumentNullException("func", "Cached Value ctor null function");
			}
			this._func = func;
			Interlocked.Increment(ref CachedValue.TotalCount);
			Interlocked.Increment(ref CachedValue.LifeCount);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0018D7C4 File Offset: 0x0018D7C4
		public T Value
		{
			get
			{
				bool flag = this.Update(this._force);
				T storedValue;
				if (flag)
				{
					this._force = false;
					this.StoredValue = this._func();
					CachedValue<T>.CacheUpdateEvent onUpdate = this.OnUpdate;
					if (onUpdate != null)
					{
						onUpdate(this.StoredValue);
					}
					this._updated = true;
					storedValue = this.StoredValue;
				}
				else
				{
					bool flag2 = !this._updated;
					if (flag2)
					{
						this.StoredValue = this._func();
						CachedValue<T>.CacheUpdateEvent onUpdate2 = this.OnUpdate;
						if (onUpdate2 != null)
						{
							onUpdate2(this.StoredValue);
						}
						this._updated = true;
						storedValue = this.StoredValue;
					}
					else
					{
						storedValue = this.StoredValue;
					}
				}
				return storedValue;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0018D878 File Offset: 0x0018D878
		public T RealValue
		{
			get
			{
				return this._func();
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000970 RID: 2416 RVA: 0x0018D888 File Offset: 0x0018D888
		// (remove) Token: 0x06000971 RID: 2417 RVA: 0x0018D8C0 File Offset: 0x0018D8C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event CachedValue<T>.CacheUpdateEvent OnUpdate;

		// Token: 0x06000972 RID: 2418 RVA: 0x0018D8F8 File Offset: 0x0018D8F8
		public void ForceUpdate()
		{
			this._force = true;
		}

		// Token: 0x06000973 RID: 2419
		protected abstract bool Update(bool force);

		// Token: 0x06000974 RID: 2420 RVA: 0x0018D904 File Offset: 0x0018D904
		~CachedValue()
		{
			Interlocked.Decrement(ref CachedValue.LifeCount);
		}

		// Token: 0x04007D72 RID: 32114
		protected static readonly Stopwatch sw = Stopwatch.StartNew();

		// Token: 0x04007D73 RID: 32115
		private readonly Func<T> _func;

		// Token: 0x04007D74 RID: 32116
		private bool _force;

		// Token: 0x04007D75 RID: 32117
		protected T StoredValue;

		// Token: 0x04007D76 RID: 32118
		private bool _updated = false;

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x06000977 RID: 2423
		public delegate void CacheUpdateEvent(T t);
	}
}
