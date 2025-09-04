using System;
using ImGuiNET;

namespace ExileCore2.RenderQ
{
	// Token: 0x0200017F RID: 383
	public readonly struct FontContainer
	{
		// Token: 0x06000A00 RID: 2560 RVA: 0x0018EA44 File Offset: 0x0018EA44
		public unsafe FontContainer(ImFont* atlas, string name, int size)
		{
			ref this;
			atlas;
			ref this;
			name;
			ref this;
			size;
		}

		// Token: 0x04007DBD RID: 32189
		public unsafe readonly ImFont* Atlas;

		// Token: 0x04007DBE RID: 32190
		public readonly string Name;

		// Token: 0x04007DBF RID: 32191
		public readonly int Size;
	}
}
