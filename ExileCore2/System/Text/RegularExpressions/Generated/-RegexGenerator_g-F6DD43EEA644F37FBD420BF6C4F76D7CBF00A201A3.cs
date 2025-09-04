using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated
{
	// Token: 0x02000007 RID: 7
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.46610")]
	[SkipLocalsInit]
	internal sealed class <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__StringTemplateRegex_0 : Regex
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00169A1C File Offset: 0x00169A1C
		private <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__StringTemplateRegex_0()
		{
			this;
			this;
			"{(?<id>\\d*)(:(?<format>[^}]*))?}";
			this;
			12;
			this;
			this;
			this;
			"0";
			0;
			"format";
			2;
			"id";
			1;
			this;
			string[] array = new string[]
			{
				"0",
				"id",
				"format"
			};
			this;
			3;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00169AD4 File Offset: 0x00169AD4
		// Note: this type is marked as 'beforefieldinit'.
		static <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__StringTemplateRegex_0()
		{
			new <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__StringTemplateRegex_0();
		}

		// Token: 0x04000010 RID: 16
		[Nullable(1)]
		internal static readonly <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__StringTemplateRegex_0 Instance;

		// Token: 0x02000008 RID: 8
		private sealed class RunnerFactory : RegexRunnerFactory
		{
			// Token: 0x06000027 RID: 39 RVA: 0x00169AE0 File Offset: 0x00169AE0
			[NullableContext(1)]
			protected override RegexRunner CreateInstance()
			{
				return new <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__StringTemplateRegex_0.RunnerFactory.Runner();
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00169AE8 File Offset: 0x00169AE8
			public RunnerFactory()
			{
				this;
			}

			// Token: 0x02000009 RID: 9
			private sealed class Runner : RegexRunner
			{
				// Token: 0x06000029 RID: 41 RVA: 0x00169AF4 File Offset: 0x00169AF4
				protected override void Scan(ReadOnlySpan<char> inputSpan)
				{
					goto IL_00;
					for (;;)
					{
						IL_00:
						goto IL_00;
					}
				}

				// Token: 0x0600002A RID: 42 RVA: 0x00169B54 File Offset: 0x00169B54
				private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
				{
					/*
An exception occurred when decompiling this method (0600002A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.Generated.<RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__StringTemplateRegex_0/RunnerFactory/Runner::TryFindNextPossibleStartingPosition(System.ReadOnlySpan`1<System.Char>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
				}

				// Token: 0x0600002B RID: 43 RVA: 0x00169BBC File Offset: 0x00169BBC
				private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
				{
					/*
An exception occurred when decompiling this method (0600002B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.Generated.<RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__StringTemplateRegex_0/RunnerFactory/Runner::TryMatchAtCurrentPosition(System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Inconsistent stack size at IL_1B
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
				}

				// Token: 0x0600002C RID: 44 RVA: 0x00169EF0 File Offset: 0x00169EF0
				public Runner()
				{
					this;
				}

				// Token: 0x0600002D RID: 45 RVA: 0x00169EFC File Offset: 0x00169EFC
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				private void <TryMatchAtCurrentPosition>g__UncaptureUntil|2_0(int capturePosition)
				{
					goto IL_00;
					for (;;)
					{
						IL_00:
						goto IL_00;
					}
				}
			}
		}
	}
}
