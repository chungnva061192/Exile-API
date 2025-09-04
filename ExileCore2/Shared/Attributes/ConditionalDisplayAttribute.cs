using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ExileCore2.Shared.Attributes
{
	// Token: 0x02000175 RID: 373
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public class ConditionalDisplayAttribute : Attribute
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0018E1CC File Offset: 0x0018E1CC
		public string ConditionMethodName
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0018E1D4 File Offset: 0x0018E1D4
		public bool ComparisonValue
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0018E1DC File Offset: 0x0018E1DC
		public ConditionalDisplayAttribute([NotNull] string conditionMethodName, bool comparisonValue = true)
		{
			this;
			this;
			conditionMethodName;
			this;
			comparisonValue;
		}
	}
}
