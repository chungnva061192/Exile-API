using System;
using ExileCore2.PoEMemory.Elements.InventoryElements;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001B8 RID: 440
	public class CardTradeWindow : Element
	{
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00197F34 File Offset: 0x00197F34
		public Element CardSlotElement
		{
			get
			{
				this;
				return 5;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00197F40 File Offset: 0x00197F40
		public NormalInventoryItem CardSlotItem
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000CB4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Elements.InventoryElements.NormalInventoryItem ExileCore2.PoEMemory.MemoryObjects.CardTradeWindow::get_CardSlotItem()

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
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00197F6C File Offset: 0x00197F6C
		public Element TradeButton
		{
			get
			{
				this;
				return 4;
			}
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00197F78 File Offset: 0x00197F78
		public CardTradeWindow()
		{
			this;
		}
	}
}
