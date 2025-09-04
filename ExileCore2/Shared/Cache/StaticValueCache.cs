using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x0200016E RID: 366
	public class StaticValueCache<T> : CachedValue<T>
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x0018DF78 File Offset: 0x0018DF78
		public StaticValueCache(Func<T> func) : base(func)
		{
			this.first = true;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0018DF8C File Offset: 0x0018DF8C
		protected override bool Update(bool force)
		{
			bool flag = this.first;
			bool result;
			if (flag)
			{
				this.first = false;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04007D8E RID: 32142
		private bool first;
	}
}
