using System.Runtime.InteropServices;

namespace imgui_net_export;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public unsafe struct IUnknown
{
    public VFT* mVirtualFunctionTable; 
    public int mFieldA;
    public int mFieldB;
    
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VFT
    {
        public delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int> QueryInterface;
        public delegate* unmanaged[Stdcall]<IUnknown*, int> AddRef;
        public delegate* unmanaged[Stdcall]<IUnknown*, int> Release;
    }
}