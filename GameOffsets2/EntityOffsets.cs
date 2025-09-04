using GameOffsets2.Native;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000028 RID: 40
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct EntityOffsets
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000022F8 File Offset: 0x000004F8
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Head: ");
			defaultInterpolatedStringHandler.AppendFormatted<ObjectHeaderOffsets>(this.Head);
			defaultInterpolatedStringHandler.AppendLiteral(" ComponentList:");
			defaultInterpolatedStringHandler.AppendFormatted<StdVector>(this.ComponentList);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040000CB RID: 203
		[FieldOffset(2132284507)]
		public ObjectHeaderOffsets Head;

		// Token: 0x040000CC RID: 204
		[FieldOffset(2145268290)]
		public long EntityDetailsPtr;

		// Token: 0x040000CD RID: 205
		[FieldOffset(2144834910)]
		public StdVector ComponentList;

		// Token: 0x040000CE RID: 206
		[FieldOffset(2131083221)]
		public uint Id;

		// Token: 0x040000CF RID: 207
		[FieldOffset(2137302216)]
		public EntityFlags Flags;
	}
}
