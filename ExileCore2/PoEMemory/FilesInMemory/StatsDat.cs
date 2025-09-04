using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Enums;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000273 RID: 627
	public class StatsDat : FileInMemory
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x001AA8DC File Offset: 0x001AA8DC
		public StatsDat(IMemory m, Func<long> address)
		{
			this;
			this;
			this;
			this;
			m;
			address;
			this;
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x001AA918 File Offset: 0x001AA918
		public IDictionary<string, StatsDat.StatRecord> records
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x001AA920 File Offset: 0x001AA920
		public IDictionary<int, StatsDat.StatRecord> recordsById
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x001AA928 File Offset: 0x001AA928
		public StatsDat.StatRecord GetStatByAddress(long address)
		{
			this;
			return address;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x001AA938 File Offset: 0x001AA938
		private void loadItems()
		{
			/*
An exception occurred when decompiling this method (06001268)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.FilesInMemory.StatsDat::loadItems()

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

		// Token: 0x0400819D RID: 33181
		private readonly Dictionary<long, StatsDat.StatRecord> _recordsByAddress;

		// Token: 0x02000274 RID: 628
		public class StatRecord
		{
			// Token: 0x06001269 RID: 4713 RVA: 0x001AA9D0 File Offset: 0x001AA9D0
			public StatRecord(IMemory m, long addr, int iCounter)
			{
				/*
An exception occurred when decompiling this method (06001269)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.FilesInMemory.StatsDat/StatRecord::.ctor(ExileCore2.Shared.Interfaces.IMemory,System.Int64,System.Int32)

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

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x0600126A RID: 4714 RVA: 0x001AAB58 File Offset: 0x001AAB58
			public GameStat MatchingStat
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x0600126B RID: 4715 RVA: 0x001AAB60 File Offset: 0x001AAB60
			public string Key
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x0600126C RID: 4716 RVA: 0x001AAB68 File Offset: 0x001AAB68
			public long Address
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x0600126D RID: 4717 RVA: 0x001AAB70 File Offset: 0x001AAB70
			public StatType Type
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x0600126E RID: 4718 RVA: 0x001AAB78 File Offset: 0x001AAB78
			public bool Flag0
			{
				[CompilerGenerated]
				get
				{
					return this != null;
				}
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x0600126F RID: 4719 RVA: 0x001AAB80 File Offset: 0x001AAB80
			public bool IsLocal
			{
				[CompilerGenerated]
				get
				{
					return this != null;
				}
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x06001270 RID: 4720 RVA: 0x001AAB88 File Offset: 0x001AAB88
			public bool IsWeaponLocal
			{
				[CompilerGenerated]
				get
				{
					return this != null;
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x06001271 RID: 4721 RVA: 0x001AAB90 File Offset: 0x001AAB90
			public bool Flag3
			{
				[CompilerGenerated]
				get
				{
					return this != null;
				}
			}

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x06001272 RID: 4722 RVA: 0x001AAB98 File Offset: 0x001AAB98
			public string UserFriendlyName
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x06001273 RID: 4723 RVA: 0x001AABA0 File Offset: 0x001AABA0
			public int ID
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
			}

			// Token: 0x06001274 RID: 4724 RVA: 0x001AABA8 File Offset: 0x001AABA8
			public override string ToString()
			{
				/*
An exception occurred when decompiling this method (06001274)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.StatsDat/StatRecord::ToString()

 ---> System.Exception: Inconsistent stack size at IL_05
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06001275 RID: 4725 RVA: 0x001AABD8 File Offset: 0x001AABD8
			public string ValueToString(int val)
			{
				/*
An exception occurred when decompiling this method (06001275)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.StatsDat/StatRecord::ValueToString(System.Int32)

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
		}
	}
}
