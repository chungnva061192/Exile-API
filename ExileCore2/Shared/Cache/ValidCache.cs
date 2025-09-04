using System;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2.Shared.Cache
{
	// Token: 0x02000170 RID: 368
	public class ValidCache<T> : CachedValue<T>
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x0018E044 File Offset: 0x0018E044
		public ValidCache(Entity entity, Func<T> func) : base(func)
		{
			this._entity = entity;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0018E058 File Offset: 0x0018E058
		protected override bool Update(bool force)
		{
			return this._entity.IsValid || force;
		}

		// Token: 0x04007D91 RID: 32145
		private readonly Entity _entity;
	}
}
