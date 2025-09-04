using System;
using System.Numerics;
using ExileCore2.Shared.Cache;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200035D RID: 861
	public class Positioned : Component
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x001B5E2C File Offset: 0x001B5E2C
		public Positioned()
		{
			this;
			this;
			this;
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x001B5E50 File Offset: 0x001B5E50
		public PositionedComponentOffsets PositionedStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x001B5E60 File Offset: 0x001B5E60
		public new long OwnerAddress
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x001B5E70 File Offset: 0x001B5E70
		public int GridX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x001B5E80 File Offset: 0x001B5E80
		public int GridY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x001B5E90 File Offset: 0x001B5E90
		public Vector2 GridPos
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x001B5EA8 File Offset: 0x001B5EA8
		public Vector2i GridPosI
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x001B5EBC File Offset: 0x001B5EBC
		public Vector2 WorldPos
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x001B5ECC File Offset: 0x001B5ECC
		public Vector2 TravelTarget
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x001B5EDC File Offset: 0x001B5EDC
		public Vector2 TravelStart
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x001B5EEC File Offset: 0x001B5EEC
		public float TravelProgress
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x001B5EFC File Offset: 0x001B5EFC
		public Vector2i GridPosition
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x001B5F0C File Offset: 0x001B5F0C
		public float Rotation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x001B5F1C File Offset: 0x001B5F1C
		public float WorldX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x001B5F2C File Offset: 0x001B5F2C
		public float WorldY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x001B5F3C File Offset: 0x001B5F3C
		public float RotationDeg
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001748)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ExileCore2.PoEMemory.Components.Positioned::get_RotationDeg()

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

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x001B5F4C File Offset: 0x001B5F4C
		public byte Reaction
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x001B5F5C File Offset: 0x001B5F5C
		public int Size
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x001B5F6C File Offset: 0x001B5F6C
		public float Scale
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040082FB RID: 33531
		private readonly CachedValue<PositionedComponentOffsets> _cachedValue;
	}
}
