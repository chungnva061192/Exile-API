using System;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001D7 RID: 471
	public class AreaLoadingState : GameState
	{
		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0019BF20 File Offset: 0x0019BF20
		private AreaLoadingStateOffsets Data
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0019BF34 File Offset: 0x0019BF34
		public bool IsLoading
		{
			get
			{
				return this == 1L;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0019BF48 File Offset: 0x0019BF48
		public uint TotalLoadingScreenTimeMs
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0019BF58 File Offset: 0x0019BF58
		public string AreaName
		{
			get
			{
				this;
				this;
				this;
				return 1;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0019BF84 File Offset: 0x0019BF84
		public WorldArea Area
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0019BFA8 File Offset: 0x0019BFA8
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000D92)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.AreaLoadingState::ToString()

 ---> System.Exception: Inconsistent stack size at IL_0F
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0019BFF4 File Offset: 0x0019BFF4
		public AreaLoadingState()
		{
			this;
		}
	}
}
