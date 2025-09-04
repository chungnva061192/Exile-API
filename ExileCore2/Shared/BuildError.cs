using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.Shared
{
	// Token: 0x020000B5 RID: 181
	public class BuildError
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0017FD78 File Offset: 0x0017FD78
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0017FD80 File Offset: 0x0017FD80
		public string File
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0017FD8C File Offset: 0x0017FD8C
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x0017FD94 File Offset: 0x0017FD94
		public DateTime Timestamp
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0017FDA0 File Offset: 0x0017FDA0
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x0017FDA8 File Offset: 0x0017FDA8
		public int LineNumber
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0017FDB4 File Offset: 0x0017FDB4
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x0017FDBC File Offset: 0x0017FDBC
		public int ColumnNumber
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0017FDC8 File Offset: 0x0017FDC8
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x0017FDD0 File Offset: 0x0017FDD0
		public string Code
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0017FDDC File Offset: 0x0017FDDC
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x0017FDE4 File Offset: 0x0017FDE4
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0017FDF0 File Offset: 0x0017FDF0
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x0017FDF8 File Offset: 0x0017FDF8
		public string ProjectFile
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0017FE04 File Offset: 0x0017FE04
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600051E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.Shared.BuildError::ToString()

 ---> System.Exception: Inconsistent stack size at IL_35
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0017FECC File Offset: 0x0017FECC
		public BuildError()
		{
			this;
		}
	}
}
