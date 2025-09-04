using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Build.Locator;
using Serilog;

namespace Loader
{
	// Token: 0x02000004 RID: 4
	public class Loader
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000021D0 File Offset: 0x000003D0
		public void Load(string[] args)
		{
			this._stopwatch = Stopwatch.StartNew();
			try
			{
				using (new AppIcon(this._cancellationTokenSource))
				{
					Loader.CheckPluginCompiler();
					this.RunUpdater();
					this.LoadCoreDll();
					if (args.Length != 0)
					{
						string command = string.Join(" ", from x in args
						select x.ToLower());
						this.ExecuteCommand(command);
					}
					else
					{
						this.LoadLogger();
						this.SetupExceptionHandling();
						this.LogStartMessage();
						this.LoadCoreType();
						this.LoadPerformanceTimerType();
						this.CreateOffsets();
						this.CreateCoreTypeInstance();
						this.LogHudLoadedMessage();
						this.StartRenderLoop();
						this.DisposeCoreTypeInstance();
						this.LogCloseMessage();
					}
				}
			}
			catch (Exception e)
			{
				this.LogLoaderError(e);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022B8 File Offset: 0x000004B8
		private static void CheckPluginCompiler()
		{
			try
			{
				string text = "disable_plugin_compilation.txt";
				string path = Path.Join(AppDomain.CurrentDomain.BaseDirectory, text);
				if (!File.Exists(path))
				{
					List<VisualStudioInstance> source;
					try
					{
						source = MSBuildLocator.QueryVisualStudioInstances().ToList<VisualStudioInstance>();
					}
					catch
					{
						source = new List<VisualStudioInstance>();
					}
					List<VisualStudioInstance> source2 = (from x in source
					where x.Version.Major >= 8
					select x).ToList<VisualStudioInstance>();
					if (!source2.Any<VisualStudioInstance>())
					{
						switch (MissingMsBuildHelper.ShowDialogBox())
						{
						case DialogResult.Cancel:
							Environment.Exit(1);
							break;
						case DialogResult.Ignore:
							MessageBox.Show("Created " + text + " in HUD's folder. To try loading the compiler again, first delete it.");
							File.Open(path, FileMode.OpenOrCreate).Dispose();
							break;
						}
					}
					else
					{
						MSBuildLocator.RegisterInstance(source2.First<VisualStudioInstance>());
					}
				}
			}
			catch (InvalidOperationException value)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(112, 1);
				defaultInterpolatedStringHandler.AppendLiteral("There is an issue with the .NET SDK. To learn more about ways to fix this, click the YES button.\nError details: ");
				defaultInterpolatedStringHandler.AppendFormatted<InvalidOperationException>(value);
				if (MessageBox.Show(defaultInterpolatedStringHandler.ToStringAndClear(), "Issue with the .NET SDK", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = "https://github.com/dotnet/sdk/issues/14139#issuecomment-1510555315",
						UseShellExecute = true
					});
				}
			}
			catch (Exception value2)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 1);
				defaultInterpolatedStringHandler.AppendLiteral("There is an issue with the .NET SDK.\nError details: ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(value2);
				MessageBox.Show(defaultInterpolatedStringHandler.ToStringAndClear(), "Issue with the .NET SDK", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000244C File Offset: 0x0000064C
		private void SetupExceptionHandling()
		{
			AppDomain.CurrentDomain.UnhandledException += delegate(object s, UnhandledExceptionEventArgs e)
			{
				this.LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");
			};
			TaskScheduler.UnobservedTaskException += delegate(object s, UnobservedTaskExceptionEventArgs e)
			{
				this.LogUnhandledException(e.Exception, "TaskScheduler.UnobservedTaskException");
			};
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002478 File Offset: 0x00000678
		private void LogUnhandledException(Exception exception, string source)
		{
			ILogger logger = this._logger;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Unhandled exception (");
			defaultInterpolatedStringHandler.AppendFormatted(source);
			defaultInterpolatedStringHandler.AppendLiteral(") in program: ");
			defaultInterpolatedStringHandler.AppendFormatted<Exception>(exception);
			logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000024CC File Offset: 0x000006CC
		private void RunUpdater()
		{
			try
			{
				string text = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "HUDUpdater.dll");
				if (File.Exists(text))
				{
					CoreAssemblyLoadHelper @object = new CoreAssemblyLoadHelper(text);
					AssemblyLoadContext.Default.Resolving += @object.ResolvingCallback;
					AssemblyLoadContext.Default.ResolvingUnmanagedDll += @object.ResolvingUnmanagedDllCallback;
					Assembly.LoadFrom(text).GetType("HUDUpdater.HudUpdater").GetMethod("RunUpdater", BindingFlags.Static | BindingFlags.Public).Invoke(null, new object[]
					{
						AppDomain.CurrentDomain.BaseDirectory
					});
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002574 File Offset: 0x00000774
		private void LoadCoreDll()
		{
			string text = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "ExileCore2.dll");
			CoreAssemblyLoadHelper @object = new CoreAssemblyLoadHelper(text);
			AssemblyLoadContext.Default.Resolving += @object.ResolvingCallback;
			AssemblyLoadContext.Default.ResolvingUnmanagedDll += @object.ResolvingUnmanagedDllCallback;
			this._coreDll = Assembly.LoadFrom(text);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000025D5 File Offset: 0x000007D5
		private void ExecuteCommand(string command)
		{
			this.GetTypeFromCoreDll("ExileCore2.CommandExecutor").GetMethod("Execute").Invoke(null, new object[]
			{
				command
			});
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002600 File Offset: 0x00000800
		private void LoadLogger()
		{
			PropertyInfo property = this.GetTypeFromCoreDll("ExileCore2.Logger").GetProperty("Log");
			if (property == null)
			{
				throw new InvalidOperationException("Not found Log property in Logger class.");
			}
			PropertyInfo propertyInfo = property;
			ILogger logger = propertyInfo.GetValue(null) as ILogger;
			if (logger == null)
			{
				throw new InvalidOperationException("Logger can't be null.");
			}
			this._logger = logger;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002653 File Offset: 0x00000853
		private void LoadCoreType()
		{
			this._coreType = this.GetTypeFromCoreDll("ExileCore2.Core");
			PropertyInfo property = this._coreType.GetProperty("Logger");
			if (property == null)
			{
				return;
			}
			property.SetValue(null, this._logger);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002687 File Offset: 0x00000887
		private void CreateOffsets()
		{
			this.MeasurePerformance("Create new offsets", delegate
			{
				this.ExecuteCommand("loader_offsets");
			});
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000026A0 File Offset: 0x000008A0
		private void CreateCoreTypeInstance()
		{
			this._coreTypeInstance = Activator.CreateInstance(this._coreType, new object[]
			{
				this._cancellationTokenSource.Token
			});
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000026CC File Offset: 0x000008CC
		private void MeasurePerformance(string actionName, Action action)
		{
			MethodBase method = this._performanceTimerType.GetMethod("Dispose");
			object obj = this.CreatePerformanceTimer(actionName);
			action();
			method.Invoke(obj, null);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026FF File Offset: 0x000008FF
		private void LoadPerformanceTimerType()
		{
			this._performanceTimerType = this.GetTypeFromCoreDll("ExileCore2.Shared.Helpers.PerformanceTimer");
			this._performanceTimerType.GetField("Logger").SetValue(null, this._logger);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000272E File Offset: 0x0000092E
		private object CreatePerformanceTimer(string debugText)
		{
			return Activator.CreateInstance(this._performanceTimerType, new object[]
			{
				debugText,
				0,
				null,
				true
			});
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002758 File Offset: 0x00000958
		private void StartRenderLoop()
		{
			MethodInfo method = this._coreType.GetMethod("Run");
			try
			{
				method.Invoke(this._coreTypeInstance, null);
			}
			catch (Exception e)
			{
				this.LogError(e);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027A0 File Offset: 0x000009A0
		private void LogHudLoadedMessage()
		{
			MethodBase method = this.GetTypeFromCoreDll("ExileCore2.DebugWindow").GetMethod("LogMsg", new Type[]
			{
				typeof(string),
				typeof(float),
				typeof(Color)
			});
			object obj = null;
			object[] array = new object[3];
			int num = 0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("HUD loaded in ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this._stopwatch.Elapsed.TotalMilliseconds);
			defaultInterpolatedStringHandler.AppendLiteral(" ms.");
			array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[1] = 7;
			array[2] = Color.GreenYellow;
			method.Invoke(obj, array);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002858 File Offset: 0x00000A58
		private void LogError(Exception e)
		{
			this.GetTypeFromCoreDll("ExileCore2.DebugWindow").GetMethod("LogError").Invoke(null, new object[]
			{
				e.ToString(),
				2
			});
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000288E File Offset: 0x00000A8E
		private void DisposeCoreTypeInstance()
		{
			this._coreType.GetMethod("Dispose").Invoke(this._coreTypeInstance, null);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000028AD File Offset: 0x00000AAD
		private Type GetTypeFromCoreDll(string name)
		{
			return this._coreDll.GetType(name, true, true);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000028C0 File Offset: 0x00000AC0
		private void LogLoaderError(Exception e)
		{
			try
			{
				if (this._logger != null)
				{
					ILogger logger = this._logger;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Loader -> ");
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(e);
					logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
					this.LogCloseMessage();
				}
				else
				{
					Directory.CreateDirectory("Logs");
					File.WriteAllText("Logs\\Loader.txt", e.ToString());
				}
			}
			catch (Exception item)
			{
				e = new AggregateException("Failed to write error log to disk", new List<Exception>
				{
					e,
					item
				});
			}
			MessageBox.Show(e.ToString(), "Error while launching program");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000296C File Offset: 0x00000B6C
		private void LogStartMessage()
		{
			ILogger logger = this._logger;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 3);
			defaultInterpolatedStringHandler.AppendFormatted("===============");
			defaultInterpolatedStringHandler.AppendLiteral(" Start hud at ");
			defaultInterpolatedStringHandler.AppendFormatted<DateTime>(DateTime.Now);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted("===============");
			logger.Information(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000029D4 File Offset: 0x00000BD4
		private void LogCloseMessage()
		{
			ILogger logger = this._logger;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 3);
			defaultInterpolatedStringHandler.AppendFormatted("===============");
			defaultInterpolatedStringHandler.AppendLiteral(" Close hud at ");
			defaultInterpolatedStringHandler.AppendFormatted<DateTime>(DateTime.Now);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted("===============");
			logger.Information(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x04000005 RID: 5
		private const string AttentionSign = "===============";

		// Token: 0x04000006 RID: 6
		private ILogger _logger;

		// Token: 0x04000007 RID: 7
		private Assembly _coreDll;

		// Token: 0x04000008 RID: 8
		private Stopwatch _stopwatch;

		// Token: 0x04000009 RID: 9
		private Type _coreType;

		// Token: 0x0400000A RID: 10
		private Type _performanceTimerType;

		// Token: 0x0400000B RID: 11
		private object _coreTypeInstance;

		// Token: 0x0400000C RID: 12
		private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
	}
}
