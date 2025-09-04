using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using ExileCore2.PoEMemory.Components;
using ExileCore2.PoEMemory.MemoryObjects.Bestiary;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x02000206 RID: 518
	public class ServerData : RemoteMemoryObject
	{
		// Token: 0x06000F7B RID: 3963 RVA: 0x001A1950 File Offset: 0x001A1950
		public ServerData()
		{
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x001A1A20 File Offset: 0x001A1A20
		public List<long> PerPlayerServerDataList
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x001A1A40 File Offset: 0x001A1A40
		public ServerPlayerData PlayerInformation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x001A1A50 File Offset: 0x001A1A50
		public ServerDataOffsets ServerDataStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x001A1A60 File Offset: 0x001A1A60
		public ushort TradeChatChannel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x001A1A70 File Offset: 0x001A1A70
		public ushort GlobalChatChannel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x001A1A80 File Offset: 0x001A1A80
		public byte MonsterLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x001A1A90 File Offset: 0x001A1A90
		public int DialogDepth
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x001A1AA0 File Offset: 0x001A1AA0
		public byte MonstersRemaining
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x001A1AB0 File Offset: 0x001A1AB0
		public Vector2 WorldMousePosition
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x001A1AC4 File Offset: 0x001A1AC4
		public IList<Player> NearestPlayers
		{
			get
			{
				this;
				this;
				24;
				return this;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x001A1AF4 File Offset: 0x001A1AF4
		public List<EntityEffect> EntityEffects
		{
			get
			{
				this;
				this;
				this;
				return null;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x001A1B28 File Offset: 0x001A1B28
		public List<PlacedCurrencyExchangeOrder> PlacedCurrencyExchangeOrders
		{
			get
			{
				this;
				this;
				return 88;
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x001A1B48 File Offset: 0x001A1B48
		public int GetBeastCapturedAmount(BestiaryCapturableMonster monster)
		{
			/*
An exception occurred when decompiling this method (06000F88)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.MemoryObjects.ServerData::GetBeastCapturedAmount(ExileCore2.PoEMemory.MemoryObjects.Bestiary.BestiaryCapturableMonster)

 ---> System.Exception: Inconsistent stack size at IL_0B
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x001A1B7C File Offset: 0x001A1B7C
		public Dictionary<QuestFlag, bool> QuestFlags
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x001A1B8C File Offset: 0x001A1B8C
		private Dictionary<QuestFlag, bool> GetQuestFlags()
		{
			/*
An exception occurred when decompiling this method (06000F8A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<ExileCore2.Shared.Enums.QuestFlag,System.Boolean> ExileCore2.PoEMemory.MemoryObjects.ServerData::GetQuestFlags()

 ---> System.Exception: Inconsistent stack size at IL_1C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x001A1C38 File Offset: 0x001A1C38
		public ushort LastActionId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x001A1C48 File Offset: 0x001A1C48
		public int Gold
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x001A1C5C File Offset: 0x001A1C5C
		public int CharacterLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x001A1C6C File Offset: 0x001A1C6C
		public int QuestPassiveSkillPoints
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x001A1C7C File Offset: 0x001A1C7C
		public int TotalAscendancyPoints
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x001A1C8C File Offset: 0x001A1C8C
		public int SpentAscendancyPoints
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x001A1C9C File Offset: 0x001A1C9C
		public PartyAllocation PartyAllocationType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x001A1CAC File Offset: 0x001A1CAC
		public string League
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x001A1CC4 File Offset: 0x001A1CC4
		public PartyStatus PartyStatusType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x001A1CD4 File Offset: 0x001A1CD4
		public bool IsInGame
		{
			get
			{
				return this == 3;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x001A1CE0 File Offset: 0x001A1CE0
		public NetworkStateE NetworkState
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x001A1CF0 File Offset: 0x001A1CF0
		public int Latency
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x001A1D00 File Offset: 0x001A1D00
		public string Guild
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x001A1D20 File Offset: 0x001A1D20
		public string GuildTag
		{
			get
			{
				this + 32L;
				return this;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x001A1D44 File Offset: 0x001A1D44
		public BitArray WaypointsUnlockState
		{
			get
			{
				this + this;
				return 24;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x001A1D68 File Offset: 0x001A1D68
		public int InstanceId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x001A1D78 File Offset: 0x001A1D78
		public IList<ushort> SkillBarIds
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F9B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.UInt16> ExileCore2.PoEMemory.MemoryObjects.ServerData::get_SkillBarIds()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x001A1DC8 File Offset: 0x001A1DC8
		public IList<ushort> PassiveSkillIds
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.UInt16> ExileCore2.PoEMemory.MemoryObjects.ServerData::get_PassiveSkillIds()

 ---> System.Exception: Inconsistent stack size at IL_0C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x001A1E38 File Offset: 0x001A1E38
		public IList<ushort> AtlasPassiveSkillIds
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F9D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.UInt16> ExileCore2.PoEMemory.MemoryObjects.ServerData::get_AtlasPassiveSkillIds()

 ---> System.Exception: Inconsistent stack size at IL_0C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x001A1EB4 File Offset: 0x001A1EB4
		public IList<ServerStashTab> PlayerStashTabs
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x001A1ECC File Offset: 0x001A1ECC
		public IList<ServerStashTab> GuildStashTabs
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x001A1EE4 File Offset: 0x001A1EE4
		private List<ServerStashTab> GetStashTabs(StdVector vector)
		{
			/*
An exception occurred when decompiling this method (06000FA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.ServerStashTab> ExileCore2.PoEMemory.MemoryObjects.ServerData::GetStashTabs(GameOffsets2.Native.StdVector)

 ---> System.Exception: Inconsistent stack size at IL_08
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x001A1F58 File Offset: 0x001A1F58
		private IList<InventoryHolder> ReadInventoryHolders(NativePtrArray array)
		{
			/*
An exception occurred when decompiling this method (06000FA1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<ExileCore2.PoEMemory.MemoryObjects.InventoryHolder> ExileCore2.PoEMemory.MemoryObjects.ServerData::ReadInventoryHolders(GameOffsets2.Native.NativePtrArray)

 ---> System.Exception: Inconsistent stack size at IL_0A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x001A1FB4 File Offset: 0x001A1FB4
		public IList<InventoryHolder> PlayerInventories
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x001A1FC4 File Offset: 0x001A1FC4
		public IList<InventoryHolder> NPCInventories
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x001A1FD4 File Offset: 0x001A1FD4
		public IList<InventoryHolder> GuildInventories
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x001A1FE4 File Offset: 0x001A1FE4
		public ServerInventory GetPlayerInventoryBySlot(InventorySlotE slot)
		{
			/*
An exception occurred when decompiling this method (06000FA5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.MemoryObjects.ServerInventory ExileCore2.PoEMemory.MemoryObjects.ServerData::GetPlayerInventoryBySlot(ExileCore2.Shared.Enums.InventorySlotE)

 ---> System.Exception: Inconsistent stack size at IL_04
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x001A2050 File Offset: 0x001A2050
		public ServerInventory GetPlayerInventoryByType(InventoryTypeE type)
		{
			/*
An exception occurred when decompiling this method (06000FA6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.MemoryObjects.ServerInventory ExileCore2.PoEMemory.MemoryObjects.ServerData::GetPlayerInventoryByType(ExileCore2.Shared.Enums.InventoryTypeE)

 ---> System.Exception: Inconsistent stack size at IL_04
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x001A20BC File Offset: 0x001A20BC
		public ServerInventory GetPlayerInventoryBySlotAndType(InventoryTypeE type, InventorySlotE slot)
		{
			/*
An exception occurred when decompiling this method (06000FA7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.MemoryObjects.ServerInventory ExileCore2.PoEMemory.MemoryObjects.ServerData::GetPlayerInventoryBySlotAndType(ExileCore2.Shared.Enums.InventoryTypeE,ExileCore2.Shared.Enums.InventorySlotE)

 ---> System.Exception: Inconsistent stack size at IL_04
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x001A2138 File Offset: 0x001A2138
		public ushort LesserBrokenCircleArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x001A214C File Offset: 0x001A214C
		public ushort GreaterBrokenCircleArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x001A2160 File Offset: 0x001A2160
		public ushort GrandBrokenCircleArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x001A2174 File Offset: 0x001A2174
		public ushort ExceptionalBrokenCircleArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x001A2188 File Offset: 0x001A2188
		public ushort LesserBlackScytheArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x001A219C File Offset: 0x001A219C
		public ushort GreaterBlackScytheArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x001A21B0 File Offset: 0x001A21B0
		public ushort GrandBlackScytheArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x001A21C4 File Offset: 0x001A21C4
		public ushort ExceptionalBlackScytheArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x001A21D8 File Offset: 0x001A21D8
		public ushort LesserOrderArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x001A21EC File Offset: 0x001A21EC
		public ushort GreaterOrderArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x001A2200 File Offset: 0x001A2200
		public ushort GrandOrderArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x001A2214 File Offset: 0x001A2214
		public ushort ExceptionalOrderArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x001A2228 File Offset: 0x001A2228
		public ushort LesserSunArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x001A223C File Offset: 0x001A223C
		public ushort GreaterSunArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x001A2250 File Offset: 0x001A2250
		public ushort GrandSunArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x001A2264 File Offset: 0x001A2264
		public ushort ExceptionalSunArtifacts
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04008040 RID: 32832
		private readonly CachedValue<ServerDataOffsets> _cachedValue;

		// Token: 0x04008041 RID: 32833
		private readonly CachedValue<ServerPlayerData> _playerRelatedData;

		// Token: 0x04008042 RID: 32834
		private readonly CachedValue<Dictionary<QuestFlag, bool>> _questFlags;

		// Token: 0x04008043 RID: 32835
		private readonly CachedValue<IList<InventoryHolder>> _playerInventoriesCache;

		// Token: 0x04008044 RID: 32836
		private readonly CachedValue<PerPlayerServerDataOffsets> _firstPlayerData;

		// Token: 0x04008045 RID: 32837
		private readonly CachedValue<PerPlayerSubDataOffsets> _firstPlayerSubData;

		// Token: 0x04008046 RID: 32838
		private readonly FrameCache<IList<InventoryHolder>> _npcInventoriesCache;

		// Token: 0x04008047 RID: 32839
		private readonly FrameCache<IList<InventoryHolder>> _guildInventoriesCache;

		// Token: 0x02000207 RID: 519
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 9)]
		private struct QuestFlagStore
		{
			// Token: 0x04008048 RID: 32840
			[FieldOffset(0)]
			public byte PartialId;

			// Token: 0x04008049 RID: 32841
			[FieldOffset(1)]
			public ulong Flags;
		}
	}
}
