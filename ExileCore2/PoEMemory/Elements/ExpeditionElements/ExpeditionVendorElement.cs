using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.Elements.InventoryElements;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2.PoEMemory.Elements.ExpeditionElements
{
	// Token: 0x02000304 RID: 772
	public class ExpeditionVendorElement : Element
	{
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x001B144C File Offset: 0x001B144C
		public SearchBarElement HighlightSearchbarElement
		{
			get
			{
				this;
				return new int[]
				{
					4,
					3
				};
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x001B1468 File Offset: 0x001B1468
		public Element VendorResponseTextBox
		{
			get
			{
				this;
				return new int[]
				{
					6,
					1
				};
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x001B1480 File Offset: 0x001B1480
		public string VendorWindowTitle
		{
			get
			{
				this;
				int[] array = new int[3];
				array[0] = 6;
				array[1] = 2;
				return array;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x001B149C File Offset: 0x001B149C
		public Element RefreshItemsButton
		{
			get
			{
				this;
				int[] array = new int[2];
				array[0] = 7;
				return array;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x001B14B0 File Offset: 0x001B14B0
		public Element RefreshCurrencyInfoBox
		{
			get
			{
				this;
				return new int[]
				{
					7,
					1
				};
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x001B14C8 File Offset: 0x001B14C8
		public List<NormalInventoryItem> InventoryItems
		{
			get
			{
				this;
				int[] array = new int[4];
				array[0] = 8;
				array[1] = 1;
				return 1;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x001B14F0 File Offset: 0x001B14F0
		public ExpeditionVendorCurrencyInfoElement CurrencyInfo
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001531)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Elements.ExpeditionElements.ExpeditionVendorCurrencyInfoElement ExileCore2.PoEMemory.Elements.ExpeditionElements.ExpeditionVendorElement::get_CurrencyInfo()

 ---> System.Exception: Inconsistent stack size at IL_08
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

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x001B1508 File Offset: 0x001B1508
		public List<Entity> OfferedItems
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001532)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.Entity> ExileCore2.PoEMemory.Elements.ExpeditionElements.ExpeditionVendorElement::get_OfferedItems()

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
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x001B153C File Offset: 0x001B153C
		public TujenHaggleWindowElement TujenHaggleWindow
		{
			get
			{
				this;
				int[] array = new int[2];
				array[0] = 11;
				return array;
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x001B1554 File Offset: 0x001B1554
		public ExpeditionVendorElement()
		{
			this;
		}
	}
}
