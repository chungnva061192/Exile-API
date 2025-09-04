using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000003 RID: 3
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActorComponentOffsets
	{
		// Token: 0x04000004 RID: 4
		[FieldOffset(2140385175)]
		public long AnimationControllerPtr;

		// Token: 0x04000005 RID: 5
		[FieldOffset(2138668009)]
		public long ActionPtr;

		// Token: 0x04000006 RID: 6
		[FieldOffset(2131074645)]
		public short ActionId;

		// Token: 0x04000007 RID: 7
		[FieldOffset(2134308336)]
		public int AnimationId;

		// Token: 0x04000008 RID: 8
		[FieldOffset(2134272624)]
		public NativePtrArray ActorSkillsArray;

		// Token: 0x04000009 RID: 9
		[FieldOffset(2142548515)]
		public NativePtrArray ActorSkillsCooldownArray;

		// Token: 0x0400000A RID: 10
		[FieldOffset(2138448124)]
		public StdVector DeployedObjectArray;
	}
}
