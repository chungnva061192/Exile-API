using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Build.Locator;
using Serilog;

namespace Loader;

public class Loader
{
	private const string AttentionSign = "===============";

	private ILogger _logger;

	private Assembly _coreDll;

	private Stopwatch _stopwatch;

	private Type _coreType;

	private Type _performanceTimerType;

	private object _coreTypeInstance;

	private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

	public void Load(string[] args)
	{
		_stopwatch = Stopwatch.StartNew();
		try
		{
			using (new AppIcon(_cancellationTokenSource))
			{
				CheckPluginCompiler();
				RunUpdater();
				LoadCoreDll();
				if (args.Length != 0)
				{
					string command = string.Join(" ", args.Select((string x) => x.ToLower()));
					ExecuteCommand(command);
					return;
				}
				LoadLogger();
				SetupExceptionHandling();
				LogStartMessage();
				LoadCoreType();
				LoadPerformanceTimerType();
				CreateCoreTypeInstance();
				LogHudLoadedMessage();
				StartRenderLoop();
				DisposeCoreTypeInstance();
				LogCloseMessage();
			}
		}
		catch (Exception e)
		{
			LogLoaderError(e);
		}
	}

	private static void CheckPluginCompiler()
	{
		try
		{
			string text = "disable_plugin_compilation.txt";
			string path = Path.Join(AppDomain.CurrentDomain.BaseDirectory, text);
			if (File.Exists(path))
			{
				return;
			}
			List<VisualStudioInstance> source;
			try
			{
				source = MSBuildLocator.QueryVisualStudioInstances().ToList();
			}
			catch
			{
				source = new List<VisualStudioInstance>();
			}
			List<VisualStudioInstance> source2 = source.Where((VisualStudioInstance x) => x.Version.Major >= 8).ToList();
			if (!source2.Any())
			{
				switch (MissingMsBuildHelper.ShowDialogBox())
				{
				case DialogResult.Cancel:
					Environment.Exit(1);
					break;
				case DialogResult.Ignore:
					MessageBox.Show("Created " + text + " in ExileCore2's folder. To try loading the compiler again, first delete it.");
					File.Open(path, FileMode.OpenOrCreate).Dispose();
					break;
				case DialogResult.OK:
				case DialogResult.Abort:
				case DialogResult.Retry:
					break;
				}
			}
			else
			{
				MSBuildLocator.RegisterInstance(source2.First());
			}
		}
		catch (InvalidOperationException value)
		{
			if (MessageBox.Show($"There is an issue with the .NET SDK. To learn more about ways to fix this, click the YES button.\nError details: {value}", "Issue with the .NET SDK", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
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
			MessageBox.Show($"There is an issue with the .NET SDK.\nError details: {value2}", "Issue with the .NET SDK", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void SetupExceptionHandling()
	{
		AppDomain.CurrentDomain.UnhandledException += delegate(object s, UnhandledExceptionEventArgs e)
		{
			LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");
		};
		TaskScheduler.UnobservedTaskException += delegate(object? s, UnobservedTaskExceptionEventArgs e)
		{
			LogUnhandledException(e.Exception, "TaskScheduler.UnobservedTaskException");
		};
	}

	private void LogUnhandledException(Exception exception, string source)
	{
		_logger.Error($"Unhandled exception ({source}) in program: {exception}");
	}

	private void RunUpdater()
	{
		try
		{
			string text = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "HUDUpdater.dll");
			if (File.Exists(text))
			{
				CoreAssemblyLoadHelper coreAssemblyLoadHelper = new CoreAssemblyLoadHelper(text);
				AssemblyLoadContext.Default.Resolving += coreAssemblyLoadHelper.ResolvingCallback;
				AssemblyLoadContext.Default.ResolvingUnmanagedDll += coreAssemblyLoadHelper.ResolvingUnmanagedDllCallback;
				Assembly.LoadFrom(text).GetType("HUDUpdater.HudUpdater").GetMethod("RunUpdater", BindingFlags.Static | BindingFlags.Public)
					.Invoke(null, new object[1] { AppDomain.CurrentDomain.BaseDirectory });
			}
		}
		catch (Exception)
		{
		}
	}

	private void LoadCoreDll()
	{
		string text = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "ExileCore2.dll");
		CoreAssemblyLoadHelper coreAssemblyLoadHelper = new CoreAssemblyLoadHelper(text);
		AssemblyLoadContext.Default.Resolving += coreAssemblyLoadHelper.ResolvingCallback;
		AssemblyLoadContext.Default.ResolvingUnmanagedDll += coreAssemblyLoadHelper.ResolvingUnmanagedDllCallback;
		_coreDll = Assembly.LoadFrom(text);
	}

	private void ExecuteCommand(string command)
	{
		GetTypeFromCoreDll("ExileCore2.CommandExecutor").GetMethod("Execute").Invoke(null, new object[1] { command });
	}

	private void LoadLogger()
	{
		PropertyInfo propertyInfo = GetTypeFromCoreDll("ExileCore2.Logger").GetProperty("Log") ?? throw new InvalidOperationException("Not found Log property in Logger class.");
		_logger = (propertyInfo.GetValue(null) as ILogger) ?? throw new InvalidOperationException("Logger can't be null.");
	}

	private void LoadCoreType()
	{
		_coreType = GetTypeFromCoreDll("ExileCore2.Core");
		_coreType.GetProperty("Logger")?.SetValue(null, _logger);
	}

	private void CreateCoreTypeInstance()
	{
		_coreTypeInstance = Activator.CreateInstance(_coreType, _cancellationTokenSource.Token);
	}

	private void LoadPerformanceTimerType()
	{
		_performanceTimerType = GetTypeFromCoreDll("ExileCore2.Shared.Helpers.PerformanceTimer");
		_performanceTimerType.GetField("Logger").SetValue(null, _logger);
	}

	private void StartRenderLoop()
	{
		MethodInfo method = _coreType.GetMethod("Run");
		try
		{
			method.Invoke(_coreTypeInstance, null);
		}
		catch (Exception e)
		{
			LogError(e);
		}
	}

	private void LogHudLoadedMessage()
	{
		GetTypeFromCoreDll("ExileCore2.DebugWindow").GetMethod("LogMsg", new Type[3]
		{
			typeof(string),
			typeof(float),
			typeof(Color)
		}).Invoke(null, new object[3]
		{
			$"ExileCore2 Loaded in {_stopwatch.Elapsed.TotalMilliseconds} ms.",
			7,
			Color.GreenYellow
		});
	}

	private void LogError(Exception e)
	{
		GetTypeFromCoreDll("ExileCore2.DebugWindow").GetMethod("LogError").Invoke(null, new object[2]
		{
			e.ToString(),
			2
		});
	}

	private void DisposeCoreTypeInstance()
	{
		_coreType.GetMethod("Dispose").Invoke(_coreTypeInstance, null);
	}

	private Type GetTypeFromCoreDll(string name)
	{
		return _coreDll.GetType(name, throwOnError: true, ignoreCase: true);
	}

	private void LogLoaderError(Exception e)
	{
		try
		{
			if (_logger != null)
			{
				_logger.Error($"Loader -> {e}");
				LogCloseMessage();
			}
			else
			{
				Directory.CreateDirectory("Logs");
				File.WriteAllText("Logs\\Loader.txt", e.ToString());
			}
		}
		catch (Exception item)
		{
			e = new AggregateException("Failed to write error log to disk", new List<Exception> { e, item });
		}
		MessageBox.Show(e.ToString(), "Error while launching program");
	}

	private void LogStartMessage()
	{
		_logger.Information($"{"==============="} Start ExileCore2 at {DateTime.Now} {"==============="}");
	}

	private void LogCloseMessage()
	{
		_logger.Information($"{"==============="} Close ExileCore2 at {DateTime.Now} {"==============="}");
	}
}
