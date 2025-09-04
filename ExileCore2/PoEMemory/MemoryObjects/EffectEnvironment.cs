using System;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001BC RID: 444
	public class EffectEnvironment : StructuredRemoteMemoryObject<EnvironmentOffsets>
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x001981DC File Offset: 0x001981DC
		public ushort Key
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x001981EC File Offset: 0x001981EC
		public ushort Value0
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x001981FC File Offset: 0x001981FC
		public float Value1
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0019820C File Offset: 0x0019820C
		public EffectEnvironment()
		{
			this;
		}
	}
}
