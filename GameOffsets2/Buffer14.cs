using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameOffsets2
{
	// Token: 0x02000014 RID: 20
	[InlineArray(14)]
	public struct Buffer14<T>
	{
        // Token: 0x06000003 RID: 3 RVA: 0x0000222C File Offset: 0x0000042C
        public unsafe List<T> AsList()
        {
            List<T> list = new List<T>(14);
            for (int i = 0; i < 14; i++)
            {
                list.Add(this[i]); // compiler generate indexer cho InlineArray
            }
            return list;
        }

        // Token: 0x04000054 RID: 84
        private T _element;
	}
}
