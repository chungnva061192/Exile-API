using System;
using System.Collections.Generic;
using System.Linq;

namespace ExileCore2.Shared
{
	// Token: 0x020000EB RID: 235
	public static class SyncTask
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x00188704 File Offset: 0x00188704
		public static SyncTask<T> FromResult<T>(T result)
		{
			SyncTask<T> syncTask = new SyncTask<T>(true);
			syncTask.Awaiter.ResultTask.SetResult(result);
			return syncTask;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00188730 File Offset: 0x00188730
		public static SyncTask<SyncTask<T>> WhenAny<T>(params SyncTask<T>[] tasks)
		{
			SyncTask<SyncTask<T>> aggregateTask = new SyncTask<SyncTask<T>>(false);
			SyncTask<T> syncTask = tasks.FirstOrDefault((SyncTask<T> x) => x.Awaiter.IsCompleted);
			bool flag = syncTask != null;
			SyncTask<SyncTask<T>> aggregateTask2;
			if (flag)
			{
				aggregateTask.GetAwaiter().ResultTask.SetResult(syncTask);
				aggregateTask2 = aggregateTask;
			}
			else
			{
				List<IDisposable> disposeList = new List<IDisposable>();
				foreach (SyncTask<T> syncTask2 in tasks)
				{
					disposeList.Add(syncTask2.Awaiter.RedirectExecutionQueue(aggregateTask.Awaiter));
				}
				for (int j = 0; j < tasks.Length; j++)
				{
					SyncTask<T> childTask = tasks[j];
					childTask.Awaiter.OnCompleted(delegate
					{
						bool flag2 = aggregateTask.GetAwaiter().ResultTask.TrySetResult(childTask);
						if (flag2)
						{
							foreach (IDisposable disposable in disposeList)
							{
								disposable.Dispose();
							}
						}
					});
				}
				aggregateTask2 = aggregateTask;
			}
			return aggregateTask2;
		}
	}
}
