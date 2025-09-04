using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ExileCore2.Shared;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001C1 RID: 449
	public class EntityList : RemoteMemoryObject
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00199D18 File Offset: 0x00199D18
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00199D20 File Offset: 0x00199D20
		public int EntitiesProcessed
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00199D2C File Offset: 0x00199D2C
		[DebuggerStepThrough]
		public Task CollectEntities(EntityCollectSettingsContainer container)
		{
			/*
An exception occurred when decompiling this method (06000D17)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task ExileCore2.PoEMemory.MemoryObjects.EntityList::CollectEntities(ExileCore2.EntityCollectSettingsContainer)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00199D78 File Offset: 0x00199D78
		private uint ParseEntity(long addrEntity, EntityCacheContainer entityCache, uint entitiesVersion, Stack<Entity> newEntities, int? instanceId)
		{
			/*
An exception occurred when decompiling this method (06000D18)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 ExileCore2.PoEMemory.MemoryObjects.EntityList::ParseEntity(System.Int64,ExileCore2.EntityCacheContainer,System.UInt32,System.Collections.Generic.Stack`1<ExileCore2.PoEMemory.MemoryObjects.Entity>,System.Nullable`1<System.Int32>)

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

		// Token: 0x06000D19 RID: 3353 RVA: 0x00199EAC File Offset: 0x00199EAC
		public EntityList()
		{
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00199F0C File Offset: 0x00199F0C
		// Note: this type is marked as 'beforefieldinit'.
		static EntityList()
		{
			"Collect Entities";
			1;
		}

		// Token: 0x04007F23 RID: 32547
		private readonly Queue<long> _unexploredAddressQueue;

		// Token: 0x04007F24 RID: 32548
		private readonly List<long> _discoveredAddressList;

		// Token: 0x04007F25 RID: 32549
		private readonly HashSet<long> _discoveredAddressSet;

		// Token: 0x04007F26 RID: 32550
		private readonly HashSet<long> _discoveredEntityIds;

		// Token: 0x04007F27 RID: 32551
		private readonly object _lock;

		// Token: 0x04007F29 RID: 32553
		private static readonly DebugInformation CollectEntitiesDebug;
	}
}
