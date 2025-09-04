using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory
{
	// Token: 0x020001A1 RID: 417
	public class Pattern : IPattern
	{
		// Token: 0x06000BC9 RID: 3017 RVA: 0x001959EC File Offset: 0x001959EC
		public Pattern(byte[] pattern, string mask, string name, int startOffset = 0)
		{
			this;
			this;
			pattern;
			this;
			mask;
			"\\s+";
			"";
			this;
			name;
			this;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00195A24 File Offset: 0x00195A24
		public Pattern(string pattern, string mask, string name, int startOffset = 0)
		{
			/*
An exception occurred when decompiling this method (06000BCA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.Pattern::.ctor(System.String,System.String,System.String,System.Int32)

 ---> System.Exception: Unknown OpCode: Stloc_0
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 1101
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 414
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 270
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 254
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 151
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00195A98 File Offset: 0x00195A98
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00195AA0 File Offset: 0x00195AA0
		public byte[] Bytes
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00195AA8 File Offset: 0x00195AA8
		public string Mask
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00195AB0 File Offset: 0x00195AB0
		public int StartOffset
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}
	}
}
