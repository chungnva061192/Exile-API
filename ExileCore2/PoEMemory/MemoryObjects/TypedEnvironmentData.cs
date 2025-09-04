using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001CC RID: 460
	public class TypedEnvironmentData<[IsUnmanaged] T> where T : struct, ValueType
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x0019B2E4 File Offset: 0x0019B2E4
		public TypedEnvironmentData(IMemory m, long environmentDataPtr, long environmentPtr, int startOffset, int defaultStartOffset, int count, Dictionary<long, DefaultEnvironmentSetting> defaultSettings)
		{
			this._m = m;
			this._environmentDataPtr = environmentDataPtr;
			this._environmentPtr = environmentPtr;
			this._startOffset = startOffset;
			this._defaultStartOffset = defaultStartOffset;
			this._count = count;
			this._defaultSettings = defaultSettings;
			this._entriesCache = new FrameCache<List<EnvironmentSettingValue<T>>>(delegate()
			{
				long[] source = this._m.ReadMem<long>(this._environmentDataPtr + (long)this._defaultStartOffset, this._count);
				List<DefaultEnvironmentSetting> second = (from x in source
				select (x == 0L) ? null : (this._defaultSettings.GetValueOrDefault(x) ?? RemoteMemoryObject.GetObjectStatic<DefaultEnvironmentSetting>(x))).ToList<DefaultEnvironmentSetting>();
				List<EnvironmentSettingValue<T>> list = this._m.ReadStructsArray<EnvironmentSettingValue<T>>(this._environmentPtr + (long)this._startOffset, this._environmentPtr + (long)this._startOffset + (long)(this._count * Unsafe.SizeOf<T>()), Unsafe.SizeOf<T>(), null);
				foreach (ValueTuple<EnvironmentSettingValue<T>, DefaultEnvironmentSetting> valueTuple in list.Zip(second))
				{
					EnvironmentSettingValue<T> item = valueTuple.Item1;
					DefaultEnvironmentSetting item2 = valueTuple.Item2;
					item.Default = item2;
				}
				return list;
			});
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0019B348 File Offset: 0x0019B348
		public List<EnvironmentSettingValue<T>> Entries
		{
			get
			{
				return this._entriesCache.Value;
			}
		}

		// Token: 0x04007F65 RID: 32613
		private readonly IMemory _m;

		// Token: 0x04007F66 RID: 32614
		private readonly long _environmentDataPtr;

		// Token: 0x04007F67 RID: 32615
		private readonly long _environmentPtr;

		// Token: 0x04007F68 RID: 32616
		private readonly int _startOffset;

		// Token: 0x04007F69 RID: 32617
		private readonly int _defaultStartOffset;

		// Token: 0x04007F6A RID: 32618
		private readonly int _count;

		// Token: 0x04007F6B RID: 32619
		private readonly Dictionary<long, DefaultEnvironmentSetting> _defaultSettings;

		// Token: 0x04007F6C RID: 32620
		private readonly CachedValue<List<EnvironmentSettingValue<T>>> _entriesCache;
	}
}
