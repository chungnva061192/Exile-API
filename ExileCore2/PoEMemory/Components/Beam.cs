using System;
using System.Numerics;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000326 RID: 806
	public class Beam : Component
	{
		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x001B30E8 File Offset: 0x001B30E8
		public Vector3 BeamStart
		{
			get
			{
				this;
				return this + 80L;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x001B3100 File Offset: 0x001B3100
		public Vector3 BeamEnd
		{
			get
			{
				this;
				return this + 92L;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x001B3118 File Offset: 0x001B3118
		public int Unknown1
		{
			get
			{
				this;
				return this + 64L;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x001B3130 File Offset: 0x001B3130
		public int Unknown2
		{
			get
			{
				this;
				return this + 68L;
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x001B3148 File Offset: 0x001B3148
		public Beam()
		{
			this;
		}

		// Token: 0x040082BA RID: 33466
		private const int BeamStartOffset = 80;

		// Token: 0x040082BB RID: 33467
		private const int BeamEndOffset = 92;
	}
}
