using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001C7 RID: 455
	public class EnvironmentData : StructuredRemoteMemoryObject<EnvironmentDataOffsets>
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x0019AD40 File Offset: 0x0019AD40
		public EnvironmentData()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0019AD78 File Offset: 0x0019AD78
		public List<DefaultEnvironmentSetting> DefaultSettingMap
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0019AD88 File Offset: 0x0019AD88
		public List<EnvironmentDataEnvironment> Environments
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04007F50 RID: 32592
		private readonly CachedValue<List<DefaultEnvironmentSetting>> _defaultSettings;

		// Token: 0x04007F51 RID: 32593
		private readonly CachedValue<List<EnvironmentDataEnvironment>> _environments;

		// Token: 0x020001C8 RID: 456
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04007F52 RID: 32594
			public static Func<long, DefaultEnvironmentSetting> <0>__GetObjectStatic;
		}
	}
}
