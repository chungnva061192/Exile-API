using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2
{
	// Token: 0x0200009D RID: 157
	public class SettingsHolder : ISettingsHolder
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0017D8EC File Offset: 0x0017D8EC
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0017D8F4 File Offset: 0x0017D8F4
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0017D900 File Offset: 0x0017D900
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0017D908 File Offset: 0x0017D908
		public string Tooltip
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0017D914 File Offset: 0x0017D914
		public string Unique
		{
			get
			{
				2;
				2;
				this;
				"##";
				return this;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0017D95C File Offset: 0x0017D95C
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0017D964 File Offset: 0x0017D964
		public int ID
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0017D970 File Offset: 0x0017D970
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0017D978 File Offset: 0x0017D978
		public Action DrawDelegate
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0017D984 File Offset: 0x0017D984
		public IList<ISettingsHolder> Children
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0017D98C File Offset: 0x0017D98C
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0017D994 File Offset: 0x0017D994
		public bool ChildrenAreSearchable
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0017D9A0 File Offset: 0x0017D9A0
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0017D9A8 File Offset: 0x0017D9A8
		public Func<bool> DisplayCondition
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0017D9B4 File Offset: 0x0017D9B4
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x0017D9BC File Offset: 0x0017D9BC
		public bool CollapsedByDefault
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0017D9C8 File Offset: 0x0017D9C8
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x0017D9D0 File Offset: 0x0017D9D0
		public bool EnableSelfDrawCollapsing
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0017D9DC File Offset: 0x0017D9DC
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x0017D9E4 File Offset: 0x0017D9E4
		public bool EnableCollapsing
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0017D9F0 File Offset: 0x0017D9F0
		public void Draw()
		{
			/*
An exception occurred when decompiling this method (060004AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.SettingsHolder::Draw()

 ---> System.Exception: Inconsistent stack size at IL_07
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0017DC94 File Offset: 0x0017DC94
		public SettingsHolder()
		{
			this;
			"";
			this;
			"";
			this;
			-1;
			this;
			this;
			1;
			this;
			1;
			this;
		}
	}
}
