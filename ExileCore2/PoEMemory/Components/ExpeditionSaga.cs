using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects.Expedition;
using ExileCore2.Shared.Cache;
using GameOffsets2.Components.LeagueSpecific;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000337 RID: 823
	public class ExpeditionSaga : Component
	{
		// Token: 0x06001656 RID: 5718 RVA: 0x001B3ABC File Offset: 0x001B3ABC
		public ExpeditionSaga()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x001B3AE0 File Offset: 0x001B3AE0
		public ExpeditionSagaOffsets SagaStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x001B3AF0 File Offset: 0x001B3AF0
		public int AreaLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x001B3B00 File Offset: 0x001B3B00
		public List<ExpeditionAreaData> Areas
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001659)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.Expedition.ExpeditionAreaData> ExileCore2.PoEMemory.Components.ExpeditionSaga::get_Areas()

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

		// Token: 0x040082C7 RID: 33479
		private readonly CachedValue<ExpeditionSagaOffsets> _cachedValue;
	}
}
