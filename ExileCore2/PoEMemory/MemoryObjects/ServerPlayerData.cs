using System;
using ExileCore2.Shared.Enums;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x02000205 RID: 517
	public class ServerPlayerData : StructuredRemoteMemoryObject<ServerPlayerDataOffsets>
	{
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x001A18E4 File Offset: 0x001A18E4
		public CharacterClass Class
		{
			get
			{
				return this & 15;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x001A18F4 File Offset: 0x001A18F4
		public int Level
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x001A1904 File Offset: 0x001A1904
		public int QuestPassiveSkillPoints
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x001A1914 File Offset: 0x001A1914
		public int TotalAscendancyPoints
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x001A1924 File Offset: 0x001A1924
		public int SpentAscendancyPoints
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x001A1934 File Offset: 0x001A1934
		public StdVector AllocatedPassivesIds
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x001A1944 File Offset: 0x001A1944
		public ServerPlayerData()
		{
			this;
		}
	}
}
