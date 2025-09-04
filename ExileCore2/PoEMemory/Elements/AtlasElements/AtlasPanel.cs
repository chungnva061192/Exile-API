using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Cache;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Elements.AtlasElements
{
	// Token: 0x02000308 RID: 776
	public class AtlasPanel : Element
	{
		// Token: 0x06001549 RID: 5449 RVA: 0x001B170C File Offset: 0x001B170C
		public AtlasPanel()
		{
			this;
			this;
			this;
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x001B1724 File Offset: 0x001B1724
		public List<AtlasNodeDescription> Descriptions
		{
			get
			{
				this;
				this;
				return 32;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x001B1748 File Offset: 0x001B1748
		public List<ValueTuple<Vector2i, Vector2i, Vector2i, Vector2i, Vector2i>> Points
		{
			get
			{
				this;
				this;
				return 40;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x001B176C File Offset: 0x001B176C
		public List<AtlasEffectSource> EffectSources
		{
			get
			{
				this;
				this;
				return 32;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x001B1790 File Offset: 0x001B1790
		public AtlasCameraHelper CameraHelper
		{
			get
			{
				AtlasPanel atlasPanel = this + this;
				int[] array = new int[2];
				array[array] = 0;
				atlasPanel[atlasPanel] = 1;
				return this;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x001B17C8 File Offset: 0x001B17C8
		public Camera Camera
		{
			get
			{
				this;
				Camera result = this + this;
				int[] array = new int[1];
				array[array] = 0;
				return result;
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x001B17F8 File Offset: 0x001B17F8
		// Note: this type is marked as 'beforefieldinit'.
		static AtlasPanel()
		{
			/*
An exception occurred when decompiling this method (0600154F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.Elements.AtlasElements.AtlasPanel::.cctor()

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

		// Token: 0x04008286 RID: 33414
		private readonly FrameCache<AtlasPanelOffsets> _cache;

		// Token: 0x04008287 RID: 33415
		private static readonly int CameraOffset1;

		// Token: 0x04008288 RID: 33416
		private static readonly int CameraOffset2;

		// Token: 0x04008289 RID: 33417
		private static readonly int CameraOffset3;

		// Token: 0x0400828A RID: 33418
		private static readonly int CameraOffset4;
	}
}
