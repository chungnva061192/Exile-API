using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ExileCore2
{
	// Token: 0x020000AF RID: 175
	public class StatCollector
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x0017F294 File Offset: 0x0017F294
		public static void Run(CancellationToken cancellationToken)
		{
			goto IL_00;
			for (;;)
			{
				IL_00:
				goto IL_00;
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0017FA5C File Offset: 0x0017FA5C
		private static bool ValidateServerCert(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
		{
			/*
An exception occurred when decompiling this method (060004F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.StatCollector::ValidateServerCert(System.Object,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,System.Net.Security.SslPolicyErrors)

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

		// Token: 0x060004FA RID: 1274 RVA: 0x0017FAF4 File Offset: 0x0017FAF4
		public StatCollector()
		{
			this;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0017FB00 File Offset: 0x0017FB00
		// Note: this type is marked as 'beforefieldinit'.
		static StatCollector()
		{
			new byte[32];
			new byte[32];
		}

		// Token: 0x040002FE RID: 766
		private static readonly byte[] AbortHash;

		// Token: 0x040002FF RID: 767
		private static readonly byte[] RequestHash;

		// Token: 0x020000B0 RID: 176
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000300 RID: 768
			public static RemoteCertificateValidationCallback <0>__ValidateServerCert;
		}
	}
}
