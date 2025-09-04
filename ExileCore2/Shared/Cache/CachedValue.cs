using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x02000160 RID: 352
	public abstract class CachedValue
	{
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0018D74C File Offset: 0x0018D74C
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x0018D754 File Offset: 0x0018D754
		public static float Latency
		{
			[CompilerGenerated]
			get
			{
				return CachedValue.<Latency>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				value;
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0018D75C File Offset: 0x0018D75C
		protected CachedValue()
		{
			this;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0018D768 File Offset: 0x0018D768
		// Note: this type is marked as 'beforefieldinit'.
		static CachedValue()
		{
			25f;
		}

		// Token: 0x04007D6F RID: 32111
		public static int TotalCount;

		// Token: 0x04007D70 RID: 32112
		public static int LifeCount;
	}
}
