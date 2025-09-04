using System;
using ExileCore2.PoEMemory.MemoryObjects.Archive;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200035F RID: 863
	public class Prophecy : Component
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x001B5F9C File Offset: 0x001B5F9C
		public ProphecyDat DatProphecy
		{
			get
			{
				this;
				return this + 24L;
			}
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x001B5FC8 File Offset: 0x001B5FC8
		public Prophecy()
		{
			this;
		}
	}
}
