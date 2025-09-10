// Loader, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Loader.CoreAssemblyLoadHelper
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace Loader
{
    // Token: 0x02000003 RID: 3
    internal class CoreAssemblyLoadHelper : AssemblyLoadContext
    {
        // Token: 0x06000006 RID: 6 RVA: 0x00002134 File Offset: 0x00000334
        public CoreAssemblyLoadHelper(string coreAssemblyLocation)
        {
            this._coreAssemblyLocation = coreAssemblyLocation;
            this._resolver = new AssemblyDependencyResolver(coreAssemblyLocation);
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002150 File Offset: 0x00000350
        public Assembly ResolvingCallback(AssemblyLoadContext context, AssemblyName assemblyName)
        {
            string text = this._resolver.ResolveAssemblyToPath(assemblyName);
            if (text == null)
            {
                string text2 = Path.Join(Path.GetDirectoryName(this._coreAssemblyLocation), assemblyName.Name + ".dll");
                if (File.Exists(text2))
                {
                    text = text2;
                }
            }
            if (text == null)
            {
                return null;
            }
            return context.LoadFromAssemblyPath(text);
        }

        // Token: 0x06000008 RID: 8 RVA: 0x000021A4 File Offset: 0x000003A4
        public IntPtr ResolvingUnmanagedDllCallback(Assembly assembly, string dllName)
        {
            string text = this._resolver.ResolveUnmanagedDllToPath(dllName);
            if (text == null)
            {
                return IntPtr.Zero;
            }
            return base.LoadUnmanagedDllFromPath(text);
        }

        // Token: 0x04000003 RID: 3
        private readonly string _coreAssemblyLocation;

        // Token: 0x04000004 RID: 4
        private readonly AssemblyDependencyResolver _resolver;
    }
}
