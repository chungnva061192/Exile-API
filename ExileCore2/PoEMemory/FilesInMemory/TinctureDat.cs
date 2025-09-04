using System;
using ExileCore2.PoEMemory.Models;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000279 RID: 633
	public class TinctureDat : RemoteMemoryObject
	{
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x001AAE60 File Offset: 0x001AAE60
		public BaseItemType BaseItemType
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x001AAE88 File Offset: 0x001AAE88
		public int DebuffInterval
		{
			get
			{
				this;
				return this + 16L;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x001AAEA0 File Offset: 0x001AAEA0
		public int Cooldown
		{
			get
			{
				this;
				return this + 20L;
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x001AAEB8 File Offset: 0x001AAEB8
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06001286)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.TinctureDat::ToString()

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

		// Token: 0x06001287 RID: 4743 RVA: 0x001AAF2C File Offset: 0x001AAF2C
		public TinctureDat()
		{
			this;
		}
	}
}
