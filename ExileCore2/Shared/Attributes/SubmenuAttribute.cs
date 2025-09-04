using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.Shared.Attributes
{
	// Token: 0x02000174 RID: 372
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public class SubmenuAttribute : Attribute
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0018E15C File Offset: 0x0018E15C
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0018E164 File Offset: 0x0018E164
		public bool CollapsedByDefault
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

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0018E170 File Offset: 0x0018E170
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0018E178 File Offset: 0x0018E178
		public bool EnableSelfDrawCollapsing
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0018E184 File Offset: 0x0018E184
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x0018E18C File Offset: 0x0018E18C
		public bool EnableCollapsing
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0018E198 File Offset: 0x0018E198
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x0018E1A0 File Offset: 0x0018E1A0
		public string RenderMethod
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

		// Token: 0x060009B7 RID: 2487 RVA: 0x0018E1AC File Offset: 0x0018E1AC
		public SubmenuAttribute()
		{
			this;
			0;
			this;
			0;
			this;
			1;
			this;
		}
	}
}
