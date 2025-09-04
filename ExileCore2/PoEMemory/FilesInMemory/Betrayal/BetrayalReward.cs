using System;

namespace ExileCore2.PoEMemory.FilesInMemory.Betrayal
{
	// Token: 0x0200029D RID: 669
	public class BetrayalReward : RemoteMemoryObject
	{
		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x001AD014 File Offset: 0x001AD014
		public BetrayalJob Job
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x001AD03C File Offset: 0x001AD03C
		public BetrayalTarget Target
		{
			get
			{
				this;
				return this + 16L;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x001AD068 File Offset: 0x001AD068
		public BetrayalRank Rank
		{
			get
			{
				this;
				return this + 32L;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x001AD094 File Offset: 0x001AD094
		public string Reward
		{
			get
			{
				this;
				this;
				this + 48L;
				return 1;
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x001AD0BC File Offset: 0x001AD0BC
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06001342)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.Betrayal.BetrayalReward::ToString()

 ---> System.Exception: Inconsistent stack size at IL_03
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x001AD0D4 File Offset: 0x001AD0D4
		public BetrayalReward()
		{
			this;
		}
	}
}
