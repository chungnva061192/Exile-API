using System;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001B9 RID: 441
	public class CraftBenchWindow : Element
	{
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00197F84 File Offset: 0x00197F84
		public Element PrefixesElement
		{
			get
			{
				this;
				int[] array = new int[5];
				array[0] = 3;
				array[3] = 1;
				return array;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00197F9C File Offset: 0x00197F9C
		public Element SuffixesElement
		{
			get
			{
				this;
				return new int[5];
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00197FB8 File Offset: 0x00197FB8
		public Element FilterElement
		{
			get
			{
				this;
				int[] array = new int[4];
				array[0] = 2;
				array[1] = 1;
				return array;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00197FD0 File Offset: 0x00197FD0
		public Element CraftsListElement
		{
			get
			{
				this;
				return new int[]
				{
					3
				};
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00197FE4 File Offset: 0x00197FE4
		public Element ItemSlotElement
		{
			get
			{
				this;
				return new int[]
				{
					5,
					1
				};
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00197FFC File Offset: 0x00197FFC
		public Element CraftButton
		{
			get
			{
				this;
				int[] array = new int[3];
				array[0] = 5;
				return array;
			}
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00198010 File Offset: 0x00198010
		public CraftBenchWindow()
		{
			this;
		}
	}
}
