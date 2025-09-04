using GameOffsets2.Native;
using System;
using System.Runtime.InteropServices;

namespace GameOffsets2
{
	// Token: 0x02000029 RID: 41
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct EnvironmentDataOffsets
	{
		// Token: 0x040000D0 RID: 208
		public const int Type1Count = 103;

		// Token: 0x040000D1 RID: 209
		public const int Type1Size = 8;

		// Token: 0x040000D2 RID: 210
		public const int Type1Offset = 0;

		// Token: 0x040000D3 RID: 211
		public const int Type2Count = 1;

		// Token: 0x040000D4 RID: 212
		public const int Type2Size = 8;

		// Token: 0x040000D5 RID: 213
		public const int Type2Offset = 824;

		// Token: 0x040000D6 RID: 214
		public const int Type3Count = 8;

		// Token: 0x040000D7 RID: 215
		public const int Type3Size = 16;

		// Token: 0x040000D8 RID: 216
		public const int Type3Offset = 832;

		// Token: 0x040000D9 RID: 217
		public const int Type4Count = 11;

		// Token: 0x040000DA RID: 218
		public const int Type4Size = 2;

		// Token: 0x040000DB RID: 219
		public const int Type4Offset = 960;

		// Token: 0x040000DC RID: 220
		public const int Type5Count = 2;

		// Token: 0x040000DD RID: 221
		public const int Type5Size = 8;

		// Token: 0x040000DE RID: 222
		public const int Type5Offset = 984;

		// Token: 0x040000DF RID: 223
		public const int Type6Count = 13;

		// Token: 0x040000E0 RID: 224
		public const int Type6Size = 80;

		// Token: 0x040000E1 RID: 225
		public const int Type6Offset = 1000;

		// Token: 0x040000E2 RID: 226
		public const int Type7Count = 1;

		// Token: 0x040000E3 RID: 227
		public const int Type7Size = 32;

		// Token: 0x040000E4 RID: 228
		public const int Type7Offset = 2040;

		// Token: 0x040000E5 RID: 229
		public const int Type8Count = 1;

		// Token: 0x040000E6 RID: 230
		public const int Type8Size = 32;

		// Token: 0x040000E7 RID: 231
		public const int Type8Offset = 2072;

		// Token: 0x040000E8 RID: 232
		public const int Type9Count = 1;

		// Token: 0x040000E9 RID: 233
		public const int Type9Size = 32;

		// Token: 0x040000EA RID: 234
		public const int Type9Offset = 2104;

		// Token: 0x040000EB RID: 235
		public const int Type10Count = 1;

		// Token: 0x040000EC RID: 236
		public const int Type10Size = 32;

		// Token: 0x040000ED RID: 237
		public const int Type10Offset = 2136;

		// Token: 0x040000EE RID: 238
		[FieldOffset(2145286722)]
		public StdVector DefaultSettingsList;

		// Token: 0x040000EF RID: 239
		[FieldOffset(2141755009)]
		public StdVector ActiveEnvironmentList;

		// Token: 0x040000F0 RID: 240
		[FieldOffset(2137389064)]
		public StdVector FootstepAudioList;

		// Token: 0x040000F1 RID: 241
		public const int FirstInlineValueListOffset = 1392;

		// Token: 0x040000F2 RID: 242
		public const int SecondInlineValueListOffset = 3560;
	}
}
