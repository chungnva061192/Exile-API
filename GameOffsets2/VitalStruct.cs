using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x0200004C RID: 76
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct VitalStruct
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		public int Reserved
		{
			get
			{
				return (int)Math.Ceiling((double)this.ReservedFraction / 10000.0 * (double)this.Max) + this.ReservedFlat;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000208E File Offset: 0x0000028E
		public int Unreserved
		{
			get
			{
				return this.Max - this.Reserved;
			}
		}

		// Token: 0x040001CF RID: 463
		[FieldOffset(2146585839)]
		public float Regen;

		// Token: 0x040001D0 RID: 464
		[FieldOffset(2131080469)]
		public int Max;

		// Token: 0x040001D1 RID: 465
		[FieldOffset(2136711085)]
		public int Current;

		// Token: 0x040001D2 RID: 466
		[FieldOffset(2144834910)]
		public int ReservedFlat;

		// Token: 0x040001D3 RID: 467
		[FieldOffset(2142509539)]
		public int ReservedFraction;
	}
}
