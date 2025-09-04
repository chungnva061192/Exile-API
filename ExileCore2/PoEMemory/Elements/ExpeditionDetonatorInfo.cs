using System;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002BA RID: 698
	public class ExpeditionDetonatorInfo : StructuredRemoteMemoryObject<ExpeditionDetonatorInfoOffsets>
	{
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x001AE0D4 File Offset: 0x001AE0D4
		public bool IsExplosivePlacementActive
		{
			get
			{
				return this != 0L;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x001AE0E8 File Offset: 0x001AE0E8
		public Vector2i[] PlacedExplosiveGridPositions
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x001AE100 File Offset: 0x001AE100
		public int TotalExplosiveCount
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x001AE110 File Offset: 0x001AE110
		public int PlacedExplosiveCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (060013BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Elements.ExpeditionDetonatorInfo::get_PlacedExplosiveCount()

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

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x001AE134 File Offset: 0x001AE134
		public int RemainingExplosiveCount
		{
			get
			{
				return this - this;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x001AE144 File Offset: 0x001AE144
		public Vector2i DetonatorGridPosition
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x001AE154 File Offset: 0x001AE154
		public Vector2i PlacementIndicatorGridPosition
		{
			get
			{
				return this;
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x001AE164 File Offset: 0x001AE164
		public ExpeditionDetonatorInfo()
		{
			this;
		}
	}
}
