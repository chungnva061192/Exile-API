using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ExileCore2.Shared.Nodes
{
	// Token: 0x0200010E RID: 270
	public static class JsonSerializationHelper
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x0018B10C File Offset: 0x0018B10C
		public static JsonSerializer Unwrap(JsonSerializer serializer)
		{
			/*
An exception occurred when decompiling this method (06000848)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonSerializer ExileCore2.Shared.Nodes.JsonSerializationHelper::Unwrap(Newtonsoft.Json.JsonSerializer)

 ---> System.Exception: Inconsistent stack size at IL_0E
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0018B168 File Offset: 0x0018B168
		public static T DeserializeDefaultValue<T>(JsonReader reader, Type objectType, T existingValue, JsonSerializer serializer)
		{
			object obj = JsonSerializationHelper.IntSerMethod.Invoke(serializer, Array.Empty<object>());
			JsonContract jsonContract = serializer.ContractResolver.ResolveContract(objectType);
			return (T)((object)JsonSerializationHelper.CreateMethod.Invoke(obj, new object[]
			{
				reader,
				objectType,
				jsonContract,
				null,
				null,
				null,
				existingValue
			}));
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0018B1C8 File Offset: 0x0018B1C8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializationHelper()
		{
			typeof(JsonReader).TypeHandle;
			"Newtonsoft.Json.Serialization.JsonSerializerProxy";
			typeof(JsonReader).TypeHandle;
			"Newtonsoft.Json.Serialization.JsonSerializerInternalReader";
			"GetInternalSerializer";
			36;
			"CreateValueInternal";
			36;
			"_serializer";
			36;
		}

		// Token: 0x04000449 RID: 1097
		private static readonly Type SerializerProxyType;

		// Token: 0x0400044A RID: 1098
		private static readonly Type InternalSerializerType;

		// Token: 0x0400044B RID: 1099
		private static readonly MethodInfo IntSerMethod;

		// Token: 0x0400044C RID: 1100
		private static readonly MethodInfo CreateMethod;

		// Token: 0x0400044D RID: 1101
		private static readonly FieldInfo UnwrappedSerializerField;
	}
}
