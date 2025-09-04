using System;
using ExileCore2.PoEMemory.MemoryObjects;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000333 RID: 819
	public class DeployedObject : StructuredRemoteMemoryObject<ActorDeployedObjectOffsets>
	{
		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x001B3928 File Offset: 0x001B3928
		public uint ObjectId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x001B3938 File Offset: 0x001B3938
		public ushort SkillKey
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x001B3948 File Offset: 0x001B3948
		public ushort SkillKey2
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x001B3958 File Offset: 0x001B3958
		public Entity Entity
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600164C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.MemoryObjects.Entity ExileCore2.PoEMemory.Components.DeployedObject::get_Entity()

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
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x001B3984 File Offset: 0x001B3984
		public override string ToString()
		{
			7;
			4;
			this;
			"/";
			this;
			" -> ";
			this;
			"(";
			this;
			return ")";
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x001B3A10 File Offset: 0x001B3A10
		public DeployedObject()
		{
			this;
		}

		// Token: 0x040082C6 RID: 33478
		private Entity _entity;
	}
}
