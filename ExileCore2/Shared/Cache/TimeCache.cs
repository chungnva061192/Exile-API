using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x0200016F RID: 367
	public class TimeCache<T> : CachedValue<T>
	{
		// Token: 0x060009A0 RID: 2464 RVA: 0x0018DFB8 File Offset: 0x0018DFB8
		public TimeCache(Func<T> func, long waitMilliseconds) : base(func)
		{
			this.time = long.MinValue;
			this._waitMilliseconds = waitMilliseconds;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0018DFDC File Offset: 0x0018DFDC
		public void NewTime(long newTime)
		{
			this._waitMilliseconds = newTime;
			this.time = this._waitMilliseconds + CachedValue<T>.sw.ElapsedMilliseconds;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0018E000 File Offset: 0x0018E000
		protected override bool Update(bool force)
		{
			long elapsedMilliseconds = CachedValue<T>.sw.ElapsedMilliseconds;
			bool flag = elapsedMilliseconds >= this.time || force;
			bool result;
			if (flag)
			{
				this.time = elapsedMilliseconds + this._waitMilliseconds;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04007D8F RID: 32143
		private long _waitMilliseconds;

		// Token: 0x04007D90 RID: 32144
		private long time;
	}
}
