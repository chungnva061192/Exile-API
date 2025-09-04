using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NAudio.Wave;

namespace ExileCore2
{
	// Token: 0x020000AE RID: 174
	internal class CachedSoundSampleProvider : ISampleProvider
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x0017F1D4 File Offset: 0x0017F1D4
		public CachedSoundSampleProvider(CachedSound cachedSound)
		{
			this;
			cachedSound;
			this;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0017F1E4 File Offset: 0x0017F1E4
		public int Read(float[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (060004F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.CachedSoundSampleProvider::Read(System.Single[],System.Int32,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_1C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0017F284 File Offset: 0x0017F284
		public WaveFormat WaveFormat
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040002FC RID: 764
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CachedSound <cachedSound>P;

		// Token: 0x040002FD RID: 765
		private int _position;
	}
}
