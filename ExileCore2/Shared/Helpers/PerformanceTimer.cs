using System;
using System.Diagnostics;
using Serilog;

namespace ExileCore2.Shared.Helpers
{
	// Token: 0x0200012C RID: 300
	public struct PerformanceTimer : IDisposable
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x0018D138 File Offset: 0x0018D138
		public PerformanceTimer(string debugText, int triggerMs = 0, Action<string, TimeSpan> callback = null, bool log = true)
		{
			ref this;
			callback;
			ref this;
			debugText;
			ref this;
			triggerMs;
			ref this;
			ref this;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0018D164 File Offset: 0x0018D164
		public void Dispose()
		{
			ref this;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0018D170 File Offset: 0x0018D170
		public void StopAndPrint()
		{
			/*
An exception occurred when decompiling this method (06000950)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.Shared.Helpers.PerformanceTimer::StopAndPrint()

 ---> System.Exception: Inconsistent stack size at IL_09
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x04000477 RID: 1143
		private readonly string DebugText;

		// Token: 0x04000478 RID: 1144
		private readonly Action<string, TimeSpan> FinishedCallback;

		// Token: 0x04000479 RID: 1145
		private readonly int TriggerMs;

		// Token: 0x0400047A RID: 1146
		private readonly bool Log;

		// Token: 0x0400047B RID: 1147
		public static bool IgnoreTimer;

		// Token: 0x0400047C RID: 1148
		public static ILogger Logger;

		// Token: 0x0400047D RID: 1149
		private readonly Stopwatch sw;
	}
}
