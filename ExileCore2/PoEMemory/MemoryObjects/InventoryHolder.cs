using System;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001EC RID: 492
	public class InventoryHolder : RemoteMemoryObject
	{
		// Token: 0x06000EC1 RID: 3777 RVA: 0x0019F874 File Offset: 0x0019F874
		public InventoryHolder()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0019F898 File Offset: 0x0019F898
		public int Id
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0019F8AC File Offset: 0x0019F8AC
		public InventoryNameE TypeId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0019F8B4 File Offset: 0x0019F8B4
		public ServerInventory Inventory
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0019F8C4 File Offset: 0x0019F8C4
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000EC5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.InventoryHolder::ToString()

 ---> System.Exception: Inconsistent stack size at IL_25
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x04008011 RID: 32785
		private readonly CachedValue<ServerInventory> _inventoryCache;

		// Token: 0x04008012 RID: 32786
		public const int StructSize = 24;
	}
}
