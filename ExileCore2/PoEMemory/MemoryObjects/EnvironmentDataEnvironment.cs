using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001CB RID: 459
	public class EnvironmentDataEnvironment : RemoteMemoryObject
	{
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0019AEC4 File Offset: 0x0019AEC4
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x0019AECC File Offset: 0x0019AECC
		public long EnvironmentDataAddress
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			internal set
			{
				this;
				value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0019AED8 File Offset: 0x0019AED8
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x0019AEE0 File Offset: 0x0019AEE0
		public Dictionary<long, DefaultEnvironmentSetting> DefaultSettings
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			internal set
			{
				this;
				value;
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0019AEEC File Offset: 0x0019AEEC
		public EnvironmentDataEnvironment()
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
			this;
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0019B000 File Offset: 0x0019B000
		public string Name
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0019B010 File Offset: 0x0019B010
		private int GetTypeNDefaultDataOffset(int n)
		{
			new int[10];
			return (n - 1) * 8 + 24;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0019B038 File Offset: 0x0019B038
		public TypedEnvironmentData<Type1EnvironmentSettingsOffsets> Type1Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0019B048 File Offset: 0x0019B048
		public TypedEnvironmentData<Type2EnvironmentSettingsOffsets> Type2Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0019B058 File Offset: 0x0019B058
		public TypedEnvironmentData<Type3EnvironmentSettingsOffsets> Type3Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0019B068 File Offset: 0x0019B068
		public TypedEnvironmentData<Type4EnvironmentSettingsOffsets> Type4Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0019B078 File Offset: 0x0019B078
		public TypedEnvironmentData<Type5EnvironmentSettingsOffsets> Type5Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0019B088 File Offset: 0x0019B088
		public TypedEnvironmentData<Type6EnvironmentSettingsOffsets> Type6Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0019B098 File Offset: 0x0019B098
		public TypedEnvironmentData<Type7PlusEnvironmentSettingsOffsets> Type7Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0019B0A8 File Offset: 0x0019B0A8
		public TypedEnvironmentData<Type7PlusEnvironmentSettingsOffsets> Type8Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0019B0B8 File Offset: 0x0019B0B8
		public TypedEnvironmentData<Type7PlusEnvironmentSettingsOffsets> Type9Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0019B0C8 File Offset: 0x0019B0C8
		public TypedEnvironmentData<Type7PlusEnvironmentSettingsOffsets> Type10Settings
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0019B0D8 File Offset: 0x0019B0D8
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000D40)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.EnvironmentDataEnvironment::ToString()

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

		// Token: 0x04007F57 RID: 32599
		private readonly CachedValue<string> _nameCache;

		// Token: 0x04007F58 RID: 32600
		private readonly CachedValue<TypedEnvironmentData<Type1EnvironmentSettingsOffsets>> _type1Cache;

		// Token: 0x04007F59 RID: 32601
		private readonly CachedValue<TypedEnvironmentData<Type2EnvironmentSettingsOffsets>> _type2Cache;

		// Token: 0x04007F5A RID: 32602
		private readonly CachedValue<TypedEnvironmentData<Type3EnvironmentSettingsOffsets>> _type3Cache;

		// Token: 0x04007F5B RID: 32603
		private readonly CachedValue<TypedEnvironmentData<Type4EnvironmentSettingsOffsets>> _type4Cache;

		// Token: 0x04007F5C RID: 32604
		private readonly CachedValue<TypedEnvironmentData<Type5EnvironmentSettingsOffsets>> _type5Cache;

		// Token: 0x04007F5D RID: 32605
		private readonly CachedValue<TypedEnvironmentData<Type6EnvironmentSettingsOffsets>> _type6Cache;

		// Token: 0x04007F5E RID: 32606
		private readonly CachedValue<TypedEnvironmentData<Type7PlusEnvironmentSettingsOffsets>> _type7Cache;

		// Token: 0x04007F5F RID: 32607
		private readonly CachedValue<TypedEnvironmentData<Type7PlusEnvironmentSettingsOffsets>> _type8Cache;

		// Token: 0x04007F60 RID: 32608
		private readonly CachedValue<TypedEnvironmentData<Type7PlusEnvironmentSettingsOffsets>> _type9Cache;

		// Token: 0x04007F61 RID: 32609
		private readonly CachedValue<TypedEnvironmentData<Type7PlusEnvironmentSettingsOffsets>> _type10Cache;

		// Token: 0x04007F62 RID: 32610
		private const int EnvironmentNameSize = 32;
	}
}
