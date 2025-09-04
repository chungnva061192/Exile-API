using System;
using System.Numerics;

namespace ExileCore2.Shared
{
	// Token: 0x020000E8 RID: 232
	internal static class SpanExtensions
	{
		// Token: 0x06000766 RID: 1894 RVA: 0x00188398 File Offset: 0x00188398
		public unsafe static T Average<T>(this Span<T> span) where T : INumber<T>
		{
			bool isEmpty = span.IsEmpty;
			T result;
			if (isEmpty)
			{
				result = INumberBase<T>.Zero;
			}
			else
			{
				T left = INumberBase<T>.Zero;
				Span<T> span2 = span;
				for (int i = 0; i < span2.Length; i++)
				{
					T right = *span2[i];
					left += right;
				}
				result = left / INumberBase<T>.CreateChecked<int>(span.Length);
			}
			return result;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00188428 File Offset: 0x00188428
		public unsafe static T Min<T>(this Span<T> span) where T : INumber<T>
		{
			bool isEmpty = span.IsEmpty;
			T result;
			if (isEmpty)
			{
				result = INumberBase<T>.Zero;
			}
			else
			{
				T t = *span[0];
				ref Span<T> ptr = ref span;
				Span<T> span2 = ptr.Slice(1, ptr.Length - 1);
				for (int i = 0; i < span2.Length; i++)
				{
					T x = *span2[i];
					t = INumber<T>.Min(x, t);
				}
				result = t;
			}
			return result;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x001884B0 File Offset: 0x001884B0
		public unsafe static T Max<T>(this Span<T> span) where T : INumber<T>
		{
			bool isEmpty = span.IsEmpty;
			T result;
			if (isEmpty)
			{
				result = INumberBase<T>.Zero;
			}
			else
			{
				T t = *span[0];
				ref Span<T> ptr = ref span;
				Span<T> span2 = ptr.Slice(1, ptr.Length - 1);
				for (int i = 0; i < span2.Length; i++)
				{
					T x = *span2[i];
					t = INumber<T>.Max(x, t);
				}
				result = t;
			}
			return result;
		}
	}
}
