using System;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x02000203 RID: 515
	public class SentinelData : RemoteMemoryObject
	{
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x001A18C0 File Offset: 0x001A18C0
		public SentinelState State
		{
			get
			{
				this;
				return this + 24L;
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x001A18D8 File Offset: 0x001A18D8
		public SentinelData()
		{
			this;
		}
	}
}
