using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ExileCore2.Shared.AtlasHelper
{
	// Token: 0x02000176 RID: 374
	public class AtlasConfigData
	{
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0018E1F4 File Offset: 0x0018E1F4
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x0018E1FC File Offset: 0x0018E1FC
		[JsonProperty("frames")]
		public Dictionary<string, FrameValue> Frames
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0018E208 File Offset: 0x0018E208
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x0018E210 File Offset: 0x0018E210
		[JsonProperty("meta")]
		public Meta Meta
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0018E21C File Offset: 0x0018E21C
		public AtlasConfigData()
		{
			this;
		}
	}
}
