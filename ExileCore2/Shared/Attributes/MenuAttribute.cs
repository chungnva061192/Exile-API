using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.Shared.Attributes
{
	// Token: 0x02000172 RID: 370
	[AttributeUsage(AttributeTargets.Property)]
	public class MenuAttribute : Attribute
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0018E084 File Offset: 0x0018E084
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0018E08C File Offset: 0x0018E08C
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

		// Token: 0x060009A8 RID: 2472 RVA: 0x0018E098 File Offset: 0x0018E098
		public MenuAttribute(string menuName)
		{
			this;
			-1;
			this;
			-1;
			this;
			this;
			menuName;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0018E0B8 File Offset: 0x0018E0B8
		public MenuAttribute(string menuName, string tooltip)
		{
			this;
			menuName;
			this;
			tooltip;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0018E0CC File Offset: 0x0018E0CC
		public MenuAttribute(string menuName, int index)
		{
			this;
			-1;
			this;
			-1;
			this;
			this;
			menuName;
			this;
			index;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0018E0F4 File Offset: 0x0018E0F4
		public MenuAttribute(string menuName, string tooltip, int index)
		{
			this;
			menuName;
			index;
			this;
			tooltip;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0018E108 File Offset: 0x0018E108
		public MenuAttribute(string menuName, int index, int parentIndex)
		{
			this;
			-1;
			this;
			-1;
			this;
			this;
			menuName;
			this;
			index;
			this;
			parentIndex;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0018E138 File Offset: 0x0018E138
		public MenuAttribute(string menuName, string tooltip, int index, int parentIndex)
		{
			this;
			menuName;
			index;
			this;
			tooltip;
		}

		// Token: 0x04007D92 RID: 32146
		public int index;

		// Token: 0x04007D93 RID: 32147
		public string MenuName;

		// Token: 0x04007D94 RID: 32148
		public int parentIndex;

		// Token: 0x04007D95 RID: 32149
		public string Tooltip;
	}
}
