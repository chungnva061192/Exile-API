using GameOffsets2.Native;
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000024 RID: 36
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ElementOffsets
	{
		// Token: 0x040000AB RID: 171
		public const int OffsetBuffers = 0;

		// Token: 0x040000AC RID: 172
		private const int ElementColorsOffset = 400;

		// Token: 0x040000AD RID: 173
		[FieldOffset(2144835422)]
		public long SelfPointer;

		// Token: 0x040000AE RID: 174
		[FieldOffset(2138479356)]
		public long ChildStart;

		// Token: 0x040000AF RID: 175
		[FieldOffset(2144835550)]
		public NativePtrArray Childs;

		// Token: 0x040000B0 RID: 176
		[FieldOffset(2140375447)]
		public long ChildEnd;

		// Token: 0x040000B1 RID: 177
		[FieldOffset(2137302920)]
		public Vector2 ScrollOffset;

		// Token: 0x040000B2 RID: 178
		[FieldOffset(2140373143)]
		public Vector2 Position;

		// Token: 0x040000B3 RID: 179
		[FieldOffset(2138658409)]
		public float Scale;

		// Token: 0x040000B4 RID: 180
		[FieldOffset(2139247172)]
		public byte LabelTextSize;

		// Token: 0x040000B5 RID: 181
		[FieldOffset(2138477948)]
		public ushort Type;

		// Token: 0x040000B6 RID: 182
		[FieldOffset(2137301000)]
		public long Parent;

		// Token: 0x040000B7 RID: 183
		[FieldOffset(2142506595)]
		public ElementFlags Flags;

		// Token: 0x040000B8 RID: 184
		[FieldOffset(2142503075)]
		public long Tooltip;

		// Token: 0x040000B9 RID: 185
		[FieldOffset(2145259714)]
		public Vector2 Size;

		// Token: 0x040000BA RID: 186
		[FieldOffset(2131440678)]
		public byte isHighlighted;

		// Token: 0x040000BB RID: 187
		[FieldOffset(2146592879)]
		public uint LabelBorderColor;

		// Token: 0x040000BC RID: 188
		[FieldOffset(2131440742)]
		public uint LabelBackgroundColor;

		// Token: 0x040000BD RID: 189
		[FieldOffset(2138668649)]
		public uint LabelTextColor;

		// Token: 0x040000BE RID: 190
		[FieldOffset(2139024810)]
		public byte ShinyHighlightState;

		// Token: 0x040000BF RID: 191
		[FieldOffset(2140387095)]
		public NativeUtf16Text Text;

		// Token: 0x040000C0 RID: 192
		[FieldOffset(2134304752)]
		public long TextureNamePtr;

		// Token: 0x040000C1 RID: 193
		[FieldOffset(2131451046)]
		public NativeUtf16Text TextNoTags;
	}
}
