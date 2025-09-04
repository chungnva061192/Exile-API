using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ExileCore2.Shared.AtlasHelper
{
	// Token: 0x02000177 RID: 375
	public class FrameValue
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0018E228 File Offset: 0x0018E228
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0018E230 File Offset: 0x0018E230
		[JsonProperty("frame")]
		public SpriteSourceSizeClass Frame
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

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0018E23C File Offset: 0x0018E23C
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0018E244 File Offset: 0x0018E244
		[JsonProperty("rotated")]
		public bool Rotated
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0018E250 File Offset: 0x0018E250
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0018E258 File Offset: 0x0018E258
		[JsonProperty("trimmed")]
		public bool Trimmed
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0018E264 File Offset: 0x0018E264
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x0018E26C File Offset: 0x0018E26C
		[JsonProperty("spriteSourceSize")]
		public SpriteSourceSizeClass SpriteSourceSize
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

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0018E278 File Offset: 0x0018E278
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0018E280 File Offset: 0x0018E280
		[JsonProperty("sourceSize")]
		public Size SourceSize
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0018E28C File Offset: 0x0018E28C
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0018E294 File Offset: 0x0018E294
		[JsonProperty("pivot")]
		public Pivot Pivot
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

		// Token: 0x060009CC RID: 2508 RVA: 0x0018E2A0 File Offset: 0x0018E2A0
		public FrameValue()
		{
			this;
		}
	}
}
