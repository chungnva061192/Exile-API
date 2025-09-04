using System;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002C6 RID: 710
	public class Map : Element
	{
		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x001AF38C File Offset: 0x001AF38C
		public SubMap LargeMap
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001417)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Elements.SubMap ExileCore2.PoEMemory.Elements.Map::get_LargeMap()

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
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x001AF3B8 File Offset: 0x001AF3B8
		public float LargeMapShiftX
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x001AF3D8 File Offset: 0x001AF3D8
		public float LargeMapShiftY
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x001AF3F8 File Offset: 0x001AF3F8
		public float LargeMapZoom
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x001AF418 File Offset: 0x001AF418
		public SubMap SmallMiniMap
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600141B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Elements.SubMap ExileCore2.PoEMemory.Elements.Map::get_SmallMiniMap()

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
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x001AF444 File Offset: 0x001AF444
		public float SmallMinMapX
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x001AF464 File Offset: 0x001AF464
		public float SmallMinMapY
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x001AF484 File Offset: 0x001AF484
		public float SmallMinMapZoom
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x001AF4A4 File Offset: 0x001AF4A4
		public Element OrangeWords
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x001AF4B4 File Offset: 0x001AF4B4
		public Element BlueWords
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x001AF4C4 File Offset: 0x001AF4C4
		public Map()
		{
			this;
		}

		// Token: 0x0400823F RID: 33343
		private SubMap _largeMap;

		// Token: 0x04008240 RID: 33344
		private SubMap _smallMap;
	}
}
