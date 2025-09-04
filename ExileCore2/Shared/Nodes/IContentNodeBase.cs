using System;
using System.Collections.Generic;

namespace ExileCore2.Shared.Nodes
{
	// Token: 0x0200010D RID: 269
	internal interface IContentNodeBase
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000842 RID: 2114
		IEnumerable<object> Content { get; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000843 RID: 2115
		bool EnableControls { get; }

		// Token: 0x06000844 RID: 2116
		bool Remove(object item);

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000845 RID: 2117
		Action SpawnItem { get; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000846 RID: 2118
		bool EnableItemCollapsing { get; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000847 RID: 2119
		bool UseFlatItems { get; }
	}
}
