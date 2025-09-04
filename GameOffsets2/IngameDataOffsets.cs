using GameOffsets2.Native;
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000043 RID: 67
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct IngameDataOffsets
	{
		// Token: 0x04000144 RID: 324
		[FieldOffset(2136709933)]
		public long LabDataPtr;

		// Token: 0x04000145 RID: 325
		[FieldOffset(2138477052)]
		public long CurrentArea;

		// Token: 0x04000146 RID: 326
		[FieldOffset(2138657321)]
		public byte CurrentAreaLevel;

		// Token: 0x04000147 RID: 327
		[FieldOffset(2144836254)]
		public uint CurrentAreaHash;

		// Token: 0x04000148 RID: 328
		[FieldOffset(2141770753)]
		public NativePtrArray MapStats;

		// Token: 0x04000149 RID: 329
		[FieldOffset(2138655337)]
		public NativePtrArray MapStatsVisible;

		// Token: 0x0400014A RID: 330
		[FieldOffset(2142515875)]
		public long IngameStatePtr;

		// Token: 0x0400014B RID: 331
		[FieldOffset(2141778561)]
		public long IngameStatePtr2;

		// Token: 0x0400014C RID: 332
		[FieldOffset(2138984602)]
		public StdVector EffectEnvironments;

		// Token: 0x0400014D RID: 333
		[FieldOffset(2141739905)]
		public long ServerData;

		// Token: 0x0400014E RID: 334
		[FieldOffset(2141739777)]
		public StdVector LocalPlayers;

		// Token: 0x0400014F RID: 335
		[FieldOffset(2146623983)]
		public long EntityList;

		// Token: 0x04000150 RID: 336
		[FieldOffset(2144805982)]
		public long EntitiesCount;

		// Token: 0x04000151 RID: 337
		[FieldOffset(2139262788)]
		public TerrainData Terrain;

		// Token: 0x04000152 RID: 338
		[FieldOffset(2138458620)]
		public NativePtrArray TgtArray;

		// Token: 0x04000153 RID: 339
		[FieldOffset(2142560099)]
		public int MillisecondsSpentInMapBeforeZoneIn;

		// Token: 0x04000154 RID: 340
		[FieldOffset(2137285768)]
		public long ZoneInQPC;

		// Token: 0x04000155 RID: 341
		[FieldOffset(2144781022)]
		public long EnvironmentDataPtr;

		// Token: 0x04000156 RID: 342
		[FieldOffset(2131387302)]
		public StdVector AzmeriDataArray1;

		// Token: 0x04000157 RID: 343
		[FieldOffset(2140339863)]
		public StdVector AzmeriDataArray2;

		// Token: 0x04000158 RID: 344
		[FieldOffset(2144788702)]
		public Vector2i AzmeriZoneTileDimensions;

		// Token: 0x04000159 RID: 345
		[FieldOffset(2138582505)]
		public Vector2 AzmeriZoneMinBorder;

		// Token: 0x0400015A RID: 346
		[FieldOffset(2146647023)]
		public Vector2 AzmeriZoneMaxBorder;

		// Token: 0x0400015B RID: 347
		[FieldOffset(2134357360)]
		public byte IsInsideAzmeriZone;
	}
}
