using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200034B RID: 843
	public class MinimapIcon : Component
	{
		// Token: 0x060016C0 RID: 5824 RVA: 0x001B4BC4 File Offset: 0x001B4BC4
		public MinimapIcon()
		{
			this;
			this;
			this;
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x001B4BE8 File Offset: 0x001B4BE8
		private MinimapIconOffsets MinimapIconOffsets
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x001B4BF8 File Offset: 0x001B4BF8
		public bool IsVisible
		{
			get
			{
				return this == 0;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x001B4C08 File Offset: 0x001B4C08
		public bool IsHide
		{
			get
			{
				return this == 1;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x001B4C18 File Offset: 0x001B4C18
		public string TestString
		{
			get
			{
				this;
				this;
				this;
				return 1;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x001B4C44 File Offset: 0x001B4C44
		public string Name
		{
			get
			{
				0;
				2;
				this;
				this;
				return this;
			}
		}

		// Token: 0x040082E5 RID: 33509
		private FrameCache<MinimapIconOffsets> cachedValue;
	}
}
