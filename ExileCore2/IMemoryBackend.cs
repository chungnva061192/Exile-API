using System;

namespace ExileCore2
{
	// Token: 0x02000053 RID: 83
	public interface IMemoryBackend : IDisposable
	{
		// Token: 0x0600032D RID: 813
		bool TryReadMemory(IntPtr address, Span<byte> target);

		// Token: 0x0600032E RID: 814
		void NotifyFrame();
	}
}
