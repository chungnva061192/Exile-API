using System;

namespace ExileCore2.PoEMemory.Elements.ExpeditionElements
{
	// Token: 0x02000307 RID: 775
	public class TujenHaggleWindowElement : Element
	{
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x001B1674 File Offset: 0x001B1674
		public string WindowTitle
		{
			get
			{
				this;
				return 0;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x001B1684 File Offset: 0x001B1684
		public Element HaggleTargetItem
		{
			get
			{
				this;
				return 1;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x001B1690 File Offset: 0x001B1690
		public Element HaggleArtifactType
		{
			get
			{
				this;
				return 3;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x001B169C File Offset: 0x001B169C
		public int HaggleArtifactCurrentOfferAmount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001542)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Elements.ExpeditionElements.TujenHaggleWindowElement::get_HaggleArtifactCurrentOfferAmount()

 ---> System.Exception: Inconsistent stack size at IL_07
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

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x001B16C0 File Offset: 0x001B16C0
		public ArtifactSliderElement ArtifactOfferSliderElement
		{
			get
			{
				this;
				return 5;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x001B16D0 File Offset: 0x001B16D0
		public Element SameNewOfferIndicator
		{
			get
			{
				this;
				return 6;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x001B16DC File Offset: 0x001B16DC
		public Element ConfirmButton
		{
			get
			{
				this;
				return 7;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x001B16E8 File Offset: 0x001B16E8
		public Element ExitWindowButton
		{
			get
			{
				this;
				return 8;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x001B16F4 File Offset: 0x001B16F4
		public Element HaggleTargetItemTooltipElement
		{
			get
			{
				this;
				return 9;
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x001B1700 File Offset: 0x001B1700
		public TujenHaggleWindowElement()
		{
			this;
		}
	}
}
