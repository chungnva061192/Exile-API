using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace Loader;

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
		string text = _resolver.ResolveAssemblyToPath(assemblyName);
		if (text == null)
		{
			string text2 = Path.Join(Path.GetDirectoryName(_coreAssemblyLocation), assemblyName.Name + ".dll");
			if (File.Exists(text2))
			{
				text = text2;
			}
		}
		if (text != null)
		{
			return context.LoadFromAssemblyPath(text);
		}
		return null;
	}

	public nint ResolvingUnmanagedDllCallback(Assembly assembly, string dllName)
	{
		string text = _resolver.ResolveUnmanagedDllToPath(dllName);
		if (text != null)
		{
			return LoadUnmanagedDllFromPath(text);
		}
		return IntPtr.Zero;
	}
}
