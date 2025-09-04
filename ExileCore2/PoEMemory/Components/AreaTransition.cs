using System;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2.Components;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200031F RID: 799
	public class AreaTransition : Component
	{
		// Token: 0x060015D8 RID: 5592 RVA: 0x001B2BC0 File Offset: 0x001B2BC0
		public AreaTransition()
		{
			this;
			this;
			this;
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x001B2BE4 File Offset: 0x001B2BE4
		public int WorldAreaId
		{
			get
			{
				/*
An exception occurred when decompiling this method (060015D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Components.AreaTransition::get_WorldAreaId()

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
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x001B2BF8 File Offset: 0x001B2BF8
		public WorldArea AreaById
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x001B2C14 File Offset: 0x001B2C14
		public WorldArea WorldArea
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x001B2C3C File Offset: 0x001B2C3C
		public AreaTransitionType TransitionType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040082B5 RID: 33461
		private readonly CachedValue<AreaTransitionComponentOffsets> _cache;
	}
}
