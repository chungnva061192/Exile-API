using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Cache;

namespace ExileCore2.PoEMemory
{
	// Token: 0x020001A7 RID: 423
	public abstract class StructuredRemoteMemoryObject<[IsUnmanaged] T> : RemoteMemoryObject where T : struct, ValueType
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x0019606C File Offset: 0x0019606C
		public StructuredRemoteMemoryObject()
		{
			this._cachedStructValue = base.CreateStructFrameCache<T>();
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00196084 File Offset: 0x00196084
		public T Structure
		{
			get
			{
				return this._cachedStructValue.Value;
			}
		}

		// Token: 0x04007ED2 RID: 32466
		private readonly CachedValue<T> _cachedStructValue;

		// Token: 0x04007ED3 RID: 32467
		public static readonly int StructureSize = Unsafe.SizeOf<T>();
	}
}
