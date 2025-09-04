using System;

namespace ExileCore2
{
	// Token: 0x0200003F RID: 63
	internal class DisposableAction : IDisposable
	{
		// Token: 0x06000221 RID: 545 RVA: 0x001709C0 File Offset: 0x001709C0
		public DisposableAction(Action action)
		{
			this;
			this;
			action;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x001709D4 File Offset: 0x001709D4
		public void Dispose()
		{
			this;
		}

		// Token: 0x04000129 RID: 297
		private readonly Action _action;
	}
}
