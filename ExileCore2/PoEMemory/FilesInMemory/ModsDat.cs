using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared;
using ExileCore2.Shared.Enums;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000247 RID: 583
	public class ModsDat : FileInMemory
	{
		// Token: 0x0600116D RID: 4461 RVA: 0x001A7110 File Offset: 0x001A7110
		public ModsDat(IMemory m, Func<long> address, StatsDat sDat, TagsDat tagsDat)
		{
			this;
			this;
			this;
			this;
			this;
			m;
			address;
			this;
			sDat;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x001A7164 File Offset: 0x001A7164
		public IDictionary<string, ModsDat.ModRecord> records
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x001A716C File Offset: 0x001A716C
		public IDictionary<long, ModsDat.ModRecord> DictionaryRecords
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x001A7174 File Offset: 0x001A7174
		private Dictionary<uint, ModsDat.ModRecord> ModsByHash32
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x001A717C File Offset: 0x001A717C
		public IDictionary<Tuple<string, ModType>, List<ModsDat.ModRecord>> recordsByTier
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x001A7184 File Offset: 0x001A7184
		public ModsDat.ModRecord GetModByAddress(long address)
		{
			/*
An exception occurred when decompiling this method (06001172)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.ModsDat/ModRecord ExileCore2.PoEMemory.FilesInMemory.ModsDat::GetModByAddress(System.Int64)

 ---> System.Exception: Inconsistent stack size at IL_06
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x001A71A8 File Offset: 0x001A71A8
		public ModsDat.ModRecord GetByHash32(uint hash)
		{
			this;
			return hash;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x001A71B8 File Offset: 0x001A71B8
		private void loadItems(StatsDat sDat, TagsDat tagsDat)
		{
			/*
An exception occurred when decompiling this method (06001174)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.FilesInMemory.ModsDat::loadItems(ExileCore2.PoEMemory.FilesInMemory.StatsDat,ExileCore2.PoEMemory.FilesInMemory.TagsDat)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x02000248 RID: 584
		public class ModRecord
		{
			// Token: 0x06001175 RID: 4469 RVA: 0x001A7384 File Offset: 0x001A7384
			public ModRecord(IMemory m, StatsDat sDat, TagsDat tagsDat, long addr)
			{
				/*
An exception occurred when decompiling this method (06001175)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.FilesInMemory.ModsDat/ModRecord::.ctor(ExileCore2.Shared.Interfaces.IMemory,ExileCore2.PoEMemory.FilesInMemory.StatsDat,ExileCore2.PoEMemory.FilesInMemory.TagsDat,System.Int64)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x06001176 RID: 4470 RVA: 0x001A775C File Offset: 0x001A775C
			public long Address
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x06001177 RID: 4471 RVA: 0x001A7764 File Offset: 0x001A7764
			public string Key
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x06001178 RID: 4472 RVA: 0x001A776C File Offset: 0x001A776C
			public ModType AffixType
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x06001179 RID: 4473 RVA: 0x001A7774 File Offset: 0x001A7774
			public ModDomain Domain
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x0600117A RID: 4474 RVA: 0x001A777C File Offset: 0x001A777C
			public string Group
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x0600117B RID: 4475 RVA: 0x001A7784 File Offset: 0x001A7784
			public List<string> Groups
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x0600117C RID: 4476 RVA: 0x001A778C File Offset: 0x001A778C
			public int MinLevel
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x0600117D RID: 4477 RVA: 0x001A7794 File Offset: 0x001A7794
			public StatsDat.StatRecord[] StatNames
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x0600117E RID: 4478 RVA: 0x001A779C File Offset: 0x001A779C
			public IntRange[] StatRange
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x0600117F RID: 4479 RVA: 0x001A77A4 File Offset: 0x001A77A4
			public IDictionary<string, int> TagChances
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x06001180 RID: 4480 RVA: 0x001A77AC File Offset: 0x001A77AC
			public TagsDat.TagRecord[] Tags
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x06001181 RID: 4481 RVA: 0x001A77B4 File Offset: 0x001A77B4
			public int Hash
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x06001182 RID: 4482 RVA: 0x001A77BC File Offset: 0x001A77BC
			public uint Hash32
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x06001183 RID: 4483 RVA: 0x001A77C4 File Offset: 0x001A77C4
			public string UserFriendlyName
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x06001184 RID: 4484 RVA: 0x001A77CC File Offset: 0x001A77CC
			public bool IsEssence
			{
				[CompilerGenerated]
				get
				{
					return this != null;
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x06001185 RID: 4485 RVA: 0x001A77D4 File Offset: 0x001A77D4
			public string Tier
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x06001186 RID: 4486 RVA: 0x001A77DC File Offset: 0x001A77DC
			public string TypeName
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06001187 RID: 4487 RVA: 0x001A77E4 File Offset: 0x001A77E4
			public InfluenceTypes InfluenceType
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x06001188 RID: 4488 RVA: 0x001A77EC File Offset: 0x001A77EC
			public override string ToString()
			{
				/*
An exception occurred when decompiling this method (06001188)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.ModsDat/ModRecord::ToString()

 ---> System.Exception: Inconsistent stack size at IL_37
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06001189 RID: 4489 RVA: 0x001A78A0 File Offset: 0x001A78A0
			// Note: this type is marked as 'beforefieldinit'.
			static ModRecord()
			{
				new ModsDat.ModRecord.LevelComparer();
			}

			// Token: 0x040080DE RID: 32990
			public const int NumberOfStats = 6;

			// Token: 0x040080DF RID: 32991
			public static readonly IComparer<ModsDat.ModRecord> ByLevelComparer;

			// Token: 0x02000249 RID: 585
			private class LevelComparer : IComparer<ModsDat.ModRecord>
			{
				// Token: 0x0600118A RID: 4490 RVA: 0x001A78AC File Offset: 0x001A78AC
				public int Compare(ModsDat.ModRecord x, ModsDat.ModRecord y)
				{
					/*
An exception occurred when decompiling this method (0600118A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.FilesInMemory.ModsDat/ModRecord/LevelComparer::Compare(ExileCore2.PoEMemory.FilesInMemory.ModsDat/ModRecord,ExileCore2.PoEMemory.FilesInMemory.ModsDat/ModRecord)

 ---> System.Exception: Inconsistent stack size at IL_06
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
				}

				// Token: 0x0600118B RID: 4491 RVA: 0x001A78CC File Offset: 0x001A78CC
				public LevelComparer()
				{
					this;
				}
			}
		}
	}
}
