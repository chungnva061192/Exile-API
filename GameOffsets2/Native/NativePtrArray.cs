using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2.Native
{
	// Token: 0x02000089 RID: 137
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct NativePtrArray : IEquatable<NativePtrArray>
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000020DD File Offset: 0x000002DD
		public long Size
		{
			get
			{
				return this.Last - this.First;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020EC File Offset: 0x000002EC
		public int Capacity
		{
			get
			{
				return (int)(this.End - this.First);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026C0 File Offset: 0x000008C0
		public long ElementCount(int elementSize)
		{
			return (this.Last - this.First) / (long)elementSize;
		}

        // Token: 0x0600001C RID: 28 RVA: 0x000026E4 File Offset: 0x000008E4
        public long ElementCount<T>() where T : unmanaged
        {
            return ElementCount(Unsafe.SizeOf<T>());
        }

        // Token: 0x0600001D RID: 29 RVA: 0x00002704 File Offset: 0x00000904
        public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 4);
			defaultInterpolatedStringHandler.AppendLiteral("First: 0x");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.First);
			defaultInterpolatedStringHandler.AppendLiteral(", Last: 0x");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.Last);
			defaultInterpolatedStringHandler.AppendLiteral(", End: 0x");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.End);
			defaultInterpolatedStringHandler.AppendLiteral(" Size:");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.Size);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002794 File Offset: 0x00000994
		public bool Equals(NativePtrArray other)
		{
			return this.First == other.First && this.Last == other.Last && this.End == other.End;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000027D4 File Offset: 0x000009D4
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is NativePtrArray)
			{
				NativePtrArray other = (NativePtrArray)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002800 File Offset: 0x00000A00
		public override int GetHashCode()
		{
			return (this.First.GetHashCode() * 397 ^ this.Last.GetHashCode()) * 397 ^ this.End.GetHashCode();
		}

		// Token: 0x04000340 RID: 832
		public readonly long First;

		// Token: 0x04000341 RID: 833
		public readonly long Last;

		// Token: 0x04000342 RID: 834
		public readonly long End;
	}
}
