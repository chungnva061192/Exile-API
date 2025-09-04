using System;
using System.Numerics;
using ExileCore2.Shared.Cache;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002E1 RID: 737
	public class SubMap : Element
	{
		// Token: 0x0600149E RID: 5278 RVA: 0x001B02B8 File Offset: 0x001B02B8
		public SubMap()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x001B02F0 File Offset: 0x001B02F0
		public Vector2 Shift
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x001B030C File Offset: 0x001B030C
		public Vector2 DefaultShift
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x001B0328 File Offset: 0x001B0328
		public float Zoom
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x001B0344 File Offset: 0x001B0344
		public float MapScale
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x001B0354 File Offset: 0x001B0354
		public Vector2 MapCenter
		{
			get
			{
				return this;
			}
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x001B0364 File Offset: 0x001B0364
		// Note: this type is marked as 'beforefieldinit'.
		static SubMap()
		{
			/*
An exception occurred when decompiling this method (060014A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.Elements.SubMap::.cctor()

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

		// Token: 0x0400825B RID: 33371
		private readonly CachedValue<float> _mapScale;

		// Token: 0x0400825C RID: 33372
		private readonly CachedValue<Vector2> _mapCenter;

		// Token: 0x0400825D RID: 33373
		public const double CameraAngle = 0.6754424205218056;

		// Token: 0x0400825E RID: 33374
		public static readonly float CameraAngleCos;

		// Token: 0x0400825F RID: 33375
		public static readonly float CameraAngleSin;
	}
}
