using System;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x02000200 RID: 512
	public class QuestState : RemoteMemoryObject
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x001A161C File Offset: 0x001A161C
		public QuestStateOffsets QuestStateOffsets
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x001A1630 File Offset: 0x001A1630
		public long QuestPtr
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x001A1640 File Offset: 0x001A1640
		public Quest Quest
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x001A165C File Offset: 0x001A165C
		public int QuestStateId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x001A166C File Offset: 0x001A166C
		public string QuestStateText
		{
			get
			{
				this;
				this;
				return 1;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x001A168C File Offset: 0x001A168C
		public string QuestProgressText
		{
			get
			{
				this;
				this;
				return 1;
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x001A16AC File Offset: 0x001A16AC
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000F61)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.QuestState::ToString()

 ---> System.Exception: Inconsistent stack size at IL_25
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x001A1748 File Offset: 0x001A1748
		public QuestState()
		{
			this;
		}
	}
}
