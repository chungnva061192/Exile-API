using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x0200016C RID: 364
	public class LatancyCache<T> : CachedValue<T>
	{
		// Token: 0x0600098D RID: 2445 RVA: 0x0018DBF8 File Offset: 0x0018DBF8
		public LatancyCache(Func<T> func, int minLatency = 10) : base(func)
		{
			this._minLatency = minLatency;
			this._checkTime = long.MinValue;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0018DC1C File Offset: 0x0018DC1C
		protected override bool Update(bool force)
		{
			float latency = CachedValue.Latency;
			long elapsedMilliseconds = CachedValue<T>.sw.ElapsedMilliseconds;
			bool flag = elapsedMilliseconds >= this._checkTime || force;
			bool result;
			if (flag)
			{
				bool flag2 = latency > (float)this._minLatency;
				if (flag2)
				{
					this._checkTime = (long)((float)elapsedMilliseconds + latency);
				}
				else
				{
					this._checkTime = elapsedMilliseconds + (long)this._minLatency;
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04007D84 RID: 32132
		private readonly int _minLatency;

		// Token: 0x04007D85 RID: 32133
		private long _checkTime;
	}
}
