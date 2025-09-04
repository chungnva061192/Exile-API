using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ExileCore2.PoEMemory;
using ExileCore2.Shared.Enums;
using GameOffsets2.Native;

namespace ExileCore2.Shared.Interfaces
{
	// Token: 0x02000119 RID: 281
	public interface IMemory : IDisposable
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000885 RID: 2181
		IntPtr MainWindowHandle { get; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000886 RID: 2182
		IntPtr OpenProcessHandle { get; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000887 RID: 2183
		long AddressOfProcess { get; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000888 RID: 2184
		Dictionary<OffsetsName, long> BaseOffsets { get; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000889 RID: 2185
		Process Process { get; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600088A RID: 2186
		// (set) Token: 0x0600088B RID: 2187
		MemoryBackendMode BackendMode { get; set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600088C RID: 2188
		// (set) Token: 0x0600088D RID: 2189
		IMemoryBackend CustomBackend { get; set; }

		// Token: 0x0600088E RID: 2190
		string ReadString(long addr, int length = 256, bool replaceNull = true);

		// Token: 0x0600088F RID: 2191
		string ReadNativeString(long addr);

		// Token: 0x06000890 RID: 2192
		string ReadStringU(long addr, int lengthBytes = 256, bool replaceNull = true);

		// Token: 0x06000891 RID: 2193
		byte[] ReadMem(long addr, int size);

		// Token: 0x06000892 RID: 2194
		byte[] ReadMem(IntPtr addr, int size);

		// Token: 0x06000893 RID: 2195
		T[] ReadMem<[IsUnmanaged] T>(long addr, int size) where T : struct, ValueType;

		// Token: 0x06000894 RID: 2196
		T[] ReadMem<[IsUnmanaged] T>(IntPtr address, int size) where T : struct, ValueType;

		// Token: 0x06000895 RID: 2197
		byte[] ReadBytes(long addr, int size);

		// Token: 0x06000896 RID: 2198
		byte[] ReadBytes(long addr, long size);

		// Token: 0x06000897 RID: 2199
		List<T> ReadStructsArray<T>(long startAddress, long endAddress, int structSize, RemoteMemoryObject game) where T : RemoteMemoryObject, new();

		// Token: 0x06000898 RID: 2200
		List<T> ReadStructsArray<[IsUnmanaged] T>(long startAddress, long endAddress, int structSize) where T : struct, ValueType;

		// Token: 0x06000899 RID: 2201
		IList<T> ReadDoublePtrVectorClasses<T>(long address, RemoteMemoryObject game, bool noNullPointers = false) where T : RemoteMemoryObject, new();

		// Token: 0x0600089A RID: 2202
		IList<long> ReadPointersArray(long startAddress, long endAddress, int offset = 8);

		// Token: 0x0600089B RID: 2203
		IList<long> ReadSecondPointerArray_Count(long startAddress, int count);

		// Token: 0x0600089C RID: 2204
		T Read<[IsUnmanaged] T>(Pointer addr, params int[] offsets) where T : struct, ValueType;

		// Token: 0x0600089D RID: 2205
		T Read<[IsUnmanaged] T>(IntPtr addr, params int[] offsets) where T : struct, ValueType;

		// Token: 0x0600089E RID: 2206
		T Read<[IsUnmanaged] T>(long addr, params int[] offsets) where T : struct, ValueType;

		// Token: 0x0600089F RID: 2207
		T Read<[IsUnmanaged] T>(Pointer addr) where T : struct, ValueType;

		// Token: 0x060008A0 RID: 2208
		T Read<[IsUnmanaged] T>(IntPtr addr) where T : struct, ValueType;

		// Token: 0x060008A1 RID: 2209
		T Read<[IsUnmanaged] T>(long addr) where T : struct, ValueType;

		// Token: 0x060008A2 RID: 2210
		IList<T> ReadNativeArray<[IsUnmanaged] T>(INativePtrArray ptrArray, int offset = 8) where T : struct, ValueType;

		// Token: 0x060008A3 RID: 2211
		IList<T> ReadNativeArray<[IsUnmanaged] T>(long first, long last, int offset = 8) where T : struct, ValueType;

		// Token: 0x060008A4 RID: 2212
		IList<Tuple<long, int>> ReadDoublePointerIntList(long address);

		// Token: 0x060008A5 RID: 2213
		IList<T> ReadList<[IsUnmanaged] T>(IntPtr head) where T : struct, ValueType;

		// Token: 0x060008A6 RID: 2214
		IList<T> ReadStdList<[IsUnmanaged] T>(IntPtr head) where T : struct, ValueType;

		// Token: 0x060008A7 RID: 2215
		T[] ReadRMOStdVector<T>(StdVector nativeContainer, int objectSize) where T : RemoteMemoryObject, new();

		// Token: 0x060008A8 RID: 2216
		T[] ReadStdVector<[IsUnmanaged] T>(StdVector nativeContainer) where T : struct, ValueType;

		// Token: 0x060008A9 RID: 2217
		T[] ReadStdVectorStride<[IsUnmanaged] T>(StdVector nativeContainer, int stride) where T : struct, ValueType;

		// Token: 0x060008AA RID: 2218
		T ReadStdVectorElement<[IsUnmanaged] T>(StdVector nativeContainer, int index) where T : struct, ValueType;

		// Token: 0x060008AB RID: 2219
		IList<long> ReadListPointer(IntPtr head);

		// Token: 0x060008AC RID: 2220
		long[] FindPatterns(params IPattern[] patterns);

		// Token: 0x060008AD RID: 2221
		bool IsInvalid();

		// Token: 0x060008AE RID: 2222
		void NotifyFrame();

		// Token: 0x060008AF RID: 2223
		T[] ReadStdVector<[IsUnmanaged] T>(NativePtrArray nativeContainer) where T : struct, ValueType;

		// Token: 0x060008B0 RID: 2224
		T[] ReadStdVectorStride<[IsUnmanaged] T>(NativePtrArray nativeContainer, int stride) where T : struct, ValueType;

		// Token: 0x060008B1 RID: 2225
		T ReadStdVectorElement<[IsUnmanaged] T>(NativePtrArray nativeContainer, int index) where T : struct, ValueType;

		// Token: 0x060008B2 RID: 2226
		IDisposable DisableCaching();

		// Token: 0x060008B3 RID: 2227
		List<T> ReadRMOUnorderedMap<T>(UnorderedMap map) where T : RemoteMemoryObject, new();

		// Token: 0x060008B4 RID: 2228
		Dictionary<int, bool> ReadPackedFlagsVector(StdVector vector);
	}
}
