using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace imgui_net_export;

public readonly unsafe partial struct BSTR : IDisposable
{
    public readonly char* mPointer;

    /*public string GetString()
    {
        if (mPointer == null)
        {
            return "Unknown";
        }
        return new string(MemoryMarshal.CreateReadOnlySpanFromNullTerminated(mPointer));
    }*/

    //public bool IsEmpty => mPointer == null || *mPointer != '\0';
    //public static implicit operator string(BSTR bstr) => bstr.GetString();
    
    public override string ToString()
    {
        return mPointer == null ? string.Empty : new string(MemoryMarshal.CreateReadOnlySpanFromNullTerminated(mPointer));
    }

    public void Dispose()
    {
        if(mPointer != null) SysFreeString(mPointer);
    }
    
    [LibraryImport("oleaut32.dll", SetLastError = false), UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)]), SuppressGCTransition]
    private static partial void SysFreeString(char* bstr);
}