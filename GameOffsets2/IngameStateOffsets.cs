using GameOffsets2.Native;
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000044 RID: 68
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct IngameStateOffsets
	{
		// Token: 0x0400015C RID: 348
		[FieldOffset(2141777153)]
		public long Data;

		// Token: 0x0400015D RID: 349
		[FieldOffset(2144844766)]
		public long WorldData;

		// Token: 0x0400015E RID: 350
		[FieldOffset(2145255618)]
		public long EntityLabelMap;

		// Token: 0x0400015F RID: 351
		[FieldOffset(2144860382)]
		public long UIRoot;

		// Token: 0x04000160 RID: 352
		[FieldOffset(2139238084)]
		public long UIHoverElement;

		// Token: 0x04000161 RID: 353
		[FieldOffset(2131452454)]
		public Vector2 CurentUIElementPos;

		// Token: 0x04000162 RID: 354
		[FieldOffset(2131086933)]
		public long UIHover;

		// Token: 0x04000163 RID: 355
		[FieldOffset(2141763073)]
		public Vector2i MouseGlobal;

		// Token: 0x04000164 RID: 356
		[FieldOffset(2138499644)]
		public Vector2 UIHoverPos;

		// Token: 0x04000165 RID: 357
		[FieldOffset(2139011034)]
		public Vector2 MouseInGame;

		// Token: 0x04000166 RID: 358
		[FieldOffset(2140360215)]
		public float TimeInGameF;

		// Token: 0x04000167 RID: 359
		[FieldOffset(2136690989)]
		public long IngameUi;

		// Token: 0x04000168 RID: 360
		[FieldOffset(2132330139)]
		public int ZoneSwitchCounter;
	}
}
