using System;

namespace ExileCore2
{
	// Token: 0x02000062 RID: 98
	internal static class Limits
	{
		// Token: 0x06000375 RID: 885 RVA: 0x00175668 File Offset: 0x00175668
		static Limits()
		{
			/*
An exception occurred when decompiling this method (06000375)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.Limits::.cctor()

 ---> System.Exception: Inconsistent stack size at IL_1A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x040001C8 RID: 456
		public static readonly int ElementChildCount;

		// Token: 0x040001C9 RID: 457
		public static readonly int UnicodeStringLength;

		// Token: 0x040001CA RID: 458
		public static readonly int ReadStructsArrayCount;

		// Token: 0x040001CB RID: 459
		public static readonly int ReadMemoryTimeLimit;

		// Token: 0x02000063 RID: 99
		private class LimitsInstance
		{
			// Token: 0x06000376 RID: 886 RVA: 0x001757F0 File Offset: 0x001757F0
			public LimitsInstance()
			{
				this;
			}

			// Token: 0x040001CC RID: 460
			public int? ElementChildCount;

			// Token: 0x040001CD RID: 461
			public int? UnicodeStringLength;

			// Token: 0x040001CE RID: 462
			public int? ReadStructsArrayCount;

			// Token: 0x040001CF RID: 463
			public int? ReadMemoryTimeLimit;
		}
	}
}
