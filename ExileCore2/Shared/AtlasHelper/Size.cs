using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ExileCore2.Shared.AtlasHelper
{
	// Token: 0x0200017A RID: 378
	public class Size
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0018E33C File Offset: 0x0018E33C
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x0018E344 File Offset: 0x0018E344
		[JsonProperty("w")]
		public int W
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0018E350 File Offset: 0x0018E350
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0018E358 File Offset: 0x0018E358
		[JsonProperty("h")]
		public int H
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

		// Token: 0x060009DF RID: 2527 RVA: 0x0018E364 File Offset: 0x0018E364
		public Size()
		{
			this;
		}
	}
}
