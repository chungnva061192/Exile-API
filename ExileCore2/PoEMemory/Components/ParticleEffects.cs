using System;
using System.Collections.Generic;
using System.Numerics;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000355 RID: 853
	public class ParticleEffects : Component
	{
		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x001B55D4 File Offset: 0x001B55D4
		public Matrix4x4 Matrix
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x001B55F0 File Offset: 0x001B55F0
		public Vector3 Scale
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001703)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Numerics.Vector3 ExileCore2.PoEMemory.Components.ParticleEffects::get_Scale()

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

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x001B561C File Offset: 0x001B561C
		public List<ParticleEffects.ParticleEffect> Effects
		{
			get
			{
				this;
				this;
				this + 48L;
				return 40;
			}
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x001B5648 File Offset: 0x001B5648
		public ParticleEffects()
		{
			this;
		}

		// Token: 0x02000356 RID: 854
		public class ParticleEffect : RemoteMemoryObject
		{
			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06001706 RID: 5894 RVA: 0x001B5654 File Offset: 0x001B5654
			[Obsolete("Subject to change if I ever figure out what these are")]
			public int Id1
			{
				get
				{
					this;
					return this + 8L;
				}
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06001707 RID: 5895 RVA: 0x001B566C File Offset: 0x001B566C
			[Obsolete("Subject to change if I ever figure out what these are")]
			public int Id2
			{
				get
				{
					this;
					return this + 12L;
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06001708 RID: 5896 RVA: 0x001B5684 File Offset: 0x001B5684
			[Obsolete("Subject to change if I ever figure out what these are")]
			public int Id3
			{
				get
				{
					this;
					return this + 36L;
				}
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06001709 RID: 5897 RVA: 0x001B569C File Offset: 0x001B569C
			public string PetNames
			{
				get
				{
					this;
					this + 16L;
					int[] array = new int[]
					{
						24,
						8
					};
					return this;
				}
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x001B56D0 File Offset: 0x001B56D0
			public ParticleEffect()
			{
				this;
			}
		}
	}
}
