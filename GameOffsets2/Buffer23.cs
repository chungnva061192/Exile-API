using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameOffsets2
{
	// Token: 0x02000012 RID: 18
	[InlineArray(23)]
	public struct Buffer23<T>
	{
        // Token: 0x06000001 RID: 1 RVA: 0x000021A4 File Offset: 0x000003A4
        public unsafe List<T> AsList()
        {
            List<T> list = new List<T>(23);
            for (int i = 0; i < 23; i++)
            {
                list.Add(this[i]); // compiler generate indexer cho InlineArray
            }
            return list;
        }

        // Token: 0x04000052 RID: 82
        private T _element;
	}
}
