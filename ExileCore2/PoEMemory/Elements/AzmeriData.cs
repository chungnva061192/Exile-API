using System;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002AC RID: 684
	public class AzmeriData : RemoteMemoryObject
	{
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x001ADC80 File Offset: 0x001ADC80
		public uint CurrentFuel
		{
			get
			{
				uint result = this + this;
				int[] array = new int[1];
				array[array] = 0;
				return result;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x001ADCA8 File Offset: 0x001ADCA8
		public uint MaxFuel
		{
			get
			{
				uint result = this + this;
				int[] array = new int[1];
				array[array] = 0;
				return result;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x001ADCD0 File Offset: 0x001ADCD0
		public float RemainingFuelFraction
		{
			get
			{
				return this / this;
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x001ADCE4 File Offset: 0x001ADCE4
		public AzmeriData()
		{
			this;
		}

		// Token: 0x04008218 RID: 33304
		public const int FuelDataPtrOffset = 344;

		// Token: 0x04008219 RID: 33305
		public const int CurrentFuelOffset = 216;

		// Token: 0x0400821A RID: 33306
		public const int MaxFuelOffset = 220;
	}
}
