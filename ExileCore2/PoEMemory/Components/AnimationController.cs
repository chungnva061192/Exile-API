using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000317 RID: 791
	public class AnimationController : Component
	{
		// Token: 0x060015A5 RID: 5541 RVA: 0x001B24BC File Offset: 0x001B24BC
		public AnimationController()
		{
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x001B2540 File Offset: 0x001B2540
		public AnimationControllerOffsets Structure
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x001B2550 File Offset: 0x001B2550
		private ActiveAnimationData ActiveAnimationData
		{
			get
			{
				this;
				this;
				this;
				return this;
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x001B258C File Offset: 0x001B258C
		public float TransformProgress(float progress)
		{
			this;
			return progress;
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x001B25A0 File Offset: 0x001B25A0
		public float MaxRawAnimationProgress
		{
			get
			{
				return this - this;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x001B25BC File Offset: 0x001B25BC
		public float RawNextAnimationPoint
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x001B25CC File Offset: 0x001B25CC
		public float RawAnimationProgress
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x001B25DC File Offset: 0x001B25DC
		public float RawAnimationSpeed
		{
			get
			{
				return this * this;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x001B25F8 File Offset: 0x001B25F8
		public float TransformedMaxRawAnimationProgress
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x001B2608 File Offset: 0x001B2608
		public float TransformedRawNextAnimationPoint
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x001B2618 File Offset: 0x001B2618
		public float TransformedRawAnimationProgress
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x001B2628 File Offset: 0x001B2628
		public float AnimationSpeed
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x001B2638 File Offset: 0x001B2638
		public SupportedAnimationList SupportedAnimationList
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x001B2648 File Offset: 0x001B2648
		public int CurrentAnimationId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x001B2658 File Offset: 0x001B2658
		public int CurrentAnimationStage
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x001B2668 File Offset: 0x001B2668
		public AnimationStageList CurrentAnimation
		{
			get
			{
				/*
An exception occurred when decompiling this method (060015B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Components.AnimationStageList ExileCore2.PoEMemory.Components.AnimationController::get_CurrentAnimation()

 ---> System.Exception: Inconsistent stack size at IL_02
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x001B2708 File Offset: 0x001B2708
		public float NextAnimationPoint
		{
			get
			{
				return this / this;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x001B2718 File Offset: 0x001B2718
		public float AnimationProgress
		{
			get
			{
				return this / this;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x001B2728 File Offset: 0x001B2728
		public TimeSpan AnimationCompletesIn
		{
			get
			{
				/*
An exception occurred when decompiling this method (060015B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan ExileCore2.PoEMemory.Components.AnimationController::get_AnimationCompletesIn()

 ---> System.Exception: Inconsistent stack size at IL_0C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x001B2768 File Offset: 0x001B2768
		public TimeSpan AnimationActiveFor
		{
			get
			{
				/*
An exception occurred when decompiling this method (060015B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan ExileCore2.PoEMemory.Components.AnimationController::get_AnimationActiveFor()

 ---> System.Exception: Inconsistent stack size at IL_0A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x040082A5 RID: 33445
		private readonly CachedValue<Func<float, float>> _progressTransformFunc;

		// Token: 0x040082A6 RID: 33446
		private readonly CachedValue<float> _animationSpeed;

		// Token: 0x040082A7 RID: 33447
		private readonly CachedValue<SupportedAnimationList> _supportedAnimationList;

		// Token: 0x040082A8 RID: 33448
		private readonly CachedValue<AnimationControllerOffsets> _cachedValue;
	}
}
