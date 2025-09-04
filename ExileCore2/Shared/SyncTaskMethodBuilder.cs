using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.Shared
{
	// Token: 0x020000E9 RID: 233
	public class SyncTaskMethodBuilder<T>
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x00188538 File Offset: 0x00188538
		public static SyncTaskMethodBuilder<T> Create()
		{
			return new SyncTaskMethodBuilder<T>();
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00188540 File Offset: 0x00188540
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			this._stateMachine = stateMachine;
			this._stateMachine.SetStateMachine(stateMachine);
			this.Task.Awaiter.EnqueueItem(new Action(this._stateMachine.MoveNext));
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0018859C File Offset: 0x0018859C
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this._stateMachine = stateMachine;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x001885A8 File Offset: 0x001885A8
		public void SetException(Exception exception)
		{
			this.Task.Awaiter.ResultTask.SetException(exception);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x001885C4 File Offset: 0x001885C4
		public void SetResult(T result)
		{
			this.Task.Awaiter.ResultTask.SetResult(result);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x001885E0 File Offset: 0x001885E0
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			this._stateMachine = stateMachine;
			this._stateMachine.SetStateMachine(stateMachine);
			ref TAwaiter ptr = ref awaiter;
			if (default(TAwaiter) == null)
			{
				TAwaiter tawaiter = awaiter;
				ptr = ref tawaiter;
			}
			ptr.OnCompleted(delegate
			{
				this.Task.Awaiter.EnqueueItem(new Action(this._stateMachine.MoveNext));
			});
			SyncAwaiter syncAwaiter = awaiter as SyncAwaiter;
			bool flag = syncAwaiter != null;
			if (flag)
			{
				IDisposable @object = syncAwaiter.RedirectExecutionQueue(this.Task.Awaiter);
				syncAwaiter.OnCompleted(new Action(@object.Dispose));
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00188688 File Offset: 0x00188688
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			this.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00188694 File Offset: 0x00188694
		public SyncTask<T> Task { get; } = new SyncTask<T>(false);

		// Token: 0x040003E2 RID: 994
		private IAsyncStateMachine _stateMachine;
	}
}
