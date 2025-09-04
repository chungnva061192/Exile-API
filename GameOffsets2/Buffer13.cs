using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameOffsets2
{
	// Token: 0x02000013 RID: 19
	[InlineArray(13)]
	public struct Buffer13<T>
	{
        // Token: 0x06000002 RID: 2 RVA: 0x000021E8 File Offset: 0x000003E8
        public unsafe List<T> AsList()
        {
            List<T> list = new List<T>(13);
            for (int i = 0; i < 13; i++)
            {
                list.Add(this[i]); // compiler generate indexer cho InlineArray
            }
            return list;
        }

        // Token: 0x04000053 RID: 83
        private T _element;
	}
}
