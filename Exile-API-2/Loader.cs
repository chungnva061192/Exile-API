// Loader, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Loader.Loader
using Microsoft.Build.Locator;
using Serilog;
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
                        string text = string.Join(" ", args.Select((string x) => x.ToLower()));
                        this.ExecuteCommand(text);
                    }
                    else
                    {
                        this.LoadLogger();
                        this.SetupExceptionHandling();
                        this.LogStartMessage();
                        this.LoadCoreType();
                        this.LoadPerformanceTimerType();
                        this.CreateCoreTypeInstance();
                        this.LogHudLoadedMessage();
                        this.StartRenderLoop();
                        this.DisposeCoreTypeInstance();
                        this.LogCloseMessage();
                    }
                }
            }
            catch (Exception ex)
            {
                this.LogLoaderError(ex);
            }
        }

        // Token: 0x0600000A RID: 10 RVA: 0x000022B4 File Offset: 0x000004B4
        private static void CheckPluginCompiler()
        {
            try
            {
                string text = "disable_plugin_compilation.txt";
                string text2 = Path.Join(AppDomain.CurrentDomain.BaseDirectory, text);
                if (!File.Exists(text2))
                {
                    List<VisualStudioInstance> list;
                    try
                    {
                        list = MSBuildLocator.QueryVisualStudioInstances().ToList<VisualStudioInstance>();
                    }
                    catch
                    {
                        list = new List<VisualStudioInstance>();
                    }
                    List<VisualStudioInstance> list2 = list.Where((VisualStudioInstance x) => x.Version.Major >= 8).ToList<VisualStudioInstance>();
                    if (!list2.Any<VisualStudioInstance>())
                    {
                        switch (MissingMsBuildHelper.ShowDialogBox())
                        {
                            case DialogResult.Cancel:
                                Environment.Exit(1);
                                break;
                            case DialogResult.Ignore:
                                MessageBox.Show("Created " + text + " in ExileCore2's folder. To try loading the compiler again, first delete it.");
                                File.Open(text2, FileMode.OpenOrCreate).Dispose();
                                break;
                        }
                    }
                    else
                    {
                        MSBuildLocator.RegisterInstance(list2.First<VisualStudioInstance>());
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(112, 1);
                defaultInterpolatedStringHandler.AppendLiteral("There is an issue with the .NET SDK. To learn more about ways to fix this, click the YES button.\nError details: ");
                defaultInterpolatedStringHandler.AppendFormatted<InvalidOperationException>(ex);
                if (MessageBox.Show(defaultInterpolatedStringHandler.ToStringAndClear(), "Issue with the .NET SDK", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://github.com/dotnet/sdk/issues/14139#issuecomment-1510555315",
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex2)
            {
                DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 1);
                defaultInterpolatedStringHandler.AppendLiteral("There is an issue with the .NET SDK.\nError details: ");
                defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex2);
                MessageBox.Show(defaultInterpolatedStringHandler.ToStringAndClear(), "Issue with the .NET SDK", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        // Token: 0x0600000B RID: 11 RVA: 0x00002448 File Offset: 0x00000648
        private void SetupExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException += delegate (object s, UnhandledExceptionEventArgs e)
            {
                this.LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");
            };
            TaskScheduler.UnobservedTaskException += delegate (object s, UnobservedTaskExceptionEventArgs e)
            {
                this.LogUnhandledException(e.Exception, "TaskScheduler.UnobservedTaskException");
            };
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002474 File Offset: 0x00000674
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

        // Token: 0x0600000D RID: 13 RVA: 0x000024C8 File Offset: 0x000006C8
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
                        .Invoke(null, new object[] { AppDomain.CurrentDomain.BaseDirectory });
                }
            }
            catch (Exception)
            {
            }
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00002570 File Offset: 0x00000770
        private void LoadCoreDll()
        {
            string text = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "ExileCore2.dll");
            CoreAssemblyLoadHelper coreAssemblyLoadHelper = new CoreAssemblyLoadHelper(text);
            AssemblyLoadContext.Default.Resolving += coreAssemblyLoadHelper.ResolvingCallback;
            AssemblyLoadContext.Default.ResolvingUnmanagedDll += coreAssemblyLoadHelper.ResolvingUnmanagedDllCallback;
            this._coreDll = Assembly.LoadFrom(text);
        }

        // Token: 0x0600000F RID: 15 RVA: 0x000025D1 File Offset: 0x000007D1
        private void ExecuteCommand(string command)
        {
            this.GetTypeFromCoreDll("ExileCore2.CommandExecutor").GetMethod("Execute").Invoke(null, new object[] { command });
        }

        // Token: 0x06000010 RID: 16 RVA: 0x000025FC File Offset: 0x000007FC
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

        // Token: 0x06000011 RID: 17 RVA: 0x0000264F File Offset: 0x0000084F
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

        // Token: 0x06000012 RID: 18 RVA: 0x00002683 File Offset: 0x00000883
        private void CreateCoreTypeInstance()
        {
            this._coreTypeInstance = Activator.CreateInstance(this._coreType, new object[] { this._cancellationTokenSource.Token });
        }

        // Token: 0x06000013 RID: 19 RVA: 0x000026AF File Offset: 0x000008AF
        private void LoadPerformanceTimerType()
        {
            this._performanceTimerType = this.GetTypeFromCoreDll("ExileCore2.Shared.Helpers.PerformanceTimer");
            this._performanceTimerType.GetField("Logger").SetValue(null, this._logger);
        }

        // Token: 0x06000014 RID: 20 RVA: 0x000026E0 File Offset: 0x000008E0
        private void StartRenderLoop()
        {
            MethodInfo method = this._coreType.GetMethod("Run");
            try
            {
                method.Invoke(this._coreTypeInstance, null);
            }
            catch (Exception ex)
            {
                this.LogError(ex);
            }
        }

        // Token: 0x06000015 RID: 21 RVA: 0x00002728 File Offset: 0x00000928
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
            DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
            defaultInterpolatedStringHandler.AppendLiteral("ExileCore2 Loaded in ");
            defaultInterpolatedStringHandler.AppendFormatted<double>(this._stopwatch.Elapsed.TotalMilliseconds);
            defaultInterpolatedStringHandler.AppendLiteral(" ms.");
            array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
            array[1] = 7;
            array[2] = Color.GreenYellow;
            method.Invoke(obj, array);
        }

        // Token: 0x06000016 RID: 22 RVA: 0x000027E0 File Offset: 0x000009E0
        private void LogError(Exception e)
        {
            this.GetTypeFromCoreDll("ExileCore2.DebugWindow").GetMethod("LogError").Invoke(null, new object[]
            {
                e.ToString(),
                2
            });
        }

        // Token: 0x06000017 RID: 23 RVA: 0x00002816 File Offset: 0x00000A16
        private void DisposeCoreTypeInstance()
        {
            this._coreType.GetMethod("Dispose").Invoke(this._coreTypeInstance, null);
        }

        // Token: 0x06000018 RID: 24 RVA: 0x00002835 File Offset: 0x00000A35
        private Type GetTypeFromCoreDll(string name)
        {
            return this._coreDll.GetType(name, true, true);
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00002848 File Offset: 0x00000A48
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
            catch (Exception ex)
            {
                e = new AggregateException("Failed to write error log to disk", new List<Exception> { e, ex });
            }
            MessageBox.Show(e.ToString(), "Error while launching program");
        }

        // Token: 0x0600001A RID: 26 RVA: 0x000028F4 File Offset: 0x00000AF4
        private void LogStartMessage()
        {
            ILogger logger = this._logger;
            DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
            defaultInterpolatedStringHandler.AppendFormatted("===============");
            defaultInterpolatedStringHandler.AppendLiteral(" Start ExileCore2 at ");
            defaultInterpolatedStringHandler.AppendFormatted<DateTime>(DateTime.Now);
            defaultInterpolatedStringHandler.AppendLiteral(" ");
            defaultInterpolatedStringHandler.AppendFormatted("===============");
            logger.Information(defaultInterpolatedStringHandler.ToStringAndClear());
        }

        // Token: 0x0600001B RID: 27 RVA: 0x0000295C File Offset: 0x00000B5C
        private void LogCloseMessage()
        {
            ILogger logger = this._logger;
            DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
            defaultInterpolatedStringHandler.AppendFormatted("===============");
            defaultInterpolatedStringHandler.AppendLiteral(" Close ExileCore2 at ");
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