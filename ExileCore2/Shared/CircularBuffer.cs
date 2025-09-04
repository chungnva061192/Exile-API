using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExileCore2.Shared
{
	// Token: 0x020000B8 RID: 184
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000537 RID: 1335 RVA: 0x00180080 File Offset: 0x00180080
		public CircularBuffer(int capacity) : this(capacity, Array.Empty<T>())
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00180090 File Offset: 0x00180090
		public CircularBuffer(int capacity, T[] items)
		{
			bool flag = capacity < 1;
			if (flag)
			{
				throw new ArgumentException("Circular buffer cannot have negative or zero capacity.", "capacity");
			}
			bool flag2 = items == null;
			if (flag2)
			{
				throw new ArgumentNullException("items");
			}
			bool flag3 = items.Length > capacity;
			if (flag3)
			{
				throw new ArgumentException("Too many items to fit circular buffer", "items");
			}
			this._buffer = new T[capacity];
			Array.Copy(items, this._buffer, items.Length);
			this.Size = items.Length;
			this._start = 0;
			this._end = ((this.Size == capacity) ? 0 : this.Size);
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00180130 File Offset: 0x00180130
		public int Capacity
		{
			get
			{
				return this._buffer.Length;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0018013C File Offset: 0x0018013C
		public bool IsFull
		{
			get
			{
				return this.Size == this.Capacity;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0018014C File Offset: 0x0018014C
		public bool IsEmpty
		{
			get
			{
				return this.Size == 0;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00180158 File Offset: 0x00180158
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00180160 File Offset: 0x00180160
		public int Size { get; private set; }

		// Token: 0x17000122 RID: 290
		public T this[int index]
		{
			get
			{
				bool isEmpty = this.IsEmpty;
				if (isEmpty)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Cannot access index ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(index);
					defaultInterpolatedStringHandler.AppendLiteral(". Buffer is empty");
					throw new IndexOutOfRangeException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				bool flag = index >= this.Size;
				if (flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Cannot access index ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(index);
					defaultInterpolatedStringHandler.AppendLiteral(". Buffer size is ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.Size);
					throw new IndexOutOfRangeException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				int num = this.InternalIndex(index);
				return this._buffer[num];
			}
			set
			{
				bool isEmpty = this.IsEmpty;
				if (isEmpty)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Cannot access index ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(index);
					defaultInterpolatedStringHandler.AppendLiteral(". Buffer is empty");
					throw new IndexOutOfRangeException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				bool flag = index >= this.Size;
				if (flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Cannot access index ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(index);
					defaultInterpolatedStringHandler.AppendLiteral(". Buffer size is ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.Size);
					throw new IndexOutOfRangeException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				int num = this.InternalIndex(index);
				this._buffer[num] = value;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x001802F0 File Offset: 0x001802F0
		public IEnumerator<T> GetEnumerator()
		{
			ArraySegment<T>[] segments = new ArraySegment<T>[]
			{
				this.ArrayOne(),
				this.ArrayTwo()
			};
			foreach (ArraySegment<T> segment in segments)
			{
				int num;
				for (int i = 0; i < segment.Count; i = num + 1)
				{
					yield return segment.Array[segment.Offset + i];
					num = i;
				}
				segment = default(ArraySegment<T>);
			}
			ArraySegment<T>[] array = null;
			yield break;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00180300 File Offset: 0x00180300
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00180318 File Offset: 0x00180318
		public T Front()
		{
			this.ThrowIfEmpty("Cannot access an empty buffer.");
			return this._buffer[this._start];
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00180348 File Offset: 0x00180348
		public T Back()
		{
			this.ThrowIfEmpty("Cannot access an empty buffer.");
			return this._buffer[((this._end != 0) ? this._end : this.Capacity) - 1];
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0018038C File Offset: 0x0018038C
		public void Clear()
		{
			while (!this.IsEmpty)
			{
				this.PopBackCore();
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x001803B4 File Offset: 0x001803B4
		public void PushBack(T item)
		{
			bool isFull = this.IsFull;
			if (isFull)
			{
				this._buffer[this._end] = item;
				this.Increment(ref this._end);
				this._start = this._end;
			}
			else
			{
				this._buffer[this._end] = item;
				this.Increment(ref this._end);
				int size = this.Size + 1;
				this.Size = size;
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00180430 File Offset: 0x00180430
		public void PushFront(T item)
		{
			bool isFull = this.IsFull;
			if (isFull)
			{
				this.Decrement(ref this._start);
				this._end = this._start;
				this._buffer[this._start] = item;
			}
			else
			{
				this.Decrement(ref this._start);
				this._buffer[this._start] = item;
				int size = this.Size + 1;
				this.Size = size;
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x001804AC File Offset: 0x001804AC
		public void PopBack()
		{
			this.ThrowIfEmpty("Cannot take elements from an empty buffer.");
			this.PopBackCore();
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x001804C4 File Offset: 0x001804C4
		private void PopBackCore()
		{
			this.Decrement(ref this._end);
			this._buffer[this._end] = default(T);
			int size = this.Size - 1;
			this.Size = size;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0018050C File Offset: 0x0018050C
		public void PopFront()
		{
			this.ThrowIfEmpty("Cannot take elements from an empty buffer.");
			this._buffer[this._start] = default(T);
			this.Increment(ref this._start);
			int size = this.Size - 1;
			this.Size = size;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00180560 File Offset: 0x00180560
		public T[] ToArray()
		{
			T[] array = new T[this.Size];
			int num = 0;
			ArraySegment<T>[] array2 = new ArraySegment<T>[]
			{
				this.ArrayOne(),
				this.ArrayTwo()
			};
			foreach (ArraySegment<T> arraySegment in array2)
			{
				Array.Copy(arraySegment.Array, arraySegment.Offset, array, num, arraySegment.Count);
				num += arraySegment.Count;
			}
			return array;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x001805EC File Offset: 0x001805EC
		private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
		{
			bool isEmpty = this.IsEmpty;
			if (isEmpty)
			{
				throw new InvalidOperationException(message);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0018060C File Offset: 0x0018060C
		private void Increment(ref int index)
		{
			int num = index + 1;
			index = num;
			bool flag = num == this.Capacity;
			if (flag)
			{
				index = 0;
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00180634 File Offset: 0x00180634
		private void Decrement(ref int index)
		{
			bool flag = index == 0;
			if (flag)
			{
				index = this.Capacity;
			}
			index--;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0018065C File Offset: 0x0018065C
		private int InternalIndex(int index)
		{
			return this._start + ((index < this.Capacity - this._start) ? index : (index - this.Capacity));
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00180690 File Offset: 0x00180690
		private ArraySegment<T> ArrayOne()
		{
			return (this._start < this._end) ? new ArraySegment<T>(this._buffer, this._start, this._end - this._start) : new ArraySegment<T>(this._buffer, this._start, this._buffer.Length - this._start);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x001806F0 File Offset: 0x001806F0
		private ArraySegment<T> ArrayTwo()
		{
			return (this._start < this._end) ? new ArraySegment<T>(this._buffer, this._end, 0) : new ArraySegment<T>(this._buffer, 0, this._end);
		}

		// Token: 0x0400031E RID: 798
		private readonly T[] _buffer;

		// Token: 0x0400031F RID: 799
		private int _end;

		// Token: 0x04000320 RID: 800
		private int _start;
	}
}
