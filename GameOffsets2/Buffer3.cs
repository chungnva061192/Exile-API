using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameOffsets2
{
	// Token: 0x02000016 RID: 22
	[InlineArray(3)]
	public struct Buffer3<T>
	{
        // Token: 0x06000005 RID: 5 RVA: 0x000022B4 File Offset: 0x000004B4
        public unsafe List<T> AsList()
        {
            List<T> list = new List<T>(3);
            for (int i = 0; i < 3; i++)
            {
                list.Add(this[i]); // compiler generate indexer cho InlineArray
            }
            return list;
        }

        // Token: 0x04000056 RID: 86
        private T _element;
	}
}
