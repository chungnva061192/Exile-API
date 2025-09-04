using System;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements.InventoryElements
{
	// Token: 0x02000302 RID: 770
	public class NormalInventoryItem : Element
	{
		// Token: 0x06001520 RID: 5408 RVA: 0x001B12FC File Offset: 0x001B12FC
		public NormalInventoryItem()
		{
			this;
			this;
			this;
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x001B1320 File Offset: 0x001B1320
		public virtual int ItemWidth
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x001B1338 File Offset: 0x001B1338
		public virtual int ItemHeight
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x001B1350 File Offset: 0x001B1350
		public Entity Item
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001523)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.MemoryObjects.Entity ExileCore2.PoEMemory.Elements.InventoryElements.NormalInventoryItem::get_Item()

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

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x001B1388 File Offset: 0x001B1388
		public ToolTipType toolTipType
		{
			get
			{
				return ToolTipType.InventoryItem;
			}
		}

		// Token: 0x0400827D RID: 33405
		private Entity _item;

		// Token: 0x0400827E RID: 33406
		private readonly Lazy<NormalInventoryItemOffsets> cachedValue;
	}
}
