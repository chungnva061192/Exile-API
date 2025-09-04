using System;

namespace ExileCore2.Shared.Attributes
{
	// Token: 0x02000171 RID: 369
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class HideInReflectionAttribute : Attribute
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x0018E078 File Offset: 0x0018E078
		public HideInReflectionAttribute()
		{
			this;
		}
	}
}
