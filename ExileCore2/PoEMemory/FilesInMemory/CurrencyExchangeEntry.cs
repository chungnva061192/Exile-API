using System;
using ExileCore2.PoEMemory.Models;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x0200022A RID: 554
	public class CurrencyExchangeEntry : RemoteMemoryObject
	{
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x001A557C File Offset: 0x001A557C
		public BaseItemType BaseItemType
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x001A55A4 File Offset: 0x001A55A4
		public CurrencyExchangeCategory Category1
		{
			get
			{
				this;
				return this + 16L;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x001A55D0 File Offset: 0x001A55D0
		public CurrencyExchangeCategory Category2
		{
			get
			{
				this;
				return this + 32L;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x001A55FC File Offset: 0x001A55FC
		public byte Byte1
		{
			get
			{
				this;
				return this + 48L;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x001A5614 File Offset: 0x001A5614
		public byte Byte2
		{
			get
			{
				this;
				return this + 49L;
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x001A562C File Offset: 0x001A562C
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (060010E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.CurrencyExchangeEntry::ToString()

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

		// Token: 0x060010EA RID: 4330 RVA: 0x001A56A0 File Offset: 0x001A56A0
		public CurrencyExchangeEntry()
		{
			this;
		}
	}
}
