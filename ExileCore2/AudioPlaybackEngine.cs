using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace ExileCore2
{
	// Token: 0x020000AC RID: 172
	internal class AudioPlaybackEngine : IDisposable
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x0017EF80 File Offset: 0x0017EF80
		public AudioPlaybackEngine(int sampleRate = 44100, int channelCount = 2)
		{
			this;
			this;
			this;
			sampleRate;
			channelCount;
			1;
			this;
			this;
			0;
			this;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0017EFDC File Offset: 0x0017EFDC
		private ISampleProvider ConvertToRightChannelCount(ISampleProvider input)
		{
			/*
An exception occurred when decompiling this method (060004EC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling NAudio.Wave.ISampleProvider ExileCore2.AudioPlaybackEngine::ConvertToRightChannelCount(NAudio.Wave.ISampleProvider)

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

		// Token: 0x060004ED RID: 1261 RVA: 0x0017F050 File Offset: 0x0017F050
		public void PlaySound(CachedSound sound)
		{
			this;
			sound;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0017F060 File Offset: 0x0017F060
		private void AddMixerInput(ISampleProvider input)
		{
			this;
			this;
			input;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0017F078 File Offset: 0x0017F078
		public void Dispose()
		{
			this;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0017F088 File Offset: 0x0017F088
		public void SetVolume(float volume)
		{
			this;
			volume;
		}

		// Token: 0x040002F8 RID: 760
		private readonly IWavePlayer _outputDevice;

		// Token: 0x040002F9 RID: 761
		private readonly MixingSampleProvider _mixer;
	}
}
