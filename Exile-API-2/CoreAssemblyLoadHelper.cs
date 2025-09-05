// Loader, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Loader.CoreAssemblyLoadHelper
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

internal class CoreAssemblyLoadHelper : AssemblyLoadContext
{
    private readonly string _coreAssemblyLocation;

    private readonly AssemblyDependencyResolver _resolver;

    public CoreAssemblyLoadHelper(string coreAssemblyLocation)
    {
        _coreAssemblyLocation = coreAssemblyLocation;
        _resolver = new AssemblyDependencyResolver(coreAssemblyLocation);
    }

    public Assembly ResolvingCallback(AssemblyLoadContext context, AssemblyName assemblyName)
    {
        string assemblyPath = _resolver.ResolveAssemblyToPath(assemblyName);
        if (assemblyPath == null)
        {
            string path = Path.Join(Path.GetDirectoryName(_coreAssemblyLocation), assemblyName.Name + ".dll");
            if (File.Exists(path))
            {
                assemblyPath = path;
            }
        }
        if (assemblyPath != null)
        {
            return context.LoadFromAssemblyPath(assemblyPath);
        }
        return null;
    }

    public nint ResolvingUnmanagedDllCallback(Assembly assembly, string dllName)
    {
        string path = _resolver.ResolveUnmanagedDllToPath(dllName);
        if (path != null)
        {
            return LoadUnmanagedDllFromPath(path);
        }
        return IntPtr.Zero;
    }
}
