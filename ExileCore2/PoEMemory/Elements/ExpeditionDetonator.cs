using System;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002B9 RID: 697
	public class ExpeditionDetonator : Element
	{
		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x001AE078 File Offset: 0x001AE078
		public ExpeditionDetonatorInfo Info
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x001AE088 File Offset: 0x001AE088
		public int RemainingExplosives
		{
			get
			{
				this;
				return new int[3];
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x001AE0A0 File Offset: 0x001AE0A0
		public Element RevertExplosiveButton
		{
			get
			{
				this;
				return new int[]
				{
					0,
					0,
					1
				};
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x001AE0B4 File Offset: 0x001AE0B4
		public Element ToggleExplosivePlacementButton
		{
			get
			{
				this;
				return new int[]
				{
					0,
					1
				};
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x001AE0C8 File Offset: 0x001AE0C8
		public ExpeditionDetonator()
		{
			this;
		}
	}
}
