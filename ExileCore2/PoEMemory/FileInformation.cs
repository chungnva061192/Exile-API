using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.PoEMemory
{
	// Token: 0x0200019A RID: 410
	public struct FileInformation
	{
		// Token: 0x06000BA8 RID: 2984 RVA: 0x00195074 File Offset: 0x00195074
		public FileInformation(long ptr, int changeCount)
		{
			ref this;
			ptr;
			ref this;
			changeCount;
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00195088 File Offset: 0x00195088
		public readonly long Ptr
		{
			[CompilerGenerated]
			get
			{
				return ref this;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x00195090 File Offset: 0x00195090
		public readonly int ChangeCount
		{
			[CompilerGenerated]
			get
			{
				return ref this;
			}
		}
	}
}
