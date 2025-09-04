using System;
using System.Diagnostics;
using System.Drawing;
using Newtonsoft.Json;

namespace ExileCore2.Shared.Nodes
{
	// Token: 0x02000111 RID: 273
	public sealed class RangeNode<T> where T : struct
	{
		// Token: 0x06000855 RID: 2133 RVA: 0x0018B444 File Offset: 0x0018B444
		public RangeNode()
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0018B450 File Offset: 0x0018B450
		public RangeNode(T value, T min, T max)
		{
			this.Value = value;
			this.Min = min;
			this.Max = max;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0018B474 File Offset: 0x0018B474
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x0018B47C File Offset: 0x0018B47C
		public T Value
		{
			get
			{
				return this._value;
			}
			set
			{
				bool flag = value.Equals(this._value);
				if (!flag)
				{
					this._value = value;
					try
					{
						EventHandler<T> onValueChanged = this.OnValueChanged;
						if (onValueChanged != null)
						{
							onValueChanged(this, value);
						}
					}
					catch (Exception)
					{
						DebugWindow.LogMsg("Error in function that subscribed for: RangeNode.OnValueChanged", 10f, Color.Red);
					}
				}
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0018B4F4 File Offset: 0x0018B4F4
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x0018B4FC File Offset: 0x0018B4FC
		[JsonIgnore]
		public T Min { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0018B508 File Offset: 0x0018B508
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x0018B510 File Offset: 0x0018B510
		[JsonIgnore]
		public T Max { get; set; }

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600085D RID: 2141 RVA: 0x0018B51C File Offset: 0x0018B51C
		// (remove) Token: 0x0600085E RID: 2142 RVA: 0x0018B554 File Offset: 0x0018B554
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler<T> OnValueChanged;

		// Token: 0x0600085F RID: 2143 RVA: 0x0018B58C File Offset: 0x0018B58C
		public static implicit operator T(RangeNode<T> node)
		{
			return node.Value;
		}

		// Token: 0x04000456 RID: 1110
		private T _value;
	}
}
