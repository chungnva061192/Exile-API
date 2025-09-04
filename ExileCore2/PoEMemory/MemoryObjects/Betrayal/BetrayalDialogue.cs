using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.FilesInMemory.Betrayal;

namespace ExileCore2.PoEMemory.MemoryObjects.Betrayal
{
	// Token: 0x0200021B RID: 539
	public class BetrayalDialogue : RemoteMemoryObject
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x001A3934 File Offset: 0x001A3934
		public BetrayalTarget Target
		{
			get
			{
				this;
				return this + 8L;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x001A3960 File Offset: 0x001A3960
		public int Unknown1
		{
			get
			{
				this;
				return this + 16L;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x001A3978 File Offset: 0x001A3978
		public int Unknown2
		{
			get
			{
				this;
				return this + 20L;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x001A3990 File Offset: 0x001A3990
		public int Unknown3
		{
			get
			{
				this;
				return this + 56L;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x001A39A8 File Offset: 0x001A39A8
		public bool Unknown4
		{
			get
			{
				this;
				return this + 108L > 0;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x001A39C4 File Offset: 0x001A39C4
		public bool Unknown5
		{
			get
			{
				return this + this > 0;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x001A39E4 File Offset: 0x001A39E4
		public BetrayalJob Job
		{
			get
			{
				this;
				return this + 68L;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x001A3A10 File Offset: 0x001A3A10
		public BetrayalUpgrade Upgrade
		{
			get
			{
				this;
				return 100;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x001A3A1C File Offset: 0x001A3A1C
		public string DialogueText
		{
			get
			{
				this;
				this + this;
				(new int[1])[0] = 24;
				return 1;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x001A3A54 File Offset: 0x001A3A54
		public List<int> Keys1
		{
			get
			{
				this;
				return 32L;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x001A3A60 File Offset: 0x001A3A60
		public List<int> Keys2
		{
			get
			{
				this;
				return 84L;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x001A3A6C File Offset: 0x001A3A6C
		public List<int> Keys3
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x001A3A7C File Offset: 0x001A3A7C
		private List<int> ReadKeys(long offset)
		{
			/*
An exception occurred when decompiling this method (0600106E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Int32> ExileCore2.PoEMemory.MemoryObjects.Betrayal.BetrayalDialogue::ReadKeys(System.Int64)

 ---> System.Exception: Inconsistent stack size at IL_13
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x001A3AE4 File Offset: 0x001A3AE4
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600106F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.Betrayal.BetrayalDialogue::ToString()

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

		// Token: 0x06001070 RID: 4208 RVA: 0x001A3B8C File Offset: 0x001A3B8C
		public BetrayalDialogue()
		{
			this;
		}
	}
}
