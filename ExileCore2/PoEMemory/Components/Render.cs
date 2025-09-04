using System;
using System.Numerics;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000361 RID: 865
	public class Render : Component
	{
		// Token: 0x06001752 RID: 5970 RVA: 0x001B6004 File Offset: 0x001B6004
		public Render()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x001B6028 File Offset: 0x001B6028
		public RenderComponentOffsets RenderStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x001B6038 File Offset: 0x001B6038
		public float X
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x001B6048 File Offset: 0x001B6048
		public float Y
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x001B6058 File Offset: 0x001B6058
		public float Z
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x001B6068 File Offset: 0x001B6068
		public Vector3 Pos
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x001B6078 File Offset: 0x001B6078
		public Vector3 InteractCenter
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x001B6098 File Offset: 0x001B6098
		public float Height
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001759)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ExileCore2.PoEMemory.Components.Render::get_Height()

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
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x001B60C0 File Offset: 0x001B60C0
		public float UnclampedHeight
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x001B60D0 File Offset: 0x001B60D0
		public string Name
		{
			get
			{
				0;
				2;
				"Render";
				this;
				return this;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x001B6130 File Offset: 0x001B6130
		public string NameNoCache
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x001B6148 File Offset: 0x001B6148
		public Vector3 Rotation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x001B6158 File Offset: 0x001B6158
		public Vector3 Bounds
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x001B6168 File Offset: 0x001B6168
		public Vector3 MeshRotation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x001B6178 File Offset: 0x001B6178
		public float RotationInDegrees
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001760)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ExileCore2.PoEMemory.Components.Render::get_RotationInDegrees()

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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x001B6190 File Offset: 0x001B6190
		public float TerrainHeight
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001761)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ExileCore2.PoEMemory.Components.Render::get_TerrainHeight()

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
		}

		// Token: 0x040082FC RID: 33532
		private readonly CachedValue<RenderComponentOffsets> _cachedValue;
	}
}
