using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001CD RID: 461
	public class EnvironmentSettingValue<[IsUnmanaged] T> : StructuredRemoteMemoryObject<T> where T : struct, ValueType
	{
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0019B458 File Offset: 0x0019B458
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0019B460 File Offset: 0x0019B460
		public DefaultEnvironmentSetting Default { get; internal set; }

		// Token: 0x06000D52 RID: 3410 RVA: 0x0019B46C File Offset: 0x0019B46C
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<T>(base.Structure);
			defaultInterpolatedStringHandler.AppendLiteral(" :");
			defaultInterpolatedStringHandler.AppendFormatted<DefaultEnvironmentSetting>(this.Default);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}
}
