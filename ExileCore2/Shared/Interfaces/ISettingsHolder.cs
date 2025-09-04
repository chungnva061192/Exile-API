using System;
using System.Collections.Generic;

namespace ExileCore2.Shared.Interfaces
{
	// Token: 0x0200011E RID: 286
	public interface ISettingsHolder
	{
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060008DD RID: 2269
		// (set) Token: 0x060008DE RID: 2270
		string Name { get; set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060008DF RID: 2271
		// (set) Token: 0x060008E0 RID: 2272
		string Tooltip { get; set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060008E1 RID: 2273
		string Unique { get; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060008E2 RID: 2274
		// (set) Token: 0x060008E3 RID: 2275
		int ID { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060008E4 RID: 2276
		// (set) Token: 0x060008E5 RID: 2277
		Action DrawDelegate { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060008E6 RID: 2278
		IList<ISettingsHolder> Children { get; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060008E7 RID: 2279
		bool ChildrenAreSearchable { get; }

		// Token: 0x060008E8 RID: 2280
		void Draw();
	}
}
