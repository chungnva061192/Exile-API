using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200006A RID: 106
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ServerDataOffsets
	{
		// Token: 0x04000283 RID: 643
		public const int Skip = 0;

		// Token: 0x04000284 RID: 644
		public const int WaypointsUnlockStateOffset = 49085;

		// Token: 0x04000285 RID: 645
		[FieldOffset(2134296176)]
		public StdVector PerPlayerServerData;

		// Token: 0x04000286 RID: 646
		[FieldOffset(2146676719)]
		public int TimeInGame2;

		// Token: 0x04000287 RID: 647
		[FieldOffset(2144760542)]
		public NativeUtf16Text League;

		// Token: 0x04000288 RID: 648
		[FieldOffset(2140300567)]
		public int InstanceId;

		// Token: 0x04000289 RID: 649
		[FieldOffset(2139338308)]
		public byte NetworkState;

		// Token: 0x0400028A RID: 650
		[FieldOffset(2131419174)]
		public int TimeInGame;

		// Token: 0x0400028B RID: 651
		[FieldOffset(2136631469)]
		public int Latency;

		// Token: 0x0400028C RID: 652
		[FieldOffset(2139113284)]
		public StdVector NearestPlayers;

		// Token: 0x0400028D RID: 653
		[FieldOffset(2137432328)]
		public ushort TradeChatChannel;

		// Token: 0x0400028E RID: 654
		[FieldOffset(2134166896)]
		public ushort GlobalChatChannel;

		// Token: 0x0400028F RID: 655
		[FieldOffset(2136576045)]
		public byte MonsterLevel;

		// Token: 0x04000290 RID: 656
		[FieldOffset(2131213125)]
		public byte MonstersRemaining;

		// Token: 0x04000291 RID: 657
		[FieldOffset(2142509219)]
		public NativeUtf16Text PartyLeaderName;

		// Token: 0x04000292 RID: 658
		[FieldOffset(2139014170)]
		public byte PartyStatusType;

		// Token: 0x04000293 RID: 659
		[FieldOffset(2131431974)]
		public NativePtrArray CurrentParty;

		// Token: 0x04000294 RID: 660
		[FieldOffset(2139243332)]
		public byte PartyAllocationType;

		// Token: 0x04000295 RID: 661
		[FieldOffset(2132284635)]
		public bool PartyDownscaleDisabled;

		// Token: 0x04000296 RID: 662
		[FieldOffset(2142509219)]
		public StdVector MinimapIcons;

		// Token: 0x04000297 RID: 663
		[FieldOffset(2136710317)]
		public NativePtrArray EntityEffects;

		// Token: 0x04000298 RID: 664
		[FieldOffset(2131431974)]
		public ushort LastActionId;

		// Token: 0x04000299 RID: 665
		[FieldOffset(2140376471)]
		public StdVector PlacedCurrencyOrders;

		// Token: 0x0400029A RID: 666
		[FieldOffset(2145268418)]
		public int DialogDepth;

		// Token: 0x0400029B RID: 667
		[FieldOffset(2139014170)]
		public ServerDataArtifacts Artifacts;
	}
}
