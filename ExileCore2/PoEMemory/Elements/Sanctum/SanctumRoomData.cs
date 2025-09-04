using System;
using ExileCore2.PoEMemory.FilesInMemory.Sanctum;

namespace ExileCore2.PoEMemory.Elements.Sanctum
{
	// Token: 0x020002F8 RID: 760
	public class SanctumRoomData : RemoteMemoryObject
	{
		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x001B0FEC File Offset: 0x001B0FEC
		public SanctumRoom FightRoom
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x001B1014 File Offset: 0x001B1014
		public SanctumRoom RewardRoom
		{
			get
			{
				this;
				return this + 16L;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x001B1040 File Offset: 0x001B1040
		public SanctumPersistentEffect RoomEffect
		{
			get
			{
				this;
				return this + 32L;
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x001B106C File Offset: 0x001B106C
		public SanctumRoomData()
		{
			this;
		}
	}
}
