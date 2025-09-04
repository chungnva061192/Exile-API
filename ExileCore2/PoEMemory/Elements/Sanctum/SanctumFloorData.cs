using System;
using System.Collections.Generic;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Elements.Sanctum
{
	// Token: 0x020002F2 RID: 754
	public class SanctumFloorData : RemoteMemoryObject
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x001B0BC4 File Offset: 0x001B0BC4
		public NativePtrArray RoomDataArray
		{
			get
			{
				this;
				return this + 24L;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x001B0BDC File Offset: 0x001B0BDC
		public List<SanctumRoomData> RoomData
		{
			get
			{
				this;
				this + 8L;
				this + 8L;
				64;
				return null;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x001B0C08 File Offset: 0x001B0C08
		public byte[][][] RoomLayout
		{
			get
			{
				this;
				this;
				this;
				32;
				return this;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x001B0C40 File Offset: 0x001B0C40
		public List<byte> RoomChoices
		{
			get
			{
				this;
				List<byte> result = this + 56L;
				int num = 8;
				while ((num = num) != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x001B0C8C File Offset: 0x001B0C8C
		public short CurrentResolve
		{
			get
			{
				this;
				return this + 80L;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x001B0CA4 File Offset: 0x001B0CA4
		public short MaxResolve
		{
			get
			{
				this;
				return this + 82L;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x001B0CBC File Offset: 0x001B0CBC
		public short Inspiration
		{
			get
			{
				this;
				return this + 84L;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x001B0CD4 File Offset: 0x001B0CD4
		public int Gold
		{
			get
			{
				this;
				return this + 72L;
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x001B0CEC File Offset: 0x001B0CEC
		public SanctumFloorData()
		{
			this;
		}
	}
}
