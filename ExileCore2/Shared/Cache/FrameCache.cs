using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x02000167 RID: 359
	public class FrameCache<T> : CachedValue<T>
	{
		// Token: 0x06000983 RID: 2435 RVA: 0x0018DA54 File Offset: 0x0018DA54
		public FrameCache(Func<T> func) : base(func)
		{
			this._frame = uint.MaxValue;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0018DA68 File Offset: 0x0018DA68
		protected override bool Update(bool force)
		{
			bool flag = this._frame != Core.FramesCount || force;
			bool result;
			if (flag)
			{
				this._frame = Core.FramesCount;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04007D7C RID: 32124
		private uint _frame;
	}
}
