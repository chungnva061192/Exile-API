using System;
using System.Collections.Generic;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200036F RID: 879
	public class SoundEvents : Component
	{
		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x001B69D4 File Offset: 0x001B69D4
		public List<SoundEvents.SoundEvent> Events
		{
			get
			{
				this;
				this;
				this + 88L;
				32;
				return this;
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x001B6A10 File Offset: 0x001B6A10
		public SoundEvents()
		{
			this;
		}

		// Token: 0x02000370 RID: 880
		public class SoundEvent : RemoteMemoryObject
		{
			// Token: 0x17000949 RID: 2377
			// (get) Token: 0x06001798 RID: 6040 RVA: 0x001B6A1C File Offset: 0x001B6A1C
			public string Name
			{
				get
				{
					this;
					this + 64L;
					return this;
				}
			}

			// Token: 0x06001799 RID: 6041 RVA: 0x001B6A40 File Offset: 0x001B6A40
			public override string ToString()
			{
				/*
An exception occurred when decompiling this method (06001799)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.SoundEvents/SoundEvent::ToString()

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

			// Token: 0x0600179A RID: 6042 RVA: 0x001B6A64 File Offset: 0x001B6A64
			public SoundEvent()
			{
				this;
			}
		}
	}
}
