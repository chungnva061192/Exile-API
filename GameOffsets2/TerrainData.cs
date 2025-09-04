using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200007E RID: 126
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct TerrainData
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020CD File Offset: 0x000002CD
		private int Cols
		{
			get
			{
				return (int)this.NumCols;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000020D5 File Offset: 0x000002D5
		private int Rows
		{
			get
			{
				return (int)this.NumRows;
			}
		}

		// Token: 0x04000319 RID: 793
		[FieldOffset(2136710445)]
		public ushort NumCols;

		// Token: 0x0400031A RID: 794
		[FieldOffset(2138479484)]
		public ushort NumRows;

		// Token: 0x0400031B RID: 795
		[FieldOffset(2131080533)]
		public NativePtrArray TgtArray;

		// Token: 0x0400031C RID: 796
		[FieldOffset(2146583407)]
		public NativePtrArray LayerMelee;

		// Token: 0x0400031D RID: 797
		[FieldOffset(2145270850)]
		public NativePtrArray LayerRanged;

		// Token: 0x0400031E RID: 798
		[FieldOffset(2146590319)]
		public int BytesPerRow;

		// Token: 0x0400031F RID: 799
		[FieldOffset(2140380631)]
		public short TileHeightMultiplier;
	}
}
