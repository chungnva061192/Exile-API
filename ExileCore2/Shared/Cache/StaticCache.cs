using System;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using System.Threading;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x0200016D RID: 365
	public class StaticCache<T> : IStaticCache<T>, IStaticCache, IDisposable
	{
		// Token: 0x0600098F RID: 2447 RVA: 0x0018DC84 File Offset: 0x0018DC84
		public StaticCache(int lifeTimeForCache = 120, string name = null)
		{
			this._name = (name ?? typeof(T).Name);
			this._cache = new MemoryCache(this._name, null);
			this._policy = new CacheItemPolicy
			{
				SlidingExpiration = TimeSpan.FromSeconds((double)lifeTimeForCache),
				RemovedCallback = delegate(CacheEntryRemovedArguments arguments)
				{
					int deletedCache = this.DeletedCache;
					this.DeletedCache = deletedCache + 1;
				}
			};
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0018DD04 File Offset: 0x0018DD04
		public void UpdateCache()
		{
			bool flag = !this._isEmpty;
			if (flag)
			{
				this._cache.Trim(100);
				this._isEmpty = true;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0018DD38 File Offset: 0x0018DD38
		public int Count
		{
			get
			{
				return this.ReadMemory - this.DeletedCache;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0018DD48 File Offset: 0x0018DD48
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x0018DD50 File Offset: 0x0018DD50
		public int DeletedCache { get; private set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0018DD5C File Offset: 0x0018DD5C
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x0018DD64 File Offset: 0x0018DD64
		public int ReadCache { get; private set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0018DD70 File Offset: 0x0018DD70
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0018DD78 File Offset: 0x0018DD78
		public int ReadMemory { get; private set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0018DD84 File Offset: 0x0018DD84
		public string CoeffString
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.Coeff, "0.000");
				defaultInterpolatedStringHandler.AppendLiteral("% Read from memory");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0018DDC4 File Offset: 0x0018DDC4
		public float Coeff
		{
			get
			{
				return (float)this.ReadMemory / (float)(this.ReadCache + this.ReadMemory) * 100f;
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0018DDE4 File Offset: 0x0018DDE4
		public T Read(string addr, Func<T> func)
		{
			this._cacheLock.EnterReadLock();
			try
			{
				this._isEmpty = false;
				object obj = this._cache[addr];
				bool flag = obj != null;
				if (flag)
				{
					int num = this.ReadCache;
					this.ReadCache = num + 1;
					return (T)((object)obj);
				}
			}
			finally
			{
				this._cacheLock.ExitReadLock();
			}
			this._cacheLock.EnterUpgradeableReadLock();
			T result;
			try
			{
				object obj2 = this._cache.Get(addr, null);
				bool flag2 = obj2 != null;
				if (flag2)
				{
					int num = this.ReadCache;
					this.ReadCache = num + 1;
					result = (T)((object)obj2);
				}
				else
				{
					try
					{
						this._cacheLock.EnterWriteLock();
						T t = func();
						int num = this.ReadMemory;
						this.ReadMemory = num + 1;
						this._cache.Add(addr, t, this._policy, null);
						result = t;
					}
					finally
					{
						this._cacheLock.ExitWriteLock();
					}
				}
			}
			finally
			{
				this._cacheLock.ExitUpgradeableReadLock();
			}
			return result;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0018DF1C File Offset: 0x0018DF1C
		public bool Remove(string key)
		{
			return this._cache.Remove(key, null) != null;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0018DF40 File Offset: 0x0018DF40
		public void Dispose()
		{
			MemoryCache cache = this._cache;
			if (cache != null)
			{
				cache.Dispose();
			}
		}

		// Token: 0x04007D86 RID: 32134
		private readonly ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim();

		// Token: 0x04007D87 RID: 32135
		private readonly string _name;

		// Token: 0x04007D88 RID: 32136
		private readonly CacheItemPolicy _policy;

		// Token: 0x04007D89 RID: 32137
		private readonly MemoryCache _cache;

		// Token: 0x04007D8A RID: 32138
		private bool _isEmpty = true;
	}
}
