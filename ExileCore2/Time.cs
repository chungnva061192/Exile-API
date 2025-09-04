using System;
using System.Diagnostics;

namespace ExileCore2
{
	// Token: 0x020000B3 RID: 179
	public static class Time
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0017FC80 File Offset: 0x0017FC80
		private static Stopwatch Stopwatch { get; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0017FC88 File Offset: 0x0017FC88
		public static double TotalMilliseconds
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000508)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double ExileCore2.Time::get_TotalMilliseconds()

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
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0017FCA8 File Offset: 0x0017FCA8
		public static long ElapsedMilliseconds
		{
			get
			{
				return Time.Stopwatch;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0017FCB4 File Offset: 0x0017FCB4
		public static TimeSpan Elapsed
		{
			get
			{
				return Time.Stopwatch;
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0017FCC0 File Offset: 0x0017FCC0
		// Note: this type is marked as 'beforefieldinit'.
		static Time()
		{
			Stopwatch.StartNew();
		}
	}
}
