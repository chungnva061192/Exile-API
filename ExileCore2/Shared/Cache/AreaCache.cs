using System;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x0200015E RID: 350
	public class AreaCache<T> : CachedValue<T>
	{
		// Token: 0x06000961 RID: 2401 RVA: 0x0018D654 File Offset: 0x0018D654
		public AreaCache(Func<T> func) : base(func)
		{
			this._areaHash = uint.MaxValue;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0018D668 File Offset: 0x0018D668
		protected override bool Update(bool force)
		{
			bool flag = this._areaHash != AreaInstance.CurrentHash || this._zoneSwitchId != AreaInstance.ZoneSwitchCounter || this._forceRefreshCounter != AreaInstance.ForceRefreshCounter || force;
			bool result;
			if (flag)
			{
				this._areaHash = AreaInstance.CurrentHash;
				this._zoneSwitchId = AreaInstance.ZoneSwitchCounter;
				this._forceRefreshCounter = AreaInstance.ForceRefreshCounter;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04007D6B RID: 32107
		private uint _areaHash;

		// Token: 0x04007D6C RID: 32108
		private int _zoneSwitchId;

		// Token: 0x04007D6D RID: 32109
		private uint _forceRefreshCounter;
	}
}
