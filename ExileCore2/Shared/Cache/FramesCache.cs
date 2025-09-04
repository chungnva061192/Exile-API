using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x02000168 RID: 360
	public class FramesCache<T> : FrameCache<T>
	{
		// Token: 0x06000985 RID: 2437 RVA: 0x0018DAA4 File Offset: 0x0018DAA4
		public FramesCache(Func<T> func, uint waitFrames = 1U) : base(func)
		{
			this._waitFrames = waitFrames;
			this._frame = 0U;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0018DAC0 File Offset: 0x0018DAC0
		protected override bool Update(bool force)
		{
			bool flag = Core.FramesCount >= this._frame || force;
			bool result;
			if (flag)
			{
				this._frame += this._waitFrames;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04007D7D RID: 32125
		private readonly uint _waitFrames;

		// Token: 0x04007D7E RID: 32126
		private uint _frame;
	}
}
