using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExileCore2.Shared
{
	// Token: 0x020000EF RID: 239
	public class SyncAwaiter<T> : SyncAwaiter
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00188914 File Offset: 0x00188914
		public bool IsSyncContinuation { get; }

		// Token: 0x0600077F RID: 1919 RVA: 0x0018891C File Offset: 0x0018891C
		public SyncAwaiter(bool isSyncContinuation)
		{
			this.IsSyncContinuation = isSyncContinuation;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00188938 File Offset: 0x00188938
		public bool IsCompleted
		{
			get
			{
				return this.ResultTask.Task.IsCompleted;
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0018894C File Offset: 0x0018894C
		public T GetResult()
		{
			return this.ResultTask.Task.GetAwaiter().GetResult();
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00188974 File Offset: 0x00188974
		internal TaskCompletionSource<T> ResultTask { get; } = new TaskCompletionSource<T>();

		// Token: 0x06000783 RID: 1923 RVA: 0x0018897C File Offset: 0x0018897C
		public override void OnCompleted(Action completion)
		{
			bool flag = this.IsSyncContinuation && this.ResultTask.Task.IsCompleted;
			if (flag)
			{
				completion();
			}
			else
			{
				this.ResultTask.Task.ContinueWith(delegate([Nullable(new byte[]
				{
					1,
					0
				})] Task<T> _)
				{
					completion();
				}, TaskContinuationOptions.ExecuteSynchronously);
			}
		}
	}
}
