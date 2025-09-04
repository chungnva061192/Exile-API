using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.Shared
{
	// Token: 0x020000EA RID: 234
	[AsyncMethodBuilder(typeof(SyncTaskMethodBuilder<>))]
	public class SyncTask<T>
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x001886DC File Offset: 0x001886DC
		public SyncTask(bool isSyncContinuation)
		{
			this.Awaiter = new SyncAwaiter<T>(isSyncContinuation);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x001886F4 File Offset: 0x001886F4
		public SyncAwaiter<T> GetAwaiter()
		{
			return this.Awaiter;
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x001886FC File Offset: 0x001886FC
		internal SyncAwaiter<T> Awaiter { get; }
	}
}
