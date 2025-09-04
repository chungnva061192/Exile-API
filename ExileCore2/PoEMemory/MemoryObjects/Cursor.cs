using System;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001BA RID: 442
	public class Cursor : Element
	{
		// Token: 0x06000CBE RID: 3262 RVA: 0x0019801C File Offset: 0x0019801C
		public Cursor()
		{
			this;
			this;
			this;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00198040 File Offset: 0x00198040
		public MouseActionType Action
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00198054 File Offset: 0x00198054
		public int Clicks
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00198068 File Offset: 0x00198068
		public string ActionString
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00198088 File Offset: 0x00198088
		public string ActionSound
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x04007EF8 RID: 32504
		private readonly CachedValue<CursorOffsets> _cachevalue;
	}
}
