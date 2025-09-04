using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000374 RID: 884
	public class Stats : Component
	{
		// Token: 0x060017AA RID: 6058 RVA: 0x001B6D48 File Offset: 0x001B6D48
		public Stats()
		{
			this;
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x001B6DA4 File Offset: 0x001B6DA4
		public new long OwnerAddress
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x001B6DB8 File Offset: 0x001B6DB8
		public Dictionary<GameStat, int> StatDictionary
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x001B6DC8 File Offset: 0x001B6DC8
		public long StatsCount
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x001B6DD8 File Offset: 0x001B6DD8
		public int ActiveWeaponSetIndex
		{
			get
			{
				return this;
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x001B6DEC File Offset: 0x001B6DEC
		private Dictionary<GameStat, int> ParseStats(SubStatsComponentOffsets subStats, bool secondary)
		{
			/*
An exception occurred when decompiling this method (060017AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<ExileCore2.Shared.Enums.GameStat,System.Int32> ExileCore2.PoEMemory.Components.Stats::ParseStats(GameOffsets2.SubStatsComponentOffsets,System.Boolean)

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

		// Token: 0x04008314 RID: 33556
		private readonly CachedValue<StatsComponentOffsets> _statsValue;

		// Token: 0x04008315 RID: 33557
		private readonly CachedValue<Dictionary<GameStat, int>> _statDictionary;

		// Token: 0x04008316 RID: 33558
		private readonly Dictionary<GameStat, int> _mainStatDictionary;

		// Token: 0x04008317 RID: 33559
		private readonly Dictionary<GameStat, int> _secondaryStatDictionary;
	}
}
