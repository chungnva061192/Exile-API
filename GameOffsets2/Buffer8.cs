using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameOffsets2
{
	// Token: 0x02000015 RID: 21
	[InlineArray(8)]
	public struct Buffer8<T>
	{
        // Token: 0x06000004 RID: 4 RVA: 0x00002270 File Offset: 0x00000470
        public unsafe List<T> AsList()
        {
            List<T> list = new List<T>(8);
            for (int i = 0; i < 8; i++)
            {
                list.Add(this[i]); // compiler generate indexer cho InlineArray
            }
            return list;
        }

        // Token: 0x04000055 RID: 85
        private T _element;
	}
}
